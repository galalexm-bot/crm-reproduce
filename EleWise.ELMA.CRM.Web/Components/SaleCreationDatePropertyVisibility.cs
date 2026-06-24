// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.SaleCreationDatePropertyVisibility
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.Common.Extensions;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component]
  public class SaleCreationDatePropertyVisibility : IFilterPropertiesExtension
  {
    public bool Resolve(PropertyMetadata prop, ClassMetadata metadata) => false;

    public IEnumerable<FilterMetadataProperty> GetFilterMetadataProperties(
      IEntityFilter obj,
      PropertyMetadata prop,
      ClassMetadata metadata,
      string prefix,
      Guid? filterObjectTypeUid,
      Guid? filterCode,
      out bool addProperty)
    {
      throw new NotImplementedException();
    }

    public void UpdateProperties(
      Type type,
      Guid? filterObjectTypeUid,
      Guid? filterCode,
      List<FilterMetadataProperty> properties)
    {
      Guid? nullable = filterObjectTypeUid;
      Guid guid = InterfaceActivator.UID<ISale>();
      if ((nullable.HasValue ? (nullable.HasValue ? (nullable.GetValueOrDefault() != guid ? 1 : 0) : 0) : 1) != 0)
        return;
      Guid creationDatePropertyUid = InterfaceActivator.PropertyUid<ISaleFilter>((Expression<Func<ISaleFilter, object>>) (f => (object) f.CreationDate));
      properties.Where<FilterMetadataProperty>((Func<FilterMetadataProperty, bool>) (prop => prop.PropertyUid == creationDatePropertyUid)).Each<FilterMetadataProperty>((Action<FilterMetadataProperty>) (prop => prop.Visible = true));
    }
  }
}
