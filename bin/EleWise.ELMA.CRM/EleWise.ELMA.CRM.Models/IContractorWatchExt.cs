using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("f01f1918-4279-42fd-b0fe-435442e3c37c")]
[DisplayName(typeof(__Resources_IContractorWatchExt), "DisplayName")]
[BaseClass("e40e61fc-45d4-44d8-b748-d6ccbffe79b2")]
[DisplayFormat(null)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>bdd04431-ccf8-4d78-91f6-9f10cbb58cd3</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("ContractorWatchExt")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.InterfaceExtension)]
[ActionsType(typeof(ContractorWatchExtActions))]
public interface IContractorWatchExt : IWatch, IEntity<long>, IEntity, IIdentified
{
}
