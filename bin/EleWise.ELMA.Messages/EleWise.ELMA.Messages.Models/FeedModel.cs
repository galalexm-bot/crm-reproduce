using System;
using System.Collections.Generic;
using System.ComponentModel;
using EleWise.ELMA.Common.Services;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Messages.Enums;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.Models;

public sealed class FeedModel : ICloneable
{
	private FeedModel parent;

	private readonly Lazy<ListSortDirection> sortDirection;

	private readonly SortedSet<FeedModel> messages;

	public long Id { get; set; }

	public string Subject { get; set; }

	public string Text { get; set; }

	public string TextHtml { get; set; }

	public Guid ActionObjectUid { get; set; }

	public Guid ActionUid { get; set; }

	public long ActionObjectId { get; set; }

	public DateTime CreationDate { get; set; }

	public DateTime ChangeDate { get; set; }

	public IUser CreationAuthor { get; set; }

	internal long CreationAuthorId { get; set; }

	public long? ParentObjectId { get; set; }

	public Guid? ParentObjectUid { get; set; }

	public int ChildCount { get; set; }

	public bool IsRead { get; set; }

	public DateTime? ReadDate { get; set; }

	public bool HasUnreadChild { get; set; }

	public int UnreadCount { get; set; }

	[DefaultValue(FeedPriority.Normal)]
	public FeedPriority Priority { get; set; }

	public string ChangeDateHash { get; set; }

	public FeedModel Parent
	{
		get
		{
			return parent;
		}
		set
		{
			if (parent != value)
			{
				RemoveParent();
				SetParent(value);
			}
		}
	}

	public ISet<FeedModel> Messages => messages;

	public ListSortDirection SortDirection => sortDirection.Value;

	public bool IsParent { get; set; }

	public FeedMessageRecipientList ObjectRecipients { get; set; }

	public FeedMessageAttachmentList MessageAttachments { get; set; }

	public FeedMessageObjectList MessageObjects { get; set; }

	[StringRangeLength(0, "2000")]
	public string Url { get; set; }

	public bool IsSingle { get; set; }

	public FeedModel()
	{
		sortDirection = new Lazy<ListSortDirection>(() => Locator.GetServiceNotNull<IHistoryOrder>().GetOrderType(new HistoryIdParams
		{
			TypeUid = ActionObjectUid,
			Id = ActionObjectId.ToString()
		}));
		messages = new SortedSet<FeedModel>(new FunctorComparer<FeedModel>(ChangeDateHashComparison));
		MessageObjects = new FeedMessageObjectList(new List<MessageObject>());
		MessageAttachments = new FeedMessageAttachmentList(new List<MessageAttachment>());
		ObjectRecipients = new FeedMessageRecipientList(new List<MessageRecipient>());
	}

	private void SetParent(FeedModel parentMessage)
	{
		if (parentMessage == null)
		{
			parent = null;
			return;
		}
		parent = parentMessage;
		if (!parent.Messages.Contains(this))
		{
			parent.Messages.Add(this);
		}
	}

	private void RemoveParent()
	{
		if (parent != null)
		{
			if (parent.Messages.Contains(this))
			{
				parent.Messages.Remove(this);
			}
			parent = null;
		}
	}

	private int ChangeDateHashComparison(FeedModel model, FeedModel feedModel)
	{
		if (model == null && feedModel == null)
		{
			return 0;
		}
		if (model == feedModel)
		{
			return 0;
		}
		if (model == null)
		{
			return -1;
		}
		if (feedModel == null)
		{
			return 1;
		}
		int num = string.Compare(model.ChangeDateHash, feedModel.ChangeDateHash, StringComparison.Ordinal);
		if (SortDirection == ListSortDirection.Descending)
		{
			num *= -1;
		}
		return num;
	}

	object ICloneable.Clone()
	{
		return Clone();
	}

	public FeedModel Clone()
	{
		FeedModel feedModel = new FeedModel();
		CopyTo(feedModel);
		return feedModel;
	}

	public void CopyTo(FeedModel model)
	{
		model.Id = Id;
		model.ActionObjectId = ActionObjectId;
		model.ActionObjectUid = ActionObjectUid;
		model.ActionUid = ActionUid;
		model.ChangeDate = ChangeDate;
		model.ChangeDateHash = ChangeDateHash;
		model.ChildCount = ChildCount;
		model.CreationAuthor = CreationAuthor;
		model.CreationDate = CreationDate;
		model.HasUnreadChild = HasUnreadChild;
		model.IsParent = IsParent;
		model.IsRead = IsRead;
		model.MessageAttachments = ClassSerializationHelper.CloneObject(MessageAttachments);
		model.MessageObjects = ClassSerializationHelper.CloneObject(MessageObjects);
		model.ObjectRecipients = ClassSerializationHelper.CloneObject(ObjectRecipients);
		model.ParentObjectId = ParentObjectId;
		model.ParentObjectUid = ParentObjectUid;
		model.Priority = Priority;
		model.Subject = Subject;
		model.Text = Text;
		model.TextHtml = TextHtml;
		model.UnreadCount = UnreadCount;
		model.Url = Url;
		model.Messages.AddSequense(Messages);
		if (Parent != null)
		{
			model.Parent = Parent.Clone();
		}
	}
}
