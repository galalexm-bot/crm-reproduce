// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.InterfaceImplementationAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Определяет интерфейс, который реализует класс (соответствует ClassMetadata.ImplementedInterfaces).
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
  public class InterfaceImplementationAttribute : Attribute
  {
    private string interfaceTypeName;
    internal static InterfaceImplementationAttribute UQBOvmo8yi54K8q6VocL;

    /// <summary>Ctor</summary>
    /// <param name="interfaceTypeName">Имя типа интерфейса</param>
    public InterfaceImplementationAttribute(string interfaceTypeName)
    {
      InterfaceImplementationAttribute.ra4HeGo89t7oFlpF0v9Q();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.interfaceTypeName = interfaceTypeName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Имя типа интерфейса</summary>
    public string InterfaceTypeName => this.interfaceTypeName;

    internal static void ra4HeGo89t7oFlpF0v9Q() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool hYBcGFo8MVcchahNNu9e() => InterfaceImplementationAttribute.UQBOvmo8yi54K8q6VocL == null;

    internal static InterfaceImplementationAttribute nvCAtlo8J4ZQXp7Eriug() => InterfaceImplementationAttribute.UQBOvmo8yi54K8q6VocL;
  }
}
