// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Accessors.GetAccessor`3
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using NHibernate.Engine;
using NHibernate.Properties;
using System;
using System.Collections;
using System.ComponentModel;
using System.Reflection;

namespace EleWise.ELMA.Model.Accessors
{
  /// <inheritdoc />
  [EditorBrowsable(EditorBrowsableState.Never)]
  [Serializable]
  public abstract class GetAccessor<T, TVal, TData> : AccessorBase<T, TVal, TData>, IGetter
    where T : class
    where TData : class
  {
    private static object X1p1UqhmkBQP3iKJxj5K;

    /// <inheritdoc />
    protected GetAccessor(string propertyName, int dataIndex)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(propertyName, dataIndex);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <inheritdoc />
    public override bool HasGetter => true;

    /// <inheritdoc />
    public override bool HasSetter => false;

    /// <summary>Получить значение</summary>
    /// <param name="target">Объект</param>
    /// <returns>Значение</returns>
    public abstract TVal Get(T target);

    Type IGetter.ReturnType => this.PropertyType;

    MethodInfo IGetter.Method => (MethodInfo) null;

    object IGetter.GetForInsert(object owner, IDictionary mergeMap, ISessionImplementor session) => (object) this.Get((T) owner);

    object IGetter.Get(object target) => (object) this.Get((T) target);

    internal static bool eVr5v9hmnBSw6HmlTFxh() => GetAccessor<T, TVal, TData>.X1p1UqhmkBQP3iKJxj5K == null;

    internal static object sdASnhhmOflZXpYetunO() => GetAccessor<T, TVal, TData>.X1p1UqhmkBQP3iKJxj5K;
  }
}
