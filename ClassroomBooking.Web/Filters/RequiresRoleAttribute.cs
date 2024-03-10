using System.Security.Claims;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ClassroomBooking.Web.Filters;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public sealed class RequiresRoleAttribute: Attribute, IAsyncAuthorizationFilter
{
    private readonly UserRole _requiresRole;
    
    public RequiresRoleAttribute(UserRole requiresRole)
    {
        _requiresRole = requiresRole;
    }

    public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
    {
        var value = context.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        var userRepository = context.HttpContext.RequestServices.GetService<IUserRepository>();
        
        if (value == null || userRepository == null)
        {
            return;
        }
        
        var userId = Guid.Parse(value);
        var user = await userRepository.GetByIdAsync(userId);
        
        if (user != null && (user.UserRole == null || user.UserRole < _requiresRole))
        {
            context.Result = new ForbidResult();
        }
    }
}