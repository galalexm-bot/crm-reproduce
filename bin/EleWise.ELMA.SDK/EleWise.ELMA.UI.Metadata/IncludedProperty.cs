using System;
using System.Collections.Generic;
using System.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Metadata;

[Serializable]
public sealed class IncludedProperty : DatePartProperty
{
	private static IncludedProperty MoALuCBhPVCN3dW0Krp8;

	public List<Guid> PropertyParents { get; set; }

	public IncludedProperty()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		YVnb8rBh3BuZEsc4d5eF();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
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
			PropertyParents = new List<Guid>();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
			{
				num = 1;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializePropertyParents()
	{
		return YcxMHhBhpuWBtXTTQ4IU(PropertyParents) != 0;
	}

	internal static void YVnb8rBh3BuZEsc4d5eF()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool PKbquSBh1iPciabbNwWE()
	{
		return MoALuCBhPVCN3dW0Krp8 == null;
	}

	internal static IncludedProperty pXos8XBhNuewPyyhDyj9()
	{
		return MoALuCBhPVCN3dW0Krp8;
	}

	internal static int YcxMHhBhpuWBtXTTQ4IU(object P_0)
	{
		return ((List<Guid>)P_0).Count;
	}
}
