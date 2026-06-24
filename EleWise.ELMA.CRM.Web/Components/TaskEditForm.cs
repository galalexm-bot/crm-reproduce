// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.TaskEditForm
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component(EnableInterceptiors = false, InjectProerties = false, Order = 10)]
  public class TaskEditForm : IExtensionZone
  {
    private static readonly List<string> zones = new List<string>()
    {
      "EleWise.ELMA.BPM.Web.Tasks.EditForm"
    };

    public bool CanRenderInZone(string zoneId, HtmlHelper html) => TaskEditForm.zones.Contains(zoneId);

    public void RenderZone(string zoneId, HtmlHelper html)
    {
      if (!TaskEditForm.zones.Contains(zoneId) || !(html.ViewData.Model is TaskModel model) || !(((EntityModel<ITask>) model).Entity is ICRMTaskBase entity))
        return;
      if (Locator.GetServiceNotNull<CrmSettingsModule>().Settings.Tasks_AllowSelectEntity)
        html.RenderPartial("TaskEntitySelector", (object) entity, new ViewDataDictionary()
        {
          TemplateInfo = new TemplateInfo()
          {
            HtmlFieldPrefix = "Entity"
          }
        });
      else
        html.RenderPartial("TaskEntityDisplay", (object) entity, new ViewDataDictionary()
        {
          TemplateInfo = new TemplateInfo()
          {
            HtmlFieldPrefix = "Entity"
          }
        });
    }
  }
}
