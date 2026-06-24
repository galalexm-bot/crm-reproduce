// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.RenderViewInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Diagnostics.Attributes;
using EleWise.ELMA.Diagnostics.Events;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Web.Mvc;

namespace EleWise.ELMA.Diagnostics
{
  /// <summary>Информация о рендере представления</summary>
  [DiagnosticEvents(StartEvent = typeof (RenderViewStartEvent), EndEvent = typeof (RenderViewEndEvent), ErrorEvent = typeof (RenderViewErrorEvent))]
  [Serializable]
  public class RenderViewInfo : AbstractCallInfo, IEmptyCallInfo
  {
    private static RenderViewInfo kAk4o3EFMQlvp053GdpH;

    /// <summary>Ctor</summary>
    public RenderViewInfo()
    {
      RenderViewInfo.t8t4BQEFdD0xbhSuLVZ7();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="viewContext">Контекст представления</param>
    /// <param name="virtualPath">Виртуальный путь</param>
    /// <param name="isPartial">Частичное</param>
    public RenderViewInfo(ViewContext viewContext, string virtualPath, bool isPartial)
    {
      RenderViewInfo.t8t4BQEFdD0xbhSuLVZ7();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.VirtualPath = virtualPath;
            num = 2;
            continue;
          case 2:
            this.IsPartial = isPartial;
            num = 3;
            continue;
          case 3:
            goto label_3;
          default:
            this.ViewContext = viewContext;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Контекст представления</summary>
    public ViewContext ViewContext
    {
      get => this.\u003CViewContext\u003Ek__BackingField;
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
              this.\u003CViewContext\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
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

    /// <summary>Виртуальный путь</summary>
    public string VirtualPath
    {
      get => this.\u003CVirtualPath\u003Ek__BackingField;
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
              this.\u003CVirtualPath\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
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

    /// <summary>Частичное</summary>
    public bool IsPartial
    {
      get => this.\u003CIsPartial\u003Ek__BackingField;
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
              this.\u003CIsPartial\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
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
    public override string CallType => (string) RenderViewInfo.fqEaVMEFluCZYvTX04ow(-105199646 ^ -104927316);

    /// <inheritdoc />
    public override string Description
    {
      get
      {
        int num = 1;
        string virtualPath;
        while (true)
        {
          switch (num)
          {
            case 1:
              virtualPath = this.VirtualPath;
              if (virtualPath == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return virtualPath;
label_5:
        return (string) RenderViewInfo.fqEaVMEFluCZYvTX04ow(712480695 ^ 712225021);
      }
    }

    /// <inheritdoc />
    public bool IsEmpty
    {
      get => this.\u003CIsEmpty\u003Ek__BackingField;
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
              this.\u003CIsEmpty\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
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

    protected override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            RenderViewInfo.w52mCxEFrVDi6UNJGkxZ((object) info, RenderViewInfo.fqEaVMEFluCZYvTX04ow(-2112703338 ^ -2112449722), this.IsPartial);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static void t8t4BQEFdD0xbhSuLVZ7() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool iDdaFVEFJOqa55p2Fccn() => RenderViewInfo.kAk4o3EFMQlvp053GdpH == null;

    internal static RenderViewInfo vpcJk7EF98M149V9GuYF() => RenderViewInfo.kAk4o3EFMQlvp053GdpH;

    internal static object fqEaVMEFluCZYvTX04ow(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void w52mCxEFrVDi6UNJGkxZ([In] object obj0, [In] object obj1, [In] bool obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);
  }
}
