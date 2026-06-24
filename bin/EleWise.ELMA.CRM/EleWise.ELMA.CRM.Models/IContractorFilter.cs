using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.CRM.Types;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(IContractor))]
[InterfaceImplementation("EleWise.ELMA.CRM.IMarketingActivityTargetFilter,EleWise.ELMA.CRM")]
public interface IContractorFilter : IMarketingActivityTargetFilter, IEntityFilter
{
	string Name { get; set; }

	string Fax { get; set; }

	IUser Responsible { get; set; }

	DateTimeRange CompanyDay { get; set; }

	DoubleRange AnnualIncome { get; set; }

	IAddressFilter LegalAddress { get; set; }

	string INN { get; set; }

	DateTimeRange CreationDate { get; set; }

	IUser CreationAuthor { get; set; }

	DateTimeRange ChangeDate { get; set; }

	IUser ChangeAuthor { get; set; }

	IContractorRegion Region { get; set; }

	IContractorIndustry Industry { get; set; }

	IContractor Partner { get; set; }

	IContractorType Type { get; set; }

	ISet<ICategory> Categories { get; set; }

	ISet<IBankAccount> BankAccounts { get; set; }

	[CustomFilterProperty]
	[Uid("00599498-b985-49a9-9e34-dc1d20d564c2")]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "ShowOnlyMy")]
	[DisplayName(typeof(__Resources_IContractor), "FP_ShowOnlyMy_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	bool ShowOnlyMy { get; set; }

	[CustomFilterProperty]
	[Uid("cb94790c-4150-461b-b090-4ccf364a805d")]
	[Order(1)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Phone")]
	[DisplayName(typeof(__Resources_IContractor), "FP_Phone_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	string Phone { get; set; }

	[CustomFilterProperty]
	[Uid("c2910f04-c460-40ab-88ec-9983fdad64f2")]
	[Order(2)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Email")]
	[DisplayName(typeof(__Resources_IContractor), "FP_Email_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	string Email { get; set; }

	[CustomFilterProperty]
	[Uid("2a8f3dbf-0e72-4600-860b-b5ac57338ea6")]
	[Order(3)]
	[CanBeNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "IsContactSupportType")]
	[DisplayName(typeof(__Resources_IContractor), "FP_IsContactSupportType_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	bool? IsContactSupportType { get; set; }

	[CustomFilterProperty]
	[Uid("12794d70-ca92-4490-95ff-ac26af569d46")]
	[Order(4)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "c29d5357-56dc-4e65-9c89-91faed78abca")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "MarketingGroup")]
	[DisplayName(typeof(__Resources_IContractor), "FP_MarketingGroup_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"Obsolete\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство MarketingObjects</Value>\r\n    </Parameter>\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">true</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[Obsolete("Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство MarketingObjects", true)]
	IMarketingGroup MarketingGroup { get; set; }

	[CustomFilterProperty]
	[Uid("b59ba164-abd2-42ea-944a-799c30cbe05c")]
	[Order(5)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "53f2d16c-4d27-4891-a3ea-9f8fe7f68a00")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "MarketingActivity")]
	[DisplayName(typeof(__Resources_IContractor), "FP_MarketingActivity_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"Obsolete\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство MarketingObjects</Value>\r\n    </Parameter>\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">true</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[Obsolete("Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство MarketingObjects", true)]
	IMarketingActivity MarketingActivity { get; set; }

	[CustomFilterProperty]
	[Uid("9d727d11-bd9c-4949-88f1-05a3ee482b6d")]
	[Order(6)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "2c2ae8eb-9f42-4d3e-b990-157357c1a535")]
	[MarketingEffectSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "MarketingEffect")]
	[DisplayName(typeof(__Resources_IContractor), "FP_MarketingEffect_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"Obsolete\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство MarketingObjects</Value>\r\n    </Parameter>\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">true</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[Obsolete("Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство MarketingObjects", true)]
	IMarketingEffect MarketingEffect { get; set; }

	[CustomFilterProperty]
	[Uid("debf31e9-f888-4198-8459-ef9de275234d")]
	[Order(7)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "fffdf82c-19fe-4e06-b29e-c7a34b33c4d1")]
	[EntitySettings(RelationType = RelationType.ManyToMany, ParentColumnName = "Parent", ChildColumnName = "Child", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_IContractor), "FP_MarketingObjects_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"EleWise.ELMA.Model.Attributes.UniversalFilterUnPackFromAttribute\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">e42908f0-52c6-4fb9-9d54-f52c33573978</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"EleWise.ELMA.Model.Attributes.UniversalFilterUnPackFromAttribute\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">4659128d-aad4-411f-96e2-7220b5edfa6a</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"EleWise.ELMA.Model.Attributes.UniversalFilterUnPackFromAttribute\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">f8ac787d-c57e-4033-9b0f-a033e5553acb</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"EleWise.ELMA.Model.Attributes.UniversalFilterUnPackFromAttribute\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">bd8dd28a-b03f-2936-22ab-1f0dcc1a5090</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[UniversalFilterUnPackFrom("e42908f0-52c6-4fb9-9d54-f52c33573978")]
	[UniversalFilterUnPackFrom("4659128d-aad4-411f-96e2-7220b5edfa6a")]
	[UniversalFilterUnPackFrom("f8ac787d-c57e-4033-9b0f-a033e5553acb")]
	[UniversalFilterUnPackFrom("bd8dd28a-b03f-2936-22ab-1f0dcc1a5090")]
	new ISet<IMarketingBase> MarketingObjects { get; set; }
}
