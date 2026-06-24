// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.Creator`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.NH.Proxy;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace EleWise.ELMA.Model.Entities
{
  /// <summary>
  /// Класс-контейнер метода создания экземпляра данных динамической сущности/фильтра
  /// </summary>
  /// <typeparam name="T">Тип сущности/фильтра</typeparam>
  [EditorBrowsable(EditorBrowsableState.Never)]
  public static class Creator<T>
  {
    private static Creator<T>.ICreator instance;
    private static object KDpsyhh8kDXgEHOCLwkg;

    /// <summary>Получить эеземлпяр класса</summary>
    /// <param name="creator">Метод создания</param>
    /// <returns>Экземпляр класса</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static EleWise.ELMA.Model.Entities.ICreator<T, TData> ResolveCreator<TData, TClassData>(
      Func<T, TData> creator)
      where TData : class
      where TClassData : TData
    {
      if (Creator<T>.instance == null)
        Creator<T>.SetCreator<TData>(creator, typeof (TClassData));
      return (EleWise.ELMA.Model.Entities.ICreator<T, TData>) Creator<T>.instance;
    }

    internal static void SetCreator<TData>(Func<T, TData> creator, Type dataClassType) where TData : class
    {
      if (Creator<T>.instance == null)
        Creator<T>.instance = (Creator<T>.ICreator) new Creator<T>.CreatorInternal<TData>();
      ((Creator<T>.CreatorInternal<TData>) Creator<T>.instance).SetCreator(creator, dataClassType);
    }

    internal static Type DataType
    {
      get
      {
        int num = 1;
        Type dataType;
        while (true)
        {
          switch (num)
          {
            case 1:
              Creator<T>.ICreator instance = Creator<T>.instance;
              if (instance == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
                continue;
              }
              dataType = instance.DataType;
              break;
            case 2:
              goto label_9;
            default:
              dataType = (Type) null;
              break;
          }
          if ((object) dataType == null)
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 2 : 2;
          else
            break;
        }
        return dataType;
label_9:
        return typeof (T).GetNestedType(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304556407), BindingFlags.NonPublic);
      }
    }

    internal static bool fxeIuuh8nLOj7StbGcSk() => Creator<T>.KDpsyhh8kDXgEHOCLwkg == null;

    internal static object Ny93fUh8OCkYnHbi6pyy() => Creator<T>.KDpsyhh8kDXgEHOCLwkg;

    private interface ICreator
    {
      Type DataType { get; }
    }

    private sealed class CreatorInternal<TData> : Creator<T>.ICreator, EleWise.ELMA.Model.Entities.ICreator<T, TData>
      where TData : class
    {
      private readonly PublishCacheContext.Local<Func<T, TData>> creator;
      private readonly PublishCacheContext.Local<Type> dataClassType;
      private int dataIndex;
      private static object V3NK2BCsePHmU3kDINAf;

      /// <summary>Создать данные</summary>
      /// <returns>Экземпляр данных</returns>
      public TData Create(T entity)
      {
        if (!(entity is IEntityProxy entityProxy) || entityProxy.HibernateLazyInitializer == null)
          return this.creator.Value(entity);
        IEnumerable<object> data1 = ((IValueContainerObjectInternal) entityProxy.HibernateLazyInitializer.GetImplementation()).GetData();
        if (this.dataIndex >= 0)
          return (TData) data1.ElementAt<object>(this.dataIndex);
        TData data2;
        (data2, this.dataIndex) = data1.Select<object, (TData, int)>((Func<object, int, (TData, int)>) ((d, i) => (d as TData, i))).First<(TData, int)>((Func<(TData, int), bool>) (d => (object) d.data != null));
        return data2;
      }

      public Type DataType => this.dataClassType.Value;

      public void SetCreator(Func<T, TData> creator, Type dataClassType)
      {
        this.creator.Value = creator;
        this.dataClassType.Value = dataClassType;
      }

      public CreatorInternal()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        this.creator = new PublishCacheContext.Local<Func<T, TData>>();
        this.dataClassType = new PublishCacheContext.Local<Type>();
        this.dataIndex = -1;
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool xvhWZyCsPSm7xXLj3KO4() => Creator<T>.CreatorInternal<TData>.V3NK2BCsePHmU3kDINAf == null;

      internal static object yfZYOXCs1aB674PGJtxU() => Creator<T>.CreatorInternal<TData>.V3NK2BCsePHmU3kDINAf;
    }
  }
}
