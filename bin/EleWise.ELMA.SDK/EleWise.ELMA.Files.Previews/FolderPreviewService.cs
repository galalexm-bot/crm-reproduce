using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Files.Previews;

[Service]
internal class FolderPreviewService : IFolderPreviewService
{
	private IFileManager fileManager;

	internal static FolderPreviewService wfuOgPGOJTaEyhf5fyfH;

	public IFileManager FileManager
	{
		get
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (fileManager == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 1:
					fileManager = Locator.GetServiceNotNull<IFileManager>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			return fileManager;
		}
	}

	public IRuntimeApplication RuntimeApplication
	{
		[CompilerGenerated]
		get
		{
			return _003CRuntimeApplication_003Ek__BackingField;
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
					_003CRuntimeApplication_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string PreviewsPath
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return (string)K8xPFEGOgROKBeAnCpdU(FileManager);
				case 4:
					return string.Empty;
				default:
					if (CWT1hEGOln2cS5OpAiqB(RuntimeApplication) != null)
					{
						if (!DirectoryCreated)
						{
							num2 = 3;
							break;
						}
						goto case 5;
					}
					num2 = 4;
					break;
				case 3:
					pnxtNDGOrUPxBXwS0x0Q(FileManager.PreviewsPath);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					if (RuntimeApplication != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 4;
				case 2:
					DirectoryCreated = true;
					num2 = 5;
					break;
				}
			}
		}
	}

	private bool DirectoryCreated
	{
		[CompilerGenerated]
		get
		{
			return _003CDirectoryCreated_003Ek__BackingField;
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
					_003CDirectoryCreated_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string GetPreviewDirectory(Guid id)
	{
		//Discarded unreachable code: IL_0039, IL_0048
		int num = 4;
		int num2 = num;
		string pathPreviewByHash = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (GKX7lgGOjWFhlKe67gBA(pathPreviewByHash))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			default:
				return pathPreviewByHash;
			case 4:
				Contract.CheckWithMessage<InvalidOperationException>(xkg13UGO504U0C2imarU(id, Guid.Empty), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138201920));
				num2 = 3;
				break;
			case 1:
				pnxtNDGOrUPxBXwS0x0Q(pathPreviewByHash);
				num2 = 5;
				break;
			case 3:
				pathPreviewByHash = GetPathPreviewByHash(PreviewsPath, id);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	private string GetPathPreviewByHash(string pathRoot, Guid guid)
	{
		//Discarded unreachable code: IL_0053, IL_008b, IL_00c3, IL_00d2
		int num = 2;
		int num2 = num;
		byte[] byteArray = default(byte[]);
		SHA1 sHA = default(SHA1);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					byteArray = (byte[])CnqjLYGOYyFj7P9TcX0m(sHA, guid.ToByteArray());
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				finally
				{
					if (sHA != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								MuXGgQGOLwyYOvpqo2iB(sHA);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
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
				goto default;
			default:
				return Path.Combine(GetPathPreview(pathRoot, byteArray), guid.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A6145B0)));
			case 2:
				sHA = SHA1.Create();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private string GetPathPreview(string pathRoot, byte[] byteArray)
	{
		return (string)hp2yZXGOUeKp7ELfrKK2(hp2yZXGOUeKp7ELfrKK2(hp2yZXGOUeKp7ELfrKK2(hp2yZXGOUeKp7ELfrKK2(pathRoot, GetLevel(byteArray, 0, 1)), GetLevel(byteArray, 1, 1)), GetLevel(byteArray, 2, 1)), GetLevel(byteArray, 3, 1));
	}

	private string GetLevel(byte[] hash, int v1, int v2)
	{
		return (string)tWWQecGOcVkWG30FFZrR(jUgSWSGOslBYxJ6sVBZq(hash, v1, v2), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852834712), "");
	}

	public FolderPreviewService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		q9d100GOz8kMNymsROAc();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool sSvUg0GO9SMRCpqkeVgQ()
	{
		return wfuOgPGOJTaEyhf5fyfH == null;
	}

	internal static FolderPreviewService rG1ktWGOdTgC4G3nqMO3()
	{
		return wfuOgPGOJTaEyhf5fyfH;
	}

	internal static object CWT1hEGOln2cS5OpAiqB(object P_0)
	{
		return ((IRuntimeApplication)P_0).Configuration;
	}

	internal static object pnxtNDGOrUPxBXwS0x0Q(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static object K8xPFEGOgROKBeAnCpdU(object P_0)
	{
		return ((IFileManager)P_0).PreviewsPath;
	}

	internal static bool xkg13UGO504U0C2imarU(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static bool GKX7lgGOjWFhlKe67gBA(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object CnqjLYGOYyFj7P9TcX0m(object P_0, object P_1)
	{
		return ((HashAlgorithm)P_0).ComputeHash((byte[])P_1);
	}

	internal static void MuXGgQGOLwyYOvpqo2iB(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object hp2yZXGOUeKp7ELfrKK2(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object jUgSWSGOslBYxJ6sVBZq(object P_0, int P_1, int P_2)
	{
		return BitConverter.ToString((byte[])P_0, P_1, P_2);
	}

	internal static object tWWQecGOcVkWG30FFZrR(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static void q9d100GOz8kMNymsROAc()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
