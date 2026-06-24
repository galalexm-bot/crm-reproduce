using System;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.KPI.Common.Interfaces;
using EleWise.ELMA.KPI.Common.Models;
using EleWise.ELMA.KPI.Common.Properties;

namespace EleWise.ELMA.KPI.Common.Scales;

public class MaxByPlanIndicatorScale : IndicatorScaleBase
{
	public static readonly MaxByPlanIndicatorScale Instance = new MaxByPlanIndicatorScale();

	private readonly Guid id = new Guid("F80CE70E-8BD1-4073-BE15-66535A2BAE97");

	public override Guid Id => id;

	public override string[] IndicatorProperties => new string[2]
	{
		LinqUtils.NameOf((Expression<Func<IScaleParams, object>>)((IScaleParams i) => i.MinValue)),
		LinqUtils.NameOf((Expression<Func<IScaleParams, object>>)((IScaleParams i) => i.MaxValue))
	};

	public override IndicatorGrowthDirection IndicatorGrowthDirection => IndicatorGrowthDirection.Maximization;

	public override string Name => SR.T("По плану и выше");

	public override Image PreviewImage => Resource.MaxByPlan;

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
		if (object.Equals(plan, num3))
		{
			return 0.0;
		}
		return (num2 - num) * (fact - num3) / (plan - num3) + num;
	}

	public override double[] GetIntervals(IScaleParams scaleParams, double? plan)
	{
		return new double?[3]
		{
			scaleParams.MinValue,
			plan,
			double.PositiveInfinity
		}.Select((double? d) => d ?? 0.0).ToArray();
	}

	public override PointState[] GetRangePoints(IScaleParams scaleParams, double? plan)
	{
		return new PointState[3]
		{
			new PointState
			{
				value = double.NegativeInfinity,
				status = ScaleStatus.Unavailable
			},
			new PointState
			{
				value = plan,
				status = ScaleStatus.Critical
			},
			new PointState
			{
				value = double.PositiveInfinity,
				status = ScaleStatus.Good
			}
		};
	}

	public override ScaleStatus[] GetStatuses()
	{
		return new ScaleStatus[2]
		{
			ScaleStatus.Critical,
			ScaleStatus.Good
		};
	}

	public override bool Validate(IScaleParamsWithPlanValue scaleParams, out string errorMessage)
	{
		if (!base.Validate(scaleParams, out errorMessage))
		{
			return false;
		}
		if (scaleParams.MinValue > scaleParams.PlanValue)
		{
			errorMessage = SR.T("Минимальное значение шкалы не должно быть больше планового значения");
			return false;
		}
		return true;
	}
}
