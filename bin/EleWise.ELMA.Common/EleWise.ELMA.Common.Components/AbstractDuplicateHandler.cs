using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Common.Components;

public abstract class AbstractDuplicateHandler : IDuplicateHandler
{
	private readonly IEnumerable<IPropertyDuplicateFilter> propertyDuplicateFilters;

	private readonly IEnumerable<IScoringSettings> entityScoringSettings;

	private readonly IEnumerable<IScoringStepSettings> entityScorinStepSettings;

	private ISessionProvider sessionProvider;

	private IMetadataRuntimeService metadataRuntimeService;

	public AbstractDuplicateHandler(IEnumerable<IPropertyDuplicateFilter> propertyDuplicateFilters, IEnumerable<IScoringSettings> entityScoringSettings, IEnumerable<IScoringStepSettings> entityScorinStepSettings, ISessionProvider sessionProvider, IMetadataRuntimeService metadataRuntimeService)
	{
		Contract.ArgumentNotNull(propertyDuplicateFilters, "propertyDuplicateFilters");
		Contract.ArgumentNotNull(entityScoringSettings, "entityScoringSettings");
		Contract.ArgumentNotNull(entityScorinStepSettings, "entityScorinStepSettings");
		Contract.ArgumentNotNull(sessionProvider, "sessionProvider");
		Contract.ArgumentNotNull(metadataRuntimeService, "metadataRuntimeService");
		this.propertyDuplicateFilters = propertyDuplicateFilters;
		this.entityScoringSettings = entityScoringSettings;
		this.entityScorinStepSettings = entityScorinStepSettings;
		this.sessionProvider = sessionProvider;
		this.metadataRuntimeService = metadataRuntimeService;
	}

	public virtual Guid? EntityType()
	{
		return default(Guid);
	}

	public virtual List<PossibleDuplicate> GetPossibleDuplicates(IEntity entity)
	{
		List<PossibleDuplicate> list = new List<PossibleDuplicate>();
		Type type = entity.GetType();
		EntityMetadata metadata = MetadataLoader.LoadMetadata(type) as EntityMetadata;
		if (metadata != null)
		{
			IScoringSettings scoringSettings = entityScoringSettings.FirstOrDefault((IScoringSettings x) => x.Check(metadata.Uid));
			IScoringStepSettings scoringStepSettings = entityScorinStepSettings.FirstOrDefault((IScoringStepSettings x) => x.Check(metadata.Uid));
			List<long> list2 = new List<long>();
			if (scoringSettings != null && scoringStepSettings != null)
			{
				IEnumerable<IScoringSettings> scoringSettings2 = scoringSettings.GetScoringSettings();
				ISession session = sessionProvider.GetSession("");
				{
					foreach (IScoringSettings scoringProperty in scoringSettings2)
					{
						EntityPropertyMetadata entityProperty = (EntityPropertyMetadata)metadata.Properties.FirstOrDefault((PropertyMetadata x) => x.Uid == scoringProperty.Property);
						if (scoringProperty.TypeUid == scoringProperty.DuplicateTypeUid)
						{
							IPropertyDuplicateFilter propertyDuplicateFilter = propertyDuplicateFilters.FirstOrDefault((IPropertyDuplicateFilter x) => x.Check(entityProperty));
							ICriteria val = session.CreateCriteria(type);
							if (type.GetInterfaces().Contains(typeof(ISoftDeletable)))
							{
								val.Add((ICriterion)(object)Restrictions.Eq("IsDeleted", (object)false));
							}
							if (propertyDuplicateFilter != null)
							{
								list2.AddRange(propertyDuplicateFilter.GetDuplicatesForProperty(val, type, entityProperty, entity.GetPropertyValue(entityProperty.Name, null), "Id"));
							}
						}
						else
						{
							Type typeByUid = metadataRuntimeService.GetTypeByUid(scoringProperty.DuplicateTypeUid);
							EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(typeByUid) as EntityMetadata;
							EntityPropertyMetadata duplicateProperty = (EntityPropertyMetadata)entityMetadata.Properties.FirstOrDefault((PropertyMetadata x) => x.Uid == scoringProperty.DuplicateProperty);
							IPropertyDuplicateFilter propertyDuplicateFilter2 = propertyDuplicateFilters.FirstOrDefault((IPropertyDuplicateFilter x) => x.Check(duplicateProperty));
							ICriteria val2 = session.CreateCriteria(typeByUid);
							if (typeByUid.GetInterfaces().Contains(typeof(ISoftDeletable)))
							{
								val2.Add((ICriterion)(object)Restrictions.Eq("IsDeleted", (object)false));
							}
							if (propertyDuplicateFilter2 != null)
							{
								list2.AddRange(propertyDuplicateFilter2.GetDuplicatesForProperty(val2, typeByUid, duplicateProperty, entity.GetPropertyValue(entityProperty.Name, null), "Id"));
							}
						}
						foreach (long item in list2.Where((long m) => m != (long)entity.GetId()))
						{
							ReferenceOnEntity currentDuplicate = ReferenceOnEntity.Create(scoringProperty.DuplicateTypeUid, item);
							PossibleDuplicate possibleDuplicate = list.FirstOrDefault((PossibleDuplicate x) => x.DuplicateReference.Equals(currentDuplicate));
							if (possibleDuplicate != null)
							{
								possibleDuplicate.Weight += scoringProperty.PercentValue;
								possibleDuplicate.PropertyList.Add(scoringProperty.Property);
								continue;
							}
							list.Add(new PossibleDuplicate
							{
								DuplicateReference = currentDuplicate,
								Weight = scoringProperty.PercentValue,
								PropertyList = new List<Guid> { scoringProperty.Property }
							});
						}
						IEnumerable<IScoringStepSettings> scoringStepSettings2 = scoringStepSettings.GetScoringStepSettings();
						IScoringStepSettings minStep = scoringStepSettings2.OrderBy((IScoringStepSettings m) => m.PercentValue).FirstOrDefault();
						if (minStep != null)
						{
							list.RemoveAll((PossibleDuplicate m) => m.Weight < minStep.PercentValue);
						}
						list2.Clear();
					}
					return list;
				}
			}
		}
		return list;
	}

	public virtual bool IsScoringEnabled(Guid TypeUid)
	{
		Guid? guid = EntityType();
		return TypeUid == guid;
	}
}
