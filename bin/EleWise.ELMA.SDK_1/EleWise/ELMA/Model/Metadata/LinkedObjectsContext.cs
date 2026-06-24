// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.LinkedObjectsContext
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>
  /// Контекст проверки на связанность объектов с ограниченным списком объектов
  /// </summary>
  public class LinkedObjectsContext : RuntimeObjectsContext
  {
    private static LinkedObjectsContext WwfhqobNeD0hIAi6OgsJ;

    /// <summary>Все объекты контекста проверки</summary>
    public ICollection<ILinkedObject> AllObjects { get; }

    /// <summary>Ctor</summary>
    public LinkedObjectsContext()
    {
      LinkedObjectsContext.RGf3OGbNNVlLWV0RLr23();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.AllObjects = (ICollection<ILinkedObject>) new List<ILinkedObject>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    internal static void RGf3OGbNNVlLWV0RLr23() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool mc6AEnbNPxRZNdyI5mRM() => LinkedObjectsContext.WwfhqobNeD0hIAi6OgsJ == null;

    internal static LinkedObjectsContext pVIixNbN1prHD2iJkguE() => LinkedObjectsContext.WwfhqobNeD0hIAi6OgsJ;
  }
}
