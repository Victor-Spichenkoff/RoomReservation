using EventPilot.Application.DTOs.Event;
using EventPilot.Application.DTOs.Responses;
using EventPilot.Application.Interfaces.Repositories;
using EventPilot.Application.Services;
using EventPilot.Domain.Entities;
using EventPilot.Domain.Exceptions;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace EventPilot.Controllers;

[ApiController]
[Route("[controller]")]
public class EventsController(EventService eventService) : ControllerBase
{
    private readonly EventService _eventService = eventService;

    [HttpGet]
    public async Task<ActionResult<ICollection<EventResponseDto>>> Get([FromQuery] int page = 0)
        => Ok(await _eventService.GetPaged(page));

    [HttpGet("{id}")]
    public async Task<ActionResult<EventResponseDto>> GetEventById(long id)
    => Ok(await _eventService.GetEventAsync(id));
    

    
    [ProducesResponseType(typeof(EventResponseDto), 200)]
    [HttpPost]
    public async Task<ActionResult<EventResponseDto>> CreateEvent([FromBody] EventDto eventDto)
    {
        return Ok(await _eventService.CreateEventAsync(eventDto));
    }
    
    
    [ProducesResponseType(typeof(EventResponseDto), 200)]
    [HttpPut("{id}")]
    public async Task<ActionResult<EventResponseDto>> UpdateEvent([FromBody] UpdateEventDto eventDto, long id)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
            // throw new BusinessException(ModelState.)
            
        return Ok(await _eventService.UpdateEventAsync(eventDto, id));
    }
    
    [ProducesResponseType(typeof(EventResponseDto), 200)]
    [HttpPatch("{id}")]
    public async Task<ActionResult<EventResponseDto>> PatchEvent([FromBody] PatchEventDto eventDto, long id)
    {
        return Ok(await _eventService.PatchEventAsync(eventDto, id));
    }


    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteEvent(long id)
    {
        await _eventService.DeleteEventAsync(id);
        return NoContent();
    }
    
}