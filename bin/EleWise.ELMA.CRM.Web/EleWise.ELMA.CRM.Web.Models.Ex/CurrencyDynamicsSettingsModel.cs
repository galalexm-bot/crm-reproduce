using System;
using System.Collections.Generic;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.CRM.Web.Models.ExchangeRates;

public class CurrencyDynamicsSettingsModel
{
	[DisplayName(typeof(__Resources_CurrencyDynamicsSettingsModel), "P_StartDate_DisplayName")]
	[DateTimeSettings(ShowDate = true, ShowTime = false)]
	public DateTime StartDate { get; set; }

	[DisplayName(typeof(__Resources_CurrencyDynamicsSettingsModel), "P_EndDate_DisplayName")]
	[DateTimeSettings(ShowDate = true, ShowTime = false)]
	public DateTime EndDate { get; set; }

	public IEnumerable<CurrencyImportGridRowModel> Items { get; set; }

	public CurrencyDynamicsSettingsModel()
	{
		Items = new List<CurrencyImportGridRowModel>();
	}
}
