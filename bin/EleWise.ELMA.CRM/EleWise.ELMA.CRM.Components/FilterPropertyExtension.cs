using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.NH;
using NHibernate;
using NHibernate.Collection;
using NHibernate.Criterion;
using NHibernate.SqlCommand;

namespace EleWise.ELMA.CRM.Components;

[Component(Order = int.MaxValue)]
public class FilterPropertyExtension : ILeadFilterProperty
{
	public bool Check(EntityPropertyMetadata property)
	{
		return true;
	}

	public ICollection<long> GetFilterPropertyList(ICriteria criteria, Type type, EntityPropertyMetadata property, object propertyValue, string nameReturnProperty)
	{
		if (propertyValue != null)
		{
			if (propertyValue.GetType().IsGenericType)
			{
				IPersistentCollection val = (IPersistentCollection)((propertyValue is IPersistentCollection) ? propertyValue : null);
				if (val == null)
				{
					return new List<long>();
				}
				IEnumerable<Entity<long>> source = val.GetValue() as IEnumerable<Entity<long>>;
				if (MetadataServiceContext.Service.GetTypeDescriptor(property.TypeUid, property.SubTypeUid) is EntityDescriptor)
				{
					DetachedCriteria val2 = DetachedCriteria.For(InterfaceActivator.TypeOf(type)).CreateAlias(property.Name, property.Name + "Alias", (JoinType)0).Add((ICriterion)(object)Restrictions.In(property.Name + "Alias.Id", (ICollection)source.Select((Entity<long> e) => e.Id).ToArray()))
						.SetProjection((IProjection)(object)Projections.Property("Id"));
					criteria.Add((ICriterion)(object)Subqueries.PropertyIn("Id", val2));
				}
				else
				{
					object[] array = source.Select((Entity<long> e) => e.GetPropertyValue(property.Name, null)).ToArray();
					if (Array.Exists(array, (object e) => e != null))
					{
						criteria.Add((ICriterion)(object)Restrictions.In(property.Name, array));
					}
				}
			}
			else
			{
				Type rootEntityTypeIfAvailable = criteria.GetRootEntityTypeIfAvailable();
				if (rootEntityTypeIfAvailable == null)
				{
					throw new NullReferenceException(SR.T("Не удалось получить тип корневой сущности у критерии"));
				}
				EntityMetadata metadata = (EntityMetadata)MetadataLoader.LoadMetadata(rootEntityTypeIfAvailable);
				criteria.Add((ICriterion)(object)new EqExpression(property.Name, metadata, propertyValue));
			}
			criteria.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property(nameReturnProperty)) });
			return criteria.List<long>();
		}
		return new List<long>();
	}
}
