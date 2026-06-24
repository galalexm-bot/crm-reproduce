using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using NHibernate.Criterion;

namespace EleWise.ELMA.CRM.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class ExchangeCurrencyRateManager : EntityManager<IExchangeCurrencyRate, long>
{
	private const string TableName = "ExchangeCurrencyRate";

	public new static ExchangeCurrencyRateManager Instance => Locator.GetServiceNotNull<ExchangeCurrencyRateManager>();

	private ITransformationProvider transformationProvider => Locator.GetServiceNotNull<ITransformationProvider>();

	public void Update(List<ExchangeCurrencyRateImportModel> values)
	{
		List<ExchangeCurrencyRateImportModel> list = values.Distinct(new ECRImportModelComparer()).ToList();
		IEnumerable<string> codes = list.Select((ExchangeCurrencyRateImportModel a) => a.CurrencyEstimated).Concat(list.Select((ExchangeCurrencyRateImportModel a) => a.CurrenctValuation));
		List<CurrencyHelpModel> source = CurrencyManager.Instance.GetCurrencyValuesByCodes(codes).ToList();
		DateTime? fromDate = list.Min((ExchangeCurrencyRateImportModel a) => a.ValuationDate);
		DateTime? toDate = list.Max((ExchangeCurrencyRateImportModel a) => a.ValuationDate);
		foreach (IGrouping<string, ExchangeCurrencyRateImportModel> item in from a in list
			group a by a.CurrencyEstimated)
		{
			DeleteOldExchangeRates(item.Select((ExchangeCurrencyRateImportModel a) => a.CurrenctValuation).ToList(), item.Key, fromDate, toDate);
		}
		DataTable dataTable = new DataTable("ExchangeCurrencyRate");
		dataTable.Columns.Add("Id", typeof(long));
		dataTable.Columns.Add("Uid", typeof(Guid));
		dataTable.Columns.Add("CurrencyEstimated", typeof(long));
		dataTable.Columns.Add("CurrencyValuation", typeof(long));
		dataTable.Columns.Add("Nominal", typeof(long));
		dataTable.Columns.Add("ExchangeRate", typeof(double));
		dataTable.Columns.Add("ValuationDate", typeof(DateTime));
		foreach (ExchangeCurrencyRateImportModel val in list)
		{
			DataRow dataRow = dataTable.NewRow();
			dataRow["Uid"] = Guid.NewGuid();
			dataRow["CurrencyEstimated"] = source.FirstOrDefault((CurrencyHelpModel a) => a.Code == val.CurrencyEstimated).Id;
			dataRow["CurrencyValuation"] = source.FirstOrDefault((CurrencyHelpModel a) => a.Code == val.CurrenctValuation).Id;
			dataRow["Nominal"] = val.Nominal;
			dataRow["ExchangeRate"] = val.ExchangeRate;
			dataRow["ValuationDate"] = val.ValuationDate;
			dataTable.Rows.Add(dataRow);
		}
		if (dataTable.Rows.Count > 0)
		{
			transformationProvider.BulkInsert("ExchangeCurrencyRate", dataTable);
		}
	}

	public void DeleteOldExchangeRates(IEnumerable<string> currencyValuationCodes, string currencyEstimatedCode, DateTime? fromDate = null, DateTime? toDate = null)
	{
		Dictionary<string, object> parameters = new Dictionary<string, object> { { "currencyEstimated", currencyEstimatedCode } };
		int i = 0;
		currencyValuationCodes = currencyValuationCodes.Distinct().ToList();
		currencyValuationCodes.Each(delegate(string a)
		{
			parameters.Add($"valCode{i++}", a);
		});
		i = 0;
		string[] array = new string[8]
		{
			transformationProvider.Dialect.QuoteIfNeeded("ExchangeCurrencyRate"),
			transformationProvider.ParameterSeparator,
			string.Join(",", currencyValuationCodes.Select((string a) => $"{transformationProvider.ParameterSeparator}valCode{i++}")),
			transformationProvider.Dialect.QuoteIfNeeded("CurrencyValuation"),
			transformationProvider.Dialect.QuoteIfNeeded("CurrencyEstimated"),
			transformationProvider.Dialect.QuoteIfNeeded("Currency"),
			transformationProvider.Dialect.QuoteIfNeeded("Id"),
			transformationProvider.Dialect.QuoteIfNeeded("CodeISOAlphabetic")
		};
		object[] args = array;
		string text = string.Format("DELETE FROM {0} WHERE {4} IN (Select {6} FROM {5} WHERE {7} = {1}currencyEstimated) AND {3} IN (Select {6} FROM {5} WHERE {7} in ({2}))", args);
		if (toDate.HasValue && fromDate.HasValue)
		{
			parameters.Add("fromDate", fromDate.Value);
			parameters.Add("toDate", toDate.Value);
			text += string.Format(" AND {1} >= {0}fromDate AND {1} <= {0}toDate", transformationProvider.ParameterSeparator, transformationProvider.Dialect.QuoteIfNeeded("ValuationDate"));
		}
		transformationProvider.ExecuteNonQuery(text, parameters);
	}

	public void DeleteExchangeRatesByCurrency(ICurrency currency)
	{
		if (currency != null)
		{
			string sql = string.Format("DELETE FROM {0} WHERE {1} = {3}currencyId OR {2} = {3}currencyId", transformationProvider.Dialect.QuoteIfNeeded("ExchangeCurrencyRate"), transformationProvider.Dialect.QuoteIfNeeded("CurrencyValuation"), transformationProvider.Dialect.QuoteIfNeeded("CurrencyEstimated"), transformationProvider.ParameterSeparator);
			transformationProvider.ExecuteNonQuery(sql, new Dictionary<string, object> { { "currencyId", currency.Id } });
		}
	}

	[PublicApiMember]
	public virtual IExchangeCurrencyRate GetExchangeRate(ICurrency currencyEstimated, ICurrency currencyValuation, DateTime date)
	{
		if (currencyEstimated == null)
		{
			throw new ArgumentNullException("currencyEstimated");
		}
		if (currencyValuation == null)
		{
			throw new ArgumentNullException("currencyValuation");
		}
		return (IExchangeCurrencyRate)CreateCriteria().Add((ICriterion)(object)Restrictions.Eq((IProjection)(object)ProjectionFor((IExchangeCurrencyRate h) => h.CurrencyEstimated), (object)currencyEstimated)).Add((ICriterion)(object)Restrictions.Eq((IProjection)(object)ProjectionFor((IExchangeCurrencyRate h) => h.CurrencyValuation), (object)currencyValuation)).Add((ICriterion)(object)Restrictions.Eq((IProjection)(object)ProjectionFor((IExchangeCurrencyRate h) => h.ValuationDate), (object)date))
			.AddOrder(Order.Desc((IProjection)(object)ProjectionFor((IExchangeCurrencyRate h) => h.ValuationDate)))
			.UniqueResult();
	}

	[PublicApiMember]
	public virtual double RecalculationSum(IExchangeCurrencyRate currencyRate, double amounts)
	{
		if (currencyRate == null)
		{
			throw new ArgumentNullException("currencyRate");
		}
		if (amounts <= 0.0)
		{
			throw new ArgumentException(SR.T("Исходная сумма должна быть больше 0"));
		}
		if (!currencyRate.RateToNominal.HasValue)
		{
			throw new Exception(SR.T("В курсе валют \"{0}\" не заполнено свойство \"Курс к номиналу\", необходимое для перерасчета", currencyRate.Name));
		}
		return currencyRate.RateToNominal.Value * amounts;
	}
}
