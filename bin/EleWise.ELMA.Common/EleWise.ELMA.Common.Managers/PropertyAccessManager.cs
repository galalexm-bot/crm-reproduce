using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Common.Managers;

public class PropertyAccessManager : EntityManager<IPropertyAccess, long>
{
	public new static PropertyAccessManager Instance => Locator.GetServiceNotNull<PropertyAccessManager>();

	public IList<IPropertyAccess> GetPropertyAccessList(List<ReferenceOnEntityType> typeReferences)
	{
		DetachedCriteria val = DetachedCriteria.For(InterfaceActivator.TypeOf<IPropertyProfile>()).Add((ICriterion)(object)Restrictions.In("CatalogType", typeReferences.Cast<object>().ToArray())).SetProjection(Projections.Distinct((IProjection)(object)Projections.Property("Id")));
		ICriteria obj = CreateCriteria();
		obj.Add((ICriterion)(object)Subqueries.PropertyIn("PropertyProfile", val));
		return obj.List<IPropertyAccess>();
	}
}
