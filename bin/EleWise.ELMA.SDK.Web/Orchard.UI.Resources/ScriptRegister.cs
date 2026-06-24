using System;
using System.Web.Mvc;

namespace Orchard.UI.Resources;

public abstract class ScriptRegister : ResourceRegister
{
	protected ScriptRegister(IViewDataContainer container, IResourceManager resourceManager)
		: base(container, resourceManager, "script")
	{
	}

	public abstract IDisposable Head();

	public abstract IDisposable Foot();
}
