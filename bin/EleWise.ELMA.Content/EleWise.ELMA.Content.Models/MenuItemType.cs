using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Content.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("0ec4bd65-b1da-4975-a630-1b21d515ca38")]
[DisplayName(typeof(__Resources_MenuItemType), "DisplayName")]
[Description(typeof(__Resources_MenuItemType), "Description")]
public enum MenuItemType
{
	[Uid("25c006c0-2ab4-4d16-b072-55887644a679")]
	[DisplayName(typeof(__Resources_MenuItemType), "P_Action_DisplayName")]
	[Description(typeof(__Resources_MenuItemType), "P_Action_Description")]
	Action,
	[Uid("f2e12f36-a7eb-44c8-b959-025612761120")]
	[DisplayName(typeof(__Resources_MenuItemType), "P_Section_DisplayName")]
	[Description(typeof(__Resources_MenuItemType), "P_Section_Description")]
	Section,
	[Uid("a3a780e8-75b1-4d9a-81a4-8dfabae4054f")]
	[DisplayName(typeof(__Resources_MenuItemType), "P_Separator_DisplayName")]
	[Description(typeof(__Resources_MenuItemType), "P_Separator_Description")]
	Separator
}
