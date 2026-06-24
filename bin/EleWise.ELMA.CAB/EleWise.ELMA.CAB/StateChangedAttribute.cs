using EleWise.ELMA.CAB.Events;

namespace EleWise.ELMA.CAB;

public class StateChangedAttribute : EventSubscriptionAttribute
{
	public StateChangedAttribute(string topic, ThreadOption option)
		: base(StateChangedTopic.BuildStateChangedTopicString(topic))
	{
		base.Thread = option;
	}
}
