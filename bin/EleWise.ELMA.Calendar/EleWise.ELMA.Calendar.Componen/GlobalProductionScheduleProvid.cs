using EleWise.ELMA.Calendar.ExtensionPoints;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Calendar.Components;

[Component]
internal class GlobalProductionScheduleProvider : IProductionScheduleProvider
{
	private const int AggregationPriority = 0;

	public ProductionScheduleData GetProductionSchedule(IUser user, IEntity entity)
	{
		return ProductionScheduleDataFactory.CreateByEntity(ResourceCalendarManager.Instance.GetGlobal());
	}
}
