using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Extensions;
using EleWise.ELMA.Documents.Web.Services;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Web.Models;

public class FolderBaseModel<T> : EntityModel<T> where T : class, IFolder
{
	private Lazy<bool> _editPerm;

	private Lazy<bool> _fullPerm;

	private Lazy<bool> _deletePerm;

	private Lazy<bool> _managerPerm;

	public bool UniqueGridId { get; set; }

	public string GridId { get; set; }

	public Guid GridStateProviderUid { get; set; }

	public bool EditPermission
	{
		get
		{
			if (base.Entity == null)
			{
				return false;
			}
			if (_editPerm == null)
			{
				_editPerm = new Lazy<bool>(() => Locator.GetServiceNotNull<ISecurityService>().HasPermission(PermissionProvider.DocumentEditPermission, base.Entity));
			}
			if (!FullPermission)
			{
				return _editPerm.Value;
			}
			return true;
		}
	}

	public bool FullPermission
	{
		get
		{
			if (base.Entity == null)
			{
				return false;
			}
			if (_fullPerm == null)
			{
				_fullPerm = new Lazy<bool>(() => Locator.GetServiceNotNull<ISecurityService>().HasPermission(PermissionProvider.DocumentFullAccessPermission, base.Entity));
			}
			return _fullPerm.Value;
		}
	}

	public bool ManagerPermissions
	{
		get
		{
			if (base.Entity == null)
			{
				return false;
			}
			if (_managerPerm == null)
			{
				_managerPerm = new Lazy<bool>(() => Locator.GetServiceNotNull<ISecurityService>().HasPermission(PermissionProvider.DocumentManagerAccessPermission, base.Entity));
			}
			return _managerPerm.Value;
		}
	}

	public bool DocumentsDeletePermission
	{
		get
		{
			if (_deletePerm == null)
			{
				_deletePerm = new Lazy<bool>(() => Locator.GetServiceNotNull<ISecurityService>().HasPermission(PermissionProvider.DocumentDeletePermission));
			}
			return _deletePerm.Value;
		}
	}

	public bool HasConvertPermission => Locator.GetServiceNotNull<ISecurityService>().HasPermission(PermissionProvider.DocumentsConvertPermission);

	public List<IFolderViewProvider> ViewProviders => (from p in ComponentManager.Current.GetExtensionPoints<IFolderViewProvider>()
		where p.CheckType(base.Entity)
		select p).ToList();

	public IFolderViewProvider CurrentViewProvider => Locator.GetServiceNotNull<IFolderViewService>().GetCurrent(base.Entity);
}
