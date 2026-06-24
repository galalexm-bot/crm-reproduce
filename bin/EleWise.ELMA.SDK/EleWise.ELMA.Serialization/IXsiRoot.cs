using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Serialization;

[ExtensionPoint(false, ComponentType.All, ServiceScope.Application, ForceRegister = true)]
public interface IXsiRoot
{
}
