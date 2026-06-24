using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Cache.ActorModel.Configuration;

public sealed class CacheOptions
{
	internal static CacheOptions VOYW2XfTQeb7XnHyv7ih;

	public byte ReplicaFactor
	{
		[CompilerGenerated]
		get
		{
			return _003CReplicaFactor_003Ek__BackingField;
		}
		[CompilerGenerated]
		internal set
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
					_003CReplicaFactor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public CacheOptions()
	{
		//Discarded unreachable code: IL_0036, IL_003b
		QwkpsifT8aMVAMEUmlbC();
		ReplicaFactor = 1;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool mktokIfTC7stPTxH5D8O()
	{
		return VOYW2XfTQeb7XnHyv7ih == null;
	}

	internal static CacheOptions My4rASfTvOgAviflT1S5()
	{
		return VOYW2XfTQeb7XnHyv7ih;
	}

	internal static void QwkpsifT8aMVAMEUmlbC()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
