// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.TypeToMap
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Ссылка на реальный на .NET тип</summary>
  [DataContract]
  [Serializable]
  public sealed class TypeToMap
  {
    private static TypeToMap h7OTaVb1a643i98evPMp;

    /// <summary>
    /// Имя реального .NET типа, в который может маппиться структура обмена данными
    /// </summary>
    /// <remarks>
    /// Имя типа должно быть полным, включая имя сборки, например:
    /// EleWise.ELMA.Model.Metadata.DataClassMetadata, EleWise.ELMA.SDK
    /// </remarks>
    [XmlElement("FullTypeName")]
    [DataMember]
    public string FullTypeName
    {
      get => this.\u003CFullTypeName\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CFullTypeName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public TypeToMap()
    {
      TypeToMap.SQidYEb1wHEQPRuJpOub();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool cMCnAbb1DSaKSm6Fuh6K() => TypeToMap.h7OTaVb1a643i98evPMp == null;

    internal static TypeToMap FYuMtsb1t21r7TXnrNLI() => TypeToMap.h7OTaVb1a643i98evPMp;

    internal static void SQidYEb1wHEQPRuJpOub() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
