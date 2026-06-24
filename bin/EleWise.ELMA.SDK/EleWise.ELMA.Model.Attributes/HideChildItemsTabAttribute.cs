using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, Inherited = false)]
public class HideChildItemsTabAttribute : Attribute
{
	private readonly bool needHide;

	private static HideChildItemsTabAttribute CQqweDofJBGoGeAV0Va1;

	public bool NeedHide => needHide;

	public HideChildItemsTabAttribute()
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(needHide: true);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public HideChildItemsTabAttribute(bool needHide)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
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
			this.needHide = needHide;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
			{
				num = 1;
			}
		}
	}

	internal static bool UCu1FNof9k3xAxweonvf()
	{
		return CQqweDofJBGoGeAV0Va1 == null;
	}

	internal static HideChildItemsTabAttribute k8KZEKofd0ByVICdEM0D()
	{
		return CQqweDofJBGoGeAV0Va1;
	}
}
