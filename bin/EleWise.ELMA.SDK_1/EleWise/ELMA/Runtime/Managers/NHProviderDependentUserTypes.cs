// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Managers.NHProviderDependentUserTypes
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using NHibernate.UserTypes;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Runtime.Managers
{
  /// <summary>Кеш провайдерозависимых типов данных NHibernate</summary>
  internal static class NHProviderDependentUserTypes
  {
    private static readonly Dictionary<Type, Type> cache;
    internal static NHProviderDependentUserTypes d5V2E8WMf3Gs9t6nDifv;

    /// <summary>Зарегистрировать тип</summary>
    /// <typeparam name="TBaseType">Базовый тип</typeparam>
    /// <typeparam name="TImplType">Тип реализации для выборанного провайдера БД</typeparam>
    public static void Register<TBaseType, TImplType>() => NHProviderDependentUserTypes.cache[typeof (TBaseType)] = typeof (TImplType);

    /// <summary>Получить провайдерозависимый тип</summary>
    /// <typeparam name="TBaseType">Базовый тип</typeparam>
    /// <returns>Провайдерозависимый тип</returns>
    public static Type Get<TBaseType>() => NHProviderDependentUserTypes.cache[typeof (TBaseType)];

    /// <summary>
    /// Получить экземпляр провайдерозависимого типа данных NHibernate
    /// </summary>
    /// <typeparam name="TBaseType"></typeparam>
    /// <returns></returns>
    public static IUserType GetInstance<TBaseType>() where TBaseType : IUserType
    {
      Type type = NHProviderDependentUserTypes.Get<TBaseType>();
      return !(type == (Type) null) ? (IUserType) Activator.CreateInstance(type) : throw new ArgumentException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874148291), (object) typeof (TBaseType).FullName));
    }

    static NHProviderDependentUserTypes()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            NHProviderDependentUserTypes.cache = new Dictionary<Type, Type>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
            continue;
          case 2:
            NHProviderDependentUserTypes.DmJ9xZWMvUGDv4WHCIen();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void DmJ9xZWMvUGDv4WHCIen() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool DtyAXTWMQWfyMWFuuMgc() => NHProviderDependentUserTypes.d5V2E8WMf3Gs9t6nDifv == null;

    internal static NHProviderDependentUserTypes KEQuahWMCRLBOGKV3U4m() => NHProviderDependentUserTypes.d5V2E8WMf3Gs9t6nDifv;
  }
}
