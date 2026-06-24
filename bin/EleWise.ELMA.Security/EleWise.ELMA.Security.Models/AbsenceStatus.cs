using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Security.Models;

[MetadataType(typeof(EnumMetadata))]
[Description(typeof(__Resources_AbsenceStatus), "Description")]
[DisplayName(typeof(__Resources_AbsenceStatus), "DisplayName")]
[Uid("5af31f82-2104-4d1b-b028-a5996cad46e7")]
public enum AbsenceStatus
{
	[Uid("31ce659b-3c44-4baf-9802-ed7ac8eae908")]
	[DisplayName(typeof(__Resources_AbsenceStatus), "P_Active_DisplayName")]
	Active,
	[DisplayName(typeof(__Resources_AbsenceStatus), "P_Closed_DisplayName")]
	[Uid("3f5a4838-dc59-42df-895b-83b0f8070df9")]
	Closed,
	[Uid("043797c2-b8fa-4cc1-b26a-34486ebae0d3")]
	[DisplayName(typeof(__Resources_AbsenceStatus), "P_Draft_DisplayName")]
	Draft
}
