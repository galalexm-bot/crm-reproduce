using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.ComponentModel;

[ExtensionPoint(ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IInitHandler
{
	void Init();

	void InitComplete();
}
