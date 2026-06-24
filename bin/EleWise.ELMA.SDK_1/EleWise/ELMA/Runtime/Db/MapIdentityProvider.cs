// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.MapIdentityProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode;

namespace EleWise.ELMA.Runtime.Db
{
  /// <summary>
  /// Абстрактный класс провайдера генератора идентификатора для класса OR-маппинга
  /// </summary>
  public abstract class MapIdentityProvider : IMapIdentityProvider
  {
    /// <summary>MaxLo по умолчанию</summary>
    protected const string MaxLoParamValue = "100";
    private static MapIdentityProvider OQ0FXtWity8LDUTAsOkY;

    /// <summary>Провайдер для текущего потока</summary>
    public static IMapIdentityProvider CurrentThreadProvider { get; set; }

    /// <inheritdoc />
    public abstract void SetGenerator(IIdMapper mapping, string tableName, string idColumnName);

    protected MapIdentityProvider()
    {
      MapIdentityProvider.NikbboWi67kXbT9GM4rW();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void NikbboWi67kXbT9GM4rW() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool JoRok7WiwZZUsBE5Qlgu() => MapIdentityProvider.OQ0FXtWity8LDUTAsOkY == null;

    internal static MapIdentityProvider YpWkBUWi4auI4diNFfJc() => MapIdentityProvider.OQ0FXtWity8LDUTAsOkY;
  }
}
