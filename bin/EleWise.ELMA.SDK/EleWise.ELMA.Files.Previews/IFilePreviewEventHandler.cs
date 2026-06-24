using System;
using System.Threading.Tasks;
using EleWise.ELMA.Events;

namespace EleWise.ELMA.Files.Previews;

public interface IFilePreviewEventHandler : IEventHandler
{
	Task Complete(string fileId, Exception exception = null);
}
