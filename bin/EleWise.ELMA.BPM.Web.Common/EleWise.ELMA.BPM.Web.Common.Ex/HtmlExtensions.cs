using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Enums;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html.Buttons;
using EleWise.ELMA.Web.Mvc.Html.Grids;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Models.Panels;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

public static class HtmlExtensions
{
	public static MvcHtmlString EntityInfo(this HtmlHelper htmlHelper, IEntity entity)
	{
		return htmlHelper.EntityInfo(entity, null);
	}

	public static MvcHtmlString EntityInfo(this HtmlHelper htmlHelper, IEntity entity, string url, string defaultTitle = "", string target = "")
	{
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		if (entity == null)
		{
			return MvcHtmlString.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		IEnumerable<IEntityInfoExtension> extensionPoints = ComponentManager.Current.GetExtensionPoints<IEntityInfoExtension>();
		if (extensionPoints == null || !extensionPoints.Any())
		{
			stringBuilder.Append(((object)htmlHelper.EntityInfoDefault(entity, url, defaultTitle)).ToString());
		}
		else
		{
			Dictionary<IEntityInfoExtension, int> dictionary = new Dictionary<IEntityInfoExtension, int>();
			Type type = entity.GetType();
			int num = 0;
			do
			{
				Guid entityUid = InterfaceActivator.UID(type);
				foreach (IEntityInfoExtension item in extensionPoints.Where((IEntityInfoExtension e) => e.EntityUid == entityUid))
				{
					if (dictionary.ContainsKey(item))
					{
						dictionary[item] = num;
					}
					else
					{
						dictionary.Add(item, num);
					}
				}
				num++;
				type = type.BaseType;
			}
			while (type != null);
			stringBuilder.Append(((object)((dictionary.Count == 0) ? htmlHelper.EntityInfoDefault(entity, url, defaultTitle) : (from e in dictionary
				orderby e.Value
				select e.Key).First().EntityInfo(htmlHelper, entity, url, defaultTitle))).ToString());
		}
		IWorkLogEntityInfoLinkDescription workLogEntityInfoLinkDescription = ComponentManager.Current.GetExtensionPoints<IWorkLogEntityInfoLinkDescription>().FirstOrDefault((IWorkLogEntityInfoLinkDescription e) => e.CheckType(entity));
		if (workLogEntityInfoLinkDescription != null)
		{
			string text = ((object)workLogEntityInfoLinkDescription.Description(htmlHelper, entity)).ToString();
			if (!string.IsNullOrWhiteSpace(text))
			{
				stringBuilder.Append($"<br />{text}");
			}
		}
		return new MvcHtmlString(string.IsNullOrEmpty(target) ? stringBuilder.ToString() : SetTargetBlankForLink(stringBuilder.ToString(), target));
	}

	private static MvcHtmlString EntityInfoDefault(this HtmlHelper htmlHelper, IEntity entity, string url, string defaultTitle)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		if (entity == null)
		{
			return MvcHtmlString.Empty;
		}
		string text = entity.ToString();
		if (string.IsNullOrEmpty(text))
		{
			text = defaultTitle ?? "";
		}
		TagBuilder val = new TagBuilder("a");
		val.MergeAttribute("href", string.IsNullOrEmpty(url) ? htmlHelper.Url().Entity(entity) : url, true);
		val.SetInnerText(text);
		string text2 = val.ToString((TagRenderMode)0);
		IMetadataRuntimeService service = Locator.GetService<IMetadataRuntimeService>();
		Guid metadataUid = InterfaceActivator.UID(entity.GetType());
		NamedMetadata namedMetadata = (NamedMetadata)service.GetMetadata(metadataUid);
		if (namedMetadata != null && !string.IsNullOrEmpty(namedMetadata.DisplayName))
		{
			TagBuilder val2 = new TagBuilder("span");
			val2.get_Attributes().Add("style", "color: Grey");
			val2.set_InnerHtml(namedMetadata.DisplayName);
			text2 = text2 + "<br />" + val2.ToString((TagRenderMode)0);
		}
		return new MvcHtmlString(text2);
	}

	private static string SetTargetBlankForLink(string htmlString, string target = "_blank")
	{
		return Regex.Replace(htmlString, "<a.*?>\\s*(.*?)\\s*</a>", delegate(Match link)
		{
			string text = link.Value;
			if (text.ToLower().IndexOf("target") == -1)
			{
				text = $"<a target=\"{target}\"{text.Substring(2)}";
			}
			return text;
		});
	}

	public static MvcHtmlString EventHistory([NotNull] this HtmlHelper html, [NotNull] IEntity<long> entity, bool inTab = false, string divPanelId = null, List<string> disableButtons = null, bool asyncLoading = true, List<string> hideButtons = null)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		Guid objectUid = InterfaceActivator.UID(entity.CastAsRealType().GetType());
		return PartialExtensions.Partial(html, "EntityHistoryPanel", (object)new EntityHistoryPanelViewModel
		{
			ObjectUid = objectUid,
			DivId = ((!string.IsNullOrEmpty(divPanelId)) ? divPanelId : $"eh_{TagBuilder.CreateSanitizedId(entity.Implementation().GetType().FullName)}_{entity.Id}"),
			InTab = inTab,
			Entity = entity,
			DisableButtons = disableButtons,
			AsyncLoading = asyncLoading,
			HideButtons = hideButtons
		});
	}

	public static MvcHtmlString EventHistoryWithComment([NotNull] this HtmlHelper html, [NotNull] EventHistoryCommentViewModel model)
	{
		Contract.NotNull(model.Entity, "Entity");
		IMetadata metadata = MetadataLoader.LoadMetadata(model.Entity.GetType());
		if (metadata != null)
		{
			model.ObjectUid = metadata.Uid;
			if (model.DivId.IsNullOrWhiteSpace())
			{
				Type type = metadata.Implementation().GetType();
				model.DivId = $"eh_{TagBuilder.CreateSanitizedId(type.FullName)}_{model.Entity.Id}";
			}
		}
		return PartialExtensions.Partial(html, "EntityHistoryWithCommentPanel", (object)model);
	}

	public static MvcHtmlString EventHistoryWithComment([NotNull] this HtmlHelper html, [NotNull] IEntity<long> entity, Guid commentActionUid)
	{
		return html.EventHistoryWithComment(new EventHistoryCommentViewModel
		{
			Entity = entity,
			AddCommentActionUid = commentActionUid
		});
	}

	public static MvcHtmlString EventHistoryWithComment([NotNull] this HtmlHelper html, [NotNull] IEntity<long> entity, Guid commentActionUid, string redirectUrl)
	{
		return html.EventHistoryWithComment(new EventHistoryCommentViewModel
		{
			Entity = entity,
			RedirectUrl = redirectUrl,
			AddCommentActionUid = commentActionUid
		});
	}

	public static MvcHtmlString PropertySelector([NotNull] this HtmlHelper html, [NotNull] PropertySelectorInfo model)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		if (model == null)
		{
			throw new ArgumentNullException("model");
		}
		return html.PopupWindow(new Popup
		{
			PopupId = model.PopupId,
			PopupHeader = SR.T("Выберите свойство"),
			ActionUrl = html.Url().Action("PropertySelector", "Entity", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Common",
				objectType = model.ObjectType.AssemblyQualifiedName,
				popupId = model.PopupId
			})
		});
	}

	[CreatorForm]
	public static MvcHtmlString Explorer(this HtmlHelper html, string popupId, string inputId, Guid typeUid, bool showOnlyGroups, string filterProviderUid = null, string filterProviderData = null, int width = 0, bool multiSelect = false, string chooseHandler = null)
	{
		return html.PopupWindow(new Popup
		{
			PopupId = popupId,
			PopupHeader = SR.T("Выберите элемент"),
			ActionUrl = html.ExplorerUrl(popupId, inputId, typeUid, showOnlyGroups, filterProviderUid, filterProviderData, multiSelect, chooseHandler),
			Width = width
		});
	}

	[CreatorForm]
	public static string ExplorerUrl(this HtmlHelper html, string popupId, string inputId, Guid typeUid, bool showOnlyGroups, string filterProviderUid = null, string filterProviderData = null, bool multiSelect = false, string chooseHandler = null)
	{
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary
		{
			{ "area", "EleWise.ELMA.BPM.Web.Common" },
			{ "typeUid", typeUid },
			{ "inputId", inputId },
			{ "showOnlyGroups", showOnlyGroups },
			{ "filterProviderUid", filterProviderUid },
			{ "filterProviderData", filterProviderData },
			{ "multiSelect", multiSelect },
			{ "chooseHandler", chooseHandler }
		};
		return html.Url().Action("Explorer", "Entity", routeValueDictionary);
	}

	public static MvcHtmlString FilterEditButton(this HtmlHelper html, FilterEditButtonModel model)
	{
		return PartialExtensions.Partial(html, "Filter/FilterEditButton", (object)model);
	}

	public static GridDataFilter<TModel> CreateGridData<TModel>([NotNull] this IEntityManager manager, GridCommand command, FilterModel filter) where TModel : IEntity
	{
		if (manager == null)
		{
			throw new ArgumentNullException("manager");
		}
		GridDataFilter<TModel> gridDataFilter = CreateGridDataNoData<TModel>(command, filter);
		IEntityFilter entityFilter = gridDataFilter.DataFilter.Filter;
		gridDataFilter.SetCount((GridData<TModel> d, FetchOptions f) => (entityFilter == null) ? manager.Count() : manager.Count(entityFilter));
		if (command != null && command.get_GroupDescriptors().Any())
		{
			gridDataFilter.GroupDescriptors = (from gd in command.get_GroupDescriptors()
				select new GridGroupDescriptor
				{
					Member = ((SortDescriptor)gd).get_Member(),
					SortDirection = ((SortDescriptor)gd).get_SortDirection()
				}).ToList();
			gridDataFilter.SetDataSource(delegate(GridData<TModel> d, FetchOptions f)
			{
				GridCommand command2 = command;
				object items;
				if (d.Count > 0)
				{
					items = ((entityFilter != null) ? manager.Find(entityFilter, f).Cast<TModel>() : manager.Find(f).Cast<TModel>());
				}
				else
				{
					IEnumerable<TModel> enumerable = new List<TModel>();
					items = enumerable;
				}
				return command2.ApplyGrouping((IEnumerable<TModel>)items);
			});
		}
		else
		{
			gridDataFilter.SetDataSource(delegate(GridData<TModel> d, FetchOptions f)
			{
				if (d.Count <= 0)
				{
					return new List<TModel>();
				}
				return (entityFilter == null) ? manager.Find(f) : manager.Find(entityFilter, f).Cast<TModel>();
			});
		}
		return gridDataFilter;
	}

	public static GridDataFilter<TModel> CreateGridDataNoData<TModel>(GridCommand command, FilterModel filter) where TModel : IEntity
	{
		return new GridDataFilter<TModel>
		{
			Command = command,
			DataFilter = filter
		};
	}

	public static GridDataFilter<TModel> CreateGridData<TModel>([NotNull] this IEntityManager manager, GridCommand command, FilterModel filter, long count) where TModel : IEntity
	{
		if (manager == null)
		{
			throw new ArgumentNullException("manager");
		}
		GridDataFilter<TModel> gridDataFilter = new GridDataFilter<TModel>
		{
			Command = command,
			DataFilter = filter
		};
		IEntityFilter entityFilter = gridDataFilter.DataFilter.Filter;
		gridDataFilter.SetCount((GridData<TModel> d, FetchOptions f) => count);
		gridDataFilter.SetDataSource(delegate(GridData<TModel> d, FetchOptions f)
		{
			if (d.Count <= 0)
			{
				return new List<TModel>();
			}
			return (entityFilter == null) ? manager.Find(f) : manager.Find(entityFilter, f).Cast<TModel>();
		});
		return gridDataFilter;
	}

	public static DynamicGridBuilder<TData> FilterDynamicGrid<TData>(this HtmlHelper htmlHelper, GridDataFilter<TData> gridData) where TData : class
	{
		return htmlHelper.FilterDynamicGrid(gridData, FilterGridStateProvider.UID);
	}

	public static DynamicGridBuilder<TData> FilterDynamicGrid<TData>(this HtmlHelper htmlHelper, GridDataFilter<TData> gridData, Guid filterGridStateProvider) where TData : class
	{
		return htmlHelper.DynamicGrid(gridData.GridId, gridData, (gridData.DataFilter.Entity != null && gridData.DataFilter.Entity.Id > 0) ? filterGridStateProvider : Guid.Empty).EnableCustomize(gridData.DataFilter.Entity == null || gridData.DataFilter.Entity.Id == 0);
	}

	public static MvcHtmlString WatchPanel(this HtmlHelper html, Guid typeUid, object entityId)
	{
		WatchesModel watchesModel = new WatchesModel(typeUid, entityId)
		{
			DynamicLoad = true
		};
		return PartialExtensions.Partial(html, "Watch/IconInfoPanel", (object)watchesModel);
	}

	public static MvcHtmlString WatchManager(this HtmlHelper html, Guid typeUid, object entityId)
	{
		string id = $"{UIExtensions.PrepareId(typeUid.ToString())}{entityId}";
		return html.AdaptivePopupWindow(id, SR.T("Список наблюдателей"), UIWindowSize.M);
	}

	public static string OpenWatchManager(this HtmlHelper html, Guid typeUid, object entityId, Guid permissiontoValidate, Guid typeUidForPermission, bool canEdit = true, string typeWatchesCaption = null)
	{
		string text = $"{UIExtensions.PrepareId(typeUid.ToString())}{entityId}";
		return string.Format("refreshPopup('{0}', '{1}');", text, html.Url().Action("FullListPopup", "Watch", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common",
			typeUid = typeUid,
			entityId = entityId,
			permissiontoValidate = permissiontoValidate,
			typeUidForPermission = typeUidForPermission,
			popupId = text,
			canEdit = canEdit,
			typeWatchesCaption = typeWatchesCaption
		}));
	}

	public static MvcHtmlString WatchSettings(this HtmlHelper html, Guid typeUid, object entityId, string popupId = "watchListPopup", string callback = "")
	{
		return html.PopupWindow(popupId, SR.T("Настройка наблюдения за изменениями"), html.Url().Action("Settings", "Watch", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common",
			typeUid = typeUid,
			entityId = entityId,
			popupId = popupId,
			callback = callback
		}));
	}

	public static string WatchSettingsOpen(this HtmlHelper html, Guid typeUid, object entityId, string popupId = "watchListPopup", string callback = "")
	{
		return string.Format("refreshPopup('{0}', '{1}')", popupId, html.Url().Action("Settings", "Watch", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common",
			typeUid = typeUid,
			entityId = entityId,
			popupId = popupId,
			callback = callback
		}));
	}

	public static MvcHtmlString PackageIcon(this HtmlHelper html, string id, string version, Uri iconUrl)
	{
		string text = (Locator.GetServiceNotNull<PackageService>().HasPackageLocalIcon(id, version) ? html.Url().Action("Icon", (object)new { id, version }) : ((iconUrl != null) ? iconUrl.AbsoluteUri : null));
		if (!string.IsNullOrEmpty(text))
		{
			return html.Image(text, "-");
		}
		return html.Image("#modules.svg", "-");
	}

	public static MvcHtmlString LastObjectHandler(this HtmlHelper html, LastObjectInfoModel model)
	{
		if (model.ObjectId <= 0)
		{
			return MvcHtmlString.Empty;
		}
		return PartialExtensions.Partial(html, "LastObjectInfo/Handler", (object)model);
	}

	public static MvcHtmlString UnitMeasureDisplay(this HtmlHelper html, double? value, IUnitMeasure unitMeasure, IWpiSelectListItem listItem = null)
	{
		if (!value.HasValue)
		{
			return null;
		}
		if (unitMeasure == null)
		{
			return MvcHtmlString.Create(value.ToString());
		}
		Func<double, string> func = delegate(double v)
		{
			string format = "{0}";
			if (unitMeasure.Properties == null)
			{
				return v.ToString(CultureInfo.InvariantCulture);
			}
			string value2 = "#############################################".Substring(0, unitMeasure.Properties.GroupMemberLenght);
			string text3 = ((unitMeasure.Properties.GroupMemberLenght <= 0) ? "#############################################" : new StringBuilder().Append(value2).Append("-").Append(value2)
				.Append("-")
				.Append(value2)
				.Append("-")
				.Append(value2)
				.Append("-")
				.Append(value2)
				.Append("-")
				.Append(value2)
				.Append("-")
				.Append(value2)
				.Append("-")
				.Append(value2)
				.Append("-")
				.Append(value2)
				.Append("-")
				.Append(value2)
				.Append("-")
				.Append(value2)
				.Append("-")
				.Append(value2)
				.Append("-")
				.Append(value2)
				.Append("-")
				.Append(value2)
				.Append("-")
				.Append(value2)
				.Append("-")
				.Append(value2)
				.Append("-")
				.Append(value2)
				.Append("-")
				.Append(value2)
				.Append("-")
				.Append(value2)
				.Append("-")
				.Append(value2)
				.ToString());
			if (value < 0.0)
			{
				switch (unitMeasure.Properties.NegativeFormat)
				{
				case NegativeFormat.Bracers:
					format = "({0})";
					break;
				case NegativeFormat.LeftMinus:
					format = "-{0}";
					break;
				case NegativeFormat.LeftMinusWithSpace:
					format = "- {0}";
					break;
				case NegativeFormat.RigthMinus:
					format = "{0}-";
					break;
				case NegativeFormat.RigthMinusWithSpace:
					format = "{0} -";
					break;
				}
			}
			double num = Math.Floor(Math.Abs(v));
			string text4 = $"{v:F12}".Split(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator.ToCharArray())[1];
			StringBuilder stringBuilder = new StringBuilder(num.ToString(text3).TrimStart("-".ToCharArray()).Replace("-", unitMeasure.Properties.GroupSeparator));
			if (long.Parse(text4) != 0L && unitMeasure.Properties.DoublePrecision > 0)
			{
				stringBuilder.Append(unitMeasure.Properties.DoubleSeparator).Append(text4.Substring(0, unitMeasure.Properties.DoublePrecision).TrimEnd("0".ToCharArray()));
			}
			return string.Format(format, stringBuilder.ToString());
		};
		string text = "";
		string arg = "";
		string text2 = "";
		if (unitMeasure.IsSelectList)
		{
			if (listItem == null || ((IEnumerable<IWpiSelectListItem>)unitMeasure.WpiSelectList).All((IWpiSelectListItem l) => l == listItem))
			{
				return MvcHtmlString.Create(value.ToString());
			}
			text = ((unitMeasure.Properties == null || unitMeasure.Properties.Position == UnitMeasurePosition.Right) ? "{0} {1}" : "{1} {0}");
			text2 = listItem.Name;
		}
		else
		{
			text = ((unitMeasure.Properties == null || unitMeasure.Properties.Position == UnitMeasurePosition.Right) ? "{0} {1}" : "{1} {0}");
			arg = func(value.Value);
			text2 = unitMeasure.Shortening;
		}
		return MvcHtmlString.Create(string.Format(text, arg, text2));
	}

	public static MvcHtmlString FilterLinkGenerator(this HtmlHelper html)
	{
		return html.FilterLinkGenerator(null, null);
	}

	public static MvcHtmlString FilterLinkGenerator(this HtmlHelper html, string baseUrl, string saveSelector)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		ViewDataDictionary val = new ViewDataDictionary();
		val.Add("BaseUrl", (object)baseUrl);
		val.Add("SaveSelector", (object)saveSelector);
		return PartialExtensions.Partial(html, "FilterLinkGenerator", val);
	}

	public static MvcHtmlString CurrentSearchLinkButton(this HtmlHelper html, Guid typeUid)
	{
		return html.CurrentSearchLinkButton(typeUid, null, html.Path());
	}

	public static MvcHtmlString CurrentSearchLinkButton(this HtmlHelper html, Guid baseTypeUid, Guid? objectUid, string baseUrl)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		ViewDataDictionary val = new ViewDataDictionary();
		val.Add("TypeUid", (object)baseTypeUid);
		val.Add("ObjectUid", (object)objectUid);
		val.Add("BaseUrl", (object)baseUrl);
		return PartialExtensions.Partial(html, "CurrentSearchLinkButton", val);
	}

	public static MvcHtmlString BigText(this HtmlHelper html, string text, string buttonText = "")
	{
		return html.BigText(new BigTextModel
		{
			Text = text,
			ButtonNext = buttonText
		});
	}

	public static MvcHtmlString BigText(this HtmlHelper html, BigTextModel model)
	{
		if (string.IsNullOrEmpty(model.ButtonNext))
		{
			model.ButtonNext = SR.T("читать далее...");
		}
		return PartialExtensions.Partial(html, "BigText", (object)model);
	}

	public static MvcHtmlString GetLicenseStateMessage(this HtmlHelper html, IStoreComponentInfo component)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		DateTime? expirationDate = Locator.GetServiceNotNull<ExpirationInfoService>().GetExpirationDate(component);
		TagBuilder val = new TagBuilder("td");
		string text = null;
		if (expirationDate.HasValue)
		{
			if (expirationDate.Value <= DateTime.Now)
			{
				val.set_InnerHtml(SR.T("Лицензия истекла"));
				val.AddCssClass("expiratedLicense");
				text = ((object)val).ToString();
			}
			else
			{
				val.set_InnerHtml(SR.T("Лицензия истекает"));
				text = ((object)val).ToString();
				val.set_InnerHtml(expirationDate.Value.ToShortDateString());
				text += ((object)val).ToString();
			}
		}
		return MvcHtmlString.Create(text);
	}

	public static MvcHtmlString GetCatalogHeaderEditBreadcrumbs(this HtmlHelper html, string catalogName, bool isNew, object typeUid)
	{
		ActionButtonBuilder catalogButton = html.Button().Url(html.Url().Action("View", "Catalogs", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common",
			uid = typeUid
		})).Text(html.Encode(catalogName));
		return html.GetCatalogHeaderEditBreadcrumbs(catalogButton, isNew);
	}

	public static MvcHtmlString GetCatalogHeaderEditBreadcrumbs(this HtmlHelper html, ActionButtonBuilder catalogButton, bool isNew)
	{
		ButtonGroupBuilder buttonGroupBuilder = html.Breadcrumbs("catalog-view").Item(delegate(ActionButtonBuilder button)
		{
			button.Text(SR.T("Справочники")).Url(html.Url().Action("Index", "Catalogs", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Common"
			}));
		}).Item(catalogButton);
		if (isNew)
		{
			buttonGroupBuilder.Item(delegate(ActionButtonBuilder button)
			{
				button.Text(SR.T("Новая запись"));
			});
		}
		else
		{
			buttonGroupBuilder.Item(delegate(ActionButtonBuilder button)
			{
				button.Text(SR.T("Редактирование записи"));
			});
		}
		return MvcHtmlString.Create(buttonGroupBuilder.ToHtmlString());
	}
}
