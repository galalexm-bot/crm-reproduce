using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using EleWise.ELMA.Memory;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Serialization;

[Serializable]
public class SerializableDictionary<TKey, TValue> : Dictionary<TKey, TValue>, ISerializable, ICloneable
{
	protected const string KEY_NAME = "key";

	protected const string VALUE_NAME = "value";

	internal static object eCiJdMBgVo0eSfNPcbuF;

	public SerializableDictionary()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public SerializableDictionary(int capacity)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(capacity);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public SerializableDictionary(IEqualityComparer<TKey> comparer)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(comparer);
	}

	public SerializableDictionary(int capacity, IEqualityComparer<TKey> comparer)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(capacity, comparer);
	}

	public SerializableDictionary(IDictionary<TKey, TValue> dictionary)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(dictionary);
	}

	public SerializableDictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(dictionary, comparer);
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_0032, IL_003c, IL_0188, IL_019b, IL_01aa
		int num = 3;
		int num2 = num;
		Enumerator enumerator = default(Enumerator);
		KeyValuePair<TKey, TValue> current = default(KeyValuePair<TKey, TValue>);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				try
				{
					while (true)
					{
						IL_00ed:
						int num4;
						if (!enumerator.MoveNext())
						{
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
							{
								num4 = 4;
							}
							goto IL_0040;
						}
						goto IL_00aa;
						IL_00aa:
						current = enumerator.Current;
						num4 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
						{
							num4 = 5;
						}
						goto IL_0040;
						IL_0040:
						while (true)
						{
							switch (num4)
							{
							default:
								info.AddValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334979207) + num3, current.Value);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
								{
									num4 = 1;
								}
								continue;
							case 3:
								break;
							case 1:
								num3++;
								num4 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
								{
									num4 = 0;
								}
								continue;
							case 2:
								goto IL_00ed;
							case 5:
								info.AddValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998471014) + num3, current.Key);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
								{
									num4 = 0;
								}
								continue;
							case 4:
								return;
							}
							break;
						}
						goto IL_00aa;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
			case 0:
				return;
			case 2:
				enumerator = GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				num3 = 0;
				num2 = 2;
				break;
			}
		}
	}

	public SerializableDictionary(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002a, IL_0072, IL_0081, IL_0090, IL_00ca, IL_00fd, IL_0127, IL_0136, IL_01de, IL_01ed
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
		{
			num = 0;
		}
		object value2 = default(object);
		object value = default(object);
		string text = default(string);
		SerializationInfoEnumerator enumerator = default(SerializationInfoEnumerator);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 2:
				try
				{
					Add((TKey)value2, (TValue)value);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch (Exception innerException)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					default:
						throw new Exception(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70078297), innerException);
					}
				}
				break;
			case 4:
				text = enumerator.Name.Substring(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957762080).Length);
				num = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num = 5;
				}
				continue;
			case 3:
				value2 = info.GetValue(enumerator.Name, typeof(TKey));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num = 4;
				}
				continue;
			case 6:
				return;
			case 5:
				enumerator.Reset();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num = 1;
				}
				continue;
			case 1:
			case 7:
			case 9:
				break;
			case 8:
			case 11:
				if (!enumerator.Name.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978423470)))
				{
					num2 = 9;
					goto IL_002f;
				}
				goto case 3;
			default:
				enumerator = info.GetEnumerator();
				num2 = 5;
				goto IL_002f;
			case 10:
				{
					value = info.GetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECE1A7C) + text, typeof(TValue));
					num2 = 2;
					goto IL_002f;
				}
				IL_002f:
				num = num2;
				continue;
			}
			if (!enumerator.MoveNext())
			{
				break;
			}
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
			{
				num = 11;
			}
		}
	}

	public byte[] SerializeByBinary()
	{
		//Discarded unreachable code: IL_0074, IL_00d3, IL_0113, IL_0122, IL_012e, IL_013d
		int num = 2;
		int num2 = num;
		byte[] result = default(byte[]);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			default:
				return result;
			case 2:
				memoryStream = MemoryHelper.GetMemoryStream();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					new BinaryFormatter().Serialize(memoryStream, this);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							return result;
						case 0:
							return result;
						case 1:
							result = memoryStream.ToArray();
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				}
				finally
				{
					int num4;
					if (memoryStream == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num4 = 1;
						}
						goto IL_00d7;
					}
					goto IL_00ed;
					IL_00ed:
					((IDisposable)memoryStream).Dispose();
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num4 = 0;
					}
					goto IL_00d7;
					IL_00d7:
					switch (num4)
					{
					default:
						goto end_IL_00b2;
					case 2:
						break;
					case 1:
						goto end_IL_00b2;
					case 0:
						goto end_IL_00b2;
					}
					goto IL_00ed;
					end_IL_00b2:;
				}
			}
		}
	}

	public static SerializableDictionary<TKey, TValue> DeserializeByBinary(byte[] serializedBytes)
	{
		using MemoryStream serializationStream = MemoryHelper.GetMemoryStream(serializedBytes, writable: false);
		return (SerializableDictionary<TKey, TValue>)new BinaryFormatter().Deserialize(serializationStream);
	}

	public object Clone()
	{
		return ClassSerializationHelper.CloneObject(this);
	}

	internal static bool AuHyrgBgSJOC56QAG5Z3()
	{
		return eCiJdMBgVo0eSfNPcbuF == null;
	}

	internal static object jsc0CFBgiELOEvt2scfV()
	{
		return eCiJdMBgVo0eSfNPcbuF;
	}
}
