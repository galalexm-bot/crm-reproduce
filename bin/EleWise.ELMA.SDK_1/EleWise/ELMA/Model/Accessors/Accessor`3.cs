// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Accessors.Accessor`3
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
  public abstract class Accessor<T, TVal, TData> : AccessorBase<T, TVal, TData>, IGetter, ISetter
    where T : class
    where TData : class
  {
    internal static object E5H91ihmpiKf3I0InmZg;

    /// <inheritdoc />
    protected Accessor(string propertyName, int dataIndex)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(propertyName, dataIndex);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <inheritdoc />
    public override bool HasGetter => true;

    /// <inheritdoc />
    public override bool HasSetter => true;

    /// <summary>Получить значение</summary>
    /// <param name="target">Объект</param>
    /// <returns>Значение</returns>
    public abstract TVal Get(T target);

    /// <summary>Установить значение</summary>
    /// <param name="target">Объект</param>
    /// <param name="value">Значение</param>
    public abstract void Set(T target, TVal value);

    Type IGetter.ReturnType => this.PropertyType;

    MethodInfo IGetter.Method => (MethodInfo) null;

    object IGetter.GetForInsert(object owner, IDictionary mergeMap, ISessionImplementor session) => (object) this.Get((T) owner);

    object IGetter.Get(object target) => (object) this.Get((T) target);

    MethodInfo ISetter.Method => (MethodInfo) null;

    void ISetter.Set(object target, object value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_4;
          case 1:
            this.Set((T) target, !(value is TVal val) ? default (TVal) : val);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_4:
      return;
label_2:;
    }

    internal static bool qqQflAhmaOVMxnXoiQM1() => Accessor<T, TVal, TData>.E5H91ihmpiKf3I0InmZg == null;

    internal static object JpRFOFhmDF4RAXGyFybf() => Accessor<T, TVal, TData>.E5H91ihmpiKf3I0InmZg;
  }
}
