using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.BPM.Web.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface ICatalogViewHandler
{
	bool CanDelete(IEntity entity);

	bool ShowInCatalogTree(IEntityMetadata metadata);
}
