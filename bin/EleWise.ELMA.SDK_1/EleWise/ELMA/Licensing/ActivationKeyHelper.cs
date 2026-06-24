// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Licensing.ActivationKeyHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Licensing
{
  /// <summary>Класс-помощник для преобразования ключей активации</summary>
  public static class ActivationKeyHelper
  {
    private static readonly ConcurrentDictionary<string, IEnumerable<ActivationKeyHelper.ActivationKeyInfo>> cache;
    private static ActivationKeyHelper rrrS93ASvMLNPnu9Yfd;

    /// <summary>
    /// Получить ключ активации для лицензируемой части приложения
    /// </summary>
    /// <param name="activationKey">Ключ активации</param>
    /// <param name="unitUid">Уникальный ключ лицензируемой части приложения</param>
    /// <returns>Ключ активации для данной лицензируемой части или NULL (если ключ сформирован не стандартным генератором ключей или не содержит ключ актиации для данной части приложения)</returns>
    public static string GetUnitActivationKey(string activationKey, Guid unitUid)
    {
      int num = 2;
      ActivationKeyHelper.ActivationKeyInfo activationKeyInfo;
      string unitHash;
      while (true)
      {
        switch (num)
        {
          case 1:
            unitHash = ActivationKeyHelper.iHCRfGAqHQMrkXpQSyK(unitUid).ToString();
            num = 4;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_7;
          case 4:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            activationKeyInfo = ActivationKeyHelper.GetActivationKeyInfos((object) activationKey).FirstOrDefault<ActivationKeyHelper.ActivationKeyInfo>((Func<ActivationKeyHelper.ActivationKeyInfo, bool>) (i => ActivationKeyHelper.\u003C\u003Ec__DisplayClass0_0.fjsgRAfrzhAhekGV3pvt(ActivationKeyHelper.\u003C\u003Ec__DisplayClass0_0.SOUShmfrcc9hbETfTwfs((object) i), (object) unitHash)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
            continue;
          default:
            if (activationKeyInfo == null)
            {
              num = 3;
              continue;
            }
            goto label_8;
        }
      }
label_7:
      return (string) null;
label_8:
      return (string) ActivationKeyHelper.xHNZ4MAKjAyyLUY6ltA((object) activationKeyInfo);
    }

    /// <summary>
    /// Получить ключ активации для лицензируемой части приложения
    /// </summary>
    /// <param name="activationKey">Ключ активации</param>
    /// <param name="unitUid">Уникальный ключ лицензируемой части приложения</param>
    /// <returns>Ключ активации для данной лицензируемой части или NULL (если ключ сформирован не стандартным генератором ключей или не содержит ключ актиации для данной части приложения)</returns>
    public static string[] GetUnitActivationKeys(string activationKey, Guid unitUid)
    {
      int num = 1;
      string unitHash;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            unitHash = ActivationKeyHelper.iHCRfGAqHQMrkXpQSyK(unitUid).ToString();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 2 : 0;
            continue;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      IEnumerable<ActivationKeyHelper.ActivationKeyInfo> source = ActivationKeyHelper.GetActivationKeyInfos((object) activationKey).Where<ActivationKeyHelper.ActivationKeyInfo>((Func<ActivationKeyHelper.ActivationKeyInfo, bool>) (i => ActivationKeyHelper.\u003C\u003Ec__DisplayClass1_0.MDVPBcfghkYqcdVbXoZj(ActivationKeyHelper.\u003C\u003Ec__DisplayClass1_0.x2Og7tfgb5tooBwa5kCf((object) i), (object) unitHash)));
      // ISSUE: reference to a compiler-generated field
      Func<ActivationKeyHelper.ActivationKeyInfo, string> func = ActivationKeyHelper.\u003C\u003Ec.\u003C\u003E9__1_1;
      Func<ActivationKeyHelper.ActivationKeyInfo, string> selector;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        ActivationKeyHelper.\u003C\u003Ec.\u003C\u003E9__1_1 = selector = (Func<ActivationKeyHelper.ActivationKeyInfo, string>) (i => (string) ActivationKeyHelper.\u003C\u003Ec.fUoRsRfgCbCjSxtM8HC6((object) i));
      }
      else
        goto label_7;
label_6:
      return source.Select<ActivationKeyHelper.ActivationKeyInfo, string>(selector).ToArray<string>();
label_7:
      selector = func;
      goto label_6;
    }

    public static uint GetUnitHashCode(Guid uid) => ActivationKeyHelper.MF95YnATfcWQAOrefWv(ActivationKeyHelper.hRoS2EAXnDFt1TLGLtA(uid.GetHashCode()), 0);

    private static IEnumerable<ActivationKeyHelper.ActivationKeyInfo> GetActivationKeyInfos(
      object actKey)
    {
      if (actKey != null)
        actKey = (object) ((string) actKey).Trim(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917293984).ToCharArray());
      if (!string.IsNullOrEmpty((string) actKey))
      {
        if (((string) actKey).StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(993438473 ^ 993410107)))
        {
          try
          {
            byte[] numArray = Convert.FromBase64String(((string) actKey).Substring(3));
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte num in numArray)
            {
              string str = Convert.ToString(num, 16).ToUpper();
              if (str.Length < 2)
                str = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1597012150 ^ 1597007674) + str;
              stringBuilder.Append(str);
            }
            string str1 = stringBuilder.ToString().Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870909061), "");
            List<ActivationKeyHelper.ActivationKeyInfo> activationKeyInfos = new List<ActivationKeyHelper.ActivationKeyInfo>();
            char[] charArray = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217493499).ToCharArray();
            foreach (string str2 in str1.Split(charArray, StringSplitOptions.RemoveEmptyEntries))
            {
              string[] strArray = str2.Split(z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870862987).ToCharArray());
              activationKeyInfos.Add(new ActivationKeyHelper.ActivationKeyInfo()
              {
                ModuleHash = strArray[0],
                ActivationKey = strArray[1]
              });
            }
            ActivationKeyHelper.cache[(string) actKey] = (IEnumerable<ActivationKeyHelper.ActivationKeyInfo>) activationKeyInfos;
            return (IEnumerable<ActivationKeyHelper.ActivationKeyInfo>) activationKeyInfos;
          }
          catch
          {
            ActivationKeyHelper.cache[(string) actKey] = (IEnumerable<ActivationKeyHelper.ActivationKeyInfo>) new ActivationKeyHelper.ActivationKeyInfo[0];
            return (IEnumerable<ActivationKeyHelper.ActivationKeyInfo>) new ActivationKeyHelper.ActivationKeyInfo[0];
          }
        }
      }
      return (IEnumerable<ActivationKeyHelper.ActivationKeyInfo>) new ActivationKeyHelper.ActivationKeyInfo[0];
    }

    static ActivationKeyHelper()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ActivationKeyHelper.spNbQuAkWYhfyct8dLS();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ActivationKeyHelper.cache = new ConcurrentDictionary<string, IEnumerable<ActivationKeyHelper.ActivationKeyInfo>>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static uint iHCRfGAqHQMrkXpQSyK(Guid uid) => ActivationKeyHelper.GetUnitHashCode(uid);

    internal static object xHNZ4MAKjAyyLUY6ltA([In] object obj0) => (object) ((ActivationKeyHelper.ActivationKeyInfo) obj0).ActivationKey;

    internal static bool F6L1DFAidXPoyQ23gif() => ActivationKeyHelper.rrrS93ASvMLNPnu9Yfd == null;

    internal static ActivationKeyHelper Y7o917ARiV6GNFSfIwk() => ActivationKeyHelper.rrrS93ASvMLNPnu9Yfd;

    internal static object hRoS2EAXnDFt1TLGLtA([In] int obj0) => (object) BitConverter.GetBytes(obj0);

    internal static uint MF95YnATfcWQAOrefWv([In] object obj0, [In] int obj1) => BitConverter.ToUInt32((byte[]) obj0, obj1);

    internal static void spNbQuAkWYhfyct8dLS() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    private class ActivationKeyInfo
    {
      internal static object oCAUuRfrr3KPXqLG9sMo;

      public string ModuleHash
      {
        get => this.\u003CModuleHash\u003Ek__BackingField;
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
                this.\u003CModuleHash\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
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

      public string ActivationKey
      {
        get => this.\u003CActivationKey\u003Ek__BackingField;
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
                this.\u003CActivationKey\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
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

      public ActivationKeyInfo()
      {
        ActivationKeyHelper.ActivationKeyInfo.V4RyK6frjIXggVZjdl55();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool jn8b1CfrgBj0oBr7541H() => ActivationKeyHelper.ActivationKeyInfo.oCAUuRfrr3KPXqLG9sMo == null;

      internal static ActivationKeyHelper.ActivationKeyInfo pak4NCfr5EZtmNW9g5vc() => (ActivationKeyHelper.ActivationKeyInfo) ActivationKeyHelper.ActivationKeyInfo.oCAUuRfrr3KPXqLG9sMo;

      internal static void V4RyK6frjIXggVZjdl55() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
