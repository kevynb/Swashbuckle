﻿using System.Collections.Generic;
using System.Web.Http.Description;

namespace Swashbuckle.Core.Swagger
{
    public interface IOperationFilter
    {
        void Apply(Operation operation, Dictionary<string, DataType> complexModels, DataTypeGenerator dataTypeGenerator, ApiDescription apiDescription);
    }
}