using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Workflow.Models;

[DisplayName("SR.M('Группа доступа к процессу')")]
[BaseClass("72c9994a-cd4e-4746-ac50-5f454b450231")]
[DisplayFormat(null)]
[ShowInCatalogList(false)]
[MetadataType(typeof(EntityMetadata))]
[Uid("084ca4c6-d8fa-4a85-82b0-d615b5bed614")]
[ActionsType(typeof(ProcessAccessGroupActions))]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("2d102c1a-7ffd-4371-94e7-87856ae350eb")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>7d969858-774f-421b-aa31-89ce8b6ed3c3</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("ProcessAccessGroup")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
public interface IProcessAccessGroup : IUserGroup, IEntity<long>, IEntity, IIdentified, IInheritable
{
}
