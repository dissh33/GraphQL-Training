using DataAccess.Interfaces;
using Database.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.API.Mutations
{
    public class PropertyMutation : ObjectGraphType
    {
        public PropertyMutation(IPropertyRepository propertyRepository)
        {
            Name = "AddPropertyMutation";

            Field<PropertyType>(
                "addProperty",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<PropertyInputType>> { Name = "property" }),
                resolve: context =>
                {
                    var property = context.GetArgument<Property>("property");
                    return propertyRepository.Add(property);
                });
        }
    }
}
