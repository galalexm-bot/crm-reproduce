// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.SaleDefaultSelectedColumnsProvider
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component]
  public class SaleDefaultSelectedColumnsProvider : IDefaultSelectedColumnsProvider
  {
    public Type EntityType => typeof (ISale);

    public List<KeyValuePair<PropertyMetadata, EntityMetadata>> GetProperties()
    {
      List<KeyValuePair<PropertyMetadata, EntityMetadata>> properties = new List<KeyValuePair<PropertyMetadata, EntityMetadata>>();
      EntityMetadata entityMetadata = (EntityMetadata) InterfaceActivator.LoadMetadata<ISale>();
      PropertyMetadata key1 = entityMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.Name == "MarketingGroup"));
      if (key1 != null)
        properties.Add(new KeyValuePair<PropertyMetadata, EntityMetadata>(key1, entityMetadata));
      PropertyMetadata key2 = entityMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.Name == "MarketingActivity"));
      if (key2 != null)
        properties.Add(new KeyValuePair<PropertyMetadata, EntityMetadata>(key2, entityMetadata));
      PropertyMetadata key3 = entityMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.Name == "MarketingEffect"));
      if (key3 != null)
        properties.Add(new KeyValuePair<PropertyMetadata, EntityMetadata>(key3, entityMetadata));
      return properties;
    }
  }
}
