using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.IntegrationModules.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("10c0a279-adfb-4757-9353-4b754fc493ed")]
[DisplayName("SR.M('Статус выполнения активити интеграции')")]
public enum IntegrationModuleActivityStatus
{
	[Uid("fefe09a7-4f20-4a8f-89ab-48ff994c40dd")]
	[DisplayName("SR.M('Ошибка выполнения интеграции')")]
	Error,
	[Uid("e6d038ef-20dd-4f0e-a001-42e1efd0759b")]
	[DisplayName("SR.M('Ожидание внешнего события')")]
	Expectation,
	[Uid("8a971342-2cf8-401b-bb02-cc0e27f8832e")]
	[DisplayName("SR.M('Выполнено')")]
	Complete,
	[Uid("3289bc10-0ab1-49dc-8d4b-c054b8df770c")]
	[DisplayName("SR.M('Отменено')")]
	Terminated
}
