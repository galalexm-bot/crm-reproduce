// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Impl.SimpleBoundVariableService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Services.Impl
{
  /// <summary>
  /// Хранилище данных на основе статического словаря ключ-значение
  /// </summary>
  public class SimpleBoundVariableService : 
    SimpleBoundVariableServiceBase,
    ISessionBoundVariableService,
    IAbstractBoundVariableService
  {
    private readonly System.Collections.Generic.Dictionary<string, object> dictionary;
    internal static SimpleBoundVariableService rwBQ7bBJQbJ1u4hnOTre;

    /// <inheritdoc />
    protected override IDictionary<string, object> Dictionary => (IDictionary<string, object>) this.dictionary;

    public SimpleBoundVariableService()
    {
      SimpleBoundVariableService.HjgF9ZBJ806Dd3cS7BXf();
      this.dictionary = new System.Collections.Generic.Dictionary<string, object>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void HjgF9ZBJ806Dd3cS7BXf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool AS8H54BJCeTr1jUymhUL() => SimpleBoundVariableService.rwBQ7bBJQbJ1u4hnOTre == null;

    internal static SimpleBoundVariableService aCLcfIBJva34sH0Pg8ET() => SimpleBoundVariableService.rwBQ7bBJQbJ1u4hnOTre;
  }
}
