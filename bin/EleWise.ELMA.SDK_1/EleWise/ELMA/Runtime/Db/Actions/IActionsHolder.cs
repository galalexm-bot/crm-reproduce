// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Actions.IActionsHolder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;

namespace EleWise.ELMA.Runtime.Db.Actions
{
  /// <summary>
  /// Интерфейс класса, содержащего наборы действий по преобразованию БД
  /// </summary>
  public interface IActionsHolder
  {
    /// <summary>Действия после создания таблиц и колонок</summary>
    List<IDbAction> TablesCreatedActions { get; }

    /// <summary>Действия после удаления таблиц и колонок</summary>
    List<IDbAction> TablesDeletedActions { get; }

    /// <summary>Действия после создания внешних ключей</summary>
    List<IDbAction> ForeignKeysCreatedActions { get; }

    /// <summary>Действия после создания первичных ключей</summary>
    List<IDbAction> PrimaryKeysCreatedActions { get; }
  }
}
