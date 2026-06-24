using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Scheduling.Models;

namespace EleWise.ELMA.Workflow.Models;

[EntityMetadataType(EntityMetadataType.Interface)]
[ShowInCatalogList(false)]
[ImplementationUid("008b0779-62a0-4ed8-819c-8b70702c37ef")]
[DisplayName(typeof(__Resources_IOptimizeMonitorCacheJob), "DisplayName")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[MetadataType(typeof(EntityMetadata))]
[Uid("eb23866e-f1ff-4e13-b4bb-96e0a33df0d5")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>73164b15-2523-4544-9424-6eb732cd2cca</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("OptimizeMonitorCacheJob")]
[BaseClass("215dd155-ef88-4b92-ab32-6c370e50340c")]
[DisplayFormat(null)]
public interface IOptimizeMonitorCacheJob : ISchedulerTaskJob, IEntity<long>, IEntity, IIdentified, IInheritable
{
}
