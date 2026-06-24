// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.IAutoClassGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>
  /// Интерфейс генератора кода автоимплементируемого класса
  /// </summary>
  public interface IAutoClassGenerator
  {
    /// <summary>
    /// Сгенерировать код с реализацией интерфейса и расширений интерфейсов
    /// </summary>
    /// <param name="interfaceType">Тип интерфейса</param>
    /// <param name="extensionTypes">Расширяемые типы</param>
    string GenerateCode(Type interfaceType, params Type[] extensionTypes);
  }
}
