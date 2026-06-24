using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata;

public sealed class FindLinkedObjectsResult
{
	private static FindLinkedObjectsResult kaFXSsbNZsw93eXaeSYl;

	public ICollection<ILinkedObject> AddedObjects { get; set; }

	public ICollection<ILinkedObject> LinkedObjects { get; set; }

	public FindLinkedObjectsResult()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		kXCAk1bNV4vJLsLGwliW();
		base._002Ector();
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
			default:
				AddedObjects = new List<ILinkedObject>();
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
				{
					num = 0;
				}
				break;
			case 2:
				LinkedObjects = new List<ILinkedObject>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal static void kXCAk1bNV4vJLsLGwliW()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool DTe69MbNuy40dkDlBVKV()
	{
		return kaFXSsbNZsw93eXaeSYl == null;
	}

	internal static FindLinkedObjectsResult dg06ipbNIiUrVavL6cTr()
	{
		return kaFXSsbNZsw93eXaeSYl;
	}
}
