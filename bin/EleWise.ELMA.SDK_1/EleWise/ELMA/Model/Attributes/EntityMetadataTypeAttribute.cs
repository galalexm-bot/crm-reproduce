// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.EntityMetadataTypeAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Указывает тип метаданных сущности</summary>
  public class EntityMetadataTypeAttribute : Attribute
  {
    private EntityMetadataType type;
    internal static EntityMetadataTypeAttribute U0mV2ro8fnRC4Doy6Olk;

    /// <summary>Ctor</summary>
    /// <param name="type">Тип метаданных сущности</param>
    public EntityMetadataTypeAttribute(EntityMetadataType type)
    {
      EntityMetadataTypeAttribute.dgVh7lo8vM2bNI5lKwCM();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.type = type;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Тип метаданных сущности</summary>
    public EntityMetadataType Type => this.type;

    internal static void dgVh7lo8vM2bNI5lKwCM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool VCpsOeo8QNeAx5ZXpE2A() => EntityMetadataTypeAttribute.U0mV2ro8fnRC4Doy6Olk == null;

    internal static EntityMetadataTypeAttribute G7NFtUo8CrJEpMfSpsZW() => EntityMetadataTypeAttribute.U0mV2ro8fnRC4Doy6Olk;
  }
}
