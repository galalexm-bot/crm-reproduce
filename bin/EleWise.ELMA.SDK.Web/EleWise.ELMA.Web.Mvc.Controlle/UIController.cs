using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services.Scope;
using EleWise.ELMA.UI;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UI.Results;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Web.Mvc.Models.UI;
using EleWise.ELMA.Web.Mvc.Models.UI.ResultConverters;
using EleWise.ELMA.Web.Mvc.Portlets;
using Orchard.Themes;

namespace EleWise.ELMA.Web.Mvc.Controllers;

[Themed]
public class UIController : BaseController
{
	private readonly FormDescriptorProvider formDescriptorProvider;

	private readonly IExecutionScopeFactory executionScopeFactory;

	private readonly IEnumerable<IFormDescriptorPermissionChecker> formDescriptorPermissionCheckers;

	public IEntityManager<ComponentMetadataItemHeader, long> ComponentMetadataItemHeaderManager { get; set; }

	public UIController(FormDescriptorProvider formDescriptorProvider, IExecutionScopeFactory executionScopeFactory, IEnumerable<IFormDescriptorPermissionChecker> formDescriptorPermissionCheckers)
	{
		this.formDescriptorProvider = formDescriptorProvider;
		this.executionScopeFactory = executionScopeFactory;
		this.formDescriptorPermissionCheckers = formDescriptorPermissionCheckers;
	}

	[EntityForm(AreaName = "EleWise.ELMA.SDK.Web")]
	public ActionResult CreateForm([ParameterContainer] IEntity entity, Guid headerUid, PropertyMap map, string parentFormId, string formId = null)
	{
		PageDescriptor pageDescriptor = (PageDescriptor)formDescriptorProvider.GetDescriptorByHeaderUid(PageMetadata.TypeUid, headerUid, forEmulation: false);
		if (pageDescriptor == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		FormResult pageLoadResult = new UIPageRenderer(pageDescriptor, this, executionScopeFactory).GetPageLoadResult(entity, map, parentFormId, formId);
		if (pageLoadResult == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		IFormResultConverter obj = GetConverter(pageLoadResult.GetType()) ?? throw new InvalidOperationException($"Cannot find converter for type \"{pageLoadResult.GetType().FullName}\"");
		((Controller)this).get_RouteData().Values.Add("partial", true);
		return obj.Convert(pageLoadResult, this);
	}

	public ActionResult Page(string pageName, string pagePart, bool? forEmulation = null)
	{
		ComponentMetadataItemHeaderFilter filter = new ComponentMetadataItemHeaderFilter
		{
			Name = pageName,
			MetadataTypeUid = PageComponentMetadata.TypeUid
		};
		ComponentMetadataItemHeader componentMetadataItemHeader = ComponentMetadataItemHeaderManager.Find(filter, FetchOptions.First).FirstOrDefault();
		if (componentMetadataItemHeader != null)
		{
			bool num = (((Controller)this).get_RouteData().Values["partial"] as bool?) ?? false;
			PageApplicationData pageApplicationData = new PageApplicationData(componentMetadataItemHeader.Uid, new Dictionary<string, object> { 
			{
				PageApplicationData.DynamicFormsProviderDataKey,
				string.Concat(PageComponentMetadata.TypeUid, ";", componentMetadataItemHeader.Published.Uid)
			} });
			if (!num)
			{
				return (ActionResult)(object)((Controller)this).View("UI/PageApplication", (object)pageApplicationData);
			}
			return (ActionResult)(object)GetPartialViewResult("UI/PageApplication", pageApplicationData);
		}
		PageDescriptor pageDescriptor = (PageDescriptor)formDescriptorProvider.GetDescriptor(PageMetadata.TypeUid, pageName, forEmulation.HasValue && forEmulation.Value);
		if (pageDescriptor == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		if (!forEmulation.HasValue || !forEmulation.Value)
		{
			IFormDescriptorPermissionChecker formDescriptorPermissionChecker = formDescriptorPermissionCheckers.FirstOrDefault((IFormDescriptorPermissionChecker p) => p.CanCheckPermission(CommonPermissions.View, pageDescriptor));
			if (formDescriptorPermissionChecker != null && !formDescriptorPermissionChecker.HasPermission(CommonPermissions.View, pageDescriptor))
			{
				throw new SecurityException();
			}
		}
		else
		{
			IUser currentUser = base.AuthenticationService.GetCurrentUser();
			if (currentUser == null || !pageDescriptor.AuthorId.HasValue || (long?)currentUser.GetId() != pageDescriptor.AuthorId.Value)
			{
				throw new SecurityException();
			}
		}
		FormResult pageLoadResult = new UIPageRenderer(pageDescriptor, this, executionScopeFactory).GetPageLoadResult();
		if (pageLoadResult == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		return (GetConverter(pageLoadResult.GetType()) ?? throw new InvalidOperationException($"Cannot find converter for type \"{pageLoadResult.GetType().FullName}\"")).Convert(pageLoadResult, this);
	}

	public ActionResult PageV2(Guid pageUid)
	{
		ComponentMetadataItemHeader componentMetadataItemHeader = ComponentMetadataItemHeaderManager.LoadOrNull(pageUid);
		if (componentMetadataItemHeader != null)
		{
			bool num = (((Controller)this).get_RouteData().Values["partial"] as bool?) ?? false;
			PageApplicationData model = new PageApplicationData(componentMetadataItemHeader.Uid, new Dictionary<string, object> { 
			{
				PageApplicationData.DynamicFormsProviderDataKey,
				string.Concat(PageComponentMetadata.TypeUid, ";", componentMetadataItemHeader.Published.Uid)
			} });
			if (!num)
			{
				return (ActionResult)(object)GetViewResult("UI/PageApplication", model);
			}
			return (ActionResult)(object)GetPartialViewResult("UI/PageApplication", model);
		}
		return (ActionResult)(object)((Controller)this).HttpNotFound();
	}

	public ActionResult PortletV2(Guid portletUid, UIPortletPersonalization settings)
	{
		if (!(new EntityJsonSerializer().ConvertToSerializable(settings) is Dictionary<string, object> dictionary))
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		ComponentMetadataItemHeader componentMetadataItemHeader = ComponentMetadataItemHeaderManager.LoadOrNull(portletUid);
		if (componentMetadataItemHeader != null)
		{
			dictionary.Add(PageApplicationData.DynamicFormsProviderDataKey, string.Concat(PortletComponentMetadata.TypeUid, ";", componentMetadataItemHeader.Published.Uid));
			PageApplicationData model = new PageApplicationData(componentMetadataItemHeader.Uid, dictionary);
			return (ActionResult)(object)GetPartialViewResult("UI/PortletApplication", model);
		}
		return (ActionResult)(object)((Controller)this).HttpNotFound();
	}

	public ActionResult PortletContent(Guid headerUid, UIPortletPersonalization settings, bool? forEmulation = null)
	{
		Contract.ArgumentNotNull(settings, "settings");
		PortletDescriptor portletDescriptor = (PortletDescriptor)formDescriptorProvider.GetDescriptorByHeaderUid(PortletMetadata.TypeUid, headerUid, forEmulation.HasValue && forEmulation.Value);
		if (portletDescriptor == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		PersonalizationContext personalizationContext = settings.GetPersonalizationContext();
		FormResult contentLoadResult = new UIPortletRenderer(portletDescriptor, settings, this, personalizationContext?.CurrentScope ?? PersonalizationScope.User, personalizationContext?.Path, settings.PortletUid, settings.InstanceId, settings.Path, executionScopeFactory).GetContentLoadResult();
		if (contentLoadResult == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		return (GetConverter(contentLoadResult.GetType()) ?? throw new InvalidOperationException($"Cannot find converter for type \"{contentLoadResult.GetType().FullName}\"")).Convert(contentLoadResult, this);
	}

	public static IFormResultConverter GetConverter(Type resultType)
	{
		IEnumerable<IFormResultConverter> extensionPoints = ComponentManager.Current.GetExtensionPoints<IFormResultConverter>();
		Type type = resultType;
		IFormResultConverter formResultConverter = null;
		while (formResultConverter == null && type != null)
		{
			formResultConverter = extensionPoints.FirstOrDefault((IFormResultConverter c) => c.ResultType == type);
			type = type.BaseType;
		}
		return formResultConverter;
	}
}
