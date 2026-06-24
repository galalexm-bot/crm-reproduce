// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.IAuditObject
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using System;
using System.Drawing;

namespace EleWise.ELMA.Events.Audit
{
  /// <summary>Объект события аудита</summary>
  public interface IAuditObject
  {
    /// <summary>Uid объекта</summary>
    Guid Uid { get; }

    /// <summary>Тип объекта. Может быть не задан</summary>
    IAuditObjectType Type { get; }

    /// <summary>Родительский объект</summary>
    IAuditObject Parent { get; }

    /// <summary>Название объекта</summary>
    string Name { get; }

    /// <summary>Отображаемое название объекта</summary>
    string DisplayName { get; }

    /// <summary>Изображение объекта (16x16)</summary>
    Image Image { get; }

    /// <summary>Метаданные изображение объекта</summary>
    MetadataImage MetadataImage { get; }

    /// <summary>
    /// Получить иконку указанного размера. Если иконки такого размера нет и onlyToSize == false, то возвращается иконка с размером, наиболее близким к указанному, иначе null.
    /// </summary>
    /// <param name="size"></param>
    /// <returns></returns>
    MetadataImage GetImage(int size);
  }
}
