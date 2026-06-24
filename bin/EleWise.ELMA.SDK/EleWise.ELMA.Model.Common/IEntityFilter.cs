using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Model.Common;

public interface IEntityFilter
{
	[View(Visibility.Hidden)]
	[DisplayName(typeof(__Resources_IEntityFilter), "P_SearchString_DisplayName")]
	string SearchString { get; set; }

	[View(Visibility.Hidden)]
	[DisplayName(typeof(__Resources_IEntityFilter), "P_Subtype_DisplayName")]
	[PublicApiMethodForBuilder(false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"PublicApiMethodForBuilder\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">false</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	Type Subtype { get; set; }

	[View(Visibility.Hidden)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"PublicApiMethodForBuilder\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">false</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[PublicApiMethodForBuilder(false)]
	[DisplayName(typeof(__Resources_IEntityFilter), "P_PermissionId_DisplayName")]
	Guid? PermissionId { get; set; }

	[View(Visibility.Hidden)]
	[PublicApiMethodForBuilder(false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"PublicApiMethodForBuilder\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">false</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[DisplayName(typeof(__Resources_IEntityFilter), "P_PermissionUser_DisplayName")]
	IUser PermissionUser { get; set; }

	[DisplayName(typeof(__Resources_IEntityFilter), "P_DisableSecurity_DisplayName")]
	[PublicApiMethodForBuilder(false)]
	[View(Visibility.Hidden)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"PublicApiMethodForBuilder\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">false</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	bool DisableSecurity { get; set; }

	[PublicApiMethodForBuilder(false)]
	[View(Visibility.Hidden)]
	[DisplayName(typeof(__Resources_IEntityFilter), "P_DisableSoftDeletable_DisplayName")]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"PublicApiMethodForBuilder\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">false</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	bool DisableSoftDeletable { get; set; }

	[PublicApiMethodForBuilder(false)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"PublicApiMethodForBuilder\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">false</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[View(Visibility.Hidden)]
	[DisplayName(typeof(__Resources_IEntityFilter), "P_SkipAdminPermission_DisplayName")]
	bool SkipAdminPermission { get; set; }

	[DisplayName(typeof(__Resources_IEntityFilter), "P_Id_DisplayName")]
	[View(Visibility.Hidden)]
	object Id { get; set; }

	[PublicApiMethodForBuilder(false)]
	[View(Visibility.Hidden)]
	[DisplayName(typeof(__Resources_IEntityFilter), "P_HierarchyParent_DisplayName")]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"PublicApiMethodForBuilder\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">false</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	object HierarchyParent { get; set; }

	[PublicApiMethodForBuilder(false)]
	[View(Visibility.Hidden)]
	[DisplayName(typeof(__Resources_IEntityFilter), "P_FilterByHierarchyParent_DisplayName")]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"PublicApiMethodForBuilder\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">false</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	bool FilterByHierarchyParent { get; set; }

	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"PublicApiMethodForBuilder\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">false</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[DisplayName(typeof(__Resources_IEntityFilter), "P_DisableAutoFilter_DisplayName")]
	[PublicApiMethodForBuilder(false)]
	[View(Visibility.Hidden)]
	bool DisableAutoFilter { get; set; }

	[DisplayName(typeof(__Resources_IEntityFilter), "P_ShowOnlyGroups_DisplayName")]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"PublicApiMethodForBuilder\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">false</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	[View(Visibility.Hidden)]
	[PublicApiMethodForBuilder(false)]
	bool ShowOnlyGroups { get; set; }

	[DisplayName(typeof(__Resources_IEntityFilter), "P_FullTextInAttachments_DisplayName")]
	[View(Visibility.Hidden)]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"PublicApiMethodForBuilder\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">false</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	bool FullTextInAttachments { get; set; }

	[View(Visibility.Hidden)]
	[DisplayName(typeof(__Resources_IEntityFilter), "P_Query_DisplayName")]
	string Query { get; set; }

	[PublicApiMethodForBuilder(false)]
	[View(Visibility.Hidden)]
	[DisplayName(typeof(__Resources_IEntityFilter), "P_QueryParameters_DisplayName")]
	[PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"PublicApiMethodForBuilder\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">false</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
	QueryParameters QueryParameters { get; }

	bool IsEmpty();
}
