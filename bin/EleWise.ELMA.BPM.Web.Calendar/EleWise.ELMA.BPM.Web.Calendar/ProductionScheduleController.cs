using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Calendar.Extensions;
using EleWise.ELMA.BPM.Web.Calendar.Models;
using EleWise.ELMA.BPM.Web.Calendar.Services;
using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.Calendar.ExtensionPoints;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Projects.Models.Resources;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.BPM.Web.Calendar.Controllers;

public class ProductionScheduleController : FilterTreeBaseController<IResourceCalendar, long>
{
	public const string ProductionScheduleId = "ProductionScheduleController.ProductionSchedule";

	public const string ProductionScheduleModeCode = "ProductionScheduleController.ProductionSchedule+Mode";

	[NotNull]
	public ResourceCalendarManager ResourceCalendarManager { get; set; }

	public IProductionScheduleConfigService ProductionScheduleConfigService { get; set; }

	[ContentItem(Name = "SR.M('Глобальный календарь')", Image24 = "#calendar.svg")]
	[Permission("71C2885B-3C58-4671-AA89-BF50ED7A4950")]
	public ActionResult GlobalProductionSchedule(string modeCode)
	{
		return Execute(ResourceCalendarManager.GetGlobal().Id, modeCode);
	}

	public ActionResult Execute(long id, string modeCode)
	{
		if (string.IsNullOrEmpty(modeCode))
		{
			modeCode = DataAccessManager.BLOBManager.GetBLOB<string>(CalendarConstants.GlobalProductionScheduleViewMode, "ProductionScheduleController.ProductionSchedule+Mode");
		}
		else
		{
			DataAccessManager.BLOBManager.SetBLOB(CalendarConstants.GlobalProductionScheduleViewMode, "ProductionScheduleController.ProductionSchedule+Mode", modeCode);
		}
		ProductionScheduleModel productionScheduleModel = new ProductionScheduleModel(ResourceCalendarManager.Load(id), modeCode);
		if (base.SecurityService.HasPermission(PermissionProvider.ProductionSchedulePermission))
		{
			productionScheduleModel.IsReadOnly = false;
		}
		return (ActionResult)(object)((Controller)this).View("Execute", (object)productionScheduleModel);
	}

	public JsonResult LoadProductionSchedule(IResourceCalendar schedule, DateTime? start)
	{
		ProductionScheduleData productionScheduleData = ProductionScheduleDataFactory.CreateByEntity(schedule, dateTimeIsClient: true);
		productionScheduleData.FillWithHoliday();
		WeekDay[] array = productionScheduleData.WeekDays.OrderBy((WeekDay wd) => wd.DayOfWeek).ToArray();
		List<ExceptionalDay> list = productionScheduleData.ExceptionalDays.OrderBy((ExceptionalDay ed) => ed.Date).ToList();
		List<object> list2 = new List<object>();
		DateTime dateTime = start ?? DateTime.Now;
		DateTime dateTime2 = new DateTime(dateTime.Year, dateTime.Month, 1);
		int num = DateTime.DaysInMonth(dateTime.Year, dateTime.Month);
		for (int i = 1; i <= num; i++)
		{
			DateTime date = new DateTime(dateTime.Year, dateTime.Month, i).Date;
			WeekDay weekDay = array[(int)date.DayOfWeek];
			ExceptionalDay exceptionalDay = list.FirstOrDefault((ExceptionalDay d) => d.Date == date);
			if (exceptionalDay != null)
			{
				if (!exceptionalDay.IsHoliday && exceptionalDay.WorkingTimeIntervals.Count() > 0)
				{
					TimeSpan start2 = exceptionalDay.WorkingTimeIntervals.First().Start;
					TimeSpan end = exceptionalDay.WorkingTimeIntervals.Last().End;
					DateTime dateTime3 = date.Add(start2);
					DateTime dateTime4 = date.Add(end);
					list2.Add(new
					{
						title = dateTime4.ToString("h\\:mm"),
						start = dateTime3.ToString(),
						end = dateTime4.ToString()
					});
				}
			}
			else if (!weekDay.IsHoliday)
			{
				TimeSpan start3 = weekDay.WorkingTimeIntervals.First().Start;
				TimeSpan end2 = weekDay.WorkingTimeIntervals.Last().End;
				DateTime dateTime5 = date.Add(start3);
				DateTime dateTime6 = date.Add(end2);
				list2.Add(new
				{
					title = dateTime6.ToString("h\\:mm"),
					start = dateTime5.ToString(),
					end = dateTime6.ToString()
				});
			}
		}
		DateTime dateTime7 = dateTime2.AddMonths(-1);
		DateTime dateTime8 = dateTime2.AddMonths(2).AddDays(-1.0);
		foreach (ExceptionalDay item in list)
		{
			if (!(item.Date < dateTime7) && !(item.Date > dateTime8))
			{
				DayType dayType = DayType.CustomWorkingDay;
				string text = "fc-exceptional-custom-workday";
				if (item.IsHoliday)
				{
					text = "fc-exceptional-holiday";
					dayType = DayType.Holiday;
				}
				list2.Add(new
				{
					start = item.Date.ToString("yyyy-MM-dd"),
					end = item.Date.AddDays(1.0).ToString("yyyy-MM-dd"),
					classNames = new string[2] { "fc-exceptional-day", text },
					dayType = dayType
				});
			}
		}
		return ((Controller)this).Json((object)new
		{
			events = list2
		}, (JsonRequestBehavior)0);
	}

	[ContentItem(Name = "SR.M('Производственные календари')", Image24 = "#calendar.svg")]
	[Permission("99A0C619-AF6B-4D66-88C4-2C8F07B34575")]
	public ActionResult CommonGrid(long? FilterId = null)
	{
		ActionResult val = BaseIndex(FilterId, "FilterId", "CommonGrid");
		if (val != null)
		{
			return val;
		}
		FilterModel filter = CreateFilter(FilterId);
		GridDataFilter<IResourceCalendar> gridDataFilter = CreateGridData(null, filter);
		return (ActionResult)(object)((Controller)this).View((object)gridDataFilter);
	}

	[HttpPost]
	[TransactionAction]
	[Permission("99A0C619-AF6B-4D66-88C4-2C8F07B34575")]
	public JsonResult Delete(long id)
	{
		string url = ((Controller)this).get_Url().Action("CommonGrid", "ProductionSchedule", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Calendar"
		});
		try
		{
			IResourceCalendar productionSchedule = ResourceCalendarManager.Load(id);
			foreach (IResourceCalendarValidator extensionPoint in ComponentManager.Current.GetExtensionPoints<IResourceCalendarValidator>())
			{
				if (!extensionPoint.CanDelete(productionSchedule))
				{
					base.Notifier.Error(SR.T("Нет разрешения на удаление производственного календаря"));
					return ((Controller)this).Json((object)new
					{
						Url = url
					}, (JsonRequestBehavior)0);
				}
			}
			((IEnumerable<IBaseTimeInterval>)productionSchedule.BaseIntervals).ToList().ForEach(delegate(IBaseTimeInterval bi)
			{
				bi.Calendar = null;
				((ICollection<IBaseTimeInterval>)productionSchedule.BaseIntervals).Remove(bi);
				bi.Delete();
			});
			((IEnumerable<IWorkTimeInterval>)productionSchedule.WorkIntervals).ToList().ForEach(delegate(IWorkTimeInterval wi)
			{
				wi.Calendar = null;
				((ICollection<IWorkTimeInterval>)productionSchedule.WorkIntervals).Remove(wi);
				wi.Delete();
			});
			((IEnumerable<IHolidayInterval>)productionSchedule.HolidayIntervals).ToList().ForEach(delegate(IHolidayInterval hi)
			{
				hi.Calendar = null;
				((ICollection<IHolidayInterval>)productionSchedule.HolidayIntervals).Remove(hi);
				hi.Delete();
			});
			productionSchedule.Delete();
		}
		catch (Exception exception)
		{
			base.Notifier.Error(SR.T("Не удалось удалить производственный календарь"));
			base.Logger.Error(SR.T("Ошибка удаления производственного календаря с ID={0}", id), exception);
		}
		base.Notifier.Information(SR.T("Производственный календарь удален"));
		return ((Controller)this).Json((object)new
		{
			Url = url
		}, (JsonRequestBehavior)0);
	}

	[Permission("99A0C619-AF6B-4D66-88C4-2C8F07B34575")]
	public ActionResult EditUserSetting(long userId)
	{
		ProductionScheduleUserSettingModel productionScheduleUserSettingModel = new ProductionScheduleUserSettingModel(UserManager.Instance.Load(userId));
		return (ActionResult)(object)((Controller)this).View("Security/EditUserSetting", (object)productionScheduleUserSettingModel);
	}

	[HttpPost]
	[TransactionAction]
	[Permission("99A0C619-AF6B-4D66-88C4-2C8F07B34575")]
	public ActionResult SaveUserSetting(ProductionScheduleUserSettingModel model)
	{
		try
		{
			if (model.User == null)
			{
				throw new ArgumentNullException("user");
			}
			IResourceCalendarUserMapFilter resourceCalendarUserMapFilter = InterfaceActivator.Create<IResourceCalendarUserMapFilter>();
			resourceCalendarUserMapFilter.User = model.User;
			IResourceCalendarUserMap map = EntityManager<IResourceCalendarUserMap>.Instance.Find(resourceCalendarUserMapFilter, new FetchOptions(0, 1)).FirstOrDefault();
			if (map != null)
			{
				if ((model.ProductionScheduleType == ProductionScheduleType.Global || model.ProductionScheduleType == ProductionScheduleType.Common) && map.Calendar != null && map.Calendar.Uid != CalendarConstants.GlobalProductionScheduleEntityUid && (!map.Calendar.IsCatalog.HasValue || !map.Calendar.IsCatalog.Value))
				{
					((IEnumerable<IBaseTimeInterval>)map.Calendar.BaseIntervals).ToList().ForEach(delegate(IBaseTimeInterval bi)
					{
						bi.Calendar = null;
						((ICollection<IBaseTimeInterval>)map.Calendar.BaseIntervals).Remove(bi);
						bi.Delete();
					});
					((IEnumerable<IWorkTimeInterval>)map.Calendar.WorkIntervals).ToList().ForEach(delegate(IWorkTimeInterval wi)
					{
						wi.Calendar = null;
						((ICollection<IWorkTimeInterval>)map.Calendar.WorkIntervals).Remove(wi);
						wi.Delete();
					});
					((IEnumerable<IHolidayInterval>)map.Calendar.HolidayIntervals).ToList().ForEach(delegate(IHolidayInterval hi)
					{
						hi.Calendar = null;
						((ICollection<IHolidayInterval>)map.Calendar.HolidayIntervals).Remove(hi);
						hi.Delete();
					});
					map.Calendar.Delete();
				}
				if (model.ProductionScheduleType == ProductionScheduleType.Global)
				{
					map.Delete();
				}
			}
			if (model.ProductionScheduleType == ProductionScheduleType.Common || model.ProductionScheduleType == ProductionScheduleType.Personal)
			{
				if (map == null)
				{
					map = EntityManager<IResourceCalendarUserMap>.Instance.Create();
					map.User = model.User;
				}
				if (model.ProductionScheduleType == ProductionScheduleType.Common)
				{
					map.Calendar = model.CommonProductionSchedule;
				}
				else
				{
					if (model.ProductionScheduleType != ProductionScheduleType.Personal)
					{
						throw new InvalidOperationException();
					}
					map.Calendar = model.PersonalProductionSchedule;
				}
				if (map.Calendar == null)
				{
					throw new NullReferenceException(SR.T("Отсутствует ссылка на производственный календарь"));
				}
				map.Save();
			}
			return (ActionResult)(object)((Controller)this).RedirectToAction("Profile", "User", new RouteValueDictionary
			{
				{ "area", "EleWise.ELMA.BPM.Web.Security" },
				{
					"id",
					model.User.Id
				}
			});
		}
		catch (Exception exception)
		{
			base.Logger.Error(SR.T("Ошибка сохранения персонального производственного календаря"), exception);
			if (model.User != null)
			{
				base.Notifier.Error(SR.T("Ошибка сохранения персонального производственного календаря"));
				return EditUserSetting(model.User.Id);
			}
			throw;
		}
	}

	[Permission("99A0C619-AF6B-4D66-88C4-2C8F07B34575")]
	public ActionResult CreatePersonalProductionSchedule(string stringUid = null, bool inJsonFormat = false)
	{
		try
		{
			IResourceCalendar productionSchedule = ResourceCalendarManager.Create();
			ResourceCalendarManager.FillWithDefaultBaseIntervalCollection(productionSchedule);
			ResourceCalendarManager.AddFiveDayWorkingWeekByBaseIntervals(productionSchedule);
			ProductionScheduleConfigModel productionScheduleConfigModel = new ProductionScheduleConfigModel(productionSchedule, stringUid);
			productionScheduleConfigModel.InitializeMode(takeWeekDayIntervalCollection: true, takeExceptionalDayIntervalCollection: false);
			productionScheduleConfigModel.Entity.Name = SR.T("Личный производственный календарь");
			productionScheduleConfigModel.Entity.IsCatalog = false;
			productionScheduleConfigModel.InJsonFormat = inJsonFormat;
			((ControllerBase)this).get_ViewData().set_Item("PersonalProductionScheduleCreation", (object)true);
			((ControllerBase)this).get_ViewData().set_Item("Uid", (object)stringUid);
			return (ActionResult)(object)((Controller)this).PartialView("BaseConfigPopup", (object)productionScheduleConfigModel);
		}
		catch (Exception exception)
		{
			base.Logger.Error(SR.T("Ошибка создания персонального производственного календаря"), exception);
			return (ActionResult)(object)((Controller)this).Content(string.Format("<div class=\"messagePanel-Error schedule-error\"\">{0}</div>", SR.T("Ошибка создания персонального производственного календаря")));
		}
	}

	[Permission("99A0C619-AF6B-4D66-88C4-2C8F07B34575")]
	public ActionResult EditPersonalProductionSchedule([Bind(Prefix = "Config")] ProductionScheduleSimpleConfigModel config, [Bind(Prefix = "BaseConfig")] ConfigDataModel baseConfig, [Bind(Prefix = "WeekDayCollection")] ConfigDataModel weekDayCollection, [Bind(Prefix = "Sunday")] ConfigDataModel sunday, [Bind(Prefix = "Monday")] ConfigDataModel monday, [Bind(Prefix = "Tuesday")] ConfigDataModel tuesday, [Bind(Prefix = "Wednesday")] ConfigDataModel wednesday, [Bind(Prefix = "Thursday")] ConfigDataModel thursday, [Bind(Prefix = "Friday")] ConfigDataModel friday, [Bind(Prefix = "Saturday")] ConfigDataModel saturday, string stringUid = null)
	{
		try
		{
			ProductionScheduleConfigModel productionScheduleConfigModel = new ProductionScheduleConfigModel(new CalendarConfigModel
			{
				Config = config,
				BaseConfig = baseConfig,
				WeekDayCollection = weekDayCollection,
				Sunday = sunday,
				Monday = monday,
				Tuesday = tuesday,
				Wednesday = wednesday,
				Thursday = thursday,
				Friday = friday,
				Saturday = saturday
			}, stringUid);
			productionScheduleConfigModel.InitializeMode(takeWeekDayIntervalCollection: true, takeExceptionalDayIntervalCollection: false);
			productionScheduleConfigModel.InJsonFormat = true;
			((ControllerBase)this).get_ViewData().set_Item("PersonalProductionScheduleCreation", (object)true);
			((ControllerBase)this).get_ViewData().set_Item("Uid", (object)stringUid);
			return (ActionResult)(object)((Controller)this).PartialView("BaseConfigPopup", (object)productionScheduleConfigModel);
		}
		catch (Exception exception)
		{
			base.Logger.Error(SR.T("Ошибка редактирования персонального производственного календаря"), exception);
			return (ActionResult)(object)((Controller)this).Content(string.Format("<div class=\"messagePanel-Error schedule-error\"\">{0}</div>", SR.T("Ошибка редактирования производственного календаря")));
		}
	}

	public ActionResult EditBaseConfig(long? id)
	{
		try
		{
			IResourceCalendar resourceCalendar = (id.HasValue ? ResourceCalendarManager.Load(id.Value) : ResourceCalendarManager.Create());
			if (resourceCalendar.IsNew())
			{
				ResourceCalendarManager.FillWithDefaultBaseIntervalCollection(resourceCalendar);
				ResourceCalendarManager.AddFiveDayWorkingWeekByBaseIntervals(resourceCalendar);
			}
			ProductionScheduleConfigModel productionScheduleConfigModel = new ProductionScheduleConfigModel(resourceCalendar);
			productionScheduleConfigModel.InitializeMode(takeWeekDayIntervalCollection: true, takeExceptionalDayIntervalCollection: false);
			return (ActionResult)(object)((Controller)this).PartialView("BaseConfigPopup", (object)productionScheduleConfigModel);
		}
		catch (Exception exception)
		{
			base.Logger.Error(SR.T("Ошибка редактирования базовых настроек производственного календаря с ID={0}", id), exception);
			return (ActionResult)(object)((Controller)this).Content(string.Format("<div class=\"messagePanel-Error schedule-error\"\">{0}</div>", SR.T("Ошибка редактирования производственного календаря")));
		}
	}

	[HttpPost]
	[TransactionAction]
	[Permission("99A0C619-AF6B-4D66-88C4-2C8F07B34575")]
	public JsonResult SaveBaseConfig([Bind(Prefix = "Config")] ProductionScheduleSimpleConfigModel config, [Bind(Prefix = "BaseConfig")] ConfigDataModel baseConfig, [Bind(Prefix = "WeekDayCollection")] ConfigDataModel weekDayCollection, [Bind(Prefix = "Sunday")] ConfigDataModel sunday, [Bind(Prefix = "Monday")] ConfigDataModel monday, [Bind(Prefix = "Tuesday")] ConfigDataModel tuesday, [Bind(Prefix = "Wednesday")] ConfigDataModel wednesday, [Bind(Prefix = "Thursday")] ConfigDataModel thursday, [Bind(Prefix = "Friday")] ConfigDataModel friday, [Bind(Prefix = "Saturday")] ConfigDataModel saturday)
	{
		IResourceCalendar resourceCalendar = null;
		try
		{
			CalendarConfigModel model = new CalendarConfigModel
			{
				Config = config,
				BaseConfig = baseConfig,
				WeekDayCollection = weekDayCollection,
				Sunday = sunday,
				Monday = monday,
				Tuesday = tuesday,
				Wednesday = wednesday,
				Thursday = thursday,
				Friday = friday,
				Saturday = saturday
			};
			resourceCalendar = ProductionScheduleConfigService.GetResourceCalendar(model);
			string url = ((resourceCalendar.Uid == CalendarConstants.GlobalProductionScheduleEntityUid) ? ((Controller)this).get_Url().Action("GlobalProductionSchedule", "ProductionSchedule", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Calendar"
			}) : ((Controller)this).get_Url().Action("Execute", "ProductionSchedule", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Calendar",
				id = resourceCalendar.Id
			}));
			return ((Controller)this).Json((object)new
			{
				Success = true,
				Id = ((resourceCalendar.Uid == CalendarConstants.GlobalProductionScheduleEntityUid) ? string.Empty : resourceCalendar.Id.ToString()),
				Url = url
			}, (JsonRequestBehavior)0);
		}
		catch (Exception exception)
		{
			base.Notifier.Error(SR.T("Ошибка сохранения базовых настроек производственного календаря"));
			if (resourceCalendar == null)
			{
				base.Logger.Error(SR.T("Ошибка создания или загрузки производственного календаря"), exception);
			}
			else
			{
				base.Logger.Error(SR.T("Ошибка сохранения базовых настроек производственного календаря с ID={0}", config.Entity.Id), exception);
			}
			return ((Controller)this).Json((object)new
			{
				Success = false
			}, (JsonRequestBehavior)0);
		}
	}

	[HttpPost]
	public ActionResult EnableBaseConfigSimpleMode(long id, string name, string baseTimeIntervalCollectionJsonData, string workingTimeIntervalCollectionJsonData, bool isCatalog, bool personalProductionScheduleCreation, string stringUid = null, bool inJsonFormat = false)
	{
		try
		{
			IResourceCalendar resourceCalendar = ((id != 0L) ? ResourceCalendarManager.Load(id) : ResourceCalendarManager.Create());
			resourceCalendar.Name = name;
			BaseTimeIntervalsRenew(resourceCalendar, baseTimeIntervalCollectionJsonData, inJsonFormat);
			WorkTimeIntervalsRenew(resourceCalendar, workingTimeIntervalCollectionJsonData, inJsonFormat);
			ProductionScheduleConfigModel productionScheduleConfigModel = new ProductionScheduleConfigModel(resourceCalendar, stringUid);
			productionScheduleConfigModel.Entity.IsCatalog = isCatalog;
			productionScheduleConfigModel.InJsonFormat = inJsonFormat;
			productionScheduleConfigModel.InitializeMode(takeWeekDayIntervalCollection: true, takeExceptionalDayIntervalCollection: false);
			((ControllerBase)this).get_ViewData().set_Item("PersonalProductionScheduleCreation", (object)personalProductionScheduleCreation);
			((ControllerBase)this).get_ViewData().set_Item("Uid", (object)stringUid);
			return (ActionResult)(object)((Controller)this).PartialView("BaseConfigPopup", (object)productionScheduleConfigModel);
		}
		catch (Exception exception)
		{
			base.Logger.Error(SR.T("Ошибка активации обычного режима редактирования базовых настроек производственного календаря с ID={0}", id), exception);
			return (ActionResult)(object)((Controller)this).Content(string.Format("<div class=\"messagePanel-Error schedule-error\"\">{0}</div>", SR.T("Ошибка активации обычного режима редактирования")));
		}
	}

	private void BaseTimeIntervalsRenew(IResourceCalendar productionSchedule, string baseTimeIntervalCollectionJsonData, bool inJsonFormat)
	{
		List<IBaseTimeInterval> baseTimeIntervalCollection = ConfigDataModelExtension.BaseTimeIntervalCollectionDeserialize(baseTimeIntervalCollectionJsonData).ToList();
		if (!baseTimeIntervalCollection.Any())
		{
			throw new ArgumentException(SR.T("Коллекция базовых интервалов пуста"));
		}
		IEnumerable<IBaseTimeInterval> enumerable = ((IEnumerable<IBaseTimeInterval>)productionSchedule.BaseIntervals).Where((IBaseTimeInterval bi) => !baseTimeIntervalCollection.Contains(bi));
		if (!inJsonFormat)
		{
			ResourceCalendarManager.DeleteBaseTimeIntervalCollectionImmediately(productionSchedule, enumerable);
		}
		else
		{
			foreach (IBaseTimeInterval item in enumerable.ToList())
			{
				((ICollection<IBaseTimeInterval>)productionSchedule.BaseIntervals).Remove(item);
			}
		}
		baseTimeIntervalCollection.ForEach(delegate(IBaseTimeInterval bi)
		{
			if (bi.IsNew())
			{
				bi.Id = 0L;
				bi.Calendar = productionSchedule;
				productionSchedule.BaseIntervals.Add(bi);
			}
		});
	}

	private void WorkTimeIntervalsRenew(IResourceCalendar productionSchedule, string workingTimeIntervalCollectionJsonData, bool inJsonFormat)
	{
		IEnumerable<IWorkTimeInterval> source = ConfigDataModelExtension.WorkingTimeIntervalCollectionDeserialize(workingTimeIntervalCollectionJsonData);
		List<IWorkTimeInterval> weekDayWorkingTimeIntervalCollection = source.ToList();
		IEnumerable<IWorkTimeInterval> enumerable = ((IEnumerable<IWorkTimeInterval>)productionSchedule.WorkIntervals).Where((IWorkTimeInterval wi) => wi.DayOfWeek.HasValue && !wi.DateExceptionStart.HasValue && !wi.DateExceptionFinish.HasValue && !weekDayWorkingTimeIntervalCollection.Contains(wi));
		if (!inJsonFormat)
		{
			ResourceCalendarManager.DeleteWorkingTimeIntervalCollectionImmediately(productionSchedule, enumerable);
		}
		else
		{
			foreach (IWorkTimeInterval item in enumerable.ToList())
			{
				((ICollection<IWorkTimeInterval>)productionSchedule.WorkIntervals).Remove(item);
			}
		}
		weekDayWorkingTimeIntervalCollection.ForEach(delegate(IWorkTimeInterval wi)
		{
			if (wi.IsNew())
			{
				wi.Id = 0L;
				wi.Calendar = productionSchedule;
				productionSchedule.WorkIntervals.Add(wi);
			}
		});
	}

	[HttpPost]
	public ActionResult EnableBaseConfigAdvancedMode([Bind(Prefix = "BaseConfig")] ConfigDataModel baseConfig, string stringUid = "")
	{
		try
		{
			List<IBaseTimeInterval> list = ProductionScheduleConfigService.GetUpdatedBaseTimeIntervalCollection(baseConfig, (from bi in ConfigDataModelExtension.BaseTimeIntervalCollectionDeserialize(baseConfig.JsonBaseTimeIntervalCollection, loadEntityIfExists: false)
				orderby bi.Start
				select bi).ToList()).ToList();
			if (!list.Any())
			{
				throw new ArgumentException(SR.T("Коллекция базовых интервалов пуста"));
			}
			foreach (IBaseTimeInterval item in list.Where((IBaseTimeInterval bi) => bi.Id == 0))
			{
				item.Id = list.Min((IBaseTimeInterval jbi) => jbi.Id) - 1;
			}
			((ControllerBase)this).get_ViewData().set_Item("Prefix", (object)baseConfig.Prefix);
			((ControllerBase)this).get_ViewData().set_Item("GridId", (object)baseConfig.GridId);
			((ControllerBase)this).get_ViewData().set_Item("Uid", (object)stringUid);
			return (ActionResult)(object)((Controller)this).PartialView("Base/BaseTimeIntervalGrid", (object)list);
		}
		catch (Exception exception)
		{
			base.Logger.Error(SR.T("Ошибка активации экспертного режима редактирования базовых настроек производственного календаря"), exception);
			return (ActionResult)(object)((Controller)this).Content(string.Format("<div class=\"messagePanel-Error schedule-error\"\">{0}</div>", SR.T("Ошибка активации экспертного режима редактирования")));
		}
	}

	[HttpPost]
	public ActionResult EnableWeekDayCollectionConfigAdvancedMode([Bind(Prefix = "BaseConfig")] ConfigDataModel baseConfig, [Bind(Prefix = "WeekDayCollection")] ConfigDataModel weekDayCollection, [Bind(Prefix = "Sunday")] ConfigDataModel sunday, [Bind(Prefix = "Monday")] ConfigDataModel monday, [Bind(Prefix = "Tuesday")] ConfigDataModel tuesday, [Bind(Prefix = "Wednesday")] ConfigDataModel wednesday, [Bind(Prefix = "Thursday")] ConfigDataModel thursday, [Bind(Prefix = "Friday")] ConfigDataModel friday, [Bind(Prefix = "Saturday")] ConfigDataModel saturday, string stringUid = "")
	{
		try
		{
			List<ConfigDataModel> obj = new List<ConfigDataModel> { sunday, monday, tuesday, wednesday, thursday, friday, saturday };
			IEnumerable<IGrouping<int?, IWorkTimeInterval>> weekDayTimeIntervalCollectionGroups = from wi in ConfigDataModelExtension.WorkingTimeIntervalCollectionDeserialize(weekDayCollection.JsonWorkingTimeIntervalCollection, loadEntityIfExists: false)
				group wi by wi.DayOfWeek;
			IEnumerable<IBaseTimeInterval> updatedBaseTimeIntervalCollection = ProductionScheduleConfigService.GetUpdatedBaseTimeIntervalCollection(baseConfig, (from bi in ConfigDataModelExtension.BaseTimeIntervalCollectionDeserialize(baseConfig.JsonBaseTimeIntervalCollection, loadEntityIfExists: false)
				orderby bi.Start
				select bi).ToList());
			List<IBaseTimeInterval> baseTimeIntervalCollection = updatedBaseTimeIntervalCollection.ToList();
			if (!baseTimeIntervalCollection.Any())
			{
				throw new ArgumentException(SR.T("Коллекция базовых интервалов пуста"));
			}
			List<IWorkTimeInterval> weekDayTimeIntervalCollection = new List<IWorkTimeInterval>();
			obj.ForEach(delegate(ConfigDataModel cm)
			{
				if (cm.DayOfWeek.HasValue)
				{
					IEnumerable<IWorkTimeInterval> updatedWeekDayTimeIntervalCollection = ProductionScheduleConfigService.GetUpdatedWeekDayTimeIntervalCollection(cm, weekDayTimeIntervalCollectionGroups.SelectMany((IGrouping<int?, IWorkTimeInterval> g) => g), baseTimeIntervalCollection);
					weekDayTimeIntervalCollection.AddRange(updatedWeekDayTimeIntervalCollection);
				}
			});
			foreach (IWorkTimeInterval item in weekDayTimeIntervalCollection.Where((IWorkTimeInterval wi) => wi.Id == 0))
			{
				item.Id = weekDayTimeIntervalCollection.Min((IWorkTimeInterval wi) => wi.Id) - 1;
			}
			((ControllerBase)this).get_ViewData().set_Item("Prefix", (object)weekDayCollection.Prefix);
			((ControllerBase)this).get_ViewData().set_Item("GridId", (object)weekDayCollection.GridId);
			((ControllerBase)this).get_ViewData().set_Item("Uid", (object)stringUid);
			return (ActionResult)(object)((Controller)this).PartialView("WeekDay/WeekDayTimeIntervalGrid", (object)(from wi in weekDayTimeIntervalCollection
				where wi.DayOfWeek.HasValue && wi.DayOfWeek >= 1 && wi.DayOfWeek <= 7
				orderby wi.DayOfWeek, wi.Start
				select wi));
		}
		catch (Exception exception)
		{
			base.Logger.Error(SR.T("Ошибка активации экспертного режима редактирования базовых настроек производственного календаря"), exception);
			return (ActionResult)(object)((Controller)this).Content(string.Format("<div class=\"messagePanel-Error schedule-error\"\">{0}</div>", SR.T("Ошибка активации экспертного режима редактирования")));
		}
	}

	public ActionResult EditWeekDay(long id, int weekDayIndex)
	{
		try
		{
			if (weekDayIndex < 0 || weekDayIndex > 6)
			{
				throw new ArgumentOutOfRangeException(SR.T("Индекс дня недели {0} не принадлежит диапазону от 0 до 6", weekDayIndex));
			}
			WeekDayModel weekDayModel = new WeekDayModel(ResourceCalendarManager.Load(id), (DayOfWeek)weekDayIndex);
			return (ActionResult)(object)((Controller)this).PartialView("WeekDayPopup", (object)weekDayModel);
		}
		catch (Exception exception)
		{
			base.Logger.Error(SR.T("Ошибка редактирования дня недели производственного календаря"), exception);
			return (ActionResult)(object)((Controller)this).Content(string.Format("<div class=\"messagePanel-Error schedule-error\"\">{0}</div>", SR.T("Ошибка редактирования дня недели")));
		}
	}

	[HttpPost]
	[TransactionAction]
	[Permission("99A0C619-AF6B-4D66-88C4-2C8F07B34575")]
	public JsonResult SaveWeekDay(WeekDayModel weekDayModel, [Bind(Prefix = "Sunday")] ConfigDataModel sunday, [Bind(Prefix = "Monday")] ConfigDataModel monday, [Bind(Prefix = "Tuesday")] ConfigDataModel tuesday, [Bind(Prefix = "Wednesday")] ConfigDataModel wednesday, [Bind(Prefix = "Thursday")] ConfigDataModel thursday, [Bind(Prefix = "Friday")] ConfigDataModel friday, [Bind(Prefix = "Saturday")] ConfigDataModel saturday)
	{
		try
		{
			IResourceCalendar productionSchedule = ResourceCalendarManager.Load(weekDayModel.Entity.Id);
			ConfigDataModel configDataModel = new List<ConfigDataModel> { sunday, monday, tuesday, wednesday, thursday, friday, saturday }.First((ConfigDataModel m) => m != null);
			if (!configDataModel.DayOfWeek.HasValue)
			{
				throw new Exception(SR.T("Перечисление дня недели отсутствует"));
			}
			IEnumerable<IBaseTimeInterval> baseIntervals = (IEnumerable<IBaseTimeInterval>)productionSchedule.BaseIntervals;
			List<IWorkTimeInterval> weekDayWorkingTimeIntervalCollection = ConfigDataModelExtension.WorkingTimeIntervalCollectionDeserialize(configDataModel.JsonWorkingTimeIntervalCollection).ToList();
			if (weekDayModel.SimpleModeEnable)
			{
				weekDayWorkingTimeIntervalCollection = (from wi in ProductionScheduleConfigService.GetUpdatedWeekDayTimeIntervalCollection(configDataModel, weekDayWorkingTimeIntervalCollection, baseIntervals)
					orderby wi.Start
					select wi).ToList();
			}
			int denormalizedIndex = configDataModel.DayOfWeek.Value.GetWorkTimeIntervalDayOfWeek();
			((IEnumerable<IWorkTimeInterval>)productionSchedule.WorkIntervals).Where((IWorkTimeInterval wi) => wi.DayOfWeek.HasValue && !wi.DateExceptionStart.HasValue && !wi.DateExceptionFinish.HasValue && wi.DayOfWeek == denormalizedIndex && !weekDayWorkingTimeIntervalCollection.Contains(wi)).ToList().ForEach(delegate(IWorkTimeInterval wi)
			{
				((ICollection<IWorkTimeInterval>)productionSchedule.WorkIntervals).Remove(wi);
				wi.Delete();
			});
			weekDayWorkingTimeIntervalCollection.ForEach(delegate(IWorkTimeInterval wi)
			{
				if (wi.IsNew())
				{
					wi.Id = 0L;
					wi.Calendar = productionSchedule;
					productionSchedule.WorkIntervals.Add(wi);
				}
			});
			if (!ResourceCalendarManager.CanSave(productionSchedule).Result)
			{
				base.UnitOfWorkManager.RollbackCurrent(string.Empty);
				throw new Exception(SR.T("Ошибка валидации при сохранении производственного календаря"));
			}
			productionSchedule.Save();
			string url = ((productionSchedule.Uid == CalendarConstants.GlobalProductionScheduleEntityUid) ? ((Controller)this).get_Url().Action("GlobalProductionSchedule", "ProductionSchedule", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Calendar"
			}) : ((Controller)this).get_Url().Action("Execute", "ProductionSchedule", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Calendar",
				id = productionSchedule.Id
			}));
			return ((Controller)this).Json((object)new
			{
				Success = true,
				Url = url
			}, (JsonRequestBehavior)0);
		}
		catch (Exception exception)
		{
			base.Notifier.Error(SR.T("Ошибка сохранения дня недели производственного календаря"));
			base.Logger.Error(SR.T("Ошибка сохранения дня недели производственного календаря с ID={1}", weekDayModel.Entity.Id), exception);
			return ((Controller)this).Json((object)new
			{
				Success = false
			}, (JsonRequestBehavior)0);
		}
	}

	[HttpPost]
	public ActionResult EnableWeekDayConfigSimpleMode(long id, string workingTimeIntervalCollectionJsonData, int weekDayIndex)
	{
		try
		{
			if (weekDayIndex < 0 || weekDayIndex > 6)
			{
				throw new ArgumentOutOfRangeException(SR.T("Индекс дня недели {0} не принадлежит диапазону от 0 до 6", weekDayIndex));
			}
			IResourceCalendar productionSchedule = ((id != 0L) ? ResourceCalendarManager.Load(id) : ResourceCalendarManager.Create());
			IEnumerable<IWorkTimeInterval> source = ConfigDataModelExtension.WorkingTimeIntervalCollectionDeserialize(workingTimeIntervalCollectionJsonData);
			int denormalizedIndex = weekDayIndex.GetWorkTimeIntervalDayOfWeek();
			List<IWorkTimeInterval> weekDayWorkingTimeIntervalCollection = source.ToList();
			ResourceCalendarManager.DeleteWorkingTimeIntervalCollectionImmediately(productionSchedule, from wi in (IEnumerable<IWorkTimeInterval>)productionSchedule.WorkIntervals
				where wi.DayOfWeek.HasValue && !wi.DateExceptionStart.HasValue && !wi.DateExceptionFinish.HasValue && wi.DayOfWeek.Value == denormalizedIndex
				where !weekDayWorkingTimeIntervalCollection.Contains(wi)
				select wi);
			weekDayWorkingTimeIntervalCollection.ForEach(delegate(IWorkTimeInterval wi)
			{
				if (wi.IsNew())
				{
					wi.Id = 0L;
					wi.Calendar = productionSchedule;
					productionSchedule.WorkIntervals.Add(wi);
				}
			});
			WeekDayModel weekDayModel = new WeekDayModel(productionSchedule, (DayOfWeek)weekDayIndex);
			return (ActionResult)(object)((Controller)this).PartialView("WeekDayPopup", (object)weekDayModel);
		}
		catch (Exception exception)
		{
			base.Logger.Error(SR.T("Ошибка активации обычного режима редактирования дня недели производственного календаря с ID={0}", id), exception);
			return (ActionResult)(object)((Controller)this).Content(string.Format("<div class=\"messagePanel-Error schedule-error\"\">{0}</div>", SR.T("Ошибка активации обычного режима редактирования")));
		}
	}

	[HttpPost]
	public ActionResult EnableWeekDayConfigAdvancedMode([Bind(Prefix = "Sunday")] ConfigDataModel sunday, [Bind(Prefix = "Monday")] ConfigDataModel monday, [Bind(Prefix = "Tuesday")] ConfigDataModel tuesday, [Bind(Prefix = "Wednesday")] ConfigDataModel wednesday, [Bind(Prefix = "Thursday")] ConfigDataModel thursday, [Bind(Prefix = "Friday")] ConfigDataModel friday, [Bind(Prefix = "Saturday")] ConfigDataModel saturday, string baseTimeIntervalCollectionJsonData, string stringUid = "")
	{
		try
		{
			ConfigDataModel configDataModel = new List<ConfigDataModel> { sunday, monday, tuesday, wednesday, thursday, friday, saturday }.First((ConfigDataModel m) => m != null);
			List<IBaseTimeInterval> list = (from bi in ConfigDataModelExtension.BaseTimeIntervalCollectionDeserialize(baseTimeIntervalCollectionJsonData, loadEntityIfExists: false)
				orderby bi.Start
				select bi).ToList();
			if (!list.Any())
			{
				throw new ArgumentException(SR.T("Коллекция базовых интервалов пуста"));
			}
			List<IWorkTimeInterval> source = (from wi in ProductionScheduleConfigService.GetUpdatedWeekDayTimeIntervalCollection(configDataModel, ConfigDataModelExtension.WorkingTimeIntervalCollectionDeserialize(configDataModel.JsonWorkingTimeIntervalCollection, loadEntityIfExists: false), list)
				orderby wi.Start
				select wi).ToList();
			foreach (IWorkTimeInterval item in source.Where((IWorkTimeInterval wi) => wi.Id == 0))
			{
				item.Id = source.Min((IWorkTimeInterval wi) => wi.Id) - 1;
			}
			((ControllerBase)this).get_ViewData().set_Item("Prefix", (object)configDataModel.Prefix);
			((ControllerBase)this).get_ViewData().set_Item("GridId", (object)configDataModel.GridId);
			((ControllerBase)this).get_ViewData().set_Item("WeekDayIndex", (object)(configDataModel.DayOfWeek.HasValue ? configDataModel.DayOfWeek : null));
			((ControllerBase)this).get_ViewData().set_Item("Uid", (object)stringUid);
			return (ActionResult)(object)((Controller)this).PartialView("WeekDay/WeekDayTimeIntervalGrid", (object)(from wi in source
				where wi.DayOfWeek.HasValue && wi.DayOfWeek >= 1 && wi.DayOfWeek <= 7
				orderby wi.DayOfWeek, wi.Start
				select wi));
		}
		catch (Exception exception)
		{
			base.Logger.Error(SR.T("Ошибка активации экспертного режима редактирования дня недели производственного календаря"), exception);
			return (ActionResult)(object)((Controller)this).Content(string.Format("<div class=\"messagePanel-Error schedule-error\"\">{0}</div>", SR.T("Ошибка активации экспертного режима редактирования")));
		}
	}

	public ActionResult EditBaseTimeInterval(long? id, string baseTimeIntervalCollectionJsonData, string prefix = "", string stringUid = "")
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		try
		{
			BaseIntervalEditModel baseIntervalEditModel = new BaseIntervalEditModel();
			if (id.HasValue)
			{
				IEnumerable<IBaseTimeInterval> source = ConfigDataModelExtension.BaseTimeIntervalCollectionDeserialize(baseTimeIntervalCollectionJsonData, loadEntityIfExists: false);
				baseIntervalEditModel.Entity = source.FirstOrDefault((IBaseTimeInterval s) => s.Id == id.Value);
			}
			if (baseIntervalEditModel.Entity == null)
			{
				baseIntervalEditModel.Entity = InterfaceActivator.Create<IBaseTimeInterval>();
			}
			ViewDataDictionary viewData = ((ControllerBase)this).get_ViewData();
			TemplateInfo val = new TemplateInfo();
			val.set_HtmlFieldPrefix(prefix + ".BaseTimeInterval");
			viewData.set_TemplateInfo(val);
			baseIntervalEditModel.Prefix = prefix;
			((ControllerBase)this).get_ViewData().set_Item("Uid", (object)stringUid);
			return (ActionResult)(object)((Controller)this).PartialView("Base/EditBaseTimeInterval", (object)baseIntervalEditModel);
		}
		catch (Exception exception)
		{
			base.Logger.Error(SR.T("Ошибка редактирования базового интервала с ID={0} производственного календаря", id), exception);
			return (ActionResult)(object)((Controller)this).Content(string.Format("<div class=\"messagePanel-Error schedule-error\"\">{0}</div>", SR.T("Ошибка редактирования базового интервала")));
		}
	}

	[Permission("99A0C619-AF6B-4D66-88C4-2C8F07B34575")]
	public ActionResult SaveBaseTimeInterval([Bind(Prefix = "BaseTimeInterval")] BaseIntervalEditModel model, string baseTimeIntervalCollectionJsonData, string prefix = "", string gridId = "", string stringUid = "")
	{
		model.Entity.Start = new DateTime(DateTime.Now.Year, 1, 1).AddHours(model.Entity.Start.Hour).AddMinutes(model.Entity.Start.Minute);
		model.Entity.Finish = new DateTime(DateTime.Now.Year, 1, 1).AddHours(model.Entity.Finish.Hour).AddMinutes(model.Entity.Finish.Minute);
		List<IBaseTimeInterval> list = ConfigDataModelExtension.BaseTimeIntervalCollectionDeserialize(baseTimeIntervalCollectionJsonData, loadEntityIfExists: false).ToList();
		int num = list.FindIndex((IBaseTimeInterval s) => s.Id == model.Entity.Id);
		if (num >= 0)
		{
			list[num] = model.Entity;
		}
		else
		{
			model.Entity.Id = 0L;
			list.Add(model.Entity);
			model.Entity.Id = list.Min((IBaseTimeInterval s) => s.Id) - 1;
		}
		((ControllerBase)this).get_ViewData().set_Item("GridId", (object)gridId);
		((ControllerBase)this).get_ViewData().set_Item("Prefix", (object)prefix);
		((ControllerBase)this).get_ViewData().set_Item("Uid", (object)stringUid);
		return (ActionResult)(object)((Controller)this).PartialView("Base/BaseTimeIntervalGrid", (object)list.OrderBy((IBaseTimeInterval bi) => bi.Start));
	}

	public ActionResult EditWeekDayTimeInterval(long? id, string weekDayTimeIntervalCollectionJsonData, int? weekDayIndex, string prefix = "", string stringUid = "")
	{
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		try
		{
			WorkIntervalEditModel workIntervalEditModel = new WorkIntervalEditModel();
			if (weekDayIndex < 0 || weekDayIndex > 6)
			{
				throw new ArgumentOutOfRangeException(SR.T("Индекс дня недели {0} не принадлежит диапазону от 0 до 6", weekDayIndex));
			}
			if (id.HasValue)
			{
				IEnumerable<IWorkTimeInterval> source = ConfigDataModelExtension.WorkingTimeIntervalCollectionDeserialize(weekDayTimeIntervalCollectionJsonData, loadEntityIfExists: false);
				workIntervalEditModel.Entity = source.FirstOrDefault((IWorkTimeInterval s) => s.Id == id.Value);
			}
			if (workIntervalEditModel.Entity == null)
			{
				workIntervalEditModel.Entity = InterfaceActivator.Create<IWorkTimeInterval>();
				if (weekDayIndex.HasValue)
				{
					workIntervalEditModel.Entity.DayOfWeek = weekDayIndex.Value.GetWorkTimeIntervalDayOfWeek();
				}
				else
				{
					DayOfWeek firstDayOfWeek = CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek;
					workIntervalEditModel.Entity.DayOfWeek = firstDayOfWeek.GetWorkTimeIntervalDayOfWeek();
				}
			}
			if (weekDayIndex.HasValue)
			{
				workIntervalEditModel.WeekDayIndex = weekDayIndex;
			}
			ViewDataDictionary viewData = ((ControllerBase)this).get_ViewData();
			TemplateInfo val = new TemplateInfo();
			val.set_HtmlFieldPrefix($"Bind{stringUid}.WeekDayWorkingTimeInterval");
			viewData.set_TemplateInfo(val);
			workIntervalEditModel.Prefix = prefix;
			((ControllerBase)this).get_ViewData().set_Item("Uid", (object)stringUid);
			return (ActionResult)(object)((Controller)this).PartialView("WeekDay/EditWeekDayTimeInterval", (object)workIntervalEditModel);
		}
		catch (Exception exception)
		{
			base.Logger.Error(SR.T("Ошибка редактирования рабочего интервала дня недели с ID={0} производственного календаря", id), exception);
			return (ActionResult)(object)((Controller)this).Content(string.Format("<div class=\"messagePanel-Error schedule-error\"\">{0}</div>", SR.T("Ошибка редактирования интервала дня недели")));
		}
	}

	[Permission("99A0C619-AF6B-4D66-88C4-2C8F07B34575")]
	public ActionResult SaveWeekDayTimeInterval([Bind(Prefix = "WeekDayWorkingTimeInterval")] WorkIntervalEditModel model, string weekDayTimeIntervalCollectionJsonData, string prefix = "", string gridId = "", string stringUid = "")
	{
		model.Entity.DateExceptionStart = null;
		model.Entity.DateExceptionFinish = null;
		model.Entity.Start = new DateTime(DateTime.Now.Year, 1, 1).AddHours(model.Entity.Start.Hour).AddMinutes(model.Entity.Start.Minute);
		model.Entity.Finish = new DateTime(DateTime.Now.Year, 1, 1).AddHours(model.Entity.Finish.Hour).AddMinutes(model.Entity.Finish.Minute);
		List<IWorkTimeInterval> list = ConfigDataModelExtension.WorkingTimeIntervalCollectionDeserialize(weekDayTimeIntervalCollectionJsonData, loadEntityIfExists: false).ToList();
		int num = list.FindIndex((IWorkTimeInterval s) => s.Id == model.Entity.Id);
		if (num >= 0)
		{
			list[num] = model.Entity;
		}
		else
		{
			model.Entity.Id = 0L;
			list.Add(model.Entity);
			model.Entity.Id = list.Min((IWorkTimeInterval s) => s.Id) - 1;
		}
		((ControllerBase)this).get_ViewData().set_Item("Prefix", (object)prefix);
		((ControllerBase)this).get_ViewData().set_Item("GridId", (object)gridId);
		((ControllerBase)this).get_ViewData().set_Item("WeekDayIndex", (object)model.WeekDayIndex);
		((ControllerBase)this).get_ViewData().set_Item("Uid", (object)stringUid);
		return (ActionResult)(object)((Controller)this).PartialView("WeekDay/WeekDayTimeIntervalGrid", (object)(from wi in list
			where wi.DayOfWeek.HasValue && wi.DayOfWeek >= 1 && wi.DayOfWeek <= 7
			orderby wi.DayOfWeek, wi.Start
			select wi));
	}
}
