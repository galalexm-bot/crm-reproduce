using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using Orchard.ContentManagement;
using Orchard.DisplayManagement;
using Orchard.DisplayManagement.Descriptors;
using Orchard.DisplayManagement.Descriptors.ResourceBindingStrategy;
using Orchard.DisplayManagement.Implementation;
using Orchard.Environment;
using Orchard.Localization;
using Orchard.Mvc;
using Orchard.Settings;
using Orchard.UI;
using Orchard.UI.Resources;
using Orchard.UI.Zones;
using Orchard.Utility.Extensions;

namespace Orchard.Core.Shapes;

public class CoreShapes : IShapeTableProvider, IDependency
{
	private class ViewDataContainer : IViewDataContainer
	{
		public ViewDataDictionary ViewData { get; set; }

		public ViewDataContainer(ViewDataDictionary viewData)
		{
			ViewData = viewData;
		}
	}

	private readonly Work<WorkContext> _workContext;

	private readonly Work<IResourceManager> _resourceManager;

	private readonly Work<IHttpContextAccessor> _httpContextAccessor;

	private readonly Work<IShapeFactory> _shapeFactory;

	public Localizer T { get; set; }

	public dynamic New => _shapeFactory.Value;

	public CoreShapes(Work<WorkContext> workContext, Work<IResourceManager> resourceManager, Work<IHttpContextAccessor> httpContextAccessor, Work<IShapeFactory> shapeFactory)
	{
		_workContext = workContext;
		_resourceManager = resourceManager;
		_httpContextAccessor = httpContextAccessor;
		_shapeFactory = shapeFactory;
		T = NullLocalizer.Instance;
	}

	public void Discover(ShapeTableBuilder builder)
	{
		builder.Describe("Layout").Configure(delegate(ShapeDescriptor descriptor)
		{
			descriptor.Wrappers.Add("Document");
		}).OnCreating(delegate(ShapeCreatingContext creating)
		{
			creating.Create = () => new ZoneHolding(() => creating.New.Zone());
		})
			.OnCreated(delegate(ShapeCreatedContext created)
			{
				object shape13 = created.Shape;
				((dynamic)shape13).Head = created.New.DocumentZone(ZoneName: "Head");
				((dynamic)shape13).Body = created.New.DocumentZone(ZoneName: "Body");
				((dynamic)shape13).Tail = created.New.DocumentZone(ZoneName: "Tail");
				((dynamic)shape13).Body.Add(created.New.PlaceChildContent(Source: (dynamic)shape13));
				((dynamic)shape13).Content = created.New.Zone();
				((dynamic)shape13).Content.ZoneName = "Content";
				((dynamic)shape13).Content.Add(created.New.PlaceChildContent(Source: (dynamic)shape13));
			});
		builder.Describe("Zone").OnCreating(delegate(ShapeCreatingContext creating)
		{
			creating.Create = () => new Zone();
		}).OnDisplaying(delegate(ShapeDisplayingContext displaying)
		{
			object shape12 = displaying.Shape;
			string text18 = ((dynamic)shape12).ZoneName;
			((dynamic)shape12).Classes.Add("zone-" + text18.HtmlClassify());
			((dynamic)shape12).Classes.Add("zone");
			((dynamic)shape12).Metadata.Alternates.Add("Zone__" + text18);
		});
		builder.Describe("Menu").OnDisplaying(delegate(ShapeDisplayingContext displaying)
		{
			object shape11 = displaying.Shape;
			string text17 = ((dynamic)shape11).MenuName;
			((dynamic)shape11).Classes.Add("menu-" + text17.HtmlClassify());
			((dynamic)shape11).Classes.Add("menu");
			((dynamic)shape11).Metadata.Alternates.Add("Menu__" + EncodeAlternateElement(text17));
		});
		builder.Describe("MenuItem").OnDisplaying(delegate(ShapeDisplayingContext displaying)
		{
			object shape10 = displaying.Shape;
			object obj8 = ((dynamic)shape10).Menu;
			int num2 = ((dynamic)shape10).Level;
			((dynamic)shape10).Metadata.Alternates.Add("MenuItem__level__" + num2);
			((dynamic)shape10).Metadata.Alternates.Add("MenuItem__" + EncodeAlternateElement(((dynamic)obj8).MenuName));
			((dynamic)shape10).Metadata.Alternates.Add("MenuItem__" + EncodeAlternateElement(((dynamic)obj8).MenuName) + "__level__" + num2);
		});
		builder.Describe("MenuItemLink").OnDisplaying(delegate(ShapeDisplayingContext displaying)
		{
			object shape9 = displaying.Shape;
			string alternateElement = ((dynamic)shape9).Menu.MenuName;
			string text16 = null;
			int num = ((dynamic)shape9).Level;
			if (((dynamic)shape9).Content != null)
			{
				text16 = ((IContent)((dynamic)shape9).Content).ContentItem.ContentType;
			}
			((dynamic)shape9).Metadata.Alternates.Add("MenuItemLink__level__" + num);
			if (text16 != null)
			{
				((dynamic)shape9).Metadata.Alternates.Add("MenuItemLink__" + EncodeAlternateElement(text16));
				((dynamic)shape9).Metadata.Alternates.Add("MenuItemLink__" + EncodeAlternateElement(text16) + "__level__" + num);
			}
			((dynamic)shape9).Metadata.Alternates.Add("MenuItemLink__" + EncodeAlternateElement(alternateElement));
			((dynamic)shape9).Metadata.Alternates.Add("MenuItemLink__" + EncodeAlternateElement(alternateElement) + "__level__" + num);
			if (text16 != null)
			{
				((dynamic)shape9).Metadata.Alternates.Add("MenuItemLink__" + EncodeAlternateElement(alternateElement) + "__" + EncodeAlternateElement(text16));
				((dynamic)shape9).Metadata.Alternates.Add("MenuItemLink__" + EncodeAlternateElement(alternateElement) + "__" + EncodeAlternateElement(text16) + "__level__" + num);
			}
		});
		builder.Describe("LocalMenu").OnDisplaying(delegate(ShapeDisplayingContext displaying)
		{
			object shape8 = displaying.Shape;
			string text15 = ((dynamic)shape8).MenuName;
			((dynamic)shape8).Classes.Add("localmenu-" + text15.HtmlClassify());
			((dynamic)shape8).Classes.Add("localmenu");
			((dynamic)shape8).Metadata.Alternates.Add("LocalMenu__" + EncodeAlternateElement(text15));
		});
		builder.Describe("LocalMenuItem").OnDisplaying(delegate(ShapeDisplayingContext displaying)
		{
			object shape7 = displaying.Shape;
			object obj7 = ((dynamic)shape7).Menu;
			((dynamic)shape7).Metadata.Alternates.Add("LocalMenuItem__" + EncodeAlternateElement(((dynamic)obj7).MenuName));
		});
		builder.Describe("Pager").OnDisplaying(delegate(ShapeDisplayingContext displaying)
		{
			object shape6 = displaying.Shape;
			string text14 = ((dynamic)shape6).PagerId;
			if (!string.IsNullOrWhiteSpace(text14))
			{
				displaying.Shape.Metadata.Alternates.Add("Pager__" + EncodeAlternateElement(text14));
			}
		});
		builder.Describe("Pager_Gap").OnDisplaying(delegate(ShapeDisplayingContext displaying)
		{
			object obj6 = displaying.Shape.Pager;
			string text13 = ((dynamic)obj6).PagerId;
			if (!string.IsNullOrWhiteSpace(text13))
			{
				((dynamic)obj6).Metadata.Alternates.Add("Pager_Gap__" + EncodeAlternateElement(text13));
			}
		});
		builder.Describe("Pager_First").OnDisplaying(delegate(ShapeDisplayingContext displaying)
		{
			object obj5 = displaying.Shape.Pager;
			string text12 = ((dynamic)obj5).PagerId;
			if (!string.IsNullOrWhiteSpace(text12))
			{
				displaying.Shape.Metadata.Alternates.Add("Pager_First__" + EncodeAlternateElement(text12));
			}
		});
		builder.Describe("Pager_Previous").OnDisplaying(delegate(ShapeDisplayingContext displaying)
		{
			object obj4 = displaying.Shape.Pager;
			string text11 = ((dynamic)obj4).PagerId;
			if (!string.IsNullOrWhiteSpace(text11))
			{
				displaying.Shape.Metadata.Alternates.Add("Pager_Previous__" + EncodeAlternateElement(text11));
			}
		});
		builder.Describe("Pager_Next").OnDisplaying(delegate(ShapeDisplayingContext displaying)
		{
			object obj3 = displaying.Shape.Pager;
			string text10 = ((dynamic)obj3).PagerId;
			if (!string.IsNullOrWhiteSpace(text10))
			{
				displaying.Shape.Metadata.Alternates.Add("Pager_Next__" + EncodeAlternateElement(text10));
			}
		});
		builder.Describe("Pager_Last").OnDisplaying(delegate(ShapeDisplayingContext displaying)
		{
			object obj2 = displaying.Shape.Pager;
			string text9 = ((dynamic)obj2).PagerId;
			if (!string.IsNullOrWhiteSpace(text9))
			{
				displaying.Shape.Metadata.Alternates.Add("Pager_Last__" + EncodeAlternateElement(text9));
			}
		});
		builder.Describe("Pager_CurrentPage").OnDisplaying(delegate(ShapeDisplayingContext displaying)
		{
			object obj = displaying.Shape.Pager;
			string text8 = ((dynamic)obj).PagerId;
			if (!string.IsNullOrWhiteSpace(text8))
			{
				displaying.Shape.Metadata.Alternates.Add("Pager_CurrentPage__" + EncodeAlternateElement(text8));
			}
		});
		builder.Describe("Pager_Links").OnDisplaying(delegate(ShapeDisplayingContext displaying)
		{
			object shape5 = displaying.Shape;
			string text7 = ((dynamic)shape5).PagerId;
			if (!string.IsNullOrWhiteSpace(text7))
			{
				displaying.Shape.Metadata.Alternates.Add("Pager_Links__" + EncodeAlternateElement(text7));
			}
		});
		builder.Describe("List").OnCreated(delegate(ShapeCreatedContext created)
		{
			object shape4 = created.Shape;
			((dynamic)shape4).Tag = "ul";
			((dynamic)shape4).ItemClasses = new List<string>();
			((dynamic)shape4).ItemAttributes = new Dictionary<string, string>();
		});
		builder.Describe("Style").OnDisplaying(delegate(ShapeDisplayingContext displaying)
		{
			object shape3 = displaying.Shape;
			string text5 = ((dynamic)shape3).Url;
			string text6 = ((text5 != null) ? StaticFileBindingStrategy.GetAlternateShapeNameFromFileName(text5) : null);
			if (!string.IsNullOrEmpty(text6))
			{
				((dynamic)shape3).Metadata.Alternates.Add("Style__" + text6);
			}
		});
		builder.Describe("Script").OnDisplaying(delegate(ShapeDisplayingContext displaying)
		{
			object shape2 = displaying.Shape;
			string text3 = ((dynamic)shape2).Url;
			string text4 = ((text3 != null) ? StaticFileBindingStrategy.GetAlternateShapeNameFromFileName(text3) : null);
			if (!string.IsNullOrEmpty(text4))
			{
				((dynamic)shape2).Metadata.Alternates.Add("Script__" + text4);
			}
		});
		builder.Describe("Resource").OnDisplaying(delegate(ShapeDisplayingContext displaying)
		{
			object shape = displaying.Shape;
			string text = ((dynamic)shape).Url;
			string text2 = ((text != null) ? StaticFileBindingStrategy.GetAlternateShapeNameFromFileName(text) : null);
			if (!string.IsNullOrEmpty(text2))
			{
				((dynamic)shape).Metadata.Alternates.Add("Resource__" + text2);
			}
		});
	}

	private static TagBuilder GetTagBuilder(string tagName, string id, IEnumerable<string> classes, IDictionary<string, string> attributes)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		TagBuilder val = new TagBuilder(tagName);
		val.MergeAttributes<string, string>(attributes, false);
		foreach (string item in classes ?? Enumerable.Empty<string>())
		{
			val.AddCssClass(item);
		}
		if (!string.IsNullOrWhiteSpace(id))
		{
			val.GenerateId(id);
		}
		return val;
	}

	[Shape]
	public void Zone(dynamic Display, dynamic Shape, TextWriter Output)
	{
		string id = Shape.Id;
		IEnumerable<string> classes = Shape.Classes;
		IDictionary<string, string> attributes = Shape.Attributes;
		TagBuilder tagBuilder = GetTagBuilder("div", id, classes, attributes);
		Output.Write(tagBuilder.ToString((TagRenderMode)1));
		foreach (dynamic item in Order(Shape))
		{
			Output.Write(Display(item));
		}
		Output.Write(tagBuilder.ToString((TagRenderMode)2));
	}

	[Shape]
	public void ContentZone(dynamic Display, dynamic Shape, TextWriter Output)
	{
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		object[] array = ((IEnumerable<object>)Shape).ToArray();
		IEnumerable<IGrouping<string, object>> enumerable = from x in array
			group x by (string)x.Metadata.Tab;
		if (enumerable.Count() > 1)
		{
			foreach (IGrouping<string, object> item in enumerable)
			{
				string text = (string.IsNullOrWhiteSpace(item.Key) ? "Content" : item.Key);
				TagBuilder val = new TagBuilder("div");
				val.get_Attributes()["id"] = "tab-" + text.HtmlClassify();
				val.get_Attributes()["data-tab"] = text;
				Output.Write(val.ToString((TagRenderMode)1));
				foreach (dynamic item2 in Order(item))
				{
					Output.Write(Display(item2));
				}
				Output.Write(val.ToString((TagRenderMode)2));
			}
			return;
		}
		foreach (dynamic item3 in Order(array))
		{
			Output.Write(Display(item3));
		}
	}

	[Shape]
	public void DocumentZone(dynamic Display, dynamic Shape, TextWriter Output)
	{
		foreach (dynamic item in Order(Shape))
		{
			Output.Write(Display(item));
		}
	}

	public static IEnumerable<dynamic> Order(dynamic shape)
	{
		IEnumerable<object> enumerable = shape;
		if (enumerable == null || enumerable.Count() < 2)
		{
			return shape;
		}
		int num = 1;
		int num2 = 1;
		FlatPositionComparer flatPositionComparer = new FlatPositionComparer();
		var list = enumerable.Select(delegate(dynamic item)
		{
			string position = null;
			if (item is IPositioned positioned)
			{
				position = positioned.Position;
			}
			return new
			{
				item = (object)item,
				position = position
			};
		}).ToList();
		while (num < list.Count())
		{
			if (flatPositionComparer.Compare(list[num].position, list[num - 1].position) > -1)
			{
				if (num == num2)
				{
					num2 = ++num;
				}
				else
				{
					num = num2;
				}
				continue;
			}
			var value = list[num];
			list[num] = list[num - 1];
			list[num - 1] = value;
			if (num > 1)
			{
				num--;
			}
		}
		return list.Select(ordered => ordered.item).ToList();
	}

	public static IEnumerable<string> HarvestAndSortTabs(IEnumerable<dynamic> shapes)
	{
		dynamic[] array = Order(shapes).ToArray();
		List<string> list = new List<string>();
		object[] array2 = array;
		foreach (dynamic val in array2)
		{
			string text = (string)val.Metadata.Tab;
			if (!string.IsNullOrEmpty(text) && !list.Contains(text))
			{
				list.Add(text);
			}
		}
		if (list.Any())
		{
			list.Remove("Content");
			list.Insert(0, "Content");
		}
		return list;
	}

	[Shape]
	public void HeadScripts(dynamic Display, TextWriter Output)
	{
		WriteResources(Display, Output, "script", ResourceLocation.Head, null);
		WriteLiteralScripts(Output, _resourceManager.Value.GetRegisteredHeadScripts());
	}

	[Shape]
	public void FootScripts(dynamic Display, TextWriter Output)
	{
		WriteResources(Display, Output, "script", null, ResourceLocation.Head);
		WriteLiteralScripts(Output, _resourceManager.Value.GetRegisteredFootScripts());
	}

	[Shape]
	public void Metas(TextWriter Output)
	{
		foreach (MetaEntry registeredMeta in _resourceManager.Value.GetRegisteredMetas())
		{
			Output.WriteLine(registeredMeta.GetTag());
		}
	}

	[Shape]
	public void HeadLinks(TextWriter Output)
	{
		foreach (LinkEntry registeredLink in _resourceManager.Value.GetRegisteredLinks())
		{
			Output.WriteLine(registeredLink.GetTag());
		}
	}

	[Shape]
	public void StylesheetLinks(dynamic Display, TextWriter Output)
	{
		WriteResources(Display, Output, "stylesheet", null, null);
	}

	[Shape]
	public void Style(dynamic Display, HtmlHelper Html, TextWriter Output, ResourceDefinition Resource, string Url, string Condition, Dictionary<string, string> TagAttributes)
	{
		ResourceManager.WriteResource(Html.get_ViewContext().get_Writer(), Resource, Url, Condition, TagAttributes);
	}

	[Shape]
	public void Script(HtmlHelper Html, TextWriter Output, ResourceDefinition Resource, string Url, string Condition, Dictionary<string, string> TagAttributes)
	{
		ResourceManager.WriteResource(Html.get_ViewContext().get_Writer(), Resource, Url, Condition, TagAttributes);
	}

	[Shape]
	public void Resource(TextWriter Output, ResourceDefinition Resource, string Url, string Condition, Dictionary<string, string> TagAttributes)
	{
		ResourceManager.WriteResource(Output, Resource, Url, Condition, TagAttributes);
	}

	private static void WriteLiteralScripts(TextWriter output, IEnumerable<string> scripts)
	{
		if (scripts == null)
		{
			return;
		}
		foreach (string script in scripts)
		{
			output.WriteLine(script);
		}
	}

	private void WriteResources(dynamic Display, TextWriter Output, string resourceType, ResourceLocation? includeLocation, ResourceLocation? excludeLocation)
	{
		ISite currentSite = _workContext.Value.CurrentSite;
		bool debugMode = currentSite.ResourceDebugMode switch
		{
			ResourceDebugMode.Enabled => true, 
			ResourceDebugMode.Disabled => false, 
			_ => _httpContextAccessor.Value.Current()?.IsDebuggingEnabled ?? false, 
		};
		RequireSettings baseSettings = new RequireSettings
		{
			DebugMode = debugMode,
			CdnMode = currentSite.UseCdn,
			Culture = _workContext.Value.CurrentCulture
		};
		IList<ResourceRequiredContext> source = _resourceManager.Value.BuildRequiredResources(resourceType);
		HttpContextBase httpContextBase = _httpContextAccessor.Value.Current();
		string appPath = ((httpContextBase == null || httpContextBase.Request == null) ? null : httpContextBase.Request.ApplicationPath);
		bool ssl = httpContextBase?.Request?.IsSecureConnection ?? false;
		foreach (ResourceRequiredContext item in source.Where((ResourceRequiredContext r) => (!includeLocation.HasValue || r.Settings.Location == includeLocation.Value) && (!excludeLocation.HasValue || r.Settings.Location != excludeLocation.Value)))
		{
			string resourceUrl = item.GetResourceUrl(baseSettings, appPath, ssl);
			string condition = item.Settings.Condition;
			Dictionary<string, string> dictionary = (item.Settings.HasAttributes ? item.Settings.Attributes : null);
			IHtmlString value = ((!(resourceType == "stylesheet")) ? ((!(resourceType == "script")) ? ((IHtmlString)Display.Resource(Url: resourceUrl, Condition: condition, Resource: item.Resource, TagAttributes: dictionary)) : ((IHtmlString)Display.Script(Url: resourceUrl, Condition: condition, Resource: item.Resource, TagAttributes: dictionary))) : ((IHtmlString)Display.Style(Url: resourceUrl, Condition: condition, Resource: item.Resource, TagAttributes: dictionary)));
			Output.Write(value);
		}
	}

	[Shape]
	public IHtmlString Pager_Links(dynamic Shape, dynamic Display, HtmlHelper Html, int Page, int PageSize, double TotalItemCount, int? Quantity, object FirstText, object PreviousText, object NextText, object LastText, object GapText, string PagerId)
	{
		int num = Page;
		if (num < 1)
		{
			num = 1;
		}
		int num2 = Quantity ?? 0;
		if (!Quantity.HasValue || Quantity < 0)
		{
			num2 = 7;
		}
		int num3 = ((PageSize <= 0) ? 1 : ((int)Math.Ceiling(TotalItemCount / (double)PageSize)));
		object obj = FirstText ?? T("&lt;&lt;");
		object obj2 = PreviousText ?? T("&lt;");
		object obj3 = NextText ?? T("&gt;");
		object obj4 = LastText ?? T("&gt;&gt;");
		object obj5 = GapText ?? T("...");
		RouteValueDictionary routeData = new RouteValueDictionary(((ControllerContext)Html.get_ViewContext()).get_RouteData().Values);
		NameValueCollection queryString = _workContext.Value.HttpContext.Request.QueryString;
		if (queryString != null)
		{
			foreach (string item in from string key in queryString.Keys
				where key != null && !routeData.ContainsKey(key)
				let value = queryString[key]
				select key)
			{
				routeData[item] = queryString[item];
			}
		}
		object obj6 = Shape.RouteData;
		if (obj6 != null)
		{
			RouteValueDictionary routeValueDictionary = obj6 as RouteValueDictionary;
			if (routeValueDictionary == null && obj6 is RouteData routeData2)
			{
				routeValueDictionary = routeData2.Values;
			}
			if (routeValueDictionary != null)
			{
				foreach (KeyValuePair<string, object> item2 in routeValueDictionary)
				{
					routeData[item2.Key] = item2.Value;
				}
			}
		}
		foreach (string item3 in routeData.Keys.Where((string key) => routeData[key] is DictionaryValueProvider<object>).ToList())
		{
			routeData.Remove(item3);
		}
		int num4 = Math.Max(1, Page - num2 / 2);
		int num5 = Math.Min(num3, Page + num2 / 2);
		string key2 = (string.IsNullOrEmpty(PagerId) ? "page" : PagerId);
		Shape.Classes.Add("pager");
		Shape.Metadata.Alternates.Clear();
		Shape.Metadata.Type = "List";
		if (Page > 1)
		{
			if (routeData.ContainsKey(key2))
			{
				routeData.Remove(key2);
			}
			Shape.Add(New.Pager_First(Value: obj, RouteValues: new RouteValueDictionary(routeData), Pager: Shape));
			if (num > 2)
			{
				routeData[key2] = num - 1;
			}
			Shape.Add(New.Pager_Previous(Value: obj2, RouteValues: new RouteValueDictionary(routeData), Pager: Shape));
		}
		if (num4 > 1 && num2 > 0)
		{
			Shape.Add(New.Pager_Gap(Value: obj5, Pager: Shape));
		}
		if (num2 > 0 && num5 > 1)
		{
			for (int i = num4; i <= num5; i++)
			{
				if (i == num)
				{
					Shape.Add(New.Pager_CurrentPage(Value: i, RouteValues: new RouteValueDictionary(routeData), Pager: Shape));
					continue;
				}
				if (i == 1)
				{
					routeData.Remove(key2);
				}
				else
				{
					routeData[key2] = i;
				}
				Shape.Add(New.Pager_Link(Value: i, RouteValues: new RouteValueDictionary(routeData), Pager: Shape));
			}
		}
		if (num5 < num3 && num2 > 0)
		{
			Shape.Add(New.Pager_Gap(Value: obj5, Pager: Shape));
		}
		if (Page < num3)
		{
			routeData[key2] = Page + 1;
			Shape.Add(New.Pager_Next(Value: obj3, RouteValues: new RouteValueDictionary(routeData), Pager: Shape));
			routeData[key2] = num3;
			Shape.Add(New.Pager_Last(Value: obj4, RouteValues: new RouteValueDictionary(routeData), Pager: Shape));
		}
		return Display(Shape);
	}

	[Shape]
	public IHtmlString Pager(dynamic Shape, dynamic Display)
	{
		Shape.Metadata.Alternates.Clear();
		Shape.Metadata.Type = "Pager_Links";
		return Display(Shape);
	}

	[Shape]
	public IHtmlString Pager_First(dynamic Shape, dynamic Display)
	{
		Shape.Metadata.Alternates.Clear();
		Shape.Metadata.Type = "Pager_Link";
		return Display(Shape);
	}

	[Shape]
	public IHtmlString Pager_Previous(dynamic Shape, dynamic Display)
	{
		Shape.Metadata.Alternates.Clear();
		Shape.Metadata.Type = "Pager_Link";
		return Display(Shape);
	}

	[Shape]
	public IHtmlString Pager_CurrentPage(HtmlHelper Html, dynamic Display, object Value)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		TagBuilder val = new TagBuilder("span");
		val.set_InnerHtml((string)EncodeOrDisplay(Value, Display, Html).ToString());
		return (IHtmlString)MvcHtmlString.Create(((object)val).ToString());
	}

	[Shape]
	public IHtmlString Pager_Next(dynamic Shape, dynamic Display)
	{
		Shape.Metadata.Alternates.Clear();
		Shape.Metadata.Type = "Pager_Link";
		return Display(Shape);
	}

	[Shape]
	public IHtmlString Pager_Last(dynamic Shape, dynamic Display)
	{
		Shape.Metadata.Alternates.Clear();
		Shape.Metadata.Type = "Pager_Link";
		return Display(Shape);
	}

	[Shape]
	public IHtmlString Pager_Link(HtmlHelper Html, dynamic Shape, dynamic Display, object Value)
	{
		Shape.Metadata.Alternates.Clear();
		Shape.Metadata.Type = "ActionLink";
		return Display(Shape);
	}

	[Shape]
	public IHtmlString ActionLink(HtmlHelper Html, UrlHelper Url, dynamic Shape, dynamic Display, object Value)
	{
		object obj = Shape.RouteValues;
		RouteValueDictionary routeValueDictionary = ((obj != null) ? ((obj is RouteValueDictionary) ? ((RouteValueDictionary)obj) : new RouteValueDictionary(obj)) : new RouteValueDictionary());
		string value = Url.Action((string)routeValueDictionary["action"], (string)routeValueDictionary["controller"], routeValueDictionary);
		IEnumerable<string> classes = Shape.Classes;
		IDictionary<string, string> dictionary = Shape.Attributes;
		dictionary["href"] = value;
		string id = Shape.Id;
		TagBuilder tagBuilder = GetTagBuilder("a", id, classes, dictionary);
		tagBuilder.set_InnerHtml((string)EncodeOrDisplay(Value, Display, Html).ToString());
		return Html.Raw(((object)tagBuilder).ToString());
	}

	[Shape]
	public IHtmlString Pager_Gap(HtmlHelper Html, dynamic Display, object Value)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		TagBuilder val = new TagBuilder("span");
		val.set_InnerHtml((string)EncodeOrDisplay(Value, Display, Html).ToString());
		return (IHtmlString)MvcHtmlString.Create(((object)val).ToString());
	}

	[Shape]
	public void List(dynamic Display, TextWriter Output, IEnumerable<dynamic> Items, string Tag, string Id, IEnumerable<string> Classes, IDictionary<string, string> Attributes, string ItemTag, IEnumerable<string> ItemClasses, IDictionary<string, string> ItemAttributes)
	{
		if (Items == null)
		{
			return;
		}
		List<object> list = Items.ToList();
		int num = list.Count();
		if (num < 1)
		{
			return;
		}
		string text = null;
		if (Tag != "-")
		{
			text = (string.IsNullOrEmpty(Tag) ? "ul" : Tag);
		}
		TagBuilder val = (string.IsNullOrEmpty(text) ? null : GetTagBuilder(text, Id, Classes, Attributes));
		string text2 = null;
		if (ItemTag != "-")
		{
			text2 = (string.IsNullOrEmpty(ItemTag) ? "li" : ItemTag);
		}
		if (val != null)
		{
			Output.Write(val.ToString((TagRenderMode)1));
		}
		List<TagBuilder> list2 = new List<TagBuilder>();
		List<string> list3 = new List<string>();
		int num2 = 0;
		foreach (dynamic item in list)
		{
			TagBuilder val2 = (string.IsNullOrEmpty(text2) ? null : GetTagBuilder(text2, null, ItemClasses, ItemAttributes));
			if (item is IShape)
			{
				item.Tag = val2;
			}
			dynamic val3 = Display(item).ToHtmlString();
			if ((!string.IsNullOrWhiteSpace(val3)))
			{
				list2.Add(val2);
				list3.Add(val3);
			}
			else
			{
				num--;
			}
			num2++;
		}
		num2 = 0;
		foreach (string item2 in list3)
		{
			TagBuilder val4 = list2[num2];
			if (val4 != null)
			{
				if (num2 == 0)
				{
					val4.AddCssClass("first");
				}
				if (num2 == num - 1)
				{
					val4.AddCssClass("last");
				}
				Output.Write(val4.ToString((TagRenderMode)1));
			}
			Output.Write(item2);
			if (val4 != null)
			{
				Output.WriteLine(val4.ToString((TagRenderMode)2));
			}
			num2++;
		}
		if (val != null)
		{
			Output.WriteLine(val.ToString((TagRenderMode)2));
		}
	}

	[Shape]
	public IHtmlString PlaceChildContent(dynamic Source)
	{
		return Source.Metadata.ChildContent;
	}

	[Shape]
	public void Partial(HtmlHelper Html, TextWriter Output, string TemplateName, object Model, string Prefix)
	{
		RenderInternal(Html, Output, TemplateName, Model, Prefix);
	}

	[Shape]
	public void DisplayTemplate(HtmlHelper Html, TextWriter Output, string TemplateName, object Model, string Prefix)
	{
		RenderInternal(Html, Output, "DisplayTemplates/" + TemplateName, Model, Prefix);
	}

	[Shape]
	public void EditorTemplate(HtmlHelper Html, TextWriter Output, string TemplateName, object Model, string Prefix)
	{
		RenderInternal(Html, Output, "EditorTemplates/" + TemplateName, Model, Prefix);
	}

	[Shape]
	public void DefinitionTemplate(HtmlHelper Html, TextWriter Output, string TemplateName, object Model, string Prefix)
	{
		RenderInternal(Html, Output, "DefinitionTemplates/" + TemplateName, Model, Prefix);
	}

	private static void RenderInternal(HtmlHelper Html, TextWriter Output, string TemplateName, object Model, string Prefix)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0037: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		ViewDataDictionary val = new ViewDataDictionary(Html.get_ViewDataContainer().get_ViewData());
		val.set_Model(DetermineModel(Html, Model));
		TemplateInfo val2 = new TemplateInfo();
		val2.set_HtmlFieldPrefix(DeterminePrefix(Html, Prefix));
		val.set_TemplateInfo(val2);
		ViewDataDictionary val3 = val;
		RenderPartialExtensions.RenderPartial(new HtmlHelper(new ViewContext((ControllerContext)(object)Html.get_ViewContext(), Html.get_ViewContext().get_View(), val3, Html.get_ViewContext().get_TempData(), Output), (IViewDataContainer)(object)new ViewDataContainer(val3)), TemplateName);
	}

	private static object DetermineModel(HtmlHelper Html, object Model)
	{
		if (!(bool)((dynamic)Model == null))
		{
			return Model;
		}
		return Html.get_ViewData().get_Model();
	}

	private static string DeterminePrefix(HtmlHelper Html, string Prefix)
	{
		if (!string.IsNullOrEmpty(Prefix))
		{
			return Html.get_ViewContext().get_ViewData().get_TemplateInfo()
				.GetFullHtmlFieldName(Prefix);
		}
		return Html.get_ViewContext().get_ViewData().get_TemplateInfo()
			.get_HtmlFieldPrefix();
	}

	private string EncodeAlternateElement(string alternateElement)
	{
		return alternateElement.Replace("-", "__").Replace(".", "_");
	}

	private IHtmlString EncodeOrDisplay(dynamic Value, dynamic Display, HtmlHelper Html)
	{
		if (!(Value is IHtmlString))
		{
			if (!(Value is IShape))
			{
				return Html.Raw(Html.Encode(Value.ToString()));
			}
			return Display(Value).ToString();
		}
		return Value;
	}
}
