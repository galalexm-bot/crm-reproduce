// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Managers.IReferenceOnEntityManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities.EntityReferences;

namespace EleWise.ELMA.Runtime.Managers
{
  /// <summary>Интерфейс для управления ссылками на объект</summary>
  public interface IReferenceOnEntityManager
  {
    /// <summary>Сохранить ссылку на объект</summary>
    /// <param name="ref"></param>
    /// <returns></returns>
    string SaveRef(ReferenceOnEntity @ref);

    /// <summary>Загрузить ссылку на объект</summary>
    /// <param name="id"></param>
    /// <returns></returns>
    ReferenceOnEntity LoadRef(string id);
  }
}
