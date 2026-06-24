using System;
using System.Collections.Generic;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.Messages.Web.Models;

public class MessageChannels : FormViewModel
{
	public List<IMessageChannel> Channels { get; set; }

	public List<Guid> CheckedChannels { get; set; }

	public bool CheckedAll { get; set; }

	public bool RememberChecked { get; set; }

	public string PopupId { get; set; }

	public Guid ObjectUid { get; set; }

	public Guid ActionUid { get; set; }

	public MessageChannels()
	{
		CheckedChannels = new List<Guid>();
		Channels = new List<IMessageChannel>();
		base.PostAction = "AddException";
		base.PostController = "MessageException";
		base.PostArea = "EleWise.ELMA.Messages.Web";
	}
}
