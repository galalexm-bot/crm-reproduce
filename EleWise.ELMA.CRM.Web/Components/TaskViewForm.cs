// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.TaskViewForm
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component(EnableInterceptiors = false, InjectProerties = false, Order = 10)]
  public class TaskViewForm : IExtensionZone
  {
    private static readonly List<string> zones = new List<string>()
    {
      "EleWise.ELMA.BPM.Web.Tasks.ViewForm-Right"
    };

    public bool CanRenderInZone(string zoneId, HtmlHelper html) => TaskViewForm.zones.Contains(zoneId);

    public void RenderZone(string zoneId, HtmlHelper html)
    {
      if (!TaskViewForm.zones.Contains(zoneId) || !(html.ViewData.Model is TaskViewModel model) || !(((EntityModel<ITaskBase>) model).Entity is ICRMTaskBase entity))
        return;
      if (entity.Contractor != null)
        html.ViewContext.Writer.Write((object) html.Property("Entity.Contractor"));
      if (entity.Contact != null)
        html.ViewContext.Writer.Write((object) html.Property("Entity.Contact"));
      if (entity.Lead != null)
        html.ViewContext.Writer.Write((object) html.Property("Entity.Lead"));
      if (entity.Sale == null)
        return;
      html.ViewContext.Writer.Write((object) html.Property("Entity.Sale"));
    }
  }
}
