﻿using FluentValidation;
using FunctionMonkey.Tests.Integration.Functions.Commands;
using FunctionMonkey.Tests.Integration.Functions.Commands.HttpResponseShaping;

namespace FunctionMonkey.Tests.Integration.Functions.Validators
{
    public class HttpCommandWithResultAndValidatorThatFailsValidator : AbstractValidator<HttpCommandWithResultAndValidatorThatFails>
    {
        public HttpCommandWithResultAndValidatorThatFailsValidator()
        {
            RuleFor(m => m.Value).NotEqual(0);
        }
    }
}
