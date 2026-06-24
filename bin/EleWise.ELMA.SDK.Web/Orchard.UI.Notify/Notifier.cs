using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using Orchard.Localization;

namespace Orchard.UI.Notify;

public class Notifier : INotifier, IDependency
{
	private readonly IList<NotifyEntry> entries;

	public ILogger Logger { get; set; }

	public Notifier()
	{
		Logger = NullLogger.Instance;
		entries = new List<NotifyEntry>();
	}

	public void Add(NotifyType type, LocalizedString message)
	{
		Logger.InfoFormat("Notification {0} message: {1}", type, message);
		MvcHtmlString mvcStringMessage = ((type == NotifyType.HtmlAction) ? MvcHtmlString.Create(message.ToString()) : MvcHtmlString.Create(message.ToString().HtmlEncode()));
		entries.Add(new NotifyEntry
		{
			Type = type,
			MvcStringMessage = mvcStringMessage
		});
	}

	public void Add(NotifyType type, MvcHtmlString message)
	{
		Logger.InfoFormat("Notification {0} message: {1}", type, message);
		entries.Add(new NotifyEntry
		{
			Type = type,
			MvcStringMessage = message
		});
	}

	public IEnumerable<NotifyEntry> List()
	{
		return entries;
	}
}
