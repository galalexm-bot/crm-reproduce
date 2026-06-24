// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.IConvertTypeWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [ExtensionPoint(ServiceScope.Application, ComponentType.All)]
  public interface IConvertTypeWrapper
  {
    /// <summary>Тип</summary>
    Type OriginalType { get; }

    /// <summary>Обертка для типа</summary>
    Type ConvertType { get; }

    /// <summary>Нужно ли применять конвертер</summary>
    /// <param name="type"></param>
    /// <returns></returns>
    bool RelativeConvertNeeded(Type type);

    /// <summary>Создать обертку из оригинального объекта</summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    object ConvertWrapper(object obj);
  }
}
