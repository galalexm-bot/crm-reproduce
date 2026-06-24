using EleWise.ELMA.ComponentModel;
using NHibernate;

namespace EleWise.ELMA.Model.Common;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IFindCriteriaExtender
{
	string QueryKey { get; }

	void Extend(IEntityFilter filter, ICriteria criteria, FetchOptions fetchOptions);
}
