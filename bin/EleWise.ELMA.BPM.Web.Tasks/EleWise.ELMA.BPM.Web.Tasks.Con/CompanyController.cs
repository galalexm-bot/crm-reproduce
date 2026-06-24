using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Tasks.Components;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.BPM.Web.Tasks.Models.Settings;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Web.Mvc.Portlets;
using NHibernate;

namespace EleWise.ELMA.BPM.Web.Tasks.Controllers;

public class CompanyController : BPMController
{
	private const string TasksCompanySettings = "Tasks-CompanySettings";

	public ISessionProvider SessionProvider { get; set; }

	public ActionResult Index(KeyIndicator? keyFeature = null, DateTime? period = null)
	{
		((ControllerBase)this).get_ViewData().set_Item("MarkLoad", (object)true);
		CompanySettings companySettings = LoadSettings();
		CompanySettings oldSettings = new CompanySettings(companySettings);
		companySettings.IsNew = true;
		SearchType searchType = companySettings.LastSearchType;
		bool flag = base.SecurityService.HasPermission(EleWise.ELMA.Security.PermissionProvider.AbsenceUsePermission);
		bool flag2 = base.SecurityService.HasPermission(EleWise.ELMA.Security.PermissionProvider.ReplacementUsePermission);
		bool flag3 = base.SecurityService.HasPermission(EleWise.ELMA.Tasks.PermissionProvider.CompanyAllIndicatorsPermission);
		((ControllerBase)this).get_ViewData().Add("AllowAbsence", (object)flag);
		((ControllerBase)this).get_ViewData().Add("AllowReplacement", (object)flag2);
		((ControllerBase)this).get_ViewData().Add("AllIndicators", (object)flag3);
		IEnumerable<EleWise.ELMA.Security.Models.IUser> enumerable = new List<EleWise.ELMA.Security.Models.IUser>();
		if (keyFeature.HasValue)
		{
			companySettings.KeyFeature = keyFeature.Value;
		}
		if (companySettings.KeyFeature == KeyIndicator.WorkLog && !WorkLogSettingsHelper.WorkLogEnabled())
		{
			companySettings.KeyFeature = KeyIndicator.None;
		}
		if (period.HasValue)
		{
			companySettings.Period = period.Value;
		}
		DateTime dateTime = (period.HasValue ? period.Value : companySettings.Period);
		if (searchType != SearchType.LastSearch)
		{
			if (searchType == SearchType.Department && !UserManager.Instance.HaveSubordinatesForUser(GetCurrentUser()))
			{
				searchType = SearchType.Company;
			}
			IUserFilter userFilter = InterfaceActivator.Create<IUserFilter>();
			userFilter.ShowBlock = false;
			userFilter.ShowOnlySubordinateAndSelf = searchType == SearchType.Department;
			if (searchType == SearchType.New)
			{
				DateTime dateTime2 = ((companySettings.Period.Year == DateTime.Now.Year && companySettings.Period.Month == DateTime.Now.Month) ? companySettings.Period.AddMonths(-1) : companySettings.Period);
				userFilter.EmployDate = new DateTimeRange(new DateTime(dateTime2.Year, dateTime2.Month, 1, 0, 0, 0), new DateTime(companySettings.Period.Year, companySettings.Period.Month, DateTime.DaysInMonth(companySettings.Period.Year, companySettings.Period.Month), 23, 59, 59));
			}
			string sortExpression = "FullName";
			ListSortDirection sortDirection = ListSortDirection.Ascending;
			if (searchType == SearchType.New)
			{
				sortExpression = "EmployDate";
				sortDirection = ListSortDirection.Descending;
			}
			enumerable = ((searchType != SearchType.BirthDays) ? UserManager.Instance.Find(userFilter, new FetchOptions(0, 15, sortDirection, sortExpression)) : UserManager.Instance.FindOrderedBirthDateUsers(new DateTimeRange
			{
				From = DateTime.Today,
				To = DateTime.Today.AddMonths(1)
			}, new FetchOptions
			{
				MaxResults = 15
			}));
			CompanyModel companyModel = new CompanyModel(enumerable, companySettings.KeyFeature, dateTime)
			{
				SearchType = searchType,
				Count = CompanyHelper.Count(searchType, dateTime),
				NewCount = CompanyHelper.Count(SearchType.New, dateTime),
				BirthDatesCount = CompanyHelper.Count(SearchType.BirthDays)
			};
			companySettings.LoadedUsersIds = enumerable.Select((EleWise.ELMA.Security.Models.IUser u) => u.Id).ToList();
			companySettings.ClearCheckedUsers(clearPrevious: true);
			SaveSettings(companySettings, oldSettings);
			return (ActionResult)(object)((Controller)this).View((object)companyModel);
		}
		enumerable = UserManager.Instance.FindByIdArray(companySettings.LastUsersIds.ToArray());
		CompanyModel companyModel2 = new CompanyModel(enumerable, companySettings.KeyFeature, dateTime)
		{
			SearchType = searchType,
			Count = enumerable.Count(),
			NewCount = CompanyHelper.Count(SearchType.New, dateTime),
			BirthDatesCount = CompanyHelper.Count(SearchType.BirthDays)
		};
		companySettings.LoadedUsersIds = companySettings.LastUsersIds;
		companySettings.ClearCheckedUsers(clearPrevious: true);
		SaveSettings(companySettings, oldSettings);
		return (ActionResult)(object)((Controller)this).View((object)companyModel2);
	}

	public ActionResult SelectUsers(long[] usersToLoad, DateTime period, long[] usersToCheck = null, SearchType searchType = SearchType.LastSearch, bool checkUsers = false, bool clearState = false)
	{
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		CompanySettings companySettings = PersonalizationAdministration.LoadState<CompanySettings>(Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>().UserName, "Tasks-CompanySettings") ?? new CompanySettings();
		bool flag = base.SecurityService.HasPermission(EleWise.ELMA.Security.PermissionProvider.AbsenceUsePermission);
		bool flag2 = base.SecurityService.HasPermission(EleWise.ELMA.Security.PermissionProvider.ReplacementUsePermission);
		bool flag3 = base.SecurityService.HasPermission(EleWise.ELMA.Tasks.PermissionProvider.CompanyAllIndicatorsPermission);
		((ControllerBase)this).get_ViewData().Add("AllowAbsence", (object)flag);
		((ControllerBase)this).get_ViewData().Add("AllowReplacement", (object)flag2);
		((ControllerBase)this).get_ViewData().Add("AllIndicators", (object)flag3);
		if (clearState)
		{
			companySettings.ClearLastUsers();
			companySettings.ClearCheckedUsers();
		}
		if (usersToLoad != null && usersToLoad.Any())
		{
			long[] array = usersToLoad;
			foreach (long userId in array)
			{
				companySettings.AddLastUser(userId);
				companySettings.AddLoadedUser(userId);
				companySettings.AddCheckedUser(userId);
			}
		}
		if (usersToCheck != null && usersToCheck.Any())
		{
			long[] array = usersToCheck;
			foreach (long userId2 in array)
			{
				companySettings.AddLastUser(userId2);
				companySettings.AddCheckedUser(userId2);
			}
		}
		SaveSettings(companySettings);
		if (usersToLoad == null || !usersToLoad.Any())
		{
			return (ActionResult)new EmptyResult();
		}
		CompanyModel companyModel = new CompanyModel(UserManager.Instance.FindByIdArray(usersToLoad.ToArray()), companySettings.KeyFeature, period)
		{
			SearchType = searchType,
			Period = period,
			KeyFeature = companySettings.KeyFeature,
			Count = -1L
		};
		((ControllerBase)this).get_ViewData().set_Item("CheckUsers", (object)checkUsers);
		return (ActionResult)(object)((Controller)this).PartialView("Users", (object)companyModel);
	}

	[HttpPost]
	public ActionResult LoadUsers(int lastId, DateTime period, SearchType searchType, bool checkUsers = false)
	{
		CompanySettings state = LoadSettings();
		CompanySettings oldSettings = new CompanySettings(state);
		if (state.LastSearchType != searchType)
		{
			state.ClearLoadedUsers();
		}
		state.LastSearchType = searchType;
		bool flag = base.SecurityService.HasPermission(EleWise.ELMA.Security.PermissionProvider.AbsenceUsePermission);
		bool flag2 = base.SecurityService.HasPermission(EleWise.ELMA.Security.PermissionProvider.ReplacementUsePermission);
		bool flag3 = base.SecurityService.HasPermission(EleWise.ELMA.Tasks.PermissionProvider.CompanyAllIndicatorsPermission);
		((ControllerBase)this).get_ViewData().Add("AllowAbsence", (object)flag);
		((ControllerBase)this).get_ViewData().Add("AllowReplacement", (object)flag2);
		((ControllerBase)this).get_ViewData().Add("AllIndicators", (object)flag3);
		if (searchType != SearchType.LastSearch)
		{
			IUserFilter userFilter = InterfaceActivator.Create<IUserFilter>();
			userFilter.ShowBlock = false;
			userFilter.ShowOnlySubordinateAndSelf = searchType == SearchType.Department;
			if (lastId == 0)
			{
				state.PreviousLoadedUsersIds = state.CheckedUsersIds;
				state.IsNew = state.CheckedUsersIds == null || !state.CheckedUsersIds.Any();
			}
			if (state.PreviousLoadedUsersIds != null && state.PreviousLoadedUsersIds.Any())
			{
				userFilter.Query = string.Format("NOT Id IN ({0})", string.Join(",", state.PreviousLoadedUsersIds));
			}
			if (searchType == SearchType.New)
			{
				DateTime dateTime = ((state.Period.Year == DateTime.Now.Year && state.Period.Month == DateTime.Now.Month) ? state.Period.AddMonths(-1) : state.Period);
				userFilter.EmployDate = new DateTimeRange(new DateTime(dateTime.Year, dateTime.Month, 1, 0, 0, 0), new DateTime(state.Period.Year, state.Period.Month, DateTime.DaysInMonth(state.Period.Year, state.Period.Month), 23, 59, 59));
			}
			string sortExpression = "FullName";
			ListSortDirection sortDirection = ListSortDirection.Ascending;
			if (searchType == SearchType.New)
			{
				sortExpression = "EmployDate";
				sortDirection = ListSortDirection.Descending;
			}
			IEnumerable<EleWise.ELMA.Security.Models.IUser> enumerable;
			if (searchType == SearchType.BirthDays)
			{
				enumerable = UserManager.Instance.FindOrderedBirthDateUsers(new DateTimeRange
				{
					From = DateTime.Today,
					To = DateTime.Today.AddMonths(1)
				}, new FetchOptions
				{
					FirstResult = lastId,
					MaxResults = 15
				});
			}
			else
			{
				enumerable = UserManager.Instance.Find(userFilter, new FetchOptions(lastId, 15, sortDirection, sortExpression));
				if (lastId > 0)
				{
					enumerable = enumerable.Where((EleWise.ELMA.Security.Models.IUser u) => !state.LoadedUsersIds.Contains(u.Id)).ToList();
				}
			}
			CompanyModel companyModel = new CompanyModel(enumerable, state.KeyFeature, period)
			{
				SearchType = searchType,
				Period = period,
				KeyFeature = state.KeyFeature,
				Count = CompanyHelper.Count(searchType, period)
			};
			((ControllerBase)this).get_ViewData().set_Item("MarkLoad", (object)true);
			foreach (EleWise.ELMA.Security.Models.IUser item in enumerable)
			{
				state.AddLoadedUser(item.Id);
			}
			SaveSettings(state, oldSettings);
			return (ActionResult)(object)((Controller)this).PartialView("Users", (object)companyModel);
		}
		ICollection<EleWise.ELMA.Security.Models.IUser> collection = UserManager.Instance.FindByIdArray(state.LastUsersIds.Where((long id) => !state.CheckedUsersIds.Contains(id)).ToArray());
		foreach (EleWise.ELMA.Security.Models.IUser item2 in collection)
		{
			state.AddLoadedUser(item2.Id);
		}
		CompanyModel companyModel2 = new CompanyModel(collection, state.KeyFeature, period)
		{
			SearchType = searchType,
			Period = period,
			KeyFeature = state.KeyFeature,
			Count = collection.Count
		};
		((ControllerBase)this).get_ViewData().set_Item("MarkLoad", (object)true);
		SaveSettings(state, oldSettings);
		return (ActionResult)(object)((Controller)this).PartialView("Users", (object)companyModel2);
	}

	public JsonResult DeleteUsers(long[] users, bool forgetAll = false)
	{
		CompanySettings companySettings = LoadSettings();
		if (forgetAll)
		{
			companySettings.ClearLastUsers();
			companySettings.ClearCheckedUsers();
		}
		else
		{
			foreach (long userId in users)
			{
				companySettings.RemoveLastUser(userId);
				companySettings.RemoveCheckedUser(userId);
			}
		}
		SaveSettings(companySettings);
		return ((Controller)this).Json((object)new
		{
			result = "success"
		});
	}

	public JsonResult RememberUsers(long[] users)
	{
		CompanySettings companySettings = LoadSettings();
		foreach (long userId in users)
		{
			companySettings.AddLastUser(userId);
			companySettings.AddCheckedUser(userId);
			companySettings.AddLoadedUser(userId);
		}
		SaveSettings(companySettings);
		return ((Controller)this).Json((object)new
		{
			result = "success"
		});
	}

	public JsonResult StaySelectedUsers(long[] users)
	{
		CompanySettings companySettings = LoadSettings();
		companySettings.LastUsersIds = users.ToList();
		companySettings.LoadedUsersIds = users.ToList();
		SaveSettings(companySettings);
		return ((Controller)this).Json((object)new
		{
			result = "success"
		});
	}

	public ActionResult GetUserPerformance(long userId, DateTime periodStart, DateTime periodEnd)
	{
		((ControllerBase)this).get_ViewData().set_Item("PeriodStart", (object)periodStart);
		((ControllerBase)this).get_ViewData().set_Item("periodEnd", (object)periodEnd);
		return (ActionResult)(object)((Controller)this).PartialView("DepartmentUserDetails", (object)UserManager.Instance.Load(userId));
	}

	public JsonResult CloseGroup()
	{
		CompanySettings companySettings = LoadSettings();
		companySettings.IsNew = true;
		companySettings.ClearCheckedUsers();
		SaveSettings(companySettings);
		return ((Controller)this).Json((object)new
		{
			result = "success"
		});
	}

	private CompanySettings LoadSettings()
	{
		return PersonalizationAdministration.LoadState<CompanySettings>(GetCurrentUser().UserName, "Tasks-CompanySettings") ?? new CompanySettings();
	}

	private void SaveSettings(CompanySettings newSettings, CompanySettings oldSettings = null)
	{
		Contract.ArgumentNotNull(newSettings, "newSettings");
		if (oldSettings != null && newSettings.Equals(oldSettings))
		{
			return;
		}
		EleWise.ELMA.Security.Models.IUser currentUser = GetCurrentUser();
		ITransaction val = SessionProvider.GetSession(string.Empty).BeginTransaction();
		try
		{
			PersonalizationAdministration.SaveState(currentUser.UserName, "Tasks-CompanySettings", newSettings);
			val.Commit();
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
