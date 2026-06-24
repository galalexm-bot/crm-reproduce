using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using NHibernate.Transform;

namespace EleWise.ELMA.Messages.Components.Feed;

[Serializable]
internal class FeedMessageInfoTransformer : IResultTransformer
{
	public IList TransformList(IList collection)
	{
		return collection.Cast<FeedMessageInfoModel>().ToList();
	}

	public object TransformTuple(object[] tuple, string[] aliases)
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		TransformerObjectReader transformerObjectReader = new TransformerObjectReader(tuple, aliases);
		return new FeedMessageInfoModel
		{
			Id = transformerObjectReader.Value("Id", 0L, Convert.ToInt64),
			ActionObjectUid = transformerObjectReader.Value("ActionObjectUid", Guid.Empty, serviceNotNull.Dialect.GetGuid),
			ActionObjectId = transformerObjectReader.Value("ActionObjectId", 0L, Convert.ToInt64),
			ChangeDate = transformerObjectReader.Value("ChangeDate", DateTime.Now),
			Recipient = transformerObjectReader.Value("Recipient", 0L, Convert.ToInt64),
			Data = ClassSerializationHelper.DeserializeObjectByJson<List<WebData>>(Encoding.UTF8.GetString(transformerObjectReader.Value("Data", Array.Empty<byte>())))
		};
	}
}
