// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.ViewModelTypeName
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model
{
  /// <summary>Имя типа модели представления</summary>
  public sealed class ViewModelTypeName
  {
    private static IList<string> assemblyNames;
    private static Dictionary<string, ICollection<string>> ambiguousTypes;
    private static ViewModelTypeName QU91FpWgFVLR1E6TYVSO;

    private static Dictionary<string, ICollection<string>> AmbiguousTypes
    {
      get
      {
        if (ViewModelTypeName.ambiguousTypes == null)
          ViewModelTypeName.ambiguousTypes = ((IEnumerable<Assembly>) AppDomain.CurrentDomain.GetAssemblies()).Join<Assembly, string, string, Assembly>((IEnumerable<string>) ViewModelTypeName.assemblyNames, (Func<Assembly, string>) (a => (string) ViewModelTypeName.\u003C\u003Ec.leQpNIQz7f6N20vm3vKF(ViewModelTypeName.\u003C\u003Ec.c0gAsCQzAeXKC1s2ATM7((object) a))), (Func<string, string>) (n => n), (Func<Assembly, string, Assembly>) ((a, n) => a)).SelectMany<Assembly, Type>((Func<Assembly, IEnumerable<Type>>) (a =>
          {
            try
            {
              return (IEnumerable<Type>) a.GetTypes();
            }
            catch (ReflectionTypeLoadException ex)
            {
              return (IEnumerable<Type>) ex.Types;
            }
          })).Where<Type>((Func<Type, bool>) (t =>
          {
            bool ambiguousTypes;
            switch (1)
            {
              case 1:
                try
                {
                  int num1;
                  if (t.Namespace == null)
                    num1 = 2;
                  else
                    goto label_5;
label_4:
                  int num2;
                  switch (num1)
                  {
                    case 1:
                      break;
                    case 2:
                      num2 = 0;
                      goto label_10;
                    case 3:
                      goto label_8;
                    case 4:
                      num2 = 1;
                      goto label_10;
                    default:
                      goto label_1;
                  }
label_5:
                  if (ViewModelTypeName.\u003C\u003Ec.QPCoX4Qz0eAjAAjYyrfe((object) t.Namespace, ViewModelTypeName.\u003C\u003Ec.gfoQrIQzxtoUWVTLoYUG(132912447 ^ 133123043)))
                  {
                    num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 4 : 0;
                    goto label_4;
                  }
label_8:
                  num2 = t.Namespace.StartsWith((string) ViewModelTypeName.\u003C\u003Ec.gfoQrIQzxtoUWVTLoYUG(-1638402543 ^ -1638767229)) ? 1 : 0;
label_10:
                  ambiguousTypes = num2 != 0;
                  num1 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
                  {
                    num1 = 0;
                    goto label_4;
                  }
                  else
                    goto label_4;
                }
                catch
                {
                  int num = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
                    num = 0;
                  while (true)
                  {
                    switch (num)
                    {
                      case 1:
                        ambiguousTypes = false;
                        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_1;
                    }
                  }
                }
            }
label_1:
            return ambiguousTypes;
          })).GroupBy<Type, string>((Func<Type, string>) (t => (string) ViewModelTypeName.\u003C\u003Ec.qpwYK2QzmmUR8A8kqx49((object) t))).ToDictionary<IGrouping<string, Type>, string, ICollection<string>>((Func<IGrouping<string, Type>, string>) (g => g.Key), (Func<IGrouping<string, Type>, ICollection<string>>) (g => (ICollection<string>) g.Select<Type, string>((Func<Type, string>) (t => t.Namespace)).ToArray<string>()));
        return ViewModelTypeName.ambiguousTypes;
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="name">Имя типа</param>
    /// <param name="namespace">Пространство имен</param>
    /// <param name="isNullable">Является ли тип Nullable</param>
    /// <param name="isEnumerable">Является ли тип коллекцией</param>
    public ViewModelTypeName(string name, string @namespace, bool isNullable = false, bool isEnumerable = false)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 6;
      ICollection<string> strings;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_8;
          case 1:
            this.Namespace = (string) ViewModelTypeName.IOwfU6WghVABKTDvv72K((object) new string[5]
            {
              name,
              (string) ViewModelTypeName.l2yIDsWgoeDMGMMDv3ti(1461625753 ^ 1461651205),
              @namespace,
              (string) ViewModelTypeName.l2yIDsWgoeDMGMMDv3ti(272623989 ^ 272626609),
              name
            });
            num = 2;
            continue;
          case 2:
            goto label_7;
          case 3:
          case 5:
            if (ViewModelTypeName.AmbiguousTypes.TryGetValue(name, out strings))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 5 : 8;
              continue;
            }
            goto case 4;
          case 4:
            this.Namespace = @namespace;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
            continue;
          case 6:
            this.Name = isNullable ? (string) ViewModelTypeName.KmsqvLWgbrjmTNMdWrMh((object) name, ViewModelTypeName.l2yIDsWgoeDMGMMDv3ti(~289714581 ^ -289712608)) : name;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 5 : 7;
            continue;
          case 7:
            if (!isEnumerable)
            {
              num = 3;
              continue;
            }
            goto case 9;
          case 8:
            if (strings.Contains(@namespace))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 4;
              continue;
            }
            goto case 1;
          case 9:
            this.Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 901938183) + this.Name + (string) ViewModelTypeName.l2yIDsWgoeDMGMMDv3ti(-1217523399 ^ -1217503495);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 3 : 5;
            continue;
          default:
            goto label_4;
        }
      }
label_8:
      return;
label_7:
      return;
label_4:;
    }

    /// <summary>Имя типа</summary>
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
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
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
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

    /// <summary>Пространство имен</summary>
    public string Namespace
    {
      get => this.\u003CNamespace\u003Ek__BackingField;
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
              this.\u003CNamespace\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
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

    static ViewModelTypeName()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ViewModelTypeName.assemblyNames = (IList<string>) new string[19]
            {
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883222696),
              (string) ViewModelTypeName.l2yIDsWgoeDMGMMDv3ti(-1998538950 ^ -1998418538),
              (string) ViewModelTypeName.l2yIDsWgoeDMGMMDv3ti(-740338220 ^ -740402294),
              (string) ViewModelTypeName.l2yIDsWgoeDMGMMDv3ti(-812025778 ^ -812058520),
              (string) ViewModelTypeName.l2yIDsWgoeDMGMMDv3ti(1581325282 << 3 ^ -234250066),
              (string) ViewModelTypeName.l2yIDsWgoeDMGMMDv3ti(44884861 ^ 45013427),
              (string) ViewModelTypeName.l2yIDsWgoeDMGMMDv3ti(-710283084 ^ -537863435 ^ 173740201),
              (string) ViewModelTypeName.l2yIDsWgoeDMGMMDv3ti(-2138160520 ^ -2138062206),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727487386),
              (string) ViewModelTypeName.l2yIDsWgoeDMGMMDv3ti(-398663332 ^ -398630614),
              (string) ViewModelTypeName.l2yIDsWgoeDMGMMDv3ti(-477139494 ^ -477276524),
              (string) ViewModelTypeName.l2yIDsWgoeDMGMMDv3ti(~-122002947 ^ 122135934),
              (string) ViewModelTypeName.l2yIDsWgoeDMGMMDv3ti(~538519529 ^ -538647630),
              (string) ViewModelTypeName.l2yIDsWgoeDMGMMDv3ti(694673736 ^ -23604109 ^ -672002305),
              (string) ViewModelTypeName.l2yIDsWgoeDMGMMDv3ti(323422137 << 2 ^ 1293821196),
              (string) ViewModelTypeName.l2yIDsWgoeDMGMMDv3ti(-2107978722 ^ -2108100596),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108100532),
              (string) ViewModelTypeName.l2yIDsWgoeDMGMMDv3ti(323422137 << 2 ^ 1293786716),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173741769)
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
            continue;
          case 2:
            ViewModelTypeName.lwJJUeWgGixgN3beSed4();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object l2yIDsWgoeDMGMMDv3ti(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object KmsqvLWgbrjmTNMdWrMh([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object IOwfU6WghVABKTDvv72K([In] object obj0) => (object) string.Concat((string[]) obj0);

    internal static bool GgfSlPWgB381RoQsQs5A() => ViewModelTypeName.QU91FpWgFVLR1E6TYVSO == null;

    internal static ViewModelTypeName ARkh9TWgWJNRU4W0j3UY() => ViewModelTypeName.QU91FpWgFVLR1E6TYVSO;

    internal static void lwJJUeWgGixgN3beSed4() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
