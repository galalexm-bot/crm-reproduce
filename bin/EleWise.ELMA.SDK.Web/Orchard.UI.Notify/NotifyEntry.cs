using System;
using System.Web.Mvc;
using Orchard.Localization;

namespace Orchard.UI.Notify;

public class NotifyEntry
{
	public NotifyType Type { get; set; }

	[Obsolete("Используйте параметр MvcStringMessage")]
	public LocalizedString Message { get; set; }

	public MvcHtmlString MvcStringMessage { get; set; }
}
