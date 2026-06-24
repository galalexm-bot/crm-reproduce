using System.Runtime.CompilerServices;

namespace EleWise.ELMA.Runtime.Db;

public struct BackupParameters
{
	internal static object KynumVWuI3F2yuHAvu1H;

	public bool MainDatabase
	{
		[CompilerGenerated]
		get
		{
			return _003CMainDatabase_003Ek__BackingField;
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
					_003CMainDatabase_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public static BackupParameters OnlyMainDatabase
	{
		get
		{
			int num = 2;
			int num2 = num;
			BackupParameters result = default(BackupParameters);
			while (true)
			{
				switch (num2)
				{
				default:
					return result;
				case 2:
					result = default(BackupParameters);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					result.MainDatabase = true;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	internal static bool YCa1UpWuVEitO4tGZcfb()
	{
		return KynumVWuI3F2yuHAvu1H == null;
	}

	internal static object HbHgcJWuSniowQpwtr5t()
	{
		return KynumVWuI3F2yuHAvu1H;
	}
}
