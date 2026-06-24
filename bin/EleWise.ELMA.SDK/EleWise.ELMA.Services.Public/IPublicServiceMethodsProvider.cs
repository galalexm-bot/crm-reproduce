using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Services.Public;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
[ExtensionPoint(ComponentType.Server)]
public interface IPublicServiceMethodsProvider
{
	IEnumerable<IPublicServiceMethod> GetMethods();
}
