using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Reports.Activity;

[Component]
public abstract class ActivityReportPage : IActivityReportPage
{
	private static ActivityReportPage xT8EqnEf5ZOYtErM0pNJ;

	public abstract string Name { get; }

	public abstract void ExportExcel(IEnumerable<CallContextInfo> currentCalls, ExcelReportBuilder builder);

	protected ActivityReportPage()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		x98fJvEfLuUU5qGy12lR();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void x98fJvEfLuUU5qGy12lR()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool eGxQQDEfjIFiLmuY78vP()
	{
		return xT8EqnEf5ZOYtErM0pNJ == null;
	}

	internal static ActivityReportPage s1N2kSEfYhblMZwHjD5O()
	{
		return xT8EqnEf5ZOYtErM0pNJ;
	}
}
