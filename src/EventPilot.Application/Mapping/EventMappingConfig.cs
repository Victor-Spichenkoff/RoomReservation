using EventPilot.Application.DTOs.Event;
using EventPilot.Domain.Entities;
using Mapster;

namespace EventPilot.Application;

public class EventMappingConfig: IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        // use active reset here (clear )
        config.NewConfig<UpdateEventDto, Event>()
            .IgnoreNullValues(true);

        config.NewConfig<PatchEventDto, Event>()
            .IgnoreNullValues(true);
    }
}