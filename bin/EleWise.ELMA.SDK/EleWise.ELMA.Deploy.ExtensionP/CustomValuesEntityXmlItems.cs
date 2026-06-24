using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.ExtensionPoints.PropTypes;

public class CustomValuesEntityXmlItems
{
	private static CustomValuesEntityXmlItems nxIVNbEg2271BKVG0sky;

	public ITypeDescriptor TypeDescriptor
	{
		[CompilerGenerated]
		get
		{
			return _003CTypeDescriptor_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CTypeDescriptor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IDictionary<string, object> Values { get; set; }

	public CustomValuesEntityXmlItems()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				Values = new Dictionary<string, object>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool iJYIEhEgeH1IdxOxPeUR()
	{
		return nxIVNbEg2271BKVG0sky == null;
	}

	internal static CustomValuesEntityXmlItems xS158eEgPuVLCgEjZ5dI()
	{
		return nxIVNbEg2271BKVG0sky;
	}
}
