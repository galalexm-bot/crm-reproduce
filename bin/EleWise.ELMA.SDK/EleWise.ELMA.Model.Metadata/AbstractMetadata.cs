using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.Common;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
[DataContract]
[Component]
public abstract class AbstractMetadata : Entity<long>, IMetadata, IXsiType, IUnique, ICloneable, IXsiRoot
{
	[NonSerialized]
	private string uidStr;

	private Guid uid;

	private static ConcurrentDictionary<Type, PropertiesHelper> editableMetadataCache;

	private static AbstractMetadata Rco46nbmae8I2dXA6Sob;

	[EntityProperty]
	[PublicationBehaviour(PublicationType.Restart)]
	[Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
	[GuidSettings(FieldName = "Uid")]
	[SystemProperty]
	[Uid("{3508CCB9-AEB6-4AEC-AF21-6A4C8FBEFC53}")]
	[XmlElement("Uid")]
	[DataMember]
	public virtual Guid Uid
	{
		get
		{
			return uid;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					uidStr = value.ToString();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					uid = value;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[XmlIgnore]
	public virtual string UidStr => uidStr;

	[GuidSettings(FieldName = "ModuleUid")]
	[Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
	[XmlElement("ModuleUid")]
	[EntityProperty]
	[Uid("{2BF00C87-1D45-4B93-8689-2709BAB4E97A}")]
	[DataMember]
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
				case 0:
					return;
				case 1:
					_003CModuleUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	[Uid("{6A951C1D-446D-45D2-8834-4C2677CF90F3}")]
	[XmlElement("Internal")]
	[DefaultValue(false)]
	[BoolSettings(FieldName = "Internal")]
	[EntityProperty]
	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	public virtual bool Internal
	{
		[CompilerGenerated]
		get
		{
			return _003CInternal_003Ek__BackingField;
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
					_003CInternal_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
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

	protected AbstractMetadata()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public virtual object Clone()
	{
		AbstractMetadata abstractMetadata = ClassSerializationHelper.CloneObjectByXml(this);
		abstractMetadata.Uid = JBwvQYbmwwM5dtWn7VXf();
		return abstractMetadata;
	}

	public virtual void InitNew()
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
				Uid = JBwvQYbmwwM5dtWn7VXf();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual void AfterLoad()
	{
	}

	public virtual void CopyFrom(AbstractMetadata source, params string[] ignoredProperties)
	{
		//Discarded unreachable code: IL_00c2, IL_00d1, IL_00e1, IL_00f0, IL_017b, IL_018a, IL_0239, IL_02eb, IL_030c, IL_0370, IL_037f
		int num = 21;
		PropertyInfo propertyInfo = default(PropertyInfo);
		int num3 = default(int);
		PropertyInfo property = default(PropertyInfo);
		object obj = default(object);
		object obj2 = default(object);
		PropertyInfo[] properties = default(PropertyInfo[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int condition;
				switch (num2)
				{
				case 16:
					if (ignoredProperties == null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 26;
				case 27:
					return;
				case 21:
					T6yHvEbm6dGCQeWmmG03(source, sYI9Dhbm4BN9xrNLiDaA(0x12441CA4 ^ 0x12441602));
					num2 = 20;
					continue;
				default:
					if (!w0OypDbmx59LnMBqXxBS(propertyInfo))
					{
						num2 = 25;
						continue;
					}
					goto case 22;
				case 4:
				case 28:
					if (xrdGKLbmAVkA5cLySGud(GetType(), source.GetType()))
					{
						num2 = 23;
						continue;
					}
					goto case 2;
				case 29:
					num3 = 0;
					num = 12;
					break;
				case 13:
					if (ignoredProperties != null)
					{
						num = 19;
						break;
					}
					goto case 17;
				case 18:
					new List<string>(ignoredProperties);
					num2 = 17;
					continue;
				case 22:
					if (!BAou9Tbm0pn7ASxEZuFR(propertyInfo))
					{
						num2 = 15;
						continue;
					}
					goto case 16;
				case 2:
					property = source.GetType().GetProperty((string)qCrwARbmmvEo4VE9eODI(propertyInfo));
					num2 = 31;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 13;
					}
					continue;
				case 23:
					obj = GXQVijbmyCJahg3396AT(propertyInfo, source, null);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 1;
					}
					continue;
				case 9:
					LxwXvkbmMagvM3NJ04Lv(propertyInfo, this, obj2, null);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 7;
					}
					continue;
				case 20:
					if (xrdGKLbmAVkA5cLySGud(qQjU8lbmHHVwZMQW3dw1(this), source.GetType()))
					{
						num2 = 10;
						continue;
					}
					goto case 11;
				case 8:
					obj2 = GXQVijbmyCJahg3396AT(property, source, null);
					num2 = 9;
					continue;
				case 3:
				case 7:
				case 15:
				case 25:
				case 30:
					num3++;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 6;
					}
					continue;
				case 19:
					if (ignoredProperties.Length != 0)
					{
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num2 = 16;
						}
						continue;
					}
					goto case 17;
				case 26:
					if (ignoredProperties.Contains((string)qCrwARbmmvEo4VE9eODI(propertyInfo)))
					{
						num2 = 30;
						continue;
					}
					goto case 4;
				case 14:
					condition = (source.GetType().IsAssignableFrom(qQjU8lbmHHVwZMQW3dw1(this)) ? 1 : 0);
					goto IL_03cb;
				case 17:
					properties = qQjU8lbmHHVwZMQW3dw1(this).GetProperties();
					num2 = 29;
					continue;
				case 5:
				case 24:
					propertyInfo = properties[num3];
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					if (!GetType().IsAssignableFrom(source.GetType()))
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 10;
				case 1:
					LxwXvkbmMagvM3NJ04Lv(propertyInfo, this, obj, null);
					num2 = 3;
					continue;
				case 6:
				case 12:
					if (num3 >= properties.Length)
					{
						return;
					}
					num2 = 24;
					continue;
				case 31:
					if (Oj09AdbmJVpH1jTvCWZ3(property, null))
					{
						num2 = 8;
						continue;
					}
					goto case 3;
				case 10:
					{
						condition = 1;
						goto IL_03cb;
					}
					IL_03cb:
					Xmw1qmbm7CXyjElVKPcC((byte)condition != 0, sYI9Dhbm4BN9xrNLiDaA(0x4D1C1EE4 ^ 0x4D1EE24C));
					num2 = 13;
					continue;
				}
				break;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeUid()
	{
		return POI1y1bmded6FELSorcd(TEJsdIbm9SZ7oKUB5PvL(this), Guid.Empty);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeModuleUid()
	{
		return POI1y1bmded6FELSorcd(MAFKJ6bmlOyQY0bJukYi(this), Guid.Empty);
	}

	public static PropertiesHelper GetInitializerCache(Type type)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_ = default(_003C_003Ec__DisplayClass23_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return editableMetadataCache.GetOrAdd(_003C_003Ec__DisplayClass23_.type, _003C_003Ec__DisplayClass23_._003CGetInitializerCache_003Eb__0);
			case 1:
				_003C_003Ec__DisplayClass23_ = new _003C_003Ec__DisplayClass23_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass23_.type = type;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public static bool IsEditingProperty(Type type, string name)
	{
		int num = 1;
		int num2 = num;
		Dictionary<string, Func<object, object>> getActions = default(Dictionary<string, Func<object, object>>);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return true;
			case 1:
				getActions = ((PropertiesHelper)zfFQwDbmrOFwGsNkbKlB(type)).GetActions;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (nn7XU6bmgSGXKZge9phu(getActions) > 0)
			{
				return getActions.ContainsKey(name);
			}
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
			{
				num2 = 0;
			}
		}
	}

	public virtual bool Equals(AbstractMetadata rhs)
	{
		//Discarded unreachable code: IL_0042, IL_0051, IL_0177, IL_018a, IL_01c6
		int num = 5;
		Dictionary<string, Func<object, object>>.Enumerator enumerator = default(Dictionary<string, Func<object, object>>.Enumerator);
		object obj = default(object);
		Func<object, object> value = default(Func<object, object>);
		object obj2 = default(object);
		KeyValuePair<string, Func<object, object>> current = default(KeyValuePair<string, Func<object, object>>);
		bool flag = default(bool);
		PropertiesHelper propertiesHelper = default(PropertiesHelper);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					try
					{
						while (true)
						{
							IL_0131:
							int num4;
							if (!enumerator.MoveNext())
							{
								int num3 = 6;
								num4 = num3;
								goto IL_0060;
							}
							goto IL_00c2;
							IL_0060:
							while (true)
							{
								switch (num4)
								{
								case 5:
									obj = value(this);
									num4 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
									{
										num4 = 4;
									}
									continue;
								case 4:
									obj2 = value(rhs);
									num4 = 3;
									continue;
								case 1:
									break;
								default:
									if (value != null)
									{
										num4 = 5;
										continue;
									}
									goto IL_0131;
								case 7:
									value = current.Value;
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
									{
										num4 = 0;
									}
									continue;
								case 3:
									flag |= obj.Equals(obj2);
									num4 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
									{
										num4 = 0;
									}
									continue;
								case 2:
									goto IL_0131;
								case 6:
									goto end_IL_0131;
								}
								break;
							}
							goto IL_00c2;
							IL_00c2:
							current = enumerator.Current;
							num4 = 7;
							goto IL_0060;
							continue;
							end_IL_0131:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					goto default;
				case 6:
					flag = false;
					num2 = 2;
					continue;
				case 7:
					if (qQjU8lbmHHVwZMQW3dw1(this) == rhs.GetType())
					{
						num2 = 6;
						continue;
					}
					goto default;
				case 5:
					break;
				case 4:
					if (propertiesHelper == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 7;
				default:
					return false;
				case 2:
					enumerator = propertiesHelper.GetActions.GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			propertiesHelper = (PropertiesHelper)zfFQwDbmrOFwGsNkbKlB(rhs.GetType());
			num = 4;
		}
	}

	static AbstractMetadata()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				editableMetadataCache = new ConcurrentDictionary<Type, PropertiesHelper>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				cCK0rlbm5O4kUCY6rUDH();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool UPFp0FbmD2aDgjIu5oXR()
	{
		return Rco46nbmae8I2dXA6Sob == null;
	}

	internal static AbstractMetadata IjVIh5bmtr0ahqc0HSUt()
	{
		return Rco46nbmae8I2dXA6Sob;
	}

	internal static Guid JBwvQYbmwwM5dtWn7VXf()
	{
		return Guid.NewGuid();
	}

	internal static object sYI9Dhbm4BN9xrNLiDaA(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void T6yHvEbm6dGCQeWmmG03(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static Type qQjU8lbmHHVwZMQW3dw1(object P_0)
	{
		return P_0.GetType();
	}

	internal static bool xrdGKLbmAVkA5cLySGud(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static void Xmw1qmbm7CXyjElVKPcC(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static bool w0OypDbmx59LnMBqXxBS(object P_0)
	{
		return ((PropertyInfo)P_0).CanRead;
	}

	internal static bool BAou9Tbm0pn7ASxEZuFR(object P_0)
	{
		return ((PropertyInfo)P_0).CanWrite;
	}

	internal static object qCrwARbmmvEo4VE9eODI(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object GXQVijbmyCJahg3396AT(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static void LxwXvkbmMagvM3NJ04Lv(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static bool Oj09AdbmJVpH1jTvCWZ3(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 != (PropertyInfo)P_1;
	}

	internal static Guid TEJsdIbm9SZ7oKUB5PvL(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static bool POI1y1bmded6FELSorcd(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static Guid MAFKJ6bmlOyQY0bJukYi(object P_0)
	{
		return ((AbstractMetadata)P_0).ModuleUid;
	}

	internal static object zfFQwDbmrOFwGsNkbKlB(Type type)
	{
		return GetInitializerCache(type);
	}

	internal static int nn7XU6bmgSGXKZge9phu(object P_0)
	{
		return ((Dictionary<string, Func<object, object>>)P_0).Count;
	}

	internal static void cCK0rlbm5O4kUCY6rUDH()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
