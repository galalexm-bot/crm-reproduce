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

namespace EleWise.ELMA.Workflow.Models;

[FilterFor(typeof(IWorkflowInstance))]
public interface IWorkflowInstanceFilter : IEntityFilter
{
	IWorkflowInstance ParentInstance { get; set; }

	string Name { get; set; }

	IUser Initiator { get; set; }

	IUser Responsible { get; set; }

	DateTimeRange StartDate { get; set; }

	DateTimeRange EndDate { get; set; }

	bool? IsEmulation { get; set; }

	[DisplayName("SR.M('Статусы экземпляров')")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("0b19751d-fcc1-43c5-83db-2b51caa4d749")]
	[CustomFilterProperty]
	[Order(3)]
	[AnyTypeSettings(FullTypeName = "System.Collections.Generic.List<WorkflowInstanceStatus>")]
	[Property("c77cd813-1dfb-4777-ab7e-87b54bd09e38")]
	List<WorkflowInstanceStatus> Statuses { get; set; }

	[StringSettings(FieldName = "TaskName")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[DisplayName("SR.M('Имя задачи')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("b83b9c86-4b2a-45f0-b55d-6abcb95653c1")]
	[Order(4)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[CustomFilterProperty]
	string TaskName { get; set; }

	[Order(6)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[GuidSettings(FieldName = "SwimlaneUid")]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName("SR.M('Уникальный идентификатор Зоны Ответственности')")]
	[CanBeNull]
	[CustomFilterProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("75f22b80-0e82-4ade-88af-a7d2a8f6888a")]
	Guid? SwimlaneUid { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("f2c7e506-f6e7-40c8-94e5-0aceef47195f")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Property("5c281e64-ddc8-4bc9-991a-84d9dc4e7649")]
	[Order(7)]
	[DisplayName("SR.M('Фильтр по идентификаторам задач')")]
	[ListOfSimpleTypeSettings(SimpleTypeUidStr = "eb6e8ddc-fafe-4e0e-9018-1a7667012579", FieldName = "ActivityUids")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[CustomFilterProperty]
	List<Guid> ActivityUids { get; set; }

	[Property("c77cd813-1dfb-4777-ab7e-87b54bd09e38")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[TypeFilterPropertyResolver("310778a4-1bdb-4e8b-ba97-756d294e846a")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("fbeb4d40-700c-4e50-b21f-c27c1cdd005b")]
	[CustomFilterProperty]
	[Order(10)]
	[DisplayName("SR.M('Фильтр по контекстным переменным')")]
	[AnyTypeSettings(FullTypeName = "EleWise.ELMA.Model.Common.Filter")]
	Filter ContextFilter { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("c70b574b-78a6-4d57-b8bd-c6abba8665e0")]
	[CustomFilterProperty]
	[EntityUserSettings(FieldName = "TaskExecutor")]
	[Order(5)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName("SR.M('Исполнитель задачи')")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	IUser TaskExecutor { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Int64Settings(FieldName = "ProcessHeaderId")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName("SR.M('Идентификатор заголовка процесса')")]
	[Description("SR.M('Не использовать. Устаревшее. Применять свойство ProcessHeader')")]
	[CustomFilterProperty]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Uid("e4adcbda-5c09-4844-9f61-a3765599d9fd")]
	[CanBeNull]
	[Order(1)]
	long? ProcessHeaderId { get; set; }

	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ProcessHeader")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "da55965d-02a3-4dfd-8b71-d0c45d82c6a5")]
	[DisplayName("SR.M('Процесс')")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("c5d08041-61e2-4e59-9837-84403bc55c8a")]
	[CustomFilterProperty]
	IProcessHeader ProcessHeader { get; set; }

	[Order(9)]
	[CanBeNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[CustomFilterProperty]
	[Uid("a2073d5f-5480-432b-a8b0-6eec857f8e1e")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[GuidSettings(FieldName = "CurrentExecuterRole")]
	[DisplayName("SR.M('Моя роль в процессе')")]
	Guid? CurrentExecuterRole { get; set; }

	[DisplayName("SR.M('Состояние')")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EnumSettings(FieldName = "GeneralStatus")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Order(2)]
	[CustomFilterProperty]
	[CanBeNull]
	[Uid("95f71dd4-8ae5-4969-b012-1a4deea05067")]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "a6f70f2a-4685-4b4e-adce-d7aa16f245b2")]
	WorkflowInstanceGeneralStatus? GeneralStatus { get; set; }

	[CanBeNull]
	[CustomFilterProperty]
	[Uid("196f4c6e-41dc-423d-9735-276bd0b9cd24")]
	[Order(8)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[BoolSettings(FieldName = "WithNullStatus")]
	[DisplayName("SR.M('С непроставленным статусом')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	bool? WithNullStatus { get; set; }

	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[Order(11)]
	[Uid("aa73fd8d-d0ee-4e27-87fa-468f9c9369dc")]
	[CustomFilterProperty]
	[DisplayName("SR.M('Список идентификаторов процессов')")]
	[AnyTypeSettings(FullTypeName = "System.Collections.Generic.IList<long>")]
	[Property("c77cd813-1dfb-4777-ab7e-87b54bd09e38")]
	IList<long> ProcessIds { get; set; }
}
