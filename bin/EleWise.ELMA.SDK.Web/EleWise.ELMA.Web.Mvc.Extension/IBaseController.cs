using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Mvc.UI;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(false, ComponentType.Web | ComponentType.Test, ServiceScope.Shell)]
public interface IBaseController
{
	INotifier Notifier { get; set; }

	PoolBasedSettingsService PoolBasedSettingsService { get; set; }

	ISecurityService SecurityService { get; set; }

	IAuthenticationService AuthenticationService { get; set; }
}
[ExtensionPoint(false, ComponentType.Web | ComponentType.Test, ServiceScope.Shell)]
public interface IBaseController<TModel, TModelId> : IBaseController where TModel : IEntity<TModelId>
{
	IEntityManager<TModel, TModelId> Manager { get; set; }
}
