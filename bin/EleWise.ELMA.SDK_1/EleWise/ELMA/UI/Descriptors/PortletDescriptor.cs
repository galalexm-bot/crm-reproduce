// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Descriptors.PortletDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Descriptors
{
  /// <summary>Дескриптор портлета</summary>
  public class PortletDescriptor : FormDescriptor
  {
    internal static PortletDescriptor mVRYQ5MMOyrXRIqRv4Q;

    public PortletDescriptor(IFormMetadataItem item)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(item);
      int num = 2;
      string str;
      PortletMetadata portletMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            str = (string) PortletDescriptor.pg1LJmMLJnf1AXncLFq(PortletDescriptor.plgjt1M51AdOBA0F92A((object) portletMetadata), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051276242 - 990076387 ^ 61184561), PortletDescriptor.lT18qCMY8LSh1pGDQtF(PortletDescriptor.xtZfygMjZ5AuJ3S4Xbd((object) portletMetadata)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
            continue;
          case 2:
            PortletDescriptor.KmrHUJMrSpx6kh3eKau(PortletDescriptor.gh3YqpMdiFPC9HGZBQJ((object) item) is PortletMetadata, PortletDescriptor.BXhooVMlkC09nJu5K5m(1051276242 - 990076387 ^ 61177353));
            num = 3;
            continue;
          case 3:
            portletMetadata = (PortletMetadata) PortletDescriptor.gh3YqpMdiFPC9HGZBQJ((object) item);
            num = 7;
            continue;
          case 4:
            if (!(this.PersonalizationType == (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 6 : 2;
              continue;
            }
            goto label_5;
          case 5:
            goto label_5;
          case 6:
            goto label_10;
          case 7:
            this.Content = new PortletContentDescriptor(this, (PortletContentMetadata) PortletDescriptor.iMQEbhMgLqecycdLL0R((object) portletMetadata));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 8 : 0;
            continue;
          case 8:
            this.Settings = new PortletSettingsDescriptor(this, portletMetadata.Settings);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 1 : 0;
            continue;
          default:
            this.PersonalizationType = this.Assembly.GetType(str);
            num = 4;
            continue;
        }
      }
label_10:
      return;
label_5:
      throw new TypeNotFoundException(str);
    }

    /// <summary>Дескриптор содержимого страницы</summary>
    public PortletContentDescriptor Content
    {
      get => this.\u003CContent\u003Ek__BackingField;
      private set
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
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

    /// <summary>Дескриптор настроек страницы</summary>
    public PortletSettingsDescriptor Settings
    {
      get => this.\u003CSettings\u003Ek__BackingField;
      private set
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
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

    /// <summary>Тип класса персонализации (настроек) портлета</summary>
    public Type PersonalizationType
    {
      get => this.\u003CPersonalizationType\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CPersonalizationType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
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

    internal static object gh3YqpMdiFPC9HGZBQJ([In] object obj0) => ((IFormMetadataItem) obj0).Metadata;

    internal static object BXhooVMlkC09nJu5K5m(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void KmrHUJMrSpx6kh3eKau(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static object iMQEbhMgLqecycdLL0R([In] object obj0) => (object) ((PortletMetadata) obj0).Content;

    internal static object plgjt1M51AdOBA0F92A([In] object obj0) => (object) ((FormMetadata) obj0).FullTypeName;

    internal static object xtZfygMjZ5AuJ3S4Xbd([In] object obj0) => (object) ((PortletMetadata) obj0).PersonalizationContext;

    internal static object lT18qCMY8LSh1pGDQtF([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object pg1LJmMLJnf1AXncLFq([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static bool VxB9SQMJ5O1TTHwpxZy() => PortletDescriptor.mVRYQ5MMOyrXRIqRv4Q == null;

    internal static PortletDescriptor eZMrW7M9WZCv9UY4kdh() => PortletDescriptor.mVRYQ5MMOyrXRIqRv4Q;

    [Component]
    public class Info : IFormDescriptorInfo
    {
      internal static PortletDescriptor.Info r3T81yfgjYiZK1sSZ14J;

      public Type MetadataType => PortletDescriptor.Info.s2325xfgUkncW28m0gcM(__typeref (PortletMetadata));

      public Type DescriptorType => typeof (PortletDescriptor);

      public Info()
      {
        PortletDescriptor.Info.XdL8aYfgsbXfwutxOLwf();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static Type s2325xfgUkncW28m0gcM([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

      internal static void XdL8aYfgsbXfwutxOLwf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool oWiEmIfgYjkULPXxqisn() => PortletDescriptor.Info.r3T81yfgjYiZK1sSZ14J == null;

      internal static PortletDescriptor.Info S8xnMvfgLsBYkKUsPWdp() => PortletDescriptor.Info.r3T81yfgjYiZK1sSZ14J;
    }
  }
}
