using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Reports.Activity;

public class CurrentCallsReportPage : ActivityReportPage
{
	internal static CurrentCallsReportPage Oc6sJgEfmVB9WxR64Lvg;

	public override string Name => (string)q2cGvHEf9xWMN3F3ttI8(QWsgJTEfJfYelfutCFgo(-195614443 ^ -195879787));

	public override void ExportExcel(IEnumerable<CallContextInfo> currentCalls, ExcelReportBuilder builder)
	{
		builder.SetColumnsWidths(21, 150);
		foreach (CallContextInfo item in currentCalls.OrderBy((CallContextInfo c) => _003C_003Ec.eTT4s48ilfnu332DIxTx(c)))
		{
			builder.SetRowStyle(builder.Styles.HeaderStyle);
			builder.SetValues(item.StartTime.ConvertUtcToLocal().ToShortDateString() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x2026536D) + item.StartTime.ConvertUtcToLocal().ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210459037)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A6CDED) + item.Id + ((item.UserId != null) ? string.Concat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858628579), item.UserId, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E28D62)) : "") + ((!string.IsNullOrEmpty(item.UserHostAddress)) ? (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234034494) + item.UserHostAddress + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CBB0A3)) : "") + ((!string.IsNullOrEmpty(item.HttpMethod)) ? (z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6A6FEB) + item.HttpMethod + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16734193)) : "") + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675491683) + item.Name);
			builder.NextRow();
			foreach (AbstractCallInfo item2 in item.GetCallStack())
			{
				builder.SetValues(item2.StartTime.ConvertUtcToLocal().ToShortDateString() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638416589) + item2.StartTime.ConvertUtcToLocal().ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269A6A6A)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281830822) + item2.CallType + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35722941) + item2.Description);
				builder.NextRow();
			}
			builder.NextRow();
		}
	}

	public CurrentCallsReportPage()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Q2LKvNEfdRVx7sGiqbmc();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object QWsgJTEfJfYelfutCFgo(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object q2cGvHEf9xWMN3F3ttI8(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool B8CuU0Efyrp8nIuZeauT()
	{
		return Oc6sJgEfmVB9WxR64Lvg == null;
	}

	internal static CurrentCallsReportPage cYthQBEfM0sS2odFNdlI()
	{
		return Oc6sJgEfmVB9WxR64Lvg;
	}

	internal static void Q2LKvNEfdRVx7sGiqbmc()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
