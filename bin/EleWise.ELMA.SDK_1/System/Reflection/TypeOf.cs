// Decompiled with JetBrains decompiler
// Type: System.Reflection.TypeOf
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using System.Reflection.Extensions;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace System.Reflection
{
  /// <summary>typeof(T)</summary>
  public static class TypeOf
  {
    /// <summary>
    /// typeof(<see cref="T:System.Void" />)
    /// </summary>
    public static readonly RipeType Void;
    /// <summary>
    /// typeof(<see cref="!:Nullable&lt;&gt;" />)
    /// </summary>
    public static readonly RipeType Nullable;
    /// <summary>
    /// typeof(<see cref="!:List&lt;&gt;" />)
    /// </summary>
    public static readonly RipeType List;
    /// <summary>
    /// typeof(<see cref="!:IList&lt;&gt;" />)
    /// </summary>
    public static readonly RipeType IList;
    /// <summary>
    /// typeof(<see cref="!:ICollection&lt;&gt;" />)
    /// </summary>
    public static readonly RipeType ICollection;
    /// <summary>
    /// typeof(<see cref="!:ISet&lt;&gt;" />)
    /// </summary>
    public static readonly RipeType ISet;
    /// <summary>
    /// typeof(<see cref="!:Iesi.Collections.Generic.HashedSet&lt;&gt;" />)
    /// </summary>
    public static readonly RipeType Iesi_HashedSet;
    /// <summary>
    /// typeof(<see cref="!:Iesi.Collections.Generic.ISet&lt;&gt;" />)
    /// </summary>
    public static readonly RipeType Iesi_ISet;
    /// <summary>
    /// typeof(<see cref="F:System.Reflection.TypeOf.Enumerable" />)
    /// </summary>
    public static readonly RipeType Enumerable;
    /// <summary>
    /// typeof(<see cref="!:IEnumerable&lt;&gt;" />)
    /// </summary>
    public static readonly RipeType IEnumerable;
    /// <summary>
    /// typeof(<see cref="!:Dictionary&lt;,&gt;" />)
    /// </summary>
    public static readonly RipeType Dictionary;
    /// <summary>
    /// typeof(<see cref="!:IDictionary&lt;,&gt;" />)
    /// </summary>
    public static readonly RipeType IDictionary;
    /// <summary>
    /// typeof(<see cref="!:KeyValuePair&lt;,&gt;" />)
    /// </summary>
    public static readonly RipeType KeyValuePair;
    /// <summary>
    /// typeof(<see cref="!:Func&lt;&gt;" />)
    /// </summary>
    public static readonly RipeType Func1;
    /// <summary>
    /// typeof(<see cref="!:Func&lt;,&gt;" />)
    /// </summary>
    public static readonly RipeType Func2;
    /// <summary>
    /// typeof(<see cref="!:Func&lt;,,&gt;" />)
    /// </summary>
    public static readonly RipeType Func3;
    /// <summary>
    /// typeof(<see cref="!:Task&lt;&gt;" />)
    /// </summary>
    public static readonly RipeType Task1;
    /// <summary>
    /// typeof(<see cref="!:ValueTask&lt;&gt;" />)
    /// </summary>
    public static readonly RipeType ValueTask1;
    private static TypeOf M4fg6OEFZQZ6sjjP7ps;

    static TypeOf()
    {
      int num1 = 18;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              TypeOf.KeyValuePair = (RipeType) TypeOf.XrZ9rsEbutKEbxa8JSG(typeof (System.Collections.Generic.KeyValuePair<,>));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 10 : 3;
              continue;
            case 2:
              // ISSUE: type reference
              TypeOf.ISet = (RipeType) TypeOf.XrZ9rsEbutKEbxa8JSG(TypeOf.GOiI9YEhKUlKSyQo157(__typeref (System.Collections.Generic.ISet<>)));
              num2 = 16;
              continue;
            case 3:
              // ISSUE: type reference
              TypeOf.ICollection = TypeOf.GOiI9YEhKUlKSyQo157(__typeref (System.Collections.Generic.ICollection<>)).ToRipeType();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 2 : 2;
              continue;
            case 4:
              // ISSUE: type reference
              TypeOf.Enumerable = (RipeType) TypeOf.XrZ9rsEbutKEbxa8JSG(TypeOf.GOiI9YEhKUlKSyQo157(__typeref (System.Linq.Enumerable)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
              continue;
            case 5:
              // ISSUE: type reference
              TypeOf.Dictionary = TypeOf.GOiI9YEhKUlKSyQo157(__typeref (System.Collections.Generic.Dictionary<,>)).ToRipeType();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 7 : 1;
              continue;
            case 6:
              // ISSUE: type reference
              TypeOf.Func3 = (RipeType) TypeOf.XrZ9rsEbutKEbxa8JSG(TypeOf.GOiI9YEhKUlKSyQo157(__typeref (Func<,,>)));
              num2 = 9;
              continue;
            case 7:
              TypeOf.IDictionary = (RipeType) TypeOf.XrZ9rsEbutKEbxa8JSG(typeof (System.Collections.Generic.IDictionary<,>));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 1;
              continue;
            case 8:
              // ISSUE: type reference
              TypeOf.IList = (RipeType) TypeOf.XrZ9rsEbutKEbxa8JSG(TypeOf.GOiI9YEhKUlKSyQo157(__typeref (System.Collections.Generic.IList<>)));
              num2 = 3;
              continue;
            case 9:
              goto label_16;
            case 10:
              TypeOf.Func1 = (RipeType) TypeOf.XrZ9rsEbutKEbxa8JSG(typeof (Func<>));
              num2 = 15;
              continue;
            case 11:
              // ISSUE: type reference
              TypeOf.ValueTask1 = (RipeType) TypeOf.XrZ9rsEbutKEbxa8JSG(TypeOf.GOiI9YEhKUlKSyQo157(__typeref (ValueTask<>)));
              num2 = 12;
              continue;
            case 12:
              goto label_3;
            case 13:
              // ISSUE: type reference
              TypeOf.Nullable = (RipeType) TypeOf.XrZ9rsEbutKEbxa8JSG(TypeOf.GOiI9YEhKUlKSyQo157(__typeref (System.Nullable<>)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 11 : 19;
              continue;
            case 14:
              // ISSUE: type reference
              TypeOf.Iesi_ISet = (RipeType) TypeOf.XrZ9rsEbutKEbxa8JSG(TypeOf.GOiI9YEhKUlKSyQo157(__typeref (Iesi.Collections.Generic.ISet<>)));
              num2 = 4;
              continue;
            case 15:
              // ISSUE: type reference
              TypeOf.Func2 = (RipeType) TypeOf.XrZ9rsEbutKEbxa8JSG(TypeOf.GOiI9YEhKUlKSyQo157(__typeref (Func<,>)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 2 : 6;
              continue;
            case 16:
              // ISSUE: type reference
              TypeOf.Iesi_HashedSet = TypeOf.GOiI9YEhKUlKSyQo157(__typeref (HashedSet<>)).ToRipeType();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 14 : 1;
              continue;
            case 17:
              TypeOf.Void = (RipeType) TypeOf.XrZ9rsEbutKEbxa8JSG(typeof (void));
              num2 = 13;
              continue;
            case 18:
              TypeOf.cm11GBEo7IONZbujXCY();
              num2 = 17;
              continue;
            case 19:
              goto label_17;
            default:
              // ISSUE: type reference
              TypeOf.IEnumerable = (RipeType) TypeOf.XrZ9rsEbutKEbxa8JSG(TypeOf.GOiI9YEhKUlKSyQo157(__typeref (System.Collections.Generic.IEnumerable<>)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 5 : 2;
              continue;
          }
        }
label_16:
        // ISSUE: type reference
        TypeOf.Task1 = TypeOf.GOiI9YEhKUlKSyQo157(__typeref (Task<>)).ToRipeType();
        num1 = 11;
        continue;
label_17:
        // ISSUE: type reference
        TypeOf.List = (RipeType) TypeOf.XrZ9rsEbutKEbxa8JSG(TypeOf.GOiI9YEhKUlKSyQo157(__typeref (System.Collections.Generic.List<>)));
        num1 = 8;
      }
label_3:;
    }

    internal static void cm11GBEo7IONZbujXCY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object XrZ9rsEbutKEbxa8JSG(Type type) => (object) type.ToRipeType();

    internal static Type GOiI9YEhKUlKSyQo157([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool ImvA7AEBFsjl1M1Viri() => TypeOf.M4fg6OEFZQZ6sjjP7ps == null;

    internal static TypeOf Wts18eEWeyfyxeXXqRM() => TypeOf.M4fg6OEFZQZ6sjjP7ps;
  }
}
