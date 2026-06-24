using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Calendar.Extensions;
using EleWise.ELMA.BPM.Web.Calendar.Models;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Projects.Models.Resources;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Serialization;
using Newtonsoft.Json.Linq;

namespace EleWise.ELMA.BPM.Web.Calendar.Services;

[Service(Scope = ServiceScope.Shell)]
internal sealed class ProductionScheduleConfigService : IProductionScheduleConfigService
{
	private ResourceCalendarManager resourceCalendarManager;

	private IUnitOfWorkManager unitOfWorkManager;

	public ProductionScheduleConfigService(ResourceCalendarManager resourceCalendarManager, IUnitOfWorkManager unitOfWorkManager)
	{
		this.resourceCalendarManager = resourceCalendarManager;
		this.unitOfWorkManager = unitOfWorkManager;
	}

	public string GetResourceCalendarJson(IResourceCalendar resourceCalendar)
	{
		Contract.ArgumentNotNull(resourceCalendar, "resourceCalendar");
		ProductionScheduleConfigModel productionScheduleConfigModel = new ProductionScheduleConfigModel(resourceCalendar);
		productionScheduleConfigModel.InitializeMode(takeWeekDayIntervalCollection: true, takeExceptionalDayIntervalCollection: false);
		CalendarConfigModel model = new CalendarConfigModel
		{
			Config = new ProductionScheduleSimpleConfigModel(productionScheduleConfigModel),
			BaseConfig = productionScheduleConfigModel.BaseConfigDataModel,
			WeekDayCollection = productionScheduleConfigModel.WeekDayCollectionConfigDataModel,
			Monday = productionScheduleConfigModel.WeekDayConfigModelCollection.First((ConfigDataModel x) => x.DayOfWeek == DayOfWeek.Monday),
			Tuesday = productionScheduleConfigModel.WeekDayConfigModelCollection.First((ConfigDataModel x) => x.DayOfWeek == DayOfWeek.Tuesday),
			Wednesday = productionScheduleConfigModel.WeekDayConfigModelCollection.First((ConfigDataModel x) => x.DayOfWeek == DayOfWeek.Wednesday),
			Thursday = productionScheduleConfigModel.WeekDayConfigModelCollection.First((ConfigDataModel x) => x.DayOfWeek == DayOfWeek.Thursday),
			Friday = productionScheduleConfigModel.WeekDayConfigModelCollection.First((ConfigDataModel x) => x.DayOfWeek == DayOfWeek.Friday),
			Saturday = productionScheduleConfigModel.WeekDayConfigModelCollection.First((ConfigDataModel x) => x.DayOfWeek == DayOfWeek.Saturday),
			Sunday = productionScheduleConfigModel.WeekDayConfigModelCollection.First((ConfigDataModel x) => x.DayOfWeek == DayOfWeek.Sunday)
		};
		return SerializeToFlatJSON(model);
	}

	public IResourceCalendar GetResourceCalendar(CalendarConfigModel model)
	{
		CheckModel(model);
		IResourceCalendar productionSchedule = (model.Config.Entity.IsNew() ? model.Config.Entity : resourceCalendarManager.Load(model.Config.Entity.Id));
		productionSchedule.Name = model.Config.Entity.Name;
		if (model.Config.Entity.IsNew())
		{
			productionSchedule.IsCatalog = model.Config.Entity.IsCatalog ?? (productionSchedule.Uid != CalendarConstants.GlobalProductionScheduleEntityUid);
		}
		List<ConfigDataModel> list = (from cm in ConfigDataModelFactory.CreateExceptionalDayConfigDataCollection(productionSchedule)
			where cm.DayType == DayType.WorkingDay
			select cm).ToList();
		List<IBaseTimeInterval> baseTimeIntervalCollection = (from bi in ConfigDataModelExtension.BaseTimeIntervalCollectionDeserialize(model.BaseConfig.JsonBaseTimeIntervalCollection)
			orderby bi.Start
			select bi).ToList();
		List<IWorkTimeInterval> weekDayCollectionTimeIntervalCollection = ConfigDataModelExtension.WorkingTimeIntervalCollectionDeserialize(model.WeekDayCollection.JsonWorkingTimeIntervalCollection).ToList();
		if (model.Config.SimpleModeEnable)
		{
			baseTimeIntervalCollection = GetUpdatedBaseTimeIntervalCollection(model.BaseConfig, baseTimeIntervalCollection.OrderBy((IBaseTimeInterval bi) => bi.Start).ToList()).ToList();
			IEnumerable<IGrouping<int?, IWorkTimeInterval>> weekDayTimeIntervalCollectionGroups = from wi in weekDayCollectionTimeIntervalCollection
				group wi by wi.DayOfWeek;
			weekDayCollectionTimeIntervalCollection = new List<IWorkTimeInterval>();
			model.Days.ForEach(delegate(ConfigDataModel cm)
			{
				if (cm.DayOfWeek.HasValue)
				{
					IEnumerable<IWorkTimeInterval> updatedWeekDayTimeIntervalCollection = GetUpdatedWeekDayTimeIntervalCollection(cm, weekDayTimeIntervalCollectionGroups.SelectMany((IGrouping<int?, IWorkTimeInterval> g) => g), baseTimeIntervalCollection);
					weekDayCollectionTimeIntervalCollection.AddRange(updatedWeekDayTimeIntervalCollection);
				}
			});
		}
		((IEnumerable<IBaseTimeInterval>)productionSchedule.BaseIntervals).Where((IBaseTimeInterval bi) => !baseTimeIntervalCollection.Contains(bi)).ToList().ForEach(delegate(IBaseTimeInterval bi)
		{
			((ICollection<IBaseTimeInterval>)productionSchedule.BaseIntervals).Remove(bi);
			bi.Delete();
		});
		baseTimeIntervalCollection.ForEach(delegate(IBaseTimeInterval bi)
		{
			if (bi.IsNew())
			{
				bi.Id = 0L;
				bi.Calendar = productionSchedule;
				productionSchedule.BaseIntervals.Add(bi);
			}
		});
		((IEnumerable<IWorkTimeInterval>)productionSchedule.WorkIntervals).Where((IWorkTimeInterval wi) => wi.DayOfWeek.HasValue && !wi.DateExceptionStart.HasValue && !wi.DateExceptionFinish.HasValue && !weekDayCollectionTimeIntervalCollection.Contains(wi)).ToList().ForEach(delegate(IWorkTimeInterval wi)
		{
			((ICollection<IWorkTimeInterval>)productionSchedule.WorkIntervals).Remove(wi);
			wi.Delete();
		});
		weekDayCollectionTimeIntervalCollection.ForEach(delegate(IWorkTimeInterval wi)
		{
			if (wi.IsNew())
			{
				wi.Id = 0L;
				wi.Calendar = productionSchedule;
				productionSchedule.WorkIntervals.Add(wi);
			}
		});
		foreach (ConfigDataModel item in list)
		{
			List<IWorkTimeInterval> list2 = ConfigDataModelExtension.NormalizeIntervalCollectionForUpdate(item.WorkingTimeIntervals, ((ICollection<IBaseTimeInterval>)productionSchedule.BaseIntervals).Count).ToList();
			for (int i = 0; i < ((ICollection<IBaseTimeInterval>)productionSchedule.BaseIntervals).Count; i++)
			{
				IWorkTimeInterval workTimeInterval = list2[i];
				IBaseTimeInterval baseTimeInterval = baseTimeIntervalCollection[i];
				workTimeInterval.DayOfWeek = null;
				workTimeInterval.Start = baseTimeInterval.Start;
				workTimeInterval.Finish = baseTimeInterval.Finish;
				workTimeInterval.DateExceptionStart = item.ExceptionalDate;
				workTimeInterval.DateExceptionFinish = item.ExceptionalDate;
				if (workTimeInterval.IsNew())
				{
					workTimeInterval.Calendar = productionSchedule;
					productionSchedule.WorkIntervals.Add(workTimeInterval);
				}
			}
		}
		if (!resourceCalendarManager.CanSave(productionSchedule).Result)
		{
			unitOfWorkManager.RollbackCurrent(string.Empty);
			throw new Exception(SR.T("Ошибка валидации при сохранении производственного календаря"));
		}
		productionSchedule.Save();
		return productionSchedule;
	}

	public IEnumerable<IBaseTimeInterval> GetUpdatedBaseTimeIntervalCollection(ConfigDataModel baseConfig, IEnumerable<IBaseTimeInterval> baseTimeIntervalCollection)
	{
		List<IBaseTimeInterval> list = new List<IBaseTimeInterval>();
		List<IBaseTimeInterval> list2 = baseTimeIntervalCollection.ToList();
		if (baseConfig != null)
		{
			if (baseConfig.WithBreakTime)
			{
				IBaseTimeInterval baseTimeInterval2;
				IBaseTimeInterval baseTimeInterval3;
				if (list2.Count >= 2)
				{
					while (list2.Count > 2)
					{
						IBaseTimeInterval baseTimeInterval = list2.FirstOrDefault((IBaseTimeInterval bi) => bi.Id <= 0);
						if (baseTimeInterval != null)
						{
							list2.Remove(baseTimeInterval);
						}
						else
						{
							list2 = list2.Take(list2.Count - 1).ToList();
						}
					}
					baseTimeInterval2 = list2.First();
					baseTimeInterval3 = list2.Last();
				}
				else if (list2.Any())
				{
					baseTimeInterval2 = list2.First();
					baseTimeInterval3 = InterfaceActivator.Create<IBaseTimeInterval>();
				}
				else
				{
					baseTimeInterval2 = InterfaceActivator.Create<IBaseTimeInterval>();
					baseTimeInterval3 = InterfaceActivator.Create<IBaseTimeInterval>();
				}
				baseTimeInterval2.Start = baseConfig.WorkingTimeStart;
				baseTimeInterval2.Finish = baseConfig.BreakTimeStart;
				baseTimeInterval3.Start = baseConfig.BreakTimeEnd;
				baseTimeInterval3.Finish = baseConfig.WorkingTimeEnd;
				list.Add(baseTimeInterval2);
				list.Add(baseTimeInterval3);
			}
			else
			{
				IBaseTimeInterval baseTimeInterval5;
				if (list2.Any())
				{
					while (list2.Count > 1)
					{
						IBaseTimeInterval baseTimeInterval4 = list2.FirstOrDefault((IBaseTimeInterval bi) => bi.Id <= 0);
						if (baseTimeInterval4 != null)
						{
							list2.Remove(baseTimeInterval4);
						}
						else
						{
							list2 = list2.Take(list2.Count - 1).ToList();
						}
					}
					baseTimeInterval5 = list2.First();
				}
				else
				{
					baseTimeInterval5 = InterfaceActivator.Create<IBaseTimeInterval>();
				}
				baseTimeInterval5.Start = baseConfig.WorkingTimeStart;
				baseTimeInterval5.Finish = baseConfig.WorkingTimeEnd;
				list.Add(baseTimeInterval5);
			}
		}
		return list;
	}

	public IEnumerable<IWorkTimeInterval> GetUpdatedWeekDayTimeIntervalCollection(ConfigDataModel configDataModel, IEnumerable<IWorkTimeInterval> workingTimeIntervals, IEnumerable<IBaseTimeInterval> baseTimeIntervals)
	{
		if (configDataModel == null)
		{
			return workingTimeIntervals ?? new List<IWorkTimeInterval>();
		}
		List<IWorkTimeInterval> list = new List<IWorkTimeInterval>();
		if (configDataModel.DayOfWeek.HasValue)
		{
			int denormalizedIndex = configDataModel.DayOfWeek.Value.GetWorkTimeIntervalDayOfWeek();
			List<IWorkTimeInterval> list2 = ((workingTimeIntervals == null) ? new List<IWorkTimeInterval>() : (from wti in workingTimeIntervals
				where wti.DayOfWeek.HasValue && !wti.DateExceptionStart.HasValue && !wti.DateExceptionFinish.HasValue && wti.DayOfWeek.Value == denormalizedIndex
				orderby wti.Start
				select wti).ToList());
			List<IBaseTimeInterval> list3 = ((baseTimeIntervals == null) ? new List<IBaseTimeInterval>() : baseTimeIntervals.ToList());
			if (configDataModel.DayType == DayType.WorkingDay)
			{
				list2 = ConfigDataModelExtension.NormalizeIntervalCollectionForUpdate(list2, list3.Count).ToList();
				for (int i = 0; i < list3.Count; i++)
				{
					IWorkTimeInterval workTimeInterval = list2[i];
					IBaseTimeInterval baseTimeInterval = list3[i];
					workTimeInterval.DayOfWeek = configDataModel.DayOfWeek.Value.GetWorkTimeIntervalDayOfWeek();
					workTimeInterval.Start = baseTimeInterval.Start;
					workTimeInterval.Finish = baseTimeInterval.Finish;
					workTimeInterval.DateExceptionStart = null;
					workTimeInterval.DateExceptionFinish = null;
					list.Add(workTimeInterval);
				}
			}
			if (configDataModel.DayType == DayType.Holiday)
			{
				return new List<IWorkTimeInterval>();
			}
			if (configDataModel.DayType == DayType.CustomWorkingDay)
			{
				list2 = ConfigDataModelExtension.NormalizeIntervalCollectionForUpdate(list2, (!configDataModel.WithBreakTime) ? 1 : 2).ToList();
				if (configDataModel.WithBreakTime)
				{
					IWorkTimeInterval workTimeInterval2 = list2.First();
					IWorkTimeInterval workTimeInterval3 = list2.Last();
					workTimeInterval2.DayOfWeek = configDataModel.DayOfWeek.Value.GetWorkTimeIntervalDayOfWeek();
					workTimeInterval2.Start = configDataModel.WorkingTimeStart;
					workTimeInterval2.Finish = configDataModel.BreakTimeStart;
					workTimeInterval2.DateExceptionStart = null;
					workTimeInterval2.DateExceptionFinish = null;
					workTimeInterval3.DayOfWeek = configDataModel.DayOfWeek.Value.GetWorkTimeIntervalDayOfWeek();
					workTimeInterval3.Start = configDataModel.BreakTimeEnd;
					workTimeInterval3.Finish = configDataModel.WorkingTimeEnd;
					workTimeInterval3.DateExceptionStart = null;
					workTimeInterval3.DateExceptionFinish = null;
					list.Add(workTimeInterval2);
					list.Add(workTimeInterval3);
				}
				else
				{
					IWorkTimeInterval workTimeInterval4 = list2.First();
					workTimeInterval4.DayOfWeek = configDataModel.DayOfWeek.Value.GetWorkTimeIntervalDayOfWeek();
					workTimeInterval4.Start = configDataModel.WorkingTimeStart;
					workTimeInterval4.Finish = configDataModel.WorkingTimeEnd;
					workTimeInterval4.DateExceptionStart = null;
					workTimeInterval4.DateExceptionFinish = null;
					list.Add(workTimeInterval4);
				}
			}
		}
		return list;
	}

	private string SerializeToFlatJSON(CalendarConfigModel model)
	{
		Dictionary<string, string> obj = (from t in ((JToken)JObject.FromObject((object)model)).SelectTokens("$..*")
			where !t.get_HasValues()
			select t).ToDictionary((JToken t) => t.get_Path(), (JToken t) => ((object)t).ToString());
		return new JsonSerializer().Serialize(obj);
	}

	private void CheckModel(CalendarConfigModel model)
	{
		Contract.ArgumentNotNull(model, "model");
		Contract.NotNull(model.Config, "model.Config");
		Contract.NotNull(model.Config.Entity, "model.Config.Entity");
		Contract.NotNull(model.BaseConfig, "model.BaseConfig");
		Contract.NotNull(model.WeekDayCollection, "model.WeekDayCollection");
	}
}
