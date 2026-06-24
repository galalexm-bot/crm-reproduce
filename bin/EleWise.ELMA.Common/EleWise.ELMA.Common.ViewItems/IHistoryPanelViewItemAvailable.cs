using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Common.ViewItems;

[ExtensionPoint(ComponentType.All)]
public interface IHistoryPanelViewItemAvailable
{
	bool? IsAvailable(IMetadata metadata);
}
