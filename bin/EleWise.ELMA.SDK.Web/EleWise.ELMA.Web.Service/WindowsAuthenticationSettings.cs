using System;
using System.ComponentModel;

namespace EleWise.ELMA.Web.Service;

[EditorBrowsable(EditorBrowsableState.Never)]
public static class WindowsAuthenticationSettings
{
	private static class Parameters
	{
		public const string CookieName = "SSPI.CookieName";

		public const string TicketLifetime = "SSPI.TicketLifetime";

		public const string SecurityKey = "SSPI.SecurityKey";

		public const string SecurityVector = "SSPI.SecurityVector";

		public const string InstanceUid = "SSPI.InstanceUid";

		public const string UseInPlaceWinAuth = "SSPI.UseInPlaceWinAuth";

		public const string EnableSSO = "SSPI.EnableSSO";
	}

	public static class Headers
	{
		public const string BypassIWA = "Elma-BypassIWA";
	}

	public static bool IsInPlaceWinAuthEnabled()
	{
		return SR.GetSetting("SSPI.UseInPlaceWinAuth", defaultValue: false);
	}

	public static string GetCookieName()
	{
		return SR.GetSetting("SSPI.CookieName", "Elma.V3.SSPI");
	}

	public static int GetTicketLifetime()
	{
		return SR.GetSetting("SSPI.TicketLifetime", 60);
	}

	public static Guid GetInstanceUid()
	{
		if (!Guid.TryParse(SR.GetSetting("SSPI.InstanceUid"), out var result))
		{
			result = new Guid("7EFF5F19-58D1-4904-8699-0A059BAB5F08");
		}
		return result;
	}

	public static string GetSecurityKey()
	{
		string setting = SR.GetSetting("SSPI.SecurityKey");
		if (string.IsNullOrEmpty(setting))
		{
			throw new Exception(SR.T("Не задан ключ \"{0}\"", "SSPI.SecurityKey"));
		}
		return setting;
	}

	public static string GetSecurityVector()
	{
		string setting = SR.GetSetting("SSPI.SecurityVector");
		if (string.IsNullOrEmpty(setting))
		{
			throw new Exception(SR.T("Не задан ключ \"{0}\"", "SSPI.SecurityVector"));
		}
		return setting;
	}

	public static bool IsSSOEnabled()
	{
		return SR.GetSetting("SSPI.EnableSSO", defaultValue: false);
	}
}
