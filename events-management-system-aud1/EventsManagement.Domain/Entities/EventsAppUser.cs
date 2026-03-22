using Microsoft.AspNetCore.Identity;

namespace EventsManagement.Domain.Entities;

public class EventsAppUser : IdentityUser
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
}