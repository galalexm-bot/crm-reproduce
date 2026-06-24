// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Accessors.AccessorBase`3
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;

namespace EleWise.ELMA.Model.Accessors
{
  /// <inheritdoc />
  [EditorBrowsable(EditorBrowsableState.Never)]
  [Serializable]
  public abstract class AccessorBase<T, TVal, TData> : IAccessor
    where T : class
    where TData : class
  {
    private static readonly MethodInfo GetDataMethod;
    private readonly int dataIndex;
    private PropertyInfo property;
    private Type dataType;
    private IList<CustomAttributeData> customAttributesData;
    private static object Oe3XX6hmZSnf0mR7WDKX;

    /// <summary>ctor</summary>
    /// <param name="propertyName">Имя свойства</param>
    /// <param name="dataIndex">Индекс наследования</param>
    protected AccessorBase(string propertyName, int dataIndex)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.PropertyType = typeof (TVal);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.dataIndex = dataIndex;
            num = 2;
            continue;
          default:
            this.PropertyName = propertyName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 1 : 3;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public Type PropertyType { get; }

    /// <inheritdoc />
    public string PropertyName { get; }

    /// <inheritdoc />
    public abstract bool HasGetter { get; }

    /// <inheritdoc />
    public abstract bool HasSetter { get; }

    /// <inheritdoc />
    public Expression GetExpression(Expression instance) => (Expression) Expression.Property((Expression) Expression.Convert((Expression) Expression.Call(AccessorBase<T, TVal, TData>.GetDataMethod, AccessorBase<T, TVal, TData>.GetLimitedSelf(instance), (Expression) Expression.Constant((object) this.dataIndex)), typeof (TData)), this.PropertyName);

    /// <inheritdoc />
    public Expression SetExpression(Expression instance, Expression value) => (Expression) Expression.Assign((Expression) Expression.Property((Expression) Expression.Convert((Expression) Expression.Call(AccessorBase<T, TVal, TData>.GetDataMethod, AccessorBase<T, TVal, TData>.GetLimitedSelf(instance), (Expression) Expression.Constant((object) this.dataIndex)), typeof (TData)), this.PropertyName), value);

    private static Expression GetLimitedSelf(Expression instance)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (AccessorBase<T, TVal, TData>.AreEquivalent(instance.Type, typeof (T)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return (Expression) Expression.Convert(instance, typeof (T));
label_3:
      return instance;
    }

    private static bool AreEquivalent(Type t1, Type t2)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(t1 == t2))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return t1.IsEquivalentTo(t2);
label_3:
      return true;
    }

    static AccessorBase()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            AccessorBase<T, TVal, TData>.GetDataMethod = typeof (EleWise.ELMA.Model.Accessors.Accessors).GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70238029), BindingFlags.Static | BindingFlags.NonPublic);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool zC12njhmukILJKFf2LZd() => AccessorBase<T, TVal, TData>.Oe3XX6hmZSnf0mR7WDKX == null;

    internal static object AIi2Q4hmIUliuJ5wtPEQ() => AccessorBase<T, TVal, TData>.Oe3XX6hmZSnf0mR7WDKX;
  }
}
