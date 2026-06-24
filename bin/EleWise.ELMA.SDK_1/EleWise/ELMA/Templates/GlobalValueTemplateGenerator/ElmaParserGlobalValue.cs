// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Templates.GlobalValueTemplateGenerator.ElmaParserGlobalValue
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Services;
using EleWise.TemplateGenerator;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Templates.GlobalValueTemplateGenerator
{
  public abstract class ElmaParserGlobalValue : IElmaParserGlobalValue
  {
    internal static ElmaParserGlobalValue jE6HWABNqADWq3vnTuSa;

    public abstract FormatedValue Parse(string[] propertyNames);

    /// <summary>Парсить Guid</summary>
    /// <returns></returns>
    protected virtual string ParseGuid(Guid guid)
    {
      int num = 1;
      Func<Guid, string> func;
      string guid1;
      IRuntimeApplication serviceNotNull;
      while (true)
      {
        switch (num)
        {
          case 1:
            guid1 = (string) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_6;
          case 3:
            guid1 = ((IProvider) ElmaParserGlobalValue.Ev7a4pBNnFoH4dXcUgia((object) serviceNotNull)).GuidQuerySintaxis(guid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 5;
            continue;
          case 4:
          case 5:
            goto label_8;
          case 6:
            ElmaParserGlobalValue.HikV27BNk8PGNMYm4TAG(ElmaParserGlobalValue.IaZHsDBNTr4I96N8Vy5R(-1978478350 ^ -1978429156));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 4 : 3;
            continue;
          case 7:
            if (serviceNotNull.MainProvider != null)
            {
              num = 3;
              continue;
            }
            goto label_8;
          case 8:
            if (func != null)
            {
              num = 9;
              continue;
            }
            goto label_6;
          case 9:
            guid1 = func(guid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 6 : 1;
            continue;
          default:
            if (!ContextVars.TryGetValue<Func<Guid, string>>((string) ElmaParserGlobalValue.IaZHsDBNTr4I96N8Vy5R(-398663332 ^ -398614350), out func))
            {
              serviceNotNull = Locator.GetServiceNotNull<IRuntimeApplication>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 4 : 7;
              continue;
            }
            num = 8;
            continue;
        }
      }
label_6:
      return (string) null;
label_8:
      return guid1;
    }

    protected ElmaParserGlobalValue()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object IaZHsDBNTr4I96N8Vy5R(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void HikV27BNk8PGNMYm4TAG([In] object obj0) => ContextVars.Remove((string) obj0);

    internal static object Ev7a4pBNnFoH4dXcUgia([In] object obj0) => (object) ((IRuntimeApplication) obj0).MainProvider;

    internal static bool xTvRkLBNKvv4HST2hmkw() => ElmaParserGlobalValue.jE6HWABNqADWq3vnTuSa == null;

    internal static ElmaParserGlobalValue zyrZd0BNXT5QbCRtIYiV() => ElmaParserGlobalValue.jE6HWABNqADWq3vnTuSa;
  }
}
