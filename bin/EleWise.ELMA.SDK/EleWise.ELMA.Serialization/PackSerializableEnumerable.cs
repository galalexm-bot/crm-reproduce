using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Serialization;

[Serializable]
public class PackSerializableEnumerable<T> : IEnumerable<T>, IEnumerable where T : IPackSerializableItem
{
	private class MyEnumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private readonly PackSerializableEnumerable<T> enumerable;

		private IEnumerator<T> baseEnumerator;

		internal static object b61mmMQ2ehx37mIOPrAf;

		public T Current => GetBaseEnumerator().Current;

		object IEnumerator.Current => GetBaseEnumerator().Current;

		public MyEnumerator(PackSerializableEnumerable<T> enumerable)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			this.enumerable = enumerable;
		}

		public void Dispose()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (baseEnumerator != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				case 2:
					return;
				default:
					baseEnumerator.Dispose();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		public bool MoveNext()
		{
			return GetBaseEnumerator().MoveNext();
		}

		public void Reset()
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
					GetBaseEnumerator().Reset();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		private IEnumerator<T> GetBaseEnumerator()
		{
			lock (this.enumerable)
			{
				if (!this.enumerable.isNormalCollection)
				{
					PackSerializableEnumerable<T> packSerializableEnumerable = this.enumerable;
					IEnumerable<T> enumerable = PackSerializableEnumerable<T>.Unpack(this.enumerable.packSource);
					packSerializableEnumerable.source = enumerable ?? new PackSerializableEnumerable<T>(new T[0]).source;
					this.enumerable.isNormalCollection = true;
				}
				if (baseEnumerator == null)
				{
					baseEnumerator = this.enumerable.source.GetEnumerator();
				}
			}
			return baseEnumerator;
		}

		internal static bool hsEckcQ2PL0gdXI25kFK()
		{
			return b61mmMQ2ehx37mIOPrAf == null;
		}

		internal static object WdoCybQ21T3sKB4rygP3()
		{
			return b61mmMQ2ehx37mIOPrAf;
		}
	}

	private IEnumerable<T> source;

	private bool isNormalCollection;

	private readonly byte[] packSource;

	private static object XbvRhnBd9XykIZeECM25;

	public PackSerializableEnumerable(byte[] packSource)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				isNormalCollection = false;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			default:
				this.packSource = packSource;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	public PackSerializableEnumerable(IEnumerable<T> source)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.source = source ?? new T[0];
		isNormalCollection = true;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return new MyEnumerator(this);
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return new MyEnumerator(this);
	}

	public static byte[] Pack(PackSerializableEnumerable<T> source)
	{
		if (source != null && source.source != null && source.Any())
		{
			return GetBytes(StringSerializable(source.Select((T value) => value.Serialize()).ToList())).Zip(9);
		}
		return null;
	}

	public static PackSerializableEnumerable<T> Unpack(byte[] packSource)
	{
		if (packSource == null || packSource.Length == 0)
		{
			return new PackSerializableEnumerable<T>(new T[0]);
		}
		try
		{
			return new PackSerializableEnumerable<T>(StringDeserializable(GetString((packSource.Length != 0) ? packSource.Unzip() : Array.Empty<byte>())).Select(delegate(string i)
			{
				T result = InterfaceActivator.Create<T>();
				result.DeserializeFrom(i);
				return result;
			}));
		}
		catch (Exception)
		{
			return null;
		}
	}

	private static byte[] GetBytes(string str)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
				if (!string.IsNullOrEmpty(str))
				{
					return Encoding.UTF8.GetBytes(str);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static string GetString(byte[] bytes)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return null;
			default:
				return "";
			case 2:
				if (bytes != null)
				{
					if (bytes.Length != 0)
					{
						return Encoding.UTF8.GetString(bytes);
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 1;
					}
				}
				break;
			}
		}
	}

	private static string StringSerializable(List<string> listString)
	{
		if (listString == null || !listString.Any())
		{
			return null;
		}
		return string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538465700), listString.Select((string s) => s.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87336947), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA585811)).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571FD1D3), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606715068))));
	}

	private static IEnumerable<string> StringDeserializable(string value)
	{
		_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass15_0();
		if (value == null)
		{
			return null;
		}
		if (string.IsNullOrEmpty(value))
		{
			return new List<string> { value };
		}
		CS_0024_003C_003E8__locals0.tempSeparator = Guid.NewGuid().ToString();
		CS_0024_003C_003E8__locals0.tempSeparator2 = Guid.NewGuid().ToString();
		Func<string, string> selector = (string s) => s.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FB7296), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112633124)).Replace(CS_0024_003C_003E8__locals0.tempSeparator, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334996875)).Replace(CS_0024_003C_003E8__locals0.tempSeparator2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710505344));
		value = value.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x42654053), CS_0024_003C_003E8__locals0.tempSeparator).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC3C315), CS_0024_003C_003E8__locals0.tempSeparator2);
		return value.Split(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x51147057).ToCharArray()).Select(selector);
	}

	internal static bool JGMGUMBddV47GFVXgd5g()
	{
		return XbvRhnBd9XykIZeECM25 == null;
	}

	internal static object ccpa4iBdlkRMtPyPOmeJ()
	{
		return XbvRhnBd9XykIZeECM25;
	}
}
