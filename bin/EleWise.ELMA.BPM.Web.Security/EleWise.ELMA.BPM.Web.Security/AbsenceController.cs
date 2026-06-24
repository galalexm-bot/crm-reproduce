using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.BPM.Web.Security.Portlets;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Security.Controllers;

[RouteArea("EleWise.ELMA.BPM.Web.Security")]
public class AbsenceController : BPMController<IAbsence, long>
{
	public AbsenceManager AbsenceManager { get; set; }

	public UserManager UserManager { get; set; }

	public ActionResult Create(long? idUser = null)
	{
		AbsenceManagmentType absenceManagmentType = GetAbsenceManagmentType();
		if (absenceManagmentType == AbsenceManagmentType.None)
		{
			throw new SecurityException(SR.T("Недостаточно прав для назначения отсутствия"));
		}
		InstanceOf<IAbsence> instanceOf = new InstanceOf<IAbsence>();
		instanceOf.New.StartDate = DateTime.Now.NormalizeStartDate(time: false);
		instanceOf.New.EndDate = DateTime.Now.NormalizeEndDate(time: false);
		IAbsence @new = instanceOf.New;
		if (idUser.HasValue && absenceManagmentType == AbsenceManagmentType.All)
		{
			@new.User = UserManager.Load(idUser.Value);
		}
		if (absenceManagmentType == AbsenceManagmentType.OnlyMy)
		{
			@new.User = base.AuthenticationService.GetCurrentUser() as EleWise.ELMA.Security.Models.IUser;
			((ControllerBase)this).get_ViewData().set_Item("UserReadOnly", (object)true);
		}
		return (ActionResult)(object)((Controller)this).View("Edit", (object)@new);
	}

	[HttpPost]
	public ActionResult Create(IAbsence model)
	{
		AbsenceManagmentType absenceManagmentType = GetAbsenceManagmentType();
		switch (absenceManagmentType)
		{
		case AbsenceManagmentType.None:
			throw new SecurityException(SR.T("Недостаточно прав для назначения отсутствия"));
		case AbsenceManagmentType.OnlyMy:
		{
			EleWise.ELMA.Security.Models.IUser user = base.AuthenticationService.GetCurrentUser() as EleWise.ELMA.Security.Models.IUser;
			if (model.User != null && model.User.Id != user.Id)
			{
				throw new SecurityException(SR.T("Недостаточно прав для назначения отсутствия"));
			}
			break;
		}
		}
		if (AbsenceManager.FindIntersection(model.User, model.StartDate, model.EndDate).Count == 0)
		{
			AbsenceManager.Assign(model);
			if (absenceManagmentType == AbsenceManagmentType.All)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
			}
			base.Notifier.Information("Отсутствие назначено");
			return (ActionResult)(object)((Controller)this).RedirectToAction("CurrentProfile", "User");
		}
		base.Notifier.Error(SR.T("На указанное время у пользователя назначено отсутствие"));
		((ControllerBase)this).get_ViewData().set_Item("UserReadOnly", (object)(absenceManagmentType == AbsenceManagmentType.OnlyMy));
		return (ActionResult)(object)((Controller)this).View("Edit", (object)model);
	}

	[AnyPermission(new string[] { "22581049-E783-4F60-BF3F-FAC25C433E30", "C94736CF-EE73-4635-B1CB-C7E6BC315086" })]
	public ActionResult Edit(long id)
	{
		((ControllerBase)this).get_ViewData().set_Item("UserReadOnly", (object)(GetAbsenceManagmentType() == AbsenceManagmentType.OnlyMy));
		IAbsence absence = base.Manager.LoadOrNull(id);
		return (ActionResult)(object)((Controller)this).View((object)(absence ?? base.Manager.Create()));
	}

	[HttpPost]
	[AnyPermission(new string[] { "22581049-E783-4F60-BF3F-FAC25C433E30", "C94736CF-EE73-4635-B1CB-C7E6BC315086" })]
	public ActionResult Edit(IAbsence model)
	{
		if (AbsenceManager.FindIntersection(model.User, model.StartDate, model.EndDate).Count((IAbsence m) => m.Id != model.Id) == 0)
		{
			model.Save();
			return (ActionResult)(object)((Controller)this).RedirectToAction((GetAbsenceManagmentType() == AbsenceManagmentType.OnlyMy) ? "OwnIndex" : "Index");
		}
		base.Notifier.Error(SR.T("На указанное время у пользователя назначено отсутствие"));
		return (ActionResult)(object)((Controller)this).View((object)model);
	}

	[ContentItem(Name = "SR.M('График отсутствий')", Image24 = "#calendar.svg")]
	[Permission("22581049-E783-4F60-BF3F-FAC25C433E30")]
	public ActionResult Index()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		return (ActionResult)(object)((Controller)this).View((object)CreateGridData(new GridCommand(), CreateFilter()));
	}

	[Permission("22581049-E783-4F60-BF3F-FAC25C433E30")]
	protected IAbsenceFilter CreateFilter(IAbsenceFilter filter = null)
	{
		if (filter == null)
		{
			InstanceOf<IAbsenceFilter> instanceOf = new InstanceOf<IAbsenceFilter>();
			instanceOf.New.EndDate = new DateTimeRange(DateTime.Now, null);
			instanceOf.New.Status = AbsenceStatus.Active;
			filter = instanceOf.New;
		}
		return filter;
	}

	[CustomGridAction]
	[Permission("22581049-E783-4F60-BF3F-FAC25C433E30")]
	public ActionResult Grid(GridCommand command, [Bind(Prefix = "DataFilter")] IAbsenceFilter filter)
	{
		GridData<IAbsence, IAbsenceFilter> gridData = CreateGridData(command, CreateFilter(filter));
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	[AnyPermission(new string[] { "22581049-E783-4F60-BF3F-FAC25C433E30", "C94736CF-EE73-4635-B1CB-C7E6BC315086" })]
	public ActionResult Cancel(IAbsence missing)
	{
		AbsenceManagmentType absenceManagmentType = GetAbsenceManagmentType();
		bool flag = absenceManagmentType == AbsenceManagmentType.OnlyMy;
		if ((flag && missing.User == GetCurrentUser()) || absenceManagmentType == AbsenceManagmentType.All)
		{
			AbsenceManager.Cancel(missing);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction(flag ? "OwnIndex" : "Index");
	}

	public ActionResult AbsenceManagementPortlet(AbsenceManagementPortletPersonalization settings)
	{
		return (ActionResult)(object)((Controller)this).PartialView();
	}

	[CustomGridAction]
	public ActionResult PortletGrid(GridCommand command, AbsenceDateRangeEnum interval)
	{
		((ControllerBase)this).get_ViewData().Add("GridId", (object)interval);
		IAbsenceFilter absenceFilter = InterfaceActivator.Create<IAbsenceFilter>();
		absenceFilter.Status = AbsenceStatus.Active;
		switch (interval)
		{
		case AbsenceDateRangeEnum.Today:
			absenceFilter.StartDate = (DateTimeRange)new RelativeDateTime
			{
				IsRelative = true,
				RelativeFrom = null,
				RelativeTo = "0d"
			};
			absenceFilter.EndDate = (DateTimeRange)new RelativeDateTime
			{
				IsRelative = true,
				RelativeFrom = "0d",
				RelativeTo = null
			};
			break;
		case AbsenceDateRangeEnum.Tomorrow:
			absenceFilter.StartDate = (DateTimeRange)new RelativeDateTime
			{
				IsRelative = true,
				RelativeFrom = null,
				RelativeTo = "+1d"
			};
			absenceFilter.EndDate = (DateTimeRange)new RelativeDateTime
			{
				IsRelative = true,
				RelativeFrom = "+1d",
				RelativeTo = null
			};
			break;
		case AbsenceDateRangeEnum.OnTheWeek:
			absenceFilter.StartDate = (DateTimeRange)new RelativeDateTime
			{
				IsRelative = true,
				RelativeFrom = null,
				RelativeTo = "0w"
			};
			absenceFilter.EndDate = (DateTimeRange)new RelativeDateTime
			{
				IsRelative = true,
				RelativeFrom = "0w",
				RelativeTo = null
			};
			break;
		case AbsenceDateRangeEnum.ThisMonth:
			absenceFilter.StartDate = (DateTimeRange)new RelativeDateTime
			{
				IsRelative = true,
				RelativeFrom = null,
				RelativeTo = "0m"
			};
			absenceFilter.EndDate = (DateTimeRange)new RelativeDateTime
			{
				IsRelative = true,
				RelativeFrom = "0m",
				RelativeTo = null
			};
			break;
		case AbsenceDateRangeEnum.NextMonth:
			absenceFilter.StartDate = (DateTimeRange)new RelativeDateTime
			{
				IsRelative = true,
				RelativeFrom = null,
				RelativeTo = "+1m"
			};
			absenceFilter.EndDate = (DateTimeRange)new RelativeDateTime
			{
				IsRelative = true,
				RelativeFrom = "+1m",
				RelativeTo = null
			};
			break;
		}
		ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
		if (!serviceNotNull.HasPermission(PermissionProvider.AbsenceViewPermission) && !serviceNotNull.HasPermission(PermissionProvider.AbsenceUsePermission))
		{
			EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
			List<IOrganizationItem> list = UserManager.GetUserPositions(currentUser).ToList();
			List<EleWise.ELMA.Security.Models.IUser> list2 = new List<EleWise.ELMA.Security.Models.IUser>();
			foreach (IOrganizationItem item in list)
			{
				IOrganizationItem parentItem = item.ParentItem;
				while (parentItem != null && parentItem.ItemType != OrganizationItemType.Position)
				{
					parentItem = parentItem.ParentItem;
				}
				if (parentItem != null && parentItem.User != null && parentItem.User.Status != UserStatus.Blocked)
				{
					list2.Add(parentItem.User);
				}
			}
			absenceFilter.Users.Add(currentUser);
			((ICollection<EleWise.ELMA.Security.Models.IUser>)absenceFilter.Users).AddRange(list2);
			((ICollection<EleWise.ELMA.Security.Models.IUser>)absenceFilter.Users).AddRange(from p in UserManager.GetSubordinateByUser(currentUser)
				where p.Status != UserStatus.Blocked
				select p);
		}
		else
		{
			((ICollection<EleWise.ELMA.Security.Models.IUser>)absenceFilter.Users).AddRange(UserManager.Find(InterfaceActivator.Create<IUserFilter>(), null));
		}
		GridData<IAbsence, IAbsenceFilter> gridData = AbsenceManager.Instance.CreateGridData(command, absenceFilter);
		return GridView(gridData);
	}

	[AnyPermission(new string[] { "22581049-E783-4F60-BF3F-FAC25C433E30", "C94736CF-EE73-4635-B1CB-C7E6BC315086" })]
	public ActionResult OwnIndex()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		return (ActionResult)(object)((Controller)this).View((object)CreateGridData(new GridCommand(), CreateOwnFilter()));
	}

	[CustomGridAction]
	[AnyPermission(new string[] { "22581049-E783-4F60-BF3F-FAC25C433E30", "C94736CF-EE73-4635-B1CB-C7E6BC315086" })]
	public ActionResult OwnGrid(GridCommand command, [Bind(Prefix = "DataFilter")] IAbsenceFilter filter)
	{
		GridData<IAbsence, IAbsenceFilter> gridData = CreateGridData(command, CreateOwnFilter(filter));
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	[AnyPermission(new string[] { "22581049-E783-4F60-BF3F-FAC25C433E30", "C94736CF-EE73-4635-B1CB-C7E6BC315086" })]
	protected IAbsenceFilter CreateOwnFilter(IAbsenceFilter filter = null)
	{
		if (filter == null)
		{
			InstanceOf<IAbsenceFilter> instanceOf = new InstanceOf<IAbsenceFilter>();
			instanceOf.New.EndDate = new DateTimeRange(DateTime.Now, null);
			instanceOf.New.Status = AbsenceStatus.Active;
			filter = instanceOf.New;
			filter.Users.Add(GetCurrentUser());
		}
		return filter;
	}

	private AbsenceManagmentType GetAbsenceManagmentType()
	{
		if (base.SecurityService.HasPermission(PermissionProvider.AbsenceUsePermission))
		{
			return AbsenceManagmentType.All;
		}
		if (base.SecurityService.HasPermission(PermissionProvider.AbsenceOwnPermission))
		{
			return AbsenceManagmentType.OnlyMy;
		}
		return AbsenceManagmentType.None;
	}
}
