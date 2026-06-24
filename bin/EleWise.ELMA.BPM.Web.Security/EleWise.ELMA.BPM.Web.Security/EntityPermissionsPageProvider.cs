using System.Linq;
using System.Security;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web.Security.Components;

[Component]
public abstract class EntityPermissionsPageProvider<TEntity> : IEntityPermissionsPageProvider where TEntity : class
{
	protected ISecurityService SecurityService { get; private set; }

	protected virtual Permission[] AccessPermissions => new Permission[1] { PermissionProvider.AccessManagmentPermission };

	public EntityPermissionsPageProvider()
	{
		SecurityService = Locator.GetServiceNotNull<ISecurityService>();
	}

	public virtual bool IsSupported(object entity)
	{
		return entity is TEntity;
	}

	public void CheckAccess(object entity)
	{
		Permission[] accessPermissions = AccessPermissions;
		if (accessPermissions == null || accessPermissions.Any((Permission p) => SecurityService.HasPermission(p)))
		{
			return;
		}
		if (accessPermissions.Length == 1)
		{
			throw new SecurityException(SR.T("Отсутствует привилегия \"{0}\"", SR.T(accessPermissions.First().Name)));
		}
		if (accessPermissions.Length > 1)
		{
			throw new SecurityException(SR.T("Нет ни одной из привилегий доступа ({0})", string.Join(", ", accessPermissions.Select((Permission p) => $"\"{p.Name}\""))));
		}
		throw new SecurityException(SR.T("Отсутствуют привилегии для настройки прав доступа к объекту"));
	}
}
