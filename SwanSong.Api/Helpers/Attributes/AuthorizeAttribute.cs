using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SwanSong.Domain;
using SwanSong.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using static SwanSong.Domain.Helper.Enums;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AuthorizeAttribute(params SwanSong.Domain.Helper.Enums.Role[] roles) : Attribute, IAuthorizationFilter
{
    private readonly IList<Role> _roles = roles ?? Array.Empty<Role>();

    public void OnAuthorization(AuthorizationFilterContext context)
    {
        if (context.HttpContext.GetEndpoint().Metadata.GetMetadata<Microsoft.AspNetCore.Authorization.AllowAnonymousAttribute>() is not object)
        {
            var account = (Account)context.HttpContext.Items[ConstantMessages.Account];
            if (account == null || (_roles.Any() && !_roles.Contains(account.Role)))
            {
                // not logged in or role not authorized
                context.Result = new JsonResult(new { message = ConstantMessages.Unauthorized }) { StatusCode = StatusCodes.Status401Unauthorized };
            }
        }
    }
}