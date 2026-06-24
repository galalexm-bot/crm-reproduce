using EleWise.ELMA.KPI.Common.Scales;

namespace EleWise.ELMA.KPI.Common.Interfaces;

public interface IScaleUser
{
	IIndicatorScale GetScale();

	bool CanUseScale();
}
