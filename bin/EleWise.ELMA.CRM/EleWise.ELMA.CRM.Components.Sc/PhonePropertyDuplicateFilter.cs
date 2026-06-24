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

[Component(Order = 2)]
internal class PhonePropertyDuplicateFilter : IPropertyDuplicateFilter
{
	public bool Check(EntityPropertyMetadata property)
	{
		return property.Name == "Phone";
	}

	public ICollection<long> GetDuplicatesForProperty(ICriteria criteria, Type type, EntityPropertyMetadata property, object propertyValue, string nameReturnProperty)
	{
		List<long> result = new List<long>();
		try
		{
			if (propertyValue != null)
			{
				IEnumerable<IPhone> enumerable = propertyValue as IEnumerable<IPhone>;
				IList<IPhone> list = (enumerable as IList<IPhone>) ?? enumerable.ToList();
				if (enumerable != null)
				{
					if (list.Any())
					{
						List<long> list2 = new List<long>();
						foreach (IPhone item in list)
						{
							if (!string.IsNullOrWhiteSpace(item.PhoneString))
							{
								DetachedCriteria val = DetachedCriteria.For(InterfaceActivator.TypeOf(type)).CreateAlias("Phone", "PhoneAlias", (JoinType)0).Add((ICriterion)(object)ElmaRestrictions.Like("PhoneAlias.PhoneString", item.PhoneString, MatchMode.Exact))
									.SetProjection((IProjection)(object)Projections.Property("Id"));
								criteria.Add((ICriterion)(object)Subqueries.PropertyIn("Id", val));
								criteria.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property(nameReturnProperty)) });
								list2.AddRange(criteria.List<long>());
							}
						}
						return list2.Distinct().ToList();
					}
					return result;
				}
				return result;
			}
			return result;
		}
		catch (Exception ex)
		{
			Logger.Log.Error(ex, SR.T("Ошибка при сравнении свойств: {0}", ex.Message));
			return result;
		}
	}
}
