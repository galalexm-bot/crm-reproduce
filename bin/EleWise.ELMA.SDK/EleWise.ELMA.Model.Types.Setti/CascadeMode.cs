using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types.Settings;

[Uid("F231B7D1-9108-4DAC-8822-8A826D05CE4C")]
[DisplayName(typeof(__Resources_CascadeMode), "DisplayName")]
[MetadataType(typeof(EnumMetadata))]
public enum CascadeMode
{
	[DisplayName(typeof(__Resources_CascadeMode), "P_None_DisplayName")]
	[Uid("BAD0DBF3-3FF6-49D2-AFD1-A039A5531C5F")]
	None,
	[Uid("58F6399E-D34F-4185-AA74-6DA970A360D1")]
	[DisplayName(typeof(__Resources_CascadeMode), "P_All_DisplayName")]
	[Description(typeof(__Resources_CascadeMode), "P_All_Description")]
	All,
	[Uid("BB38646B-3C20-485E-8161-31E5C714604F")]
	[DisplayName(typeof(__Resources_CascadeMode), "P_SaveUpdate_DisplayName")]
	SaveUpdate,
	[Uid("438CAE24-19A9-46B0-AB8C-3E5E971029BE")]
	[Description(typeof(__Resources_CascadeMode), "P_AllDeleteOrphan_Description")]
	[DisplayName(typeof(__Resources_CascadeMode), "P_AllDeleteOrphan_DisplayName")]
	AllDeleteOrphan
}
