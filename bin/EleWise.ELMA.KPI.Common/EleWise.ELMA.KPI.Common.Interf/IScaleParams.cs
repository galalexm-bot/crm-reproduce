using System;
using EleWise.ELMA.KPI.Common.Models;

namespace EleWise.ELMA.KPI.Common.Interfaces;

public interface IScaleParams
{
	double? MinValue { get; set; }

	ScaleValueType MinValueType { get; set; }

	double? MinCriticalValue { get; set; }

	ScaleValueType MinCriticalValueType { get; set; }

	double? MaxCriticalValue { get; set; }

	ScaleValueType MaxCriticalValueType { get; set; }

	double? MaxValue { get; set; }

	ScaleValueType MaxValueType { get; set; }

	double? MinNormalValue { get; set; }

	ScaleValueType MinNormalValueType { get; set; }

	double? MaxNormalValue { get; set; }

	ScaleValueType MaxNormalValueType { get; set; }

	double? MinPerformance { get; set; }

	double? PlanPerformance { get; set; }

	double? MaxPerformance { get; set; }

	[Obsolete]
	double? MaxDeviation { get; set; }
}
