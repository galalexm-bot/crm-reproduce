using System;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.KPI.Common.Interfaces;
using EleWise.ELMA.KPI.Common.Models;
using EleWise.ELMA.KPI.Common.Properties;

namespace EleWise.ELMA.KPI.Common.Scales;

public class StableIndicatorScale : IndicatorScaleBase
{
	public static readonly StableIndicatorScale Instance = new StableIndicatorScale();

	private readonly Guid id = new Guid("B2BD146F-158F-43ca-B43A-B345DB43AB4D");

	public override Guid Id => id;

	public override string[] IndicatorProperties => new string[5]
	{
		LinqUtils.NameOf((Expression<Func<IScaleParams, object>>)((IScaleParams i) => i.MinValue)),
		LinqUtils.NameOf((Expression<Func<IScaleParams, object>>)((IScaleParams i) => i.MinCriticalValue)),
		LinqUtils.NameOf((Expression<Func<IScaleParams, object>>)((IScaleParams i) => i.MaxDeviation)),
		LinqUtils.NameOf((Expression<Func<IScaleParams, object>>)((IScaleParams i) => i.MaxCriticalValue)),
		LinqUtils.NameOf((Expression<Func<IScaleParams, object>>)((IScaleParams i) => i.MaxValue))
	};

	public override string Name => SR.T("Стабилизация");

	public override Image PreviewImage => Resource.Stable;

	protected StableIndicatorScale()
	{
	}

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
		double num = (scaleParams.MinPerformance ?? 0.0) / 100.0;
		double num2 = (scaleParams.PlanPerformance ?? 100.0) / 100.0;
		double num3 = (scaleParams.MaxPerformance ?? 0.0) / 100.0;
		double num4 = scaleParams.MinValue ?? 0.0;
		double num5 = scaleParams.MaxValue ?? 100.0;
		if (scaleParams.MaxValueType == ScaleValueType.Percent)
		{
			num5 = plan.Value * (100.0 + num5) / 100.0;
		}
		else if (scaleParams.MaxValueType == ScaleValueType.Offset)
		{
			num5 += plan.Value;
		}
		if (object.Equals(plan, num4) || object.Equals(plan, num5))
		{
			return 0.0;
		}
		if (!(fact > plan))
		{
			return (num2 - num) * (fact - num4) / (plan - num4) + num;
		}
		return num2 - (num2 - num3) * (fact - plan) / (num5 - plan);
	}

	public override double[] GetIntervals(IScaleParams scaleParams, double? plan)
	{
		double? num = (plan - scaleParams.MinValue) / 100.0;
		double? num2 = scaleParams.MinCriticalValue;
		if (scaleParams.MinCriticalValueType == ScaleValueType.Percent)
		{
			num2 = plan + num * num2;
		}
		else if (scaleParams.MinCriticalValueType == ScaleValueType.Offset)
		{
			num2 += plan;
		}
		double? num3 = scaleParams.MinNormalValue;
		if (scaleParams.MinNormalValueType == ScaleValueType.Percent)
		{
			num3 = plan + num * num3;
		}
		else if (scaleParams.MinNormalValueType == ScaleValueType.Offset)
		{
			num3 += plan;
		}
		double? num4 = scaleParams.MaxCriticalValue;
		if (scaleParams.MaxCriticalValueType == ScaleValueType.Percent)
		{
			num4 = plan + num * num4;
		}
		else if (scaleParams.MaxCriticalValueType == ScaleValueType.Offset)
		{
			num4 += plan;
		}
		double? num5 = scaleParams.MaxNormalValue;
		if (scaleParams.MaxNormalValueType == ScaleValueType.Percent)
		{
			num5 = plan + num * num5;
		}
		else if (scaleParams.MaxNormalValueType == ScaleValueType.Offset)
		{
			num5 += plan;
		}
		double? num6 = scaleParams.MaxValue;
		if (scaleParams.MaxValueType == ScaleValueType.Percent)
		{
			num6 = plan + (plan - scaleParams.MinValue) * scaleParams.MaxValue / 100.0;
		}
		else if (scaleParams.MaxValueType == ScaleValueType.Offset)
		{
			num6 += plan;
		}
		return new double?[6] { scaleParams.MinValue, num2, num3, num5, num4, num6 }.Select((double? d) => d ?? 0.0).ToArray();
	}

	public override PointState[] GetRangePoints(IScaleParams scaleParams, double? plan)
	{
		double? num = (plan - scaleParams.MinValue) / 100.0;
		double? num2 = scaleParams.MinCriticalValue;
		if (scaleParams.MinCriticalValueType == ScaleValueType.Percent)
		{
			num2 = plan + num * num2;
		}
		else if (scaleParams.MinCriticalValueType == ScaleValueType.Offset)
		{
			num2 += plan;
		}
		double? num3 = scaleParams.MinNormalValue;
		if (scaleParams.MinNormalValueType == ScaleValueType.Percent)
		{
			num3 = plan + num * num3;
		}
		else if (scaleParams.MinNormalValueType == ScaleValueType.Offset)
		{
			num3 += plan;
		}
		double? num4 = scaleParams.MaxCriticalValue;
		if (scaleParams.MaxCriticalValueType == ScaleValueType.Percent)
		{
			num4 = plan + num * num4;
		}
		else if (scaleParams.MaxCriticalValueType == ScaleValueType.Offset)
		{
			num4 += plan;
		}
		double? num5 = scaleParams.MaxNormalValue;
		if (scaleParams.MaxNormalValueType == ScaleValueType.Percent)
		{
			num5 = plan + num * num5;
		}
		else if (scaleParams.MaxNormalValueType == ScaleValueType.Offset)
		{
			num5 += plan;
		}
		return new PointState[6]
		{
			new PointState
			{
				value = double.NegativeInfinity,
				status = null
			},
			new PointState
			{
				value = num2,
				status = ScaleStatus.Critical
			},
			new PointState
			{
				value = num3,
				status = ScaleStatus.Normal
			},
			new PointState
			{
				value = num5,
				status = ScaleStatus.Good
			},
			new PointState
			{
				value = num4,
				status = ScaleStatus.Normal
			},
			new PointState
			{
				value = double.PositiveInfinity,
				status = (num4.HasValue ? ScaleStatus.Critical : ScaleStatus.Normal)
			}
		};
	}

	public override bool Validate(IScaleParamsWithPlanValue scaleParams, out string errorMessage)
	{
		if (!base.Validate(scaleParams, out errorMessage))
		{
			return false;
		}
		if (!scaleParams.MinCriticalValue.HasValue)
		{
			errorMessage = SR.T("Введите минимальное критическое значение шкалы");
			return false;
		}
		if (!scaleParams.MaxCriticalValue.HasValue)
		{
			errorMessage = SR.T("Введите максимальное критическое значение шкалы");
			return false;
		}
		if (scaleParams.MinCriticalValueType == ScaleValueType.Value && scaleParams.MinCriticalValue < scaleParams.MinValue)
		{
			errorMessage = SR.T("Минимальное критическое значение шкалы должно быть больше минимального значения");
			return false;
		}
		if (scaleParams.MinCriticalValueType == ScaleValueType.Offset && scaleParams.PlanValue + scaleParams.MinCriticalValue < scaleParams.MinValue)
		{
			errorMessage = SR.T("Минимальное критическое значение шкалы должно быть больше минимального значения");
			return false;
		}
		if (scaleParams.MaxCriticalValue > scaleParams.MaxValue)
		{
			errorMessage = SR.T("Максимальное критическое значение шкалы должно быть меньше максимального значения");
			return false;
		}
		return true;
	}
}
