using System.ComponentModel;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Db;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Menu;

namespace EleWise.ELMA.Documents.Web.Menu;

[Component]
public class DocumentsSharedFoldersItems : IMenuCustomItems
{
	public FolderManager FolderManager { get; set; }

	public DmsObjectManager DmsObjectManager { get; set; }

	private IFolder GetSharedFolder()
	{
		try
		{
			return FolderManager.Load(DocumentConstants.SharedFolderUid);
		}
		catch
		{
			return null;
		}
	}

	public bool HasCustomItems(MenuItemNode item)
	{
		return item.Code == "documents-shared-folders";
	}

	public void Items(HtmlHelper htmlHelper, MenuItemNode item)
	{
		IFolder sharedFolder = GetSharedFolder();
		if (sharedFolder == null)
		{
			new DocumentsDbStructure().CreateSharedFolder();
			sharedFolder = GetSharedFolder();
		}
		if (sharedFolder == null)
		{
			return;
		}
		item.Items.Clear();
		IDmsObjectFilter dmsObjectFilter = InterfaceActivator.Create<IDmsObjectFilter>();
		dmsObjectFilter.Folder = sharedFolder;
		dmsObjectFilter.PermissionId = PermissionProvider.DocumentViewPermission.Id;
		foreach (IDmsObject item2 in DmsObjectManager.Find(dmsObjectFilter, new FetchOptions(0, 0, ListSortDirection.Ascending, "Name")))
		{
			if (item2 is IFolder || item2 is IFolderReference)
			{
				item.Items.Add(new MenuItemNode
				{
					Code = "shared-folder-" + item2.Id,
					Parent = item,
					Name = item2.Name,
					NavigateUrl = htmlHelper.Url().Entity(item2),
					Disabled = false,
					ImageUrl = ((item2 is IUserImageSetable && !string.IsNullOrEmpty(((IUserImageSetable)item2).ImageUrl)) ? ((IUserImageSetable)item2).ImageUrl : htmlHelper.Url().Action("Object", "Images", (object)new
					{
						area = "EleWise.ELMA.SDK.Web",
						id = MetadataLoader.LoadMetadata(item2.GetType()).Uid,
						useParent = true
					}))
				});
			}
		}
	}
}
