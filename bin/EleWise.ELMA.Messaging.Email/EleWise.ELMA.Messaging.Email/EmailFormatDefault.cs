using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Notifications;

namespace EleWise.ELMA.Messaging.Email;

[Component(Order = int.MaxValue)]
internal class EmailFormatDefault : IEmailFormat
{
	public string Name => null;

	public string DisplayName => SR.T("По умолчанию");

	public string SubjectPrefix => null;

	public IEnumerable<Pair<INotificationFlow, IMessageChannel>> AllowPairs
	{
		get
		{
			IMessageChannel second = ComponentManager.Current.GetExtensionPoints<IMessageChannel>().FirstOrDefault((IMessageChannel mc) => mc.Uid == EmailChannel.UID);
			yield return new Pair<INotificationFlow, IMessageChannel>(null, second);
		}
	}

	public void Prepare(IMessage message)
	{
	}
}
