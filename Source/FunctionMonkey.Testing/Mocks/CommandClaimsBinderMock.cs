﻿using System.Security.Claims;
using System.Threading.Tasks;
using AzureFromTheTrenches.Commanding.Abstractions;
using FunctionMonkey.Abstractions;

namespace FunctionMonkey.Testing.Mocks
{
    public class CommandClaimsBinderMock : ICommandClaimsBinder
    {
        public bool Bind(ClaimsPrincipal principal, ICommand command)
        {
            return false;
        }

        public Task<bool> BindAsync(ClaimsPrincipal principal, ICommand command)
        {
            return null;
        }
    }
}
