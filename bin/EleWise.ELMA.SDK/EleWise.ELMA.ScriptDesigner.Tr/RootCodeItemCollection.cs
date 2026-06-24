using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ScriptDesigner.CodeItems;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ScriptDesigner.TranslateData;

[Serializable]
[Component]
public class RootCodeItemCollection : IXsiRoot
{
	private static RootCodeItemCollection GQwKJ2Zr33nOxOHU76D;

	public List<RootCodeItem> Items { get; set; }

	public RootCodeItemCollection()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		cBANrYZjbPL2OgyD894();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
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
			Items = new List<RootCodeItem>();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
			{
				num = 0;
			}
		}
	}

	public RootCodeItem GetItem(Guid uid)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return Items.FirstOrDefault(_003C_003Ec__DisplayClass5_._003CGetItem_003Eb__0);
			case 2:
				_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass5_.uid = uid;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void cBANrYZjbPL2OgyD894()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool hmUYo1ZgDXaIJgCawq3()
	{
		return GQwKJ2Zr33nOxOHU76D == null;
	}

	internal static RootCodeItemCollection cPc01LZ5lCvbOjDnKjX()
	{
		return GQwKJ2Zr33nOxOHU76D;
	}
}
