using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Reports.Excel.Formats;

public class PercentFormat : FloatFormat
{
	internal static PercentFormat F0QCEgEEjc2eoZwVlLct;

	public new static PercentFormat Default { get; private set; }

	public PercentFormat()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		dUUrssEEUZLDRJPdWn6J();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				base.DecimalCount = 1;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected override string GetFormat()
	{
		return (string)ySvI9PEEcA3ZmkR787EE(base.GetFormat(), Ir0BG3EEsAFKapvFfYhH(0x7C1EE318 ^ 0x7C1AD72E));
	}

	static PercentFormat()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				SZ610sEEzZOU3apIYEEN(new PercentFormat());
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				dUUrssEEUZLDRJPdWn6J();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void dUUrssEEUZLDRJPdWn6J()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool bhULVgEEYdsGnLvNbdUp()
	{
		return F0QCEgEEjc2eoZwVlLct == null;
	}

	internal static PercentFormat MiclWkEELeyfo5dOrtlm()
	{
		return F0QCEgEEjc2eoZwVlLct;
	}

	internal static object Ir0BG3EEsAFKapvFfYhH(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object ySvI9PEEcA3ZmkR787EE(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void SZ610sEEzZOU3apIYEEN(object P_0)
	{
		Default = (PercentFormat)P_0;
	}
}
