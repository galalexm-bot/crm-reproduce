using System;
using System.Globalization;
using EleWise.ELMA.CAB.Events;

namespace EleWise.ELMA.CAB.Commands;

public class EventTopicCommand : Command
{
	private const string TopicNameFormat = "topic://EventTopicCommand/{0}";

	private PublicationScope scope = PublicationScope.Descendants;

	private WorkItem workItem;

	[ServiceDependency]
	public WorkItem WorkItem
	{
		set
		{
			workItem = value;
		}
	}

	public PublicationScope Scope
	{
		get
		{
			return scope;
		}
		set
		{
			scope = value;
		}
	}

	protected override void OnExecuteAction(object sender, EventArgs e)
	{
		base.OnExecuteAction(sender, e);
		workItem.EventTopics.Get(string.Format(CultureInfo.InstalledUICulture, "topic://EventTopicCommand/{0}", new object[1] { base.Name }))?.Fire(sender, e, workItem, scope);
	}
}
