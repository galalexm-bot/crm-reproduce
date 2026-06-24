using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Calendar.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IProductionScheduleProvider
{
	ProductionScheduleData GetProductionSchedule(IUser user, IEntity entity);
}
