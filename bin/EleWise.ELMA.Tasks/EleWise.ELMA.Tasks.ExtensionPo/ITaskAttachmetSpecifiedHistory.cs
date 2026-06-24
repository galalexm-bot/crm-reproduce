using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface ITaskAttachmetSpecifiedHistoryExtension : ITaskAttachmetSpecifiedExtension
{
	bool AttachmentsIdsInitialized(ITaskBase task);
}
