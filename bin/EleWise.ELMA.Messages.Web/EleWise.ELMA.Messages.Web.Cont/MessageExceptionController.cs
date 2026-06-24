using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Web.Models;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Portlets;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.Messages.Web.Controllers;

[Permission("258BBEBC-006B-46FB-80AC-B36456A191E9")]
public class MessageExceptionController : BPMController<IMessageException, long>
{
	private const string SettingsMessagesPath = "SettingsMessagesException";

	public IAuditManager AuditManager { get; set; }

	private MessageSettingsInfo BuildSettingsModel()
	{
		MessageSettingsInfo model = new MessageSettingsInfo();
		MessageExceptionManager.Instance.GetUserExceptions().ToList().ForEach(delegate(IMessageException a)
		{
			IAuditObject obj = AuditManager.GetObject(a.ObjectUid);
			if (obj != null)
			{
				IAuditAction action = AuditManager.GetAction(obj, a.ActionUid);
				if (action != null)
				{
					ChannelSettingsInfo channel = (a.ChannelUid.HasValue ? model.Channels.FirstOrDefault((ChannelSettingsInfo c) => c.Uid == a.ChannelUid.Value) : null);
					ObjectSettingsInfo objectSettingsInfo = model.Objects.FirstOrDefault((ObjectSettingsInfo o) => o.Uid == obj.Uid);
					if (objectSettingsInfo == null)
					{
						objectSettingsInfo = new ObjectSettingsInfo
						{
							Uid = obj.Uid,
							DisplayName = obj.DisplayName
						};
						model.Objects.Add(objectSettingsInfo);
					}
					ActionSettingsInfo actionSettingsInfo = objectSettingsInfo.ActionsInfo.FirstOrDefault((ActionSettingsInfo o) => o.Uid == action.Uid);
					if (actionSettingsInfo == null)
					{
						actionSettingsInfo = new ActionSettingsInfo
						{
							Uid = action.Uid,
							DisplayName = action.DisplayName
						};
						actionSettingsInfo.Init();
						objectSettingsInfo.ActionsInfo.Add(actionSettingsInfo);
					}
					if (channel == null)
					{
						actionSettingsInfo.ChannelsInfo.ForEach(delegate(ChannelSettingsInfo ci)
						{
							ci.Checked = true;
						});
					}
					else
					{
						actionSettingsInfo.ChannelsInfo.FirstOrDefault((ChannelSettingsInfo ci) => ci.Uid == channel.Uid).Checked = true;
					}
				}
			}
		});
		return model;
	}

	public ActionResult Settings()
	{
		MessageSettingsInfo messageSettingsInfo = BuildSettingsModel();
		return (ActionResult)(object)((Controller)this).View((object)messageSettingsInfo);
	}

	[HttpPost]
	public ActionResult Settings(MessageSettingsInfo info)
	{
		MessageExceptionManager.Instance.DeleteMyException();
		foreach (ObjectSettingsInfo @object in info.Objects)
		{
			foreach (ActionSettingsInfo item in @object.ActionsInfo)
			{
				foreach (ChannelSettingsInfo item2 in item.ChannelsInfo.Where((ChannelSettingsInfo c) => c.Checked))
				{
					IMessageException ex = InterfaceActivator.Create<IMessageException>();
					ex.ObjectUid = @object.Uid;
					ex.ActionUid = item.Uid;
					ex.ChannelUid = item2.Uid;
					ex.Save();
				}
			}
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("List", "BaseMessage", (object)new
		{
			area = "EleWise.ELMA.Messages.Web"
		});
	}

	[HttpPost]
	public ActionResult Grid(MessageSettingsInfo info)
	{
		return (ActionResult)(object)((Controller)this).PartialView((object)info);
	}

	public ActionResult ActionSelector(string popupId, string callback)
	{
		SingleObjectActionSelectorInfo singleObjectActionSelectorInfo = new SingleObjectActionSelectorInfo
		{
			PopupId = popupId,
			Callback = callback
		};
		return (ActionResult)(object)((Controller)this).PartialView("PartialActionSelector", (object)singleObjectActionSelectorInfo);
	}

	[HttpPost]
	public ActionResult AddExceptions(SingleObjectActionSelectorInfo info)
	{
		List<ObjectSettingsInfo> list = new List<ObjectSettingsInfo>();
		ObjectSettingsInfo objectSettingsInfo = new ObjectSettingsInfo
		{
			Uid = info.ObjectUid,
			ActionsInfo = info.ActionsInfo
		};
		if (objectSettingsInfo.ActionsInfo.Any((ActionSettingsInfo a) => a.Checked))
		{
			objectSettingsInfo.ActionsInfo.RemoveAll((ActionSettingsInfo ai) => !ai.Checked);
			objectSettingsInfo.ActionsInfo.ForEach(delegate(ActionSettingsInfo ai)
			{
				ai.Init();
			});
			list.Add(objectSettingsInfo);
		}
		return (ActionResult)(object)((Controller)this).Json((object)list);
	}

	public ActionResult ChannelSelector(Guid objectUid, Guid actionUid, string popupId)
	{
		MessageChannels model = new MessageChannels
		{
			ActionUid = actionUid,
			ObjectUid = objectUid,
			PopupId = popupId,
			Channels = ComponentManager.Current.GetExtensionPoints<IMessageChannel>().ToList()
		};
		List<Guid> list = PersonalizationAdministration.LoadState<List<Guid>>(Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<IUser>().UserName, "SettingsMessagesException");
		if (list != null && list.Count != 0)
		{
			foreach (Guid item in list.Where((Guid channelUid) => model.Channels.Exists((IMessageChannel ch) => ch.Uid == channelUid)))
			{
				model.CheckedChannels.Add(item);
			}
			model.CheckedAll = model.CheckedChannels.Count() == model.Channels.Count();
			model.RememberChecked = true;
		}
		return (ActionResult)(object)((Controller)this).PartialView((object)model);
	}

	[HttpPost]
	public ActionResult AddException(MessageChannels model)
	{
		IAuditObject @object = AuditManager.GetObject(model.ObjectUid);
		if (@object == null)
		{
			return (ActionResult)(object)((Controller)this).Json((object)SR.T("Не задан объект"));
		}
		IAuditAction action = AuditManager.GetAction(@object, model.ActionUid);
		if (action == null)
		{
			return (ActionResult)(object)((Controller)this).Json((object)SR.T("Не задано действие"));
		}
		MessageExceptionManager.Instance.DeleteException(@object, action);
		foreach (Guid checkedChannel in model.CheckedChannels)
		{
			IMessageException ex = InterfaceActivator.Create<IMessageException>();
			ex.ActionUid = model.ActionUid;
			ex.ObjectUid = model.ObjectUid;
			ex.ChannelUid = checkedChannel;
			ex.Save();
		}
		IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<IUser>();
		if (model.RememberChecked)
		{
			PersonalizationAdministration.SaveState(currentUser.UserName, "SettingsMessagesException", model.CheckedChannels);
		}
		else
		{
			PersonalizationAdministration.ResetState<List<Guid>>(currentUser.UserName, "SettingsMessagesException");
		}
		return (ActionResult)(object)((Controller)this).Json((object)"ok");
	}

	public ActionResult GetObjectTypes(string text = "")
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00a7: Expected O, but got Unknown
		var source = from o in AuditManager.GetObjects().ToList()
			select new
			{
				id = o.Uid,
				text = o.DisplayName
			};
		if (!string.IsNullOrEmpty(text))
		{
			source = source.Where(o => o.text != null && o.text.ToUpper().Contains(text.ToUpper()));
		}
		JsonResult val = new JsonResult();
		val.set_Data((object)new SelectList((IEnumerable)source.OrderBy(t => t.text).ToList(), "id", "text"));
		return (ActionResult)val;
	}

	public ActionResult ObjectActions(Guid objectUid)
	{
		SingleObjectActionSelectorInfo singleObjectActionSelectorInfo = new SingleObjectActionSelectorInfo
		{
			ObjectUid = objectUid
		};
		IAuditObject @object = AuditManager.GetObject(objectUid);
		if (@object != null)
		{
			List<IAuditAction> source = AuditManager.GetActions(@object).ToList();
			singleObjectActionSelectorInfo.ActionsInfo = source.Select((IAuditAction a) => new ActionSettingsInfo
			{
				Uid = a.Uid,
				DisplayName = a.DisplayName
			}).ToList();
		}
		return (ActionResult)(object)((Controller)this).PartialView((object)singleObjectActionSelectorInfo);
	}
}
