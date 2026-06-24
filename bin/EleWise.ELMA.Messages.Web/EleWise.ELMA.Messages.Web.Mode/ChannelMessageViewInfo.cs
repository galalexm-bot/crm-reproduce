using System;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Models.Forms;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Messages.Web.Models;

public class ChannelMessageViewInfo : FormViewModel
{
	public IChannelMessage Message { get; set; }

	public HashedSet<IUser> Users { get; set; }

	public new string Callback { get; set; }

	public string PopupId { get; set; }

	public bool IsDiscussion { get; set; }

	public DateTime? DateEnd { get; set; }

	public bool AjaxSubmit { get; set; }

	public string BeforeSubmitScript { get; set; }

	public InformationChannelSetModel ChannelsSelector { get; set; }

	public void UpdateChannelsToMessage()
	{
		if (Message != null)
		{
			Message.Channels = ChannelsSelector.GetChannels();
		}
	}

	public void UpdateChannels()
	{
		if (Message != null)
		{
			ChannelsSelector.SetChannels(Message.Channels);
		}
	}

	public ChannelMessageViewInfo()
	{
		Users = new HashedSet<IUser>();
		base.PostAction = "Save";
		base.PostController = "ChannelMessage";
		base.PostArea = "EleWise.ELMA.Messages.Web";
		DateEnd = DateTime.Now.AddDays(1.0);
		ChannelsSelector = new InformationChannelSetModel();
		AjaxSubmit = true;
	}
}
