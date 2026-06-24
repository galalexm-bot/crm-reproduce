// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Metadata.PortletMetadata
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
  /// <summary>Метаданные портлета</summary>
  [Image(typeof (PortletMetadata), "portlet", 16, ImageFormatType.IconPack, false)]
  [XmlRoot("Portlet")]
  [Image(typeof (PortletMetadata), "portlet", 32, ImageFormatType.IconPack, false)]
  public class PortletMetadata : FormMetadata
  {
    public const string IconImageKey = "CD097E40E88B466B833FC69F312600AF";
    public static readonly Guid TypeUid;
    internal static PortletMetadata dbYlblBfC1PG0bnmP7ZY;

    /// <summary>Метаданные содержимого портлета</summary>
    public PortletContentMetadata Content
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
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

    /// <summary>Метаданные контекста персонализации портлета</summary>
    public FormContextMetadata PersonalizationContext
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
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

    /// <summary>Метаданные настроек портлета</summary>
    public PortletSettingsMetadata Settings
    {
      get => this.\u003CSettings\u003Ek__BackingField;
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
              this.\u003CSettings\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
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

    /// <summary>Иконка портлета</summary>
    [XmlIgnore]
    public MetadataImage Icon
    {
      get => (MetadataImage) PortletMetadata.dRAcl8BfZS3fHRyNVSWu((object) this, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398717088));
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
              PortletMetadata.WBh0veBfIpZUCdAcBK42((object) this, PortletMetadata.DsmtCeBfuTMghvQIlx6l(1178210108 ^ 1178263808), (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
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

    /// <summary>Url иконки портлета</summary>
    public string IconUrl
    {
      get => this.\u003CIconUrl\u003Ek__BackingField;
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
              this.\u003CIconUrl\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
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

    public override Guid GetTypeUid() => PortletMetadata.TypeUid;

    public override void InitNew()
    {
      int num1 = 9;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              PortletMetadata.IBRHkOBfK4AEXjDGiH2A(PortletMetadata.ySwycBBfiykmSeiXngxr((object) this.Settings), (object) EleWise.ELMA.SR.T((string) PortletMetadata.DsmtCeBfuTMghvQIlx6l(333888594 ^ 1075625116 ^ 1408954242)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 6 : 5;
              continue;
            case 2:
              this.Settings = new PortletSettingsMetadata();
              num2 = 7;
              continue;
            case 3:
              goto label_10;
            case 4:
              PortletMetadata.KoRqOQBfSQRegU6KYGBo((object) this.PersonalizationContext);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 13 : 2;
              continue;
            case 5:
              if (this.Settings == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 2 : 1;
                continue;
              }
              goto label_3;
            case 6:
              goto label_16;
            case 7:
              goto label_4;
            case 8:
              if (PortletMetadata.Yv554aBfVDHZ1pAsoUxX((object) this.Namespace))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 17 : 7;
                continue;
              }
              break;
            case 9:
              base.InitNew();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 5 : 8;
              continue;
            case 10:
            case 15:
              if (this.PersonalizationContext == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 14 : 5;
                continue;
              }
              goto case 5;
            case 11:
              goto label_14;
            case 12:
              goto label_26;
            case 13:
              PortletMetadata.lH6HF1BfR0OK9mqCP1En((object) this.PersonalizationContext, PortletMetadata.DsmtCeBfuTMghvQIlx6l(-1822890472 ^ -1822945998));
              num2 = 11;
              continue;
            case 14:
              this.PersonalizationContext = new FormContextMetadata();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 4 : 1;
              continue;
            case 16:
              PortletMetadata.KoRqOQBfSQRegU6KYGBo((object) this.Content);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 12 : 6;
              continue;
            case 17:
              this.Namespace = (string) PortletMetadata.DsmtCeBfuTMghvQIlx6l(1470440286 ^ 1470483934);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
              continue;
            case 18:
              PortletMetadata.lH6HF1BfR0OK9mqCP1En(PortletMetadata.ySwycBBfiykmSeiXngxr((object) this.Settings), PortletMetadata.DsmtCeBfuTMghvQIlx6l(1052221104 - 768835541 ^ 283393613));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 1;
              continue;
            case 19:
              PortletMetadata.IBRHkOBfK4AEXjDGiH2A((object) this.Content.Context, PortletMetadata.QVq04SBfqpYXMuE5d0Vi(PortletMetadata.DsmtCeBfuTMghvQIlx6l(1470998129 - 231418599 ^ 1239586124)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 15 : 14;
              continue;
          }
          if (this.Content != null)
            num2 = 10;
          else
            goto label_10;
        }
label_4:
        this.Settings.InitNew();
        num1 = 18;
        continue;
label_10:
        this.Content = new PortletContentMetadata();
        num1 = 16;
        continue;
label_14:
        PortletMetadata.IBRHkOBfK4AEXjDGiH2A((object) this.PersonalizationContext, PortletMetadata.QVq04SBfqpYXMuE5d0Vi(PortletMetadata.DsmtCeBfuTMghvQIlx6l(1149433385 + 173655049 ^ 1323062574)));
        num1 = 5;
        continue;
label_26:
        PortletMetadata.lH6HF1BfR0OK9mqCP1En(PortletMetadata.ySwycBBfiykmSeiXngxr((object) this.Content), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867767560));
        num1 = 19;
      }
label_16:
      return;
label_3:;
    }

    public override void GenerateNewUids()
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (this.PersonalizationContext != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
                continue;
              }
              goto case 7;
            case 2:
              goto label_3;
            case 3:
              PortletMetadata.IWjd2wBfX1qecO5QTJAy((object) this.Settings);
              num2 = 2;
              continue;
            case 4:
              PortletMetadata.IWjd2wBfX1qecO5QTJAy((object) this.Content);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 0;
              continue;
            case 5:
              if (this.Content == null)
                goto case 1;
              else
                goto label_9;
            case 6:
              base.GenerateNewUids();
              num2 = 5;
              continue;
            case 7:
              if (this.Settings != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 3 : 3;
                continue;
              }
              goto label_14;
            default:
              PortletMetadata.Nmu5RtBfTWKe3NeJYaRa((object) this.PersonalizationContext);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 7 : 7;
              continue;
          }
        }
label_9:
        num1 = 4;
      }
label_3:
      return;
label_14:;
    }

    public override EntityMetadata GetPartContext(Guid uid)
    {
      int num = 13;
      EntityMetadata contextRecursive1;
      EntityMetadata contextRecursive2;
      EntityMetadata contextRecursive3;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 12:
            if (this.PersonalizationContext != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 2 : 6;
              continue;
            }
            goto case 4;
          case 2:
            contextRecursive3 = this.FindFormContextRecursive((EntityMetadata) PortletMetadata.ySwycBBfiykmSeiXngxr((object) this.Settings), uid);
            num = 5;
            continue;
          case 3:
            goto label_6;
          case 4:
            if (this.Settings != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 3 : 10;
              continue;
            }
            goto label_7;
          case 5:
            if (contextRecursive3 != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 2 : 3;
              continue;
            }
            goto label_7;
          case 6:
            contextRecursive2 = this.FindFormContextRecursive((EntityMetadata) this.PersonalizationContext, uid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 15 : 13;
            continue;
          case 7:
            goto label_7;
          case 8:
            if (PortletMetadata.ySwycBBfiykmSeiXngxr((object) this.Content) == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 1 : 1;
              continue;
            }
            goto case 9;
          case 9:
            contextRecursive1 = this.FindFormContextRecursive((EntityMetadata) PortletMetadata.ySwycBBfiykmSeiXngxr((object) this.Content), uid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 5 : 14;
            continue;
          case 10:
            if (this.Settings.Context == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 7 : 0;
              continue;
            }
            goto case 2;
          case 11:
            goto label_2;
          case 13:
            if (this.Content == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 12 : 2;
              continue;
            }
            goto case 8;
          case 14:
            if (contextRecursive1 != null)
            {
              num = 11;
              continue;
            }
            goto case 1;
          case 15:
            if (contextRecursive2 == null)
            {
              num = 4;
              continue;
            }
            goto label_10;
          default:
            goto label_10;
        }
      }
label_2:
      return contextRecursive1;
label_6:
      return contextRecursive3;
label_7:
      return (EntityMetadata) null;
label_10:
      return contextRecursive2;
    }

    public override FormPartMetadata GetPart(Guid partUid)
    {
      int num = 6;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            if (!(PortletMetadata.SHdO3SBfkIAvG87atnJ5((object) this.Settings) == partUid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 4;
              continue;
            }
            goto label_4;
          case 3:
            goto label_6;
          case 4:
            goto label_5;
          case 5:
            if (!(this.Content.Uid == partUid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 6:
            if (this.Content != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 5 : 2;
              continue;
            }
            break;
        }
        if (this.Settings != null)
          num = 2;
        else
          goto label_5;
      }
label_4:
      return (FormPartMetadata) this.Settings;
label_5:
      return (FormPartMetadata) null;
label_6:
      return (FormPartMetadata) this.Content;
    }

    public override IEnumerable<Guid> PartUids => (IEnumerable<Guid>) new PortletMetadata.\u003Cget_PartUids\u003Ed__28(-2)
    {
      \u003C\u003E4__this = this
    };

    protected override void GetMetadataToRegister(List<IMetadata> metadataList)
    {
      if (this.Content != null && this.Content.Context != null)
        metadataList.Add((IMetadata) this.Content.Context);
      if (this.PersonalizationContext != null)
        metadataList.Add((IMetadata) this.PersonalizationContext);
      if (this.Settings == null || this.Settings.Context == null)
        return;
      metadataList.Add((IMetadata) this.Settings.Context);
    }

    public PortletMetadata()
    {
      PortletMetadata.yu7JjVBfnL9mWGDQwxYy();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static PortletMetadata()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            PortletMetadata.TypeUid = new Guid((string) PortletMetadata.DsmtCeBfuTMghvQIlx6l(-138018305 ^ -137957801));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
            continue;
          case 2:
            PortletMetadata.yu7JjVBfnL9mWGDQwxYy();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool zbj8naBfv0cML7TMgZIq() => PortletMetadata.dbYlblBfC1PG0bnmP7ZY == null;

    internal static PortletMetadata ytDiCGBf8q0v0sfKK9tu() => PortletMetadata.dbYlblBfC1PG0bnmP7ZY;

    internal static object dRAcl8BfZS3fHRyNVSWu([In] object obj0, [In] object obj1) => (object) ((NamedMetadata) obj0).GetNamedImage((string) obj1);

    internal static object DsmtCeBfuTMghvQIlx6l(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void WBh0veBfIpZUCdAcBK42([In] object obj0, [In] object obj1, [In] object obj2) => ((NamedMetadata) obj0).AddNamedImage((string) obj1, (MetadataImage) obj2);

    internal static bool Yv554aBfVDHZ1pAsoUxX([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static void KoRqOQBfSQRegU6KYGBo([In] object obj0) => ((AbstractMetadata) obj0).InitNew();

    internal static object ySwycBBfiykmSeiXngxr([In] object obj0) => (object) ((FormPartMetadata) obj0).Context;

    internal static void lH6HF1BfR0OK9mqCP1En([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).Name = (string) obj1;

    internal static object QVq04SBfqpYXMuE5d0Vi([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void IBRHkOBfK4AEXjDGiH2A([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).DisplayName = (string) obj1;

    internal static void IWjd2wBfX1qecO5QTJAy([In] object obj0) => ((FormPartMetadata) obj0).GenerateNewUids();

    internal static void Nmu5RtBfTWKe3NeJYaRa([In] object obj0) => ((FormContextMetadata) obj0).GenerateNewUids();

    internal static Guid SHdO3SBfkIAvG87atnJ5([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static void yu7JjVBfnL9mWGDQwxYy() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    /// <summary>Информация о типе метаданных</summary>
    [Component]
    public class Info : IMetadataTypeInfo
    {
      internal static PortletMetadata.Info HV3ayOQbe0x3VcTZPgOE;

      public string Name => (string) PortletMetadata.Info.uOQgCHQb3apNpHaVBAjN(PortletMetadata.Info.BdidOXQbNZGWO8vjrQly(-2099751081 ^ -2099547813));

      public string Description => (string) PortletMetadata.Info.uOQgCHQb3apNpHaVBAjN((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345233796));

      public Type MetadataType => PortletMetadata.Info.yPiEU0Qbpc14Y58SW0iS(__typeref (PortletMetadata));

      public Type GeneratorType => typeof (PortletMetadataGenerator);

      public Info()
      {
        PortletMetadata.Info.xDIZCEQbapWhb8N5BZPi();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object BdidOXQbNZGWO8vjrQly(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object uOQgCHQb3apNpHaVBAjN([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool zSTHKyQbPNHXkXoQrXYB() => PortletMetadata.Info.HV3ayOQbe0x3VcTZPgOE == null;

      internal static PortletMetadata.Info lLcl0yQb1geWaGBtaiVH() => PortletMetadata.Info.HV3ayOQbe0x3VcTZPgOE;

      internal static Type yPiEU0Qbpc14Y58SW0iS([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

      internal static void xDIZCEQbapWhb8N5BZPi() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
