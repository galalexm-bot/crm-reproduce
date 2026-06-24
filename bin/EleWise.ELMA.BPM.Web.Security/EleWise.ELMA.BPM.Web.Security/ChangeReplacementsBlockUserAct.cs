using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.Components;

[Component]
internal class ChangeReplacementsBlockUserActionExtension : IBlockUserActionExtension
{
	public ReplacementManager ReplacementManager { get; set; }

	public ReplacementRuleManager ReplacementRuleManager { get; set; }

	public UserManager UserManager { get; set; }

	public void HandleModel(IBlockUserModel model)
	{
		if (!(model is IChangeReplacementsBlockUserModel changeReplacementsBlockUserModel) || changeReplacementsBlockUserModel.ChangeTargetUsersModelList == null || changeReplacementsBlockUserModel.ChangeTargetUsersModelList.Count <= 0)
		{
			return;
		}
		foreach (ChangeTargetUsersModel changeTargetUsersModel in changeReplacementsBlockUserModel.ChangeTargetUsersModelList)
		{
			if (changeTargetUsersModel.ReplacementRuleId != 0L)
			{
				IReplacementRule replacementRule = ReplacementRuleManager.Load(changeTargetUsersModel.ReplacementRuleId);
				if (changeTargetUsersModel.NewTargetUser != null)
				{
					replacementRule.TargetUser = changeTargetUsersModel.NewTargetUser;
					ReplacementRuleManager.Save(replacementRule);
				}
				else
				{
					ReplacementRuleManager.Delete(replacementRule);
				}
			}
			else
			{
				IReplacement replacement = ReplacementManager.Load(changeTargetUsersModel.ReplacementId);
				if (changeTargetUsersModel.NewTargetUser != null)
				{
					replacement.TargetUser = changeTargetUsersModel.NewTargetUser;
					ReplacementManager.PutReplacement(replacement);
				}
			}
		}
	}

	public MvcHtmlString RenderFormInputs(HtmlHelper helper, IUser user)
	{
		if (!(InterfaceActivator.Create<IBlockUserModel>() is IChangeReplacementsBlockUserModel changeReplacementsBlockUserModel))
		{
			return null;
		}
		long id = user.Id;
		IList<IReplacement> list = ReplacementManager.FindPlannedReplacement(null, UserManager.Load(id), DateTime.Today, null);
		IList<IReplacementRule> list2 = ReplacementRuleManager.FindPlannedReplacementRule(null, UserManager.Load(id), DateTime.Today, null);
		if (list.Count <= 0 && list2.Count <= 0)
		{
			return null;
		}
		List<ChangeTargetUsersModel> second = list2.Select((IReplacementRule r) => new ChangeTargetUsersModel
		{
			ReplacementId = r.Replacement.Id,
			StartDate = r.Replacement.StartDate,
			EndDate = r.Replacement.EndDate,
			SourceUser = r.Replacement.SourceUser,
			ReplacementRuleId = r.Id,
			ReplacementRuleName = r.Name
		}).ToList();
		IDictionary<long, bool> replacementsHaveRules = ReplacementRuleManager.CheckIfReplacementsHaveRules(list);
		changeReplacementsBlockUserModel.ChangeTargetUsersModelList = list.Select((IReplacement r) => new ChangeTargetUsersModel
		{
			ReplacementId = r.Id,
			StartDate = r.StartDate,
			EndDate = r.EndDate,
			SourceUser = r.SourceUser,
			HasReplacementRules = replacementsHaveRules[r.Id]
		}).Concat(second).ToList();
		changeReplacementsBlockUserModel.BlockUser = user;
		return PartialExtensions.Partial(helper, "User/ChangeReplacementsPopup", (object)changeReplacementsBlockUserModel);
	}
}
