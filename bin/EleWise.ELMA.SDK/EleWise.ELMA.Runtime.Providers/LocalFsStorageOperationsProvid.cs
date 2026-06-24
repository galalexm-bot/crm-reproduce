using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Providers.Impl;

internal class LocalFsStorageOperationsProvider : IStorageOperationsProvider
{
	private readonly ILogger logger;

	private readonly ILocationSchema locationSchema;

	private static LocalFsStorageOperationsProvider Jl3V1sWfU9h0YHy9BU56;

	public LocalFsStorageOperationsProvider(ILogger logger, ILocationSchema locationSchema)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		htk39nWfzQXlVC86FrPl();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				this.locationSchema = locationSchema;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num = 1;
				}
				break;
			default:
				this.logger = logger;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	public Uri GetSourceContentLocation(SystemFile systemFile)
	{
		return (Uri)JkXKXaWQFNmPyDUglE9o(locationSchema, systemFile);
	}

	public void FetchContent(SystemFile systemFile)
	{
	}

	public Task FetchContentAsync(SystemFile systemFile, CancellationToken token)
	{
		return CompletedTask.Default;
	}

	public BinaryFileContentInfo DecryptContent(SystemFile systemFile, string password)
	{
		int num = 2;
		int num2 = num;
		Uri uri2 = default(Uri);
		string text = default(string);
		Uri uri = default(Uri);
		Guid guid = default(Guid);
		while (true)
		{
			switch (num2)
			{
			case 4:
				hsmTOqWQCIicD2jmHIfp(uri2.LocalPath, text, w4IkjxWQQ261bRjWYBFu(systemFile), password);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				text = (string)zaqd8TWQfummUFplwpA6(uri);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				guid = pYim0sWQW8kn01CnTqA5();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 6;
				}
				break;
			case 2:
				uri2 = (Uri)JkXKXaWQFNmPyDUglE9o(locationSchema, systemFile);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				uri = (Uri)eHmSanWQEtc86D51rqVc(locationSchema, guid.ToString((string)BPulnsWQoNb2kpkZOTao(-218496594 ^ -218467936)), tOGJ1xWQGOXsLbHOdctB(JTxGXMWQhguhC6AX4aAP(HGOC8kWQbTBmwkb1pJy2(systemFile))));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				ValidateContent(uri2, (string)q5QX0gWQBfFFgMaDcoj9(systemFile));
				num2 = 5;
				break;
			default:
			{
				BinaryFileContentInfo binaryFileContentInfo = new BinaryFileContentInfo();
				oasiL0WQvXh8sRxX27GN(binaryFileContentInfo, uri);
				xDEEJYWQZDTBO9jesloQ(binaryFileContentInfo, cNthweWQ8RZ3xiKTfQb5(new FileInfo(text)));
				DvVkiOWQIFx4JAsU8PtM(binaryFileContentInfo, UUgk17WQuQyTN3Gvegh3(text));
				return binaryFileContentInfo;
			}
			}
		}
	}

	public BinaryFileContentInfo EncryptContent(SystemFile systemFile, string password)
	{
		int num = 4;
		int num2 = num;
		Uri uri2 = default(Uri);
		string text = default(string);
		Uri uri = default(Uri);
		Guid guid = default(Guid);
		while (true)
		{
			switch (num2)
			{
			default:
				oplrejWQVmtyd9CflQlu(zaqd8TWQfummUFplwpA6(uri2), text, w4IkjxWQQ261bRjWYBFu(systemFile), password);
				num2 = 5;
				break;
			case 4:
				uri2 = (Uri)JkXKXaWQFNmPyDUglE9o(locationSchema, systemFile);
				num2 = 3;
				break;
			case 5:
			{
				BinaryFileContentInfo binaryFileContentInfo = new BinaryFileContentInfo();
				oasiL0WQvXh8sRxX27GN(binaryFileContentInfo, uri);
				xDEEJYWQZDTBO9jesloQ(binaryFileContentInfo, cNthweWQ8RZ3xiKTfQb5(new FileInfo(text)));
				DvVkiOWQIFx4JAsU8PtM(binaryFileContentInfo, UUgk17WQuQyTN3Gvegh3(text));
				return binaryFileContentInfo;
			}
			case 3:
				ValidateContent(uri2, (string)q5QX0gWQBfFFgMaDcoj9(systemFile));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				guid = Guid.NewGuid();
				num2 = 2;
				break;
			case 2:
				uri = (Uri)eHmSanWQEtc86D51rqVc(locationSchema, guid.ToString((string)BPulnsWQoNb2kpkZOTao(0x34185E55 ^ 0x34182E5B)), tOGJ1xWQGOXsLbHOdctB(JTxGXMWQhguhC6AX4aAP(HGOC8kWQbTBmwkb1pJy2(systemFile))));
				num2 = 6;
				break;
			case 6:
				text = (string)zaqd8TWQfummUFplwpA6(uri);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public long? GetContentSize(SystemFile systemFile)
	{
		FileInfo fileInfo = new FileInfo(locationSchema.MapPersistentLocation(systemFile).LocalPath);
		if (!fileInfo.Exists)
		{
			return null;
		}
		return fileInfo.Length;
	}

	public Stream OpenTempContentWriteStream(Action<Uri> contentInfoHandler, PutContentOptions options)
	{
		Contract.ArgumentNotNull(options, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x1245BA86));
		Uri uri = locationSchema.CreateNewTempLocation(options.Extension);
		contentInfoHandler(uri);
		string localPath = uri.LocalPath;
		if (File.Exists(localPath))
		{
			File.Delete(localPath);
		}
		return OpenWriteFileStream(localPath, options.ForAsync);
	}

	public Stream OpenPersistentContentReadStream(SystemFile systemFile, GetContentOptions options)
	{
		int num = 1;
		int num2 = num;
		Uri uri = default(Uri);
		while (true)
		{
			switch (num2)
			{
			case 1:
				uri = (Uri)JkXKXaWQFNmPyDUglE9o(locationSchema, systemFile);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 0;
				}
				break;
			default:
				ValidateContent(uri, (string)q5QX0gWQBfFFgMaDcoj9(systemFile));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return OpenReadFileStream((string)zaqd8TWQfummUFplwpA6(uri), options.ForAsync);
			}
		}
	}

	public Stream OpenTempContentReadStream(Uri contentLocation, GetContentOptions options)
	{
		return OpenReadFileStream(contentLocation.LocalPath, IDmOV4WQSMlgbXcfrOuL(options));
	}

	public Uri SaveContent(Uri srcLocation, SystemFile systemFile, bool deleteSourceAfterSave = false)
	{
		//Discarded unreachable code: IL_010a, IL_011d, IL_01c9, IL_0221, IL_026a
		int num = 6;
		int num2 = num;
		string localPath = default(string);
		string text = default(string);
		Uri uri = default(Uri);
		while (true)
		{
			switch (num2)
			{
			case 10:
				SxPG5sWQqZT8m3pKfI5y(localPath, text, true);
				num2 = 11;
				break;
			case 5:
				localPath = srcLocation.LocalPath;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 1;
				}
				break;
			case 11:
				if (deleteSourceAfterSave)
				{
					num2 = 9;
					break;
				}
				goto default;
			case 3:
				if (!oQFAtMWQRAJaJWNdhsIR(localPath))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 8;
			case 4:
				if (!r91FSWWQiSZC7PwGdmmW(srcLocation, uri))
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 7;
					}
					break;
				}
				goto case 3;
			case 1:
				text = (string)zaqd8TWQfummUFplwpA6(uri);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 4;
				}
				break;
			default:
				return uri;
			case 8:
				logger.InfoFormat((string)BPulnsWQoNb2kpkZOTao(0x48A7E34A ^ 0x48A6457E), srcLocation, uri);
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
				{
					num2 = 7;
				}
				break;
			case 6:
				uri = (Uri)JkXKXaWQFNmPyDUglE9o(locationSchema, systemFile);
				num2 = 5;
				break;
			case 9:
				try
				{
					logger.InfoFormat((string)BPulnsWQoNb2kpkZOTao(0x76DD48E ^ 0x76C72E2), srcLocation);
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							return uri;
						case 0:
							return uri;
						case 1:
							MiTkhNWQKawBmIcmChEX(localPath);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				}
				catch (Exception ex)
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							return uri;
						case 0:
							return uri;
						case 1:
							logger.Error(bI9ugJWQXIsakqC6vsmo(ex), ex);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
							{
								num4 = 0;
							}
							break;
						}
					}
				}
			}
		}
	}

	public string GetContentHash(SystemFile systemFile, HashAlogrithmEnum hashAlgorithm)
	{
		//Discarded unreachable code: IL_004f, IL_0087, IL_00a6, IL_00b5, IL_00d2, IL_00e1
		int num = 1;
		int num2 = num;
		Stream stream = default(Stream);
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 1:
				stream = OpenPersistentContentReadStream(systemFile, GetContentOptions.NonSeekable);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				result = (string)YwPj8CWQTKl6JGBNaxa8(stream);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
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
				if (stream == null)
				{
					num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num4 = 1;
					}
					goto IL_008b;
				}
				goto IL_00c0;
				IL_00c0:
				RDZLgMWQkaRp7XKiatOw(stream);
				num4 = 2;
				goto IL_008b;
				IL_008b:
				switch (num4)
				{
				case 1:
					goto end_IL_0066;
				case 2:
					goto end_IL_0066;
				}
				goto IL_00c0;
				end_IL_0066:;
			}
		}
	}

	public Task<string> GetContentHashAsync(SystemFile systemFile, HashAlogrithmEnum hashAlgorithm, CancellationToken token)
	{
		_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.systemFile = systemFile;
		CS_0024_003C_003E8__locals0.hashAlgorithm = hashAlgorithm;
		return Task.Factory.StartNew(() => CS_0024_003C_003E8__locals0._003C_003E4__this.GetContentHash(CS_0024_003C_003E8__locals0.systemFile, CS_0024_003C_003E8__locals0.hashAlgorithm), token, TaskCreationOptions.LongRunning, TaskScheduler.Current);
	}

	private void ValidateContent(Uri location, string crcStr)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				throw new InvalidDataException(SR.T((string)BPulnsWQoNb2kpkZOTao(-583745292 ^ -583702566), location));
			case 1:
			{
				if (!uint.TryParse(crcStr, out var result))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 0;
					}
					break;
				}
				if (UUgk17WQuQyTN3Gvegh3(zaqd8TWQfummUFplwpA6(location)) == result)
				{
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 1;
				}
				break;
			}
			default:
				throw new InvalidDataException((string)T7uVdCWQnSdKmrZXBNLA(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099645965)));
			}
		}
	}

	private Stream OpenReadFileStream(string path, bool forAsync)
	{
		//Discarded unreachable code: IL_005e, IL_006d
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (forAsync)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return (Stream)oaZgGnWQOjhPLBuSN7Ra(path, FileMode.Open, FileAccess.Read, FileShare.Read);
			case 1:
				return FileAsync.OpenRead(path);
			}
		}
	}

	private Stream OpenWriteFileStream(string path, bool forAsync)
	{
		//Discarded unreachable code: IL_005d, IL_006c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return (Stream)Jy2riWWQ2Ss8u5o1hFho(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
			default:
				return (Stream)SkpIm6WQeGAiRXl7gfYY(path);
			case 1:
				if (forAsync)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	internal static void htk39nWfzQXlVC86FrPl()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool SfuPCqWfsQa9UPIRyBoU()
	{
		return Jl3V1sWfU9h0YHy9BU56 == null;
	}

	internal static LocalFsStorageOperationsProvider Lo4snBWfctlllRtagYtE()
	{
		return Jl3V1sWfU9h0YHy9BU56;
	}

	internal static object JkXKXaWQFNmPyDUglE9o(object P_0, object P_1)
	{
		return ((ILocationSchema)P_0).MapPersistentLocation((SystemFile)P_1);
	}

	internal static object q5QX0gWQBfFFgMaDcoj9(object P_0)
	{
		return ((SystemFile)P_0).FileCrc;
	}

	internal static Guid pYim0sWQW8kn01CnTqA5()
	{
		return Guid.NewGuid();
	}

	internal static object BPulnsWQoNb2kpkZOTao(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object HGOC8kWQbTBmwkb1pJy2(object P_0)
	{
		return ((SystemFile)P_0).Name;
	}

	internal static object JTxGXMWQhguhC6AX4aAP(object P_0)
	{
		return ((string)P_0).ReplaceInvalidFileNameChars();
	}

	internal static object tOGJ1xWQGOXsLbHOdctB(object P_0)
	{
		return Path.GetExtension((string)P_0);
	}

	internal static object eHmSanWQEtc86D51rqVc(object P_0, object P_1, object P_2)
	{
		return ((ILocationSchema)P_0).MapTempLocation((string)P_1, (string)P_2);
	}

	internal static object zaqd8TWQfummUFplwpA6(object P_0)
	{
		return ((Uri)P_0).LocalPath;
	}

	internal static object w4IkjxWQQ261bRjWYBFu(object P_0)
	{
		return ((SystemFile)P_0).Salt;
	}

	internal static void hsmTOqWQCIicD2jmHIfp(object P_0, object P_1, object P_2, object P_3)
	{
		EncryptionHelper.DecryptFile((string)P_0, (string)P_1, (string)P_2, (string)P_3);
	}

	internal static void oasiL0WQvXh8sRxX27GN(object P_0, object P_1)
	{
		((BinaryFileContentInfo)P_0).ContentLocation = (Uri)P_1;
	}

	internal static long cNthweWQ8RZ3xiKTfQb5(object P_0)
	{
		return ((FileInfo)P_0).Length;
	}

	internal static void xDEEJYWQZDTBO9jesloQ(object P_0, long value)
	{
		((BinaryFileContentInfo)P_0).ContentLength = value;
	}

	internal static uint UUgk17WQuQyTN3Gvegh3(object P_0)
	{
		return Crc32.GetCrcValue((string)P_0);
	}

	internal static void DvVkiOWQIFx4JAsU8PtM(object P_0, uint value)
	{
		((BinaryFileContentInfo)P_0).Crc = value;
	}

	internal static void oplrejWQVmtyd9CflQlu(object P_0, object P_1, object P_2, object P_3)
	{
		EncryptionHelper.EncryptFile((string)P_0, (string)P_1, (string)P_2, (string)P_3);
	}

	internal static bool IDmOV4WQSMlgbXcfrOuL(object P_0)
	{
		return ((GetContentOptions)P_0).ForAsync;
	}

	internal static bool r91FSWWQiSZC7PwGdmmW(object P_0, object P_1)
	{
		return (Uri)P_0 != (Uri)P_1;
	}

	internal static bool oQFAtMWQRAJaJWNdhsIR(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static void SxPG5sWQqZT8m3pKfI5y(object P_0, object P_1, bool P_2)
	{
		File.Copy((string)P_0, (string)P_1, P_2);
	}

	internal static void MiTkhNWQKawBmIcmChEX(object P_0)
	{
		File.Delete((string)P_0);
	}

	internal static object bI9ugJWQXIsakqC6vsmo(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static object YwPj8CWQTKl6JGBNaxa8(object P_0)
	{
		return EncryptionHelper.GetMd5Hash((Stream)P_0);
	}

	internal static void RDZLgMWQkaRp7XKiatOw(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object T7uVdCWQnSdKmrZXBNLA(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object oaZgGnWQOjhPLBuSN7Ra(object P_0, FileMode P_1, FileAccess P_2, FileShare P_3)
	{
		return File.Open((string)P_0, P_1, P_2, P_3);
	}

	internal static object Jy2riWWQ2Ss8u5o1hFho(object P_0, FileMode P_1, FileAccess P_2)
	{
		return File.Open((string)P_0, P_1, P_2);
	}

	internal static object SkpIm6WQeGAiRXl7gfYY(object P_0)
	{
		return FileAsync.OpenWrite((string)P_0);
	}
}
