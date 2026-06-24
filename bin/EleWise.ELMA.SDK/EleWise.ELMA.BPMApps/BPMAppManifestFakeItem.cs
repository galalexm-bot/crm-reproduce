using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.BPMApps;

[Serializable]
public class BPMAppManifestFakeItem
{
	internal static BPMAppManifestFakeItem SPwrFAfkvaHXXRUxTgIq;

	[XmlElement("Uid")]
	public Guid Uid
	{
		[CompilerGenerated]
		get
		{
			return _003CUid_003Ek__BackingField;
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
					_003CUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("UidProxy")]
	public string UidProxy
	{
		[CompilerGenerated]
		get
		{
			return _003CUidProxy_003Ek__BackingField;
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
					_003CUidProxy_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
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

	[XmlElement("Title")]
	public string Title
	{
		[CompilerGenerated]
		get
		{
			return _003CTitle_003Ek__BackingField;
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
					_003CTitle_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("TitleAdditional")]
	public string TitleAdditional
	{
		[CompilerGenerated]
		get
		{
			return _003CTitleAdditional_003Ek__BackingField;
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
					_003CTitleAdditional_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
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

	[XmlArray("Items")]
	public List<BPMAppManifestFakeItem> Items { get; set; }

	public BPMAppManifestFakeItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		blmoLyfkuDjnUAiR3HyF();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public BPMAppManifestFakeItem(Guid uid, string title)
	{
		//Discarded unreachable code: IL_001e
		blmoLyfkuDjnUAiR3HyF();
		base._002Ector();
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					Uid = uid;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					Title = title;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					return;
				}
				break;
			}
			Items = new List<BPMAppManifestFakeItem>();
			num = 3;
		}
	}

	public BPMAppManifestFakeItem(string uidProxy, string title)
	{
		//Discarded unreachable code: IL_001e
		SingletonReader.PushGlobal();
		base._002Ector();
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				Uid = BP4hlXfkIhrLJ6XpVHKM();
				num2 = 4;
				break;
			case 0:
				return;
			case 4:
				Title = title;
				num2 = 3;
				break;
			case 3:
				UidProxy = uidProxy;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				Items = new List<BPMAppManifestFakeItem>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public BPMAppManifestFakeItem GetOrCreateItemByUid(Guid uid, string title = null)
	{
		//Discarded unreachable code: IL_005f, IL_006e, IL_00a2
		int num = 4;
		_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_ = default(_003C_003Ec__DisplayClass23_0);
		BPMAppManifestFakeItem bPMAppManifestFakeItem = default(BPMAppManifestFakeItem);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					_003C_003Ec__DisplayClass23_.uid = uid;
					num2 = 7;
					continue;
				case 8:
				case 10:
					return bPMAppManifestFakeItem;
				case 4:
					_003C_003Ec__DisplayClass23_ = new _003C_003Ec__DisplayClass23_0();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
				case 5:
					if (title == null)
					{
						num2 = 10;
						continue;
					}
					goto case 1;
				case 9:
					bPMAppManifestFakeItem = new BPMAppManifestFakeItem(_003C_003Ec__DisplayClass23_.uid, title);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 6;
					}
					continue;
				case 6:
					Items.Add(bPMAppManifestFakeItem);
					num2 = 2;
					continue;
				case 1:
					bIa0AffkVdFlsbuZSRSw(bPMAppManifestFakeItem, title);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 5;
					}
					continue;
				case 7:
					bPMAppManifestFakeItem = Items.FirstOrDefault(_003C_003Ec__DisplayClass23_._003CGetOrCreateItemByUid_003Eb__0);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					if (bPMAppManifestFakeItem != null)
					{
						break;
					}
					goto case 9;
				}
				break;
			}
			num = 5;
		}
	}

	public BPMAppManifestFakeItem GetOrCreateItemByUidProxy(string uidProxy, string title = null)
	{
		//Discarded unreachable code: IL_0106
		int num = 2;
		BPMAppManifestFakeItem bPMAppManifestFakeItem = default(BPMAppManifestFakeItem);
		_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = default(_003C_003Ec__DisplayClass24_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					bPMAppManifestFakeItem.Title = title;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					_003C_003Ec__DisplayClass24_.uidProxy = uidProxy;
					num2 = 3;
					continue;
				case 9:
					if (bPMAppManifestFakeItem != null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num2 = 2;
						}
						continue;
					}
					break;
				case 3:
					bPMAppManifestFakeItem = Items.FirstOrDefault(_003C_003Ec__DisplayClass24_._003CGetOrCreateItemByUidProxy_003Eb__0);
					num2 = 9;
					continue;
				case 7:
					Items.Add(bPMAppManifestFakeItem);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 5;
					}
					continue;
				case 4:
					break;
				case 8:
					return bPMAppManifestFakeItem;
				case 2:
					_003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
				case 6:
					if (title != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 8;
				}
				break;
			}
			bPMAppManifestFakeItem = new BPMAppManifestFakeItem(_003C_003Ec__DisplayClass24_.uidProxy, title);
			num = 7;
		}
	}

	public BPMAppManifestFakeItem GetItemByUid(Guid uid)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass25_0 _003C_003Ec__DisplayClass25_ = default(_003C_003Ec__DisplayClass25_0);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass25_.uid = uid;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass25_ = new _003C_003Ec__DisplayClass25_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return Items.FirstOrDefault(_003C_003Ec__DisplayClass25_._003CGetItemByUid_003Eb__0);
			}
		}
	}

	internal static void blmoLyfkuDjnUAiR3HyF()
	{
		SingletonReader.PushGlobal();
	}

	internal static bool B0inuifk8DpUMB5pf09i()
	{
		return SPwrFAfkvaHXXRUxTgIq == null;
	}

	internal static BPMAppManifestFakeItem QJ2xMQfkZ7hnQFCxYIJe()
	{
		return SPwrFAfkvaHXXRUxTgIq;
	}

	internal static Guid BP4hlXfkIhrLJ6XpVHKM()
	{
		return Guid.NewGuid();
	}

	internal static void bIa0AffkVdFlsbuZSRSw(object P_0, object P_1)
	{
		((BPMAppManifestFakeItem)P_0).Title = (string)P_1;
	}
}
