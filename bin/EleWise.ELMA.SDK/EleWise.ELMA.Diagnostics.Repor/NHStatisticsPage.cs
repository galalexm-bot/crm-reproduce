using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aspose.Cells;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using EleWise.ELMA.Diagnostics.Reports.Excel.Formats;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Stat;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Reports.Performance;

[ComponentOrder(30)]
internal class NHStatisticsPage : PerformanceReportPage
{
	internal static NHStatisticsPage y9eCNwECFvqR6duREvym;

	public override string Name => (string)q95v7KECbE7dWM1nbdfH(uTWRb0ECoEK2mU4PnYlL(-234299632 ^ -234035160));

	public SessionFactoryHolder SessionFactoryHolder
	{
		[CompilerGenerated]
		get
		{
			return _003CSessionFactoryHolder_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CSessionFactoryHolder_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public NHStatisticsPage(IEnumerable<IPerformanceReportPageColumnBuilder> builders)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(builders);
	}

	public override void ExportExcel(MetricsContainer metrics, ExcelReportBuilder builder)
	{
		//Discarded unreachable code: IL_00bc, IL_00cb
		int num = 2;
		int num2 = num;
		ExcelTable<KeyValuePair<string, EntityStatistics>> excelTable = default(ExcelTable<KeyValuePair<string, EntityStatistics>>);
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				builder.RenderTable(excelTable);
				num2 = 7;
				break;
			case 6:
				if (_003C_003Ec__DisplayClass7_.nhStat != null)
				{
					num2 = 5;
					break;
				}
				return;
			case 1:
				_003C_003Ec__DisplayClass7_.nhStat = (IStatistics)zI41Y3ECGgOuboCJA0fn(rfkmcCEChkqgC1w6vZry(SessionFactoryHolder));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 6;
				}
				break;
			case 7:
				return;
			case 2:
				_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				return;
			case 5:
				excelTable = new ExcelTable<KeyValuePair<string, EntityStatistics>>
				{
					FixedRows = 1
				}.AddColumn((string)q95v7KECbE7dWM1nbdfH(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x2025C29D)), 50.0, delegate(KeyValuePair<string, EntityStatistics> s)
				{
					_003C_003Ec__DisplayClass7_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_1();
					CS_0024_003C_003E8__locals0.s = s;
					return new CellValue(CS_0024_003C_003E8__locals0.s.Key, new CustomCellFormat(delegate(Cell cell, object v)
					{
						//Discarded unreachable code: IL_0039, IL_0048
						int num3 = 4;
						int num4 = num3;
						int num5 = default(int);
						while (true)
						{
							switch (num4)
							{
							case 2:
								return;
							case 3:
								num5 = _003C_003Ec__DisplayClass7_1.bHJdCE8RyUrLGZibgNSH(CS_0024_003C_003E8__locals0.s.Key, '(');
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
								{
									num4 = 0;
								}
								break;
							case 1:
							{
								object obj = _003C_003Ec__DisplayClass7_1.VxcClA8R9pUFDIjwb3BN(_003C_003Ec__DisplayClass7_1.nLAjKw8RJWKnFH3rqxW7(cell, num5, _003C_003Ec__DisplayClass7_1.PCad2G8RMLQ12rD5M0ZS(CS_0024_003C_003E8__locals0.s.Key) - num5));
								((Font)obj).set_Size(8);
								((Font)obj).set_Color(_003C_003Ec__DisplayClass7_1.xRCULt8Rd6RCo5nTDIFs());
								num4 = 5;
								break;
							}
							case 4:
								_003C_003Ec__DisplayClass7_1.XJWwnk8RmYuoX9UP9oym(cell, CS_0024_003C_003E8__locals0.s.Key);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
								{
									num4 = 3;
								}
								break;
							case 5:
								return;
							default:
								if (num5 <= 0)
								{
									num4 = 2;
									break;
								}
								goto case 1;
							}
						}
					}));
				}).AddColumn(10L, (string)q95v7KECbE7dWM1nbdfH(uTWRb0ECoEK2mU4PnYlL(-675505729 ^ -675762443)), 10.0, (KeyValuePair<string, EntityStatistics> s) => s.Value.get_LoadCount()).AddColumn(20L, SR.T((string)uTWRb0ECoEK2mU4PnYlL(-1426094279 ^ -1426345795)), 10.0, (KeyValuePair<string, EntityStatistics> s) => s.Value.get_FetchCount())
					.AddColumn(30L, (string)q95v7KECbE7dWM1nbdfH(uTWRb0ECoEK2mU4PnYlL(-1633514411 ^ -1633240087)), 12.0, (KeyValuePair<string, EntityStatistics> s) => s.Value.get_FetchTime())
					.AddColumn(40L, (string)q95v7KECbE7dWM1nbdfH(uTWRb0ECoEK2mU4PnYlL(-1487388570 ^ -1487112320)), 10.0, (KeyValuePair<string, EntityStatistics> s) => s.Value.get_FetchFromCacheCount())
					.AddColumn(50L, (string)q95v7KECbE7dWM1nbdfH(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210457631)), 10.0, (KeyValuePair<string, EntityStatistics> s) => s.Value.get_FetchFromCacheSuccessCount())
					.AddColumn(60L, (string)q95v7KECbE7dWM1nbdfH(uTWRb0ECoEK2mU4PnYlL(0xA592A41 ^ 0xA5D123D)), 12.0, (KeyValuePair<string, EntityStatistics> s) => s.Value.get_FetchFromCacheTime())
					.AddColumn(70L, (string)q95v7KECbE7dWM1nbdfH(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD39D7D4)), 10.0, (KeyValuePair<string, EntityStatistics> s) => s.Value.get_QueryCount())
					.AddColumn(80L, (string)q95v7KECbE7dWM1nbdfH(uTWRb0ECoEK2mU4PnYlL(-1867198571 ^ -1867450505)), 12.0, (KeyValuePair<string, EntityStatistics> s) => s.Value.get_QueryTime())
					.AddColumn(90L, (string)q95v7KECbE7dWM1nbdfH(uTWRb0ECoEK2mU4PnYlL(0x1637C429 ^ 0x1633FD25)), 10.0, (KeyValuePair<string, EntityStatistics> s) => s.Value.get_QueryFromCacheCount())
					.AddColumn(100L, (string)q95v7KECbE7dWM1nbdfH(uTWRb0ECoEK2mU4PnYlL(-1108654032 ^ -1108381322)), 12.0, (KeyValuePair<string, EntityStatistics> s) => s.Value.get_QueryFromCacheTime())
					.AddColumn(110L, (string)q95v7KECbE7dWM1nbdfH(uTWRb0ECoEK2mU4PnYlL(0x1FFEF86A ^ 0x1FFAC118)), 10.0, (KeyValuePair<string, EntityStatistics> s) => s.Value.get_InsertCount())
					.AddColumn(120L, (string)q95v7KECbE7dWM1nbdfH(uTWRb0ECoEK2mU4PnYlL(-281842504 ^ -281586428)), 12.0, (KeyValuePair<string, EntityStatistics> s) => s.Value.get_InsertTime())
					.AddColumn(130L, SR.T((string)uTWRb0ECoEK2mU4PnYlL(-1886646897 ^ -1886899115)), 10.0, (KeyValuePair<string, EntityStatistics> s) => s.Value.get_UpdateCount())
					.AddColumn(140L, (string)q95v7KECbE7dWM1nbdfH(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234035930)), 12.0, (KeyValuePair<string, EntityStatistics> s) => s.Value.get_UpdateTime())
					.AddColumn(150L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -69766022)), 10.0, (KeyValuePair<string, EntityStatistics> s) => s.Value.get_DeleteCount())
					.AddColumn(160L, (string)q95v7KECbE7dWM1nbdfH(uTWRb0ECoEK2mU4PnYlL(-1765851862 ^ -1766127740)), 12.0, (KeyValuePair<string, EntityStatistics> s) => s.Value.get_DeleteTime());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				excelTable.Items = (from p in ((IEnumerable<string>)VbJ10xECE46vJTEULLCt(_003C_003Ec__DisplayClass7_.nhStat)).Select(_003C_003Ec__DisplayClass7_._003CExportExcel_003Eb__17)
					where p.Value != null
					orderby p.Key
					select p).ToList();
				num2 = 3;
				break;
			}
		}
	}

	internal static object uTWRb0ECoEK2mU4PnYlL(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object q95v7KECbE7dWM1nbdfH(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool gphag2ECBptjggfONNUx()
	{
		return y9eCNwECFvqR6duREvym == null;
	}

	internal static NHStatisticsPage YK3XtPECW5TEXegtpuKF()
	{
		return y9eCNwECFvqR6duREvym;
	}

	internal static object rfkmcCEChkqgC1w6vZry(object P_0)
	{
		return ((SessionFactoryHolder)P_0).SessionFactory;
	}

	internal static object zI41Y3ECGgOuboCJA0fn(object P_0)
	{
		return ((ISessionFactory)P_0).get_Statistics();
	}

	internal static object VbJ10xECE46vJTEULLCt(object P_0)
	{
		return ((IStatistics)P_0).get_EntityNames();
	}
}
