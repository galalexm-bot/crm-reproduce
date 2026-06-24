using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Services;

public interface IAutoDeployWithResultService
{
	IEnumerable<IDeployResult> RunAutoDeployWithResult(string autoDeployPath);
}
