using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Routing;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class EntityPermissionRoleTypeSelectorModel
{
	public bool DisabledNotUserGroup { get; set; }

	public object Instance { get; set; }

	public Type EntityType { get; set; }

	public EntityMetadata EntityMetadata { get; set; }

	public IEnumerable<Tuple<Permission, PermissionRoleTypeSelectorModel, IEnumerable<AssignedRoleTypeModel>>> PermissionTypeRolesModels { get; set; }

	public bool Edit { get; set; }

	public IEnumerable<Permission> GrandPermission { get; set; }

	public Func<Permission[], Permission[], Permission, Guid, IEntity, object, bool> PermissionCanGrantResolver { get; set; }

	public Func<Guid, IEntity, object, bool> IsSystemRole { get; set; }

	public string PopupId { get; set; }

	public string BindModelName { get; set; }

	public bool ShowSaveButton { get; set; }

	public bool NoForm { get; set; }

	public RouteValueDictionary Routes { get; set; }

	public List<EntityPermissionRoleTypeSelectorModel> PropertyPermissionRoleTypeSelectorList { get; set; }

	public bool IsCatalog { get; set; }

	public Guid HidePropertyPermissionId { get; set; }

	public Guid ViewPropertyPermissionId { get; set; }

	public Guid EditPropertyPermissionId { get; set; }

	public bool Ajax { get; internal set; }

	public bool IsInstancePermissionSupport { get; set; }

	public string OnClosePopupFunction { get; set; }

	public EntityPermissionRoleTypeSelectorModel()
	{
		BindModelName = "access";
		ShowSaveButton = true;
	}

	public EntityPermissionRoleTypeSelectorModel(object instance, Type type, EntityMetadata entityMetadata, IEnumerable<Tuple<Permission, PermissionRoleTypeSelectorModel, IEnumerable<AssignedRoleTypeModel>>> stereotypes)
		: this()
	{
		Instance = instance;
		PermissionTypeRolesModels = stereotypes;
		EntityType = type;
		EntityMetadata = entityMetadata;
	}

	public IEnumerable<object> GetPermissionDependencies()
	{
		if (PermissionTypeRolesModels == null)
		{
			return null;
		}
		return PermissionTypeRolesModels.Select((Tuple<Permission, PermissionRoleTypeSelectorModel, IEnumerable<AssignedRoleTypeModel>> p) => new
		{
			id = p.Item1.Id.ToString(),
			dependencies = p.Item1.AllDependencies.Select((Permission dp) => dp.Id.ToString())
		});
	}

	public IEnumerable<Permission> GetOrderedPermissions()
	{
		if (PermissionTypeRolesModels == null)
		{
			return null;
		}
		return PermissionTypeRolesModels.Select((Tuple<Permission, PermissionRoleTypeSelectorModel, IEnumerable<AssignedRoleTypeModel>> p) => p.Item1).PartialOrderBy((Permission p) => p, new FunctorComparer<Permission>(delegate(Permission p1, Permission p2)
		{
			if (p1.AllDependencies.Contains(p2))
			{
				return 1;
			}
			return p2.AllDependencies.Contains(p1) ? (-1) : 0;
		}));
	}
}
