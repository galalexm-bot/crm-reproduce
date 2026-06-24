using EleWise.ELMA.Events.Audit;

namespace EleWise.ELMA.Actions;

public interface IActionInvoker
{
	IAuditObject ActionObject { get; }

	IAuditAction ActionType { get; }

	ActionMethodMetadata MethodMetadata { get; }

	object InvokeAction(ActionInvokeEventArgs e);

	ActionCheckResult CheckAction(ActionInvokeEventArgs e);
}
