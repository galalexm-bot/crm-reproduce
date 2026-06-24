// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Metadata.PageComponentMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.UI.CodeGeneration;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.UI.Metadata
{
  /// <summary>Метаданные пользовательской страницы</summary>
  [XmlRoot("PageComponent")]
  [EleWise.ELMA.Model.Attributes.Uid("{CBEA0822-E430-4BCF-8D6E-DD5AC76AE84E}")]
  [DataContract]
  [Serializable]
  public sealed class PageComponentMetadata : ComponentMetadata
  {
    /// <summary>Уникальный идентификатор данного типа метаданных</summary>
    public new static readonly Guid TypeUid;
    private static PageComponentMetadata pE8TpRBhUh92Q8M2h5QC;

    /// <summary>Ctor</summary>
    public PageComponentMetadata()
    {
      PageComponentMetadata.OSAKt3BhzEvAyYY476mu();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="moduleUid">Уникальный идентификатор модуля</param>
    public PageComponentMetadata(Guid moduleUid)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(moduleUid);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <inheritdoc />
    public override Guid GetMetadataTypeUid() => PageComponentMetadata.TypeUid;

    static PageComponentMetadata()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            PageComponentMetadata.OSAKt3BhzEvAyYY476mu();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            PageComponentMetadata.TypeUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87310407));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static void OSAKt3BhzEvAyYY476mu() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool ykEuSFBhsidp752luTfr() => PageComponentMetadata.pE8TpRBhUh92Q8M2h5QC == null;

    internal static PageComponentMetadata n7Y2D0Bhc73XpDEcor4R() => PageComponentMetadata.pE8TpRBhUh92Q8M2h5QC;

    /// <summary>Информация о типе метаданных</summary>
    [Component]
    private new sealed class Info : IMetadataTypeInfo
    {
      private static object oGR0ffQoIAAMsHKUKqdb;

      /// <inheritdoc />
      public string Name => EleWise.ELMA.SR.T((string) PageComponentMetadata.Info.wLW5S3QoirMcqMs0T5Ia(-1638402543 ^ -1638608881));

      /// <inheritdoc />
      public string Description => (string) PageComponentMetadata.Info.Lb7urJQoRtf8YYhqCfov((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606971372));

      /// <inheritdoc />
      public Type MetadataType => PageComponentMetadata.Info.vJ41BgQoqq8TDVMFLlov(__typeref (PageComponentMetadata));

      /// <inheritdoc />
      public Type GeneratorType => PageComponentMetadata.Info.vJ41BgQoqq8TDVMFLlov(__typeref (PageComponentMetadataGenerator));

      public Info()
      {
        PageComponentMetadata.Info.HxvypmQoKtuYHMd6WFhu();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object wLW5S3QoirMcqMs0T5Ia(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static bool SQW5xrQoV1TQdqECbwLk() => PageComponentMetadata.Info.oGR0ffQoIAAMsHKUKqdb == null;

      internal static PageComponentMetadata.Info PbTkrhQoSrYjLNss4TcI() => (PageComponentMetadata.Info) PageComponentMetadata.Info.oGR0ffQoIAAMsHKUKqdb;

      internal static object Lb7urJQoRtf8YYhqCfov([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static Type vJ41BgQoqq8TDVMFLlov([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

      internal static void HxvypmQoKtuYHMd6WFhu() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
