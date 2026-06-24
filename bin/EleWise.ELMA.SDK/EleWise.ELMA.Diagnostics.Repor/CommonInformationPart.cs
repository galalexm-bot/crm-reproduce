using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Reports.Performance;

[Component]
public abstract class CommonInformationPart : ICommonInformationPart
{
	internal static CommonInformationPart aTb0lHEQiVBL4A497daK;

	public abstract string Title { get; }

	public abstract IEnumerable<CommonInformationPartItem> GetItems(MetricsContainer metrics);

	protected CommonInformationPart()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		IWykc0EQKhQkDQ2CVg70();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void IWykc0EQKhQkDQ2CVg70()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool JIdSXOEQRi9K3TKDeIZG()
	{
		return aTb0lHEQiVBL4A497daK == null;
	}

	internal static CommonInformationPart PsXjflEQqJqV9qKckh7y()
	{
		return aTb0lHEQiVBL4A497daK;
	}
}
