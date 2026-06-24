using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Security.Models;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Messages.Web.Models;

public class ChannelsAndRecipientsModel
{
	public long ChannelMessageId { get; set; }

	public ISet<IInformationChannel> Channels { get; set; }

	public InformationChannelSetModel ChannelsSelector { get; set; }

	public IChannelMessage Message { get; set; }

	public string PopupId { get; set; }

	public bool AutoResize { get; set; }

	public List<IUser> RecipientsView
	{
		get
		{
			if (Message == null)
			{
				return new List<IUser>();
			}
			return new List<IUser>((IEnumerable<IUser>)Message.Recipients).Where((IUser r) => r.Id != Message.CreationAuthor.Id).ToList();
		}
		set
		{
		}
	}

	public ChannelsAndRecipientsModel()
	{
		Channels = (ISet<IInformationChannel>)(object)new HashedSet<IInformationChannel>();
		ChannelsSelector = new InformationChannelSetModel();
		AutoResize = true;
	}
}
