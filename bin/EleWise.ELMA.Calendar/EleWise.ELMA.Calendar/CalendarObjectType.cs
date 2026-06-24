using System;

namespace EleWise.ELMA.Calendar;

[Obsolete("Не используется")]
public enum CalendarObjectType
{
	Any = 0,
	CalendarEvent = 1,
	RelationshipCall = 2,
	RelationshipMeeting = 3,
	RelationshipMail = 4,
	Order = 5,
	WFTask = 6,
	OrderControl = 7,
	PrjControlPoint = 11,
	PrjTask = 12,
	DocumentResolution = 13,
	DocumentCreateTasks = 14,
	DocumentHarmonization = 15,
	Question = 17,
	OrderComplex = 18,
	DocumentAcquaintance = 19,
	RepeatOrder = 20,
	RepeatOrderControl = 21
}
