// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.TasksGridViewItemRenderer
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.ViewItems;
using EleWise.ELMA.CRM.Web.Controllers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component]
  public class TasksGridViewItemRenderer : 
    ViewItemRendererBase<TasksGridViewItem>,
    ICountViewItemRenderer
  {
    public long? Count(object model, ICountViewItem viewItem)
    {
      ICRMTaskBaseFilter filter = TaskController.CreateFilter();
      filter.Contractor = model as IContractor;
      filter.Contact = model as IContact;
      filter.Lead = model as ILead;
      filter.Sale = model as ISale;
      return new long?(TaskBaseManager.Instance.Count((IEntityFilter) filter));
    }
  }
}
