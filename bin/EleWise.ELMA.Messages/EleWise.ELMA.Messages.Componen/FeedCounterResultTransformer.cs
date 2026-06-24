using System;
using System.Collections;
using EleWise.ELMA.Messages.Models;
using NHibernate.Transform;

namespace EleWise.ELMA.Messages.Components.Feed;

[Serializable]
internal class FeedCounterResultTransformer : IResultTransformer
{
	public IList TransformList(IList collection)
	{
		return collection;
	}

	public object TransformTuple(object[] tuple, string[] aliases)
	{
		TransformerObjectReader transformerObjectReader = new TransformerObjectReader(tuple, aliases);
		return new FeedCounter
		{
			Count = transformerObjectReader.Value("Count", 0L, Convert.ToInt64),
			WithPriority = transformerObjectReader.Value("WithPriority", defaultValue: false, Convert.ToBoolean)
		};
	}
}
