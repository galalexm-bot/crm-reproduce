using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;

namespace EleWise.ELMA.Common.Components;

[Component]
internal class CommonModelHistoryFilter : EntityModelHistoryEventsFilterBase
{
	protected override Type[] ExcludeTypes => new Type[3]
	{
		typeof(IBlobStoreHolder),
		typeof(IEntityActionHistory),
		typeof(IEntityModelHistory)
	};
}
