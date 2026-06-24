using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Common;

[Component]
[ExtensionPoint(false, ComponentType.All, ServiceScope.Application)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IAutoImplement
{
}
