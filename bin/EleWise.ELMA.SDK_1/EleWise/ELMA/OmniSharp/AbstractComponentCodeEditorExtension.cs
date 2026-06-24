// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.OmniSharp.AbstractComponentCodeEditorExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.OmniSharp.Models;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace EleWise.ELMA.OmniSharp
{
  /// <summary>
  /// Абстрактный класс генерации исходников для модулей сценариев компонента
  /// </summary>
  [Component]
  internal abstract class AbstractComponentCodeEditorExtension : AbstractCodeEditorExtension
  {
    private static AbstractComponentCodeEditorExtension fxFwrdW9mrlc6D0Iygbo;

    /// <summary>Сервис получения исходников для метаданных компонента</summary>
    public IComponentMetadataSourcesService ComponentMetadataSourcesService
    {
      get => this.\u003CComponentMetadataSourcesService\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CComponentMetadataSourcesService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
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

    /// <inheritdoc />
    public override bool Check(InitWorkspaceRequest request)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (request == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
              continue;
            }
            break;
          case 3:
            goto label_2;
        }
        if (AbstractComponentCodeEditorExtension.sYmRroW9JZyGcXgKNtPS((object) request) == AbstractComponentCodeEditorExtension.MZBw4BW993tYde04dirr((object) this))
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 1 : 3;
        else
          goto label_3;
      }
label_2:
      return AbstractComponentCodeEditorExtension.b4GjOjW9dCdhx5wePBlb((object) request) is ComponentMetadata;
label_3:
      return false;
    }

    /// <inheritdoc />
    public override int GetMethodPosition(string sourceCode, string className, string methodName)
    {
      int num1 = 10;
      MethodDeclarationSyntax declarationSyntax1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          ClassDeclarationSyntax declarationSyntax2;
          ClassDeclarationSyntax declarationSyntax3;
          string className1;
          string methodName1;
          switch (num2)
          {
            case 1:
              goto label_5;
            case 2:
              if (declarationSyntax2 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 7 : 3;
                continue;
              }
              goto label_5;
            case 3:
              methodName1 = methodName;
              num2 = 5;
              continue;
            case 4:
              goto label_23;
            case 5:
              if (string.IsNullOrEmpty(methodName1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 11 : 7;
                continue;
              }
              goto case 12;
            case 6:
              ClassDeclarationSyntax declarationSyntax4 = CSharpSyntaxTree.ParseText(sourceCode, (CSharpParseOptions) AbstractComponentCodeEditorExtension.dxyaloW9g2sKjIukjjEt(AbstractComponentCodeEditorExtension.GVaA2DW9rgcbwqRE2G5J(), LanguageVersion.CSharp7), "", (Encoding) null, (ImmutableDictionary<string, ReportDiagnostic>) null, new CancellationToken()).GetRoot().DescendantNodes().OfType<ClassDeclarationSyntax>().FirstOrDefault<ClassDeclarationSyntax>((Func<ClassDeclarationSyntax, bool>) (q =>
              {
                int num3 = 1;
                SyntaxToken identifier;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      identifier = q.Identifier;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_2;
                  }
                }
label_2:
                // ISSUE: reference to a compiler-generated method
                return AbstractComponentCodeEditorExtension.\u003C\u003Ec__DisplayClass5_0.OYt4CkQU3uCnn5G630rZ((object) identifier.ToString(), (object) className1);
              }));
              if (declarationSyntax4 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 6 : 8;
                continue;
              }
              IEnumerable<ClassDeclarationSyntax> source = declarationSyntax4.Members.OfType<ClassDeclarationSyntax>();
              // ISSUE: reference to a compiler-generated field
              Func<ClassDeclarationSyntax, bool> func = AbstractComponentCodeEditorExtension.\u003C\u003Ec.\u003C\u003E9__5_1;
              Func<ClassDeclarationSyntax, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                AbstractComponentCodeEditorExtension.\u003C\u003Ec.\u003C\u003E9__5_1 = predicate = (Func<ClassDeclarationSyntax, bool>) (q =>
                {
                  int num4 = 1;
                  SyntaxToken syntaxToken;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        syntaxToken = AbstractComponentCodeEditorExtension.\u003C\u003Ec.qVE5m7QU4B7GsqNL6f6V((object) q);
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_3;
                    }
                  }
label_3:
                  // ISSUE: reference to a compiler-generated method
                  return AbstractComponentCodeEditorExtension.\u003C\u003Ec.QXkkmVQU6hBUu85e82a2((object) syntaxToken.ToString(), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289775736));
                });
              }
              else
                goto label_25;
label_21:
              declarationSyntax3 = source.FirstOrDefault<ClassDeclarationSyntax>(predicate);
              break;
label_25:
              predicate = func;
              goto label_21;
            case 7:
              declarationSyntax1 = declarationSyntax2.Members.OfType<MethodDeclarationSyntax>().FirstOrDefault<MethodDeclarationSyntax>((Func<MethodDeclarationSyntax, bool>) (q =>
              {
                int num5 = 1;
                SyntaxToken syntaxToken;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      syntaxToken = AbstractComponentCodeEditorExtension.\u003C\u003Ec__DisplayClass5_0.Dv6uEvQUpMr0tIS7DvNU((object) q);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_2;
                  }
                }
label_2:
                // ISSUE: reference to a compiler-generated method
                return AbstractComponentCodeEditorExtension.\u003C\u003Ec__DisplayClass5_0.OYt4CkQU3uCnn5G630rZ((object) syntaxToken.ToString(), (object) methodName1);
              }));
              if (declarationSyntax1 == null)
              {
                num2 = 4;
                continue;
              }
              goto label_24;
            case 8:
              declarationSyntax3 = (ClassDeclarationSyntax) null;
              break;
            case 9:
              className1 = className;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 3 : 1;
              continue;
            case 10:
              goto label_13;
            case 12:
              if (!AbstractComponentCodeEditorExtension.zxUU15W9laIgcUrhunqg((object) sourceCode))
              {
                num2 = 6;
                continue;
              }
              goto label_15;
            default:
              goto label_15;
          }
          declarationSyntax2 = declarationSyntax3;
          num2 = 2;
        }
label_13:
        num1 = 9;
      }
label_5:
      return 0;
label_15:
      return 0;
label_23:
      return 0;
label_24:
      return AbstractComponentCodeEditorExtension.KN6rrlW9jM01LX3PBPpM(AbstractComponentCodeEditorExtension.yv0wLmW95OttrPhpUIPs((object) declarationSyntax1));
    }

    /// <summary>Уникальный идентификатор типа модуля сценариев</summary>
    protected abstract Guid ModuleTypeUid { get; }

    /// <inheritdoc />
    protected override ICodeEditorInitData GetCodeEditorInitData(InitWorkspaceRequest request)
    {
      int num = 5;
      ComponentMetadata metadata;
      ScriptModule scriptModuleRequired;
      AbstractCodeEditorExtension.WorkspaceProjectHelper workspaceProjectHelper;
      while (true)
      {
        NamedMetadata namedMetadata;
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            goto label_2;
          case 3:
            workspaceProjectHelper = new AbstractCodeEditorExtension.WorkspaceProjectHelper(scriptModuleRequired);
            num = 2;
            continue;
          case 4:
            namedMetadata = (NamedMetadata) null;
            break;
          case 5:
            if (request == null)
            {
              num = 4;
              continue;
            }
            namedMetadata = request.Metadata;
            break;
          default:
            if (metadata != null)
            {
              scriptModuleRequired = AbstractCodeEditorExtension.FindScriptModuleRequired((IEnumerable<ScriptModule>) request.ScriptModules, AbstractComponentCodeEditorExtension.yJpL1QW9YkkdJ0HVlyec((object) this));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 3 : 3;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 0;
            continue;
        }
        metadata = namedMetadata as ComponentMetadata;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
      }
label_2:
      CodeEditorInitData codeEditorInitData = new CodeEditorInitData();
      AbstractComponentCodeEditorExtension.BnShrqW9LJF2qaQRF0fW((object) codeEditorInitData, (object) this.GetFileName(metadata));
      codeEditorInitData.ClassName = metadata.Name;
      codeEditorInitData.MethodName = (string) AbstractComponentCodeEditorExtension.siPFLRW9UDeK7D5RvOqv((object) request);
      AbstractComponentCodeEditorExtension.xvGJCiW9ckWPtI2s9Vuk((object) codeEditorInitData, AbstractComponentCodeEditorExtension.aiHJMtW9svOkoAcS7NYj((object) scriptModuleRequired));
      AbstractComponentCodeEditorExtension.VbjFBNWdFJhWe1bmg3bf((object) codeEditorInitData, AbstractComponentCodeEditorExtension.CaVYFoW9zkSeXMv9Rk82((object) workspaceProjectHelper));
      return (ICodeEditorInitData) codeEditorInitData;
label_7:
      return (ICodeEditorInitData) null;
    }

    /// <summary>Получить расширенный список метаданных</summary>
    /// <param name="metadata">Метаданные компонента</param>
    /// <returns>Расширенный список метаданных</returns>
    protected IEnumerable<IMetadata> GetExtendMetadata(ComponentMetadata metadata) => ((IEnumerable<IMetadata>) this.SearchMetadataService.GetPublishedDataClasses()).Concat<IMetadata>(metadata.GetMetadataToRegister());

    private string GetFileName(ComponentMetadata metadata)
    {
      int num = 1;
      CodeType codeType;
      while (true)
      {
        switch (num)
        {
          case 1:
            codeType = AbstractComponentCodeEditorExtension.MZBw4BW993tYde04dirr((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_8;
          case 3:
            goto label_4;
          default:
            switch (codeType)
            {
              case CodeType.Client:
                goto label_4;
              case CodeType.Server:
                goto label_5;
              case CodeType.Test:
                goto label_6;
              case CodeType.GlobalFunction:
                goto label_8;
              case CodeType.View:
                goto label_7;
              default:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 2 : 0;
                continue;
            }
        }
      }
label_4:
      return this.ComponentMetadataSourcesService.ClientControllerName(metadata);
label_5:
      return this.ComponentMetadataSourcesService.ServerControllerName(metadata);
label_6:
      return (string) AbstractComponentCodeEditorExtension.BPslRHWdBbMiCQvjcxrK((object) this.ComponentMetadataSourcesService, (object) metadata);
label_7:
      return (string) AbstractComponentCodeEditorExtension.kFFLCUWdWh5qTDcDmdLs((object) this.ComponentMetadataSourcesService, (object) metadata);
label_8:
      return string.Empty;
    }

    protected AbstractComponentCodeEditorExtension()
    {
      AbstractComponentCodeEditorExtension.uLCnOJWdoQHtPLSccvn5();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool VHBCa3W9yALRYRVDTi12() => AbstractComponentCodeEditorExtension.fxFwrdW9mrlc6D0Iygbo == null;

    internal static AbstractComponentCodeEditorExtension uk96CtW9MenHVw7xnv3Y() => AbstractComponentCodeEditorExtension.fxFwrdW9mrlc6D0Iygbo;

    internal static CodeType sYmRroW9JZyGcXgKNtPS([In] object obj0) => ((InitWorkspaceRequest) obj0).CodeType;

    internal static CodeType MZBw4BW993tYde04dirr([In] object obj0) => ((AbstractCodeEditorExtension) obj0).CodeType;

    internal static object b4GjOjW9dCdhx5wePBlb([In] object obj0) => (object) ((InitWorkspaceRequest) obj0).Metadata;

    internal static bool zxUU15W9laIgcUrhunqg([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object GVaA2DW9rgcbwqRE2G5J() => (object) CSharpParseOptions.Default;

    internal static object dxyaloW9g2sKjIukjjEt([In] object obj0, [In] LanguageVersion obj1) => (object) ((CSharpParseOptions) obj0).WithLanguageVersion(obj1);

    internal static object yv0wLmW95OttrPhpUIPs([In] object obj0) => (object) ((BaseMethodDeclarationSyntax) obj0).Body;

    internal static int KN6rrlW9jM01LX3PBPpM([In] object obj0) => ((SyntaxNode) obj0).SpanStart;

    internal static Guid yJpL1QW9YkkdJ0HVlyec([In] object obj0) => ((AbstractComponentCodeEditorExtension) obj0).ModuleTypeUid;

    internal static void BnShrqW9LJF2qaQRF0fW([In] object obj0, [In] object obj1) => ((CodeEditorInitData) obj0).FileName = (string) obj1;

    internal static object siPFLRW9UDeK7D5RvOqv([In] object obj0) => (object) ((InitWorkspaceRequest) obj0).MethodName;

    internal static object aiHJMtW9svOkoAcS7NYj([In] object obj0) => (object) ((ScriptModule) obj0).SourceCode;

    internal static void xvGJCiW9ckWPtI2s9Vuk([In] object obj0, [In] object obj1) => ((CodeEditorInitData) obj0).SourceCode = (string) obj1;

    internal static object CaVYFoW9zkSeXMv9Rk82([In] object obj0) => (object) ((AbstractCodeEditorExtension.WorkspaceProjectHelper) obj0).CsprojFileName;

    internal static void VbjFBNWdFJhWe1bmg3bf([In] object obj0, [In] object obj1) => ((CodeEditorInitData) obj0).ProjectName = (string) obj1;

    internal static object BPslRHWdBbMiCQvjcxrK([In] object obj0, [In] object obj1) => (object) ((IComponentMetadataSourcesService) obj0).TestControllerName((ComponentMetadata) obj1);

    internal static object kFFLCUWdWh5qTDcDmdLs([In] object obj0, [In] object obj1) => (object) ((IComponentMetadataSourcesService) obj0).ViewControllerName((ComponentMetadata) obj1);

    internal static void uLCnOJWdoQHtPLSccvn5() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
