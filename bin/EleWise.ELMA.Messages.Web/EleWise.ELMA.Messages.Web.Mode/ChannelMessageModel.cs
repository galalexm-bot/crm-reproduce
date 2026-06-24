using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using EleWise.ELMA.BPM.Web.Common.Services;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Services;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.Web.Models;

public class ChannelMessageModel : MessageViewInfo<IChannelMessage>
{
	private IInformationChannel _channel;

	private readonly Lazy<bool> anyAttachment;

	private readonly Lazy<bool> anyAttachmentWithComments;

	private readonly Lazy<long> countAttachment;

	private readonly Lazy<bool> anyFile;

	private readonly Lazy<ListSortDirection> sortDirection;

	private bool? isFavorite;

	public IInformationChannel Channel => _channel;

	public long? ChannelId
	{
		get
		{
			return (_channel != null) ? _channel.Id : 0;
		}
		set
		{
			if (value.HasValue && (_channel == null || _channel.Id != value.Value))
			{
				_channel = InformationChannelManager.Instance.Load(value.Value);
			}
		}
	}

	public bool IsAssign { get; set; }

	public override bool AllowComment
	{
		get
		{
			if (alowComment.HasValue)
			{
				return alowComment.Value;
			}
			alowComment = ChannelMessageManager.Instance.HasComment(base.Message);
			return alowComment.Value;
		}
	}

	public override bool AllowEdit
	{
		get
		{
			if (alowEdit.HasValue)
			{
				return alowEdit.Value;
			}
			alowEdit = ChannelMessageManager.Instance.HasEdit(base.Message);
			return alowEdit.Value;
		}
	}

	public override bool FullAccess
	{
		get
		{
			if (fullAccess.HasValue)
			{
				return fullAccess.Value;
			}
			fullAccess = ChannelMessageManager.Instance.HasFullAccess(base.Message);
			return fullAccess.Value;
		}
	}

	public bool HasAttachments => anyAttachment.Value;

	public bool HasAttachmentsWithComments => anyAttachmentWithComments.Value;

	public long CountAttachments => countAttachment.Value;

	public bool AnyFile => anyFile.Value;

	public string TextPostComment { get; set; }

	public ListSortDirection SortDirection => sortDirection.Value;

	public ChannelMessageModel()
	{
		countAttachment = new Lazy<long>(() => Locator.GetServiceNotNull<ICheckAnyAttachmentService>().GetCountAttachments(base.Message.TypeUid, base.Message));
		anyAttachment = new Lazy<bool>(() => Locator.GetServiceNotNull<ICheckAnyAttachmentService>().CheckAnyAttachments(base.Message.TypeUid, base.Message));
		anyAttachmentWithComments = new Lazy<bool>(() => anyAttachment.Value || ((IEnumerable<IChannelMessage>)base.Message.Messages).Any((IChannelMessage c) => ((IEnumerable<IAttachment>)c.Attachments).Any()));
		anyFile = new Lazy<bool>(() => Locator.GetServiceNotNull<ICheckAnyAttachmentService>().CheckAnyFile(base.Message.TypeUid, base.Message));
		sortDirection = new Lazy<ListSortDirection>(() => Locator.GetServiceNotNull<IHistoryOrder>().GetOrderType(new HistoryIdParams
		{
			Id = base.Message.Id.ToString(),
			TypeUid = base.Message.TypeUid
		}));
	}

	public bool IsFavorite()
	{
		if (isFavorite.HasValue)
		{
			return isFavorite.Value;
		}
		isFavorite = FeedManager.Instance.IsFavorite(InterfaceActivator.UID<IChannelMessage>(), base.Message.Id);
		return isFavorite.Value;
	}
}
