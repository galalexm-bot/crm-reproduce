using System.Globalization;

namespace EleWise.ELMA.CAB;

internal static class StateChangedTopic
{
	private const string TOPIC_PREFIX = "topic://WorkitemStateChanged/{0}";

	internal static string BuildStateChangedTopicString(string stateName)
	{
		return string.Format(CultureInfo.InvariantCulture, "topic://WorkitemStateChanged/{0}", new object[1] { stateName });
	}
}
