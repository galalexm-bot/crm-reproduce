using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using EleWise.ELMA.Messages.API.Feed.Models;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.Messages.API;

[ServiceContract(Namespace = "http://www.elma-bpm.ru/api/")]
[AuthorizeContractBehavior]
[FaultContractBehavior(typeof(PublicServiceException))]
public interface IMessageFeedService
{
	[OperationContract]
	[WebGet(UriTemplate = "/Posts/Feed?after={after}&before={before}&limit={limit}&onlyUnread={onlyUnread}")]
	FeedData GetMyFeed(string after, string before, int limit, bool onlyUnread);

	[OperationContract]
	[WebGet(UriTemplate = "/Posts/Feed/UnreadCount")]
	long UnreadCount();

	[OperationContract]
	[WebGet(UriTemplate = "/Posts/{id}/Comments?after={after}&before={before}&limit={limit}")]
	FeedData GetPostComments(string id, string after, string before, int limit);

	[OperationContract]
	[WebGet(UriTemplate = "/Posts/{id}")]
	FeedPost GetPost(string id);

	[Obsolete("Метод устарел. Используйте, вместо него GetFeedSettings")]
	[OperationContract]
	[WebGet(UriTemplate = "/Settings/PostCommentEnterKey")]
	bool GetSettingsPostCommentEnterKey();

	[OperationContract]
	[WebGet(UriTemplate = "/Settings/FeedSettings")]
	FeedSettings GetFeedSettings();

	[OperationContract]
	[WebInvoke(UriTemplate = "/Posts/GetPosts", Method = "POST")]
	FeedPost[] GetPosts(string[] ids);

	[OperationContract]
	[WebInvoke(UriTemplate = "/Posts/AddFavorite", Method = "POST")]
	bool AddFavorite(FeedFavoritePost post);

	[OperationContract]
	[WebInvoke(UriTemplate = "/Posts/DeleteFavorite", Method = "POST")]
	bool DeleteFavorite(FeedFavoritePost post);

	[OperationContract]
	[WebGet(UriTemplate = "/Posts/GetMyFavorite?limit={limit}&afterHash={afterHash}")]
	FavoriteData GetMyFavorite(int limit, string afterHash = null);

	[OperationContract]
	[WebGet(UriTemplate = "/Posts/GetMyInfo?limit={limit}&after={after}")]
	InfoData GetMyInfo(int limit, DateTime after = default(DateTime));

	[OperationContract]
	[WebInvoke(UriTemplate = "/Posts/{id}/SetAsRead", Method = "POST")]
	bool SetAsReadPost(string id, string commentsLastAfterHash);

	[OperationContract]
	[WebInvoke(UriTemplate = "/Posts/SetAsRead", Method = "POST")]
	bool SetAsReadParents(SetAsReadParentsInfo info);

	[OperationContract]
	[WebInvoke(UriTemplate = "/Posts/CreatePost", Method = "POST")]
	bool CreatePost(NewPostInfo info);

	[OperationContract]
	[WebInvoke(UriTemplate = "/Posts/{id}/CreateComment", Method = "POST")]
	bool CreateComment(string id, NewCommentInfo info);

	[OperationContract]
	[WebInvoke(UriTemplate = "/Posts/{id}/CreateQuestion", Method = "POST")]
	bool CreateQuestion(string id, NewQuestionInfo info);

	[OperationContract]
	[WebGet(UriTemplate = "/Posts/Readed?fromDate={fromDate}")]
	ReadedPostsInfo GetReadedPosts(DateTime fromDate);

	[OperationContract]
	[WebGet(UriTemplate = "/Posts/Channels")]
	Channel[] GetMyChannels();

	[OperationContract]
	[WebInvoke(UriTemplate = "/Posts/Feed?after={after}&before={before}&limit={limit}&onlyUnread={onlyUnread}", Method = "POST")]
	FeedData GetMyFeedWithFilter(string after, string before, int limit, bool onlyUnread, FeedFilterData filterData);

	[OperationContract]
	[WebGet(UriTemplate = "/Posts/GetMyFavoritePosts?limit={limit}&after={after}")]
	FeedData GetMyFavoritePosts(int limit, string after);
}
