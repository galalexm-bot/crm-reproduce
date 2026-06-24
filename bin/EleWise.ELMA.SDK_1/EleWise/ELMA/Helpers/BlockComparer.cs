// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.BlockComparer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Helpers
{
  internal class BlockComparer : Comparer
  {
    private readonly string[] propertiesToIgnore;
    private static BlockComparer BAfC93hzo30WUxaYaFxB;

    public BlockComparer()
    {
      BlockComparer.Y82PsnhzGmiE9rSDo9BU();
      this.propertiesToIgnore = new string[4]
      {
        (string) BlockComparer.MCfqwXhzEKPHxLqNyZEC(~289714581 ^ -289866600),
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712505381),
        (string) BlockComparer.MCfqwXhzEKPHxLqNyZEC(-1886646897 ^ -1886614319),
        (string) BlockComparer.MCfqwXhzEKPHxLqNyZEC(1917998801 >> 2 ^ 479462786)
      };
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
        num1 = 0;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          default:
            this.Expression = (Func<object, object, bool>) ((x, y) =>
            {
              int num2 = 2;
              IEnumerator<PropertyInfo> enumerator;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_5;
                  case 2:
                    enumerator = ((IEnumerable<PropertyInfo>) x.GetType().GetReflectionProperties()).Where<PropertyInfo>((Func<PropertyInfo, bool>) (property => !((IEnumerable<string>) this.propertiesToIgnore).Contains<string>((string) BlockComparer.Vd3oKyhzvRBK3vm1lq9y((object) property)))).GetEnumerator();
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 1;
                    continue;
                  default:
                    goto label_3;
                }
              }
label_3:
              return true;
label_5:
              bool flag;
              try
              {
label_18:
                if (BlockComparer.HTuWeihzCiQV2e1p0T64((object) enumerator))
                  goto label_11;
                else
                  goto label_19;
label_7:
                PropertyInfo current;
                int num3;
                while (true)
                {
                  int num4;
                  object obj1;
                  object[] arrayOrNull;
                  object obj2;
                  object[] y1;
                  BlockComparer blockComparer;
                  switch (num3)
                  {
                    case 1:
                    case 2:
                      flag = false;
                      num4 = 25;
                      break;
                    case 3:
                      obj1 = current.GetValue(y, (object[]) null);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 10 : 1;
                      continue;
                    case 4:
                    case 5:
                    case 8:
                    case 12:
                      goto label_18;
                    case 6:
                      if (arrayOrNull == null)
                      {
                        num4 = 22;
                        break;
                      }
                      goto default;
                    case 7:
                      goto label_11;
                    case 9:
                      if (BlockComparer.is4ewThzQtUMERp3LJ8T((object) current, x, (object) null).Equals(BlockComparer.is4ewThzQtUMERp3LJ8T((object) current, y, (object) null)))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 2 : 4;
                        continue;
                      }
                      goto case 1;
                    case 10:
                      if (obj2 != null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 2 : 11;
                        continue;
                      }
                      goto case 14;
                    case 11:
                    case 15:
                      if (obj2 == null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 1 : 12;
                        continue;
                      }
                      goto case 9;
                    case 13:
                      y1 = (BlockComparer.is4ewThzQtUMERp3LJ8T((object) current, y, (object) null) as IEnumerable).CastToArrayOrNull<object>();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 4 : 6;
                      continue;
                    case 14:
                      if (obj1 != null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 1;
                        continue;
                      }
                      goto case 11;
                    case 16:
                      blockComparer = this;
                      num3 = 24;
                      continue;
                    case 17:
                    case 22:
                      flag = false;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 23 : 1;
                      continue;
                    case 18:
                    case 20:
                      obj2 = BlockComparer.is4ewThzQtUMERp3LJ8T((object) current, x, (object) null);
                      num3 = 3;
                      continue;
                    case 19:
                      // ISSUE: type reference
                      if (!((IEnumerable<object>) current.GetCustomAttributes(BlockComparer.hee5nZhzfZ2evA8idHAl(__typeref (TablePartPropertyAttribute)), false)).Any<object>())
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 20 : 6;
                        continue;
                      }
                      goto case 28;
                    case 21:
                      if (!((IEnumerable<object>) arrayOrNull).Where<object>((Func<object, int, bool>) ((t, i) => !blockComparer.Expression(t, y1[i]))).Any<object>())
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 5 : 2;
                        continue;
                      }
                      goto case 17;
                    case 23:
                    case 25:
                      goto label_4;
                    case 24:
                      arrayOrNull = (BlockComparer.is4ewThzQtUMERp3LJ8T((object) current, x, (object) null) as IEnumerable).CastToArrayOrNull<object>();
                      num3 = 13;
                      continue;
                    case 26:
                      if (arrayOrNull.Length == y1.Length)
                      {
                        num4 = 21;
                        break;
                      }
                      goto case 17;
                    case 27:
                      goto label_3;
                    case 28:
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 16 : 5;
                      continue;
                    default:
                      if (y1 != null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 14 : 26;
                        continue;
                      }
                      goto case 17;
                  }
                  num3 = num4;
                }
label_11:
                current = enumerator.Current;
                num3 = 19;
                goto label_7;
label_19:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 27 : 9;
                goto label_7;
              }
              finally
              {
                int num5;
                if (enumerator == null)
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
                else
                  goto label_40;
label_39:
                switch (num5)
                {
                  case 1:
                    break;
                  default:
                }
label_40:
                enumerator.Dispose();
                num5 = 2;
                goto label_39;
              }
label_4:
              return flag;
            });
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    internal static void Y82PsnhzGmiE9rSDo9BU() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object MCfqwXhzEKPHxLqNyZEC(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool aPEDuAhzbnAsVy8No3Y8() => BlockComparer.BAfC93hzo30WUxaYaFxB == null;

    internal static BlockComparer gFusG1hzhHta5tNwywHm() => BlockComparer.BAfC93hzo30WUxaYaFxB;

    internal static Type hee5nZhzfZ2evA8idHAl([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object is4ewThzQtUMERp3LJ8T([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static bool HTuWeihzCiQV2e1p0T64([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static object Vd3oKyhzvRBK3vm1lq9y([In] object obj0) => (object) ((MemberInfo) obj0).Name;
  }
}
