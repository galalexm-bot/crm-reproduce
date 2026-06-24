using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Controllers;
using EleWise.ELMA.Documents.Web.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Documents.Web.Components.ViewItemContentExtension;

[Component]
internal abstract class DocumentViewItemContentExtension<T> : IViewItemContentExtension where T : ViewItem
{
	public bool Check(ViewItem viewItem, IEntity entity)
	{
		return viewItem is T;
	}

	public object GetModel(params object[] parameters)
	{
		if (parameters.Length != 0 && parameters[0] is IDocument document)
		{
			DocumentInfo documentInfo = new DocumentInfo(document, ViewType.Create);
			DocumentController.InitDocumentInfo(documentInfo, document.Folder?.Id, null, disableProfileFolder: false);
			return documentInfo;
		}
		return null;
	}
}
