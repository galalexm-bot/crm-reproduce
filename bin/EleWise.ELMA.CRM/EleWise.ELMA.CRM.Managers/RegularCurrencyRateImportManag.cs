using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;

namespace EleWise.ELMA.CRM.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class RegularCurrencyRateImportManager : EntityManager<IRegularCurrencyRateImport, long>
{
	private const string TableName = "RegularCurrencyRateImport";

	public new static RegularCurrencyRateImportManager Instance => Locator.GetServiceNotNull<RegularCurrencyRateImportManager>();

	private ITransformationProvider transformationProvider => Locator.GetServiceNotNull<ITransformationProvider>();

	public IEnumerable<CurrencyImportGridRowModel> GetAllRowsForGrid(IEnumerable<Guid> providersGuids = null)
	{
		ICriteria val = CreateCriteria().CreateAlias("CurrencyEstimated", "Estimated").CreateAlias("CurrencyValuation", "Valuation").SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property("Id"), "Id").Add((IProjection)(object)Projections.Property("Uid"), "Uid")
			.Add((IProjection)(object)Projections.Property("Provider"), "Provider")
			.Add((IProjection)(object)Projections.Property("Estimated.CodeISOAlphabetic"), "EstimatedCode")
			.Add((IProjection)(object)Projections.Property("Valuation.CodeISOAlphabetic"), "ValuationCode") });
		if (providersGuids != null)
		{
			val.Add((ICriterion)(object)Restrictions.In((IProjection)(object)ProjectionFor((IRegularCurrencyRateImport a) => a.Provider), (ICollection)providersGuids.ToList()));
		}
		return val.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(CurrencyImportGridRowModel))).List<CurrencyImportGridRowModel>();
	}

	public void RemoveByIdsArray(long[] idsArray)
	{
		if (idsArray != null && idsArray.Any())
		{
			for (int i = 0; i < idsArray.Count(); i += 1000)
			{
				IQuery obj = base.Session.CreateQuery(string.Format("DELETE FROM {0} WHERE {1} IN (:ids)", transformationProvider.Dialect.QuoteIfNeeded("RegularCurrencyRateImport"), transformationProvider.Dialect.QuoteIfNeeded("id")));
				obj.SetParameterList("ids", (IEnumerable)idsArray.Skip(i).Take(1000));
				obj.ExecuteUpdate();
			}
		}
	}

	public void Update(IEnumerable<CurrencyImportGridRowModel> values)
	{
		values = values.Where((CurrencyImportGridRowModel a) => !string.IsNullOrEmpty(a.EstimatedCode) && !string.IsNullOrEmpty(a.ValuationCode)).ToList();
		DataTable dataTable = new DataTable("RegularCurrencyRateImport");
		dataTable.Columns.Add("Id", typeof(long));
		dataTable.Columns.Add("Uid", typeof(Guid));
		dataTable.Columns.Add("CurrencyEstimated", typeof(long));
		dataTable.Columns.Add("CurrencyValuation", typeof(long));
		dataTable.Columns.Add("Provider", typeof(Guid));
		List<CurrencyImportGridRowModel> list = values.Where((CurrencyImportGridRowModel a) => a.Id == 0).ToList();
		IEnumerable<CurrencyHelpModel> currencyValuesByCodes = CurrencyManager.Instance.GetCurrencyValuesByCodes(values.Select((CurrencyImportGridRowModel a) => a.EstimatedCode).Concat(values.Select((CurrencyImportGridRowModel a) => a.ValuationCode)));
		foreach (CurrencyImportGridRowModel val2 in list)
		{
			DataRow dataRow = dataTable.NewRow();
			dataRow["Uid"] = Guid.NewGuid();
			CurrencyHelpModel currencyHelpModel = currencyValuesByCodes.First((CurrencyHelpModel a) => a.Code == val2.EstimatedCode);
			CurrencyHelpModel currencyHelpModel2 = currencyValuesByCodes.First((CurrencyHelpModel a) => a.Code == val2.ValuationCode);
			dataRow["CurrencyEstimated"] = currencyHelpModel.Id;
			dataRow["CurrencyValuation"] = currencyHelpModel2.Id;
			dataRow["Provider"] = (val2.Provider.HasValue ? val2.Provider.Value : Guid.Empty);
			dataTable.Rows.Add(dataRow);
		}
		if (dataTable.Rows.Count > 0)
		{
			transformationProvider.BulkInsert("RegularCurrencyRateImport", dataTable);
		}
		dataTable.Rows.Clear();
		foreach (CurrencyImportGridRowModel val in values.Where((CurrencyImportGridRowModel a) => a.Id != 0).ToList())
		{
			DataRow dataRow2 = dataTable.NewRow();
			CurrencyHelpModel currencyHelpModel3 = currencyValuesByCodes.First((CurrencyHelpModel a) => a.Code == val.EstimatedCode);
			CurrencyHelpModel currencyHelpModel4 = currencyValuesByCodes.First((CurrencyHelpModel a) => a.Code == val.ValuationCode);
			dataRow2["CurrencyEstimated"] = currencyHelpModel3.Id;
			dataRow2["CurrencyValuation"] = currencyHelpModel4.Id;
			dataRow2["Provider"] = val.Provider;
			dataRow2["Id"] = val.Id;
			dataRow2["Uid"] = val.Uid;
			dataTable.Rows.Add(dataRow2);
		}
		if (dataTable.Rows.Count > 0)
		{
			transformationProvider.BulkUpdate("RegularCurrencyRateImport", dataTable);
		}
	}
}
