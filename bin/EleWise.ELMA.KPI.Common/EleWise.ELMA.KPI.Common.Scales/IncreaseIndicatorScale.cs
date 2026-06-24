using System;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.KPI.Common.Interfaces;
using EleWise.ELMA.KPI.Common.Models;
using EleWise.ELMA.KPI.Common.Properties;

namespace EleWise.ELMA.KPI.Common.Scales;

public class IncreaseIndicatorScale : IndicatorScaleBase
{
	public static readonly IncreaseIndicatorScale Instance = new IncreaseIndicatorScale();

	private readonly Guid id = new Guid("D9BF4B3C-AB92-40f4-B804-38EFE5155862");

	public override Guid Id => id;

	public override string[] IndicatorProperties => new string[3]
	{
		LinqUtils.NameOf((Expression<Func<IScaleParams, object>>)((IScaleParams i) => i.MinValue)),
		LinqUtils.NameOf((Expression<Func<IScaleParams, object>>)((IScaleParams i) => i.MinCriticalValue)),
		LinqUtils.NameOf((Expression<Func<IScaleParams, object>>)((IScaleParams i) => i.MaxValue))
	};

	public override IndicatorGrowthDirection IndicatorGrowthDirection => IndicatorGrowthDirection.Maximization;

	public override string Name => SR.T("Увеличение");

	public override Image PreviewImage => Resource.Increase;

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
		double num3 = scaleParams.MinValue ?? 0.0;
		if (plan == num3)
		{
			return 0.0;
		}
		return (num2 - num) * (fact - num3) / (plan - num3) + num;
	}

	public override double[] GetIntervals(IScaleParams scaleParams, double? plan)
	{
		double? num = scaleParams.MinCriticalValue;
		if (scaleParams.MinCriticalValueType == ScaleValueType.Percent)
		{
			num = plan + (plan - (scaleParams.MinValue ?? 0.0)) * scaleParams.MinCriticalValue / 100.0;
		}
		else if (scaleParams.MinCriticalValueType == ScaleValueType.Offset)
		{
			num += plan;
		}
		return new double?[4]
		{
			scaleParams.MinValue,
			num,
			plan,
			double.PositiveInfinity
		}.Select((double? d) => d ?? 0.0).ToArray();
	}

	public override PointState[] GetRangePoints(IScaleParams indicator, double? plan)
	{
		double? num = indicator.MinCriticalValue;
		if (indicator.MinCriticalValueType == ScaleValueType.Percent)
		{
			num = plan + (plan - (indicator.MinValue ?? 0.0)) * indicator.MinCriticalValue / 100.0;
		}
		else if (indicator.MinCriticalValueType == ScaleValueType.Offset)
		{
			num += plan;
		}
		return new PointState[4]
		{
			new PointState
			{
				value = double.NegativeInfinity,
				status = ScaleStatus.Unavailable
			},
			new PointState
			{
				value = num,
				status = ScaleStatus.Critical
			},
			new PointState
			{
				value = plan,
				status = ScaleStatus.Normal
			},
			new PointState
			{
				value = double.PositiveInfinity,
				status = ScaleStatus.Good
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
		if (scaleParams.MinCriticalValue > scaleParams.PlanValue)
		{
			errorMessage = SR.T("Минимальное критическое значение шкалы должно быть меньше планового значения");
			return false;
		}
		return true;
	}
}
