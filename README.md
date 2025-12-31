#   RoomReservation


# TODO
- [X] How to expose Ex information only DEV + log production
- [ ] Use validation + error handler with fields
- [ ] Test Error handler




# IMPORTANT PATTERS DESIGN
## UPDATE/PATCH
- For easy map integration, every null will be discarded and not persisted
- Some fields may be changed to ````null````
- Client must send, in the request, props like ````{ clearCapacity: true }````