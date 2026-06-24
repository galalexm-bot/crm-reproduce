// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.SaleFunnelEditModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class SaleFunnelEditModel
  {
    public SaleFunnelEditModel()
    {
    }

    public SaleFunnelEditModel(ISaleFunnel funnel)
    {
      this.Entity = funnel;
      this.JsonData = SaleFunnelEditModel.Serialize((ICollection<ISaleStage>) funnel.SaleStages);
    }

    public ISaleFunnel Entity { get; set; }

    public string JsonData { get; set; }

    public static string Serialize(ICollection<ISaleStage> saleStages)
    {
      EntityJsonSerializer entityJsonSerializer = new EntityJsonSerializer();
      return new JsonSerializer().Serialize((object) saleStages.Select<ISaleStage, object>(new Func<ISaleStage, object>(entityJsonSerializer.ConvertToSerializable)).ToArray<object>());
    }

    public static List<ISaleStage> Deserialize(string saleStages, bool loadEntityIfExists = true)
    {
      ExpandoObject[] source = new JsonSerializer().Deserialize<ExpandoObject[]>(saleStages);
      EntityJsonSerializer serializer = new EntityJsonSerializer();
      Func<ExpandoObject, ISaleStage> selector = (Func<ExpandoObject, ISaleStage>) (s => (ISaleStage) serializer.ConvertFromSerializable((IDictionary<string, object>) s, InterfaceActivator.TypeOf<ISaleStage>(), loadEntityIfExists));
      return ((IEnumerable<ExpandoObject>) source).Select<ExpandoObject, ISaleStage>(selector).ToList<ISaleStage>();
    }
  }
}
