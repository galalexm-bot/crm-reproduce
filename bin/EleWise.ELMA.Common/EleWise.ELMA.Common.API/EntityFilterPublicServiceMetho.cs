using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Common.API;

[Component]
internal sealed class EntityFilterPublicServiceMethodsProvider : IPublicServiceMethodsProvider
{
	public IEnumerable<IPublicServiceMethod> GetMethods()
	{
		return new IPublicServiceMethod[1]
		{
			new PublicServiceMethod(EntityFilterPublicService.UID, "FindByFilter", FindByFilterExecutor.MethodDescription, new Version(1, 0, 0), (WebData data) => new FindByFilterExecutor(data))
			{
				ParametersDescriptor = FindByFilterExecutor.ParametersDescriptor,
				ResultDescriptor = FindByFilterExecutor.ResultDescriptor
			}
		};
	}
}
