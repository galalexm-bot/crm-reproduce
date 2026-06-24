using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Tasks.Models;

[MetadataType(typeof(EntityMetadata))]
[Uid("31c95394-0958-4027-b15c-2db4632564c6")]
[DisplayName("SR.M('Вопрос')")]
[Description("SR.M('Вопрос заданный по задаче')")]
[BaseClass("0f338330-068c-4135-be4e-95797a209c4e")]
[DisplayFormat("{$Subject}")]
[Image(typeof(IQuestion), "help", 16, ImageFormatType.IconPack, false)]
[TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>e793ef67-5d80-4884-8636-4ee6a6a2440a</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
[Entity("Question")]
[IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
[ShowInCatalogList(false)]
[EntityMetadataType(EntityMetadataType.Interface)]
[SaveHistory]
[Filterable]
[ImplementationUid("39efee84-74e8-4bb1-b9ae-846622208520")]
[FilterType(typeof(IQuestionFilter))]
[ActionsType(typeof(QuestionActions))]
public interface IQuestion : ITaskBase, IEntity<long>, IEntity, IIdentified, IInheritable
{
	[Uid("c4731aea-2fa6-4725-ad76-baae51c8c208")]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(DefaultValueStr = "True", DisplayType = BoolDisplayType.Checkbox, FieldName = "ShowAll")]
	[DisplayName("SR.M('Показывать всем')")]
	[Description("SR.M('Признак показывать или нет вопрос всем пользователям')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[EntityProperty]
	bool ShowAll { get; set; }

	[Uid("5fa40069-0303-4ee7-a7d8-142e1006c275")]
	[Order(1)]
	[Property("1f289b26-0607-4bc7-adc0-9ed814c80c90")]
	[ReferenceOnEntitySettings(FieldName = "RefObject")]
	[DisplayName("SR.M('Ссылка на сущность')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[EntityProperty]
	ReferenceOnEntity RefObject { get; set; }

	[Uid("cc171394-8e82-420e-abf0-6c4ca2aa8d5a")]
	[Order(2)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "ddff09fe-8839-448d-be48-2349985aa5c2")]
	[EntitySettings(CascadeMode = CascadeMode.All, FieldName = "Answer")]
	[DisplayName("SR.M('Ответ')")]
	[Description("SR.M('Ответ на вопрос, ссылка на соответствующий объект')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[EntityProperty]
	IAnswer Answer { get; set; }
}
