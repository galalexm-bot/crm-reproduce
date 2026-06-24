// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.EmailSetBinder
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Components
{
  public class EmailSetBinder : DefaultModelBinder
  {
    private RunWithSoftDeletableService runWithSoftDeletableService;

    private RunWithSoftDeletableService RunWithSoftDeletableService => this.runWithSoftDeletableService ?? (this.runWithSoftDeletableService = Locator.GetService<RunWithSoftDeletableService>());

    public override object BindModel(
      ControllerContext controllerContext,
      ModelBindingContext bindingContext)
    {
      bool turned = this.RunWithSoftDeletableService.Turned;
      this.RunWithSoftDeletableService.Turned = true;
      try
      {
        object source;
        try
        {
          source = base.BindModel(controllerContext, bindingContext);
        }
        catch
        {
          return (object) null;
        }
        if (!(source is IEnumerable))
          return source;
        List<IEmail> list = ((IEnumerable) source).Cast<IEmail>().Where<IEmail>((Func<IEmail, bool>) (q => q == null || string.IsNullOrWhiteSpace(q.EmailString))).ToList<IEmail>();
        if (!list.Any<IEmail>())
          return source;
        MethodInfo method = source.GetType().GetMethod("Remove", new Type[1]
        {
          InterfaceActivator.TypeOf<IEmail>()
        });
        foreach (IEmail email in list)
          method.Invoke(source, new object[1]
          {
            (object) email
          });
        return source;
      }
      finally
      {
        this.RunWithSoftDeletableService.Turned = turned;
      }
    }
  }
}
