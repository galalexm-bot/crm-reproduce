// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.InstanceCreators.IInstanceCreator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.DataClasses;
using System;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.InstanceCreators
{
  /// <summary>Интерфейс создателя экземпляров</summary>
  internal interface IInstanceCreator
  {
    /// <summary>Можно ли создать экземпляр указанного типа</summary>
    /// <param name="type">Ожидаемый тип</param>
    /// <returns><c>true</c>, если можно создать экземпляр указанного типа</returns>
    bool CanCreateInstance(Type type);

    /// <summary>Создать экземпляр</summary>
    /// <param name="dataClass">Структура обмена данными</param>
    /// <param name="type">Ожидаемый тип</param>
    /// <returns>Экземпляр</returns>
    object CreateInstance(DataClass dataClass, Type type);
  }
}
