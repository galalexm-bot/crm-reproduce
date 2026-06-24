using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Globalization;

public class PoMerge
{
	private class MergeStatistics
	{
		public int ValuesAdded;

		public int ValuesRemoved;

		public int ValuesUpdated;

		public int ValuesRestored;

		internal static object xbvtkGvd7kuHeAgZNFnQ;

		public void UpdateFrom(MergeStatistics statistics)
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 3:
						ValuesRestored += statistics.ValuesRestored;
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
						{
							num2 = 2;
						}
						continue;
					case 2:
						return;
					case 1:
						ValuesAdded += statistics.ValuesAdded;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num2 = 0;
						}
						continue;
					case 4:
						ValuesUpdated += statistics.ValuesUpdated;
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				}
				ValuesRemoved += statistics.ValuesRemoved;
				num = 4;
			}
		}

		public bool NotNull()
		{
			//Discarded unreachable code: IL_005e, IL_0092, IL_00a1
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (ValuesAdded != 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 4:
					if (ValuesRemoved != 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto default;
				default:
					if (ValuesUpdated == 0)
					{
						num2 = 5;
						continue;
					}
					break;
				case 5:
					return ValuesRestored != 0;
				case 1:
				case 3:
					break;
				}
				break;
			}
			return true;
		}

		public MergeStatistics()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			eJEdmuvdmjVppXQxMa0k();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool dY4XMavdxCVpX0uWalAu()
		{
			return xbvtkGvd7kuHeAgZNFnQ == null;
		}

		internal static MergeStatistics dvmYPSvd0PVSZOahGcDb()
		{
			return (MergeStatistics)xbvtkGvd7kuHeAgZNFnQ;
		}

		internal static void eJEdmuvdmjVppXQxMa0k()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	internal static PoMerge V4S1PoGou7sNjq30EFEp;

	public static void Merge(string sourcePath, string targetPath, bool doBackup = true, bool allowRemove = false)
	{
		//Discarded unreachable code: IL_008e, IL_010b, IL_011a, IL_01a5, IL_01dd, IL_027b, IL_0319, IL_0328, IL_0409, IL_0418, IL_0522, IL_0535, IL_05c7, IL_05d2, IL_05e1, IL_05ec, IL_0623, IL_0633, IL_063d, IL_06e2, IL_0701, IL_072d, IL_073c, IL_07f5, IL_0804, IL_08a8, IL_08e0, IL_08ef, IL_0926, IL_0939, IL_096e
		int num = 19;
		int num2 = num;
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		string text2 = default(string);
		string current5 = default(string);
		string value = default(string);
		Dictionary<string, string> dictionary = default(Dictionary<string, string>);
		StreamWriter streamWriter = default(StreamWriter);
		string text = default(string);
		Dictionary<string, string>.Enumerator enumerator2 = default(Dictionary<string, string>.Enumerator);
		LocalizationFile localizationFile = default(LocalizationFile);
		MergeStatistics mergeStatistics2 = default(MergeStatistics);
		HashSet<PoLineDescriptor> allKeys = default(HashSet<PoLineDescriptor>);
		KeyValuePair<string, string> current = default(KeyValuePair<string, string>);
		MergeStatistics mergeStatistics = default(MergeStatistics);
		string fileName = default(string);
		KeyValuePair<string, string> current2 = default(KeyValuePair<string, string>);
		IEnumerator<PoLineDescriptor> enumerator3 = default(IEnumerator<PoLineDescriptor>);
		PoLineDescriptor current4 = default(PoLineDescriptor);
		PoLineDescriptor current3 = default(PoLineDescriptor);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 6:
				try
				{
					while (true)
					{
						int num13;
						if (!SPAhVgGonOE4Ct96oTCp(enumerator))
						{
							num13 = 2;
							goto IL_009c;
						}
						goto IL_00ef;
						IL_009c:
						while (true)
						{
							switch (num13)
							{
							case 4:
								text2 = (string)SGTtIIGoTkaeGFm1fS8E(current5);
								num13 = 6;
								continue;
							case 1:
							case 3:
								break;
							case 7:
								goto IL_00ef;
							case 6:
								if (text2 == null)
								{
									num13 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
									{
										num13 = 0;
									}
									continue;
								}
								goto default;
							default:
								value = (string)O8QbpqGoksQ3T1g8FNt4(targetPath, text2);
								num13 = 5;
								continue;
							case 5:
								dictionary.Add(current5, value);
								num13 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
								{
									num13 = 0;
								}
								continue;
							case 2:
								goto end_IL_00d9;
							}
							break;
						}
						continue;
						IL_00ef:
						current5 = enumerator.Current;
						int num14 = 4;
						num13 = num14;
						goto IL_009c;
						continue;
						end_IL_00d9:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num15 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
						{
							num15 = 0;
						}
						while (true)
						{
							switch (num15)
							{
							case 1:
								uuyWbGGoO1DddwOmb1Tb(enumerator);
								num15 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
								{
									num15 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
				goto case 20;
			case 13:
			case 25:
				streamWriter = null;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 23;
				}
				break;
			case 22:
				streamWriter = new StreamWriter((string)fu8vTsGoKFAbGffcG5yg(text, E3RGDIGoiI3c5IVS0UCP(0xA592A41 ^ 0xA5A92ED)));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 3;
				}
				break;
			case 9:
				enumerator2 = dictionary.GetEnumerator();
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 11;
				}
				break;
			case 20:
				localizationFile = new LocalizationFile();
				num2 = 9;
				break;
			case 26:
				dictionary = new Dictionary<string, string>();
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 24;
				}
				break;
			case 7:
				WriteStats(streamWriter, mergeStatistics2);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 1;
				}
				break;
			case 17:
				if (text != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 13;
			case 21:
				allKeys = new HashSet<PoLineDescriptor>(localizationFile.Resources);
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 16;
				}
				break;
			case 1:
				try
				{
					while (true)
					{
						IL_04d0:
						int num3;
						if (!enumerator2.MoveNext())
						{
							num3 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
							{
								num3 = 2;
							}
							goto IL_0337;
						}
						goto IL_0495;
						IL_0495:
						current = enumerator2.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num3 = 1;
						}
						goto IL_0337;
						IL_0337:
						while (true)
						{
							switch (num3)
							{
							case 2:
								XPhnqZGo11vPNMM5eDB9(streamWriter, "");
								num3 = 4;
								continue;
							default:
								WriteStats(streamWriter, mergeStatistics, fileName);
								num3 = 2;
								continue;
							case 4:
								Write(streamWriter, E3RGDIGoiI3c5IVS0UCP(0x92F12D5 ^ 0x92CAA15));
								num3 = 7;
								continue;
							case 12:
								mergeStatistics = MergeFiles(current.Key, current.Value, allowRemove, text, allKeys, streamWriter);
								num3 = 3;
								continue;
							case 9:
							{
								xMjMjaGoPsX5uCmCABKb(mergeStatistics2, mergeStatistics);
								int num4 = 8;
								num3 = num4;
								continue;
							}
							case 7:
								XPhnqZGo11vPNMM5eDB9(streamWriter, "");
								num3 = 10;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
								{
									num3 = 2;
								}
								continue;
							case 8:
								Write(streamWriter, "");
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
								{
									num3 = 0;
								}
								continue;
							case 3:
								if (!bsSkSJGoeuyNwyUE6C0P(mergeStatistics))
								{
									num3 = 8;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
									{
										num3 = 11;
									}
									continue;
								}
								goto case 9;
							case 5:
								break;
							case 1:
								fileName = (string)SGTtIIGoTkaeGFm1fS8E(current.Key);
								num3 = 12;
								continue;
							case 10:
							case 11:
								goto IL_04d0;
							case 6:
								goto end_IL_04d0;
							}
							break;
						}
						goto IL_0495;
						continue;
						end_IL_04d0:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				goto case 7;
			case 15:
				ENxFoHGoqsmDaYpU2adJ(text);
				num2 = 25;
				break;
			default:
				if (EAlT0HGoSy3gTEjpPmFr(text))
				{
					num2 = 13;
					break;
				}
				goto case 15;
			case 8:
				return;
			case 5:
				localizationFile = (LocalizationFile)eLIjgjGo2jM8BoUZ2jsZ(localizationFile);
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 21;
				}
				break;
			case 10:
				streamWriter.Close();
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (streamWriter == null)
				{
					return;
				}
				num2 = 10;
				break;
			case 14:
				obj = null;
				goto IL_09fb;
			case 11:
				try
				{
					while (true)
					{
						int num6;
						if (!enumerator2.MoveNext())
						{
							num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
							{
								num6 = 1;
							}
							goto IL_05f0;
						}
						goto IL_0798;
						IL_0798:
						current2 = enumerator2.Current;
						num6 = 5;
						goto IL_05f0;
						IL_05f0:
						while (true)
						{
							switch (num6)
							{
							case 2:
								try
								{
									while (true)
									{
										IL_0696:
										int num10;
										if (!SPAhVgGonOE4Ct96oTCp(enumerator3))
										{
											num10 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
											{
												num10 = 0;
											}
											goto IL_0641;
										}
										goto IL_0673;
										IL_0673:
										current4 = enumerator3.Current;
										num10 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
										{
											num10 = 0;
										}
										goto IL_0641;
										IL_0641:
										while (true)
										{
											switch (num10)
											{
											case 1:
												localizationFile.Resources.Add(current4);
												num10 = 2;
												continue;
											case 3:
												goto IL_0673;
											case 2:
												goto IL_0696;
											case 0:
												break;
											}
											break;
										}
										break;
									}
								}
								finally
								{
									int num11;
									if (enumerator3 == null)
									{
										num11 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
										{
											num11 = 0;
										}
										goto IL_06e6;
									}
									goto IL_070b;
									IL_070b:
									uuyWbGGoO1DddwOmb1Tb(enumerator3);
									num11 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
									{
										num11 = 1;
									}
									goto IL_06e6;
									IL_06e6:
									switch (num11)
									{
									default:
										goto end_IL_06c1;
									case 0:
										goto end_IL_06c1;
									case 2:
										break;
									case 1:
										goto end_IL_06c1;
									}
									goto IL_070b;
									end_IL_06c1:;
								}
								goto case 4;
							case 5:
								if (string.IsNullOrEmpty(current2.Key))
								{
									num6 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
									{
										num6 = 3;
									}
									continue;
								}
								goto case 7;
							case 3:
							case 8:
								break;
							default:
								goto IL_0798;
							case 7:
								enumerator3 = new LocalizationFile(current2.Key).Resources.GetEnumerator();
								num6 = 2;
								continue;
							case 4:
								enumerator3 = new LocalizationFile(current2.Value).Resources.GetEnumerator();
								num6 = 6;
								continue;
							case 6:
								try
								{
									while (true)
									{
										IL_0868:
										int num8;
										if (!SPAhVgGonOE4Ct96oTCp(enumerator3))
										{
											int num7 = 2;
											num8 = num7;
											goto IL_0813;
										}
										goto IL_082d;
										IL_0813:
										while (true)
										{
											switch (num8)
											{
											case 1:
												break;
											default:
												localizationFile.Resources.Add(current3);
												num8 = 3;
												continue;
											case 3:
												goto IL_0868;
											case 2:
												goto end_IL_0868;
											}
											break;
										}
										goto IL_082d;
										IL_082d:
										current3 = enumerator3.Current;
										num8 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
										{
											num8 = 0;
										}
										goto IL_0813;
										continue;
										end_IL_0868:
										break;
									}
								}
								finally
								{
									if (enumerator3 != null)
									{
										int num9 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
										{
											num9 = 1;
										}
										while (true)
										{
											switch (num9)
											{
											case 1:
												uuyWbGGoO1DddwOmb1Tb(enumerator3);
												num9 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
												{
													num9 = 0;
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
								}
								break;
							case 1:
								goto end_IL_0772;
							}
							break;
						}
						continue;
						end_IL_0772:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
					int num12 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num12 = 0;
					}
					switch (num12)
					{
					case 0:
						break;
					}
				}
				goto case 5;
			case 19:
				if (EAlT0HGoSy3gTEjpPmFr(sourcePath))
				{
					num2 = 18;
					break;
				}
				return;
			case 4:
				mergeStatistics2 = new MergeStatistics();
				num2 = 26;
				break;
			case 16:
				enumerator2 = dictionary.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return;
			case 12:
				if (!doBackup)
				{
					num2 = 14;
					break;
				}
				obj = Path.Combine(targetPath, string.Format((string)E3RGDIGoiI3c5IVS0UCP(0x42643203 ^ 0x42678A65), DxcEsZGoR8HKOqN5KhSZ()));
				goto IL_09fb;
			case 18:
				if (!EAlT0HGoSy3gTEjpPmFr(targetPath))
				{
					return;
				}
				num2 = 12;
				break;
			case 23:
				if (text != null)
				{
					num2 = 22;
					break;
				}
				goto case 4;
			case 24:
				{
					enumerator = ((IEnumerable<string>)SAoKd2GoXsdImLJkyIGS(sourcePath)).Where(delegate(string f)
					{
						int num16 = 1;
						int num17 = num16;
						while (true)
						{
							switch (num17)
							{
							default:
								return !_003C_003Ec.XSmtGrvddd8qlc2NFdYy(f, _003C_003Ec.RW7fDJvdltZaZe4OwRXb(0x3630F361 ^ 0x363524FD));
							case 1:
								if (!_003C_003Ec.XSmtGrvddd8qlc2NFdYy(f, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE4ACE7)))
								{
									return false;
								}
								num17 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
								{
									num17 = 0;
								}
								break;
							}
						}
					}).GetEnumerator();
					num2 = 6;
					break;
				}
				IL_09fb:
				text = (string)obj;
				num2 = 17;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num2 = 15;
				}
				break;
			}
		}
	}

	private static MergeStatistics MergeFiles(object sourcePath, object targetPath, bool allowRemove, string backupPath = null, HashSet<PoLineDescriptor> allKeys = null, StreamWriter log = null)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		MergeStatistics mergeStatistics = new MergeStatistics();
		LocalizationFile file = new LocalizationFile((string)sourcePath);
		file = RemoveDuplicatesFrom(file);
		LocalizationFile file2 = new LocalizationFile((string)targetPath);
		file2 = RemoveDuplicatesFrom(file2);
		if (!File.Exists((string)targetPath))
		{
			File.Copy((string)sourcePath, (string)targetPath, overwrite: true);
			foreach (PoLineDescriptor resource in file.Resources)
			{
				_003C_003Ec__DisplayClass1_1 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass1_1();
				CS_0024_003C_003E8__locals2.sourceKey = resource.Key;
				Write(log, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C972D58), CS_0024_003C_003E8__locals2.sourceKey));
				allKeys?.RemoveWhere((PoLineDescriptor k) => _003C_003Ec__DisplayClass1_1.hJP89fvlFTGuXftbF4jm(_003C_003Ec__DisplayClass1_1.h9cyILvdzGwd5Tg5wkRe(k), CS_0024_003C_003E8__locals2.sourceKey));
			}
			mergeStatistics.ValuesAdded += file.Resources.Count;
			return mergeStatistics;
		}
		if (!string.IsNullOrEmpty(backupPath))
		{
			File.Copy((string)targetPath, backupPath + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106521422) + Path.GetFileName((string)targetPath), overwrite: true);
		}
		CS_0024_003C_003E8__locals0.newTargetFile = new LocalizationFile
		{
			Header = (file2.Header ?? file.Header),
			Name = file2.Name
		};
		using (IEnumerator<PoLineDescriptor> enumerator = file.Resources.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass1_2 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass1_2();
				CS_0024_003C_003E8__locals3.sourcePoLine = enumerator.Current;
				_003C_003Ec__DisplayClass1_3 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass1_3();
				CS_0024_003C_003E8__locals4.sourceKey = CS_0024_003C_003E8__locals3.sourcePoLine.Key;
				PoLineDescriptor poLineDescriptor = file2.Resources.FirstOrDefault((PoLineDescriptor l) => _003C_003Ec__DisplayClass1_3.vE0pG3vlCZqUsm7cLoZg(_003C_003Ec__DisplayClass1_3.mUEEhevlQW8kIvAiBpXr(l), CS_0024_003C_003E8__locals4.sourceKey));
				if (poLineDescriptor == null)
				{
					PoLineDescriptor poLineDescriptor2 = ((allKeys == null) ? CS_0024_003C_003E8__locals3.sourcePoLine : allKeys.FirstOrDefault((PoLineDescriptor l) => _003C_003Ec__DisplayClass1_2.Vn3LWhvlhKifFLW8in6v(_003C_003Ec__DisplayClass1_2.saZBf8vlbWkx6QLZM5P2(l), CS_0024_003C_003E8__locals3.sourcePoLine.Key)));
					if (poLineDescriptor2 != null)
					{
						CS_0024_003C_003E8__locals0.newTargetFile.Resources.Add(poLineDescriptor2);
						Write(log, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411292863), CS_0024_003C_003E8__locals4.sourceKey));
						allKeys?.RemoveWhere((PoLineDescriptor l) => _003C_003Ec__DisplayClass1_2.Vn3LWhvlhKifFLW8in6v(l.Key, _003C_003Ec__DisplayClass1_2.saZBf8vlbWkx6QLZM5P2(CS_0024_003C_003E8__locals3.sourcePoLine)));
						mergeStatistics.ValuesAdded++;
					}
				}
				else if (allKeys == null || allKeys.FirstOrDefault((PoLineDescriptor l) => _003C_003Ec__DisplayClass1_2.Vn3LWhvlhKifFLW8in6v(_003C_003Ec__DisplayClass1_2.saZBf8vlbWkx6QLZM5P2(l), _003C_003Ec__DisplayClass1_2.saZBf8vlbWkx6QLZM5P2(CS_0024_003C_003E8__locals3.sourcePoLine))) != null)
				{
					if (!string.IsNullOrEmpty(CS_0024_003C_003E8__locals3.sourcePoLine.Value) && CS_0024_003C_003E8__locals3.sourcePoLine.Value != poLineDescriptor.Value)
					{
						Write(log, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979401013), CS_0024_003C_003E8__locals4.sourceKey));
						mergeStatistics.ValuesUpdated++;
					}
					else
					{
						Write(log, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76E6D86), CS_0024_003C_003E8__locals4.sourceKey));
						mergeStatistics.ValuesRestored++;
					}
					PoLineDescriptor poLineDescriptor3 = ((allKeys == null) ? CS_0024_003C_003E8__locals3.sourcePoLine : (allKeys.FirstOrDefault((PoLineDescriptor l) => _003C_003Ec__DisplayClass1_2.Vn3LWhvlhKifFLW8in6v(_003C_003Ec__DisplayClass1_2.saZBf8vlbWkx6QLZM5P2(l), _003C_003Ec__DisplayClass1_2.saZBf8vlbWkx6QLZM5P2(CS_0024_003C_003E8__locals3.sourcePoLine))) ?? CS_0024_003C_003E8__locals3.sourcePoLine));
					if (string.IsNullOrEmpty(poLineDescriptor3.Value))
					{
						poLineDescriptor3.Value = poLineDescriptor.Value;
					}
					poLineDescriptor3.IsLow |= poLineDescriptor.IsLow;
					CS_0024_003C_003E8__locals0.newTargetFile.Resources.Add(poLineDescriptor3);
					allKeys?.RemoveWhere((PoLineDescriptor l) => _003C_003Ec__DisplayClass1_2.Vn3LWhvlhKifFLW8in6v(_003C_003Ec__DisplayClass1_2.saZBf8vlbWkx6QLZM5P2(l), _003C_003Ec__DisplayClass1_2.saZBf8vlbWkx6QLZM5P2(CS_0024_003C_003E8__locals3.sourcePoLine)));
				}
			}
		}
		using (List<PoLineDescriptor>.Enumerator enumerator2 = file2.Resources.Where(delegate(PoLineDescriptor poLine)
		{
			int num = 1;
			int num2 = num;
			_003C_003Ec__DisplayClass1_4 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_4);
			while (true)
			{
				switch (num2)
				{
				default:
					_003C_003Ec__DisplayClass1_.poLine = poLine;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_4();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return CS_0024_003C_003E8__locals0.newTargetFile.Resources.All(_003C_003Ec__DisplayClass1_._003CMergeFiles_003Eb__8);
				}
			}
		}).ToList().GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				_003C_003Ec__DisplayClass1_5 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass1_5();
				CS_0024_003C_003E8__locals1.targetPoLine = enumerator2.Current;
				if (allowRemove || (allKeys != null && allKeys.FirstOrDefault((PoLineDescriptor l) => _003C_003Ec__DisplayClass1_5.Im3B9wvlXyMl8JSKAWwQ(_003C_003Ec__DisplayClass1_5.ogQNxevlK6f1wWgEGmkF(l), _003C_003Ec__DisplayClass1_5.ogQNxevlK6f1wWgEGmkF(CS_0024_003C_003E8__locals1.targetPoLine))) == null))
				{
					Write(log, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234134010), CS_0024_003C_003E8__locals1.targetPoLine.Key));
					mergeStatistics.ValuesRemoved++;
					continue;
				}
				Write(log, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740496164), CS_0024_003C_003E8__locals1.targetPoLine.Key));
				CS_0024_003C_003E8__locals0.newTargetFile.Resources.Add(CS_0024_003C_003E8__locals1.targetPoLine);
				mergeStatistics.ValuesRestored++;
				allKeys?.RemoveWhere((PoLineDescriptor l) => _003C_003Ec__DisplayClass1_5.Im3B9wvlXyMl8JSKAWwQ(_003C_003Ec__DisplayClass1_5.ogQNxevlK6f1wWgEGmkF(l), _003C_003Ec__DisplayClass1_5.ogQNxevlK6f1wWgEGmkF(CS_0024_003C_003E8__locals1.targetPoLine)));
			}
		}
		CS_0024_003C_003E8__locals0.newTargetFile.SaveToFile();
		return mergeStatistics;
	}

	private static void Write(object sw, object msg)
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
				if (sw == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 0;
					}
					break;
				}
				mq5PVHGoN5cJbGItnyp9(sw, msg);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 0:
				return;
			}
		}
	}

	private static void WriteStats(object sw, object stats, string fileName = null)
	{
		int num = 3;
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					XPhnqZGo11vPNMM5eDB9(sw, text);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					text = SR.T((string)E3RGDIGoiI3c5IVS0UCP(-957824448 ^ -957645980), ((MergeStatistics)stats).ValuesAdded, ((MergeStatistics)stats).ValuesUpdated, ((MergeStatistics)stats).ValuesRemoved, ((MergeStatistics)stats).ValuesRestored);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					text = SR.T((string)E3RGDIGoiI3c5IVS0UCP(-541731959 ^ -541693385), ((MergeStatistics)stats).ValuesAdded, ((MergeStatistics)stats).ValuesUpdated, ((MergeStatistics)stats).ValuesRemoved, ((MergeStatistics)stats).ValuesRestored, fileName);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					return;
				case 2:
					if (!Hlw1tWGo3dO6VMUEPxQn(fileName))
					{
						break;
					}
					goto default;
				}
				break;
			}
			num = 4;
		}
	}

	private static LocalizationFile RemoveDuplicatesFrom(object file)
	{
		//Discarded unreachable code: IL_0058, IL_0067, IL_0078, IL_0082, IL_00cc, IL_00d6, IL_013f, IL_014e, IL_025b, IL_031e, IL_0331, IL_0441, IL_0460, IL_046f, IL_049c, IL_04ab
		int num = 4;
		int num2 = num;
		LocalizationFile localizationFile = default(LocalizationFile);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		List<PoLineDescriptor>.Enumerator enumerator2 = default(List<PoLineDescriptor>.Enumerator);
		PoLineDescriptor current2 = default(PoLineDescriptor);
		bool flag = default(bool);
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		string current = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return localizationFile;
			case 4:
				if (file != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 1;
			case 2:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 4;
							goto IL_0086;
						}
						goto IL_03f7;
						IL_0086:
						while (true)
						{
							switch (num3)
							{
							case 4:
								return localizationFile;
							case 1:
								break;
							case 2:
								try
								{
									while (true)
									{
										IL_0269:
										int num4;
										if (!enumerator2.MoveNext())
										{
											num4 = 4;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
											{
												num4 = 2;
											}
											goto IL_00da;
										}
										goto IL_0243;
										IL_0243:
										current2 = enumerator2.Current;
										num4 = 11;
										goto IL_00da;
										IL_00da:
										while (true)
										{
											switch (num4)
											{
											case 10:
												if (!flag)
												{
													num4 = 9;
													continue;
												}
												goto case 2;
											case 13:
												flag = true;
												num4 = 3;
												continue;
											case 7:
												if (Hlw1tWGo3dO6VMUEPxQn(IlPMSJGoHl6hNuIMkFUZ(_003C_003Ec__DisplayClass4_.line)))
												{
													num4 = 12;
													continue;
												}
												goto IL_0269;
											case 9:
												RFU5abGowHVAv3KaU7GC(_003C_003Ec__DisplayClass4_.line, IlPMSJGoHl6hNuIMkFUZ(current2));
												num4 = 13;
												continue;
											case 1:
											{
												PoLineDescriptor line = _003C_003Ec__DisplayClass4_.line;
												Hhjr1xGo6RGKrSaRjATi(line, EFQj0rGo4NEn1sEjvlhs(line) | EFQj0rGo4NEn1sEjvlhs(current2));
												num4 = 7;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
												{
													num4 = 7;
												}
												continue;
											}
											case 2:
												iPJDHOGo7LdQ37UCES91(_003C_003Ec__DisplayClass4_.line, true);
												num4 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
												{
													num4 = 6;
												}
												continue;
											case 5:
												if (GGufaGGoA71JM3Vj4cvy(IlPMSJGoHl6hNuIMkFUZ(_003C_003Ec__DisplayClass4_.line), IlPMSJGoHl6hNuIMkFUZ(current2)))
												{
													num4 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
													{
														num4 = 0;
													}
													continue;
												}
												goto case 10;
											case 12:
												if (!string.IsNullOrEmpty(current2.Value))
												{
													num4 = 5;
													continue;
												}
												goto IL_0269;
											case 8:
												break;
											default:
												goto IL_0269;
											case 11:
												_003C_003Ec__DisplayClass4_.line.Comments.AddRange(current2.Comments.Where(_003C_003Ec__DisplayClass4_._003CRemoveDuplicatesFrom_003Eb__6));
												num4 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
												{
													num4 = 1;
												}
												continue;
											case 4:
												goto end_IL_0269;
											}
											break;
										}
										goto IL_0243;
										continue;
										end_IL_0269:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator2).Dispose();
									int num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
									{
										num5 = 0;
									}
									switch (num5)
									{
									case 0:
										break;
									}
								}
								goto case 5;
							case 3:
							{
								List<PoLineDescriptor> list = ((LocalizationFile)file).Resources.Where(_003C_003Ec__DisplayClass4_._003CRemoveDuplicatesFrom_003Eb__5).ToList();
								_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_2 = _003C_003Ec__DisplayClass4_;
								PoLineDescriptor poLineDescriptor = new PoLineDescriptor();
								P3N6xeGotXRma7lqbCVa(poLineDescriptor, _003C_003Ec__DisplayClass4_.key);
								poLineDescriptor.IsFuzzy = false;
								RFU5abGowHVAv3KaU7GC(poLineDescriptor, string.Empty);
								_003C_003Ec__DisplayClass4_2.line = poLineDescriptor;
								flag = false;
								enumerator2 = list.GetEnumerator();
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
								{
									num3 = 2;
								}
								continue;
							}
							case 5:
								localizationFile.Resources.Add(_003C_003Ec__DisplayClass4_.line);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
								{
									num3 = 1;
								}
								continue;
							case 6:
								_003C_003Ec__DisplayClass4_.key = current;
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
								{
									num3 = 2;
								}
								continue;
							case 7:
								goto IL_03f7;
							default:
								_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
								num3 = 6;
								continue;
							}
							break;
						}
						continue;
						IL_03f7:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
						{
							num3 = 0;
						}
						goto IL_0086;
					}
				}
				finally
				{
					int num6;
					if (enumerator == null)
					{
						num6 = 2;
						goto IL_0445;
					}
					goto IL_047a;
					IL_0445:
					switch (num6)
					{
					case 2:
						goto end_IL_0430;
					case 1:
						goto end_IL_0430;
					}
					goto IL_047a;
					IL_047a:
					uuyWbGGoO1DddwOmb1Tb(enumerator);
					num6 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num6 = 1;
					}
					goto IL_0445;
					end_IL_0430:;
				}
			case 1:
				return new LocalizationFile();
			case 3:
			{
				IEnumerable<IGrouping<string, PoLineDescriptor>> source = from r in ((LocalizationFile)file).Resources
					group r by (string)_003C_003Ec.emcQIpvdrsox3eiqta5L(r);
				IEnumerable<PoLineDescriptor> collection = source.Where((IGrouping<string, PoLineDescriptor> r) => r.Count() == 1).SelectMany((IGrouping<string, PoLineDescriptor> g) => g);
				LocalizationFile obj = new LocalizationFile
				{
					Name = (string)iOnlqHGopHXr1xZ9uQKy(file),
					Header = ((LocalizationFile)file).Header
				};
				QaCLQEGoDSOlgf55Uslj(obj, Et3xuWGoakYu6YFj35Yy(file));
				obj.Resources = new ConcurrentBag<PoLineDescriptor>(collection);
				localizationFile = obj;
				enumerator = (from r in source
					where r.Count() > 1
					select r.Key).GetEnumerator();
				num2 = 2;
				break;
			}
			}
		}
	}

	public PoMerge()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool EAlT0HGoSy3gTEjpPmFr(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object E3RGDIGoiI3c5IVS0UCP(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static DateTime DxcEsZGoR8HKOqN5KhSZ()
	{
		return DateTime.Now;
	}

	internal static object ENxFoHGoqsmDaYpU2adJ(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static object fu8vTsGoKFAbGffcG5yg(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object SAoKd2GoXsdImLJkyIGS(object P_0)
	{
		return Directory.GetFiles((string)P_0);
	}

	internal static object SGTtIIGoTkaeGFm1fS8E(object P_0)
	{
		return Path.GetFileName((string)P_0);
	}

	internal static object O8QbpqGoksQ3T1g8FNt4(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static bool SPAhVgGonOE4Ct96oTCp(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void uuyWbGGoO1DddwOmb1Tb(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object eLIjgjGo2jM8BoUZ2jsZ(object P_0)
	{
		return RemoveDuplicatesFrom(P_0);
	}

	internal static bool bsSkSJGoeuyNwyUE6C0P(object P_0)
	{
		return ((MergeStatistics)P_0).NotNull();
	}

	internal static void xMjMjaGoPsX5uCmCABKb(object P_0, object P_1)
	{
		((MergeStatistics)P_0).UpdateFrom((MergeStatistics)P_1);
	}

	internal static void XPhnqZGo11vPNMM5eDB9(object P_0, object P_1)
	{
		Write(P_0, P_1);
	}

	internal static bool NHf8bqGoIj4ouTKEnZcI()
	{
		return V4S1PoGou7sNjq30EFEp == null;
	}

	internal static PoMerge RZlCB2GoVFeBtnAVUlT8()
	{
		return V4S1PoGou7sNjq30EFEp;
	}

	internal static void mq5PVHGoN5cJbGItnyp9(object P_0, object P_1)
	{
		((TextWriter)P_0).WriteLine((string)P_1);
	}

	internal static bool Hlw1tWGo3dO6VMUEPxQn(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object iOnlqHGopHXr1xZ9uQKy(object P_0)
	{
		return ((LocalizationFile)P_0).Name;
	}

	internal static object Et3xuWGoakYu6YFj35Yy(object P_0)
	{
		return ((LocalizationFile)P_0).LocalizationName;
	}

	internal static void QaCLQEGoDSOlgf55Uslj(object P_0, object P_1)
	{
		((LocalizationFile)P_0).LocalizationName = (string)P_1;
	}

	internal static void P3N6xeGotXRma7lqbCVa(object P_0, object P_1)
	{
		((PoLineDescriptor)P_0).Key = (string)P_1;
	}

	internal static void RFU5abGowHVAv3KaU7GC(object P_0, object P_1)
	{
		((PoLineDescriptor)P_0).Value = (string)P_1;
	}

	internal static bool EFQj0rGo4NEn1sEjvlhs(object P_0)
	{
		return ((PoLineDescriptor)P_0).IsLow;
	}

	internal static void Hhjr1xGo6RGKrSaRjATi(object P_0, bool value)
	{
		((PoLineDescriptor)P_0).IsLow = value;
	}

	internal static object IlPMSJGoHl6hNuIMkFUZ(object P_0)
	{
		return ((PoLineDescriptor)P_0).Value;
	}

	internal static bool GGufaGGoA71JM3Vj4cvy(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void iPJDHOGo7LdQ37UCES91(object P_0, bool value)
	{
		((PoLineDescriptor)P_0).IsFuzzy = value;
	}
}
