using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component]
internal class ReplacementTaskBlockUserActionExtension : IBlockUserActionExtension
{
	public ReplacementTaskManager Manager { get; set; }

	public IAuthenticationService AuthenticationService { get; set; }

	public void HandleModel(IBlockUserModel model)
	{
		if (!(model is IBlockUserReplacementTaskModel))
		{
			return;
		}
		IBlockUserReplacementTaskModel blockUserReplacementTaskModel = (IBlockUserReplacementTaskModel)model;
		if (blockUserReplacementTaskModel.CreateBlockUserTask)
		{
			if (!ModelStateIsValid(blockUserReplacementTaskModel))
			{
				throw new ArgumentException(SR.T("Ошибка создания задачи назначения заместителей"));
			}
			IReplacementTask replacementTask = blockUserReplacementTaskModel.ReplacementTask;
			replacementTask.BlockedUser = model.BlockUser;
			replacementTask.Status = TaskBaseStatus.NewOrder;
			replacementTask.Subject = SR.T("Переназначить активные задачи блокированного пользователя ({0})", blockUserReplacementTaskModel.BlockUser.FullName);
			replacementTask.NotShowInLists = false;
			Manager.Save(replacementTask);
		}
	}

	public MvcHtmlString RenderFormInputs(HtmlHelper helper, IUser user)
	{
		if (!(InterfaceActivator.Create<IBlockUserModel>() is IBlockUserReplacementTaskModel blockUserReplacementTaskModel))
		{
			return MvcHtmlString.Empty;
		}
		IReplacementTask replacementTask = Manager.Create();
		replacementTask.Executor = AuthenticationService.GetCurrentUser<IUser>();
		replacementTask.StartDate = DateTime.Now;
		replacementTask.EndDate = DateTime.Now;
		blockUserReplacementTaskModel.ReplacementTask = replacementTask;
		blockUserReplacementTaskModel.CreateBlockUserTask = false;
		return PartialExtensions.Partial(helper, "ReplacementTask/ReplacementTaskBlockUserInputs", (object)blockUserReplacementTaskModel);
	}

	private bool ModelStateIsValid(IBlockUserReplacementTaskModel model)
	{
		IReplacementTask replacementTask = model.ReplacementTask;
		if (!model.CreateBlockUserTask)
		{
			return model.BlockUser != null;
		}
		if (replacementTask.Executor != null && model.BlockUser != null)
		{
			return replacementTask.Executor != model.BlockUser;
		}
		return false;
	}
}
