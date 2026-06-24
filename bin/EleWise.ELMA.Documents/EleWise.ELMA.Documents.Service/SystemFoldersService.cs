using System.Collections.Concurrent;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Services;

[Service]
public class SystemFoldersService : ISystemFoldersService
{
	private IFolder _sharedFolder;

	private IFilterDocumentFolder _archiveFolder;

	private ConcurrentDictionary<long, IMyDocumentFolder> _myDocumentFolders = new ConcurrentDictionary<long, IMyDocumentFolder>();

	private ConcurrentDictionary<long, IFavoritesFolder> _favoritesFolders = new ConcurrentDictionary<long, IFavoritesFolder>();

	private ConcurrentDictionary<long, bool> _hasArchivePermission = new ConcurrentDictionary<long, bool>();

	public ISecurityService SecurityService => Locator.GetServiceNotNull<ISecurityService>();

	public IFolder SharedFolder
	{
		get
		{
			if (_sharedFolder == null || !Locator.GetServiceNotNull<ISessionProvider>().GetSession("").Contains((object)_sharedFolder))
			{
				lock (this)
				{
					SecurityService.RunWithElevatedPrivilegiesAndWithDeleted(delegate
					{
						_sharedFolder = FolderManager.Instance.Load(DocumentConstants.SharedFolderUid);
					});
				}
			}
			return _sharedFolder;
		}
	}

	public IFilterDocumentFolder ArchiveFolder
	{
		get
		{
			if (_archiveFolder == null || !Locator.GetServiceNotNull<ISessionProvider>().GetSession("").Contains((object)_archiveFolder))
			{
				lock (this)
				{
					SecurityService.RunWithElevatedPrivilegiesAndWithDeleted(delegate
					{
						_archiveFolder = FilterDocumentFolderManager.Instance.Load(DocumentConstants.ArchiveFolderUid);
					});
				}
			}
			return _archiveFolder;
		}
	}

	public IFilterDocumentFolder GetArchiveFolderForCurrentUser(bool noSecurityException = false)
	{
		EleWise.ELMA.Security.Models.IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		bool value;
		if (_hasArchivePermission.ContainsKey(currentUser.Id))
		{
			_hasArchivePermission.TryGetValue(currentUser.Id, out value);
		}
		else
		{
			value = SecurityService.HasPermission(PermissionProvider.DocumentViewPermission, ArchiveFolder);
			_hasArchivePermission.TryAdd(currentUser.Id, value);
		}
		if (value)
		{
			return ArchiveFolder;
		}
		if (noSecurityException)
		{
			return null;
		}
		string text = SR.T("Ошибка доступа к объекту \"Папка\" с идентификатором {1}", ArchiveFolder.Id);
		throw FolderManager.Instance.CreateSecurityException(text, ArchiveFolder.Id);
	}

	public IMyDocumentFolder GetMyDocumentFolder(EleWise.ELMA.Security.Models.IUser user)
	{
		IMyDocumentFolder value = null;
		if (_myDocumentFolders.ContainsKey(user.Id))
		{
			_myDocumentFolders.TryGetValue(user.Id, out value);
			if (!Locator.GetService<ISessionProvider>().GetSession("").Contains((object)value))
			{
				value = MyDocumentFolderManager.Instance.LoadByUser(user);
				_myDocumentFolders[user.Id] = value;
			}
			return value;
		}
		value = MyDocumentFolderManager.Instance.LoadByUser(user);
		_myDocumentFolders.TryAdd(user.Id, value);
		return value;
	}

	public IFavoritesFolder GetFavoritesFolder(EleWise.ELMA.Security.Models.IUser user)
	{
		IFavoritesFolder value = null;
		if (_favoritesFolders.ContainsKey(user.Id))
		{
			_favoritesFolders.TryGetValue(user.Id, out value);
			if (!Locator.GetService<ISessionProvider>().GetSession("").Contains((object)value))
			{
				value = FavoritesFolderManager.Instance.LoadByUser(user);
				_favoritesFolders[user.Id] = value;
			}
			return value;
		}
		value = FavoritesFolderManager.Instance.LoadByUser(user);
		_favoritesFolders.TryAdd(user.Id, value);
		return value;
	}

	public IMyDocumentFolder GetMyDocumentFolderForCurrentUser()
	{
		EleWise.ELMA.Security.Models.IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		return GetMyDocumentFolder(currentUser);
	}

	public IFavoritesFolder GetFavoritesFolderForCurrentUser()
	{
		EleWise.ELMA.Security.Models.IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		return GetFavoritesFolder(currentUser);
	}

	public void ClearAll()
	{
		lock (this)
		{
			_hasArchivePermission = new ConcurrentDictionary<long, bool>();
		}
	}
}
