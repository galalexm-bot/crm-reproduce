using System;

namespace EleWise.ELMA.Web.Mvc.Models.Settings;

[Serializable]
public sealed class GlobalSettingsSaveResult
{
	public bool Success { get; set; }

	public string ErrorMessage { get; set; }
}
