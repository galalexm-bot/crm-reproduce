using System.Collections.Generic;
using System.Threading;

namespace EleWise.ELMA.Deploy;

public interface IRunImportParameters
{
	List<DeployLogMessage> LogMessages { get; }

	List<DeploySystemMessage> SystemMessages { get; }

	long SignedUserId { get; }

	CancellationToken CancellationToken { get; }
}
