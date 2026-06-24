// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.ScriptModuleCodeGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Exceptions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>Генератор исходного кода для модуля сценариев</summary>
  public abstract class ScriptModuleCodeGenerator : ClassGenerator
  {
    internal static ScriptModuleCodeGenerator S0v7sfhO3g1au7mY8ZCd;

    /// <inheritdoc />
    protected override GeneratedFileInfo GenerateMainFileInternal()
    {
      GeneratedFileInfo mainFileHelper;
      switch (1)
      {
        case 1:
          try
          {
            ISyntaxNode[] array = this.GenerateMainFile().ToArray<ISyntaxNode>();
            int num = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
              num = 0;
            while (true)
            {
              string name;
              switch (num)
              {
                case 1:
                  name = (string) ScriptModuleCodeGenerator.CSMsYShOD0qTqK8QUdkn((object) this);
                  num = 5;
                  continue;
                case 2:
                  goto label_1;
                case 3:
                case 4:
                  mainFileHelper = this.GenerateMainFileHelper(array);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 2 : 2;
                  continue;
                case 5:
                  if (ScriptModuleCodeGenerator.C5oQTThOtqOR7YPJZUZD((object) name))
                  {
                    num = 3;
                    continue;
                  }
                  break;
              }
              array = this.GetNamespaces().Concat<ISyntaxNode>(name.NamespaceDeclaration(array)).ToArray<ISyntaxNode>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 4 : 1;
            }
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
              num = 0;
            switch (num)
            {
              default:
                throw new CodeGenerationException(EleWise.ELMA.SR.T((string) ScriptModuleCodeGenerator.V2cOPAhOwipsMbX57je6(-1334993905 ^ -1334915607)), ex);
            }
          }
      }
label_1:
      return mainFileHelper;
    }

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> GenerateMainFile()
    {
      ISyntaxNode type = this.GetClassName().ClassDeclaration(modifiers: DeclarationModifiers.Partial, members: this.GetMembers());
      this.WriteComments(type);
      return (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
      {
        type
      };
    }

    /// <summary>Получить имя класса</summary>
    /// <returns>Имя класса</returns>
    protected abstract string GetClassName();

    protected ScriptModuleCodeGenerator()
    {
      ScriptModuleCodeGenerator.R1Ki7AhO4J3IHTf7eDCF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object CSMsYShOD0qTqK8QUdkn([In] object obj0) => (object) ((ClassGenerator) obj0).GetNamespace();

    internal static bool C5oQTThOtqOR7YPJZUZD([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object V2cOPAhOwipsMbX57je6(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool nF276jhOplhMt8oEDfXi() => ScriptModuleCodeGenerator.S0v7sfhO3g1au7mY8ZCd == null;

    internal static ScriptModuleCodeGenerator IfwbshhOawApFnJINHGt() => ScriptModuleCodeGenerator.S0v7sfhO3g1au7mY8ZCd;

    internal static void R1Ki7AhO4J3IHTf7eDCF() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
