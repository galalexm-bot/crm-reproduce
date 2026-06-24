using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Web.Models;
using EleWise.ELMA.Web.Mvc.Html.EditableList;

namespace EleWise.ELMA.Documents.Web.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IDocumentMetadataSaveHandler
{
	void Init(DocumentMetadataProfileInfo info, UrlHelper url);

	void Save(EditableListModel model, DocumentMetadataProfileInfo info);
}
