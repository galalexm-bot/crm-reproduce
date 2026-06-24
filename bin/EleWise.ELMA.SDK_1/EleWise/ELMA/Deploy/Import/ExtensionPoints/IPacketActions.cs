// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.IPacketActions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Models;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  /// <summary>
  /// Точка расширения для выполнения действиями над пакетом импорта сущностей
  /// </summary>
  [ExtensionPoint(ComponentType.Server)]
  internal interface IPacketActions
  {
    /// <summary>Действие до коммита пакета импорта сущностей</summary>
    /// <param name="args">Аргументы</param>
    /// <returns><c>true</c> если выполнение прошло успешно</returns>
    bool BeforeCommitAction(PacketActionArgs args);

    /// <summary>Действие после коммита пакета импорта сущностей</summary>
    /// <param name="args">Аргументы</param>
    /// <returns><c>true</c> если выполнение прошло успешно</returns>
    bool AfterCommitAction(PacketActionArgs args);

    /// <summary>Действие обработки ошибки</summary>
    /// <param name="args">Аргументы</param>
    /// <param name="beforeCommit"><c>true</c> если ошибка произошла при выполнении метода <see cref="M:EleWise.ELMA.Deploy.Import.ExtensionPoints.IPacketActions.BeforeCommitAction(EleWise.ELMA.Deploy.Models.PacketActionArgs)" /></param>
    /// <returns><c>true</c> если необходимо прервать процесс импорта</returns>
    bool ErrorAction(PacketActionArgs args, bool beforeCommit);
  }
}
