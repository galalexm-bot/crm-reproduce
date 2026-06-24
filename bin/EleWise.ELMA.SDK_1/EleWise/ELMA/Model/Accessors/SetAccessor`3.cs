// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Accessors.SetAccessor`3
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using NHibernate.Properties;
using System;
using System.ComponentModel;
using System.Reflection;

namespace EleWise.ELMA.Model.Accessors
{
  /// <inheritdoc />
  [EditorBrowsable(EditorBrowsableState.Never)]
  [Serializable]
  public abstract class SetAccessor<T, TVal, TData> : AccessorBase<T, TVal, TData>, ISetter
    where T : class
    where TData : class
  {
    internal static object aAHFh3hm1G6ymQD1rKar;

    /// <inheritdoc />
    protected SetAccessor(string propertyName, int dataIndex)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(propertyName, dataIndex);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <inheritdoc />
    public override bool HasGetter => false;

    /// <inheritdoc />
    public override bool HasSetter => true;

    /// <summary>Установить значение</summary>
    /// <param name="target">Объект</param>
    /// <param name="value">Значение</param>
    public abstract void Set(T target, TVal value);

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
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_4:
      return;
label_2:;
    }

    internal static bool uQb6WVhmNPXuJeRLv7NW() => SetAccessor<T, TVal, TData>.aAHFh3hm1G6ymQD1rKar == null;

    internal static object UP4W4mhm308QY4FVvXIo() => SetAccessor<T, TVal, TData>.aAHFh3hm1G6ymQD1rKar;
  }
}
