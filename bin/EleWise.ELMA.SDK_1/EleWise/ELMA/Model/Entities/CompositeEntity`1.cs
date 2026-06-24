// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.CompositeEntity`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Entities
{
  /// <summary>Составная сущность</summary>
  /// <typeparam name="IdT">Тип идентификатора</typeparam>
  public abstract class CompositeEntity<IdT> : 
    Entity<IdT>,
    ICompositeEntity<IdT>,
    IEntity<IdT>,
    IEntity,
    IIdentified,
    ICompositeEntity
  {
    internal static object ANZ0eShZLnTN8vR9ufbx;

    /// <summary>Получить список составляющих сущностей</summary>
    /// <returns>Список составляющих сущностей</returns>
    public abstract IEnumerable<IEntity> GetCompositeEntities();

    protected CompositeEntity()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Y1WRolhZUhJJHF6FslwS() => CompositeEntity<IdT>.ANZ0eShZLnTN8vR9ufbx == null;

    internal static object rLdGAFhZsRB1fWQVk5x0() => CompositeEntity<IdT>.ANZ0eShZLnTN8vR9ufbx;
  }
}
