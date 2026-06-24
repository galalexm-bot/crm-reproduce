// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Configuration.GenericProviderCollection`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Configuration.Provider;

namespace EleWise.ELMA.Configuration
{
  /// <summary>Коллекция для провайдеров</summary>
  /// <typeparam name="T">Тип провайдера, должен быть унаследован от <see cref="T:System.Configuration.Provider.ProviderBase" /></typeparam>
  public class GenericProviderCollection<T> : ProviderCollection where T : ProviderBase
  {
    private static object ToZDHbfWiBHgx0IJ3q9p;

    public override void Add(ProviderBase provider)
    {
      int num = 1;
      string paramName;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (provider != null)
            {
              if ((object) (provider as T) != null)
              {
                num = 3;
                continue;
              }
              goto case 5;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
              continue;
            }
          case 2:
            goto label_7;
          case 3:
            base.Add(provider);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 2 : 2;
            continue;
          case 4:
            goto label_5;
          case 5:
            paramName = typeof (T).ToString();
            num = 4;
            continue;
          default:
            goto label_2;
        }
      }
label_7:
      return;
label_2:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70099325));
label_5:
      throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638733903), paramName);
    }

    /// <summary>Получить провайдер по имени</summary>
    /// <param name="name">Имя провайдера, как указано в кофигурации</param>
    public T this[string name] => (T) base[name];

    public GenericProviderCollection()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool csG1RtfWR4QY0jJ2CYjG() => GenericProviderCollection<T>.ToZDHbfWiBHgx0IJ3q9p == null;

    internal static object a7Zv17fWqRc5oYTur7Fd() => GenericProviderCollection<T>.ToZDHbfWiBHgx0IJ3q9p;
  }
}
