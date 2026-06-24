using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Views;

[Uid("c9f10bdc-93bb-45ad-831a-1ff2e63a3ef9")]
[ShowInTypeTree(false)]
[DisplayName(typeof(__Resources_Visibility), "DisplayName")]
[MetadataType(typeof(EnumMetadata))]
[ShowInDesigner(false)]
public enum Visibility
{
	[Uid("1ce934fc-c569-4706-846b-51e682a94db2")]
	[DisplayName(typeof(__Resources_Visibility), "P_Hidden_DisplayName")]
	Hidden,
	[Uid("2b843113-9bf3-42db-b2b7-21259c06ca2b")]
	[DisplayName(typeof(__Resources_Visibility), "P_Visible_DisplayName")]
	Visible,
	[DisplayName(typeof(__Resources_Visibility), "P_ForceHidden_DisplayName")]
	[Uid("44422b3f-ab49-4d2f-852a-0b4815feb1a3")]
	ForceHidden
}
