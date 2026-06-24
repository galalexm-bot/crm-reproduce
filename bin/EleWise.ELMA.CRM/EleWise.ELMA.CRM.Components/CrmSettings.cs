using System;
using System.Web.Mvc;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Settings;

namespace EleWise.ELMA.CRM.Components;

public class CrmSettings : GlobalSettingsBase
{
	[HiddenInput(DisplayValue = false)]
	[DisplayName(typeof(CrmSettings_SR), "DefaultSaleCurrency")]
	public ICurrency DefaultSaleCurrency
	{
		get
		{
			return AbstractNHEntityManager<ICurrency, long>.Instance.LoadOrNull(DefaultSaleCurrencyUid);
		}
		set
		{
			DefaultSaleCurrencyUid = value?.Uid ?? Guid.Empty;
		}
	}

	public Guid DefaultSaleCurrencyUid { get; set; }

	[HiddenInput(DisplayValue = false)]
	[DisplayName(typeof(CrmSettings_SR), "DefaultSaleType")]
	public ISaleType DefaultSaleType
	{
		get
		{
			return AbstractNHEntityManager<ISaleType, long>.Instance.LoadOrNull(DefaultSaleTypeUid);
		}
		set
		{
			DefaultSaleTypeUid = value?.Uid ?? Guid.Empty;
		}
	}

	public Guid DefaultSaleTypeUid { get; set; }

	[DisplayName(typeof(CrmSettings_SR), "Tasks_AllowSelectEntity")]
	public bool Tasks_AllowSelectEntity { get; set; }

	[DisplayName(typeof(CrmSettings_SR), "TasksGrid_ShowCompleted")]
	public bool TasksGrid_ShowCompleted { get; set; }

	[DisplayName(typeof(CrmSettings_SR), "LeadSearchDublicate")]
	public bool LeadSearchDublicate { get; set; }

	[DisplayName(typeof(CrmSettings_SR), "DefaultLeadStatus")]
	public LeadStatus DefaultLeadStatus { get; set; }

	[DisplayName(typeof(CrmSettings_SR), "RelationshipEditPermissionCheck")]
	public RelationshipEditPermissionCheckEnum RelationshipEditPermissionCheck { get; set; }

	[HiddenInput(DisplayValue = false)]
	[DisplayName(typeof(CrmSettings_SR), "DefaultCountry")]
	public ICountry DefaultCountry
	{
		get
		{
			return AbstractNHEntityManager<ICountry, long>.Instance.LoadOrNull(DefaultCountryUid);
		}
		set
		{
			DefaultCountryUid = value?.Uid ?? Guid.Empty;
		}
	}

	public Guid DefaultCountryUid { get; set; }

	public CrmSettings()
	{
		Tasks_AllowSelectEntity = false;
		TasksGrid_ShowCompleted = false;
		DefaultLeadStatus = LeadStatus.InHand;
		LeadSearchDublicate = true;
		RelationshipEditPermissionCheck = RelationshipEditPermissionCheckEnum.EditPermission;
	}
}
