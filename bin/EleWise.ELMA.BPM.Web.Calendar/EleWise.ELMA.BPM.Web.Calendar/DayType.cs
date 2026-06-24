using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.BPM.Web.Calendar.Models;

public enum DayType
{
	[DisplayName("SR.M('Рабочий')")]
	WorkingDay,
	[DisplayName("SR.M('Выходной')")]
	Holiday,
	[DisplayName("SR.M('Пользовательский')")]
	CustomWorkingDay
}
