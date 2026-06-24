using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.Diagnostics.Metrics;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Reports.Excel;

public class MetricExcelTable<TMetric> : ExcelTable<KeyValuePair<string, TMetric>> where TMetric : IMetric
{
	private static object vm3oAwEEP1XUqTurlE4P;

	public new MetricExcelTable<TMetric> AddColumn<TValue>(string title, double width, Func<KeyValuePair<string, TMetric>, TValue> valueAccessor, IExcelCellFormat format = null)
	{
		base.Columns.Add(new Column<TValue>
		{
			Title = title,
			Width = width,
			ValueAccessor = valueAccessor,
			Format = format
		});
		return this;
	}

	public MetricExcelTable<TMetric> AddColumn<TValue>(long order, string title, double width, Func<TMetric, TValue> valueAccessor, IExcelCellFormat format = null)
	{
		_003C_003Ec__DisplayClass1_0<TValue> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0<TValue>();
		CS_0024_003C_003E8__locals0.valueAccessor = valueAccessor;
		base.Columns.Add(new Column<TValue>
		{
			Order = order,
			Title = title,
			Width = width,
			ValueAccessor = (KeyValuePair<string, TMetric> s) => CS_0024_003C_003E8__locals0.valueAccessor(s.Value),
			Format = format
		});
		return this;
	}

	public MetricExcelTable<TMetric> AddColumn<TValue>(Expression<Func<TMetric, TValue>> valueAccessor, double width = 10.0, IExcelCellFormat format = null)
	{
		_003C_003Ec__DisplayClass2_0<TValue> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0<TValue>();
		string displayName = MetricsHelper<TMetric>.GetDisplayName(valueAccessor);
		long order = MetricsHelper<TMetric>.GetOrder(valueAccessor);
		CS_0024_003C_003E8__locals0.accessor = valueAccessor.Compile();
		base.Columns.Add(new Column<TValue>
		{
			Order = order,
			Title = displayName,
			ValueAccessor = (KeyValuePair<string, TMetric> s) => CS_0024_003C_003E8__locals0.accessor(s.Value),
			Format = format,
			Width = width
		});
		return this;
	}

	public MetricExcelTable()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool clDhqUEE1mQsUwB1jBm3()
	{
		return vm3oAwEEP1XUqTurlE4P == null;
	}

	internal static object o67PASEENa1kNK5vjtm5()
	{
		return vm3oAwEEP1XUqTurlE4P;
	}
}
