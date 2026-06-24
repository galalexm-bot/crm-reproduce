using System;
using EleWise.ELMA.BPM.Common.Models;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class AutoResizeTextboxModel
{
	public string EmptyText { get; set; }

	public string ClientId { get; set; }

	public bool PostCommentEnterKey { get; set; }

	public string DescriptionText { get; set; }

	public bool ShowCommentOnlyFocus { get; set; }

	public string Text { get; set; }

	public string MaxLength { get; set; }

	public int MaxHeight { get; set; }

	public Func<dynamic, object> TopElements { get; set; }

	public bool CanBeEmpty { get; set; }

	public AutoResizeTextboxModel()
	{
		PostCommentEnterKey = GetPostCommentEnterKey();
		EmptyText = SR.T("Оставить комментарий");
		ShowCommentOnlyFocus = false;
	}

	private bool GetPostCommentEnterKey()
	{
		return ContextVars.GetOrAdd("FastCommentAutoResizeTextboxModel", delegate
		{
			IUser currentUser = AuthenticationService.GetCurrentUser<IUser>();
			if (currentUser != null)
			{
				FastCommentSettingsModel fastCommentSettingsModel = PersonalizationAdministration.LoadState<FastCommentSettingsModel>(currentUser.UserName, "FastCommentSettingsModel");
				if (fastCommentSettingsModel != null)
				{
					return fastCommentSettingsModel.PostCommentEnterKey;
				}
			}
			return true;
		});
	}
}
