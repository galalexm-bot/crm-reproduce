// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.IdTypeAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут указывает уникальный идентификатор типа для идентификатора сущности
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
  public class IdTypeAttribute : Attribute
  {
    private Guid typeUid;
    private static IdTypeAttribute DWiKjYo8nVeAcNfSl5rR;

    /// <summary>Ctor</summary>
    /// <param name="typeUid">Уникальный идентификатор типа</param>
    public IdTypeAttribute(string typeUid)
    {
      IdTypeAttribute.rF2lGXo8eLnNinl70F1j();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.typeUid = new Guid(typeUid);
            num = 2;
            continue;
          case 2:
            goto label_3;
          default:
            Contract.ArgumentNotNull((object) typeUid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751289120));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>UID типа данных</summary>
    public Guid TypeUid => this.typeUid;

    internal static void rF2lGXo8eLnNinl70F1j() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Jp9laQo8Ogtyp9Ftadp3() => IdTypeAttribute.DWiKjYo8nVeAcNfSl5rR == null;

    internal static IdTypeAttribute YxqO3ho82Jl2eQdEWpQv() => IdTypeAttribute.DWiKjYo8nVeAcNfSl5rR;
  }
}
