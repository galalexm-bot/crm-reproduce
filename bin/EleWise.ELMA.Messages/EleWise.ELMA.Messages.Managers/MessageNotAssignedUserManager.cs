using System;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate.Criterion;

namespace EleWise.ELMA.Messages.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class MessageNotAssignedUserManager : EntityManager<IMessageNotAssignedUser, long>
{
	private readonly TimeSpan messageNotAssignedRecipientsTimeout = TimeSpan.FromDays(2.0);

	private const string RootMessagePrefix = "MessageNotAssignedUserManager_RootMessage_";

	private const string MessageNotAssignedRecipientsKeyPrefix = "MessageNotAssignedRecipients_";

	internal const string MessageNotAssignedRecipientsTimestampKeyPrefix = "MessageNotAssignedRecipientsTimestamp_";

	public new static MessageNotAssignedUserManager Instance => Locator.GetServiceNotNull<MessageNotAssignedUserManager>();

	public IComplexCacheService ComplexCacheService { get; set; }

	public new IMemoryCacheService MemoryCacheService { get; set; }

	public bool IsAssignToMessage(long сhannelMessageId, EleWise.ELMA.Security.Models.IUser user = null)
	{
		if (user == null)
		{
			user = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		}
		string key = "MessageNotAssignedUserManager_RootMessage_" + сhannelMessageId;
		if (!MemoryCacheService.TryGetValue<long>(key, out var rootChannelMessageId))
		{
			rootChannelMessageId = сhannelMessageId;
			IChannelMessage сhannelMessage = null;
			Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(delegate
			{
				сhannelMessage = ChannelMessageManager.Instance.LoadOrNull(сhannelMessageId);
			});
			if (сhannelMessage != null)
			{
				while (сhannelMessage.Parent != null)
				{
					сhannelMessage = сhannelMessage.Parent;
				}
				rootChannelMessageId = сhannelMessage.Id;
			}
			MemoryCacheService.Insert(key, rootChannelMessageId, messageNotAssignedRecipientsTimeout);
		}
		return !ComplexCacheService.GetOrAdd("MessageNotAssignedRecipients_" + rootChannelMessageId, "MessageNotAssignedRecipientsTimestamp_" + rootChannelMessageId, () => CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("ChannelMessage.Id", (object)rootChannelMessageId)).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property("Recipient.Id") }).List<long>(), messageNotAssignedRecipientsTimeout).Contains(user.Id);
	}

	[Transaction]
	public virtual void AssignedAction(long сhannelMessageId)
	{
		bool num = IsAssignToMessage(сhannelMessageId);
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		IChannelMessage channelMessage = ChannelMessageManager.Instance.Load(сhannelMessageId);
		if (!num)
		{
			IMessageNotAssignedUserFilter messageNotAssignedUserFilter = InterfaceActivator.Create<IMessageNotAssignedUserFilter>();
			messageNotAssignedUserFilter.Recipient = currentUser;
			messageNotAssignedUserFilter.ChannelMessage = channelMessage;
			FetchOptions all = FetchOptions.All;
			{
				foreach (IMessageNotAssignedUser item in AbstractNHEntityManager<IMessageNotAssignedUser, long>.Instance.Find(messageNotAssignedUserFilter, all))
				{
					AbstractNHEntityManager<IMessageNotAssignedUser, long>.Instance.Delete(item);
				}
				return;
			}
		}
		InstanceOf<IMessageNotAssignedUser> instanceOf = new InstanceOf<IMessageNotAssignedUser>();
		instanceOf.New.ChannelMessage = channelMessage;
		instanceOf.New.Recipient = currentUser;
		IMessageNotAssignedUser @new = instanceOf.New;
		AbstractNHEntityManager<IMessageNotAssignedUser, long>.Instance.Save(@new);
	}
}
