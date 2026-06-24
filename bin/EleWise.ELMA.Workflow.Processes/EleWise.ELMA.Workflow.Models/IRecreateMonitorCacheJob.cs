using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Scheduling.Models;

namespace EleWise.ELMA.Workflow.Models;

[Entity("RecreateMonitorCacheJob")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>b0c60945-26a1-4373-b628-93292a199801</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[DisplayFormat(null)]
[BaseClass("215dd155-ef88-4b92-ab32-6c370e50340c")]
[MetadataType(typeof(EntityMetadata))]
[ImplementationUid("150f9066-ad6c-4c02-8128-c6e9cd0f6c09")]
[DisplayName(typeof(__Resources_IRecreateMonitorCacheJob), "DisplayName")]
[Uid("b9703266-2d15-4d15-a435-596e1d0c73cf")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
public interface IRecreateMonitorCacheJob : ISchedulerTaskJob, IEntity<long>, IEntity, IIdentified, IInheritable
{
}
