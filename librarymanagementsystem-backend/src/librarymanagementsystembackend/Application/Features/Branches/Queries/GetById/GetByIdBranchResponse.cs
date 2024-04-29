using NArchitecture.Core.Application.Responses;

namespace Application.Features.Branches.Queries.GetById;

public class GetByIdBranchResponse : IResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime WorkingHours { get; set; }
    public string PhoneNumber { get; set; }
    public string? WebSiteUrl { get; set; }
    public Guid AddressId { get; set; }
    public Guid LibraryId { get; set; }
}