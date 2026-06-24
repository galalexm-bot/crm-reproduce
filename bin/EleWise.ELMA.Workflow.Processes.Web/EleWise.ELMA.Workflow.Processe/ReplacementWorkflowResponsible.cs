using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Components;

[Component]
internal class ReplacementWorkflowResponsibleBlockUserActionExtension : IBlockUserActionExtension
{
	public IMessageManager MessageManager { get; set; }

	public WorkflowInstanceManager WorkflowInstanceManager { get; set; }

	public void HandleModel(IBlockUserModel model)
	{
		if (!(model is IBlockUserReplacementWorkflowResponsibleModel blockUserReplacementWorkflowResponsibleModel))
		{
			return;
		}
		InstanceOf<IWorkflowInstanceFilter> instanceOf = new InstanceOf<IWorkflowInstanceFilter>();
		instanceOf.New.GeneralStatus = WorkflowInstanceGeneralStatus.Current;
		instanceOf.New.Responsible = blockUserReplacementWorkflowResponsibleModel.BlockUser;
		IWorkflowInstanceFilter @new = instanceOf.New;
		IDictionary<IWorkflowInstance, ICollection<IUser>> processOwners = WorkflowInstanceManager.GetProcessOwners(@new);
		if (!blockUserReplacementWorkflowResponsibleModel.ChangeResponsible)
		{
			foreach (KeyValuePair<IWorkflowInstance, ICollection<IUser>> item in processOwners)
			{
				if (item.Value != null && item.Value.Any())
				{
					SendOwnersMessage(item.Value, item.Key, blockUserReplacementWorkflowResponsibleModel.BlockUser);
				}
			}
			return;
		}
		if (!IsValid(blockUserReplacementWorkflowResponsibleModel))
		{
			throw new ArgumentException(SR.T("Ошибка переназначения ответственного за процесс"));
		}
		foreach (KeyValuePair<IWorkflowInstance, ICollection<IUser>> item2 in processOwners)
		{
			WorkflowInstanceManager.ChangeResponsible(item2.Key, blockUserReplacementWorkflowResponsibleModel.ResponsibleUser);
		}
	}

	public MvcHtmlString RenderFormInputs(HtmlHelper helper, IUser user)
	{
		if (!(InterfaceActivator.Create<IBlockUserModel>() is IBlockUserReplacementWorkflowResponsibleModel blockUserReplacementWorkflowResponsibleModel))
		{
			return MvcHtmlString.Empty;
		}
		return PartialExtensions.Partial(helper, "ReplacementWorkflowResponsibleBlockUserInputs", (object)blockUserReplacementWorkflowResponsibleModel);
	}

	private bool IsValid(IBlockUserReplacementWorkflowResponsibleModel blockUserModel)
	{
		if (blockUserModel.BlockUser != null && blockUserModel.ResponsibleUser != null)
		{
			return blockUserModel.BlockUser != blockUserModel.ResponsibleUser;
		}
		return false;
	}

	private void SendOwnersMessage(IEnumerable<IUser> users, IWorkflowInstance workflowInstance, IUser blockUser)
	{
		IMessage message = MessageManager.Create();
		message.Recipient = users;
		message.Subject = SR.T("Переназначить ответственного за экземпляр процесса");
		message.Author = null;
		message.ObjectUid = InterfaceActivator.UID<IWorkflowInstance>();
		message.ActionUid = WorkflowInstanceActions.NotificationGuid;
		message.ObjectId = workflowInstance.Id.ToString(CultureInfo.InvariantCulture);
		message.FullMessageText = SR.T("Необходимо переназначить ответственного за экземпляр процесса, так как пользователь {0} был заблокирован", blockUser.GetShortName());
		message.ShortMessageText = SR.T("Необходимо переназначить ответственного за экземпляр процесса");
		MessageManager.Send(message);
	}
}
