// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IEntityCopyRuleProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Дополнительные правила для копирования документа</summary>
  [ExtensionPoint(ServiceScope.Application, ComponentType.All)]
  public interface IEntityCopyRuleProvider
  {
    /// <summary>Проверить тип</summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    bool CheckType(object entity);

    /// <summary>Сформировать правила</summary>
    /// <param name="builder"></param>
    void InitRules<T>(RestrictionsBuilder<T> builder) where T : class;
  }
}
