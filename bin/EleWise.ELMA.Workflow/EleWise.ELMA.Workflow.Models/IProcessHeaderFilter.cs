using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Workflow.Models;

[FilterFor(typeof(IProcessHeader))]
public interface IProcessHeaderFilter : IEntityFilter
{
	string Name { get; set; }

	DateTimeRange CreationDate { get; set; }

	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Description("SR.M('Процессы, которые можно запускать \\nПрименяется в связке с UserIds. Если false, то UserIds не учитывается')")]
	[DisplayName("SR.M('Запускаемость')")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[RequiredField]
	[NotNull]
	[Uid("cdfe4266-b494-44a3-a7e8-2724a200fac3")]
	[CustomFilterProperty]
	[BoolSettings(FieldName = "Startable")]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[Required(true)]
	bool Startable { get; set; }

	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Description("SR.M('Id-ры пользователей, которые могут запустить процесс.\\nЕсли null - то для текущего пользователя.  ')")]
	[DisplayName("SR.M('Id-ры пользователей, которые могут запустить процесс')")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Uid("8e5386fc-04b5-455f-8f3a-cadd090bc73c")]
	[CustomFilterProperty]
	[Order(1)]
	[AnyTypeSettings(FullTypeName = "System.Collections.Generic.List<long>")]
	[Property("c77cd813-1dfb-4777-ab7e-87b54bd09e38")]
	List<long> UserIds { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName("SR.M('Фильтрация по уровням ответственности')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Uid("8345f2fe-f6ad-443f-893a-f2df9fcb8d6c")]
	[CustomFilterProperty]
	[Order(2)]
	[AnyTypeSettings(FullTypeName = "System.Collections.Generic.List<ResponsibilityLevel>")]
	[Property("c77cd813-1dfb-4777-ab7e-87b54bd09e38")]
	List<ResponsibilityLevel> ResponsibilityLevels { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[DisplayName("SR.M('Фильтрация процессов по кураторcтву текущего пользователя')")]
	[BoolSettings(FieldName = "IsCurator")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(3)]
	[Uid("42d571f6-a354-4ef7-bbc1-eb4db9c682c4")]
	[CustomFilterProperty]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[CanBeNull]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	bool? IsCurator { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[CustomFilterProperty]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "Published1")]
	[CanBeNull]
	[Uid("c9565b82-59ab-4eca-8c0f-589b24ab425d")]
	[DisplayName("SR.M('Процессы, у которых есть (нет) опубликованные версии')")]
	[Order(4)]
	bool? HasPublished { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[CustomFilterProperty]
	[DisplayName("SR.M('Идентификаторы заголовков процесса')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[AnyTypeSettings(FullTypeName = "System.Collections.Generic.IList<long>")]
	[Uid("7d143ae2-be64-444b-879c-70d344fd48ca")]
	[Order(5)]
	[Property("c77cd813-1dfb-4777-ab7e-87b54bd09e38")]
	IList<long> Ids { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Sortable(false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[Order(6)]
	[CustomFilterProperty]
	[Uid("df09b763-a08e-4914-9333-834d5eb467b3")]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[DisplayName("SR.M('Фильтрация заголовков процессов для монитора процессов')")]
	[NotNull]
	[BoolSettings(DisplayType = BoolDisplayType.Checkbox, FieldName = "MonitorProcessHeaderFilter")]
	bool MonitorProcessHeaderFilter { get; set; }
}
