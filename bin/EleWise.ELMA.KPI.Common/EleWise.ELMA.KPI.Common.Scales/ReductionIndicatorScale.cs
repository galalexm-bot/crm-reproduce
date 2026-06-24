using System;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.KPI.Common.Interfaces;
using EleWise.ELMA.KPI.Common.Models;
using EleWise.ELMA.KPI.Common.Properties;

namespace EleWise.ELMA.KPI.Common.Scales;

public class ReductionIndicatorScale : IndicatorScaleBase
{
	public static readonly ReductionIndicatorScale Instance = new ReductionIndicatorScale();

	private Guid id = new Guid("D0EDEF11-EB2A-419f-B818-600754DEF42A");

	public override Guid Id => id;

	public override string[] IndicatorProperties => new string[3]
	{
		LinqUtils.NameOf((Expression<Func<IScaleParams, object>>)((IScaleParams i) => i.MinValue)),
		LinqUtils.NameOf((Expression<Func<IScaleParams, object>>)((IScaleParams i) => i.MaxCriticalValue)),
		LinqUtils.NameOf((Expression<Func<IScaleParams, object>>)((IScaleParams i) => i.MaxValue))
	};

	public override string Name => SR.T("Уменьшение");

	public override Image PreviewImage => Resource.Reduction;

	public override IndicatorGrowthDirection IndicatorGrowthDirection => IndicatorGrowthDirection.Minimization;

	public override double? PercentComplete(IScaleParams scaleParams, double? plan, double? fact)
	{
		if (!plan.HasValue || !fact.HasValue)
		{
			return null;
		}
		if (fact == 0.0 && plan == 0.0)
		{
			return 1.0;
		}
		if (plan == 0.0)
		{
			return base.PercentAtZeroPlanSettings.PercentAtZeroPlan / 100.0;
		}
		double num = (scaleParams.MinPerformance ?? 100.0) / 100.0;
		double num2 = (scaleParams.PlanPerformance ?? 100.0) / 100.0;
		double num3 = (scaleParams.MaxPerformance ?? 0.0) / 100.0;
		double num4 = scaleParams.MaxValue ?? 100.0;
		if (scaleParams.MaxValueType == ScaleValueType.Percent)
		{
			num4 = plan.Value * (1.0 + num4 / 100.0);
		}
		else if (scaleParams.MaxValueType == ScaleValueType.Offset)
		{
			num4 = plan.Value + num4;
		}
		if (fact > plan && object.Equals(num4, plan))
		{
			return 0.0;
		}
		if (fact <= plan && object.Equals(scaleParams.MinValue ?? 0.0, plan))
		{
			return 0.0;
		}
		return Math.Max(0.0, ((!(fact > plan)) ? ((plan - fact) / (plan - (scaleParams.MinValue ?? 0.0)) * (num - num2) + num2) : ((num4 - fact) / (num4 - plan) * (num2 - num3))) ?? 0.0);
	}

	public override double[] GetIntervals(IScaleParams scaleParams, double? plan)
	{
		double? num = scaleParams.MaxCriticalValue;
		if (scaleParams.MaxCriticalValueType == ScaleValueType.Percent)
		{
			num = plan + (plan - scaleParams.MinValue) * scaleParams.MaxCriticalValue / 100.0;
		}
		else if (scaleParams.MaxCriticalValueType == ScaleValueType.Offset)
		{
			num += plan;
		}
		double? num2 = scaleParams.MaxValue;
		if (scaleParams.MaxValueType == ScaleValueType.Percent)
		{
			num2 = plan + (plan - scaleParams.MinValue) * scaleParams.MaxValue / 100.0;
		}
		else if (scaleParams.MaxValueType == ScaleValueType.Offset)
		{
			num2 += plan;
		}
		return new double?[4] { scaleParams.MinValue, plan, num, num2 }.Select((double? d) => d ?? 0.0).ToArray();
	}

	public override PointState[] GetRangePoints(IScaleParams scaleParams, double? plan)
	{
		double? num = scaleParams.MaxCriticalValue;
		if (scaleParams.MaxCriticalValueType == ScaleValueType.Percent)
		{
			num = plan + (plan - scaleParams.MinValue) * scaleParams.MaxCriticalValue / 100.0;
		}
		else if (scaleParams.MaxCriticalValueType == ScaleValueType.Offset)
		{
			num += plan;
		}
		double? num2 = scaleParams.MaxValue;
		if (scaleParams.MaxValueType == ScaleValueType.Percent)
		{
			num2 = plan + (plan - scaleParams.MinValue) * scaleParams.MaxValue / 100.0;
		}
		else if (scaleParams.MaxValueType == ScaleValueType.Offset)
		{
			num2 += plan;
		}
		return new PointState[5]
		{
			new PointState
			{
				value = double.NegativeInfinity,
				status = ScaleStatus.Unavailable
			},
			new PointState
			{
				value = plan,
				status = ScaleStatus.Good
			},
			new PointState
			{
				value = num,
				status = ScaleStatus.Normal
			},
			new PointState
			{
				value = num2,
				status = (num.HasValue ? ScaleStatus.Critical : ScaleStatus.Normal)
			},
			new PointState
			{
				value = double.PositiveInfinity,
				status = ScaleStatus.Critical
			}
		};
	}

	public override bool Validate(IScaleParamsWithPlanValue scaleParams, out string errorMessage)
	{
		if (!base.Validate(scaleParams, out errorMessage))
		{
			return false;
		}
		if (!scaleParams.MaxCriticalValue.HasValue)
		{
			errorMessage = SR.T("Введите максимальное критическое значение шкалы");
			return false;
		}
		if (!scaleParams.MaxValue.HasValue)
		{
			errorMessage = SR.T("Введите максимальное значение шкалы");
			return false;
		}
		if (scaleParams.MinValue > scaleParams.PlanValue)
		{
			errorMessage = SR.T("Минимальное значение шкалы не должно быть больше планового значения");
			return false;
		}
		if (scaleParams.MaxCriticalValueType == ScaleValueType.Value && scaleParams.PlanValue > scaleParams.MaxCriticalValue)
		{
			errorMessage = SR.T("Плановое значение шкалы не должно быть больше максимального критического значения");
			return false;
		}
		if (scaleParams.MaxCriticalValueType == scaleParams.MaxValueType && scaleParams.MaxValue < scaleParams.MaxCriticalValue)
		{
			errorMessage = SR.T("Максимальное значение шкалы не должно быть меньше максимального критического значения");
			return false;
		}
		return true;
	}
}
