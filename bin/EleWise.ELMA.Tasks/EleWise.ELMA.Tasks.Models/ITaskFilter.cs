using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Tasks.Models;

[FilterFor(typeof(ITask))]
[InterfaceImplementation("EleWise.ELMA.Tasks.Models.ITaskControlFilter, EleWise.ELMA.Tasks")]
public interface ITaskFilter : ITaskControlFilter, ITaskBaseFilter, IEntityFilter
{
	new IUser ControlUser { get; set; }

	new TaskControlType? ControlType { get; set; }

	CalendarEventPeriod? Period { get; set; }

	ITask PeriodTemplate { get; set; }

	bool? IsTemplate { get; set; }

	[CustomFilterProperty]
	[Uid("849692bf-68b5-4bdf-bf58-68b92a198ece")]
	[Order(1)]
	[CanBeNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "Periodical")]
	[DisplayName(typeof(__Resources_ITask), "FP_Periodical_DisplayName")]
	bool? Periodical { get; set; }

	[CustomFilterProperty]
	[Uid("9c43b4f2-486c-4b86-a40e-1dda1ac100a5")]
	[Order(2)]
	[CanBeNull]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "10d92b32-84c9-4278-8d2b-5e8eb7625543")]
	[EnumSettings(DefaultValueStr = "40fdf331-4b37-4691-8ca5-ad1d1ea272cf", FieldName = "ControlStatus")]
	[DisplayName(typeof(__Resources_ITask), "FP_ControlStatus_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	new TaskControlStatus? ControlStatus { get; set; }

	[CustomFilterProperty]
	[Uid("e3a9165f-f9de-4dc3-bb4f-9bb5a25b7852")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(RelationType = RelationType.ManyToMany, ParentColumnName = "Parent", ChildColumnName = "Child", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_ITask), "FP_CurrentControllers_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	new ISet<IUser> CurrentControllers { get; set; }

	[CustomFilterProperty]
	[Uid("91575da2-82d2-4812-8f81-c56ac9eb70af")]
	[Order(3)]
	[CanBeNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "UnderControl")]
	[DisplayName(typeof(__Resources_ITask), "FP_UnderControl_DisplayName")]
	[Description(typeof(__Resources_ITask), "FP_UnderControl_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	new bool? UnderControl { get; set; }
}
