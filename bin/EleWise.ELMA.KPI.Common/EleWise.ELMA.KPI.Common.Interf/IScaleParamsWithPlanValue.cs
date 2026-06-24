namespace EleWise.ELMA.KPI.Common.Interfaces;

public interface IScaleParamsWithPlanValue : IScaleParams
{
	double? PlanValue { get; set; }
}
