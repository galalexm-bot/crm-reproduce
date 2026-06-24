using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Files;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Messages.Enums;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using EleWise.ELMA.Web.Hubs.Services;

namespace EleWise.ELMA.Messages.Channels;

[Component]
internal class InternalMailChannel : GroupingMessageChannel, IThreadPoolContainer
{
	private const string MessageChannelInternalMailEnabled = "MessageChannel.InternalMail.Enabled";

	public static readonly FeedPriority DefaultFeedPriority = FeedPriority.Normal;

	private readonly ThreadSubPool pool;

	private static readonly Guid AttachmentTypeUid = BinaryFileDescriptor.UID;

	public IAgentHubService AgentHubService { get; set; }

	public ILogger Logger { get; set; }

	public ISecurityService SecurityService => Locator.GetServiceNotNull<ISecurityService>();

	public IEnumerable<IFeedMessageUpdateProvider> FeedMessageUpdateProviders { get; set; }

	public IFeatureFlagService FeatureFlagService { get; set; }

	public override Guid Uid => InternalMailChannelDescriptor.UID;

	public override string Name => InternalMailChannelDescriptor.Name;

	public override string DisplayName => InternalMailChannelDescriptor.DisplayName;

	IThreadPool IThreadPoolContainer.Pool => pool;

	public override bool Enabled => FeatureFlagService.Enabled("MessageChannel.InternalMail.Enabled", defaultEnabled: true);

	internal InternalMailChannel()
	{
		pool = new ThreadSubPool("InternalMailChannel.PoolSize", 5);
	}

	public override void Send([NotNull] IMessage message)
	{
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		Send(message, new List<EleWise.ELMA.Security.Models.IUser> { (EleWise.ELMA.Security.Models.IUser)message.Recipient });
	}

	public override void Send([NotNull] IMessage message, [NotNull] IEnumerable<EleWise.ELMA.Security.IUser> recipients)
	{
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		if (recipients == null)
		{
			throw new ArgumentNullException("recipients");
		}
		EleWise.ELMA.Security.IUser[] recUsers = (recipients as EleWise.ELMA.Security.IUser[]) ?? recipients.ToArray();
		EleWise.ELMA.Security.Models.IUser creationAuthor = ((EleWise.ELMA.Security.Models.IUser)message.Author) ?? UserManager.Instance.Load(SecurityConstants.SystemUserUid);
		if (recUsers.Length == 0)
		{
			return;
		}
		SecurityService.RunWithElevatedPrivilegiesAndWithDeleted(delegate
		{
			SecurityService.RunByUser(creationAuthor, delegate
			{
				DateTime now = DateTime.Now;
				FeedMessageAttachmentList messageAttachmentList = GetMessageAttachmentList(message);
				FeedModel feedMessage = new FeedModel
				{
					ActionObjectId = ((message.ObjectId != null) ? long.Parse(message.ObjectId) : 0),
					ActionObjectUid = (message.ObjectUid.HasValue ? message.ObjectUid.Value : Guid.Empty),
					ActionUid = (message.ActionUid.HasValue ? message.ActionUid.Value : Guid.Empty),
					ChangeDate = now,
					CreationAuthor = creationAuthor,
					CreationDate = now,
					Subject = message.Subject,
					Priority = (FeedPriority)message.Priority,
					Text = message.ShortMessageText,
					TextHtml = message.ShortMessageHtml,
					MessageAttachments = messageAttachmentList,
					Url = message.URL
				};
				IFeedMessageUpdater[] updaters = (from p in FeedMessageUpdateProviders
					where p.CanUpdateMessage(feedMessage.ActionUid, feedMessage.ActionObjectUid, feedMessage.ActionObjectId)
					select p.GetMessageUpdater(feedMessage.ActionUid, feedMessage.ActionObjectUid, feedMessage.ActionObjectId)).ToArray();
				if (updaters.Length == 0)
				{
					Logger.Info(SR.T("Невозможно сопоставить обработчик для элемента ленты сообщений: {0}", feedMessage.Id));
					feedMessage.Parent = null;
					feedMessage.ParentObjectId = feedMessage.ActionObjectId;
					feedMessage.ParentObjectUid = feedMessage.ActionObjectUid;
					feedMessage.IsParent = true;
				}
				else
				{
					updaters = updaters.Where((IFeedMessageUpdater u) => u.UpdateMessage(feedMessage)).ToArray();
				}
				FeedModel feedModel = feedMessage.Clone();
				ReplaceTextHtml(feedModel);
				if (feedModel.Parent == null)
				{
					recUsers = recUsers.Where((EleWise.ELMA.Security.IUser r) => IsCanMessage(message, (EleWise.ELMA.Security.Models.IUser)r)).ToArray();
					if (recUsers.Length == 0)
					{
						return;
					}
				}
				FeedManager.Instance.SaveMessage(feedModel, recUsers.Cast<EleWise.ELMA.Security.Models.IUser>().Select(delegate(EleWise.ELMA.Security.Models.IUser m)
				{
					FeedRecipientInfo result = default(FeedRecipientInfo);
					result.User = m;
					result.Priority = (updaters.Any() ? updaters.Select((IFeedMessageUpdater u) => u.GetPriorityForRecipient(feedMessage, m)).Max() : DefaultFeedPriority);
					return result;
				}).ToArray(), !message.SendToAuthor, checkParent: true);
				AgentHubService.Send(recUsers, "FeedMessage", "");
			});
		});
	}

	internal static void ReplaceTextHtml(FeedModel feedModel)
	{
		if (feedModel != null)
		{
			string shortMessageHtml = feedModel.TextHtml.ValueOrDefaultWhiteSpace(HttpUtility.HtmlEncode(feedModel.Text).Nl2Br());
			feedModel.TextHtml = ParseHtml(shortMessageHtml);
			if (feedModel.Parent != null)
			{
				string shortMessageHtml2 = feedModel.Parent.TextHtml.ValueOrDefaultWhiteSpace(HttpUtility.HtmlEncode(feedModel.Parent.Text).Nl2Br());
				feedModel.Parent.TextHtml = ParseHtml(shortMessageHtml2);
			}
		}
	}

	private static string ParseHtml(string shortMessageHtml)
	{
		if (string.IsNullOrWhiteSpace(shortMessageHtml))
		{
			return null;
		}
		return shortMessageHtml.PrepareHtmlHref();
	}

	private static bool IsCanMessage([NotNull] IMessage message, EleWise.ELMA.Security.Models.IUser recipient)
	{
		if (!(message.Author is EleWise.ELMA.Security.Models.IUser user) || recipient.Id != user.Id || message.SendToAuthor)
		{
			return true;
		}
		if (message.ObjectUid == InterfaceActivator.UID<IChannelMessage>())
		{
			return true;
		}
		return false;
	}

	private static FeedMessageAttachmentList GetMessageAttachmentList(IMessage message)
	{
		MessageAttachment[] array = message.MessageAttachments ?? new MessageAttachment[0];
		if (message.AttachmentIds != null && message.AttachmentIds.Length != 0)
		{
			array = array.Union(DataAccessManager.FileManager.LoadFiles(message.AttachmentIds).Select(delegate(BinaryFile a)
			{
				MessageAttachment result = default(MessageAttachment);
				result.Id = a.Id;
				result.Name = a.Name;
				result.TypeUid = AttachmentTypeUid;
				return result;
			})).ToArray();
		}
		return new FeedMessageAttachmentList(array);
	}
}
