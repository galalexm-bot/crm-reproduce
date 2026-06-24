using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Messages.Enums;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate.Transform;

namespace EleWise.ELMA.Messages.Components.Feed;

[Serializable]
internal class FeedResultTransformer : IResultTransformer
{
	private readonly FeedResultGroupMode mode;

	private readonly bool sort = true;

	private readonly List<FeedModel> parents = new List<FeedModel>();

	private readonly List<FeedModel> messages = new List<FeedModel>();

	public FeedResultTransformer(bool sort, FeedResultGroupMode mode = FeedResultGroupMode.Parents)
	{
		this.mode = mode;
		this.sort = sort;
	}

	public FeedResultTransformer(FeedResultGroupMode mode = FeedResultGroupMode.Parents)
	{
		this.mode = mode;
		sort = true;
	}

	public IList TransformList(IList collection)
	{
		List<FeedModel> list = collection.Cast<FeedModel>().ToList();
		if (list.Count == 0)
		{
			return new List<FeedModel>();
		}
		long[] idArray = list.Select((FeedModel m) => m.CreationAuthorId).Distinct().ToArray();
		ICollection<IUser> authors = UserManager.Instance.FindByIdArray(idArray);
		list.ForEach(delegate(FeedModel m)
		{
			m.CreationAuthor = authors.First((IUser a) => a.Id == m.CreationAuthorId);
		});
		foreach (FeedModel item in messages.OrderBy((FeedModel m) => m.ChangeDateHash))
		{
			FeedModel feedModel = item;
			item.Parent = parents.FirstOrDefault(delegate(FeedModel m)
			{
				if (m.ParentObjectId == feedModel.ParentObjectId)
				{
					Guid? parentObjectUid = m.ParentObjectUid;
					Guid? parentObjectUid2 = feedModel.ParentObjectUid;
					if (parentObjectUid.HasValue != parentObjectUid2.HasValue)
					{
						return false;
					}
					if (!parentObjectUid.HasValue)
					{
						return true;
					}
					return parentObjectUid.GetValueOrDefault() == parentObjectUid2.GetValueOrDefault();
				}
				return false;
			});
		}
		IEnumerable<FeedModel> source;
		if (mode == FeedResultGroupMode.Parents)
		{
			source = (from f in list
				select (!f.IsParent) ? f.Parent : f into m
				where m != null
				select m).Distinct();
			if (sort)
			{
				source = source.OrderByDescending((FeedModel m) => m.ChangeDateHash);
			}
		}
		else
		{
			source = (from m in list.SelectMany((FeedModel f) => (!f.IsParent) ? new List<FeedModel> { f } : f.Messages.ToList())
				where m != null
				select m).Distinct();
			if (sort)
			{
				source = source.OrderByDescending((FeedModel m) => m.ChangeDateHash);
			}
		}
		return source.ToList();
	}

	public object TransformTuple(object[] tuple, string[] aliases)
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		Func<object, FeedPriority> converter = (object o) => (o != null) ? ((FeedPriority)Convert.ToInt32(o)) : FeedPriority.Normal;
		TransformerObjectReader transformerObjectReader = new TransformerObjectReader(tuple, aliases);
		FeedModel feedModel = new FeedModel
		{
			Id = transformerObjectReader.Value("Id", 0L, Convert.ToInt64),
			Subject = transformerObjectReader.Value<string>("Subject", null),
			Text = transformerObjectReader.Value<string>("Text", null),
			TextHtml = transformerObjectReader.Value<string>("TextHtml", null),
			ActionObjectUid = transformerObjectReader.Value("ActionObjectUid", Guid.Empty, serviceNotNull.Dialect.GetGuid),
			ActionUid = transformerObjectReader.Value("ActionUid", Guid.Empty, serviceNotNull.Dialect.GetGuid),
			ActionObjectId = transformerObjectReader.Value("ActionObjectId", 0L, Convert.ToInt64),
			CreationDate = transformerObjectReader.Value("CreationDate", DateTime.MinValue),
			ChangeDate = transformerObjectReader.Value("ChangeDate", DateTime.MinValue),
			CreationAuthorId = transformerObjectReader.Value("CreationAuthor", 0L, Convert.ToInt64),
			ChildCount = transformerObjectReader.Value("ChildCount", 0, Convert.ToInt32),
			IsRead = transformerObjectReader.Value("IsRead", defaultValue: false, Convert.ToBoolean),
			ReadDate = transformerObjectReader.Value<DateTime?>("ReadDate", null),
			HasUnreadChild = transformerObjectReader.Value("HasUnreadChild", defaultValue: true, Convert.ToBoolean),
			ParentObjectId = transformerObjectReader.Value("ParentObjectId", 0L, Convert.ToInt64),
			ParentObjectUid = transformerObjectReader.Value("ParentObjectUid", Guid.Empty, serviceNotNull.Dialect.GetGuid),
			Priority = transformerObjectReader.Value("Priority", FeedPriority.Normal, converter),
			UnreadCount = transformerObjectReader.Value("UnreadCount", 0, Convert.ToInt32),
			ChangeDateHash = transformerObjectReader.Value<string>("ChangeDateHash", null),
			IsParent = transformerObjectReader.Value("IsParent", defaultValue: false, Convert.ToBoolean),
			MessageAttachments = new FeedMessageAttachmentList(transformerObjectReader.Value("MessageAttachments", Array.Empty<byte>())),
			ObjectRecipients = new FeedMessageRecipientList(transformerObjectReader.Value("ObjectRecipients", Array.Empty<byte>())),
			MessageObjects = new FeedMessageObjectList(transformerObjectReader.Value("MessageObjects", Array.Empty<byte>())),
			Url = transformerObjectReader.Value<string>("Url", null)
		};
		if (feedModel.IsParent)
		{
			parents.Add(feedModel);
		}
		else
		{
			messages.Add(feedModel);
		}
		return feedModel;
	}
}
