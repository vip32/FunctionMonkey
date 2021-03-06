﻿using System;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Http;

namespace FunctionMonkey.Model
{
    public class HttpParameter
    {
        public string Name { get; set; }

        public string TypeName { get; set; }

        public bool IsString => TypeName.Equals("System.String");

        public Type Type { get; set; }

        public bool IsFormCollection => Type == typeof(IFormCollection);

        public bool IsEnum => Type.IsEnum;

      public bool IsNullable => Type.IsGenericType && Type.GetGenericTypeDefinition() == typeof(Nullable<>);

	    public string NullableType => Type.GetGenericArguments().First().FullName;

	    public bool IsNullableTypeHasTryParseMethod => IsNullable && Type.GetGenericArguments().First()
		                                                   .GetMethods(BindingFlags.Public | BindingFlags.Static)
		                                                   .Any(x => x.Name == "TryParse");

        public bool IsOptional { get; set; }

        // The below applies to route parameters
        public string RouteName { get; set; }
        public string RouteTypeName { get; set; }
        public bool IsNullableType { get; set; }
        public bool IsGuid => Type == typeof(Guid) || Type == typeof(Guid?);
    }
}
