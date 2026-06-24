using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Services;
using EleWise.ELMA.Documents.Web.Extensions;
using EleWise.ELMA.Documents.Web.Models;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Documents.Web.Components;

[Component(Order = 100)]
public class DocumentLastObjectRenderer : ILastObjectRenderer
{
	public Guid TypeUid => InterfaceActivator.UID<IDocument>();

	public string ContextMenuName => "DocumentContextMenu";

	public MvcHtmlString Render(HtmlHelper helper, ReferenceOnEntity entity)
	{
		return PartialExtensions.Partial(helper, "DisplayTemplates/Entities/Document", (object)entity.Object);
	}

	public bool HasContextMenu(ReferenceOnEntity entity)
	{
		if (!(entity.Object is IDocument document))
		{
			return false;
		}
		return !document.IsDeleted;
	}

	public void RenderContextMenu(HtmlHelper helper, ReferenceOnEntity entity)
	{
		helper.RegisterContent("FolderOperations", (dynamic d) => PartialExtensions.Partial(helper, "Folder/Operations", (object)new FolderModel
		{
			Entity = Locator.GetServiceNotNull<ISystemFoldersService>().GetMyDocumentFolderForCurrentUser()
		}));
	}

	public List<string> NotVisibleItems(HtmlHelper helper, ReferenceOnEntity entity)
	{
		return helper.NotVisibleItems((IDocument)entity.Object);
	}
}
