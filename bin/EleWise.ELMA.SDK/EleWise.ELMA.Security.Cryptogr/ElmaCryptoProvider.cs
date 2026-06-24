using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Text;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Cryptography;

public static class ElmaCryptoProvider
{
	private sealed class Container
	{
		private static object instance;

		private object pubKey;

		private object iv;

		internal static object U8PEAkQPDIxYP6oOAUy5;

		internal static Container Instance
		{
			get
			{
				int num = 1;
				int num2 = num;
				object obj;
				while (true)
				{
					switch (num2)
					{
					case 1:
						obj = instance;
						if (obj != null)
						{
							break;
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num2 = 0;
						}
						continue;
					default:
						obj = (instance = new Container());
						break;
					}
					break;
				}
				return (Container)obj;
			}
		}

		private Container()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			AhugMaQP46dC4c3bqvwe();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
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
				Init();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num = 0;
				}
			}
		}

		private void Init()
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
				{
					byte[] array2 = new byte[16];
					JD30vbQP6OBO7gU8TbvG(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					pubKey = array2;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 1;
					}
					break;
				}
				case 1:
				{
					byte[] array = new byte[16];
					JD30vbQP6OBO7gU8TbvG(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					iv = array;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					break;
				}
				case 0:
					return;
				}
			}
		}

		internal byte[] GetPub()
		{
			return (byte[])pubKey;
		}

		internal byte[] GetIv()
		{
			return (byte[])iv;
		}

		internal static void AhugMaQP46dC4c3bqvwe()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool CA7S4hQPt1d3cgNHoFBP()
		{
			return U8PEAkQPDIxYP6oOAUy5 == null;
		}

		internal static Container BxVNEaQPwYUCEm55EyCv()
		{
			return (Container)U8PEAkQPDIxYP6oOAUy5;
		}

		internal static void JD30vbQP6OBO7gU8TbvG(object P_0, RuntimeFieldHandle P_1)
		{
			RuntimeHelpers.InitializeArray((Array)P_0, P_1);
		}
	}

	private static ElmaCryptoProvider NW9ct4BL7uDHSq4PCOO8;

	public static string EncryptPassword(string pwd)
	{
		//Discarded unreachable code: IL_006b, IL_00c2, IL_0140, IL_0175, IL_01ad, IL_01cc, IL_021d, IL_0255, IL_0264, IL_0295, IL_02b4, IL_0301, IL_0339, IL_0348
		int num = 2;
		int num2 = num;
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				rijndaelManaged = new RijndaelManaged();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					MemoryStream memoryStream = (MemoryStream)yg5BXKBLmWrvoIoF0S2S();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							CryptoStream cryptoStream = new CryptoStream((Stream)NXJBIeBLyMHM9QpVi4OD(memoryStream), (ICryptoTransform)Q6fJXIBL9WhtM4grZVSD(rijndaelManaged, ((Container)w6bFWOBLMewq6fK5V0SE()).GetPub(), dM96JtBLJs3ih9JUaCqp(w6bFWOBLMewq6fK5V0SE())), CryptoStreamMode.Write);
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									rvpTE3BLrVbMYZqaGCUs(memoryStream, 0L, SeekOrigin.Begin);
									num4 = 2;
									break;
								case 2:
									result = MemoryHelper.ActionWithMemoryBuffer<byte, MemoryStream, string>((int)enDQj0BLgTd979M7UhZ3(memoryStream), memoryStream, EncryptPasswordAction);
									num4 = 3;
									break;
								default:
									try
									{
										StreamWriter streamWriter = new StreamWriter(cryptoStream);
										int num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
										{
											num5 = 0;
										}
										switch (num5)
										{
										default:
											try
											{
												E8Sex1BLd9qmbemZV2ne(streamWriter, pwd);
												int num6 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
												{
													num6 = 0;
												}
												switch (num6)
												{
												case 0:
													break;
												}
											}
											finally
											{
												int num7;
												if (streamWriter == null)
												{
													num7 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
													{
														num7 = 1;
													}
													goto IL_01b1;
												}
												goto IL_01da;
												IL_01da:
												DIAPpYBLlbfhAxx9BGbI(streamWriter);
												num7 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
												{
													num7 = 0;
												}
												goto IL_01b1;
												IL_01b1:
												switch (num7)
												{
												default:
													goto end_IL_018c;
												case 1:
													goto end_IL_018c;
												case 2:
													break;
												case 0:
													goto end_IL_018c;
												}
												goto IL_01da;
												end_IL_018c:;
											}
											break;
										}
									}
									finally
									{
										if (cryptoStream != null)
										{
											int num8 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
											{
												num8 = 0;
											}
											while (true)
											{
												switch (num8)
												{
												default:
													DIAPpYBLlbfhAxx9BGbI(cryptoStream);
													num8 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
													{
														num8 = 1;
													}
													continue;
												case 1:
													break;
												}
												break;
											}
										}
									}
									goto case 1;
								case 3:
									return result;
								}
							}
						}
						finally
						{
							int num9;
							if (memoryStream == null)
							{
								num9 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
								{
									num9 = 0;
								}
								goto IL_0299;
							}
							goto IL_02be;
							IL_02be:
							DIAPpYBLlbfhAxx9BGbI(memoryStream);
							num9 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
							{
								num9 = 1;
							}
							goto IL_0299;
							IL_0299:
							switch (num9)
							{
							default:
								goto end_IL_0274;
							case 0:
								goto end_IL_0274;
							case 2:
								break;
							case 1:
								goto end_IL_0274;
							}
							goto IL_02be;
							end_IL_0274:;
						}
					}
				}
				finally
				{
					if (rijndaelManaged != null)
					{
						int num10 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
						{
							num10 = 0;
						}
						while (true)
						{
							switch (num10)
							{
							default:
								DIAPpYBLlbfhAxx9BGbI(rijndaelManaged);
								num10 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
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
			default:
				return result;
			}
		}
	}

	private static string EncryptPasswordAction(object buffer, int offset, int length, object memoryStream)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				c0A69WBL5ToMBWGR7BFv(memoryStream, buffer, offset, length);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return Convert.ToBase64String((byte[])buffer, offset, length);
			}
		}
	}

	public static string DecryptPassword(string pwd)
	{
		//Discarded unreachable code: IL_0075, IL_00c7, IL_00fd, IL_0133, IL_016b, IL_01c4, IL_021d, IL_023c, IL_024b, IL_0299, IL_02d1, IL_02e0
		int num = 3;
		int num2 = num;
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
		byte[] array = default(byte[]);
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				rijndaelManaged = new RijndaelManaged();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				return result;
			case 3:
				array = (byte[])PYRQwXBLjuUcvBVqRiIV(pwd);
				num2 = 2;
				continue;
			}
			try
			{
				MemoryStream memoryStream = (MemoryStream)q3Ouw8BLYuWLvriEWv4I(array, false);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				default:
					try
					{
						CryptoStream cryptoStream = new CryptoStream(memoryStream, (ICryptoTransform)BCknJABLULRuBSOGMA12(rijndaelManaged, JXJiXcBLLKMhhDOhqVJh(w6bFWOBLMewq6fK5V0SE()), dM96JtBLJs3ih9JUaCqp(w6bFWOBLMewq6fK5V0SE())), CryptoStreamMode.Read);
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						default:
							try
							{
								StreamReader streamReader = new StreamReader(cryptoStream);
								int num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
								{
									num5 = 0;
								}
								switch (num5)
								{
								default:
									try
									{
										result = streamReader.ReadLine();
										int num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
										{
											num6 = 0;
										}
										return num6 switch
										{
											0 => result, 
											_ => result, 
										};
									}
									finally
									{
										if (streamReader != null)
										{
											int num7 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
											{
												num7 = 0;
											}
											while (true)
											{
												switch (num7)
												{
												default:
													DIAPpYBLlbfhAxx9BGbI(streamReader);
													num7 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
													{
														num7 = 0;
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
								if (cryptoStream != null)
								{
									int num8 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
									{
										num8 = 0;
									}
									while (true)
									{
										switch (num8)
										{
										default:
											DIAPpYBLlbfhAxx9BGbI(cryptoStream);
											num8 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
											{
												num8 = 1;
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
						int num9;
						if (memoryStream == null)
						{
							num9 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
							{
								num9 = 0;
							}
							goto IL_0221;
						}
						goto IL_0256;
						IL_0256:
						DIAPpYBLlbfhAxx9BGbI(memoryStream);
						num9 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
						{
							num9 = 0;
						}
						goto IL_0221;
						IL_0221:
						switch (num9)
						{
						default:
							goto end_IL_01fc;
						case 1:
							goto end_IL_01fc;
						case 2:
							break;
						case 0:
							goto end_IL_01fc;
						}
						goto IL_0256;
						end_IL_01fc:;
					}
				}
			}
			finally
			{
				if (rijndaelManaged != null)
				{
					int num10 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num10 = 1;
					}
					while (true)
					{
						switch (num10)
						{
						case 1:
							DIAPpYBLlbfhAxx9BGbI(rijndaelManaged);
							num10 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
							{
								num10 = 0;
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

	public static SecureString DecryptPasswordSecure(string pwd)
	{
		//Discarded unreachable code: IL_0051, IL_00a3, IL_00d7, IL_011d, IL_012c, IL_013c, IL_01e7, IL_0240, IL_0299, IL_02d1, IL_02e0
		int num = 3;
		int num2 = num;
		byte[] buffer = default(byte[]);
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
		int num6 = default(int);
		SecureString result = default(SecureString);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					MemoryStream memoryStream = MemoryHelper.GetMemoryStream(buffer, writable: false);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							CryptoStream cryptoStream = new CryptoStream(memoryStream, (ICryptoTransform)BCknJABLULRuBSOGMA12(rijndaelManaged, JXJiXcBLLKMhhDOhqVJh(w6bFWOBLMewq6fK5V0SE()), dM96JtBLJs3ih9JUaCqp(Container.Instance)), CryptoStreamMode.Read);
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
							{
								num4 = 0;
							}
							switch (num4)
							{
							default:
								try
								{
									SecureString secureString = new SecureString();
									int num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
									{
										num5 = 0;
									}
									while (true)
									{
										switch (num5)
										{
										case 5:
											num6 = JdtPk9BLsI44i6oC3v4y(cryptoStream);
											num5 = 7;
											break;
										case 2:
										case 3:
											CYsbokBLcB76nLaQFEfg(secureString, Convert.ToChar(num6));
											num5 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
											{
												num5 = 5;
											}
											break;
										case 4:
											result = secureString;
											num5 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
											{
												num5 = 1;
											}
											break;
										default:
											num6 = JdtPk9BLsI44i6oC3v4y(cryptoStream);
											num5 = 4;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
											{
												num5 = 6;
											}
											break;
										case 6:
										case 7:
											if (num6 > -1)
											{
												num5 = 2;
												break;
											}
											goto case 4;
										case 1:
											return result;
										}
									}
								}
								finally
								{
									if (cryptoStream != null)
									{
										int num7 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
										{
											num7 = 1;
										}
										while (true)
										{
											switch (num7)
											{
											case 1:
												((IDisposable)cryptoStream).Dispose();
												num7 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
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
							}
						}
						finally
						{
							if (memoryStream != null)
							{
								int num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
								{
									num8 = 0;
								}
								while (true)
								{
									switch (num8)
									{
									default:
										DIAPpYBLlbfhAxx9BGbI(memoryStream);
										num8 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
										{
											num8 = 0;
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
					if (rijndaelManaged != null)
					{
						int num9 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
						{
							num9 = 0;
						}
						while (true)
						{
							switch (num9)
							{
							default:
								DIAPpYBLlbfhAxx9BGbI(rijndaelManaged);
								num9 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
								{
									num9 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 3:
				buffer = (byte[])PYRQwXBLjuUcvBVqRiIV(pwd);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				rijndaelManaged = new RijndaelManaged();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return result;
			}
		}
	}

	public static string EncryptTextAes256(string text, byte[] key, byte[] iv)
	{
		//Discarded unreachable code: IL_0081, IL_00b6, IL_016f, IL_01cc, IL_020c, IL_021b, IL_022a, IL_025b, IL_02b4, IL_02d3, IL_02e2, IL_030f, IL_031e
		int num = 1;
		int num2 = num;
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				RijndaelManaged obj = new RijndaelManaged
				{
					KeySize = 256
				};
				DUT1lrBLzTLAcf1OY9d8(obj, 256);
				rijndaelManaged = obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 0;
				}
				continue;
			}
			case 2:
				return result;
			}
			try
			{
				MemoryStream memoryStream = (MemoryStream)yg5BXKBLmWrvoIoF0S2S();
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				default:
					try
					{
						CryptoStream cryptoStream = new CryptoStream((Stream)NXJBIeBLyMHM9QpVi4OD(memoryStream), rijndaelManaged.CreateEncryptor(key, iv), CryptoStreamMode.Write);
						int num4 = 3;
						while (true)
						{
							switch (num4)
							{
							case 2:
								result = MemoryHelper.ActionWithMemoryBuffer<byte, MemoryStream, string>((int)enDQj0BLgTd979M7UhZ3(memoryStream), memoryStream, EncryptTextAes256ToString);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
								{
									num4 = 0;
								}
								break;
							case 1:
								rvpTE3BLrVbMYZqaGCUs(memoryStream, 0L, SeekOrigin.Begin);
								num4 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
								{
									num4 = 2;
								}
								break;
							case 3:
								try
								{
									MemoryHelper.ActionWithMemoryBuffer<byte, (CryptoStream, string)>(EncodingCache.UTF8WithoutEmitIdentifier.GetByteCount(text), (cryptoStream, text), EncryptTextAes256WriteStream);
									int num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
									{
										num5 = 1;
									}
									while (true)
									{
										switch (num5)
										{
										case 1:
											uKykuJBUFLCQUeKHp0qA(cryptoStream);
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
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
								finally
								{
									int num6;
									if (cryptoStream == null)
									{
										num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
										{
											num6 = 0;
										}
										goto IL_01d0;
									}
									goto IL_01e6;
									IL_01e6:
									DIAPpYBLlbfhAxx9BGbI(cryptoStream);
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
									{
										num6 = 1;
									}
									goto IL_01d0;
									IL_01d0:
									switch (num6)
									{
									default:
										goto end_IL_01ab;
									case 2:
										break;
									case 0:
										goto end_IL_01ab;
									case 1:
										goto end_IL_01ab;
									}
									goto IL_01e6;
									end_IL_01ab:;
								}
								goto case 1;
							default:
								return result;
							case 0:
								return result;
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							int num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
							{
								num7 = 0;
							}
							while (true)
							{
								switch (num7)
								{
								default:
									DIAPpYBLlbfhAxx9BGbI(memoryStream);
									num7 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
									{
										num7 = 1;
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
				int num8;
				if (rijndaelManaged == null)
				{
					num8 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num8 = 0;
					}
					goto IL_02b8;
				}
				goto IL_02ed;
				IL_02ed:
				((IDisposable)rijndaelManaged).Dispose();
				num8 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num8 = 2;
				}
				goto IL_02b8;
				IL_02b8:
				switch (num8)
				{
				case 1:
					goto end_IL_0293;
				case 2:
					goto end_IL_0293;
				}
				goto IL_02ed;
				end_IL_0293:;
			}
		}
	}

	private static string EncryptTextAes256ToString(object bytes, int bufferOffset, int bufferLength, object stream)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				((Stream)stream).Read((byte[])bytes, bufferOffset, bufferLength);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (string)JifloNBUo6rbSg2JPsW6(OtuNyEBUBU9KILtUiHsy(bytes, bufferOffset, bufferLength), slUp5gBUWGEHW3l0wAud(-1146510045 ^ -1146508465), "");
			}
		}
	}

	private static void EncryptTextAes256WriteStream(object buffer, int offset, int length, (CryptoStream, string) param)
	{
		var (cryptoStream, text) = param;
		EncodingCache.UTF8WithoutEmitIdentifier.GetBytes(text, 0, text.Length, (byte[])buffer, offset);
		cryptoStream.Write((byte[])buffer, offset, length);
	}

	public static string DecryptTextAes256(byte[] encodedData, byte[] key, byte[] iv)
	{
		//Discarded unreachable code: IL_004a, IL_008f, IL_00d0, IL_012d, IL_0165, IL_0174, IL_01cd, IL_0226, IL_0245, IL_0254, IL_0281, IL_0290
		int num = 2;
		int num2 = num;
		RijndaelManaged rijndaelManaged2 = default(RijndaelManaged);
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					MemoryStream memoryStream = (MemoryStream)yg5BXKBLmWrvoIoF0S2S();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							CryptoStream cryptoStream = new CryptoStream((Stream)NXJBIeBLyMHM9QpVi4OD(memoryStream), (ICryptoTransform)BCknJABLULRuBSOGMA12(rijndaelManaged2, key, iv), CryptoStreamMode.Write);
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									try
									{
										BPTTQhBUh4u8kDhc3Gvm(cryptoStream, encodedData, 0, encodedData.Length);
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
												uKykuJBUFLCQUeKHp0qA(cryptoStream);
												num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
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
									finally
									{
										if (cryptoStream != null)
										{
											int num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
											{
												num6 = 0;
											}
											while (true)
											{
												switch (num6)
												{
												default:
													DIAPpYBLlbfhAxx9BGbI(cryptoStream);
													num6 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
													{
														num6 = 1;
													}
													continue;
												case 1:
													break;
												}
												break;
											}
										}
									}
									goto default;
								default:
									result = (string)amxsXIBUGdEF8V1CfJqy(memoryStream, EncodingCache.UTF8WithoutEmitIdentifier);
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
									{
										num4 = 2;
									}
									break;
								case 2:
									return result;
								}
							}
						}
						finally
						{
							if (memoryStream != null)
							{
								int num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
								{
									num7 = 0;
								}
								while (true)
								{
									switch (num7)
									{
									default:
										DIAPpYBLlbfhAxx9BGbI(memoryStream);
										num7 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
										{
											num7 = 1;
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
					int num8;
					if (rijndaelManaged2 == null)
					{
						num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num8 = 0;
						}
						goto IL_022a;
					}
					goto IL_025f;
					IL_025f:
					DIAPpYBLlbfhAxx9BGbI(rijndaelManaged2);
					num8 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num8 = 2;
					}
					goto IL_022a;
					IL_022a:
					switch (num8)
					{
					default:
						goto end_IL_0205;
					case 0:
						goto end_IL_0205;
					case 1:
						break;
					case 2:
						goto end_IL_0205;
					}
					goto IL_025f;
					end_IL_0205:;
				}
			case 2:
			{
				RijndaelManaged rijndaelManaged = new RijndaelManaged();
				vWFbqxBUbfUZdnmrcY94(rijndaelManaged, 256);
				DUT1lrBLzTLAcf1OY9d8(rijndaelManaged, 256);
				rijndaelManaged2 = rijndaelManaged;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num2 = 1;
				}
				break;
			}
			default:
				return result;
			}
		}
	}

	public static string DecryptTextAes256(string encodedData, byte[] key, byte[] iv)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass9_.encodedData = encodedData;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return DecryptTextAes256((from x in Enumerable.Range(0, _003C_003Ec__DisplayClass9_.encodedData.Length)
					where (x & 1) == 0
					select x).Select(_003C_003Ec__DisplayClass9_._003CDecryptTextAes256_003Eb__1).ToArray(), key, iv);
			}
		}
	}

	internal static object yg5BXKBLmWrvoIoF0S2S()
	{
		return MemoryHelper.GetMemoryStream();
	}

	internal static object NXJBIeBLyMHM9QpVi4OD(object P_0)
	{
		return ((MemoryStream)P_0).AsNoClose();
	}

	internal static object w6bFWOBLMewq6fK5V0SE()
	{
		return Container.Instance;
	}

	internal static object dM96JtBLJs3ih9JUaCqp(object P_0)
	{
		return ((Container)P_0).GetIv();
	}

	internal static object Q6fJXIBL9WhtM4grZVSD(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateEncryptor((byte[])P_1, (byte[])P_2);
	}

	internal static void E8Sex1BLd9qmbemZV2ne(object P_0, object P_1)
	{
		((TextWriter)P_0).Write((string)P_1);
	}

	internal static void DIAPpYBLlbfhAxx9BGbI(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static long rvpTE3BLrVbMYZqaGCUs(object P_0, long P_1, SeekOrigin P_2)
	{
		return ((Stream)P_0).Seek(P_1, P_2);
	}

	internal static long enDQj0BLgTd979M7UhZ3(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static bool gGQ6ORBLx66uTkOTg0MO()
	{
		return NW9ct4BL7uDHSq4PCOO8 == null;
	}

	internal static ElmaCryptoProvider XfqEEoBL0D9YipHkg0jG()
	{
		return NW9ct4BL7uDHSq4PCOO8;
	}

	internal static int c0A69WBL5ToMBWGR7BFv(object P_0, object P_1, int P_2, int P_3)
	{
		return ((Stream)P_0).Read((byte[])P_1, P_2, P_3);
	}

	internal static object PYRQwXBLjuUcvBVqRiIV(object P_0)
	{
		return Convert.FromBase64String((string)P_0);
	}

	internal static object q3Ouw8BLYuWLvriEWv4I(object P_0, bool writable)
	{
		return MemoryHelper.GetMemoryStream((byte[])P_0, writable);
	}

	internal static object JXJiXcBLLKMhhDOhqVJh(object P_0)
	{
		return ((Container)P_0).GetPub();
	}

	internal static object BCknJABLULRuBSOGMA12(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	internal static int JdtPk9BLsI44i6oC3v4y(object P_0)
	{
		return ((Stream)P_0).ReadByte();
	}

	internal static void CYsbokBLcB76nLaQFEfg(object P_0, char P_1)
	{
		((SecureString)P_0).AppendChar(P_1);
	}

	internal static void DUT1lrBLzTLAcf1OY9d8(object P_0, int P_1)
	{
		((SymmetricAlgorithm)P_0).BlockSize = P_1;
	}

	internal static void uKykuJBUFLCQUeKHp0qA(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object OtuNyEBUBU9KILtUiHsy(object P_0, int P_1, int P_2)
	{
		return BitConverter.ToString((byte[])P_0, P_1, P_2);
	}

	internal static object slUp5gBUWGEHW3l0wAud(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object JifloNBUo6rbSg2JPsW6(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static void vWFbqxBUbfUZdnmrcY94(object P_0, int P_1)
	{
		((SymmetricAlgorithm)P_0).KeySize = P_1;
	}

	internal static void BPTTQhBUh4u8kDhc3Gvm(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static object amxsXIBUGdEF8V1CfJqy(object P_0, object P_1)
	{
		return ((MemoryStream)P_0).AsString((Encoding)P_1);
	}
}
