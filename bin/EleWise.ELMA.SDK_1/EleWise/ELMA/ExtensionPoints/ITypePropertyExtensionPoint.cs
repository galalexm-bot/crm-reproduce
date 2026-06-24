// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.ITypePropertyExtensionPoint
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Точка расширения для типа</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface ITypePropertyExtensionPoint
  {
    /// <summary>
    /// Проверяет возможность применения точки расширения для типа
    /// </summary>
    /// <param name="type">Тип</param>
    bool Can(Type type);

    /// <summary>Получить значение по умолчанию для типа</summary>
    /// <param name="type">Тип</param>
    /// <param name="idType">Тип идентификатора</param>
    /// <param name="forIdentifier">Для идентификатора</param>
    object DefaultValue(Type type, Type idType, bool forIdentifier);

    /// <summary>
    /// Проверяет, является ли значение идентификатора значением по умолчанию
    /// </summary>
    /// <param name="type">Тип</param>
    /// <param name="idType">Тип идентификатора</param>
    /// <param name="idValue">Значение идентификатора</param>
    bool IsDefaultId(Type type, Type idType, object idValue);

    /// <summary>
    /// Конвертирует значение идентификатора в числовое для проверки на значение по умолчанию
    /// </summary>
    /// <param name="type">Тип</param>
    /// <param name="idType">Тип идентификатора</param>
    /// <param name="idValue">Значение идентификатора</param>
    long ConvertToNewId(Type type, Type idType, object idValue);

    /// <summary>
    /// Конвертировать целочисленный идентификатор в идентификатор типа
    /// </summary>
    /// <param name="type">Тип</param>
    /// <param name="idType">Тип идентификатора</param>
    /// <param name="id">Целочисленное значение идентификатора</param>
    object ConvertId(Type type, Type idType, object id);
  }
}
