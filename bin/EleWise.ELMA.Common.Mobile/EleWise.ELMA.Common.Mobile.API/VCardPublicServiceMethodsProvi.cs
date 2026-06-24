using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Common.Mobile.API;

[Component]
internal class VCardPublicServiceMethodsProvider : IPublicServiceMethodsProvider
{
	public IEnumerable<IPublicServiceMethod> GetMethods()
	{
		return new PublicServiceMethod[1]
		{
			new PublicServiceMethod(VCardPublicService.UID, "GetVCardForUser", GetVCardForUserExecutor.MethodDescription, new Version(1, 0, 0), (WebData data) => new GetVCardForUserExecutor(data))
			{
				ParametersDescriptor = GetVCardForUserExecutor.ParametersDescriptor,
				ResultDescriptor = GetVCardForUserExecutor.ResultDescriptor
			}
		};
	}
}
