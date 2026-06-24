using System;

namespace EleWise.ELMA.IntegrationModules.Constants;

public static class IntegrationsConstants
{
	public static string IntegrationParamName = "integrationModule";

	public static string ActivityParamName = "activity";

	public static string DataParamName = "data";

	public static string AuthenticationParamName = "authenticationObject";

	public static string AuthenticationResponseParamName = "authenticationResponseObject";

	public static string ExternalObjectParamName = "externalObject";

	public static Guid DeletedModulesGroupUid = new Guid("{B32412A3-6B08-4731-9BEF-FA2AEF4E55A7}");

	public static Guid DisabledIntegrationModuleAuthenticationUid = new Guid("{B32412A3-6B08-4731-9BEF-FA2AEF4E55A7}");

	public static int DefaultAuthenticationAttemptCount = 3;

	public static int DefaultAuthenticationAttemptInterval = 30;

	public static readonly Guid ExportExtensionUid = new Guid("3D0F4505-5519-4177-8E59-52EED80A058A");

	internal static readonly Guid PasswordPropertyUid = new Guid("C690A3AD-BEBD-4989-8053-52CD7DA3E250");

	internal const string PasswordPropertyName = "Password";

	internal static readonly Guid LoginPropertyUid = new Guid("6DB85E57-B6B2-467C-90EC-2CD6A4A44344");

	internal const string LoginPropertyName = "UserName";
}
