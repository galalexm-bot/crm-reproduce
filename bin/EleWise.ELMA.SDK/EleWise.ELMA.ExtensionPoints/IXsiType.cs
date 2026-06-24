using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(false, ComponentType.All, ServiceScope.Application, ForceRegister = true)]
public interface IXsiType
{
}
