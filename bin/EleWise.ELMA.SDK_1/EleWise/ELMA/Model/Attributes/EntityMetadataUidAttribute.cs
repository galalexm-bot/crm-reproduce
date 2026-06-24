// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.EntityMetadataUidAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут уникального идентификатора метаданных интерфейса сущности
  /// </summary>
  [AttributeUsage(AttributeTargets.Class, Inherited = false)]
  public sealed class EntityMetadataUidAttribute : Attribute
  {
    internal static EntityMetadataUidAttribute fZpRs9ofVSiHUfSalwow;

    /// <summary>Ctor</summary>
    /// <param name="uid">Уникальный идентификатор метаданных интерфейса сущности</param>
    public EntityMetadataUidAttribute(string uid)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Uid = new Guid(uid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>
    /// Уникальный идентификатор метаданных интерфейса сущности
    /// </summary>
    internal Guid Uid { get; }

    internal static bool Cl9NIhofS1OGmfLH3Qev() => EntityMetadataUidAttribute.fZpRs9ofVSiHUfSalwow == null;

    internal static EntityMetadataUidAttribute eDAi3fofiINmSmHiyllv() => EntityMetadataUidAttribute.fZpRs9ofVSiHUfSalwow;
  }
}
