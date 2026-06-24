using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Extensions;
using EleWise.ELMA.CRM.Web.Extensions;
using EleWise.ELMA.CRM.Web.Models;

namespace EleWise.ELMA.CRM.Web.Components;

[Component(Order = 500)]
public class CrmModuleSettingsCurrencyItemProvider : ICrmModuleSettingsItemProvider
{
	public IEnumerable<CrmModuleSettingsItem> GetItems(UrlHelper urlHelper)
	{
		string category = SR.T("Импорт курсов валют");
		List<IExchangeCurrencyRateImportProvider> source = ComponentManager.Current.GetExtensionPoints<IExchangeCurrencyRateImportProvider>().ToList();
		List<CrmModuleSettingsItem> list = new List<CrmModuleSettingsItem>();
		if (source.Any())
		{
			list.AddRange(new List<CrmModuleSettingsItem>
			{
				new CrmModuleSettingsItem
				{
					Order = 43,
					Category = category,
					Text = SR.T("Импортировать динамику курса валюты"),
					Description = SR.T("Получение динамики (за период) ежедневных курсов валюты"),
					Url = urlHelper.Action("Index", "CurrencyDynamics", (object)new
					{
						area = "EleWise.ELMA.CRM.Web"
					})
				},
				new CrmModuleSettingsItem
				{
					Order = 44,
					Category = category,
					Text = SR.T("Автоматическое регулярное получение курсов валют"),
					Description = SR.T("Автоматическое регулярное получение курсов валют"),
					Url = urlHelper.Action("Index", "AutomaticCurrencyImport", (object)new
					{
						area = "EleWise.ELMA.CRM.Web"
					})
				}
			});
			if (source.Any((IExchangeCurrencyRateImportProvider p) => p.CanFillingCurrencies))
			{
				list.Add(new CrmModuleSettingsItem
				{
					Order = 42,
					Category = category,
					Text = SR.T("Импортировать классификатор валют"),
					Description = SR.T("Заполнение/дополнение справочника валют"),
					Url = urlHelper.Action("Index", "CurrencyQualifier", (object)new
					{
						area = "EleWise.ELMA.CRM.Web"
					})
				});
			}
		}
		return list;
	}

	public IEnumerable<CrmModuleSettingsItem> GetObjects(UrlHelper urlHelper)
	{
		return new List<CrmModuleSettingsItem>();
	}
}
