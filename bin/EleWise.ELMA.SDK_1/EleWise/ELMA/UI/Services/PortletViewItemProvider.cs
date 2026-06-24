// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Services.PortletViewItemProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Services
{
  public class PortletViewItemProvider : UIViewItemProvider
  {
    public static readonly Guid UID;
    internal static PortletViewItemProvider qwQog3ciVBom13MhafX;

    /// <summary>Создать идентфикатор элемента представления</summary>
    public static string CreateViewItemId(
      FormDescriptor formDescriptor,
      FormPartMetadata partMetadata,
      int portletManagerScope,
      string portletManagerPath,
      Guid portletId,
      Guid instanceId,
      string path)
    {
      PortletViewItemParams portletViewItemParams = new PortletViewItemParams();
      PortletViewItemProvider.vyIm5ScKXpnwYC3l314((object) portletViewItemParams, (object) formDescriptor, (object) partMetadata, portletManagerScope, (object) portletManagerPath, portletId, instanceId, (object) path);
      return portletViewItemParams.ToString();
    }

    /// <summary>
    /// Инициализировать <paramref name="viewItemParams" /> с помощью остальных параметров
    /// </summary>
    public static void InitViewItemParams(
      PortletViewItemParams viewItemParams,
      FormDescriptor formDescriptor,
      FormPartMetadata partMetadata,
      int portletManagerScope,
      string portletManagerPath,
      Guid portletId,
      Guid instanceId,
      string path)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            Contract.ArgumentNotNull((object) viewItemParams, (string) PortletViewItemProvider.dvscI1cXhyXfw7a4ZRI(87862435 ^ 87847941));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            viewItemParams.PortletManagerPath = portletManagerPath;
            num = 7;
            continue;
          case 4:
            viewItemParams.PortletManagerScope = portletManagerScope;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 3;
            continue;
          case 5:
            PortletViewItemProvider.gRWHCecnMnl8QK18cBh((object) viewItemParams, instanceId);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 6 : 2;
            continue;
          case 6:
            PortletViewItemProvider.IdI8G0cOTWKvw8WdWGk((object) viewItemParams, (object) path);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 2;
            continue;
          case 7:
            PortletViewItemProvider.wfLBg5ckuNU29tGrlZG((object) viewItemParams, portletId);
            num = 5;
            continue;
          default:
            PortletViewItemProvider.cm6TB3cTS3xAawUtA29((object) viewItemParams, (object) formDescriptor, (object) partMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 4 : 3;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Разобрать параметры отображения представления</summary>
    /// <param name="viewItemId">Строка с параметрами (элементы разделяются точкой с запятой)</param>
    /// <returns>Разобранные параметры</returns>
    public new static UIViewItemParams ParseViewItemId(string viewItemId) => (UIViewItemParams) new PortletViewItemParams(viewItemId);

    public override Guid ProviderUid => PortletViewItemProvider.UID;

    protected override UIViewItemParams ParseViewItemParams(string viewItemId) => (UIViewItemParams) PortletViewItemProvider.TLeEsjc2h8orO0Uxtl6((object) viewItemId);

    public PortletViewItemProvider()
    {
      PortletViewItemProvider.lfEQLpcerW61YGO2lvM();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static PortletViewItemProvider()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            PortletViewItemProvider.UID = new Guid((string) PortletViewItemProvider.dvscI1cXhyXfw7a4ZRI(-398663332 ^ -398706614));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
            continue;
          case 2:
            PortletViewItemProvider.lfEQLpcerW61YGO2lvM();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void vyIm5ScKXpnwYC3l314(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      int portletManagerScope,
      [In] object obj4,
      Guid portletId,
      Guid instanceId,
      [In] object obj7)
    {
      PortletViewItemProvider.InitViewItemParams((PortletViewItemParams) obj0, (FormDescriptor) obj1, (FormPartMetadata) obj2, portletManagerScope, (string) obj4, portletId, instanceId, (string) obj7);
    }

    internal static bool cFTPZocRbOAXreQCH22() => PortletViewItemProvider.qwQog3ciVBom13MhafX == null;

    internal static PortletViewItemProvider nc6uoMcqBD27uAmqUSh() => PortletViewItemProvider.qwQog3ciVBom13MhafX;

    internal static object dvscI1cXhyXfw7a4ZRI(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void cm6TB3cTS3xAawUtA29([In] object obj0, [In] object obj1, [In] object obj2) => UIViewItemProvider.InitViewItemParams((UIViewItemParams) obj0, (FormDescriptor) obj1, (FormPartMetadata) obj2);

    internal static void wfLBg5ckuNU29tGrlZG([In] object obj0, Guid value) => ((PortletViewItemParams) obj0).PortletId = value;

    internal static void gRWHCecnMnl8QK18cBh([In] object obj0, Guid value) => ((PortletViewItemParams) obj0).InstanceId = value;

    internal static void IdI8G0cOTWKvw8WdWGk([In] object obj0, [In] object obj1) => ((PortletViewItemParams) obj0).Path = (string) obj1;

    internal static object TLeEsjc2h8orO0Uxtl6([In] object obj0) => (object) PortletViewItemProvider.ParseViewItemId((string) obj0);

    internal static void lfEQLpcerW61YGO2lvM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
