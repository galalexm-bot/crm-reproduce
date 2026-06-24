using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.BPM.Web.Calendar.Models;

public enum ProductionScheduleType
{
	[DisplayName("SR.M('Глобальный')")]
	Global,
	[DisplayName("SR.M('Общий')")]
	Common,
	[DisplayName("SR.M('Личный')")]
	Personal
}
