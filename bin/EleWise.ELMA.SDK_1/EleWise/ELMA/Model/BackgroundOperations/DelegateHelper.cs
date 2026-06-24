// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.BackgroundOperations.DelegateHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.BackgroundOperations
{
  /// <summary>Помощник в работе с сигнатурами методов.</summary>
  public static class DelegateHelper
  {
    internal static DelegateHelper iECxFsWce5HFZ17arvB7;

    /// <summary>Привести строковое представление делегата.</summary>
    /// <param name="delegate">Делегат.</param>
    /// <returns>Строковое представление делегата.</returns>
    public static string DelegateToString(Delegate @delegate)
    {
      int num = 2;
      string name;
      IEnumerable<string> values;
      while (true)
      {
        switch (num)
        {
          case 1:
            name = @delegate.Method.Name;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
            continue;
          case 2:
            if ((object) @delegate != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          case 3:
            goto label_7;
          case 4:
            goto label_2;
          default:
            ParameterInfo[] parameters = ((MethodBase) DelegateHelper.m1oSUdWcNq1oTsfCeJs5((object) @delegate)).GetParameters();
            // ISSUE: reference to a compiler-generated field
            Func<ParameterInfo, string> func = DelegateHelper.\u003C\u003Ec.\u003C\u003E9__0_0;
            Func<ParameterInfo, string> selector;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              DelegateHelper.\u003C\u003Ec.\u003C\u003E9__0_0 = selector = (Func<ParameterInfo, string>) (arg => arg.ParameterType.ToString());
            }
            else
              goto label_4;
label_10:
            values = ((IEnumerable<ParameterInfo>) parameters).Select<ParameterInfo, string>(selector);
            num = 3;
            continue;
label_4:
            selector = func;
            goto label_10;
        }
      }
label_2:
      return string.Empty;
label_7:
      return (string) DelegateHelper.YFeO0hWcpnKevHs85Nkp(DelegateHelper.nZ9dLZWc3h9PgHgtgIeE(1232639661 >> 3 ^ 154126491), (object) name, (object) string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088305190), values));
    }

    /// <summary>
    /// Проверить делегат на анонимную лямбду и бросить исключение, если это так.
    /// </summary>
    /// <param name="delegate">Делегат.</param>
    public static void ThrowIfAnonymousLambda(Delegate @delegate)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_9;
          case 1:
            if (!DelegateHelper.pTK8T0WcaVIDS67AF6Vb(DelegateHelper.m1oSUdWcNq1oTsfCeJs5((object) @delegate)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            goto label_6;
          case 3:
            goto label_3;
          case 4:
            if ((object) @delegate == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 3 : 3;
              continue;
            }
            goto case 1;
          default:
            goto label_2;
        }
      }
label_9:
      return;
label_3:
      return;
label_2:
      return;
label_6:
      throw new ArgumentException((string) DelegateHelper.XFiO8iWcDGKiHs3dRJBK(DelegateHelper.nZ9dLZWc3h9PgHgtgIeE(~1767720452 ^ -1767834317)));
    }

    /// <summary>
    /// Проверить, что делегат является публичным. Бросить исключение, если это не так.
    /// </summary>
    /// <param name="delegate">Делегат.</param>
    public static void ThrowIfNotPublic(Delegate @delegate)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            if ((object) @delegate == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 2:
            if (!DelegateHelper.BtGBv3Wcts3v2tbmaMxp(DelegateHelper.m1oSUdWcNq1oTsfCeJs5((object) @delegate)))
            {
              num = 3;
              continue;
            }
            goto label_8;
          case 3:
            goto label_3;
          default:
            goto label_9;
        }
      }
label_2:
      return;
label_9:
      return;
label_3:
      throw new ArgumentException((string) DelegateHelper.XFiO8iWcDGKiHs3dRJBK((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106371454)));
label_8:;
    }

    /// <summary>Получить имена аргументов делегата в виде массива.</summary>
    /// <param name="delegate">Делегат.</param>
    /// <returns>Массив имён аргументов делегата. Порядок соответствует позиции в сигнатуре.</returns>
    public static string[] GetDelegateArgumentNames(Delegate @delegate)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if ((object) @delegate != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return new string[0];
label_5:
      return ((IEnumerable<ParameterInfo>) DelegateHelper.LHXoTuWcwcChjK3ruLD8((object) @delegate.Method)).Select<ParameterInfo, string>((Func<ParameterInfo, string>) (p => p.Name)).ToArray<string>();
    }

    internal static object m1oSUdWcNq1oTsfCeJs5([In] object obj0) => (object) ((Delegate) obj0).Method;

    internal static object nZ9dLZWc3h9PgHgtgIeE(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object YFeO0hWcpnKevHs85Nkp([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static bool hwsuCgWcPriGiGncpK3g() => DelegateHelper.iECxFsWce5HFZ17arvB7 == null;

    internal static DelegateHelper w2R21iWc185W5S5GjkQ3() => DelegateHelper.iECxFsWce5HFZ17arvB7;

    internal static bool pTK8T0WcaVIDS67AF6Vb([In] object obj0) => ((MethodInfo) obj0).IsAnonymous();

    internal static object XFiO8iWcDGKiHs3dRJBK([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool BtGBv3Wcts3v2tbmaMxp([In] object obj0) => ((MethodBase) obj0).IsPublic;

    internal static object LHXoTuWcwcChjK3ruLD8([In] object obj0) => (object) ((MethodBase) obj0).GetParameters();
  }
}
