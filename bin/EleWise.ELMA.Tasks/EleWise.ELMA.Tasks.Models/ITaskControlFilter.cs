using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Tasks.Models;

[Uid("35b25a3a-8fad-4508-b691-e1f5de83060b")]
public interface ITaskControlFilter : ITaskBaseFilter, IEntityFilter
{
	[Uid("6ced6d03-224d-47a0-a4df-3c4d7bfb591c")]
	[Order(0)]
	[DisplayName("SR.M('Контролер')")]
	[Description("SR.M('Пользователь осуществляющий контроль исполнения задачи, если задача находится \"На контроле\"')")]
	[CustomFilterProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	IUser ControlUser { get; set; }

	[Uid("2596fa54-71ab-4a32-a036-a6754065b20f")]
	[Order(1)]
	[CanBeNull]
	[DisplayName("SR.M('Тип контроля')")]
	[Description("SR.M('Правило осуществления контроля исполнения задачи')")]
	[CustomFilterProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	TaskControlType? ControlType { get; set; }

	[Uid("f4d6effa-f6e1-4e3f-b13f-7e394e79b09b")]
	[Order(2)]
	[EntityUserSettings(RelationType = RelationType.ManyToMany, ParentColumnName = "Parent", ChildColumnName = "Child", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName("SR.M('На текущем контроле')")]
	[Description("SR.M('Пользователи у которых задача находится на текущем контроле')")]
	[CustomFilterProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	ISet<IUser> CurrentControllers { get; set; }

	[Uid("baf8942f-ad4d-4c93-abce-838f24c6e671")]
	[Order(3)]
	[CanBeNull]
	[BoolSettings(FieldName = "UnderControl")]
	[DisplayName("SR.M('На контроле')")]
	[Description("SR.M('Признак находится или нет задача на контроле исполнения задачи')")]
	[CustomFilterProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	bool? UnderControl { get; set; }

	[Uid("0ad49b52-17de-4fd1-a042-39e63e34e68c")]
	[Order(4)]
	[CanBeNull]
	[DisplayName("SR.M('Статус контроля')")]
	[CustomFilterProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	TaskControlStatus? ControlStatus { get; set; }
}
