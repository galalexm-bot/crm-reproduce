using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;

namespace EleWise.ELMA.Tasks.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("97df6b13-44cc-41d0-b1e6-76de556fd746")]
[DisplayName(typeof(__Resources_IComplexTask), "DisplayName")]
[BaseClass("0f338330-068c-4135-be4e-95797a209c4e")]
[AllowCreateHeirs(true)]
[DisplayFormat("{$ComplexTask}")]
[Image(typeof(IComplexTask), "task_complex", 16, ImageFormatType.IconPack, false)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>19a01aab-6904-4eb9-92f5-3e36479f19b2</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("ComplexTask")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[Filterable]
[ImplementationUid("3f33e28e-908d-4e93-8f40-b05ae88038ed")]
[FilterType(typeof(IComplexTaskFilter))]
[ActionsType(typeof(ComplexTaskActions))]
public interface IComplexTask : ITaskBase, IEntity<long>, IEntity, IIdentified, IInheritable
{
	[Uid("04b66e20-6641-466d-8edc-95b97d7ab7ee")]
	[Required(true)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ControlUser")]
	[RequiredField]
	[DisplayName(typeof(__Resources_IComplexTask), "P_ControlUser_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	IUser ControlUser { get; set; }
}
