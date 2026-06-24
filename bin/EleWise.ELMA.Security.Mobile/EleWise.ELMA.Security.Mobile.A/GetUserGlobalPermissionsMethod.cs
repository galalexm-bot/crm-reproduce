using System;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Security.Mobile.API.Services;

internal class GetUserGlobalPermissionsMethodExecutor : PublicServiceMethodExecutor
{
	private class ResultModel
	{
		public bool Result { get; set; }

		public Guid[] Permissions { get; set; }
	}

	private const string ResultParamName = "Result";

	private const string PermissionsParamName = "Permissions";

	private SecurityService securityService;

	private SecurityService SecurityService => securityService ?? (securityService = Locator.GetServiceNotNull<SecurityService>());

	public static string MethodName => "GetUserGlobalPermissions";

	public static string Description => SR.T("Получить список глобальных привилегий пользователя");

	public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().Descriptor;

	public static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor("Result", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Type(typeof(bool)).Description(SR.T("Результат"));
	}).ItemWithDescriptor("Permissions", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Type(typeof(Guid[])).Description(SR.T("Уникальные идентификаторы привилегий"));
	}).Descriptor;

	public GetUserGlobalPermissionsMethodExecutor(WebData parameters)
		: base(parameters)
	{
	}

	public override WebData Execute()
	{
		return ExecuteInternal();
	}

	private WebData ExecuteInternal()
	{
		EleWise.ELMA.Security.Models.IUser currentUser = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		Guid[] userGlobalPermissions = SecurityService.GetUserGlobalPermissions(currentUser);
		return WebData.CreateFromObject(new ResultModel
		{
			Result = true,
			Permissions = userGlobalPermissions
		});
	}
}
