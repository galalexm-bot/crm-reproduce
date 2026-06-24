using System.Collections;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[XmlRoot("ArrayValue")]
[Component]
public class ArrayWrapper : IXsiType
{
	private static ArrayWrapper KyJIRjbhJV2OWREF8j27;

	[XmlElement("Value")]
	public string Value
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
				case 1:
					_003CValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
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

	[XmlElement("ArrayTypeName")]
	public string ArrayTypeName
	{
		[CompilerGenerated]
		get
		{
			return _003CArrayTypeName_003Ek__BackingField;
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
					_003CArrayTypeName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ArrayWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		B9nAv9bhl5GnObbJL6PP();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ArrayWrapper(ICollection array)
	{
		//Discarded unreachable code: IL_002a, IL_002f, IL_0057, IL_0066
		B9nAv9bhl5GnObbJL6PP();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			case 4:
				return;
			case 2:
				ArrayTypeName = array.GetType().AssemblyQualifiedName;
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num = 3;
				}
				break;
			default:
				Value = ClassSerializationHelper.SerializeObjectByJson(array);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num = 2;
				}
				break;
			case 1:
				if (array == null)
				{
					num = 4;
					break;
				}
				goto default;
			}
		}
	}

	internal static void B9nAv9bhl5GnObbJL6PP()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool hQKG2vbh9yexEwBqsIfs()
	{
		return KyJIRjbhJV2OWREF8j27 == null;
	}

	internal static ArrayWrapper cRV3SwbhdrjcU3wSsljM()
	{
		return KyJIRjbhJV2OWREF8j27;
	}
}
