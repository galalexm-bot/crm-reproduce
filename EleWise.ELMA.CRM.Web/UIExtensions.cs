// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.UIExtensions
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html.Toolbar;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;

namespace EleWise.ELMA.CRM.Web
{
  public static class UIExtensions
  {
    public static string EntityAction<AttributeType>(this UrlHelper url, Guid entityTypeUid) => url.EntityAction<AttributeType>(entityTypeUid, out AttributeType _, (RouteValueDictionary) null);

    public static string EntityAction<AttributeType>(
      this UrlHelper url,
      Guid entityTypeUid,
      out AttributeType attr)
    {
      return url.EntityAction<AttributeType>(entityTypeUid, out attr, (RouteValueDictionary) null);
    }

    public static string EntityAction<AttributeType>(
      this UrlHelper url,
      Guid entityTypeUid,
      out AttributeType attr,
      object routeValues)
    {
      return url.EntityAction<AttributeType>(entityTypeUid, out attr, new RouteValueDictionary(routeValues));
    }

    public static string EntityAction<AttributeType>(
      this UrlHelper url,
      Guid entityTypeUid,
      out AttributeType attr,
      RouteValueDictionary routeValues)
    {
      string actionName = "";
      string controllerName = "";
      string areaName = "";
      UIExtensions.SearchAction<AttributeType>(entityTypeUid, out actionName, out controllerName, out areaName, out attr);
      RouteValueDictionary routeValues1 = new RouteValueDictionary();
      if (!string.IsNullOrEmpty(areaName))
        routeValues1.Add("area", (object) areaName);
      if (routeValues != null)
      {
        foreach (KeyValuePair<string, object> routeValue in routeValues)
          routeValues1.Add(routeValue.Key, routeValue.Value);
      }
      return url.Action(actionName, controllerName.Replace("Controller", ""), routeValues1);
    }

    internal static void SearchAction<AttributeType>(
      Guid entityTypeUid,
      out string actionName,
      out string controllerName,
      out string areaName,
      out AttributeType attr)
    {
      actionName = "";
      controllerName = "";
      areaName = "";
      attr = default (AttributeType);
      Type type1 = typeof (IBaseController<,>);
      foreach (Type extensionPointType in ComponentManager.Current.GetExtensionPointTypes(type1))
      {
        Type type2 = extensionPointType.GetInterface(type1.FullName);
        if (type2 != (Type) null && type2.IsGenericType && !type2.IsGenericTypeDefinition && type2.GetGenericTypeDefinition() == type1)
        {
          Guid guid = InterfaceActivator.UID(type2.GetGenericArguments()[0]);
          if (entityTypeUid == guid)
          {
            object obj = ((IEnumerable<object>) extensionPointType.GetCustomAttributes(typeof (RouteAreaAttribute), false)).FirstOrDefault<object>();
            if (obj != null)
              areaName = ((RouteAreaAttribute) obj).AreaName;
            foreach (MethodInfo method in extensionPointType.GetMethods())
            {
              attr = (AttributeType) ((IEnumerable<object>) method.GetCustomAttributes(typeof (AttributeType), false)).FirstOrDefault<object>();
              if ((object) attr != null)
              {
                actionName = method.Name;
                controllerName = extensionPointType.Name;
                break;
              }
            }
          }
        }
      }
    }

    public static ToolbarButtonsBuilder ToolbarCreateRelationships(
      this ToolbarButtonsBuilder builder,
      object routeValues)
    {
      return UIExtensions.CreateRelationshipsLinks<ToolbarButtonsBuilder>(builder, new RouteValueDictionary(routeValues), builder.HtmlHelper, false, (Func<ToolbarButtonsBuilder, ClassMetadata, RelationshipCreateAttribute, string, ToolbarButtonsBuilder>) ((b, md, attr, createUrl) =>
      {
        b.Link(createUrl).Text(EleWise.ELMA.SR.T(md.DisplayName)).ToolTip(EleWise.ELMA.SR.T(md.DisplayName)).IconUrl(attr.ImageUrl).Uid(string.Format("toolbar-action-Create{0}", (object) md.Name));
        return builder;
      }));
    }

    public static ToolbarGroupBuilder ToolbarCreateRelationships(
      this ToolbarGroupBuilder builder,
      object routeValues)
    {
      return builder.ToolbarCreateRelationships(new RouteValueDictionary(routeValues), false);
    }

    public static ToolbarGroupBuilder ToolbarCreateRelationships(
      this ToolbarGroupBuilder builder,
      RouteValueDictionary routeValues,
      bool all = false)
    {
      return UIExtensions.CreateRelationshipsLinks<ToolbarGroupBuilder>(builder, routeValues, builder.HtmlHelper, all, (Func<ToolbarGroupBuilder, ClassMetadata, RelationshipCreateAttribute, string, ToolbarGroupBuilder>) ((b, md, attr, createUrl) => b.ToolbarLink(EleWise.ELMA.SR.T(md.DisplayName), EleWise.ELMA.SR.T(md.DisplayName), attr.ImageUrl, createUrl, string.Format("toolbar-action-Create{0}", (object) md.Name))));
    }

    private static T CreateRelationshipsLinks<T>(
      T builder,
      RouteValueDictionary routeValues,
      HtmlHelper htmlHelper,
      bool all,
      Func<T, ClassMetadata, RelationshipCreateAttribute, string, T> func)
    {
      foreach (ClassMetadata classMetadata in Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList().Where<IMetadata>((Func<IMetadata, bool>) (m => m is ClassMetadata && ((ClassMetadata) m).BaseClassUid == InterfaceActivator.UID<IRelationship>())).Cast<ClassMetadata>())
      {
        RelationshipCreateAttribute attr;
        string str = htmlHelper.Url().EntityAction<RelationshipCreateAttribute>(classMetadata.Uid, out attr, routeValues);
        if (attr != null && !attr.ToActions | all)
          builder = func(builder, classMetadata, attr, str);
      }
      return builder;
    }

    public static List<IActionItem> ToolbarCreateRelationshipsToActionsList(
      HtmlHelper htmlHelper,
      object routeValues,
      bool all = false)
    {
      List<IActionItem> relationshipsToActionsList = new List<IActionItem>();
      foreach (ClassMetadata classMetadata in Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList().Where<IMetadata>((Func<IMetadata, bool>) (m => m is ClassMetadata && ((ClassMetadata) m).BaseClassUid == InterfaceActivator.UID<IRelationship>())).Cast<ClassMetadata>())
      {
        RelationshipCreateAttribute attr;
        string str = htmlHelper.Url().EntityAction<RelationshipCreateAttribute>(classMetadata.Uid, out attr, new RouteValueDictionary(routeValues));
        if (attr != null && attr.ToActions | all)
        {
          List<IActionItem> actionItemList = relationshipsToActionsList;
          ActionToolbarItem actionToolbarItem = new ActionToolbarItem();
          actionToolbarItem.Uid = "toolbar-button-" + (object) classMetadata.Uid;
          actionToolbarItem.Text = EleWise.ELMA.SR.T(attr.Name);
          actionToolbarItem.IconUrl = string.IsNullOrWhiteSpace(attr.SmallImageUrl) ? attr.ImageUrl : attr.SmallImageUrl;
          actionToolbarItem.Url = str;
          actionItemList.Add((IActionItem) actionToolbarItem);
        }
      }
      return relationshipsToActionsList;
    }
  }
}
