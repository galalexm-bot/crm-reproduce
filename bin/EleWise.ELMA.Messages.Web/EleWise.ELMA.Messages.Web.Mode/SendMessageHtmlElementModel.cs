using System.Collections.Generic;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages.Web.Models;

public class SendMessageHtmlElementModel
{
	public string Subject { get; set; }

	public InformationChannelSetModel ChannelSetModel { get; set; }

	public List<IUser> Recipients { get; set; }

	public SendMessageHtmlElementModel()
	{
		ChannelSetModel = new InformationChannelSetModel();
		Recipients = new List<IUser>();
	}
}
