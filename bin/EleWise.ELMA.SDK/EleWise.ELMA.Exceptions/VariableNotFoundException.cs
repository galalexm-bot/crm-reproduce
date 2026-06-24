using System;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Exceptions;

[Serializable]
public class VariableNotFoundException : EQLException
{
	private string variableName;

	private static VariableNotFoundException N66CDkGjNE8geQhoEkpl;

	public string VariableName => variableName;

	public VariableNotFoundException()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Q7ApCHGjaqpMvovCNBu6();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public VariableNotFoundException(string variableName)
	{
		//Discarded unreachable code: IL_0050, IL_0055
		Q7ApCHGjaqpMvovCNBu6();
		base._002Ector(null, SR.T((string)lq8JsWGjDSn6oIeOPvuT(0x53FA00CE ^ 0x53FE1A20), variableName));
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.variableName = variableName;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
			{
				num = 1;
			}
		}
	}

	internal static void Q7ApCHGjaqpMvovCNBu6()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool JAbnXQGj3FmOcpGVtRw2()
	{
		return N66CDkGjNE8geQhoEkpl == null;
	}

	internal static VariableNotFoundException VPhYicGjpdcvdBCASySS()
	{
		return N66CDkGjNE8geQhoEkpl;
	}

	internal static object lq8JsWGjDSn6oIeOPvuT(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
