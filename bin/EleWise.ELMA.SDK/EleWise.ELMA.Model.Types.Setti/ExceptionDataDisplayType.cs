using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types.Settings;

[MetadataType(typeof(EnumMetadata))]
[Uid("94ec0966-a965-41e2-9f66-e459666e5c32")]
[DisplayName(typeof(__Resources_ExceptionDataDisplayType), "DisplayName")]
public enum ExceptionDataDisplayType
{
	[DisplayName(typeof(__Resources_ExceptionDataDisplayType), "P_simple_DisplayName")]
	[Uid("acbe09a0-f8fc-4c1e-9f98-13671e5d2777")]
	[Description(typeof(__Resources_ExceptionDataDisplayType), "P_simple_Description")]
	simple,
	[DisplayName(typeof(__Resources_ExceptionDataDisplayType), "P_complex_DisplayName")]
	[Description(typeof(__Resources_ExceptionDataDisplayType), "P_complex_Description")]
	[Uid("40d72baa-e376-4c74-af6f-02eb023cd0b4")]
	complex
}
