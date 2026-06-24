using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Security.Mobile.API.Services;

[Component]
public class PermissionPublicServiceMethodsProvider : IPublicServiceMethodsProvider
{
	public IEnumerable<IPublicServiceMethod> GetMethods()
	{
		return new PublicServiceMethod[3]
		{
			new PublicServiceMethod(PermissionPublicService.UID, "CheckPermissionsToEntity", CheckPermissionsToEntityMethodExecutor.Description, new Version(1, 0, 0), (WebData data) => new CheckPermissionsToEntityMethodExecutor(data))
			{
				ParametersDescriptor = CheckPermissionsToEntityMethodExecutor.ParametersDescriptor,
				ResultDescriptor = CheckPermissionsToEntityMethodExecutor.ResultDescriptor
			},
			new PublicServiceMethod(PermissionPublicService.UID, "AddPermissionsToEntity", AddPermissionsToEntityMethodExecutor.Description, new Version(1, 0, 0), (WebData data) => new AddPermissionsToEntityMethodExecutor(data))
			{
				ParametersDescriptor = AddPermissionsToEntityMethodExecutor.ParametersDescriptor,
				ResultDescriptor = AddPermissionsToEntityMethodExecutor.ResultDescriptor
			},
			new PublicServiceMethod(PermissionPublicService.UID, GetUserGlobalPermissionsMethodExecutor.MethodName, GetUserGlobalPermissionsMethodExecutor.Description, new Version(1, 0, 0), (WebData data) => new GetUserGlobalPermissionsMethodExecutor(data))
			{
				ParametersDescriptor = GetUserGlobalPermissionsMethodExecutor.ParametersDescriptor,
				ResultDescriptor = GetUserGlobalPermissionsMethodExecutor.ResultDescriptor
			}
		};
	}
}
