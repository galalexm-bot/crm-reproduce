using System;
using EleWise.ELMA.Web.Mvc.Models.Trees;

namespace EleWise.ELMA.Documents.Web.Models;

[Obsolete("Данная модель больше не используется и будет вскоре удалена", true)]
public class MenuFolderTreeModel
{
	public TreeModel TreeModel { get; set; }

	public bool ShowButton { get; set; }

	public bool IsTemp { get; set; }

	public bool HasIndexingFolders { get; set; }

	public MenuFolderTreeModel()
	{
		IsTemp = true;
	}
}
