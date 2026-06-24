// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.EntitySubTypeDescriptor`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>
  /// Базовый класс для дескрипторов типов конкретных сущностей
  /// </summary>
  public abstract class EntitySubTypeDescriptor<TEntity> : EntityDescriptor where TEntity : IEntity
  {
    private static object uB24BKoyr2aCjgDmCQMg;

    public override Guid SubTypeUid => this.EntityUid;

    public override bool Visible => false;

    /// <summary>Уникальный идентификатор типа сущности</summary>
    protected virtual Guid EntityUid => InterfaceActivator.UID<TEntity>(false);

    public override object SerializeSimple(IEntity value) => this.SerializeSimple((TEntity) value);

    public virtual object SerializeSimple(TEntity value) => this.SerializeSimple((object) value, typeof (TEntity));

    public virtual TEntity DeserializeSimple(object value) => (TEntity) this.DeserializeSimple(value, typeof (TEntity));

    protected EntitySubTypeDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool dQuVv4oygh2hnPy9kk3H() => EntitySubTypeDescriptor<TEntity>.uB24BKoyr2aCjgDmCQMg == null;

    internal static object g5kptmoy5So7MZ89xpnA() => EntitySubTypeDescriptor<TEntity>.uB24BKoyr2aCjgDmCQMg;
  }
}
