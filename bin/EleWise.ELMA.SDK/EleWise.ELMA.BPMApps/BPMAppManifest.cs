using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.BPMApps;

public class BPMAppManifest
{
	private static BPMAppManifest Qj5wJhfkqyNeinbNWhkZ;

	[XmlArray("Chapters")]
	public List<BPMAppManifestChapter> Chapters { get; set; }

	[XmlArray("Flags")]
	public List<BPMAppManifestFlag> Flags { get; set; }

	public BPMAppManifest()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				Chapters = new List<BPMAppManifestChapter>();
				num = 2;
				break;
			case 1:
				return;
			case 2:
				Flags = new List<BPMAppManifestFlag>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public void SetChapter(BPMAppManifestChapter chapter)
	{
		//Discarded unreachable code: IL_010d
		int num = 7;
		int num2 = num;
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 4:
				JYvKSVfkkQiSTZrmFPrj(_003C_003Ec__DisplayClass9_.chapter, rKpYIDfkTFjEQSdWerVb(0x463A0F3C ^ 0x463F497A));
				num2 = 5;
				break;
			case 5:
				num3 = Chapters.FindIndex(_003C_003Ec__DisplayClass9_._003CSetChapter_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			case 7:
				_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
				num2 = 6;
				break;
			default:
				if (num3 < 0)
				{
					num2 = 2;
					break;
				}
				goto case 8;
			case 2:
			case 3:
				Chapters.Add(_003C_003Ec__DisplayClass9_.chapter);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				Chapters[num3] = _003C_003Ec__DisplayClass9_.chapter;
				num2 = 3;
				break;
			case 6:
				_003C_003Ec__DisplayClass9_.chapter = chapter;
				num2 = 4;
				break;
			}
		}
	}

	public BPMAppManifestChapter GetChapter(Guid uid)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return Chapters.FirstOrDefault(_003C_003Ec__DisplayClass10_._003CGetChapter_003Eb__0);
			case 1:
				_003C_003Ec__DisplayClass10_.uid = uid;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void SetFlag(Guid uid, bool value)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
		BPMAppManifestFlag bPMAppManifestFlag = default(BPMAppManifestFlag);
		while (true)
		{
			switch (num2)
			{
			case 6:
				return;
			case 4:
			{
				BPMAppManifestFlag bPMAppManifestFlag2 = new BPMAppManifestFlag();
				yKAoYAfkn5OOsZMPY9Qu(bPMAppManifestFlag2, _003C_003Ec__DisplayClass11_.uid);
				bPMAppManifestFlag = bPMAppManifestFlag2;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 3;
				}
				break;
			}
			case 3:
				Flags.Add(bPMAppManifestFlag);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 2;
				}
				break;
			default:
				_003C_003Ec__DisplayClass11_.uid = uid;
				num2 = 5;
				break;
			case 5:
				bPMAppManifestFlag = Flags.FirstOrDefault(_003C_003Ec__DisplayClass11_._003CSetFlag_003Eb__0);
				num2 = 7;
				break;
			case 7:
				if (bPMAppManifestFlag == null)
				{
					num2 = 4;
					break;
				}
				goto case 2;
			case 2:
				jyA2kMfkOBQFUHkWy8i9(bPMAppManifestFlag, value);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public bool? GetFlag(Guid uid)
	{
		_003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_0();
		CS_0024_003C_003E8__locals0.uid = uid;
		return Flags.FirstOrDefault((BPMAppManifestFlag f) => _003C_003Ec__DisplayClass12_0.adJ4VS8cjdPtAP2vuO0P(_003C_003Ec__DisplayClass12_0.FM9iwh8c5fZ296kJkDBJ(f), CS_0024_003C_003E8__locals0.uid))?.Value;
	}

	public bool GetFlag(Guid uid, bool defaultValue)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = default(_003C_003Ec__DisplayClass13_0);
		BPMAppManifestFlag bPMAppManifestFlag = default(BPMAppManifestFlag);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				if (bPMAppManifestFlag != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return defaultValue;
			case 1:
				_003C_003Ec__DisplayClass13_.uid = uid;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				bPMAppManifestFlag = Flags.FirstOrDefault(_003C_003Ec__DisplayClass13_._003CGetFlag_003Eb__0);
				num2 = 4;
				break;
			default:
				return BoStNlfk2ReQNwOLXKl3(bPMAppManifestFlag);
			}
		}
	}

	internal static bool y3XSVHfkKbw7nciN1EuX()
	{
		return Qj5wJhfkqyNeinbNWhkZ == null;
	}

	internal static BPMAppManifest dNo2lifkX34MQV5vFcOT()
	{
		return Qj5wJhfkqyNeinbNWhkZ;
	}

	internal static object rKpYIDfkTFjEQSdWerVb(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void JYvKSVfkkQiSTZrmFPrj(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void yKAoYAfkn5OOsZMPY9Qu(object P_0, Guid value)
	{
		((BPMAppManifestFlag)P_0).Uid = value;
	}

	internal static void jyA2kMfkOBQFUHkWy8i9(object P_0, bool value)
	{
		((BPMAppManifestFlag)P_0).Value = value;
	}

	internal static bool BoStNlfk2ReQNwOLXKl3(object P_0)
	{
		return ((BPMAppManifestFlag)P_0).Value;
	}
}
