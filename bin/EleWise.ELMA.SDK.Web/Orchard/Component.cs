using EleWise.ELMA.Logging;
using Orchard.Localization;

namespace Orchard;

public abstract class Component : IDependency
{
	public ILogger Logger { get; set; }

	public Localizer T { get; set; }

	protected Component()
	{
		Logger = NullLogger.Instance;
		T = NullLocalizer.Instance;
	}
}
