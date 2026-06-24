using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Web.ExtensionPoints;
using EleWise.ELMA.Messages.Web.Models;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.Web.Components;

public static class ChannelMessageHelper
{
	private static bool AllowCommentMessage(IChannelMessage message, EleWise.ELMA.Security.Models.IUser currentUser)
	{
		if (message.Channels == null || !((IEnumerable<IInformationChannel>)message.Channels).Any((IInformationChannel ch) => ch.IsCommentable && !ch.IsArchive && ch.IsActive))
		{
			return ((ICollection<EleWise.ELMA.Security.Models.IUser>)message.Recipients).Contains(currentUser);
		}
		return true;
	}

	private static List<EleWise.ELMA.Security.Models.IUser> GetRecipients(IChannelMessage message, EleWise.ELMA.Security.Models.IUser currentUser)
	{
		return ((IEnumerable<EleWise.ELMA.Security.Models.IUser>)message.Recipients).Where((EleWise.ELMA.Security.Models.IUser r) => r != currentUser).ToList();
	}

	internal static IEnumerable<InfoChannelMessageParent> GetParentsMessages(List<IBaseMessage> messages, EleWise.ELMA.Security.Models.IUser currentUser, ISecurityService securityService, int? maxCommentsCount = null)
	{
		Dictionary<long, List<InfoChannelMessageChild>> dictionary = new Dictionary<long, List<InfoChannelMessageChild>>();
		GroupMessages(messages, dictionary, currentUser, maxCommentsCount);
		List<InfoChannelMessageParent> list = new List<InfoChannelMessageParent>();
		foreach (long key in dictionary.Keys)
		{
			InfoChannelMessageParent blockFeed;
			if (dictionary[key].Exists((InfoChannelMessageChild m) => m.ObjectId == key))
			{
				InfoChannelMessageChild infoChannelMessageChild = dictionary[key].Find((InfoChannelMessageChild m) => m.ObjectId == key);
				dictionary[key].Remove(infoChannelMessageChild);
				blockFeed = InfoChannelMessageParent.CreateFromFeedMessage(infoChannelMessageChild);
				blockFeed.Messages = dictionary[key].Select(delegate(InfoChannelMessageChild ms)
				{
					ms.Parent = blockFeed;
					return ms;
				}).ToList();
			}
			else
			{
				IChannelMessage channelMessage = AbstractNHEntityManager<IChannelMessage, long>.Instance.Load(key);
				IChannelMessage channelMessage2 = channelMessage.Parent ?? channelMessage;
				blockFeed = new InfoChannelMessageParent
				{
					Messages = dictionary[key].Where((InfoChannelMessageChild ms) => ms.ObjectId != key).ToList(),
					AllowComment = AllowCommentMessage(channelMessage, currentUser),
					Recipients = GetRecipients(channelMessage, currentUser),
					Message = channelMessage,
					DiscussionObjectsOriginal = ((IEnumerable<IDiscussionObject>)channelMessage2.DiscussionObjects).ToList(),
					DiscussionObjects = (from o in ((IEnumerable<IDiscussionObject>)channelMessage2.DiscussionObjects).Select(delegate(IDiscussionObject o)
						{
							Type entityType = ModelHelper.GetEntityType(o.ObjectType);
							IEntityManager manager = ModelHelper.GetEntityManager(entityType);
							object obj = null;
							Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegiesAndWithDeleted(delegate
							{
								obj = manager.LoadOrNull(o.ObjectId);
							});
							return obj;
						})
						where o != null
						select o).ToList()
				};
				string text = "";
				foreach (IInformationChannel item in (IEnumerable<IInformationChannel>)channelMessage2.Channels)
				{
					if (!string.IsNullOrEmpty(text))
					{
						text += ", ";
					}
					text += item.ToString();
				}
				blockFeed.Subject = ((((ICollection<IInformationChannel>)channelMessage2.Channels).Count != 0) ? string.Format("{0} {1}. {2}", (((ICollection<IInformationChannel>)channelMessage2.Channels).Count == 1) ? SR.T("Сообщение в инфоканале") : SR.T("Сообщение в инфоканалах"), text, channelMessage2.Subject) : string.Format("{0}. {1}", SR.T("Сообщение"), channelMessage2.Subject));
				blockFeed.FullMessageText = channelMessage2.FullMessage;
				blockFeed.CreationAuthor = channelMessage2.CreationAuthor;
				blockFeed.CreationDate = channelMessage2.CreationDate;
				blockFeed.ObjectId = key;
				blockFeed.AllowDelete = true;
				blockFeed.URL = "/Messages/ChannelMessage/Info/" + channelMessage2.Id;
				if (blockFeed.Messages != null && blockFeed.Messages.Count == 1 && blockFeed.Messages[0].Id == -1)
				{
					blockFeed.Messages.Clear();
				}
			}
			if (blockFeed.Messages != null)
			{
				foreach (InfoChannelMessageChild message in blockFeed.Messages)
				{
					message.Parent = blockFeed;
				}
			}
			list.Add(blockFeed);
		}
		return list;
	}

	private static void GroupMessages(IEnumerable<IBaseMessage> messages, IDictionary<long, List<InfoChannelMessageChild>> feedsMessages, EleWise.ELMA.Security.Models.IUser currentUser, int? maxCommentsCount = null)
	{
		if (messages == null)
		{
			return;
		}
		FeedMessagesSettings feedMessagesSettings = BaseMessageManager.Instance.LoadSettings();
		ICommentActionHandler commentAction = Locator.GetService<ICommentActionHandler>();
		foreach (IChannelMessage message in messages)
		{
			long id = (message.Parent ?? message).Id;
			if (!feedsMessages.ContainsKey(id))
			{
				feedsMessages.Add(id, new List<InfoChannelMessageChild>());
			}
			InstanceOf<IChannelMessageFilter> instanceOf = new InstanceOf<IChannelMessageFilter>();
			instanceOf.New.Parent = message;
			IChannelMessageFilter @new = instanceOf.New;
			FetchOptions all = FetchOptions.All;
			all.SortExpression = "CreationDate";
			all.SortDirection = ListSortDirection.Descending;
			all.MaxResults = maxCommentsCount ?? (feedMessagesSettings.CommentsCount + 1);
			feedsMessages[id].AddRange(ChannelMessageManager.Instance.Find(@new, all).Select(delegate(IChannelMessage m)
			{
				InfoChannelMessageChild infoChannelMessageChild = new InfoChannelMessageChild
				{
					Id = m.Id,
					CreationAuthor = m.CreationAuthor,
					CreationDate = m.CreationDate,
					FullMessageText = m.FullMessage,
					Subject = m.Subject,
					AllowEdit = false,
					AllowComment = AllowCommentMessage(m, currentUser),
					Recipients = GetRecipients(m, currentUser),
					Message = m,
					DiscussionObjectsOriginal = ((IEnumerable<IDiscussionObject>)m.DiscussionObjects).ToList(),
					DiscussionObjects = (from o in ((IEnumerable<IDiscussionObject>)m.DiscussionObjects).Select(delegate(IDiscussionObject o)
						{
							Type entityType = ModelHelper.GetEntityType(o.ObjectType);
							IEntityManager manager = ModelHelper.GetEntityManager(entityType);
							object obj = null;
							Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegiesAndWithDeleted(delegate
							{
								obj = manager.LoadOrNull(o.ObjectId);
							});
							return obj;
						})
						where o != null
						select o).ToList()
				};
				if (commentAction != null)
				{
					commentAction.ProcessToCommentModel(m, infoChannelMessageChild.CommentModel);
				}
				return infoChannelMessageChild;
			}));
			if (feedsMessages[id].Count == 0)
			{
				feedsMessages[id].Add(new InfoChannelMessageChild
				{
					Id = -1L
				});
			}
		}
	}

	public static Dictionary<MessageObject, object> GetMessageObjects(List<MessageObject> msgObjects)
	{
		Dictionary<Guid, List<MessageObject>> dictionary = (from m in msgObjects
			group m by m.TypeUid).ToDictionary((IGrouping<Guid, MessageObject> m) => m.Key, (IGrouping<Guid, MessageObject> m) => m.ToList());
		Dictionary<MessageObject, object> dictionary2 = new Dictionary<MessageObject, object>();
		foreach (Guid typeUid in dictionary.Keys)
		{
			IFeedMessageObjectsExtension feedMessageObjectsExtension = ComponentManager.Current.GetExtensionPoints<IFeedMessageObjectsExtension>().FirstOrDefault((IFeedMessageObjectsExtension e) => e.IsSupport(typeUid));
			if (feedMessageObjectsExtension == null)
			{
				continue;
			}
			Dictionary<MessageObject, object> messageObjects = feedMessageObjectsExtension.GetMessageObjects(dictionary[typeUid].Distinct().ToList());
			foreach (MessageObject key in messageObjects.Keys)
			{
				dictionary2.Add(key, messageObjects[key]);
			}
		}
		return dictionary2;
	}
}
