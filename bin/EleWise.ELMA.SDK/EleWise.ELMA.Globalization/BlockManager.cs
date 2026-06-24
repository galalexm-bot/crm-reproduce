using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Globalization;

internal class BlockManager
{
	private List<Block> _list;

	private Block _current;

	private SubBlockType _type;

	private static BlockManager KMMOjsGENbNu1N0fE5vd;

	public BlockManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		d4WQs7GEaYWML2tpFHdV();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
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
			_list = new List<Block>();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
			{
				num = 0;
			}
		}
	}

	public void NewBlock()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				_current = new Block();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				_type = SubBlockType.none;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 1:
				_list.Add(_current);
				num2 = 3;
				break;
			}
		}
	}

	public void SetSubBlockType(SubBlockType type)
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
				_type = type;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void StoreSubBlockString(string s)
	{
		//Discarded unreachable code: IL_0141, IL_0162
		int num = 3;
		int num2 = num;
		SubBlockType type = default(SubBlockType);
		while (true)
		{
			switch (num2)
			{
			case 4:
				GWql5rGEwBFxJke4LF2S(_current, true);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_current.MsgId.Add(s);
				num2 = 8;
				break;
			case 6:
				if (!snAJrfGEtTbvlHuj3aNp(s, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767831787)))
				{
					num2 = 9;
					break;
				}
				goto case 4;
			case 5:
				return;
			case 10:
				EopC65GEDFvcUGXSS0sA(_current, s);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			case 7:
				throw new Exception(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76E6A74));
			case 9:
				return;
			case 2:
				switch (type)
				{
				case SubBlockType.comment:
					_current.Comments.Add(s);
					num2 = 6;
					goto end_IL_0012;
				case SubBlockType.msgid:
					break;
				default:
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 7;
					}
					goto end_IL_0012;
				case SubBlockType.msgstr:
					_current.MsgStr.Add(s);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 1;
					}
					goto end_IL_0012;
				}
				goto case 10;
			case 3:
				type = _type;
				num2 = 2;
				break;
			case 8:
				return;
				end_IL_0012:
				break;
			}
		}
	}

	public Block GetBlock(int msgIdHash)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return _list.FirstOrDefault(_003C_003Ec__DisplayClass7_._003CGetBlock_003Eb__0);
			default:
				_003C_003Ec__DisplayClass7_.msgIdHash = msgIdHash;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public void ReadFromFile(string filename)
	{
		//Discarded unreachable code: IL_0091, IL_00a0, IL_00e3, IL_0114, IL_0123, IL_0145, IL_0154, IL_01b3, IL_01c6, IL_0284, IL_02b0, IL_02c3, IL_0341
		int num = 1;
		int num2 = num;
		string text = default(string);
		string[] array2 = default(string[]);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 4:
				StoreSubBlockString(text);
				num2 = 16;
				continue;
			case 9:
			case 21:
				text = array2[num3];
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 25;
				}
				continue;
			case 3:
				NewBlock();
				num2 = 10;
				continue;
			case 18:
				StoreSubBlockString(text);
				num2 = 22;
				continue;
			case 6:
			case 8:
				StoreSubBlockString(text);
				num2 = 12;
				continue;
			case 13:
				return;
			case 7:
			case 17:
				if (!G7AXomGEHgbBrgC85sPr(text, aU1QKRGE6TfY0ndSFxOx(0x20261A4F ^ 0x20252D65)))
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 5;
					}
					continue;
				}
				goto case 24;
			case 14:
				StoreSubBlockString(text);
				num2 = 11;
				continue;
			case 19:
			case 27:
				if (num3 >= array2.Length)
				{
					return;
				}
				num2 = 18;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 21;
				}
				continue;
			case 2:
			case 15:
				if (!text.StartsWith((string)aU1QKRGE6TfY0ndSFxOx(0x7459E02 ^ 0x7462138)))
				{
					num2 = 6;
					continue;
				}
				goto case 23;
			case 10:
			case 11:
			case 12:
			case 16:
			case 22:
				num3++;
				num2 = 19;
				continue;
			case 25:
				if (!vErPthGE4jWwcPH3pIii(text, ""))
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 17;
					}
					continue;
				}
				goto case 3;
			case 1:
			{
				string[] array = File.ReadAllLines(filename);
				NewBlock();
				array2 = array;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			default:
				num3 = 0;
				num2 = 27;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 26;
				}
				continue;
			case 24:
				SetSubBlockType(SubBlockType.comment);
				num2 = 4;
				continue;
			case 23:
				SetSubBlockType(SubBlockType.msgstr);
				num2 = 14;
				continue;
			case 5:
			case 26:
				if (!G7AXomGEHgbBrgC85sPr(text, aU1QKRGE6TfY0ndSFxOx(0x18A6761F ^ 0x18A5C933)))
				{
					num2 = 15;
					continue;
				}
				break;
			case 20:
				break;
			}
			SetSubBlockType(SubBlockType.msgid);
			num2 = 10;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
			{
				num2 = 18;
			}
		}
	}

	public IEnumerator<Block> GetEnumerator()
	{
		return _list.GetEnumerator();
	}

	internal static void d4WQs7GEaYWML2tpFHdV()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool DaRUbuGE3HfliPe3bOo8()
	{
		return KMMOjsGENbNu1N0fE5vd == null;
	}

	internal static BlockManager YpxO4SGEpEyHUAXwaPTW()
	{
		return KMMOjsGENbNu1N0fE5vd;
	}

	internal static void EopC65GEDFvcUGXSS0sA(object P_0, object P_1)
	{
		((Block)P_0).MsgIdHashRecalc((string)P_1);
	}

	internal static bool snAJrfGEtTbvlHuj3aNp(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static void GWql5rGEwBFxJke4LF2S(object P_0, bool value)
	{
		((Block)P_0).IsJsBlock = value;
	}

	internal static bool vErPthGE4jWwcPH3pIii(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object aU1QKRGE6TfY0ndSFxOx(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool G7AXomGEHgbBrgC85sPr(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}
}
