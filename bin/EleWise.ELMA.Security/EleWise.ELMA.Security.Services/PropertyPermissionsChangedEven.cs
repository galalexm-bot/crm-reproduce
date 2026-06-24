using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Services;

public class PropertyPermissionsChangedEventArgs : EventArgs
{
	private static PropertyPermissionsChangedEventArgs djfPavPTcrscUxL3NRn;

	public Type ModelType
	{
		[CompilerGenerated]
		get
		{
			return _003CModelType_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CModelType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 != 0)
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

	public PropertyPermissionsChangedEventArgs(Type modelType)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Ny77g1PrK2yqE68KmXW();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				ModelType = modelType;
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void Ny77g1PrK2yqE68KmXW()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool dHq3s5PgtKCUAj4wUnF()
	{
		return djfPavPTcrscUxL3NRn == null;
	}

	internal static PropertyPermissionsChangedEventArgs j1LnOWP8FUEG6Wvo8tm()
	{
		return djfPavPTcrscUxL3NRn;
	}
}
