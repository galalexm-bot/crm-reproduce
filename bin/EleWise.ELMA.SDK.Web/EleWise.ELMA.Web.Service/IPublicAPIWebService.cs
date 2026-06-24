using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Web.Service;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
[ExtensionPoint(false, ComponentType.Server, ServiceScope.Application)]
public interface IPublicAPIWebService
{
}
