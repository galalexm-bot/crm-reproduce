using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Web.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Web.Components;

[Component(Order = 100)]
public class DocumentDiscussionObjectDisplayView : IDiscussionObjectDisplayView
{
	public EntityService EntityService { get; set; }

	public bool CheckType(IDiscussionObject obj)
	{
		EntityMetadata entityMetadata = (EntityMetadata)InterfaceActivator.LoadMetadata<IDocument>();
		List<ClassMetadata> childClasses = MetadataLoader.GetChildClasses(entityMetadata);
		childClasses.Add(entityMetadata);
		return childClasses.Any((ClassMetadata c) => c.Uid == obj.ObjectType);
	}

	public MvcHtmlString Render(HtmlHelper html, IDiscussionObject obj)
	{
		IDocument document = null;
		Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegiesAndWithDeleted(delegate
		{
			document = DocumentManager.Instance.LoadOrNull(obj.ObjectId);
		});
		if (document == null)
		{
			return MvcHtmlString.Empty;
		}
		return PartialExtensions.Partial(html, "DisplayTemplates/Entities/Document", (object)document);
	}
}
