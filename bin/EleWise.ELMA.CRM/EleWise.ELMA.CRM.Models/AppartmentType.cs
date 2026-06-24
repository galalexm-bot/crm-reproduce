using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("10b87a5f-11f0-4b2c-83d6-87a0c756706b")]
[DisplayName(typeof(__Resources_AppartmentType), "DisplayName")]
[DefaultValueUid("1b88d54b-9400-4153-8943-2a7753359c40")]
public enum AppartmentType
{
	[Uid("1b88d54b-9400-4153-8943-2a7753359c40")]
	[DisplayName(typeof(__Resources_AppartmentType), "P_Appartment_DisplayName")]
	Appartment,
	[Uid("3d273f5e-7f62-40b1-baff-15f124e0a3b7")]
	[DisplayName(typeof(__Resources_AppartmentType), "P_Office_DisplayName")]
	Office,
	[Uid("b918b276-797d-44a6-9846-bedfb2e65167")]
	[DisplayName(typeof(__Resources_AppartmentType), "P_Hall_DisplayName")]
	Hall,
	[Uid("3a8c3409-95b2-4479-85e9-088d99e6fa67")]
	[DisplayName(typeof(__Resources_AppartmentType), "P_Room_DisplayName")]
	Room,
	[Uid("77d30726-1232-454c-bb67-24102f29e2c3")]
	[DisplayName(typeof(__Resources_AppartmentType), "P_Cabinet_DisplayName")]
	Cabinet,
	[Uid("e00464a6-898a-448e-a422-354a9d122b73")]
	[DisplayName(typeof(__Resources_AppartmentType), "P_POBox_DisplayName")]
	POBox
}
