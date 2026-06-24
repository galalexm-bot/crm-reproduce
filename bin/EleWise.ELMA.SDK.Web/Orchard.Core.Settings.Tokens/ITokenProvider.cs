using EleWise.ELMA.Events;

namespace Orchard.Core.Settings.Tokens;

public interface ITokenProvider : IEventHandler
{
	void Describe(dynamic context);

	void Evaluate(dynamic context);
}
