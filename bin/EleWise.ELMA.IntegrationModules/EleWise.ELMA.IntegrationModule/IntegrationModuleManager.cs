using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.IntegrationModules.Metadata;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;

namespace EleWise.ELMA.IntegrationModules.Managers;

public class IntegrationModuleManager : EntityManager<IIntegrationModule, long>
{
	private MetadataItemHeaderManager metadataItemHeaderManager;

	public IntegrationModuleManager(MetadataItemHeaderManager metadataItemHeaderManager)
	{
		this.metadataItemHeaderManager = metadataItemHeaderManager;
	}

	public IEnumerable<Pair<Guid, string>> GetIntegrationModulesDropDownElements(Guid? headerUid = null)
	{
		IMetadataItemHeader metadataItemHeader = null;
		if (headerUid.HasValue)
		{
			metadataItemHeader = metadataItemHeaderManager.LoadOrNull(headerUid.Value);
			if (metadataItemHeader?.Current == null)
			{
				return Enumerable.Empty<Pair<Guid, string>>();
			}
		}
		ICriteria val = CreateCriteria();
		if (metadataItemHeader?.Current != null)
		{
			IntegrationModuleMetadata integrationModuleMetadata = metadataItemHeader.Current.Metadata as IntegrationModuleMetadata;
			val.Add((ICriterion)(object)Restrictions.Eq(NHibernateHelper.GetCriteriaTypeUidPropertyName(integrationModuleMetadata.Uid), (object)integrationModuleMetadata.ImplementationUid));
		}
		val.Add((ICriterion)(object)Restrictions.Eq("IsTemplate", (object)true));
		val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property("Uid"), "First").Add((IProjection)(object)Projections.Property("Name"), "Second") });
		val.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(Pair<Guid, string>)));
		return val.List<Pair<Guid, string>>();
	}

	public void CopyFromTemplate(IIntegrationModule source, IIntegrationModule target)
	{
		Contract.ArgumentNotNull(source, "source");
		if (target == null)
		{
			target = InterfaceActivator.Create(source.GetType()) as IIntegrationModule;
		}
		new CloneHelperBuilder<IIntegrationModule>(source).Restrictions(delegate(RestrictionsBuilder<IIntegrationModule> a)
		{
			a.Rule().ForPropertyName((IIntegrationModule b) => b.Id).Ignore();
			a.Rule().ForPropertyName((IIntegrationModule b) => b.Uid).Ignore();
			a.Rule().ForPropertyName((IIntegrationModule b) => b.IsTemplate).Ignore();
			a.Rule().ForPropertyName((IIntegrationModule b) => b.Error).Ignore();
			a.Rule().ForPropertyName((IIntegrationModule b) => b.AuthAttempt).Ignore();
			a.Rule().ForPropertyName((IIntegrationModule b) => b.CreationAuthor).Ignore();
			a.Rule().ForPropertyName((IIntegrationModule b) => b.CreationDate).Ignore();
		}).Clone(target);
		target.IsTemplate = false;
		target.Template = source;
	}
}
