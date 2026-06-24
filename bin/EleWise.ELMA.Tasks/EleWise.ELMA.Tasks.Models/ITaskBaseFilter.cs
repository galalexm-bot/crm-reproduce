using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Tasks.Models;

[FilterFor(typeof(ITaskBase))]
public interface ITaskBaseFilter : IEntityFilter
{
	string Subject { get; set; }

	string Description { get; set; }

	RelativeDateTime CreationDate { get; set; }

	IUser CreationAuthor { get; set; }

	IUser Executor { get; set; }

	DateTimeRange StartDate { get; set; }

	RelativeDateTime EndDate { get; set; }

	TaskPriority? Priority { get; set; }

	ITaskBase ParentTask { get; set; }

	TaskBaseStatus Status { get; set; }

	RelativeDateTime EndWorkDate { get; set; }

	ISet<IUser> InformTo { get; set; }

	bool? NotShowInLists { get; set; }

	ITaskCategory Category { get; set; }

	bool? IsEmulation { get; set; }

	[CustomFilterProperty]
	[Uid("88f9aa08-a220-4e33-b097-22993ab4f39d")]
	[CanBeNull]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "b11d6d0a-f07b-40a3-bc49-2cc5a67fbc81")]
	[EnumSettings(RelationType = EnumRelationType.Many, FieldName = "Statuses")]
	[DisplayName(typeof(__Resources_ITaskBase), "FP_Statuses_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	List<TaskBaseStatus> Statuses { get; set; }

	[CustomFilterProperty]
	[Uid("a4459a1b-a1c1-4da9-ae24-858747c21f33")]
	[Order(1)]
	[CanBeNull]
	[Property("c503ae0f-d260-4173-b52b-63e9158f3d7d")]
	[TimeSpanSettings(FieldName = "TimePlannedRange")]
	[DisplayName(typeof(__Resources_ITaskBase), "FP_TimePlannedRange_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	TimeSpan? TimePlannedRange { get; set; }

	[CustomFilterProperty]
	[Uid("53e9a68d-d263-4032-a917-488177f29c87")]
	[Order(2)]
	[CanBeNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "IsPlanned")]
	[DisplayName(typeof(__Resources_ITaskBase), "FP_IsPlanned_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	bool? IsPlanned { get; set; }

	[CustomFilterProperty]
	[Uid("f7a7aeb1-2ab0-4439-a2f4-d588d5bbe190")]
	[Order(3)]
	[CanBeNull]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(MinValue = 1L, FieldName = "TaskID")]
	[RangeValue(1L, long.MaxValue)]
	[DisplayName(typeof(__Resources_ITaskBase), "FP_TaskId_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	long? TaskId { get; set; }

	[CustomFilterProperty]
	[Uid("ade75e3f-fdc5-4718-8007-9174e963764d")]
	[Order(4)]
	[CanBeNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "TypeUid")]
	[DisplayName(typeof(__Resources_ITaskBase), "FP_TypeUid_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	Guid? TypeUid { get; set; }

	[CustomFilterProperty]
	[Uid("b4ea087f-6330-4cbe-ad2b-49a2b9fcc9ee")]
	[Order(5)]
	[NotNull]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "066145ed-7384-4894-b651-407694517ecc")]
	[EnumSettings(DefaultValueStr = "02b202f3-5734-424a-8b03-0ffa84e254d0", FieldName = "CompleteStatus")]
	[DisplayName(typeof(__Resources_ITaskBase), "FP_CompleteStatus_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	TaskCompleteStatus CompleteStatus { get; set; }

	[CustomFilterProperty]
	[Uid("99ad10b0-aa66-4d00-aba0-feb044f41f7a")]
	[Order(7)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(RelationType = RelationType.ManyToMany, ParentColumnName = "Parent", ChildColumnName = "Child")]
	[DisplayName(typeof(__Resources_ITaskBase), "FP_Executors_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	ISet<IUser> Executors { get; set; }

	[CustomFilterProperty]
	[Uid("59095418-c0da-4f88-971c-bfad31f70b61")]
	[Order(8)]
	[Property("6fbbca7c-a693-4791-902c-30b5984671a2")]
	[DateTimeSettings(FieldName = "DatePeriod")]
	[DisplayName(typeof(__Resources_ITaskBase), "FP_DatePeriod_DisplayName")]
	[Description(typeof(__Resources_ITaskBase), "FP_DatePeriod_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	DateTimeRange DatePeriod { get; set; }

	[CustomFilterProperty]
	[Uid("c972fd2b-f4db-43d6-80bc-1ded778b7cd1")]
	[Order(9)]
	[Property("c77cd813-1dfb-4777-ab7e-87b54bd09e38")]
	[AnyTypeSettings(FullTypeName = "System.Collections.Generic.List<System.Guid>")]
	[DisplayName(typeof(__Resources_ITaskBase), "FP_TypeUids_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	List<Guid> TypeUids { get; set; }

	[CustomFilterProperty]
	[Uid("194cf02a-d719-4e0c-9513-2c4cdff67a70")]
	[Order(11)]
	[CanBeNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "OnlyFromMyDepartment")]
	[DisplayName(typeof(__Resources_ITaskBase), "FP_OnlyFromMyDepartment_DisplayName")]
	[Sortable(false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	bool? OnlyFromMyDepartment { get; set; }

	[CustomFilterProperty]
	[Uid("7101fb83-44f4-4d1f-b50c-1b48ecc6a0cf")]
	[Order(10)]
	[CanBeNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "OnlyForMyDepartment")]
	[DisplayName(typeof(__Resources_ITaskBase), "FP_OnlyForMyDepartment_DisplayName")]
	[Sortable(false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	bool? OnlyForMyDepartment { get; set; }

	[CustomFilterProperty]
	[Uid("2bd8f236-f585-4b4e-b8b4-ebe7a0ac6f5a")]
	[Order(6)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(RelationType = RelationType.ManyToMany, ParentColumnName = "Parent", ChildColumnName = "Child", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_ITaskBase), "FP_CreationAuthors_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	ISet<IUser> CreationAuthors { get; set; }

	[CustomFilterProperty]
	[Uid("cd3b5bd2-bd34-4118-bbd4-b3af43f3540b")]
	[Order(12)]
	[Property("c77cd813-1dfb-4777-ab7e-87b54bd09e38")]
	[AnyTypeSettings(FullTypeName = "System.Collections.Generic.List<System.Guid>")]
	[DisplayName(typeof(__Resources_ITaskBase), "FP_ExcludedTypeUids_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	List<Guid> ExcludedTypeUids { get; set; }

	[CustomFilterProperty]
	[Uid("94becfc4-7fa0-4ffc-8bcd-b5b998df5e8f")]
	[Order(13)]
	[CanBeNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "OnlyICoExecutor")]
	[DisplayName(typeof(__Resources_ITaskBase), "FP_OnlyICoExecutor_DisplayName")]
	[Sortable(false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	bool? OnlyICoExecutor { get; set; }
}
