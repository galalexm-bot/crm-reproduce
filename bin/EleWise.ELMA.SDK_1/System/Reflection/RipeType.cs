// Decompiled with JetBrains decompiler
// Type: System.Reflection.RipeType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;

namespace System.Reflection
{
  /// <summary>typeof(T)</summary>
  public class RipeType
  {
    private string name;
    private string fullName;
    private Assembly assembly;
    internal static RipeType ArUZicGU8kUQ5g8bbB2;

    internal RipeType(Type raw)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Raw = raw;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>typeof(T)</summary>
    public Type Raw { get; }

    /// <summary>typeof(T).Name</summary>
    public string Name
    {
      get
      {
        int num = 1;
        string name1;
        string name2;
        while (true)
        {
          switch (num)
          {
            case 1:
              name2 = this.name;
              if (name2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.name = name1 = (string) RipeType.pQieMiGzcfVThOf0IBt((object) this.Raw);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 2 : 2;
              continue;
          }
        }
label_2:
        return name2;
label_6:
        return name1;
      }
    }

    /// <summary>typeof(T).FullName</summary>
    public string FullName
    {
      get
      {
        int num = 1;
        string fullName1;
        string fullName2;
        while (true)
        {
          switch (num)
          {
            case 1:
              fullName2 = this.fullName;
              if (fullName2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.fullName = fullName1 = this.Raw.FullName;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 2 : 0;
              continue;
          }
        }
label_2:
        return fullName2;
label_6:
        return fullName1;
      }
    }

    /// <summary>typeof(T).Assembly</summary>
    public Assembly Assembly
    {
      get
      {
        int num = 2;
        Assembly assembly1;
        Assembly assembly2;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.assembly = assembly1 = this.Raw.Assembly;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
              continue;
            case 2:
              assembly2 = this.assembly;
              if ((object) assembly2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_6;
          }
        }
label_2:
        return assembly2;
label_6:
        return assembly1;
      }
    }

    internal static bool z7pwsUGsurIIK4U6Xc7() => RipeType.ArUZicGU8kUQ5g8bbB2 == null;

    internal static RipeType oHGDT9GcLFJWcOmmo5r() => RipeType.ArUZicGU8kUQ5g8bbB2;

    internal static object pQieMiGzcfVThOf0IBt([In] object obj0) => (object) ((MemberInfo) obj0).Name;
  }
}
