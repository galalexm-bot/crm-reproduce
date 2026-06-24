using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[XmlRoot("EnumBaseValue")]
[Component]
public class EnumBaseWrapper : IXsiType
{
	internal static EnumBaseWrapper TkMTD0boN28Wwrj4SZGS;

	[XmlElement("Value")]
	public Guid Value
	{
		[CompilerGenerated]
		get
		{
			return _003CValue_003Ek__BackingField;
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
					_003CValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("TypeUid")]
	public Guid TypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CTypeUid_003Ek__BackingField;
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
					_003CTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public EnumBaseWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		sp5O9kboaYRalZvSO81h();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public EnumBaseWrapper(EnumBase enumBase)
	{
		//Discarded unreachable code: IL_001a
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		IMetadata metadata = default(IMetadata);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 1:
				return;
			case 4:
				TypeUid = metadata.Uid;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num = 0;
				}
				break;
			default:
				metadata = MetadataLoader.LoadMetadata(enumBase.GetType());
				num2 = 3;
				goto IL_001f;
			case 3:
				if (metadata == null)
				{
					return;
				}
				num2 = 4;
				goto IL_001f;
			case 2:
				{
					Value = qcXjKCboD8beUuZ0e7j5(enumBase);
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num = 0;
					}
					break;
				}
				IL_001f:
				num = num2;
				break;
			}
		}
	}

	internal static void sp5O9kboaYRalZvSO81h()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool qQjO5fbo3S3D51xv7jWY()
	{
		return TkMTD0boN28Wwrj4SZGS == null;
	}

	internal static EnumBaseWrapper P4sOZQbopwDu6Am4XKcA()
	{
		return TkMTD0boN28Wwrj4SZGS;
	}

	internal static Guid qcXjKCboD8beUuZ0e7j5(object P_0)
	{
		return ((EnumBase)P_0).Value;
	}
}
