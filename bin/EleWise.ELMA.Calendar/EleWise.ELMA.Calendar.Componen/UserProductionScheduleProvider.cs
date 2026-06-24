using System.Linq;
using EleWise.ELMA.Calendar.ExtensionPoints;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Calendar.Components;

[Component]
internal class UserProductionScheduleProvider : IProductionScheduleProvider
{
	private const int AggregationPriority = 100;

	public ProductionScheduleData GetProductionSchedule(EleWise.ELMA.Security.IUser user, IEntity entity)
	{
		if (user != null)
		{
			EleWise.ELMA.Security.Models.IUser user2 = (user as EleWise.ELMA.Security.Models.IUser) ?? UserManager.Instance.Load((long)user.GetId());
			IResourceCalendarUserMapFilter resourceCalendarUserMapFilter = InterfaceActivator.Create<IResourceCalendarUserMapFilter>();
			resourceCalendarUserMapFilter.User = user2;
			IResourceCalendarUserMap resourceCalendarUserMap = EntityManager<IResourceCalendarUserMap>.Instance.Find(resourceCalendarUserMapFilter, new FetchOptions(0, 1)).FirstOrDefault();
			if (resourceCalendarUserMap != null && resourceCalendarUserMap.Calendar != null)
			{
				ProductionScheduleData productionScheduleData = ProductionScheduleDataFactory.CreateByEntity(resourceCalendarUserMap.Calendar, 100);
				productionScheduleData.OverridingPowerUp();
				return productionScheduleData;
			}
		}
		return null;
	}
}
