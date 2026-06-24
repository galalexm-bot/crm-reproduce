using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Memory;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata;

public static class MetadataSerializer
{
	private static object lockObj;

	private static Dictionary<Type, XmlSerializer> serializers;

	private static Dictionary<string, Type> metadataTypesByXmlName;

	private static Type[] xsiTypes;

	internal static MetadataSerializer ldRvwsb0c0KmjGOhlICA;

	public static IMetadata LoadMetadata(string fileName)
	{
		return (IMetadata)vifxUAbmBGNtlVrlTsU9(fileName, true);
	}

	public static IMetadata LoadMetadata(string fileName, bool throwEx)
	{
		//Discarded unreachable code: IL_00ad, IL_00bc, IL_00eb, IL_012c, IL_0164, IL_0183, IL_0192, IL_01bf, IL_01ce, IL_01ff, IL_021e, IL_024a, IL_028d, IL_034e, IL_037e, IL_038d, IL_0399, IL_0459, IL_0489, IL_04b9, IL_04c8
		int num = 2;
		int num2 = num;
		bool lockTaken = default(bool);
		object obj = default(object);
		FileStream fileStream = default(FileStream);
		IMetadata metadata = default(IMetadata);
		XmlSerializer value = default(XmlSerializer);
		IMetadata result = default(IMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					Type metadataType = GetMetadataType(fileName, throwEx);
					int num3 = 4;
					while (true)
					{
						switch (num3)
						{
						case 6:
							lockTaken = false;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
							{
								num3 = 0;
							}
							break;
						case 1:
							obj = lockObj;
							num3 = 6;
							break;
						case 3:
							try
							{
								XmlTextReader xmlTextReader = new XmlTextReader(fileStream);
								int num7 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
								{
									num7 = 1;
								}
								switch (num7)
								{
								case 1:
									try
									{
										metadata = (IMetadata)hcZ5BwbmhvvlQe0mnMTM(value, xmlTextReader);
										int num8 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
										{
											num8 = 0;
										}
										switch (num8)
										{
										case 0:
											break;
										}
									}
									finally
									{
										int num9;
										if (xmlTextReader == null)
										{
											num9 = 2;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
											{
												num9 = 2;
											}
											goto IL_0168;
										}
										goto IL_019d;
										IL_019d:
										FnQRWTbmGQG7vbGtXLBb(xmlTextReader);
										num9 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
										{
											num9 = 1;
										}
										goto IL_0168;
										IL_0168:
										switch (num9)
										{
										case 2:
											goto end_IL_0143;
										case 1:
											goto end_IL_0143;
										}
										goto IL_019d;
										end_IL_0143:;
									}
									break;
								case 0:
									break;
								}
							}
							finally
							{
								int num10;
								if (fileStream == null)
								{
									num10 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
									{
										num10 = 1;
									}
									goto IL_0203;
								}
								goto IL_0228;
								IL_0228:
								FnQRWTbmGQG7vbGtXLBb(fileStream);
								num10 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
								{
									num10 = 0;
								}
								goto IL_0203;
								IL_0203:
								switch (num10)
								{
								default:
									goto end_IL_01de;
								case 1:
									goto end_IL_01de;
								case 2:
									break;
								case 0:
									goto end_IL_01de;
								}
								goto IL_0228;
								end_IL_01de:;
							}
							goto case 2;
						case 10:
						{
							xJGonBbmQECodauVEdTu(metadata);
							int num6 = 11;
							num3 = num6;
							break;
						}
						default:
							try
							{
								Monitor.Enter(obj, ref lockTaken);
								int num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
								{
									num4 = 2;
								}
								while (true)
								{
									switch (num4)
									{
									case 2:
										if (!serializers.TryGetValue(metadataType, out value))
										{
											num4 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
											{
												num4 = 1;
											}
											continue;
										}
										break;
									case 1:
										value = new XmlSerializer(metadataType, (Type[])wuZICSbmoXi1wC10g1Q4());
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
										{
											num4 = 0;
										}
										continue;
									default:
										serializers.Add(metadataType, value);
										num4 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
										{
											num4 = 3;
										}
										continue;
									case 3:
										break;
									}
									break;
								}
							}
							finally
							{
								int num5;
								if (!lockTaken)
								{
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
									{
										num5 = 1;
									}
									goto IL_0352;
								}
								goto IL_0368;
								IL_0368:
								zVcmf7bmbncEFHinCBTQ(obj);
								num5 = 2;
								goto IL_0352;
								IL_0352:
								switch (num5)
								{
								case 1:
									goto end_IL_032d;
								case 2:
									goto end_IL_032d;
								}
								goto IL_0368;
								end_IL_032d:;
							}
							goto case 7;
						case 7:
							fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
							num3 = 3;
							break;
						case 11:
							result = metadata;
							num3 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
							{
								num3 = 5;
							}
							break;
						case 2:
							if (DwyR58bmfoZPCsZWMwOO(W5G0HybmEv3k6uEZAEpC(metadata), Guid.Empty))
							{
								num3 = 9;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
								{
									num3 = 10;
								}
								break;
							}
							goto case 11;
						case 4:
							if (metadataType == null)
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
								{
									num3 = 9;
								}
								break;
							}
							goto case 1;
						case 9:
							result = null;
							num3 = 8;
							break;
						case 5:
							return result;
						case 8:
							return result;
						}
					}
				}
				catch (MetadataLoadException)
				{
					int num11 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num11 = 0;
					}
					switch (num11)
					{
					default:
						throw;
					}
				}
				catch (Exception innerException)
				{
					int num12 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num12 = 0;
					}
					switch (num12)
					{
					default:
						throw new MetadataLoadException(SR.T((string)BGhrj6bmWYrn7G6LvQ7J(0x5F3078B6 ^ 0x5F328302)), fileName, innerException);
					}
				}
			case 2:
				Contract.ArgumentNotNull(fileName, (string)BGhrj6bmWYrn7G6LvQ7J(0x68BBB53E ^ 0x68BBCB24));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return result;
			}
		}
	}

	public static void SaveMetadata(IMetadata metadata, string fileName)
	{
		//Discarded unreachable code: IL_0071, IL_00a6, IL_0162, IL_019a, IL_01da, IL_01e9, IL_0216, IL_026f, IL_02af, IL_02be, IL_02ca, IL_02d9, IL_0308, IL_03e8, IL_03f7, IL_0424
		int num = 2;
		MemoryStream memoryStream = default(MemoryStream);
		FileStream fileStream = default(FileStream);
		XmlSerializer value = default(XmlSerializer);
		object obj = default(object);
		bool lockTaken = default(bool);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					try
					{
						XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, (Encoding)HLKTpUbmIDYsmyl5KbKs());
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						default:
							try
							{
								Jw7iJQbmVyXI40fecZQe(xmlTextWriter, Formatting.Indented);
								int num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
								{
									num7 = 0;
								}
								while (true)
								{
									switch (num7)
									{
									case 2:
										aqUPoqbmRdCImXDJo9wi(memoryStream, 0L, SeekOrigin.Begin);
										num7 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
										{
											num7 = 1;
										}
										break;
									case 1:
										fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
										num7 = 4;
										break;
									case 3:
										xmlTextWriter.IndentChar = ' ';
										num7 = 5;
										break;
									default:
										PH9IJ8bmSrF0ac8Q1snW(xmlTextWriter, 2);
										num7 = 3;
										break;
									case 5:
										kPp7IIbmiY9X4gWnMCMM(value, xmlTextWriter, metadata);
										num7 = 2;
										break;
									case 4:
										try
										{
											lUpWVobmqA7XgbFc05hH(memoryStream, fileStream);
											int num8 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
											{
												num8 = 0;
											}
											switch (num8)
											{
											case 0:
												break;
											}
											return;
										}
										finally
										{
											int num9;
											if (fileStream == null)
											{
												num9 = 2;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
												{
													num9 = 0;
												}
												goto IL_019e;
											}
											goto IL_01b4;
											IL_01b4:
											FnQRWTbmGQG7vbGtXLBb(fileStream);
											num9 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
											{
												num9 = 0;
											}
											goto IL_019e;
											IL_019e:
											switch (num9)
											{
											default:
												goto end_IL_0179;
											case 1:
												break;
											case 2:
												goto end_IL_0179;
											case 0:
												goto end_IL_0179;
											}
											goto IL_01b4;
											end_IL_0179:;
										}
									}
								}
							}
							finally
							{
								if (xmlTextWriter != null)
								{
									int num10 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
									{
										num10 = 0;
									}
									while (true)
									{
										switch (num10)
										{
										default:
											((IDisposable)xmlTextWriter).Dispose();
											num10 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
											{
												num10 = 1;
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
						int num11;
						if (memoryStream == null)
						{
							num11 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
							{
								num11 = 0;
							}
							goto IL_0273;
						}
						goto IL_0289;
						IL_0289:
						FnQRWTbmGQG7vbGtXLBb(memoryStream);
						num11 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
						{
							num11 = 1;
						}
						goto IL_0273;
						IL_0273:
						switch (num11)
						{
						default:
							goto end_IL_024e;
						case 1:
							break;
						case 0:
							goto end_IL_024e;
						case 2:
							goto end_IL_024e;
						}
						goto IL_0289;
						end_IL_024e:;
					}
				default:
					try
					{
						Monitor.Enter(obj, ref lockTaken);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (!serializers.TryGetValue(metadata.GetType(), out value))
								{
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
									{
										num3 = 1;
									}
									continue;
								}
								break;
							case 1:
								value = new XmlSerializer(metadata.GetType(), (Type[])wuZICSbmoXi1wC10g1Q4());
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
								{
									num3 = 3;
								}
								continue;
							case 3:
								serializers.Add(metadata.GetType(), value);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
								{
									num3 = 2;
								}
								continue;
							case 2:
								break;
							}
							break;
						}
					}
					finally
					{
						int num5;
						if (!lockTaken)
						{
							int num4 = 2;
							num5 = num4;
							goto IL_03cd;
						}
						goto IL_0402;
						IL_03cd:
						switch (num5)
						{
						default:
							goto end_IL_03b4;
						case 2:
							goto end_IL_03b4;
						case 1:
							break;
						case 0:
							goto end_IL_03b4;
						}
						goto IL_0402;
						IL_0402:
						Monitor.Exit(obj);
						num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num5 = 0;
						}
						goto IL_03cd;
						end_IL_03b4:;
					}
					goto case 4;
				case 8:
					memoryStream = (MemoryStream)iJ9TOhbmuYa7aclf8amr();
					num2 = 3;
					continue;
				case 5:
					break;
				case 4:
					text = (string)xtr35Tbmv9lfDAt3RLA2(fileName);
					num2 = 6;
					continue;
				case 1:
					zub0KFbmC0GKO0Q9w4Jk(fileName, BGhrj6bmWYrn7G6LvQ7J(-87337865 ^ -87348627));
					num2 = 9;
					continue;
				case 6:
					if (!Lpuieibm8JDaRCjrUQgw(text))
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 8;
				case 9:
					obj = lockObj;
					num2 = 10;
					continue;
				case 10:
					lockTaken = false;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					return;
				case 2:
					zub0KFbmC0GKO0Q9w4Jk(metadata, BGhrj6bmWYrn7G6LvQ7J(0x3A6135BE ^ 0x3A617C80));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			xMva6nbmZZfmxSKLC4hF(text);
			num = 8;
		}
	}

	private static Type[] GetXsiTypes()
	{
		//Discarded unreachable code: IL_0053, IL_010f, IL_0147, IL_0156
		int num = 3;
		int num2 = num;
		Type[] result = default(Type[]);
		object obj = default(object);
		bool lockTaken = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return result;
			case 3:
				obj = lockObj;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
				lockTaken = false;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				int num3 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						return result;
					default:
						xsiTypes = (Type[])fOsa7JbmX4rLsKBRYFQt(ComponentManager.Current, YjRrUZbmKdFeI9VtP1OJ(typeof(IXsiType).TypeHandle));
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
						{
							num3 = 3;
						}
						continue;
					case 2:
						if (xsiTypes == null)
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						break;
					case 3:
						break;
					}
					result = xsiTypes;
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num3 = 1;
					}
				}
			}
			finally
			{
				if (lockTaken)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							zVcmf7bmbncEFHinCBTQ(obj);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
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

	public static void LoadMetadataTypes()
	{
		//Discarded unreachable code: IL_0050, IL_00eb, IL_00fa, IL_015c, IL_0225, IL_0265, IL_0274, IL_0280, IL_028f, IL_02c0, IL_02f8, IL_0307
		int num = 3;
		object obj = default(object);
		bool lockTaken = default(bool);
		IEnumerator<IMetadataTypeInfo> enumerator = default(IEnumerator<IMetadataTypeInfo>);
		IMetadataTypeInfo current = default(IMetadataTypeInfo);
		XmlRootAttribute attribute = default(XmlRootAttribute);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					try
					{
						Monitor.Enter(obj, ref lockTaken);
						int num3 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 3:
								enumerator = ((ComponentManager)YLSH98bmTiUmef1TIFmm()).GetExtensionPoints<IMetadataTypeInfo>().GetEnumerator();
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
								{
									num3 = 1;
								}
								break;
							case 2:
								metadataTypesByXmlName = new Dictionary<string, Type>();
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
								{
									num3 = 3;
								}
								break;
							case 4:
								if (metadataTypesByXmlName == null)
								{
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
									{
										num3 = 1;
									}
									break;
								}
								return;
							case 1:
								try
								{
									while (true)
									{
										IL_01c8:
										int num4;
										if (!MVfXDxbmOhkPcicepxlO(enumerator))
										{
											num4 = 7;
											goto IL_0109;
										}
										goto IL_0166;
										IL_0149:
										int num5 = 5;
										goto IL_0105;
										IL_0166:
										current = enumerator.Current;
										num5 = 4;
										goto IL_0105;
										IL_0105:
										num4 = num5;
										goto IL_0109;
										IL_0109:
										while (true)
										{
											switch (num4)
											{
											case 1:
												if (metadataTypesByXmlName.ContainsKey((string)lTpo2Gbmn4fIJDX2etmN(attribute)))
												{
													goto IL_0149;
												}
												goto case 3;
											case 3:
												metadataTypesByXmlName.Add((string)lTpo2Gbmn4fIJDX2etmN(attribute), B9NC0Fbmklo3RYi1U7xE(current));
												num4 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
												{
													num4 = 6;
												}
												continue;
											case 4:
												attribute = AttributeHelper<XmlRootAttribute>.GetAttribute(B9NC0Fbmklo3RYi1U7xE(current), inherited: false);
												num4 = 2;
												continue;
											case 5:
											case 6:
												goto IL_01c8;
											case 2:
												if (attribute != null)
												{
													num4 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
													{
														num4 = 0;
													}
													continue;
												}
												goto IL_01c8;
											case 7:
												return;
											}
											break;
										}
										goto IL_0166;
									}
								}
								finally
								{
									int num6;
									if (enumerator == null)
									{
										num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
										{
											num6 = 1;
										}
										goto IL_0229;
									}
									goto IL_023f;
									IL_023f:
									FnQRWTbmGQG7vbGtXLBb(enumerator);
									num6 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
									{
										num6 = 0;
									}
									goto IL_0229;
									IL_0229:
									switch (num6)
									{
									case 1:
										goto end_IL_0204;
									case 2:
										goto end_IL_0204;
									}
									goto IL_023f;
									end_IL_0204:;
								}
							case 0:
								return;
							}
						}
					}
					finally
					{
						if (lockTaken)
						{
							int num7 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
							{
								num7 = 1;
							}
							while (true)
							{
								switch (num7)
								{
								case 1:
									zVcmf7bmbncEFHinCBTQ(obj);
									num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
									{
										num7 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
				case 3:
					break;
				case 1:
					return;
				case 2:
					lockTaken = false;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			obj = lockObj;
			num = 2;
		}
	}

	private static Type GetMetadataType(object fileName, bool throwEx)
	{
		//Discarded unreachable code: IL_0201, IL_0234, IL_029e, IL_02ad, IL_02bd, IL_02f0
		int num = 3;
		XmlNode xmlNode = default(XmlNode);
		Type value = default(Type);
		XmlDocument xmlDocument = default(XmlDocument);
		Type result = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					throw new MetadataLoadException(SR.T((string)BGhrj6bmWYrn7G6LvQ7J(0x53CACA3 ^ 0x53E50F5), ixhmNBbm33B5cwDcf9dB(xmlNode)), (string)fileName);
				case 4:
					return value;
				default:
					if (throwEx)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num2 = 8;
						}
						continue;
					}
					return null;
				case 11:
					if (!throwEx)
					{
						return null;
					}
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					if (!WTXOnxbmeAkcncYZXW25(fileName))
					{
						num2 = 13;
						continue;
					}
					goto end_IL_0012;
				case 1:
					if (xmlNode == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						LoadMetadataTypes();
						num2 = 15;
					}
					continue;
				case 3:
					EQ6h7ibm2giaxgBWd62a();
					num2 = 2;
					continue;
				case 13:
					throw new MetadataLoadException((string)Fk5H0fbmPmAgPMYAv8as(BGhrj6bmWYrn7G6LvQ7J(-787452571 ^ -787310967)), (string)fileName);
				case 12:
					xmlNode = (XmlNode)NeWl7ebmNK4rtdKu80Rl(xmlDocument);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num2 = 4;
					}
					continue;
				case 8:
					throw new MetadataLoadException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECCAF28)), (string)fileName);
				case 15:
					if (metadataTypesByXmlName.TryGetValue(xmlNode.Name, out value))
					{
						num2 = 4;
						continue;
					}
					goto case 11;
				case 7:
					if (xmlNode is XmlElement)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 9:
					try
					{
						ACq9Fpbm17opwJq5w14d(xmlDocument, fileName);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
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
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								return result;
							case 0:
								return result;
							case 2:
								throw new MetadataLoadException(SR.T((string)BGhrj6bmWYrn7G6LvQ7J(-218496594 ^ -218563188)), (string)fileName, innerException);
							case 1:
								if (!throwEx)
								{
									result = null;
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
									{
										num4 = 0;
									}
								}
								else
								{
									num4 = 2;
								}
								break;
							}
						}
					}
					goto case 12;
				case 6:
				case 14:
					if (xmlNode != null)
					{
						num2 = 7;
						continue;
					}
					goto case 1;
				case 5:
					break;
				}
				xmlNode = xmlNode.NextSibling;
				num2 = 14;
				continue;
				end_IL_0012:
				break;
			}
			xmlDocument = new XmlDocument();
			num = 9;
		}
	}

	static MetadataSerializer()
	{
		int num = 3;
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
				lockObj = new object();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				serializers = new Dictionary<Type, XmlSerializer>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				UdOxOZbmp07vJpluZSd3();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static object vifxUAbmBGNtlVrlTsU9(object P_0, bool throwEx)
	{
		return LoadMetadata((string)P_0, throwEx);
	}

	internal static bool hE5Bc0b0ztKfAAZCqZ0I()
	{
		return ldRvwsb0c0KmjGOhlICA == null;
	}

	internal static MetadataSerializer v1pSRSbmFAEF2FRBHyXC()
	{
		return ldRvwsb0c0KmjGOhlICA;
	}

	internal static object BGhrj6bmWYrn7G6LvQ7J(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object wuZICSbmoXi1wC10g1Q4()
	{
		return GetXsiTypes();
	}

	internal static void zVcmf7bmbncEFHinCBTQ(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static object hcZ5BwbmhvvlQe0mnMTM(object P_0, object P_1)
	{
		return ((XmlSerializer)P_0).Deserialize((XmlReader)P_1);
	}

	internal static void FnQRWTbmGQG7vbGtXLBb(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static Guid W5G0HybmEv3k6uEZAEpC(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static bool DwyR58bmfoZPCsZWMwOO(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static void xJGonBbmQECodauVEdTu(object P_0)
	{
		((IMetadata)P_0).InitNew();
	}

	internal static void zub0KFbmC0GKO0Q9w4Jk(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object xtr35Tbmv9lfDAt3RLA2(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}

	internal static bool Lpuieibm8JDaRCjrUQgw(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object xMva6nbmZZfmxSKLC4hF(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static object iJ9TOhbmuYa7aclf8amr()
	{
		return MemoryHelper.GetMemoryStream();
	}

	internal static object HLKTpUbmIDYsmyl5KbKs()
	{
		return Encoding.UTF8;
	}

	internal static void Jw7iJQbmVyXI40fecZQe(object P_0, Formatting P_1)
	{
		((XmlTextWriter)P_0).Formatting = P_1;
	}

	internal static void PH9IJ8bmSrF0ac8Q1snW(object P_0, int P_1)
	{
		((XmlTextWriter)P_0).Indentation = P_1;
	}

	internal static void kPp7IIbmiY9X4gWnMCMM(object P_0, object P_1, object P_2)
	{
		((XmlSerializer)P_0).Serialize((XmlWriter)P_1, P_2);
	}

	internal static long aqUPoqbmRdCImXDJo9wi(object P_0, long P_1, SeekOrigin P_2)
	{
		return ((Stream)P_0).Seek(P_1, P_2);
	}

	internal static void lUpWVobmqA7XgbFc05hH(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	internal static Type YjRrUZbmKdFeI9VtP1OJ(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object fOsa7JbmX4rLsKBRYFQt(object P_0, Type type)
	{
		return ((ComponentManager)P_0).GetExtensionPointTypesArray(type);
	}

	internal static object YLSH98bmTiUmef1TIFmm()
	{
		return ComponentManager.Current;
	}

	internal static Type B9NC0Fbmklo3RYi1U7xE(object P_0)
	{
		return ((IMetadataTypeInfo)P_0).MetadataType;
	}

	internal static object lTpo2Gbmn4fIJDX2etmN(object P_0)
	{
		return ((XmlRootAttribute)P_0).ElementName;
	}

	internal static bool MVfXDxbmOhkPcicepxlO(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void EQ6h7ibm2giaxgBWd62a()
	{
		LoadMetadataTypes();
	}

	internal static bool WTXOnxbmeAkcncYZXW25(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object Fk5H0fbmPmAgPMYAv8as(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void ACq9Fpbm17opwJq5w14d(object P_0, object P_1)
	{
		((XmlDocument)P_0).Load((string)P_1);
	}

	internal static object NeWl7ebmNK4rtdKu80Rl(object P_0)
	{
		return ((XmlNode)P_0).FirstChild;
	}

	internal static object ixhmNBbm33B5cwDcf9dB(object P_0)
	{
		return ((XmlNode)P_0).Name;
	}

	internal static void UdOxOZbmp07vJpluZSd3()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
