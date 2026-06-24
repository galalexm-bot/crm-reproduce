using System;
using Autofac;
using Autofac.Core;

namespace EleWise.ELMA.BPM.Web.Content.Components;

internal class WorkPlaceVirtualPathProviderActivationModule : Module
{
	protected override void AttachToComponentRegistration(IComponentRegistry componentRegistry, IComponentRegistration registration)
	{
		registration.add_Activated((EventHandler<ActivatedEventArgs<object>>)RegistrationOnActivated);
	}

	private void RegistrationOnActivated(object sender, ActivatedEventArgs<object> activatedEventArgs)
	{
		if (activatedEventArgs.get_Instance() is WorkPlaceVirtualPathProvider workPlaceVirtualPathProvider)
		{
			workPlaceVirtualPathProvider.Activated();
		}
	}
}
