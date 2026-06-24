using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Aspose.Cells;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Reports.Performance;

[Component(Order = 10)]
public class PerformanceReport : DiagnosticsReport
{
	private static PerformanceReport xYf4BUECJFOKPOnADg2J;

	public override Guid Uid => new Guid((string)GFy2DFEClFl8ngBglLmL(-740338220 ^ -740593982));

	public override string Name => SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D1C1EE4 ^ 0x4D182582));

	public IEnumerable<IPerformanceReportPage> PagesExt { get; private set; }

	public PerformanceReport(IEnumerable<IPerformanceReportPage> pages)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		PagesExt = pages;
	}

	public override string Export()
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				text = (string)wJXc64ECj4ncn7P91sL6(CaLRE8ECr70fxa3lRytw(this), (string)GFy2DFEClFl8ngBglLmL(-957824448 ^ -957548050) + (string)Ul2DrWECgCJEpN80yyRY() + (string)GFy2DFEClFl8ngBglLmL(-138018305 ^ -138015355) + (string)dOWSCsEC55vj7uFJtE5v(DateTime.Now.ToString((string)GFy2DFEClFl8ngBglLmL(-309639236 ^ -309366026)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3326242), GFy2DFEClFl8ngBglLmL(0x1637C429 ^ 0x1637C853)) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521184118));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 0;
				}
				break;
			default:
				Export(text);
				num2 = 3;
				break;
			case 2:
				return text;
			case 3:
				ClearOldReports((string)wJXc64ECj4ncn7P91sL6(DefaultFolder, Xu5EiZECYxhc4TwDIVsB(GFy2DFEClFl8ngBglLmL(-812025778 ^ -811777056), Ul2DrWECgCJEpN80yyRY(), GFy2DFEClFl8ngBglLmL(-477139494 ^ -477407052))));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void Export(string fileName)
	{
		//Discarded unreachable code: IL_00f7, IL_0181, IL_018b, IL_026a, IL_02a2
		int num = 9;
		int num2 = num;
		ExcelReportBuilder excelReportBuilder = default(ExcelReportBuilder);
		string text = default(string);
		MetricsContainer metricsContainer = default(MetricsContainer);
		IEnumerator<IPerformanceReportPage> enumerator = default(IEnumerator<IPerformanceReportPage>);
		IPerformanceReportPage current = default(IPerformanceReportPage);
		while (true)
		{
			switch (num2)
			{
			case 2:
				P7RQ0OEvhe6EumCS6NUI(fileName);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num2 = 6;
				}
				break;
			case 9:
				d9X1YbECUjbFge7fKVTy(pISiFcECLFfXJtQW9Rg8(fileName));
				num2 = 8;
				break;
			case 8:
				excelReportBuilder = new ExcelReportBuilder();
				num2 = 10;
				break;
			case 1:
				return;
			case 3:
				if (q8dOWKEvoa5feHnfjmxJ(text))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 11;
			case 7:
				text = (string)pISiFcECLFfXJtQW9Rg8(fileName);
				num2 = 3;
				break;
			case 11:
				d9X1YbECUjbFge7fKVTy(text);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 5;
				}
				break;
			case 10:
				metricsContainer = (MetricsContainer)gnwgcaECclx7LoW7jrOT(RfROBEECsWq9DcuOCMnN());
				num2 = 4;
				break;
			default:
				if (KpN1XBEvb0tL6sMRFYHM(fileName))
				{
					num2 = 2;
					break;
				}
				goto case 6;
			case 6:
				((Workbook)qggVjJEvGTxlCJBKcQBi(excelReportBuilder)).Save(fileName, (SaveFormat)6);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				enumerator = PagesExt.GetEnumerator();
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 12;
				}
				break;
			case 12:
				try
				{
					while (true)
					{
						IL_01f9:
						int num3;
						if (!s0IbuYEvWoukRyr3bd4S(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
							{
								num3 = 3;
							}
							goto IL_018f;
						}
						goto IL_01ad;
						IL_01ad:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
						{
							num3 = 1;
						}
						goto IL_018f;
						IL_018f:
						while (true)
						{
							switch (num3)
							{
							case 4:
								break;
							case 1:
								Nkh4FqEvF2nrwcKvwx2j(excelReportBuilder, N19JErECzFcnP6niP26c(current));
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
								{
									num3 = 0;
								}
								continue;
							default:
								goto IL_01f9;
							case 2:
								oLaJd8EvBLl9CffQlDvX(current, metricsContainer, excelReportBuilder);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
								{
									num3 = 0;
								}
								continue;
							case 3:
								goto end_IL_01f9;
							}
							break;
						}
						goto IL_01ad;
						continue;
						end_IL_01f9:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								enumerator.Dispose();
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
				goto case 7;
			}
		}
	}

	internal static object GFy2DFEClFl8ngBglLmL(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool JWbQJuEC9hLlwqAOcK37()
	{
		return xYf4BUECJFOKPOnADg2J == null;
	}

	internal static PerformanceReport u7gWmKECdJNQCYvbEIJP()
	{
		return xYf4BUECJFOKPOnADg2J;
	}

	internal static object CaLRE8ECr70fxa3lRytw(object P_0)
	{
		return ((DiagnosticsReport)P_0).DefaultFolder;
	}

	internal static object Ul2DrWECgCJEpN80yyRY()
	{
		return Environment.MachineName;
	}

	internal static object dOWSCsEC55vj7uFJtE5v(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object wJXc64ECj4ncn7P91sL6(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object Xu5EiZECYxhc4TwDIVsB(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object pISiFcECLFfXJtQW9Rg8(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}

	internal static object d9X1YbECUjbFge7fKVTy(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static object RfROBEECsWq9DcuOCMnN()
	{
		return DiagnosticsManager.Instance;
	}

	internal static object gnwgcaECclx7LoW7jrOT(object P_0)
	{
		return ((DiagnosticsManager)P_0).Metrics;
	}

	internal static object N19JErECzFcnP6niP26c(object P_0)
	{
		return ((IPerformanceReportPage)P_0).Name;
	}

	internal static object Nkh4FqEvF2nrwcKvwx2j(object P_0, object P_1)
	{
		return ((ExcelReportBuilder)P_0).AddWorksheet((string)P_1);
	}

	internal static void oLaJd8EvBLl9CffQlDvX(object P_0, object P_1, object P_2)
	{
		((IPerformanceReportPage)P_0).ExportExcel((MetricsContainer)P_1, (ExcelReportBuilder)P_2);
	}

	internal static bool s0IbuYEvWoukRyr3bd4S(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static bool q8dOWKEvoa5feHnfjmxJ(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static bool KpN1XBEvb0tL6sMRFYHM(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static void P7RQ0OEvhe6EumCS6NUI(object P_0)
	{
		File.Delete((string)P_0);
	}

	internal static object qggVjJEvGTxlCJBKcQBi(object P_0)
	{
		return ((ExcelReportBuilder)P_0).Workbook;
	}
}
