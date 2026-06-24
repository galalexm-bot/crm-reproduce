using System;
using System.Collections.Generic;
using Aspose.Words;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Files.Previews;

[Component(Order = 100)]
public class WordFilePreviewCreator : BasePasswordFilePreviewCreatorEx
{
	public static Guid UID;

	private static WordFilePreviewCreator CiO2HMG3bp0SeRdfycSh;

	public override Guid Uid => UID;

	public override string DisplayName => (string)WQEQggG3frt30pGqH0sY(va53OfG3Epk9P1hLZAu5(0x49E27B8A ^ 0x49E18E00));

	public override List<string> Extensions => new List<string>
	{
		z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC00714),
		z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521184016),
		z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195663411),
		z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -575974886),
		z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561162070),
		z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112798388)
	};

	public override string ExternalCreatorFileName => (string)va53OfG3Epk9P1hLZAu5(-488881205 ^ -488655315);

	public override bool CheckPassword(BinaryFile file, string password)
	{
		//Discarded unreachable code: IL_008c, IL_009b, IL_00c4, IL_0138, IL_018b, IL_01c3, IL_01d2, IL_01e2, IL_01f1
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		int num = 6;
		bool result = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return false;
				case 7:
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 1;
					}
					break;
				case 6:
					if (!YGhP1EG3CfjKb9nbgVWg(NGjuRCG3Q6pXd8nTa9B3(file)))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 3;
				case 4:
					return password == null;
				case 8:
					if (password != null)
					{
						goto end_IL_0012;
					}
					goto default;
				case 1:
					return result;
				case 3:
					return password == null;
				case 5:
					if (((FileFormatInfo)j9D8tRG3vfRVM8XXG6CH(NGjuRCG3Q6pXd8nTa9B3(file))).get_IsEncrypted())
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
						{
							num2 = 4;
						}
						break;
					}
					goto case 4;
				case 2:
					try
					{
						object obj = NGjuRCG3Q6pXd8nTa9B3(file);
						LoadOptions val = new LoadOptions();
						val.set_Password(password);
						new Document((string)obj, val);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								return result;
							}
							result = true;
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
							{
								num3 = 1;
							}
						}
					}
					catch (IncorrectPasswordException)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								return result;
							}
							result = false;
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
							{
								num4 = 1;
							}
						}
					}
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
		}
	}

	public WordFilePreviewCreator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		oOUIkYG38xFVnfN2ePFm();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WordFilePreviewCreator()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				UID = new Guid((string)va53OfG3Epk9P1hLZAu5(0xD3DEF7E ^ 0xD3E1944));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static object va53OfG3Epk9P1hLZAu5(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object WQEQggG3frt30pGqH0sY(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool Jl44BXG3h3nAQj29NlOM()
	{
		return CiO2HMG3bp0SeRdfycSh == null;
	}

	internal static WordFilePreviewCreator MTxKJyG3G9sQTZwktD9s()
	{
		return CiO2HMG3bp0SeRdfycSh;
	}

	internal static object NGjuRCG3Q6pXd8nTa9B3(object P_0)
	{
		return ((BinaryFile)P_0).ContentFilePath;
	}

	internal static bool YGhP1EG3CfjKb9nbgVWg(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object j9D8tRG3vfRVM8XXG6CH(object P_0)
	{
		return FileFormatUtil.DetectFileFormat((string)P_0);
	}

	internal static void oOUIkYG38xFVnfN2ePFm()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
