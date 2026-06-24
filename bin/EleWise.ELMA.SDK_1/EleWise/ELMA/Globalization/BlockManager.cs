// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.BlockManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Globalization
{
  internal class BlockManager
  {
    private List<Block> _list;
    private Block _current;
    private SubBlockType _type;
    private static BlockManager KMMOjsGENbNu1N0fE5vd;

    public BlockManager()
    {
      BlockManager.d4WQs7GEaYWML2tpFHdV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this._list = new List<Block>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    public void NewBlock()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this._list.Add(this._current);
            num = 3;
            continue;
          case 2:
            this._current = new Block();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 1 : 1;
            continue;
          case 3:
            this._type = SubBlockType.none;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    public void SetSubBlockType(SubBlockType type)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this._type = type;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void StoreSubBlockString(string s)
    {
      int num = 3;
      SubBlockType type;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            switch (type)
            {
              case SubBlockType.msgid:
                goto label_8;
              case SubBlockType.msgstr:
                this._current.MsgStr.Add(s);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 5 : 1;
                continue;
              case SubBlockType.comment:
                this._current.Comments.Add(s);
                num = 6;
                continue;
              default:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 2 : 7;
                continue;
            }
          case 3:
            type = this._type;
            num = 2;
            continue;
          case 4:
            BlockManager.GWql5rGEwBFxJke4LF2S((object) this._current, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 0;
            continue;
          case 5:
            goto label_15;
          case 6:
            if (!BlockManager.snAJrfGEtTbvlHuj3aNp((object) s, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767831787)))
            {
              num = 9;
              continue;
            }
            goto case 4;
          case 7:
            goto label_10;
          case 8:
            goto label_11;
          case 9:
            goto label_9;
          case 10:
label_8:
            BlockManager.EopC65GEDFvcUGXSS0sA((object) this._current, (object) s);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
            continue;
          default:
            this._current.MsgId.Add(s);
            num = 8;
            continue;
        }
      }
label_6:
      return;
label_15:
      return;
label_11:
      return;
label_9:
      return;
label_10:
      throw new Exception(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124676724));
    }

    public Block GetBlock(int msgIdHash)
    {
      int num = 1;
      int msgIdHash1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            msgIdHash1 = msgIdHash;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 2 : 2;
            continue;
        }
      }
label_3:
      // ISSUE: reference to a compiler-generated method
      return this._list.FirstOrDefault<Block>((Func<Block, bool>) (b => BlockManager.\u003C\u003Ec__DisplayClass7_0.DmW1CAvgl8INwXspJ3jZ((object) b) == msgIdHash1));
    }

    public void ReadFromFile(string filename)
    {
      int num = 1;
      string s;
      string[] strArray1;
      int index;
      while (true)
      {
        switch (num)
        {
          case 1:
            string[] strArray2 = File.ReadAllLines(filename);
            this.NewBlock();
            strArray1 = strArray2;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
            continue;
          case 2:
          case 15:
            if (!s.StartsWith((string) BlockManager.aU1QKRGE6TfY0ndSFxOx(~-122002947 ^ 122036536)))
            {
              num = 6;
              continue;
            }
            goto case 23;
          case 3:
            this.NewBlock();
            num = 10;
            continue;
          case 4:
            this.StoreSubBlockString(s);
            num = 16;
            continue;
          case 5:
          case 26:
            if (!BlockManager.G7AXomGEHgbBrgC85sPr((object) s, BlockManager.aU1QKRGE6TfY0ndSFxOx(1654249598 >> 2 ^ 413518131)))
            {
              num = 15;
              continue;
            }
            goto case 20;
          case 6:
          case 8:
            this.StoreSubBlockString(s);
            num = 12;
            continue;
          case 7:
          case 17:
            if (!BlockManager.G7AXomGEHgbBrgC85sPr((object) s, BlockManager.aU1QKRGE6TfY0ndSFxOx(-1445902765 ^ -1980277732 ^ 539307365)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 5 : 5;
              continue;
            }
            goto case 24;
          case 9:
          case 21:
            s = strArray1[index];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 8 : 25;
            continue;
          case 10:
          case 11:
          case 12:
          case 16:
          case 22:
            ++index;
            num = 19;
            continue;
          case 13:
            goto label_25;
          case 14:
            this.StoreSubBlockString(s);
            num = 11;
            continue;
          case 18:
            this.StoreSubBlockString(s);
            num = 22;
            continue;
          case 19:
          case 27:
            if (index < strArray1.Length)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 18 : 21;
              continue;
            }
            goto label_19;
          case 20:
            this.SetSubBlockType(SubBlockType.msgid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 10 : 18;
            continue;
          case 23:
            this.SetSubBlockType(SubBlockType.msgstr);
            num = 14;
            continue;
          case 24:
            this.SetSubBlockType(SubBlockType.comment);
            num = 4;
            continue;
          case 25:
            if (!BlockManager.vErPthGE4jWwcPH3pIii((object) s, (object) ""))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 9 : 17;
              continue;
            }
            goto case 3;
          default:
            index = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 27 : 26;
            continue;
        }
      }
label_25:
      return;
label_19:;
    }

    public IEnumerator<Block> GetEnumerator() => (IEnumerator<Block>) this._list.GetEnumerator();

    internal static void d4WQs7GEaYWML2tpFHdV() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool DaRUbuGE3HfliPe3bOo8() => BlockManager.KMMOjsGENbNu1N0fE5vd == null;

    internal static BlockManager YpxO4SGEpEyHUAXwaPTW() => BlockManager.KMMOjsGENbNu1N0fE5vd;

    internal static void EopC65GEDFvcUGXSS0sA([In] object obj0, [In] object obj1) => ((Block) obj0).MsgIdHashRecalc((string) obj1);

    internal static bool snAJrfGEtTbvlHuj3aNp([In] object obj0, [In] object obj1) => ((string) obj0).Contains((string) obj1);

    internal static void GWql5rGEwBFxJke4LF2S([In] object obj0, bool value) => ((Block) obj0).IsJsBlock = value;

    internal static bool vErPthGE4jWwcPH3pIii([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object aU1QKRGE6TfY0ndSFxOx(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool G7AXomGEHgbBrgC85sPr([In] object obj0, [In] object obj1) => ((string) obj0).StartsWith((string) obj1);
  }
}
