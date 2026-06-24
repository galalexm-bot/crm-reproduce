using System.Collections.Generic;
using System.Linq;
using Aspose.Cells;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Diagnostics.Reports.Activity;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using EleWise.ELMA.Diagnostics.Reports.Performance;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Reports;

[Component(Order = 10000)]
public class ServerInformationPage : IActivityReportPage, IPerformanceReportPage
{
	private static ServerInformationPage hEacpBEhZoesLn4NeIDy;

	public string Name => (string)MFhUaSEhST035DqhbaXI(SohE7pEhVTlYY5oPJXnW(0x1ECE530A ^ 0x1ECA7CFA));

	private void ExportExcel(ExcelReportBuilder builder)
	{
		//Discarded unreachable code: IL_0268, IL_035c, IL_036b
		int num = 29;
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 14:
					builder.SetValues(MFhUaSEhST035DqhbaXI(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC6805B)), PatternLayoutExt.ConfigurationDirectory);
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 2;
					}
					continue;
				case 25:
					builder.SetValues(MFhUaSEhST035DqhbaXI(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420493510)), aeVsZWEhkfYB7M1875vA());
					num2 = 9;
					continue;
				case 1:
					Mdnl7wEhT8AkghCQvtU4(builder);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 16;
					}
					continue;
				case 30:
					Mdnl7wEhT8AkghCQvtU4(builder);
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 1;
					}
					continue;
				case 22:
					if (h7fjjxEhpZ45PGcSeQC2() == null)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 31;
				case 18:
					Mdnl7wEhT8AkghCQvtU4(builder);
					num2 = 25;
					continue;
				case 13:
					builder.NextRow();
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num2 = 4;
					}
					continue;
				case 33:
					builder.SetValues(MFhUaSEhST035DqhbaXI(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -868076398)), qtnR6kEh3U1Sm69rJQQi());
					num = 5;
					break;
				case 17:
					return;
				case 26:
					Mdnl7wEhT8AkghCQvtU4(builder);
					num2 = 4;
					continue;
				case 20:
					builder.SetValues(SHxAeIEhXoU5FZKUEORU());
					num2 = 24;
					continue;
				case 19:
					builder.SetValues(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD16094)), aNhj7GEh1GWLYKANkXWL());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 0;
					}
					continue;
				case 16:
					builder.SetValues(MFhUaSEhST035DqhbaXI(SohE7pEhVTlYY5oPJXnW(-1822890472 ^ -1822632334)), lAdyfVEhes8a4IbYsMm2());
					num2 = 32;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 30;
					}
					continue;
				case 10:
					Mdnl7wEhT8AkghCQvtU4(builder);
					num2 = 33;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					if (omPTXbEhnFdZl5Gwlx5S() != null)
					{
						num2 = 23;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 16;
				case 15:
					FeHC93EhKPBmYieOfhxd(builder, BVFQvGEhqfUZMMptvAep(zsYZTwEhR3EOLjBiHoxv(builder)));
					num2 = 20;
					continue;
				default:
					Mdnl7wEhT8AkghCQvtU4(builder);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 1;
					}
					continue;
				case 24:
					Mdnl7wEhT8AkghCQvtU4(builder);
					num2 = 18;
					continue;
				case 5:
					builder.NextRow();
					num2 = 22;
					continue;
				case 6:
				case 21:
					builder.SetValues(MFhUaSEhST035DqhbaXI(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521524222)), omPTXbEhnFdZl5Gwlx5S());
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 0;
					}
					continue;
				case 28:
					builder.SetColumnsWidths(30, 50);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 15;
					}
					continue;
				case 7:
					builder.SetValues(MFhUaSEhST035DqhbaXI(SohE7pEhVTlYY5oPJXnW(0x18A6761F ^ 0x18A246D1)), bLFq33EhNHuxavmcapHG());
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 10;
					}
					continue;
				case 12:
					No7BDQEhO3wVJJkAxuGQ(builder, (num3 + 1) * 17);
					num2 = 27;
					continue;
				case 32:
					builder.NextRow();
					num2 = 3;
					continue;
				case 9:
					Mdnl7wEhT8AkghCQvtU4(builder);
					num2 = 2;
					continue;
				case 29:
					ss3xGFEhiMwbFOKIDoU1(builder, 0);
					num2 = 28;
					continue;
				case 3:
					builder.SetValues(MFhUaSEhST035DqhbaXI(SohE7pEhVTlYY5oPJXnW(-234299632 ^ -234033274)), sfmpW9EhPhaJZ8IUlmbq());
					num2 = 30;
					continue;
				case 4:
				case 8:
					if (PatternLayoutExt.ConfigurationDirectory == null)
					{
						return;
					}
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 14;
					}
					continue;
				case 11:
					if (num3 <= 0)
					{
						num = 21;
						break;
					}
					goto case 12;
				case 31:
					builder.SetValues(MFhUaSEhST035DqhbaXI(SohE7pEhVTlYY5oPJXnW(-281842504 ^ -281584560)), h7fjjxEhpZ45PGcSeQC2());
					num2 = 26;
					continue;
				case 23:
					num3 = ((IEnumerable<char>)omPTXbEhnFdZl5Gwlx5S()).Count((char c) => c == '\n');
					num2 = 11;
					continue;
				case 27:
					oiMgk6Eh2frPJq5s7FuY(builder, 1, new ExcelStyle
					{
						Action = delegate(Style s, StyleFlag f)
						{
							int num4 = 1;
							int num5 = num4;
							while (true)
							{
								switch (num5)
								{
								case 1:
									_003C_003Ec.xGrVyG8iSDAluW0F10IA(f, true);
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
									{
										num5 = 0;
									}
									break;
								default:
									_003C_003Ec.sqta1x8iiZfjQjItH6lI(s, true);
									num5 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
									{
										num5 = 2;
									}
									break;
								case 2:
									return;
								}
							}
						}
					});
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	public void ExportExcel(IEnumerable<CallContextInfo> currentCalls, ExcelReportBuilder builder)
	{
		ExportExcel(builder);
	}

	public void ExportExcel(MetricsContainer metrics, ExcelReportBuilder builder)
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
				ExportExcel(builder);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ServerInformationPage()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		PnOK8uEhaI7ki282f75A();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object SohE7pEhVTlYY5oPJXnW(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object MFhUaSEhST035DqhbaXI(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool yAbwEhEhutP75jBfT5ju()
	{
		return hEacpBEhZoesLn4NeIDy == null;
	}

	internal static ServerInformationPage D3Db5MEhI0x6WNmbghha()
	{
		return hEacpBEhZoesLn4NeIDy;
	}

	internal static void ss3xGFEhiMwbFOKIDoU1(object P_0, int value)
	{
		((ExcelReportBuilder)P_0).RowIndex = value;
	}

	internal static object zsYZTwEhR3EOLjBiHoxv(object P_0)
	{
		return ((ExcelReportBuilder)P_0).Styles;
	}

	internal static object BVFQvGEhqfUZMMptvAep(object P_0)
	{
		return ((ExcelStylesheet)P_0).MainHeaderStyle;
	}

	internal static void FeHC93EhKPBmYieOfhxd(object P_0, object P_1)
	{
		((ExcelReportBuilder)P_0).SetRowStyle((IExcelStyle)P_1);
	}

	internal static object SHxAeIEhXoU5FZKUEORU()
	{
		return PatternLayoutExt.Version;
	}

	internal static void Mdnl7wEhT8AkghCQvtU4(object P_0)
	{
		((ExcelReportBuilder)P_0).NextRow();
	}

	internal static object aeVsZWEhkfYB7M1875vA()
	{
		return PatternLayoutExt.ServerSoftware;
	}

	internal static object omPTXbEhnFdZl5Gwlx5S()
	{
		return PatternLayoutExt.DataBaseSoftware;
	}

	internal static void No7BDQEhO3wVJJkAxuGQ(object P_0, int height)
	{
		((ExcelReportBuilder)P_0).SetRowHeight(height);
	}

	internal static void oiMgk6Eh2frPJq5s7FuY(object P_0, int columnIndex, object P_2)
	{
		((ExcelReportBuilder)P_0).SetCellStyle(columnIndex, (IExcelStyle)P_2);
	}

	internal static object lAdyfVEhes8a4IbYsMm2()
	{
		return PatternLayoutExt.OS;
	}

	internal static object sfmpW9EhPhaJZ8IUlmbq()
	{
		return PatternLayoutExt.Framework;
	}

	internal static object aNhj7GEh1GWLYKANkXWL()
	{
		return PatternLayoutExt.CPU;
	}

	internal static object bLFq33EhNHuxavmcapHG()
	{
		return PatternLayoutExt.Memory;
	}

	internal static object qtnR6kEh3U1Sm69rJQQi()
	{
		return PatternLayoutExt.HDD;
	}

	internal static object h7fjjxEhpZ45PGcSeQC2()
	{
		return PatternLayoutExt.ApplicationDirectory;
	}

	internal static void PnOK8uEhaI7ki282f75A()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
