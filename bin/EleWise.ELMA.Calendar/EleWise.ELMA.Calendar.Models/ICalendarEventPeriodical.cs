using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Calendar.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("426355b4-d657-427c-afb8-50f544a87f11")]
[DisplayName("SR.M('Шаблон периодического события')")]
[Description("SR.M('Данный объект представляет собой шаблон, на основе которого создаются периодические события. Для добавления свойств и редактирования форм используйте объект «Событие».')")]
[BaseClass("6fb5a4a7-8b40-4b17-a2ae-3fdd0b04945c")]
[AllowCreateHeirs(true)]
[DisplayFormat(null)]
[InterfaceImplementation(" EleWise.ELMA.Common.Models.IPeriodicalEntityExtension, EleWise.ELMA.Common")]
[Image(typeof(ICalendarEventPeriodical), "calendar_periodical", 16, ImageFormatType.IconPack, false)]
[CustomCode(typeof(ICalendarEventPeriodical), "EleWise.ELMA.Calendar.Models.CalendarEventPeriodical.CustomCodeTemplate.cs")]
[ClassFormsScheme(ClassFormsScheme.FormConstructor)]
[Form(typeof(ICalendarEventPeriodical), "EleWise.ELMA.Calendar.Models.CalendarEventPeriodical.Form.DummyForm.xml")]
[FormTransformation(typeof(ICalendarEventPeriodical), "EleWise.ELMA.Calendar.Models.CalendarEventPeriodical.Form.Form.xml")]
[FormTransformation(typeof(ICalendarEventPeriodical), "EleWise.ELMA.Calendar.Models.CalendarEventPeriodical.Form.ViewForm.xml")]
[TableView("\ufeff<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>99568358-7a5c-4f83-a366-3baa3a2b3724</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("CalendarEventPeriodical")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[SaveHistory]
[Filterable]
[ImplementationUid("4f44892b-1162-44f5-bca9-34fc4f1ee267")]
[FilterType(typeof(ICalendarEventPeriodicalFilter))]
[ActionsType(typeof(CalendarEventPeriodicalActions))]
public interface ICalendarEventPeriodical : ICalendarEvent, IEntity<long>, IEntity, IIdentified, IInheritable, IPeriodicalEntityExtension, IPeriodicalEntity
{
	[Uid("c7553b88-37f2-4b95-bd80-d0e6c6809624")]
	[NotNull]
	[Required(true)]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "b7cb3369-f04c-418e-a311-1baedc11fcb6")]
	[EnumSettings(DefaultValueStr = "e1e582da-461d-4bec-807b-9c10f93ffeab", FieldName = "Period")]
	[RequiredField]
	[DisplayName("SR.M('Периодичность')")]
	[Description("SR.M('Периодичность повторения')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	new Periodicity Period { get; set; }

	[Uid("230a6e23-7825-4777-b713-03bb5c456903")]
	[Order(1)]
	[CanBeNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(FieldName = "UntilDate")]
	[DisplayName("SR.M('Дата завершения')")]
	[Description("SR.M('Дата завершения создания сущностей')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	new DateTime? UntilDate { get; set; }

	[Uid("12fa42b8-db34-433c-b095-68e656392fc0")]
	[Order(2)]
	[NotNull]
	[Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
	[Int64Settings(DefaultValueStr = "0", FieldName = "ForwardCreated")]
	[DisplayName("SR.M('Количество создаваемых')")]
	[Description("SR.M('Количество вперед создаваемых сущностей')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	new long ForwardCreated { get; set; }

	[Uid("6a1264c2-123e-4e94-bdea-4e50417851f6")]
	[Order(3)]
	[CanBeNull]
	[Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
	[DateTimeSettings(FieldName = "LastPeriodDate")]
	[DisplayName("SR.M('Дата последнего создания')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	new DateTime? LastPeriodDate { get; set; }

	[Uid("939125fb-1b32-4dbe-a20c-960e9f654ea7")]
	[Order(4)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "Closed")]
	[DisplayName("SR.M('Статус закрытия')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	new bool Closed { get; set; }

	[Uid("f4da0669-10a6-4d17-a04c-d4fdf4262e1e")]
	[Order(5)]
	[Property("317e3d72-9c47-4b68-926d-ba77a2579bc2")]
	[TextSettings(FieldName = "SettingsData")]
	[DisplayName("SR.M('Параметры периодического события в формате JSON')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[EntityProperty]
	new string SettingsData { get; set; }
}
