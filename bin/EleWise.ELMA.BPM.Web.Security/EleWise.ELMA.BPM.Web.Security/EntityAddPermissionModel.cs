using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class EntityAddPermissionModel
{
	public string LabelText { get; set; }

	public string ButtonText { get; set; }

	public string SubmitScript { get; set; }

	public Type EntityType { get; set; }

	public EntityMetadata EntityMetadata { get; set; }

	public IEnumerable<Tuple<Permission, object, IEnumerable<AssignedRoleTypeModel>>> PermissionTypeRolesModels { get; set; }

	public string PopupId { get; set; }

	public bool Edit { get; set; }

	public Dictionary<long, IEnumerable<Permission>> GrandPermission { get; set; }

	public EntityAddPermissionModel()
	{
	}

	public EntityAddPermissionModel(Type type, EntityMetadata entityMetadata, IEnumerable<Tuple<Permission, object, IEnumerable<AssignedRoleTypeModel>>> stereotypes)
	{
		PermissionTypeRolesModels = stereotypes;
		EntityType = type;
		EntityMetadata = entityMetadata;
	}
}
