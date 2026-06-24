using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.Panels;
using EleWise.ELMA.Web.Mvc.Models.Selectors;

namespace EleWise.ELMA.Web.Mvc.Models.Boxes;

public class AutocompleteEntityComboBox : AutocompleteComboBox
{
	public ClassMetadata Metadata { get; set; }

	public bool HideCreator { get; set; }

	public bool SelectorForCreator { get; set; }

	public bool DisableCreatorSecurity { get; set; }

	public RouteValueDictionary AdditionalRouteValueDictionary { get; set; }

	public AutocompleteEntityComboBox()
	{
		base.ComboBoxAddLoading = true;
		base.ComboBoxAddIconEnabled = true;
	}

	public void InitCreatePopup(HtmlHelper helper)
	{
		InitCreatePopup(helper, null);
	}

	public void InitCreatePopup(HtmlHelper helper, ClassMetadata child)
	{
		if (base.FormCreator == null || base.FormCreator.Count == 0)
		{
			return;
		}
		string text = UIExtensions.PrepareId(Guid.NewGuid().ToString());
		string value = TagBuilder.CreateSanitizedId(base.Name.Replace(".", "_"));
		PropertyMetadata propMetadata = helper.get_ViewData().get_ModelMetadata().GetPropertyMetadata() as PropertyMetadata;
		object container = helper.get_ViewData().get_ModelMetadata().GetContainerObject();
		Func<IFormCreator, IDictionary<string, object>, ObjectCreatorParams> createParams = delegate(IFormCreator o, IDictionary<string, object> paramsFromServer)
		{
			if (paramsFromServer != null && paramsFromServer.Count > 0)
			{
				ObjectCreatorParams objectCreatorParams3 = new ObjectCreatorParams();
				{
					foreach (KeyValuePair<string, object> item2 in paramsFromServer)
					{
						ObjectCreatorParam item = new ObjectCreatorParam
						{
							Key = item2.Key,
							Value = item2.Value.ToString()
						};
						objectCreatorParams3.Params.Add(item);
					}
					return objectCreatorParams3;
				}
			}
			return null;
		};
		if (!SelectorForCreator)
		{
			IFormCreator formCreator = base.FormCreator.First();
			IDictionary<string, object> serverParams = formCreator.GetServerParams(container, propMetadata);
			IMetadataRuntimeService serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
			Guid guid = child?.Uid ?? Metadata.Uid;
			Type typeByUid = serviceNotNull.GetTypeByUid(guid);
			RouteValueDictionary routeDictionary = new RouteValueDictionary
			{
				{ "area", "EleWise.ELMA.BPM.Web.Common" },
				{
					"creatorUid",
					Guid.Empty
				},
				{ "inputId", value },
				{ "typeUid", guid },
				{ "containerId", base.ContainerId },
				{
					"popupId",
					$"CreateEntityPopup{text}"
				}
			};
			ObjectCreatorParams objectCreatorParams = createParams(formCreator, serverParams);
			Popup popup2 = (base.CreatePopup = new Popup
			{
				RegisterOnce = true,
				PopupId = text,
				PopupHeader = formCreator.PopupHeader(typeByUid),
				ActionUrl = helper.Url().Action("CreatorForm", "Entity", SquashRouteValueDictionaries(routeDictionary))
			});
			string text2 = ((objectCreatorParams != null) ? $"data = 'creatorParams={ClassSerializationHelper.SerializeObjectByJson(objectCreatorParams)}';" : string.Empty);
			text2 = (base.CreatePopupParams = text2 + formCreator.GetParamsFunc(helper, helper.get_ViewData().get_TemplateInfo().get_HtmlFieldPrefix()));
			return;
		}
		RouteValueDictionary routeDictionary2 = new RouteValueDictionary
		{
			{ "area", "EleWise.ELMA.BPM.Web.Common" },
			{ "typeUid", Metadata.Uid },
			{ "inputId", value },
			{ "containerId", base.ContainerId },
			{
				"popupId",
				$"CreateEntityPopup{text}"
			},
			{
				"parentHtmlPrefix",
				helper.get_ViewData().get_TemplateInfo().get_HtmlFieldPrefix()
			}
		};
		ObjectCreatorParamsContainer creatorParamsContainer = new ObjectCreatorParamsContainer();
		base.FormCreator.ForEach(delegate(IFormCreator o)
		{
			IDictionary<string, object> serverParams2 = o.GetServerParams(container, propMetadata);
			ObjectCreatorParams objectCreatorParams2 = createParams(o, serverParams2);
			if (objectCreatorParams2 != null)
			{
				creatorParamsContainer.CreatorParams.Add(objectCreatorParams2);
			}
		});
		base.CreatePopup = new Popup
		{
			RegisterOnce = true,
			PopupId = text,
			PopupHeader = SR.T("Выберите тип объекта"),
			ActionUrl = helper.Url().Action("EntityTypeSelector", "Entity", SquashRouteValueDictionaries(routeDictionary2))
		};
		base.CreatePopupParams = ((creatorParamsContainer.CreatorParams.Count > 0) ? $"var data = 'creatorParamsContainer={ClassSerializationHelper.SerializeObjectByJson(creatorParamsContainer)}';" : null);
	}

	private RouteValueDictionary SquashRouteValueDictionaries(RouteValueDictionary routeDictionary)
	{
		if (AdditionalRouteValueDictionary != null)
		{
			foreach (KeyValuePair<string, object> item in AdditionalRouteValueDictionary)
			{
				routeDictionary[item.Key] = item.Value;
			}
			return routeDictionary;
		}
		return routeDictionary;
	}
}
