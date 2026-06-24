// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.EntityManagerBehavior
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Common;
using j3AmrhgkCleVTGdEwA;
using NHibernate;

namespace EleWise.ELMA.Model.Managers
{
  /// <summary>
  /// Базовая реализация <see cref="T:EleWise.ELMA.Model.Managers.IEntityManagerBehavior" /> для изменения поведения менеджера <see cref="T:EleWise.ELMA.Model.Managers.EntityManager`1" />
  /// </summary>
  public class EntityManagerBehavior : IEntityManagerBehavior
  {
    private static EntityManagerBehavior Ci1N6mhQO0j6F9latuL8;

    /// <inheritdoc />
    public virtual void OnCreateCriteria(ICriteria criteria, IEntityFilter filter)
    {
    }

    /// <inheritdoc />
    public virtual void OnLoad(object target)
    {
    }

    public EntityManagerBehavior()
    {
      EntityManagerBehavior.V5GyWkhQPg5GnC79DfTl();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void V5GyWkhQPg5GnC79DfTl() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool uFyWhFhQ2JHUh4adL0WE() => EntityManagerBehavior.Ci1N6mhQO0j6F9latuL8 == null;

    internal static EntityManagerBehavior RXNjlMhQeajTAMLZBb16() => EntityManagerBehavior.Ci1N6mhQO0j6F9latuL8;
  }
}
