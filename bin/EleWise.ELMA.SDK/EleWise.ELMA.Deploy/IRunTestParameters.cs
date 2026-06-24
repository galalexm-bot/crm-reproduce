using System.Threading;

namespace EleWise.ELMA.Deploy;

public interface IRunTestParameters
{
	string ActivationKey { get; }

	CancellationToken CancellationToken { get; }
}
