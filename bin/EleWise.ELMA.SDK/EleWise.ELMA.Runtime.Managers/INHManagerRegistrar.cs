using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Runtime.Managers;

[ExtensionPoint(ComponentType.Server)]
public interface INHManagerRegistrar
{
	void Register(NHManagerRegisterParams parameters);
}
