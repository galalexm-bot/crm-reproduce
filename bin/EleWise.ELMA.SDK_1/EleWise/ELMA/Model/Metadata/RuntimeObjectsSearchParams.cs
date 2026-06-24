// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.RuntimeObjectsSearchParams
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>
  /// Входные параметры для запуска поиска связанных объектов
  /// </summary>
  public class RuntimeObjectsSearchParams
  {
    private static RuntimeObjectsSearchParams GghsJUb3SHF2PqC7wDuM;

    /// <summary>Объекты, по которым нужно найти связанные</summary>
    public ICollection<ILinkedObject> ObjectsToSearching { get; }

    /// <summary>Отмеченные объекты</summary>
    public ICollection<ILinkedObject> CheckedObjects { get; }

    /// <summary>Ctor</summary>
    public RuntimeObjectsSearchParams()
    {
      RuntimeObjectsSearchParams.DoJmhhb3q8DhyjjUJ5UI();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.ObjectsToSearching = (ICollection<ILinkedObject>) new List<ILinkedObject>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
            continue;
          case 2:
            this.CheckedObjects = (ICollection<ILinkedObject>) new List<ILinkedObject>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void DoJmhhb3q8DhyjjUJ5UI() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool yHZWZQb3iukMqM0xIAJS() => RuntimeObjectsSearchParams.GghsJUb3SHF2PqC7wDuM == null;

    internal static RuntimeObjectsSearchParams mnG7SUb3RxTCe1X6GqjE() => RuntimeObjectsSearchParams.GghsJUb3SHF2PqC7wDuM;
  }
}
