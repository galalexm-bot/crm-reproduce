using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Documents.Models;

[FilterFor(typeof(IDocument))]
public interface IDocumentFilter : IDmsObjectFilter, IEntityFilter
{
	ILifeCycleStatus Status { get; set; }

	[CustomFilterProperty]
	[Uid("3325d7df-9c76-4edd-b215-445c3301ec22")]
	[CanBeNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "TypeUid")]
	[DisplayName("SR.M('TypeUid')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	Guid? TypeUid { get; set; }

	[CustomFilterProperty]
	[Uid("7f36f012-b4aa-4cd3-bf53-6678fc957142")]
	[Order(4)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "0bf0145b-21ae-4184-80eb-f26c967dcce6")]
	[EntitySettings(RelationType = RelationType.ManyToMany, ParentColumnName = "Parent", ChildColumnName = "Child")]
	[DisplayName("SR.M('Статус ЖЦ')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	ISet<ILifeCycleStatus> ListCycleStatus { get; set; }

	[CustomFilterProperty]
	[Uid("f9eab3a0-dac2-42d0-a053-669946475f7d")]
	[Order(1)]
	[Property("5c281e64-ddc8-4bc9-991a-84d9dc4e7649")]
	[ListOfSimpleTypeSettings(SimpleTypeUidStr = "2df8e9ca-3ac4-4ba5-832f-18f6374397e7", FieldName = "Types")]
	[DisplayName("SR.M('Типы документа')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	List<ReferenceOnEntityType> Types { get; set; }

	[CustomFilterProperty]
	[Uid("6b2e5415-886a-434f-8afb-80bee339508d")]
	[Order(2)]
	[Property("c77cd813-1dfb-4777-ab7e-87b54bd09e38")]
	[AnyTypeSettings(FullTypeName = "EleWise.ELMA.Documents.Models.SendInfo")]
	[DisplayName("SR.M('Отправление')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	SendInfo SendInfo { get; set; }

	[CustomFilterProperty]
	[Uid("89bc5575-ed5f-412f-9b0e-83c0deadaaab")]
	[Order(3)]
	[CanBeNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "NeedAnswer")]
	[DisplayName("SR.M('Требуют ответа')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	bool? NeedAnswer { get; set; }

	[CustomFilterProperty]
	[Uid("e99388f2-7801-4ddc-9f90-34fa449c30d5")]
	[Order(5)]
	[Property("5c281e64-ddc8-4bc9-991a-84d9dc4e7649")]
	[ListOfSimpleTypeSettings(SimpleTypeUidStr = "d90a59af-7e47-48c5-8c4c-dad04834e6e3", FieldName = "Ids")]
	[DisplayName("SR.M('Идентификаторы проектов')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	List<long> Ids { get; set; }

	[CustomFilterProperty]
	[Uid("1bb2ac25-ea38-48a0-a986-3a14694f0eef")]
	[Order(6)]
	[Property("5c281e64-ddc8-4bc9-991a-84d9dc4e7649")]
	[ListOfSimpleTypeSettings(SimpleTypeUidStr = "eb6e8ddc-fafe-4e0e-9018-1a7667012579", FieldName = "TypeUids")]
	[DisplayName("SR.M('Типы')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	List<Guid> TypeUids { get; set; }
}
