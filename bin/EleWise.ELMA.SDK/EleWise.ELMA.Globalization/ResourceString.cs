using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Globalization;

[Serializable]
public class ResourceString
{
	private static ResourceString uqxawoGfKusVX92BrJwH;

	public string AssemblyName
	{
		[CompilerGenerated]
		get
		{
			return _003CAssemblyName_003Ek__BackingField;
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
					_003CAssemblyName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
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

	public string Namespace
	{
		[CompilerGenerated]
		get
		{
			return _003CNamespace_003Ek__BackingField;
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
					_003CNamespace_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string ClassName
	{
		[CompilerGenerated]
		get
		{
			return _003CClassName_003Ek__BackingField;
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
					_003CClassName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string ResourceName
	{
		[CompilerGenerated]
		get
		{
			return _003CResourceName_003Ek__BackingField;
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
					_003CResourceName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string FullClassName => (string)U5d9MyGf1MNoL5GmZV9i(bG8rReGfOGxnKGSwV1KH(0x7459E02 ^ 0x7471DB4), Namespace, xiDiNUGfniIj00fmaXIi(Namespace) ? "" : bG8rReGfOGxnKGSwV1KH(-740338220 ^ -740339952), ClassName);

	public string Value
	{
		get
		{
			//Discarded unreachable code: IL_0074, IL_00c5, IL_00d4, IL_0127, IL_013b, IL_014a
			string result = default(string);
			switch (1)
			{
			default:
				return result;
			case 1:
				try
				{
					PropertyInfo property = VDZ65iGf3LsywQJnDJAj(Assembly.Load((string)HiQDo7GfNKAZfia8bJB2(AssemblyName)), HiQDo7GfNKAZfia8bJB2(FullClassName)).GetProperty(ResourceName.Trim());
					int num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num = 3;
					}
					while (true)
					{
						switch (num)
						{
						case 1:
							return result;
						case 2:
							return result;
						case 4:
							result = (string)OnLSkrGfpCJXlTrhR9KV(property, null, null);
							num = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
							{
								num = 1;
							}
							break;
						default:
							result = "";
							num = 2;
							break;
						case 3:
							if (property != null)
							{
								num = 4;
								break;
							}
							goto default;
						}
					}
				}
				catch
				{
					int num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					default:
						throw;
					}
				}
			}
		}
	}

	public ResourceString()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		lbGhdLGfkfvQCtKAnHya();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public void Parse(string val)
	{
		//Discarded unreachable code: IL_013a, IL_01e7, IL_0235, IL_02bb, IL_02ca, IL_0316
		int num = 6;
		string[] array2 = default(string[]);
		string[] array3 = default(string[]);
		List<string> list = default(List<string>);
		string[] array = default(string[]);
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 27:
					ResourceName = array2[1];
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 21;
					}
					continue;
				case 2:
					if (array3.Length <= 1)
					{
						num2 = 24;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 16;
				case 3:
				case 8:
					ResourceName = val;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 4;
					}
					continue;
				case 19:
					if (array2.Length > 1)
					{
						num2 = 7;
						continue;
					}
					goto case 21;
				default:
					EcDCa6GfPnouCM3lqmZ7(list, array.Length - 1);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 26;
					}
					continue;
				case 9:
					return;
				case 21:
				case 25:
					if (val.Contains((string)bG8rReGfOGxnKGSwV1KH(-1751176224 ^ -1751174876)))
					{
						num2 = 20;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
						{
							num2 = 16;
						}
					}
					else
					{
						if (!flag)
						{
							return;
						}
						num2 = 17;
					}
					continue;
				case 28:
					ClassName = array[array.Length - 1];
					num2 = 13;
					continue;
				case 15:
					array2 = (string[])TRcIMMGfe5cG9P0OlcNs(val, new string[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837748423) }, StringSplitOptions.RemoveEmptyEntries);
					num2 = 19;
					continue;
				case 18:
				case 22:
				case 24:
					break;
				case 4:
					flag = false;
					num2 = 25;
					continue;
				case 23:
					if (!LHsbylGf2wM909MALXGt(val, bG8rReGfOGxnKGSwV1KH(0x6DC147B0 ^ 0x6DC016F2)))
					{
						num2 = 8;
						continue;
					}
					goto case 15;
				case 16:
					AssemblyName = array3[0];
					num2 = 14;
					continue;
				case 26:
					Namespace = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138961604), list);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 1;
					}
					continue;
				case 10:
					return;
				case 5:
					if (!LHsbylGf2wM909MALXGt(val, bG8rReGfOGxnKGSwV1KH(-889460160 ^ -889472848)))
					{
						num2 = 22;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 12;
				case 20:
					array = val.Split(new string[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852839744) }, StringSplitOptions.RemoveEmptyEntries);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 11;
					}
					continue;
				case 1:
					return;
				case 12:
					array3 = (string[])TRcIMMGfe5cG9P0OlcNs(val, new string[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710562758) }, StringSplitOptions.RemoveEmptyEntries);
					num2 = 2;
					continue;
				case 13:
					list = new List<string>(array);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					val = array2[0];
					num2 = 27;
					continue;
				case 14:
					val = array3[1];
					num2 = 18;
					continue;
				case 17:
					ClassName = val;
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 7;
					}
					continue;
				case 6:
					if (xiDiNUGfniIj00fmaXIi(val))
					{
						return;
					}
					num2 = 5;
					continue;
				case 11:
					if (array.Length == 0)
					{
						return;
					}
					num2 = 28;
					continue;
				}
				break;
			}
			flag = true;
			num = 23;
		}
	}

	internal static bool gimmCUGfXTfmAkTx6bRh()
	{
		return uqxawoGfKusVX92BrJwH == null;
	}

	internal static ResourceString qX4srSGfTWC9J9K4eYJN()
	{
		return uqxawoGfKusVX92BrJwH;
	}

	internal static void lbGhdLGfkfvQCtKAnHya()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool xiDiNUGfniIj00fmaXIi(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object bG8rReGfOGxnKGSwV1KH(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool LHsbylGf2wM909MALXGt(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static object TRcIMMGfe5cG9P0OlcNs(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((string[])P_1, P_2);
	}

	internal static void EcDCa6GfPnouCM3lqmZ7(object P_0, int P_1)
	{
		((List<string>)P_0).RemoveAt(P_1);
	}

	internal static object U5d9MyGf1MNoL5GmZV9i(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object HiQDo7GfNKAZfia8bJB2(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static Type VDZ65iGf3LsywQJnDJAj(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetReflectionType((string)P_1);
	}

	internal static object OnLSkrGfpCJXlTrhR9KV(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}
}
