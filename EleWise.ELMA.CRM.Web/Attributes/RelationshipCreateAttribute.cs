// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Attributes.RelationshipCreateAttribute
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using System;

namespace EleWise.ELMA.CRM.Web.Attributes
{
  public class RelationshipCreateAttribute : Attribute
  {
    public string Name { get; set; }

    public string ImageUrl { get; set; }

    public string SmallImageUrl { get; set; }

    public bool ToActions { get; set; }

    public RelationshipCreateAttribute() => this.ToActions = false;
  }
}
