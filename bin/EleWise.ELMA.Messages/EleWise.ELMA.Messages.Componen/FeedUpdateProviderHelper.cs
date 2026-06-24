using System.Globalization;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages.Components.Feed;

public static class FeedUpdateProviderHelper
{
	public static MessageRecipient RecipientFromChannel(IInformationChannel channel)
	{
		return new MessageRecipient(channel.Name, InterfaceActivator.UID<IInformationChannel>(), channel.Id.ToString(CultureInfo.InvariantCulture));
	}

	public static MessageRecipient RecipientFromUser(IUser user)
	{
		return new MessageRecipient(user.GetShortName(), InterfaceActivator.UID<IUser>(), user.Id.ToString(CultureInfo.InvariantCulture));
	}
}
