using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Enums.ExchangeRates;
using EleWise.ELMA.CRM.Extensions;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Components;

public static class CurrencyImportHelper
{
	public static IEnumerable<string> GetCurrencyEstimatedCodes(this IExchangeCurrencyRateImportProvider provider)
	{
		return GetCurrencyCodes(string.Concat(provider.Uid, "_CurrencyRateImport_CurrenciesEstimated"), provider, (IExchangeCurrencyRateImportProvider p) => p.CurrenciesEstimated);
	}

	public static IEnumerable<string> GetCurrencyValuationCodes(this IExchangeCurrencyRateImportProvider provider)
	{
		return GetCurrencyCodes(string.Concat(provider.Uid, "_CurrencyRateImport_CurrenciesValuation"), provider, (IExchangeCurrencyRateImportProvider p) => p.CurrenciesValuation);
	}

	private static IEnumerable<string> GetCurrencyCodes(string key, IExchangeCurrencyRateImportProvider prov, Func<IExchangeCurrencyRateImportProvider, IEnumerable<string>> currencies)
	{
		IMemoryCacheService serviceNotNull = Locator.GetServiceNotNull<IMemoryCacheService>();
		if (!serviceNotNull.TryGetValue<List<string>>(key, out var result) || result == null)
		{
			try
			{
				result = currencies(prov).ToList();
				serviceNotNull.Insert(key, result, new TimeSpan(1, 0, 0, 0));
			}
			catch (Exception ex)
			{
				Logger.Log.Error(ex.Message, ex);
				serviceNotNull.Insert(key, result, new TimeSpan(0, 0, 5, 0));
			}
		}
		return CurrencyManager.Instance.GetAvalailableCodes(result);
	}

	private static void SendMessages(IEnumerable<string> messages)
	{
		IEnumerable<IUser> users = GetUsers();
		if (users != null && users.Any())
		{
			string fullMessage = messages.ToSeparatedString("\n");
			IChannelMessage serviceNotNull = Locator.GetServiceNotNull<IChannelMessage>();
			serviceNotNull.Subject = SR.T("Ошибка обновления курсов валют");
			serviceNotNull.CreationDate = DateTime.Now;
			serviceNotNull.FullMessage = fullMessage;
			((ISet<IUser>)serviceNotNull.Recipients).AddAll(users);
			serviceNotNull.Save();
		}
	}

	private static IEnumerable<IUser> GetUsers()
	{
		IUserGroup groupForNotification = Locator.GetServiceNotNull<CurrencyExchangeImportModule>().Settings.GroupForNotification;
		if (groupForNotification != null)
		{
			long[] idArray = UserGroupManager.Instance.GetUsersByGroup(groupForNotification.Id).ToArray();
			return UserManager.Instance.FindByIdArray(idArray);
		}
		return null;
	}

	public static IEnumerable<string> UpdateCurrenciesRates(IEnumerable<CurrencyImportGridRowModel> currenciesForRateImport, ValueStorageForExchangeRates valueStorage, DateTime fromDate, DateTime toDate)
	{
		IEnumerable<IExchangeCurrencyRateImportProvider> extensionPoints = ComponentManager.Current.GetExtensionPoints<IExchangeCurrencyRateImportProvider>();
		List<string> list = new List<string>();
		foreach (IExchangeCurrencyRateImportProvider item in extensionPoints)
		{
			IExchangeCurrencyRateImportProvider provider = item;
			List<CurrencyImportGridRowModel> source = currenciesForRateImport.Where(delegate(CurrencyImportGridRowModel a)
			{
				Guid? provider2 = a.Provider;
				Guid uid = provider.Uid;
				if (!provider2.HasValue)
				{
					return false;
				}
				return !provider2.HasValue || provider2.GetValueOrDefault() == uid;
			}).ToList();
			if (!source.Any())
			{
				continue;
			}
			foreach (IGrouping<string, CurrencyImportGridRowModel> item2 in from a in source
				group a by a.EstimatedCode)
			{
				IEnumerable<string> enumerable = item2.Select((CurrencyImportGridRowModel a) => a.ValuationCode);
				List<string> list2 = new List<string>();
				try
				{
					list2 = provider.FillСurrencyDynamics(enumerable, item2.Key, fromDate, toDate).ToList();
				}
				catch (Exception ex)
				{
					Logger.Log.Error(ex.Message, ex);
					list.Add(ex.Message);
				}
				if (list2.Any())
				{
					if (valueStorage == ValueStorageForExchangeRates.Current)
					{
						ExchangeCurrencyRateManager.Instance.DeleteOldExchangeRates(enumerable, item2.Key);
					}
					list.AddRange(list2);
				}
			}
		}
		if (list.Any())
		{
			SendMessages(list);
		}
		return list;
	}
}
