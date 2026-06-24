// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.LeadScoringModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class LeadScoringModel
  {
    public LeadScoringModel() => this.Entity = new LeadScoringSettings();

    public LeadScoringModel(long id)
    {
      this.Entity = LeadScoringSettings.LoadScoringSetting(id);
      this.Property = this.Entity.Property;
      this.ContractorProperty = this.Entity.ContractorProperty;
      this.Operator = this.Entity.Operator;
      this.LeadPercentValue = this.Entity.LeadPercentValue;
      this.ContractorPercentValue = this.Entity.ContractorPercentValue;
      this.UseLeadContactProperty = this.Entity.UseLeadContactProperty;
      this.LeadContactProperty = this.Entity.LeadContactProperty;
      this.UseContractorContactProperty = this.Entity.UseContractorContactProperty;
      this.ContractorContactProperty = this.Entity.ContractorContactProperty;
    }

    public void Save()
    {
      this.Entity.Property = this.Property;
      this.Entity.ContractorProperty = this.ContractorProperty;
      this.Entity.Operator = this.Operator;
      this.Entity.LeadPercentValue = this.LeadPercentValue;
      this.Entity.ContractorPercentValue = this.ContractorPercentValue;
      this.Entity.UseLeadContactProperty = this.UseLeadContactProperty;
      this.Entity.LeadContactProperty = this.UseLeadContactProperty ? this.LeadContactProperty : Guid.Empty;
      this.Entity.UseContractorContactProperty = this.UseContractorContactProperty;
      this.Entity.ContractorContactProperty = this.UseContractorContactProperty ? this.ContractorContactProperty : Guid.Empty;
      this.Entity.Save();
    }

    public LeadScoringSettings Entity { get; set; }

    [DisplayName(typeof (LeadScoringModel_SR), "Property")]
    public Guid Property { get; set; }

    [DisplayName(typeof (LeadScoringModel_SR), "ContractorProperty")]
    public Guid ContractorProperty { get; set; }

    [DisplayName(typeof (LeadScoringModel_SR), "Operator")]
    public LeadCompareType Operator { get; set; }

    [DisplayName(typeof (LeadScoringModel_SR), "LeadPercentValue")]
    public long LeadPercentValue { get; set; }

    [Required(false)]
    [DisplayName(typeof (LeadScoringModel_SR), "ContractorPercentValue")]
    public long ContractorPercentValue { get; set; }

    [DisplayName(typeof (LeadScoringModel_SR), "UseLeadContactProperty")]
    public bool UseLeadContactProperty { get; set; }

    [DisplayName(typeof (LeadScoringModel_SR), "LeadContactProperty")]
    public Guid LeadContactProperty { get; set; }

    [DisplayName(typeof (LeadScoringModel_SR), "UseContractorContactProperty")]
    public bool UseContractorContactProperty { get; set; }

    [DisplayName(typeof (LeadScoringModel_SR), "ContractorContactProperty")]
    public Guid ContractorContactProperty { get; set; }

    public List<SelectListItem> LeadPropertyList => (MetadataLoader.LoadMetadata(InterfaceActivator.TypeOf<ILead>()) as EntityMetadata).Properties.OfType<EntityPropertyMetadata>().Select<EntityPropertyMetadata, SelectListItem>((Func<EntityPropertyMetadata, SelectListItem>) (s => new SelectListItem()
    {
      Value = s.Uid.ToString(),
      Text = s.DisplayName,
      Selected = s.Uid == this.Property
    })).ToList<SelectListItem>();

    public List<SelectListItem> ContractorPropertyList => (MetadataLoader.LoadMetadata(InterfaceActivator.TypeOf<IContractor>()) as EntityMetadata).Properties.OfType<EntityPropertyMetadata>().Select<EntityPropertyMetadata, SelectListItem>((Func<EntityPropertyMetadata, SelectListItem>) (s => new SelectListItem()
    {
      Value = s.Uid.ToString(),
      Text = s.DisplayName,
      Selected = s.Uid == this.LeadContactProperty
    })).ToList<SelectListItem>();

    public List<SelectListItem> LeadContactPropertyList => (MetadataLoader.LoadMetadata(InterfaceActivator.TypeOf<ILeadContact>()) as EntityMetadata).Properties.OfType<EntityPropertyMetadata>().Select<EntityPropertyMetadata, SelectListItem>((Func<EntityPropertyMetadata, SelectListItem>) (s => new SelectListItem()
    {
      Value = s.Uid.ToString(),
      Text = s.DisplayName,
      Selected = s.Uid == this.ContractorProperty
    })).ToList<SelectListItem>();

    public List<SelectListItem> ContractorContactPropertyList => (MetadataLoader.LoadMetadata(InterfaceActivator.TypeOf<IContact>()) as EntityMetadata).Properties.OfType<EntityPropertyMetadata>().Select<EntityPropertyMetadata, SelectListItem>((Func<EntityPropertyMetadata, SelectListItem>) (s => new SelectListItem()
    {
      Value = s.Uid.ToString(),
      Text = s.DisplayName,
      Selected = s.Uid == this.ContractorContactProperty
    })).ToList<SelectListItem>();
  }
}
