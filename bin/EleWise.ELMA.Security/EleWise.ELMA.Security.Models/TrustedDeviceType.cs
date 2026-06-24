using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Security.Models;

[Uid("fbcf2a36-81c7-44ce-bb0f-37015940c32f")]
[DisplayName(typeof(__Resources_TrustedDeviceType), "DisplayName")]
[DefaultValueUid("932a727d-3933-487e-b607-fed6b05282bb")]
[MetadataType(typeof(EnumMetadata))]
public enum TrustedDeviceType
{
	[DisplayName(typeof(__Resources_TrustedDeviceType), "P_TrustedDevice_DisplayName")]
	[Uid("932a727d-3933-487e-b607-fed6b05282bb")]
	TrustedDevice,
	[Uid("2d2b18b8-30cd-422d-ab44-80366872f00a")]
	[DisplayName(typeof(__Resources_TrustedDeviceType), "P_Token_DisplayName")]
	Token,
	[DisplayName(typeof(__Resources_TrustedDeviceType), "P_Certificate_DisplayName")]
	[Uid("5ab0301a-bdd6-444e-9f3b-90de846e76fe")]
	Certificate
}
