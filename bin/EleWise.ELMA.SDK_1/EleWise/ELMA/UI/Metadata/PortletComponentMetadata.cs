// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Metadata.PortletComponentMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.CodeGeneration;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.UI.Metadata
{
  /// <summary>Метаданные пользовательского портлета</summary>
  [XmlRoot("PortletComponent")]
  [DataContract]
  [EleWise.ELMA.Model.Attributes.Uid("{76584C56-99AD-4D3E-B0AB-7758333251BD}")]
  [Serializable]
  public sealed class PortletComponentMetadata : ComponentMetadata
  {
    /// <summary>Уникальный идентификатор данного типа метаданных</summary>
    public new static readonly Guid TypeUid;
    internal static PortletComponentMetadata qM7284Bha4Fw19vcAVLT;

    /// <summary>Ctor</summary>
    public PortletComponentMetadata()
    {
      PortletComponentMetadata.O6B68aBhwBSvaUW8oDhr();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="moduleUid">Уникальный идентификатор модуля</param>
    public PortletComponentMetadata(Guid moduleUid)
    {
      PortletComponentMetadata.O6B68aBhwBSvaUW8oDhr();
      // ISSUE: explicit constructor call
      base.\u002Ector(moduleUid);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Метаданные контекста персонализации портлета</summary>
    public PortletPersonalizationMetadata PersonalizationContext
    {
      get => this.\u003CPersonalizationContext\u003Ek__BackingField;
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
              this.\u003CPersonalizationContext\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
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

    /// <inheritdoc />
    public override Guid GetMetadataTypeUid() => PortletComponentMetadata.TypeUid;

    /// <inheritdoc />
    public override void InitNew()
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            PortletComponentMetadata.WwKPGpBh4Ir8H176QqnA((object) this.PersonalizationContext);
            num = 3;
            continue;
          case 2:
            goto label_7;
          case 3:
            PortletComponentMetadata.khm5XlBh669wqP844ckm((object) this.PersonalizationContext, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561101234));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
            continue;
          case 4:
            if (this.PersonalizationContext == null)
            {
              num = 6;
              continue;
            }
            goto label_2;
          case 5:
            base.InitNew();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 4 : 4;
            continue;
          case 6:
            this.PersonalizationContext = new PortletPersonalizationMetadata();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 1 : 1;
            continue;
          case 7:
            goto label_9;
          default:
            PortletComponentMetadata.aArZhyBhAi5wCSh5O6of((object) this.PersonalizationContext, (object) EleWise.ELMA.SR.T((string) PortletComponentMetadata.tkr5jgBhH4w4gmuHaxqk(-1350312861 << 3 ^ 2082342996)));
            num = 2;
            continue;
        }
      }
label_7:
      return;
label_9:
      return;
label_2:;
    }

    static PortletComponentMetadata()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            PortletComponentMetadata.TypeUid = new Guid((string) PortletComponentMetadata.tkr5jgBhH4w4gmuHaxqk(654297945 ^ 654254119));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void O6B68aBhwBSvaUW8oDhr() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Lwty84BhDUbn8c8xbnCK() => PortletComponentMetadata.qM7284Bha4Fw19vcAVLT == null;

    internal static PortletComponentMetadata y7mNqMBhtUToNEDnr1IX() => PortletComponentMetadata.qM7284Bha4Fw19vcAVLT;

    internal static void WwKPGpBh4Ir8H176QqnA([In] object obj0) => ((AbstractMetadata) obj0).InitNew();

    internal static void khm5XlBh669wqP844ckm([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).Name = (string) obj1;

    internal static object tkr5jgBhH4w4gmuHaxqk(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void aArZhyBhAi5wCSh5O6of([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).DisplayName = (string) obj1;

    /// <summary>Информация о типе метаданных</summary>
    [Component]
    private new sealed class Info : IMetadataTypeInfo
    {
      internal static object Nnr6QYQoQ5RYCUntOnyI;

      /// <inheritdoc />
      public string Name => (string) PortletComponentMetadata.Info.pUIHrZQo8aLiTXX191Si((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2139015692));

      /// <inheritdoc />
      public string Description => (string) PortletComponentMetadata.Info.pUIHrZQo8aLiTXX191Si((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 653959565));

      /// <inheritdoc />
      public Type MetadataType => PortletComponentMetadata.Info.vC0oqoQoZF8MLfwbtgaC(__typeref (PortletComponentMetadata));

      /// <inheritdoc />
      public Type GeneratorType => PortletComponentMetadata.Info.vC0oqoQoZF8MLfwbtgaC(__typeref (PortletComponentMetadataGenerator));

      public Info()
      {
        PortletComponentMetadata.Info.klTKscQouAMwEfBj6PEU();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object pUIHrZQo8aLiTXX191Si([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool YIekHjQoCc3NI9nd38w2() => PortletComponentMetadata.Info.Nnr6QYQoQ5RYCUntOnyI == null;

      internal static PortletComponentMetadata.Info YUg9ZEQov0JiKltaM4UC() => (PortletComponentMetadata.Info) PortletComponentMetadata.Info.Nnr6QYQoQ5RYCUntOnyI;

      internal static Type vC0oqoQoZF8MLfwbtgaC([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

      internal static void klTKscQouAMwEfBj6PEU() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
