using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.Panels;
using EleWise.ELMA.Web.Mvc.Models.Portal;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Web.Mvc.Controllers;

[OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
public class PersonalizationController : BaseController
{
	private PortletManager portletManager;

	public PortletManager PortletManager
	{
		get
		{
			if (portletManager == null)
			{
				PersonalizationScope valueFromRequest = GetValueFromRequest("scope", (string v) => (PersonalizationScope)Enum.Parse(typeof(PersonalizationScope), v));
				string valueFromRequest2 = GetValueFromRequest("path", (string v) => v);
				portletManager = PortletManagerFactory.Create(valueFromRequest, valueFromRequest2);
			}
			return portletManager;
		}
	}

	public PortletManager PortletManagerFactory { get; set; }

	private T GetValueFromRequest<T>(string key, Func<string, T> convert)
	{
		object obj = ((Controller)this).get_RouteData().DataTokens[key];
		if (obj != null)
		{
			return (T)obj;
		}
		string text = ((Controller)this).get_Request().QueryString.Get(key) ?? ((Controller)this).get_Request().Form.Get(key);
		if (!string.IsNullOrWhiteSpace(text))
		{
			return convert(text);
		}
		throw new InvalidOperationException(SR.T("Не удалось получить значение по ключу {0}", key));
	}

	private bool TryUpdateModel(Type type, object model, string prefix, string[] includeProperties, string[] excludeProperties)
	{
		return (bool)((object)this).GetType().GetMethod("_TryUpdateModel").MakeGenericMethod(type)
			.Invoke(this, new object[4] { model, prefix, includeProperties, excludeProperties });
	}

	[NonAction]
	[UsedImplicitly]
	public bool _TryUpdateModel<TModel>(TModel model, string prefix, string[] includeProperties, string[] excludeProperties) where TModel : class
	{
		return ((Controller)this).TryUpdateModel<TModel>(model, prefix, includeProperties, excludeProperties);
	}

	public ActionResult PortletContent(Guid portletId, Guid instanceId, string path)
	{
		IPortlet portlet = PortletManager.GetPortlet(portletId);
		_ = portlet.SettingsType;
		PortletPersonalization personalization = PortletManager.GetPersonalization(portletId, instanceId, path);
		if (personalization == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		PortletViewModel portletViewModel = CreateModel(portlet, personalization, path);
		return (ActionResult)(object)((Controller)this).PartialView("UI/Portlets/PortletContent", (object)portletViewModel);
	}

	[HttpPost]
	public ActionResult PortletSettings(Guid portletId, Guid? instanceId, string path)
	{
		IPortlet portlet = PortletManager.GetPortlet(portletId);
		Type settingsType = portlet.SettingsType;
		PortletPersonalization portletPersonalization;
		if (instanceId.HasValue)
		{
			portletPersonalization = PortletManager.GetPersonalization(portletId, instanceId.Value, path, addIfNotExists: false, settingsType);
			if (portletPersonalization == null)
			{
				throw new InvalidOperationException(SR.T("Отсутствует instance {0}", instanceId.Value));
			}
		}
		else
		{
			portletPersonalization = PortletManager.AddPortlet(portlet, path);
		}
		string prefix = PortletViewModel.SettingsPrefix(instanceId ?? Guid.Empty);
		if (!TryUpdateModel(settingsType, portletPersonalization, prefix, null, PortletViewModel.SkipEditProperties.Union(new string[2] { "PortletUid", "InstanceId" }).ToArray()))
		{
			List<string> list = new List<string>();
			HashSet<string> hashSet = new HashSet<string>(((Controller)this).get_Request().Form.AllKeys);
			foreach (KeyValuePair<string, ModelState> item in ((Controller)this).get_ModelState())
			{
				if (((Collection<ModelError>)(object)item.Value.get_Errors()).Count > 0 && hashSet.Contains(item.Key))
				{
					list.Add(item.Key);
				}
			}
			if (list.Any())
			{
				return (ActionResult)(object)((Controller)this).Json((object)new
				{
					error = string.Format("{0}: {1}", SR.T("Не заполнены поля"), string.Join(", ", list))
				});
			}
		}
		PortletManager.SavePersonalization(portletPersonalization, path);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = true
		});
	}

	[HttpGet]
	[OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
	public ActionResult PortletSettings(Guid portletId, Guid? instanceId, string path, [DefaultValue(false)] bool addIfNotExists, PersonalizationScope scope = PersonalizationScope.User)
	{
		IPortlet portlet = PortletManager.GetPortlet(portletId);
		if (portlet == null)
		{
			throw new InvalidOperationException("portletId " + portletId);
		}
		((ControllerBase)this).get_ViewData().set_Item("newPortlet", (object)(!instanceId.HasValue));
		((ControllerBase)this).get_ViewData().set_Item("inPopup", (object)true);
		((ControllerBase)this).get_ViewData().set_Item("scope", (object)scope);
		PortletPersonalization portletPersonalization = null;
		if (instanceId.HasValue)
		{
			portletPersonalization = PortletManager.GetPersonalization(portletId, instanceId.Value, path, addIfNotExists, portlet.SettingsType);
		}
		if (portletPersonalization == null)
		{
			portletPersonalization = PortletManager.CreateDefaultSettings(portlet, path);
			portletPersonalization.PortletUid = portlet.Uid;
		}
		if (string.IsNullOrEmpty(portletPersonalization.Path))
		{
			portletPersonalization.Path = path;
		}
		return (ActionResult)(object)PortletSettingsViewResult(portlet, portletPersonalization, path);
	}

	private PartialViewResult PortletSettingsViewResult(IPortlet portlet, PortletPersonalization personalization, string path)
	{
		return ((Controller)this).PartialView("UI/Portlets/PortletSettings", (object)CreateModel(portlet, personalization, path));
	}

	public ActionResult HasAddedPortlets(string path)
	{
		IEnumerable<AddPortlet> allAllowedPortlets = PortletManager.GetAllAllowedPortlets(path);
		return (ActionResult)(object)((Controller)this).PartialView("UI/Portlets/PortletAdd", (object)new AddPortletModel
		{
			Scope = PortletManager.PersonalizationContext.CurrentScope,
			AllPortlets = allAllowedPortlets
		});
	}

	protected PortletViewModel CreateModel(IPortlet portlet, PortletPersonalization personalization, string path)
	{
		return new PortletViewModel(portlet, personalization, path, PortletManager.PersonalizationContext.CurrentScope, PortletManager.AllowedProperties(personalization, portlet, path));
	}

	[HttpGet]
	public ActionResult EditPortlet(Guid portletId, Guid instanceId, string path)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		PortletPersonalization personalization = PortletManager.GetPersonalization(portletId, instanceId, path);
		if (personalization == null)
		{
			return (ActionResult)new EmptyResult();
		}
		IPortlet portlet = PortletManager.GetPortlet(personalization.PortletUid);
		if (portlet == null)
		{
			return (ActionResult)new EmptyResult();
		}
		string text = "UI/Portlets/EditPortlet";
		return (ActionResult)(object)((Controller)this).PartialView(text, (object)CreateModel(portlet, personalization, path));
	}

	public ActionResult AddPortlet(Guid portletId, string path, string zone, string appendType)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		if (string.IsNullOrWhiteSpace(zone))
		{
			throw new ArgumentNullException("zone");
		}
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		IPortlet portlet = PortletManager.GetPortlet(portletId);
		if (portlet == null)
		{
			dictionary["error"] = SR.T("Не найден портлет");
			JsonResult val = new JsonResult();
			val.set_Data((object)dictionary);
			val.set_JsonRequestBehavior((JsonRequestBehavior)0);
			return (ActionResult)val;
		}
		if (!PortletManager.CanAddPortlet(portlet, path))
		{
			dictionary["error"] = SR.T("Нельзя добавить портлет {0}", portlet.Name);
			JsonResult val2 = new JsonResult();
			val2.set_Data((object)dictionary);
			val2.set_JsonRequestBehavior((JsonRequestBehavior)0);
			return (ActionResult)val2;
		}
		PortletViewModel[] source = PortletManager.GetAllPortlets(path).ToArray();
		int order = ((!(appendType == "append")) ? (source.Any() ? (source.Select((PortletViewModel m) => m.Personalization.Order).Min() - 1) : 0) : (source.Any() ? (source.Select((PortletViewModel m) => m.Personalization.Order).Max() + 1) : 0));
		PortletPersonalization personalization = PortletManager.GetPersonalization(portletId, portletId, PortletManager.DefaultSettingsPath(portlet), addIfNotExists: false, portlet.SettingsType);
		PortletPersonalization portletPersonalization = ((personalization != null) ? PortletManager.AddPortlet(portlet.Uid, delegate
		{
			personalization.Shared = false;
			return personalization;
		}, path) : PortletManager.AddPortlet(portlet, path));
		portletPersonalization.Order = order;
		portletPersonalization.Zone = zone;
		portletPersonalization.Closed = false;
		portletPersonalization.Collapsed = false;
		PortletManager.SavePersonalization(portletPersonalization, path);
		dictionary["portletZone"] = portletPersonalization.Zone;
		dictionary["portletId"] = portlet.Uid.ToString();
		dictionary["instanceId"] = portletPersonalization.InstanceId;
		dictionary["title"] = portletPersonalization.Name ?? portlet.Name;
		dictionary["path"] = path;
		JsonResult val3 = new JsonResult();
		val3.set_Data((object)dictionary);
		val3.set_JsonRequestBehavior((JsonRequestBehavior)0);
		return (ActionResult)val3;
	}

	public ActionResult ResetPersonalization(string path)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		PortletManager.ResetPersonalization(path);
		return (ActionResult)new EmptyResult();
	}

	public ActionResult SavePositions(PortalModel model)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		PortletManager.SavePersonalization(model);
		return (ActionResult)new EmptyResult();
	}

	public ActionResult Set(Guid instanceId, string path, bool? collapse, string zone, int? zoneOrder, bool? closed)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		PortletManager.SavePersonalization(instanceId, path, collapse, zone, zoneOrder, closed);
		return (ActionResult)new EmptyResult();
	}

	public ActionResult BatchClose(string instances, string path)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		foreach (string item in new JsonSerializer().Deserialize<List<string>>(instances))
		{
			Guid instanceId = Guid.Parse(item);
			PortletManager.SavePersonalization(instanceId, path, null, null, null, true);
		}
		return (ActionResult)new EmptyResult();
	}

	public ActionResult SaveCollapsiblePanelState(string panel, bool stateValue)
	{
		PanelState panelState = PanelPersonalizationAdministration.LoadState(panel);
		if (panelState == null)
		{
			panelState = new PanelState();
		}
		panelState.Expanded = stateValue;
		PanelPersonalizationAdministration.SaveState(panel, panelState);
		return (ActionResult)(object)((Controller)this).Json((object)panelState, (JsonRequestBehavior)0);
	}

	public ActionResult LoadCollapsiblePanelState(string panel)
	{
		PanelState panelState = PanelPersonalizationAdministration.LoadState(panel);
		if (panelState == null)
		{
			panelState = new PanelState();
		}
		return (ActionResult)(object)((Controller)this).Json((object)panelState, (JsonRequestBehavior)0);
	}
}
