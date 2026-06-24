// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Packaging.ISoftInstallState
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Packaging
{
  /// <summary>
  /// Интерфейс состояния "мягкой" установки компонента (не требующего перезапуск сервера).
  /// </summary>
  [Obsolete("Интерфейс утратил актуальность - не используйте его", true)]
  public interface ISoftInstallState
  {
    /// <summary>Компонент.</summary>
    ManifestStoreComponentInfo ComponentInfo { get; }

    /// <summary>Журнал развёртывания компонента.</summary>
    string Log { get; }

    /// <summary>Был компонент уже обработан или нет?</summary>
    bool HasBeenProcessed { get; }

    /// <summary>Порядковый номер обработанного компонента.</summary>
    int Index { get; }

    /// <summary>Имеются ли ошибки при развёртывании.</summary>
    bool HasErrors { get; }
  }
}
