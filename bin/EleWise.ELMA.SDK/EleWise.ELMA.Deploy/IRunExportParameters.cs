using System.Collections.Generic;
using System.Threading;

namespace EleWise.ELMA.Deploy;

public interface IRunExportParameters
{
	List<DeployLogMessage> LogMessages { get; }

	long SignedUserId { get; }

	CancellationToken CancellationToken { get; }
}
