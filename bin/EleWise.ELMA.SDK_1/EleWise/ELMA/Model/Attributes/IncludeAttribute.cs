// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.IncludeAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут, указывающий какой тип включает в себя класс
  /// </summary>
  /// <remarks>
  /// Вместо явного наследования используется композиция типов
  /// Пример:
  /// Class1 : Class2 -&gt; Явное наслеование
  /// 
  /// [Include("EB7951CA-8F91-43C0-A50E-EBC37E6418A6")]
  /// Class1 -&gt; Означает, что Class1 НЕ наследует Class2, но включает его метаданные в себя,
  /// то есть при использовании метода As можно будет использовать свойства Class2 явно
  /// </remarks>
  [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
  public sealed class IncludeAttribute : Attribute
  {
    private static IncludeAttribute SRsGT6ofRixnajlpD22X;

    /// <summary>Ctor</summary>
    /// <param name="uid"></param>
    public IncludeAttribute(string uid)
    {
      IncludeAttribute.EXixLDofX727XhXniyQs();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Uid = new Guid(uid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>
    /// Уникальный идентификатор метаданных, который включен в данный класс
    /// </summary>
    internal Guid Uid { get; }

    internal static void EXixLDofX727XhXniyQs() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool UKeURPofqjuSLhjB3rtI() => IncludeAttribute.SRsGT6ofRixnajlpD22X == null;

    internal static IncludeAttribute lZvSo2ofKwfmgMJELnUr() => IncludeAttribute.SRsGT6ofRixnajlpD22X;
  }
}
