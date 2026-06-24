// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.LocalizationHash
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Globalization
{
  [Serializable]
  public class LocalizationHash
  {
    private static LocalizationHash tgxTY0GbcDsOlund7ZDb;

    public string Local
    {
      get => this.\u003CLocal\u003Ek__BackingField;
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
              this.\u003CLocal\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
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

    public List<LocalizationFileHash> FileHashes { get; set; }

    public LocalizationHash()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.FileHashes = new List<LocalizationFileHash>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public override bool Equals(object obj)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            goto label_9;
          case 3:
            if (this == obj)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 2 : 2;
              continue;
            }
            if (LocalizationHash.npAGJ5GhBmoYpipg8fph(obj.GetType(), typeof (LocalizationHash)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 1;
              continue;
            }
            goto label_8;
          case 4:
            if (obj != null)
            {
              num = 3;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return false;
label_7:
      return false;
label_8:
      return this.Equals((LocalizationHash) obj);
label_9:
      return true;
    }

    public bool Equals(LocalizationHash other)
    {
      int num1 = 2;
      ArrayEqualityComparer<LocalizationFileHash> equalityComparer;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_13;
            case 2:
              if (other == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 1;
                continue;
              }
              if (this != other)
              {
                equalityComparer = new ArrayEqualityComparer<LocalizationFileHash>();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
                continue;
              }
              num2 = 11;
              continue;
            case 3:
              goto label_3;
            case 4:
              if (this.Local != null)
              {
                num2 = 6;
                continue;
              }
              goto case 13;
            case 5:
              goto label_5;
            case 6:
            case 7:
              if (LocalizationHash.osHg3vGhWnB72aiR5hfP((object) other) == null)
              {
                num2 = 9;
                continue;
              }
              goto case 15;
            case 8:
              goto label_4;
            case 9:
            case 10:
              goto label_6;
            case 11:
              goto label_11;
            case 12:
              if (other.FileHashes != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 14 : 11;
                continue;
              }
              goto label_4;
            case 13:
              if (other.FileHashes == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 6 : 16;
                continue;
              }
              goto case 12;
            case 14:
              if (this.FileHashes == null)
              {
                num2 = 8;
                continue;
              }
              goto label_3;
            case 15:
              if (!LocalizationHash.f334NeGhoqWGK11Li3pA((object) other.Local, (object) this.Local, StringComparison.OrdinalIgnoreCase))
              {
                num2 = 10;
                continue;
              }
              goto case 13;
            case 16:
              if (this.FileHashes != null)
                goto case 12;
              else
                goto label_23;
            default:
              if (LocalizationHash.osHg3vGhWnB72aiR5hfP((object) other) == null)
                goto case 4;
              else
                goto label_8;
          }
        }
label_8:
        num1 = 7;
        continue;
label_23:
        num1 = 5;
      }
label_3:
      return LocalizationHash.apdXaUGhhLVWQvcqGwli((object) equalityComparer, LocalizationHash.kkN6XcGhb4nRxKslguL8((object) other.FileHashes), (object) this.FileHashes.ToArray());
label_4:
      return false;
label_5:
      return true;
label_6:
      return false;
label_11:
      return true;
label_13:
      return false;
    }

    public override int GetHashCode()
    {
      int num = 2;
      ArrayEqualityComparer<LocalizationFileHash> equalityComparer;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.Local == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            equalityComparer = new ArrayEqualityComparer<LocalizationFileHash>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      // ISSUE: type reference
      int hashCode = LocalizationHash.MQI909GhGah9i44RA9F5(__typeref (string)).GetHashCode();
      goto label_7;
label_6:
      hashCode = this.Local.GetHashCode();
label_7:
      // ISSUE: type reference
      return hashCode * 347 ^ (this.FileHashes == null ? LocalizationHash.MQI909GhGah9i44RA9F5(__typeref (List<LocalizationFileHash>)).GetHashCode() : equalityComparer.GetHashCode((LocalizationFileHash[]) LocalizationHash.kkN6XcGhb4nRxKslguL8((object) this.FileHashes)));
    }

    internal static bool peGJnCGbzYUnQ2jx4Maj() => LocalizationHash.tgxTY0GbcDsOlund7ZDb == null;

    internal static LocalizationHash NVOa6EGhFaaICZPwVm3y() => LocalizationHash.tgxTY0GbcDsOlund7ZDb;

    internal static bool npAGJ5GhBmoYpipg8fph([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object osHg3vGhWnB72aiR5hfP([In] object obj0) => (object) ((LocalizationHash) obj0).Local;

    internal static bool f334NeGhoqWGK11Li3pA([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).Equals((string) obj1, obj2);

    internal static object kkN6XcGhb4nRxKslguL8([In] object obj0) => (object) ((List<LocalizationFileHash>) obj0).ToArray();

    internal static bool apdXaUGhhLVWQvcqGwli([In] object obj0, [In] object obj1, [In] object obj2) => ((ArrayEqualityComparer<LocalizationFileHash>) obj0).Equals((LocalizationFileHash[]) obj1, (LocalizationFileHash[]) obj2);

    internal static Type MQI909GhGah9i44RA9F5([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);
  }
}
