// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IQueryFunctionResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>
  /// Расширение, предоставляющее возможность добавлять функции в запросы EQL
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IQueryFunctionResult
  {
    /// <summary>Имя функции</summary>
    string FunctionName { get; }

    /// <summary>Получить константное значение</summary>
    /// <param name="metadata"></param>
    /// <param name="propName"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    object GetValue(EntityMetadata metadata, string propName, object[] parameters);
  }
}
