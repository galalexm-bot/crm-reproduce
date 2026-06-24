// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.LocalizationFileHash
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Globalization
{
  [Serializable]
  public class LocalizationFileHash
  {
    private static LocalizationFileHash WppoFqGhEQbLkg73jL8C;

    public string FileName
    {
      get => this.\u003CFileName\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CFileName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public byte[] Hash
    {
      get => this.\u003CHash\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CHash\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public override bool Equals(object obj)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this == obj)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 3 : 1;
              continue;
            }
            if (!LocalizationFileHash.aqQ9pAGhCFYwoKgAVJMZ(obj.GetType(), typeof (LocalizationFileHash)))
            {
              num = 4;
              continue;
            }
            goto label_10;
          case 2:
            if (obj != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 1;
              continue;
            }
            goto label_2;
          case 3:
            goto label_7;
          case 4:
            goto label_11;
          case 5:
            goto label_10;
          default:
            goto label_2;
        }
      }
label_2:
      return false;
label_7:
      return true;
label_10:
      return false;
label_11:
      return this.Equals((LocalizationFileHash) obj);
    }

    public bool Equals(LocalizationFileHash other)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this != other)
            {
              if (LocalizationFileHash.hjRbNRGhvCiQFpZ8uZ2Y((object) other) == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 4 : 4;
                continue;
              }
              goto case 9;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 3 : 0;
              continue;
            }
          case 2:
            if (other != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 1 : 1;
              continue;
            }
            goto label_15;
          case 3:
            goto label_12;
          case 4:
            if (this.FileName == null)
            {
              num = 10;
              continue;
            }
            goto case 9;
          case 5:
          case 10:
            if (other.Hash == null)
            {
              num = 11;
              continue;
            }
            break;
          case 6:
            if (LocalizationFileHash.TCPkJmGh8jDrLvmKOmdG(LocalizationFileHash.hjRbNRGhvCiQFpZ8uZ2Y((object) other), (object) this.FileName, StringComparison.OrdinalIgnoreCase))
            {
              num = 5;
              continue;
            }
            goto label_23;
          case 7:
            goto label_22;
          case 8:
            goto label_20;
          case 9:
            if (LocalizationFileHash.hjRbNRGhvCiQFpZ8uZ2Y((object) other) != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 4 : 6;
              continue;
            }
            goto label_23;
          case 11:
            if (this.Hash == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 7 : 2;
              continue;
            }
            break;
          case 12:
            goto label_15;
        }
        if (LocalizationFileHash.rlWywjGhZetuneAvCW1C((object) other) != null)
          num = 8;
        else
          goto label_21;
      }
label_12:
      return true;
label_15:
      return false;
label_20:
      return ((IEnumerable<byte>) LocalizationFileHash.rlWywjGhZetuneAvCW1C((object) other)).SequenceEqual<byte>((IEnumerable<byte>) this.Hash);
label_21:
      return false;
label_22:
      return true;
label_23:
      return false;
    }

    protected static int ByteArrayHashCode(byte[] bytes)
    {
      int num1 = 1;
      int num2;
      while (true)
      {
        int num3 = num1;
        byte[] numArray;
        int index;
        byte num4;
        while (true)
        {
          switch (num3)
          {
            case 1:
              if (bytes != null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
                continue;
              }
              goto label_8;
            case 2:
            case 10:
              if (index >= numArray.Length)
              {
                num3 = 4;
                continue;
              }
              goto label_3;
            case 3:
              ++index;
              num3 = 10;
              continue;
            case 4:
              goto label_14;
            case 5:
              goto label_8;
            case 6:
              index = 0;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 2 : 1;
              continue;
            case 7:
              num2 = num2 * 31 + EqualityComparer<byte>.Default.GetHashCode(num4);
              num3 = 3;
              continue;
            case 8:
              goto label_11;
            case 9:
              goto label_3;
            default:
              num2 = 17;
              num3 = 8;
              continue;
          }
        }
label_3:
        num4 = numArray[index];
        num1 = 7;
        continue;
label_11:
        numArray = bytes;
        num1 = 6;
      }
label_8:
      return 0;
label_14:
      return num2;
    }

    public override int GetHashCode()
    {
      int num = 1;
      ArrayEqualityComparer<byte> equalityComparer;
      while (true)
      {
        switch (num)
        {
          case 1:
            equalityComparer = new ArrayEqualityComparer<byte>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            if (this.FileName == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 2;
              continue;
            }
            goto label_6;
        }
      }
label_4:
      int hashCode = typeof (string).GetHashCode();
      goto label_7;
label_6:
      hashCode = this.FileName.GetHashCode();
label_7:
      // ISSUE: type reference
      return hashCode * 384 ^ (this.Hash != null ? equalityComparer.GetHashCode(this.Hash) : LocalizationFileHash.Yti6hqGhuZGE8uRDIusO(__typeref (byte[])).GetHashCode());
    }

    public LocalizationFileHash()
    {
      LocalizationFileHash.yMK9IKGhI01TyAfCyBBT();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool wBwDfZGhfksNOfo0pZrs() => LocalizationFileHash.WppoFqGhEQbLkg73jL8C == null;

    internal static LocalizationFileHash nyK2wcGhQ46wgtJGXSRh() => LocalizationFileHash.WppoFqGhEQbLkg73jL8C;

    internal static bool aqQ9pAGhCFYwoKgAVJMZ([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object hjRbNRGhvCiQFpZ8uZ2Y([In] object obj0) => (object) ((LocalizationFileHash) obj0).FileName;

    internal static bool TCPkJmGh8jDrLvmKOmdG([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).Equals((string) obj1, obj2);

    internal static object rlWywjGhZetuneAvCW1C([In] object obj0) => (object) ((LocalizationFileHash) obj0).Hash;

    internal static Type Yti6hqGhuZGE8uRDIusO([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static void yMK9IKGhI01TyAfCyBBT() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
