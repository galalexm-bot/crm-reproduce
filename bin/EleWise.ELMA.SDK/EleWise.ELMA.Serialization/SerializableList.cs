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
public class SerializableList<T> : List<T>, ISerializable, ICloneable
{
	protected const string VALUE_NAME = "value";

	protected const string ARRAY_NAME = "values";

	private static object N9ZRRaB5ZIvDNWjnGHCU;

	public SerializableList()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public SerializableList(IEnumerable<T> collection)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(collection);
	}

	public SerializableList(int capacity)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(capacity);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_006e, IL_007d
		int num = 4;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return;
			case 2:
			case 3:
				if (num3 >= base.Count)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 4:
				num3 = 0;
				num2 = 3;
				continue;
			case 1:
				num3++;
				num2 = 2;
				continue;
			}
			info.AddValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289732836) + num3, base[num3]);
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
			{
				num2 = 1;
			}
		}
	}

	public SerializableList(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_001a, IL_001f, IL_0062, IL_0071, IL_012f, IL_013e, IL_01b7, IL_01c6
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 4;
		T[] collection = default(T[]);
		SerializationInfoEnumerator enumerator = default(SerializationInfoEnumerator);
		while (true)
		{
			switch (num)
			{
			case 11:
				AddRange(collection);
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num = 1;
				}
				break;
			default:
				if (enumerator.Name.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307ED6A7)))
				{
					num = 10;
					break;
				}
				goto case 5;
			case 2:
				return;
			case 7:
				enumerator.Reset();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
				{
					num = 5;
				}
				break;
			case 5:
			case 6:
				if (enumerator.MoveNext())
				{
					num = 9;
					break;
				}
				return;
			case 10:
				Add((T)info.GetValue(enumerator.Name, enumerator.ObjectType));
				num = 6;
				break;
			case 1:
				collection = (T[])info.GetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812118090), typeof(T[]));
				num = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num = 10;
				}
				break;
			case 3:
				if (!IsSerializableFieldExists(enumerator, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x426545FB)))
				{
					num = 7;
					break;
				}
				goto case 1;
			case 8:
				return;
			case 4:
				enumerator = info.GetEnumerator();
				num = 3;
				break;
			}
		}
	}

	public static bool IsSerializableFieldExists(SerializationInfoEnumerator sie, string name)
	{
		//Discarded unreachable code: IL_0045, IL_0054, IL_0067, IL_00c2, IL_00d1
		int num = 4;
		int num2 = num;
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
			case 8:
				return result;
			case 4:
				result = false;
				num2 = 3;
				break;
			case 2:
				if (!(sie.Name == name))
				{
					num2 = 6;
					break;
				}
				goto case 5;
			case 3:
				sie.Reset();
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 7;
				}
				break;
			case 5:
				result = true;
				num2 = 8;
				break;
			default:
				if (!sie.MoveNext())
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public byte[] SerializeByBinary()
	{
		//Discarded unreachable code: IL_0074, IL_00d3, IL_00f2, IL_0122, IL_0131
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
				memoryStream = MemoryHelper.GetMemoryStream();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				new BinaryFormatter().Serialize(memoryStream, this);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						return result;
					}
					result = memoryStream.ToArray();
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num3 = 1;
					}
				}
			}
			finally
			{
				int num4;
				if (memoryStream == null)
				{
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num4 = 1;
					}
					goto IL_00d7;
				}
				goto IL_0100;
				IL_0100:
				((IDisposable)memoryStream).Dispose();
				num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num4 = 0;
				}
				goto IL_00d7;
				IL_00d7:
				switch (num4)
				{
				default:
					goto end_IL_00b2;
				case 1:
					goto end_IL_00b2;
				case 2:
					break;
				case 0:
					goto end_IL_00b2;
				}
				goto IL_0100;
				end_IL_00b2:;
			}
		}
	}

	public static SerializableList<T> DeserializeByBinary(byte[] serializedBytes)
	{
		using MemoryStream serializationStream = MemoryHelper.GetMemoryStream(serializedBytes, writable: false);
		return (SerializableList<T>)new BinaryFormatter().Deserialize(serializationStream);
	}

	public object Clone()
	{
		return ClassSerializationHelper.CloneObject(this);
	}

	internal static bool Qlka4CB5uQ0Gvb6Bj3SL()
	{
		return N9ZRRaB5ZIvDNWjnGHCU == null;
	}

	internal static object J8lFEZB5ITuHC16qu06n()
	{
		return N9ZRRaB5ZIvDNWjnGHCU;
	}
}
