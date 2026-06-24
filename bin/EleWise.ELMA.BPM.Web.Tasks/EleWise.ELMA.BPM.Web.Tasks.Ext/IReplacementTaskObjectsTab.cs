using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Tasks.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IReplacementTaskObjectsTab
{
	string Name { get; }

	string TabId { get; }

	IEnumerable<long> Count(long replacementTaskId);

	string ContentUrl(HtmlHelper html, long replacementTaskId);
}
