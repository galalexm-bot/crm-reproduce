using EleWise.ELMA.Events;

namespace EleWise.ELMA.Model.Metadata;

public interface IMetadataItemSaveEventHandler : IEventHandler
{
	void BeforeSave(IMetadataItem metadataItem);
}
