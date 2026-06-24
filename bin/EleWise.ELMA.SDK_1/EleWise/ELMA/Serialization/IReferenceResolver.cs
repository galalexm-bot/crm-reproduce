// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Serialization.IReferenceResolver
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Serialization
{
  /// <summary>Резолвер ссылок на объекты по идентификаторам</summary>
  internal interface IReferenceResolver
  {
    /// <summary>Резолв ссылки по идентификатору $id</summary>
    /// <param name="reference">Идентификатор ссылки $id</param>
    /// <returns>Объект по ссылке</returns>
    object ResolveReference(string reference);

    /// <summary>Добавить ссылку на объект по идентификатору</summary>
    /// <param name="reference">Идентификатор ссылки</param>
    /// <param name="value">Объект</param>
    void AddReference(string reference, object value);

    /// <summary>Попытаться получить ссылку по объекту</summary>
    /// <param name="value">Объект</param>
    /// <param name="metadata">Метаданные</param>
    /// <param name="reference">Идентификатор ссылки на этот объект</param>
    /// <returns><c>true</c>, если существует ссылка на указанный объект</returns>
    bool TryGetReference(object value, IMetadata metadata, out string reference);
  }
}
