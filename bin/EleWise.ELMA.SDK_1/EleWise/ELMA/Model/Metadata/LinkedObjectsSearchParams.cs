// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.LinkedObjectsSearchParams
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>
  /// Входные параметры для запуска поиска связанных объектов с контекстом
  /// </summary>
  public class LinkedObjectsSearchParams : RuntimeObjectsSearchParams
  {
    private static LinkedObjectsSearchParams jPwvUJbN3vL9sU7PlFll;

    /// <summary>Все объекты контекста проверки</summary>
    public ICollection<ILinkedObject> AllObjects { get; }

    /// <summary>Ctor</summary>
    public LinkedObjectsSearchParams()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.AllObjects = (ICollection<ILinkedObject>) new List<ILinkedObject>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    internal static bool uAZ9Y5bNpve8Vb37moor() => LinkedObjectsSearchParams.jPwvUJbN3vL9sU7PlFll == null;

    internal static LinkedObjectsSearchParams QU4YJIbNaW11LPwMdXoc() => LinkedObjectsSearchParams.jPwvUJbN3vL9sU7PlFll;
  }
}
