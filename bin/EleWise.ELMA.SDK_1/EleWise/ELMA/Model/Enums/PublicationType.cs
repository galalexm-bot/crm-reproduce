// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Enums.PublicationType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Model.Enums
{
  /// <summary>Тип публикации</summary>
  [Flags]
  public enum PublicationType
  {
    /// <summary>Мягкая публикация</summary>
    /// <remarks>Не требует перестроение дельта-сборок</remarks>
    Soft = 0,
    /// <summary>Дельта-публикация</summary>
    /// <remarks>
    /// Разрешает дельта-публикацию при создании и изменении объекта метаданных
    /// </remarks>
    Delta = 1,
    /// <summary>Требуется перезапуск сервера</summary>
    /// <remarks>
    /// Разрешает дельта-публикацию только при создании объекта метаданных
    /// </remarks>
    Restart = 3,
  }
}
