using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EleWise.ELMA.BPM.Web.Calendar.Extensions;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Projects.Models.Resources;

namespace EleWise.ELMA.BPM.Web.Calendar.Models;

public class ProductionScheduleConfigModel
{
	public IResourceCalendar Entity { get; set; }

	public bool IsGlobalProductionSchedule { get; private set; }

	public ConfigDataModel BaseConfigDataModel { get; private set; }

	public ConfigDataModel WeekDayCollectionConfigDataModel { get; set; }

	public IEnumerable<ConfigDataModel> WeekDayConfigModelCollection { get; private set; }

	public ConfigDataModel ExceptionalDayCollectionConfigDataModel { get; set; }

	public IEnumerable<ConfigDataModel> ExceptionalDayConfigModelCollection { get; private set; }

	public bool SimpleModeEnable { get; set; }

	public string StringUid { get; set; }

	public bool InJsonFormat { get; set; }

	public ProductionScheduleConfigModel()
	{
	}

	public ProductionScheduleConfigModel(IResourceCalendar productionSchedule)
		: this(productionSchedule, string.Empty)
	{
	}

	public ProductionScheduleConfigModel(IResourceCalendar productionSchedule, string uid)
	{
		if (productionSchedule == null)
		{
			throw new ArgumentNullException("productionSchedule");
		}
		if (productionSchedule.BaseIntervals == null || !((IEnumerable<IBaseTimeInterval>)productionSchedule.BaseIntervals).Any())
		{
			throw new ArgumentException(SR.T("Коллекция базовых интервалов пуста"));
		}
		Entity = productionSchedule;
		StringUid = uid;
		long baseTimeIntervalNegativeId = ((IEnumerable<IBaseTimeInterval>)Entity.BaseIntervals).Min((IBaseTimeInterval bi) => bi.Id);
		baseTimeIntervalNegativeId = ((baseTimeIntervalNegativeId > 0) ? 0 : baseTimeIntervalNegativeId);
		((IEnumerable<IBaseTimeInterval>)Entity.BaseIntervals).Where((IBaseTimeInterval bi) => bi.Id == 0).ForEach(delegate(IBaseTimeInterval bi)
		{
			bi.Id = --baseTimeIntervalNegativeId;
		});
		long workingTimeIntervalNegativeId = (((IEnumerable<IWorkTimeInterval>)Entity.WorkIntervals).Any() ? ((IEnumerable<IWorkTimeInterval>)Entity.WorkIntervals).Min((IWorkTimeInterval bi) => bi.Id) : 0);
		workingTimeIntervalNegativeId = ((workingTimeIntervalNegativeId > 0) ? 0 : workingTimeIntervalNegativeId);
		((IEnumerable<IWorkTimeInterval>)Entity.WorkIntervals).Where((IWorkTimeInterval wi) => wi.Id == 0).ForEach(delegate(IWorkTimeInterval wi)
		{
			wi.Id = --workingTimeIntervalNegativeId;
		});
		IsGlobalProductionSchedule = productionSchedule.Uid == CalendarConstants.GlobalProductionScheduleEntityUid;
		BaseConfigDataModel = new ConfigDataModel((IEnumerable<IBaseTimeInterval>)productionSchedule.BaseIntervals, uid);
		WeekDayCollectionConfigDataModel = ConfigDataModelFactory.CreateWeekDayCollectionConfigModel(productionSchedule, uid);
		WeekDayConfigModelCollection = ConfigDataModelFactory.CreateWeekDayConfigDataCollection(productionSchedule, uid);
		ExceptionalDayCollectionConfigDataModel = ConfigDataModelFactory.CreateExceptionalDayCollectionConfigModel(productionSchedule, uid);
		ExceptionalDayConfigModelCollection = ConfigDataModelFactory.CreateExceptionalDayConfigDataCollection(productionSchedule, uid);
	}

	public ProductionScheduleConfigModel(CalendarConfigModel model, string uid)
	{
		StringUid = uid;
		Entity = model.Config.Entity;
		SimpleModeEnable = model.Config.SimpleModeEnable;
		IsGlobalProductionSchedule = model.Config.IsGlobalProductionSchedule;
		InJsonFormat = model.Config.InJsonFormat;
		BaseConfigDataModel = model.BaseConfig;
		BaseConfigDataModel.BaseTimeIntervals = (from bi in ConfigDataModelExtension.BaseTimeIntervalCollectionDeserialize(model.BaseConfig.JsonBaseTimeIntervalCollection)
			orderby bi.Start
			select bi).ToList();
		FillInConfigDataModel(BaseConfigDataModel, "BaseConfig");
		WeekDayCollectionConfigDataModel = model.WeekDayCollection;
		WeekDayCollectionConfigDataModel.WorkingTimeIntervals = ConfigDataModelExtension.WorkingTimeIntervalCollectionDeserialize(model.WeekDayCollection.JsonWorkingTimeIntervalCollection).ToList();
		FillInConfigDataModel(WeekDayCollectionConfigDataModel, "WeekDayCollection");
		int cultureFirstDay = (int)CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek;
		WeekDayConfigModelCollection = model.Days.OrderBy((ConfigDataModel x) => (int)(x.DayOfWeek.Value - cultureFirstDay + 7) % 7);
		foreach (ConfigDataModel item in WeekDayConfigModelCollection)
		{
			FillInConfigDataModel(item, ConfigDataModel.PrefixProvider.GetWeekDayPrefix(item.DayOfWeek.Value));
		}
		ExceptionalDayCollectionConfigDataModel = new ConfigDataModel();
		FillInConfigDataModel(ExceptionalDayCollectionConfigDataModel, "ExceptionalDayCollection");
		ExceptionalDayConfigModelCollection = new List<ConfigDataModel>();
	}

	private void FillInConfigDataModel(ConfigDataModel configDataModel, string prefix)
	{
		configDataModel.SimpleModeEnable = SimpleModeEnable;
		configDataModel.Prefix = ConfigDataModelFactory.AddBind(StringUid, prefix);
		configDataModel.GridId = $"{configDataModel.Prefix}Grid{StringUid}";
	}

	public void InitializeMode(bool takeWeekDayIntervalCollection, bool takeExceptionalDayIntervalCollection)
	{
		Func<bool> b = () => WeekDayConfigModelCollection.All((ConfigDataModel cm) => cm.SimpleModeEnable);
		Func<bool> b2 = () => ExceptionalDayConfigModelCollection.All((ConfigDataModel cm) => cm.SimpleModeEnable);
		Func<bool> func = () => BaseConfigDataModel.SimpleModeEnable;
		if (takeWeekDayIntervalCollection)
		{
			func = (Func<bool>)Delegate.Combine(func, b);
		}
		if (takeExceptionalDayIntervalCollection)
		{
			func = (Func<bool>)Delegate.Combine(func, b2);
		}
		SimpleModeEnable = func.GetInvocationList().Aggregate(seed: true, (bool simpleModeEnable, Delegate simpleModelEnableDelegate) => simpleModeEnable && ((Func<bool>)simpleModelEnableDelegate)());
		BaseConfigDataModel.SimpleModeEnable = SimpleModeEnable;
		WeekDayCollectionConfigDataModel.SimpleModeEnable = SimpleModeEnable;
		foreach (ConfigDataModel item in WeekDayConfigModelCollection)
		{
			item.SimpleModeEnable = SimpleModeEnable;
		}
		ExceptionalDayCollectionConfigDataModel.SimpleModeEnable = SimpleModeEnable;
		foreach (ConfigDataModel item2 in ExceptionalDayConfigModelCollection)
		{
			item2.SimpleModeEnable = SimpleModeEnable;
		}
	}
}
