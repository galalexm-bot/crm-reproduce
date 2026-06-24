using System;
using System.Collections;
using System.Linq;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using NHibernate.Transform;

namespace EleWise.ELMA.Messages.Components.Feed;

[Serializable]
internal class FeedFavoriteResultTransformer : IResultTransformer
{
	public IList TransformList(IList collection)
	{
		return collection.Cast<FeedFavoriteModel>().ToList();
	}

	public object TransformTuple(object[] tuple, string[] aliases)
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		TransformerObjectReader transformerObjectReader = new TransformerObjectReader(tuple, aliases);
		return new FeedFavoriteModel
		{
			Id = transformerObjectReader.Value("Id", 0L, Convert.ToInt64),
			ActionObjectUid = transformerObjectReader.Value("ActionObjectUid", Guid.Empty, serviceNotNull.Dialect.GetGuid),
			ActionObjectId = transformerObjectReader.Value("ActionObjectId", 0L, Convert.ToInt64),
			ChangeDateHash = transformerObjectReader.Value<string>("ChangeDateHash", null),
			IsDelete = transformerObjectReader.Value("IsDelete", defaultValue: false, Convert.ToBoolean),
			Recipient = transformerObjectReader.Value("Recipient", 0L, Convert.ToInt64)
		};
	}
}
