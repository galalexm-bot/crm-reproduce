using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html.Toolbar;

namespace EleWise.ELMA.Documents.Web.Extensions;

public static class ToolbarExtensions
{
	public const string BackToToolbarGroupUid = "document_back_to_toolbargroup";

	[NotNull]
	public static ToolbarGroupBuilder FolderBackTo([NotNull] this ToolbarBuilder builder, IFolder folder)
	{
		ToolbarGroupBuilder toolbarGroupBuilder = builder.Group("document_back_to_toolbargroup");
		if (folder == null)
		{
			return toolbarGroupBuilder;
		}
		if (builder == null)
		{
			throw new ArgumentNullException("builder");
		}
		return BackToExt(folder, toolbarGroupBuilder);
	}

	[NotNull]
	public static ToolbarGroupBuilder FolderBackTo([NotNull] this ToolbarGroupBuilder builder, IFolder folder)
	{
		if (folder == null)
		{
			return builder;
		}
		if (builder == null)
		{
			throw new ArgumentNullException("builder");
		}
		return BackToExt(folder, builder);
	}

	private static ToolbarGroupBuilder BackToExt(IFolder folder, ToolbarGroupBuilder b)
	{
		List<IFolderToolbarExtension> list = ComponentManager.Current.GetExtensionPoints<IFolderToolbarExtension>().ToList();
		if (list.Any())
		{
			foreach (IFolderToolbarExtension item in list)
			{
				item.BackToExt(folder, b);
			}
			return b;
		}
		return b;
	}
}
