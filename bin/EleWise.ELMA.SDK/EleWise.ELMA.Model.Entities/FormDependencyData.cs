using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Entities;

[Serializable]
public class FormDependencyData : IFormDependencyData
{
	internal static class Tables
	{
		internal static class Fields
		{
			internal const string DependObjectUid = "DependObjectUid";

			internal const string DependObjectFormUid = "DependObjectFormUid";

			internal const string UsesObjectUid = "UsesObjectUid";

			internal const string UsesObjectFormUid = "UsesObjectFormUid";

			internal const string Type = "Type";
		}

		internal const string TableName = "FormDependencies";
	}

	private static FormDependencyData u2HvVYh8ySCWHba7ustw;

	public Guid DependObjectUid
	{
		[CompilerGenerated]
		get
		{
			return _003CDependObjectUid_003Ek__BackingField;
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
					_003CDependObjectUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
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

	public Guid DependObjectFormUid
	{
		[CompilerGenerated]
		get
		{
			return _003CDependObjectFormUid_003Ek__BackingField;
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
					_003CDependObjectFormUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
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

	public Guid UsesObjectUid
	{
		[CompilerGenerated]
		get
		{
			return _003CUsesObjectUid_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CUsesObjectUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid UsesObjectFormUid
	{
		[CompilerGenerated]
		get
		{
			return _003CUsesObjectFormUid_003Ek__BackingField;
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
					_003CUsesObjectFormUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
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

	public FormDependencyDataType Type
	{
		[CompilerGenerated]
		get
		{
			return _003CType_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public FormDependencyData(Guid dependObjectUid, Guid dependObjectFormUid, Guid usesObjectUid, Guid usesObjectFormUid, FormDependencyDataType type)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		guAbX1h89pV4qS7sJ8kn();
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 3:
				DependObjectUid = dependObjectUid;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			default:
				DependObjectFormUid = dependObjectFormUid;
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num = 2;
				}
				break;
			case 4:
				UsesObjectUid = usesObjectUid;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num = 2;
				}
				break;
			case 5:
				Type = type;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				UsesObjectFormUid = usesObjectFormUid;
				num = 5;
				break;
			}
		}
	}

	public string GenerateDependInfo()
	{
		return (string)bbsiSgh8doa366gumaDr(FormDependencyHelper.KeySplitter, new object[3] { DependObjectUid, DependObjectFormUid, Type });
	}

	public string GenerateUsesInfo()
	{
		return (string)bbsiSgh8doa366gumaDr(FormDependencyHelper.KeySplitter, new object[3] { UsesObjectUid, UsesObjectFormUid, Type });
	}

	internal static void guAbX1h89pV4qS7sJ8kn()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool L8YuWnh8MB5MttINkYvL()
	{
		return u2HvVYh8ySCWHba7ustw == null;
	}

	internal static FormDependencyData KBnpTMh8JR8JxAPFSpeE()
	{
		return u2HvVYh8ySCWHba7ustw;
	}

	internal static object bbsiSgh8doa366gumaDr(object P_0, object P_1)
	{
		return string.Join((string)P_0, (object[])P_1);
	}
}
