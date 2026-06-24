// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Db.DbModel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Db
{
  public class DbModel
  {
    internal static DbModel Tr0c5EooXDVxcwfipoQN;

    public DbModel()
    {
      DbModel.kUMuSjoonwvly7kGRpuf();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void kUMuSjoonwvly7kGRpuf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Q3uQIpooTopPt5EdBUxy() => DbModel.Tr0c5EooXDVxcwfipoQN == null;

    internal static DbModel Lwg7qvookq4BguDbebW3() => DbModel.Tr0c5EooXDVxcwfipoQN;

    /// <summary>Таблицы БД</summary>
    public static class Tables
    {
      /// <summary>Таблица хранения абстрактных метаданных</summary>
      public static class AbstractMetadata
      {
        /// <summary>Поля</summary>
        public static class Fields
        {
          /// <summary>Идентификатор</summary>
          public const string Id = "Id";
          /// <summary>Уникальный идентификатор</summary>
          public const string Uid = "Uid";
        }
      }

      /// <summary>Таблица хранения именованных метаданных</summary>
      public static class NamedMetadata
      {
        /// <summary>Поля</summary>
        public static class Fields
        {
          /// <summary>Название</summary>
          public const string Name = "Name";
          /// <summary>Отображаемое название</summary>
          public const string DisplayName = "DisplayName";
          /// <summary>Описание</summary>
          public const string Description = "Description";
        }
      }
    }
  }
}
