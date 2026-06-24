using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Settings;

namespace EleWise.ELMA.Common.Components;

public class GlobalScoringSettings : GlobalSettingsBase
{
	[DisplayName("SR.M('Включен ли глобальный скоринг для сущностей.')")]
	public bool IsGlobalScoringEnabled { get; set; }

	public GlobalScoringSettings()
	{
		IsGlobalScoringEnabled = false;
	}
}
