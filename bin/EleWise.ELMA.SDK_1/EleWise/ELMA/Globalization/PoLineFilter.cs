// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.PoLineFilter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Common;
using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Globalization
{
  public class PoLineFilter : Filter
  {
    internal static PoLineFilter XJNwAGGEAFGV4v8DUYAs;

    public string FileName
    {
      get => this.\u003CFileName\u003Ek__BackingField;
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
              this.\u003CFileName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
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

    public bool Untranslated
    {
      get => this.\u003CUntranslated\u003Ek__BackingField;
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
              this.\u003CUntranslated\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
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

    public bool Fuzzy
    {
      get => this.\u003CFuzzy\u003Ek__BackingField;
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
              this.\u003CFuzzy\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
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

    public bool HighPriority
    {
      get => this.\u003CHighPriority\u003Ek__BackingField;
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
              this.\u003CHighPriority\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
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

    public bool LowPriority
    {
      get => this.\u003CLowPriority\u003Ek__BackingField;
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
              this.\u003CLowPriority\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
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

    public bool Checked(PoLineDescriptor descriptor)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 4:
            if (this.Fuzzy == PoLineFilter.VkW2WSGEylp5SfaGw5Ud((object) descriptor))
            {
              if (this.HighPriority != !descriptor.IsLow)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 6 : 1;
                continue;
              }
              if (this.LowPriority != PoLineFilter.VifVPLGEM7lMBZKbm7jd((object) descriptor))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 6 : 7;
                continue;
              }
              goto label_13;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 5 : 0;
              continue;
            }
          case 2:
            if (!this.Untranslated)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 1;
              continue;
            }
            goto case 3;
          case 3:
            if (PoLineFilter.q1htN0GEmVaRGmqkbbXS(PoLineFilter.gUhy2IGE0sayQKHNK3A4((object) descriptor)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 4 : 4;
              continue;
            }
            goto label_14;
          case 5:
            goto label_2;
          case 6:
            goto label_9;
          case 7:
            goto label_12;
          default:
            goto label_14;
        }
      }
label_2:
      return false;
label_9:
      return false;
label_12:
      return false;
label_13:
      return true;
label_14:
      return false;
    }

    public PoLineFilter()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool KuIm2aGE7CC6uF82hRTV() => PoLineFilter.XJNwAGGEAFGV4v8DUYAs == null;

    internal static PoLineFilter vfpHkfGExDlO3g4JiHE3() => PoLineFilter.XJNwAGGEAFGV4v8DUYAs;

    internal static object gUhy2IGE0sayQKHNK3A4([In] object obj0) => (object) ((PoLineDescriptor) obj0).Value;

    internal static bool q1htN0GEmVaRGmqkbbXS([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static bool VkW2WSGEylp5SfaGw5Ud([In] object obj0) => ((PoLineDescriptor) obj0).IsFuzzy;

    internal static bool VifVPLGEM7lMBZKbm7jd([In] object obj0) => ((PoLineDescriptor) obj0).IsLow;
  }
}
