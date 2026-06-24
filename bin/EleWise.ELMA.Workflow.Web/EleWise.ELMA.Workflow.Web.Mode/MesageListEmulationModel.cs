using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.Trees;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Web.Models;

public class MesageListEmulationModel
{
	private class EmulationMessageTreeMenuNode : TreeMenuNode
	{
		public HtmlHelper HtmlHelper { get; set; }

		public long MessageId { get; set; }

		public override string GetEncodedText()
		{
			string text = string.Empty;
			if (HtmlHelper != null)
			{
				text = HtmlHelper.ImageButton("#control.svg").Click(((HtmlString)(object)HtmlHelper.RefreshPopup("EmulationMessagePopup", HtmlHelper.Url().Action("GetEmulationMessage", "ProcessStartEmulation", (object)new
				{
					area = "EleWise.ELMA.Workflow.Web",
					id = MessageId
				}))).ToHtmlString()).Attributes(new
				{
					@class = "tree-item-button",
					tooltiptext = SR.T("Показать сообщение")
				})
					.ToHtmlString();
			}
			return base.GetEncodedText() + text;
		}
	}

	private readonly HtmlHelper htmlHelper;

	public const string MessagePopupId = "EmulationMessagePopup";

	private Dictionary<IWorkflowInstance, List<IWorkflowInstance>> currentSubInstances;

	public TreeModel TreeFeed { get; set; }

	public MesageListEmulationModel()
	{
	}

	public MesageListEmulationModel(HtmlHelper htmlHelper)
	{
		this.htmlHelper = htmlHelper;
	}

	public void LoadFeed(long emulationUid)
	{
		TreeFeed = new TreeModel
		{
			Id = "EmulationMessageTree",
			Children = LoadFeedTree(emulationUid),
			HtmlAttributes = new
			{
				style = "width:100%;height:100%; border: 0px solid #FFF;"
			},
			ShowExpandCollapseButtons = true
		};
	}

	private List<TreeMenuNode> LoadFeedTree(long emulationUid)
	{
		List<TreeMenuNode> list = new List<TreeMenuNode>();
		IEmulationMessagesFilter emulationMessagesFilter = InterfaceActivator.Create<IEmulationMessagesFilter>();
		IWorkflowInstance workflowInstance2 = (emulationMessagesFilter.WorkflowInstance = WorkflowInstanceManager.Instance.LoadOrNull(emulationUid));
		foreach (IWorkflowInstance currentSubInstance in GetCurrentSubInstances(workflowInstance2))
		{
			TreeMenuNode item = new TreeMenuNode
			{
				children = LoadFeedTree(currentSubInstance.Id),
				text = SR.T(currentSubInstance.Process.Name).Trunk(40, "..."),
				expanded = true,
				id = "InstanceCurrentSubInstances_" + workflowInstance2.Id,
				icon = "~/Content/IconPack/process.svg",
				HtmlClass = new List<string> { "EmulationSubInstance" }
			};
			list.Add(item);
		}
		ICollection<IEmulationMessages> collection = EmulationMessagesManager.Instance.Find(emulationMessagesFilter, null);
		IEnumerable<IMessageChannel> extensionPoints = ComponentManager.Current.GetExtensionPoints<IMessageChannel>();
		List<ITaskBase> list2 = new List<ITaskBase>();
		foreach (IEmulationMessages item5 in collection)
		{
			if (item5.Task != null)
			{
				list2.Add(item5.Task);
				continue;
			}
			EmulationMessageTreeMenuNode item2 = new EmulationMessageTreeMenuNode
			{
				text = item5.Subject.Trunk(40, "..."),
				expanded = true,
				icon = "#messages.svg",
				HtmlClass = new List<string> { "EmulationSubTreeBlack" },
				HtmlAttributes = new Dictionary<string, object> { 
				{
					"tooltiptext",
					MessageText(item5, extensionPoints)
				} },
				HtmlHelper = htmlHelper,
				MessageId = item5.Id
			};
			list.Add(item2);
		}
		foreach (ITaskBase item6 in list2.Distinct().ToList())
		{
			List<TreeMenuNode> list3 = new List<TreeMenuNode>();
			ITaskBase task1 = item6;
			foreach (IEmulationMessages item7 in collection.Where((IEmulationMessages m) => m.Task != null && m.Task.Id == task1.Id))
			{
				EmulationMessageTreeMenuNode item3 = new EmulationMessageTreeMenuNode
				{
					text = item7.Subject.Trunk(40, "..."),
					expanded = true,
					icon = "#messages.svg",
					HtmlClass = new List<string> { "EmulationSubTreeBlack" },
					HtmlAttributes = new Dictionary<string, object> { 
					{
						"tooltiptext",
						MessageText(item7, extensionPoints)
					} },
					HtmlHelper = htmlHelper,
					MessageId = item7.Id
				};
				list3.Add(item3);
			}
			TreeMenuNode item4 = new TreeMenuNode
			{
				children = list3,
				text = SR.T(item6.Subject).Trunk(40, "..."),
				expanded = true,
				icon = "#company.svg",
				HtmlClass = new List<string> { "EmulationSubTreeBlack" }
			};
			list.Add(item4);
		}
		return list;
	}

	private string MessageText(IEmulationMessages message, IEnumerable<IMessageChannel> Channels)
	{
		string text = SR.T("Дата и время отправки сообщения:") + "<br>";
		text = string.Concat(text, "<b>", message.DateMessage, "</b><br>");
		text = text + SR.T("Каналы-получатели сообщения:") + "<br>";
		foreach (Guid channelMessage in message.ChannelMessage)
		{
			IMessageChannel messageChannel = Channels.FirstOrDefault((IMessageChannel a) => a.Uid == channelMessage);
			if (messageChannel != null)
			{
				text = text + "<b>" + messageChannel.DisplayName + "</b><br>";
			}
		}
		text = text + SR.T("пользователи получатели сообщения:") + "<br>";
		foreach (IUser item in (IEnumerable<IUser>)message.Recipients)
		{
			text = text + "<b>" + item.FirstName + "</b><br>";
		}
		return text;
	}

	public IEnumerable<IWorkflowInstance> GetCurrentSubInstances(IWorkflowInstance instance)
	{
		if (currentSubInstances == null)
		{
			currentSubInstances = new Dictionary<IWorkflowInstance, List<IWorkflowInstance>>();
			List<IWorkflowInstance> list = new List<IWorkflowInstance>();
			list.Add(instance);
			foreach (IWorkflowInstance item in from i in Locator.GetServiceNotNull<WorkflowInstanceManager>().GetSubInstances(list)
				where i.ParentInstance != null
				select i)
			{
				IWorkflowInstance parentInstance = item.ParentInstance;
				if (!currentSubInstances.TryGetValue(parentInstance, out var value))
				{
					value = new List<IWorkflowInstance>();
					currentSubInstances.Add(parentInstance, value);
				}
				value.Add(item);
			}
		}
		if (currentSubInstances.TryGetValue(instance, out var value2))
		{
			return value2;
		}
		return new IWorkflowInstance[0];
	}
}
