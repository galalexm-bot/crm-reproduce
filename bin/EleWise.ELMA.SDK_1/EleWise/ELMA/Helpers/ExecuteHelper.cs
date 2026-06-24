// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.ExecuteHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Helpers
{
  public static class ExecuteHelper
  {
    private static ExecuteHelper aaAcuJhLw7AKDFiIIeJA;

    public static void InvokeSafe(System.Action action)
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        bool flag;
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
              continue;
            case 2:
            case 4:
label_18:
              if (num3 < 200)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 5 : 5;
                continue;
              }
              goto label_13;
            case 3:
              goto label_21;
            case 5:
              if (flag)
              {
                num2 = 3;
                continue;
              }
              goto case 1;
            case 6:
              goto label_17;
            case 7:
              num3 = 0;
              num2 = 6;
              continue;
            default:
              try
              {
                ExecuteHelper.iy5mEXhLHicAmFi8nwmT((object) action);
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
                  num4 = 0;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_18;
                    default:
                      flag = true;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 0;
                      continue;
                  }
                }
              }
              catch (Exception ex)
              {
                int num5 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0)
                  num5 = 0;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_18;
                    case 2:
                      ++num3;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
                      continue;
                    default:
                      ExecuteHelper.UZEfNZhLAVkfa3fD8Sn4(2000);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 1 : 0;
                      continue;
                  }
                }
              }
          }
        }
label_17:
        flag = false;
        num1 = 2;
      }
label_21:
      return;
label_13:;
    }

    internal static void iy5mEXhLHicAmFi8nwmT([In] object obj0) => ((System.Action) obj0)();

    internal static void UZEfNZhLAVkfa3fD8Sn4([In] int obj0) => Thread.Sleep(obj0);

    internal static bool zd1dSGhL47yCGtX5PMp3() => ExecuteHelper.aaAcuJhLw7AKDFiIIeJA == null;

    internal static ExecuteHelper VLRlZZhL65qIdO1ZV8TY() => ExecuteHelper.aaAcuJhLw7AKDFiIIeJA;
  }
}
