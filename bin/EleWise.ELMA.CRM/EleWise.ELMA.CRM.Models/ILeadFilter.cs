using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Types;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(ILead))]
[InterfaceImplementation("EleWise.ELMA.CRM.IMarketingActivityTargetFilter,EleWise.ELMA.CRM")]
public interface ILeadFilter : IMarketingActivityTargetFilter, IEntityFilter
{
	string Name { get; set; }

	LeadStatus? Status { get; set; }

	ISet<ILeadType> Types { get; set; }

	ILeadSource Source { get; set; }

	IUser Responsible { get; set; }

	IUser CreationAuthor { get; set; }

	IUser ChangeAuthor { get; set; }

	ILegalForm LegalForm { get; set; }

	IAddressFilter Address { get; set; }

	ISet<ICategory> Categories { get; set; }

	IContractorRegion Region { get; set; }

	IContractorIndustry Industry { get; set; }

	string Site { get; set; }

	string UtmSource { get; set; }

	string UtmMedium { get; set; }

	string UtmTerm { get; set; }

	string UtmContent { get; set; }

	string UtmCampaign { get; set; }

	LeadDublicateStatus? LeadDublicateStatus { get; set; }

	[CustomFilterProperty]
	[Uid("7b68ec36-697f-45ad-a4ac-61bbf19a0eb9")]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "ShowOnlyMy")]
	[DisplayName(typeof(__Resources_ILead), "FP_ShowOnlyMy_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	bool ShowOnlyMy { get; set; }

	[CustomFilterProperty]
	[Uid("df3dd320-a14d-462c-9a1b-e5137d6af317")]
	[Order(1)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Phone")]
	[DisplayName(typeof(__Resources_ILead), "FP_Phone_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	string Phone { get; set; }

	[CustomFilterProperty]
	[Uid("a9f927c8-52d3-448c-8838-20100ecc6e55")]
	[Order(2)]
	[Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
	[StringSettings(FieldName = "Email")]
	[DisplayName(typeof(__Resources_ILead), "FP_Email_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	string Email { get; set; }

	[CustomFilterProperty]
	[Uid("4cfae9a1-23ed-41bf-a494-db17f8c0b32b")]
	[Order(3)]
	[CanBeNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "Active")]
	[DisplayName(typeof(__Resources_ILead), "FP_Active_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	bool? Active { get; set; }

	[CustomFilterProperty]
	[Uid("16f89d54-e105-4e48-a846-6cc0cc1ed91e")]
	[Order(4)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "c29d5357-56dc-4e65-9c89-91faed78abca")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "MarketingGroup")]
	[DisplayName(typeof(__Resources_ILead), "FP_MarketingGroup_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"Obsolete\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство MarketingObjects</Value>\r\n    </Parameter>\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">true</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[Obsolete("Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство MarketingObjects", true)]
	IMarketingGroup MarketingGroup { get; set; }

	[CustomFilterProperty]
	[Uid("198cf22a-cafc-47d5-bfe1-5418a852e089")]
	[Order(5)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "53f2d16c-4d27-4891-a3ea-9f8fe7f68a00")]
	[EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "MarketingActivity")]
	[DisplayName(typeof(__Resources_ILead), "FP_MarketingActivity_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"Obsolete\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство MarketingObjects</Value>\r\n    </Parameter>\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">true</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[Obsolete("Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство MarketingObjects", true)]
	IMarketingActivity MarketingActivity { get; set; }

	[CustomFilterProperty]
	[Uid("9a79987b-3d7f-4085-a0f6-db1151659a2d")]
	[Order(6)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "2c2ae8eb-9f42-4d3e-b990-157357c1a535")]
	[MarketingEffectSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "MarketingEffect")]
	[DisplayName(typeof(__Resources_ILead), "FP_MarketingEffect_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"Obsolete\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство MarketingObjects</Value>\r\n    </Parameter>\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">true</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[Obsolete("Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство MarketingObjects", true)]
	IMarketingEffect MarketingEffect { get; set; }

	[CustomFilterProperty]
	[Uid("8aa69e88-b218-483d-9c64-96016bad36f4")]
	[Order(7)]
	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "fffdf82c-19fe-4e06-b29e-c7a34b33c4d1")]
	[EntitySettings(RelationType = RelationType.ManyToMany, ParentColumnName = "Parent", ChildColumnName = "Child", CascadeMode = CascadeMode.SaveUpdate)]
	[DisplayName(typeof(__Resources_ILead), "FP_MarketingObjects_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"EleWise.ELMA.Model.Attributes.UniversalFilterUnPackFromAttribute\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">5fb1b8ba-47ad-47fc-bad0-d94a914e6aad</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"EleWise.ELMA.Model.Attributes.UniversalFilterUnPackFromAttribute\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">9ed529e8-5f31-41c6-b982-45e5564edb51</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"EleWise.ELMA.Model.Attributes.UniversalFilterUnPackFromAttribute\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">6d0d7d72-e9c5-47a0-a953-1ea7beda76dc</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"EleWise.ELMA.Model.Attributes.UniversalFilterUnPackFromAttribute\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">bd8dd28a-b03f-2936-22ab-1f0dcc1a5090</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[UniversalFilterUnPackFrom("5fb1b8ba-47ad-47fc-bad0-d94a914e6aad")]
	[UniversalFilterUnPackFrom("9ed529e8-5f31-41c6-b982-45e5564edb51")]
	[UniversalFilterUnPackFrom("6d0d7d72-e9c5-47a0-a953-1ea7beda76dc")]
	[UniversalFilterUnPackFrom("bd8dd28a-b03f-2936-22ab-1f0dcc1a5090")]
	new ISet<IMarketingBase> MarketingObjects { get; set; }

	[CustomFilterProperty]
	[Uid("5bf15ea2-64e2-49bc-8ac3-658cdee357af")]
	[Order(8)]
	[CanBeNull]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "ab7c728d-3ba6-44ae-8e79-02f02f6ee430")]
	[EnumSettings(FieldName = "SummaryLeadStatus")]
	[DisplayName(typeof(__Resources_ILead), "FP_SummaryLeadStatus_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	SummaryLeadStatus? SummaryLeadStatus { get; set; }

	[CustomFilterProperty]
	[Uid("3f3026d5-f2f3-48c5-a935-0d7467da0e24")]
	[Order(9)]
	[Property("6fbbca7c-a693-4791-902c-30b5984671a2")]
	[DateTimeSettings(FieldName = "CreationDate")]
	[DisplayName(typeof(__Resources_ILead), "FP_CreationDate_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"Obsolete\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство RelativeCreationDate</Value>\r\n    </Parameter>\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">true</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[Obsolete("Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство RelativeCreationDate", true)]
	DateTimeRange CreationDate { get; set; }

	[CustomFilterProperty]
	[Uid("13bcdbb3-6e07-4701-bfce-6c8b3bbf6017")]
	[Order(10)]
	[Property("6fbbca7c-a693-4791-902c-30b5984671a2")]
	[DateTimeSettings(FieldName = "ChangeDate")]
	[DisplayName(typeof(__Resources_ILead), "FP_ChangeDate_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"Obsolete\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство RelativeChangeDate</Value>\r\n    </Parameter>\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">true</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[Obsolete("Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство RelativeChangeDate", true)]
	DateTimeRange ChangeDate { get; set; }

	[CustomFilterProperty]
	[Uid("51675f1e-156b-432d-9ab3-58605795e8af")]
	[Order(11)]
	[Property("1b104510-6460-441a-b75e-f3b7e9115e72")]
	[DateTimeSettings(FieldName = "RelativeCreationDate")]
	[DisplayName(typeof(__Resources_ILead), "FP_RelativeCreationDate_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"EleWise.ELMA.Model.Attributes.UniversalFilterUnPackFromAttribute\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">cf1c554f-b8ac-4316-9db8-50e99358867c</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[UniversalFilterUnPackFrom("cf1c554f-b8ac-4316-9db8-50e99358867c")]
	RelativeDateTime RelativeCreationDate { get; set; }

	[CustomFilterProperty]
	[Uid("964d04d0-ed22-47df-8ad5-faedc5d5d2dc")]
	[Order(12)]
	[Property("1b104510-6460-441a-b75e-f3b7e9115e72")]
	[DateTimeSettings(FieldName = "RelativeChangeDate")]
	[DisplayName(typeof(__Resources_ILead), "FP_RelativeChangeDate_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"EleWise.ELMA.Model.Attributes.UniversalFilterUnPackFromAttribute\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">a3bea24e-0f0a-43ce-8c53-98d4b6c58cf9</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[UniversalFilterUnPackFrom("a3bea24e-0f0a-43ce-8c53-98d4b6c58cf9")]
	RelativeDateTime RelativeChangeDate { get; set; }
}
