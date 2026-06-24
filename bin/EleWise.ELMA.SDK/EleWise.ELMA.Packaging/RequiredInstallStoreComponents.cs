using System;
using System.Collections.Generic;
using System.Linq;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Packaging;

[Serializable]
public class RequiredInstallStoreComponentsException : Exception
{
	private IEnumerable<IStoreComponentInfo> _componentsInfo;

	internal static RequiredInstallStoreComponentsException hsNVaOBnweMgbCUcKmJP;

	public IEnumerable<IStoreComponentInfo> ComponentsInfo => _componentsInfo;

	public RequiredInstallStoreComponentsException()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		EaFrtmBnHdL4wOqPNUrf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public RequiredInstallStoreComponentsException(IEnumerable<IStoreComponentInfo> componentsInfo)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218463814), string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F4DFDF1), componentsInfo.Select((IStoreComponentInfo c) => string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A09D37), _003C_003Ec.RddKKHQVqZHeMtbejUf8(_003C_003Ec.kNUx5BQVRVCZXtVaZTF0(c)), _003C_003Ec.El49gQQVT32Pp68uWOuD(c.Id, _003C_003Ec.IRKLTjQVK9WIAPYHmHOa(-1824388195 ^ -1824374081), _003C_003Ec.rsTBRmQVXxiamXLBv7GH(c)))))));
		if (componentsInfo == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70090992));
		}
		_componentsInfo = componentsInfo;
	}

	internal static void EaFrtmBnHdL4wOqPNUrf()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool mUh3mmBn4GlsjwCZMRgP()
	{
		return hsNVaOBnweMgbCUcKmJP == null;
	}

	internal static RequiredInstallStoreComponentsException kotQBJBn6YnjUTZ8MCcA()
	{
		return hsNVaOBnweMgbCUcKmJP;
	}
}
