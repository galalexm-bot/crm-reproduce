using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Messages.API.Extensions;
using EleWise.ELMA.Messages.API.Feed.Models;
using EleWise.ELMA.Messages.Enums;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.Messages.API;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[ServiceKnownType("GetEntityKnownTypes", typeof(ServiceKnownTypeHelper))]
[Component]
[Uid("{36F517FB-51D1-47DE-995B-4326A5F8F1F3}")]
public class MessageFeedService : IMessageFeedService, IPublicAPIWebService
{
	public const string GuidS = "{36F517FB-51D1-47DE-995B-4326A5F8F1F3}";

	public static Guid Guid = new Guid("{36F517FB-51D1-47DE-995B-4326A5F8F1F3}");

	private const int MaxLimit = 100;

	private const int DefaultLimit = 20;

	private const int LENGTH_HASH_FAVORITE = 16;

	private const int HitDelayTimeout = 5;

	private Guid recipientUserUid = InterfaceActivator.UID<EleWise.ELMA.Security.Models.IUser>();

	private Guid channelUserUid = InterfaceActivator.UID<IInformationChannel>();

	private const int SHUFFLE_LENGTH = 35;

	private IUnitOfWorkManager UnitOfWorkManager => Locator.GetServiceNotNull<IUnitOfWorkManager>();

	private IEnumerable<IChannelMessageHandler> ChannelMessageHandlers => ComponentManager.Current.GetExtensionPoints<IChannelMessageHandler>();

	public FeedData GetMyFeed(string after, string before, int limit, bool onlyUnread)
	{
		APIRouteProvider.CheckHpsLimit("EleWise.ELMA.Messages.API/MessageFeedService/Feed", 5.0);
		return FetchFeedModels(after, before, limit, onlyUnread);
	}

	public FeedData GetMyFeedWithFilter(string after, string before, int limit, bool onlyUnread, FeedFilterData filterData)
	{
		APIRouteProvider.CheckHpsLimit("EleWise.ELMA.Messages.API/MessageFeedService/FindInFeed", 5.0);
		return FetchFeedModels(after, before, limit, onlyUnread, filterData);
	}

	public FavoriteData GetMyFavorite(int limit, string after = null)
	{
		APIRouteProvider.CheckHpsLimit("EleWise.ELMA.Messages.API/MessageFeedService/FeedFavorite", 5.0);
		using IUnitOfWork unitOfWork = UnitOfWorkManager.Create("", transactional: true, IsolationLevel.ReadCommitted);
		try
		{
			int num = ((limit == 0) ? 20 : limit);
			if (num > 100)
			{
				num = 100;
			}
			List<FeedFavoritePost> list = new List<FeedFavoritePost>();
			string text = string.Empty;
			EleWise.ELMA.Security.Models.IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
			FeedFavoriteLoadSettings feedFavoriteLoadSettings = new FeedFavoriteLoadSettings();
			feedFavoriteLoadSettings.Recipient = currentUser;
			feedFavoriteLoadSettings.MaxCount = num;
			if (!string.IsNullOrEmpty(after))
			{
				text = UnShuffleHash(after, 16);
			}
			feedFavoriteLoadSettings.ChangeDateHash = text.ToLowerInvariant();
			List<FeedFavoriteModel> source = FeedManager.Instance.LoadFavoritesNew(feedFavoriteLoadSettings);
			list.AddRange(source.Select(FeedFavoritePost.Create));
			string text2 = text;
			if (list.Count > 0)
			{
				text2 = list.Last().ObjectHash;
			}
			if (!text2.IsNullOrWhiteSpace())
			{
				text2 = ShuffleHashAnyLength(text2);
			}
			FavoriteData result = new FavoriteData
			{
				Data = list.ToArray(),
				Count = list.Count,
				After = text2
			};
			unitOfWork.Commit();
			return result;
		}
		catch (Exception)
		{
			unitOfWork.Rollback();
			throw;
		}
	}

	public FeedData GetMyFavoritePosts(int limit, string after = null)
	{
		APIRouteProvider.CheckHpsLimit("EleWise.ELMA.Messages.API/MessageFeedService/FeedFavoritePosts", 5.0);
		return FetchFeedModels(after, null, limit, onlyUnread: false, new FeedFilterData
		{
			Favorites = true
		});
	}

	public InfoData GetMyInfo(int limit, DateTime after = default(DateTime))
	{
		APIRouteProvider.CheckHpsLimit("EleWise.ELMA.Messages.API/MessageFeedService/FeedInfo", 5.0);
		using IUnitOfWork unitOfWork = UnitOfWorkManager.Create("", transactional: true, IsolationLevel.ReadCommitted);
		try
		{
			DateTime? dateTime = ((after == DateTime.MinValue) ? null : new DateTime?(after));
			int num = ((limit == 0) ? 20 : limit);
			if (num > 100)
			{
				num = 100;
			}
			List<FeedInfoPost> list = new List<FeedInfoPost>();
			EleWise.ELMA.Security.Models.IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
			FeedMessageInfoLoadSettings feedMessageInfoLoadSettings = new FeedMessageInfoLoadSettings();
			feedMessageInfoLoadSettings.Recipient = currentUser;
			feedMessageInfoLoadSettings.MaxCount = num;
			feedMessageInfoLoadSettings.ChangeDate = dateTime;
			List<FeedMessageInfoModel> messageInfoNew = FeedManager.Instance.GetMessageInfoNew(feedMessageInfoLoadSettings);
			list.AddRange(messageInfoNew.Select(FeedInfoPost.Create));
			DateTime? after2 = dateTime;
			if (list.Count > 0)
			{
				after2 = list.Last().ChangeDate;
			}
			InfoData result = new InfoData
			{
				Data = list.ToArray(),
				Count = list.Count,
				After = after2
			};
			unitOfWork.Commit();
			return result;
		}
		catch (Exception)
		{
			unitOfWork.Rollback();
			throw;
		}
	}

	public FeedPost GetPost(string id)
	{
		if (!long.TryParse(id, out var result))
		{
			throw PublicServiceException.CreateWebFault($"Incorrect post id: {id}", 404);
		}
		return FeedPost.CreateFeedPost(FeedManager.Instance.LoadMessage(result) ?? throw PublicServiceException.CreateWebFault("Post not found", 404));
	}

	public FeedPost[] GetPosts(string[] ids)
	{
		if (ids == null || ids.Length == 0)
		{
			return new FeedPost[0];
		}
		List<long> idsL = new List<long>();
		ids.ForEach(delegate(string i)
		{
			if (long.TryParse(i, out var result))
			{
				idsL.Add(result);
			}
		});
		if (!ids.Any())
		{
			return new FeedPost[0];
		}
		return FeedManager.Instance.LoadMessages(idsL.ToArray()).Select(FeedPost.CreateFeedPost).ToArray();
	}

	public bool AddFavorite(FeedFavoritePost post)
	{
		try
		{
			FeedManager.Instance.AddToFavorite(post.ObjectUid, post.ObjectId);
			return true;
		}
		catch (Exception)
		{
		}
		return false;
	}

	public bool DeleteFavorite(FeedFavoritePost post)
	{
		try
		{
			FeedManager.Instance.DeleteFromFavorite(post.ObjectUid, post.ObjectId);
			return true;
		}
		catch (Exception)
		{
		}
		return false;
	}

	public bool SetAsReadPost(string id, string lastCommentHash)
	{
		if (!long.TryParse(id, out var result))
		{
			throw PublicServiceException.CreateWebFault($"Incorrect post id: {id}", 404);
		}
		FeedModel feedModel = FeedManager.Instance.LoadMessage(result);
		if (feedModel == null)
		{
			throw PublicServiceException.CreateWebFault("Post not found", 404);
		}
		try
		{
			string changeDateHash = null;
			if (!lastCommentHash.IsNullOrWhiteSpace())
			{
				changeDateHash = UnShuffleHash(lastCommentHash);
			}
			FeedManager.Instance.SetAsRead(changeDateHash, feedModel.ActionObjectId, feedModel.ActionObjectUid);
		}
		catch (Exception ex)
		{
			throw PublicServiceException.CreateWebFault($"SetAsRead Error: {ex.Message}", 500);
		}
		return true;
	}

	public bool SetAsReadParents(SetAsReadParentsInfo info)
	{
		if (info == null)
		{
			return false;
		}
		string changeDateHashMax = null;
		string changeDateHashMin = null;
		if (!info.FirstBeforeHash.IsNullOrWhiteSpace())
		{
			changeDateHashMax = UnShuffleHash(info.FirstBeforeHash);
		}
		if (!info.LastAfterHash.IsNullOrWhiteSpace())
		{
			changeDateHashMin = UnShuffleHash(info.LastAfterHash);
		}
		EleWise.ELMA.Messages.Enums.FeedPriority? priority = null;
		if (info.Priority.HasValue)
		{
			int value = info.Priority.Value;
			if (Enum.IsDefined(typeof(EleWise.ELMA.Messages.Enums.FeedPriority), value))
			{
				priority = (EleWise.ELMA.Messages.Enums.FeedPriority)value;
			}
		}
		try
		{
			FeedManager.Instance.SetAsReadParents(changeDateHashMin, changeDateHashMax, priority);
			return true;
		}
		catch (Exception ex)
		{
			throw PublicServiceException.CreateWebFault($"SetAsReadParents Error: {ex.Message}", 500);
		}
	}

	public FeedData GetPostComments(string id, string after, string before, int limit)
	{
		if (!before.IsNullOrWhiteSpace() && !after.IsNullOrWhiteSpace())
		{
			throw PublicServiceException.CreateWebFault("Cannot use from and until in same request", 400);
		}
		int num = ((limit == 0) ? 20 : limit);
		if (num > 100)
		{
			num = 100;
		}
		if (!long.TryParse(id, out var result))
		{
			throw PublicServiceException.CreateWebFault($"Incorrect post id: {id}", 404);
		}
		FeedModel feedModel = FeedManager.Instance.LoadMessage(result);
		if (feedModel == null)
		{
			throw PublicServiceException.CreateWebFault("Post not found by id", 404);
		}
		List<FeedPost> list = new List<FeedPost>();
		string text = null;
		string text2 = null;
		FeedLoadSettings feedLoadSettings = new FeedLoadSettings();
		feedLoadSettings.Recipient = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		feedLoadSettings.MaxCount = num;
		new FeedFilter().ChangeDate = default(DateTimeRange);
		if (!before.IsNullOrWhiteSpace())
		{
			text = UnShuffleHash(before);
			feedLoadSettings.ChangeDateHash = text.ToLowerInvariant();
			FeedModel feedModel2 = FeedManager.Instance.LoadComments(feedModel.ActionObjectId, feedModel.ActionObjectUid, feedLoadSettings);
			if (feedModel2 == null)
			{
				throw PublicServiceException.CreateWebFault("Post not found", 404);
			}
			list.AddRange(feedModel2.Messages.Select(FeedPost.CreateFeedPost));
		}
		else if (!after.IsNullOrWhiteSpace())
		{
			text2 = UnShuffleHash(after);
			feedLoadSettings.ChangeDateHash = text2.ToLowerInvariant();
			FeedModel feedModel3 = FeedManager.Instance.LoadComments(feedModel.ActionObjectId, feedModel.ActionObjectUid, feedLoadSettings);
			if (feedModel3 == null)
			{
				throw PublicServiceException.CreateWebFault("Post not found", 404);
			}
			list.AddRange(feedModel3.Messages.Select(FeedPost.CreateFeedPost));
		}
		else
		{
			FeedModel feedModel4 = FeedManager.Instance.LoadComments(feedModel.ActionObjectId, feedModel.ActionObjectUid, feedLoadSettings);
			if (feedModel4 == null)
			{
				throw PublicServiceException.CreateWebFault("Post not found", 404);
			}
			list.AddRange(feedModel4.Messages.Select(FeedPost.CreateFeedPost));
		}
		string text3 = text2;
		string text4 = text;
		if (list.Count > 0)
		{
			text4 = list.First().RealHash;
			text3 = list.Last().RealHash;
		}
		if (!text4.IsNullOrWhiteSpace())
		{
			text4 = ShuffleHash(text4);
		}
		if (!text3.IsNullOrWhiteSpace())
		{
			text3 = ShuffleHash(text3);
		}
		return new FeedData
		{
			Data = list.ToArray(),
			Count = list.Count,
			Before = text4,
			After = text3
		};
	}

	public long UnreadCount()
	{
		return FeedManager.Instance.GetUnreadCount().FirstOrDefault((FeedCounter m) => m.WithPriority).Count;
	}

	public bool CreatePost(NewPostInfo info)
	{
		if (info == null)
		{
			throw PublicServiceException.CreateWebFault($"Cannot create comment: post is null", 400);
		}
		if (info.ObjectRecipients == null)
		{
			throw PublicServiceException.CreateWebFault($"Cannot create comment: recipients is null", 400);
		}
		try
		{
			if (info.ObjectRecipients.Any())
			{
				IChannelMessage channelMessage = InterfaceActivator.Create<IChannelMessage>();
				channelMessage.Subject = info.Subject;
				channelMessage.FullMessage = info.Text;
				List<long> list = new List<long>();
				List<long> list2 = new List<long>();
				foreach (MessageRecipientInfo item in info.ObjectRecipients.Where((MessageRecipientInfo r) => r != null))
				{
					long result = 0L;
					if (long.TryParse(item.Id, out result))
					{
						if (item.TypeUid == recipientUserUid && !list.Contains(result))
						{
							list.Add(result);
						}
						if (item.TypeUid == channelUserUid && !list2.Contains(result))
						{
							list2.Add(result);
						}
					}
				}
				if (list2.Any() || list.Any())
				{
					channelMessage.Channels.AddAll((ICollection<IInformationChannel>)(from ch in InformationChannelManager.Instance.FindByIdArray(list2.ToArray())
						where !ch.IsArchive
						select ch).ToList());
					channelMessage.Recipients.AddAll(UserManager.Instance.FindByIdArray(list.ToArray()));
					if (info.MessageAttachments != null && info.MessageAttachments.Any())
					{
						foreach (IGrouping<Guid, MessageAttachmentInfo> group in from i in info.MessageAttachments
							group i by i.TypeUid)
						{
							ChannelMessageHandlers.FirstOrDefault((IChannelMessageHandler h) => h.TypeUid == group.Key)?.Handle(channelMessage, group.ToArray());
						}
					}
					ChannelMessageManager.Instance.ProcessChannelAndSave(channelMessage);
				}
			}
		}
		catch (Exception ex)
		{
			throw PublicServiceException.CreateWebFault($"Cannot create post: {ex.Message}", 500);
		}
		return true;
	}

	protected virtual IAttachment GetAttachment(Guid fileUid)
	{
		IAttachment attachment = InterfaceActivator.Create<IAttachment>();
		attachment.File = BinaryFileDescriptor.Download(fileUid);
		attachment.CreationAuthor = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		attachment.CreationDate = DateTime.Now;
		return attachment;
	}

	public bool CreateComment(string id, NewCommentInfo info)
	{
		if (info == null)
		{
			throw PublicServiceException.CreateWebFault($"Cannot create comment: info is null", 400);
		}
		try
		{
			return FeedManager.Instance.CreateComment(info.PostActionObjectUid, info.PostActionObjectId, info.Text, (info.MessageAttachments != null) ? info.MessageAttachments.Select(MessageAttachmentInfo.CreateMessageAttachmenttModel).ToArray() : new MessageAttachment[0]) != Guid.Empty;
		}
		catch (Exception ex)
		{
			throw PublicServiceException.CreateWebFault($"Cannot create comment: {ex.Message}", 500);
		}
	}

	public bool CreateQuestion(string id, NewQuestionInfo info)
	{
		if (info == null)
		{
			throw PublicServiceException.CreateWebFault($"Cannot create question: info is null", 400);
		}
		try
		{
			return FeedManager.Instance.CreateQuestion(info.PostActionObjectUid, info.PostActionObjectId, info.Text, info.Executor.ToEntity() as EleWise.ELMA.Security.IUser, (info.MessageAttachments != null) ? info.MessageAttachments.Select(MessageAttachmentInfo.CreateMessageAttachmenttModel).ToArray() : new MessageAttachment[0], info.ShowAll) != Guid.Empty;
		}
		catch (Exception ex)
		{
			throw PublicServiceException.CreateWebFault($"Cannot create comment: {ex.Message}", 500);
		}
	}

	public ReadedPostsInfo GetReadedPosts(DateTime fromDate)
	{
		APIRouteProvider.CheckHpsLimit("EleWise.ELMA.Messages.API/MessageFeedService/ReadedPosts", 5.0);
		DateTime now = DateTime.Now;
		try
		{
			long[] readedPostsIds = FeedManager.Instance.GetReadedPostsIds(fromDate);
			return new ReadedPostsInfo
			{
				PostsIds = readedPostsIds,
				Now = now,
				DateHashLast = FeedManager.Instance.ChangeDateHashFirst()
			};
		}
		catch (Exception ex)
		{
			throw PublicServiceException.CreateWebFault($"Cannot get readed posts: {ex.Message}", 500);
		}
	}

	public Channel[] GetMyChannels()
	{
		List<Channel> channels = new List<Channel>();
		InformationChannelManager.Instance.GetChannelsForSending().ForEach(delegate(IInformationChannel c)
		{
			if (c != null)
			{
				channels.Add(Channel.CreateChannel(c));
			}
		});
		return channels.ToArray();
	}

	public bool IsRead(bool isRead)
	{
		return false;
	}

	internal static string UnShuffleHash(string hash, int length)
	{
		hash = UnShuffleHash(hash);
		return hash.Substring(0, length);
	}

	internal static string ShuffleHashAnyLength(string hash)
	{
		if (!string.IsNullOrEmpty(hash))
		{
			return ShuffleHash(hash.PadRight(35, '0').Substring(0, 35));
		}
		return string.Empty;
	}

	internal static string ShuffleHash(string hash)
	{
		return Convert.ToBase64String(Shuffle(Encoding.ASCII.GetBytes(hash)));
	}

	internal static string UnShuffleHash(string hash)
	{
		return Encoding.ASCII.GetString(UnShuffle(Convert.FromBase64String(hash)));
	}

	internal static byte[] Shuffle(byte[] bytes)
	{
		if (bytes.Length != 35)
		{
			throw new ArgumentException("bytes must be array of 35 length");
		}
		byte[] array = new byte[35];
		Array.Copy(bytes, 0, array, 6, 3);
		Array.Copy(bytes, 3, array, 14, 3);
		Array.Copy(bytes, 6, array, 20, 3);
		Array.Copy(bytes, 9, array, 0, 3);
		Array.Copy(bytes, 12, array, 26, 3);
		Array.Copy(bytes, 15, array, 3, 3);
		Array.Copy(bytes, 18, array, 29, 3);
		Array.Copy(bytes, 21, array, 23, 3);
		Array.Copy(bytes, 24, array, 17, 3);
		Array.Copy(bytes, 27, array, 9, 2);
		Array.Copy(bytes, 29, array, 11, 3);
		Array.Copy(bytes, 32, array, 33, 1);
		Array.Copy(bytes, 33, array, 34, 1);
		Array.Copy(bytes, 34, array, 32, 1);
		return array;
	}

	internal static byte[] UnShuffle(byte[] bytes)
	{
		if (bytes.Length != 35)
		{
			throw new ArgumentException("bytes must be array of 35 length");
		}
		byte[] array = new byte[35];
		Array.Copy(bytes, 6, array, 0, 3);
		Array.Copy(bytes, 14, array, 3, 3);
		Array.Copy(bytes, 20, array, 6, 3);
		Array.Copy(bytes, 0, array, 9, 3);
		Array.Copy(bytes, 26, array, 12, 3);
		Array.Copy(bytes, 3, array, 15, 3);
		Array.Copy(bytes, 29, array, 18, 3);
		Array.Copy(bytes, 23, array, 21, 3);
		Array.Copy(bytes, 17, array, 24, 3);
		Array.Copy(bytes, 9, array, 27, 2);
		Array.Copy(bytes, 11, array, 29, 3);
		Array.Copy(bytes, 32, array, 34, 1);
		Array.Copy(bytes, 33, array, 32, 1);
		Array.Copy(bytes, 34, array, 33, 1);
		return array;
	}

	[Obsolete("Метод устарел. Используйте, вместо него GetFeedSettings")]
	public bool GetSettingsPostCommentEnterKey()
	{
		return BaseMessageManager.Instance.LoadSettings().PostCommentEnterKey;
	}

	public FeedSettings GetFeedSettings()
	{
		FeedMessagesSettings feedMessagesSettings = BaseMessageManager.Instance.LoadSettings();
		return new FeedSettings
		{
			PostCommentEnterKey = feedMessagesSettings.PostCommentEnterKey,
			MessagesCount = feedMessagesSettings.MessagesCount,
			CommentsCount = feedMessagesSettings.CommentsCount
		};
	}

	private FeedData FetchFeedModels(string after, string before, int limit, bool onlyUnread, FeedFilterData filterData = null)
	{
		if (!before.IsNullOrWhiteSpace() && !after.IsNullOrWhiteSpace())
		{
			throw PublicServiceException.CreateWebFault("Cannot use from and until in same request", 400);
		}
		FeedFilter filter = FeedFilterData.ToFeedFilter(filterData);
		bool flag = false;
		bool favorites = false;
		if (filter == null || filter.IsEmpty() || (string.IsNullOrEmpty(filter.SearchString) && !filter.ChangeDate.From.HasValue && !filter.ChangeDate.To.HasValue && filter.CreationAuthor.Count == 0))
		{
			flag = true;
		}
		if (filter != null)
		{
			favorites = filter.Favorites;
		}
		using IUnitOfWork unitOfWork = UnitOfWorkManager.Create("", transactional: true, IsolationLevel.ReadCommitted);
		try
		{
			int mylimit = ((limit == 0) ? 20 : limit);
			if (mylimit > 100)
			{
				mylimit = 100;
			}
			if (filter != null && !filter.ChangeDate.From.HasValue)
			{
				filter.ChangeDate = new DateTimeRange(FeedManager.Instance.GetRealArchiveDateLimit(), filter.ChangeDate.To);
			}
			EleWise.ELMA.Security.Models.IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
			string text = null;
			string text2 = null;
			string changeDateHash = null;
			Func<FeedLoadSettings, List<FeedModel>> loadFeedMessagesDelegate = null;
			Func<FeedFavoriteLoadSettings, List<FeedModel>> loadFavoriteMessagesDelegate = null;
			Func<List<FeedModel>> func = null;
			Func<string, string> func2 = (string hash) => (!favorites) ? UnShuffleHash(hash) : UnShuffleHash(hash, 16);
			if (!before.IsNullOrWhiteSpace())
			{
				text = func2(before);
				changeDateHash = text.ToLowerInvariant();
				if (flag && !favorites)
				{
					loadFeedMessagesDelegate = (FeedLoadSettings settings) => FeedManager.Instance.LoadMessagesNew(settings, onlyUnread);
				}
			}
			else if (!after.IsNullOrWhiteSpace())
			{
				text2 = func2(after);
				changeDateHash = text2.ToLowerInvariant();
				if (flag && !favorites)
				{
					loadFeedMessagesDelegate = (FeedLoadSettings settings) => FeedManager.Instance.LoadMessages(settings, onlyUnread);
				}
			}
			else if (flag && !favorites)
			{
				loadFeedMessagesDelegate = (FeedLoadSettings settings) => FeedManager.Instance.LoadMessages(settings, onlyUnread);
			}
			if (favorites)
			{
				if (flag)
				{
					loadFavoriteMessagesDelegate = (FeedFavoriteLoadSettings settings) => FeedManager.Instance.LoadFavoriteMessages(settings);
				}
				else
				{
					if (filter != null)
					{
						filter.OnlyUnread = false;
					}
					loadFavoriteMessagesDelegate = (FeedFavoriteLoadSettings settings) => FeedManager.Instance.FindFavoriteMessages(settings, filter);
				}
				func = delegate
				{
					FeedFavoriteLoadSettings feedFavoriteLoadSettings = new FeedFavoriteLoadSettings();
					if (changeDateHash != null)
					{
						feedFavoriteLoadSettings.ChangeDateHash = changeDateHash;
					}
					feedFavoriteLoadSettings.Recipient = currentUser;
					feedFavoriteLoadSettings.MaxCount = mylimit;
					return loadFavoriteMessagesDelegate?.Invoke(feedFavoriteLoadSettings);
				};
			}
			else
			{
				if (!flag)
				{
					if (filter != null)
					{
						filter.OnlyUnread = onlyUnread;
					}
					loadFeedMessagesDelegate = (FeedLoadSettings settings) => FeedManager.Instance.FindMessages(settings, filter);
				}
				func = delegate
				{
					FeedLoadSettings feedLoadSettings = new FeedLoadSettings
					{
						Recipient = currentUser,
						MaxCount = mylimit
					};
					if (changeDateHash != null)
					{
						feedLoadSettings.ChangeDateHash = changeDateHash;
					}
					return loadFeedMessagesDelegate?.Invoke(feedLoadSettings);
				};
			}
			FeedPost[] array = (func?.Invoke() ?? new List<FeedModel>()).Select(FeedPost.CreateFeedPost).ToArray();
			string text3 = text2;
			string text4 = text;
			Func<string, string> func3 = (string hash) => (!favorites) ? ShuffleHash(hash) : ShuffleHashAnyLength(hash);
			int num = array.Length;
			if (num > 0)
			{
				FeedPost feedPost = array.First();
				text4 = ((feedPost.LastComments != null && feedPost.LastComments.Data != null && feedPost.LastComments.Data.Any()) ? feedPost.LastComments.Before : func3(feedPost.RealHash));
				text3 = array.Last().RealHash;
			}
			else if (!text4.IsNullOrWhiteSpace())
			{
				text4 = func3(text4);
			}
			if (!text3.IsNullOrWhiteSpace())
			{
				text3 = func3(text3);
			}
			EleWise.ELMA.Messages.Enums.FeedPriority priority = FeedManager.Instance.GetPriority(currentUser);
			EleWise.ELMA.Messages.API.Feed.Models.FeedPriority priority2 = EleWise.ELMA.Messages.API.Feed.Models.FeedPriority.Normal;
			if (Enum.IsDefined(typeof(EleWise.ELMA.Messages.API.Feed.Models.FeedPriority), (int)priority))
			{
				priority2 = (EleWise.ELMA.Messages.API.Feed.Models.FeedPriority)priority;
			}
			FeedData result = new FeedData
			{
				Data = array,
				Count = num,
				Before = text4,
				After = text3,
				Priority = priority2
			};
			unitOfWork.Commit();
			return result;
		}
		catch (Exception)
		{
			unitOfWork.Rollback();
			throw;
		}
	}
}
