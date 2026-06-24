// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.IMapIdentityProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using NHibernate.Mapping.ByCode;

namespace EleWise.ELMA.Runtime.Db
{
  /// <summary>
  /// Провайдер генератора идентификатора для класса OR-маппинга
  /// </summary>
  public interface IMapIdentityProvider
  {
    /// <summary>Установить генератор</summary>
    /// <param name="mapping">Мэппинг</param>
    /// <param name="tableName">Имя таблицы</param>
    /// <param name="idColumnName">Имя колонки идентификатора</param>
    void SetGenerator(IIdMapper mapping, string tableName, string idColumnName);
  }
}
