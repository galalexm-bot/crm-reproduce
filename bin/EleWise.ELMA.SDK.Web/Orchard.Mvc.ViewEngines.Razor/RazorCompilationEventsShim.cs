using System;
using System.Threading;
using System.Web.Razor.Generator;
using System.Web.WebPages.Razor;
using Orchard.Environment;

namespace Orchard.Mvc.ViewEngines.Razor;

public class RazorCompilationEventsShim : IShim
{
	private static int _initialized;

	public IOrchardHostContainer HostContainer { get; set; }

	private RazorCompilationEventsShim()
	{
		OrchardHostContainerRegistry.RegisterShim(this);
		RazorBuildProvider.add_CodeGenerationStarted((EventHandler)RazorBuildProviderCodeGenerationStarted);
		RazorBuildProvider.add_CodeGenerationCompleted((EventHandler<CodeGenerationCompleteEventArgs>)RazorBuildProviderCodeGenerationCompleted);
	}

	private void RazorBuildProviderCodeGenerationStarted(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		RazorBuildProvider provider = (RazorBuildProvider)sender;
		HostContainer.Resolve<IRazorCompilationEvents>().CodeGenerationStarted(provider);
	}

	private void RazorBuildProviderCodeGenerationCompleted(object sender, CodeGenerationCompleteEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		RazorBuildProvider provider = (RazorBuildProvider)sender;
		HostContainer.Resolve<IRazorCompilationEvents>().CodeGenerationCompleted(provider, e);
	}

	public static void EnsureInitialized()
	{
		if (Interlocked.CompareExchange(ref _initialized, 1, 0) == 0)
		{
			new RazorCompilationEventsShim();
		}
	}
}
