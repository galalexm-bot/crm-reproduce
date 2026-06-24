using System;
using System.Configuration;
using System.IO;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Files;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Services;

[Service]
internal class ExportImportFileService : ExportImportFileServiceBase
{
	public const long BufferLength = 393216L;

	private readonly ICacheFilesService cacheFilesService;

	internal static ExportImportFileService DTUCCsEA4sZiWfVCD1aY;

	private string filesPath
	{
		get
		{
			//Discarded unreachable code: IL_0047, IL_0056
			int num = 2;
			int num2 = num;
			string text = default(string);
			while (true)
			{
				switch (num2)
				{
				default:
					U0g9eREAdUXBuv0P4Gdf(text);
					num2 = 3;
					break;
				case 2:
					text = (string)Wl0EdYEAJyBhfxtmt9xD(this);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					if (dRxLPnEA9XlPY7HCwWUP(text))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
						{
							num2 = 3;
						}
						break;
					}
					goto default;
				case 3:
				case 4:
					return text;
				}
			}
		}
	}

	public ExportImportFileService(ICacheFilesService cacheFilesService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Wt4eU4EAACLqssGjEhUb();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.cacheFilesService = cacheFilesService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override long GetBufferLength()
	{
		return 393216L;
	}

	public override string GetFilesFolderName()
	{
		return (string)N6YhnjEA7Fbn2SUuq4Pd(-1858887263 ^ -1858653573);
	}

	public override string GetFilesFolderPath()
	{
		return (string)lFqesbEAMuaHRNbBgfnf(CaQPOpEAycWysp3eaG3r(wynmFpEAm5r1oKpQSDwf(pkBrdaEA0IWh9aFFZhSY(FrHKhqEAxanR929xvqAX(Locator.GetService<IRuntimeApplication>())))), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -671832351));
	}

	public override string CreateZipFileName(string id)
	{
		return (string)OFs0xUEAl2KwanUODWWY(this, id, null);
	}

	public override string CreateZipFileName(string id, string ext)
	{
		//Discarded unreachable code: IL_005f
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (id != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 2:
				return (string)lFqesbEAMuaHRNbBgfnf(filesPath, text);
			case 3:
				throw new ArgumentNullException((string)N6YhnjEA7Fbn2SUuq4Pd(0x34185E55 ^ 0x34196D2F));
			default:
				text = (string)pZiuKWEAr0Nbao5LV8JT(N6YhnjEA7Fbn2SUuq4Pd(-1852837372 ^ -1852854266), id, ext ?? N6YhnjEA7Fbn2SUuq4Pd(-398663332 ^ -398953124));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override string CreateFileName(string id, string folder, string name, string ext)
	{
		int num = 2;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return (string)lFqesbEAMuaHRNbBgfnf(L6gpKbEAgXKlphmVpp1i(this, id, folder), text);
			case 2:
				if (id == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 1;
					}
					break;
				}
				text = string.Format((string)N6YhnjEA7Fbn2SUuq4Pd(-1487388570 ^ -1487404444), name ?? id, ext ?? z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463E6F3E));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16683619));
			}
		}
	}

	public override string CreateFileName(string id, string name = null, string ext = "xml")
	{
		return CreateFileName(id, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFE54E2), name, ext);
	}

	public override string CreateFolderName(string id)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				throw new ArgumentNullException((string)N6YhnjEA7Fbn2SUuq4Pd(-951514650 ^ -951567716));
			default:
				return Path.Combine(filesPath, id);
			case 1:
				if (id != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public override string CreateDeployFolderName(string id)
	{
		return (string)L6gpKbEAgXKlphmVpp1i(this, id, N6YhnjEA7Fbn2SUuq4Pd(0x7247028A ^ 0x7247AE02));
	}

	public override string CreateDeployFolderName(string id, string folder)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				throw new ArgumentNullException((string)N6YhnjEA7Fbn2SUuq4Pd(-542721635 ^ -542668057));
			case 1:
				if (id != null)
				{
					return (string)lFqesbEAMuaHRNbBgfnf(RFZgmpEA5nyDVgqPZ13I(this, id), folder);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void AddToFile(string id, byte[] buf)
	{
		//Discarded unreachable code: IL_00d5, IL_00f8, IL_014e, IL_0165, IL_0174, IL_0184, IL_0193
		int num = 5;
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521195718));
				default:
					throw new ArgumentOutOfRangeException((string)N6YhnjEA7Fbn2SUuq4Pd(-1767720453 ^ -1767494155));
				case 3:
					text = (string)aNwwAaEAj1RLf5VHqmQW(this, id);
					num2 = 2;
					continue;
				case 5:
					if (id == null)
					{
						break;
					}
					if (buf != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				case 2:
					try
					{
						int num3;
						if (CAo20JEAYZHGpkd5lsux(text))
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
							{
								num3 = 0;
							}
							goto IL_00d9;
						}
						object obj = ArxwShEALwfyYcRrkGhY(text);
						goto IL_0104;
						IL_0104:
						lCrMiuEAU0bcB0Ivmygr(obj, buf, 0, buf.Length);
						WN3QYSEAsWPkJ44lRdXU(obj);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
						{
							num3 = 0;
						}
						goto IL_00d9;
						IL_00d9:
						switch (num3)
						{
						default:
							return;
						case 1:
							break;
						case 0:
							return;
						}
						obj = new FileStream(text, FileMode.Append);
						goto IL_0104;
					}
					catch (Exception)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
						return;
					}
				case 1:
					return;
				}
				break;
			}
			num = 4;
		}
	}

	public override void AddToFile(string id, BinaryFile file)
	{
		//Discarded unreachable code: IL_004d, IL_0085, IL_00c5, IL_00d4, IL_00e0, IL_00ef
		int num = 1;
		int num2 = num;
		Stream content = default(Stream);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				content = file.GetContent();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				AddToFile(id, content);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				case 0:
					break;
				}
				return;
			}
			finally
			{
				int num4;
				if (content == null)
				{
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num4 = 0;
					}
					goto IL_0089;
				}
				goto IL_009f;
				IL_009f:
				tepa2xEAcJy0nsOKUm4k(content);
				num4 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num4 = 0;
				}
				goto IL_0089;
				IL_0089:
				switch (num4)
				{
				default:
					goto end_IL_0064;
				case 2:
					break;
				case 0:
					goto end_IL_0064;
				case 1:
					goto end_IL_0064;
				}
				goto IL_009f;
				end_IL_0064:;
			}
		}
	}

	public override void AddToNestedFile(string id, string nestedId, string path, byte[] buf)
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
				ptth4aEAzHeiEV2hDrku(this, id, nestedId, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561366684), path, buf);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void AddToNestedFile(string id, string nestedId, string fileExtension, string path, byte[] buf)
	{
		//Discarded unreachable code: IL_00a9, IL_0124, IL_0154, IL_01e4, IL_020f, IL_023d, IL_0275, IL_02ad, IL_02bc, IL_02cc, IL_02db, IL_0329, IL_0340, IL_034f
		int num = 12;
		int num2 = num;
		string text2 = default(string);
		string text3 = default(string);
		string text = default(string);
		FileStream fileStream2 = default(FileStream);
		while (true)
		{
			switch (num2)
			{
			case 1:
				text2 = (string)lFqesbEAMuaHRNbBgfnf(text3, text);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 4;
				}
				break;
			case 7:
				throw new ArgumentNullException((string)N6YhnjEA7Fbn2SUuq4Pd(-951514650 ^ -951214598));
			case 14:
				if (path != null)
				{
					num2 = 13;
					break;
				}
				goto case 6;
			case 11:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFFCB10));
			case 9:
				throw new ArgumentOutOfRangeException((string)N6YhnjEA7Fbn2SUuq4Pd(-420743386 ^ -420519128));
			default:
				text3 = (string)oMWFF7E7FW9Xaw2nDOgR(filesPath, id, path);
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 1;
				}
				break;
			case 12:
				if (id != null)
				{
					if (nestedId != null)
					{
						num2 = 14;
						break;
					}
					goto case 7;
				}
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 11;
				}
				break;
			case 8:
				return;
			case 5:
				Directory.CreateDirectory(text3);
				num2 = 3;
				break;
			case 6:
				throw new ArgumentNullException((string)N6YhnjEA7Fbn2SUuq4Pd(0x3C5338FF ^ 0x3C576683));
			case 13:
				if (buf != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 9;
			case 10:
				if (Directory.Exists(text3))
				{
					num2 = 2;
					break;
				}
				goto case 5;
			case 4:
				try
				{
					int num3;
					if (!CAo20JEAYZHGpkd5lsux(text2))
					{
						num3 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
						{
							num3 = 3;
						}
						goto IL_01e8;
					}
					goto IL_0202;
					IL_02e6:
					FileStream fileStream = File.Create(text2);
					goto IL_02ed;
					IL_01e8:
					switch (num3)
					{
					case 1:
						return;
					case 2:
						try
						{
							fileStream2.Write(buf, 0, buf.Length);
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
							{
								num4 = 0;
							}
							switch (num4)
							{
							case 0:
								break;
							}
							return;
						}
						finally
						{
							if (fileStream2 != null)
							{
								int num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
								{
									num5 = 1;
								}
								while (true)
								{
									switch (num5)
									{
									case 1:
										tepa2xEAcJy0nsOKUm4k(fileStream2);
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
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
					case 3:
						goto IL_02e6;
					}
					goto IL_0202;
					IL_0202:
					fileStream = new FileStream(text2, FileMode.Append);
					goto IL_02ed;
					IL_02ed:
					fileStream2 = fileStream;
					num3 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num3 = 0;
					}
					goto IL_01e8;
				}
				catch (Exception)
				{
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
					return;
				}
			case 2:
			case 3:
				text = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426078405), nestedId, fileExtension);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override byte[] LoadFile(string id, long i)
	{
		return (byte[])AlhjZEE7BoSCDxnP10Lw(this, id, i, null);
	}

	public override byte[] LoadFile(string id, long i, string ext)
	{
		//Discarded unreachable code: IL_01bf, IL_01d6, IL_01e5, IL_0214, IL_024b, IL_025a, IL_02cf, IL_02ee, IL_02fd, IL_032a
		int num = 5;
		int num2 = num;
		FileStream fileStream = default(FileStream);
		string text = default(string);
		long num5 = default(long);
		byte[] result = default(byte[]);
		byte[] array = default(byte[]);
		long num6 = default(long);
		while (true)
		{
			switch (num2)
			{
			case 1:
				fileStream = new FileStream(text, FileMode.Open, FileAccess.Read);
				num2 = 3;
				break;
			case 5:
				if (id == null)
				{
					num2 = 4;
					break;
				}
				if (i < 0)
				{
					num2 = 6;
					break;
				}
				text = (string)OFs0xUEAl2KwanUODWWY(this, id, ext);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F4CC289));
			default:
				if (CAo20JEAYZHGpkd5lsux(text))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			case 2:
				throw new Exception((string)N6YhnjEA7Fbn2SUuq4Pd(-1886646897 ^ -1886873153));
			case 6:
				throw new ArgumentOutOfRangeException((string)N6YhnjEA7Fbn2SUuq4Pd(-867826612 ^ -867765796));
			case 3:
				try
				{
					int num3;
					if ((i + 1) * 393216 >= bLPoLdE7WxaX6WWCd6BN(fileStream))
					{
						num3 = 9;
						goto IL_0125;
					}
					long num4 = 393216L;
					goto IL_029d;
					IL_029d:
					num5 = num4;
					num3 = 4;
					goto IL_0125;
					IL_0125:
					while (true)
					{
						switch (num3)
						{
						case 3:
							return result;
						case 6:
							return result;
						case 11:
							return result;
						case 4:
							if (num5 >= 0)
							{
								num3 = 7;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
								{
									num3 = 6;
								}
								continue;
							}
							goto case 12;
						case 1:
						case 7:
							array = new byte[num5];
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
							{
								num3 = 1;
							}
							continue;
						case 9:
							break;
						case 12:
							result = null;
							num3 = 6;
							continue;
						case 8:
							result = array;
							num3 = 3;
							continue;
						case 10:
						{
							result = null;
							int num7 = 11;
							num3 = num7;
							continue;
						}
						case 2:
							num6 = 393216 * i;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
							{
								num3 = 0;
							}
							continue;
						case 5:
							if (fileStream.Read(array, 0, array.Length) == 0)
							{
								num3 = 10;
								continue;
							}
							goto case 8;
						default:
							YURYfBE7obyeNTmjPWTT(fileStream, num6, SeekOrigin.Begin);
							num3 = 5;
							continue;
						}
						break;
					}
					num4 = bLPoLdE7WxaX6WWCd6BN(fileStream) - i * 393216;
					goto IL_029d;
				}
				finally
				{
					int num8;
					if (fileStream == null)
					{
						num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
						{
							num8 = 0;
						}
						goto IL_02d3;
					}
					goto IL_0308;
					IL_0308:
					tepa2xEAcJy0nsOKUm4k(fileStream);
					num8 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num8 = 1;
					}
					goto IL_02d3;
					IL_02d3:
					switch (num8)
					{
					default:
						goto end_IL_02ae;
					case 0:
						goto end_IL_02ae;
					case 2:
						break;
					case 1:
						goto end_IL_02ae;
					}
					goto IL_0308;
					end_IL_02ae:;
				}
			}
		}
	}

	public override void DeleteFiles(string id)
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
				EcUmqkE7b5n5hREJdtUX(this, id, null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override void DeleteFiles(string id, string ext)
	{
		//Discarded unreachable code: IL_00a9, IL_00b8, IL_0120, IL_012f
		int num = 9;
		int num2 = num;
		string text = default(string);
		string text2 = default(string);
		while (true)
		{
			switch (num2)
			{
			case 6:
				lsWtmCE7GxXE3rW8lVcy(text, true);
				num2 = 7;
				break;
			default:
				iwPJHaE7h5MGeNtSq9Dk(text2);
				num2 = 5;
				break;
			case 3:
				if (!File.Exists(text2))
				{
					num2 = 2;
					break;
				}
				goto default;
			case 1:
				if (!dRxLPnEA9XlPY7HCwWUP(text))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 6;
			case 4:
				return;
			case 7:
				return;
			case 9:
				if (id == null)
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					text2 = (string)OFs0xUEAl2KwanUODWWY(this, id, ext);
					num2 = 3;
				}
				break;
			case 2:
			case 5:
				text = (string)RFZgmpEA5nyDVgqPZ13I(this, id);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 1;
				}
				break;
			case 8:
				return;
			}
		}
	}

	public override void LoadFileToCache(string fileName, string fullFileName, Guid uid)
	{
		//Discarded unreachable code: IL_0039, IL_0048, IL_00ad, IL_00d5, IL_00f4, IL_0103, IL_0130, IL_013f
		int num = 3;
		FileStream fileStream = default(FileStream);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 3:
					if (!CAo20JEAYZHGpkd5lsux(fullFileName))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
						{
							num2 = 2;
						}
						continue;
					}
					break;
				case 5:
					try
					{
						cacheFilesService.IncrementCacheFile(uid, fileStream, 0L);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
						return;
					}
					finally
					{
						int num4;
						if (fileStream == null)
						{
							num4 = 2;
							goto IL_00d9;
						}
						goto IL_010e;
						IL_00d9:
						switch (num4)
						{
						case 2:
							goto end_IL_00c4;
						case 1:
							goto end_IL_00c4;
						}
						goto IL_010e;
						IL_010e:
						((IDisposable)fileStream).Dispose();
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
						{
							num4 = 1;
						}
						goto IL_00d9;
						end_IL_00c4:;
					}
				case 1:
					return;
				case 4:
					break;
				default:
					goto end_IL_0012;
				}
				if (!OIL7AXE7Esgg8Zlg6GcD(cacheFilesService, uid, fileName))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			fileStream = new FileStream(fullFileName, FileMode.Open, FileAccess.Read);
			num = 5;
		}
	}

	private void AddToFile(string id, Stream stream)
	{
		//Discarded unreachable code: IL_006d, IL_007c, IL_01ce, IL_01d8, IL_0209
		int num = 11;
		long num3 = default(long);
		long bufferLength = default(long);
		long num4 = default(long);
		byte[] array = default(byte[]);
		long num6 = default(long);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				long num5;
				switch (num2)
				{
				case 12:
				case 16:
					if (num3 != 0L)
					{
						num2 = 7;
						continue;
					}
					goto case 8;
				default:
					if ((num3 + 1) * bufferLength >= num4)
					{
						num2 = 3;
						continue;
					}
					num5 = bufferLength;
					break;
				case 18:
					array = new byte[num6];
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 7;
					}
					continue;
				case 15:
					stream.Read(array, 0, array.Length);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 1;
					}
					continue;
				case 13:
					num4 = bLPoLdE7WxaX6WWCd6BN(stream);
					num2 = 9;
					continue;
				case 8:
					throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138667144)));
				case 7:
					return;
				case 14:
					if (num6 <= 0)
					{
						goto end_IL_0012;
					}
					goto case 18;
				case 5:
				case 17:
					if (num3 != long.MaxValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 12;
				case 11:
					num3 = 0L;
					num2 = 10;
					continue;
				case 4:
					num6 = bufferLength;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 13;
					}
					continue;
				case 2:
				case 9:
					if (num6 > 0)
					{
						num2 = 5;
						continue;
					}
					goto case 12;
				case 1:
					KWbyIqE7f8VGTgWebV18(this, id, array);
					num2 = 6;
					continue;
				case 3:
					num5 = num4 - num3 * bufferLength;
					break;
				case 10:
					bufferLength = GetBufferLength();
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					num3++;
					num2 = 2;
					continue;
				}
				num6 = num5;
				num2 = 14;
				continue;
				end_IL_0012:
				break;
			}
			num = 16;
		}
	}

	public override bool Exists(string id, string ext)
	{
		int num = 1;
		int num2 = num;
		string path = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (id == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					break;
				}
				path = (string)pZiuKWEAr0Nbao5LV8JT(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463A4D3E), id, ext ?? N6YhnjEA7Fbn2SUuq4Pd(-561074844 ^ -561366684));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return CAo20JEAYZHGpkd5lsux(Path.Combine(filesPath, path));
			default:
				return false;
			}
		}
	}

	public override bool Exists(string id)
	{
		return t0eHAjE7QWstdYkJOv14(this, id, null);
	}

	internal static void Wt4eU4EAACLqssGjEhUb()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool QDIGdgEA6hoXQ5M5CGrj()
	{
		return DTUCCsEA4sZiWfVCD1aY == null;
	}

	internal static ExportImportFileService VHhgXwEAHdaH1ss7ll4F()
	{
		return DTUCCsEA4sZiWfVCD1aY;
	}

	internal static object N6YhnjEA7Fbn2SUuq4Pd(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object FrHKhqEAxanR929xvqAX(object P_0)
	{
		return ((IRuntimeApplication)P_0).Configuration;
	}

	internal static object pkBrdaEA0IWh9aFFZhSY(object P_0)
	{
		return ((RuntimeConfiguration)P_0).Config;
	}

	internal static object wynmFpEAm5r1oKpQSDwf(object P_0)
	{
		return ((System.Configuration.Configuration)P_0).FilePath;
	}

	internal static object CaQPOpEAycWysp3eaG3r(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}

	internal static object lFqesbEAMuaHRNbBgfnf(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object Wl0EdYEAJyBhfxtmt9xD(object P_0)
	{
		return ((ExportImportFileServiceBase)P_0).GetFilesFolderPath();
	}

	internal static bool dRxLPnEA9XlPY7HCwWUP(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object U0g9eREAdUXBuv0P4Gdf(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static object OFs0xUEAl2KwanUODWWY(object P_0, object P_1, object P_2)
	{
		return ((ExportImportFileServiceBase)P_0).CreateZipFileName((string)P_1, (string)P_2);
	}

	internal static object pZiuKWEAr0Nbao5LV8JT(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object L6gpKbEAgXKlphmVpp1i(object P_0, object P_1, object P_2)
	{
		return ((ExportImportFileServiceBase)P_0).CreateDeployFolderName((string)P_1, (string)P_2);
	}

	internal static object RFZgmpEA5nyDVgqPZ13I(object P_0, object P_1)
	{
		return ((ExportImportFileServiceBase)P_0).CreateFolderName((string)P_1);
	}

	internal static object aNwwAaEAj1RLf5VHqmQW(object P_0, object P_1)
	{
		return ((ExportImportFileServiceBase)P_0).CreateZipFileName((string)P_1);
	}

	internal static bool CAo20JEAYZHGpkd5lsux(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object ArxwShEALwfyYcRrkGhY(object P_0)
	{
		return File.Create((string)P_0);
	}

	internal static void lCrMiuEAU0bcB0Ivmygr(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void WN3QYSEAsWPkJ44lRdXU(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static void tepa2xEAcJy0nsOKUm4k(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void ptth4aEAzHeiEV2hDrku(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5)
	{
		((ExportImportFileServiceBase)P_0).AddToNestedFile((string)P_1, (string)P_2, (string)P_3, (string)P_4, (byte[])P_5);
	}

	internal static object oMWFF7E7FW9Xaw2nDOgR(object P_0, object P_1, object P_2)
	{
		return Path.Combine((string)P_0, (string)P_1, (string)P_2);
	}

	internal static object AlhjZEE7BoSCDxnP10Lw(object P_0, object P_1, long i, object P_3)
	{
		return ((ExportImportFileServiceBase)P_0).LoadFile((string)P_1, i, (string)P_3);
	}

	internal static long bLPoLdE7WxaX6WWCd6BN(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static long YURYfBE7obyeNTmjPWTT(object P_0, long P_1, SeekOrigin P_2)
	{
		return ((Stream)P_0).Seek(P_1, P_2);
	}

	internal static void EcUmqkE7b5n5hREJdtUX(object P_0, object P_1, object P_2)
	{
		((ExportImportFileServiceBase)P_0).DeleteFiles((string)P_1, (string)P_2);
	}

	internal static void iwPJHaE7h5MGeNtSq9Dk(object P_0)
	{
		File.Delete((string)P_0);
	}

	internal static void lsWtmCE7GxXE3rW8lVcy(object P_0, bool P_1)
	{
		Directory.Delete((string)P_0, P_1);
	}

	internal static bool OIL7AXE7Esgg8Zlg6GcD(object P_0, Guid uid, object P_2)
	{
		return ((ICacheFilesService)P_0).CreateCacheFileByUid(uid, (string)P_2);
	}

	internal static void KWbyIqE7f8VGTgWebV18(object P_0, object P_1, object P_2)
	{
		((ExportImportFileServiceBase)P_0).AddToFile((string)P_1, (byte[])P_2);
	}

	internal static bool t0eHAjE7QWstdYkJOv14(object P_0, object P_1, object P_2)
	{
		return ((ExportImportFileServiceBase)P_0).Exists((string)P_1, (string)P_2);
	}
}
