using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using NHibernate;

namespace EleWise.ELMA.Documents.Extensions;

[ExtensionPoint(ComponentType.WebServer)]
public interface IDocumentFilterExtension
{
	void AddFilterCriteris(ICriteria criteria, IEntityFilter filter);
}
