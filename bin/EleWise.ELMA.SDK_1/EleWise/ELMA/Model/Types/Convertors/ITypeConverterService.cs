// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Convertors.ITypeConverterService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Model.Types.Convertors
{
  /// <summary>Сервис для работы с преобразователями типов</summary>
  public interface ITypeConverterService
  {
    /// <summary>
    /// Проверяет возможность преобразования типа-источника в целевой тип
    /// </summary>
    /// <param name="sourceTypeUid">Идентификатор типа-источника</param>
    /// <param name="targetTypeUid">Идентификатор целевого типа</param>
    /// <returns><c>True</c>, если преобразование возможно</returns>
    bool CanConvert(Guid sourceTypeUid, Guid targetTypeUid);

    /// <summary>Получить конвертер в целевой тип</summary>
    /// <param name="targetTypeUid">Идентификатор целевого типа</param>
    /// <returns>Конвертер</returns>
    ITypeConvertor GetConverterToTargetType(Guid targetTypeUid);
  }
}
