using System;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems;

[Component(Order = 20)]
public class ContextCodeItemToolBoxGroup : ICodeItemToolBoxGroup
{
	public static readonly Guid UID;

	internal static ContextCodeItemToolBoxGroup cUZ8ZpIEiMbdSEI5DiC;

	public Guid GroupUid => UID;

	public Guid ParentGroupUid => Guid.Empty;

	public string Name => SR.T((string)h0JBCKICjttY4rvXonF(-1886646897 ^ -1886632129));

	public ContextCodeItemToolBoxGroup()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		JE4UJ4Ivs3xEWAOolgT();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ContextCodeItemToolBoxGroup()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				UID = new Guid((string)h0JBCKICjttY4rvXonF(0x12441CA4 ^ 0x12445660));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static object h0JBCKICjttY4rvXonF(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool Q4ktvrIftKfRV0eZYod()
	{
		return cUZ8ZpIEiMbdSEI5DiC == null;
	}

	internal static ContextCodeItemToolBoxGroup iAJPf1IQlaQkR3CWkdB()
	{
		return cUZ8ZpIEiMbdSEI5DiC;
	}

	internal static void JE4UJ4Ivs3xEWAOolgT()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
