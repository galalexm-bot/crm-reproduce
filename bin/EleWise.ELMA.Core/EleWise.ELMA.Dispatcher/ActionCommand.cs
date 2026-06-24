using EleWise.ELMA.Core.Diagnostics;

namespace EleWise.ELMA.Dispatcher;

public sealed class ActionCommand
{
	private readonly string _003CActionTypeId_003Ek__BackingField;

	private readonly string _003CActionId_003Ek__BackingField;

	private readonly object[] _003CArgs_003Ek__BackingField;

	public string ActionTypeId => _003CActionTypeId_003Ek__BackingField;

	public string ActionId => _003CActionId_003Ek__BackingField;

	public object[] Args => _003CArgs_003Ek__BackingField;

	public ActionCommand(string actionTypeId, string actionId, params object[] args)
	{
		Contract.ArgumentNotNull(actionTypeId, "actionTypeId");
		_003CActionTypeId_003Ek__BackingField = actionTypeId;
		_003CActionId_003Ek__BackingField = actionId;
		_003CArgs_003Ek__BackingField = args;
	}
}
