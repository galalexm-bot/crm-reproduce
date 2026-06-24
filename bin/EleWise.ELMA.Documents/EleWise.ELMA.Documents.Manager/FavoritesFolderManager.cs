using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Documents.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class FavoritesFolderManager : FolderManager<IFavoritesFolder, long>
{
	public MyDocumentFolderManager MyDocumentFolderManager { get; set; }

	public new static FavoritesFolderManager Instance => Locator.GetServiceNotNull<FavoritesFolderManager>();

	[Transaction]
	public virtual IFavoritesFolder CreateForUser(IUser owner, IMyDocumentFolder myDocumentFolder = null)
	{
		InstanceOf<IFavoritesFolder> instanceOf = new InstanceOf<IFavoritesFolder>();
		instanceOf.New.Owner = owner;
		instanceOf.New.CreationAuthor = owner;
		instanceOf.New.Folder = myDocumentFolder ?? MyDocumentFolderManager.LoadByUser(owner, createFavorite: false);
		instanceOf.New.Name = SR.T("Избранное");
		instanceOf.New.FolderType = FolderType.Favorites;
		IFavoritesFolder @new = instanceOf.New;
		Save(@new);
		base.Session.Flush();
		return @new;
	}

	[ContextCache]
	public virtual IFavoritesFolder LoadByUser(IUser owner)
	{
		ICriteria obj = CreateCriteria().SetCacheable(true);
		obj.Add((ICriterion)(object)Restrictions.Eq("Owner", (object)owner));
		return obj.List<IFavoritesFolder>().FirstOrDefault() ?? CreateForUser(owner);
	}

	[ContextCache]
	public virtual IFavoritesFolder LoadForCurrentUser()
	{
		return LoadByUser(base.AuthenticationService.GetCurrentUser<IUser>());
	}

	[ContextCache]
	public virtual bool IsInFavorites(long documentId)
	{
		ICriteria val = CreateCriteriaByReference();
		val.CreateAlias("Reference", "rf").Add((ICriterion)(object)Restrictions.Eq("rf.Id", (object)documentId)).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Count("rf.Id") });
		return Convert.ToInt64(val.UniqueResult()) > 0;
	}

	public virtual List<IDocumentReference> GetReferencesinFavorites(long documentId)
	{
		ICriteria obj = CreateCriteriaByReference();
		obj.CreateAlias("Reference", "rf").Add((ICriterion)(object)Restrictions.Eq("rf.Id", (object)documentId));
		return obj.List<IDocumentReference>().ToList();
	}

	protected virtual ICriteria CreateCriteriaByReference()
	{
		IFavoritesFolder favoritesFolderForCurrentUser = base.SystemFoldersService.GetFavoritesFolderForCurrentUser();
		SqlSubQuery sqlSubQuery = base.Session.GetNamedSubQuery("GetSubfoldersQuery").SetParameter("folderId", favoritesFolderForCurrentUser.Id);
		return base.Session.CreateCriteria(InterfaceActivator.TypeOf<IDocumentReference>()).Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.IsNull("IsDeleted"), (ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq("IsDeleted", (object)true)))).Add((ICriterion)(object)NHQueryExtensions.Sql("{Folder} in (" + sqlSubQuery.Sql + ")", sqlSubQuery.ParametersValues, sqlSubQuery.ParametersTypes));
	}
}
