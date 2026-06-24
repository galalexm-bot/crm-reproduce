using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.Components.Feed;

[Component(Order = 500)]
public class FeedCommentChannelExtension : FeedCommentExtensionBase
{
	private IEnumerable<ICommentAttachmentConvertor> commentAttachmentConvertors { get; set; }

	[NotNull]
	public ISecurityService SecurityService => Locator.GetServiceNotNull<ISecurityService>();

	public FeedCommentChannelExtension(IEnumerable<ICommentAttachmentConvertor> commentAttachmentConvertors)
	{
		this.commentAttachmentConvertors = commentAttachmentConvertors;
	}

	protected List<Guid> CommentSupportedObject()
	{
		return new List<Guid> { InterfaceActivator.UID<IChannelMessage>() };
	}

	public override bool CommentIsSupported(Guid objectUid)
	{
		return CommentSupportedObject().Contains(objectUid);
	}

	public override bool IsCommentAction(Guid objectUid, Guid actionUid)
	{
		return actionUid == DefaultEntityActions.CreateGuid;
	}

	public override bool CanAddCommentAttachment(Guid objectUid)
	{
		return true;
	}

	public override void CanCreateComment(List<CanCreateCommentItemMessage> objects)
	{
		base.CanCreateComment(objects);
		long num = (long)Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser().GetId();
		Guid channelTypeUid = InterfaceActivator.UID<IInformationChannel>();
		Guid userTypeUid = InterfaceActivator.UID<EleWise.ELMA.Security.Models.IUser>();
		Dictionary<long, IInformationChannel> channelsCache = new Dictionary<long, IInformationChannel>();
		foreach (CanCreateCommentItemMessage item in from o in objects
			where CommentIsSupported(o.Message.ParentObjectUid.Value)
			where o.Message.ObjectRecipients.Any((MessageRecipient r) => r.TypeUid == channelTypeUid)
			select o)
		{
			IEnumerable<IInformationChannel> source = from c in item.Message.ObjectRecipients.Where((MessageRecipient r) => r.TypeUid == channelTypeUid).Select(delegate(MessageRecipient r)
				{
					long channelId = Convert.ToInt64(r.Id);
					IInformationChannel channel = null;
					if (channelsCache.Keys.Contains(channelId))
					{
						channel = channelsCache[channelId];
					}
					else
					{
						SecurityService.RunWithElevatedPrivilegies(delegate
						{
							channel = InformationChannelManager.Instance.LoadOrNull(channelId);
						});
						channelsCache.Add(channelId, channel);
					}
					return channel;
				})
				where c != null
				select c;
			IEnumerable<long> source2 = from r in item.Message.ObjectRecipients
				where r.TypeUid == userTypeUid
				select Convert.ToInt64(r.Id);
			item.CanCreateComment = item.CanCreateComment && (source.Any((IInformationChannel c) => c.IsCommentable && c.IsActive && !c.IsArchive) || item.Message.CreationAuthor.Id == num || source2.Contains(num));
		}
	}

	public override void CanCreateComment(Guid objectUid, Dictionary<long, bool> items)
	{
		if (items == null || items.Count == 0 || !CommentIsSupported(objectUid))
		{
			return;
		}
		EleWise.ELMA.Security.IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser();
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		string text = string.Join(", ", items.Keys);
		string sql = string.Format("\r\nselect distinct bm.{9} {27}\r\nfrom {0}\r\nleft join {1} on r.{10} = bm.{9}\r\nleft join {2} on chm.{10} = bm.{9}\r\nleft join {3} on ch.{9} = chm.{11}\r\nleft join {4} on p.{12} = ch.{9}\r\nleft join {5} on p.{13} = oiu.{14}\r\nleft join {6} on p.{15} = oi.{9}\r\nleft join {7} on usc.{16} = p.{17}\r\nleft join {8} on (p.{18} = usc2.{19} and p.{20} = usc2.{21})\r\nwhere\r\n\tbm.{22} = {28}TypeUid\r\n\tand bm.{9} in ({29})\r\n\tand (\r\n\t\tbm.{23} = {30}\r\n\t\tor r.{24} = {30}\r\n\t\tor (\r\n\t\t\tnot ch.{9} is null\r\n\t\t\tand ch.{25} = 1\r\n\t\t\tand (ch.{26} is null or ch.{26} = 0)\r\n\t\t\tand (\r\n\t\t\t\tp.{17} = {30}\r\n\t\t\t\tor (p.{17} <> {30} and p.{17} <> usc.{24} and (usc.{24} = {30} or usc2.{24} = {30}))\r\n\t\t\t\tor (not p.{20} is null and (usc.{24} = {30} or usc2.{24} = {30}))\r\n\t\t\t\tor (oiu.{24} = {30} or oi.{24} = {30})\r\n\t\t\t)\r\n\t\t)\r\n\t)\r\n", serviceNotNull.NoLockTableExpression("BaseMessage", "bm"), serviceNotNull.NoLockTableExpression("M_BaseMessage_Recipients", "r"), serviceNotNull.NoLockTableExpression("M_ChannelMessage_Channels", "chm"), serviceNotNull.NoLockTableExpression("InformationChannel", "ch"), serviceNotNull.NoLockTableExpression("InformationChannelPermission", "p"), serviceNotNull.NoLockTableExpression("OrganizationItemUsers", "oiu"), serviceNotNull.NoLockTableExpression("OrganizationItem", "oi"), serviceNotNull.NoLockTableExpression("UserSecuritySetCache", "usc"), serviceNotNull.NoLockTableExpression("UserSecuritySetCache", "usc2"), serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded("MessageId"), serviceNotNull.Dialect.QuoteIfNeeded("ChannelId"), serviceNotNull.Dialect.QuoteIfNeeded("Channel"), serviceNotNull.Dialect.QuoteIfNeeded("OrganizationItem"), serviceNotNull.Dialect.QuoteIfNeeded("OrganizationItemId"), serviceNotNull.Dialect.QuoteIfNeeded("OrganizationItemPosition"), serviceNotNull.Dialect.QuoteIfNeeded("SubordinateUserId"), serviceNotNull.Dialect.QuoteIfNeeded("User"), serviceNotNull.Dialect.QuoteIfNeeded("UserSecuritySetCacheId"), serviceNotNull.Dialect.QuoteIfNeeded("SetId"), serviceNotNull.Dialect.QuoteIfNeeded("Group"), serviceNotNull.Dialect.QuoteIfNeeded("GroupId"), serviceNotNull.Dialect.QuoteIfNeeded("TypeUid"), serviceNotNull.Dialect.QuoteIfNeeded("CreationAuthor"), serviceNotNull.Dialect.QuoteIfNeeded("UserId"), serviceNotNull.Dialect.QuoteIfNeeded("IsCommentable"), serviceNotNull.Dialect.QuoteIfNeeded("IsArchive"), serviceNotNull.Dialect.QuoteIfNeeded("MessageObjId"), serviceNotNull.ParameterSeparator, text, currentUser.GetId());
		using IDataReader dataReader = serviceNotNull.ExecuteQuery(sql, new Dictionary<string, object> { 
		{
			"TypeUid",
			InterfaceActivator.UID<IChannelMessage>()
		} });
		while (dataReader.Read())
		{
			if (!(dataReader["MessageObjId"] is DBNull))
			{
				long key = Convert.ToInt64(dataReader["MessageObjId"]);
				if (items.ContainsKey(key))
				{
					items[key] = true;
				}
			}
		}
	}

	public override Guid CreateComment(Guid objectUid, long objectId, string text, MessageAttachment[] messageAttachments)
	{
		if (!CommentIsSupported(objectUid))
		{
			return Guid.Empty;
		}
		Dictionary<long, bool> dictionary = new Dictionary<long, bool> { { objectId, false } };
		CanCreateComment(objectUid, dictionary);
		if (!dictionary[objectId])
		{
			return Guid.Empty;
		}
		IChannelMessage channelMessage = AbstractNHEntityManager<IChannelMessage, long>.Instance.Load(Convert.ToInt64(objectId));
		IChannelMessage message = channelMessage.Parent ?? channelMessage;
		ICommentActionModel commentActionModel = InterfaceActivator.Create<ICommentActionModel>();
		commentActionModel.Comment = InterfaceActivator.Create<IComment>();
		commentActionModel.Comment.Text = text;
		foreach (IGrouping<Guid, MessageAttachment> group in from a in messageAttachments
			group a by a.TypeUid)
		{
			ICommentAttachmentConvertor commentAttachmentConvertor = commentAttachmentConvertors.FirstOrDefault((ICommentAttachmentConvertor c) => c.Supported(group.Key));
			if (commentAttachmentConvertor == null)
			{
				continue;
			}
			foreach (MessageAttachment item in group)
			{
				commentAttachmentConvertor.AddAttachmentToActionModel(commentActionModel, item.Id, item.TypeUid);
			}
		}
		ChannelMessageManager.Instance.AddComment(message, commentActionModel);
		return DefaultEntityActions.CreateGuid;
	}
}
