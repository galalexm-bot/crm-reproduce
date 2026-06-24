using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Security;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Security.Listeners;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.Trees;

namespace EleWise.ELMA.BPM.Web.Security.Extensions;

public static class UserWebExtensions
{
	public static MvcHtmlString UserPhotoWithoutSize([NotNull] this HtmlHelper html, IUser user, string @class = "", string style = "")
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		ViewDataDictionary val = new ViewDataDictionary();
		val.Add("withoutSize", (object)true);
		val.Add("class", (object)@class);
		val.Add("style", (object)style);
		return PartialExtensions.Partial(html, "User/Photo", (object)user, val);
	}

	public static MvcHtmlString UserPhoto([NotNull] this HtmlHelper html, IUser user, int width = 120, int height = 120, string @class = "", string style = "")
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		ViewDataDictionary val = new ViewDataDictionary();
		val.Add("width", (object)width);
		val.Add("height", (object)height);
		val.Add("class", (object)@class);
		val.Add("style", (object)style);
		return PartialExtensions.Partial(html, "User/Photo", (object)user, val);
	}

	public static MvcHtmlString UserProfilePhoto([NotNull] this HtmlHelper html, IUser user, int width = 120, string @class = "", string style = "")
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		ViewDataDictionary val = new ViewDataDictionary();
		val.Add("width", (object)width);
		val.Add("saveProportions", (object)true);
		val.Add("class", (object)@class);
		val.Add("style", (object)style);
		return PartialExtensions.Partial(html, "User/Photo", (object)user, val);
	}

	public static string UserPhotoUrl([NotNull] this UrlHelper urlHelper, IUser user, int size)
	{
		if (user != null)
		{
			try
			{
				if (user.Photo != null)
				{
					return urlHelper.Action("Photo", "User", (object)new
					{
						id = user.Id,
						area = "EleWise.ELMA.BPM.Web.Security",
						uid = user.Photo.Uid.ToString("N")
					});
				}
			}
			catch (Exception exception)
			{
				Logger.Log.Error(SR.T("Не удалось загрузить файл"), exception);
			}
		}
		return urlHelper.Image("#no_photo.svg");
	}

	public static string GetUserPhotoUrl([NotNull] this UrlHelper urlHelper, long userId, Guid photoUid, int size)
	{
		if (userId > 0 && photoUid != Guid.Empty)
		{
			try
			{
				return urlHelper.Action("Photo", "User", (object)new
				{
					id = userId,
					area = "EleWise.ELMA.BPM.Web.Security",
					uid = photoUid.ToString("N")
				});
			}
			catch (Exception exception)
			{
				Logger.Log.Error(SR.T("Не удалось загрузить файл"), exception);
			}
		}
		return urlHelper.Image("#no_photo.svg");
	}

	public static string UserPhotoUrl([NotNull] this UrlHelper urlHelper, long userId, int size)
	{
		if (userId > 0)
		{
			IUser user = UserManager.Instance.Load(userId);
			return urlHelper.UserPhotoUrl(user, size);
		}
		return urlHelper.Image("#no_photo.svg");
	}

	public static List<string> UserPhotoUrls([NotNull] this UrlHelper urlHelper, IEnumerable<long> userIds, int size)
	{
		if (userIds == null)
		{
			return null;
		}
		if (userIds.Any())
		{
			Dictionary<long, Guid> usersPhotoDict = new Dictionary<long, Guid>();
			List<string> list = new List<string>();
			IComplexCacheService service = Locator.GetService<IComplexCacheService>();
			usersPhotoDict = service.GetOrAdd(UserCacheEventListener.UserDictionaryUid, UserCacheEventListener.UserDictionaryTimeStump, () => urlHelper.GetPairUserPhoto(size));
			if (userIds.Any((long id) => id >= 0 && !usersPhotoDict.ContainsKey(id)))
			{
				service.RefreshTimestamp(UserCacheEventListener.UserDictionaryTimeStump);
				usersPhotoDict = service.GetOrAdd(UserCacheEventListener.UserDictionaryUid, UserCacheEventListener.UserDictionaryTimeStump, () => urlHelper.GetPairUserPhoto(size));
			}
			UserManager instance = UserManager.Instance;
			{
				foreach (long userId in userIds)
				{
					int num = (int)userId;
					if (num > 0)
					{
						if (usersPhotoDict.ContainsKey(num))
						{
							list.Add(urlHelper.GetUserPhotoUrl(num, usersPhotoDict[num], size));
							continue;
						}
						IUser user = instance.LoadOrNull(num);
						if (user != null)
						{
							if (user.Photo != null)
							{
								list.Add(urlHelper.GetUserPhotoUrl(num, user.Photo.Uid, size));
							}
							else
							{
								list.Add(urlHelper.Image("#no_photo.svg"));
							}
						}
						else
						{
							list.Add(null);
						}
						service.RefreshTimestamp(UserCacheEventListener.UserDictionaryTimeStump);
					}
					else
					{
						list.Add(urlHelper.Image("#no_photo.svg"));
					}
				}
				return list;
			}
		}
		return null;
	}

	private static Dictionary<long, Guid> GetPairUserPhoto([NotNull] this UrlHelper urlHelper, int size)
	{
		ICollection<IUser> collection = UserManager.Instance.FindAll();
		Dictionary<long, Guid> dictionary = new Dictionary<long, Guid>();
		foreach (IUser item in collection)
		{
			if (item.Photo != null)
			{
				dictionary.Add(item.Id, item.Photo.Uid);
			}
			else
			{
				dictionary.Add(item.Id, Guid.Empty);
			}
		}
		return dictionary;
	}

	public static MvcHtmlString UserWithGroupEditor<TModel, TValue>(this HtmlHelper<TModel> html, ComplexExecutor model, Expression<Func<TModel, TValue>> expression, Action<WebViewAttributes> viewAttributesAction = null)
	{
		string expressionText = ExpressionHelper.GetExpressionText((LambdaExpression)expression);
		return html.UserWithGroupEditor(model, expression, $"{expressionText}.Users", $"{expressionText}.Groups", viewAttributesAction);
	}

	public static MvcHtmlString UserWithGroupEditor<TModel, TValue>(this HtmlHelper<TModel> html, ComplexExecutor model, Expression<Func<TModel, TValue>> expression, Expression<Func<TModel, List<IUser>>> userExpression, Expression<Func<TModel, List<IUserGroup>>> groupExpression, Action<WebViewAttributes> viewAttributesAction = null)
	{
		string expressionText = ExpressionHelper.GetExpressionText((LambdaExpression)userExpression);
		string expressionText2 = ExpressionHelper.GetExpressionText((LambdaExpression)groupExpression);
		return html.UserWithGroupEditor(model, expression, expressionText, expressionText2, viewAttributesAction);
	}

	public static MvcHtmlString UserWithGroupEditor<TModel, TValue>(this HtmlHelper<TModel> html, ComplexExecutor model, Expression<Func<TModel, TValue>> expression, string userExpression, string groupExpression, Action<WebViewAttributes> viewAttributesAction = null)
	{
		return ModelExtensions.Editor(viewAttributesAction: delegate(WebViewAttributes attributes)
		{
			attributes.TypeSettingsCreator = delegate
			{
				ComplexExecutorSettings complexExecutorSettings = new ComplexExecutorSettings();
				ModelMetadata modelMetadata = ModelMetadata.FromStringExpression(userExpression, (ViewDataDictionary)(object)html.get_ViewData());
				ModelMetadata modelMetadata2 = ModelMetadata.FromStringExpression(groupExpression, (ViewDataDictionary)(object)html.get_ViewData());
				if (modelMetadata.GetPropertyMetadata() is PropertyMetadata propertyMetadata)
				{
					complexExecutorSettings.UserSettings = propertyMetadata.Settings as EntityUserSettings;
				}
				if (modelMetadata2.GetPropertyMetadata() is PropertyMetadata propertyMetadata2)
				{
					complexExecutorSettings.GroupSettings = propertyMetadata2.Settings as EntitySettings;
				}
				return complexExecutorSettings;
			};
			if (viewAttributesAction != null)
			{
				viewAttributesAction(attributes);
			}
		}, html: html, expression: expression);
	}

	public static string GetUserInfoLink(this UrlHelper urlHelper, IUser user)
	{
		Contract.ArgumentNotNull(user, "user");
		return $"<a href=\"javascript: showUserInfo('{user.Id}')\">{user.GetShortName().HtmlEncode()}</a>";
	}

	public static string GetUsersInfoLinks(this UrlHelper urlHelper, IEnumerable<IUser> users)
	{
		return urlHelper.GetUsersInfoLinks(users, showReplaceUser: false);
	}

	public static string GetUsersInfoLinks(this UrlHelper urlHelper, IEnumerable<IUser> users, bool showReplaceUser)
	{
		Contract.ArgumentNotNull(users, "users");
		string text = "";
		foreach (IUser user in users)
		{
			text = text + (string.IsNullOrWhiteSpace(text) ? "" : ", ") + urlHelper.GetUserInfoLink(user);
			if (showReplaceUser && user.ReplacementUser != null)
			{
				text = text + " " + SR.T("(замещающий - {0})", urlHelper.GetUserInfoLink(user.ReplacementUser));
			}
		}
		return text;
	}

	public static int AuthorizationType([NotNull] this HtmlHelper html)
	{
		int result = -1;
		if (((ControllerContext)html.get_ViewContext()).get_HttpContext().User.Identity is FormsIdentity formsIdentity)
		{
			string[] array = formsIdentity.Ticket.UserData.Split(";".ToCharArray());
			if (array.Length > 2)
			{
				int num = array[2].IndexOf(':');
				if (num > 0)
				{
					int.TryParse(array[2].Substring(0, num), out result);
				}
			}
		}
		return result;
	}

	public static MvcHtmlString GetUserInfo(this HtmlHelper html, InfoUserPanel model)
	{
		Contract.NotNull(html, "html");
		return PartialExtensions.Partial(html, "User/InfoUserPanel", (object)model);
	}

	public static MvcHtmlString UserSelectItem(this HtmlHelper html, AutoCompleteUserItem item, string photoUrl)
	{
		return html.UserSelectItem(new UserSelectModel
		{
			Item = item,
			PhotoUrl = photoUrl
		});
	}

	public static MvcHtmlString UserSelectItem(this HtmlHelper html, UserSelectModel model)
	{
		Contract.NotNull(html, "html");
		Contract.NotNull(model, "model");
		return PartialExtensions.Partial(html, "User/UserSelectItem", (object)model);
	}

	public static MvcHtmlString TreeSearchIncludeSub(this HtmlHelper html, TreeModel model, ViewDataDictionary viewData = null)
	{
		return PartialExtensions.Partial(html, "Shared/Organization/TreeSearchIncludeSubCheckbox", (object)model, viewData ?? html.get_ViewData());
	}
}
