using System.Collections.Generic;
using System.Threading;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy;

public class RunExportParameters : IRunExportParameters
{
	public List<DeployLogMessage> LogMessages { get; }

	public long SignedUserId { get; }

	public CancellationToken CancellationToken { get; }

	public RunExportParameters(long? signedUserId = null, List<DeployLogMessage> logMessages = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		SignedUserId = signedUserId ?? 0;
		LogMessages = logMessages ?? new List<DeployLogMessage>();
		CancellationToken = cancellationToken;
	}
}
