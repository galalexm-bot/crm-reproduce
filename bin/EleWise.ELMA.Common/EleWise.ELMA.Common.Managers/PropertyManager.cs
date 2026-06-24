using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Common.Managers;

public class PropertyManager : EntityManager<IPropertyProfile, long>
{
	public new static PropertyManager Instance => Locator.GetServiceNotNull<PropertyManager>();

	public IList<IPropertyProfile> LoadPropertyProfileByCatalogType(ReferenceOnEntityType type)
	{
		IList<IPropertyProfile> profile = null;
		Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(delegate
		{
			ICriteria val = CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("CatalogType", (object)type));
			profile = val.List<IPropertyProfile>();
		});
		return profile;
	}

	public IList<IPropertyAccess> GetAccessesByProfile(IPropertyProfile profile)
	{
		IList<IPropertyAccess> list = null;
		Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(delegate
		{
			ICriteria val = CreateCriteria(null, InterfaceActivator.TypeOf<IPropertyAccess>()).Add((ICriterion)(object)Restrictions.Eq("PropertyProfile", (object)profile));
			list = val.List<IPropertyAccess>();
		});
		return list;
	}
}
