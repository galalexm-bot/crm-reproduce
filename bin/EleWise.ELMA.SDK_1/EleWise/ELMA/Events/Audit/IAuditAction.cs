// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.IAuditAction
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using System;
using System.Drawing;

namespace EleWise.ELMA.Events.Audit
{
  /// <summary>Действие с объектом аудита</summary>
  public interface IAuditAction
  {
    /// <summary>Uid действия</summary>
    Guid Uid { get; }

    /// <summary>Название действия</summary>
    string Name { get; }

    /// <summary>Отображаемое название действия</summary>
    string DisplayName { get; }

    /// <summary>Описание действия</summary>
    string Description { get; }

    /// <summary>Изображение действия (16x16)</summary>
    Image Image { get; }

    /// <summary>Метаданные изображение действия</summary>
    MetadataImage MetadataImage { get; }
  }
}
