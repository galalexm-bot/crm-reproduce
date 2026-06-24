// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Scripts.PortletMetadataUpdateHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Scripts
{
  /// <summary>Обновление метаданных на новый рантайм для портлетов</summary>
  internal sealed class PortletMetadataUpdateHandler : FormMetadataUpdateHandler
  {
    private static PortletMetadataUpdateHandler a6fwwWgPXVlXEUj3X3K;

    /// <inheritdoc />
    public override bool Check(IMetadata metadata) => metadata is PortletMetadata;

    /// <inheritdoc />
    protected override string OnLoadScriptName => (string) PortletMetadataUpdateHandler.iorPAOg3BXxMEsGZeZM(1642859704 ^ 1642907664);

    /// <inheritdoc />
    protected override string GetMetadataName(IMetadataUpdateResult updateResult) => (string) PortletMetadataUpdateHandler.H1OlvsgaXhtv5kWBRk1((object) (PortletMetadata) PortletMetadataUpdateHandler.fpRUwvgp5LXwnIo8LvL((object) updateResult));

    /// <inheritdoc />
    protected override FormPartMetadata GetContent(IMetadataUpdateResult updateResult) => (FormPartMetadata) PortletMetadataUpdateHandler.PmxFIlgDe10VwdaoiGr((object) (PortletMetadata) PortletMetadataUpdateHandler.fpRUwvgp5LXwnIo8LvL((object) updateResult));

    /// <inheritdoc />
    protected override string GetViewModelTypeName(IMetadataUpdateResult updateResult)
    {
      int num = 1;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            str = (string) PortletMetadataUpdateHandler.X8wIIYgtFABcrbDwQ0d((object) this, (object) updateResult);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (string) PortletMetadataUpdateHandler.RPL9E4gw1CumE71HWiq((object) new string[5]
      {
        (string) PortletMetadataUpdateHandler.iorPAOg3BXxMEsGZeZM(-1120607109 - 305487170 ^ -1426111491),
        str,
        (string) PortletMetadataUpdateHandler.iorPAOg3BXxMEsGZeZM(44884861 ^ 44836741),
        str,
        (string) PortletMetadataUpdateHandler.iorPAOg3BXxMEsGZeZM(1994213607 >> 4 ^ 124588416)
      });
    }

    /// <inheritdoc />
    protected override string GetLoadViewModelTypeName(IMetadataUpdateResult updateResult)
    {
      int num = 1;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            str = (string) PortletMetadataUpdateHandler.X8wIIYgtFABcrbDwQ0d((object) this, (object) updateResult);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (string) PortletMetadataUpdateHandler.RPL9E4gw1CumE71HWiq((object) new string[5]
      {
        (string) PortletMetadataUpdateHandler.iorPAOg3BXxMEsGZeZM(1242972401 >> 4 ^ 77701435),
        str,
        (string) PortletMetadataUpdateHandler.iorPAOg3BXxMEsGZeZM(-1217523399 ^ -1217473087),
        str,
        (string) PortletMetadataUpdateHandler.iorPAOg3BXxMEsGZeZM(95909607 + 343705423 ^ 439565112)
      });
    }

    /// <inheritdoc />
    protected override string ItemViewModelTypeName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021427205);

    /// <inheritdoc />
    protected override void AdditionalMetadataActions(
      FormMetadata formMetadata,
      ComponentMetadata componentMetadata)
    {
      int num1 = 1;
      PortletComponentMetadata componentMetadata1;
      List<PropertyMetadata>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            PortletMetadata portletMetadata = (PortletMetadata) formMetadata;
            componentMetadata1 = (PortletComponentMetadata) componentMetadata;
            enumerator = portletMetadata.PersonalizationContext.Properties.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_14;
          default:
            goto label_3;
        }
      }
label_14:
      return;
label_3:
      try
      {
label_6:
        if (enumerator.MoveNext())
          goto label_9;
        else
          goto label_7;
label_5:
        PropertyMetadata current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_10;
            case 2:
              goto label_9;
            case 3:
              componentMetadata1.PersonalizationContext.Properties.Add((PropertyMetadata) PortletMetadataUpdateHandler.xHm4GNg4np5Xe18FtnJ((object) current));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
              continue;
            default:
              goto label_6;
          }
        }
label_10:
        return;
label_7:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 1 : 1;
        goto label_5;
label_9:
        current = enumerator.Current;
        num2 = 3;
        goto label_5;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    public PortletMetadataUpdateHandler()
    {
      PortletMetadataUpdateHandler.abBHYTg6E0KrFZVXWcV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool ffN3drg1legPHo1VIvn() => PortletMetadataUpdateHandler.a6fwwWgPXVlXEUj3X3K == null;

    internal static PortletMetadataUpdateHandler aR7tFQgNctJhf5bhrnD() => PortletMetadataUpdateHandler.a6fwwWgPXVlXEUj3X3K;

    internal static object iorPAOg3BXxMEsGZeZM(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object fpRUwvgp5LXwnIo8LvL([In] object obj0) => (object) ((IMetadataUpdateResult) obj0).Metadata;

    internal static object H1OlvsgaXhtv5kWBRk1([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object PmxFIlgDe10VwdaoiGr([In] object obj0) => (object) ((PortletMetadata) obj0).Content;

    internal static object X8wIIYgtFABcrbDwQ0d([In] object obj0, [In] object obj1) => (object) ((FormMetadataUpdateHandler) obj0).GetMetadataName((IMetadataUpdateResult) obj1);

    internal static object RPL9E4gw1CumE71HWiq([In] object obj0) => (object) string.Concat((string[]) obj0);

    internal static object xHm4GNg4np5Xe18FtnJ([In] object obj0) => (object) FormMetadataUpdateHandler.CloneToViewModelPropertyMetadata((PropertyMetadata) obj0);

    internal static void abBHYTg6E0KrFZVXWcV() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
