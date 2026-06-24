using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;

namespace EleWise.ELMA.CRM.Components.Scoring;

[Component(Order = 1)]
public class EmailPropertyDuplicateFilter : IPropertyDuplicateFilter
{
	public bool Check(EntityPropertyMetadata property)
	{
		return property.Name == "Email";
	}

	public ICollection<long> GetDuplicatesForProperty(ICriteria criteria, Type type, EntityPropertyMetadata property, object propertyValue, string nameReturnProperty)
	{
		List<long> list = new List<long>();
		try
		{
			if (propertyValue != null)
			{
				if (propertyValue is IEnumerable<IEmail> enumerable)
				{
					if (enumerable.Any())
					{
						foreach (IEmail item in enumerable)
						{
							if (!string.IsNullOrWhiteSpace(item.EmailString))
							{
								DetachedCriteria val = DetachedCriteria.For(InterfaceActivator.TypeOf(type)).CreateAlias("Email", "EmailAlias", (JoinType)0).Add((ICriterion)(object)ElmaRestrictions.InsensitiveLike("EmailAlias.EmailString", item.EmailString, MatchMode.Anywhere))
									.SetProjection((IProjection)(object)Projections.Property("Id"));
								criteria.Add((ICriterion)(object)Subqueries.PropertyIn("Id", val));
								criteria.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property(nameReturnProperty)) });
								list.AddRange(criteria.List<long>());
							}
						}
						return list.Distinct().ToList();
					}
					return list;
				}
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
