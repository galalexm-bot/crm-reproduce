using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Extensions;
using EleWise.ELMA.Documents.Web.Models;

namespace EleWise.ELMA.Documents.Web.Components;

[Component(Order = 100)]
public class BaseFolderViewProvider : IFolderViewProvider
{
	public static Guid UID = new Guid("{C3E57A50-0A94-441D-B38B-10DC65B6DF8B}");

	public Guid Uid => UID;

	public string DisplayName => SR.T("Таблица");

	public string GetIconUrl(int size)
	{
		return "#table_type.svg";
	}

	public void Render<T>(HtmlHelper html, FolderBaseModel<T> folder) where T : class, IFolder
	{
		if (folder is FolderModel)
		{
			RenderPartialExtensions.RenderPartial(html, "Folder/ViewFolder", (object)folder);
		}
	}

	public bool CheckType(IFolder folder)
	{
		return true;
	}
}
