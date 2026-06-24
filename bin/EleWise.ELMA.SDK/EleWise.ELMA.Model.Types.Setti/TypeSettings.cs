using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.Common;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Settings;

[Serializable]
[KnownType("GetKnownType")]
[Component]
public class TypeSettings : Attribute, IXsiType, IXsiRoot, ISerializable
{
	private static ConcurrentDictionary<Type, PropertiesHelper> initializersCache;

	private static ConcurrentDictionary<Type, PropertiesContainer> defaultValuesCache;

	[NonSerialized]
	private IEntity _boundEntity;

	[NonSerialized]
	private Guid _boundEntityPropertyUid;

	internal static TypeSettings aZVIyqbBypqJFOyJK8W7;

	[XmlIgnore]
	[ScriptIgnore]
	public override object TypeId => rD6UldbWFQh0A8bHfx6F(this);

	public TypeSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		gLYDm0bB9qp406LWIdC8();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
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
			tvwgXIbBdqBaGvrmBNDc(this);
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
			{
				num = 0;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CWriteValidatePropertyAttributes_003Ed__1))]
	public virtual IEnumerable<ISyntaxNode> WriteValidatePropertyAttributes()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CWriteValidatePropertyAttributes_003Ed__1(-2);
	}

	public Dictionary<string, object> GetSettingsValuePairs()
	{
		return TypeSettingsSerializer.SerializeToDictionary(this);
	}

	public virtual void SerializeToJsonObject(SerializableDictionary<string, object> jsonObject)
	{
		TypeSettingsSerializer.SerializeBasicToJsonObject(this, jsonObject);
	}

	public virtual void DeserializeFromJsonObject(IDictionary<string, object> jsonObject)
	{
		TypeSettingsSerializer.DeserializeBasicFromJsonObject(this, jsonObject);
	}

	public TypeSerializationDescriptor GetSerializationDescriptor()
	{
		int num = 1;
		int num2 = num;
		TypeSerializationDescriptor typeSerializationDescriptor = default(TypeSerializationDescriptor);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return typeSerializationDescriptor;
			default:
				GetSerializationDescriptor(typeSerializationDescriptor);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				typeSerializationDescriptor = new TypeSerializationDescriptor();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void CopyFrom(TypeSettings other)
	{
		//Discarded unreachable code: IL_0035, IL_0044, IL_009d, IL_00ac, IL_010d, IL_01d3, IL_01e2, IL_027c, IL_028f, IL_029e
		int num = 4;
		int num2 = num;
		Dictionary<string, object>.Enumerator enumerator = default(Dictionary<string, object>.Enumerator);
		KeyValuePair<string, object> current = default(KeyValuePair<string, object>);
		PropertyInfo property = default(PropertyInfo);
		PropertyInfo property2 = default(PropertyInfo);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				enumerator = other.GetSettingsValuePairs().GetEnumerator();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				if (other == null)
				{
					return;
				}
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				try
				{
					while (true)
					{
						IL_0160:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
							{
								num3 = 0;
							}
							goto IL_00bb;
						}
						goto IL_00f5;
						IL_00f5:
						current = enumerator.Current;
						num3 = 7;
						goto IL_00bb;
						IL_00bb:
						while (true)
						{
							int num4;
							switch (num3)
							{
							case 3:
								if (!lmNfZobBr6wOMNBE1wn8(property, null))
								{
									num4 = 8;
									goto IL_00b7;
								}
								goto case 9;
							case 7:
								property2 = other.GetType().GetProperty(current.Key);
								num3 = 9;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
								{
									num3 = 10;
								}
								continue;
							case 5:
							case 8:
							case 11:
								goto IL_0160;
							case 9:
								if (!XWYMLLbBgiVAdFu0J8x8(property))
								{
									num3 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 6;
							case 6:
								if (U4mxV6bBjejC0VQoJ0Vp(PyxLi2bB5N1ATnc7RZLC(property), property2.PropertyType))
								{
									num3 = 2;
									continue;
								}
								goto IL_0160;
							case 4:
								if (lmNfZobBr6wOMNBE1wn8(property2, null))
								{
									num3 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto IL_0160;
							case 10:
								property = nXbZRNbBlCxjh56cBTNj(this).GetProperty(current.Key);
								num4 = 4;
								goto IL_00b7;
							case 2:
								property.SetValue(this, current.Value, null);
								num3 = 11;
								continue;
							case 1:
								return;
								IL_00b7:
								num3 = num4;
								continue;
							}
							break;
						}
						goto IL_00f5;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
			case 1:
				return;
			}
		}
	}

	public virtual TypeSettings Clone()
	{
		TypeSettings obj = (TypeSettings)SEGV6tbBYqv8OCpio064(nXbZRNbBlCxjh56cBTNj(this));
		GuI58ybBL3xcsBcBapCS(obj, this);
		return obj;
	}

	public TSettings As<TSettings>() where TSettings : TypeSettings
	{
		return (TSettings)this;
	}

	public void BindToEntity(IEntity entity, Guid propertyUid)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				_boundEntity = entity;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_boundEntityPropertyUid = propertyUid;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public void Save()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				throw new InvalidOperationException(SR.T((string)RuOImAbBUQp8GWFdvp97(0x6A81B9B4 ^ 0x6A8316C2), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE139A3)));
			case 1:
				if (_boundEntity != null)
				{
					XbyslpbBs63S17Xvnh4L(_boundEntity, _boundEntityPropertyUid, this);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num2 = 2;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 0;
					}
				}
				break;
			case 2:
				return;
			}
		}
	}

	public virtual void SetTypeSettings(PropertiesContainer dict)
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
				KAn1FnbBzGxTHi31iMge(NZdH3tbBcGKChXSNjy1G(nXbZRNbBlCxjh56cBTNj(this)), dict, this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected TypeSettings(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_001a, IL_001f, IL_0092, IL_00a1
		gLYDm0bB9qp406LWIdC8();
		base._002Ector();
		int num = 3;
		object obj = default(object);
		SerializationInfoEnumerator serializationInfoEnumerator = default(SerializationInfoEnumerator);
		PropertyInfo property = default(PropertyInfo);
		string name = default(string);
		while (true)
		{
			switch (num)
			{
			case 4:
				obj = OCEga9bWoZ5UBa7FKvSi(info, serializationInfoEnumerator.Name, serializationInfoEnumerator.ObjectType);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num = 0;
				}
				break;
			default:
				R2vTTFbWbkDoL1JRfebA(property, this, obj, null);
				num = 7;
				break;
			case 1:
				return;
			case 2:
			case 5:
			case 7:
				if (!k8kE1WbWhe11qRKgRL82(serializationInfoEnumerator))
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num = 1;
					}
					break;
				}
				goto case 10;
			case 9:
				property = nXbZRNbBlCxjh56cBTNj(this).GetProperty(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
				num = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num = 7;
				}
				break;
			case 10:
				name = (string)NrLQwubWWGIWNfl26pi5(serializationInfoEnumerator);
				num = 9;
				break;
			case 11:
				serializationInfoEnumerator = (SerializationInfoEnumerator)lbQXgAbWBlxol0N9RJIH(info);
				num = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num = 6;
				}
				break;
			case 3:
				tvwgXIbBdqBaGvrmBNDc(this);
				num = 11;
				break;
			case 8:
				if (!(property != null))
				{
					num = 2;
					break;
				}
				goto case 4;
			case 6:
				serializationInfoEnumerator.Reset();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num = 5;
				}
				break;
			}
		}
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002e, IL_0038, IL_00e9, IL_00fc, IL_010b
		int num = 1;
		int num2 = num;
		Dictionary<string, object>.Enumerator enumerator = default(Dictionary<string, object>.Enumerator);
		KeyValuePair<string, object> current = default(KeyValuePair<string, object>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				enumerator = GetSettingsValuePairs().GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 2;
						goto IL_003c;
					}
					goto IL_009a;
					IL_003c:
					while (true)
					{
						switch (num3)
						{
						default:
							WPZ7BubWGZoMudIM22N2(info, current.Key, current.Value);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							break;
						case 3:
							goto IL_009a;
						case 2:
							return;
						}
						break;
					}
					continue;
					IL_009a:
					current = enumerator.Current;
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num3 = 0;
					}
					goto IL_003c;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				case 0:
					break;
				}
			}
		}
	}

	protected virtual void InitDefaultPropertyValues()
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = default(_003C_003Ec__DisplayClass16_0);
		PropertiesContainer orAdd = default(PropertiesContainer);
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				KAn1FnbBzGxTHi31iMge(_003C_003Ec__DisplayClass16_.cache, orAdd, this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
				num2 = 2;
				break;
			case 4:
				orAdd = defaultValuesCache.GetOrAdd(type, _003C_003Ec__DisplayClass16_._003CInitDefaultPropertyValues_003Eb__0);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				_003C_003Ec__DisplayClass16_.cache = GetInitializerCache(type);
				num2 = 4;
				break;
			case 2:
				type = nXbZRNbBlCxjh56cBTNj(this);
				num2 = 5;
				break;
			}
		}
	}

	protected virtual void GetSerializationDescriptor(TypeSerializationDescriptor descriptor)
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
				imqfXabWEJtuqvNm8RMh(nXbZRNbBlCxjh56cBTNj(this), descriptor);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private static PropertiesHelper GetInitializerCache(Type type)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass22_0 _003C_003Ec__DisplayClass22_ = default(_003C_003Ec__DisplayClass22_0);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass22_.type = type;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return initializersCache.GetOrAdd(_003C_003Ec__DisplayClass22_.type, _003C_003Ec__DisplayClass22_._003CGetInitializerCache_003Eb__0);
			case 1:
				_003C_003Ec__DisplayClass22_ = new _003C_003Ec__DisplayClass22_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[UsedImplicitly]
	private static IEnumerable<Type> GetKnownType()
	{
		return from t in ComponentManager.Current.GetExtensionPointTypes<IXsiType>()
			where _003C_003Ec.dEnHgwCXUIiWC5Kw9QHq(typeof(TypeSettings).TypeHandle).IsAssignableFrom(t)
			select t;
	}

	static TypeSettings()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				defaultValuesCache = new ConcurrentDictionary<Type, PropertiesContainer>();
				num2 = 3;
				break;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				initializersCache = new ConcurrentDictionary<Type, PropertiesHelper>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			}
		}
	}

	internal static void gLYDm0bB9qp406LWIdC8()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void tvwgXIbBdqBaGvrmBNDc(object P_0)
	{
		((TypeSettings)P_0).InitDefaultPropertyValues();
	}

	internal static bool AOMKAdbBMpc157VNSmdO()
	{
		return aZVIyqbBypqJFOyJK8W7 == null;
	}

	internal static TypeSettings onOLVvbBJQ4RVlNgS9xx()
	{
		return aZVIyqbBypqJFOyJK8W7;
	}

	internal static Type nXbZRNbBlCxjh56cBTNj(object P_0)
	{
		return P_0.GetType();
	}

	internal static bool lmNfZobBr6wOMNBE1wn8(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 != (PropertyInfo)P_1;
	}

	internal static bool XWYMLLbBgiVAdFu0J8x8(object P_0)
	{
		return ((PropertyInfo)P_0).CanWrite;
	}

	internal static Type PyxLi2bB5N1ATnc7RZLC(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static bool U4mxV6bBjejC0VQoJ0Vp(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object SEGV6tbBYqv8OCpio064(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static void GuI58ybBL3xcsBcBapCS(object P_0, object P_1)
	{
		((TypeSettings)P_0).CopyFrom((TypeSettings)P_1);
	}

	internal static object RuOImAbBUQp8GWFdvp97(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void XbyslpbBs63S17Xvnh4L(object P_0, Guid propertyUid, object P_2)
	{
		((IEntity)P_0).SavePropertyInstanceSettings(propertyUid, (TypeSettings)P_2);
	}

	internal static object NZdH3tbBcGKChXSNjy1G(Type type)
	{
		return GetInitializerCache(type);
	}

	internal static void KAn1FnbBzGxTHi31iMge(object P_0, object P_1, object P_2)
	{
		((PropertiesHelper)P_0).SetValues((PropertiesContainer)P_1, P_2);
	}

	internal static object rD6UldbWFQh0A8bHfx6F(object P_0)
	{
		return ((Attribute)P_0).TypeId;
	}

	internal static object lbQXgAbWBlxol0N9RJIH(object P_0)
	{
		return ((SerializationInfo)P_0).GetEnumerator();
	}

	internal static object NrLQwubWWGIWNfl26pi5(object P_0)
	{
		return ((SerializationInfoEnumerator)P_0).Name;
	}

	internal static object OCEga9bWoZ5UBa7FKvSi(object P_0, object P_1, Type P_2)
	{
		return ((SerializationInfo)P_0).GetValue((string)P_1, P_2);
	}

	internal static void R2vTTFbWbkDoL1JRfebA(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static bool k8kE1WbWhe11qRKgRL82(object P_0)
	{
		return ((SerializationInfoEnumerator)P_0).MoveNext();
	}

	internal static void WPZ7BubWGZoMudIM22N2(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}

	internal static void imqfXabWEJtuqvNm8RMh(Type typeSettingsType, object P_1)
	{
		TypeSettingsSerializer.GetSerializationDescriptor(typeSettingsType, (TypeSerializationDescriptor)P_1);
	}
}
