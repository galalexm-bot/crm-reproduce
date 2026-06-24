using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Workflow.Models;

[Uid("c4dc0ccc-c1a3-45d6-b794-e23152342c3d")]
[DisplayName(typeof(__Resources_IWorkflowTask), "DisplayName")]
[ClassFormsScheme(ClassFormsScheme.FormConstructor)]
[MetadataType(typeof(EntityMetadata))]
[DisplayFormat("{$Name}")]
[Image(typeof(IWorkflowTask), "process", 16, ImageFormatType.IconPack, false)]
[AllowCreateHeirs(true)]
[Description(typeof(__Resources_IWorkflowTask), "Description")]
[BaseClass("0f338330-068c-4135-be4e-95797a209c4e")]
[ActionsType(typeof(WorkflowTaskActions))]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[FormView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<FormView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>00000000-0000-0000-0000-000000000000</Uid>\r\n  <ViewType>Display</ViewType>\r\n  <CanUseCommonView>true</CanUseCommonView>\r\n  <CanUseCommonRazorView>true</CanUseCommonRazorView>\r\n  <CanUseTabView>true</CanUseTabView>\r\n  <CanUseTabRazorView>true</CanUseTabRazorView>\r\n  <ViewInCommon>true</ViewInCommon>\r\n</FormView>")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>4461d1f7-695f-44e7-9331-05055a908bb3</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("WorkflowTask")]
[EntityMetadataType(EntityMetadataType.Interface)]
[ImplementationUid("555a587d-25c1-4f99-ade6-3176b4fc9a6c")]
[FilterType(typeof(IWorkflowTaskFilter))]
[Filterable]
[FormTransformation(typeof(IWorkflowTask), "EleWise.ELMA.Workflow.Models.WorkflowTask.Form.Edit.xml")]
[SaveHistory]
public interface IWorkflowTask : ITaskBase, IEntity<long>, IEntity, IIdentified, IInheritable
{
}
