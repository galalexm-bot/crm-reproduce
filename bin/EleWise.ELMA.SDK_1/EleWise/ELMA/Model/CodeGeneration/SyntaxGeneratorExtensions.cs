// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.SyntaxGeneratorExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.CodeGeneration.CSharp;
using EleWise.ELMA.CodeGeneration.CSharp.Nodes;
using EleWise.ELMA.CodeGeneration.CSharp.Trivias;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Memory;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace EleWise.ELMA.Model.CodeGeneration
{
  public static class SyntaxGeneratorExtensions
  {
    [ThreadStatic]
    private static SyntaxGenerator syntaxGenerator;
    [ThreadStatic]
    private static ICollection<string> ignoreNamespaces;
    internal static SyntaxGeneratorExtensions s2T1WVhPONeogEjGaJy6;

    public static SyntaxGenerator SyntaxGenerator
    {
      get
      {
        int num1 = 1;
        string str;
        bool lockTaken;
        while (true)
        {
          switch (num1)
          {
            case 1:
              if (SyntaxGeneratorExtensions.syntaxGenerator != null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            case 2:
              lockTaken = false;
              num1 = 5;
              continue;
            case 3:
              str = z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867426927);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 2;
              continue;
            case 5:
              goto label_2;
            default:
              goto label_13;
          }
        }
label_2:
        try
        {
          Monitor.Enter((object) str, ref lockTaken);
          int num2 = 2;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
            num2 = 2;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_13;
              case 2:
                if (SyntaxGeneratorExtensions.syntaxGenerator == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
                  continue;
                }
                goto label_13;
              default:
                SyntaxGeneratorExtensions.syntaxGenerator = new SyntaxGenerator();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 1;
                continue;
            }
          }
        }
        finally
        {
          int num3;
          if (!lockTaken)
            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
          else
            goto label_11;
label_10:
          switch (num3)
          {
            case 1:
              break;
            default:
          }
label_11:
          Monitor.Exit((object) str);
          num3 = 2;
          goto label_10;
        }
label_13:
        return SyntaxGeneratorExtensions.syntaxGenerator;
      }
    }

    /// <summary>Сгенерировать исходный код</summary>
    /// <param name="declaration">Namespace import, namespace or type declaration</param>
    /// <returns>Исходный код</returns>
    public static byte[] GenerateCSCode(this ISyntaxNode declaration) => SyntaxGeneratorExtensions.GenerateCSCode(new ISyntaxNode[1]
    {
      declaration
    });

    /// <summary>Сгенерировать исходный код</summary>
    /// <param name="declarations">Zero or more namespace import, namespace or type declarations</param>
    /// <returns>Исходный код</returns>
    public static byte[] GenerateCSCode(params ISyntaxNode[] declarations) => ((IEnumerable<ISyntaxNode>) declarations).AsEnumerable<ISyntaxNode>().GenerateCSCode();

    /// <summary>Сгенерировать исходный код</summary>
    /// <param name="declarations">Zero or more namespace import, namespace or type declarations</param>
    /// <returns>Исходный код</returns>
    public static byte[] GenerateCSCode(this IEnumerable<ISyntaxNode> declarations)
    {
      using (MemoryStream memoryStream = MemoryHelper.GetMemoryStream())
      {
        using (StreamWriter writer = new StreamWriter((Stream) memoryStream, Encoding.UTF8))
        {
          SyntaxGeneratorExtensions.SyntaxGenerator.Generate(declarations.Unpack(), (TextWriter) writer, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1515136725));
          writer.Flush();
          return memoryStream.ToArray();
        }
      }
    }

    /// <summary>Сгенерировать исходный код в строку</summary>
    /// <param name="declaration">Namespace import, namespace or type declaration</param>
    /// <returns>Исходный код</returns>
    public static string GenerateCSCodeString(this ISyntaxNode declaration) => SyntaxGeneratorExtensions.GenerateCSCodeString(new ISyntaxNode[1]
    {
      declaration
    });

    /// <summary>Сгенерировать исходный код в строку</summary>
    /// <param name="declarations">Zero or more namespace import, namespace or type declarations</param>
    /// <returns>Исходный код</returns>
    public static string GenerateCSCodeString(params ISyntaxNode[] declarations) => ((IEnumerable<ISyntaxNode>) declarations).AsEnumerable<ISyntaxNode>().GenerateCSCodeString();

    /// <summary>Сгенерировать исходный код в строку</summary>
    /// <param name="declarations">Zero or more namespace import, namespace or type declarations</param>
    /// <returns>Исходный код</returns>
    public static string GenerateCSCodeString(this IEnumerable<ISyntaxNode> declarations) => SyntaxGeneratorExtensions.SyntaxGenerator.Generate(declarations.Unpack(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825310458), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822915290));

    public static ISyntaxNode IdentifierName(this string identifier) => ((SyntaxNode) SyntaxGeneratorExtensions.CYY0W1hP1FVsdjn6tLgq(SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr(), (object) identifier)).Pack();

    public static ISyntaxNode GenericName(
      this string identifier,
      params ISyntaxNode[] typeArguments)
    {
      return identifier.GenericName(((IEnumerable<ISyntaxNode>) typeArguments).AsEnumerable<ISyntaxNode>());
    }

    public static ISyntaxNode GenericName(
      this string identifier,
      IEnumerable<ISyntaxNode> typeArguments)
    {
      return SyntaxGeneratorExtensions.SyntaxGenerator.GenericName(identifier, typeArguments.Unpack()).Pack();
    }

    public static bool IsGeneric(this ISyntaxNode declaration) => declaration.GetGenericArguments() != null;

    public static string GetGenericIdentifier(this ISyntaxNode declaration)
    {
      int num = 2;
      GenericNameSyntax genericNameSyntax;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (genericNameSyntax == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            genericNameSyntax = SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) declaration) as GenericNameSyntax;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 1 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return (string) null;
label_5:
      return (string) SyntaxGeneratorExtensions.jBQrwshP3PTx97TcRmB9((object) genericNameSyntax);
    }

    public static IEnumerable<ISyntaxNode> GetGenericArguments(this ISyntaxNode declaration)
    {
      TypeSyntax[] typeArguments = declaration.Unpack() is GenericNameSyntax genericNameSyntax ? genericNameSyntax.TypeArguments : (TypeSyntax[]) null;
      return typeArguments == null || typeArguments.Length == 0 ? (IEnumerable<ISyntaxNode>) null : ((IEnumerable<SyntaxNode>) typeArguments).Pack();
    }

    public static ISyntaxNode Null => (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng(SyntaxGeneratorExtensions.mCAYDHhPpuAWwaSQQTa7(SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr()));

    public static ISyntaxNode This => (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng((object) ((SyntaxGenerator) SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr()).ThisExpression());

    public static ISyntaxNode Base => (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng(SyntaxGeneratorExtensions.AXO8nshPDqbtI6gr61R6(SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr()));

    public static ISyntaxNode Value => (ISyntaxNode) SyntaxGeneratorExtensions.s092OqhPwXvD2xKWydyw(SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(87862435 ^ 87877077));

    public static void WithIgnoreNamespaces(this ICollection<string> namespaces, System.Action action) => namespaces.WithIgnoreNamespaces<int>((Func<int>) (() =>
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            action();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return 0;
    }));

    public static T WithIgnoreNamespaces<T>(this ICollection<string> namespaces, Func<T> action)
    {
      ICollection<string> ignoreNamespaces = SyntaxGeneratorExtensions.ignoreNamespaces;
      try
      {
        SyntaxGeneratorExtensions.ignoreNamespaces = namespaces;
        return action();
      }
      finally
      {
        SyntaxGeneratorExtensions.ignoreNamespaces = ignoreNamespaces;
      }
    }

    private static ICollection<string> IgnoreNamespaces => SyntaxGeneratorExtensions.ignoreNamespaces ?? (ICollection<string>) new string[0];

    private static void IgnoreNamespace(ref string typeName)
    {
      int num1 = 1;
      while (true)
      {
        string str;
        int num2;
        object obj;
        switch (num1)
        {
          case 1:
            num2 = SyntaxGeneratorExtensions.hDOW0nhP4TCw3bP9J7YK((object) typeName, '.');
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_15;
          case 3:
            typeName = num2 <= 0 ? typeName : (string) SyntaxGeneratorExtensions.U4M9MshPHK96RJ1Wl1Et((object) typeName, num2 + 1);
            num1 = 5;
            continue;
          case 4:
            obj = SyntaxGeneratorExtensions.QQkRvQhP6fpfFLLA4639((object) typeName, 0, num2);
            break;
          case 5:
            goto label_6;
          case 6:
            obj = (object) null;
            break;
          case 7:
            if (str == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 2 : 1;
              continue;
            }
            goto case 8;
          case 8:
            if (SyntaxGeneratorExtensions.IgnoreNamespaces.Contains(str))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 3 : 2;
              continue;
            }
            goto label_7;
          default:
            if (num2 > 0)
            {
              num1 = 4;
              continue;
            }
            goto case 6;
        }
        str = (string) obj;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 2 : 7;
      }
label_15:
      return;
label_6:
      return;
label_7:;
    }

    private static void AddGlobal(ref string typeName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (SyntaxGeneratorExtensions.NeXC9HhPAilYihGIP9eo((object) typeName, SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(-1380439818 << 3 ^ 1841388916)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
              continue;
            }
            goto label_9;
          case 2:
            goto label_2;
          case 3:
            typeName = (string) SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(44884861 ^ 44918335) + typeName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 2;
            continue;
          default:
            if (!SyntaxGeneratorExtensions.jSEfFqhP7etjIiiZnT5w((object) typeName, SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(-1317790512 ^ -1317693038)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 3;
              continue;
            }
            goto label_8;
        }
      }
label_2:
      return;
label_8:
      return;
label_9:;
    }

    /// <summary>Создать ссылку на тип</summary>
    /// <typeparam name="T">Тип</typeparam>
    public static ISyntaxNode CreateTypeSyntax<T>() => TypeOf<T>.Raw.CreateTypeSyntax();

    /// <summary>Создать ссылку на тип</summary>
    /// <param name="type">Тип</param>
    public static ISyntaxNode CreateTypeSyntax(this Type type)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            Contract.ArgumentNotNull((object) type, (string) SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(1917998801 >> 2 ^ 479500694));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (ISyntaxNode) SyntaxGeneratorExtensions.gTDhJXhPxOUxnRrST4OZ(type, true);
    }

    /// <summary>Создать ссылку на тип</summary>
    /// <param name="type">Тип</param>
    /// <param name="useGlobal">Дописывать global::</param>
    public static ISyntaxNode CreateTypeSyntax(this Type type, bool useGlobal)
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_11;
          case 2:
            if (type.IsGenericType)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 1;
              continue;
            }
            goto label_15;
          case 3:
            goto label_5;
          case 4:
            if (!type.IsArray)
            {
              if (!type.IsGenericParameter)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 1 : 2;
                continue;
              }
              goto label_5;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
              continue;
            }
          case 5:
            SyntaxGeneratorExtensions.xxOQsvhP0Bh14afDXB8A((object) type, SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(92412609 - 1050237057 ^ -957821342));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 4 : 4;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (ISyntaxNode) SyntaxGeneratorExtensions.OZGLpRhPy1QT8LFbGgLH(SyntaxGeneratorExtensions.eACjIfhPmu37oVjVtfMl(type.GetElementType()));
label_5:
      return (ISyntaxNode) SyntaxGeneratorExtensions.QJElImhPMyCQONFOQx7J((object) type.Name);
label_11:
      Type genericTypeDefinition = type.GetGenericTypeDefinition();
      Type[] genericArguments = type.GetGenericArguments();
      // ISSUE: reference to a compiler-generated field
      Func<Type, ISyntaxNode> func = SyntaxGeneratorExtensions.\u003C\u003Ec.\u003C\u003E9__33_0;
      Func<Type, ISyntaxNode> selector;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        SyntaxGeneratorExtensions.\u003C\u003Ec.\u003C\u003E9__33_0 = selector = (Func<Type, ISyntaxNode>) (t => (ISyntaxNode) SyntaxGeneratorExtensions.\u003C\u003Ec.QOghwWvu59mnKYyPnXWL(t));
      }
      else
        goto label_12;
label_14:
      ISyntaxNode[] array = ((IEnumerable<Type>) genericArguments).Select<Type, ISyntaxNode>(selector).ToArray<ISyntaxNode>();
      return genericTypeDefinition.CreateTypeSyntax(array);
label_12:
      selector = func;
      goto label_14;
label_15:
      return type.CreateTypeSyntax(useGlobal, (ISyntaxNode[]) null);
    }

    /// <summary>Создать ссылку на тип</summary>
    /// <param name="type">Тип</param>
    /// <param name="typeArguments">Аргументы типа (для Generic-типов)</param>
    public static ISyntaxNode CreateTypeSyntax(this Type type, params ISyntaxNode[] typeArguments) => type.CreateTypeSyntax(true, typeArguments);

    /// <summary>Создать ссылку на тип</summary>
    /// <param name="type">Тип</param>
    /// <param name="useGlobal">Дописывать global::</param>
    /// <param name="typeArguments">Аргументы типа (для Generic-типов)</param>
    public static ISyntaxNode CreateTypeSyntax(
      this Type type,
      bool useGlobal,
      params ISyntaxNode[] typeArguments)
    {
      return type.FullName.CreateTypeSyntax(useGlobal, typeArguments);
    }

    /// <summary>Создать ссылку на тип</summary>
    /// <param name="typeName">Полное имя типа</param>
    public static ISyntaxNode CreateTypeSyntax(this string typeName) => (ISyntaxNode) SyntaxGeneratorExtensions.CFjP60hPJCjwBVf1HtXL((object) typeName, true);

    /// <summary>Создать ссылку на тип</summary>
    /// <param name="typeName">Полное имя типа</param>
    /// <param name="useGlobal">Дописывать global::</param>
    public static ISyntaxNode CreateTypeSyntax(this string typeName, bool useGlobal)
    {
      int num1 = 33;
      ISyntaxNode[] syntaxNodeArray;
      bool useGlobal1;
      while (true)
      {
        int num2 = num1;
        int num3;
        int index1;
        List<string> list1;
        List<string> list2;
        int index2;
        List<string> stringList;
        int index3;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 37:
              if (list2[index2].Count<char>((Func<char, bool>) (c => c == '[')) <= list2[index2].Count<char>((Func<char, bool>) (c => c == ']')))
              {
                num2 = 25;
                continue;
              }
              goto case 12;
            case 2:
              if (num3 <= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 9 : 22;
                continue;
              }
              goto label_17;
            case 3:
              SyntaxGeneratorExtensions.tJKtTohPrMRj7qlOdqA7((object) list1, index1 + 1);
              num2 = 18;
              continue;
            case 4:
              goto label_18;
            case 5:
              index3 = index1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 26 : 26;
              continue;
            case 6:
            case 20:
              if (index2 < SyntaxGeneratorExtensions.LC4DTkhPgmvVqjOgUK1t((object) list2))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 37 : 9;
                continue;
              }
              goto label_18;
            case 7:
            case 23:
              goto label_12;
            case 8:
              num3 = SyntaxGeneratorExtensions.CXte2nhP94T0O9IAFUZa((object) typeName, '<');
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 2 : 2;
              continue;
            case 9:
              stringList = list1;
              num2 = 5;
              continue;
            case 10:
              typeName = (string) SyntaxGeneratorExtensions.qOWVsVhPdsdqmh36Fp84((object) typeName, num3);
              num2 = 27;
              continue;
            case 11:
              stringList[index3] = stringList[index3] + (string) SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(1574260816 ^ 1574240928) + list2[index2 + 1];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 13 : 1;
              continue;
            case 12:
              stringList = list2;
              num2 = 28;
              continue;
            case 13:
              SyntaxGeneratorExtensions.tJKtTohPrMRj7qlOdqA7((object) list2, index2 + 1);
              num2 = 15;
              continue;
            case 14:
              ++index1;
              num2 = 17;
              continue;
            case 15:
              --index2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 35 : 27;
              continue;
            case 16:
              if (num3 > 0)
              {
                num2 = 30;
                continue;
              }
              goto label_12;
            case 17:
            case 31:
              if (index1 >= SyntaxGeneratorExtensions.LC4DTkhPgmvVqjOgUK1t((object) list1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
                continue;
              }
              goto case 21;
            case 18:
              --index1;
              num2 = 14;
              continue;
            case 19:
              syntaxNodeArray = (ISyntaxNode[]) null;
              num2 = 8;
              continue;
            case 21:
              string source = list1[index1];
              // ISSUE: reference to a compiler-generated field
              Func<char, bool> func = SyntaxGeneratorExtensions.\u003C\u003Ec.\u003C\u003E9__37_1;
              Func<char, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                SyntaxGeneratorExtensions.\u003C\u003Ec.\u003C\u003E9__37_1 = predicate = (Func<char, bool>) (c => c == '<');
              }
              else
                goto label_43;
label_39:
              if (source.Count<char>(predicate) > list1[index1].Count<char>((Func<char, bool>) (c => c == '>')))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 9 : 9;
                continue;
              }
              goto case 14;
label_43:
              predicate = func;
              goto label_39;
            case 22:
            case 24:
              goto label_32;
            case 25:
            case 35:
              ++index2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 6 : 2;
              continue;
            case 26:
              stringList[index3] = stringList[index3] + (string) SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(1242972401 >> 4 ^ 77674239) + list1[index1 + 1];
              num2 = 3;
              continue;
            case 27:
              index2 = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 5 : 20;
              continue;
            case 28:
              index3 = index2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 11 : 2;
              continue;
            case 29:
              typeName = (string) SyntaxGeneratorExtensions.qOWVsVhPdsdqmh36Fp84((object) typeName, num3);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 20 : 34;
              continue;
            case 30:
              list2 = ((IEnumerable<string>) SyntaxGeneratorExtensions.RDZSHAhPlGC2fywTxxOY(SyntaxGeneratorExtensions.U4M9MshPHK96RJ1Wl1Et(SyntaxGeneratorExtensions.qOWVsVhPdsdqmh36Fp84((object) typeName, typeName.LastIndexOf(']')), num3 + 1), (object) new char[1]
              {
                ','
              })).ToList<string>();
              num2 = 10;
              continue;
            case 32:
              useGlobal1 = useGlobal;
              num2 = 19;
              continue;
            case 33:
              num2 = 32;
              continue;
            case 34:
              index1 = 0;
              num2 = 31;
              continue;
            case 36:
              goto label_17;
            default:
              // ISSUE: reference to a compiler-generated method
              syntaxNodeArray = list1.Select<string, ISyntaxNode>((Func<string, ISyntaxNode>) (a => (ISyntaxNode) SyntaxGeneratorExtensions.\u003C\u003Ec__DisplayClass37_0.DpmtZdvIbEscZpXLccgJ((object) a, useGlobal1))).ToArray<ISyntaxNode>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 18 : 23;
              continue;
          }
        }
label_17:
        list1 = ((IEnumerable<string>) SyntaxGeneratorExtensions.RDZSHAhPlGC2fywTxxOY((object) ((string) SyntaxGeneratorExtensions.qOWVsVhPdsdqmh36Fp84((object) typeName, typeName.LastIndexOf('>'))).Substring(num3 + 1), (object) new char[1]
        {
          ','
        })).ToList<string>();
        num1 = 29;
        continue;
label_18:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        syntaxNodeArray = list2.Select<string, ISyntaxNode>((Func<string, ISyntaxNode>) (a => (ISyntaxNode) SyntaxGeneratorExtensions.\u003C\u003Ec__DisplayClass37_0.DpmtZdvIbEscZpXLccgJ((object) a.Substring(1, SyntaxGeneratorExtensions.\u003C\u003Ec__DisplayClass37_0.FHBPBgvIh2h9edJaK2i4((object) a) - 2), useGlobal1))).ToArray<ISyntaxNode>();
        num1 = 7;
        continue;
label_32:
        num3 = SyntaxGeneratorExtensions.CXte2nhP94T0O9IAFUZa((object) typeName, '[');
        num1 = 16;
      }
label_12:
      return typeName.CreateTypeSyntax(useGlobal1, syntaxNodeArray);
    }

    /// <summary>Создать ссылку на тип</summary>
    /// <param name="typeName">Полное имя типа</param>
    /// <param name="typeArguments">Аргументы типа (для Generic-типов)</param>
    public static ISyntaxNode CreateTypeSyntax(
      this string typeName,
      params ISyntaxNode[] typeArguments)
    {
      return typeName.CreateTypeSyntax(true, typeArguments);
    }

    /// <summary>Создать ссылку на тип</summary>
    /// <param name="typeName">Полное имя типа</param>
    /// <param name="useGlobal">Дописывать global::</param>
    /// <param name="typeArguments">Аргументы типа (для Generic-типов)</param>
    public static ISyntaxNode CreateTypeSyntax(
      this string typeName,
      bool useGlobal,
      params ISyntaxNode[] typeArguments)
    {
      int num1 = 82;
      while (true)
      {
        int num2 = num1;
        uint num3;
        int num4;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (num3 != 1324880019U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 15 : 45;
                continue;
              }
              goto case 98;
            case 2:
            case 22:
            case 61:
            case 73:
            case 79:
            case 93:
            case 113:
            case 136:
              goto label_102;
            case 3:
              if (SyntaxGeneratorExtensions.CaqHKyhPjP0LWp9itjL8((object) typeName, SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(-1487388570 ^ -1487200242)))
              {
                num2 = 136;
                continue;
              }
              goto case 17;
            case 4:
              if (SyntaxGeneratorExtensions.CaqHKyhPjP0LWp9itjL8((object) typeName, SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(1021410165 ^ 1021453577)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 81 : 151;
                continue;
              }
              goto case 8;
            case 5:
            case 56:
              if (num3 <= 3409549631U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 25 : 92;
                continue;
              }
              goto case 84;
            case 6:
            case 54:
              if (typeArguments == null)
              {
                num2 = 69;
                continue;
              }
              goto label_29;
            case 7:
              if (num3 != 3079944380U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 156 : 112;
                continue;
              }
              goto case 15;
            case 8:
            case 13:
            case 19:
            case 20:
            case 23:
            case 32:
            case 33:
            case 39:
            case 46:
            case 55:
            case 71:
            case 75:
            case 81:
            case 97:
            case 111:
            case 115:
            case 118:
            case 119:
            case 129:
            case 130:
            case 145:
            case 146:
            case 152:
            case 155:
              // ISSUE: reference to a compiler-generated method
              num3 = \u003CPrivateImplementationDetails\u003E.ComputeStringHash(typeName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 20 : 125;
              continue;
            case 9:
              typeName = (string) SyntaxGeneratorExtensions.qOWVsVhPdsdqmh36Fp84((object) typeName, num4);
              num2 = 47;
              continue;
            case 10:
              if (num3 != 1625787317U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 126 : 78;
                continue;
              }
              goto case 29;
            case 11:
              if (num3 != 1697786220U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 14 : 99;
                continue;
              }
              goto case 26;
            case 12:
            case 30:
            case 50:
            case 64:
            case 77:
            case 107:
            case 123:
            case 124:
            case 151:
            case 154:
              goto label_53;
            case 14:
            case 148:
              if (num3 != 4180476474U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 94 : 10;
                continue;
              }
              goto case 135;
            case 15:
              if (SyntaxGeneratorExtensions.CaqHKyhPjP0LWp9itjL8((object) typeName, SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(694673736 ^ -23604109 ^ -671913383)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 2 : 1;
                continue;
              }
              goto case 17;
            case 16:
              if (num3 != 942540437U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 10 : 0;
                continue;
              }
              goto label_71;
            case 17:
            case 31:
            case 36:
            case 42:
            case 59:
            case 65:
            case 70:
            case 80:
            case 83:
            case 87:
            case 90:
            case 96:
            case 104:
            case 105:
            case 110:
            case 120:
            case 126:
            case (int) sbyte.MaxValue:
            case 138:
            case 144:
            case 157:
              num4 = typeName.IndexOf('`');
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 53 : 44;
              continue;
            case 18:
            case 47:
            case 149:
              typeName = (string) SyntaxGeneratorExtensions.c319iHhPL4ZZStZPvpr5((object) typeName, '+', '.');
              num2 = 147;
              continue;
            case 21:
            case 137:
              if (num3 <= 1323747186U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 117 : 85;
                continue;
              }
              goto case 1;
            case 24:
              if (num3 <= 875577056U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 37 : 37;
                continue;
              }
              goto case 60;
            case 25:
              if (num4 < 0)
              {
                num2 = 149;
                continue;
              }
              goto case 9;
            case 26:
              if (!(typeName == (string) SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(1033719030 - 2012070891 ^ -978528649)))
              {
                num2 = 70;
                continue;
              }
              goto label_102;
            case 27:
              if (SyntaxGeneratorExtensions.CaqHKyhPjP0LWp9itjL8((object) typeName, SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(-97972138 ^ -97890544)))
              {
                num2 = 113;
                continue;
              }
              goto case 17;
            case 28:
            case 142:
              if (num3 != 3969205087U)
              {
                num2 = 35;
                continue;
              }
              goto case 128;
            case 29:
              if (!SyntaxGeneratorExtensions.CaqHKyhPjP0LWp9itjL8((object) typeName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283590709)))
              {
                num2 = 144;
                continue;
              }
              goto label_102;
            case 34:
              if (num3 > 2747029693U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 118 : 131;
                continue;
              }
              goto case 109;
            case 35:
              if (num3 != 4051133705U)
              {
                num2 = 8;
                continue;
              }
              goto case 108;
            case 37:
              if (num3 != 347085918U)
              {
                num2 = 101;
                continue;
              }
              goto label_123;
            case 38:
              goto label_71;
            case 40:
              SyntaxGeneratorExtensions.AddGlobal(ref typeName);
              num2 = 6;
              continue;
            case 41:
              if (SyntaxGeneratorExtensions.CaqHKyhPjP0LWp9itjL8((object) typeName, SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(-630932142 - 1120244082 ^ -1751364694)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 61 : 2;
                continue;
              }
              goto case 17;
            case 43:
              if (num3 != 2185383742U)
              {
                num2 = 31;
                continue;
              }
              goto case 41;
            case 44:
              num3 = SyntaxGeneratorExtensions.j59ZWVhP500j9jGbbWLk((object) typeName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 132 : 82;
              continue;
            case 45:
              if (num3 != 1615808600U)
              {
                num2 = 146;
                continue;
              }
              goto case 67;
            case 48:
              goto label_123;
            case 49:
              if (SyntaxGeneratorExtensions.CaqHKyhPjP0LWp9itjL8((object) typeName, SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(1461825605 - 1531863589 ^ -70250310)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 107 : 61;
                continue;
              }
              goto case 8;
            case 51:
              if (num3 != 2779444460U)
              {
                num2 = 91;
                continue;
              }
              goto case 49;
            case 52:
              if (!SyntaxGeneratorExtensions.CaqHKyhPjP0LWp9itjL8((object) typeName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418260676)))
              {
                num2 = 129;
                continue;
              }
              goto label_53;
            case 53:
              if (num4 >= 0)
              {
                num2 = 106;
                continue;
              }
              goto case 153;
            case 57:
              if (num3 != 697196164U)
              {
                num2 = 39;
                continue;
              }
              goto case 4;
            case 58:
              if (typeName == z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 45071633))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 64 : 56;
                continue;
              }
              goto case 8;
            case 60:
              if (num3 > 1625787317U)
                goto case 11;
              else
                goto label_32;
            case 62:
              goto label_29;
            case 63:
            case 131:
              if (num3 > 3291009739U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 148 : 35;
                continue;
              }
              goto case 7;
            case 66:
              if (num3 != 1323747186U)
              {
                num2 = 152;
                continue;
              }
              goto case 52;
            case 67:
              if (!SyntaxGeneratorExtensions.CaqHKyhPjP0LWp9itjL8((object) typeName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479710072)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 46 : 42;
                continue;
              }
              goto label_53;
            case 68:
              if (typeName == (string) SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(~-306453669 ^ 306530762))
              {
                num2 = 79;
                continue;
              }
              goto case 17;
            case 69:
            case 112:
              goto label_26;
            case 72:
              if (SyntaxGeneratorExtensions.CaqHKyhPjP0LWp9itjL8((object) typeName, SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(-1939377524 ^ -1939592042)))
              {
                num2 = 12;
                continue;
              }
              goto case 8;
            case 74:
              if (SyntaxGeneratorExtensions.CaqHKyhPjP0LWp9itjL8((object) typeName, SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(-1088304168 ^ -1088252572)))
              {
                num2 = 30;
                continue;
              }
              goto case 8;
            case 76:
              if (typeName == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088252918))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 73 : 5;
                continue;
              }
              goto case 17;
            case 78:
              if (num3 != 3851314394U)
              {
                num2 = 75;
                continue;
              }
              goto case 122;
            case 82:
              if (SyntaxGeneratorExtensions.IgnoreNamespaces.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408962192)))
                goto case 44;
              else
                goto label_68;
            case 84:
              if (num3 > 3851314394U)
              {
                num2 = 142;
                continue;
              }
              goto case 158;
            case 85:
              if (num3 != 423635464U)
              {
                num2 = 121;
                continue;
              }
              goto case 116;
            case 86:
              if (num3 == 2249825754U)
                goto case 89;
              else
                goto label_90;
            case 88:
              if (!SyntaxGeneratorExtensions.CaqHKyhPjP0LWp9itjL8((object) typeName, SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(44884861 ^ 45056855)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 25 : 83;
                continue;
              }
              goto label_102;
            case 89:
              if (!(typeName == (string) SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(-1317790512 ^ -1317583876)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 63 : 80;
                continue;
              }
              goto label_102;
            case 91:
              if (num3 != 3409549631U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 101 : 115;
                continue;
              }
              goto case 103;
            case 92:
              if (num3 <= 2711245919U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 25 : 95;
                continue;
              }
              goto case 51;
            case 94:
              if (num3 != 4201364391U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 110 : 58;
                continue;
              }
              goto case 68;
            case 95:
              if (num3 != 2386971688U)
              {
                num2 = 143;
                continue;
              }
              goto case 74;
            case 98:
              if (!SyntaxGeneratorExtensions.CaqHKyhPjP0LWp9itjL8((object) typeName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886432507)))
              {
                num2 = 19;
                continue;
              }
              goto label_53;
            case 99:
              if (num3 != 1741144581U)
              {
                num2 = 42;
                continue;
              }
              goto case 88;
            case 100:
              if (!useGlobal)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 2 : 54;
                continue;
              }
              goto case 40;
            case 101:
              if (num3 != 848225627U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            case 102:
              if (num3 != 1764058053U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 41 : 43;
                continue;
              }
              goto case 150;
            case 103:
              if (!(typeName == (string) SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(-281842504 ^ -282054004)))
              {
                num2 = 130;
                continue;
              }
              goto label_53;
            case 106:
              typeName = (string) SyntaxGeneratorExtensions.qOWVsVhPdsdqmh36Fp84((object) typeName, num4);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 18 : 14;
              continue;
            case 108:
              if (typeName == (string) SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(--1867379187 ^ 1867427679))
              {
                num2 = 50;
                continue;
              }
              goto case 8;
            case 109:
              if (num3 <= 2185383742U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 33 : 102;
                continue;
              }
              goto case 86;
            case 114:
              goto label_25;
            case 116:
              if (!(typeName == (string) SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(-2138160520 ^ -2138235810)))
              {
                num2 = 118;
                continue;
              }
              goto label_53;
            case 117:
              if (num3 != 765439473U)
              {
                num2 = 66;
                continue;
              }
              goto case 134;
            case 121:
              if (num3 != 679076413U)
              {
                num2 = 57;
                continue;
              }
              goto case 72;
            case 122:
              if (!SyntaxGeneratorExtensions.CaqHKyhPjP0LWp9itjL8((object) typeName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099717581)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 55 : 20;
                continue;
              }
              goto label_53;
            case 125:
              if (num3 <= 1741144581U)
              {
                num2 = 24;
                continue;
              }
              goto case 34;
            case 128:
              if (typeName == (string) SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(372753449 ^ 372546081))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 32 : 154;
                continue;
              }
              goto case 8;
            case 132:
              if (num3 > 1615808600U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 5;
                continue;
              }
              goto case 139;
            case 133:
              if (num3 != 2747029693U)
              {
                num2 = 120;
                continue;
              }
              goto case 27;
            case 134:
              if (SyntaxGeneratorExtensions.CaqHKyhPjP0LWp9itjL8((object) typeName, SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(589593376 ^ -1977315327 ^ -1459374751)))
              {
                num2 = 123;
                continue;
              }
              goto case 8;
            case 135:
              if (SyntaxGeneratorExtensions.CaqHKyhPjP0LWp9itjL8((object) typeName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137505668)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 21 : 93;
                continue;
              }
              goto case 17;
            case 139:
              if (num3 > 697196164U)
              {
                num2 = 21;
                continue;
              }
              goto case 85;
            case 140:
              if (SyntaxGeneratorExtensions.CaqHKyhPjP0LWp9itjL8((object) typeName, SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(381945751 ^ 1158627804 ^ 1405622293)))
              {
                num2 = 124;
                continue;
              }
              goto case 8;
            case 141:
              if (SyntaxGeneratorExtensions.CaqHKyhPjP0LWp9itjL8((object) typeName, SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(-441065788 ^ -2092910478 ^ 1727399610)))
              {
                num2 = 22;
                continue;
              }
              goto case 17;
            case 143:
              if (num3 != 2711245919U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 32 : 18;
                continue;
              }
              goto case 140;
            case 147:
              goto label_24;
            case 150:
              if (!SyntaxGeneratorExtensions.CaqHKyhPjP0LWp9itjL8((object) typeName, SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(-2092274397 << 4 ^ 883264960)))
              {
                num2 = 157;
                continue;
              }
              goto label_102;
            case 153:
              num4 = SyntaxGeneratorExtensions.CXte2nhP94T0O9IAFUZa((object) typeName, ',');
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 25;
              continue;
            case 156:
              if (num3 == 3291009739U)
                goto case 76;
              else
                goto label_118;
            case 158:
              if (num3 != 3538687084U)
              {
                num2 = 78;
                continue;
              }
              goto case 58;
            default:
              if (num3 != 875577056U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 74 : 138;
                continue;
              }
              goto case 141;
          }
        }
label_24:
        SyntaxGeneratorExtensions.IgnoreNamespace(ref typeName);
        num1 = 100;
        continue;
label_29:
        if (typeArguments.Length == 0)
        {
          num1 = 112;
          continue;
        }
        break;
label_32:
        num1 = 16;
        continue;
label_53:
        typeName = (string) SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(1304605005 ^ 1304555409) + typeName;
        num1 = 71;
        continue;
label_68:
        num1 = 81;
        continue;
label_71:
        if (!(typeName == (string) SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(-398663332 ^ -398475580)))
        {
          num1 = 96;
          continue;
        }
        goto label_102;
label_90:
        num1 = 133;
        continue;
label_118:
        num1 = 59;
        continue;
label_123:
        if (!SyntaxGeneratorExtensions.CaqHKyhPjP0LWp9itjL8((object) typeName, SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(-477139494 ^ -477351210)))
          num1 = 104;
        else
          goto label_102;
      }
label_25:
      return (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng((object) SyntaxGeneratorExtensions.SyntaxGenerator.TypeSyntax(typeName, ((IEnumerable<ISyntaxNode>) typeArguments).Unpack()));
label_26:
      return ((SyntaxNode) SyntaxGeneratorExtensions.hGbBWShPYQaNbCPcYU4G(SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr(), (object) typeName)).Pack();
label_102:
      return (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng(SyntaxGeneratorExtensions.hGbBWShPYQaNbCPcYU4G(SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr(), (object) typeName));
    }

    public static ISyntaxNode CreateArrayTypeSyntax(this ISyntaxNode elementType) => (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng(SyntaxGeneratorExtensions.x2asjGhPUWY22WgFtQj3(SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr(), (object) elementType.Unpack()));

    /// <summary>Создать примитивное выражение из строки</summary>
    public static ISyntaxNode CreateAtStringSyntaxNode(this string value)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_16;
            case 2:
            case 7:
            case 9:
              goto label_17;
            case 3:
              if (!value.Contains<char>('\f'))
              {
                num2 = 8;
                continue;
              }
              goto label_17;
            case 4:
              if (value.Contains<char>(char.MinValue))
              {
                num2 = 7;
                continue;
              }
              goto case 6;
            case 5:
              if (value != null)
              {
                num2 = 4;
                continue;
              }
              goto label_13;
            case 6:
              if (value.Contains<char>('\a'))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 9 : 9;
                continue;
              }
              goto label_7;
            case 8:
              if (value.Contains<char>('\v'))
              {
                num2 = 2;
                continue;
              }
              goto label_16;
            case 10:
              goto label_13;
            default:
              goto label_7;
          }
        }
label_7:
        if (!value.Contains<char>('\b'))
          num1 = 3;
        else
          goto label_17;
      }
label_13:
      return (ISyntaxNode) SyntaxGeneratorExtensions.U2pecShPsvPhUw57ZSZJ();
label_16:
      return new LiteralExpressionSyntax((object) value, false).Pack();
label_17:
      return value.CreateStringSyntaxNode();
    }

    /// <summary>Создать примитивное выражение из строки</summary>
    public static ISyntaxNode CreateStringSyntaxNode(this string value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (value == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return (ISyntaxNode) SyntaxGeneratorExtensions.U2pecShPsvPhUw57ZSZJ();
label_3:
      return (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng(SyntaxGeneratorExtensions.zqYI3ahPcbWBDcwsX5xf((object) SyntaxGeneratorExtensions.SyntaxGenerator, (object) value));
    }

    /// <summary>Создать примитивное выражение</summary>
    public static ISyntaxNode CreateSyntaxNode(this object value)
    {
      int num1 = 1;
      IEnumerable<string> values;
      object value1;
      while (true)
      {
        int num2 = num1;
        Type type;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
              continue;
            case 2:
              object source = SyntaxGeneratorExtensions.k9ojMEh1ooTnYcL0Itqp((object) value1.ToString(), SyntaxGeneratorExtensions.HSUQm9h1W6jVfOUyehm8((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360351469)), StringSplitOptions.RemoveEmptyEntries);
              // ISSUE: reference to a compiler-generated field
              Func<string, string> func = SyntaxGeneratorExtensions.\u003C\u003Ec.\u003C\u003E9__43_1;
              Func<string, string> selector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                SyntaxGeneratorExtensions.\u003C\u003Ec.\u003C\u003E9__43_1 = selector = (Func<string, string>) (s => (string) SyntaxGeneratorExtensions.\u003C\u003Ec.YUtXDDvujdRLccfNwOjY((object) s));
              }
              else
                goto label_11;
label_55:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              values = ((IEnumerable<string>) source).Select<string, string>(selector).Where<string>((Func<string, bool>) (s => !SyntaxGeneratorExtensions.\u003C\u003Ec.utyUQPvuYMU9hsaEjSrN((object) s))).Select<string, string>((Func<string, string>) (s => (string) SyntaxGeneratorExtensions.\u003C\u003Ec__DisplayClass43_0.zNrcoovIv5ajMRDgZIBN(SyntaxGeneratorExtensions.\u003C\u003Ec__DisplayClass43_0.iufuWxvICYHxaQyoZMgQ(-1146510045 ^ -1146609567), (object) value1.GetType().FullName, SyntaxGeneratorExtensions.\u003C\u003Ec__DisplayClass43_0.iufuWxvICYHxaQyoZMgQ(--1360331293 ^ 1360337113), (object) s)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 15 : 1;
              continue;
label_11:
              selector = func;
              goto label_55;
            case 3:
              if (!SyntaxGeneratorExtensions.cEiGxghPzLTS2XXjSdqZ(type, TypeOf<ulong>.Raw))
              {
                num2 = 32;
                continue;
              }
              goto label_34;
            case 4:
              if (value1 != null)
              {
                num2 = 16;
                continue;
              }
              goto label_7;
            case 5:
              goto label_6;
            case 6:
              goto label_7;
            case 7:
              if (SyntaxGeneratorExtensions.cEiGxghPzLTS2XXjSdqZ(type, TypeOf<char>.Raw))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 19 : 8;
                continue;
              }
              goto case 27;
            case 8:
              if (SyntaxGeneratorExtensions.cEiGxghPzLTS2XXjSdqZ(type, TypeOf<int>.Raw))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 22 : 9;
                continue;
              }
              goto case 31;
            case 9:
              goto label_44;
            case 10:
              if (!(type == TypeOf<sbyte>.Raw))
              {
                num2 = 12;
                continue;
              }
              goto label_34;
            case 11:
              if (type == TypeOf<Decimal>.Raw)
              {
                num2 = 24;
                continue;
              }
              goto case 29;
            case 12:
              if (!SyntaxGeneratorExtensions.cEiGxghPzLTS2XXjSdqZ(type, TypeOf<short>.Raw))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 28 : 22;
                continue;
              }
              goto label_34;
            case 13:
              if (!SyntaxGeneratorExtensions.cEiGxghPzLTS2XXjSdqZ(type, TypeOf<float>.Raw))
              {
                num2 = 21;
                continue;
              }
              goto label_34;
            case 14:
              goto label_5;
            case 15:
              goto label_16;
            case 16:
              type = value1.GetType();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 2 : 7;
              continue;
            case 17:
            case 19:
            case 22:
            case 23:
            case 24:
            case 25:
            case 30:
              goto label_34;
            case 18:
              if ((object) (value1 as Type) == null)
              {
                num2 = 5;
                continue;
              }
              goto label_5;
            case 20:
              if (!((string) value1).Where<char>((Func<char, bool>) (c => c == '\n')).Skip<char>(1).Any<char>())
              {
                num2 = 9;
                continue;
              }
              goto label_45;
            case 21:
              goto label_12;
            case 26:
              if (!SyntaxGeneratorExtensions.cEiGxghPzLTS2XXjSdqZ(type, TypeOf<long>.Raw))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 3 : 3;
                continue;
              }
              goto label_34;
            case 27:
              if (value1 is bool)
              {
                num2 = 25;
                continue;
              }
              goto case 13;
            case 28:
              goto label_28;
            case 29:
              if (SyntaxGeneratorExtensions.cEiGxghPzLTS2XXjSdqZ(type, TypeOf<byte>.Raw))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 20 : 23;
                continue;
              }
              goto case 10;
            case 31:
              if (SyntaxGeneratorExtensions.cEiGxghPzLTS2XXjSdqZ(type, TypeOf<uint>.Raw))
              {
                num2 = 17;
                continue;
              }
              goto case 26;
            case 32:
              if (SyntaxGeneratorExtensions.cEiGxghPzLTS2XXjSdqZ(type, TypeOf<string>.Raw))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 14 : 20;
                continue;
              }
              if (!type.IsEnum)
              {
                if (!(value1 is ISyntaxNode))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 10 : 18;
                  continue;
                }
                goto label_39;
              }
              else
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 2 : 2;
                continue;
              }
            case 33:
              goto label_39;
            default:
              value1 = value;
              num2 = 4;
              continue;
          }
        }
label_12:
        if (!SyntaxGeneratorExtensions.cEiGxghPzLTS2XXjSdqZ(type, TypeOf<double>.Raw))
        {
          num1 = 11;
          continue;
        }
        goto label_34;
label_28:
        if (!SyntaxGeneratorExtensions.cEiGxghPzLTS2XXjSdqZ(type, TypeOf<ushort>.Raw))
          num1 = 8;
        else
          goto label_34;
      }
label_5:
      return (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng((object) SyntaxGeneratorExtensions.SyntaxGenerator.TypeOfExpression(((ISyntaxNode) SyntaxGeneratorExtensions.eACjIfhPmu37oVjVtfMl((Type) value1)).Unpack()));
label_6:
      throw new CodeGenerationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787280395), (object) value1.GetType().FullName));
label_7:
      return SyntaxGeneratorExtensions.Null;
label_16:
      return ((SyntaxNode) SyntaxGeneratorExtensions.CYY0W1hP1FVsdjn6tLgq(SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr(), (object) string.Join((string) SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(2008901894 << 3 ^ -1108858698), values))).Pack();
label_34:
      return (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng(SyntaxGeneratorExtensions.zqYI3ahPcbWBDcwsX5xf(SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr(), value1));
label_39:
      return (ISyntaxNode) value1;
label_44:
      return (ISyntaxNode) SyntaxGeneratorExtensions.etLcvJh1FTW6leG492aG((object) (string) value1);
label_45:
      return (ISyntaxNode) SyntaxGeneratorExtensions.cBE0GOh1BpyHGs9U5mjD((object) (string) value1);
    }

    private static string ProcessAttributeTypeName(object attributeTypeName)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 3:
              if (!SyntaxGeneratorExtensions.BdeYNch1bxCbjmjbXguB(attributeTypeName, SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(--1360331293 ^ 1360421631)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 4:
              // ISSUE: cast to a reference type
              SyntaxGeneratorExtensions.AddGlobal((string&) ref attributeTypeName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 3 : 3;
              continue;
            default:
              goto label_4;
          }
        }
label_3:
        attributeTypeName = SyntaxGeneratorExtensions.qOWVsVhPdsdqmh36Fp84(attributeTypeName, SyntaxGeneratorExtensions.ggn0Pmh1haHll4kHgHxO(attributeTypeName) - 9);
        num1 = 2;
      }
label_4:
      return (string) attributeTypeName;
    }

    /// <summary>Создать объявление атрибута</summary>
    public static ISyntaxNode CreateAttribute<T>(KeyValuePair<string, object>[] args) => TypeOf<T>.Raw.CreateAttribute(args);

    /// <summary>Создать объявление атрибута</summary>
    public static ISyntaxNode CreateAttribute(
      this Type attributeType,
      KeyValuePair<string, object>[] args)
    {
      return (ISyntaxNode) SyntaxGeneratorExtensions.weM2pwh1Gm55yMQjbaV5((object) attributeType.FullName, (object) args);
    }

    /// <summary>Создать объявление атрибута</summary>
    public static ISyntaxNode CreateAttribute<T>(params object[] args) => TypeOf<T>.Raw.CreateAttribute(args);

    /// <summary>Создать объявление атрибута</summary>
    public static ISyntaxNode CreateAttribute(this Type attributeType, params object[] args) => attributeType.FullName.CreateAttribute(args);

    /// <summary>Создать объявление атрибута</summary>
    public static ISyntaxNode CreateAttribute(
      this string attributeTypeName,
      KeyValuePair<string, object>[] args)
    {
      return (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng((object) ((SyntaxGenerator) SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr()).Attribute((string) SyntaxGeneratorExtensions.HEU4DPh1EC8KTbcKkDkA((object) attributeTypeName), ((IEnumerable<KeyValuePair<string, object>>) args).EmptyIfNull<KeyValuePair<string, object>>().Select<KeyValuePair<string, object>, SyntaxNode>((Func<KeyValuePair<string, object>, SyntaxNode>) (arg => (arg.Value as ISyntaxNode).Unpack() ?? SyntaxGeneratorExtensions.SyntaxGenerator.AttributeArgument(arg.Key, arg.Value.CreateSyntaxNode().Unpack())))));
    }

    /// <summary>Создать объявление атрибута</summary>
    public static ISyntaxNode CreateAttribute(this string attributeTypeName, params object[] args)
    {
      object obj = SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr();
      string attributeTypeName1 = SyntaxGeneratorExtensions.ProcessAttributeTypeName((object) attributeTypeName);
      IEnumerable<object> source = ((IEnumerable<object>) args).EmptyIfNull<object>();
      // ISSUE: reference to a compiler-generated field
      Func<object, SyntaxNode> func = SyntaxGeneratorExtensions.\u003C\u003Ec.\u003C\u003E9__50_0;
      Func<object, SyntaxNode> selector;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        SyntaxGeneratorExtensions.\u003C\u003Ec.\u003C\u003E9__50_0 = selector = (Func<object, SyntaxNode>) (arg =>
        {
          int num = 1;
          SyntaxNode attribute;
          while (true)
          {
            switch (num)
            {
              case 1:
                attribute = (arg as ISyntaxNode).Unpack();
                if (attribute == null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
                  continue;
                }
                goto label_2;
              default:
                goto label_5;
            }
          }
label_2:
          return attribute;
label_5:
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          return (SyntaxNode) SyntaxGeneratorExtensions.\u003C\u003Ec.l15MSRvus7OhllKVop3E(SyntaxGeneratorExtensions.\u003C\u003Ec.ukmithvuLH4rcRARBU6u(), (object) ((ISyntaxNode) SyntaxGeneratorExtensions.\u003C\u003Ec.AE2BsdvuUEPgKj3OlJsj(arg)).Unpack());
        });
      }
      else
        goto label_1;
label_3:
      IEnumerable<SyntaxNode> args1 = source.Select<object, SyntaxNode>(selector);
      return (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng((object) ((SyntaxGenerator) obj).Attribute(attributeTypeName1, args1));
label_1:
      selector = func;
      goto label_3;
    }

    public static ISyntaxNode AttributeArgument(this ISyntaxNode expression, string name = null)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!SyntaxGeneratorExtensions.oaHlRhh1fq2uhyyU0wQa((object) name))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng(SyntaxGeneratorExtensions.FrhrYuh1QgOcR9xMqtuL((object) SyntaxGeneratorExtensions.SyntaxGenerator, (object) name, SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) expression)));
label_3:
      return (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng((object) ((SyntaxGenerator) SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr()).AttributeArgument((SyntaxNode) SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) expression)));
    }

    public static ISyntaxNode AddAttributes(
      this ISyntaxNode syntaxNode,
      params ISyntaxNode[] attributes)
    {
      return syntaxNode.AddAttributes(((IEnumerable<ISyntaxNode>) attributes).AsEnumerable<ISyntaxNode>());
    }

    public static ISyntaxNode AddAttributes(
      this ISyntaxNode syntaxNode,
      IEnumerable<ISyntaxNode> attributes)
    {
      return syntaxNode.Pack(SyntaxGeneratorExtensions.SyntaxGenerator.AddAttributes(syntaxNode.Unpack(), attributes.Unpack().Where<SyntaxNode>((Func<SyntaxNode, bool>) (a => a != null))));
    }

    public static IEnumerable<ISyntaxNode> WithPragmaWarningDisableDirective(
      this IEnumerable<ISyntaxNode> syntaxNodes,
      params ISyntaxNode[] errorCodes)
    {
      return syntaxNodes.WithPragmaWarningDisableDirective(((IEnumerable<ISyntaxNode>) errorCodes).AsEnumerable<ISyntaxNode>());
    }

    public static IEnumerable<ISyntaxNode> WithPragmaWarningDisableDirective(
      this IEnumerable<ISyntaxNode> syntaxNodes,
      IEnumerable<ISyntaxNode> errorCodes)
    {
      List<SyntaxNode> list = syntaxNodes.Unpack().ToList<SyntaxNode>();
      if (list.Count == 0)
        return syntaxNodes;
      list[0].AddLeadingTrivia((IEnumerable<SyntaxTrivia>) new SyntaxTrivia[1]
      {
        SyntaxGeneratorExtensions.SyntaxGenerator.PragmaWarningDisableDirectiveTrivia(errorCodes.Unpack())
      });
      list[list.Count - 1].AddTrailingTrivia((IEnumerable<SyntaxTrivia>) new SyntaxTrivia[1]
      {
        SyntaxGeneratorExtensions.SyntaxGenerator.PragmaWarningRestoreDirectiveTrivia(errorCodes.Unpack())
      });
      return list.Pack();
    }

    public static ISyntaxNode WithPragmaWarningDisableDirective(
      this ISyntaxNode syntaxNode,
      params ISyntaxNode[] errorCodes)
    {
      return syntaxNode.WithPragmaWarningDisableDirective(((IEnumerable<ISyntaxNode>) errorCodes).AsEnumerable<ISyntaxNode>());
    }

    public static ISyntaxNode WithPragmaWarningDisableDirective(
      this ISyntaxNode syntaxNode,
      IEnumerable<ISyntaxNode> errorCodes)
    {
      return syntaxNode.Pack(syntaxNode.Unpack().AddLeadingTrivia((IEnumerable<SyntaxTrivia>) new SyntaxTrivia[1]
      {
        SyntaxGeneratorExtensions.SyntaxGenerator.PragmaWarningDisableDirectiveTrivia(errorCodes.Unpack())
      }).AddTrailingTrivia((IEnumerable<SyntaxTrivia>) new SyntaxTrivia[1]
      {
        SyntaxGeneratorExtensions.SyntaxGenerator.PragmaWarningRestoreDirectiveTrivia(errorCodes.Unpack())
      }));
    }

    public static ISyntaxNode XmlComments(
      this ISyntaxNode syntaxNode,
      params ISyntaxTrivia[] documentationComments)
    {
      return syntaxNode.XmlComments(((IEnumerable<ISyntaxTrivia>) documentationComments).AsEnumerable<ISyntaxTrivia>());
    }

    public static ISyntaxNode XmlComments(
      this ISyntaxNode syntaxNode,
      IEnumerable<ISyntaxTrivia> documentationComments)
    {
      return syntaxNode.Pack(syntaxNode.Unpack().AddLeadingTrivia(documentationComments.Unpack()));
    }

    /// <summary>Текстовый комментарий</summary>
    /// <param name="comments">Текст комментария</param>
    public static ISyntaxNode TextComments(
      this ISyntaxNode syntaxNode,
      IEnumerable<ISyntaxTrivia> comments)
    {
      return syntaxNode.Pack(syntaxNode.Unpack().AddLeadingTrivia(comments.Unpack()));
    }

    /// <summary>Текстовый комментарий после ноды</summary>
    /// <param name="syntaxNode">Нода</param>
    /// <param name="comments">Текст комментария</param>
    public static ISyntaxNode TextCommentsTrailing(
      this ISyntaxNode syntaxNode,
      IEnumerable<ISyntaxTrivia> comments)
    {
      return syntaxNode.Pack(syntaxNode.Unpack().AddTrailingTrivia(comments.Unpack()));
    }

    /// <summary>Текстовый комментарий</summary>
    /// <param name="comment">Текст комментария</param>
    public static ISyntaxTrivia TextComment(this string comment)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_8;
          case 2:
            if (SyntaxGeneratorExtensions.W4TZ6Mh1Cxm47V40n0pA((object) comment))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      object source = SyntaxGeneratorExtensions.RDZSHAhPlGC2fywTxxOY(SyntaxGeneratorExtensions.N9ty02h1vX3uc1vBV0ZT(SyntaxGeneratorExtensions.N9ty02h1vX3uc1vBV0ZT((object) comment, SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(-688192331 - 435440695 ^ -1123624128), SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(1461625753 ^ 1461632061)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576145060), SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(-649342099 - -1150814748 ^ 501465645)), (object) new char[1]
      {
        '\n'
      });
      // ISSUE: reference to a compiler-generated field
      Func<string, SyntaxTrivia> func = SyntaxGeneratorExtensions.\u003C\u003Ec.\u003C\u003E9__62_0;
      Func<string, SyntaxTrivia> selector;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        SyntaxGeneratorExtensions.\u003C\u003Ec.\u003C\u003E9__62_0 = selector = (Func<string, SyntaxTrivia>) (line => (SyntaxTrivia) SyntaxGeneratorExtensions.\u003C\u003Ec.SuYZOVvuzTFT5BEfjD4K((object) SyntaxGeneratorExtensions.SyntaxGenerator, SyntaxGeneratorExtensions.\u003C\u003Ec.vpPrAlvuc30FAhZky2BA((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 902137673), (object) line)));
      }
      else
        goto label_5;
label_7:
      return ((IEnumerable<string>) source).Select<string, SyntaxTrivia>(selector).Pack();
label_5:
      selector = func;
      goto label_7;
label_8:
      return (ISyntaxTrivia) null;
    }

    /// <summary>
    /// Документируемый комментарий, разбитый по строкам (\r\n)
    /// </summary>
    /// <param name="comment">Текст комментария</param>
    public static ISyntaxTrivia SplittedComment(this string comment, bool trim = false)
    {
      int num1 = 1;
      bool trim1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
              continue;
            case 2:
              if (SyntaxGeneratorExtensions.W4TZ6Mh1Cxm47V40n0pA((object) comment))
              {
                num2 = 5;
                continue;
              }
              goto label_8;
            case 3:
              goto label_8;
            case 4:
              goto label_4;
            case 5:
              goto label_12;
            default:
              trim1 = trim;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 2 : 2;
              continue;
          }
        }
label_8:
        if (!trim1)
          num1 = 4;
        else
          goto label_10;
      }
label_4:
      object obj1 = (object) comment;
      goto label_11;
label_10:
      obj1 = SyntaxGeneratorExtensions.KIg7XEh18jcl2qVbZl0G((object) comment);
label_11:
      object obj2 = SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(-1638402543 ^ -1638427345);
      object obj3 = SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(1819636893 << 3 ^ 1672198988);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return ((IEnumerable<string>) SyntaxGeneratorExtensions.RDZSHAhPlGC2fywTxxOY((object) ((string) SyntaxGeneratorExtensions.N9ty02h1vX3uc1vBV0ZT(obj1, obj2, obj3)).Replace((string) SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(1654249598 >> 2 ^ 413559015), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921197977)), (object) new char[1]
      {
        '\n'
      })).Select<string, SyntaxTrivia>((Func<string, SyntaxTrivia>) (line => ((SyntaxGenerator) SyntaxGeneratorExtensions.\u003C\u003Ec__DisplayClass63_0.qb8xw3vII0KuinaEtrdt()).Comment((string) SyntaxGeneratorExtensions.\u003C\u003Ec__DisplayClass63_0.OxYylpvIiKeKZv3wssrJ(SyntaxGeneratorExtensions.\u003C\u003Ec__DisplayClass63_0.fgPwJTvIVaVdAYbdd047(-2107978722 ^ -2108016172), trim1 ? SyntaxGeneratorExtensions.\u003C\u003Ec__DisplayClass63_0.xGnEAmvISCfZ229rCCae((object) line) : (object) line)))).Pack();
label_12:
      return (ISyntaxTrivia) null;
    }

    /// <summary>Документируемый комментарий</summary>
    /// <param name="tagName">Тэг</param>
    /// <param name="comment">Текст комментария</param>
    public static ISyntaxTrivia TagComment(this string comment, string tagName, bool trim = false)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!SyntaxGeneratorExtensions.W4TZ6Mh1Cxm47V40n0pA((object) comment))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return ((string) SyntaxGeneratorExtensions.QJemlnh1ZcQqQuA4RJo1((object) new string[7]
      {
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787471709),
        tagName,
        (string) SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(-688192331 - 435440695 ^ -1123690362),
        trim ? comment.Trim() : comment,
        (string) SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(--1418440330 ^ 1418252170),
        tagName,
        (string) SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(-16752921 ^ -16772825)
      })).SplittedComment(trim);
label_5:
      return (ISyntaxTrivia) null;
    }

    /// <summary>Документируемый комментарий : summary</summary>
    /// <param name="comment">Текст комментария</param>
    public static ISyntaxTrivia SummaryComment(this string comment, bool trim = false) => comment.TagComment(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822718190), trim);

    /// <summary>Документируемый комментарий : remarks</summary>
    /// <param name="comment">Текст комментария</param>
    public static ISyntaxTrivia RemarksComment(this string comment, bool trim = false) => comment.TagComment((string) SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(~541731958 ^ -541674859), trim);

    /// <summary>Документируемый комментарий : example</summary>
    /// <param name="comment">Текст комментария</param>
    public static ISyntaxTrivia ExampleComment(this string comment, bool trim = false) => comment.TagComment(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283607029), trim);

    /// <summary>Документируемый комментарий : param</summary>
    /// <param name="comment">Текст комментария</param>
    /// <param name="paramName">Имя параметра</param>
    /// <param name="trim">Убрать ли пробелы</param>
    public static ISyntaxTrivia ParamComment(this string comment, string paramName, bool trim = false)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (comment.IsNullOrWhiteSpace())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 0;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return ((string) SyntaxGeneratorExtensions.QJemlnh1ZcQqQuA4RJo1((object) new string[5]
      {
        (string) SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(--1360331293 ^ 1360421725),
        paramName,
        (string) SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(222162814 ^ 222203424),
        !trim ? comment : (string) SyntaxGeneratorExtensions.KIg7XEh18jcl2qVbZl0G((object) comment),
        (string) SyntaxGeneratorExtensions.sj4OMPhPtJmCI9JVRDnZ(589593376 ^ -1977315327 ^ -1459385785)
      })).SplittedComment(trim);
label_5:
      return (ISyntaxTrivia) null;
    }

    public static ISyntaxNode NamespaceDeclaration(
      this string name,
      params ISyntaxNode[] declarations)
    {
      return name.NamespaceDeclaration(((IEnumerable<ISyntaxNode>) declarations).AsEnumerable<ISyntaxNode>());
    }

    public static ISyntaxNode NamespaceDeclaration(
      this string name,
      IEnumerable<ISyntaxNode> declarations)
    {
      return SyntaxGeneratorExtensions.SyntaxGenerator.NamespaceDeclaration(name, declarations.Unpack()).Pack();
    }

    public static ISyntaxNode NamespaceImportDeclaration(this string name) => ((SyntaxNode) SyntaxGeneratorExtensions.KFwJDYh1uHfQ6dJL4vTp(SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr(), (object) name)).Pack();

    public static ISyntaxNode ClassDeclaration(
      this string name,
      Accessibility accessibility = Accessibility.NotApplicable,
      DeclarationModifiers modifiers = DeclarationModifiers.None,
      ISyntaxNode baseType = null,
      IEnumerable<ISyntaxNode> interfaceTypes = null,
      IEnumerable<ISyntaxNode> members = null)
    {
      return name.ClassDeclaration((IEnumerable<string>) null, accessibility, modifiers, baseType, interfaceTypes, members);
    }

    public static ISyntaxNode ClassDeclaration(
      this string name,
      IEnumerable<string> typeParameters,
      Accessibility accessibility = Accessibility.NotApplicable,
      DeclarationModifiers modifiers = DeclarationModifiers.None,
      ISyntaxNode baseType = null,
      IEnumerable<ISyntaxNode> interfaceTypes = null,
      IEnumerable<ISyntaxNode> members = null)
    {
      return SyntaxGeneratorExtensions.SyntaxGenerator.ClassDeclaration(name, typeParameters, accessibility.Unpack(), modifiers.Unpack(), baseType.Unpack(), interfaceTypes.Unpack(), members.Unpack().SortMembers()).Pack();
    }

    public static ISyntaxNode InterfaceDeclaration(
      this string name,
      Accessibility accessibility = Accessibility.NotApplicable,
      DeclarationModifiers modifiers = DeclarationModifiers.None,
      IEnumerable<ISyntaxNode> interfaceTypes = null,
      IEnumerable<ISyntaxNode> members = null)
    {
      return name.InterfaceDeclaration((IEnumerable<string>) null, accessibility, modifiers, interfaceTypes, members);
    }

    public static ISyntaxNode InterfaceDeclaration(
      this string name,
      IEnumerable<string> typeParameters,
      Accessibility accessibility = Accessibility.NotApplicable,
      DeclarationModifiers modifiers = DeclarationModifiers.None,
      IEnumerable<ISyntaxNode> interfaceTypes = null,
      IEnumerable<ISyntaxNode> members = null)
    {
      return SyntaxGeneratorExtensions.SyntaxGenerator.InterfaceDeclaration(name, typeParameters, accessibility.Unpack(), modifiers.Unpack(), interfaceTypes.Unpack(), members.Unpack().SortMembers()).Pack();
    }

    public static ISyntaxNode EnumDeclaration(
      this string name,
      Accessibility accessibility = Accessibility.NotApplicable,
      DeclarationModifiers modifiers = DeclarationModifiers.None,
      IEnumerable<ISyntaxNode> members = null)
    {
      return SyntaxGeneratorExtensions.SyntaxGenerator.EnumDeclaration(name, accessibility.Unpack(), modifiers.Unpack(), members.Unpack()).Pack();
    }

    public static ISyntaxNode EnumMember(this string name, ISyntaxNode expression = null) => (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng(SyntaxGeneratorExtensions.Uwu6S2h1IchQrtSpTWdJ(SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr(), (object) name, SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) expression)));

    public static ISyntaxNode ConstructorDeclaration(
      Accessibility accessibility = Accessibility.NotApplicable,
      DeclarationModifiers modifiers = DeclarationModifiers.None,
      IEnumerable<ISyntaxNode> baseConstructorArguments = null,
      IEnumerable<ISyntaxNode> statements = null)
    {
      return SyntaxGeneratorExtensions.ConstructorDeclaration((IEnumerable<ISyntaxNode>) null, accessibility, modifiers, baseConstructorArguments, statements);
    }

    public static ISyntaxNode ConstructorDeclaration(
      IEnumerable<ISyntaxNode> parameters,
      Accessibility accessibility = Accessibility.NotApplicable,
      DeclarationModifiers modifiers = DeclarationModifiers.None,
      IEnumerable<ISyntaxNode> baseConstructorArguments = null,
      IEnumerable<ISyntaxNode> statements = null)
    {
      return SyntaxGeneratorExtensions.SyntaxGenerator.ConstructorDeclaration(parameters.Unpack(), accessibility.Unpack(), modifiers.Unpack(), baseConstructorArguments.Unpack(), (IEnumerable<SyntaxNode>) statements.UnpackStatements()).Pack();
    }

    public static ISyntaxNode ThisConstructorDeclaration(
      Accessibility accessibility = Accessibility.NotApplicable,
      DeclarationModifiers modifiers = DeclarationModifiers.None,
      IEnumerable<ISyntaxNode> thisConstructorArguments = null,
      IEnumerable<ISyntaxNode> statements = null)
    {
      return SyntaxGeneratorExtensions.ThisConstructorDeclaration((IEnumerable<ISyntaxNode>) null, accessibility, modifiers, thisConstructorArguments, statements);
    }

    public static ISyntaxNode ThisConstructorDeclaration(
      IEnumerable<ISyntaxNode> parameters,
      Accessibility accessibility = Accessibility.NotApplicable,
      DeclarationModifiers modifiers = DeclarationModifiers.None,
      IEnumerable<ISyntaxNode> thisConstructorArguments = null,
      IEnumerable<ISyntaxNode> statements = null)
    {
      return SyntaxGeneratorExtensions.SyntaxGenerator.ThisConstructorDeclaration(parameters.Unpack(), accessibility.Unpack(), modifiers.Unpack(), thisConstructorArguments.Unpack(), (IEnumerable<SyntaxNode>) statements.UnpackStatements()).Pack();
    }

    /// <summary>Объявить свойство</summary>
    /// <param name="name">Имя свойства</param>
    /// <param name="type">Тип свойства</param>
    /// <param name="accessibility">Уровень доступа свойства</param>
    /// <param name="modifiers">Модификаторы</param>
    /// <param name="getterAccessibility">Уровень доступа функции получения значения свойства</param>
    /// <param name="setterAccessibility">Уровень доступа функции установки значения свойства</param>
    /// <returns>Сгенерированное свойство</returns>
    public static ISyntaxNode AutoPropertyDeclaration(
      this string name,
      ISyntaxNode type,
      Accessibility accessibility = Accessibility.NotApplicable,
      DeclarationModifiers modifiers = DeclarationModifiers.None,
      Accessibility getterAccessibility = Accessibility.NotApplicable,
      Accessibility setterAccessibility = Accessibility.NotApplicable)
    {
      return SyntaxGeneratorExtensions.SyntaxGenerator.AutoPropertyDeclaration(name, type.Unpack(), accessibility.Unpack(), modifiers.Unpack(), getterAccessibility.Unpack(), SyntaxGeneratorExtensions.H4n8x8h1VM8sUgNbQss2(setterAccessibility)).Pack();
    }

    /// <summary>Объявить свойство</summary>
    /// <param name="name">Имя свойства</param>
    /// <param name="type">Тип свойства</param>
    /// <param name="accessibility">Уровень доступа свойства</param>
    /// <param name="modifiers">Модификаторы</param>
    /// <param name="getAccessorStatements">Выражение получения значения свойства</param>
    /// <param name="setAccessorStatements">Выражение установки значения свойства</param>
    /// <param name="getterAccessibility">Уровень доступа функции получения значения свойства</param>
    /// <param name="setterAccessibility">Уровень доступа функции установки значения свойства</param>
    /// <returns>Сгенерированное свойство</returns>
    public static ISyntaxNode PropertyDeclaration(
      this string name,
      ISyntaxNode type,
      Accessibility accessibility = Accessibility.NotApplicable,
      DeclarationModifiers modifiers = DeclarationModifiers.None,
      IEnumerable<ISyntaxNode> getAccessorStatements = null,
      IEnumerable<ISyntaxNode> setAccessorStatements = null,
      Accessibility getterAccessibility = Accessibility.NotApplicable,
      Accessibility setterAccessibility = Accessibility.NotApplicable)
    {
      return SyntaxGeneratorExtensions.SyntaxGenerator.PropertyDeclaration(name, type.Unpack(), accessibility.Unpack(), modifiers.Unpack(), (IEnumerable<SyntaxNode>) getAccessorStatements.UnpackStatements(), (IEnumerable<SyntaxNode>) setAccessorStatements.UnpackStatements(), getterAccessibility.Unpack(), setterAccessibility.Unpack()).Pack();
    }

    public static ISyntaxNode ParameterDeclaration<T>(
      this string name,
      ISyntaxNode initializer = null,
      RefKind refKind = RefKind.None)
    {
      return name.ParameterDeclaration(SyntaxGeneratorExtensions.CreateTypeSyntax<T>(), initializer, refKind);
    }

    public static ISyntaxNode ParameterDeclaration(
      this string name,
      Type type,
      ISyntaxNode initializer = null,
      RefKind refKind = RefKind.None)
    {
      return name.ParameterDeclaration(type.CreateTypeSyntax(), initializer, refKind);
    }

    public static ISyntaxNode ParameterDeclaration(
      this string name,
      ISyntaxNode type,
      ISyntaxNode initializer = null,
      RefKind refKind = RefKind.None)
    {
      return ((SyntaxGenerator) SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr()).ParameterDeclaration(name, (SyntaxNode) SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) type), (SyntaxNode) SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) initializer), SyntaxGeneratorExtensions.chxvn3h1SwjotCOeuWxi(refKind)).Pack();
    }

    public static ISyntaxNode WithParamsModifier(this ISyntaxNode parameter)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            SyntaxGeneratorExtensions.MFR5tjh1ivOCs4Pta5j7((object) parameter.Unpack<ParameterDeclarationSyntax>(), true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return parameter;
    }

    public static ISyntaxNode MethodDeclaration(
      this string name,
      IEnumerable<ISyntaxNode> parameters = null,
      IEnumerable<string> typeParameters = null,
      ISyntaxNode returnType = null,
      Accessibility accessibility = Accessibility.NotApplicable,
      DeclarationModifiers modifiers = DeclarationModifiers.None,
      IEnumerable<ISyntaxNode> statements = null)
    {
      return SyntaxGeneratorExtensions.SyntaxGenerator.MethodDeclaration(name, parameters.Unpack(), typeParameters, returnType.Unpack(), accessibility.Unpack(), modifiers.Unpack(), (IEnumerable<SyntaxNode>) statements.UnpackStatements()).Pack();
    }

    public static ISyntaxNode FieldDeclaration(
      this string name,
      ISyntaxNode type,
      Accessibility accessibility = Accessibility.NotApplicable,
      DeclarationModifiers modifiers = DeclarationModifiers.None,
      ISyntaxNode initializer = null)
    {
      return (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng(SyntaxGeneratorExtensions.lrtdpAh1quU5RANp48Q7(SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr(), (object) name, SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) type), SyntaxGeneratorExtensions.H4n8x8h1VM8sUgNbQss2(accessibility), SyntaxGeneratorExtensions.LtSnPsh1R7fddd3TZN33(modifiers), SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) initializer)));
    }

    public static ISyntaxNode AsPrivateInterfaceImplementation(
      this ISyntaxNode declaration,
      ISyntaxNode interfaceType)
    {
      return (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng(SyntaxGeneratorExtensions.Eu8guIh1KPwwAb3mA0Px(SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr(), SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) declaration), SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) interfaceType)));
    }

    public static ISyntaxNode ReturnStatement() => (ISyntaxNode) SyntaxGeneratorExtensions.k7scLPh1XE5SfTXFfHEs((object) null);

    public static ISyntaxNode ReturnStatement(this ISyntaxNode expression) => (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng((object) SyntaxGeneratorExtensions.SyntaxGenerator.ReturnStatement((SyntaxNode) SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) expression)));

    public static ISyntaxNode AssignmentStatement(this ISyntaxNode left, ISyntaxNode right) => ((SyntaxNode) SyntaxGeneratorExtensions.StY2OGh1TEaMHZNRrgeN(SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr(), SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) left), SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) right))).Pack();

    public static ISyntaxNode LocalDeclarationStatement(
      this string identifier,
      ISyntaxNode initializer)
    {
      return (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng(SyntaxGeneratorExtensions.f3GZMSh1k41J6kTv41cO(SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr(), (object) identifier, (object) initializer.Unpack()));
    }

    public static ISyntaxNode LocalDeclarationStatement(
      this string identifier,
      ISyntaxNode type,
      ISyntaxNode initializer = null,
      bool isConst = false)
    {
      return (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng(SyntaxGeneratorExtensions.Ox3CHxh1neaePhanDXvn((object) SyntaxGeneratorExtensions.SyntaxGenerator, SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) type), (object) identifier, SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) initializer), isConst));
    }

    public static ISyntaxNode IfStatement(
      this ISyntaxNode condition,
      IEnumerable<ISyntaxNode> trueStatements,
      IEnumerable<ISyntaxNode> falseStatements = null)
    {
      return SyntaxGeneratorExtensions.SyntaxGenerator.IfStatement(condition.Unpack(), (IEnumerable<SyntaxNode>) trueStatements.UnpackStatements(), (IEnumerable<SyntaxNode>) falseStatements.UnpackStatements()).Pack();
    }

    public static ISyntaxNode SwitchStatement(
      this string identifier,
      params ISyntaxNode[] caseStatements)
    {
      return identifier.SwitchStatement(((IEnumerable<ISyntaxNode>) caseStatements).AsEnumerable<ISyntaxNode>());
    }

    public static ISyntaxNode SwitchStatement(
      this string identifier,
      IEnumerable<ISyntaxNode> caseStatements)
    {
      return identifier.IdentifierName().SwitchStatement(caseStatements);
    }

    public static ISyntaxNode SwitchStatement(
      this ISyntaxNode identifier,
      params ISyntaxNode[] caseStatements)
    {
      return identifier.SwitchStatement(((IEnumerable<ISyntaxNode>) caseStatements).AsEnumerable<ISyntaxNode>());
    }

    public static ISyntaxNode SwitchStatement(
      this ISyntaxNode identifier,
      IEnumerable<ISyntaxNode> caseStatements)
    {
      return SyntaxGeneratorExtensions.SyntaxGenerator.SwitchStatement(identifier.Unpack(), (IEnumerable<SyntaxNode>) caseStatements.UnpackStatements()).Pack();
    }

    public static ISyntaxNode CaseStatement(this ISyntaxNode value, params ISyntaxNode[] statements) => value.CaseStatement(((IEnumerable<ISyntaxNode>) statements).AsEnumerable<ISyntaxNode>());

    public static ISyntaxNode CaseDefaultStatement(params ISyntaxNode[] statements) => SyntaxGeneratorExtensions.CaseDefaultStatement(((IEnumerable<ISyntaxNode>) statements).AsEnumerable<ISyntaxNode>());

    public static ISyntaxNode CaseStatement(
      this ISyntaxNode value,
      IEnumerable<ISyntaxNode> statements)
    {
      return SyntaxGeneratorExtensions.SyntaxGenerator.CaseStatement(value.Unpack(), (IEnumerable<SyntaxNode>) statements.UnpackStatements()).Pack();
    }

    public static ISyntaxNode CaseDefaultStatement(IEnumerable<ISyntaxNode> statements) => SyntaxGeneratorExtensions.SyntaxGenerator.CaseStatement((SyntaxNode) null, (IEnumerable<SyntaxNode>) statements.UnpackStatements()).Pack();

    public static ISyntaxNode BreakStatement() => (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng(SyntaxGeneratorExtensions.uiX4Mbh1Ox35duPM47So((object) SyntaxGeneratorExtensions.SyntaxGenerator));

    public static ISyntaxNode ThrowStatement(ISyntaxNode expression = null) => (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng(SyntaxGeneratorExtensions.Q7iIhuh12UTad951cNlV(SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr(), SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) expression)));

    /// <summary>
    /// Генерация <c>NotImplementedException</c>
    /// </summary>
    /// <returns>Выражение</returns>
    public static ISyntaxNode ThrowNotImplementedStatement() => SyntaxGeneratorExtensions.ThrowStatement(((ISyntaxNode) SyntaxGeneratorExtensions.eACjIfhPmu37oVjVtfMl(TypeOf<NotImplementedException>.Raw)).ObjectCreationExpression());

    public static ISyntaxNode ParseExpression(this string text) => (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng(SyntaxGeneratorExtensions.OEF9mVh1efZDOPGJmXvc(SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr(), (object) text));

    public static ISyntaxNode CreateGuidExpression(this Guid value) => ((ISyntaxNode) SyntaxGeneratorExtensions.eACjIfhPmu37oVjVtfMl(TypeOf<Guid>.Raw)).ObjectCreationExpression((ISyntaxNode) SyntaxGeneratorExtensions.Atq2FXh1PGBgk0vBU2Ls((object) value.ToString()));

    public static ISyntaxNode CreateGuidExpression(this Guid? value) => !value.HasValue ? SyntaxGeneratorExtensions.Null : value.Value.CreateGuidExpression();

    public static ISyntaxNode CreateGuidQuickExpression(this Guid value)
    {
      int num1 = 4;
      byte num2;
      int num3;
      byte num4;
      short num5;
      short num6;
      byte num7;
      byte num8;
      byte num9;
      byte num10;
      byte num11;
      byte num12;
      while (true)
      {
        int num13 = num1;
        byte[] byteArray;
        while (true)
        {
          switch (num13)
          {
            case 1:
              num5 = (short) ((int) byteArray[5] << 8 | (int) byteArray[4]);
              num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 3 : 6;
              continue;
            case 2:
              num12 = byteArray[14];
              num13 = 7;
              continue;
            case 3:
              num3 = (int) byteArray[3] << 24 | (int) byteArray[2] << 16 | (int) byteArray[1] << 8 | (int) byteArray[0];
              num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 1;
              continue;
            case 4:
              byteArray = value.ToByteArray();
              num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 3;
              continue;
            case 5:
              num9 = byteArray[11];
              num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 11 : 11;
              continue;
            case 6:
              num6 = (short) ((int) byteArray[7] << 8 | (int) byteArray[6]);
              num13 = 8;
              continue;
            case 7:
              goto label_5;
            case 8:
              num7 = byteArray[8];
              num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
              continue;
            case 9:
              num11 = byteArray[13];
              num13 = 2;
              continue;
            case 10:
              goto label_6;
            case 11:
              num10 = byteArray[12];
              num13 = 9;
              continue;
            case 12:
              num8 = byteArray[10];
              num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 5;
              continue;
            default:
              num2 = byteArray[9];
              num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 12 : 8;
              continue;
          }
        }
label_5:
        num4 = byteArray[15];
        num1 = 10;
      }
label_6:
      return ((ISyntaxNode) SyntaxGeneratorExtensions.eACjIfhPmu37oVjVtfMl(TypeOf<Guid>.Raw)).ObjectCreationExpression(num3.CreateSyntaxNode(), (ISyntaxNode) SyntaxGeneratorExtensions.Atq2FXh1PGBgk0vBU2Ls((object) num5), (ISyntaxNode) SyntaxGeneratorExtensions.Atq2FXh1PGBgk0vBU2Ls((object) num6), (ISyntaxNode) SyntaxGeneratorExtensions.Atq2FXh1PGBgk0vBU2Ls((object) num7), (ISyntaxNode) SyntaxGeneratorExtensions.Atq2FXh1PGBgk0vBU2Ls((object) num2), (ISyntaxNode) SyntaxGeneratorExtensions.Atq2FXh1PGBgk0vBU2Ls((object) num8), (ISyntaxNode) SyntaxGeneratorExtensions.Atq2FXh1PGBgk0vBU2Ls((object) num9), (ISyntaxNode) SyntaxGeneratorExtensions.Atq2FXh1PGBgk0vBU2Ls((object) num10), (ISyntaxNode) SyntaxGeneratorExtensions.Atq2FXh1PGBgk0vBU2Ls((object) num11), (ISyntaxNode) SyntaxGeneratorExtensions.Atq2FXh1PGBgk0vBU2Ls((object) num12), (ISyntaxNode) SyntaxGeneratorExtensions.Atq2FXh1PGBgk0vBU2Ls((object) num4));
    }

    public static ISyntaxNode CreateGuidQuickExpression(this Guid? value) => !value.HasValue ? SyntaxGeneratorExtensions.Null : value.Value.CreateGuidQuickExpression();

    public static ISyntaxNode TypeOfExpression(this Type type) => (ISyntaxNode) SyntaxGeneratorExtensions.GSmtpXh11YUpfAe7aw5C(SyntaxGeneratorExtensions.eACjIfhPmu37oVjVtfMl(type));

    public static ISyntaxNode TypeOfExpression(this string typeName) => (ISyntaxNode) SyntaxGeneratorExtensions.GSmtpXh11YUpfAe7aw5C(SyntaxGeneratorExtensions.QJElImhPMyCQONFOQx7J((object) typeName));

    public static ISyntaxNode TypeOfExpression(this ISyntaxNode type) => (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng(SyntaxGeneratorExtensions.tLqORZh1NqxYWhyAgKqF((object) SyntaxGeneratorExtensions.SyntaxGenerator, SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) type)));

    public static ISyntaxNode DefaultExpression(this Type type) => (ISyntaxNode) SyntaxGeneratorExtensions.wo1Rt8h13FLrDsBk5CoD(SyntaxGeneratorExtensions.eACjIfhPmu37oVjVtfMl(type));

    public static ISyntaxNode DefaultExpression(this string typeName) => (ISyntaxNode) SyntaxGeneratorExtensions.wo1Rt8h13FLrDsBk5CoD((object) typeName.CreateTypeSyntax());

    public static ISyntaxNode DefaultExpression(this ISyntaxNode type) => (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng(SyntaxGeneratorExtensions.njxBNLh1pTkBycknTOqT(SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr(), SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) type)));

    public static ISyntaxNode CastExpression(this ISyntaxNode expression, ISyntaxNode type) => (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng(SyntaxGeneratorExtensions.fmaW0hh1aZhnENYs8kI6(SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr(), SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) type), SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) expression)));

    public static ISyntaxNode TryCastExpression(this ISyntaxNode expression, ISyntaxNode type) => (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng(SyntaxGeneratorExtensions.KjEx0Bh1DP4CeXFILgFs(SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr(), SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) expression), (object) type.Unpack()));

    public static ISyntaxNode InvocationExpression(
      this string methodName,
      params ISyntaxNode[] arguments)
    {
      return ((ISyntaxNode) SyntaxGeneratorExtensions.s092OqhPwXvD2xKWydyw((object) methodName)).InvocationExpression(arguments);
    }

    public static ISyntaxNode InvocationExpression(
      this string methodName,
      IEnumerable<ISyntaxNode> arguments)
    {
      return methodName.IdentifierName().InvocationExpression(arguments);
    }

    public static ISyntaxNode InvocationExpression(
      this ISyntaxNode expression,
      params ISyntaxNode[] arguments)
    {
      return expression.InvocationExpression(((IEnumerable<ISyntaxNode>) arguments).AsEnumerable<ISyntaxNode>());
    }

    public static ISyntaxNode InvocationExpression(
      this ISyntaxNode expression,
      IEnumerable<ISyntaxNode> arguments)
    {
      return SyntaxGeneratorExtensions.SyntaxGenerator.InvocationExpression(expression.Unpack(), arguments.Unpack()).Pack();
    }

    public static ISyntaxNode RefKindArgument(this ISyntaxNode expression, RefKind refKind) => (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng(SyntaxGeneratorExtensions.MFwUgsh1tdIHYoCwJkDn(SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr(), SyntaxGeneratorExtensions.chxvn3h1SwjotCOeuWxi(refKind), SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) expression)));

    /// <summary>Выражение создания объекта</summary>
    /// <remarks>
    /// Пример генерации:
    /// new TestClass(argument1, argument2)
    /// </remarks>
    /// <param name="type">Тип</param>
    /// <param name="arguments">Аргументы</param>
    /// <returns>Сгенерированное выражение создания объекта</returns>
    public static ISyntaxNode ObjectCreationExpression(
      this ISyntaxNode type,
      params ISyntaxNode[] arguments)
    {
      return type.ObjectCreationExpression(((IEnumerable<ISyntaxNode>) arguments).AsEnumerable<ISyntaxNode>());
    }

    /// <summary>Выражение создания объекта</summary>
    /// <remarks>
    /// Пример генерации:
    /// new TestClass(argument1, argument2)
    /// </remarks>
    /// <param name="type">Тип</param>
    /// <param name="arguments">Аргументы</param>
    /// <returns>Сгенерированное выражение создания объекта</returns>
    public static ISyntaxNode ObjectCreationExpression(
      this ISyntaxNode type,
      IEnumerable<ISyntaxNode> arguments)
    {
      return type.ObjectInitializationExpression(arguments, Enumerable.Empty<ISyntaxNode>());
    }

    /// <summary>Выражение "Инициализатор объекта"</summary>
    /// <remarks>
    /// Пример генерации:
    /// new TestClass
    /// {
    ///     Property1 = ...,
    ///     Property2 = ...
    /// }
    /// </remarks>
    /// <param name="type">Тип</param>
    /// <param name="properties">Свойства</param>
    /// <returns>Сгенерированное выражение "Инициализатор объекта"</returns>
    public static ISyntaxNode ObjectInitializationExpression(
      this ISyntaxNode type,
      params ISyntaxNode[] properties)
    {
      return type.ObjectInitializationExpression(((IEnumerable<ISyntaxNode>) properties).AsEnumerable<ISyntaxNode>());
    }

    /// <summary>Выражение "Инициализатор объекта"</summary>
    /// <remarks>
    /// Пример генерации:
    /// new TestClass
    /// {
    ///     Property1 = ...,
    ///     Property2 = ...
    /// }
    /// </remarks>
    /// <param name="type">Тип</param>
    /// <param name="properties">Свойства</param>
    /// <returns>Сгенерированное выражение "Инициализатор объекта"</returns>
    public static ISyntaxNode ObjectInitializationExpression(
      this ISyntaxNode type,
      IEnumerable<ISyntaxNode> properties)
    {
      return type.ObjectInitializationExpression(Enumerable.Empty<ISyntaxNode>(), properties);
    }

    /// <summary>Выражение "Инициализатор объекта"</summary>
    /// <remarks>
    /// Пример генерации:
    /// new TestClass(argument1, argument2)
    /// {
    ///     Property1 = ...,
    ///     Property2 = ...
    /// }
    /// </remarks>
    /// <param name="type">Тип</param>
    /// <param name="arguments">Аргументы</param>
    /// <param name="properties">Свойства</param>
    /// <returns>Сгенерированное выражение "Инициализатор объекта"</returns>
    public static ISyntaxNode ObjectInitializationExpression(
      this ISyntaxNode type,
      IEnumerable<ISyntaxNode> arguments,
      IEnumerable<ISyntaxNode> properties)
    {
      return SyntaxGeneratorExtensions.SyntaxGenerator.ObjectCreationExpression(type.Unpack(), arguments.Unpack(), properties.Unpack()).Pack();
    }

    public static ISyntaxNode MemberAccessExpression(
      this ISyntaxNode expression,
      ISyntaxNode memberName)
    {
      return ((SyntaxGenerator) SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr()).MemberAccessExpression((SyntaxNode) SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) expression), memberName.Unpack()).Pack();
    }

    public static ISyntaxNode MemberAccessExpression(this ISyntaxNode expression, string memberName) => ((SyntaxNode) SyntaxGeneratorExtensions.ILRf3Ph1wa59txoOQqc4(SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr(), (object) expression.Unpack(), (object) memberName)).Pack();

    /// <summary>
    /// Создать выражение обращения к элементу через квадратные скобки
    /// </summary>
    /// <param name="expression">Выражение</param>
    /// <param name="arguments">Аргументы</param>
    /// <returns>Выражение обращения к элементу через квадратные скобки</returns>
    public static ISyntaxNode ElementAccessExpression(
      this ISyntaxNode expression,
      params ISyntaxNode[] arguments)
    {
      return expression.ElementAccessExpression(((IEnumerable<ISyntaxNode>) arguments).AsEnumerable<ISyntaxNode>());
    }

    /// <summary>
    /// Создать выражение обращения к элементу через квадратные скобки
    /// </summary>
    /// <param name="expression">Выражение</param>
    /// <param name="arguments">Аргументы</param>
    /// <returns>Выражение обращения к элементу через квадратные скобки</returns>
    public static ISyntaxNode ElementAccessExpression(
      this ISyntaxNode expression,
      IEnumerable<ISyntaxNode> arguments)
    {
      return SyntaxGeneratorExtensions.SyntaxGenerator.ElementAccessExpression(expression.Unpack(), arguments.Unpack()).Pack();
    }

    public static ISyntaxNode ConditionalAccessExpression(
      this ISyntaxNode expression,
      ISyntaxNode memberName)
    {
      return (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng((object) ((SyntaxGenerator) SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr()).ConditionalAccessExpression((SyntaxNode) SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) expression), (SyntaxNode) SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) memberName)));
    }

    public static ISyntaxNode ConditionalAccessExpression(
      this ISyntaxNode expression,
      string memberName)
    {
      return ((SyntaxGenerator) SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr()).ConditionalAccessExpression((SyntaxNode) SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) expression), memberName).Pack();
    }

    public static ISyntaxNode ConditionalExpression(
      this ISyntaxNode condition,
      ISyntaxNode trueExpression,
      ISyntaxNode falseExpression)
    {
      return (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng((object) SyntaxGeneratorExtensions.SyntaxGenerator.ConditionalExpression((SyntaxNode) SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) condition), (SyntaxNode) SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) trueExpression), (SyntaxNode) SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) falseExpression)));
    }

    public static ISyntaxNode CoalesceExpression(this ISyntaxNode left, ISyntaxNode right) => ((SyntaxNode) SyntaxGeneratorExtensions.c7uhc8h14uLoBCgv9vRC(SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr(), (object) left.Unpack(), SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) right))).Pack();

    public static ISyntaxNode ValueReturningLambdaExpression(IEnumerable<ISyntaxNode> statements) => SyntaxGeneratorExtensions.SyntaxGenerator.ValueReturningLambdaExpression((IEnumerable<SyntaxNode>) statements.UnpackStatements()).Pack();

    public static ISyntaxNode ValueReturningLambdaExpression(ISyntaxNode expression) => (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng(SyntaxGeneratorExtensions.hPZX0qh16Z8GJsDoDBPy(SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr(), SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) expression)));

    public static ISyntaxNode ValueReturningLambdaExpression(
      this string parameterName,
      IEnumerable<ISyntaxNode> statements)
    {
      return SyntaxGeneratorExtensions.SyntaxGenerator.ValueReturningLambdaExpression(parameterName, (IEnumerable<SyntaxNode>) statements.UnpackStatements()).Pack();
    }

    public static ISyntaxNode ValueReturningLambdaExpression(
      this string parameterName,
      ISyntaxNode expression)
    {
      return (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng((object) ((SyntaxGenerator) SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr()).ValueReturningLambdaExpression(parameterName, (SyntaxNode) SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) expression)));
    }

    public static ISyntaxNode ValueReturningLambdaExpression(
      IEnumerable<ISyntaxNode> lambdaParameters,
      IEnumerable<ISyntaxNode> statements)
    {
      return SyntaxGeneratorExtensions.SyntaxGenerator.ValueReturningLambdaExpression(lambdaParameters.Unpack(), (IEnumerable<SyntaxNode>) statements.UnpackStatements()).Pack();
    }

    public static ISyntaxNode ValueReturningLambdaExpression(
      IEnumerable<ISyntaxNode> lambdaParameters,
      ISyntaxNode expression)
    {
      return SyntaxGeneratorExtensions.SyntaxGenerator.ValueReturningLambdaExpression(lambdaParameters.Unpack(), expression.Unpack()).Pack();
    }

    public static ISyntaxNode ValueEqualsExpression(this ISyntaxNode left, ISyntaxNode right) => (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng(SyntaxGeneratorExtensions.kpgdy2h1HVKcmBTT4bE4((object) SyntaxGeneratorExtensions.SyntaxGenerator, (object) left.Unpack(), SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) right)));

    public static ISyntaxNode ValueNotEqualsExpression(this ISyntaxNode left, ISyntaxNode right) => (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng(SyntaxGeneratorExtensions.MYTTk6h1AsJXSdju0vr6(SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr(), SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) left), SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) right)));

    public static ISyntaxNode LogicalOrExpression(this ISyntaxNode left, ISyntaxNode right) => (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng(SyntaxGeneratorExtensions.qUWi7Ih17AWOkwmLSaj6(SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr(), SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) left), SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) right)));

    public static ISyntaxNode LogicalAndExpression(this ISyntaxNode left, ISyntaxNode right) => (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng((object) ((SyntaxGenerator) SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr()).LogicalAndExpression((SyntaxNode) SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) left), (SyntaxNode) SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) right)));

    public static ISyntaxNode AwaitExpression(this ISyntaxNode expression) => (ISyntaxNode) SyntaxGeneratorExtensions.Swh3l3hPaSDK1GImfyng(SyntaxGeneratorExtensions.lS5B20h1xYfQ81jNukNJ(SyntaxGeneratorExtensions.NV5IknhPPLNPeCUK2LWr(), SyntaxGeneratorExtensions.XLVF7HhPNnxmdVm1UmsP((object) expression)));

    public static ISyntaxNode WithTypeConstraint(
      this ISyntaxNode declaration,
      string typeParameterName,
      params ISyntaxNode[] types)
    {
      return declaration.WithTypeConstraint(typeParameterName, SpecialTypeConstraintKind.None, types);
    }

    public static ISyntaxNode WithTypeConstraint(
      this ISyntaxNode declaration,
      string typeParameterName,
      IEnumerable<ISyntaxNode> types)
    {
      return declaration.WithTypeConstraint(typeParameterName, SpecialTypeConstraintKind.None, types);
    }

    public static ISyntaxNode WithTypeConstraint(
      this ISyntaxNode declaration,
      string typeParameterName,
      SpecialTypeConstraintKind kinds,
      params ISyntaxNode[] types)
    {
      return declaration.WithTypeConstraint(typeParameterName, kinds, ((IEnumerable<ISyntaxNode>) types).AsEnumerable<ISyntaxNode>());
    }

    public static ISyntaxNode WithTypeConstraint(
      this ISyntaxNode declaration,
      string typeParameterName,
      SpecialTypeConstraintKind kinds,
      IEnumerable<ISyntaxNode> types = null)
    {
      return declaration.Pack(SyntaxGeneratorExtensions.SyntaxGenerator.WithTypeConstraint(declaration.Unpack(), typeParameterName, kinds.Unpack(), (IEnumerable<SyntaxNode>) types.Unpack().ToArray<SyntaxNode>()));
    }

    private static IEnumerable<SyntaxNode> SortMembers(this IEnumerable<SyntaxNode> nodes) => nodes == null ? (IEnumerable<SyntaxNode>) null : (IEnumerable<SyntaxNode>) nodes.OrderBy<SyntaxNode, Type>((Func<SyntaxNode, Type>) (n => n.GetType()), (IComparer<Type>) new SyntaxGeneratorExtensions.MembersComparer());

    internal static bool NVFcSchP2oTiYU7pfE7i() => SyntaxGeneratorExtensions.s2T1WVhPONeogEjGaJy6 == null;

    internal static SyntaxGeneratorExtensions gNOhI9hPe893TJKQnXFD() => SyntaxGeneratorExtensions.s2T1WVhPONeogEjGaJy6;

    internal static object NV5IknhPPLNPeCUK2LWr() => (object) SyntaxGeneratorExtensions.SyntaxGenerator;

    internal static object CYY0W1hP1FVsdjn6tLgq([In] object obj0, [In] object obj1) => (object) ((SyntaxGenerator) obj0).IdentifierName((string) obj1);

    internal static object XLVF7HhPNnxmdVm1UmsP([In] object obj0) => (object) ((ISyntaxNode) obj0).Unpack();

    internal static object jBQrwshP3PTx97TcRmB9([In] object obj0) => (object) ((GenericNameSyntax) obj0).Identifier;

    internal static object mCAYDHhPpuAWwaSQQTa7([In] object obj0) => (object) ((SyntaxGenerator) obj0).NullLiteralExpression();

    internal static object Swh3l3hPaSDK1GImfyng([In] object obj0) => (object) ((SyntaxNode) obj0).Pack();

    internal static object AXO8nshPDqbtI6gr61R6([In] object obj0) => (object) ((SyntaxGenerator) obj0).BaseExpression();

    internal static object sj4OMPhPtJmCI9JVRDnZ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object s092OqhPwXvD2xKWydyw([In] object obj0) => (object) ((string) obj0).IdentifierName();

    internal static int hDOW0nhP4TCw3bP9J7YK([In] object obj0, [In] char obj1) => ((string) obj0).LastIndexOf(obj1);

    internal static object QQkRvQhP6fpfFLLA4639([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static object U4M9MshPHK96RJ1Wl1Et([In] object obj0, [In] int obj1) => (object) ((string) obj0).Substring(obj1);

    internal static bool NeXC9HhPAilYihGIP9eo([In] object obj0, [In] object obj1) => ((string) obj0).Contains((string) obj1);

    internal static bool jSEfFqhP7etjIiiZnT5w([In] object obj0, [In] object obj1) => ((string) obj0).StartsWith((string) obj1);

    internal static object gTDhJXhPxOUxnRrST4OZ(Type type, bool useGlobal) => (object) type.CreateTypeSyntax(useGlobal);

    internal static void xxOQsvhP0Bh14afDXB8A([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object eACjIfhPmu37oVjVtfMl(Type type) => (object) type.CreateTypeSyntax();

    internal static object OZGLpRhPy1QT8LFbGgLH([In] object obj0) => (object) ((ISyntaxNode) obj0).CreateArrayTypeSyntax();

    internal static object QJElImhPMyCQONFOQx7J([In] object obj0) => (object) ((string) obj0).CreateTypeSyntax();

    internal static object CFjP60hPJCjwBVf1HtXL([In] object obj0, bool useGlobal) => (object) ((string) obj0).CreateTypeSyntax(useGlobal);

    internal static int CXte2nhP94T0O9IAFUZa([In] object obj0, [In] char obj1) => ((string) obj0).IndexOf(obj1);

    internal static object qOWVsVhPdsdqmh36Fp84([In] object obj0, [In] int obj1) => (object) ((string) obj0).Remove(obj1);

    internal static object RDZSHAhPlGC2fywTxxOY([In] object obj0, [In] object obj1) => (object) ((string) obj0).Split((char[]) obj1);

    internal static void tJKtTohPrMRj7qlOdqA7([In] object obj0, [In] int obj1) => ((List<string>) obj0).RemoveAt(obj1);

    internal static int LC4DTkhPgmvVqjOgUK1t([In] object obj0) => ((List<string>) obj0).Count;

    internal static uint j59ZWVhP500j9jGbbWLk([In] object obj0) => \u003CPrivateImplementationDetails\u003E.ComputeStringHash((string) obj0);

    internal static bool CaqHKyhPjP0LWp9itjL8([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object hGbBWShPYQaNbCPcYU4G([In] object obj0, [In] object obj1) => (object) ((SyntaxGenerator) obj0).ParseTypeName((string) obj1);

    internal static object c319iHhPL4ZZStZPvpr5([In] object obj0, [In] char obj1, [In] char obj2) => (object) ((string) obj0).Replace(obj1, obj2);

    internal static object x2asjGhPUWY22WgFtQj3([In] object obj0, [In] object obj1) => (object) ((SyntaxGenerator) obj0).ArrayTypeExpression((SyntaxNode) obj1);

    internal static object U2pecShPsvPhUw57ZSZJ() => (object) SyntaxGeneratorExtensions.Null;

    internal static object zqYI3ahPcbWBDcwsX5xf([In] object obj0, [In] object obj1) => (object) ((SyntaxGenerator) obj0).LiteralExpression(obj1);

    internal static bool cEiGxghPzLTS2XXjSdqZ([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object etLcvJh1FTW6leG492aG([In] object obj0) => (object) ((string) obj0).CreateStringSyntaxNode();

    internal static object cBE0GOh1BpyHGs9U5mjD([In] object obj0) => (object) ((string) obj0).CreateAtStringSyntaxNode();

    internal static object HSUQm9h1W6jVfOUyehm8([In] object obj0) => (object) ((string) obj0).ToCharArray();

    internal static object k9ojMEh1ooTnYcL0Itqp([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2) => (object) ((string) obj0).Split((char[]) obj1, obj2);

    internal static bool BdeYNch1bxCbjmjbXguB([In] object obj0, [In] object obj1) => ((string) obj0).EndsWith((string) obj1);

    internal static int ggn0Pmh1haHll4kHgHxO([In] object obj0) => ((string) obj0).Length;

    internal static object weM2pwh1Gm55yMQjbaV5([In] object obj0, [In] object obj1) => (object) ((string) obj0).CreateAttribute((KeyValuePair<string, object>[]) obj1);

    internal static object HEU4DPh1EC8KTbcKkDkA([In] object obj0) => (object) SyntaxGeneratorExtensions.ProcessAttributeTypeName(obj0);

    internal static bool oaHlRhh1fq2uhyyU0wQa([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object FrhrYuh1QgOcR9xMqtuL([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((SyntaxGenerator) obj0).AttributeArgument((string) obj1, (SyntaxNode) obj2);

    internal static bool W4TZ6Mh1Cxm47V40n0pA([In] object obj0) => ((string) obj0).IsNullOrWhiteSpace();

    internal static object N9ty02h1vX3uc1vBV0ZT([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static object KIg7XEh18jcl2qVbZl0G([In] object obj0) => (object) ((string) obj0).Trim();

    internal static object QJemlnh1ZcQqQuA4RJo1([In] object obj0) => (object) string.Concat((string[]) obj0);

    internal static object KFwJDYh1uHfQ6dJL4vTp([In] object obj0, [In] object obj1) => (object) ((SyntaxGenerator) obj0).NamespaceImportDeclaration((string) obj1);

    internal static object Uwu6S2h1IchQrtSpTWdJ([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((SyntaxGenerator) obj0).EnumMember((string) obj1, (SyntaxNode) obj2);

    internal static EleWise.ELMA.CodeGeneration.CSharp.Enums.Accessibility H4n8x8h1VM8sUgNbQss2(
      Accessibility accessibility)
    {
      return accessibility.Unpack();
    }

    internal static EleWise.ELMA.CodeGeneration.CSharp.Enums.RefKind chxvn3h1SwjotCOeuWxi(
      RefKind refKind)
    {
      return refKind.Unpack();
    }

    internal static void MFR5tjh1ivOCs4Pta5j7([In] object obj0, [In] bool obj1) => ((ParameterDeclarationSyntax) obj0).ParamsModifier = obj1;

    internal static EleWise.ELMA.CodeGeneration.CSharp.Enums.DeclarationModifiers LtSnPsh1R7fddd3TZN33(
      DeclarationModifiers modifiers)
    {
      return modifiers.Unpack();
    }

    internal static object lrtdpAh1quU5RANp48Q7(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] EleWise.ELMA.CodeGeneration.CSharp.Enums.Accessibility obj3,
      [In] EleWise.ELMA.CodeGeneration.CSharp.Enums.DeclarationModifiers obj4,
      [In] object obj5)
    {
      return (object) ((SyntaxGenerator) obj0).FieldDeclaration((string) obj1, (SyntaxNode) obj2, obj3, obj4, (SyntaxNode) obj5);
    }

    internal static object Eu8guIh1KPwwAb3mA0Px([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((SyntaxGenerator) obj0).AsPrivateInterfaceImplementation((SyntaxNode) obj1, (SyntaxNode) obj2);

    internal static object k7scLPh1XE5SfTXFfHEs([In] object obj0) => (object) ((ISyntaxNode) obj0).ReturnStatement();

    internal static object StY2OGh1TEaMHZNRrgeN([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((SyntaxGenerator) obj0).AssignmentStatement((SyntaxNode) obj1, (SyntaxNode) obj2);

    internal static object f3GZMSh1k41J6kTv41cO([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((SyntaxGenerator) obj0).LocalDeclarationStatement((string) obj1, (SyntaxNode) obj2);

    internal static object Ox3CHxh1neaePhanDXvn(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      [In] bool obj4)
    {
      return (object) ((SyntaxGenerator) obj0).LocalDeclarationStatement((SyntaxNode) obj1, (string) obj2, (SyntaxNode) obj3, obj4);
    }

    internal static object uiX4Mbh1Ox35duPM47So([In] object obj0) => (object) ((SyntaxGenerator) obj0).BreakStatement();

    internal static object Q7iIhuh12UTad951cNlV([In] object obj0, [In] object obj1) => (object) ((SyntaxGenerator) obj0).ThrowStatement((SyntaxNode) obj1);

    internal static object OEF9mVh1efZDOPGJmXvc([In] object obj0, [In] object obj1) => (object) ((SyntaxGenerator) obj0).SnippetExpression((string) obj1);

    internal static object Atq2FXh1PGBgk0vBU2Ls([In] object obj0) => (object) obj0.CreateSyntaxNode();

    internal static object GSmtpXh11YUpfAe7aw5C([In] object obj0) => (object) ((ISyntaxNode) obj0).TypeOfExpression();

    internal static object tLqORZh1NqxYWhyAgKqF([In] object obj0, [In] object obj1) => (object) ((SyntaxGenerator) obj0).TypeOfExpression((SyntaxNode) obj1);

    internal static object wo1Rt8h13FLrDsBk5CoD([In] object obj0) => (object) ((ISyntaxNode) obj0).DefaultExpression();

    internal static object njxBNLh1pTkBycknTOqT([In] object obj0, [In] object obj1) => (object) ((SyntaxGenerator) obj0).DefaultExpression((SyntaxNode) obj1);

    internal static object fmaW0hh1aZhnENYs8kI6([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((SyntaxGenerator) obj0).CastExpression((SyntaxNode) obj1, (SyntaxNode) obj2);

    internal static object KjEx0Bh1DP4CeXFILgFs([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((SyntaxGenerator) obj0).TryCastExpression((SyntaxNode) obj1, (SyntaxNode) obj2);

    internal static object MFwUgsh1tdIHYoCwJkDn([In] object obj0, [In] EleWise.ELMA.CodeGeneration.CSharp.Enums.RefKind obj1, [In] object obj2) => (object) ((SyntaxGenerator) obj0).RefKindArgument(obj1, (SyntaxNode) obj2);

    internal static object ILRf3Ph1wa59txoOQqc4([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((SyntaxGenerator) obj0).MemberAccessExpression((SyntaxNode) obj1, (string) obj2);

    internal static object c7uhc8h14uLoBCgv9vRC([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((SyntaxGenerator) obj0).CoalesceExpression((SyntaxNode) obj1, (SyntaxNode) obj2);

    internal static object hPZX0qh16Z8GJsDoDBPy([In] object obj0, [In] object obj1) => (object) ((SyntaxGenerator) obj0).ValueReturningLambdaExpression((SyntaxNode) obj1);

    internal static object kpgdy2h1HVKcmBTT4bE4([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((SyntaxGenerator) obj0).ValueEqualsExpression((SyntaxNode) obj1, (SyntaxNode) obj2);

    internal static object MYTTk6h1AsJXSdju0vr6([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((SyntaxGenerator) obj0).ValueNotEqualsExpression((SyntaxNode) obj1, (SyntaxNode) obj2);

    internal static object qUWi7Ih17AWOkwmLSaj6([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((SyntaxGenerator) obj0).LogicalOrExpression((SyntaxNode) obj1, (SyntaxNode) obj2);

    internal static object lS5B20h1xYfQ81jNukNJ([In] object obj0, [In] object obj1) => (object) ((SyntaxGenerator) obj0).AwaitExpression((SyntaxNode) obj1);

    private class MembersComparer : IComparer<Type>
    {
      internal static object kq3x6gvuAkd0tG1gPa41;

      private int? Compare<T>(Type x, Type y)
      {
        if (x == TypeOf<T>.Raw || x.IsSubclassOf(TypeOf<T>.Raw))
          return new int?(-1);
        return !(y == TypeOf<T>.Raw) && !y.IsSubclassOf(TypeOf<T>.Raw) ? new int?() : new int?(1);
      }

      public int Compare(Type x, Type y)
      {
        int num = 1;
        int? nullable1;
        int? nullable2;
        int? nullable3;
        int? nullable4;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!SyntaxGeneratorExtensions.MembersComparer.ReEO9Evu0nS8HDRxG6mF(x, y))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
                continue;
              }
              goto label_9;
            case 2:
              if (!nullable2.HasValue)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 7 : 7;
                continue;
              }
              goto label_6;
            case 3:
              goto label_7;
            case 4:
              if (nullable4.HasValue)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 3 : 3;
                continue;
              }
              goto case 5;
            case 5:
              nullable2 = this.Compare<PropertyDeclarationSyntax>(x, y);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 2 : 2;
              continue;
            case 6:
              if (!nullable3.HasValue)
              {
                num = 11;
                continue;
              }
              goto label_5;
            case 7:
              nullable3 = this.Compare<MethodDeclarationSyntax>(x, y);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 6 : 2;
              continue;
            case 8:
              goto label_8;
            case 9:
              if (nullable1.HasValue)
              {
                num = 8;
                continue;
              }
              goto case 10;
            case 10:
              nullable4 = this.Compare<ConstructorDeclarationSyntax>(x, y);
              num = 4;
              continue;
            case 11:
              goto label_4;
            default:
              nullable1 = this.Compare<FieldDeclarationSyntax>(x, y);
              num = 9;
              continue;
          }
        }
label_4:
        return 0;
label_5:
        return nullable3.GetValueOrDefault();
label_6:
        return nullable2.GetValueOrDefault();
label_7:
        return nullable4.GetValueOrDefault();
label_8:
        return nullable1.GetValueOrDefault();
label_9:
        return 0;
      }

      public MembersComparer()
      {
        SyntaxGeneratorExtensions.MembersComparer.ERWgmTvumySCSbRrE4Tl();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool ReEO9Evu0nS8HDRxG6mF([In] Type obj0, [In] Type obj1) => obj0 == obj1;

      internal static bool aNphM0vu7fC5kbOcMXuf() => SyntaxGeneratorExtensions.MembersComparer.kq3x6gvuAkd0tG1gPa41 == null;

      internal static SyntaxGeneratorExtensions.MembersComparer pTsiVyvuxFtr1w7rPiNF() => (SyntaxGeneratorExtensions.MembersComparer) SyntaxGeneratorExtensions.MembersComparer.kq3x6gvuAkd0tG1gPa41;

      internal static void ERWgmTvumySCSbRrE4Tl() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
