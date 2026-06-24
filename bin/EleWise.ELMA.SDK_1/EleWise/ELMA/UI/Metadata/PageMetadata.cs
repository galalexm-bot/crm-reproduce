// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Metadata.PageMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.CodeGeneration;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.UI.Metadata
{
  /// <summary>Метаданные страницы</summary>
  [Image(typeof (PageMetadata), "performance_matrix_user", 32, ImageFormatType.IconPack, false)]
  [XmlRoot("Page")]
  [Image(typeof (PageMetadata), "performance_matrix_user", 16, ImageFormatType.IconPack, false)]
  public class PageMetadata : FormMetadata
  {
    public static readonly Guid TypeUid;
    internal static PageMetadata AVAY8OBErwAZspQrF2am;

    /// <summary>Метаданные содержимого страницы</summary>
    public PageContentMetadata Content
    {
      get => this.\u003CContent\u003Ek__BackingField;
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
              this.\u003CContent\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
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

    public override Guid GetTypeUid() => PageMetadata.TypeUid;

    public override void InitNew()
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!string.IsNullOrEmpty(this.Namespace))
                goto case 5;
              else
                goto label_10;
            case 2:
              base.InitNew();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_8;
            case 4:
              PageMetadata.Tcf4wcBEcXybcnSApXTY((object) this.Content.Context, PageMetadata.RA5PP5BEshsK029ZuIHk(PageMetadata.iWHSqDBEjYhDOxFUYIeE(-1867198571 ^ -1867243005)));
              num2 = 7;
              continue;
            case 5:
              if (this.Content != null)
              {
                num2 = 3;
                continue;
              }
              break;
            case 6:
              PageMetadata.nMEya6BEUi58obYmFLnp(PageMetadata.x908WYBELgrYOkAgX8DH((object) this.Content), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841408568));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 2 : 4;
              continue;
            case 7:
              goto label_3;
            case 8:
              this.Namespace = (string) PageMetadata.iWHSqDBEjYhDOxFUYIeE(1021410165 ^ 1021417007);
              num2 = 5;
              continue;
            case 9:
              PageMetadata.b4mqTrBEYDEkqoyT8Usy((object) this.Content);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 6 : 2;
              continue;
          }
          this.Content = new PageContentMetadata();
          num2 = 9;
        }
label_10:
        num1 = 8;
      }
label_8:
      return;
label_3:;
    }

    public override EntityMetadata GetPartContext(Guid uid)
    {
      int num = 5;
      EntityMetadata contextRecursive;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (PageMetadata.x908WYBELgrYOkAgX8DH((object) this.Content) == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 3 : 0;
              continue;
            }
            goto case 2;
          case 2:
            contextRecursive = this.FindFormContextRecursive((EntityMetadata) this.Content.Context, uid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
            continue;
          case 3:
          case 4:
            goto label_5;
          case 5:
            if (this.Content == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 4;
              continue;
            }
            goto case 1;
          case 6:
            goto label_4;
          default:
            if (contextRecursive != null)
            {
              num = 6;
              continue;
            }
            goto label_5;
        }
      }
label_4:
      return contextRecursive;
label_5:
      return (EntityMetadata) null;
    }

    public override FormPartMetadata GetPart(Guid partUid)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            if (!PageMetadata.ECiw5PBfFY1k8hwGMc18(PageMetadata.tkOyqkBEzlyDU3EmS2OD((object) this.Content), partUid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 3:
            if (this.Content != null)
            {
              num = 2;
              continue;
            }
            goto label_5;
          default:
            goto label_5;
        }
      }
label_4:
      return (FormPartMetadata) this.Content;
label_5:
      return (FormPartMetadata) null;
    }

    public override IEnumerable<Guid> PartUids => (IEnumerable<Guid>) new PageMetadata.\u003Cget_PartUids\u003Ed__11(-2)
    {
      \u003C\u003E4__this = this
    };

    public override void GenerateNewUids()
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              base.GenerateNewUids();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_6;
            case 3:
              goto label_3;
            default:
              if (this.Content != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 2 : 0;
                continue;
              }
              goto label_8;
          }
        }
label_6:
        PageMetadata.FI6ArHBfBDycIokP2u3o((object) this.Content);
        num1 = 3;
      }
label_3:
      return;
label_8:;
    }

    protected override void GetMetadataToRegister(List<IMetadata> metadataList)
    {
      if (this.Content == null || this.Content.Context == null)
        return;
      metadataList.Add((IMetadata) this.Content.Context);
    }

    public PageMetadata()
    {
      PageMetadata.yRFqrJBfWLgRjCyCFbeY();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static PageMetadata()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            PageMetadata.TypeUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178264272));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static bool yC4JXbBEg2ZTKorUedUl() => PageMetadata.AVAY8OBErwAZspQrF2am == null;

    internal static PageMetadata WnD3iQBE5eDld8L1jGcB() => PageMetadata.AVAY8OBErwAZspQrF2am;

    internal static object iWHSqDBEjYhDOxFUYIeE(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void b4mqTrBEYDEkqoyT8Usy([In] object obj0) => ((AbstractMetadata) obj0).InitNew();

    internal static object x908WYBELgrYOkAgX8DH([In] object obj0) => (object) ((FormPartMetadata) obj0).Context;

    internal static void nMEya6BEUi58obYmFLnp([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).Name = (string) obj1;

    internal static object RA5PP5BEshsK029ZuIHk([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void Tcf4wcBEcXybcnSApXTY([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).DisplayName = (string) obj1;

    internal static Guid tkOyqkBEzlyDU3EmS2OD([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static bool ECiw5PBfFY1k8hwGMc18([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static void FI6ArHBfBDycIokP2u3o([In] object obj0) => ((FormPartMetadata) obj0).GenerateNewUids();

    internal static void yRFqrJBfWLgRjCyCFbeY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    /// <summary>Информация о типе метаданных</summary>
    [Component]
    public class Info : IMetadataTypeInfo
    {
      private static PageMetadata.Info bRuxwgQbilSxZJj8fChV;

      public string Name => EleWise.ELMA.SR.T((string) PageMetadata.Info.w7OsQAQbKumuQF2Fsgky(-53329496 >> 4 ^ -3276284));

      public string Description => (string) PageMetadata.Info.aAAc4pQbX5o8g14HdFmq(PageMetadata.Info.w7OsQAQbKumuQF2Fsgky(-1876063057 ^ -1876367581));

      public Type MetadataType => PageMetadata.Info.zedN9xQbTGjGuZXbfXwS(__typeref (PageMetadata));

      public Type GeneratorType => PageMetadata.Info.zedN9xQbTGjGuZXbfXwS(__typeref (PageMetadataGenerator));

      public Info()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object w7OsQAQbKumuQF2Fsgky(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static bool lynwFpQbRqoRaa1layFc() => PageMetadata.Info.bRuxwgQbilSxZJj8fChV == null;

      internal static PageMetadata.Info nbcCCdQbqTTe386O2yoQ() => PageMetadata.Info.bRuxwgQbilSxZJj8fChV;

      internal static object aAAc4pQbX5o8g14HdFmq([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static Type zedN9xQbTGjGuZXbfXwS([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);
    }
  }
}
