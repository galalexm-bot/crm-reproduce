using System;
using System.Drawing;
using EleWise.ELMA.KPI.Common.Interfaces;
using EleWise.ELMA.KPI.Common.Models;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.KPI.Common.Scales;

public interface IIndicatorScale : IIdentity, IGenericIdentity<Guid>
{
	string Name { get; }

	Image PreviewImage { get; }

	string[] IndicatorProperties { get; }

	IndicatorGrowthDirection IndicatorGrowthDirection { get; }

	ScaleStatus[] GetStatuses();

	ScaleRange GetValueRange(IScaleParams scaleParams);

	ScaleRange GetPlanRange(IScaleParams scaleParams);

	PointState[] GetRangePoints(IScaleParams scaleParams, double? plan);

	ScaleStatus GetStatus(IScaleParamsWithPlanValue scaleParams, double? factValue);

	bool Validate(IScaleParamsWithPlanValue scaleParams, out string errorMessage);

	double? PercentComplete(IScaleParams scaleParams, double? plan, double? fact);

	double[] GetIntervals(IScaleParams scaleParams, double? plan);
}
