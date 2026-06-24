using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Common;

[Serializable]
[DataContract]
public sealed class TypeSerializationDescriptor : ICloneable
{
	private string typeName;

	private Type type;

	private static TypeSerializationDescriptor hBy6jZfV14uTvm8Rjjor;

	[DataMember]
	public string Description
	{
		[CompilerGenerated]
		get
		{
			return _003CDescription_003Ek__BackingField;
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
					_003CDescription_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
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

	[IgnoreDataMember]
	public Type Type
	{
		get
		{
			return type;
		}
		set
		{
			//Discarded unreachable code: IL_0039
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				case 3:
					if (kHtNjGfVppyqJ1g37tca(value, null))
					{
						num2 = 2;
						continue;
					}
					goto default;
				default:
					type = value;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					if (!oKrAFAfVagMO47AFDWLE(typeName, value.FullName))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
						{
							num2 = 2;
						}
						continue;
					}
					break;
				case 5:
					break;
				}
				typeName = value.FullName;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 0;
				}
			}
		}
	}

	[DataMember]
	public string TypeName
	{
		get
		{
			//Discarded unreachable code: IL_0040, IL_004f
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return typeName;
				case 1:
					return type.FullName;
				case 2:
					if (kHtNjGfVppyqJ1g37tca(type, null))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				}
			}
		}
		set
		{
			//Discarded unreachable code: IL_003d, IL_004c, IL_008e
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 2:
				case 6:
					typeName = value;
					num2 = 5;
					break;
				default:
					type = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 1;
					}
					break;
				case 5:
					return;
				case 4:
					if (!(type.FullName != value))
					{
						num2 = 6;
						break;
					}
					goto default;
				case 3:
					if (!kHtNjGfVppyqJ1g37tca(type, null))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 4;
				}
			}
		}
	}

	[DataMember]
	public bool IsArray
	{
		[CompilerGenerated]
		get
		{
			return _003CIsArray_003Ek__BackingField;
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
					_003CIsArray_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
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

	[DataMember]
	public bool IsOptional
	{
		[CompilerGenerated]
		get
		{
			return _003CIsOptional_003Ek__BackingField;
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
					_003CIsOptional_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
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

	[DataMember]
	public bool IsObsolete
	{
		[CompilerGenerated]
		get
		{
			return _003CIsObsolete_003Ek__BackingField;
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
					_003CIsObsolete_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
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

	[DataMember]
	public object DefaultValue
	{
		[CompilerGenerated]
		get
		{
			return _003CDefaultValue_003Ek__BackingField;
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
					_003CDefaultValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
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

	[DataMember]
	public ICollection<TypeSerializationItemDescriptor> Items { get; private set; }

	public TypeSerializationDescriptor()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
				Items = new SerializableList<TypeSerializationItemDescriptor>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			default:
				Description = null;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		//Discarded unreachable code: IL_00ab, IL_00be, IL_00cd
		int num = 2;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return (string)jVSkXNfVt3Qn5sS7wlJt(LsUiLHfVDii8TGUqZFn8(-1939377524 ^ -1939519262), Description);
			case 5:
				if (IsArray)
				{
					num2 = 3;
					break;
				}
				goto case 4;
			case 1:
				if (Items.Any())
				{
					num2 = 5;
					break;
				}
				goto default;
			case 2:
				text = Items.ToCommaSeparatedString();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return (string)LsUiLHfVDii8TGUqZFn8(0x7247028A ^ 0x724243B0) + text + (string)LsUiLHfVDii8TGUqZFn8(-105199646 ^ -104873824);
			case 3:
				return (string)lmR2UffVwW3ehW6YhNRX(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A84F8F6), text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606965680));
			}
		}
	}

	public TypeSerializationDescriptor Clone()
	{
		return (TypeSerializationDescriptor)JOiw7vfV4U9bhZL2gv4H(this);
	}

	object ICloneable.Clone()
	{
		TypeSerializationDescriptor typeSerializationDescriptor = new TypeSerializationDescriptor();
		iKUs0XfV6YkSMHrOiefT(typeSerializationDescriptor, IsArray);
		bgw8DMfVHQllfjZURBTP(typeSerializationDescriptor, Description);
		typeSerializationDescriptor.Items = new SerializableList<TypeSerializationItemDescriptor>(Items.Select((TypeSerializationItemDescriptor i) => (TypeSerializationItemDescriptor)_003C_003Ec.sSQSQ585z89ybaGijH4b(i)));
		return typeSerializationDescriptor;
	}

	internal static bool woBJaqfVNjXjEs5Zw9GO()
	{
		return hBy6jZfV14uTvm8Rjjor == null;
	}

	internal static TypeSerializationDescriptor YFWmRDfV3ElRf9d0DcOL()
	{
		return hBy6jZfV14uTvm8Rjjor;
	}

	internal static bool kHtNjGfVppyqJ1g37tca(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool oKrAFAfVagMO47AFDWLE(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object LsUiLHfVDii8TGUqZFn8(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object jVSkXNfVt3Qn5sS7wlJt(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object lmR2UffVwW3ehW6YhNRX(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object JOiw7vfV4U9bhZL2gv4H(object P_0)
	{
		return ((ICloneable)P_0).Clone();
	}

	internal static void iKUs0XfV6YkSMHrOiefT(object P_0, bool value)
	{
		((TypeSerializationDescriptor)P_0).IsArray = value;
	}

	internal static void bgw8DMfVHQllfjZURBTP(object P_0, object P_1)
	{
		((TypeSerializationDescriptor)P_0).Description = (string)P_1;
	}
}
