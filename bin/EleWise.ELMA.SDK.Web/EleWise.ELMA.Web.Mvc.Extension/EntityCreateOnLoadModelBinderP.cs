using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Extensions;

[Component]
public class EntityCreateOnLoadModelBinderProvider : IEntityModelBinderProvider
{
	public const string UID_S = "67E95AF5-2EB2-453E-ACDB-F61B9ADAD3AC";

	public static readonly Guid UID = new Guid("67E95AF5-2EB2-453E-ACDB-F61B9ADAD3AC");

	public ISecurityService SecurityService { get; set; }

	public Guid ProviderUid => UID;

	public object LoadEntity(Type entityType, object id)
	{
		object entity = null;
		SecurityService.RunWithElevatedPrivilegiesAndWithDeleted(delegate
		{
			IEntityManager entityManager = ModelHelper.GetEntityManager(entityType);
			entity = entityManager.LoadOrCreate(id).CastAsRealType();
		});
		return entity;
	}
}
