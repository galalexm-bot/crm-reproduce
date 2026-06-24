using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.ExtensionPoints;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Calendar;

[Service(Type = ComponentType.Server)]
public class ProductionCalendarService : IProductionCalendarService
{
	public IProductionSchedule GetProductionSchedule(IUser user, IEntity entity, TZSettings tzSettings)
	{
		IEnumerable<IProductionScheduleProvider> extensionPoints = ComponentManager.Current.GetExtensionPoints<IProductionScheduleProvider>();
		ProductionScheduleData productionScheduleData = extensionPoints.Aggregate(null, delegate(ProductionScheduleData aggregatedProductionSchedule, IProductionScheduleProvider provider)
		{
			ProductionScheduleData productionSchedule = provider.GetProductionSchedule(user, entity);
			aggregatedProductionSchedule = ((aggregatedProductionSchedule == null) ? productionSchedule : aggregatedProductionSchedule.Aggregate(productionSchedule));
			return aggregatedProductionSchedule;
		});
		return new ProductionSchedule(productionScheduleData, tzSettings);
	}

	public IProductionSchedule GetProductionSchedule(IUser user, IEntity entity)
	{
		return GetProductionSchedule(user, entity, null);
	}

	public IProductionSchedule GetGlobalProductionSchedule(TZSettings tzSettings)
	{
		return GetProductionSchedule(null, null, tzSettings);
	}

	public IProductionSchedule GetGlobalProductionSchedule()
	{
		return GetGlobalProductionSchedule(null);
	}

	public bool IsWorkDay(DateTime dateTime)
	{
		IProductionSchedule globalProductionSchedule = GetGlobalProductionSchedule();
		return globalProductionSchedule.IsWorkDay(dateTime);
	}

	public bool IsWorkDay(DateTime dateTime, bool needTransformToClientTimezone)
	{
		IProductionSchedule globalProductionSchedule = GetGlobalProductionSchedule();
		return globalProductionSchedule.IsWorkDay(dateTime, needTransformToClientTimezone);
	}

	public DateTime EvalTargetTime(DateTime startTime, TimeSpan interval)
	{
		IProductionSchedule globalProductionSchedule = GetGlobalProductionSchedule();
		return globalProductionSchedule.EvalTargetTime(startTime, interval);
	}

	public DateTime EvalTargetTime(DateTime startTime, double intervalHours)
	{
		IProductionSchedule globalProductionSchedule = GetGlobalProductionSchedule();
		return globalProductionSchedule.EvalTargetTime(startTime, intervalHours);
	}

	public TimeSpan EvalWorkTimeSpanDifference(DateTime startTime, DateTime endTime)
	{
		IProductionSchedule globalProductionSchedule = GetGlobalProductionSchedule();
		return globalProductionSchedule.EvalWorkTimeSpanDifference(startTime, endTime);
	}

	public TimeSpan EvalWorkTimeDifference(DateTime startTime, DateTime endTime)
	{
		IProductionSchedule globalProductionSchedule = GetGlobalProductionSchedule();
		return globalProductionSchedule.EvalWorkTimeDifference(startTime, endTime);
	}

	public double EvalWorkTimeHoursDifference(DateTime startTime, DateTime endTime)
	{
		IProductionSchedule globalProductionSchedule = GetGlobalProductionSchedule();
		return globalProductionSchedule.EvalWorkTimeHoursDifference(startTime, endTime);
	}

	public TimeSpan GetWorkTimeStart(DateTime day)
	{
		IProductionSchedule globalProductionSchedule = GetGlobalProductionSchedule();
		return globalProductionSchedule.GetWorkTimeStart(day);
	}

	public TimeSpan GetWorkTimeEnd(DateTime day)
	{
		IProductionSchedule globalProductionSchedule = GetGlobalProductionSchedule();
		return globalProductionSchedule.GetWorkTimeEnd(day);
	}

	public TimeSpan GetWorkTimeInDay()
	{
		IProductionSchedule globalProductionSchedule = GetGlobalProductionSchedule();
		return globalProductionSchedule.GetWorkTimeInDay();
	}

	public TimeSpan GetWorkTimeInDay(DateTime day)
	{
		IProductionSchedule globalProductionSchedule = GetGlobalProductionSchedule();
		return globalProductionSchedule.GetWorkTimeInDay(day);
	}

	public long MinutesInDay()
	{
		long num = 1440L;
		try
		{
			num = (long)Math.Floor(GetWorkTimeInDay().TotalMinutes);
			if (num <= 0)
			{
				return 1440L;
			}
		}
		catch (Exception)
		{
		}
		return num;
	}

	public long MinutesInDay(DateTime day)
	{
		long num = 1440L;
		try
		{
			num = (long)Math.Floor(GetWorkTimeInDay(day).TotalMinutes);
			if (num <= 0)
			{
				return 1440L;
			}
		}
		catch (Exception)
		{
		}
		return num;
	}

	public DateTime AddDays(DateTime startTime, int addDays)
	{
		IProductionSchedule globalProductionSchedule = GetGlobalProductionSchedule();
		return globalProductionSchedule.AddDays(startTime, addDays);
	}
}
