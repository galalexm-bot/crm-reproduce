using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Models;

namespace EleWise.ELMA.Documents.Web.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFolderViewProvider
{
	Guid Uid { get; }

	string DisplayName { get; }

	string GetIconUrl(int size);

	bool CheckType(IFolder folder);

	void Render<T>(HtmlHelper html, FolderBaseModel<T> folder) where T : class, IFolder;
}
