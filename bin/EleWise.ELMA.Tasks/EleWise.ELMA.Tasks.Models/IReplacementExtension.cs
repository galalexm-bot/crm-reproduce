using EleWise.ELMA.ComponentModel;
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
[Uid("45c56b42-7736-4887-82ab-4c52cb417988")]
[DisplayName(typeof(__Resources_IReplacementExtension), "DisplayName")]
[BaseClass("c4fbe20f-1114-4198-a307-31b65cc84635")]
[DisplayFormat(null)]
[CustomCode(typeof(IReplacementExtension), "EleWise.ELMA.Tasks.Models.ReplacementExtension.CustomCodeTemplate.cs")]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>08b7bab6-632f-4823-9271-22746597794e</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("ReplacementExtension")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.InterfaceExtension)]
public interface IReplacementExtension : IReplacementExtension2, ITaskControlReplacement, IReplacement, IEntity<long>, IEntity, IIdentified, ISoftDeletable
{
	[Uid("e3535432-b9f9-4c34-8f13-d58fe23fd9c6")]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "ReAssignActiveTasks")]
	[DisplayName(typeof(__Resources_IReplacementExtension), "P_ReAssignActiveTasks_DisplayName")]
	[Description(typeof(__Resources_IReplacementExtension), "P_ReAssignActiveTasks_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	bool ReAssignActiveTasks { get; set; }

	[Uid("3d71ff15-4b95-4167-adbd-71d45238e4b3")]
	[Order(1)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "TasksDistributer")]
	[DisplayName(typeof(__Resources_IReplacementExtension), "P_TasksDistributer_DisplayName")]
	[Description(typeof(__Resources_IReplacementExtension), "P_TasksDistributer_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	IUser TasksDistributer { get; set; }

	[Uid("38961eb8-d6d9-41f5-b326-d16e053ef934")]
	[Order(2)]
	[NotNull]
	[Required(true)]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(MinValue = 1L, DefaultValueStr = "1", FieldName = "ReAssignStartDays")]
	[RequiredField]
	[RangeValue(1L, long.MaxValue)]
	[DisplayName(typeof(__Resources_IReplacementExtension), "P_ReAssignStartDays_DisplayName")]
	[Description(typeof(__Resources_IReplacementExtension), "P_ReAssignStartDays_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	long ReAssignStartDays { get; set; }

	[Uid("7ff282e6-e89e-4940-a14b-18a333d472da")]
	[Order(3)]
	[NotNull]
	[Required(true)]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(MinValue = 1L, DefaultValueStr = "1", FieldName = "ReAssignFinishDays")]
	[RequiredField]
	[RangeValue(1L, long.MaxValue)]
	[DisplayName(typeof(__Resources_IReplacementExtension), "P_ReAssignFinishDays_DisplayName")]
	[Description(typeof(__Resources_IReplacementExtension), "P_ReAssignFinishDays_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	long ReAssignFinishDays { get; set; }
}
