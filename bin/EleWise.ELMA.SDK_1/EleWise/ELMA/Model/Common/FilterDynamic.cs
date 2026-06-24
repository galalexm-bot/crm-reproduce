// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Common.FilterDynamic
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Accessors;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Common
{
  /// <summary>
  /// Фильтр (базовый класс), поддерживающий работу с внутренним контейнером
  /// </summary>
  [DebuggerTypeProxy(typeof (DynamicDebugView))]
  public class FilterDynamic : Filter, IValueContainerObjectInternal, IDynamicMetaObjectProvider
  {
    internal static FilterDynamic esWYKihqTInoUpHPOcHj;

    /// <summary>Получить экземпляр класса</summary>
    /// <param name="creator">Метод создания</param>
    /// <returns>Экземпляр класса</returns>
    protected internal static ICreator<T, TData> ResolveCreator<T, TData, TClassData>(
      Func<T, TData> creator)
      where TData : class
      where TClassData : TData
    {
      return Creator<T>.ResolveCreator<TData, TClassData>(creator);
    }

    /// <inheritdoc />
    DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Expression parameter) => (DynamicMetaObject) new MetaDynamic(parameter, (IValueContainerObjectInternal) this, (GetPropertyAccessorDelegate) (name => (IAccessor) FilterDynamic.vpkHJ4hq2B9FoDX9ybV4(this.GetType(), (object) name, false)));

    IEnumerable<object> IValueContainerObjectInternal.GetData() => this.GetData͏();

    /// <summary>Получить контейнеры с данными</summary>
    protected internal virtual IEnumerable<object> GetData͏() => Enumerable.Empty<object>();

    /// <summary>Получить список ассоров</summary>
    /// <remarks><see cref="!:ValueContainerObjectInternalExtensions.GetAccessors͏" /></remarks>
    protected static IEnumerable<object> GetAccessors͏() => Enumerable.Empty<object>();

    public FilterDynamic()
    {
      FilterDynamic.L6g1KOhqOwmoW6VWh5hn();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool UM4BSwhqkKnFPkmApvl9() => FilterDynamic.esWYKihqTInoUpHPOcHj == null;

    internal static FilterDynamic NDjRPGhqn3FVZLCInfTZ() => FilterDynamic.esWYKihqTInoUpHPOcHj;

    internal static void L6g1KOhqOwmoW6VWh5hn() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object vpkHJ4hq2B9FoDX9ybV4(Type type, [In] object obj1, bool declaredOnly) => (object) type.GetAccessor((string) obj1, declaredOnly);
  }
}
