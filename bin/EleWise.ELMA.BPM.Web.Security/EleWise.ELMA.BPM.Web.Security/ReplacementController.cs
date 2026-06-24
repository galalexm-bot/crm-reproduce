using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.Model.Ranges;
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
public class ReplacementController : BPMController<IReplacement, long>
{
	public UserManager UserManager { get; set; }

	public ReplacementManager ReplacementManager { get; set; }

	public AbsenceManager AbsenceManager { get; set; }

	public ActionResult Create(long? idUser = null, long? idAbsence = null)
	{
		ReplacementManagmentType replacementManagmentType = GetReplacementManagmentType();
		if (replacementManagmentType == ReplacementManagmentType.None)
		{
			throw new SecurityException(SR.T("Недостаточно прав для создания замещения"));
		}
		ReplacementModel replacementModel = new ReplacementModel();
		InstanceOf<IReplacement> instanceOf = new InstanceOf<IReplacement>();
		instanceOf.New.StartDate = DateTime.Today;
		instanceOf.New.EndDate = DateTime.Today;
		replacementModel.Replacement = instanceOf.New;
		replacementModel.ReplacementManagmentType = replacementManagmentType;
		ReplacementModel replacementModel2 = replacementModel;
		if (idUser.HasValue && replacementManagmentType == ReplacementManagmentType.All)
		{
			replacementModel2.Replacement.SourceUser = UserManager.Load(idUser.Value);
		}
		if (replacementManagmentType == ReplacementManagmentType.OnlyMy)
		{
			replacementModel2.Replacement.SourceUser = base.AuthenticationService.GetCurrentUser() as EleWise.ELMA.Security.Models.IUser;
		}
		if (idAbsence.HasValue)
		{
			IAbsence absence = AbsenceManager.LoadOrNull(idAbsence.Value);
			if (absence != null)
			{
				replacementModel2.Replacement.SourceUser = absence.User;
				replacementModel2.Replacement.StartDate = absence.StartDate;
				replacementModel2.Replacement.EndDate = absence.EndDate;
			}
		}
		return (ActionResult)(object)((Controller)this).View("Edit", (object)replacementModel2);
	}

	[HttpPost]
	public ActionResult Create(ReplacementModel model)
	{
		ReplacementManagmentType replacementManagmentType = GetReplacementManagmentType();
		switch (replacementManagmentType)
		{
		case ReplacementManagmentType.None:
			throw new SecurityException(SR.T("Недостаточно прав для создания замещения"));
		case ReplacementManagmentType.OnlyMy:
			if (base.AuthenticationService.GetCurrentUser() != model.Replacement.SourceUser)
			{
				throw new SecurityException(SR.T("Недостаточно прав для создания замещения"));
			}
			break;
		}
		if (model.Replacement.SourceUser == model.Replacement.TargetUser)
		{
			base.Notifier.Error(SR.T("Пользователь не может заместить сам себя!"));
			return (ActionResult)(object)((Controller)this).View("Edit", (object)model);
		}
		IList<IAbsence> list = AbsenceManager.FindIntersection(model.Replacement.TargetUser, model.Replacement.StartDate, model.Replacement.EndDate);
		if (list.Count > 0)
		{
			string text = list.Aggregate("", (string current, IAbsence absence) => current + SR.T("с {0} по {1}, ", absence.StartDate.Date.ToShortDateString(), absence.EndDate.Date.ToShortDateString()));
			text = text.TrimEnd(',', ' ');
			base.Notifier.Error(SR.T("Замещающий пользователь {0} отсутствует {1}.", model.Replacement.TargetUser.FullName, text));
			return (ActionResult)(object)((Controller)this).View("Edit", (object)model);
		}
		IList<IReplacement> list2 = ReplacementManager.FindPlannedReplacement(model.Replacement.SourceUser, model.Replacement.TargetUser, model.Replacement.StartDate, model.Replacement.EndDate);
		IList<IReplacementRule> list3 = ReplacementRuleManager.Instance.FindPlannedReplacementRule(model.Replacement.SourceUser, model.Replacement.TargetUser, model.Replacement.StartDate, model.Replacement.EndDate);
		if (list2.Count == 0 && list3.Count == 0)
		{
			ReplacementManager.PutReplacement(model.Replacement);
			if (replacementManagmentType == ReplacementManagmentType.All)
			{
				return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
			}
			base.Notifier.Information(SR.T("Замещение создано"));
			return (ActionResult)(object)((Controller)this).RedirectToAction("CurrentProfile", "User");
		}
		model.IntersectionReplacement = list2;
		model.IntersectionReplacementRule = list3;
		return (ActionResult)(object)((Controller)this).View("Edit", (object)model);
	}

	[AnyPermission(new string[] { "08EE866C-5B8F-4D91-8BD7-0036B8DBAA0C", "8AA2A0A4-2BD9-4F3B-8487-CAE95D6249D4" })]
	public ActionResult Edit(long id)
	{
		ReplacementModel replacementModel = new ReplacementModel
		{
			Replacement = base.Manager.LoadOrNull(id)
		};
		return (ActionResult)(object)((Controller)this).View((object)replacementModel);
	}

	[HttpPost]
	[AnyPermission(new string[] { "08EE866C-5B8F-4D91-8BD7-0036B8DBAA0C", "8AA2A0A4-2BD9-4F3B-8487-CAE95D6249D4" })]
	public ActionResult Edit(ReplacementModel model)
	{
		if (((Controller)this).get_ModelState().get_IsValid())
		{
			if (model.Replacement.SourceUser == model.Replacement.TargetUser)
			{
				base.Notifier.Error(SR.T("Пользователь не может заместить сам себя!"));
				return (ActionResult)(object)((Controller)this).View((object)model);
			}
			IList<IReplacement> list = ReplacementManager.FindPlannedReplacement(model.Replacement.SourceUser, model.Replacement.TargetUser, model.Replacement.StartDate, model.Replacement.EndDate, model.Replacement.Id);
			IList<IReplacementRule> list2 = ReplacementRuleManager.Instance.FindPlannedReplacementRule(model.Replacement.SourceUser, model.Replacement.TargetUser, model.Replacement.StartDate, model.Replacement.EndDate, model.Replacement.Id);
			if (list.Count != 0 || list2.Count != 0)
			{
				model.IntersectionReplacement = list;
				model.IntersectionReplacementRule = list2;
				return (ActionResult)(object)((Controller)this).View((object)model);
			}
			ReplacementManager.PutReplacement(model.Replacement);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction((GetReplacementManagmentType() == ReplacementManagmentType.OnlyMy) ? "OwnIndex" : "Index");
	}

	[AnyPermission(new string[] { "08EE866C-5B8F-4D91-8BD7-0036B8DBAA0C", "8AA2A0A4-2BD9-4F3B-8487-CAE95D6249D4" })]
	public ActionResult Delete(IReplacement replacement)
	{
		ReplacementManagmentType replacementManagmentType = GetReplacementManagmentType();
		bool flag = replacementManagmentType == ReplacementManagmentType.OnlyMy;
		if ((flag && replacement.SourceUser == GetCurrentUser()) || replacementManagmentType == ReplacementManagmentType.All)
		{
			ReplacementManager.Delete(replacement);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction(flag ? "OwnIndex" : "Index");
	}

	[AnyPermission(new string[] { "08EE866C-5B8F-4D91-8BD7-0036B8DBAA0C", "8AA2A0A4-2BD9-4F3B-8487-CAE95D6249D4" })]
	public ActionResult Complete(EleWise.ELMA.Security.Models.IUser user)
	{
		ReplacementManagmentType replacementManagmentType = GetReplacementManagmentType();
		bool flag = replacementManagmentType == ReplacementManagmentType.OnlyMy;
		if ((flag && user == GetCurrentUser()) || replacementManagmentType == ReplacementManagmentType.All)
		{
			ReplacementManager.Complete(user.Replacement);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction(flag ? "OwnIndex" : "Index");
	}

	[AnyPermission(new string[] { "08EE866C-5B8F-4D91-8BD7-0036B8DBAA0C", "8AA2A0A4-2BD9-4F3B-8487-CAE95D6249D4" })]
	public ActionResult CompleteReplacement(IReplacement replacement)
	{
		ReplacementManagmentType replacementManagmentType = GetReplacementManagmentType();
		bool flag = replacementManagmentType == ReplacementManagmentType.OnlyMy;
		EleWise.ELMA.Security.Models.IUser currentUser = GetCurrentUser();
		if ((flag && (replacement.SourceUser == currentUser || replacement.TargetUser == currentUser)) || replacementManagmentType == ReplacementManagmentType.All)
		{
			ReplacementManager.Complete(replacement);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction(flag ? "OwnIndex" : "Index");
	}

	[EntityListLink(typeof(IReplacement))]
	[ContentItem(Name = "SR.M('Замещения')", Image24 = "~/Content/IconPack/replacement.svg")]
	[Permission("08EE866C-5B8F-4D91-8BD7-0036B8DBAA0C")]
	public ActionResult Index()
	{
		return (ActionResult)(object)((Controller)this).View();
	}

	[CustomGridAction]
	[Permission("08EE866C-5B8F-4D91-8BD7-0036B8DBAA0C")]
	public ActionResult GridSchedule(GridCommand command)
	{
		InstanceOf<IReplacementFilter> instanceOf = new InstanceOf<IReplacementFilter>();
		instanceOf.New.Status = ReplacementStatus.Active;
		instanceOf.New.EndDate = new DateTimeRange
		{
			From = DateTime.Today
		};
		IReplacementFilter @new = instanceOf.New;
		GridData<IReplacement, IReplacementFilter> gridData = CreateGridData(command, @new);
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	[CustomGridAction]
	[Permission("08EE866C-5B8F-4D91-8BD7-0036B8DBAA0C")]
	public ActionResult GridCurrent(GridCommand command)
	{
		InstanceOf<IUserFilter> instanceOf = new InstanceOf<IUserFilter>();
		instanceOf.New.ShowOnlyReplacement = true;
		IUserFilter @new = instanceOf.New;
		GridData<EleWise.ELMA.Security.Models.IUser, IUserFilter> gridData = UserManager.CreateGridData(command, @new);
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	[AnyPermission(new string[] { "08EE866C-5B8F-4D91-8BD7-0036B8DBAA0C", "8AA2A0A4-2BD9-4F3B-8487-CAE95D6249D4" })]
	public ActionResult OwnIndex()
	{
		return (ActionResult)(object)((Controller)this).View();
	}

	[CustomGridAction]
	[AnyPermission(new string[] { "08EE866C-5B8F-4D91-8BD7-0036B8DBAA0C", "8AA2A0A4-2BD9-4F3B-8487-CAE95D6249D4" })]
	public ActionResult OwnGridSchedule(GridCommand command)
	{
		InstanceOf<IReplacementFilter> instanceOf = new InstanceOf<IReplacementFilter>();
		instanceOf.New.Query = string.Format("TargetUser = {0} OR SourceUser = {0}", GetCurrentUser().Id);
		instanceOf.New.Status = ReplacementStatus.Active;
		instanceOf.New.EndDate = new DateTimeRange
		{
			From = DateTime.Today
		};
		IReplacementFilter @new = instanceOf.New;
		GridData<IReplacement, IReplacementFilter> gridData = CreateGridData(command, @new);
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	[CustomGridAction]
	[AnyPermission(new string[] { "08EE866C-5B8F-4D91-8BD7-0036B8DBAA0C", "8AA2A0A4-2BD9-4F3B-8487-CAE95D6249D4" })]
	public ActionResult OwnGridCurrent(GridCommand command)
	{
		InstanceOf<IReplacementFilter> instanceOf = new InstanceOf<IReplacementFilter>();
		instanceOf.New.Query = string.Format("TargetUser = {0} OR SourceUser = {0}", GetCurrentUser().Id);
		instanceOf.New.Status = ReplacementStatus.Active;
		instanceOf.New.StartDate = new DateTimeRange
		{
			To = DateTime.Today.AddDays(1.0).AddMinutes(-1.0)
		};
		instanceOf.New.EndDate = new DateTimeRange
		{
			From = DateTime.Today
		};
		IReplacementFilter @new = instanceOf.New;
		GridData<IReplacement, IReplacementFilter> gridData = CreateGridData(command, @new);
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	private ReplacementManagmentType GetReplacementManagmentType()
	{
		if (base.SecurityService.HasPermission(PermissionProvider.ReplacementUsePermission))
		{
			return ReplacementManagmentType.All;
		}
		if (base.SecurityService.HasPermission(PermissionProvider.ReplacementOwnPermission))
		{
			return ReplacementManagmentType.OnlyMy;
		}
		return ReplacementManagmentType.None;
	}
}
