// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.PropertyMarketingEffectIsEmpty
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Types;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component]
  public class PropertyMarketingEffectIsEmpty : IPropertyIsEmpty
  {
    private readonly Guid _marketingEffectGuid = new Guid("2c2ae8eb-9f42-4d3e-b990-157357c1a535");

    public bool? IsEmpty(PropertyViewItem propertyViewItem, object entity, EntityMetadata metadata)
    {
      if (metadata == null)
        return new bool?();
      IPropertyMetadata propertyMetadata = metadata.GetPropertiesAndTableParts().FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (p => p.PropertyUid == propertyViewItem.PropertyUid));
      if (propertyMetadata == null || propertyMetadata.SubTypeUid != this._marketingEffectGuid || !((MarketingEffectSettings) propertyMetadata.Settings).IsComposite)
        return new bool?();
      Guid[] marketingGuids = new Guid[3]
      {
        this._marketingEffectGuid,
        new Guid("53f2d16c-4d27-4891-a3ea-9f8fe7f68a00"),
        new Guid("c29d5357-56dc-4e65-9c89-91faed78abca")
      };
      IMetadataRuntimeService metadataService = Locator.GetServiceNotNull<IMetadataRuntimeService>();
      return new bool?(metadata.Properties.Where<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => ((IEnumerable<Guid>) marketingGuids).Contains<Guid>(p.SubTypeUid))).Select<PropertyMetadata, bool>((Func<PropertyMetadata, bool>) (prop => metadataService.GetTypeDescriptor(prop.TypeUid, prop.SubTypeUid).IsEmpty(prop, entity.GetPropertyValue(prop.Name, (object) null)))).Aggregate<bool>((Func<bool, bool, bool>) ((a, b) => a & b)));
    }
  }
}
