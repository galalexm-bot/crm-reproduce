using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ComponentModel;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class AspMvcViewLocationFormatAttribute : Attribute
{
	internal static AspMvcViewLocationFormatAttribute htV2tsfQeQKB8aFX49xY;

	public string Format
	{
		[CompilerGenerated]
		get
		{
			return _003CFormat_003Ek__BackingField;
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
					_003CFormat_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
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

	public AspMvcViewLocationFormatAttribute(string format)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		KJLG3AfQNmHPdrIk5myN();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
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
			Format = format;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
			{
				num = 1;
			}
		}
	}

	internal static void KJLG3AfQNmHPdrIk5myN()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool UKesgJfQPdE2Bg5tCXdV()
	{
		return htV2tsfQeQKB8aFX49xY == null;
	}

	internal static AspMvcViewLocationFormatAttribute l2TSDffQ1DmMQNjNDbkA()
	{
		return htV2tsfQeQKB8aFX49xY;
	}
}
