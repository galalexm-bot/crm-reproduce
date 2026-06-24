using EleWise.ELMA.Events;

namespace EleWise.ELMA.Model.Metadata.ExtensionPoints;

public interface IAfterDeltaPublishEventHandler : IEventHandler
{
	void Processing(MetadataPublishedEventArgs e);
}
