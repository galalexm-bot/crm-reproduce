// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.INHibernatePropertyTypeMapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Helpers
{
  /// <summary>
  /// Интерфейс формирования типа свойства NHibernate маппинга
  /// </summary>
  public interface INHibernatePropertyTypeMapper
  {
    /// <summary>Тип хранения</summary>
    /// <typeparam name="TPersistentType">Тип хранения</typeparam>
    void Type<TPersistentType>();

    /// <summary>Тип хранения</summary>
    /// <param name="persistentType">Тип хранения</param>
    void Type(System.Type persistentType);

    /// <summary>Тип хранения</summary>
    /// <typeparam name="TPersistentType">Тип хранения</typeparam>
    /// <param name="parameter">Параметры конструктора</param>
    void Type<TPersistentType>(object parameter);

    /// <summary>Тип хранения</summary>
    /// <param name="persistentType">Тип хранения</param>
    /// <param name="parameter">Параметры конструктора</param>
    void Type(System.Type persistentType, object parameter);

    /// <summary>Длина</summary>
    /// <param name="length">Длина</param>
    void Length(int length);
  }
}
