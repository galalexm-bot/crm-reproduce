// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.MethodInfoExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions
{
  /// <summary>Методы расширения для MethodInfo</summary>
  public static class MethodInfoExtensions
  {
    internal static MethodInfoExtensions Pl0V0yGpd7kyfujTZS7W;

    /// <summary>Проверка, является ли метод анонимной лямбдой?</summary>
    /// <param name="method">Рефлексия метода.</param>
    /// <returns><c>true</c> - является, <c>false</c> - нет.</returns>
    public static bool IsAnonymous(this MethodInfo method)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(MethodInfoExtensions.jmi3eXGpg7bp1uIsqpmy((object) method) == (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return !MethodInfoExtensions.VhavMbGpjEbtWb8KoVy0(MethodInfoExtensions.e4QxesGp59xQDry3LXNa((object) method));
label_3:
      return true;
    }

    internal static Type jmi3eXGpg7bp1uIsqpmy([In] object obj0) => ((MemberInfo) obj0).DeclaringType;

    internal static object e4QxesGp59xQDry3LXNa([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static bool VhavMbGpjEbtWb8KoVy0([In] object obj0) => CodeGenerator.IsValidLanguageIndependentIdentifier((string) obj0);

    internal static bool fQL5ehGplkdwq4Hi2fhJ() => MethodInfoExtensions.Pl0V0yGpd7kyfujTZS7W == null;

    internal static MethodInfoExtensions ANGKfgGpr6YCJ3IfwysG() => MethodInfoExtensions.Pl0V0yGpd7kyfujTZS7W;
  }
}
