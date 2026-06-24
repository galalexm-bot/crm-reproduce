// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.Models.ExportCheckingContext
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Export.Enums;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Export.Models
{
  /// <summary>Контекст проверки экспорта</summary>
  public sealed class ExportCheckingContext : IExportCheckingContext, ILinkedExportCheckingContext
  {
    private static ExportCheckingContext JYG8uYELD3QrRXfZeK5J;

    /// <inheritdoc />
    public ConfigExportSettings Settings
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
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
    public ExportCheckingMessageType? DefaultExportLinkChecking { get; set; }

    /// <inheritdoc />
    public LinkedObjectsSearchParams SearchParams
    {
      get => this.\u003CSearchParams\u003Ek__BackingField;
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
              this.\u003CSearchParams\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
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

    public ExportCheckingContext()
    {
      ExportCheckingContext.IKhA9UEL45yYu4598KsH();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool K0XulrELtQFkGKDbZQfX() => ExportCheckingContext.JYG8uYELD3QrRXfZeK5J == null;

    internal static ExportCheckingContext zAwQtEELwMTy0iDTZyhY() => ExportCheckingContext.JYG8uYELD3QrRXfZeK5J;

    internal static void IKhA9UEL45yYu4598KsH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
