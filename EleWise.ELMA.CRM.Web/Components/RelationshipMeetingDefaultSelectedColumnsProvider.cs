// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.RelationshipMeetingDefaultSelectedColumnsProvider
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
  public class RelationshipMeetingDefaultSelectedColumnsProvider : IDefaultSelectedColumnsProvider
  {
    public Type EntityType => typeof (IRelationshipMeeting);

    public List<KeyValuePair<PropertyMetadata, EntityMetadata>> GetProperties()
    {
      List<KeyValuePair<PropertyMetadata, EntityMetadata>> properties = new List<KeyValuePair<PropertyMetadata, EntityMetadata>>();
      EntityMetadata entityMetadata = (EntityMetadata) InterfaceActivator.LoadMetadata<IRelationshipMeeting>();
      PropertyMetadata key = entityMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.Name == "TimeNotSet"));
      if (key != null)
        properties.Add(new KeyValuePair<PropertyMetadata, EntityMetadata>(key, entityMetadata));
      return properties;
    }
  }
}
