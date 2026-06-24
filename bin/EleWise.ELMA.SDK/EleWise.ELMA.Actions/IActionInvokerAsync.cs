using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Actions;

public interface IActionInvokerAsync : IActionInvoker
{
	Task<object> InvokeActionAsync(ActionInvokeEventArgs e, CancellationToken cancellationToken);

	Task<ActionCheckResult> CheckActionAsync(ActionInvokeEventArgs e, CancellationToken cancellationToken);
}
