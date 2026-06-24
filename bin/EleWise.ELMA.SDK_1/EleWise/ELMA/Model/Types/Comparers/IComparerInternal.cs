// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Comparers.IComparerInternal
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Model.Types.Comparers
{
  /// <summary>
  /// Внутренний интерфейс сравнивателя для свойств - сортированных списоков сущностей
  /// </summary>
  internal interface IComparerInternal
  {
    /// <summary>Установить сравнивателю роль, за которую он отвечает</summary>
    /// <param name="role">NHibernate роль спискового свойства сущности</param>
    void SetRole(string role);
  }
}
