using System;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Views;

public class ViewItemTypeInfo
{
	private Type viewItemType;

	internal string name;

	internal string originalName;

	private static ViewItemTypeInfo U80R0poPqN5uhtTCJoVD;

	public Type ViewItemType => viewItemType;

	public string Name
	{
		get
		{
			int num = 1;
			int num2 = num;
			string text;
			while (true)
			{
				switch (num2)
				{
				case 1:
					text = name;
					if (text == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					text = originalName;
					break;
				}
				break;
			}
			return text;
		}
	}

	public ViewItemTypeInfo(Type viewItemType)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		IFs2XmoPTtWbUAMuar1H();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
		{
			num = 0;
		}
		ClassMetadata classMetadata = default(ClassMetadata);
		while (true)
		{
			switch (num)
			{
			case 2:
				originalName = (string)zKLAhpoPncP5NfhbaXpS(classMetadata);
				num = 4;
				continue;
			case 3:
				throw new ArgumentNullException((string)l8wVswoPkHMG1pjDvofH(0x31326106 ^ 0x313002A0));
			case 1:
				classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(viewItemType);
				num = 2;
				continue;
			case 4:
				return;
			}
			if (!(viewItemType == null))
			{
				this.viewItemType = viewItemType;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num = 1;
				}
			}
			else
			{
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num = 3;
				}
			}
		}
	}

	internal static void IFs2XmoPTtWbUAMuar1H()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object l8wVswoPkHMG1pjDvofH(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object zKLAhpoPncP5NfhbaXpS(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static bool SJNiXuoPKMoCDx4yKCw7()
	{
		return U80R0poPqN5uhtTCJoVD == null;
	}

	internal static ViewItemTypeInfo Fm8uIkoPXIVN4OCkEbwo()
	{
		return U80R0poPqN5uhtTCJoVD;
	}
}
