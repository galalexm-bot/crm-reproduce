using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Remoting;

public enum ProxyType
{
	[DisplayName(typeof(__Resources_ProxyType), "P_NotUse_DisplayName")]
	NotUse,
	[DisplayName(typeof(__Resources_ProxyType), "P_UseDefault_DisplayName")]
	UseDefault,
	[DisplayName(typeof(__Resources_ProxyType), "P_Custom_DisplayName")]
	Custom
}
