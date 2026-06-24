using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using NHibernate;
using NHibernate.Collection;
using NHibernate.Criterion;
using NHibernate.SqlCommand;

namespace EleWise.ELMA.Common.Components;

[Component(Order = int.MaxValue)]
public class PropertyDuplicateFilter : IPropertyDuplicateFilter
{
	public bool Check(EntityPropertyMetadata property)
	{
		return true;
	}

	public ICollection<long> GetDuplicatesForProperty(ICriteria criteria, Type type, EntityPropertyMetadata property, object propertyValue, string nameReturnProperty)
	{
		List<long> list = new List<long>();
		try
		{
			if (propertyValue != null)
			{
				Type type2 = propertyValue.GetType();
				IPersistentCollection val = (IPersistentCollection)((propertyValue is IPersistentCollection) ? propertyValue : null);
				if (type2.IsGenericType && val != null)
				{
					IEnumerable<Entity<long>> source = val.GetValue() as IEnumerable<Entity<long>>;
					DetachedCriteria val2 = DetachedCriteria.For(InterfaceActivator.TypeOf(type)).CreateAlias(property.Name, property.Name + "Alias", (JoinType)0).Add((ICriterion)(object)Restrictions.In(property.Name + "Alias.Id", (ICollection)source.Select((Entity<long> e) => e.Id).ToArray()))
						.SetProjection((IProjection)(object)Projections.Property("Id"));
					criteria.Add((ICriterion)(object)Subqueries.PropertyIn("Id", val2));
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
				list.AddRange(criteria.List<long>());
				return list;
			}
			return list;
		}
		catch (Exception ex)
		{
			Logger.Log.Error(ex, SR.T("Ошибка при сравнении свойств: {0}", ex.Message));
			return list;
		}
	}
}
