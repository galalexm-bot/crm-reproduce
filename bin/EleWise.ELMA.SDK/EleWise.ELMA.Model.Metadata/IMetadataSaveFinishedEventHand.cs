using EleWise.ELMA.Events;

namespace EleWise.ELMA.Model.Metadata;

public interface IMetadataSaveFinishedEventHandler : IEventHandler
{
	void SaveExecuted(MetadataSavedEventArgs e);
}
