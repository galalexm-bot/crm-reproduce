using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class ScoringStepPropertyModel
{
	[DisplayName("SR.M('Идентификатор')")]
	public long Id { get; set; }

	[DisplayName("SR.M('Тип сущности')")]
	public Guid TypeUid { get; set; }

	[DisplayName("SR.M('Является ли шаг новым')")]
	public bool IsNew { get; set; }

	[Required(true)]
	[DisplayName("SR.M('Цвет уведомления')")]
	public IColor Color { get; set; }

	[DisplayName("SR.M('Значение в процентах')")]
	public long PercentValue { get; set; }
}
