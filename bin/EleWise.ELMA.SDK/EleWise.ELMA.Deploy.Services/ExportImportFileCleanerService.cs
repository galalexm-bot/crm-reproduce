using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Actors;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Services;

[Service(Type = ComponentType.Server)]
internal class ExportImportFileCleanerService : IExportImportFileCleanerService
{
	private static readonly TimeSpan defaultStoreDuration;

	private string exportImportFilesDirectory;

	private static readonly string BLOBStoreKeyTemplate;

	private readonly IBLOBStore blobStore;

	private static ExportImportFileCleanerService eWHTsLE6bG8Mrj0OPsmo;

	public ExportImportFileCleanerService(IExportImportFileService exportImportFileService, IBLOBStore BLOBStore)
	{
		//Discarded unreachable code: IL_003a, IL_003f, IL_006a, IL_0079
		SingletonReader.JJCZtPuTvSt();
		exportImportFilesDirectory = "";
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 5:
				return;
			case 1:
				m1airjE6vB1kLZ0aGMHL(vAednlE6QIVbkCpok1Iy(), QK952kE6CDRiI41ot8rd(-1921202237 ^ -1921495781));
				num = 2;
				continue;
			case 2:
				throw new ArgumentException((string)pL6km3E68xDTpqgYQpLm(QK952kE6CDRiI41ot8rd(-70007027 ^ -69776301)));
			case 4:
				exportImportFilesDirectory = (string)OnjgKEE6EIMZaqqxpw2A(exportImportFileService);
				num = 3;
				continue;
			case 3:
				if (!LjCuM0E6fIJj7mjh3uRs(exportImportFilesDirectory))
				{
					num = 5;
					continue;
				}
				goto case 1;
			}
			blobStore = BLOBStore;
			num = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
			{
				num = 4;
			}
		}
	}

	public void Execute()
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
				Execute(defaultStoreDuration);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void Execute(TimeSpan storeDuration)
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
				CleanFiles(exportImportFilesDirectory, storeDuration);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void CleanFiles(string exportImportDirectory, TimeSpan storeDuration)
	{
		//Discarded unreachable code: IL_009e, IL_00a8, IL_019d, IL_01d5
		int num = 5;
		int num2 = num;
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		DateTime dateToDeleted = default(DateTime);
		string current = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				enumerator = GetConfigurationFiles(exportImportDirectory).GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				dateToDeleted = kHYQjhE6uWQS3jnSrJOw(fZ4xw2E6Z78JACHaiUQp(), storeDuration);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				if (!string.IsNullOrWhiteSpace(exportImportDirectory))
				{
					num2 = 4;
					break;
				}
				return;
			case 1:
				try
				{
					while (true)
					{
						IL_0120:
						int num3;
						if (!xPGOceE6IywMmg1XwEq0(enumerator))
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
							{
								num3 = 1;
							}
							goto IL_00ac;
						}
						goto IL_00e4;
						IL_00e4:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
						{
							num3 = 0;
						}
						goto IL_00ac;
						IL_00ac:
						while (true)
						{
							switch (num3)
							{
							case 5:
								DeleteFiles(current);
								num3 = 2;
								continue;
							case 6:
								break;
							default:
								if (IsNeedDelete(current, dateToDeleted))
								{
									num3 = 3;
									continue;
								}
								goto IL_0120;
							case 2:
								goto IL_0120;
							case 4:
								DeleteBLOBStoreConfigurationData(GetBLOBStoreKey(current));
								num3 = 5;
								continue;
							case 3:
								DeleteDirectory(GetDirectoryName(exportImportDirectory, current));
								num3 = 4;
								continue;
							case 1:
								return;
							}
							break;
						}
						goto IL_00e4;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								NqNIk0E6VUdh2OianPr3(enumerator);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
								{
									num4 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 4:
				if (Directory.Exists(exportImportDirectory))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 2:
				return;
			}
		}
	}

	private bool IsNeedDelete(string fullName, DateTime dateToDeleted)
	{
		int num = 1;
		int num2 = num;
		FileInfo fileInfo = default(FileInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
				fileInfo = new FileInfo(fullName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return jSQyjoE6i2wlHOasJwZY(IUqdxuE6SnBGnTA43R4M(fileInfo), dateToDeleted);
			}
			if (fileInfo.Exists)
			{
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			return false;
		}
	}

	private string GetBLOBStoreKey(string fullFileName)
	{
		return (string)LER4JiE6qWVSn8sruNbm(BLOBStoreKeyTemplate, r9LI6fE6RDduKF0jXLV0(fullFileName));
	}

	private void DeleteBLOBStoreConfigurationData(string storeKey)
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
				jRuM9LE6KVqeSrOIXEtU(blobStore, storeKey);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private IEnumerable<string> GetConfigurationFiles(string exportImportDirectory)
	{
		IEnumerable<string> files = Directory.GetFiles(exportImportDirectory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x74115E0), SearchOption.TopDirectoryOnly);
		string[] supportedComponentMask = ElmaStoreComponentFile.SupportedComponentMask;
		foreach (string searchPattern in supportedComponentMask)
		{
			files.Concat(Directory.GetFiles(exportImportDirectory, searchPattern, SearchOption.TopDirectoryOnly));
		}
		return files;
	}

	private void DeleteFiles(string fullFileName)
	{
		//Discarded unreachable code: IL_008f, IL_00e7, IL_017a, IL_0189
		int num = 1;
		int num2 = num;
		FileInfo fileInfo = default(FileInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
				fileInfo = new FileInfo(fullFileName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			try
			{
				((ILogger)vAednlE6QIVbkCpok1Iy()).InfoFormat((string)QK952kE6CDRiI41ot8rd(0x1DE3DD89 ^ 0x1DE2B93F), fullFileName);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						return;
					}
					B8pmJWE6XVFVJkU9htFK(fileInfo);
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num3 = 1;
					}
				}
			}
			catch (Exception exception)
			{
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num4 = 0;
				}
				while (true)
				{
					switch (num4)
					{
					default:
						m1airjE6vB1kLZ0aGMHL(vAednlE6QIVbkCpok1Iy(), pL6km3E68xDTpqgYQpLm(QK952kE6CDRiI41ot8rd(0x269E5FCA ^ 0x269AD43E)));
						num4 = 2;
						break;
					case 2:
						((ILogger)vAednlE6QIVbkCpok1Iy()).Warn(exception, SR.T((string)QK952kE6CDRiI41ot8rd(-16752921 ^ -16461105), fullFileName));
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num4 = 1;
						}
						break;
					case 1:
						return;
					}
				}
			}
		}
	}

	private string GetDirectoryName(string exportImportDirectory, string fullFileName)
	{
		return Path.Combine(exportImportDirectory, Path.GetFileNameWithoutExtension(fullFileName));
	}

	private void DeleteDirectory(string directoryName)
	{
		//Discarded unreachable code: IL_008f, IL_0198, IL_01a7
		int num = 1;
		int num2 = num;
		DirectoryInfo directoryInfo = default(DirectoryInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
				directoryInfo = new DirectoryInfo(directoryName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			try
			{
				Logger.Log.InfoFormat((string)QK952kE6CDRiI41ot8rd(0x4D1C1EE4 ^ 0x4D189280), directoryName);
				int num3 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					default:
						HH5E54E6kV907QgAiD3e(directoryInfo, true);
						num3 = 2;
						break;
					case 1:
						if (Q3QPWxE6TMmmrVFmKIaq(directoryInfo))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
							{
								num3 = 0;
							}
							break;
						}
						return;
					case 2:
						return;
					}
				}
			}
			catch (Exception exception)
			{
				int num4 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num4 = 1;
				}
				while (true)
				{
					switch (num4)
					{
					case 1:
						m1airjE6vB1kLZ0aGMHL(vAednlE6QIVbkCpok1Iy(), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951220878)));
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num4 = 0;
						}
						break;
					default:
					{
						Logger.Log.Warn(exception, SR.T((string)QK952kE6CDRiI41ot8rd(0xD3DEF7E ^ 0xD3963AA), directoryName));
						int num5 = 2;
						num4 = num5;
						break;
					}
					case 2:
						return;
					}
				}
			}
		}
	}

	static ExportImportFileCleanerService()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			default:
				defaultStoreDuration = TimeSpan.FromDays(2.0);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				wc6Z1kE6npWo5YYsPfsF();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				BLOBStoreKeyTemplate = (string)DRD6SvE6OKb9C4iuxoqX(ConfigurationTestActor.TestDataKey, QK952kE6CDRiI41ot8rd(-309639236 ^ -309656522));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	internal static object OnjgKEE6EIMZaqqxpw2A(object P_0)
	{
		return ((IExportImportFileService)P_0).GetFilesFolderPath();
	}

	internal static bool LjCuM0E6fIJj7mjh3uRs(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object vAednlE6QIVbkCpok1Iy()
	{
		return Logger.Log;
	}

	internal static object QK952kE6CDRiI41ot8rd(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void m1airjE6vB1kLZ0aGMHL(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static object pL6km3E68xDTpqgYQpLm(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool apbsm2E6hJN9kHpclAV3()
	{
		return eWHTsLE6bG8Mrj0OPsmo == null;
	}

	internal static ExportImportFileCleanerService hmUNONE6GQxvRjx8sqmK()
	{
		return eWHTsLE6bG8Mrj0OPsmo;
	}

	internal static DateTime fZ4xw2E6Z78JACHaiUQp()
	{
		return DateTime.Now;
	}

	internal static DateTime kHYQjhE6uWQS3jnSrJOw(DateTime P_0, TimeSpan P_1)
	{
		return P_0 - P_1;
	}

	internal static bool xPGOceE6IywMmg1XwEq0(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void NqNIk0E6VUdh2OianPr3(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static DateTime IUqdxuE6SnBGnTA43R4M(object P_0)
	{
		return ((FileSystemInfo)P_0).LastWriteTime;
	}

	internal static bool jSQyjoE6i2wlHOasJwZY(DateTime P_0, DateTime P_1)
	{
		return P_0 < P_1;
	}

	internal static object r9LI6fE6RDduKF0jXLV0(object P_0)
	{
		return Path.GetFileNameWithoutExtension((string)P_0);
	}

	internal static object LER4JiE6qWVSn8sruNbm(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void jRuM9LE6KVqeSrOIXEtU(object P_0, object P_1)
	{
		((IBLOBStore)P_0).Remove((string)P_1);
	}

	internal static void B8pmJWE6XVFVJkU9htFK(object P_0)
	{
		((FileSystemInfo)P_0).Delete();
	}

	internal static bool Q3QPWxE6TMmmrVFmKIaq(object P_0)
	{
		return ((FileSystemInfo)P_0).Exists;
	}

	internal static void HH5E54E6kV907QgAiD3e(object P_0, bool P_1)
	{
		((DirectoryInfo)P_0).Delete(P_1);
	}

	internal static void wc6Z1kE6npWo5YYsPfsF()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object DRD6SvE6OKb9C4iuxoqX(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}
}
