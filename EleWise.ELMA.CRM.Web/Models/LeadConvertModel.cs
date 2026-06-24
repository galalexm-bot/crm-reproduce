// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.LeadConvertModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Html;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class LeadConvertModel : EntityModel<ILead>
  {
    public LeadConvertModel()
    {
      ClassMetadata metadata1 = (ClassMetadata) MetadataLoader.LoadMetadata(InterfaceActivator.UID<IContractor>());
      ClassMetadata metadata2 = (ClassMetadata) MetadataLoader.LoadMetadata(InterfaceActivator.UID<IRelationship>());
      ClassMetadata classMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(InterfaceActivator.UID<ISale>());
      this.ContractorTypes = MetadataLoader.GetChildClasses(metadata1).Select<ClassMetadata, ExtendedSelectListItem>((Func<ClassMetadata, ExtendedSelectListItem>) (md =>
      {
        return new ExtendedSelectListItem()
        {
          Text = md.DisplayName,
          Value = md.Uid.ToString(),
          Selected = md.Uid == InterfaceActivator.UID<IContractorLegal>()
        };
      }));
      this.ConvertTypes = ((IEnumerable<ClassMetadata>) new ClassMetadata[1]
      {
        classMetadata
      }).Concat<ClassMetadata>((IEnumerable<ClassMetadata>) MetadataLoader.GetChildClasses(metadata2)).Concat<ClassMetadata>((IEnumerable<ClassMetadata>) new ClassMetadata[1]).Select<ClassMetadata, ExtendedSelectListItem>((Func<ClassMetadata, ExtendedSelectListItem>) (md =>
      {
        return new ExtendedSelectListItem()
        {
          Text = md != null ? md.DisplayName : EleWise.ELMA.SR.T("Не создавать"),
          Value = md != null ? md.Uid.ToString() : Guid.Empty.ToString(),
          Selected = md != null && md.Uid == InterfaceActivator.UID<ISale>(),
          HtmlAttributes = (object) new
          {
            onclick = "changeStep4(this)"
          }
        };
      }));
    }

    public IEnumerable<ExtendedSelectListItem> ContractorTypes { get; private set; }

    public Guid ContractorUid { get; set; }

    public IContractorBaseModel Contractor { get; set; }

    public IEnumerable<ExtendedSelectListItem> ConvertTypes { get; private set; }

    public Guid ConvertUid { get; set; }

    public List<IContact> Contacts { get; set; }

    public SaleModel Sale { get; set; }

    public IRelationshipBaseModel Relationship { get; set; }

    public string Comment { get; set; }

    public bool? RuntimeVersion2 { get; set; }
  }
}
