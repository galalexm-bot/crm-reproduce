using System.Collections.Generic;
using System.Threading;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy;

public sealed class RunImportParameters : IRunImportParameters
{
	public List<DeployLogMessage> LogMessages { get; }

	public List<DeploySystemMessage> SystemMessages { get; }

	public long SignedUserId { get; }

	public CancellationToken CancellationToken { get; }

	public RunImportParameters(long? signedUserId = null, List<DeployLogMessage> logMessages = null, List<DeploySystemMessage> systemMessages = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		SignedUserId = signedUserId ?? 0;
		LogMessages = logMessages ?? new List<DeployLogMessage>();
		SystemMessages = systemMessages ?? new List<DeploySystemMessage>();
		CancellationToken = cancellationToken;
	}
}
