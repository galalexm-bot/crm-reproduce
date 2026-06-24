using System.Collections.Generic;
using System.Web.Mvc;
using Orchard.Localization;

namespace Orchard.UI.Notify;

public interface INotifier : IDependency
{
	void Add(NotifyType type, LocalizedString message);

	void Add(NotifyType type, MvcHtmlString message);

	IEnumerable<NotifyEntry> List();
}
