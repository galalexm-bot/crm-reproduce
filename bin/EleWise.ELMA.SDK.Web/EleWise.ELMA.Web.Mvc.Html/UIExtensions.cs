using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.ExtensionPoints.HeaderButtonsServices;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.Boxes;
using EleWise.ELMA.Web.Mvc.Html.Buttons;
using EleWise.ELMA.Web.Mvc.Html.Card;
using EleWise.ELMA.Web.Mvc.Html.ChekBoxes;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Html.FileBrowser;
using EleWise.ELMA.Web.Mvc.Html.FilterSearchForm;
using EleWise.ELMA.Web.Mvc.Html.Menu;
using EleWise.ELMA.Web.Mvc.Html.Selectors;
using EleWise.ELMA.Web.Mvc.Html.Toolbar;
using EleWise.ELMA.Web.Mvc.Html.Validation;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Web.Mvc.Models.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Menu;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;
using EleWise.ELMA.Web.Mvc.Models.Boxes;
using EleWise.ELMA.Web.Mvc.Models.Buttons;
using EleWise.ELMA.Web.Mvc.Models.Calendar;
using EleWise.ELMA.Web.Mvc.Models.History;
using EleWise.ELMA.Web.Mvc.Models.Inputs;
using EleWise.ELMA.Web.Mvc.Models.Panels;
using EleWise.ELMA.Web.Mvc.Models.Portal;
using EleWise.ELMA.Web.Mvc.Models.Selectors;
using EleWise.ELMA.Web.Mvc.Models.Trees;
using EleWise.ELMA.Web.Mvc.Portlets;
using EleWise.ELMA.Web.Mvc.UI;
using Telerik.Web.Mvc.Infrastructure;
using Telerik.Web.Mvc.UI;
using Telerik.Web.Mvc.UI.Fluent;

namespace EleWise.ELMA.Web.Mvc.Html;

public static class UIExtensions
{
	private class ExtensionZoneComponent : IExtensionZone
	{
		private Func<dynamic, object> Action { get; set; }

		public ExtensionZoneComponent(Func<dynamic, object> action)
		{
			Action = action;
		}

		public bool CanRenderInZone(string zoneId, HtmlHelper html)
		{
			return Action != null;
		}

		public void RenderZone(string zoneId, HtmlHelper html)
		{
			html.get_ViewContext().get_Writer().Write(Action(null).ToString());
		}
	}

	public class ExtensionZoneData
	{
		public int Order { get; set; }

		public Func<dynamic, object> Action { get; set; }

		public ExtensionZoneData(int order, Func<dynamic, object> action)
		{
			Order = order;
			Action = action;
		}
	}

	public class SearchBoxModel
	{
		public string OnKeyUpHandler { get; set; }

		public string Name { get; set; }
	}

	public const string UI = "UI/";

	public const string TOOLBAR = "UI/Toolbar/";

	private const string PageSettingsUrlContextKey = "UIExtensions.PageSettingsUrl";

	private const string PageSettingsHandlerClickContextKey = "UIExtensions.PageSettingsHandlerClick";

	private const string PageSettingsActionItemsContextKey = "UIExtensions.PageSettingsActionItems";

	public const string ZONE_CONTEXT_KEY = "UIExtensions.Zones";

	public const string LabeledContainerHeaderTag = "LabeledContainerHeaderTag";

	public const string PORTLETS = "UI/Portlets/";

	public const string BOXES = "UI/Box/";

	public const string ExecuteWithoutCreatorsKey = "ExecuteWithoutCreators";

	public const string POPUPWINDOW = "UI/Popup/";

	public const string ITEMSELECTOR = "UI/Selectors/";

	public const string ACTIONITEMS = "UI/ActionItems/";

	public const string ACTIONMENU = "UI/ActionItems/ActionMenu/";

	public const string ACTIONTOOLBAR = "UI/ActionItems/ActionToolbar/";

	public const string TABS = "UI/Tabs/";

	public const string PANELS = "UI/Panels/";

	public const string WIZARD = "UI/Wizard/";

	public const string VALIDATION = "UI/Validation/";

	public const string BUTTONS = "UI/Buttons/";

	public static MvcHtmlString ExtensionZone(this HtmlHelper html, string zoneId)
	{
		return html.ExtensionZone(zoneId, (ExtensionZoneData[])null);
	}

	public static MvcHtmlString ExtensionZone(this HtmlHelper html, string zoneId, params ExtensionZoneData[] actions)
	{
		if (html != null && !string.IsNullOrWhiteSpace(zoneId))
		{
			DiagnosticsManager.Point("EZ {0} start".FormatWith(zoneId));
			List<IExtensionZone> list = (from z in ContextVars.GetOrAdd("EleWise.ELMA.Web.Mvc.ExtensionPoints.IExtensionZone", () => ComponentManager.Current.GetExtensionPoints<IExtensionZone>())
				where z?.CanRenderInZone(zoneId, html) ?? false
				select z).ToList();
			if (actions != null && actions.Any((ExtensionZoneData a) => a != null))
			{
				list = (from p in list.Select(delegate(IExtensionZone p)
					{
						Type type = p.GetType();
						ComponentAttribute attribute = AttributeHelper<ComponentAttribute>.GetAttribute(type, inherited: true);
						return new Pair<int, IExtensionZone>(AttributeHelper<ComponentOrderAttribute>.GetAttribute(type, inherited: true)?.Order ?? attribute?.Order ?? 0, p);
					}).Union(actions.Select((ExtensionZoneData a) => new Pair<int, IExtensionZone>(a.Order, new ExtensionZoneComponent(a.Action))))
					orderby p.First
					select p.Second).ToList();
			}
			foreach (IExtensionZone item in list)
			{
				string fullName = item.GetType().FullName;
				DiagnosticsManager.Point("EZ {0}; point {1} start".FormatWith(zoneId, fullName));
				item.RenderZone(zoneId, html);
				DiagnosticsManager.Point("EZ {0}; point {1} end".FormatWith(zoneId, fullName));
			}
			DiagnosticsManager.Point("EZ {0} end".FormatWith(zoneId));
		}
		return MvcHtmlString.Empty;
	}

	public static bool WantRenderInZone(this HtmlHelper html, string zoneId)
	{
		if (html != null && !string.IsNullOrWhiteSpace(zoneId))
		{
			return ContextVars.GetOrAdd("EleWise.ELMA.Web.Mvc.ExtensionPoints.IExtensionZone", () => ComponentManager.Current.GetExtensionPoints<IExtensionZone>()).Any((IExtensionZone z) => z?.CanRenderInZone(zoneId, html) ?? false);
		}
		return false;
	}

	public static MvcHtmlString TopMenu(this HtmlHelper html)
	{
		return PartialExtensions.Partial(html, "Toolbar/TopMenu");
	}

	public static MvcHtmlString CurrentUserInfo(this HtmlHelper html)
	{
		return PartialExtensions.Partial(html, "UI/CurrentUserInfo");
	}

	public static MvcHtmlString PageHeader(this HtmlHelper html)
	{
		return html.PageHeader(html.get_ViewData().GetViewTitle());
	}

	public static MvcHtmlString PageHeader(this HtmlHelper html, string title)
	{
		return PartialExtensions.Partial(html, "UI/Header", (object)(title ?? ""));
	}

	public static MvcHtmlString PageTitle(this HtmlHelper html)
	{
		return PartialExtensions.Partial(html, "UI/Title");
	}

	public static MvcHtmlString DefaultStyles(this HtmlHelper html)
	{
		return PartialExtensions.Partial(html, "UI/DefaultStyles");
	}

	public static MvcHtmlString DefaultScripts(this HtmlHelper html)
	{
		return PartialExtensions.Partial(html, "UI/DefaultScripts");
	}

	[NotNull]
	public static ToolbarBuilder Toolbar([NotNull] this HtmlHelper html, string uid = "DefaultActionsToolbar", string zone = "Toolbar")
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		string toolbarUid = uid ?? html.GenerateName("toolbar");
		ToolbarBuilder toolbarBuilder = ToolbarBuilder.GetCurrentToolbarBuilder(toolbarUid, delegate
		{
			ActionToolbar rootActionToolbar = new ActionToolbar(toolbarUid);
			return new ToolbarBuilder(html, rootActionToolbar);
		});
		html.RegisterContent("ToolbarContent" + toolbarUid, (dynamic d) => ToolbarBuilder.GetCurrentToolbarBuilder(toolbarUid, () => toolbarBuilder).Render(), zone);
		if (html.get_ViewContext() != null && ((ControllerContext)html.get_ViewContext()).get_HttpContext() != null && ((ControllerContext)html.get_ViewContext()).get_HttpContext().Request.Headers != null && ((ControllerContext)html.get_ViewContext()).get_HttpContext().Request.Headers["Elma-PopupWindow"] == "1")
		{
			string key = "ToolbarRenderScript" + toolbarUid;
			html.RenderInZone("Scripts", (dynamic d) => PartialExtensions.Partial(html, "UI/Popup/ToolbarPopup", (object)ToolbarBuilder.GetCurrentToolbarBuilder(toolbarUid, () => toolbarBuilder)), key);
		}
		return toolbarBuilder;
	}

	public static void Toolbar([NotNull] this HtmlHelper html, [NotNull] Action<ToolbarBuilder> buildToolbar, string uid = "DefaultActionsToolbar")
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		if (buildToolbar == null)
		{
			throw new ArgumentNullException("buildToolbar");
		}
		ToolbarBuilder obj = html.Toolbar(uid);
		buildToolbar(obj);
	}

	[Obsolete("Use Html.Toolbar().Group() instead")]
	public static ToolbarGroupBuilder ToolbarGroup([NotNull] this HtmlHelper html, string uid = null)
	{
		return html.Toolbar().Group(uid);
	}

	[Obsolete("Return MvcHtmlString.Empty, do not use")]
	public static MvcHtmlString Render([NotNull] this ToolbarGroupBuilder builder)
	{
		return MvcHtmlString.Empty;
	}

	public static MvcHtmlString Render([NotNull] this ToolbarBuilder builder)
	{
		if (builder == null)
		{
			throw new ArgumentNullException("builder");
		}
		return builder.HtmlHelper.ActionItem(builder.ActionItem);
	}

	public static void SetPageSettingsUrl([NotNull] this HtmlHelper html, string url, string handlerClick)
	{
		ContextVars.Set("UIExtensions.PageSettingsHandlerClick", handlerClick);
		html.SetPageSettingsUrl(url);
	}

	public static void SetPageSettingsUrl([NotNull] this HtmlHelper html, string url)
	{
		ContextVars.Set("UIExtensions.PageSettingsUrl", url);
	}

	public static void SetPageSettingsActionItems([NotNull] this HtmlHelper html, ActionItemList items)
	{
		ContextVars.Set("UIExtensions.PageSettingsActionItems", items);
	}

	public static string GetPageSettingsHandlerClick([NotNull] this HtmlHelper html)
	{
		if (!ContextVars.Contains("UIExtensions.PageSettingsHandlerClick"))
		{
			return null;
		}
		return ContextVars.Get<string>("UIExtensions.PageSettingsHandlerClick");
	}

	public static string GetPageSettingsUrl([NotNull] this HtmlHelper html)
	{
		return ContextVars.GetOrDefault<string>("UIExtensions.PageSettingsUrl");
	}

	public static ActionItemList GetPageSettingsActionItems([NotNull] this HtmlHelper html)
	{
		return ContextVars.GetOrDefault<ActionItemList>("UIExtensions.PageSettingsActionItems");
	}

	private static INamingService GetNamingService(IDictionary items)
	{
		if (!items.Contains("EleWise.ELMA.Web.Mvc.Html.NamingService.KEY"))
		{
			items["EleWise.ELMA.Web.Mvc.Html.NamingService.KEY"] = new NamingService();
		}
		return (INamingService)items["EleWise.ELMA.Web.Mvc.Html.NamingService.KEY"];
	}

	public static string GenerateName(this HttpContext context, string prefix = "")
	{
		return GetNamingService(context).GenerateName(prefix);
	}

	public static void CheckName(this HttpContext context, string name)
	{
		GetNamingService(context).CheckName(name);
	}

	public static void RegisterName(this HttpContext context, string name)
	{
		GetNamingService(context).RegisterName(name);
	}

	private static INamingService GetNamingService(HttpContext context)
	{
		return GetNamingService(context.Items);
	}

	public static string GenerateName(this HtmlHelper html, string prefix = "")
	{
		return GetNamingService(html).GenerateName(prefix);
	}

	public static void CheckName(this HtmlHelper html, string name)
	{
		GetNamingService(html).CheckName(name);
	}

	public static void RegisterName(this HtmlHelper html, string name)
	{
		GetNamingService(html).RegisterName(name);
	}

	private static INamingService GetNamingService(HtmlHelper html)
	{
		return GetNamingService(((ControllerContext)html.get_ViewContext()).get_HttpContext().Items);
	}

	public static void RegisterContent([NotNull] this HtmlHelper htmlHelper, [NotNull] string key, [NotNull] Func<dynamic, object> action, [NotNull] string zone = "DefaultContentZone")
	{
		if (htmlHelper == null)
		{
			throw new ArgumentNullException("htmlHelper");
		}
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		if (string.IsNullOrEmpty(key))
		{
			throw new ArgumentNullException("key");
		}
		if (string.IsNullOrEmpty(zone))
		{
			throw new ArgumentNullException("zone");
		}
		string text = "register-content-" + zone;
		List<string> zones = ContextVars.GetOrAdd(text, () => new List<string>());
		if (zones.Count == 0)
		{
			htmlHelper.RenderInZone(zone, delegate
			{
				IList<string> registeredContent = GetRegisteredContent();
				return PartialExtensions.Partial(htmlHelper, "UI/RegisteredScripts", (object)zones.Except(registeredContent));
			}, text + "-subrender");
		}
		if (!zones.Contains(key))
		{
			htmlHelper.RenderInZone(zone, action, key);
			zones.Add(key);
		}
	}

	public static void IgnoreZones(this HtmlHelper htmlHelper, IEnumerable<string> ignoreZonesKeys)
	{
		Contract.ArgumentNotNull(htmlHelper, "htmlHelper");
		Func<object, object> action = (dynamic d) => null;
		foreach (string ignoreZonesKey in ignoreZonesKeys)
		{
			htmlHelper.RegisterContent(ignoreZonesKey, action);
		}
	}

	public static void RegisterScriptSrc([NotNull] this HtmlHelper htmlHelper, [NotNull] string src)
	{
		if (htmlHelper == null)
		{
			throw new ArgumentNullException("htmlHelper");
		}
		if (string.IsNullOrEmpty(src))
		{
			throw new ArgumentNullException("src");
		}
		Func<object, object> action = (dynamic p) => htmlHelper.Script(src);
		htmlHelper.RegisterContent("script-" + src, action, "Scripts");
	}

	public static void RegisterCssSrc([NotNull] this HtmlHelper htmlHelper, [NotNull] string src)
	{
		Contract.NotNull(htmlHelper, "htmlHelper");
		Contract.NotNullOrEmpty(src, "src");
		RegisterHead(htmlHelper, htmlHelper.LinkCss(src), src);
	}

	public static void RegisterLessSrc([NotNull] this HtmlHelper htmlHelper, [NotNull] string src, [NotNull] string zone)
	{
		Contract.NotNull(htmlHelper, "htmlHelper");
		Contract.NotNullOrEmpty(src, "src");
		Contract.NotNullOrEmpty(zone, "zone");
		Func<object, object> action = (dynamic p) => htmlHelper.LinkLess(src, zone);
		htmlHelper.RegisterContent("cssStyle-" + src, action, "Head");
	}

	public static void RegisterLessSrc([NotNull] this HtmlHelper htmlHelper, [NotNull] string url)
	{
		Contract.NotNull(htmlHelper, "htmlHelper");
		Contract.NotNullOrEmpty(url, "url");
		htmlHelper.RegisterLessSrc(url, "FilePathLessSourceProviderArea");
	}

	public static void RenderInZone([NotNull] this HtmlHelper @this, [NotNull] string zone, [NotNull] Func<dynamic, object> action, string key = null)
	{
		if (@this == null)
		{
			throw new ArgumentNullException("this");
		}
		if (zone == null)
		{
			throw new ArgumentNullException("zone");
		}
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		if (((ControllerContext)@this.get_ViewContext()).get_HttpContext() != null)
		{
			((ControllerContext)@this.get_ViewContext()).get_HttpContext().RenderInZone(zone, action, key);
		}
	}

	public static void RenderInZone([NotNull] this HttpContextBase context, [NotNull] string zone, [NotNull] Func<object, object> action, string key = null)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (zone == null)
		{
			throw new ArgumentNullException("zone");
		}
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		RegisterZoneInContext(zone);
		string key2 = key ?? ("generated-key-" + Guid.NewGuid());
		string key3 = "zone-content-" + zone;
		if (!context.Items.Contains(key3))
		{
			context.Items[key3] = new Dictionary<string, Func<object, object>>();
		}
		((Dictionary<string, Func<object, object>>)context.Items[key3])[key2] = action;
	}

	public static void RegisterZoneInContext([NotNull] string zone)
	{
		if (zone == null)
		{
			throw new ArgumentNullException("zone");
		}
		ContextVars.GetOrAdd("UIExtensions.Zones", () => new List<string>()).AddIfNotContains(zone);
	}

	public static string[] GetRegisteredZones()
	{
		return ContextVars.GetOrAdd("UIExtensions.Zones", () => new List<string>()).ToArray();
	}

	public static MvcHtmlString RenderForZone([NotNull] this HtmlHelper @this, [NotNull] string zone, bool force = false)
	{
		if (@this == null)
		{
			throw new ArgumentNullException("this");
		}
		if (zone == null)
		{
			throw new ArgumentNullException("zone");
		}
		if (((ControllerContext)@this.get_ViewContext()).get_HttpContext() != null)
		{
			return ((ControllerContext)@this.get_ViewContext()).get_HttpContext().RenderForZone(zone, force);
		}
		return MvcHtmlString.Empty;
	}

	public static bool HasRenderForZone([NotNull] this HttpContextBase context, [NotNull] string zone)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (zone == null)
		{
			throw new ArgumentNullException("zone");
		}
		string key = "zone-content-" + zone;
		return context.Items[key] is Dictionary<string, Func<object, object>>;
	}

	public static MvcHtmlString RenderForZone([NotNull] this HttpContextBase context, [NotNull] string zone, bool force = false)
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (zone == null)
		{
			throw new ArgumentNullException("zone");
		}
		string key = "zone-content-" + zone;
		if (!(context.Items[key] is Dictionary<string, Func<object, object>> dictionary))
		{
			return MvcHtmlString.Empty;
		}
		IList<string> registeredContent = GetRegisteredContent();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < dictionary.Keys.Count; i++)
		{
			string item = dictionary.Keys.ElementAt(i);
			Func<object, object> value = null;
			if (dictionary.TryGetValue(dictionary.Keys.ElementAt(i), out value) && (force || !registeredContent.Contains(item)))
			{
				stringBuilder.Append(value(null));
			}
		}
		return new MvcHtmlString(stringBuilder.ToString());
	}

	public static IList<string> GetRegisteredContent()
	{
		string text = Locator.GetServiceNotNull<IHttpContextAccessor>().Current().Request.Headers.Get("Elma-RegisteredContent");
		List<string> result = new List<string>();
		if (!string.IsNullOrEmpty(text))
		{
			result = text.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
		}
		return result;
	}

	public static MvcHtmlString RenderForZone([NotNull] this HtmlHelper @this, [NotNull] string zone, [NotNull] Func<dynamic, object> template)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		if (@this == null)
		{
			throw new ArgumentNullException("this");
		}
		if (zone == null)
		{
			throw new ArgumentNullException("zone");
		}
		if (template == null)
		{
			throw new ArgumentNullException("template");
		}
		MvcHtmlString val = @this.RenderForZone(zone);
		if (val == null || ((object)val).ToString().Length == 0)
		{
			return val;
		}
		return new MvcHtmlString(template(val).ToString());
	}

	public static void Header(this HtmlHelper htmlHelper, string title, bool setTitle = true, bool encode = true)
	{
		htmlHelper.Header(new HeaderModel(title)
		{
			SetTitle = setTitle,
			Encode = encode
		});
	}

	public static void Header(this HtmlHelper htmlHelper, string title, IEntity entity, bool setTitle = true, bool encode = true)
	{
		htmlHelper.Header(new HeaderModel(title, entity)
		{
			SetTitle = setTitle,
			Encode = encode
		});
	}

	public static void Header(this HtmlHelper htmlHelper, string title, string imageUrl, bool setTitle = true, bool encode = true)
	{
		htmlHelper.Header(new HeaderModel(title)
		{
			ImageUrl = imageUrl,
			SetTitle = setTitle,
			Encode = encode
		});
	}

	public static void Header(this HtmlHelper htmlHelper, string title, IEntity entity, string zoneId, bool setTitle = true, bool encode = true)
	{
		if (string.IsNullOrEmpty(zoneId))
		{
			htmlHelper.Header(new HeaderModel(title, entity)
			{
				SetTitle = setTitle,
				Encode = encode
			});
		}
		else
		{
			htmlHelper.Header(new HeaderModel(title, entity)
			{
				SetTitle = setTitle,
				Encode = encode
			}, zoneId);
		}
	}

	public static void Header(this HtmlHelper htmlHelper, string title, string imageUrl, IEntity entity, bool setTitle = true, bool encode = true)
	{
		htmlHelper.Header(new HeaderModel(title, entity)
		{
			ImageUrl = imageUrl,
			SetTitle = setTitle,
			Encode = encode
		});
	}

	public static void Header(this HtmlHelper htmlHelper, HeaderModel model)
	{
		htmlHelper.Header(model, "Header");
	}

	public static void Header(this HtmlHelper htmlHelper, HeaderModel model, string zoneId)
	{
		string title = model.Title;
		if (model.Encode)
		{
			model.Title = HttpUtility.HtmlEncode(model.Title);
		}
		string header;
		if (model.ImageUrl.IsNullOrWhiteSpace())
		{
			header = model.Title;
		}
		else
		{
			header = string.Concat("<div class=\"flex-center\">", htmlHelper.Image(model.ImageUrl, model.Title), "<div class=\"base-element-margin-left\">", model.Title, "</div></div>");
		}
		string zone = zoneId + "Buttons";
		if (model.EntityTypeUid != Guid.Empty)
		{
			IEntity entity = model.GetEntity();
			IHeaderButtonsWatchIsAvailableService service = Locator.GetService<IHeaderButtonsWatchIsAvailableService>();
			if (service != null && ((entity != null && service.IsAvailable(entity)) || service.IsAvailable(model.EntityTypeUid, model.EntityId)))
			{
				model.ShowWatchButton = true;
			}
			IHeaderButtonsPaperPinIsAvailableService service2 = Locator.GetService<IHeaderButtonsPaperPinIsAvailableService>();
			if (service2 != null && ((entity != null && service2.IsAvailable(entity)) || service2.IsAvailable(model.EntityTypeUid, model.EntityId)))
			{
				model.ShowPaperPinButton = true;
			}
			if (model.ShowPaperPinButton || model.ShowWatchButton)
			{
				htmlHelper.RenderInZone(zone, (dynamic i) => PartialExtensions.Partial(htmlHelper, "HeaderButtons", (object)model));
			}
			model.TagProvider = ComponentManager.Current.GetExtensionPoints<IEntityTypeTagProvider>().FirstOrDefault((IEntityTypeTagProvider p) => p.CheckType(entity));
			if (model.TagProvider != null)
			{
				if (zoneId == "LabeledContainerHeader")
				{
					htmlHelper.RenderInZone("LabeledContainerHeaderTag", (dynamic i) => model.TagProvider.GetTag(htmlHelper, entity));
				}
				else
				{
					htmlHelper.RenderInZone(zoneId, (dynamic i) => PartialExtensions.Partial(htmlHelper, "UI/HeaderTag", (object)model));
				}
			}
		}
		MvcHtmlString buttons = htmlHelper.RenderForZone(zone);
		if (MvcHtmlString.IsNullOrEmpty(buttons))
		{
			htmlHelper.RenderInZone(zoneId, (dynamic i) => header);
		}
		else
		{
			htmlHelper.RenderInZone(zoneId, (dynamic i) => PartialExtensions.Partial(htmlHelper, "HeaderButtonsContainer", (object)new Pair<MvcHtmlString, MvcHtmlString>
			{
				First = MvcHtmlString.Create(header),
				Second = buttons
			}));
		}
		if (model.SetTitle)
		{
			htmlHelper.Title(title);
		}
	}

	public static void LabeledHeader(this HtmlHelper htmlHelper, HeaderModel model)
	{
		htmlHelper.Header(model, "LabeledContainerHeader");
	}

	public static void LabeledHeader(this HtmlHelper htmlHelper, string title, IEntity entity, bool setTitle = true, bool encode = true)
	{
		htmlHelper.Header(title, entity, "LabeledContainerHeader", setTitle, encode);
	}

	public static void LabeledHeader(this HtmlHelper htmlHelper, string title, bool setTitle = true, bool encode = true)
	{
		htmlHelper.Header(new HeaderModel(title)
		{
			SetTitle = setTitle,
			Encode = encode
		}, "LabeledContainerHeader");
	}

	public static void Title(this HtmlHelper htmlHelper, string title)
	{
		string text = null;
		if (Locator.Initialized)
		{
			CommonSettingsModule service = Locator.GetService<CommonSettingsModule>();
			if (service != null && service.Settings != null)
			{
				text = service.Settings.WindowTitle;
			}
		}
		string formattedTitle = ((!string.IsNullOrWhiteSpace(text)) ? text.Replace("{Title}", title) : title);
		formattedTitle = HttpUtility.HtmlEncode(formattedTitle);
		htmlHelper.RenderInZone("Title", (dynamic i) => formattedTitle);
	}

	public static string PersonalPath(this HtmlHelper html)
	{
		return ((ControllerContext)html.get_ViewContext()).get_HttpContext().Request.AppRelativeCurrentExecutionFilePath;
	}

	public static string PersonalPath(this HtmlHelper html, HttpRequestBase request)
	{
		return html.PersonalPath();
	}

	public static MvcHtmlString Portlet(this HtmlHelper html, PortletViewModel part)
	{
		part.Portlet.BeforeRender(html, part.Personalization);
		return PartialExtensions.Partial(html, "UI/Portlets/Portlet", (object)part);
	}

	public static MvcHtmlString EditPortlet(this HtmlHelper html, PortletViewModel part)
	{
		part.Portlet.BeforeEditRender(html, part.Personalization);
		return PartialExtensions.Partial(html, "UI/Portlets/EditPortlet", (object)part);
	}

	public static MvcHtmlString PortletSettings(this HtmlHelper html, PortletViewModel part)
	{
		return PartialExtensions.Partial(html, "UI/Portlets/PortletSettings", (object)part);
	}

	public static MvcHtmlString Portal(this HtmlHelper html, PortalModel portalModel)
	{
		return PartialExtensions.Partial(html, "UI/Portlets/Portal", (object)portalModel);
	}

	public static MvcHtmlString AutocompleteEntityComboBox(this HtmlHelper html, AutocompleteEntityComboBox model)
	{
		InitAutocompleteEntityComboBoxModel(html, model);
		return PartialExtensions.Partial(html, "UI/Box/AutocompleteComboBox", (object)model);
	}

	public static void InitAutocompleteEntityComboBoxModel(HtmlHelper html, AutocompleteEntityComboBox model)
	{
		bool orDefault = ContextVars.GetOrDefault<bool>("ExecuteWithoutCreators");
		if (model.Metadata == null || model.HideCreator || orDefault)
		{
			return;
		}
		if (model.ComboBoxAddLoading)
		{
			string text = PrepareId(Guid.NewGuid().ToString());
			string value = TagBuilder.CreateSanitizedId(model.Name.Replace(".", "_"));
			PropertyMetadata propMetadata = html.get_ViewData().get_ModelMetadata().GetPropertyMetadata() as PropertyMetadata;
			object container = html.get_ViewData().get_ModelMetadata().GetContainerObject();
			model.CreatePopup = new Popup
			{
				RegisterOnce = true,
				PopupId = text,
				PopupHeader = "ajax"
			};
			var orAdd = ContextVars.GetOrAdd("EleWise.ELMA.Web.Mvc.Html.InitAutocompleteEntityComboBoxModel.Ajax", () => (from p in ComponentManager.Current.GetExtensionPoints<IFormCreator>()
				select new
				{
					Creator = p,
					Uid = p.GetType().GUID
				}).ToList());
			List<ObjectCreatorParams> serverParams = new List<ObjectCreatorParams>();
			orAdd.ForEach(p =>
			{
				ObjectCreatorParams objectCreatorParams = ObjectCreatorParamsExtensions.FromDictionary(p.Creator.GetServerParams(container, propMetadata));
				if (objectCreatorParams != null)
				{
					objectCreatorParams.CreatorGuid = p.Uid;
					serverParams.Add(objectCreatorParams);
				}
			});
			model.ComboBoxAddLoadingFunc = string.Format("function(setResult){{ onLoadingComboboxAdd('{0}', {1}, setResult) }}", html.Url().Action("GetAvailableCreators", "Entity", new RouteValueDictionary { { "area", "EleWise.ELMA.BPM.Web.Common" } }), new Dictionary<string, string>
			{
				{
					"typeUid",
					model.Metadata.Uid.ToString()
				},
				{ "inputId", value },
				{ "containerId", model.ContainerId },
				{ "popupId", text },
				{
					"parentHtmlPrefix",
					html.get_ViewData().get_TemplateInfo().get_HtmlFieldPrefix()
				},
				{
					"disableSecurity",
					model.DisableCreatorSecurity.ToString()
				},
				{
					"serverParamsJson",
					ClassSerializationHelper.SerializeObjectByJson(serverParams)
				}
			}.ToJson());
			return;
		}
		ClassMetadata child;
		List<IFormCreator> inheritedCreatorsAndChild = GetInheritedCreatorsAndChild(model.Metadata, model.DisableCreatorSecurity, out child);
		if (inheritedCreatorsAndChild.Count > 0)
		{
			model.SelectorForCreator = inheritedCreatorsAndChild.Count > 1;
			model.FormCreator = inheritedCreatorsAndChild;
			model.InitCreatePopup(html, child);
			if (model.SelectorForCreator)
			{
				model.CreateImageOnClick = string.Format("refreshPopup('CreateEntityPopup{0}', '{1}', CreateEntityPopupGetParams{0}())", model.CreatePopup.PopupId, model.CreatePopup.ActionUrl);
			}
		}
	}

	public static void ExecuteWithoutCreators<TModel>(this HtmlHelper html, [NotNull] Action<HtmlHelper<TModel>> action)
	{
		string name = "ExecuteWithoutCreators";
		bool flag = false;
		try
		{
			flag = ContextVars.GetOrDefault<bool>(name);
			if (!flag)
			{
				ContextVars.Set(name, value: true);
			}
			action((HtmlHelper<TModel>)(object)html);
		}
		finally
		{
			if (!flag)
			{
				ContextVars.Set(name, value: false);
			}
		}
	}

	public static object ExecuteWithoutCreators(this HtmlHelper html, [NotNull] Func<dynamic, object> action)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		string name = "ExecuteWithoutCreators";
		bool flag = false;
		try
		{
			flag = ContextVars.GetOrDefault<bool>(name);
			if (!flag)
			{
				ContextVars.Set(name, value: true);
			}
			return (object)new MvcHtmlString(action(html).ToString());
		}
		finally
		{
			if (!flag)
			{
				ContextVars.Set(name, value: false);
			}
		}
	}

	public static List<IFormCreator> GetInheritedCreatorsAndChild(ClassMetadata metadata, bool disableSecurity, out ClassMetadata child)
	{
		Tuple<List<IFormCreator>, ClassMetadata> orAdd = ContextVars.GetOrAdd(string.Concat("UIExtensions.IFormCreators.Inherited:", metadata.Uid, disableSecurity.ToString()), delegate
		{
			List<ClassMetadata> orAdd2 = ContextVars.GetOrAdd(string.Concat("UIExtensions.GetInheritedCreatorsAndChild.ChildClasses:", metadata.Uid, disableSecurity.ToString()), () => MetadataLoader.GetChildClasses(metadata));
			orAdd2.Add(metadata);
			ContextVars.Set("EleWise.ELMA.Web.Mvc.Html.UiExtensions.GetInheritedCreatorsAndChild", orAdd2.Select((ClassMetadata c) => ((IEntityMetadata)c).GetImplementationUid()).ToList());
			List<IFormCreator> creators = new List<IFormCreator>();
			ClassMetadata neededChild = null;
			orAdd2.ForEach(delegate(ClassMetadata ch)
			{
				List<IFormCreator> objectCreators = null;
				if (disableSecurity)
				{
					Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(delegate
					{
						objectCreators = GetCreators(ch, metadata.Uid);
					});
				}
				else
				{
					objectCreators = GetCreators(ch, metadata.Uid);
				}
				IFormCreator formCreator = ((objectCreators != null) ? objectCreators.FirstOrDefault() : null);
				if (formCreator != null)
				{
					creators.Add(formCreator);
					neededChild = ch;
				}
			});
			ClassMetadata item = ((creators.Count != 1) ? null : neededChild);
			return Tuple.Create(creators, item);
		});
		child = orAdd.Item2;
		return orAdd.Item1;
	}

	private static List<IFormCreator> GetCreators(ClassMetadata ch, Guid metadataUid)
	{
		return ContextVars.GetOrAdd(string.Concat("UIExtensions.IFormCreator:", ch.Uid, "_", metadataUid), delegate
		{
			ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
			Type entityType = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(ch.Uid);
			IFormCreator formCreator = null;
			if (!serviceNotNull.CanCheckPermission(CommonPermissions.Create, entityType) || serviceNotNull.HasPermission(CommonPermissions.Create, entityType))
			{
				bool isThereNotBase = false;
				List<IFormCreator> source = ComponentManager.Current.GetExtensionPoints<IFormCreator>(useCache: true).Where(delegate(IFormCreator p)
				{
					bool flag = p.CheckType(entityType) && p.Action(entityType) != null;
					isThereNotBase = isThereNotBase || (flag && !p.IsBase);
					return flag;
				}).ToList();
				formCreator = (isThereNotBase ? source.FirstOrDefault((IFormCreator o) => !o.IsBase) : source.FirstOrDefault());
			}
			return (formCreator == null || formCreator.HideCreator) ? new List<IFormCreator>() : new List<IFormCreator> { formCreator };
		});
	}

	public static MvcHtmlString TokenInput(this HtmlHelper html, AutocompleteEntityComboBox model)
	{
		return PartialExtensions.Partial(html, "UI/Box/TokenInput", (object)model);
	}

	public static MvcHtmlString AutocompleteComboBox(this HtmlHelper html, AutocompleteComboBox model)
	{
		model.HideSelect = model.HideSelect || model.SelectImageUrl == null;
		return PartialExtensions.Partial(html, "UI/Box/AutoComplete", (object)model);
	}

	public static MvcHtmlString ListToListSelector(this HtmlHelper html, string id, string url, string hiddenFieldForValue, bool autoLoad, bool multiselect, string valuesContainer)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		ViewDataDictionary val = new ViewDataDictionary(html.get_ViewData());
		val.Add("loadurl", (object)url);
		val.Add("idselector", (object)id);
		val.Add("autoLoad", (object)autoLoad);
		val.Add("multiselect", (object)multiselect);
		val.Add("hiddenFieldForValue", (object)hiddenFieldForValue);
		val.Add("ValuesContainer", (object)valuesContainer);
		ViewDataDictionary val2 = val;
		return PartialExtensions.Partial(html, "UI/Selectors/ItemSelector", val2);
	}

	public static MvcHtmlString ListToListSelector(this HtmlHelper html, string id, IList<SelectListItem> avalible, IList<SelectListItem> selected, string hiddenFieldForValue, bool multiselect, string valuesContainer, string width = null, int size = 16)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		ViewDataDictionary val = new ViewDataDictionary(html.get_ViewData());
		val.Add("avalible", (object)avalible);
		val.Add("selected", (object)selected);
		val.Add("idselector", (object)id);
		val.Add("multiselect", (object)multiselect);
		val.Add("hiddenFieldForValue", (object)hiddenFieldForValue);
		val.Add("ValuesContainer", (object)valuesContainer);
		val.Add("width", (object)width);
		val.Add("listsize", (object)size);
		ViewDataDictionary val2 = val;
		return PartialExtensions.Partial(html, "UI/Selectors/ItemSelector", val2);
	}

	public static MvcHtmlString TableSelector(this HtmlHelper html, string id, string url, bool autoLoad)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		ViewDataDictionary val = new ViewDataDictionary(html.get_ViewData());
		val.Add("loadurl", (object)url);
		val.Add("idselector", (object)id);
		val.Add("autoLoad", (object)autoLoad);
		ViewDataDictionary val2 = val;
		return PartialExtensions.Partial(html, "UI/Selectors/TableSelector", val2);
	}

	public static IList<SelectListItem> ListToListSelect(this HtmlHelper html, Guid uid)
	{
		if (uid == Guid.Empty)
		{
			return new List<SelectListItem>();
		}
		Type typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(uid);
		ClassMetadata metadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeByUid);
		List<IEntity> list = ModelHelper.GetEntityManager(typeByUid).FindAll().Cast<IEntity>()
			.ToList();
		return html.ListToListSelect(list, metadata);
	}

	public static IList<SelectListItem> ListToListSelect(this HtmlHelper html, IList<IEntity> list, ClassMetadata metadata)
	{
		if (list == null || metadata == null)
		{
			return new List<SelectListItem>();
		}
		return ((IEnumerable<IEntity>)list).Select((Func<IEntity, SelectListItem>)delegate(IEntity u)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected O, but got Unknown
			SelectListItem val = new SelectListItem();
			val.set_Value(u.GetType().GetProperty("Id").GetValue(u, null)
				.ToString());
			val.set_Text(u.ToString(metadata.DisplayFormat));
			return val;
		}).ToList();
	}

	public static MvcHtmlString PopoverWindow(this HtmlHelper html, string id, Func<object, object> content)
	{
		return html.PopoverWindow(id, content, string.Empty);
	}

	public static MvcHtmlString PopoverWindow(this HtmlHelper html, string id, Func<object, object> content, string widthMode)
	{
		Popover popover = new Popover
		{
			PopupId = id,
			WidthMode = widthMode,
			ZIndex = 0,
			Content = content
		};
		return html.PopoverWindow(popover);
	}

	public static MvcHtmlString PopoverWindow(this HtmlHelper html, Popup popover)
	{
		return html.PopoverWindow((popover as Popover) ?? new Popover(popover));
	}

	public static MvcHtmlString PopoverWindow(this HtmlHelper html, Popover popover)
	{
		return PartialExtensions.Partial(html, "UI/Popup/Popover", (object)popover);
	}

	public static MvcHtmlString AdaptivePopupWindow(this HtmlHelper html, string id, string header, string widthMode)
	{
		return html.AdaptivePopupWindow(id, header, null, widthMode, "");
	}

	public static MvcHtmlString AdaptivePopupWindow(this HtmlHelper html, string id, string header, string url, string widthMode)
	{
		return html.AdaptivePopupWindow(id, header, null, widthMode, url);
	}

	public static MvcHtmlString AdaptivePopupWindow(this HtmlHelper html, string id, string header, Func<object, object> content, string widthMode)
	{
		return html.AdaptivePopupWindow(id, header, content, widthMode, "");
	}

	public static MvcHtmlString AdaptivePopupWindow(this HtmlHelper html, string id, string header, Func<object, object> content, string widthMode, bool showHeader)
	{
		return html.AdaptivePopupWindow(id, header, content, widthMode, "", showHeader);
	}

	public static MvcHtmlString AdaptivePopupWindow(this HtmlHelper html, string id, string header, Func<object, object> content, string widthMode, string url, bool showHeader = true)
	{
		Popup popup = new Popup
		{
			PopupId = id,
			PopupHeader = header,
			WidthMode = widthMode,
			Modal = true,
			ShowHeader = showHeader,
			Draggable = true,
			ZIndex = 0
		};
		if (!string.IsNullOrWhiteSpace(url))
		{
			popup.ActionUrl = url;
		}
		if (content != null)
		{
			popup.Content = content;
		}
		return html.PopupWindow(popup);
	}

	public static MvcHtmlString PopupWindow(this HtmlHelper html, Popup popup)
	{
		return PartialExtensions.Partial(html, "UI/Popup/Popup", (object)popup);
	}

	public static MvcHtmlString PopupWindow(this HtmlHelper html, string id, string header, int width = -1, bool modal = true, bool showHeader = true)
	{
		return html.PopupWindow(id, header, (Func<object, object>)null, width, modal, showHeader);
	}

	public static MvcHtmlString PopupWindow(this HtmlHelper html, string id, string header, Func<object, object> content, int width = -1, bool modal = true, bool showHeader = true)
	{
		return html.PopupWindow(id, header, content, draggable: true, width, modal, showHeader);
	}

	public static MvcHtmlString PopupWindow(this HtmlHelper html, string id, string header, Func<object, object> content, bool draggable, int width = -1, bool modal = true, bool showHeader = true)
	{
		return html.PopupWindow(id, header, content, draggable, 0, width, modal, showHeader);
	}

	public static MvcHtmlString PopupWindow(this HtmlHelper html, string id, string header, Func<object, object> content, bool draggable, int zindex, int width = -1, bool modal = true, bool showHeader = true)
	{
		Popup popup = new Popup
		{
			PopupId = id,
			PopupHeader = header,
			Width = width,
			Modal = modal,
			ShowHeader = showHeader,
			Draggable = draggable,
			ZIndex = zindex
		};
		if (content != null)
		{
			popup.Content = content;
		}
		return PartialExtensions.Partial(html, "UI/Popup/Popup", (object)popup);
	}

	public static MvcHtmlString PopupWindow(this HtmlHelper html, string id, string header, string url, int width = -1, bool modal = true, bool registerOnce = false, bool showHeader = true)
	{
		Popup popup = new Popup
		{
			PopupId = id,
			PopupHeader = header,
			Width = width,
			Modal = modal,
			ActionUrl = url,
			ShowHeader = showHeader
		};
		return PartialExtensions.Partial(html, "UI/Popup/Popup", (object)popup);
	}

	public static MvcHtmlString RefreshPopup(string id, string url, string onOpenScript = "", string onCloseScript = "", bool useReferrer = false)
	{
		return MvcHtmlString.Create($"refreshPopup('{HttpUtility.JavaScriptStringEncode(id)}','{HttpUtility.JavaScriptStringEncode(url)}', '{HttpUtility.JavaScriptStringEncode(onOpenScript)}', '{HttpUtility.JavaScriptStringEncode(onCloseScript)}', {useReferrer.ToString().ToLower()});");
	}

	public static MvcHtmlString RefreshPopup(this HtmlHelper html, string id, string url, string onOpenScript = "", string onCloseScript = "", bool useReferrer = false)
	{
		return RefreshPopup(id, url, onOpenScript, onCloseScript, useReferrer);
	}

	[NotNull]
	public static MvcHtmlString OpenPopup(this HtmlHelper html, string id, string onOpenScript = "", string onCloseScript = "", bool useReferrer = false)
	{
		if ((((ControllerContext)html.get_ViewContext()).get_HttpContext().Request.QueryString["interface"] ?? string.Empty).Equals("Light", StringComparison.OrdinalIgnoreCase))
		{
			return OpenPopup(id, onOpenScript + ";SetCloseAfterPost();", onCloseScript + ";$(\"div[id^=dialog].ui-dialog-content\").dialog(\"close\");window.top.close();", useReferrer);
		}
		return OpenPopup(id, onOpenScript, onCloseScript, useReferrer);
	}

	public static MvcHtmlString WizardButtonNext(this HtmlHelper html, string id)
	{
		return WizardButtonNext(id);
	}

	public static MvcHtmlString WizardButtonBack(this HtmlHelper html, string id)
	{
		return WizardButtonBack(id);
	}

	public static MvcHtmlString WizardPost(this HtmlHelper html, string id)
	{
		return WizardPost(id);
	}

	[NotNull]
	public static MvcHtmlString OpenPopup(string id, string onOpenScript = "", string onCloseScript = "", bool useReferrer = false)
	{
		return MvcHtmlString.Create($"openWindow('{id}','{onOpenScript}','{onCloseScript}', {useReferrer.ToString().ToLower()});");
	}

	public static MvcHtmlString WizardButtonNext(string id)
	{
		return MvcHtmlString.Create($"elma.wizards.showNextStep('{id}')");
	}

	public static MvcHtmlString WizardButtonBack(string id)
	{
		return MvcHtmlString.Create($"elma.wizards.showBackStep('{id}')");
	}

	public static MvcHtmlString WizardPost(string id)
	{
		return MvcHtmlString.Create($"elma.wizards.post('{id}')");
	}

	public static MvcHtmlString ClosePopup(this HtmlHelper html, string id, bool loaded = true)
	{
		return MvcHtmlString.Create(string.Format("closeWindow('{0}', {1});", id, loaded ? "true" : "false"));
	}

	public static MvcHtmlString ClosePopup(this HtmlHelper html, bool loaded = true)
	{
		return MvcHtmlString.Create(string.Format("closeWindow(this, {0});", loaded ? "true" : "false"));
	}

	public static MvcHtmlString PostPopup(this HtmlHelper html, string id, bool validate = false)
	{
		return MvcHtmlString.Create(string.Format("elma.PostPopup('{0}', {1});", id, validate ? "true" : "false"));
	}

	public static MvcHtmlString ActionItem(this HtmlHelper html, IActionItem actionItem)
	{
		return actionItem.Process(html).Render(html);
	}

	public static MvcHtmlString ActionMenuItems(this HtmlHelper html, IActionItemList actionItems)
	{
		return PartialExtensions.Partial(html, "UI/ActionItems/ActionMenu/MenuItems", (object)actionItems);
	}

	public static MvcHtmlString ActionMenuItem(this HtmlHelper html, ActionMenuItem actionMenuItem)
	{
		return html.ActionItem(actionMenuItem);
	}

	public static MvcHtmlString ActionMenu(this HtmlHelper html, ActionMenu actionMenu)
	{
		return html.ActionItem(actionMenu);
	}

	public static ActionMenuBuilder ActionMenu([NotNull] this HtmlHelper html, string uid = null, Action<ActionMenuButtonsBuilder> menuButtonsBuilder = null)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		ActionMenuBuilder actionMenuBuilder = new ActionMenuBuilder(html, new ActionMenu(uid ?? html.GenerateName("action-menu-")));
		if (menuButtonsBuilder == null)
		{
			return actionMenuBuilder;
		}
		return actionMenuBuilder.Buttons(menuButtonsBuilder);
	}

	public static ActionMenuBuilder ActionMenu([NotNull] this HtmlHelper html, [NotNull] Action<ActionMenuButtonsBuilder> menuButtonsBuilder)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		if (menuButtonsBuilder == null)
		{
			throw new ArgumentNullException("menuButtonsBuilder");
		}
		return new ActionMenuBuilder(html, new ActionMenu(html.GenerateName("action-menu-"))).Buttons(menuButtonsBuilder);
	}

	public static MvcHtmlString ActionMenuShow([NotNull] this HtmlHelper html, ActionMenuShowParams showParams)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		return PartialExtensions.Partial(html, "UI/ActionItems/ActionMenu/MenuShow", (object)showParams);
	}

	public static MvcHtmlString ActionMenuShow([NotNull] this HtmlHelper html, [NotNull] string menuUid, object sender, Action<ActionMenuShowParams> menuParamsBuilder)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		ActionMenuShowParams actionMenuShowParams = new ActionMenuShowParams
		{
			MenuGuid = menuUid,
			Sender = sender
		};
		menuParamsBuilder?.Invoke(actionMenuShowParams);
		return PartialExtensions.Partial(html, "UI/ActionItems/ActionMenu/MenuShow", (object)actionMenuShowParams);
	}

	public static MvcHtmlString ActionMenuShow([NotNull] string menuUid, object sender = null, Action<ActionMenuShowParams> menuParamsBuilder = null)
	{
		if (string.IsNullOrWhiteSpace(menuUid))
		{
			throw new ArgumentNullException("menuUid");
		}
		ActionMenuShowParams actionMenuShowParams = new ActionMenuShowParams
		{
			MenuGuid = menuUid,
			Sender = sender
		};
		menuParamsBuilder?.Invoke(actionMenuShowParams);
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		if (actionMenuShowParams.NotVisibleItems != null && actionMenuShowParams.NotVisibleItems.Any())
		{
			dictionary["notvisible"] = "[" + string.Join(",", actionMenuShowParams.NotVisibleItems.Select((string s) => "'" + HttpUtility.JavaScriptStringEncode(s) + "'").ToArray()) + "]";
		}
		if (!string.IsNullOrEmpty(actionMenuShowParams.NotVisibleItemsUrl))
		{
			dictionary["notvisibleurl"] = "'" + HttpUtility.JavaScriptStringEncode(actionMenuShowParams.NotVisibleItemsUrl) + "'";
		}
		return MvcHtmlString.Create(string.Format("elma.ElmaMenuMgr.show('{0}',{1},{2},'{3}',{4});", HttpUtility.JavaScriptStringEncode(actionMenuShowParams.MenuGuid.ToLower()), string.IsNullOrEmpty(((object)actionMenuShowParams.Sender.ToJson()).ToString()) ? MvcHtmlString.Create("null") : actionMenuShowParams.Sender.ToJson(), actionMenuShowParams.Scope ?? "this", HttpUtility.JavaScriptStringEncode(actionMenuShowParams.Align ?? ""), "{" + string.Join(", ", dictionary.Select((KeyValuePair<string, string> a) => a.Key + ": " + a.Value).ToArray()) + "}"));
	}

	public static TabPanelBuilder TabPanelBuilder(this HtmlHelper html, string id)
	{
		return new TabPanelBuilder(html, id);
	}

	public static StartEndTemplate TabPanel(this HtmlHelper html, string id, bool vertical = false, int activeTab = 0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		ViewDataDictionary val = new ViewDataDictionary(html.get_ViewData());
		val.Add("tabPanelId", (object)id);
		val.Add("activeTab", (object)activeTab);
		val.Add("vertical", (object)(vertical ? "true" : "false"));
		return new StartEndTemplate(html.get_ViewContext(), PartialExtensions.Partial(html, "UI/Tabs/TabPanelBegin", val), PartialExtensions.Partial(html, "UI/Tabs/TabPanelEnd", val));
	}

	public static StartEndTemplate Tab(this HtmlHelper html, string contentEl, string title, string url = "")
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		ViewDataDictionary val = new ViewDataDictionary(html.get_ViewData());
		val.Add("contentEl", (object)contentEl);
		if (!val.ContainsKey("title"))
		{
			val.Add("title", (object)title);
		}
		val.Add("actionUrl", (object)url);
		return new StartEndTemplate(html.get_ViewContext(), PartialExtensions.Partial(html, "UI/Tabs/TabBegin", val), PartialExtensions.Partial(html, "UI/Tabs/TabEnd", val));
	}

	public static StartEndTemplate ClientCollapsiblePanel(this HtmlHelper html, string id, string title, bool open = true)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		ViewDataDictionary val = new ViewDataDictionary(html.get_ViewData());
		val.set_Item("idpanel", (object)id);
		val.set_Item("title", (object)title);
		val.set_Item("open", (object)open);
		return new StartEndTemplate(html.get_ViewContext(), PartialExtensions.Partial(html, "UI/Panels/ClientCollapsablePanelBegin", val), PartialExtensions.Partial(html, "UI/Panels/ClientCollapsiblePanelEnd", val));
	}

	public static StartEndTemplate AjaxPanel(this HtmlHelper html, AjaxPanel model)
	{
		return new StartEndTemplate(html.get_ViewContext(), html.AjaxPanelBegin(model), html.AjaxPanelEnd(model));
	}

	public static MvcHtmlString AjaxPanelEnd(this HtmlHelper html, AjaxPanel model)
	{
		return PartialExtensions.Partial(html, "UI/Panels/AjaxPanelEnd", (object)model);
	}

	public static MvcHtmlString AjaxPanelBegin(this HtmlHelper html, AjaxPanel model)
	{
		return PartialExtensions.Partial(html, "UI/Panels/AjaxPanelBegin", (object)model);
	}

	public static StartEndTemplate AjaxPanel(this HtmlHelper html, string id, string url, DynamicLoadMode loadMode = DynamicLoadMode.Custom)
	{
		return html.AjaxPanel(new AjaxPanel
		{
			Id = id,
			Url = url,
			LoadMode = loadMode
		});
	}

	public static MvcHtmlString CollapsiblePanelBegin(this HtmlHelper html, CollapsiblePanel model)
	{
		model.Id = PrepareId(model.Id);
		if (model.SaveState)
		{
			PanelState panelState = PanelPersonalizationAdministration.LoadState(model.Id);
			if (panelState != null)
			{
				model.Expanded = panelState.Expanded;
			}
		}
		return PartialExtensions.Partial(html, "UI/Panels/CollapsiblePanelBegin", (object)model);
	}

	public static MvcHtmlString CollapsiblePanelEnd(this HtmlHelper html, CollapsiblePanel model)
	{
		return PartialExtensions.Partial(html, "UI/Panels/CollapsiblePanelEnd", (object)model);
	}

	public static StartEndTemplate CollapsiblePanel(this HtmlHelper html, CollapsiblePanel model)
	{
		model.Id = PrepareId(model.Id ?? html.GenerateName("collapsible_panel"));
		if (model.SaveState)
		{
			PanelState panelState = PanelPersonalizationAdministration.LoadState(model.Id);
			if (panelState != null)
			{
				model.Expanded = panelState.Expanded;
			}
		}
		return new StartEndTemplate(html.get_ViewContext(), PartialExtensions.Partial(html, "UI/Panels/CollapsiblePanelBegin", (object)model), PartialExtensions.Partial(html, "UI/Panels/CollapsiblePanelEnd", (object)model));
	}

	public static CollapsiblePanelBuilder CollapsiblePanel(this HtmlHelper html)
	{
		return new CollapsiblePanelBuilder(new CollapsiblePanel
		{
			Id = html.GenerateName("collapsible_panel")
		}, html);
	}

	public static FramePanelBuilder FramePanel(this HtmlHelper html)
	{
		return new FramePanelBuilder(new FramePanel
		{
			Id = html.GenerateName("frame_panel")
		}, html);
	}

	public static string AjaxPanelOpen(this HtmlHelper html, string id)
	{
		return $"elma.dynamics.toggle('{id}');";
	}

	public static string AjaxPanelRefresh(this HtmlHelper html, string id, string callback)
	{
		return $"elma.dynamics.update('{id}', null, {callback});";
	}

	public static MvcHtmlString InfoPanel(this HtmlHelper html, ClientInfoPanel model)
	{
		return PartialExtensions.Partial(html, "UI/Panels/ClientInfoPanel", (object)model);
	}

	public static MvcHtmlString InfoPanel(this HtmlHelper html, string panelId, string text)
	{
		return html.InfoPanel(panelId, text, rootPath: false);
	}

	public static MvcHtmlString InfoPanel(this HtmlHelper html, string panelId, string text, bool rootPath)
	{
		return html.InfoPanel(panelId, text, rootPath, "");
	}

	public static MvcHtmlString InfoPanel(this HtmlHelper html, string panelId, string text, bool rootPath, string htmlClasses)
	{
		return html.InfoPanel(new ClientInfoPanel
		{
			PanelId = panelId,
			Text = text,
			RootPath = rootPath,
			HtmlClasses = htmlClasses
		});
	}

	public static MvcHtmlString InfoPanel(this HtmlHelper html, string text)
	{
		return html.InfoPanel(new ClientInfoPanel
		{
			Closable = false,
			Text = text
		});
	}

	public static CardBuilder Card(this HtmlHelper htmlHelper)
	{
		return new CardBuilder(htmlHelper);
	}

	public static MvcHtmlString TreeWithSearch(this HtmlHelper html, TreeModel model, ViewDataDictionary viewData = null)
	{
		return PartialExtensions.Partial(html, "UI/TreeWithSearch", (object)model, viewData ?? html.get_ViewData());
	}

	public static MvcHtmlString Tree(this HtmlHelper html, string id, string controller, string action, RouteValueDictionary route = null, Action<TreeModel> modelAction = null)
	{
		return html.Tree(new TreeModel
		{
			Id = id,
			ControllerName = controller,
			ActionName = action,
			RouteValues = route,
			AjaxDataBinding = true
		}, modelAction);
	}

	public static MvcHtmlString Tree(this HtmlHelper html, List<TreeMenuNode> children, string id, bool highlightPath = true)
	{
		TreeModel treeModel = new TreeModel
		{
			Children = children,
			Id = id,
			HighlightPath = highlightPath
		};
		return PartialExtensions.Partial(html, "UI/Tree", (object)treeModel);
	}

	public static MvcHtmlString Tree(this HtmlHelper html, TreeModel model)
	{
		return PartialExtensions.Partial(html, "UI/Tree", (object)model, html.get_ViewData());
	}

	public static MvcHtmlString Tree(this HtmlHelper html, List<TreeMenuNode> children, string id, string controller, string action, RouteValueDictionary route = null)
	{
		return html.Tree(children, id, null, null, null, controller, action, route);
	}

	public static MvcHtmlString Tree(this HtmlHelper html, List<TreeMenuNode> children, string id, string height, string width, string controller, string action, RouteValueDictionary route = null)
	{
		return html.Tree(children, id, height, width, null, controller, action, route);
	}

	public static MvcHtmlString Tree(this HtmlHelper html, List<TreeMenuNode> children, string id, string height, string width, string current, string controller, string action, RouteValueDictionary route = null, bool ajaxDataBinding = false)
	{
		return html.Tree(new TreeModel
		{
			Id = id,
			Height = height,
			Width = width,
			Current = current,
			Children = children,
			ControllerName = controller,
			ActionName = action,
			RouteValues = route,
			AjaxDataBinding = ajaxDataBinding
		});
	}

	public static MvcHtmlString Tree(this HtmlHelper html, TreeModel model, Action<TreeModel> modelAction)
	{
		modelAction?.Invoke(model);
		return html.Tree(model);
	}

	public static MvcHtmlString Tree(this HtmlHelper html, TreeModel model, ViewDataDictionary viewData)
	{
		return PartialExtensions.Partial(html, "UI/Tree", (object)model, viewData);
	}

	public static MvcHtmlString TreeView(this HtmlHelper html, TreeModel model)
	{
		return PartialExtensions.Partial(html, "UI/TreeView", (object)model);
	}

	public static StartEndTemplate Wizard(this HtmlHelper html, string id)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		ViewDataDictionary val = new ViewDataDictionary(html.get_ViewData());
		val.Add("wizardId", (object)id);
		return new StartEndTemplate(html.get_ViewContext(), PartialExtensions.Partial(html, "UI/Wizard/WizardBegin", val), PartialExtensions.Partial(html, "UI/Wizard/WizardEnd", val));
	}

	public static StartEndTemplate WizardStep(this HtmlHelper html, string id, string name, string actionUrl = "", bool active = false)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		ViewDataDictionary val = new ViewDataDictionary(html.get_ViewData());
		val.Add("stepId", (object)id);
		val.Add("stepHeader", (object)name);
		val.Add("actionUrl", (object)actionUrl);
		val.Add("active", (object)active);
		return new StartEndTemplate(html.get_ViewContext(), PartialExtensions.Partial(html, "UI/Wizard/WizardStepBegin", val), PartialExtensions.Partial(html, "UI/Wizard/WizardStepEnd", val));
	}

	public static MessageBoxBuilder MessageBox(this HtmlHelper html, string id)
	{
		return new MessageBoxBuilder(html, new MessageBox(id));
	}

	public static MvcHtmlString Required(this HtmlHelper helper, MvcHtmlString html)
	{
		return PartialExtensions.Partial(helper, "UI/Validation/Required", (object)html);
	}

	public static MvcHtmlString Required(this HtmlHelper helper, string html)
	{
		return helper.Required(MvcHtmlString.Create(html));
	}

	public static ValidationRulesBuilder Validation(this HtmlHelper html, string form, string callback = "", ValidatorType validatorType = ValidatorType.NEW)
	{
		return new ValidationRulesBuilder(form, callback, validatorType);
	}

	public static MvcHtmlString Calendar(this HtmlHelper html, Calendar calendar)
	{
		return PartialExtensions.Partial(html, "UI/Calendar", (object)calendar);
	}

	public static void Repeater<T>(this HtmlHelper html, IEnumerable<T> items, Action<T> render, Action<T> renderAlt)
	{
		if (items == null)
		{
			return;
		}
		int i = 0;
		items.ToList().ForEach(delegate(T item)
		{
			if (i++ % 2 == 0)
			{
				render(item);
			}
			else
			{
				renderAlt(item);
			}
		});
	}

	public static void Repeater<T>(this HtmlHelper html, Action<T> render, Action<T> renderAlt)
	{
		IEnumerable<T> items = html.get_ViewContext().get_ViewData() as IEnumerable<T>;
		html.Repeater(items, render, renderAlt);
	}

	public static void Repeater<T>(this HtmlHelper html, string viewDataKey, Action<T> render, Action<T> renderAlt)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		IEnumerable<T> enumerable = html.get_ViewContext().get_ViewData() as IEnumerable<T>;
		IDictionary<string, object> viewData = (IDictionary<string, object>)html.get_ViewContext().get_ViewData();
		enumerable = ((viewData == null) ? (new ViewDataDictionary((object)viewData).get_Item(viewDataKey) as IEnumerable<T>) : (viewData[viewDataKey] as IEnumerable<T>));
		html.Repeater(enumerable, render, renderAlt);
	}

	public static void Repeater<T>(this HtmlHelper html, IEnumerable<T> items, string className, string classNameAlt, Action<T, string> render)
	{
		if (items != null)
		{
			int i = 0;
			items.ToList().ForEach(delegate(T item)
			{
				render(item, (i++ % 2 == 0) ? className : classNameAlt);
			});
		}
	}

	public static void Repeater<T>(this HtmlHelper html, IEnumerable<T> items, Action<T> render)
	{
		items?.ToList().ForEach(render);
	}

	public static void Repeater<T>(this HtmlHelper html, string viewDataKey, string cssClass, string altCssClass, Action<T, string> render)
	{
		IEnumerable<T> viewDataAsEnumerable = GetViewDataAsEnumerable<T>(html, viewDataKey);
		int i = 0;
		viewDataAsEnumerable.ToList().ForEach(delegate(T item)
		{
			render(item, (i++ % 2 == 0) ? cssClass : altCssClass);
		});
	}

	public static void Repeater<TKey, TValue>(this HtmlHelper html, Dictionary<TKey, TValue> dataSource, string cssClass, string altCssClass, Action<TKey, TValue, string> render)
	{
		int i = 0;
		dataSource.ToList().ForEach(delegate(KeyValuePair<TKey, TValue> item)
		{
			render(item.Key, item.Value, (i++ % 2 == 0) ? cssClass : altCssClass);
		});
	}

	public static void Repeater<TKey, TValue>(this HtmlHelper html, Dictionary<TKey, TValue> dataSource, Action<TKey, TValue> render)
	{
		dataSource.ToList().ForEach(delegate(KeyValuePair<TKey, TValue> item)
		{
			render(item.Key, item.Value);
		});
	}

	private static IEnumerable<T> GetViewDataAsEnumerable<T>(HtmlHelper html, string viewDataKey)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		IEnumerable<T> enumerable = html.get_ViewContext().get_ViewData() as IEnumerable<T>;
		IDictionary<string, object> viewData = (IDictionary<string, object>)html.get_ViewContext().get_ViewData();
		if (viewData != null)
		{
			return viewData[viewDataKey] as IEnumerable<T>;
		}
		return new ViewDataDictionary((object)viewData).get_Item(viewDataKey) as IEnumerable<T>;
	}

	public static MvcHtmlString Globalization(this HtmlHelper html)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		GlobalizationInfo val = new GlobalizationInfo(Thread.CurrentThread.CurrentCulture);
		return new MvcHtmlString(new JsonSerializer().Serialize(val.ToDictionary()));
	}

	public static IHtmlString CheckBoxList(this HtmlHelper htmlHelper, string name, IEnumerable<CheckBoxListItem> listInfo)
	{
		return htmlHelper.CheckBoxList(name, listInfo, null);
	}

	public static IHtmlString CheckBoxList(this HtmlHelper htmlHelper, string name, IEnumerable<CheckBoxListItem> listInfo, bool isEntity)
	{
		return htmlHelper.CheckBoxList(name, listInfo, null, isEntity);
	}

	public static IHtmlString CheckBoxList(this HtmlHelper htmlHelper, string name, IEnumerable<CheckBoxListItem> listInfo, IDictionary<string, object> htmlAttributes, bool isEntity = false, int columns = 1, string itemUrlTemplate = "")
	{
		if (string.IsNullOrEmpty(name))
		{
			throw new ArgumentException("The argument must have a value", "name");
		}
		if (listInfo == null)
		{
			throw new ArgumentNullException("listInfo");
		}
		CheckBoxListItem[] array = (listInfo as CheckBoxListItem[]) ?? listInfo.ToArray();
		if (!array.Any())
		{
			throw new ArgumentException("The list must contain at least one value", "listInfo");
		}
		return (IHtmlString)PartialExtensions.Partial(htmlHelper, "Templates/CheckBoxes", (object)new CheckBoxesModel
		{
			Name = name,
			Items = array,
			IsEntity = isEntity,
			Columns = columns,
			ItemUrlTemplate = itemUrlTemplate,
			HtmlAttributes = htmlAttributes
		});
	}

	public static MvcHtmlString LinkButton(this HtmlHelper htmlHelper, string text, string href = "#", string click = null, string image = null, object attributes = null)
	{
		return htmlHelper.LinkButton(new LinkButton
		{
			Text = text,
			Href = href,
			OnClick = click,
			Image = image,
			Attributes = attributes?.ToDictionary()
		});
	}

	public static MvcHtmlString LinkButton(this HtmlHelper htmlHelper, LinkButton model)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		if (model == null)
		{
			throw new ArgumentNullException("model");
		}
		ActionButtonBuilder actionButtonBuilder = htmlHelper.Button(model.Image, model.Text).Url(model.Href).Click(model.OnClick)
			.Attributes(model.Attributes)
			.AsLink();
		if (!MvcHtmlString.IsNullOrEmpty(model.Description))
		{
			TagBuilder val = new TagBuilder("div");
			val.AddCssClass("link-container");
			TagBuilder val2 = new TagBuilder("div");
			val2.AddCssClass("link-description");
			val2.set_InnerHtml(val2.get_InnerHtml() + model.Description);
			val.set_InnerHtml(actionButtonBuilder.ToHtmlString() + val2.ToString((TagRenderMode)0));
			return new MvcHtmlString(val.ToString((TagRenderMode)0));
		}
		return new MvcHtmlString(actionButtonBuilder.ToHtmlString());
	}

	public static MvcHtmlString Cached(this HtmlHelper html, string key, Func<dynamic, object> template, Func<dynamic, object> whenCached = null)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		System.Web.Caching.Cache cache = ((ControllerContext)html.get_ViewContext()).get_HttpContext().Cache;
		object obj = cache.Get(key);
		MvcHtmlString val = (MvcHtmlString)((obj is MvcHtmlString) ? obj : null);
		if (val != null)
		{
			if (whenCached != null)
			{
				val = new MvcHtmlString(whenCached(val).ToString());
			}
			return val;
		}
		return (MvcHtmlString)(cache[key] = (object)new MvcHtmlString(template(null).ToString()));
	}

	public static string PrepareId(string id)
	{
		return id?.Replace('-', '_').Replace(".", "_");
	}

	public static MvcHtmlString RemoveLineBreaks(this IHtmlString htmlString)
	{
		return MvcHtmlString.Create(htmlString.ToHtmlString().RemoveLineBreaks());
	}

	public static MvcHtmlString ModernSelector([NotNull] this HtmlHelper htmlHelper, string selectButtonScript, EditableListModel editableList, Func<dynamic, object> selectButtonAdditionalContent = null)
	{
		return htmlHelper.ModernSelector("", "", selectButtonScript, editableList, selectButtonAdditionalContent);
	}

	public static MvcHtmlString ModernSelector([NotNull] this HtmlHelper htmlHelper, string selectButtonText, string selectButtonScript, EditableListModel editableList, Func<dynamic, object> selectButtonAdditionalContent = null)
	{
		return htmlHelper.ModernSelector(selectButtonText, "", selectButtonScript, editableList, selectButtonAdditionalContent);
	}

	public static MvcHtmlString ModernSelector([NotNull] this HtmlHelper htmlHelper, string selectButtonText, string selectButtonImageUrl, string selectButtonScript, EditableListModel editableList, Func<dynamic, object> selectButtonAdditionalContent = null)
	{
		ModernSelectorModel modernSelectorModel = new ModernSelectorModel
		{
			SelectButtonScript = selectButtonScript,
			EditableList = editableList,
			SelectButtonAdditionalContent = selectButtonAdditionalContent
		};
		if (!string.IsNullOrEmpty(selectButtonText))
		{
			modernSelectorModel.SelectButtonText = selectButtonText;
		}
		if (!string.IsNullOrEmpty(selectButtonImageUrl))
		{
			modernSelectorModel.SelectButtonImageUrl = selectButtonImageUrl;
		}
		return htmlHelper.ModernSelector(modernSelectorModel);
	}

	public static MvcHtmlString ModernSelector([NotNull] this HtmlHelper htmlHelper, ModernSelectorModel model)
	{
		return PartialExtensions.Partial(htmlHelper, "Templates/ModernSelector", (object)model);
	}

	public static MvcHtmlString EditableList(this HtmlHelper htmlHelper, EditableListModel editableList)
	{
		return PartialExtensions.Partial(htmlHelper, "Templates/EditableList", (object)editableList);
	}

	public static MvcHtmlString EditableList(this HtmlHelper htmlHelper, string name, IEnumerable<EditableListItem> listItems, bool edit)
	{
		return htmlHelper.EditableList(new EditableListModel
		{
			Name = name,
			Items = listItems,
			Edit = edit
		});
	}

	public static EditableListBuilder EditableList(this HtmlHelper htmlHelper, string name)
	{
		return new EditableListBuilder(name, htmlHelper);
	}

	public static MvcHtmlString Warning(this HtmlHelper htmlHelper, string text)
	{
		return PartialExtensions.Partial(htmlHelper, "Templates/Warning", (object)MvcHtmlString.Create(text));
	}

	public static MvcHtmlString Warning(this HtmlHelper htmlHelper, Func<object, object> data)
	{
		return htmlHelper.Warning(data(htmlHelper).ToString());
	}

	public static MvcHtmlString Success(this HtmlHelper htmlHelper, Func<object, object> data)
	{
		return htmlHelper.Success(data(htmlHelper).ToString());
	}

	public static MvcHtmlString Success(this HtmlHelper htmlHelper, string text)
	{
		return PartialExtensions.Partial(htmlHelper, "Templates/Information", (object)MvcHtmlString.Create(text));
	}

	public static MvcHtmlString Error(this HtmlHelper htmlHelper, Func<object, object> data)
	{
		return htmlHelper.Error(data(htmlHelper).ToString());
	}

	public static MvcHtmlString Error(this HtmlHelper htmlHelper, string text)
	{
		return PartialExtensions.Partial(htmlHelper, "Templates/Error", (object)text);
	}

	public static MvcHtmlString Error(this HtmlHelper htmlHelper, Exception ex)
	{
		return PartialExtensions.Partial(htmlHelper, "Templates/Error", (object)ex);
	}

	public static MvcHtmlString Messages(this HtmlHelper htmlHelper)
	{
		if (((ControllerContext)htmlHelper.get_ViewContext()).get_Controller() is BaseController baseController)
		{
			INotifier notifier = baseController.Notifier;
			if (notifier != null)
			{
				return notifier.Render(htmlHelper);
			}
		}
		return MvcHtmlString.Empty;
	}

	public static ModernCheckBoxBuilder ModernCheckBox(this HtmlHelper htmlHelper, bool renderUncheckedInput)
	{
		return new ModernCheckBoxBuilder(new ModernCheckBox
		{
			RenderUncheckedInput = renderUncheckedInput
		}, htmlHelper);
	}

	public static ModernCheckBoxBuilder ModernCheckBoxFor(this HtmlHelper htmlHelper, string propertyName, bool renderUncheckedInput)
	{
		return htmlHelper.ModernCheckBoxFor(propertyName, renderUncheckedInput, generateIdByName: false);
	}

	public static ModernCheckBoxBuilder ModernCheckBoxFor(this HtmlHelper htmlHelper, string propertyName, bool renderUncheckedInput, bool generateIdByName)
	{
		ModernCheckBox modernCheckBox = new ModernCheckBox
		{
			RenderUncheckedInput = renderUncheckedInput
		};
		string fullHtmlFieldName2 = (modernCheckBox.Name = htmlHelper.get_ViewContext().get_ViewData().get_TemplateInfo()
			.GetFullHtmlFieldName(propertyName));
		if (generateIdByName)
		{
			modernCheckBox.GenerateIdByName();
		}
		modernCheckBox.CopyAttributesForProperty(htmlHelper, null, fullHtmlFieldName2);
		return new ModernCheckBoxBuilder(modernCheckBox, htmlHelper);
	}

	public static ModernCheckBoxBuilder ModernCheckBoxFor<TModel>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, bool>> expression, bool renderUncheckedInput)
	{
		return htmlHelper.ModernCheckBoxFor(expression, renderUncheckedInput, generateIdByName: false);
	}

	public static ModernCheckBoxBuilder ModernCheckBoxFor<TModel>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, bool>> expression, bool renderUncheckedInput, bool generateIdByName)
	{
		ModernCheckBox modernCheckBox = new ModernCheckBox
		{
			RenderUncheckedInput = renderUncheckedInput
		};
		string expressionText = ExpressionHelper.GetExpressionText((LambdaExpression)expression);
		string fullHtmlFieldName2 = (modernCheckBox.Name = ((HtmlHelper)htmlHelper).get_ViewContext().get_ViewData().get_TemplateInfo()
			.GetFullHtmlFieldName(expressionText));
		if (generateIdByName)
		{
			modernCheckBox.GenerateIdByName();
		}
		ModelMetadata val = ModelMetadata.FromLambdaExpression<TModel, bool>(expression, htmlHelper.get_ViewData());
		if (val.get_Model() != null && bool.TryParse(val.get_Model().ToString(), out var result))
		{
			modernCheckBox.IsChecked = result;
		}
		modernCheckBox.CopyAttributesForProperty((HtmlHelper)(object)htmlHelper, val, fullHtmlFieldName2);
		return new ModernCheckBoxBuilder(modernCheckBox, (HtmlHelper)(object)htmlHelper);
	}

	public static ModernRadioButtonBuilder ModernRadioButton(this HtmlHelper htmlHelper)
	{
		return new ModernRadioButtonBuilder(new ModernRadioButton(), htmlHelper);
	}

	public static ModernRadioButtonBuilder ModernRadioButton(this HtmlHelper htmlHelper, object value)
	{
		return new ModernRadioButtonBuilder(new ModernRadioButton
		{
			Value = value
		}, htmlHelper);
	}

	public static ModernRadioButtonBuilder ModernRadioButtonFor(this HtmlHelper htmlHelper, string propertyName, object value)
	{
		return htmlHelper.ModernRadioButtonFor(propertyName, value, generateIdByName: false);
	}

	public static ModernRadioButtonBuilder ModernRadioButtonFor(this HtmlHelper htmlHelper, string propertyName, object value, bool generateIdByName)
	{
		ModernRadioButton modernRadioButton = new ModernRadioButton
		{
			Value = value
		};
		string fullHtmlFieldName2 = (modernRadioButton.Name = htmlHelper.get_ViewContext().get_ViewData().get_TemplateInfo()
			.GetFullHtmlFieldName(propertyName));
		if (generateIdByName)
		{
			modernRadioButton.GenerateIdByName();
		}
		modernRadioButton.CopyAttributesForProperty(htmlHelper, null, fullHtmlFieldName2);
		return new ModernRadioButtonBuilder(modernRadioButton, htmlHelper);
	}

	public static ModernRadioButtonBuilder ModernRadioButtonFor<TModel, TValue>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TValue>> expression, object value)
	{
		return htmlHelper.ModernRadioButtonFor(expression, value, generateIdByName: false);
	}

	public static ModernRadioButtonBuilder ModernRadioButtonFor<TModel, TValue>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TValue>> expression, object value, bool generateIdByName)
	{
		ModernRadioButton modernRadioButton = new ModernRadioButton
		{
			Value = value
		};
		string expressionText = ExpressionHelper.GetExpressionText((LambdaExpression)expression);
		string fullHtmlFieldName2 = (modernRadioButton.Name = ((HtmlHelper)htmlHelper).get_ViewContext().get_ViewData().get_TemplateInfo()
			.GetFullHtmlFieldName(expressionText));
		if (generateIdByName)
		{
			modernRadioButton.GenerateIdByName();
		}
		ModelMetadata val = ModelMetadata.FromLambdaExpression<TModel, TValue>(expression, htmlHelper.get_ViewData());
		if (val.get_Model() != null && value != null && string.Equals(val.get_Model().ToString(), value.ToString(), StringComparison.OrdinalIgnoreCase))
		{
			modernRadioButton.IsChecked = true;
		}
		modernRadioButton.CopyAttributesForProperty((HtmlHelper)(object)htmlHelper, val, fullHtmlFieldName2);
		return new ModernRadioButtonBuilder(modernRadioButton, (HtmlHelper)(object)htmlHelper);
	}

	public static ModernSwitchButtonBuilder ModernSwitchButton(this HtmlHelper htmlHelper, bool renderUncheckedInput)
	{
		return new ModernSwitchButtonBuilder(new ModernSwitchButton
		{
			RenderUncheckedInput = renderUncheckedInput
		}, htmlHelper);
	}

	public static ModernSwitchButtonBuilder ModernSwitchButtonFor(this HtmlHelper htmlHelper, string propertyName, bool renderUncheckedInput)
	{
		return htmlHelper.ModernSwitchButtonFor(propertyName, renderUncheckedInput, generateIdByName: false);
	}

	public static ModernSwitchButtonBuilder ModernSwitchButtonFor(this HtmlHelper htmlHelper, string propertyName, bool renderUncheckedInput, bool generateIdByName)
	{
		ModernSwitchButton modernSwitchButton = new ModernSwitchButton
		{
			RenderUncheckedInput = renderUncheckedInput
		};
		string fullHtmlFieldName2 = (modernSwitchButton.Name = htmlHelper.get_ViewContext().get_ViewData().get_TemplateInfo()
			.GetFullHtmlFieldName(propertyName));
		if (generateIdByName)
		{
			modernSwitchButton.GenerateIdByName();
		}
		modernSwitchButton.CopyAttributesForProperty(htmlHelper, null, fullHtmlFieldName2);
		return new ModernSwitchButtonBuilder(modernSwitchButton, htmlHelper);
	}

	public static ModernSwitchButtonBuilder ModernSwitchButtonFor<TModel>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, bool>> expression, bool renderUncheckedInput)
	{
		return htmlHelper.ModernSwitchButtonFor(expression, renderUncheckedInput, generateIdByName: false);
	}

	public static ModernSwitchButtonBuilder ModernSwitchButtonFor<TModel>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, bool>> expression, bool renderUncheckedInput, bool generateIdByName)
	{
		ModernSwitchButton modernSwitchButton = new ModernSwitchButton
		{
			RenderUncheckedInput = renderUncheckedInput
		};
		string expressionText = ExpressionHelper.GetExpressionText((LambdaExpression)expression);
		string fullHtmlFieldName2 = (modernSwitchButton.Name = ((HtmlHelper)htmlHelper).get_ViewContext().get_ViewData().get_TemplateInfo()
			.GetFullHtmlFieldName(expressionText));
		if (generateIdByName)
		{
			modernSwitchButton.GenerateIdByName();
		}
		ModelMetadata val = ModelMetadata.FromLambdaExpression<TModel, bool>(expression, htmlHelper.get_ViewData());
		if (val.get_Model() != null && bool.TryParse(val.get_Model().ToString(), out var result))
		{
			modernSwitchButton.IsChecked = result;
		}
		modernSwitchButton.CopyAttributesForProperty((HtmlHelper)(object)htmlHelper, val, fullHtmlFieldName2);
		return new ModernSwitchButtonBuilder(modernSwitchButton, (HtmlHelper)(object)htmlHelper);
	}

	[Obsolete("Use ModernCheckBox")]
	public static MvcHtmlString CheckBoxInput(this HtmlHelper htmlHelper, string name, bool @checked, bool disabled, IDictionary<string, object> htmlAttributes = null)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		TagBuilder val = new TagBuilder("input");
		if (@checked)
		{
			val.MergeAttribute("checked", "checked");
		}
		if (disabled)
		{
			val.MergeAttribute("disabled", "true");
		}
		if (htmlAttributes != null)
		{
			val.MergeAttributes<string, object>(htmlAttributes);
		}
		val.MergeAttribute("value", "true");
		val.MergeAttribute("type", "checkbox");
		val.MergeAttribute("name", name);
		return new MvcHtmlString(val.ToString((TagRenderMode)0));
	}

	[Obsolete("Use ModernCheckBox")]
	public static MvcHtmlString CheckBoxInput(this HtmlHelper htmlHelper, string name, bool @checked, bool disabled, object htmlAttributes = null)
	{
		return htmlHelper.CheckBoxInput(name, @checked, disabled, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
	}

	[Obsolete("Use ModernCheckBox")]
	public static MvcHtmlString CheckBoxInput(this HtmlHelper htmlHelper, string name, bool @checked)
	{
		return htmlHelper.CheckBoxInput(name, @checked, disabled: false, null);
	}

	public static MvcHtmlString SmartCheckbox(this HtmlHelper htmlHelper, SmartCheckBox model)
	{
		return PartialExtensions.Partial(htmlHelper, "UI/Buttons/SmartCheckBox", (object)model);
	}

	public static MvcHtmlString Tag(this HtmlHelper htmlHelper, string name, object attributes, Func<dynamic, dynamic> content)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		TagBuilder val = new TagBuilder(name);
		val.MergeAttributes<string, object>((IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(attributes));
		val.set_InnerHtml((string)((dynamic)content(val)).ToString());
		return new MvcHtmlString(((object)val).ToString());
	}

	public static void AppendAttributeValue(this TagBuilder tagBuilder, string name, string value)
	{
		if (tagBuilder == null)
		{
			throw new ArgumentNullException("tagBuilder");
		}
		IDictionary<string, string> attributes = tagBuilder.get_Attributes();
		if (attributes.TryGetValue(name, out var value2))
		{
			attributes[name] = value2 + " " + value;
		}
		else
		{
			attributes[name] = value;
		}
	}

	public static string PrepareJavascriptHref(this string javascriptCall)
	{
		return $"javascript:void(function(){{{javascriptCall}}}())";
	}

	public static string Name(this HtmlHelper htmlHelper, string partilaFieldName)
	{
		return htmlHelper.get_ViewData().get_TemplateInfo().GetFullHtmlFieldName(partilaFieldName);
	}

	public static string ID(this HtmlHelper htmlHelper, string partilaFieldName)
	{
		return htmlHelper.get_ViewData().get_TemplateInfo().GetFullHtmlFieldId(partilaFieldName);
	}

	public static string ID<T, TProprety>(this HtmlHelper htmlHelper, Expression<Func<T, TProprety>> expression)
	{
		return htmlHelper.get_ViewData().get_TemplateInfo().GetFullHtmlFieldId(ExpressionHelper.GetExpressionText((LambdaExpression)expression));
	}

	public static string IDFor<T, TProprety>(this HtmlHelper<T> htmlHelper, Expression<Func<T, TProprety>> expression)
	{
		return ((ViewDataDictionary)htmlHelper.get_ViewData()).get_TemplateInfo().GetFullHtmlFieldId(ExpressionHelper.GetExpressionText((LambdaExpression)expression));
	}

	public static MvcHtmlString DropDownList(this HtmlHelper htmlHelper, string id, IEnumerable values, string valueField, string textField, object htmlAttributes = null, object selectedValue = null, string onChange = null)
	{
		return htmlHelper.DropDownList(id, values, valueField, textField, encode: true, htmlAttributes, selectedValue, onChange);
	}

	public static MvcHtmlString DropDownList(this HtmlHelper htmlHelper, string id, IEnumerable values, string valueField, string textField, bool encode, object htmlAttributes = null, object selectedValue = null, string onChange = null)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		DropDownListBuilder val = ((DropDownBuilderBase<DropDownList, DropDownListBuilder>)(object)((DropDownBuilderBase<DropDownList, DropDownListBuilder>)(object)((ViewComponentBuilderBase<DropDownList, DropDownListBuilder>)(object)HtmlHelperExtension.Telerik(htmlHelper).DropDownList()).Name(id)).Encode(encode)).BindTo((IEnumerable<SelectListItem>)new SelectList(values, valueField, textField, selectedValue));
		if (!string.IsNullOrEmpty(onChange))
		{
			((DropDownBuilderBase<DropDownList, DropDownListBuilder>)(object)val).ClientEvents((Action<DropDownClientEventsBuilder>)delegate(DropDownClientEventsBuilder e)
			{
				e.OnChange(onChange);
			});
		}
		if (htmlAttributes != null)
		{
			((ViewComponentBuilderBase<DropDownList, DropDownListBuilder>)(object)val).HtmlAttributes(htmlAttributes);
		}
		return MvcHtmlString.Create(((ViewComponentBuilderBase<DropDownList, DropDownListBuilder>)(object)val).ToHtmlString());
	}

	public static MvcHtmlString SwitchButton(this HtmlHelper htmlHelper, SwitchButtonModel model)
	{
		return PartialExtensions.Partial(htmlHelper, "UI/Buttons/SwitchButton", (object)model);
	}

	public static ButtonGroupBuilder Breadcrumbs(this HtmlHelper htmlHelper)
	{
		return htmlHelper.Breadcrumbs("");
	}

	public static ButtonGroupBuilder Breadcrumbs(this HtmlHelper htmlHelper, string uid)
	{
		return htmlHelper.ButtonGroup(uid).AsBreadcrumbs();
	}

	public static ActionButtonBuilder Button(this HtmlHelper htmlHelper)
	{
		return new ActionButtonBuilder(htmlHelper, new ActionButton());
	}

	public static ActionButtonBuilder Button(this HtmlHelper htmlHelper, ActionButton button)
	{
		return new ActionButtonBuilder(htmlHelper, button);
	}

	public static ActionButtonBuilder Button(this HtmlHelper htmlHelper, string icon, string text)
	{
		ActionButtonBuilder actionButtonBuilder = ((!string.IsNullOrWhiteSpace(text) || string.IsNullOrWhiteSpace(icon)) ? htmlHelper.Button().IconUrl(icon) : htmlHelper.ImageButton(icon));
		actionButtonBuilder.Text(text);
		return actionButtonBuilder;
	}

	public static ButtonGroupBuilder ButtonGroup(this HtmlHelper htmlHelper)
	{
		return htmlHelper.ButtonGroup("");
	}

	public static ButtonGroupBuilder ButtonGroup(this HtmlHelper htmlHelper, string uid)
	{
		return htmlHelper.ButtonGroup(new ActionButtonGroup(uid));
	}

	public static ButtonGroupBuilder ButtonGroup(this HtmlHelper htmlHelper, ActionButtonGroup group)
	{
		return new ButtonGroupBuilder(htmlHelper, group);
	}

	public static FilterButtonBuilder FilterButton(this HtmlHelper htmlHelper)
	{
		return new FilterButtonBuilder(htmlHelper, new ActionFilterButton());
	}

	public static MvcHtmlString ArrowButton(this HtmlHelper htmlHelper, string name, string arrowTagId, bool isOpen)
	{
		return htmlHelper.ArrowButton(MvcHtmlString.Create(name), arrowTagId, isOpen);
	}

	public static MvcHtmlString ArrowButton(this HtmlHelper htmlHelper, MvcHtmlString name, string arrowTagId, bool isOpen)
	{
		return PartialExtensions.Partial(htmlHelper, "Templates/ArrowButton", (object)new ArrowButtonModel
		{
			Name = name,
			ArrowTagId = arrowTagId,
			IsOpen = isOpen
		});
	}

	public static string ReturnUrl(this HtmlHelper htmlHelper, bool redirectHomeIfNull = false)
	{
		return htmlHelper.Url().ReturnUrl(redirectHomeIfNull);
	}

	public static MvcHtmlString ViewModuleSettings([NotNull] this HtmlHelper html, [NotNull] IGlobalSettingsModuleController module)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		if (module == null)
		{
			throw new ArgumentNullException("module");
		}
		if (!module.Visible)
		{
			return MvcHtmlString.Empty;
		}
		return PartialExtensions.Partial(html, "Templates/GlobalSettingsRenderView", (object)module);
	}

	public static MvcHtmlString RegisterImageBrowser(this HtmlHelper htmlHelper)
	{
		return PartialExtensions.Partial(htmlHelper, "UI/ImageBrowser/ImageBrowser");
	}

	public static MvcHtmlString ImageBrowser(this HtmlHelper htmlHelper, string name, string value, object htmlAtributes)
	{
		return PartialExtensions.Partial(htmlHelper, "UI/ImageBrowser/ImageBrowserInput", (object)new FileBrowserModel
		{
			Name = name,
			Attributes = htmlAtributes,
			Value = value
		});
	}

	public static MvcHtmlString ImageBrowserFor<T, TProprety>(this HtmlHelper<T> htmlHelper, Expression<Func<T, TProprety>> expression)
	{
		string expressionText = ExpressionHelper.GetExpressionText((LambdaExpression)expression);
		return htmlHelper.ImageBrowserFor(expression, (string)((ViewDataDictionary)htmlHelper.get_ViewData()).Eval(expressionText));
	}

	public static MvcHtmlString ImageBrowserFor<T, TProprety>(this HtmlHelper<T> htmlHelper, Expression<Func<T, TProprety>> expression, string value)
	{
		string expressionText = ExpressionHelper.GetExpressionText((LambdaExpression)expression);
		return PartialExtensions.Partial((HtmlHelper)(object)htmlHelper, "UI/ImageBrowser/ImageBrowserInput", (object)new FileBrowserModel
		{
			Name = expressionText,
			Attributes = null,
			Value = value
		});
	}

	public static MvcHtmlString HistoryItem(this HtmlHelper html, IHistoryBaseModel eventData, HistoryPartViewBlock extraBlock = null)
	{
		return PartialExtensions.Partial(html, "Templates/EntityActionHistoryItem", (object)new HistoryItemView
		{
			HistoryModel = eventData,
			ExtraBlock = extraBlock
		});
	}

	public static MvcHtmlString HistoryParts(this HtmlHelper html, IHistoryBaseModel eventData, HistoryPartViewBlock extraBlock = null, Func<object, object> defaultRenderAction = null)
	{
		eventData.ActionDate = eventData.ActionDate.ToClientDateTime();
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = false;
		IEnumerable<HistoryPartViewBlock> enumerable = Locator.GetServiceNotNull<IEnumerable<IHistoryPartProvider>>().SelectMany((IHistoryPartProvider pp) => pp.GetBlocks(html, eventData));
		if (extraBlock != null && !(eventData is SystemHistoryModel))
		{
			enumerable = enumerable.Union(new HistoryPartViewBlock[1] { extraBlock });
		}
		foreach (HistoryPartViewBlock item in enumerable.OrderBy((HistoryPartViewBlock b) => b.Index))
		{
			string value = ((HtmlString)(object)item.Render(html, eventData)).ToHtmlString();
			if (!string.IsNullOrEmpty(value))
			{
				stringBuilder.Append(value);
				flag = true;
			}
		}
		if (!flag && defaultRenderAction != null)
		{
			stringBuilder.Append(defaultRenderAction(eventData));
		}
		return MvcHtmlString.Create(stringBuilder.ToString());
	}

	public static FilterSearchFormBuilder<T> FilterSearchForm<T>(this HtmlHelper<T> html)
	{
		return new FilterSearchFormBuilder<T>(html);
	}

	public static ActionButton BinaryFileActionButton(string fileId, bool noPreview = false)
	{
		return new ActionButton
		{
			IconUrl = "#attachment.svg",
			Attributes = new
			{
				@class = "BinaryFilePreviewSelectorButton file-attachment-image",
				fileId = fileId,
				title = SR.T("Действия"),
				noPreview = noPreview,
				onmouseup = "elma.BinaryFilePreviewSelector.Click(this)"
			}
		};
	}

	public static MvcHtmlString HiddenId<T>(this HtmlHelper html, T id, string name, object htmlAttributes = null)
	{
		return InputExtensions.Hidden(html, $"{id}_{name}", (object)"", htmlAttributes);
	}

	public static MvcHtmlString SearchBox(this HtmlHelper html, string onKeyUpHandler)
	{
		return html.SearchBox(new SearchBoxModel
		{
			OnKeyUpHandler = onKeyUpHandler
		});
	}

	public static MvcHtmlString SearchBox(this HtmlHelper html, string onKeyUpHandler, object htmlAttributes)
	{
		return html.SearchBox(onKeyUpHandler, new RouteValueDictionary(htmlAttributes));
	}

	public static MvcHtmlString SearchBox(this HtmlHelper html, SearchBoxModel searchModel, object htmlAttributes = null)
	{
		RouteValueDictionary routeValueDictionary = ((htmlAttributes == null) ? new RouteValueDictionary() : new RouteValueDictionary(htmlAttributes));
		routeValueDictionary.Add("name", searchModel.Name);
		routeValueDictionary.Add("class", "text-box input-large");
		routeValueDictionary.Add("style", "width:100%;");
		routeValueDictionary.Add("placeholder", SR.T("Что искать?"));
		return html.SearchBox(searchModel.OnKeyUpHandler, routeValueDictionary);
	}

	public static MvcHtmlString SearchBox(this HtmlHelper html, string onKeyUpHandler, IDictionary<string, object> htmlAttributes)
	{
		if (htmlAttributes == null)
		{
			htmlAttributes = new RouteValueDictionary();
		}
		string text = (htmlAttributes.Keys.Contains("name") ? ((htmlAttributes["name"] ?? "input-Id") as string) : "input-Id");
		object obj = (htmlAttributes.Keys.Contains("value") ? (htmlAttributes["value"] ?? "") : "");
		IDictionary<string, object> dictionary = new RouteValueDictionary(htmlAttributes);
		if (!string.IsNullOrEmpty(onKeyUpHandler))
		{
			dictionary.Add("onkeyUp", onKeyUpHandler);
		}
		return InputExtensions.TextBox(html, text, obj, dictionary);
	}

	public static MvcHtmlString TextBoxWithIcon(this HtmlHelper html, string id, string value, MvcHtmlString image, object htmlAttributes = null, object textBoxHtmlAttributes = null)
	{
		return TextBoxWithIcon(InputExtensions.TextBox(html, id, (object)value, textBoxHtmlAttributes), image, htmlAttributes);
	}

	public static MvcHtmlString PasswordWithIcon(this HtmlHelper html, string id, string value, MvcHtmlString image, object htmlAttributes = null, object textBoxHtmlAttributes = null)
	{
		return TextBoxWithIcon(InputExtensions.Password(html, id, (object)value, textBoxHtmlAttributes), image, htmlAttributes);
	}

	private static MvcHtmlString TextBoxWithIcon(MvcHtmlString textbox, MvcHtmlString image, object htmlAttributes = null)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		TagBuilder val = new TagBuilder("div");
		val.MergeAttributes<string, object>((IDictionary<string, object>)new RouteValueDictionary(htmlAttributes));
		val.AddCssClass("text-box-with-image text-box");
		if (image == null)
		{
			val.set_InnerHtml(((object)textbox).ToString());
		}
		else
		{
			TagBuilder val2 = new TagBuilder("div");
			val2.AddCssClass("t-icon-wrapper");
			val2.set_InnerHtml(((object)image).ToString());
			val.set_InnerHtml(val2.ToString((TagRenderMode)0) + textbox);
		}
		return MvcHtmlString.Create(val.ToString((TagRenderMode)0));
	}

	public static IDictionary<string, object> ObjectToDictionary(object @object)
	{
		if (@object == null)
		{
			return new Dictionary<string, object>();
		}
		return @object.ToDictionary();
	}

	private static void RegisterHead(HtmlHelper htmlHelper, MvcHtmlString link, string src)
	{
		Func<object, object> action = (dynamic p) => htmlHelper.LinkCss(src);
		htmlHelper.RegisterContent("cssStyle-" + src, action, "Head");
	}
}
