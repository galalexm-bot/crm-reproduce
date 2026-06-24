using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Services;

[ServiceContract]
public interface IDownloadService
{
	void Download(string url, string fileName = null);
}
