using System;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Content.Managers;

public class PageFolderManager : PortalObjectManager<IPageFolder, long>
{
	public static readonly Guid UserPagesFolderUid = new Guid("{7489D49B-818F-4139-83E7-B08BB055978D}");

	public static readonly Guid HomePagesFolderUid = new Guid("{EA74A7BA-2E66-48EB-B70F-1A00686692C5}");

	public static readonly Guid PageProfilesFolderUid = new Guid("{976F4513-0CDA-4254-87B4-72DDE1848979}");

	public new static PageFolderManager Instance => Locator.GetServiceNotNull<PageFolderManager>();

	[Transaction]
	public virtual IPageFolder LoadOrCreateUserFolder(EleWise.ELMA.Security.Models.IUser user)
	{
		ISecurityService service = Locator.GetService<ISecurityService>();
		IPageFolder folder = null;
		Action action = delegate
		{
			folder = LoadOrNull(UserPagesFolderUid);
			if (folder == null)
			{
				InstanceOf<IPageFolder> instanceOf2 = new InstanceOf<IPageFolder>();
				instanceOf2.New.Uid = UserPagesFolderUid;
				instanceOf2.New.Name = SR.T("Пользовательские страницы");
				instanceOf2.New.SortTypeId = 0L;
				instanceOf2.New.IsSystem = true;
				folder = instanceOf2.New;
				folder.Save();
			}
		};
		if (service != null)
		{
			service.RunWithElevatedPrivilegies(action);
		}
		else
		{
			action();
		}
		IPageFolder pageFolder = ((AbstractNHEntityManager<IPageFolder, long>)this).Find((Expression<Func<IPageFolder, bool>>)((IPageFolder p) => p.Name == user.UserName)).FirstOrDefault();
		if (pageFolder == null)
		{
			InstanceOf<IPageFolder> instanceOf = new InstanceOf<IPageFolder>();
			instanceOf.New.Name = user.UserName;
			instanceOf.New.Folder = folder;
			pageFolder = instanceOf.New;
			pageFolder.Save();
		}
		return pageFolder;
	}

	public IPageFolder LoadOrCreateHomePagesFolder()
	{
		ISecurityService service = Locator.GetService<ISecurityService>();
		IPageFolder folder = null;
		Action action = delegate
		{
			folder = LoadOrNull(HomePagesFolderUid);
			if (folder == null)
			{
				InstanceOf<IPageFolder> instanceOf = new InstanceOf<IPageFolder>();
				instanceOf.New.Uid = HomePagesFolderUid;
				instanceOf.New.Name = SR.T("Главные страницы");
				instanceOf.New.SortTypeId = 0L;
				instanceOf.New.IsSystem = true;
				folder = instanceOf.New;
				folder.Save();
			}
		};
		if (service != null)
		{
			service.RunWithElevatedPrivilegies(action);
		}
		else
		{
			action();
		}
		return folder;
	}

	public IPageFolder LoadOrCreatePageProfilesFolder()
	{
		ISecurityService service = Locator.GetService<ISecurityService>();
		IPageFolder folder = null;
		Action action = delegate
		{
			folder = LoadOrNull(PageProfilesFolderUid);
			if (folder == null)
			{
				InstanceOf<IPageFolder> instanceOf = new InstanceOf<IPageFolder>();
				instanceOf.New.Uid = PageProfilesFolderUid;
				instanceOf.New.Name = SR.T("Страницы конфигурации");
				instanceOf.New.SortTypeId = 0L;
				instanceOf.New.IsSystem = true;
				folder = instanceOf.New;
				folder.Save();
			}
		};
		if (service != null)
		{
			service.RunWithElevatedPrivilegies(action);
		}
		else
		{
			action();
		}
		return folder;
	}

	public bool IsParentFolder(IPageFolder entity, IPageFolder folder)
	{
		if (folder.Folder != entity)
		{
			if (folder.Folder != null)
			{
				return IsParentFolder(entity, folder.Folder);
			}
			return false;
		}
		return true;
	}
}
