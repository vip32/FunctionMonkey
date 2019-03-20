﻿using AzureFromTheTrenches.Commanding.Abstractions;
using FunctionMonkey.Tests.Integration.Functions.Commands.Model;

namespace FunctionMonkey.Tests.Integration.Functions.Commands
{
    public class HttpCommandWithResultAndValidatorThatFails : ICommand<SimpleResponse>
    {
        public int Value { get; set; }
    }
}