using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Scripts;

[ClassMap(typeof(ModuleReferenceNHMap))]
internal class ModuleReference
{
	public static class Tables
	{
		public static class Columns
		{
			public const string MetadataUid = "MetadataUid";

			public const string ModuleUid = "ModuleUid";
		}

		public const string TableName = "ModuleReference";
	}

	internal static ModuleReference sxgngibVpxdpJoGw0bJs;

	public virtual Guid MetadataUid
	{
		[CompilerGenerated]
		get
		{
			return _003CMetadataUid_003Ek__BackingField;
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
					_003CMetadataUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual Guid ModuleUid
	{
		[CompilerGenerated]
		get
		{
			return _003CModuleUid_003Ek__BackingField;
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
					_003CModuleUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
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

	public ModuleReference()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		DLX2UIbVtI6ofExIv4Ys();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool QeipPFbVa1kUS3Doilmf()
	{
		return sxgngibVpxdpJoGw0bJs == null;
	}

	internal static ModuleReference hxWdTkbVDBWHAHQ84r7k()
	{
		return sxgngibVpxdpJoGw0bJs;
	}

	internal static void DLX2UIbVtI6ofExIv4Ys()
	{
		SingletonReader.PushGlobal();
	}
}
