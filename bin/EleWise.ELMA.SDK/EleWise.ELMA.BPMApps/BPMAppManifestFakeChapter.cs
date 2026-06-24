using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.BPMApps;

[Serializable]
public class BPMAppManifestFakeChapter : IXsiType
{
	private static BPMAppManifestFakeChapter enMG7cfTcmIIPosbP6po;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					break;
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
				case 1:
					_003CTitle_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
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

	public BPMAppManifestFakeChapter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		uYxssffkB7PRuV62YeEC();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				Items = new List<BPMAppManifestFakeItem>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public BPMAppManifestFakeChapter(Guid uid, string title)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		uYxssffkB7PRuV62YeEC();
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 3:
				Uid = uid;
				num = 2;
				break;
			case 1:
				Items = new List<BPMAppManifestFakeItem>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num = 0;
				}
				break;
			case 2:
				Title = title;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public BPMAppManifestFakeItem GetOrCreateItemByUid(Guid uid, string title = null)
	{
		//Discarded unreachable code: IL_00b4, IL_00c3
		int num = 5;
		BPMAppManifestFakeItem bPMAppManifestFakeItem = default(BPMAppManifestFakeItem);
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = default(_003C_003Ec__DisplayClass14_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					tqeqK0fkWjCftfE7dJ4Z(bPMAppManifestFakeItem, title);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 7;
					}
					break;
				default:
					if (bPMAppManifestFakeItem == null)
					{
						num2 = 9;
						break;
					}
					goto case 2;
				case 5:
					_003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 2;
					}
					break;
				case 7:
				case 8:
					return bPMAppManifestFakeItem;
				case 2:
					if (title == null)
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 9:
					bPMAppManifestFakeItem = new BPMAppManifestFakeItem(_003C_003Ec__DisplayClass14_.uid, title);
					num2 = 6;
					break;
				case 3:
					bPMAppManifestFakeItem = Items.FirstOrDefault(_003C_003Ec__DisplayClass14_._003CGetOrCreateItemByUid_003Eb__0);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					_003C_003Ec__DisplayClass14_.uid = uid;
					num2 = 3;
					break;
				case 6:
					Items.Add(bPMAppManifestFakeItem);
					num2 = 2;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 8;
		}
	}

	public BPMAppManifestFakeItem GetOrCreateItemByUidProxy(string uidProxy, string title = null)
	{
		//Discarded unreachable code: IL_005e
		int num = 2;
		int num2 = num;
		BPMAppManifestFakeItem bPMAppManifestFakeItem = default(BPMAppManifestFakeItem);
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = default(_003C_003Ec__DisplayClass15_0);
		while (true)
		{
			switch (num2)
			{
			case 6:
				tqeqK0fkWjCftfE7dJ4Z(bPMAppManifestFakeItem, title);
				num2 = 9;
				break;
			case 9:
				return bPMAppManifestFakeItem;
			case 4:
				bPMAppManifestFakeItem = new BPMAppManifestFakeItem(_003C_003Ec__DisplayClass15_.uidProxy, title);
				num2 = 8;
				break;
			default:
				if (bPMAppManifestFakeItem != null)
				{
					num2 = 3;
					break;
				}
				goto case 4;
			case 7:
				bPMAppManifestFakeItem = Items.FirstOrDefault(_003C_003Ec__DisplayClass15_._003CGetOrCreateItemByUidProxy_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass15_.uidProxy = uidProxy;
				num2 = 7;
				break;
			case 8:
				Items.Add(bPMAppManifestFakeItem);
				num2 = 5;
				break;
			case 3:
			case 5:
				if (title != null)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 9;
			case 2:
				_003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public BPMAppManifestFakeItem GetItemByUid(Guid uid)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = default(_003C_003Ec__DisplayClass16_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass16_.uid = uid;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return Items.FirstOrDefault(_003C_003Ec__DisplayClass16_._003CGetItemByUid_003Eb__0);
			}
		}
	}

	internal static void uYxssffkB7PRuV62YeEC()
	{
		SingletonReader.PushGlobal();
	}

	internal static bool wrLPvEfTzTMqpkuiN9My()
	{
		return enMG7cfTcmIIPosbP6po == null;
	}

	internal static BPMAppManifestFakeChapter OUnUTkfkFfWtAvm1CnxE()
	{
		return enMG7cfTcmIIPosbP6po;
	}

	internal static void tqeqK0fkWjCftfE7dJ4Z(object P_0, object P_1)
	{
		((BPMAppManifestFakeItem)P_0).Title = (string)P_1;
	}
}
