using System;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class IdTypeAttribute : Attribute
{
	private Guid typeUid;

	private static IdTypeAttribute DWiKjYo8nVeAcNfSl5rR;

	public Guid TypeUid => typeUid;

	public IdTypeAttribute(string typeUid)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		rF2lGXo8eLnNinl70F1j();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				this.typeUid = new Guid(typeUid);
				num = 2;
				continue;
			}
			Contract.ArgumentNotNull(typeUid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751289120));
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
			{
				num = 1;
			}
		}
	}

	internal static void rF2lGXo8eLnNinl70F1j()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Jp9laQo8Ogtyp9Ftadp3()
	{
		return DWiKjYo8nVeAcNfSl5rR == null;
	}

	internal static IdTypeAttribute YxqO3ho82Jl2eQdEWpQv()
	{
		return DWiKjYo8nVeAcNfSl5rR;
	}
}
