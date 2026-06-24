using System;
using System.Web.Mvc;
using EleWise.ELMA.CRM.Enums.ExchangeRates;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.CRM.Components;

public class CurrencyExchangeImportSettings : GlobalSettingsBase
{
	[DisplayName(typeof(__Resources_AutomaticCurrencyImportSettings), "P_ValueStorageForExchangeRates")]
	public ValueStorageForExchangeRates ValueStorage { get; set; }

	[DisplayName(typeof(__Resources_AutomaticCurrencyImportSettings), "P_UpdateTimeForDailyRates")]
	public DateTime UpdateTimeForDailyRates { get; set; }

	public long GroupForNotificationId { get; set; }

	[HiddenInput(DisplayValue = false)]
	[DisplayName(typeof(__Resources_AutomaticCurrencyImportSettings), "P_GroupsForNotification")]
	public IUserGroup GroupForNotification
	{
		get
		{
			if (GroupForNotificationId == 0L)
			{
				return null;
			}
			return UserGroupManager.Instance.Load(GroupForNotificationId);
		}
		set
		{
			GroupForNotificationId = value?.Id ?? 0;
		}
	}

	public CurrencyExchangeImportSettings()
	{
		ValueStorage = ValueStorageForExchangeRates.WhithoutRemoving;
		UpdateTimeForDailyRates = DateTime.Today;
		IUserGroup userGroup = UserGroupManager.Instance.LoadOrNull(SecurityConstants.AdminGroupUid);
		if (userGroup != null)
		{
			GroupForNotificationId = userGroup.Id;
		}
	}
}
