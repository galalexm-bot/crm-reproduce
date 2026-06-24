// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.ScriptMethodInfoHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Serialization;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Web.Script.Serialization;

namespace EleWise.ELMA.Helpers
{
  /// <summary>Хелпер для работы с ScriptMethodInfo</summary>
  public static class ScriptMethodInfoHelper
  {
    internal static ScriptMethodInfoHelper Yrw9uyhj2ESEoTGTfLsd;

    /// <summary>Сериализовать в строку</summary>
    /// <param name="methodInfo">Информация о методе</param>
    /// <returns>Сериализованнная строка в JSON формате</returns>
    public static string Serialize(ScriptMethodInfo methodInfo)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (methodInfo == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 3:
            goto label_9;
          case 4:
            if (ScriptMethodInfoHelper.TenUDkhjNtFdiOmV4aXT(ScriptMethodInfoHelper.dy9e5rhj1nxF4GZbTwYt((object) methodInfo)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 2 : 2;
              continue;
            }
            if (ScriptMethodInfoHelper.WwRWeNhj3Hhc6t1rZ0kS(methodInfo.MetadataUid, Guid.Empty))
            {
              num = 3;
              continue;
            }
            goto label_10;
          default:
            goto label_6;
        }
      }
label_6:
      return string.Empty;
label_9:
      return methodInfo.Name;
label_10:
      return (string) ScriptMethodInfoHelper.PRlnKLhjpuPTVoso5T8Q((object) new JsonSerializer(), (object) methodInfo);
    }

    /// <summary>Десериализовать из строки</summary>
    /// <param name="methodName">Имя метода</param>
    /// <returns>Информация о методе</returns>
    public static ScriptMethodInfo Deserialize(string methodName)
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (ScriptMethodInfoHelper.YmsAoZhjacqekLBr7RXs((object) methodName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867381263)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            if (!ScriptMethodInfoHelper.TenUDkhjNtFdiOmV4aXT((object) methodName))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 1;
              continue;
            }
            goto label_2;
          case 3:
            goto label_2;
          default:
            goto label_4;
        }
      }
label_2:
      return new ScriptMethodInfo() { Name = methodName };
label_4:
      ScriptMethodInfo scriptMethodInfo1;
      try
      {
        ScriptMethodInfo scriptMethodInfo2 = new JsonSerializer().Deserialize<ScriptMethodInfo>(methodName);
        int num2 = 2;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 3:
              goto label_2;
            case 2:
              if (scriptMethodInfo2 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 1;
                continue;
              }
              goto case 4;
            case 4:
              scriptMethodInfo1 = scriptMethodInfo2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_2;
            default:
              ScriptMethodInfoHelper.CR45j4hjDxpZIDoj4Zcv((object) Logger.Log, (object) ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 1;
              continue;
          }
        }
      }
label_3:
      return scriptMethodInfo1;
    }

    internal static object dy9e5rhj1nxF4GZbTwYt([In] object obj0) => (object) ((ScriptMethodInfo) obj0).Name;

    internal static bool TenUDkhjNtFdiOmV4aXT([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static bool WwRWeNhj3Hhc6t1rZ0kS([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object PRlnKLhjpuPTVoso5T8Q([In] object obj0, [In] object obj1) => (object) ((JavaScriptSerializer) obj0).Serialize(obj1);

    internal static bool sq0POAhjej43CUCfthJI() => ScriptMethodInfoHelper.Yrw9uyhj2ESEoTGTfLsd == null;

    internal static ScriptMethodInfoHelper mpAXlrhjPHlBtMT1tFJF() => ScriptMethodInfoHelper.Yrw9uyhj2ESEoTGTfLsd;

    internal static bool YmsAoZhjacqekLBr7RXs([In] object obj0, [In] object obj1) => ((string) obj0).StartsWith((string) obj1);

    internal static void CR45j4hjDxpZIDoj4Zcv([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);
  }
}
