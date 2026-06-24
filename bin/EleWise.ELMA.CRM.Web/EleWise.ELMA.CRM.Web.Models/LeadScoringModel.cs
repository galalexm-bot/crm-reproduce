using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.CRM.Web.Models;

public class LeadScoringModel
{
	public LeadScoringSettings Entity { get; set; }

	[DisplayName(typeof(LeadScoringModel_SR), "Property")]
	public Guid Property { get; set; }

	[DisplayName(typeof(LeadScoringModel_SR), "ContractorProperty")]
	public Guid ContractorProperty { get; set; }

	[DisplayName(typeof(LeadScoringModel_SR), "Operator")]
	public LeadCompareType Operator { get; set; }

	[DisplayName(typeof(LeadScoringModel_SR), "LeadPercentValue")]
	public long LeadPercentValue { get; set; }

	[Required(false)]
	[DisplayName(typeof(LeadScoringModel_SR), "ContractorPercentValue")]
	public long ContractorPercentValue { get; set; }

	[DisplayName(typeof(LeadScoringModel_SR), "UseLeadContactProperty")]
	public bool UseLeadContactProperty { get; set; }

	[DisplayName(typeof(LeadScoringModel_SR), "LeadContactProperty")]
	public Guid LeadContactProperty { get; set; }

	[DisplayName(typeof(LeadScoringModel_SR), "UseContractorContactProperty")]
	public bool UseContractorContactProperty { get; set; }

	[DisplayName(typeof(LeadScoringModel_SR), "ContractorContactProperty")]
	public Guid ContractorContactProperty { get; set; }

	public List<SelectListItem> LeadPropertyList => (MetadataLoader.LoadMetadata(InterfaceActivator.TypeOf<ILead>()) as EntityMetadata).Properties.OfType<EntityPropertyMetadata>().Select((Func<EntityPropertyMetadata, SelectListItem>)delegate(EntityPropertyMetadata s)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		SelectListItem val = new SelectListItem();
		val.set_Value(s.Uid.ToString());
		val.set_Text(s.DisplayName);
		val.set_Selected(s.Uid == Property);
		return val;
	}).ToList();

	public List<SelectListItem> ContractorPropertyList => (MetadataLoader.LoadMetadata(InterfaceActivator.TypeOf<IContractor>()) as EntityMetadata).Properties.OfType<EntityPropertyMetadata>().Select((Func<EntityPropertyMetadata, SelectListItem>)delegate(EntityPropertyMetadata s)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		SelectListItem val = new SelectListItem();
		val.set_Value(s.Uid.ToString());
		val.set_Text(s.DisplayName);
		val.set_Selected(s.Uid == LeadContactProperty);
		return val;
	}).ToList();

	public List<SelectListItem> LeadContactPropertyList => (MetadataLoader.LoadMetadata(InterfaceActivator.TypeOf<ILeadContact>()) as EntityMetadata).Properties.OfType<EntityPropertyMetadata>().Select((Func<EntityPropertyMetadata, SelectListItem>)delegate(EntityPropertyMetadata s)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		SelectListItem val = new SelectListItem();
		val.set_Value(s.Uid.ToString());
		val.set_Text(s.DisplayName);
		val.set_Selected(s.Uid == ContractorProperty);
		return val;
	}).ToList();

	public List<SelectListItem> ContractorContactPropertyList => (MetadataLoader.LoadMetadata(InterfaceActivator.TypeOf<IContact>()) as EntityMetadata).Properties.OfType<EntityPropertyMetadata>().Select((Func<EntityPropertyMetadata, SelectListItem>)delegate(EntityPropertyMetadata s)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		SelectListItem val = new SelectListItem();
		val.set_Value(s.Uid.ToString());
		val.set_Text(s.DisplayName);
		val.set_Selected(s.Uid == ContractorContactProperty);
		return val;
	}).ToList();

	public LeadScoringModel()
	{
		Entity = new LeadScoringSettings();
	}

	public LeadScoringModel(long id)
	{
		Entity = LeadScoringSettings.LoadScoringSetting(id);
		Property = Entity.Property;
		ContractorProperty = Entity.ContractorProperty;
		Operator = Entity.Operator;
		LeadPercentValue = Entity.LeadPercentValue;
		ContractorPercentValue = Entity.ContractorPercentValue;
		UseLeadContactProperty = Entity.UseLeadContactProperty;
		LeadContactProperty = Entity.LeadContactProperty;
		UseContractorContactProperty = Entity.UseContractorContactProperty;
		ContractorContactProperty = Entity.ContractorContactProperty;
	}

	public void Save()
	{
		Entity.Property = Property;
		Entity.ContractorProperty = ContractorProperty;
		Entity.Operator = Operator;
		Entity.LeadPercentValue = LeadPercentValue;
		Entity.ContractorPercentValue = ContractorPercentValue;
		Entity.UseLeadContactProperty = UseLeadContactProperty;
		Entity.LeadContactProperty = (UseLeadContactProperty ? LeadContactProperty : Guid.Empty);
		Entity.UseContractorContactProperty = UseContractorContactProperty;
		Entity.ContractorContactProperty = (UseContractorContactProperty ? ContractorContactProperty : Guid.Empty);
		Entity.Save();
	}
}
