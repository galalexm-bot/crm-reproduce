using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.BPM.Web.Calendar.Models;

public enum EventDuration
{
	[DisplayName("SR.M('30 минут')")]
	HalfHour = 30,
	[DisplayName("SR.M('1 час')")]
	Hour = 60,
	[DisplayName("SR.M('1,5 часа')")]
	HourAndAHalf = 90,
	[DisplayName("SR.M('2 часа')")]
	TwoHours = 120
}
