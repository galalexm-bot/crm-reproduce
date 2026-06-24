using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Extensions;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Documents.Web.Services;

[Service(Type = ComponentType.WebServer, InjectProperties = true, Scope = ServiceScope.Shell, EnableInterceptors = false)]
public class FolderViewService : IFolderViewService
{
	public const string Path = "FolderViewProvider";

	public IAuthenticationService AuthenticationService { get; set; }

	public IFolderViewProvider GetCurrent(IFolder folder)
	{
		Contract.ArgumentNotNull(PersonalizationAdministration.Provider, "PersonalizationAdministration.Provider");
		FolderViewHolder holder = PersonalizationAdministration.Provider.LoadState<FolderViewHolder>(AuthenticationService.GetCurrentUser().UserName + folder.Id, "FolderViewProvider");
		IFolderViewProvider folderViewProvider = null;
		if (holder != null)
		{
			folderViewProvider = ComponentManager.Current.GetExtensionPoints<IFolderViewProvider>().FirstOrDefault((IFolderViewProvider p) => p.Uid == holder.ProviderUid && p.CheckType(folder));
		}
		return folderViewProvider ?? (folderViewProvider = ComponentManager.Current.GetExtensionPoints<IFolderViewProvider>().FirstOrDefault((IFolderViewProvider p) => p.CheckType(folder)));
	}

	public void Save(IFolder folder, Guid uid)
	{
		Contract.ArgumentNotNull(PersonalizationAdministration.Provider, "PersonalizationAdministration.Provider");
		FolderViewHolder folderViewHolder = PersonalizationAdministration.Provider.LoadState<FolderViewHolder>(AuthenticationService.GetCurrentUser().UserName + folder.Id, "FolderViewProvider");
		if (folderViewHolder == null)
		{
			folderViewHolder = new FolderViewHolder();
		}
		folderViewHolder.ProviderUid = uid;
		PersonalizationAdministration.Provider.SaveState(AuthenticationService.GetCurrentUser().UserName + folder.Id, "FolderViewProvider", folderViewHolder);
	}
}
