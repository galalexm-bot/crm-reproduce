using EleWise.ELMA.Events;

namespace EleWise.ELMA.Model.Metadata;

public interface IMetadataPublishFinishedEventHandler : IEventHandler
{
	void PublishExecuted(MetadataPublishedEventArgs e);
}
