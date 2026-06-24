// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.EntityExtensionManager`3
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Managers
{
  /// <summary>Менеджер сущности-расширения интерфейса</summary>
  /// <typeparam name="TBase">Тип основной сущности</typeparam>
  /// <typeparam name="T">Тип сущности-расширения</typeparam>
  /// <typeparam name="IdT">Тип идентификатора</typeparam>
  public class EntityExtensionManager<TBase, T, IdT> : 
    EntityExtensionManager<TBase, T, IdT, IEntityManager<TBase, IdT>>
    where TBase : class, IEntity<IdT>
    where T : class, TBase
  {
    private static object wedq6RhfgGFJ7cQiWXc6;

    public EntityExtensionManager()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool cn80jEhf5su6mqssdn9s() => EntityExtensionManager<TBase, T, IdT>.wedq6RhfgGFJ7cQiWXc6 == null;

    internal static object znSd1khfjdwY13F8eLUW() => EntityExtensionManager<TBase, T, IdT>.wedq6RhfgGFJ7cQiWXc6;
  }
}
