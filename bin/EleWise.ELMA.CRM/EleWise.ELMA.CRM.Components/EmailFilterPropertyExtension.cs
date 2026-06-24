using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Extensions;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;

namespace EleWise.ELMA.CRM.Components;

[Component(Order = 1)]
public class EmailFilterPropertyExtension : ILeadFilterProperty
{
	public bool Check(EntityPropertyMetadata property)
	{
		return property.Name == "Email";
	}

	public ICollection<long> GetFilterPropertyList(ICriteria criteria, Type type, EntityPropertyMetadata property, object propertyValue, string nameReturnProperty)
	{
		if (propertyValue is IEnumerable<IEmail> source && source.Any())
		{
			List<long> list = new List<long>();
			foreach (IEmail item in source.Where((IEmail i) => i.EmailString != null && i.EmailString.Length >= 3))
			{
				DetachedCriteria val = DetachedCriteria.For(InterfaceActivator.TypeOf(type)).CreateAlias("Email", "EmailAlias", (JoinType)0).Add((ICriterion)(object)ElmaRestrictions.InsensitiveLike("EmailAlias.EmailString", item.EmailString, MatchMode.Anywhere))
					.SetProjection((IProjection)(object)Projections.Property("Id"));
				criteria.Add((ICriterion)(object)Subqueries.PropertyIn("Id", val));
				criteria.Add((ICriterion)(object)Restrictions.IsNotNull(nameReturnProperty));
				criteria.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property(nameReturnProperty)) });
				list.AddRange(criteria.List<long>());
			}
			return list.Distinct().ToList();
		}
		return new List<long>();
	}
}
