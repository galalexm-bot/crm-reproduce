using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.BPMApps;

[Serializable]
public class BPMAppFakeManifest
{
	private string displayName;

	private static BPMAppFakeManifest Hb12T3fTgSSQ92SDirqM;

	[XmlArray("Chapters")]
	public List<BPMAppManifestFakeChapter> Chapters { get; set; }

	public string TreeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CTreeUid_003Ek__BackingField;
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
				case 1:
					_003CTreeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public string DisplayName
	{
		get
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (eBxFyafTL6RApKfG8ehg(displayName))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return displayName;
				default:
					return (string)YIfrvPfTsHnyvlyIaWZB(Bkvv0CfTUpSwKBk1Tu0t(-957824448 ^ -957481134));
				}
			}
		}
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
					displayName = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public BPMAppFakeManifest()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		TRxUXhfTYC5XHrNmECuU();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			Chapters = new List<BPMAppManifestFakeChapter>();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
			{
				num = 1;
			}
		}
	}

	public BPMAppManifestFakeChapter GetOrCreateChapterByUid(Guid uid, string title = "")
	{
		int num = 5;
		BPMAppManifestFakeChapter bPMAppManifestFakeChapter = default(BPMAppManifestFakeChapter);
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = default(_003C_003Ec__DisplayClass13_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					Chapters.Add(bPMAppManifestFakeChapter);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 6;
					}
					continue;
				case 1:
					bPMAppManifestFakeChapter = Chapters.FirstOrDefault(_003C_003Ec__DisplayClass13_._003CGetOrCreateChapterByUid_003Eb__0);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					_003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
					num2 = 4;
					continue;
				case 2:
					goto end_IL_0012;
				case 4:
					_003C_003Ec__DisplayClass13_.uid = uid;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					if (bPMAppManifestFakeChapter == null)
					{
						num2 = 2;
						continue;
					}
					break;
				case 6:
					break;
				}
				return bPMAppManifestFakeChapter;
				continue;
				end_IL_0012:
				break;
			}
			bPMAppManifestFakeChapter = new BPMAppManifestFakeChapter(_003C_003Ec__DisplayClass13_.uid, title);
			num = 3;
		}
	}

	internal static void TRxUXhfTYC5XHrNmECuU()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool nFEIHjfT5H4BKj47ybL9()
	{
		return Hb12T3fTgSSQ92SDirqM == null;
	}

	internal static BPMAppFakeManifest fsZvCnfTje6Uu2b89yCx()
	{
		return Hb12T3fTgSSQ92SDirqM;
	}

	internal static bool eBxFyafTL6RApKfG8ehg(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object Bkvv0CfTUpSwKBk1Tu0t(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object YIfrvPfTsHnyvlyIaWZB(object P_0)
	{
		return SR.T((string)P_0);
	}
}
