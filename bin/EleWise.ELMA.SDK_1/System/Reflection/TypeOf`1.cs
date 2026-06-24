// Decompiled with JetBrains decompiler
// Type: System.Reflection.TypeOf`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace System.Reflection
{
  /// <summary>
  /// typeof(<typeparamref name="T" />)
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public static class TypeOf<T>
  {
    /// <summary>typeof(T)</summary>
    public static readonly Type Raw;
    private static string name;
    private static string fullName;
    private static Assembly assembly;
    internal static object AwuRyIGjqmXS8lXd9La;

    /// <summary>typeof(T).Name</summary>
    public static string Name
    {
      get
      {
        int num = 1;
        string name;
        while (true)
        {
          switch (num)
          {
            case 1:
              name = TypeOf<T>.name;
              if (name == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return name;
label_5:
        return TypeOf<T>.name = TypeOf<T>.Raw.Name;
      }
    }

    /// <summary>typeof(T).FullName</summary>
    public static string FullName
    {
      get
      {
        int num = 1;
        string fullName;
        while (true)
        {
          switch (num)
          {
            case 1:
              fullName = TypeOf<T>.fullName;
              if (fullName == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return fullName;
label_5:
        return TypeOf<T>.fullName = TypeOf<T>.Raw.FullName;
      }
    }

    /// <summary>typeof(T).Assembly</summary>
    public static Assembly Assembly
    {
      get
      {
        int num = 1;
        Assembly assembly;
        while (true)
        {
          switch (num)
          {
            case 1:
              assembly = TypeOf<T>.assembly;
              if ((object) assembly == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return assembly;
label_5:
        return TypeOf<T>.assembly = TypeOf<T>.Raw.Assembly;
      }
    }

    static TypeOf()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            TypeOf<T>.Raw = typeof (T);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool uN1pweGYtNJ7n0Mgnw7() => TypeOf<T>.AwuRyIGjqmXS8lXd9La == null;

    internal static object yARsaGGLGf2wo8F6BeZ() => TypeOf<T>.AwuRyIGjqmXS8lXd9La;
  }
}
