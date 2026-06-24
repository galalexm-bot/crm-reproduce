using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Common;

[Serializable]
[DataContract]
public sealed class TypeSerializationItemDescriptor : ICloneable
{
	private static TypeSerializationItemDescriptor EOg6pufVdyqJ505uhLE4;

	[DataMember]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
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
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	public TypeSerializationDescriptor Descriptor
	{
		[CompilerGenerated]
		get
		{
			return _003CDescriptor_003Ek__BackingField;
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
					_003CDescriptor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
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

	public TypeSerializationItemDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		d0WAKvfVgUcr90gb5lxy();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				Descriptor = new TypeSerializationDescriptor();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override string ToString()
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (string.IsNullOrEmpty(Name))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return (string)V6LT0yfVjATvrosCFgZf(FxubwafV5iOfp53Afdey(0x1A33FE36 ^ 0x1A36BFB4), Name, Descriptor);
			default:
				return Descriptor.ToString();
			}
		}
	}

	public TypeSerializationItemDescriptor Clone()
	{
		return (TypeSerializationItemDescriptor)((ICloneable)this).Clone();
	}

	object ICloneable.Clone()
	{
		TypeSerializationItemDescriptor typeSerializationItemDescriptor = new TypeSerializationItemDescriptor();
		C2iApRfVY5KnqgGxHE1y(typeSerializationItemDescriptor, Name);
		Enu7p6fVU7WtIy38wiAh(typeSerializationItemDescriptor, r3CtPEfVLn3qJ8IP2tHL(Descriptor));
		return typeSerializationItemDescriptor;
	}

	internal static void d0WAKvfVgUcr90gb5lxy()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool GjnQHMfVlpecfg29J45A()
	{
		return EOg6pufVdyqJ505uhLE4 == null;
	}

	internal static TypeSerializationItemDescriptor teAhfQfVrDUdJU739aET()
	{
		return EOg6pufVdyqJ505uhLE4;
	}

	internal static object FxubwafV5iOfp53Afdey(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object V6LT0yfVjATvrosCFgZf(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void C2iApRfVY5KnqgGxHE1y(object P_0, object P_1)
	{
		((TypeSerializationItemDescriptor)P_0).Name = (string)P_1;
	}

	internal static object r3CtPEfVLn3qJ8IP2tHL(object P_0)
	{
		return ((TypeSerializationDescriptor)P_0).Clone();
	}

	internal static void Enu7p6fVU7WtIy38wiAh(object P_0, object P_1)
	{
		((TypeSerializationItemDescriptor)P_0).Descriptor = (TypeSerializationDescriptor)P_1;
	}
}
public class TypeSerializationItemDescriptorBuilder
{
	private readonly TypeSerializationItemDescriptor item;

	private static TypeSerializationItemDescriptorBuilder vcJCNffVsiKQmmRpv12q;

	public TypeSerializationItemDescriptor Item => item;

	public TypeSerializationItemDescriptorBuilder(TypeSerializationItemDescriptor item)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		tqTCw0fSFSlsrcIfl4MC();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x3418F62B));
			case 1:
				return;
			}
			if (item != null)
			{
				this.item = item;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num = 1;
				}
			}
			else
			{
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num = 2;
				}
			}
		}
	}

	public TypeSerializationItemDescriptorBuilder Name(string name)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return this;
			case 1:
				iD7XWCfSBbTkTacEmCGq(item, name);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public TypeSerializationItemDescriptorBuilder Descriptor(string description)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				HsOh3YfSWAfN3dQCileU(item.Descriptor, description);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return this;
			}
		}
	}

	public TypeSerializationItemDescriptorBuilder Descriptor(TypeSerializationDescriptor descriptor)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				S9Cka5fSo30Wtf0bgure(item, descriptor);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return this;
			}
		}
	}

	public TypeSerializationItemDescriptorBuilder Descriptor(Action<TypeSerializationDescriptorBuilder> descriptorBuilder)
	{
		if (descriptorBuilder == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x163285B3));
		}
		descriptorBuilder(new TypeSerializationDescriptorBuilder(item.Descriptor));
		return this;
	}

	internal static void tqTCw0fSFSlsrcIfl4MC()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool koXyXifVcsQK6qpKrJC7()
	{
		return vcJCNffVsiKQmmRpv12q == null;
	}

	internal static TypeSerializationItemDescriptorBuilder YjmrJDfVzp0QhSjVEfMK()
	{
		return vcJCNffVsiKQmmRpv12q;
	}

	internal static void iD7XWCfSBbTkTacEmCGq(object P_0, object P_1)
	{
		((TypeSerializationItemDescriptor)P_0).Name = (string)P_1;
	}

	internal static void HsOh3YfSWAfN3dQCileU(object P_0, object P_1)
	{
		((TypeSerializationDescriptor)P_0).Description = (string)P_1;
	}

	internal static void S9Cka5fSo30Wtf0bgure(object P_0, object P_1)
	{
		((TypeSerializationItemDescriptor)P_0).Descriptor = (TypeSerializationDescriptor)P_1;
	}
}
