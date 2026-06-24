using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Types;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(ISale))]
[InterfaceImplementation("EleWise.ELMA.CRM.IMarketingActivityTargetFilter,EleWise.ELMA.CRM")]
public interface ISaleFilter : IMarketingActivityTargetFilter, IEntityFilter
{
	[Uid("aa3a9f60-a4e2-4e64-ba14-b887918d5f85")]
	string Name { get; set; }

	[Uid("48fbf6e2-1ea0-4dcb-91e6-38192effda56")]
	string ShortStatus { get; set; }

	[Uid("bf500e74-e2ed-4348-b9f4-2b1ed6fb1409")]
	SaleStatus? SaleStatus { get; set; }

	[Uid("716ee518-66ee-4414-94e7-7f8fd05e2368")]
	ICurrency Currency { get; set; }

	[Uid("872bbbc0-a1d7-4260-9a0e-30b419353a7b")]
	DateTimeRange StartDate { get; set; }

	[Uid("46e86d24-e920-454b-9520-8ce96f827b5b")]
	DateTimeRange EndDate { get; set; }

	[Uid("888a6dcc-f24a-46fa-bae0-f6ff7bc78890")]
	IUser Author { get; set; }

	[Uid("66e44cb8-0d63-45d8-bc75-3f3d9665be16")]
	DoubleRange SalesVolume { get; set; }

	[Uid("2d18b4cd-a899-4233-939f-a0066a706201")]
	ISaleFunnel SaleFunnel { get; set; }

	[Uid("d83cb9e4-3c91-4603-9f96-42cb17eb803a")]
	DateTimeRange CreationDate { get; set; }

	[CustomFilterProperty]
	[Uid("bb873599-16f7-4826-ad23-e0a1638779ee")]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "815fe8a8-fa62-47d8-b096-3e1aa8a52763")]
	[EntitySettings(RelationType = RelationType.ManyToMany, RelationTableName = "M_Contractor_Categories", ParentColumnName = "ContractorId", ChildColumnName = "CategoryId", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName("SR.M('Категории')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Filterable]
	[EntityProperty]
	ISet<ICategory> Categories { get; set; }

	[CustomFilterProperty]
	[Uid("d0b26b90-be0f-4fa7-96a9-d470867e8999")]
	[Order(1)]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "ShowOnlyMy")]
	[DisplayName("SR.M('Показывать только мои')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	bool ShowOnlyMy { get; set; }

	[CustomFilterProperty]
	[Uid("afb4bc2a-3d92-468f-9abc-8790f2618fc4")]
	[Order(2)]
	[CanBeNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "Closed")]
	[DisplayName("SR.M('Закрыта')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	bool? Closed { get; set; }

	[CustomFilterProperty]
	[Uid("7dd194e0-06f6-40c0-b8bc-b221339ecaaf")]
	[Order(3)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "67c2491f-a196-4b58-b43d-cfd3fa3b0606")]
	[EntitySettings(RelationType = RelationType.ManyToMany, ParentColumnName = "Parent", ChildColumnName = "Child", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName("SR.M('Продукты')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	ISet<IProduct> Products { get; set; }

	[CustomFilterProperty]
	[Uid("7074ca6c-d241-7b5f-353d-dc5db39078fd")]
	[Order(4)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Responsible")]
	[DisplayName("SR.M('Ответственный (старый)')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"Obsolete\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство Responsibles</Value>\r\n    </Parameter>\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">true</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[Obsolete("Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство Responsibles", true)]
	IUser Responsible { get; set; }

	[CustomFilterProperty]
	[Uid("a28bb6c3-57e1-49cb-984b-d24eb95b01c1")]
	[Order(5)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
	[EntityUserSettings(RelationType = RelationType.ManyToMany, ParentColumnName = "Parent", ChildColumnName = "Child", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName("SR.M('Ответственный')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"EleWise.ELMA.Model.Attributes.UniversalFilterUnPackFromAttribute\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">7074ca6c-d241-7b5f-353d-dc5db39078fd</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[UniversalFilterUnPackFrom("7074ca6c-d241-7b5f-353d-dc5db39078fd")]
	ISet<IUser> Responsibles { get; set; }

	[CustomFilterProperty]
	[Uid("04e6991a-e4ad-4a38-b98d-5e7edafffb24")]
	[Order(6)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "01e84b83-0d2b-4b29-85da-377fac2d8fbe")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "SaleStage")]
	[DisplayName("SR.M('Стадия сделки (старая)')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"Obsolete\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство SaleStages</Value>\r\n    </Parameter>\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">true</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[Obsolete("Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство SaleStages", true)]
	[EntityProperty]
	ISaleStage SaleStage { get; set; }

	[CustomFilterProperty]
	[Uid("60961000-fd12-4c71-b013-235e105bafb9")]
	[Order(7)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "01e84b83-0d2b-4b29-85da-377fac2d8fbe")]
	[EntitySettings(RelationType = RelationType.ManyToMany, ParentColumnName = "Parent", ChildColumnName = "Child", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName("SR.M('Стадия сделки')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"EleWise.ELMA.Model.Attributes.UniversalFilterUnPackFromAttribute\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">04E6991A-E4AD-4A38-B98D-5E7EDAFFFB24</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[UniversalFilterUnPackFrom("04E6991A-E4AD-4A38-B98D-5E7EDAFFFB24")]
	[EntityProperty]
	ISet<ISaleStage> SaleStages { get; set; }

	[CustomFilterProperty]
	[Uid("321dd589-431b-41ba-9f22-3e412c751b7a")]
	[Order(8)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "38096146-0c73-4809-94f5-e18b2d525531")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Contractor")]
	[DisplayName("SR.M('Контрагент (старый)')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"Obsolete\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство Contractors</Value>\r\n    </Parameter>\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">true</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[Obsolete("Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство Contractors", true)]
	[EntityProperty]
	IContractor Contractor { get; set; }

	[CustomFilterProperty]
	[Uid("eb188ed0-3e75-4d2d-9ed5-79034a0bb8ba")]
	[Order(9)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "38096146-0c73-4809-94f5-e18b2d525531")]
	[EntitySettings(RelationType = RelationType.ManyToMany, ParentColumnName = "Parent", ChildColumnName = "Child", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName("SR.M('Контрагент')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"EleWise.ELMA.Model.Attributes.UniversalFilterUnPackFromAttribute\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">321DD589-431B-41BA-9F22-3E412C751B7A</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[UniversalFilterUnPackFrom("321DD589-431B-41BA-9F22-3E412C751B7A")]
	[EntityProperty]
	ISet<IContractor> Contractors { get; set; }

	[CustomFilterProperty]
	[Uid("f2493570-ac32-41d2-8cb1-cd51bbcca453")]
	[Order(10)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "4c793f9b-aa9a-4d2e-91d6-3140241f326e")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Region")]
	[DisplayName("SR.M('Региональная группа (старая)')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"Obsolete\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство Regions</Value>\r\n    </Parameter>\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">true</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[Obsolete("Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство Regions", true)]
	[EntityProperty]
	IContractorRegion Region { get; set; }

	[CustomFilterProperty]
	[Uid("6d38e94b-b290-4589-a726-adc8d2a7e967")]
	[Order(11)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "4c793f9b-aa9a-4d2e-91d6-3140241f326e")]
	[EntitySettings(RelationType = RelationType.ManyToMany, ParentColumnName = "Parent", ChildColumnName = "Child", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName("SR.M('Региональная группа')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"EleWise.ELMA.Model.Attributes.UniversalFilterUnPackFromAttribute\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">F2493570-AC32-41D2-8CB1-CD51BBCCA453</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[UniversalFilterUnPackFrom("F2493570-AC32-41D2-8CB1-CD51BBCCA453")]
	[EntityProperty]
	ISet<IContractorRegion> Regions { get; set; }

	[CustomFilterProperty]
	[Uid("2db0249f-bb5b-4422-b927-9f1b58f936d3")]
	[Order(14)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "fa84a7f5-a0e1-432f-8c39-cbfd4f5e539d")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ContractorIndustry")]
	[DisplayName("SR.M('Отрасль (старая)')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"Obsolete\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство ContractorIndustries</Value>\r\n    </Parameter>\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">true</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[Obsolete("Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство ContractorIndustries", true)]
	[EntityProperty]
	IContractorIndustry ContractorIndustry { get; set; }

	[CustomFilterProperty]
	[Uid("c4a15724-a50e-4f50-8ec0-a27dcfd502a0")]
	[Order(15)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "fa84a7f5-a0e1-432f-8c39-cbfd4f5e539d")]
	[EntitySettings(RelationType = RelationType.ManyToMany, ParentColumnName = "Parent", ChildColumnName = "Child", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName("SR.M('Отрасль')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"EleWise.ELMA.Model.Attributes.UniversalFilterUnPackFromAttribute\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">2DB0249F-BB5B-4422-B927-9F1B58F936D3</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[UniversalFilterUnPackFrom("2DB0249F-BB5B-4422-B927-9F1B58F936D3")]
	[EntityProperty]
	ISet<IContractorIndustry> ContractorIndustries { get; set; }

	[CustomFilterProperty]
	[Uid("0a5aece0-4b57-475b-8bd7-66a3c56b70c8")]
	[Order(17)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "53f2d16c-4d27-4891-a3ea-9f8fe7f68a00")]
	[EntitySettings(RelationType = RelationType.ManyToMany, ParentColumnName = "Parent", ChildColumnName = "Child", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName("SR.M('Маркетинговое мероприятие')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"Obsolete\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство MarketingObjects</Value>\r\n    </Parameter>\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">true</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[Obsolete("Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство MarketingObjects", true)]
	[EntityProperty]
	ISet<IMarketingActivity> MarketingActivities { get; set; }

	[CustomFilterProperty]
	[Uid("7bc83968-9444-4d6a-974a-7649792ec721")]
	[Order(12)]
	[CanBeNull]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "70afc9e6-2dbf-4159-9bbe-e5fc29fcd9aa")]
	[EnumSettings(FieldName = "Priority")]
	[DisplayName("SR.M('Приоритет (старый)')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"Obsolete\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство Priorities</Value>\r\n    </Parameter>\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">true</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[Obsolete("Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство Priorities", true)]
	SalePriority? Priority { get; set; }

	[CustomFilterProperty]
	[Uid("ed15d7ca-bd54-4cf8-9ed7-88f33a7861c4")]
	[Order(13)]
	[CanBeNull]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "70afc9e6-2dbf-4159-9bbe-e5fc29fcd9aa")]
	[EnumSettings(RelationType = EnumRelationType.Many, FieldName = "Priorities")]
	[DisplayName("SR.M('Приоритет')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"EleWise.ELMA.Model.Attributes.UniversalFilterUnPackFromAttribute\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">7bc83968-9444-4d6a-974a-7649792ec721</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[UniversalFilterUnPackFrom("7bc83968-9444-4d6a-974a-7649792ec721")]
	List<SalePriority> Priorities { get; set; }

	[CustomFilterProperty]
	[Uid("e68142e9-3f3a-4c95-b494-0663989510f1")]
	[Order(21)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "2cbb2930-dc2c-415f-82cd-b30d8c3df66d")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "SaleType")]
	[DisplayName("SR.M('Тип сделки (старый)')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"Obsolete\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство SaleTypes</Value>\r\n    </Parameter>\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">true</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[Obsolete("Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство SaleTypes", true)]
	ISaleType SaleType { get; set; }

	[CustomFilterProperty]
	[Uid("d32c3e08-0901-4f39-a7f4-a66a11941b61")]
	[Order(22)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "2cbb2930-dc2c-415f-82cd-b30d8c3df66d")]
	[EntitySettings(RelationType = RelationType.ManyToMany, ParentColumnName = "Parent", ChildColumnName = "Child", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName("SR.M('Тип сделки')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"EleWise.ELMA.Model.Attributes.UniversalFilterUnPackFromAttribute\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">e68142e9-3f3a-4c95-b494-0663989510f1</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[UniversalFilterUnPackFrom("e68142e9-3f3a-4c95-b494-0663989510f1")]
	ISet<ISaleType> SaleTypes { get; set; }

	[CustomFilterProperty]
	[Uid("66d10f78-1190-4e46-a5ad-f62934cb4224")]
	[Order(20)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "fffdf82c-19fe-4e06-b29e-c7a34b33c4d1")]
	[EntitySettings(RelationType = RelationType.ManyToMany, ParentColumnName = "Parent", ChildColumnName = "Child", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName("SR.M('Маркетинг')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"EleWise.ELMA.Model.Attributes.UniversalFilterUnPackFromAttribute\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">f2d7023f-178d-4f89-a6f2-2786d7d88478</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"EleWise.ELMA.Model.Attributes.UniversalFilterUnPackFromAttribute\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">da589e79-cfba-4fcf-a0cf-85decd0824a5</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"EleWise.ELMA.Model.Attributes.UniversalFilterUnPackFromAttribute\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">487b0c45-5d4d-476c-ba97-f7a9bc20f3fe</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"EleWise.ELMA.Model.Attributes.UniversalFilterUnPackFromAttribute\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">C66266AB-A933-42EF-8878-F1781EC3DE5D</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"EleWise.ELMA.Model.Attributes.UniversalFilterUnPackFromAttribute\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">bd8dd28a-b03f-2936-22ab-1f0dcc1a5090</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[UniversalFilterUnPackFrom("f2d7023f-178d-4f89-a6f2-2786d7d88478")]
	[UniversalFilterUnPackFrom("da589e79-cfba-4fcf-a0cf-85decd0824a5")]
	[UniversalFilterUnPackFrom("487b0c45-5d4d-476c-ba97-f7a9bc20f3fe")]
	[UniversalFilterUnPackFrom("C66266AB-A933-42EF-8878-F1781EC3DE5D")]
	[UniversalFilterUnPackFrom("bd8dd28a-b03f-2936-22ab-1f0dcc1a5090")]
	new ISet<IMarketingBase> MarketingObjects { get; set; }

	[CustomFilterProperty]
	[Uid("cd9a8df4-a420-4e0a-a535-a48fc760c7f2")]
	[Order(18)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "2c2ae8eb-9f42-4d3e-b990-157357c1a535")]
	[MarketingEffectSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "MarketingEffect")]
	[DisplayName("SR.M('Маркетинговое воздействие (старое)')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"Obsolete\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство MarketingObjects</Value>\r\n    </Parameter>\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">true</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[Obsolete("Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство MarketingObjects", true)]
	IMarketingEffect MarketingEffect { get; set; }

	[CustomFilterProperty]
	[Uid("fdf24ff8-bf91-4518-af6d-3c9c65647e45")]
	[Order(16)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "53f2d16c-4d27-4891-a3ea-9f8fe7f68a00")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "MarketingActivity")]
	[DisplayName("SR.M('Маркетинговое мероприятие (старое)')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"Obsolete\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство MarketingObjects</Value>\r\n    </Parameter>\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">true</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[Obsolete("Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство MarketingObjects", true)]
	IMarketingActivity MarketingActivity { get; set; }

	[CustomFilterProperty]
	[Uid("58cbfc02-0744-4c0c-8def-cb47ab216952")]
	[Order(19)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "c29d5357-56dc-4e65-9c89-91faed78abca")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "MarketingGroup")]
	[DisplayName("SR.M('Группа мероприятий (старое)')")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"Obsolete\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство MarketingObjects</Value>\r\n    </Parameter>\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">true</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[Obsolete("Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство MarketingObjects", true)]
	IMarketingGroup MarketingGroup { get; set; }
}
