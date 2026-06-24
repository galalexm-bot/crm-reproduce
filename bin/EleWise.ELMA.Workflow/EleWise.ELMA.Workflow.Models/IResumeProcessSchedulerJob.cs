using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scheduling.Models;

namespace EleWise.ELMA.Workflow.Models;

[ShowInCatalogList(false)]
[DisplayName(typeof(__Resources_IResumeProcessSchedulerJob), "DisplayName")]
[EntityMetadataType(EntityMetadataType.Interface)]
[DisplayFormat(null)]
[ImplementationUid("9cf4e83d-790c-4b45-a1e4-5fce2d606d7c")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[BaseClass("215dd155-ef88-4b92-ab32-6c370e50340c")]
[MetadataType(typeof(EntityMetadata))]
[Uid("204bd542-92bf-4528-b628-025dabcbc776")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>127ba87c-d887-4f27-b29e-034d71327946</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("ResumeProcessSchedulerJob")]
public interface IResumeProcessSchedulerJob : ISchedulerTaskJob, IEntity<long>, IEntity, IIdentified, IInheritable
{
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[DisplayName(typeof(__Resources_IResumeProcessSchedulerJob), "P_WorkflowBookmark_DisplayName")]
	[EntityProperty]
	[Uid("a2e557ae-ee22-47d7-866c-c542ec09a329")]
	[EntitySettings(FieldName = "WorkflowBookmark")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "1c56d793-9753-4a56-bc01-790cb0417251")]
	IWorkflowBookmark WorkflowBookmark { get; set; }
}
