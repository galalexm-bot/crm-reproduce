using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Security.Controllers;

[RouteArea("EleWise.ELMA.BPM.Web.Security")]
[Permission("08EE866C-5B8F-4D91-8BD7-0036B8DBAA0C")]
public class ReplacementRuleController : BPMController<IReplacementRule, long>
{
	[Permission("22581049-E783-4F60-BF3F-FAC25C433E30")]
	public ActionResult List(long id)
	{
		IReplacement replacement = ReplacementManager.Instance.LoadOrNull(id);
		if (replacement == null)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Replacement");
		}
		ReplacementRuleModel replacementRuleModel = new ReplacementRuleModel
		{
			Entity = replacement
		};
		return (ActionResult)(object)((Controller)this).View("List", (object)replacementRuleModel);
	}

	[CustomGridAction]
	public ActionResult ReplacementRulesGrid(GridCommand command, string gridId, long replacementId)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		IReplacement replacement = ReplacementManager.Instance.LoadOrNull(replacementId);
		if (replacement == null)
		{
			return (ActionResult)new EmptyResult();
		}
		((ControllerBase)this).get_ViewData().set_Item("GridId", (object)gridId);
		((ControllerBase)this).get_ViewData().set_Item("ReplacementId", (object)replacementId);
		IReplacementRuleFilter filter = InterfaceActivator.Create<IReplacementRuleFilter>();
		filter.Replacement = replacement;
		GridData<IReplacementRule> gridData = new GridData<IReplacementRule>
		{
			Command = command
		};
		gridData.SetCount((GridData<IReplacementRule> d, FetchOptions f) => ReplacementRuleManager.Instance.Count(filter));
		gridData.SetData((IGridData d, FetchOptions f) => ReplacementRuleManager.Instance.Count(filter), (IGridData d, FetchOptions f) => ReplacementRuleManager.Instance.Find(filter, f));
		return (ActionResult)(object)((Controller)this).PartialView("ReplacementRulesGrid", (object)gridData);
	}

	[Permission("22581049-E783-4F60-BF3F-FAC25C433E30")]
	public ActionResult Create(long replacementId)
	{
		IReplacement replacement = ReplacementManager.Instance.LoadOrNull(replacementId);
		if (replacement == null)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Replacement");
		}
		IReplacementRule replacementRule = InterfaceActivator.Create<IReplacementRule>();
		replacementRule.Replacement = replacement;
		ReplacementRuleEditModel replacementRuleEditModel = new ReplacementRuleEditModel
		{
			Entity = replacementRule
		};
		return (ActionResult)(object)((Controller)this).View("EditForm", (object)replacementRuleEditModel);
	}

	[Permission("22581049-E783-4F60-BF3F-FAC25C433E30")]
	public ActionResult Edit(long id)
	{
		IReplacementRule replacementRule = ReplacementRuleManager.Instance.LoadOrNull(id);
		if (replacementRule == null)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
		}
		return (ActionResult)(object)((Controller)this).View("EditForm", (object)new ReplacementRuleEditModel
		{
			Entity = replacementRule
		});
	}

	[HttpPost]
	[Permission("22581049-E783-4F60-BF3F-FAC25C433E30")]
	public ActionResult Delete(long id)
	{
		ReplacementRuleManager.Instance.LoadOrNull(id)?.Delete();
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = true
		}, (JsonRequestBehavior)0);
	}

	[HttpPost]
	[Permission("22581049-E783-4F60-BF3F-FAC25C433E30")]
	public ActionResult Reorder(long replacementId, List<long> ruleList)
	{
		ReplacementRuleManager.Instance.Reorder(replacementId, ruleList);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = true
		}, (JsonRequestBehavior)0);
	}

	[HttpPost]
	public ActionResult Save(ReplacementRuleEditModel model, [Bind(Prefix = "DataFilter.Filter")] IEntityFilter filter)
	{
		IEntityManager entityManagerByFilter = ModelHelper.GetEntityManagerByFilter(filter);
		if (entityManagerByFilter == null)
		{
			throw new ArgumentNullException("manager");
		}
		model.Entity.Filter = UniversalFilterSaver.Pack(filter);
		if (model.Entity.TargetUser.Id == model.Entity.Replacement.SourceUser.Id)
		{
			base.Notifier.Error(SR.T("Пользователь не может заместить сам себя!"));
			return (ActionResult)(object)((Controller)this).View("EditForm", (object)model);
		}
		try
		{
			if (model.Entity.IsNew())
			{
				model.Entity.Order = int.MaxValue;
			}
			entityManagerByFilter.CheckFilter(filter);
		}
		catch (Exception exception)
		{
			base.Notifier.Error(SR.T("Неправильно составлен запрос"));
			EleWise.ELMA.Logging.Logger.Log.Error(SR.T("Неправильно составлен запрос"), exception);
			return (ActionResult)(object)((Controller)this).View("EditForm", (object)model);
		}
		try
		{
			IList<IReplacement> list = ReplacementManager.Instance.FindPlannedReplacement(model.Entity.Replacement.SourceUser, model.Entity.TargetUser, model.Entity.Replacement.StartDate, model.Entity.Replacement.EndDate, model.Entity.Replacement.Id);
			IList<IReplacementRule> list2 = ReplacementRuleManager.Instance.FindPlannedReplacementRule(model.Entity.Replacement.SourceUser, model.Entity.TargetUser, model.Entity.Replacement.StartDate, model.Entity.Replacement.EndDate, model.Entity.Replacement.Id);
			if (list.Count != 0 || list2.Count != 0)
			{
				model.IntersectionReplacement = list;
				model.IntersectionReplacementRule = list2;
				return (ActionResult)(object)((Controller)this).View("EditForm", (object)model);
			}
			model.Entity.Save();
		}
		catch (Exception ex)
		{
			FormNotifierExtensions.Error(base.Notifier, ex);
			EleWise.ELMA.Logging.Logger.Log.Error(ex);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("List", "ReplacementRule", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Security",
			id = model.Entity.Replacement.Id
		});
	}

	public ActionResult ObjectFilter(Guid propertyUid)
	{
		Guid implementationUid = ReplacementRuleManager.Instance.ObjectForProperty(propertyUid).ImplementationUid;
		ObjectFilterModel objectFilterModel = new ObjectFilterModel
		{
			EntityTypeUid = implementationUid
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)objectFilterModel);
	}

	public ActionResult ReorderPopup(long replacementId, string popupId, string callBackFunction)
	{
		IReplacement replacement = ReplacementManager.Instance.LoadOrNull(replacementId);
		if (replacement == null)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "Replacement");
		}
		ReplacementRuleReorderPopupModel replacementRuleReorderPopupModel = new ReplacementRuleReorderPopupModel
		{
			Entity = replacement,
			PopupId = popupId,
			CallBackFunctionName = callBackFunction
		};
		IReplacementRuleFilter replacementRuleFilter = InterfaceActivator.Create<IReplacementRuleFilter>();
		replacementRuleFilter.Replacement = replacement;
		replacementRuleReorderPopupModel.ReplacementRuleList = ReplacementRuleManager.Instance.Find(replacementRuleFilter, FetchOptions.All).ToList();
		return (ActionResult)(object)((Controller)this).PartialView("ReorderPopup", (object)replacementRuleReorderPopupModel);
	}
}
