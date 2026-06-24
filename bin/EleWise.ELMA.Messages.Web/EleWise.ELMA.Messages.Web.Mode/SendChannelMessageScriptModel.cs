using System.Collections.Generic;

namespace EleWise.ELMA.Messages.Web.Models;

public class SendChannelMessageScriptModel
{
	public List<long> ChannelIds { get; set; }

	public List<long> RecipientIds { get; set; }

	public string Subject { get; set; }

	public string MessageGridId { get; set; }
}
