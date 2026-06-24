using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Calendar.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("7957c8d6-40a7-4db7-87c7-655bfb23b62e")]
[DisplayName(typeof(__Resources_CalendarEventUserStatus), "DisplayName")]
[Description(typeof(__Resources_CalendarEventUserStatus), "Description")]
public enum CalendarEventUserStatus
{
	[Uid("fe4642e7-5ade-4185-9483-333ca45ec877")]
	[DisplayName(typeof(__Resources_CalendarEventUserStatus), "P_Participant_DisplayName")]
	Participant,
	[Uid("55777128-a739-40f3-8877-bccb24bffb51")]
	[DisplayName(typeof(__Resources_CalendarEventUserStatus), "P_InfromTo_DisplayName")]
	InfromTo
}
