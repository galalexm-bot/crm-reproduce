using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;
using EleWise.ELMA.Web.Mvc.Html.MessageCustomPager;

namespace EleWise.ELMA.Web.Mvc.Html.CustomMessagesPager;

public class CustomMessagesPager
{
	private readonly HttpRequestBase _request;

	private readonly string _pageQueryName = SR.T("page");

	private readonly string _pageSizeQueryName = SR.T("size");

	private readonly string _pageSizeCaption = SR.T("Кол-во:");

	private readonly string _pages = SR.T("Страницы:");

	private readonly string _itemsCountFormat = SR.T("Найдено записей:");

	private Func<int, string> _urlBuilder;

	private Guid _id;

	private MessagePagerSettings _currentSettings;

	private long _totalItems;

	private int _pageNumber;

	private int _pageSize;

	private int _totalPages;

	private List<MessagePagerSettings> _pagers;

	private bool _isDebug;

	private string _actionName;

	public string GridId { get; set; }

	public CustomMessagesPager(MessagePagerSettings currentSettings, long totalItems, List<MessagePagerSettings> pagers, HttpRequestBase request, bool isDebug, string actionName = "")
	{
		_currentSettings = currentSettings;
		_pageNumber = currentSettings.Page;
		_pageSize = currentSettings.PageSize;
		_totalItems = totalItems;
		_totalPages = Convert.ToInt32((totalItems % _pageSize == 0L) ? (totalItems / _pageSize) : (totalItems / _pageSize + 1));
		_pagers = pagers.Where((MessagePagerSettings p) => p.SourceId != _currentSettings.SourceId).ToList();
		_request = request;
		_urlBuilder = CreateDefaultUrl;
		_id = Guid.NewGuid();
		_isDebug = isDebug;
		_actionName = actionName;
	}

	public CustomMessagesPager(MessagePagerSettings currentSettings, long totalItems, HttpRequestBase request, bool isDebug, string actionName = "")
	{
		if (currentSettings.Page == 0)
		{
			currentSettings.Page = 1;
		}
		_currentSettings = currentSettings;
		_pageNumber = currentSettings.Page;
		_pageSize = currentSettings.PageSize;
		_totalItems = totalItems;
		_totalPages = Convert.ToInt32((totalItems % _pageSize == 0L) ? (totalItems / _pageSize) : (totalItems / _pageSize + 1));
		_pagers = new List<MessagePagerSettings>();
		_request = request;
		_urlBuilder = CreateDefaultUrl;
		_id = Guid.NewGuid();
		_isDebug = isDebug;
		_actionName = actionName;
	}

	public override string ToString()
	{
		if (_totalItems == 0L)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("<div class='t-grid-pager t-grid-top'>");
		RenderRightSideOfPager(stringBuilder);
		stringBuilder.Append("</div>");
		return stringBuilder.ToString();
	}

	protected virtual void RenderRightSideOfPager(StringBuilder builder)
	{
		builder.Append(string.Concat("\r\n<script type=\"text/javascript\" language=\"javascript\">\r\n$(document).ready(function() {\r\n    $('#pagesSelector_", _id, "').change(function () {\r\n        FeedPagerClick(this, ", _currentSettings.Page, ", $(this).val());\r\n    });\r\n});\r\n</script>\r\n"));
		builder.Append("<div class=\"t-page-size\"><div class=\"t-grid-pager-label t-pager-text\">" + _pageSizeCaption + "</div>" + GetPagesSelector(_id, _pageSize) + "</div>");
		builder.Append("<div class=\"t-status-text\"><span class=\"t-pager-total t-pager-text\">" + _itemsCountFormat + "</span><span>" + _totalItems + "</span></div>");
		builder.Append("<div class=\"t-pager t-reset\"><span class=\"t-pager-text\">" + _pages + "</span>");
		builder.Append("<div class=\"t-numeric\">");
		int pageNumber = _pageNumber;
		if (pageNumber > 1)
		{
			builder.Append(CreatePageLink(1, "1"));
		}
		if (pageNumber > 4)
		{
			builder.Append(CreatePageLink((pageNumber <= 5) ? 1 : (pageNumber - 5), "..."));
		}
		if (pageNumber > 3)
		{
			builder.Append(CreatePageLink(pageNumber - 2, (pageNumber - 2).ToString(CultureInfo.InvariantCulture)));
		}
		if (pageNumber > 2)
		{
			builder.Append(CreatePageLink(pageNumber - 1, (pageNumber - 1).ToString(CultureInfo.InvariantCulture)));
		}
		builder.Append("<span class=\"t-state-active\">" + pageNumber.ToString(CultureInfo.InvariantCulture) + "</span>");
		if (pageNumber + 1 < _totalPages)
		{
			builder.Append(CreatePageLink(pageNumber + 1, (pageNumber + 1).ToString(CultureInfo.InvariantCulture)));
		}
		if (pageNumber + 2 < _totalPages)
		{
			builder.Append(CreatePageLink(pageNumber + 2, (pageNumber + 2).ToString(CultureInfo.InvariantCulture)));
		}
		if (pageNumber + 3 < _totalPages)
		{
			builder.Append(CreatePageLink((pageNumber + 5 <= _totalPages) ? (pageNumber + 5) : _totalPages, "..."));
		}
		if (pageNumber < _totalPages)
		{
			builder.Append(CreatePageLink(_totalPages, _totalPages.ToString(CultureInfo.InvariantCulture)));
		}
		builder.Append("</div></div>");
		builder.Append("<div class=\"t-status\"><a class=\"t-button t-refresh\" onclick=\"FeedPagerClick(this, " + pageNumber + "," + _currentSettings.PageSize + ")\"><span class=\"t-icon t-refresh\">" + SR.T("Обновить") + "</span></a></div>");
	}

	private static string GetPagesSelector(Guid id, int size)
	{
		int[] obj = new int[11]
		{
			5, 10, 15, 20, 25, 30, 35, 40, 45, 50,
			100
		};
		string text = string.Concat("<select id=\"pagesSelector_", id, "\">");
		int[] array = obj;
		foreach (int num in array)
		{
			string arg = ((num == size) ? "selected=\"selected\"" : "");
			text += string.Format("<option {1} value=\"{0}\">{0}</option>", num, arg);
		}
		return text + "</select>";
	}

	private string CreatePageLink(int pageNumber, string text)
	{
		return string.Format("<a class=\"t-link\" onclick=\"FeedPagerClick(this, " + pageNumber + "," + _currentSettings.PageSize + ")\">{1}</a>", _urlBuilder(pageNumber), text);
	}

	private string CreateDefaultUrl(int pageNumber)
	{
		string text = CreateQueryString("&amp;");
		string filePath = GetFilePath();
		return string.Format("{0}?{1}{2}{3}={4}&amp;{5}={6}&amp;isDebug={7}", filePath, text, string.IsNullOrWhiteSpace(text) ? "" : "&amp;", GetSourceKey(_pageQueryName, _currentSettings), pageNumber, GetSourceKey(_pageSizeQueryName, _currentSettings), _pageSize, _isDebug);
	}

	private string ChangePageSizeUrl()
	{
		string text = CreateQueryString("&");
		string filePath = GetFilePath();
		return string.Format("{0}?{1}{2}{3}={4}&{5}=", filePath, text, string.IsNullOrWhiteSpace(text) ? "" : "&", GetSourceKey(_pageQueryName, _currentSettings), 1, GetSourceKey(_pageSizeQueryName, _currentSettings));
	}

	private string CreateQueryString(string amp)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < _pagers.Count; i++)
		{
			MessagePagerSettings messagePagerSettings = _pagers[i];
			string sourceKey = GetSourceKey(_pageQueryName, messagePagerSettings);
			string sourceKey2 = GetSourceKey(_pageSizeQueryName, messagePagerSettings);
			stringBuilder.AppendFormat("{2}{0}={1}", sourceKey, HttpUtility.HtmlEncode(messagePagerSettings.Page), (i != 0) ? amp : "");
			stringBuilder.AppendFormat("{2}{0}={1}", sourceKey2, HttpUtility.HtmlEncode(messagePagerSettings.PageSize), amp);
		}
		return stringBuilder.ToString();
	}

	private static string GetSourceKey(string key, MessagePagerSettings settings)
	{
		return $"{key}{settings.SourceId}";
	}

	private string GetFilePath()
	{
		if (string.IsNullOrEmpty(_actionName))
		{
			return _request.Path;
		}
		string[] array = _request.Path.Split(new char[1] { '/' }, StringSplitOptions.RemoveEmptyEntries);
		return $"/{array[0]}/{array[1]}/{_actionName}/{array[3]}";
	}
}
