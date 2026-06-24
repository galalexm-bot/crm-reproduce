using System;
using System.Security;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Common;

[Component]
public class CatalogProfilePermissionsBehavior : EntityManagerBehavior
{
	[NotNull]
	public ISecurityService SecurityService { get; set; }

	[NotNull]
	public RunWithElevatedPrivilegiesService RunWithElevatedPrivilegiesService { get; set; }

	[NotNull]
	public ScriptExecutionService ScriptExecutionService { get; set; }

	[NotNull]
	public IAuthenticationService AuthenticationService { get; set; }

	public override void OnCreateCriteria(ICriteria criteria, IEntityFilter filter)
	{
		if ((filter != null && filter.DisableSecurity) || RunWithElevatedPrivilegiesService.Turned || ScriptExecutionService.Turned)
		{
			return;
		}
		ClassMetadata classMetadata = null;
		try
		{
			Type rootEntityTypeIfAvailable = criteria.GetRootEntityTypeIfAvailable();
			if (rootEntityTypeIfAvailable.IsInheritOrSame<ICatalogProfile>())
			{
				return;
			}
			classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(rootEntityTypeIfAvailable, inherit: false);
		}
		catch
		{
		}
		if (classMetadata == null)
		{
			return;
		}
		EntityMetadata entityMetadata = classMetadata as EntityMetadata;
		if (entityMetadata != null && !entityMetadata.ShowInCatalogList)
		{
			return;
		}
		ICatalogProfile catalogProfile = CatalogManager.Instance.LoadByCatalog(entityMetadata?.ImplementationUid ?? classMetadata.Uid);
		if (catalogProfile != null)
		{
			if (AuthenticationService.GetCurrentUser() == null)
			{
				criteria.Add((ICriterion)(object)Expression.Sql("1=2"));
			}
			else if (!SecurityService.HasPermission(PermissionProvider.CatalogViewPermission, catalogProfile))
			{
				throw new SecurityException(SR.T("Недостаточно прав для просмотра справочника \"{0}\"", classMetadata.DisplayName));
			}
		}
	}
}
