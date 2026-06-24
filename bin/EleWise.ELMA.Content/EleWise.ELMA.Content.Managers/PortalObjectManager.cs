using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Content.Managers;

public class PortalObjectManager<T, TId> : EntityManager<T, TId> where T : IPortalObject, IEntity<TId>
{
	protected override void SetupFetchOptions(ICriteria criteria, FetchOptions fetchOptions, Type entityType)
	{
		if (typeof(T).IsAssignableFrom(entityType) && !(criteria is DetachedCriteriaAdapter))
		{
			criteria.AddOrder(Order.Asc("SortTypeId"));
		}
		base.SetupFetchOptions(criteria, fetchOptions, entityType);
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
		if (filter is IPortalObjectFilter portalObjectFilter && portalObjectFilter.IsRoot.HasValue)
		{
			criteria.Add((ICriterion)(object)(portalObjectFilter.IsRoot.Value ? Restrictions.IsNull("Folder") : Restrictions.IsNotNull("Folder")));
		}
	}

	public virtual void AddPermissionsFromParent(T portalObj)
	{
		if (portalObj == null)
		{
			throw new ArgumentNullException("portalObj");
		}
		if (portalObj.Folder == null)
		{
			throw new ArgumentException("portalObj.Folder");
		}
		IPageFolder parent = portalObj.Folder;
		foreach (IPortalObjectPermission s in (IEnumerable<IPortalObjectPermission>)parent.Permissions)
		{
			if (!((IEnumerable<IPortalObjectPermission>)portalObj.Permissions).Any(delegate(IPortalObjectPermission p)
			{
				Guid? permissionRole = p.PermissionRole;
				Guid? permissionRole2 = s.PermissionRole;
				return permissionRole.HasValue == permissionRole2.HasValue && (!permissionRole.HasValue || permissionRole.GetValueOrDefault() == permissionRole2.GetValueOrDefault()) && p.PermissionId == s.PermissionId && p.TypeRoleId == s.TypeRoleId && p.User == s.User && p.Group == s.Group && p.OrganizationItemEmployee == s.OrganizationItemEmployee && p.OrganizationItemPosition == s.OrganizationItemPosition && ((s.InheritedFromFolder == null && EntityHelper.Equals(p.InheritedFromFolder, parent)) || (p.InheritedFromFolder != null && EntityHelper.Equals(p.InheritedFromFolder, s.InheritedFromFolder)));
			}))
			{
				InstanceOf<IPortalObjectPermission> instanceOf = new InstanceOf<IPortalObjectPermission>();
				instanceOf.New.PortalObject = portalObj;
				instanceOf.New.User = s.User;
				instanceOf.New.Group = s.Group;
				instanceOf.New.InheritedFromFolder = s.InheritedFromFolder ?? parent.Cast<IPageFolder, IPortalObject>();
				instanceOf.New.OrganizationItemEmployee = s.OrganizationItemEmployee;
				instanceOf.New.OrganizationItemPosition = s.OrganizationItemPosition;
				instanceOf.New.PermissionId = s.PermissionId;
				instanceOf.New.TypeRoleId = s.TypeRoleId;
				instanceOf.New.PermissionRole = s.PermissionRole;
				IPortalObjectPermission @new = instanceOf.New;
				portalObj.Permissions.Add(@new);
			}
		}
	}

	[Transaction]
	public virtual void EnableInheritPermissions(T portalObj, bool enable)
	{
		if (enable)
		{
			portalObj.InheritPermissions = true;
			if (portalObj.Folder != null)
			{
				AddPermissionsFromParent(portalObj);
			}
		}
		else
		{
			portalObj.InheritPermissions = false;
			if (portalObj.Folder != null)
			{
				((IEnumerable<IPortalObjectPermission>)portalObj.Permissions).ForEach(delegate(IPortalObjectPermission p)
				{
					p.InheritedFromFolder = null;
				});
			}
		}
		Save(portalObj);
	}

	[Transaction]
	public virtual void UpdatePermissions(IPortalObject portalObject)
	{
		long id = portalObject.Id;
		bool flag = !portalObject.InheritPermissions;
		IQuery namedQuery = base.Session.GetNamedQuery("ExecUpdateInheritPortalObjectPermissions");
		namedQuery.SetTimeout(TransformationProviderBase.DefaultCommandTimeout);
		namedQuery.SetParameter<long>("objId", id);
		namedQuery.SetParameter<bool>("onlyChildren", flag);
		namedQuery.ExecuteUpdate(cleanUpCache: false);
		base.Session.CleanUpCache(typeof(IPortalObjectPermission));
	}

	[Transaction]
	public virtual void MoveTo(IPageFolder newFolder, List<TId> objectsId, List<IPortalObject> objects = null)
	{
		if (newFolder != null && objectsId != null && objectsId.Count != 0)
		{
			if (objects == null)
			{
				objects = FindByIdArray(objectsId.ToArray()).OfType<IPortalObject>().ToList();
			}
			ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
			serviceNotNull.ExecuteNonQuery(string.Format("update PortalObject set {2} = {0} where {3} in ({1})", newFolder.Id, string.Join(",", objectsId.Select((TId o) => Convert.ToString(o)).ToArray()), serviceNotNull.Dialect.QuoteIfNeeded("Folder"), serviceNotNull.Dialect.QuoteIfNeeded("Id")));
			base.Session.Flush();
			UpdatePermissions(newFolder);
		}
	}
}
public class PortalObjectManager : PortalObjectManager<IPortalObject, long>
{
	public new static PortalObjectManager Instance => Locator.GetServiceNotNull<PortalObjectManager>();
}
