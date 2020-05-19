using AutoWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSkeleton.Core.Helpers
{
    public class AutoWrapperProfile
    {
        [AutoWrapperPropertyMap(Prop.Result)]
        public object Data { get; set; }

        [AutoWrapperPropertyMap(Prop.ResponseException)]
        public object ErrorData { get; set; }

        [AutoWrapperPropertyMap(Prop.ResponseException_ExceptionMessage)]
        public object Message { get; set; }
    }
}
