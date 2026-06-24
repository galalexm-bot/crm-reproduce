// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.RelationshipEditedPropertiesModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Models;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.CRM.Web.Models
{
  public sealed class RelationshipEditedPropertiesModel
  {
    public IRelationship OldEntity { get; set; }

    public IRelationship NewEntity { get; set; }

    public IList<PropertyMetadata> ChangedProperties { get; set; }

    public IList<IUser> OldEventUsers { get; set; }

    public IList<IUser> NewEventUsers { get; set; }

    public List<Guid> BaseProperties { get; set; }
  }
}
