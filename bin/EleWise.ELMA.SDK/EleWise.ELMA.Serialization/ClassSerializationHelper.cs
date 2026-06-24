using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using System.Xml;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Text;
using EleWise.ELMA.XmlSerializers;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Serialization;

public static class ClassSerializationHelper
{
	private class XmlSerializerFactory
	{
		private bool useExtra;

		public object serializers;

		private static object lK0vwtQe4AXh9Z7EeyX0;

		public XmlSerializerFactory(bool useExtra)
		{
			//Discarded unreachable code: IL_003a, IL_003f
			SingletonReader.JJCZtPuTvSt();
			serializers = new Hashtable();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
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
				this.useExtra = useExtra;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num = 0;
				}
			}
		}

		public XmlSerializer GetSerializer(Type t)
		{
			//Discarded unreachable code: IL_00de, IL_00ed, IL_0164, IL_0173, IL_01ab, IL_022e, IL_0266, IL_0275
			int num = 3;
			XmlSerializer xmlSerializer = default(XmlSerializer);
			object obj = default(object);
			bool lockTaken = default(bool);
			XmlSerializerAttribute attribute = default(XmlSerializerAttribute);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 3:
						xmlSerializer = null;
						num2 = 2;
						continue;
					case 2:
						obj = QlrpSsQeAi9s2On0UwJc(serializers);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
						{
							num2 = 0;
						}
						continue;
					case 1:
						return xmlSerializer;
					case 4:
						try
						{
							Monitor.Enter(obj, ref lockTaken);
							int num3 = 2;
							while (true)
							{
								object obj2;
								switch (num3)
								{
								case 3:
									return xmlSerializer;
								case 10:
									attribute = AttributeHelper<XmlSerializerAttribute>.GetAttribute(t, inherited: false);
									num3 = 7;
									continue;
								case 6:
									if (useExtra)
									{
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
										{
											num3 = 9;
										}
										continue;
									}
									goto case 10;
								case 4:
									if (xmlSerializer != null)
									{
										return xmlSerializer;
									}
									num3 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
									{
										num3 = 0;
									}
									continue;
								case 2:
								{
									xmlSerializer = ((Hashtable)serializers)[(object)t] as XmlSerializer;
									int num4 = 4;
									num3 = num4;
									continue;
								}
								case 7:
									if (attribute != null)
									{
										num3 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
										{
											num3 = 0;
										}
										continue;
									}
									goto case 8;
								case 8:
									obj2 = CacheableXmlSerializer.Create(t, useExtra: false);
									break;
								case 9:
									xmlSerializer = CacheableXmlSerializer.Create(t, useExtra: true);
									num3 = 5;
									continue;
								default:
									Wu6eREQe0anvIHhZXWsU(serializers, t, xmlSerializer);
									num3 = 3;
									continue;
								case 1:
									obj2 = (XmlSerializer)Ejop1VQexcLkcfk4JTwP(Il09IhQe7cW6rQ1erANM(attribute));
									break;
								}
								xmlSerializer = (XmlSerializer)obj2;
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
								{
									num3 = 0;
								}
							}
						}
						finally
						{
							if (lockTaken)
							{
								int num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
								{
									num5 = 0;
								}
								while (true)
								{
									switch (num5)
									{
									default:
										AnqLP0QemvqKUxtfUoyV(obj);
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
										{
											num5 = 1;
										}
										continue;
									case 1:
										break;
									}
									break;
								}
							}
						}
					}
					break;
				}
				lockTaken = false;
				num = 4;
			}
		}

		internal static bool j2lsQTQe6kYX3IOLFqyC()
		{
			return lK0vwtQe4AXh9Z7EeyX0 == null;
		}

		internal static XmlSerializerFactory KV197kQeHQkYHVfa1cWq()
		{
			return (XmlSerializerFactory)lK0vwtQe4AXh9Z7EeyX0;
		}

		internal static object QlrpSsQeAi9s2On0UwJc(object P_0)
		{
			return ((Hashtable)P_0).SyncRoot;
		}

		internal static Type Il09IhQe7cW6rQ1erANM(object P_0)
		{
			return ((XmlSerializerAttribute)P_0).SerializerType;
		}

		internal static object Ejop1VQexcLkcfk4JTwP(Type P_0)
		{
			return Activator.CreateInstance(P_0);
		}

		internal static void Wu6eREQe0anvIHhZXWsU(object P_0, object P_1, object P_2)
		{
			((Hashtable)P_0).Add(P_1, P_2);
		}

		internal static void AnqLP0QemvqKUxtfUoyV(object P_0)
		{
			Monitor.Exit(P_0);
		}
	}

	private static readonly XmlSerializerFactory xmlSerFactory;

	private static readonly XmlSerializerFactory xmlSerFactoryExtra;

	internal static ClassSerializationHelper odZoMcBgReKNKGhfRWwC;

	public static void WriteDataForSerialization(object obj, SerializationInfo info)
	{
		//Discarded unreachable code: IL_007a, IL_0089
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				return;
			case 2:
				OVlovXBgXhAEi2IMKe9f(obj.GetType(), obj, info);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (obj == null)
				{
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private static void WriteDataForSerialization(Type type, object obj, object info)
	{
		//Discarded unreachable code: IL_0059, IL_0068, IL_00b4
		int num = 6;
		int num2 = num;
		int num3 = default(int);
		FieldInfo[] reflectionFields = default(FieldInfo[]);
		FieldInfo fieldInfo = default(FieldInfo);
		object obj2 = default(object);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				num3 = 0;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 11;
				}
				break;
			case 7:
				if (XltplNBgTClCmiBhPHbZ(type, AXcC3QBgkHwSBiAHW5jG(typeof(object).TypeHandle)))
				{
					num2 = 13;
					break;
				}
				reflectionFields = type.GetReflectionFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				num2 = 3;
				break;
			case 5:
				return;
			case 10:
			case 11:
				if (num3 >= reflectionFields.Length)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 9;
					}
					break;
				}
				goto case 1;
			case 9:
				OVlovXBgXhAEi2IMKe9f(type.BaseType, obj, info);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				if (XltplNBgTClCmiBhPHbZ(type, null))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 7;
			case 2:
				lH2tohBgek2V3dObVvig(info, dGQOTbBg2wDuCAUZ0WFJ(fieldInfo), obj2);
				num2 = 4;
				break;
			case 4:
				num3++;
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 4;
				}
				break;
			case 0:
				return;
			case 1:
				fieldInfo = reflectionFields[num3];
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 3;
				}
				break;
			case 12:
				obj2 = iHdfQ6BgOT722T5NOAF9(fieldInfo, obj);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num2 = 2;
				}
				break;
			case 8:
				if ((nHIMuaBgnwtQUJEbthXs(fieldInfo) & FieldAttributes.NotSerialized) != FieldAttributes.NotSerialized)
				{
					num2 = 12;
					break;
				}
				goto case 4;
			case 13:
				return;
			}
		}
	}

	public static void ReadDataForDeserialization(object obj, SerializationInfo info)
	{
		//Discarded unreachable code: IL_00a8, IL_00b7
		int num = 6;
		int num2 = num;
		SerializationInfoEnumerator serializationInfoEnumerator = default(SerializationInfoEnumerator);
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 3:
			case 4:
				if (!serializationInfoEnumerator.MoveNext())
				{
					num2 = 2;
					continue;
				}
				break;
			default:
				serializationInfoEnumerator = (SerializationInfoEnumerator)eRru6EBgP0eaWqM9Ete2(info);
				num2 = 4;
				continue;
			case 6:
				if (obj == null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 3;
					}
					continue;
				}
				type = obj.GetType();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				return;
			case 2:
				return;
			case 1:
				break;
			}
			vLxUhtBgNFGDeCb2OrtC(type, DpNv9GBg1JCYhdnjmivL(serializationInfoEnumerator), obj, info);
			num2 = 3;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
			{
				num2 = 2;
			}
		}
	}

	private static void ReadDataForDeserialization(Type type, object name, object obj, object info)
	{
		//Discarded unreachable code: IL_006b, IL_007a
		int num = 4;
		FieldInfo reflectionField = default(FieldInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return;
				case 6:
					return;
				case 7:
					wbnb1HBgDASxOHvw3KwA(reflectionField, obj, TNMWpJBgatP3vmP0PFhP(info, name, KqpUmYBgparQN1odSqVS(reflectionField)));
					num2 = 6;
					continue;
				case 2:
					return;
				default:
					reflectionField = type.GetReflectionField((string)name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					if (XltplNBgTClCmiBhPHbZ(type, null))
					{
						return;
					}
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					if (FmF92HBg3NCY9vqg5fAy(name))
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					if (!(reflectionField != null))
					{
						ReadDataForDeserialization(type.BaseType, name, obj, info);
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					num = 7;
					break;
				}
				break;
			}
		}
	}

	public static object CloneObject(object obj)
	{
		//Discarded unreachable code: IL_005b, IL_006a, IL_00c6, IL_00fe, IL_013e, IL_014d, IL_0159
		int num = 4;
		MemoryStream memoryStream = default(MemoryStream);
		object obj2 = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return null;
				case 3:
					memoryStream = (MemoryStream)yHiuvGBgtigHwHXm97lf();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return obj2;
				case 4:
					if (obj != null)
					{
						break;
					}
					goto case 1;
				default:
					try
					{
						BinaryFormatter binaryFormatter = new BinaryFormatter();
						t2gmBvBgwp6kAqRG7g4u(binaryFormatter, memoryStream, obj);
						UnKXgbBg4pFUN0t0HbUm(memoryStream, 0L, SeekOrigin.Begin);
						obj2 = binaryFormatter.Deserialize(memoryStream);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
						{
							num3 = 0;
						}
						return num3 switch
						{
							0 => obj2, 
							_ => obj2, 
						};
					}
					finally
					{
						int num4;
						if (memoryStream == null)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
							{
								num4 = 0;
							}
							goto IL_0102;
						}
						goto IL_0118;
						IL_0118:
						WMhDAiBg6i18PKUhlwGC(memoryStream);
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
						{
							num4 = 0;
						}
						goto IL_0102;
						IL_0102:
						switch (num4)
						{
						default:
							goto end_IL_00dd;
						case 2:
							break;
						case 0:
							goto end_IL_00dd;
						case 1:
							goto end_IL_00dd;
						}
						goto IL_0118;
						end_IL_00dd:;
					}
				}
				break;
			}
			num = 3;
		}
	}

	public static T CloneObject<T>(T obj)
	{
		if (object.Equals(obj, default(T)))
		{
			return default(T);
		}
		return (T)CloneObject((object)obj);
	}

	public static byte[] SerializeObject(object obj)
	{
		//Discarded unreachable code: IL_004d, IL_0069, IL_00b7, IL_00d6, IL_00e5, IL_0112, IL_0121
		int num = 1;
		int num2 = num;
		byte[] result = default(byte[]);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 1:
				memoryStream = SerializeObjectToMemoryStream(obj);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				int num3;
				if (memoryStream == null)
				{
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num3 = 0;
					}
					goto IL_0051;
				}
				object obj2 = F5kpPkBgHQWgYDJwlehB(memoryStream);
				goto IL_0075;
				IL_0075:
				result = (byte[])obj2;
				num3 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num3 = 1;
				}
				goto IL_0051;
				IL_0051:
				switch (num3)
				{
				case 1:
					return result;
				}
				obj2 = null;
				goto IL_0075;
			}
			finally
			{
				int num4;
				if (memoryStream == null)
				{
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num4 = 0;
					}
					goto IL_00bb;
				}
				goto IL_00f0;
				IL_00f0:
				((IDisposable)memoryStream).Dispose();
				num4 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num4 = 2;
				}
				goto IL_00bb;
				IL_00bb:
				switch (num4)
				{
				default:
					goto end_IL_0096;
				case 0:
					goto end_IL_0096;
				case 1:
					break;
				case 2:
					goto end_IL_0096;
				}
				goto IL_00f0;
				end_IL_0096:;
			}
		}
	}

	public static MemoryStream SerializeObjectToMemoryStream(object obj)
	{
		//Discarded unreachable code: IL_0070
		int num = 1;
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return null;
				case 1:
					if (obj != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 5:
					t2gmBvBgwp6kAqRG7g4u(new BinaryFormatter(), memoryStream, obj);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 2;
					}
					continue;
				case 3:
					return memoryStream;
				case 2:
					UnKXgbBg4pFUN0t0HbUm(memoryStream, 0L, SeekOrigin.Begin);
					num2 = 3;
					continue;
				}
				break;
			}
			memoryStream = (MemoryStream)yHiuvGBgtigHwHXm97lf();
			num = 5;
		}
	}

	public static object DeserializeObject(byte[] bytes)
	{
		//Discarded unreachable code: IL_004d, IL_005c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (bytes == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return U12oaXBgAOUZII0Kt7wZ(bytes, 0, bytes.Length);
			case 1:
				return null;
			}
		}
	}

	public static object DeserializeObject(byte[] bytes, int bytesOffset, int bytesLength)
	{
		//Discarded unreachable code: IL_0044, IL_0053, IL_0063, IL_0072, IL_00f9, IL_0131, IL_0169
		int num = 4;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		object obj = default(object);
		while (true)
		{
			switch (num2)
			{
			case 7:
				return obj;
			case 1:
				if (bytesLength != 0)
				{
					num2 = 6;
					break;
				}
				goto default;
			case 4:
				if (bytes != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			case 3:
				if (bytes.Length == 0)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			default:
				return null;
			case 6:
				memoryStream = (MemoryStream)aK2BBPBg7dpC8BEWG4JC(bytes, bytesOffset, bytesLength, false);
				num2 = 5;
				break;
			case 5:
				try
				{
					obj = DeserializeObjectFromStream(memoryStream);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => obj, 
						_ => obj, 
					};
				}
				finally
				{
					if (memoryStream != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								WMhDAiBg6i18PKUhlwGC(memoryStream);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
								{
									num4 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			}
		}
	}

	public static object DeserializeObjectFromStream(Stream memoryStream)
	{
		//Discarded unreachable code: IL_006b, IL_007a, IL_00ad, IL_00e8, IL_00fb, IL_010a
		int num = 3;
		int num2 = num;
		object result = default(object);
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 2:
				UnKXgbBg4pFUN0t0HbUm(memoryStream, 0L, SeekOrigin.Begin);
				num2 = 4;
				break;
			case 3:
				if (memoryStream != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			case 4:
				try
				{
					result = eRtOmSBgxI6nGyQEUoSC(new BinaryFormatter(), memoryStream);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => result, 
						_ => result, 
					};
				}
				finally
				{
					UnKXgbBg4pFUN0t0HbUm(memoryStream, 0L, SeekOrigin.Begin);
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			case 1:
				return result;
			}
		}
	}

	public static string SerializeObjectToString(object obj)
	{
		//Discarded unreachable code: IL_0068, IL_00f5, IL_012d, IL_013c
		int num = 1;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				memoryStream = (MemoryStream)yHiuvGBgtigHwHXm97lf();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				return result;
			case 3:
				try
				{
					t2gmBvBgwp6kAqRG7g4u(new BinaryFormatter(), memoryStream, obj);
					int num3 = 2;
					while (true)
					{
						switch (num3)
						{
						case 1:
							return result;
						default:
							result = (string)Mt7PJJBgyZ1ZIeHU6Gys(memoryStream, EncodingCache.Win1251Encoding);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
							{
								num3 = 0;
							}
							break;
						case 2:
							memoryStream.Seek(0L, SeekOrigin.Begin);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				}
				finally
				{
					if (memoryStream != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								WMhDAiBg6i18PKUhlwGC(memoryStream);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			case 1:
				bXpUTrBgmXwbEaO38p4q(obj, Fn5C9aBg0g2vvsKNa6iK(-420743386 ^ -420784978));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static object DeserializeObjectFromString(string str)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return MemoryHelper.ActionWithMemoryBuffer<byte, string, object>(cPmm6TBgMSQErkWAyD24(EncodingCache.Win1251Encoding, str), str, DeserializeObjectFromStringAction);
			case 1:
				Contract.ArgumentNotNull(str, (string)Fn5C9aBg0g2vvsKNa6iK(0x5DD55050 ^ 0x5DD52014));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static object DeserializeObjectFromStringAction(object buffer, int offset, int length, object str)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				PQ1qgnBg9mTGa1EX9on9(EncodingCache.Win1251Encoding, str, 0, oZHSfaBgJKPjGTFwVwpd(str), buffer, offset);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return U12oaXBgAOUZII0Kt7wZ(buffer, offset, length);
			}
		}
	}

	public static T CloneObjectByXml<T>(T obj, bool useComponentManager = true) where T : class
	{
		if (obj == null)
		{
			return null;
		}
		obj = obj.CastAsRealType();
		using MemoryStream memoryStream = MemoryHelper.GetMemoryStream();
		using XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
		XmlSerializer serializer = (useComponentManager ? xmlSerFactoryExtra : xmlSerFactory).GetSerializer(obj.GetType());
		serializer.Serialize(xmlTextWriter, obj);
		xmlTextWriter.Flush();
		memoryStream.Seek(0L, SeekOrigin.Begin);
		using XmlTextReader xmlReader = new XmlTextReader(memoryStream);
		return (T)serializer.Deserialize(xmlReader);
	}

	public static byte[] SerializeObjectByXmlToBytes(object obj, bool useComponentManager = true)
	{
		//Discarded unreachable code: IL_004a, IL_0069, IL_0079, IL_00c7, IL_00ff, IL_010e
		int num = 2;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		byte[] result = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					int num3;
					if (memoryStream != null)
					{
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num3 = 1;
						}
						goto IL_004e;
					}
					goto IL_0073;
					IL_007e:
					object obj2 = F5kpPkBgHQWgYDJwlehB(memoryStream);
					goto IL_0085;
					IL_004e:
					switch (num3)
					{
					case 2:
						break;
					case 1:
						goto IL_007e;
					default:
						return result;
					case 0:
						return result;
					}
					goto IL_0073;
					IL_0073:
					obj2 = null;
					goto IL_0085;
					IL_0085:
					result = (byte[])obj2;
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num3 = 0;
					}
					goto IL_004e;
				}
				finally
				{
					if (memoryStream != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								WMhDAiBg6i18PKUhlwGC(memoryStream);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
								{
									num4 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 2:
				memoryStream = (MemoryStream)t3njIIBgllshEBpf5duZ(obj, useComponentManager, n5EXOnBgdEiPL5ZhObLn());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num2 = 1;
				}
				break;
			default:
				return result;
			}
		}
	}

	public static string SerializeObjectByXml(object obj, bool useComponentManager = true)
	{
		//Discarded unreachable code: IL_004d, IL_006d, IL_0077, IL_00d3, IL_0103, IL_0112, IL_011e, IL_012d
		int num = 2;
		int num2 = num;
		string result = default(string);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			default:
				return result;
			case 1:
				try
				{
					int num3;
					if (memoryStream != null)
					{
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
						{
							num3 = 0;
						}
						goto IL_0051;
					}
					goto IL_0067;
					IL_0085:
					object obj2 = Mt7PJJBgyZ1ZIeHU6Gys(memoryStream, EncodingCache.UTF8WithoutEmitIdentifier);
					goto IL_0091;
					IL_0051:
					switch (num3)
					{
					default:
						return result;
					case 0:
						return result;
					case 2:
						break;
					case 1:
						goto IL_0085;
					}
					goto IL_0067;
					IL_0067:
					obj2 = null;
					goto IL_0091;
					IL_0091:
					result = (string)obj2;
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num3 = 0;
					}
					goto IL_0051;
				}
				finally
				{
					int num4;
					if (memoryStream == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
						{
							num4 = 0;
						}
						goto IL_00d7;
					}
					goto IL_00ed;
					IL_00ed:
					((IDisposable)memoryStream).Dispose();
					num4 = 2;
					goto IL_00d7;
					IL_00d7:
					switch (num4)
					{
					case 1:
						goto end_IL_00b2;
					case 2:
						goto end_IL_00b2;
					}
					goto IL_00ed;
					end_IL_00b2:;
				}
			case 2:
				memoryStream = (MemoryStream)t3njIIBgllshEBpf5duZ(obj, useComponentManager, EncodingCache.UTF8WithoutEmitIdentifier);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public static MemoryStream SerializeObjectByXmlToMemoryStream(object obj, bool useComponentManager = true)
	{
		return SerializeByXmlToMemoryStreamInternal(obj, useComponentManager, n5EXOnBgdEiPL5ZhObLn());
	}

	public static void SerializeObjectByXml(object obj, XmlWriter writer, bool useComponentManager = true)
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
				SerializeObjectByXml(obj.GetType(), obj, writer, useComponentManager);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void SerializeObjectByXml(Type serType, object obj, XmlWriter writer, bool useComponentManager = true)
	{
		//Discarded unreachable code: IL_0036
		int num = 3;
		int num2 = num;
		while (true)
		{
			XmlSerializerFactory xmlSerializerFactory;
			switch (num2)
			{
			default:
				return;
			case 1:
				xmlSerializerFactory = xmlSerFactory;
				break;
			case 2:
				if (!useComponentManager)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					continue;
				}
				xmlSerializerFactory = xmlSerFactoryExtra;
				break;
			case 3:
				obj = b94kMQBgrM1IInV8jn6b(obj);
				num2 = 2;
				continue;
			case 0:
				return;
			}
			k4NJlFBg5P1xa3XILlcG(Xv1oOdBggKnli9a01n6Y(xmlSerializerFactory, serType), writer, obj);
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
			{
				num2 = 0;
			}
		}
	}

	public static T DeserializeObjectByXml<T>(string xml, bool useComponentManager = true)
	{
		return (T)DeserializeObjectByXml(typeof(T), xml, useComponentManager);
	}

	public static object DeserializeObjectByXml(Type tp, string xml, bool useComponentManager = true)
	{
		//Discarded unreachable code: IL_00b6, IL_00c5, IL_00ee, IL_0113
		int num = 8;
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (xml.IndexOf('<') <= 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 4;
				default:
					return MemoryHelper.ActionWithMemoryBuffer<byte, (Type, string, bool), object>(Encoding.UTF8.GetByteCount(xml), (tp, xml, useComponentManager), DeserializeObjectByXmlAction);
				case 4:
					xml = (string)HF5CyNBgYCWi2Vw20V62(xml, num3);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					if (!FmF92HBg3NCY9vqg5fAy(xml))
					{
						goto end_IL_0012;
					}
					goto case 6;
				case 6:
				case 7:
					return null;
				case 3:
					num3 = TfN22FBgjoY76YeDFfu2(xml, '<');
					num2 = 5;
					break;
				case 8:
					if (XltplNBgTClCmiBhPHbZ(tp, null))
					{
						num2 = 7;
						break;
					}
					goto case 2;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	private static object DeserializeObjectByXmlAction(object buffer, int offset, int length, (Type, string, bool) param)
	{
		var (type, text, useComponentManager) = param;
		Encoding.UTF8.GetBytes(text, 0, text.Length, (byte[])buffer, offset);
		return DeserializeObjectByXml(type, buffer, length, offset, useComponentManager);
	}

	public static T DeserializeObjectByXml<T>(byte[] bytes, bool useComponentManager = true)
	{
		return (T)DeserializeObjectByXml(typeof(T), bytes, useComponentManager);
	}

	public static object DeserializeObjectByXml(Type tp, byte[] bytes, bool useComponentManager = true)
	{
		return DeserializeObjectByXml(tp, bytes, bytes.Length, 0, useComponentManager);
	}

	public static object DeserializeObjectByXml(Type tp, XmlReader reader, bool useComponentManager = true)
	{
		//Discarded unreachable code: IL_0078
		int num = 3;
		int num2 = num;
		XmlSerializerFactory xmlSerializerFactory;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (reader == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				if (!useComponentManager)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				xmlSerializerFactory = xmlSerFactoryExtra;
				break;
			case 1:
				return null;
			default:
				xmlSerializerFactory = xmlSerFactory;
				break;
			case 3:
				if (!XltplNBgTClCmiBhPHbZ(tp, null))
				{
					num2 = 2;
					continue;
				}
				goto case 1;
			}
			break;
		}
		return eSuMrZBgLe4eWelDfNkT(Xv1oOdBggKnli9a01n6Y(xmlSerializerFactory, tp), reader);
	}

	public static string SerializeObjectByJson(object obj)
	{
		//Discarded unreachable code: IL_009e, IL_011b, IL_013a, IL_0149, IL_0166, IL_0175
		int num = 2;
		int num2 = num;
		DataContractJsonSerializer dataContractJsonSerializer = default(DataContractJsonSerializer);
		MemoryStream memoryStream = default(MemoryStream);
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return null;
			case 2:
				if (obj != null)
				{
					dataContractJsonSerializer = new DataContractJsonSerializer(obj.GetType());
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 3;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 1;
					}
				}
				break;
			case 3:
				try
				{
					FX17UaBgUJpXuvetRGEl(dataContractJsonSerializer, memoryStream, obj);
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							UnKXgbBg4pFUN0t0HbUm(memoryStream, 0L, SeekOrigin.Begin);
							num3 = 2;
							break;
						case 2:
							result = (string)Mt7PJJBgyZ1ZIeHU6Gys(memoryStream, n5EXOnBgdEiPL5ZhObLn());
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
							{
								num3 = 0;
							}
							break;
						default:
							return result;
						case 0:
							return result;
						}
					}
				}
				finally
				{
					int num4;
					if (memoryStream == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
						{
							num4 = 1;
						}
						goto IL_011f;
					}
					goto IL_0154;
					IL_0154:
					((IDisposable)memoryStream).Dispose();
					num4 = 2;
					goto IL_011f;
					IL_011f:
					switch (num4)
					{
					case 1:
						goto end_IL_00fa;
					case 2:
						goto end_IL_00fa;
					}
					goto IL_0154;
					end_IL_00fa:;
				}
			case 4:
				memoryStream = MemoryHelper.GetMemoryStream();
				num2 = 3;
				break;
			default:
				return result;
			}
		}
	}

	public static T DeserializeObjectByJson<T>(string json)
	{
		return (T)DeserializeObjectByJson(typeof(T), json);
	}

	public static T DeserializeObjectByJson<T>(Stream json)
	{
		return (T)DeserializeObjectByJson(typeof(T), json);
	}

	public static object DeserializeObjectByJson(Type typeObject, string json)
	{
		return MemoryHelper.ActionWithMemoryBuffer<byte, (string, Type), object>(cPmm6TBgMSQErkWAyD24(Encoding.UTF8, json), (json, typeObject), DeserializeObjectByJsonAction);
	}

	public static object DeserializeObjectByJson(Type typeObject, Stream stream)
	{
		return HrXmxcBgsjxsv96q9jBP(new DataContractJsonSerializer(typeObject), stream);
	}

	private static object DeserializeObjectByJsonAction(object buffer, int offset, int length, (string, Type) param)
	{
		var (text, typeObject) = param;
		Encoding.UTF8.GetBytes(text, 0, text.Length, (byte[])buffer, offset);
		using MemoryStream stream = MemoryHelper.GetMemoryStream((byte[])buffer, offset, length, writable: false);
		return DeserializeObjectByJson(typeObject, stream);
	}

	public static string SerializeObjectByJsonNet(object obj)
	{
		return SerializeObjectByJsonNet(obj, null);
	}

	public static string SerializeObjectByJsonNet(object obj, IEnumerable<JsonConverter> converters)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		JsonSerializerSettings val = new JsonSerializerSettings();
		val.set_Error((EventHandler<ErrorEventArgs>)delegate(object sender, ErrorEventArgs args)
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
					_003C_003Ec.q65qFAQelVc1DWJlAfTx(_003C_003Ec.aoDmOhQed8p5PjnKXDL2(args), true);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		});
		JsonSerializerSettings val2 = val;
		if (converters != null)
		{
			val2.set_Converters((IList<JsonConverter>)converters.ToList());
		}
		return JsonConvert.SerializeObject(obj, val2);
	}

	public static T DeserializeObjectByJsonNet<T>(string json)
	{
		return (T)DeserializeObjectByJsonNet(TypeOf<T>.Raw, json, null);
	}

	public static T DeserializeObjectByJsonNet<T>(string json, IEnumerable<JsonConverter> converters)
	{
		return (T)DeserializeObjectByJsonNet(TypeOf<T>.Raw, json, converters);
	}

	public static object DeserializeObjectByJsonNet(string json)
	{
		return DeserializeObjectByJsonNet(json, null);
	}

	public static object DeserializeObjectByJsonNet(Type type, string json)
	{
		return DeserializeObjectByJsonNet(type, json, null);
	}

	public static object DeserializeObjectByJsonNet(string json, IEnumerable<JsonConverter> converters)
	{
		return DeserializeObjectByJsonNet(null, json, converters);
	}

	public static object DeserializeObjectByJsonNet(Type type, string json, IEnumerable<JsonConverter> converters)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		JsonSerializerSettings val = new JsonSerializerSettings();
		val.set_Error((EventHandler<ErrorEventArgs>)delegate(object sender, ErrorEventArgs args)
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
					((ErrorContext)_003C_003Ec.aoDmOhQed8p5PjnKXDL2(args)).set_Handled(true);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		});
		JsonSerializerSettings val2 = val;
		if (converters != null)
		{
			val2.set_Converters((IList<JsonConverter>)converters.ToList());
		}
		return JsonConvert.DeserializeObject(json, type, val2);
	}

	internal static string GetUnescapedJsonNetPath(string path)
	{
		//Discarded unreachable code: IL_00a6, IL_00b5
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (fTeglfBgztyBccy9WRob(path, Fn5C9aBg0g2vvsKNa6iK(0x1A33FE36 ^ 0x1A3289DE)))
					{
						goto end_IL_0012;
					}
					goto case 2;
				case 4:
					return (string)boOQ1GB5BJ1dVPvFXbqe(path);
				case 2:
					return path;
				case 5:
					if (nwVa7RB5FbrWHZS4OyjV(path, Fn5C9aBg0g2vvsKNa6iK(-740338220 ^ -740416988)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				default:
					if (oZHSfaBgJKPjGTFwVwpd(path) > 3)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 2;
				case 3:
					if (DPFsfbBgcGgpovYiXHEu(path))
					{
						num2 = 2;
						break;
					}
					goto case 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static object DeserializeObjectByXml(Type type, object bytes, int bytesCount, int bytesOffset, bool useComponentManager = true)
	{
		//Discarded unreachable code: IL_00a1, IL_00d5, IL_00f5, IL_014e, IL_0197, IL_01d7, IL_01e6, IL_01f2, IL_0201, IL_0228, IL_0237
		int num = 4;
		int num2 = num;
		object result = default(object);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 3:
				if (bytes != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 4:
				if (!XltplNBgTClCmiBhPHbZ(type, null))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 1;
			case 5:
				try
				{
					XmlTextReader xmlTextReader = new XmlTextReader(memoryStream);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							int num4;
							if (!useComponentManager)
							{
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
								{
									num4 = 0;
								}
								goto IL_00d9;
							}
							XmlSerializerFactory xmlSerializerFactory = xmlSerFactoryExtra;
							goto IL_00ff;
							IL_00ff:
							result = ((XmlSerializer)Xv1oOdBggKnli9a01n6Y(xmlSerializerFactory, type)).Deserialize((XmlReader)xmlTextReader);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
							{
								num4 = 0;
							}
							goto IL_00d9;
							IL_00d9:
							switch (num4)
							{
							case 1:
								return result;
							}
							xmlSerializerFactory = xmlSerFactory;
							goto IL_00ff;
						}
						finally
						{
							if (xmlTextReader != null)
							{
								int num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
								{
									num5 = 0;
								}
								while (true)
								{
									switch (num5)
									{
									default:
										WMhDAiBg6i18PKUhlwGC(xmlTextReader);
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
										{
											num5 = 1;
										}
										continue;
									case 1:
										break;
									}
									break;
								}
							}
						}
					}
				}
				finally
				{
					int num6;
					if (memoryStream == null)
					{
						num6 = 2;
						goto IL_019b;
					}
					goto IL_01b1;
					IL_019b:
					switch (num6)
					{
					default:
						goto end_IL_0186;
					case 1:
						break;
					case 2:
						goto end_IL_0186;
					case 0:
						goto end_IL_0186;
					}
					goto IL_01b1;
					IL_01b1:
					((IDisposable)memoryStream).Dispose();
					num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num6 = 0;
					}
					goto IL_019b;
					end_IL_0186:;
				}
			case 1:
				return null;
			default:
				memoryStream = (MemoryStream)aK2BBPBg7dpC8BEWG4JC(bytes, bytesOffset, bytesCount, false);
				num2 = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static MemoryStream SerializeByXmlToMemoryStreamInternal(object obj, bool useComponentManager, object encoding)
	{
		//Discarded unreachable code: IL_0088, IL_00f9, IL_0156, IL_0196, IL_01a5, IL_01b1, IL_01f1, IL_0200
		int num = 6;
		MemoryStream memoryStream = default(MemoryStream);
		XmlTextWriter xmlTextWriter = default(XmlTextWriter);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return null;
				case 5:
					break;
				case 2:
					memoryStream = (MemoryStream)yHiuvGBgtigHwHXm97lf();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					try
					{
						oDJVnjB5o8PpGwy4CiLN(xmlTextWriter, Formatting.Indented);
						int num3 = 4;
						while (true)
						{
							XmlSerializerFactory xmlSerializerFactory;
							switch (num3)
							{
							default:
								goto end_IL_008c;
							case 4:
								xmlTextWriter.Indentation = 2;
								num3 = 2;
								continue;
							case 3:
								if (!useComponentManager)
								{
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								xmlSerializerFactory = xmlSerFactoryExtra;
								break;
							case 2:
								XaiDvWB5bRlYuRjoQaus(xmlTextWriter, ' ');
								num3 = 3;
								continue;
							case 1:
								xmlSerializerFactory = xmlSerFactory;
								break;
							case 0:
								goto end_IL_008c;
							}
							((XmlSerializer)Xv1oOdBggKnli9a01n6Y(xmlSerializerFactory, obj.GetType())).Serialize((XmlWriter)xmlTextWriter, obj);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
							{
								num3 = 0;
							}
							continue;
							end_IL_008c:
							break;
						}
					}
					finally
					{
						int num4;
						if (xmlTextWriter == null)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
							{
								num4 = 0;
							}
							goto IL_015a;
						}
						goto IL_0170;
						IL_0170:
						WMhDAiBg6i18PKUhlwGC(xmlTextWriter);
						num4 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
						{
							num4 = 2;
						}
						goto IL_015a;
						IL_015a:
						switch (num4)
						{
						default:
							goto end_IL_0135;
						case 1:
							break;
						case 0:
							goto end_IL_0135;
						case 2:
							goto end_IL_0135;
						}
						goto IL_0170;
						end_IL_0135:;
					}
					goto case 3;
				case 3:
					UnKXgbBg4pFUN0t0HbUm(memoryStream, 0L, SeekOrigin.Begin);
					num2 = 7;
					continue;
				case 1:
					xmlTextWriter = new XmlTextWriter((Stream)Sy5jRqB5WVLwFBX2rfAx(memoryStream), (Encoding)encoding);
					num2 = 4;
					continue;
				case 7:
					return memoryStream;
				case 6:
					if (obj != null)
					{
						num2 = 5;
						continue;
					}
					goto default;
				}
				break;
			}
			obj = b94kMQBgrM1IInV8jn6b(obj);
			num = 2;
		}
	}

	private static string UnescapeJsonNetPath(object source)
	{
		//Discarded unreachable code: IL_016c, IL_0198, IL_01a7, IL_01ea, IL_0268, IL_02a3, IL_0323, IL_0332, IL_0342, IL_0351, IL_0361, IL_0384, IL_0393, IL_0405, IL_045f, IL_046e, IL_04b0, IL_05de, IL_0604
		int num = 45;
		StringBuilder stringBuilder2 = default(StringBuilder);
		int num4 = default(int);
		string text = default(string);
		int num3 = default(int);
		StringBuilder stringBuilder = default(StringBuilder);
		char c = default(char);
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 20:
					ShKmDBB5vKjPagIXbG9q(stringBuilder2, Fn5C9aBg0g2vvsKNa6iK(-1978478350 ^ -1978478762));
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 6;
					}
					continue;
				case 34:
				case 41:
					if (num4 < text.Length)
					{
						num2 = 32;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 43;
						}
						continue;
					}
					goto case 42;
				case 25:
					stringBuilder2.Append(EtCuYeB5CLPeJf9eqw2A(num3));
					num2 = 33;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 21;
					}
					continue;
				case 48:
					stringBuilder = null;
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 2;
					}
					continue;
				case 45:
					stringBuilder2 = new StringBuilder();
					num2 = 41;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 44;
					}
					continue;
				case 46:
					if (c != 'b')
					{
						num2 = 14;
						continue;
					}
					goto case 18;
				case 49:
					num4 = 0;
					num2 = 23;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 41;
					}
					continue;
				case 8:
					if (c != '\\')
					{
						num2 = 46;
						continue;
					}
					goto case 6;
				case 39:
					flag = true;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					if (stringBuilder == null)
					{
						num2 = 13;
						continue;
					}
					goto case 32;
				case 37:
					stringBuilder = new StringBuilder();
					num2 = 15;
					continue;
				case 22:
					ShKmDBB5vKjPagIXbG9q(stringBuilder2, Fn5C9aBg0g2vvsKNa6iK(0x20261A4F ^ 0x202605D1));
					num = 40;
					break;
				case 18:
					ShKmDBB5vKjPagIXbG9q(stringBuilder2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105195398));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 2;
					}
					continue;
				default:
					num4++;
					num2 = 34;
					continue;
				case 11:
					G1t70sB5E5C7WyLfWTVy(stringBuilder2, c);
					num2 = 26;
					continue;
				case 23:
					if (jqIPysB5fDlNTX73xC9h(stringBuilder) == 4)
					{
						num2 = 7;
						continue;
					}
					goto default;
				case 32:
					G1t70sB5E5C7WyLfWTVy(stringBuilder, c);
					num2 = 23;
					continue;
				case 44:
					flag = false;
					num2 = 48;
					continue;
				case 30:
					if (c != 'f')
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 22;
				case 1:
				case 43:
					c = kPNFHyB5GyXlbdyOkxpN(text, num4);
					num2 = 9;
					continue;
				case 3:
					stringBuilder = null;
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 25;
					}
					continue;
				case 27:
					ShKmDBB5vKjPagIXbG9q(stringBuilder2, Fn5C9aBg0g2vvsKNa6iK(-1411196499 ^ -1411201805));
					num2 = 36;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 5;
					}
					continue;
				case 31:
					if ((uint)c <= 98u)
					{
						num2 = 38;
						continue;
					}
					goto case 30;
				case 6:
					ShKmDBB5vKjPagIXbG9q(stringBuilder2, Fn5C9aBg0g2vvsKNa6iK(-2106517564 ^ -2106521422));
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 29;
					}
					continue;
				case 12:
					goto IL_04be;
				case 4:
					if (c != 'n')
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 20;
				case 13:
				case 47:
					if (flag)
					{
						num2 = 10;
						continue;
					}
					goto IL_0547;
				case 10:
					flag = false;
					num2 = 31;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 2;
					}
					continue;
				case 14:
				case 16:
				case 21:
					goto IL_0547;
				case 19:
					text = (string)brTqFpB5hStVoNFMSv28(source, 2, oZHSfaBgJKPjGTFwVwpd(source) - 4);
					num2 = 49;
					continue;
				case 42:
					return stringBuilder2.ToString();
				case 28:
					goto IL_058d;
				case 7:
					num3 = h275gmB5Q7dJJQt7T4gI(stringBuilder.ToString(), 16);
					num2 = 3;
					continue;
				case 38:
					if (c != '\'')
					{
						num = 8;
						break;
					}
					goto case 27;
				case 5:
					{
						switch (c)
						{
						case 'u':
							break;
						case 'r':
							goto IL_04be;
						case 's':
							goto IL_0547;
						case 't':
							goto IL_058d;
						default:
							goto IL_0628;
						}
						goto case 37;
					}
					IL_0628:
					num2 = 21;
					continue;
					IL_058d:
					ShKmDBB5vKjPagIXbG9q(stringBuilder2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A53CF4));
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 24;
					}
					continue;
					IL_0547:
					if (c == '\\')
					{
						num2 = 39;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 11;
					IL_04be:
					stringBuilder2.Append((string)Fn5C9aBg0g2vvsKNa6iK(-1108654032 ^ -1108650296));
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 35;
					}
					continue;
				}
				break;
			}
		}
	}

	static ClassSerializationHelper()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				jdHZm1B58okAVub78vgB();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				xmlSerFactory = new XmlSerializerFactory(useExtra: false);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				xmlSerFactoryExtra = new XmlSerializerFactory(useExtra: true);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void OVlovXBgXhAEi2IMKe9f(Type type, object P_1, object P_2)
	{
		WriteDataForSerialization(type, P_1, P_2);
	}

	internal static bool k60WS4BgqhjPlRtCpNMc()
	{
		return odZoMcBgReKNKGhfRWwC == null;
	}

	internal static ClassSerializationHelper sVKLHBBgKD2txYB8O42J()
	{
		return odZoMcBgReKNKGhfRWwC;
	}

	internal static bool XltplNBgTClCmiBhPHbZ(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static Type AXcC3QBgkHwSBiAHW5jG(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static FieldAttributes nHIMuaBgnwtQUJEbthXs(object P_0)
	{
		return ((FieldInfo)P_0).Attributes;
	}

	internal static object iHdfQ6BgOT722T5NOAF9(object P_0, object P_1)
	{
		return ((FieldInfo)P_0).GetValue(P_1);
	}

	internal static object dGQOTbBg2wDuCAUZ0WFJ(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static void lH2tohBgek2V3dObVvig(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}

	internal static object eRru6EBgP0eaWqM9Ete2(object P_0)
	{
		return ((SerializationInfo)P_0).GetEnumerator();
	}

	internal static object DpNv9GBg1JCYhdnjmivL(object P_0)
	{
		return ((SerializationInfoEnumerator)P_0).Name;
	}

	internal static void vLxUhtBgNFGDeCb2OrtC(Type type, object P_1, object P_2, object P_3)
	{
		ReadDataForDeserialization(type, P_1, P_2, P_3);
	}

	internal static bool FmF92HBg3NCY9vqg5fAy(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static Type KqpUmYBgparQN1odSqVS(object P_0)
	{
		return ((FieldInfo)P_0).FieldType;
	}

	internal static object TNMWpJBgatP3vmP0PFhP(object P_0, object P_1, Type P_2)
	{
		return ((SerializationInfo)P_0).GetValue((string)P_1, P_2);
	}

	internal static void wbnb1HBgDASxOHvw3KwA(object P_0, object P_1, object P_2)
	{
		((FieldInfo)P_0).SetValue(P_1, P_2);
	}

	internal static object yHiuvGBgtigHwHXm97lf()
	{
		return MemoryHelper.GetMemoryStream();
	}

	internal static void t2gmBvBgwp6kAqRG7g4u(object P_0, object P_1, object P_2)
	{
		((BinaryFormatter)P_0).Serialize((Stream)P_1, P_2);
	}

	internal static long UnKXgbBg4pFUN0t0HbUm(object P_0, long P_1, SeekOrigin P_2)
	{
		return ((Stream)P_0).Seek(P_1, P_2);
	}

	internal static void WMhDAiBg6i18PKUhlwGC(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object F5kpPkBgHQWgYDJwlehB(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	internal static object U12oaXBgAOUZII0Kt7wZ(object P_0, int bytesOffset, int bytesLength)
	{
		return DeserializeObject((byte[])P_0, bytesOffset, bytesLength);
	}

	internal static object aK2BBPBg7dpC8BEWG4JC(object P_0, int offset, int length, bool writable)
	{
		return MemoryHelper.GetMemoryStream((byte[])P_0, offset, length, writable);
	}

	internal static object eRtOmSBgxI6nGyQEUoSC(object P_0, object P_1)
	{
		return ((BinaryFormatter)P_0).Deserialize((Stream)P_1);
	}

	internal static object Fn5C9aBg0g2vvsKNa6iK(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void bXpUTrBgmXwbEaO38p4q(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object Mt7PJJBgyZ1ZIeHU6Gys(object P_0, object P_1)
	{
		return ((MemoryStream)P_0).AsString((Encoding)P_1);
	}

	internal static int cPmm6TBgMSQErkWAyD24(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetByteCount((string)P_1);
	}

	internal static int oZHSfaBgJKPjGTFwVwpd(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static int PQ1qgnBg9mTGa1EX9on9(object P_0, object P_1, int P_2, int P_3, object P_4, int P_5)
	{
		return ((Encoding)P_0).GetBytes((string)P_1, P_2, P_3, (byte[])P_4, P_5);
	}

	internal static object n5EXOnBgdEiPL5ZhObLn()
	{
		return Encoding.UTF8;
	}

	internal static object t3njIIBgllshEBpf5duZ(object P_0, bool useComponentManager, object P_2)
	{
		return SerializeByXmlToMemoryStreamInternal(P_0, useComponentManager, P_2);
	}

	internal static object b94kMQBgrM1IInV8jn6b(object P_0)
	{
		return P_0.CastAsRealType();
	}

	internal static object Xv1oOdBggKnli9a01n6Y(object P_0, Type t)
	{
		return ((XmlSerializerFactory)P_0).GetSerializer(t);
	}

	internal static void k4NJlFBg5P1xa3XILlcG(object P_0, object P_1, object P_2)
	{
		((XmlSerializer)P_0).Serialize((XmlWriter)P_1, P_2);
	}

	internal static int TfN22FBgjoY76YeDFfu2(object P_0, char P_1)
	{
		return ((string)P_0).IndexOf(P_1);
	}

	internal static object HF5CyNBgYCWi2Vw20V62(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	internal static object eSuMrZBgLe4eWelDfNkT(object P_0, object P_1)
	{
		return ((XmlSerializer)P_0).Deserialize((XmlReader)P_1);
	}

	internal static void FX17UaBgUJpXuvetRGEl(object P_0, object P_1, object P_2)
	{
		((XmlObjectSerializer)P_0).WriteObject((Stream)P_1, P_2);
	}

	internal static object HrXmxcBgsjxsv96q9jBP(object P_0, object P_1)
	{
		return ((XmlObjectSerializer)P_0).ReadObject((Stream)P_1);
	}

	internal static bool DPFsfbBgcGgpovYiXHEu(object P_0)
	{
		return ((string)P_0).IsNullOrWhiteSpace();
	}

	internal static bool fTeglfBgztyBccy9WRob(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static bool nwVa7RB5FbrWHZS4OyjV(object P_0, object P_1)
	{
		return ((string)P_0).EndsWith((string)P_1);
	}

	internal static object boOQ1GB5BJ1dVPvFXbqe(object P_0)
	{
		return UnescapeJsonNetPath(P_0);
	}

	internal static object Sy5jRqB5WVLwFBX2rfAx(object P_0)
	{
		return ((MemoryStream)P_0).AsNoClose();
	}

	internal static void oDJVnjB5o8PpGwy4CiLN(object P_0, Formatting P_1)
	{
		((XmlTextWriter)P_0).Formatting = P_1;
	}

	internal static void XaiDvWB5bRlYuRjoQaus(object P_0, char P_1)
	{
		((XmlTextWriter)P_0).IndentChar = P_1;
	}

	internal static object brTqFpB5hStVoNFMSv28(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static char kPNFHyB5GyXlbdyOkxpN(object P_0, int P_1)
	{
		return ((string)P_0)[P_1];
	}

	internal static object G1t70sB5E5C7WyLfWTVy(object P_0, char P_1)
	{
		return ((StringBuilder)P_0).Append(P_1);
	}

	internal static int jqIPysB5fDlNTX73xC9h(object P_0)
	{
		return ((StringBuilder)P_0).Length;
	}

	internal static int h275gmB5Q7dJJQt7T4gI(object P_0, int P_1)
	{
		return Convert.ToInt32((string)P_0, P_1);
	}

	internal static char EtCuYeB5CLPeJf9eqw2A(int P_0)
	{
		return Convert.ToChar(P_0);
	}

	internal static object ShKmDBB5vKjPagIXbG9q(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static void jdHZm1B58okAVub78vgB()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
