// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Serialization.KnownTypesBinder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json.Serialization;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Serialization
{
  /// <summary>Биндер типов при сериализации и десериализации.</summary>
  /// <remarks>
  /// При сериализации в поле "$type" записывается только FullName (Namespace + Name) типа без привязки к сборке
  /// </remarks>
  internal sealed class KnownTypesBinder : ISerializationBinder
  {
    private static KnownTypesBinder instance;
    internal static KnownTypesBinder uqlECqB91KOwfiY6oyq8;

    /// <summary>Экземпляр биндера</summary>
    internal static KnownTypesBinder Instance
    {
      get
      {
        int num = 1;
        KnownTypesBinder instance;
        while (true)
        {
          switch (num)
          {
            case 1:
              instance = KnownTypesBinder.instance;
              if (instance == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return instance;
label_5:
        return KnownTypesBinder.instance = new KnownTypesBinder();
      }
    }

    /// <summary>
    /// Биндинг к конкретному типу по имени типа и имени сборки
    /// </summary>
    /// <param name="assemblyName">Имя сборки</param>
    /// <param name="typeName">Имя типа</param>
    /// <returns>Тип</returns>
    public Type BindToType(string assemblyName, string typeName)
    {
      int num1 = 1;
      Type type1;
      Type type2;
      Type type3;
      Type type4;
      Type type5;
      Type type6;
      Type type7;
      Type type8;
      Type type9;
      Type type10;
      Type type11;
      string typeName1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
            continue;
          case 2:
            type2 = KnownTypesBinder.hBx8HlB94msLG37i5Tyl(KnownTypesBinder.FiYb91B9wGN8UEjqPt9Q((object) typeName1, KnownTypesBinder.DIZJQJB9athypMfjtw2F(-951514650 ^ -951556348)), false);
            if ((object) type2 == null)
            {
              num1 = 4;
              continue;
            }
            goto label_44;
          case 3:
            type3 = Type.GetType((string) KnownTypesBinder.FiYb91B9wGN8UEjqPt9Q((object) typeName1, KnownTypesBinder.DIZJQJB9athypMfjtw2F(-2106517564 ^ -2106558082)), false);
            if ((object) type3 == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 2 : 0;
              continue;
            }
            goto label_36;
          case 4:
            type4 = KnownTypesBinder.hBx8HlB94msLG37i5Tyl(KnownTypesBinder.FiYb91B9wGN8UEjqPt9Q((object) typeName1, KnownTypesBinder.DIZJQJB9athypMfjtw2F(-1120607109 - 305487170 ^ -1426135001)), false);
            if ((object) type4 == null)
            {
              num1 = 17;
              continue;
            }
            goto label_33;
          case 5:
            type5 = KnownTypesBinder.hBx8HlB94msLG37i5Tyl(KnownTypesBinder.FiYb91B9wGN8UEjqPt9Q((object) typeName1, KnownTypesBinder.DIZJQJB9athypMfjtw2F(1654249598 >> 2 ^ 413599307)), false);
            if ((object) type5 == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 8 : 10;
              continue;
            }
            goto label_22;
          case 6:
            type6 = KnownTypesBinder.hBx8HlB94msLG37i5Tyl(KnownTypesBinder.FiYb91B9wGN8UEjqPt9Q((object) typeName1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867145141)), false);
            if ((object) type6 == null)
            {
              num1 = 11;
              continue;
            }
            goto label_24;
          case 7:
            try
            {
              type1 = KnownTypesBinder.VASfMwB9tBlSkKZgBjJf(KnownTypesBinder.TA630aB9DNNUBDGvdQcA((object) typeName1, KnownTypesBinder.DIZJQJB9athypMfjtw2F(333888594 ^ 1075625116 ^ 1408896204), (object) assemblyName), false);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_4;
              }
            }
            catch
            {
              int num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
                num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    type1 = (Type) null;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
            }
          case 8:
            goto label_46;
          case 9:
            type1 = ReflectionType.GetType(typeName1, false);
            num1 = 15;
            continue;
          case 10:
            type7 = KnownTypesBinder.hBx8HlB94msLG37i5Tyl(KnownTypesBinder.FiYb91B9wGN8UEjqPt9Q((object) typeName1, KnownTypesBinder.DIZJQJB9athypMfjtw2F(-1146510045 ^ -1146563233)), false);
            if ((object) type7 == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 6 : 8;
              continue;
            }
            goto label_18;
          case 11:
            type8 = KnownTypesBinder.hBx8HlB94msLG37i5Tyl(KnownTypesBinder.FiYb91B9wGN8UEjqPt9Q((object) typeName1, KnownTypesBinder.DIZJQJB9athypMfjtw2F(874012245 ^ 874065527)), false);
            if ((object) type8 == null)
            {
              num1 = 5;
              continue;
            }
            goto label_41;
          case 12:
            goto label_25;
          case 13:
            type9 = Type.GetType((string) KnownTypesBinder.FiYb91B9wGN8UEjqPt9Q((object) typeName1, KnownTypesBinder.DIZJQJB9athypMfjtw2F(1597012150 ^ 1597052700)), false);
            if ((object) type9 == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 6 : 4;
              continue;
            }
            goto label_47;
          case 14:
            type10 = KnownTypesBinder.hBx8HlB94msLG37i5Tyl(KnownTypesBinder.FiYb91B9wGN8UEjqPt9Q((object) typeName1, KnownTypesBinder.DIZJQJB9athypMfjtw2F(1149433385 + 173655049 ^ 1323160908)), false);
            if ((object) type10 == null)
            {
              num1 = 13;
              continue;
            }
            goto label_27;
          case 15:
            if (KnownTypesBinder.sApKfZB9pGpnr6WOCoCe(type1, (Type) null))
            {
              num1 = 7;
              continue;
            }
            goto case 16;
          case 16:
label_4:
            if (!(type1 != (Type) null))
            {
              num1 = 3;
              continue;
            }
            goto label_25;
          case 17:
            type11 = KnownTypesBinder.hBx8HlB94msLG37i5Tyl(KnownTypesBinder.FiYb91B9wGN8UEjqPt9Q((object) typeName1, KnownTypesBinder.DIZJQJB9athypMfjtw2F(-951514650 ^ -951556426)), false);
            if ((object) type11 == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 1 : 14;
              continue;
            }
            goto label_30;
          default:
            typeName1 = typeName;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 9 : 6;
            continue;
        }
      }
label_47:
      return type9;
label_44:
      return type2;
label_41:
      return type8;
label_25:
      return type1;
label_36:
      return type3;
label_33:
      return type4;
label_30:
      return type11;
label_27:
      return type10;
label_24:
      return type6;
label_22:
      return type5;
label_18:
      return type7;
label_46:
      string typeName2 = typeName1;
      // ISSUE: reference to a compiler-generated field
      Func<AssemblyName, Assembly> func = KnownTypesBinder.\u003C\u003Ec.\u003C\u003E9__3_0;
      Func<AssemblyName, Assembly> assemblyResolver;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        KnownTypesBinder.\u003C\u003Ec.\u003C\u003E9__3_0 = assemblyResolver = (Func<AssemblyName, Assembly>) (asmName => (Assembly) KnownTypesBinder.\u003C\u003Ec.LXYfM0QOLJLfY0n8TSYV(KnownTypesBinder.\u003C\u003Ec.RbBH8lQOYkE7jmWmlbmi((object) asmName), false));
      }
      else
        goto label_50;
label_49:
      Func<Assembly, string, bool, Type> typeResolver = (Func<Assembly, string, bool, Type>) ((assembly, name, ignoreCase) =>
      {
        int num4 = 1;
        while (true)
        {
          switch (num4)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              if (!KnownTypesBinder.\u003C\u003Ec__DisplayClass3_0.SCCGvBQO9eXjApsZQahS((object) assembly, (object) null))
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        // ISSUE: reference to a compiler-generated method
        return KnownTypesBinder.\u003C\u003Ec__DisplayClass3_0.JdkxGFQOdwr4kuHgbukd((object) typeName1, false, ignoreCase);
label_3:
        // ISSUE: reference to a compiler-generated method
        return KnownTypesBinder.\u003C\u003Ec__DisplayClass3_0.gdX7EpQOlZNXE3nZTcQD((object) assembly, (object) name, false, ignoreCase);
      });
      return ReflectionType.GetType(typeName2, assemblyResolver, typeResolver, false, false);
label_50:
      assemblyResolver = func;
      goto label_49;
    }

    /// <summary>Биндинг типа к имени типа и имени сборки</summary>
    /// <param name="serializedType">Тип, который сериализуется</param>
    /// <param name="assemblyName">Имя сборки</param>
    /// <param name="typeName">Имя типа</param>
    public void BindToName(Type serializedType, out string assemblyName, out string typeName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            assemblyName = serializedType.Assembly.FullName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            typeName = (string) KnownTypesBinder.aSwiJoB96uIjs2vR9eQS(serializedType);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Получить полное имя типа без названия сборки.</summary>
    /// <remarks>
    /// Пример:
    /// Для типа: <see cref="!:System.Collections.Generic.Dictionary&lt;System.String, System.Collections.List&lt;System.String&gt;&gt;" />
    /// Получится строка: System.Collections.Generic.Dictionary`2[[System.String], [System.Collections.Generic.List`1[[System.String]]]]
    /// </remarks>
    /// <param name="serializedType">Тип, который необходимо сериализовать</param>
    /// <returns>Название типа в строковом виде без сборки</returns>
    private static string GetFullName(Type serializedType)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!serializedType.IsGenericType)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return serializedType.FullName;
label_5:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return serializedType.GetGenericTypeDefinition().FullName + (string) KnownTypesBinder.DIZJQJB9athypMfjtw2F(813604817 ^ 813590835) + string.Join((string) KnownTypesBinder.DIZJQJB9athypMfjtw2F(-675505729 ^ -675506755), ((IEnumerable<Type>) serializedType.GetGenericArguments()).Select<Type, string>((Func<Type, string>) (arg => (string) KnownTypesBinder.\u003C\u003Ec.EWicrjQOU7l8vBZ9oRjA(-812025778 ^ -812020052) + (string) KnownTypesBinder.\u003C\u003Ec.MxgPr8QOs36mspaGMd5U(arg) + (string) KnownTypesBinder.\u003C\u003Ec.EWicrjQOU7l8vBZ9oRjA(-2106517564 ^ -2106466004)))) + (string) KnownTypesBinder.DIZJQJB9athypMfjtw2F(1253244298 - 1829393894 ^ -576171700);
    }

    public KnownTypesBinder()
    {
      KnownTypesBinder.mFqqGoB9HGvAhSaaLLl2();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool kEf6a3B9NFYUhncS1gEr() => KnownTypesBinder.uqlECqB91KOwfiY6oyq8 == null;

    internal static KnownTypesBinder PnB9UjB93gkS0l7Xcwsd() => KnownTypesBinder.uqlECqB91KOwfiY6oyq8;

    internal static bool sApKfZB9pGpnr6WOCoCe([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object DIZJQJB9athypMfjtw2F(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object TA630aB9DNNUBDGvdQcA([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static Type VASfMwB9tBlSkKZgBjJf([In] object obj0, bool throwOnError) => ReflectionType.GetType((string) obj0, throwOnError);

    internal static object FiYb91B9wGN8UEjqPt9Q([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static Type hBx8HlB94msLG37i5Tyl([In] object obj0, [In] bool obj1) => Type.GetType((string) obj0, obj1);

    internal static object aSwiJoB96uIjs2vR9eQS(Type serializedType) => (object) KnownTypesBinder.GetFullName(serializedType);

    internal static void mFqqGoB9HGvAhSaaLLl2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
