using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.IntegrationModules.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("55c0dcbe-5af6-4d4f-9480-e9078afc9976")]
[DisplayName("SR.M('Тип модуля интеграции')")]
public enum IntegrationModuleType
{
	[Uid("74f749cb-6fb8-403d-939d-8359795a5ced")]
	[DisplayName("SR.M('Rest API')")]
	RestAPI,
	[Uid("84E3FE89-6A80-4D9F-9189-AFC069CB4AA5")]
	[DisplayName("SR.M('Без указания типа интеграции')")]
	Empty,
	[Uid("F7E33374-7259-4561-8992-1A67429832DD")]
	[DisplayName("SR.M('SOAP API')")]
	SOAPAPI
}
