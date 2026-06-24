using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using NHibernate.Criterion;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IQueryInFunction
{
	string FunctionName { get; }

	ICriterion GetCriterion(string alias, EntityMetadata metadata, string propName, object[] parameters);
}
