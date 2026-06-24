using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.BPM.Web.Tasks.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ITaskAttachmetSpecifiedViewExtension
{
	string Name { get; }

	MvcHtmlString Attachments(HtmlHelper html, IEnumerable<IEntity<long>> attachments);
}
