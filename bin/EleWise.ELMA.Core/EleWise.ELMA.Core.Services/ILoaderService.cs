using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Core.Services;

[ServiceContract]
public interface ILoaderService
{
	void Show(string key, string name = null, bool permanent = false);

	void Hide(string key);
}
