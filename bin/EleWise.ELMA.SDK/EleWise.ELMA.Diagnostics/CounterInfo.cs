using System.Diagnostics;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics;

internal sealed class CounterInfo
{
	internal static CounterInfo FErSslGzbgNpxlvhVrMh;

	public PerformanceCounterType CounterType
	{
		[CompilerGenerated]
		get
		{
			return _003CCounterType_003Ek__BackingField;
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
				case 1:
					_003CCounterType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public string CounterName
	{
		[CompilerGenerated]
		get
		{
			return _003CCounterName_003Ek__BackingField;
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
				case 1:
					_003CCounterName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public string CounterHelp
	{
		[CompilerGenerated]
		get
		{
			return _003CCounterHelp_003Ek__BackingField;
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
				case 1:
					_003CCounterHelp_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public static CounterInfo From(CounterCreationData counter)
	{
		CounterInfo counterInfo = new CounterInfo();
		Hlgd7rGzfCfRSx73Ewou(counterInfo, L7yQxCGzEsMC9HX6tkki(counter));
		Cr4w0nGzCDvov5Bpj14t(counterInfo, uIINf0GzQbEScYnl7V3V(counter));
		xhouRdGz8xtRYjLPyhHs(counterInfo, zMJvsfGzvCObjEHMOimi(counter));
		return counterInfo;
	}

	public CounterInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		gRSKZMGzZFEUkWAHLcOh();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool un66wgGzhTxWuggRXIdY()
	{
		return FErSslGzbgNpxlvhVrMh == null;
	}

	internal static CounterInfo JVZDniGzGyqWTXG7rPGa()
	{
		return FErSslGzbgNpxlvhVrMh;
	}

	internal static object L7yQxCGzEsMC9HX6tkki(object P_0)
	{
		return ((CounterCreationData)P_0).CounterHelp;
	}

	internal static void Hlgd7rGzfCfRSx73Ewou(object P_0, object P_1)
	{
		((CounterInfo)P_0).CounterHelp = (string)P_1;
	}

	internal static object uIINf0GzQbEScYnl7V3V(object P_0)
	{
		return ((CounterCreationData)P_0).CounterName;
	}

	internal static void Cr4w0nGzCDvov5Bpj14t(object P_0, object P_1)
	{
		((CounterInfo)P_0).CounterName = (string)P_1;
	}

	internal static PerformanceCounterType zMJvsfGzvCObjEHMOimi(object P_0)
	{
		return ((CounterCreationData)P_0).CounterType;
	}

	internal static void xhouRdGz8xtRYjLPyhHs(object P_0, PerformanceCounterType value)
	{
		((CounterInfo)P_0).CounterType = value;
	}

	internal static void gRSKZMGzZFEUkWAHLcOh()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
