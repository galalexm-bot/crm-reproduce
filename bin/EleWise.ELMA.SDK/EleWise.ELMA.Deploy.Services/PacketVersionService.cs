using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Attributes;
using EleWise.ELMA.Deploy.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Services;

[Service]
public class PacketVersionService
{
	private Dictionary<string, List<string>> checkDictionary;

	private Dictionary<string, List<string>> blackDictionary;

	private static PacketVersionService u1ItbnEAn0WtGPMHXpIO;

	private void InitializeCheckDictionary()
	{
		//Discarded unreachable code: IL_00a0, IL_00aa, IL_00d9, IL_01ef, IL_0227, IL_0236, IL_0247, IL_0256, IL_0261, IL_0285, IL_028f, IL_032c, IL_039b, IL_04ab, IL_04ba, IL_0501, IL_0539, IL_0548, IL_05d7, IL_0617, IL_0622
		int num = 3;
		int num2 = num;
		IEnumerator<KeyValuePair<string, List<string>>> enumerator3 = default(IEnumerator<KeyValuePair<string, List<string>>>);
		IEnumerator<IPacketVersionProcessor> enumerator = default(IEnumerator<IPacketVersionProcessor>);
		IEnumerator<PacketAttribute> enumerator2 = default(IEnumerator<PacketAttribute>);
		PacketAttribute current = default(PacketAttribute);
		string text = default(string);
		string item2 = default(string);
		KeyValuePair<string, List<string>> current2 = default(KeyValuePair<string, List<string>>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 4:
				enumerator3 = blackDictionary.Where((KeyValuePair<string, List<string>> item) => checkDictionary.ContainsKey(item.Key)).GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
			{
				IEnumerable<IPacketVersionProcessor> extensionPoints = ComponentManager.Current.GetExtensionPoints<IPacketVersionProcessor>();
				checkDictionary = new Dictionary<string, List<string>>();
				blackDictionary = new Dictionary<string, List<string>>();
				enumerator = extensionPoints.GetEnumerator();
				num2 = 2;
				continue;
			}
			case 2:
				try
				{
					while (true)
					{
						int num3;
						if (!Ao34gbEADInlWySoiDhQ(enumerator))
						{
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
							{
								num3 = 2;
							}
							goto IL_0265;
						}
						goto IL_0579;
						IL_0579:
						enumerator2 = ((IEnumerable)jEr5MxEAeejW8SAwwBve(enumerator.Current.GetType(), false)).OfType<PacketAttribute>().GetEnumerator();
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num3 = 0;
						}
						goto IL_0265;
						IL_0265:
						switch (num3)
						{
						case 1:
							continue;
						case 3:
							goto IL_0579;
						case 2:
							goto end_IL_0553;
						}
						try
						{
							while (true)
							{
								IL_045a:
								int num4;
								if (!enumerator2.MoveNext())
								{
									num4 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
									{
										num4 = 2;
									}
									goto IL_0293;
								}
								goto IL_02e1;
								IL_02e1:
								current = enumerator2.Current;
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
								{
									num4 = 1;
								}
								goto IL_0293;
								IL_0293:
								while (true)
								{
									switch (num4)
									{
									case 7:
										break;
									case 1:
										text = (string)fH1iCQEAPUL36Qckhh3e(current);
										num4 = 14;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
										{
											num4 = 5;
										}
										continue;
									case 10:
										blackDictionary[text].Add(item2);
										num4 = 9;
										continue;
									case 8:
										checkDictionary.Add(text, new List<string>());
										num4 = 13;
										continue;
									case 6:
										if (!QsyPoeEANO74Cs1bEMjM(text))
										{
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
											{
												num4 = 0;
											}
											continue;
										}
										goto IL_045a;
									case 3:
									case 4:
										if (!blackDictionary.ContainsKey(text))
										{
											num4 = 12;
											continue;
										}
										goto case 10;
									case 13:
									case 15:
										checkDictionary[text].Add(item2);
										num4 = 11;
										continue;
									case 12:
										blackDictionary.Add(text, new List<string>());
										num4 = 10;
										continue;
									case 5:
										if (checkDictionary.ContainsKey(text))
										{
											num4 = 14;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
											{
												num4 = 15;
											}
											continue;
										}
										goto case 8;
									default:
										item2 = string.Concat(SCbnGvEA3XbuHPJU4eR2(-978351861 ^ -978590379), ehyc7PEA14BL2o9KZG7V(current));
										num4 = 16;
										continue;
									case 9:
									case 11:
										goto IL_045a;
									case 16:
										if (!huvICaEApuhJIWeZwIPh(current))
										{
											num4 = 4;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
											{
												num4 = 4;
											}
											continue;
										}
										goto case 5;
									case 14:
										if (ehyc7PEA14BL2o9KZG7V(current) != 0)
										{
											num4 = 6;
											continue;
										}
										goto IL_045a;
									case 2:
										goto end_IL_045a;
									}
									break;
								}
								goto IL_02e1;
								continue;
								end_IL_045a:
								break;
							}
						}
						finally
						{
							if (enumerator2 != null)
							{
								int num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
								{
									num5 = 0;
								}
								while (true)
								{
									switch (num5)
									{
									case 1:
										jHl0BJEAaeSItBd8T6wl(enumerator2);
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
										{
											num5 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
						continue;
						end_IL_0553:
						break;
					}
				}
				finally
				{
					int num6;
					if (enumerator == null)
					{
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
						{
							num6 = 0;
						}
						goto IL_05db;
					}
					goto IL_05f1;
					IL_05f1:
					jHl0BJEAaeSItBd8T6wl(enumerator);
					num6 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num6 = 1;
					}
					goto IL_05db;
					IL_05db:
					switch (num6)
					{
					default:
						goto end_IL_05b6;
					case 2:
						break;
					case 0:
						goto end_IL_05b6;
					case 1:
						goto end_IL_05b6;
					}
					goto IL_05f1;
					end_IL_05b6:;
				}
				goto case 4;
			}
			try
			{
				while (true)
				{
					int num7;
					if (!enumerator3.MoveNext())
					{
						num7 = 3;
						goto IL_00ae;
					}
					goto IL_015c;
					IL_00ae:
					while (true)
					{
						switch (num7)
						{
						case 3:
							return;
						case 4:
							checkDictionary.Remove(current2.Key);
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
							{
								num7 = 0;
							}
							continue;
						case 2:
							if (checkDictionary[current2.Key].Any())
							{
								num7 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
								{
									num7 = 6;
								}
								continue;
							}
							goto case 4;
						case 5:
							goto IL_015c;
						case 1:
							checkDictionary[current2.Key] = checkDictionary[current2.Key].Except(blackDictionary[current2.Key]).ToList();
							num7 = 2;
							continue;
						}
						break;
					}
					continue;
					IL_015c:
					current2 = enumerator3.Current;
					num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num7 = 1;
					}
					goto IL_00ae;
				}
			}
			finally
			{
				if (enumerator3 != null)
				{
					int num8 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num8 = 1;
					}
					while (true)
					{
						switch (num8)
						{
						case 1:
							enumerator3.Dispose();
							num8 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
							{
								num8 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
			}
		}
	}

	public bool Check(string nodeName, string contentType)
	{
		//Discarded unreachable code: IL_010f
		int num = 6;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 6:
				if (vHp02hEAtNctWObKAQ5h(nodeName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426335403)))
				{
					num2 = 5;
					break;
				}
				if (QsyPoeEANO74Cs1bEMjM(nodeName))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			case 5:
				return true;
			case 3:
				if (checkDictionary.ContainsKey(contentType))
				{
					num2 = 7;
					break;
				}
				return false;
			case 2:
				InitializeCheckDictionary();
				num2 = 3;
				break;
			case 4:
				if (QsyPoeEANO74Cs1bEMjM(contentType))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 0;
					}
					break;
				}
				if (checkDictionary == null)
				{
					num2 = 2;
					break;
				}
				goto case 3;
			default:
				return false;
			case 7:
				return checkDictionary[contentType].Contains(nodeName);
			}
		}
	}

	public PacketVersionService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		W7q2klEAwvJsv9qMiknm();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object jEr5MxEAeejW8SAwwBve(object P_0, bool P_1)
	{
		return ((MemberInfo)P_0).GetCustomAttributes(P_1);
	}

	internal static object fH1iCQEAPUL36Qckhh3e(object P_0)
	{
		return ((PacketAttribute)P_0).ContentType;
	}

	internal static int ehyc7PEA14BL2o9KZG7V(object P_0)
	{
		return ((PacketAttribute)P_0).Version;
	}

	internal static bool QsyPoeEANO74Cs1bEMjM(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object SCbnGvEA3XbuHPJU4eR2(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool huvICaEApuhJIWeZwIPh(object P_0)
	{
		return ((PacketAttribute)P_0).Active;
	}

	internal static void jHl0BJEAaeSItBd8T6wl(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool Ao34gbEADInlWySoiDhQ(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static bool BiuesrEAOtg0CkrhT3sG()
	{
		return u1ItbnEAn0WtGPMHXpIO == null;
	}

	internal static PacketVersionService F1pvu2EA2l6BBv5jgifU()
	{
		return u1ItbnEAn0WtGPMHXpIO;
	}

	internal static bool vHp02hEAtNctWObKAQ5h(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void W7q2klEAwvJsv9qMiknm()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
