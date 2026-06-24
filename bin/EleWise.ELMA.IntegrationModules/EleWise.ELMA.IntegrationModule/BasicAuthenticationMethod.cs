using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.IntegrationModules.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("4c7f7106-1d2d-4839-a9c0-bd766e71b412")]
[DisplayName("SR.M('Метод аутентификации')")]
public enum BasicAuthenticationMethod
{
	[Uid("a7343055-3eeb-4331-8865-f1074ce04a9d")]
	[DisplayName("SR.M('GET')")]
	GET,
	[Uid("9628b33c-f38e-408f-a589-263f6b718bed")]
	[DisplayName("SR.M('POST')")]
	POST
}
