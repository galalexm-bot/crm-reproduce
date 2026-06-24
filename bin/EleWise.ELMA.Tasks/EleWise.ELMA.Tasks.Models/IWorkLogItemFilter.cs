using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Tasks.Models;

[FilterFor(typeof(IWorkLogItem))]
public interface IWorkLogItemFilter : IEntityFilter
{
	DateTimeRange Date { get; set; }

	WorkLogItemStatus? Status { get; set; }

	IWorkLogActivity WorkLogActivity { get; set; }

	DateTimeRange CreationDate { get; set; }

	Guid? ObjectUID { get; set; }

	Int64Range ObjectId { get; set; }

	IUser Harmonizator { get; set; }

	DateTimeRange ChangeDate { get; set; }

	IUser ChangeAuthor { get; set; }

	[CustomFilterProperty]
	[Uid("e5ba9dd3-2ac5-4d25-98da-b8621075cfe3")]
	[Property("c77cd813-1dfb-4777-ab7e-87b54bd09e38")]
	[AnyTypeSettings(FullTypeName = "System.Collections.Generic.List<EleWise.ELMA.Tasks.Models.WorkLogItemStatus>")]
	[DisplayName(typeof(__Resources_IWorkLogItem), "FP_Statuses_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	List<WorkLogItemStatus> Statuses { get; set; }

	[CustomFilterProperty]
	[Uid("98954257-2628-4819-9dc6-b7353506505d")]
	[Order(1)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(RelationType = RelationType.ManyToMany, ParentColumnName = "Parent", ChildColumnName = "Child")]
	[DisplayName(typeof(__Resources_IWorkLogItem), "FP_CreationAuthors_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	ISet<IUser> CreationAuthors { get; set; }

	[CustomFilterProperty]
	[Uid("24dfceab-e9fb-4043-beaf-108ba363fb3a")]
	[Order(2)]
	[CanBeNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "ShowDraft")]
	[DisplayName(typeof(__Resources_IWorkLogItem), "FP_ShowDraft_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	bool? ShowDraft { get; set; }

	[CustomFilterProperty]
	[Uid("892d9fbd-2639-4259-b5b0-30fb3ab6ce40")]
	[Order(3)]
	[Property("5c281e64-ddc8-4bc9-991a-84d9dc4e7649")]
	[ListOfSimpleTypeSettings(SimpleTypeUidStr = "eb6e8ddc-fafe-4e0e-9018-1a7667012579", FieldName = "ObjectUids")]
	[DisplayName(typeof(__Resources_IWorkLogItem), "FP_ObjectUids_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	List<Guid> ObjectUids { get; set; }

	[CustomFilterProperty]
	[Uid("ebd46b5c-4fd1-4f3e-a4bf-35465797da80")]
	[Order(4)]
	[Property("5c281e64-ddc8-4bc9-991a-84d9dc4e7649")]
	[ListOfSimpleTypeSettings(SimpleTypeUidStr = "d90a59af-7e47-48c5-8c4c-dad04834e6e3", FieldName = "ExcludeIds")]
	[DisplayName(typeof(__Resources_IWorkLogItem), "FP_ExcludeIds_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	List<long> ExcludeIds { get; set; }

	[CustomFilterProperty]
	[Uid("93f2c6b1-92ab-4723-bb23-a2ca6216ec36")]
	[Order(5)]
	[Property("5c281e64-ddc8-4bc9-991a-84d9dc4e7649")]
	[ListOfSimpleTypeSettings(SimpleTypeUidStr = "d90a59af-7e47-48c5-8c4c-dad04834e6e3", FieldName = "Ids")]
	[DisplayName(typeof(__Resources_IWorkLogItem), "FP_Ids_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	List<long> Ids { get; set; }

	[CustomFilterProperty]
	[Uid("fe2a8585-272b-420b-89ea-d7654bbd2374")]
	[Order(6)]
	[Property("5c281e64-ddc8-4bc9-991a-84d9dc4e7649")]
	[ListOfSimpleTypeSettings(SimpleTypeUidStr = "eb6e8ddc-fafe-4e0e-9018-1a7667012579", FieldName = "Uids")]
	[DisplayName(typeof(__Resources_IWorkLogItem), "FP_Uids_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	List<Guid> Uids { get; set; }

	[CustomFilterProperty]
	[Uid("7aae2e5a-e72b-4a25-b17d-ae846f1b3906")]
	[Order(7)]
	[CanBeNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "EmptyObjectUid")]
	[DisplayName(typeof(__Resources_IWorkLogItem), "FP_EmptyObjectUid_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	bool? EmptyObjectUid { get; set; }

	[CustomFilterProperty]
	[Uid("7c6a8c4e-f38f-4048-964f-91aa1c085f64")]
	[Order(8)]
	[Property("5c281e64-ddc8-4bc9-991a-84d9dc4e7649")]
	[ListOfSimpleTypeSettings(SimpleTypeUidStr = "d90a59af-7e47-48c5-8c4c-dad04834e6e3", FieldName = "ObjectIds")]
	[DisplayName(typeof(__Resources_IWorkLogItem), "FP_ObjectIds_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	List<long> ObjectIds { get; set; }
}
