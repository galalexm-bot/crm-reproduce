// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Descriptors.PageDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Descriptors
{
  /// <summary>Дескриптор страницы</summary>
  public class PageDescriptor : FormDescriptor
  {
    private static PageDescriptor jTrjRaJEMdTxuFAevUE;

    public PageDescriptor(IFormMetadataItem item)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(item);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
        num = 0;
      PageMetadata pageMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            pageMetadata = (PageMetadata) PageDescriptor.MqMIQKJ8dwm1je9CcIy((object) item);
            num = 3;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.Content = new PageContentDescriptor(this, pageMetadata.Content);
            num = 2;
            continue;
          default:
            PageDescriptor.XV9Jv8JvoFyd75bw3fT(item.Metadata is PageMetadata, PageDescriptor.asy0RgJCx0k5rtK19cO(-643786247 ^ -643811917));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Дескриптор содержимого страницы</summary>
    public PageContentDescriptor Content
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
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

    internal static object asy0RgJCx0k5rtK19cO(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void XV9Jv8JvoFyd75bw3fT(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static object MqMIQKJ8dwm1je9CcIy([In] object obj0) => ((IFormMetadataItem) obj0).Metadata;

    internal static bool C3MOpUJfj4oLjT2nc3H() => PageDescriptor.jTrjRaJEMdTxuFAevUE == null;

    internal static PageDescriptor MJCjZqJQxHewg4DvQ3i() => PageDescriptor.jTrjRaJEMdTxuFAevUE;

    [Component]
    public class Info : IFormDescriptorInfo
    {
      private static PageDescriptor.Info kkBHOlfgcUWFPbba07Sq;

      public Type MetadataType => PageDescriptor.Info.mGEV8If5BTh3vwh5m4Dj(__typeref (PageMetadata));

      public Type DescriptorType => typeof (PageDescriptor);

      public Info()
      {
        PageDescriptor.Info.lq94oEf5W3OobG1BGAW4();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static Type mGEV8If5BTh3vwh5m4Dj([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

      internal static void lq94oEf5W3OobG1BGAW4() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool y2qYolfgzks6MGwpgCtL() => PageDescriptor.Info.kkBHOlfgcUWFPbba07Sq == null;

      internal static PageDescriptor.Info QKWHrof5FU1v9gbO0gbN() => PageDescriptor.Info.kkBHOlfgcUWFPbba07Sq;
    }
  }
}
