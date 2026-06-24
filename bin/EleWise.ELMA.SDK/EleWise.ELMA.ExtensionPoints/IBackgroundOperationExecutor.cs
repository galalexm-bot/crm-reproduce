using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.BackgroundOperations;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IBackgroundOperationExecutor
{
	bool CanExecute(IBackgroundOperation executionInfo);

	string GetDescription(IBackgroundOperation executionInfo);

	Task<object> RunTask(IBackgroundOperation executionInfo, CancellationToken token);
}
