using Microsoft.AspNetCore.Routing;

namespace VideoGameHub.BuildingBlock.Web;

public interface IMinimalEndpoint
{
    IEndpointRouteBuilder MapEndpoint(IEndpointRouteBuilder builder);
}