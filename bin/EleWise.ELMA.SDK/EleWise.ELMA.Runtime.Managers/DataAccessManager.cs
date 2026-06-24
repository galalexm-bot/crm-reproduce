using EleWise.ELMA.Services;

namespace EleWise.ELMA.Runtime.Managers;

public static class DataAccessManager
{
	public static IBLOBDataManager _blobManager;

	public static ISettingsManager _settingsManager;

	public static IFileManager _fileManager;

	private static IBinaryFileStreams _binaryFileStreams;

	private static DataAccessManager TNMgIDW9Q7QpO210jpef;

	public static IBLOBDataManager BLOBManager
	{
		get
		{
			int num = 1;
			int num2 = num;
			IBLOBDataManager iBLOBDataManager;
			while (true)
			{
				switch (num2)
				{
				case 1:
					iBLOBDataManager = _blobManager;
					if (iBLOBDataManager == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					iBLOBDataManager = (_blobManager = Locator.GetServiceNotNull<IBLOBDataManager>());
					break;
				}
				break;
			}
			return iBLOBDataManager;
		}
	}

	public static ISettingsManager SettingsManager
	{
		get
		{
			int num = 1;
			int num2 = num;
			ISettingsManager settingsManager;
			while (true)
			{
				switch (num2)
				{
				case 1:
					settingsManager = _settingsManager;
					if (settingsManager == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					settingsManager = (_settingsManager = Locator.GetServiceNotNull<ISettingsManager>());
					break;
				}
				break;
			}
			return settingsManager;
		}
	}

	public static IFileManager FileManager
	{
		get
		{
			int num = 1;
			int num2 = num;
			IFileManager fileManager;
			while (true)
			{
				switch (num2)
				{
				case 1:
					fileManager = _fileManager;
					if (fileManager != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					fileManager = (_fileManager = Locator.GetServiceNotNull<IFileManager>());
					break;
				}
				break;
			}
			return fileManager;
		}
	}

	public static IBinaryFileStreams BinaryFileStreams
	{
		get
		{
			int num = 1;
			int num2 = num;
			IBinaryFileStreams binaryFileStreams;
			while (true)
			{
				switch (num2)
				{
				case 1:
					binaryFileStreams = _binaryFileStreams;
					if (binaryFileStreams == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					binaryFileStreams = (_binaryFileStreams = Locator.GetServiceNotNull<IBinaryFileStreams>());
					break;
				}
				break;
			}
			return binaryFileStreams;
		}
	}

	internal static bool Usds4IW9CdghjULuVurV()
	{
		return TNMgIDW9Q7QpO210jpef == null;
	}

	internal static DataAccessManager b0iFB7W9vP7ookbdH7K8()
	{
		return TNMgIDW9Q7QpO210jpef;
	}
}
