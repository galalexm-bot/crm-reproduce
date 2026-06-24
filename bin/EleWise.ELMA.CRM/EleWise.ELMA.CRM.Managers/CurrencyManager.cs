using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;

namespace EleWise.ELMA.CRM.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class CurrencyManager : EntityManager<ICurrency, long>
{
	public new static CurrencyManager Instance => Locator.GetServiceNotNull<CurrencyManager>();

	public IEnumerable<string> GetAvalailableCodes(IEnumerable<string> codes = null)
	{
		ICriteria val = CreateCriteria().SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)ProjectionFor((ICurrency a) => a.CodeISOAlphabetic) });
		if (codes != null)
		{
			val.Add((ICriterion)(object)Restrictions.In((IProjection)(object)ProjectionFor((ICurrency h) => h.CodeISOAlphabetic), (ICollection)codes.ToList()));
		}
		return val.List<string>();
	}

	public IEnumerable<CurrencyHelpModel> GetCurrencyValuesByCodes(IEnumerable<string> codes = null)
	{
		ICriteria val = CreateCriteria().SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property("Id"), "Id").Add((IProjection)(object)Projections.Property("CodeISOAlphabetic"), "Code") });
		if (codes != null)
		{
			val.Add((ICriterion)(object)Restrictions.In((IProjection)(object)ProjectionFor((ICurrency h) => h.CodeISOAlphabetic), (ICollection)codes.ToList()));
		}
		return val.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(CurrencyHelpModel))).List<CurrencyHelpModel>();
	}
}
