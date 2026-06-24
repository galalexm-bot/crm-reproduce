using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using NHibernate;
using Orchard.Environment;
using Orchard.Environment.Extensions.Models;

namespace EleWise.ELMA.Web.Orchard.Enviroment;

public class ModuleEventsImpl : IFeatureEventHandler, IEventHandler, IOrchardShellEvents
{
	private IEnumerable<IModuleEvents> moduleEventses;

	private IEnumerable<IModuleContainerEvents> moduleContainerEventses;

	public ModuleEventsImpl(IEnumerable<IModuleEvents> moduleEventses, IEnumerable<IModuleContainerEvents> moduleContainerEventses)
	{
		this.moduleEventses = moduleEventses;
		this.moduleContainerEventses = moduleContainerEventses;
	}

	public void Installing(Feature feature)
	{
		moduleEventses.ForEach(delegate(IModuleEvents me)
		{
			me.Installing(new Module(feature));
		});
	}

	public void Installed(Feature feature)
	{
		moduleEventses.ForEach(delegate(IModuleEvents me)
		{
			me.Installed(new Module(feature));
		});
	}

	public void Enabling(Feature feature)
	{
		moduleEventses.ForEach(delegate(IModuleEvents me)
		{
			me.Enabling(new Module(feature));
		});
	}

	public void Enabled(Feature feature)
	{
		moduleEventses.ForEach(delegate(IModuleEvents me)
		{
			me.Enabled(new Module(feature));
		});
	}

	public void Disabling(Feature feature)
	{
		moduleEventses.ForEach(delegate(IModuleEvents me)
		{
			me.Disabling(new Module(feature));
		});
	}

	public void Disabled(Feature feature)
	{
		moduleEventses.ForEach(delegate(IModuleEvents me)
		{
			me.Disabled(new Module(feature));
		});
	}

	public void Uninstalling(Feature feature)
	{
		moduleEventses.ForEach(delegate(IModuleEvents me)
		{
			me.Uninstalling(new Module(feature));
		});
	}

	public void Uninstalled(Feature feature)
	{
		moduleEventses.ForEach(delegate(IModuleEvents me)
		{
			me.Uninstalled(new Module(feature));
		});
	}

	public void Activated()
	{
		moduleEventses = ComponentManager.Current.GetExtensionPoints<IModuleEvents>();
		moduleContainerEventses = ComponentManager.Current.GetExtensionPoints<IModuleContainerEvents>();
		ISession session = Locator.GetServiceNotNull<ISessionProvider>().GetSession("");
		moduleContainerEventses.ForEach(delegate(IModuleContainerEvents me)
		{
			me.Activated();
			session.Flush();
		});
	}

	public void Terminating()
	{
		moduleContainerEventses.ForEach(delegate(IModuleContainerEvents me)
		{
			me.Terminating();
		});
	}
}
