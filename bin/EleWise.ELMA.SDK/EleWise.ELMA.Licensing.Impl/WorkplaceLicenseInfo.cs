using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Licensing.Impl;

public class WorkplaceLicenseInfo : LicenseInfo, IWorkplaceLicenseInfo, ILicenseInfo
{
	internal static WorkplaceLicenseInfo gYgWXV7jsgoSFPTQWYE;

	public uint? WorkplaceCount { get; set; }

	public uint UsedLicenseCount
	{
		get
		{
			//Discarded unreachable code: IL_006a, IL_0079
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (base.Owner is IWorkplaceLicenseInfoOwner)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return 0u;
				default:
					return ((IWorkplaceLicenseInfoOwner)base.Owner).UsedLicenseCount;
				}
			}
		}
	}

	public WorkplaceLicenseInfo(object owner)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		OWntKT7UOqBSAVPpGeP();
		base._002Ector(owner);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void OWntKT7UOqBSAVPpGeP()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool tqWFDf7Yqe3X9KVrRng()
	{
		return gYgWXV7jsgoSFPTQWYE == null;
	}

	internal static WorkplaceLicenseInfo Kb5QeC7LZjZejTRI4UK()
	{
		return gYgWXV7jsgoSFPTQWYE;
	}
}
