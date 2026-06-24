using System.Linq;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Documents.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class MyDocumentFolderManager : FolderManager<IMyDocumentFolder, long>
{
	public new static MyDocumentFolderManager Instance => Locator.GetServiceNotNull<MyDocumentFolderManager>();

	[Transaction]
	public virtual IMyDocumentFolder CreateForUser(IUser owner)
	{
		return CreateForUser(owner, createFavorite: true);
	}

	[Transaction]
	public virtual bool CreateDefaultFoldersForNewUser(IUser owner)
	{
		InstanceOf<IMyDocumentFolder> instanceOf = new InstanceOf<IMyDocumentFolder>();
		instanceOf.New.Owner = owner;
		instanceOf.New.CreationAuthor = owner;
		instanceOf.New.Name = SR.T("Мои документы");
		instanceOf.New.FolderType = FolderType.MyDocuments;
		instanceOf.New.SortTypeId = 500L;
		IMyDocumentFolder @new = instanceOf.New;
		Save(@new);
		InstanceOf<IFavoritesFolder> instanceOf2 = new InstanceOf<IFavoritesFolder>();
		instanceOf2.New.Owner = owner;
		instanceOf2.New.CreationAuthor = owner;
		instanceOf2.New.Folder = @new;
		instanceOf2.New.Name = SR.T("Избранное");
		instanceOf2.New.FolderType = FolderType.Favorites;
		IFavoritesFolder new2 = instanceOf2.New;
		FavoritesFolderManager.Instance.Save(new2);
		return true;
	}

	[Transaction]
	public virtual IMyDocumentFolder CreateForUser(IUser owner, bool createFavorite)
	{
		InstanceOf<IMyDocumentFolder> instanceOf = new InstanceOf<IMyDocumentFolder>();
		instanceOf.New.Owner = owner;
		instanceOf.New.CreationAuthor = owner;
		instanceOf.New.Name = SR.T("Мои документы");
		instanceOf.New.FolderType = FolderType.MyDocuments;
		instanceOf.New.SortTypeId = 500L;
		IMyDocumentFolder @new = instanceOf.New;
		Save(@new);
		base.Session.Flush();
		if (createFavorite)
		{
			FavoritesFolderManager.Instance.CreateForUser(owner, @new);
		}
		return @new;
	}

	[ContextCache]
	public virtual IMyDocumentFolder LoadByUser(IUser owner)
	{
		return LoadByUser(owner, createFavorite: true);
	}

	[ContextCache]
	public virtual IMyDocumentFolder LoadByUser(IUser owner, bool createFavorite)
	{
		ICriteria obj = CreateCriteria();
		obj.Add((ICriterion)(object)Restrictions.Eq("Owner", (object)owner));
		return obj.List<IMyDocumentFolder>().FirstOrDefault() ?? CreateForUser(owner, createFavorite);
	}

	[ContextCache]
	public virtual IMyDocumentFolder LoadForCurrentUser()
	{
		return LoadByUser(base.AuthenticationService.GetCurrentUser<IUser>());
	}
}
