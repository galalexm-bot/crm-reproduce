using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using Microsoft.Extensions.ObjectPool;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Helpers;

public class EncryptionHelper
{
	public struct VerifyMd5Result
	{
		internal static object UbXkhuv9eIac7eRRHydW;

		public bool Verified
		{
			[CompilerGenerated]
			get
			{
				return _003CVerified_003Ek__BackingField;
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
						_003CVerified_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
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

		public string Error
		{
			[CompilerGenerated]
			get
			{
				return _003CError_003Ek__BackingField;
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
						_003CError_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
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

		internal static bool lLbwFrv9P3dXvmhtuKH2()
		{
			return UbXkhuv9eIac7eRRHydW == null;
		}

		internal static object pSH5Eav91wQqWig1La71()
		{
			return UbXkhuv9eIac7eRRHydW;
		}
	}

	private static IBinaryFileHashService binaryFileHashService;

	private static readonly ObjectPool<RNGCryptoServiceProvider> RngCryptoServiceProviderPool;

	private static readonly ObjectPool<SHA256Managed> Sha256ManagedPool;

	internal static readonly ObjectPool<MD5CryptoServiceProvider> Md5CryptoServiceProviderPool;

	private static readonly byte[] PubKey;

	private static readonly byte[] Iv;

	private static EncryptionHelper SMBnkvGFH7750VrdSTL5;

	protected static IBinaryFileHashService BinaryFileHashService
	{
		get
		{
			int num = 1;
			int num2 = num;
			IBinaryFileHashService obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = binaryFileHashService;
					if (obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					obj = (binaryFileHashService = Locator.GetServiceNotNull<IBinaryFileHashService>());
					break;
				}
				break;
			}
			return obj;
		}
	}

	internal EncryptionHelper(IBinaryFileHashService binaryFileHash)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		LIYiKoGFxWWPq6Lqf2fQ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
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
			binaryFileHashService = binaryFileHash;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
			{
				num = 1;
			}
		}
	}

	public static string GenerateSalt(int size = 16)
	{
		//Discarded unreachable code: IL_0053, IL_00de, IL_00f1, IL_0100
		int num = 1;
		int num2 = num;
		RNGCryptoServiceProvider rNGCryptoServiceProvider = default(RNGCryptoServiceProvider);
		byte[] array = default(byte[]);
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				try
				{
					rNGCryptoServiceProvider = RngCryptoServiceProviderPool.Get();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							paWtVvGF0TnCOmBv8LGD(rNGCryptoServiceProvider, array);
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
							{
								num3 = 2;
							}
							break;
						case 2:
							result = (string)C4nUiiGFmXLqgTkiFtAr(array);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
							{
								num3 = 1;
							}
							break;
						case 1:
							return result;
						}
					}
				}
				finally
				{
					RngCryptoServiceProviderPool.Return(rNGCryptoServiceProvider);
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			default:
				rNGCryptoServiceProvider = null;
				num2 = 3;
				break;
			case 2:
				return result;
			case 1:
				array = new byte[size];
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static string GetSha256Hash(string input, string salt)
	{
		//Discarded unreachable code: IL_005f, IL_0113, IL_0126, IL_0135
		int num = 3;
		int num2 = num;
		SHA256Managed sHA256Managed = default(SHA256Managed);
		int num5 = default(int);
		int num4 = default(int);
		string result = default(string);
		while (true)
		{
			object obj2;
			object obj;
			switch (num2)
			{
			case 1:
				try
				{
					sHA256Managed = Sha256ManagedPool.Get();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 3:
							num5 = HWbS2lGFMdpPTPyAbpgf(bb5ienGFyXcmrOmWwlZx(), salt);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
							{
								num3 = 1;
							}
							break;
						default:
							num4 = HWbS2lGFMdpPTPyAbpgf(bb5ienGFyXcmrOmWwlZx(), input);
							num3 = 3;
							break;
						case 1:
							result = MemoryHelper.ActionWithMemoryBuffer<byte, (SHA256Managed, string, string, int), string>(num4 + num5, (sHA256Managed, input, salt, num4), GetSha256HashAction);
							num3 = 2;
							break;
						case 2:
							return result;
						}
					}
				}
				finally
				{
					Sha256ManagedPool.Return(sHA256Managed);
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
			case 6:
				sHA256Managed = null;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num2 = 1;
				}
				continue;
			case 5:
				return result;
			case 3:
				obj2 = input;
				if (obj2 == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto IL_0187;
			case 2:
				obj2 = "";
				goto IL_0187;
			case 4:
				obj = salt;
				if (obj != null)
				{
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				continue;
			default:
				{
					obj = "";
					break;
				}
				IL_0187:
				input = (string)obj2;
				num2 = 4;
				continue;
			}
			salt = (string)obj;
			num2 = 6;
		}
	}

	private static string GetSha256HashAction(object buffer, int offset, int length, (SHA256Managed, string, string, int) param)
	{
		var (sHA256Managed, text, text2, num) = param;
		Encoding.UTF8.GetBytes(text, 0, text.Length, (byte[])buffer, offset);
		Encoding.UTF8.GetBytes(text2, 0, text2.Length, (byte[])buffer, offset + num);
		return Convert.ToBase64String(sHA256Managed.ComputeHash((byte[])buffer, offset, length));
	}

	public static string GetMd5Hash(string input)
	{
		//Discarded unreachable code: IL_0082, IL_010f, IL_0122, IL_0131
		int num = 2;
		int num2 = num;
		byte[] array = default(byte[]);
		MD5CryptoServiceProvider mD5CryptoServiceProvider = default(MD5CryptoServiceProvider);
		string result = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			default:
				array = (byte[])CfFlSVGFJoADfPwDmvH5(bb5ienGFyXcmrOmWwlZx(), input);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 4;
				}
				continue;
			case 5:
				try
				{
					mD5CryptoServiceProvider = Md5CryptoServiceProviderPool.Get();
					int num3 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 2:
							array = mD5CryptoServiceProvider.ComputeHash(array);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
							{
								num3 = 0;
							}
							break;
						case 1:
							result = (string)u9iJHoGF996oMX45bnul(array);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
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
					Md5CryptoServiceProviderPool.Return(mD5CryptoServiceProvider);
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			case 4:
				mD5CryptoServiceProvider = null;
				num2 = 5;
				continue;
			case 3:
				return result;
			case 2:
				obj = input;
				if (obj == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 1:
				obj = "";
				break;
			}
			input = (string)obj;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
			{
				num2 = 0;
			}
		}
	}

	public static string GetMd5Hash(Stream input)
	{
		//Discarded unreachable code: IL_0089, IL_00e6, IL_011e, IL_017c, IL_018f, IL_019e
		int num = 1;
		int num2 = num;
		MD5CryptoServiceProvider mD5CryptoServiceProvider = default(MD5CryptoServiceProvider);
		Stream stream = default(Stream);
		string text = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 2:
				return text;
			case 1:
				obj = input;
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 4:
				mD5CryptoServiceProvider = null;
				num2 = 3;
				continue;
			case 3:
				try
				{
					mD5CryptoServiceProvider = Md5CryptoServiceProviderPool.Get();
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							stream = input;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						try
						{
							text = (string)u9iJHoGF996oMX45bnul(mD5CryptoServiceProvider.ComputeHash(input));
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
							{
								num4 = 0;
							}
							return num4 switch
							{
								0 => text, 
								_ => text, 
							};
						}
						finally
						{
							if (stream != null)
							{
								int num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
								{
									num5 = 0;
								}
								while (true)
								{
									switch (num5)
									{
									default:
										((IDisposable)stream).Dispose();
										num5 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
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
					Md5CryptoServiceProviderPool.Return(mD5CryptoServiceProvider);
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
			default:
				obj = aE0u9TGFdKjNMNyKyEyA(Array.Empty<byte>(), false);
				break;
			}
			input = (Stream)obj;
			num2 = 4;
		}
	}

	public static string GetMd5Hash(BinaryFile file)
	{
		return BinaryFileHashService.GetHash(file, HashAlogrithmEnum.MD5);
	}

	public static bool TryGetMd5Hash(BinaryFile file, out string hash)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			string error;
			switch (num2)
			{
			default:
				return TryGetMd5Hash(file, out hash, out error);
			case 1:
				error = "";
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static bool TryGetMd5Hash(BinaryFile file, out string hash, out string error)
	{
		//Discarded unreachable code: IL_004a, IL_00b3, IL_0127, IL_0136
		bool result = default(bool);
		switch (1)
		{
		default:
			return result;
		case 1:
			try
			{
				hash = GetMd5Hash(file);
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						return result;
					default:
						error = "";
						num = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
						{
							num = 2;
						}
						break;
					case 2:
						result = true;
						num = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
						{
							num = 0;
						}
						break;
					}
				}
			}
			catch (Exception ex)
			{
				int num2 = 3;
				while (true)
				{
					switch (num2)
					{
					default:
						return result;
					case 0:
						return result;
					case 3:
						hash = "";
						num2 = 2;
						break;
					case 1:
						result = false;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						error = ex.Message;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}
	}

	public static bool TryGetMd5LegacyHash(BinaryFile file, out string hash, out string error)
	{
		//Discarded unreachable code: IL_0039, IL_0114, IL_014c, IL_017c, IL_018b, IL_0197, IL_01d5, IL_0259, IL_0268
		bool result = default(bool);
		switch (1)
		{
		default:
			return result;
		case 1:
			try
			{
				string text = "";
				int num = 3;
				Stream content = default(Stream);
				byte[] array = default(byte[]);
				while (true)
				{
					switch (num)
					{
					case 2:
						return result;
					case 4:
						error = "";
						num = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num = 5;
						}
						continue;
					default:
						content = file.GetContent();
						num = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num = 1;
						}
						continue;
					case 3:
						if (file != null)
						{
							num = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
							{
								num = 0;
							}
							continue;
						}
						break;
					case 6:
						text = (string)rt0PQtGFrpsAhBM8PLlD(Encoding.UTF8, array);
						num = 7;
						continue;
					case 5:
						result = true;
						num = 2;
						continue;
					case 1:
						try
						{
							array = content.ReadAllBytes();
							int num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
							{
								num2 = 0;
							}
							switch (num2)
							{
							case 0:
								break;
							}
						}
						finally
						{
							int num3;
							if (content == null)
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
								{
									num3 = 1;
								}
								goto IL_0150;
							}
							goto IL_0166;
							IL_0166:
							Pe0o4hGFl5F4MOqr0X4h(content);
							num3 = 2;
							goto IL_0150;
							IL_0150:
							switch (num3)
							{
							case 1:
								goto end_IL_012b;
							case 2:
								goto end_IL_012b;
							}
							goto IL_0166;
							end_IL_012b:;
						}
						goto case 6;
					case 7:
						break;
					}
					hash = (string)ErL1UMGFgQ2IifOkjB1G(text);
					num = 4;
				}
			}
			catch (Exception ex)
			{
				int num4 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
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
					case 1:
						hash = "";
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
						{
							num4 = 3;
						}
						break;
					case 2:
						result = false;
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num4 = 0;
						}
						break;
					case 3:
						error = (string)VZYZdiGF5Gj4gw7plbwE(ex);
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num4 = 2;
						}
						break;
					}
				}
			}
		}
	}

	public static VerifyMd5Result VerifyMd5Hash(string hash, BinaryFile file)
	{
		//Discarded unreachable code: IL_00b2
		int num = 4;
		int num2 = num;
		string hash2 = default(string);
		VerifyMd5Result result = default(VerifyMd5Result);
		string error = default(string);
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 4:
				hash2 = "";
				num2 = 3;
				break;
			default:
				return result;
			case 1:
				if (!TryGetMd5Hash(file, out hash2, out error))
				{
					num2 = 11;
					break;
				}
				goto case 10;
			case 9:
				result.Verified = flag;
				num2 = 6;
				break;
			case 3:
				error = "";
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 1;
				}
				break;
			case 8:
				result.Error = error;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 0;
				}
				break;
			case 10:
				flag = Sy0ftoGFjEwxV6t90JDU(hash2, hash);
				num2 = 7;
				break;
			case 7:
				result = default(VerifyMd5Result);
				num2 = 9;
				break;
			case 2:
				result.Verified = false;
				num2 = 8;
				break;
			case 5:
				return result;
			case 11:
				result = default(VerifyMd5Result);
				num2 = 2;
				break;
			case 6:
				result.Error = (string)(flag ? "" : R8t5iVGFLKCGFrIbnOTv(uTZljvGFYTIvSpkJqlNi(--1867379187 ^ 0x6F4E4415)));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	public static string EncryptPwd(string encString)
	{
		return (string)jFEZ2rGFUewcdbvT9Dpp(encString, Iv);
	}

	public static string EncryptPwd(string encString, byte[] iv)
	{
		//Discarded unreachable code: IL_004d, IL_0096, IL_00d8, IL_010d, IL_0145, IL_019e, IL_01d6, IL_01e5, IL_0275, IL_0284, IL_02d2, IL_030a, IL_0319
		int num = 2;
		int num2 = num;
		string result = default(string);
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
		while (true)
		{
			switch (num2)
			{
			default:
				return result;
			case 1:
				try
				{
					MemoryStream memoryStream = (MemoryStream)Wjmcs6GFsb6VawSBxrU1();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							CryptoStream cryptoStream = new CryptoStream(memoryStream.AsNoClose(), (ICryptoTransform)X5TXutGFcbZC4nAnr0qJ(rijndaelManaged, PubKey, iv), CryptoStreamMode.Write);
							int num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
							{
								num4 = 2;
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
									try
									{
										StreamWriter streamWriter = new StreamWriter(cryptoStream);
										int num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
										{
											num5 = 0;
										}
										switch (num5)
										{
										default:
											try
											{
												streamWriter.WriteLine(encString);
												int num6 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
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
												if (streamWriter != null)
												{
													int num7 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
													{
														num7 = 0;
													}
													while (true)
													{
														switch (num7)
														{
														default:
															((IDisposable)streamWriter).Dispose();
															num7 = 1;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
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
											break;
										}
									}
									finally
									{
										if (cryptoStream != null)
										{
											int num8 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
											{
												num8 = 0;
											}
											while (true)
											{
												switch (num8)
												{
												default:
													Pe0o4hGFl5F4MOqr0X4h(cryptoStream);
													num8 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
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
									break;
								case 3:
									result = MemoryHelper.ActionWithMemoryBuffer<byte, MemoryStream, string>((int)memoryStream.Length, memoryStream, EncryptPwdAction);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
									{
										num4 = 0;
									}
									continue;
								case 1:
									break;
								}
								au3PPIGFz87gDT7sgbGP(memoryStream, 0L, SeekOrigin.Begin);
								num4 = 3;
							}
						}
						finally
						{
							int num10;
							if (memoryStream == null)
							{
								int num9 = 2;
								num10 = num9;
								goto IL_025a;
							}
							goto IL_028f;
							IL_025a:
							switch (num10)
							{
							default:
								goto end_IL_0241;
							case 2:
								goto end_IL_0241;
							case 1:
								break;
							case 0:
								goto end_IL_0241;
							}
							goto IL_028f;
							IL_028f:
							Pe0o4hGFl5F4MOqr0X4h(memoryStream);
							num10 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
							{
								num10 = 0;
							}
							goto IL_025a;
							end_IL_0241:;
						}
					}
				}
				finally
				{
					if (rijndaelManaged != null)
					{
						int num11 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num11 = 1;
						}
						while (true)
						{
							switch (num11)
							{
							case 1:
								((IDisposable)rijndaelManaged).Dispose();
								num11 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
								{
									num11 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			case 2:
				rijndaelManaged = new RijndaelManaged();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private static string EncryptPwdAction(object buffer, int offset, int length, object memoryStream)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (string)WOm14QGBFr3CyF63fGn3(buffer, offset, length);
			case 1:
				((Stream)memoryStream).Read((byte[])buffer, offset, length);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static string DecryptPwd(string pwd)
	{
		return (string)gU6OBkGBB94ccnMGBryq(pwd, Iv);
	}

	public static string DecryptPwd(string pwd, byte[] iv)
	{
		//Discarded unreachable code: IL_0051, IL_0095, IL_00cb, IL_0101, IL_0139, IL_0179, IL_01a5, IL_01fe, IL_021d, IL_022c, IL_027a, IL_02ba, IL_02c5, IL_02d4
		int num = 1;
		int num2 = num;
		byte[] array = default(byte[]);
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				try
				{
					MemoryStream memoryStream = (MemoryStream)aE0u9TGFdKjNMNyKyEyA(array, false);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							CryptoStream cryptoStream = new CryptoStream(memoryStream, (ICryptoTransform)ubABtaGBoRTHZRcqwoBw(rijndaelManaged, PubKey, iv), CryptoStreamMode.Read);
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
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
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
									{
										num5 = 0;
									}
									switch (num5)
									{
									default:
										try
										{
											result = (string)l6aKfPGBbcy28GoM2IuB(streamReader);
											int num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
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
											int num7;
											if (streamReader == null)
											{
												num7 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
												{
													num7 = 0;
												}
												goto IL_013d;
											}
											goto IL_0153;
											IL_0153:
											((IDisposable)streamReader).Dispose();
											num7 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
											{
												num7 = 0;
											}
											goto IL_013d;
											IL_013d:
											switch (num7)
											{
											default:
												goto end_IL_0118;
											case 2:
												break;
											case 0:
												goto end_IL_0118;
											case 1:
												goto end_IL_0118;
											}
											goto IL_0153;
											end_IL_0118:;
										}
									}
								}
								finally
								{
									if (cryptoStream != null)
									{
										int num8 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
										{
											num8 = 0;
										}
										while (true)
										{
											switch (num8)
											{
											case 1:
												((IDisposable)cryptoStream).Dispose();
												num8 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
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
						finally
						{
							int num9;
							if (memoryStream == null)
							{
								num9 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
								{
									num9 = 0;
								}
								goto IL_0202;
							}
							goto IL_0237;
							IL_0237:
							Pe0o4hGFl5F4MOqr0X4h(memoryStream);
							num9 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
							{
								num9 = 2;
							}
							goto IL_0202;
							IL_0202:
							switch (num9)
							{
							case 1:
								goto end_IL_01dd;
							case 2:
								goto end_IL_01dd;
							}
							goto IL_0237;
							end_IL_01dd:;
						}
					}
				}
				finally
				{
					int num10;
					if (rijndaelManaged == null)
					{
						num10 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num10 = 0;
						}
						goto IL_027e;
					}
					goto IL_0294;
					IL_0294:
					Pe0o4hGFl5F4MOqr0X4h(rijndaelManaged);
					num10 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num10 = 1;
					}
					goto IL_027e;
					IL_027e:
					switch (num10)
					{
					default:
						goto end_IL_0259;
					case 2:
						break;
					case 0:
						goto end_IL_0259;
					case 1:
						goto end_IL_0259;
					}
					goto IL_0294;
					end_IL_0259:;
				}
			default:
				rijndaelManaged = new RijndaelManaged();
				num2 = 3;
				break;
			case 1:
				array = (byte[])h0L7MFGBWcF9MXsvX5vh(pwd);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return result;
			}
		}
	}

	public static string Encrypt(string plainText, string passPhrase)
	{
		//Discarded unreachable code: IL_003d
		int num = 4;
		int num2 = num;
		StringBuilder stringBuilder = default(StringBuilder);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 2:
				mq4ZAsGBEAbvTc92aOw8(stringBuilder, nRPHqdGBG7AttuFIoO1t(uTZljvGFYTIvSpkJqlNi(0x5DD55050 ^ 0x5DD502A0), eyd55BGBhL5upVNyicGL(passPhrase)));
				num2 = 5;
				break;
			case 3:
				num3 = 0;
				num2 = 6;
				break;
			case 4:
				stringBuilder = new StringBuilder();
				num2 = 3;
				break;
			case 1:
			case 6:
				if (num3 >= 8)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 5:
				num3++;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (string)zoXtALGBfPY14yVgveBM(plainText, stringBuilder.ToString(), passPhrase);
			}
		}
	}

	public static string Encrypt(string plainText, string saltStr, string passPhrase)
	{
		//Discarded unreachable code: IL_0051, IL_00bd, IL_00cc, IL_00d8, IL_00e7
		int num = 1;
		int num2 = num;
		Rfc2898DeriveBytes rfc2898DeriveBytes = default(Rfc2898DeriveBytes);
		byte[] bytes = default(byte[]);
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				try
				{
					result = (string)GRxyWCGBCClKsdgN0PSB(plainText, rfc2898DeriveBytes);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
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
					int num4;
					if (rfc2898DeriveBytes == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num4 = 1;
						}
						goto IL_008d;
					}
					goto IL_00a3;
					IL_00a3:
					Pe0o4hGFl5F4MOqr0X4h(rfc2898DeriveBytes);
					int num5 = 2;
					num4 = num5;
					goto IL_008d;
					IL_008d:
					switch (num4)
					{
					case 1:
						goto end_IL_0068;
					case 2:
						goto end_IL_0068;
					}
					goto IL_00a3;
					end_IL_0068:;
				}
			case 1:
				bytes = ((Encoding)b8VnC3GBQhUDRbTRNykw()).GetBytes(saltStr);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				rfc2898DeriveBytes = new Rfc2898DeriveBytes(passPhrase, bytes, 10000);
				num2 = 3;
				break;
			case 2:
				return result;
			}
		}
	}

	public static string Encrypt(string plainText, string saltStr, byte[] passPhrase)
	{
		//Discarded unreachable code: IL_0051, IL_0089, IL_00c1, IL_00d0
		int num = 3;
		int num2 = num;
		Rfc2898DeriveBytes rfc2898DeriveBytes = default(Rfc2898DeriveBytes);
		byte[] salt = default(byte[]);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					text = (string)GRxyWCGBCClKsdgN0PSB(plainText, rfc2898DeriveBytes);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => text, 
						_ => text, 
					};
				}
				finally
				{
					if (rfc2898DeriveBytes != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								((IDisposable)rfc2898DeriveBytes).Dispose();
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
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
			case 3:
				salt = (byte[])CfFlSVGFJoADfPwDmvH5(b8VnC3GBQhUDRbTRNykw(), saltStr);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 2;
				}
				break;
			default:
				return text;
			case 2:
				rfc2898DeriveBytes = new Rfc2898DeriveBytes(passPhrase, salt, 10000);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private static string EncryptInnerLogic(object plainText, object pwdGen)
	{
		//Discarded unreachable code: IL_0140, IL_01be, IL_01f6, IL_022e, IL_0287, IL_02a6, IL_02f3, IL_0333, IL_033e, IL_034d
		int num = 3;
		int num2 = num;
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
		string result = default(string);
		byte[] iV = default(byte[]);
		MemoryStream memoryStream = default(MemoryStream);
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
			{
				RijndaelManaged rijndaelManaged2 = new RijndaelManaged();
				GPkAHJGB8eWfpbWNYGNh(rijndaelManaged2, 256);
				rijndaelManaged = rijndaelManaged2;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 1;
				}
				break;
			}
			default:
				return result;
			case 1:
				try
				{
					byte[] key = (byte[])B09IVKGBuF3n9rksPXgX(pwdGen, ItUKJcGBZZYj063xTm5n(rijndaelManaged) / 8);
					int num3 = 3;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						case 3:
							iV = (byte[])B09IVKGBuF3n9rksPXgX(pwdGen, rijndaelManaged.BlockSize / 8);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
							{
								num4 = 0;
							}
							break;
						default:
							rijndaelManaged.Key = key;
							num4 = 4;
							break;
						case 4:
							rijndaelManaged.IV = iV;
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
							{
								num4 = 1;
							}
							break;
						case 1:
							memoryStream = (MemoryStream)Wjmcs6GFsb6VawSBxrU1();
							num4 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
							{
								num4 = 2;
							}
							break;
						case 2:
							try
							{
								CryptoStream cryptoStream = new CryptoStream(memoryStream.AsNoClose(), (ICryptoTransform)LdL3yRGBI3H3r0iqS0ty(rijndaelManaged), CryptoStreamMode.Write);
								int num5 = 2;
								while (true)
								{
									switch (num5)
									{
									case 1:
										return result;
									default:
										result = MemoryHelper.ActionWithMemoryBuffer<byte, MemoryStream, string>((int)rI9ayTGBSgMZemxQqrRw(memoryStream), memoryStream, EncryptAction);
										num5 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
										{
											num5 = 1;
										}
										continue;
									case 2:
										try
										{
											SwI0RtGBV9V7B4iBEY4n(cryptoStream, array, 0, array.Length);
											int num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
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
											if (cryptoStream != null)
											{
												int num7 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
												{
													num7 = 0;
												}
												while (true)
												{
													switch (num7)
													{
													default:
														Pe0o4hGFl5F4MOqr0X4h(cryptoStream);
														num7 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
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
										break;
									case 3:
										break;
									}
									au3PPIGFz87gDT7sgbGP(memoryStream, 0L, SeekOrigin.Begin);
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
									{
										num5 = 0;
									}
								}
							}
							finally
							{
								int num8;
								if (memoryStream == null)
								{
									num8 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
									{
										num8 = 0;
									}
									goto IL_028b;
								}
								goto IL_02b0;
								IL_02b0:
								((IDisposable)memoryStream).Dispose();
								num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
								{
									num8 = 1;
								}
								goto IL_028b;
								IL_028b:
								switch (num8)
								{
								default:
									goto end_IL_0266;
								case 0:
									goto end_IL_0266;
								case 2:
									break;
								case 1:
									goto end_IL_0266;
								}
								goto IL_02b0;
								end_IL_0266:;
							}
						}
					}
				}
				finally
				{
					int num9;
					if (rijndaelManaged == null)
					{
						num9 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
						{
							num9 = 1;
						}
						goto IL_02f7;
					}
					goto IL_030d;
					IL_030d:
					((IDisposable)rijndaelManaged).Dispose();
					num9 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num9 = 0;
					}
					goto IL_02f7;
					IL_02f7:
					switch (num9)
					{
					default:
						goto end_IL_02d2;
					case 2:
						break;
					case 1:
						goto end_IL_02d2;
					case 0:
						goto end_IL_02d2;
					}
					goto IL_030d;
					end_IL_02d2:;
				}
			case 3:
				array = (byte[])CfFlSVGFJoADfPwDmvH5(r61mqmGBvPwMserDDdYA(), plainText);
				num2 = 2;
				break;
			}
		}
	}

	private static string EncryptAction(object buffer, int offset, int length, object memoryStream)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return Convert.ToBase64String((byte[])buffer, offset, length);
			case 1:
				((Stream)memoryStream).Read((byte[])buffer, offset, length);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void EncryptFile(string fileInput, string fileEncrypted, string saltStr, string passPhrase)
	{
		//Discarded unreachable code: IL_00aa, IL_01aa, IL_01e8, IL_021e, IL_027b, IL_02d4, IL_032d, IL_0386, IL_03a5, IL_03b4, IL_0402, IL_043a
		int num = 1;
		int num2 = num;
		byte[] salt = default(byte[]);
		Rfc2898DeriveBytes rfc2898DeriveBytes = default(Rfc2898DeriveBytes);
		byte[] array2 = default(byte[]);
		FileStream fileStream2 = default(FileStream);
		while (true)
		{
			switch (num2)
			{
			case 1:
				salt = (byte[])CfFlSVGFJoADfPwDmvH5(b8VnC3GBQhUDRbTRNykw(), saltStr);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				rfc2898DeriveBytes = new Rfc2898DeriveBytes(passPhrase, salt, 10000);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			case 2:
				try
				{
					RijndaelManaged rijndaelManaged = new RijndaelManaged();
					GPkAHJGB8eWfpbWNYGNh(rijndaelManaged, 256);
					RijndaelManaged rijndaelManaged2 = rijndaelManaged;
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							byte[] array = (byte[])B09IVKGBuF3n9rksPXgX(rfc2898DeriveBytes, rijndaelManaged2.KeySize / 8);
							int num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									array2 = (byte[])B09IVKGBuF3n9rksPXgX(rfc2898DeriveBytes, Rs1J4hGBixUexD1sJmTb(rijndaelManaged2) / 8);
									num4 = 3;
									break;
								case 2:
									LtaDamGBqpebrs4FmyYJ(rijndaelManaged2, array2);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
									{
										num4 = 0;
									}
									break;
								case 3:
									lpVuJJGBRE5Zq76Yr8jU(rijndaelManaged2, array);
									num4 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
									{
										num4 = 0;
									}
									break;
								default:
								{
									fileStream2 = new FileStream(fileInput, FileMode.Open, FileAccess.Read);
									int num11 = 4;
									num4 = num11;
									break;
								}
								case 4:
									try
									{
										FileStream fileStream = new FileStream(fileEncrypted, FileMode.Create, FileAccess.Write);
										int num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
										{
											num5 = 0;
										}
										switch (num5)
										{
										default:
											try
											{
												CryptoStream cryptoStream = new CryptoStream(fileStream, (ICryptoTransform)LdL3yRGBI3H3r0iqS0ty(rijndaelManaged2), CryptoStreamMode.Write);
												int num6 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
												{
													num6 = 0;
												}
												switch (num6)
												{
												default:
													try
													{
														FTnpW4GBKX777V9QA9hA(fileStream2, cryptoStream);
														int num7 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
														{
															num7 = 1;
														}
														while (true)
														{
															switch (num7)
															{
															default:
																return;
															case 0:
																return;
															case 1:
																PfZPklGBX52mroZwtuFR(cryptoStream);
																num7 = 0;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
																{
																	num7 = 0;
																}
																break;
															}
														}
													}
													finally
													{
														if (cryptoStream != null)
														{
															int num8 = 1;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
															{
																num8 = 0;
															}
															while (true)
															{
																switch (num8)
																{
																case 1:
																	Pe0o4hGFl5F4MOqr0X4h(cryptoStream);
																	num8 = 0;
																	if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
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
											finally
											{
												if (fileStream != null)
												{
													int num9 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
													{
														num9 = 0;
													}
													while (true)
													{
														switch (num9)
														{
														default:
															Pe0o4hGFl5F4MOqr0X4h(fileStream);
															num9 = 1;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
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
										}
									}
									finally
									{
										if (fileStream2 != null)
										{
											int num10 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
											{
												num10 = 1;
											}
											while (true)
											{
												switch (num10)
												{
												case 1:
													((IDisposable)fileStream2).Dispose();
													num10 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
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
						}
						finally
						{
							int num12;
							if (rijndaelManaged2 == null)
							{
								num12 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
								{
									num12 = 1;
								}
								goto IL_038a;
							}
							goto IL_03bf;
							IL_03bf:
							((IDisposable)rijndaelManaged2).Dispose();
							num12 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
							{
								num12 = 0;
							}
							goto IL_038a;
							IL_038a:
							switch (num12)
							{
							default:
								goto end_IL_0365;
							case 2:
								goto end_IL_0365;
							case 1:
								break;
							case 0:
								goto end_IL_0365;
							}
							goto IL_03bf;
							end_IL_0365:;
						}
					}
				}
				finally
				{
					if (rfc2898DeriveBytes != null)
					{
						int num13 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
						{
							num13 = 0;
						}
						while (true)
						{
							switch (num13)
							{
							default:
								Pe0o4hGFl5F4MOqr0X4h(rfc2898DeriveBytes);
								num13 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
								{
									num13 = 1;
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

	public static string Decrypt(string cipherText, string passPhrase)
	{
		//Discarded unreachable code: IL_0041, IL_0050, IL_0111, IL_0120
		int num = 3;
		int num2 = num;
		StringBuilder stringBuilder = default(StringBuilder);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return (string)yNyTkUGBTAr1p7I0wavv(cipherText, stringBuilder.ToString(), passPhrase);
			case 4:
			case 7:
				mq4ZAsGBEAbvTc92aOw8(stringBuilder, nRPHqdGBG7AttuFIoO1t(uTZljvGFYTIvSpkJqlNi(0x571EA399 ^ 0x571EF169), eyd55BGBhL5upVNyicGL(passPhrase)));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 6;
				}
				break;
			default:
				if (num3 < 8)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 1;
			case 2:
				num3 = 0;
				num2 = 5;
				break;
			case 3:
				stringBuilder = new StringBuilder();
				num2 = 2;
				break;
			case 6:
				num3++;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static string Decrypt(string cipherText, string saltStr, string passPhrase)
	{
		//Discarded unreachable code: IL_00a1, IL_00d9, IL_0111, IL_0120
		int num = 2;
		int num2 = num;
		Rfc2898DeriveBytes rfc2898DeriveBytes = default(Rfc2898DeriveBytes);
		byte[] bytes = default(byte[]);
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				rfc2898DeriveBytes = new Rfc2898DeriveBytes(passPhrase, bytes, 10000);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				bytes = ((Encoding)b8VnC3GBQhUDRbTRNykw()).GetBytes(saltStr);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				try
				{
					result = DecryptInnerLogic(cipherText, rfc2898DeriveBytes);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
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
					if (rfc2898DeriveBytes != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								Pe0o4hGFl5F4MOqr0X4h(rfc2898DeriveBytes);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
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
			default:
				return result;
			}
		}
	}

	public static string Decrypt(string cipherText, string saltStr, byte[] passPhrase)
	{
		//Discarded unreachable code: IL_0051, IL_0089, IL_00b9, IL_00c8, IL_00d4, IL_00e3
		int num = 3;
		int num2 = num;
		Rfc2898DeriveBytes rfc2898DeriveBytes = default(Rfc2898DeriveBytes);
		string result = default(string);
		byte[] bytes = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					result = (string)SZjKdeGBkykVTvOkvmF1(cipherText, rfc2898DeriveBytes);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
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
					int num4;
					if (rfc2898DeriveBytes == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
						{
							num4 = 1;
						}
						goto IL_008d;
					}
					goto IL_00a3;
					IL_00a3:
					Pe0o4hGFl5F4MOqr0X4h(rfc2898DeriveBytes);
					num4 = 2;
					goto IL_008d;
					IL_008d:
					switch (num4)
					{
					case 1:
						goto end_IL_0068;
					case 2:
						goto end_IL_0068;
					}
					goto IL_00a3;
					end_IL_0068:;
				}
			default:
				return result;
			case 3:
				bytes = Encoding.ASCII.GetBytes(saltStr);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				rfc2898DeriveBytes = new Rfc2898DeriveBytes(passPhrase, bytes, 10000);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static string DecryptInnerLogic(object cipherText, object pwdGen)
	{
		//Discarded unreachable code: IL_0099, IL_016e, IL_01b1, IL_01e9, IL_0221, IL_0230, IL_0279, IL_0298, IL_02e5, IL_031d
		int num = 1;
		int num2 = num;
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
		byte[] array2 = default(byte[]);
		string result = default(string);
		byte[] array3 = default(byte[]);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			default:
			{
				RijndaelManaged rijndaelManaged2 = new RijndaelManaged();
				GPkAHJGB8eWfpbWNYGNh(rijndaelManaged2, 256);
				rijndaelManaged = rijndaelManaged2;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num2 = 0;
				}
				break;
			}
			case 1:
				array2 = (byte[])h0L7MFGBWcF9MXsvX5vh(cipherText);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return result;
			case 2:
				try
				{
					byte[] array = (byte[])B09IVKGBuF3n9rksPXgX(pwdGen, rijndaelManaged.KeySize / 8);
					int num3 = 4;
					while (true)
					{
						switch (num3)
						{
						default:
							LtaDamGBqpebrs4FmyYJ(rijndaelManaged, array3);
							num3 = 2;
							break;
						case 1:
							lpVuJJGBRE5Zq76Yr8jU(rijndaelManaged, array);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
							{
								num3 = 0;
							}
							break;
						case 4:
							array3 = (byte[])B09IVKGBuF3n9rksPXgX(pwdGen, rijndaelManaged.BlockSize / 8);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
							{
								num3 = 1;
							}
							break;
						case 2:
							memoryStream = (MemoryStream)Wjmcs6GFsb6VawSBxrU1();
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
							{
								num3 = 3;
							}
							break;
						case 3:
							try
							{
								CryptoStream cryptoStream = new CryptoStream(memoryStream.AsNoClose(), (ICryptoTransform)AvkYBIGBnMy1SVwelBn6(rijndaelManaged), CryptoStreamMode.Write);
								int num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
								{
									num4 = 1;
								}
								while (true)
								{
									switch (num4)
									{
									case 2:
										return result;
									case 1:
										try
										{
											cryptoStream.Write(array2, 0, array2.Length);
											int num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
											{
												num5 = 0;
											}
											switch (num5)
											{
											case 0:
												break;
											}
										}
										finally
										{
											if (cryptoStream != null)
											{
												int num6 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
												{
													num6 = 0;
												}
												while (true)
												{
													switch (num6)
													{
													default:
														Pe0o4hGFl5F4MOqr0X4h(cryptoStream);
														num6 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
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
										break;
									}
									result = (string)QGjo1pGBO4wKBF6Hw9sA(memoryStream, r61mqmGBvPwMserDDdYA());
									num4 = 2;
								}
							}
							finally
							{
								int num7;
								if (memoryStream == null)
								{
									num7 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
									{
										num7 = 0;
									}
									goto IL_027d;
								}
								goto IL_02a2;
								IL_02a2:
								Pe0o4hGFl5F4MOqr0X4h(memoryStream);
								num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
								{
									num7 = 0;
								}
								goto IL_027d;
								IL_027d:
								switch (num7)
								{
								default:
									goto end_IL_0258;
								case 1:
									goto end_IL_0258;
								case 2:
									break;
								case 0:
									goto end_IL_0258;
								}
								goto IL_02a2;
								end_IL_0258:;
							}
						}
					}
				}
				finally
				{
					if (rijndaelManaged != null)
					{
						int num8 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
						{
							num8 = 1;
						}
						while (true)
						{
							switch (num8)
							{
							case 1:
								Pe0o4hGFl5F4MOqr0X4h(rijndaelManaged);
								num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
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
	}

	public static void DecryptFile(string fileEncrypted, string outputFile, string saltStr, string passPhrase)
	{
		//Discarded unreachable code: IL_0059, IL_0098, IL_0163, IL_01a1, IL_01d7, IL_020f, IL_024f, IL_025e, IL_028b, IL_02aa, IL_02b9, IL_02f7, IL_0337, IL_0346, IL_0373, IL_03cc, IL_0404, IL_0413
		int num = 3;
		int num2 = num;
		Rfc2898DeriveBytes rfc2898DeriveBytes = default(Rfc2898DeriveBytes);
		FileStream fileStream2 = default(FileStream);
		byte[] array = default(byte[]);
		byte[] salt = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				try
				{
					RijndaelManaged rijndaelManaged = new RijndaelManaged();
					GPkAHJGB8eWfpbWNYGNh(rijndaelManaged, 256);
					RijndaelManaged rijndaelManaged2 = rijndaelManaged;
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							byte[] key = (byte[])B09IVKGBuF3n9rksPXgX(rfc2898DeriveBytes, rijndaelManaged2.KeySize / 8);
							int num4 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								case 3:
									fileStream2 = new FileStream(fileEncrypted, FileMode.Open, FileAccess.Read);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
									{
										num4 = 1;
									}
									break;
								case 2:
									array = (byte[])B09IVKGBuF3n9rksPXgX(rfc2898DeriveBytes, Rs1J4hGBixUexD1sJmTb(rijndaelManaged2) / 8);
									num4 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
									{
										num4 = 0;
									}
									break;
								case 4:
									rijndaelManaged2.Key = key;
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
									{
										num4 = 0;
									}
									break;
								default:
									LtaDamGBqpebrs4FmyYJ(rijndaelManaged2, array);
									num4 = 3;
									break;
								case 1:
									try
									{
										FileStream fileStream = (FileStream)DF818gGB29DRQOZPWclO(outputFile);
										int num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
										{
											num5 = 0;
										}
										switch (num5)
										{
										}
										try
										{
											CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged2.CreateDecryptor(), CryptoStreamMode.Write);
											int num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
											{
												num6 = 0;
											}
											switch (num6)
											{
											}
											try
											{
												fileStream2.CopyTo(cryptoStream);
												int num7 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
												{
													num7 = 0;
												}
												switch (num7)
												{
												case 0:
													break;
												}
												return;
											}
											finally
											{
												int num8;
												if (cryptoStream == null)
												{
													num8 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
													{
														num8 = 0;
													}
													goto IL_0213;
												}
												goto IL_0229;
												IL_0229:
												Pe0o4hGFl5F4MOqr0X4h(cryptoStream);
												num8 = 2;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
												{
													num8 = 2;
												}
												goto IL_0213;
												IL_0213:
												switch (num8)
												{
												default:
													goto end_IL_01ee;
												case 1:
													break;
												case 0:
													goto end_IL_01ee;
												case 2:
													goto end_IL_01ee;
												}
												goto IL_0229;
												end_IL_01ee:;
											}
										}
										finally
										{
											int num9;
											if (fileStream == null)
											{
												num9 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
												{
													num9 = 2;
												}
												goto IL_028f;
											}
											goto IL_02c4;
											IL_02c4:
											Pe0o4hGFl5F4MOqr0X4h(fileStream);
											num9 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
											{
												num9 = 1;
											}
											goto IL_028f;
											IL_028f:
											switch (num9)
											{
											case 2:
												goto end_IL_026a;
											case 1:
												goto end_IL_026a;
											}
											goto IL_02c4;
											end_IL_026a:;
										}
									}
									finally
									{
										int num10;
										if (fileStream2 == null)
										{
											num10 = 2;
											goto IL_02fb;
										}
										goto IL_0311;
										IL_02fb:
										switch (num10)
										{
										default:
											goto end_IL_02e6;
										case 1:
											break;
										case 2:
											goto end_IL_02e6;
										case 0:
											goto end_IL_02e6;
										}
										goto IL_0311;
										IL_0311:
										((IDisposable)fileStream2).Dispose();
										num10 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
										{
											num10 = 0;
										}
										goto IL_02fb;
										end_IL_02e6:;
									}
								}
							}
						}
						finally
						{
							if (rijndaelManaged2 != null)
							{
								int num11 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
								{
									num11 = 1;
								}
								while (true)
								{
									switch (num11)
									{
									case 1:
										((IDisposable)rijndaelManaged2).Dispose();
										num11 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
										{
											num11 = 0;
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
					if (rfc2898DeriveBytes != null)
					{
						int num12 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
						{
							num12 = 0;
						}
						while (true)
						{
							switch (num12)
							{
							default:
								Pe0o4hGFl5F4MOqr0X4h(rfc2898DeriveBytes);
								num12 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
								{
									num12 = 0;
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
				rfc2898DeriveBytes = new Rfc2898DeriveBytes(passPhrase, salt, 10000);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				salt = (byte[])CfFlSVGFJoADfPwDmvH5(b8VnC3GBQhUDRbTRNykw(), saltStr);
				num2 = 2;
				break;
			case 0:
				return;
			}
		}
	}

	public static Stream DecryptStream(Stream inStream, string saltStr, string passPhrase)
	{
		//Discarded unreachable code: IL_0082, IL_00c1, IL_0185, IL_01c5, IL_01d4, IL_0214, IL_0223, IL_0250
		int num = 2;
		int num2 = num;
		Rfc2898DeriveBytes rfc2898DeriveBytes = default(Rfc2898DeriveBytes);
		byte[] salt = default(byte[]);
		Stream result = default(Stream);
		byte[] iV = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				rfc2898DeriveBytes = new Rfc2898DeriveBytes(passPhrase, salt, 10000);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				salt = (byte[])CfFlSVGFJoADfPwDmvH5(b8VnC3GBQhUDRbTRNykw(), saltStr);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				return result;
			}
			try
			{
				RijndaelManaged rijndaelManaged = new RijndaelManaged();
				GPkAHJGB8eWfpbWNYGNh(rijndaelManaged, 256);
				RijndaelManaged rijndaelManaged2 = rijndaelManaged;
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				default:
					try
					{
						byte[] array = (byte[])B09IVKGBuF3n9rksPXgX(rfc2898DeriveBytes, rijndaelManaged2.KeySize / 8);
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								rijndaelManaged2.IV = iV;
								num4 = 3;
								break;
							case 3:
								result = new CryptoStream(inStream, (ICryptoTransform)AvkYBIGBnMy1SVwelBn6(rijndaelManaged2), CryptoStreamMode.Read);
								num4 = 4;
								break;
							case 2:
								lpVuJJGBRE5Zq76Yr8jU(rijndaelManaged2, array);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
								{
									num4 = 0;
								}
								break;
							case 1:
								iV = (byte[])B09IVKGBuF3n9rksPXgX(rfc2898DeriveBytes, Rs1J4hGBixUexD1sJmTb(rijndaelManaged2) / 8);
								num4 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
								{
									num4 = 1;
								}
								break;
							case 4:
								return result;
							}
						}
					}
					finally
					{
						int num5;
						if (rijndaelManaged2 == null)
						{
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
							{
								num5 = 1;
							}
							goto IL_0189;
						}
						goto IL_019f;
						IL_019f:
						((IDisposable)rijndaelManaged2).Dispose();
						num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num5 = 0;
						}
						goto IL_0189;
						IL_0189:
						switch (num5)
						{
						default:
							goto end_IL_0164;
						case 2:
							break;
						case 1:
							goto end_IL_0164;
						case 0:
							goto end_IL_0164;
						}
						goto IL_019f;
						end_IL_0164:;
					}
				}
			}
			finally
			{
				int num7;
				if (rfc2898DeriveBytes == null)
				{
					int num6 = 2;
					num7 = num6;
					goto IL_01f9;
				}
				goto IL_022e;
				IL_01f9:
				switch (num7)
				{
				case 2:
					goto end_IL_01e0;
				case 1:
					goto end_IL_01e0;
				}
				goto IL_022e;
				IL_022e:
				Pe0o4hGFl5F4MOqr0X4h(rfc2898DeriveBytes);
				num7 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num7 = 0;
				}
				goto IL_01f9;
				end_IL_01e0:;
			}
		}
	}

	public static RSAParameters LoadRsaKeyFromFile(string keyFilePath)
	{
		//Discarded unreachable code: IL_0041, IL_0062, IL_014f, IL_015e, IL_016e, IL_02c9, IL_02d8, IL_02ff, IL_030e, IL_031e, IL_032d, IL_033d, IL_034c, IL_035b, IL_036a, IL_037a, IL_043c, IL_04ed, IL_0512, IL_0521, IL_0534, IL_0543, IL_0569, IL_059e, IL_05ad, IL_05bd, IL_05cc, IL_05dc, IL_05eb, IL_05fa, IL_0871, IL_08ce, IL_08dd
		int num = 2;
		int num2 = num;
		XmlDocument xmlDocument = default(XmlDocument);
		IEnumerator enumerator = default(IEnumerator);
		XmlNode xmlNode = default(XmlNode);
		uint num5 = default(uint);
		string name = default(string);
		RSAParameters result = default(RSAParameters);
		while (true)
		{
			switch (num2)
			{
			case 1:
				xmlDocument = new XmlDocument();
				num2 = 5;
				continue;
			case 4:
				try
				{
					while (true)
					{
						IL_04a8:
						int num3;
						if (!c2kFWhGBtu4obyinnEph(enumerator))
						{
							num3 = 31;
							goto IL_006c;
						}
						goto IL_0384;
						IL_006c:
						int num4 = num3;
						goto IL_0070;
						IL_0384:
						xmlNode = (XmlNode)d2akmgGBpYAPBUggHkv6(enumerator);
						num4 = 45;
						goto IL_0070;
						IL_0070:
						while (true)
						{
							switch (num4)
							{
							case 10:
								if (num5 != 667835878)
								{
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
									{
										num4 = 0;
									}
									continue;
								}
								goto case 14;
							case 13:
								if (!Sy0ftoGFjEwxV6t90JDU(name, uTZljvGFYTIvSpkJqlNi(0x4DC2B14D ^ 0x4DC10769)))
								{
									num4 = 46;
									continue;
								}
								goto case 19;
							case 9:
								if (num5 <= 684613497)
								{
									num4 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
									{
										num4 = 10;
									}
									continue;
								}
								goto case 26;
							case 3:
								if (!Sy0ftoGFjEwxV6t90JDU(name, uTZljvGFYTIvSpkJqlNi(0x103FE975 ^ 0x103C5F43)))
								{
									num4 = 49;
									continue;
								}
								goto case 12;
							case 33:
								if (name == (string)uTZljvGFYTIvSpkJqlNi(-978351861 ^ -978448355))
								{
									num4 = 30;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
									{
										num4 = 30;
									}
									continue;
								}
								goto IL_04a8;
							case 6:
								if (num5 == 3883103162u)
								{
									num4 = 13;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
									{
										num4 = 8;
									}
									continue;
								}
								goto IL_04a8;
							case 26:
								if (num5 != 1898057334)
								{
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
									{
										num4 = 1;
									}
									continue;
								}
								goto case 38;
							case 27:
								if (num5 != 3238785555u)
								{
									num4 = 8;
									continue;
								}
								goto case 33;
							case 5:
								if (num5 != 3574337935u)
								{
									num4 = 6;
									continue;
								}
								goto case 24;
							case 22:
								break;
							case 41:
								goto IL_0384;
							case 38:
								if (!(name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106416734)))
								{
									num4 = 15;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
									{
										num4 = 5;
									}
									continue;
								}
								goto case 11;
							case 47:
								if (!Sy0ftoGFjEwxV6t90JDU(name, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633601021)))
								{
									num4 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
									{
										num4 = 0;
									}
									continue;
								}
								goto case 21;
							default:
								if (num5 != 684613497)
								{
									num4 = 18;
									continue;
								}
								goto case 47;
							case 45:
								name = xmlNode.Name;
								num4 = 22;
								continue;
							case 24:
								if (!Sy0ftoGFjEwxV6t90JDU(name, uTZljvGFYTIvSpkJqlNi(0x10E41EDB ^ 0x10E7A891)))
								{
									num4 = 24;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
									{
										num4 = 34;
									}
									continue;
								}
								goto case 16;
							case 50:
								if (!Sy0ftoGFjEwxV6t90JDU(name, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECDE55A)))
								{
									num4 = 17;
									continue;
								}
								goto case 40;
							case 2:
							case 4:
							case 7:
							case 15:
							case 17:
							case 18:
							case 20:
							case 28:
							case 29:
							case 34:
							case 36:
							case 37:
							case 42:
							case 43:
							case 44:
							case 46:
							case 48:
							case 49:
							case 51:
								goto IL_04a8;
							case 1:
								if (num5 != 2183145318u)
								{
									num4 = 44;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
									{
										num4 = 7;
									}
									continue;
								}
								goto case 3;
							case 25:
								if (num5 <= 2183145318u)
								{
									num4 = 9;
									continue;
								}
								goto case 32;
							case 32:
								if (num5 <= 3557560316u)
								{
									num4 = 27;
									continue;
								}
								goto case 5;
							case 8:
								if (num5 != 3557560316u)
								{
									num4 = 42;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
									{
										num4 = 31;
									}
									continue;
								}
								goto case 50;
							case 14:
								if (!Sy0ftoGFjEwxV6t90JDU(name, uTZljvGFYTIvSpkJqlNi(-957824448 ^ -957647842)))
								{
									goto IL_04a8;
								}
								num4 = 39;
								continue;
							case 19:
								result.Modulus = (byte[])(U673h8GBayccYNpu4st6(xmlNode.InnerText) ? null : h0L7MFGBWcF9MXsvX5vh(w3b2mwGBD76p2gTO8evX(xmlNode)));
								num4 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
								{
									num4 = 4;
								}
								continue;
							case 12:
								result.Exponent = (byte[])(U673h8GBayccYNpu4st6(w3b2mwGBD76p2gTO8evX(xmlNode)) ? null : h0L7MFGBWcF9MXsvX5vh(w3b2mwGBD76p2gTO8evX(xmlNode)));
								num4 = 48;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
								{
									num4 = 23;
								}
								continue;
							case 16:
								result.P = (U673h8GBayccYNpu4st6(w3b2mwGBD76p2gTO8evX(xmlNode)) ? null : Convert.FromBase64String((string)w3b2mwGBD76p2gTO8evX(xmlNode)));
								num4 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
								{
									num4 = 29;
								}
								continue;
							case 40:
								result.Q = (U673h8GBayccYNpu4st6(w3b2mwGBD76p2gTO8evX(xmlNode)) ? null : Convert.FromBase64String(xmlNode.InnerText));
								num4 = 19;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
								{
									num4 = 36;
								}
								continue;
							case 21:
								result.DP = (byte[])(U673h8GBayccYNpu4st6(w3b2mwGBD76p2gTO8evX(xmlNode)) ? null : h0L7MFGBWcF9MXsvX5vh(w3b2mwGBD76p2gTO8evX(xmlNode)));
								num4 = 51;
								continue;
							case 35:
							case 39:
								result.DQ = (byte[])(string.IsNullOrEmpty((string)w3b2mwGBD76p2gTO8evX(xmlNode)) ? null : h0L7MFGBWcF9MXsvX5vh(xmlNode.InnerText));
								num4 = 20;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
								{
									num4 = 1;
								}
								continue;
							case 11:
								result.InverseQ = (byte[])(string.IsNullOrEmpty((string)w3b2mwGBD76p2gTO8evX(xmlNode)) ? null : h0L7MFGBWcF9MXsvX5vh(xmlNode.InnerText));
								num4 = 28;
								continue;
							case 23:
							case 30:
								result.D = (byte[])(string.IsNullOrEmpty((string)w3b2mwGBD76p2gTO8evX(xmlNode)) ? null : h0L7MFGBWcF9MXsvX5vh(w3b2mwGBD76p2gTO8evX(xmlNode)));
								num4 = 7;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
								{
									num4 = 0;
								}
								continue;
							case 31:
								return result;
							}
							break;
						}
						num5 = _003CPrivateImplementationDetails_003E.ComputeStringHash(name);
						num3 = 25;
						goto IL_006c;
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					int num6 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num6 = 1;
					}
					while (true)
					{
						switch (num6)
						{
						default:
							Pe0o4hGFl5F4MOqr0X4h(disposable);
							num6 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
							{
								num6 = 1;
							}
							continue;
						case 1:
							if (disposable != null)
							{
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
								{
									num6 = 0;
								}
								continue;
							}
							break;
						case 2:
							break;
						}
						break;
					}
				}
			case 2:
				result = default(RSAParameters);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 1;
				}
				continue;
			case 5:
				uwbpCPGBeOAwAHkRU3na(xmlDocument, keyFilePath);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 6;
				}
				continue;
			case 6:
				if (!qlV3wuGB1tTuFyhs9EOd(((XmlNode)OEheFCGBPZI76lNFjQ9n(xmlDocument)).Name, uTZljvGFYTIvSpkJqlNi(0x1ECE530A ^ 0x1ECDE500)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 7;
					}
					continue;
				}
				break;
			default:
				throw new Exception(SR.T((string)uTZljvGFYTIvSpkJqlNi(-2107978722 ^ -2108065180)));
			case 3:
				break;
			}
			enumerator = (IEnumerator)VZLssxGB3JrQXdZkII3P(SEylk4GBNKtUnH3958bN(OEheFCGBPZI76lNFjQ9n(xmlDocument)));
			num2 = 4;
		}
	}

	public static string RsaDecrypt(string encryptedMessage, RSAParameters privateKey)
	{
		//Discarded unreachable code: IL_008a, IL_011e, IL_013d, IL_014c, IL_0179
		int num = 1;
		int num2 = num;
		string result = default(string);
		RSACryptoServiceProvider rSACryptoServiceProvider = default(RSACryptoServiceProvider);
		byte[] array = default(byte[]);
		byte[] rgb = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return result;
			case 1:
				if (U673h8GBayccYNpu4st6(encryptedMessage))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 0;
					}
					break;
				}
				rSACryptoServiceProvider = new RSACryptoServiceProvider();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return null;
			case 2:
				try
				{
					rSACryptoServiceProvider.ImportParameters(privateKey);
					int num3 = 3;
					while (true)
					{
						switch (num3)
						{
						case 2:
							return result;
						case 1:
							array = rSACryptoServiceProvider.Decrypt(rgb, fOAEP: false);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
							{
								num3 = 0;
							}
							break;
						default:
							result = (string)rt0PQtGFrpsAhBM8PLlD(Encoding.UTF8, array);
							num3 = 2;
							break;
						case 3:
							rgb = (byte[])h0L7MFGBWcF9MXsvX5vh(encryptedMessage);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
							{
								num3 = 1;
							}
							break;
						}
					}
				}
				finally
				{
					int num4;
					if (rSACryptoServiceProvider == null)
					{
						num4 = 2;
						goto IL_0122;
					}
					goto IL_0157;
					IL_0122:
					switch (num4)
					{
					default:
						goto end_IL_010d;
					case 2:
						goto end_IL_010d;
					case 1:
						break;
					case 0:
						goto end_IL_010d;
					}
					goto IL_0157;
					IL_0157:
					Pe0o4hGFl5F4MOqr0X4h(rSACryptoServiceProvider);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num4 = 0;
					}
					goto IL_0122;
					end_IL_010d:;
				}
			}
		}
	}

	public static string RsaEncrypt(string message, RSAParameters publicKey)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return null;
			default:
				return (string)Ult5HeGBwsULAAISYqiA(((Encoding)bb5ienGFyXcmrOmWwlZx()).GetBytes(message), publicKey);
			case 1:
				if (!string.IsNullOrEmpty(message))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public static string RsaEncrypt(byte[] messageBytes, RSAParameters publicKey)
	{
		//Discarded unreachable code: IL_0089, IL_00ef, IL_012f, IL_013a, IL_0149
		int num = 3;
		RSACryptoServiceProvider rSACryptoServiceProvider = default(RSACryptoServiceProvider);
		string result = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return null;
				case 3:
					if (messageBytes != null)
					{
						rSACryptoServiceProvider = new RSACryptoServiceProvider();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				default:
					return result;
				case 1:
					try
					{
						dMB72dGB4UuBhWnDftDq(rSACryptoServiceProvider, publicKey);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
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
							result = (string)C4nUiiGFmXLqgTkiFtAr(kbcqB3GB63BNTdferCcl(rSACryptoServiceProvider, messageBytes, false));
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
							{
								num3 = 1;
							}
						}
					}
					finally
					{
						int num4;
						if (rSACryptoServiceProvider == null)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
							{
								num4 = 0;
							}
							goto IL_00f3;
						}
						goto IL_0109;
						IL_0109:
						Pe0o4hGFl5F4MOqr0X4h(rSACryptoServiceProvider);
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
						{
							num4 = 0;
						}
						goto IL_00f3;
						IL_00f3:
						switch (num4)
						{
						default:
							goto end_IL_00ce;
						case 2:
							break;
						case 0:
							goto end_IL_00ce;
						case 1:
							goto end_IL_00ce;
						}
						goto IL_0109;
						end_IL_00ce:;
					}
				}
				break;
			}
			num = 2;
		}
	}

	public static string RsaSign(string message, RSAParameters serverPrivateKey)
	{
		//Discarded unreachable code: IL_0066, IL_00e2, IL_011a, IL_0129, IL_0151, IL_0160
		int num = 4;
		int num2 = num;
		RSACryptoServiceProvider rSACryptoServiceProvider = default(RSACryptoServiceProvider);
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 3:
				rSACryptoServiceProvider = new RSACryptoServiceProvider();
				num2 = 2;
				break;
			case 2:
				try
				{
					dMB72dGB4UuBhWnDftDq(rSACryptoServiceProvider, serverPrivateKey);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							result = MemoryHelper.ActionWithMemoryBuffer<byte, (RSACryptoServiceProvider, string), string>(HWbS2lGFMdpPTPyAbpgf(bb5ienGFyXcmrOmWwlZx(), message), (rSACryptoServiceProvider, message), RsaSignAction);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
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
					if (rSACryptoServiceProvider != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								Pe0o4hGFl5F4MOqr0X4h(rSACryptoServiceProvider);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
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
			case 1:
				return result;
			case 4:
				if (!U673h8GBayccYNpu4st6(message))
				{
					num2 = 3;
					break;
				}
				goto default;
			}
		}
	}

	private static string RsaSignAction(object buffer, int offset, int length, (RSACryptoServiceProvider, string) param)
	{
		var (rSACryptoServiceProvider, text) = param;
		Encoding.UTF8.GetBytes(text, 0, text.Length, (byte[])buffer, offset);
		return Convert.ToBase64String(rSACryptoServiceProvider.SignData((byte[])buffer, offset, length, new SHA256CryptoServiceProvider()));
	}

	private static string BytesToHexString(object bytes)
	{
		return (string)aRVd9WGBAQktB6D7oxMM(((string)sCQrNyGBH4yy5jkswjAG(bytes)).Replace((string)uTZljvGFYTIvSpkJqlNi(-29254301 ^ -29256945), ""));
	}

	static EncryptionHelper()
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
			{
				byte[] array = new byte[16];
				iynDXOGB72hynar6O7ee(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
				PubKey = array;
				num2 = 5;
				break;
			}
			case 5:
			{
				byte[] array2 = new byte[16];
				iynDXOGB72hynar6O7ee(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
				Iv = array2;
				num2 = 6;
				break;
			}
			case 6:
				return;
			case 4:
				LIYiKoGFxWWPq6Lqf2fQ();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				Sha256ManagedPool = ObjectPool.Create<SHA256Managed>((IPooledObjectPolicy<SHA256Managed>)null);
				num2 = 2;
				break;
			case 2:
				Md5CryptoServiceProviderPool = ObjectPool.Create<MD5CryptoServiceProvider>((IPooledObjectPolicy<MD5CryptoServiceProvider>)null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				RngCryptoServiceProviderPool = ObjectPool.Create<RNGCryptoServiceProvider>((IPooledObjectPolicy<RNGCryptoServiceProvider>)null);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool JZP7LxGFArCqfTiWLLQT()
	{
		return SMBnkvGFH7750VrdSTL5 == null;
	}

	internal static EncryptionHelper zp0LMwGF7hLe3Qmjp76r()
	{
		return SMBnkvGFH7750VrdSTL5;
	}

	internal static void LIYiKoGFxWWPq6Lqf2fQ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void paWtVvGF0TnCOmBv8LGD(object P_0, object P_1)
	{
		((RandomNumberGenerator)P_0).GetBytes((byte[])P_1);
	}

	internal static object C4nUiiGFmXLqgTkiFtAr(object P_0)
	{
		return Convert.ToBase64String((byte[])P_0);
	}

	internal static object bb5ienGFyXcmrOmWwlZx()
	{
		return Encoding.UTF8;
	}

	internal static int HWbS2lGFMdpPTPyAbpgf(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetByteCount((string)P_1);
	}

	internal static object CfFlSVGFJoADfPwDmvH5(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetBytes((string)P_1);
	}

	internal static object u9iJHoGF996oMX45bnul(object P_0)
	{
		return BytesToHexString(P_0);
	}

	internal static object aE0u9TGFdKjNMNyKyEyA(object P_0, bool writable)
	{
		return MemoryHelper.GetMemoryStream((byte[])P_0, writable);
	}

	internal static void Pe0o4hGFl5F4MOqr0X4h(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object rt0PQtGFrpsAhBM8PLlD(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetString((byte[])P_1);
	}

	internal static object ErL1UMGFgQ2IifOkjB1G(object P_0)
	{
		return GetMd5Hash((string)P_0);
	}

	internal static object VZYZdiGF5Gj4gw7plbwE(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static bool Sy0ftoGFjEwxV6t90JDU(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object uTZljvGFYTIvSpkJqlNi(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object R8t5iVGFLKCGFrIbnOTv(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object jFEZ2rGFUewcdbvT9Dpp(object P_0, object P_1)
	{
		return EncryptPwd((string)P_0, (byte[])P_1);
	}

	internal static object Wjmcs6GFsb6VawSBxrU1()
	{
		return MemoryHelper.GetMemoryStream();
	}

	internal static object X5TXutGFcbZC4nAnr0qJ(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateEncryptor((byte[])P_1, (byte[])P_2);
	}

	internal static long au3PPIGFz87gDT7sgbGP(object P_0, long P_1, SeekOrigin P_2)
	{
		return ((Stream)P_0).Seek(P_1, P_2);
	}

	internal static object WOm14QGBFr3CyF63fGn3(object P_0, int P_1, int P_2)
	{
		return Convert.ToBase64String((byte[])P_0, P_1, P_2);
	}

	internal static object gU6OBkGBB94ccnMGBryq(object P_0, object P_1)
	{
		return DecryptPwd((string)P_0, (byte[])P_1);
	}

	internal static object h0L7MFGBWcF9MXsvX5vh(object P_0)
	{
		return Convert.FromBase64String((string)P_0);
	}

	internal static object ubABtaGBoRTHZRcqwoBw(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	internal static object l6aKfPGBbcy28GoM2IuB(object P_0)
	{
		return ((TextReader)P_0).ReadLine();
	}

	internal static int eyd55BGBhL5upVNyicGL(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object nRPHqdGBG7AttuFIoO1t(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static object mq4ZAsGBEAbvTc92aOw8(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static object zoXtALGBfPY14yVgveBM(object P_0, object P_1, object P_2)
	{
		return Encrypt((string)P_0, (string)P_1, (string)P_2);
	}

	internal static object b8VnC3GBQhUDRbTRNykw()
	{
		return Encoding.ASCII;
	}

	internal static object GRxyWCGBCClKsdgN0PSB(object P_0, object P_1)
	{
		return EncryptInnerLogic(P_0, P_1);
	}

	internal static object r61mqmGBvPwMserDDdYA()
	{
		return Encoding.Unicode;
	}

	internal static void GPkAHJGB8eWfpbWNYGNh(object P_0, int P_1)
	{
		((SymmetricAlgorithm)P_0).BlockSize = P_1;
	}

	internal static int ItUKJcGBZZYj063xTm5n(object P_0)
	{
		return ((SymmetricAlgorithm)P_0).KeySize;
	}

	internal static object B09IVKGBuF3n9rksPXgX(object P_0, int P_1)
	{
		return ((DeriveBytes)P_0).GetBytes(P_1);
	}

	internal static object LdL3yRGBI3H3r0iqS0ty(object P_0)
	{
		return ((SymmetricAlgorithm)P_0).CreateEncryptor();
	}

	internal static void SwI0RtGBV9V7B4iBEY4n(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static long rI9ayTGBSgMZemxQqrRw(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static int Rs1J4hGBixUexD1sJmTb(object P_0)
	{
		return ((SymmetricAlgorithm)P_0).BlockSize;
	}

	internal static void lpVuJJGBRE5Zq76Yr8jU(object P_0, object P_1)
	{
		((SymmetricAlgorithm)P_0).Key = (byte[])P_1;
	}

	internal static void LtaDamGBqpebrs4FmyYJ(object P_0, object P_1)
	{
		((SymmetricAlgorithm)P_0).IV = (byte[])P_1;
	}

	internal static void FTnpW4GBKX777V9QA9hA(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	internal static void PfZPklGBX52mroZwtuFR(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object yNyTkUGBTAr1p7I0wavv(object P_0, object P_1, object P_2)
	{
		return Decrypt((string)P_0, (string)P_1, (string)P_2);
	}

	internal static object SZjKdeGBkykVTvOkvmF1(object P_0, object P_1)
	{
		return DecryptInnerLogic(P_0, P_1);
	}

	internal static object AvkYBIGBnMy1SVwelBn6(object P_0)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor();
	}

	internal static object QGjo1pGBO4wKBF6Hw9sA(object P_0, object P_1)
	{
		return ((MemoryStream)P_0).AsString((Encoding)P_1);
	}

	internal static object DF818gGB29DRQOZPWclO(object P_0)
	{
		return File.OpenWrite((string)P_0);
	}

	internal static void uwbpCPGBeOAwAHkRU3na(object P_0, object P_1)
	{
		((XmlDocument)P_0).Load((string)P_1);
	}

	internal static object OEheFCGBPZI76lNFjQ9n(object P_0)
	{
		return ((XmlDocument)P_0).DocumentElement;
	}

	internal static bool qlV3wuGB1tTuFyhs9EOd(object P_0, object P_1)
	{
		return ((string)P_0).Equals((string)P_1);
	}

	internal static object SEylk4GBNKtUnH3958bN(object P_0)
	{
		return ((XmlNode)P_0).ChildNodes;
	}

	internal static object VZLssxGB3JrQXdZkII3P(object P_0)
	{
		return ((XmlNodeList)P_0).GetEnumerator();
	}

	internal static object d2akmgGBpYAPBUggHkv6(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static bool U673h8GBayccYNpu4st6(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object w3b2mwGBD76p2gTO8evX(object P_0)
	{
		return ((XmlNode)P_0).InnerText;
	}

	internal static bool c2kFWhGBtu4obyinnEph(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object Ult5HeGBwsULAAISYqiA(object P_0, RSAParameters publicKey)
	{
		return RsaEncrypt((byte[])P_0, publicKey);
	}

	internal static void dMB72dGB4UuBhWnDftDq(object P_0, RSAParameters P_1)
	{
		((RSA)P_0).ImportParameters(P_1);
	}

	internal static object kbcqB3GB63BNTdferCcl(object P_0, object P_1, bool P_2)
	{
		return ((RSACryptoServiceProvider)P_0).Encrypt((byte[])P_1, P_2);
	}

	internal static object sCQrNyGBH4yy5jkswjAG(object P_0)
	{
		return BitConverter.ToString((byte[])P_0);
	}

	internal static object aRVd9WGBAQktB6D7oxMM(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static void iynDXOGB72hynar6O7ee(object P_0, RuntimeFieldHandle P_1)
	{
		RuntimeHelpers.InitializeArray((Array)P_0, P_1);
	}
}
