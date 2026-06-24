using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Aspose.Cells;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Reports.Activity;

[Component(Order = 20)]
public class ActivityReport : DiagnosticsReport
{
	private static ActivityReport y7f70hEfTJJls7VKQ6Pn;

	public override Guid Uid => new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x769E000));

	public override string Name => (string)oiYsPZEf2SV5p2KApZ3t(mgEweMEfOjx18fYbtahD(-3333094 ^ -3600188));

	public IEnumerable<IActivityReportPage> Pages { get; private set; }

	public ActivityReport(IEnumerable<IActivityReportPage> pages)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Pages = pages;
	}

	public override string Export()
	{
		int num = 2;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				OESuqHEfpI5wo78rlHfr(this, text);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				text = (string)uyywjIEf3qtVd2c9Q9lC(kYrYfVEfeDwNtSUWKYwb(this), vwqnkqEfN0xZX23W11Mv(new string[5]
				{
					(string)mgEweMEfOjx18fYbtahD(-210725949 ^ -210458903),
					(string)qsMRowEfP2wIc1rawSCn(),
					(string)mgEweMEfOjx18fYbtahD(-629844702 ^ -629843624),
					TDu8NUEf1pNRZyAFTLhk().ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307AAA9B)).Replace((string)mgEweMEfOjx18fYbtahD(-812025778 ^ -812031350), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE1225B5)),
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210644215)
				}));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return text;
			default:
				ClearOldReports((string)uyywjIEf3qtVd2c9Q9lC(kYrYfVEfeDwNtSUWKYwb(this), VEyYZqEfaNUUNjHxoabm(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561342386), Environment.MachineName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E02BB5))));
				num2 = 3;
				break;
			}
		}
	}

	public override void Export(string fileName)
	{
		//Discarded unreachable code: IL_008f, IL_009e, IL_00a9, IL_0188, IL_01c0
		int num = 8;
		int num2 = num;
		List<CallContextInfo> currentCalls = default(List<CallContextInfo>);
		ExcelReportBuilder excelReportBuilder = default(ExcelReportBuilder);
		IEnumerator<IActivityReportPage> enumerator = default(IEnumerator<IActivityReportPage>);
		IActivityReportPage current = default(IActivityReportPage);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 9:
				currentCalls = DiagnosticsManager.Instance.GetCurrentCalls().ToList();
				num2 = 5;
				break;
			case 1:
				return;
			case 7:
				excelReportBuilder = new ExcelReportBuilder();
				num2 = 9;
				break;
			case 2:
				File.Delete(fileName);
				num2 = 3;
				break;
			case 10:
				try
				{
					while (true)
					{
						int num3;
						if (!Xyy5VwEf4YlLVZ2MbMk5(enumerator))
						{
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
							{
								num3 = 3;
							}
							goto IL_00ad;
						}
						goto IL_00f1;
						IL_00f1:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num3 = 0;
						}
						goto IL_00ad;
						IL_00ad:
						while (true)
						{
							switch (num3)
							{
							case 4:
								break;
							case 1:
								goto IL_00f1;
							case 2:
								current.ExportExcel(currentCalls, excelReportBuilder);
								num3 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
								{
									num3 = 0;
								}
								continue;
							default:
								bb7QsAEfwsKqDLnNTega(excelReportBuilder, oEebdvEftDI5GrYpUkX0(current));
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
								{
									num3 = 2;
								}
								continue;
							case 3:
								goto end_IL_00cb;
							}
							break;
						}
						continue;
						end_IL_00cb:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								CiFVvsEf6pP7rlMKjg9h(enumerator);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
								{
									num4 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto case 11;
			default:
				if (KWNRUFEf74xY20PR3Y2t(fileName))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 3;
			case 4:
				UQoEMVEfDJf6Joljte2w(text);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				Tlga8qEf0XALp1hbN4E8(mqtRfvEfx8AvpBkrhqhA(excelReportBuilder), fileName, (SaveFormat)6);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				if (!zjax0nEfAHcowyUSbblq(text))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto default;
			case 8:
				UQoEMVEfDJf6Joljte2w(Path.GetDirectoryName(fileName));
				num2 = 7;
				break;
			case 11:
				text = (string)SqMGYJEfHe9wOi2Ks5Nq(fileName);
				num2 = 6;
				break;
			case 5:
				enumerator = Pages.GetEnumerator();
				num2 = 10;
				break;
			}
		}
	}

	internal static bool lI3moOEfkIqZxaYGE13m()
	{
		return y7f70hEfTJJls7VKQ6Pn == null;
	}

	internal static ActivityReport MHn5hvEfnXO4nX0A2iwD()
	{
		return y7f70hEfTJJls7VKQ6Pn;
	}

	internal static object mgEweMEfOjx18fYbtahD(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object oiYsPZEf2SV5p2KApZ3t(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object kYrYfVEfeDwNtSUWKYwb(object P_0)
	{
		return ((DiagnosticsReport)P_0).DefaultFolder;
	}

	internal static object qsMRowEfP2wIc1rawSCn()
	{
		return Environment.MachineName;
	}

	internal static DateTime TDu8NUEf1pNRZyAFTLhk()
	{
		return DateTime.Now;
	}

	internal static object vwqnkqEfN0xZX23W11Mv(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static object uyywjIEf3qtVd2c9Q9lC(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static void OESuqHEfpI5wo78rlHfr(object P_0, object P_1)
	{
		((DiagnosticsReport)P_0).Export((string)P_1);
	}

	internal static object VEyYZqEfaNUUNjHxoabm(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object UQoEMVEfDJf6Joljte2w(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static object oEebdvEftDI5GrYpUkX0(object P_0)
	{
		return ((IActivityReportPage)P_0).Name;
	}

	internal static object bb7QsAEfwsKqDLnNTega(object P_0, object P_1)
	{
		return ((ExcelReportBuilder)P_0).AddWorksheet((string)P_1);
	}

	internal static bool Xyy5VwEf4YlLVZ2MbMk5(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void CiFVvsEf6pP7rlMKjg9h(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object SqMGYJEfHe9wOi2Ks5Nq(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}

	internal static bool zjax0nEfAHcowyUSbblq(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static bool KWNRUFEf74xY20PR3Y2t(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object mqtRfvEfx8AvpBkrhqhA(object P_0)
	{
		return ((ExcelReportBuilder)P_0).Workbook;
	}

	internal static void Tlga8qEf0XALp1hbN4E8(object P_0, object P_1, SaveFormat P_2)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		((Workbook)P_0).Save((string)P_1, P_2);
	}
}
