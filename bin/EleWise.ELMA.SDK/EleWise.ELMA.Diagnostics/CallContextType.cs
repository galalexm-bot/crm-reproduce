using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Diagnostics;

public enum CallContextType
{
	[DisplayName("Web Request")]
	WebRequest,
	[DisplayName("Background thread")]
	Background,
	[DisplayName("Background task")]
	BackgroundTask,
	[DisplayName("User diagnostics subsession")]
	SubContext
}
