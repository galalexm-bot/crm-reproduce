using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Types.Settings;

namespace EleWise.ELMA.Security.Models;

[FilterFor(typeof(IUser))]
public interface IUserFilter : IEntityFilter
{
	string UserName { get; set; }

	string FirstName { get; set; }

	string MiddleName { get; set; }

	string LastName { get; set; }

	string EMail { get; set; }

	DateTimeRange BirthDate { get; set; }

	DateTimeRange EmployDate { get; set; }

	string WorkPhone { get; set; }

	string MobilePhone { get; set; }

	string RoomNumber { get; set; }

	string Skype { get; set; }

	string ICQ { get; set; }

	string JabberID { get; set; }

	Guid? AuthProviderGuid { get; set; }

	[Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e502f586-afd4-4f55-bedb-f71028ffd302")]
	[Uid("b0b9d3a7-d192-44c3-b4f4-0cd1cff30eab")]
	[DisplayName(typeof(__Resources_IUser), "FP_OrganizationItem_DisplayName")]
	[CustomFilterProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[OrganizationItemSettings(FieldName = "OrganizationItem")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	IOrganizationItem OrganizationItem { get; set; }

	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IUser), "FP_Workers_DisplayName")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[CustomFilterProperty]
	[Order(1)]
	[Uid("fc6fe5f1-bab3-40cc-b7dc-223bae1f5451")]
	[AnyTypeSettings(FullTypeName = "System.Collections.Generic.List<EleWise.ELMA.Security.Models.Worker>")]
	[Property("c77cd813-1dfb-4777-ab7e-87b54bd09e38")]
	List<Worker> Workers { get; set; }

	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Description(typeof(__Resources_IUser), "FP_ShowBlock_Description")]
	[DisplayName(typeof(__Resources_IUser), "FP_ShowBlock_DisplayName")]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Order(2)]
	[Uid("45afd2a7-23bf-4803-9eed-fdf060563641")]
	[CustomFilterProperty]
	[BoolSettings(FieldName = "ShowBlock")]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[NotNull]
	bool ShowBlock { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Order(3)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IUser), "FP_ShowOnlyReplacement_DisplayName")]
	[CustomFilterProperty]
	[Uid("e3d9875e-1c0b-4715-b84a-b5e18e4946da")]
	[NotNull]
	[BoolSettings(FieldName = "ShowOnlyReplacement")]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	bool ShowOnlyReplacement { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[CustomFilterProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DisplayName(typeof(__Resources_IUser), "FP_OrganizationItemFindMode_DisplayName")]
	[Order(4)]
	[Uid("239dc1d7-101a-4a98-a4a2-659531fc9b27")]
	[NotNull]
	[EnumSettings(DefaultValueStr = "48ff3773-ca34-4476-97a2-3e82b874c891", FieldName = "OrganizationItemFindMode")]
	[Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "da2d0b29-7b1c-4e2b-b0f0-9675da93e54d")]
	OrganizationItemFindMode OrganizationItemFindMode { get; set; }

	[DisplayName(typeof(__Resources_IUser), "FP_ShowOnlySubordinate_DisplayName")]
	[BoolSettings(FieldName = "ShowOnlySubordinate")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[CustomFilterProperty]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Uid("f9ad0e41-2f65-43c3-b92f-eae02c78a339")]
	[NotNull]
	[Order(5)]
	bool ShowOnlySubordinate { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[CustomFilterProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[NotNull]
	[Order(6)]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[DisplayName(typeof(__Resources_IUser), "FP_ShowOnlySubordinateAndSelf_DisplayName")]
	[BoolSettings(FieldName = "ShowOnlySubordinateAndSelf")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[Uid("99684bab-79b8-4815-aac4-6700684d6d66")]
	bool ShowOnlySubordinateAndSelf { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Property("5c281e64-ddc8-4bc9-991a-84d9dc4e7649")]
	[Order(7)]
	[CustomFilterProperty]
	[Uid("6e4a9815-5d59-46c9-addb-8c4c2c7be054")]
	[DisplayName(typeof(__Resources_IUser), "FP_OrganizationItemIds_DisplayName")]
	[ListOfSimpleTypeSettings(SimpleTypeUidStr = "d90a59af-7e47-48c5-8c4c-dad04834e6e3", FieldName = "OrganizationItemIds")]
	List<long> OrganizationItemIds { get; set; }

	[Sortable(false)]
	[DisplayName(typeof(__Resources_IUser), "FP_UserIds_DisplayName")]
	[ListOfSimpleTypeSettings(SimpleTypeUidStr = "d90a59af-7e47-48c5-8c4c-dad04834e6e3", FieldName = "UserIds")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[CustomFilterProperty]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Property("5c281e64-ddc8-4bc9-991a-84d9dc4e7649")]
	[Order(8)]
	[Uid("9cfcb0dd-f9b0-46e0-bed1-1cc3aed4ad5b")]
	List<long> UserIds { get; set; }

	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[DateTimeSettings(FieldName = "YearlyBirthDate")]
	[DisplayName(typeof(__Resources_IUser), "FP_YearlyBirthDate_DisplayName")]
	[Property("6fbbca7c-a693-4791-902c-30b5984671a2")]
	[Order(9)]
	[CustomFilterProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[Uid("c7b40f52-00f2-4aca-b2b7-a40760f8b7de")]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	DateTimeRange YearlyBirthDate { get; set; }
}
