using System;
using System.Drawing;
using System.Linq;
using EleWise.ELMA.KPI.Common.Extensions;
using EleWise.ELMA.KPI.Common.Interfaces;
using EleWise.ELMA.KPI.Common.Models;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.KPI.Common.Scales;

public abstract class IndicatorScaleBase : IIndicatorScale, IIdentity, IGenericIdentity<Guid>
{
	private static ScaleStatus[] scaleStatuses = new ScaleStatus[3]
	{
		ScaleStatus.Critical,
		ScaleStatus.Normal,
		ScaleStatus.Good
	};

	public abstract Guid Id { get; }

	public PercentAtZeroPlanSettingsExtension PercentAtZeroPlanSettings => PercentAtZeroPlanSettingsExtension.Instance;

	public abstract string[] IndicatorProperties { get; }

	public abstract string Name { get; }

	public abstract Image PreviewImage { get; }

	public virtual IndicatorGrowthDirection IndicatorGrowthDirection => IndicatorGrowthDirection.Normal;

	public abstract PointState[] GetRangePoints(IScaleParams scaleParams, double? plan);

	public virtual double? PercentComplete(IScaleParams scaleParams, double? plan, double? fact)
	{
		return null;
	}

	public virtual double[] GetIntervals(IScaleParams scaleParams, double? plan)
	{
		return new double[0];
	}

	public virtual ScaleRange GetPlanRange(IScaleParams scaleParams)
	{
		GetValueRange(scaleParams);
		return new ScaleRange(scaleParams.MinValue ?? double.NegativeInfinity, scaleParams.MaxValue ?? double.PositiveInfinity, ScaleStatus.Unavailable);
	}

	public virtual ScaleRange GetValueRange(IScaleParams scaleParams)
	{
		return new ScaleRange(scaleParams.MinValue ?? double.NegativeInfinity, scaleParams.MaxValue ?? double.PositiveInfinity, ScaleStatus.Unavailable);
	}

	public ScaleStatus GetStatus(IScaleParamsWithPlanValue scaleParams, double? factValue)
	{
		if (!factValue.HasValue)
		{
			return ScaleStatus.Unavailable;
		}
		PointState[] rangePoints = GetRangePoints(scaleParams, scaleParams.PlanValue);
		if (rangePoints == null || !rangePoints.Any())
		{
			return ScaleStatus.Unavailable;
		}
		if (factValue < rangePoints.First().value || rangePoints.Count() == 1)
		{
			return rangePoints.First().status ?? ScaleStatus.Unavailable;
		}
		if (factValue > rangePoints.Last().value)
		{
			return rangePoints.Last().status ?? ScaleStatus.Unavailable;
		}
		PointState pointState = rangePoints.FirstOrDefault((PointState r) => factValue < r.value);
		if (pointState == null)
		{
			return ScaleStatus.Unavailable;
		}
		return pointState.status ?? ScaleStatus.Unavailable;
	}

	public virtual ScaleStatus[] GetStatuses()
	{
		return scaleStatuses;
	}

	public virtual bool Validate(IScaleParamsWithPlanValue scaleParams, out string errorMessage)
	{
		errorMessage = string.Empty;
		return true;
	}
}
