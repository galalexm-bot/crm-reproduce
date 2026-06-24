// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.MetadataInternalContainer.Containers.UninitializedPropertyValueContainer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.MetadataInternalContainer.Containers
{
  /// <summary>
  /// Контейнер отложенной инициализации контейнера хранения данных свойства
  /// </summary>
  internal class UninitializedPropertyValueContainer : IPropertyDefaultValueContainer
  {
    private readonly Guid metadataUid;
    private readonly Guid propertyUid;
    private readonly Func<Guid, Guid, IPropertyDefaultValueContainer> initFunc;
    private IPropertyDefaultValueContainer defaultValueContainer;
    internal static UninitializedPropertyValueContainer q3HCndhoEh3StHkUC0bo;

    /// <summary>Ctor</summary>
    /// <param name="metadataUid">Uid метаданных</param>
    /// <param name="propertyUid">Uid свойства</param>
    /// <param name="initFunc">Функция инициализации</param>
    public UninitializedPropertyValueContainer(
      Guid metadataUid,
      Guid propertyUid,
      Func<Guid, Guid, IPropertyDefaultValueContainer> initFunc)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.metadataUid = metadataUid;
      this.propertyUid = propertyUid;
      this.initFunc = initFunc;
    }

    IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
    {
      int num = 1;
      IPropertyDefaultValueContainer defaultValueContainer1;
      IPropertyDefaultValueContainer defaultValueContainer2;
      while (true)
      {
        switch (num)
        {
          case 1:
            defaultValueContainer2 = this.defaultValueContainer;
            if (defaultValueContainer2 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            goto label_5;
          default:
            this.defaultValueContainer = defaultValueContainer1 = this.initFunc(this.metadataUid, this.propertyUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 2 : 1;
            continue;
        }
      }
label_5:
      defaultValueContainer2 = defaultValueContainer1;
label_6:
      return defaultValueContainer2.Initialize();
    }

    internal static bool R43asFhofUdJKxEPudXt() => UninitializedPropertyValueContainer.q3HCndhoEh3StHkUC0bo == null;

    internal static UninitializedPropertyValueContainer kDHdgohoQMCYnwYcCgyt() => UninitializedPropertyValueContainer.q3HCndhoEh3StHkUC0bo;
  }
}
