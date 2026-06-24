using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Diagnostics.Glimpse;

[ExtensionPoint(ComponentType.Server)]
public interface IGlimpseMessagesMaker
{
	bool IsAvailable(DiagnosticsEvent @event);

	object[] MakeMessages(DiagnosticsEvent @event);
}
