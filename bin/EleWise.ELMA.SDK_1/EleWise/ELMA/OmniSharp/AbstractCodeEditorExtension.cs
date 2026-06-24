// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.OmniSharp.AbstractCodeEditorExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.OmniSharp.Models;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Templates;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.OmniSharp
{
  /// <inheritdoc />
  public abstract class AbstractCodeEditorExtension : ICodeEditorExtension
  {
    private static string compiledBaseDir;
    private IGlobalModulesReferenceService globalModulesReferenceService;
    private static readonly string[] DefaultGlobalReferences;
    private static readonly string[] DefaultElmaReferences;
    /// <summary>Формат тега Compile</summary>
    protected const string CompileFormat = "<Compile Include=\"{0}\" />";
    private static AbstractCodeEditorExtension jWcJ4kWdg7oA9iLbdB7S;

    private string LibsPath
    {
      get
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
            case 2:
              goto label_2;
            case 3:
              if (!AbstractCodeEditorExtension.ysWER0WdLmtSfF5rhhtI(AbstractCodeEditorExtension.TqkbWvWdY5B5haFdDkye((object) this.OmniSharpWorker)))
              {
                num = 2;
                continue;
              }
              break;
          }
          this.OmniSharpWorker.Start(true);
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 1 : 1;
        }
label_2:
        return (string) AbstractCodeEditorExtension.TqkbWvWdY5B5haFdDkye((object) this.OmniSharpWorker);
      }
    }

    private string ClientLibsPath
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!AbstractCodeEditorExtension.ysWER0WdLmtSfF5rhhtI(AbstractCodeEditorExtension.roiMM4WdUFvmaJrpIHsh((object) this.OmniSharpWorker)))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            case 3:
              this.OmniSharpWorker.Start(true);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 2 : 2;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return this.OmniSharpWorker.ClientCompletionLibsPath;
      }
    }

    /// <summary>Служба управления метаданными в режиме Runtime</summary>
    public IMetadataRuntimeService MetadataRuntimeService
    {
      get => this.\u003CMetadataRuntimeService\u003Ek__BackingField;
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
              this.\u003CMetadataRuntimeService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
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

    /// <summary>Сервис поиска метаданных</summary>
    public ISearchMetadataService SearchMetadataService
    {
      get => this.\u003CSearchMetadataService\u003Ek__BackingField;
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
              this.\u003CSearchMetadataService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
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

    /// <summary>Элемент для работы с сервером OmniSharp</summary>
    public IOmniSharpWorker OmniSharpWorker
    {
      get => this.\u003COmniSharpWorker\u003Ek__BackingField;
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
              this.\u003COmniSharpWorker\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
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

    /// <summary>Элемент для работы с сервером OmniSharp</summary>
    internal IGlobalModulesReferenceService GlobalModulesReferenceService
    {
      get
      {
        int num = 1;
        IGlobalModulesReferenceService serviceNotNull;
        IGlobalModulesReferenceService referenceService;
        while (true)
        {
          switch (num)
          {
            case 1:
              referenceService = this.globalModulesReferenceService;
              if (referenceService == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.globalModulesReferenceService = serviceNotNull = Locator.GetServiceNotNull<IGlobalModulesReferenceService>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 2 : 0;
              continue;
          }
        }
label_2:
        return referenceService;
label_6:
        return serviceNotNull;
      }
    }

    /// <inheritdoc />
    public abstract bool Check(InitWorkspaceRequest request);

    /// <inheritdoc />
    public virtual Task<OmniSharpItem> InitWorkspace(InitWorkspaceRequest request)
    {
      if (request == null)
        return Task.FromResult<OmniSharpItem>((OmniSharpItem) null);
      ICodeEditorInitData codeEditorInitData = this.GetCodeEditorInitData(request);
      if (codeEditorInitData == null)
        return Task.FromResult<OmniSharpItem>((OmniSharpItem) null);
      string projectDir = AbstractCodeEditorExtension.GetProjectFolderPath((object) codeEditorInitData.ProjectName, this.CodeType);
      string fileName = Path.Combine(projectDir, codeEditorInitData.FileName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121220933));
      int methodPosition = this.GetMethodPosition(codeEditorInitData.SourceCode, codeEditorInitData.ClassName, codeEditorInitData.MethodName);
      OmniSharpItem result = new OmniSharpItem();
      result.FileName = fileName;
      result.ProjectFileName = Path.Combine(projectDir, codeEditorInitData.ProjectName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304461851));
      result.MethodPosition = methodPosition;
      Task.Run((Func<Task>) (() =>
      {
        int num1 = 5;
        // ISSUE: variable of a compiler-generated type
        AbstractCodeEditorExtension.\u003C\u003Ec__DisplayClass27_0.\u003C\u003CInitWorkspace\u003Eb__0\u003Ed stateMachine;
        while (true)
        {
          int num2 = num1;
          AsyncTaskMethodBuilder tBuilder;
          while (true)
          {
            switch (num2)
            {
              case 1:
                tBuilder.Start<AbstractCodeEditorExtension.\u003C\u003Ec__DisplayClass27_0.\u003C\u003CInitWorkspace\u003Eb__0\u003Ed>(ref stateMachine);
                num2 = 3;
                continue;
              case 2:
                // ISSUE: reference to a compiler-generated field
                stateMachine.\u003C\u003E1__state = -1;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
                continue;
              case 3:
                goto label_7;
              case 4:
                // ISSUE: reference to a compiler-generated field
                stateMachine.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
                num2 = 2;
                continue;
              case 5:
                goto label_8;
              default:
                // ISSUE: reference to a compiler-generated field
                tBuilder = stateMachine.\u003C\u003Et__builder;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 1;
                continue;
            }
          }
label_8:
          // ISSUE: reference to a compiler-generated field
          stateMachine.\u003C\u003E4__this = (object) this;
          num1 = 4;
        }
label_7:
        // ISSUE: reference to a compiler-generated field
        return stateMachine.\u003C\u003Et__builder.Task;
      }));
      return Task.FromResult<OmniSharpItem>(result);
    }

    /// <inheritdoc />
    public abstract IScriptData GenerateSource(InitWorkspaceRequest request);

    /// <inheritdoc />
    public virtual int GetMethodPosition(string sourceCode, string className, string methodName)
    {
      int num1 = 7;
      ClassDeclarationSyntax declarationSyntax1;
      MethodDeclarationSyntax declarationSyntax2;
      string className1;
      string methodName1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            declarationSyntax1 = CSharpSyntaxTree.ParseText(sourceCode, (CSharpParseOptions) AbstractCodeEditorExtension.wj73NaWdcGy7JivqSQKu(AbstractCodeEditorExtension.gnu5J9WdsFcda3jnrjhE(), LanguageVersion.CSharp7), "", (Encoding) null, (ImmutableDictionary<string, ReportDiagnostic>) null, new CancellationToken()).GetRoot().DescendantNodes().OfType<ClassDeclarationSyntax>().FirstOrDefault<ClassDeclarationSyntax>((Func<ClassDeclarationSyntax, bool>) (q =>
            {
              int num2 = 1;
              SyntaxToken syntaxToken;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    syntaxToken = AbstractCodeEditorExtension.\u003C\u003Ec__DisplayClass29_0.HoCjjsQsap5sfLLKGaaW((object) q);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_2;
                }
              }
label_2:
              // ISSUE: reference to a compiler-generated method
              return AbstractCodeEditorExtension.\u003C\u003Ec__DisplayClass29_0.DlZQprQsD7auiLYL6i4o((object) syntaxToken.ToString(), (object) className1);
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_10;
          case 3:
            if (!AbstractCodeEditorExtension.ysWER0WdLmtSfF5rhhtI((object) sourceCode))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 1;
              continue;
            }
            goto label_10;
          case 4:
            goto label_16;
          case 5:
            methodName1 = methodName;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 8 : 4;
            continue;
          case 6:
            className1 = className;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 5;
            continue;
          case 7:
            num1 = 6;
            continue;
          case 8:
            if (!AbstractCodeEditorExtension.ysWER0WdLmtSfF5rhhtI((object) methodName1))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 3 : 2;
              continue;
            }
            goto label_10;
          case 9:
            goto label_13;
          default:
            if (declarationSyntax1 == null)
            {
              num1 = 9;
              continue;
            }
            declarationSyntax2 = declarationSyntax1.Members.OfType<MethodDeclarationSyntax>().FirstOrDefault<MethodDeclarationSyntax>((Func<MethodDeclarationSyntax, bool>) (q =>
            {
              int num3 = 1;
              SyntaxToken syntaxToken;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    syntaxToken = AbstractCodeEditorExtension.\u003C\u003Ec__DisplayClass29_0.WLoe8DQstpWDRy3lB9AD((object) q);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_2;
                }
              }
label_2:
              return syntaxToken.ToString() == methodName1;
            }));
            if (declarationSyntax2 == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 4 : 1;
              continue;
            }
            goto label_17;
        }
      }
label_10:
      return 0;
label_13:
      return 0;
label_16:
      return 0;
label_17:
      return AbstractCodeEditorExtension.OtQo8TWlFpyrbBLra71Y(AbstractCodeEditorExtension.HvQ0G9WdzJ0MHCTnMrde((object) declarationSyntax2));
    }

    /// <summary>Получить данные для инициализации редактора кода</summary>
    /// <param name="request">Запрос на инициализацию рабочего пространства</param>
    /// <returns>Данные для инициализации редактора кода</returns>
    protected abstract ICodeEditorInitData GetCodeEditorInitData(InitWorkspaceRequest request);

    /// <summary>Тип модуля сценариев</summary>
    protected abstract CodeType CodeType { get; }

    /// <summary>Дополнительные сборки, обязательные для подключения</summary>
    protected virtual IEnumerable<string> AdditionalElmaReferences => Enumerable.Empty<string>();

    /// <summary>Получить список сборок</summary>
    /// <param name="scriptModule">Модуль сценариев</param>
    /// <returns>Список сборок</returns>
    protected virtual IList<IScriptReference> GetAssemblies(ScriptModule scriptModule = null)
    {
      List<IScriptReference> result = new List<IScriptReference>();
      result.AddRange((IEnumerable<IScriptReference>) this.GetDynamicAssemblies());
      if (this.CodeType == CodeType.Server)
      {
        IEnumerable<ScriptReference> globalReferences = GetDefaultGlobalReferences();
        result.AddRange((IEnumerable<IScriptReference>) globalReferences);
        IEnumerable<ScriptReference> collection1 = GetGlobalReferences(scriptModule?.References).Where<ScriptReference>((Func<ScriptReference, bool>) (r => !result.Contains<IScriptReference>((IScriptReference) r, AbstractCodeEditorExtension.ScriptReferenceComparer.ByName)));
        result.AddRange((IEnumerable<IScriptReference>) collection1);
        ElmaReferencesList elmaReferenceString = ReferencesListHelper.ParseElmaReferenceString(scriptModule?.ElmaReferences);
        IEnumerable<ScriptReference> collection2 = elmaReferenceString.IncudeAllReferences ? GetAllReferencesInDirectory(this.LibsPath) : GetElmaReferences(elmaReferenceString);
        result.AddRange((IEnumerable<IScriptReference>) collection2);
        IEnumerable<ScriptReference> globalModules = GetGlobalModules((IEnumerable<AssemblyReference>) scriptModule?.GlobalScriptModules);
        result.AddRange((IEnumerable<IScriptReference>) globalModules);
      }
      else
      {
        IEnumerable<ScriptReference> referencesInDirectory = GetAllReferencesInDirectory(this.ClientLibsPath);
        result.AddRange((IEnumerable<IScriptReference>) referencesInDirectory);
      }
      foreach (DataClassAssemblyInfo dataClassAssembly in this.SearchMetadataService.GetPublishedDataClassAssemblies())
      {
        switch (this.CodeType)
        {
          case CodeType.Client:
          case CodeType.Test:
          case CodeType.View:
            if (dataClassAssembly.ClientAssemblyRaw != null)
            {
              result.Add((IScriptReference) new ScriptReference(dataClassAssembly.Name, dataClassAssembly.Name + z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647961456), dataClassAssembly.ClientAssemblyRaw));
              continue;
            }
            continue;
          case CodeType.Server:
          case CodeType.GlobalFunction:
            if (dataClassAssembly.AssemblyRaw != null)
            {
              result.Add((IScriptReference) new ScriptReference(dataClassAssembly.Name, dataClassAssembly.Name + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576068834), dataClassAssembly.AssemblyRaw));
              continue;
            }
            continue;
          default:
            continue;
        }
      }
      return (IList<IScriptReference>) result;

      static IEnumerable<ScriptReference> GetDefaultGlobalReferences() => ((IEnumerable<string>) AbstractCodeEditorExtension.DefaultGlobalReferences).Select<string, ScriptReference>((Func<string, ScriptReference>) (r => new ScriptReference(r, (string) null, (byte[]) null)));

      static IEnumerable<ScriptReference> GetGlobalReferences(string referenceString) => ReferencesListHelper.GetReferences(referenceString).Select<string, ScriptReference>((Func<string, ScriptReference>) (r => new ScriptReference(r, (string) null, (byte[]) null)));

      static IEnumerable<ScriptReference> GetAllReferencesInDirectory(string directory) => Directory.EnumerateFiles(directory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408975880), SearchOption.TopDirectoryOnly).Select<string, ScriptReference>((Func<string, ScriptReference>) (filename => new ScriptReference((string) AbstractCodeEditorExtension.\u003C\u003Ec.kIpZrVQsltIrISFbKKvu((object) filename), filename, (byte[]) null)));

      IEnumerable<ScriptReference> GetElmaReferences(ElmaReferencesList elmaReferencesList) => ((IEnumerable<string>) AbstractCodeEditorExtension.DefaultElmaReferences).Union<string>(this.AdditionalElmaReferences).Union<string>(elmaReferencesList.References).Select<string, ScriptReference>((Func<string, ScriptReference>) (r => new ScriptReference(r, (string) AbstractCodeEditorExtension.\u003C\u003Ec__DisplayClass36_0.BwBHuQQsxP5uQPp3aMvb((object) this.LibsPath, AbstractCodeEditorExtension.\u003C\u003Ec__DisplayClass36_0.CEmLy4Qs7cTMwwLHTBnI((object) r, AbstractCodeEditorExtension.\u003C\u003Ec__DisplayClass36_0.VgE4pRQsAUF7wLEg9ybt(813604817 ^ 813685611))), (byte[]) null)));

      IEnumerable<ScriptReference> GetGlobalModules(IEnumerable<AssemblyReference> modules) => modules.EmptyIfNull<AssemblyReference>().Select<AssemblyReference, ScriptReference>((Func<AssemblyReference, ScriptReference>) (module =>
      {
        int num = 1;
        string hintPath;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              hintPath = (string) AbstractCodeEditorExtension.\u003C\u003Ec__DisplayClass36_0.UWU4O0QsmUep6t4j6k4A((object) this.GlobalModulesReferenceService, AbstractCodeEditorExtension.\u003C\u003Ec__DisplayClass36_0.Nu5WsAQs0uEAOh8oju1t((object) module));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        // ISSUE: reference to a compiler-generated method
        return new ScriptReference((string) AbstractCodeEditorExtension.\u003C\u003Ec__DisplayClass36_0.mDXBu8QsyADjNNO6UrIs((object) module), hintPath, (byte[]) null);
      }));
    }

    /// <summary>Получить список динамических сборок</summary>
    /// <returns>Список динамических сборок</returns>
    protected virtual List<IScriptReference> GetDynamicAssemblies()
    {
      List<IScriptReference> dynamicAssemblies = new List<IScriptReference>();
      foreach (AssemblyModelsMetadata assemblyModelsMetadata in this.MetadataRuntimeService.GetAssemblyModelsMetadataList())
      {
        string name = assemblyModelsMetadata.Name;
        if (name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767722081) || name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921200659))
          dynamicAssemblies.Add(AbstractCodeEditorExtension.CreateScriptReference(assemblyModelsMetadata));
      }
      return dynamicAssemblies;
    }

    /// <summary>Создать ссылку на сборку</summary>
    /// <param name="modelsMetadata">Метаданные сборки с моделями</param>
    /// <returns>Ссылка на сборку</returns>
    protected static IScriptReference CreateScriptReference(AssemblyModelsMetadata modelsMetadata) => (IScriptReference) new ScriptReference((string) AbstractCodeEditorExtension.xhmcGHWlBfGUTkryo2gU((object) modelsMetadata), modelsMetadata.Name + (string) AbstractCodeEditorExtension.E9DSw5WlWUDKNZx4XRcw(-2099751081 ^ -2099702803), ((MemoryStream) AbstractCodeEditorExtension.NZQ8aYWlolFT5OxNBMMZ((object) modelsMetadata)).ToArray(), (byte[]) AbstractCodeEditorExtension.f6KnkZWlbqLBrEVCZQac((object) modelsMetadata));

    /// <summary>
    /// Сгенерировать секцию Sources для файла проекта (.csproj)
    /// </summary>
    /// <param name="sources">Список исходников</param>
    /// <returns>Секция Sources</returns>
    protected static string GenerateSourcesSection(IEnumerable<IScriptSource> sources)
    {
      StringBuilder stringBuilder = new StringBuilder();
      foreach (IScriptSource source in sources)
      {
        if (!string.IsNullOrWhiteSpace(source.Content))
        {
          stringBuilder.Append(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710717974), (object) (source.Name + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239638724))));
          stringBuilder.AppendLine();
        }
      }
      return stringBuilder.ToString();
    }

    /// <summary>
    /// Сгенерировать секцию References для файла проекта (.csproj)
    /// </summary>
    /// <param name="references">Список ссылок</param>
    /// <returns>Секция References</returns>
    protected string GenerateReferencesSection(IEnumerable<IScriptReference> references)
    {
      StringBuilder stringBuilder = new StringBuilder();
      // ISSUE: reference to a compiler-generated method
      foreach (IScriptReference scriptReference in references.Where<IScriptReference>((Func<IScriptReference, bool>) (r => !AbstractCodeEditorExtension.\u003C\u003Ec.TcBB0JQsrkPkbh4xWO02((object) r.Name))))
      {
        stringBuilder.Append(string.IsNullOrEmpty(scriptReference.HintPath) ? string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333592564), (object) scriptReference.Name) : string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70126491), (object) scriptReference.Name, (object) scriptReference.HintPath));
        stringBuilder.AppendLine();
      }
      return stringBuilder.ToString();
    }

    /// <summary>
    /// Сгенерировать данные скрипта для ссылок на веб-сервисы
    /// </summary>
    /// <param name="scriptModule">Модуль сценариев</param>
    protected IEnumerable<IScriptSource> GenerateWebReferencesSources(ScriptModule scriptModule) => (IEnumerable<IScriptSource>) new AbstractCodeEditorExtension.\u003CGenerateWebReferencesSources\u003Ed__41(-2)
    {
      \u003C\u003E4__this = this,
      \u003C\u003E3__scriptModule = scriptModule
    };

    /// <summary>Сгенерировать файл из шаблона в строку</summary>
    /// <typeparam name="T">Тип, из сборки которого берутся ресурсы. Кроме того, к имени ресурса в начало добавляется его пространство имен</typeparam>
    /// <param name="resourceName">Имя ресурса</param>
    /// <param name="conversions">Преобразования с текстом шаблона</param>
    /// <returns>Сгенерированный шаблон</returns>
    protected static string GenerateTemplate<T>(
      string resourceName,
      Func<string, string> conversions = null)
    {
      return ResourceTemplateGenerator.GenerateTemplate<T>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426214119) + resourceName, conversions);
    }

    /// <summary>Получить путь до файла проекта</summary>
    /// <param name="projectFolderPath">Путь до папки проекта</param>
    /// <param name="sourceName">Имя файла с расширением</param>
    public static string GetSourceFilePath(string projectFolderPath, string sourceName) => (string) AbstractCodeEditorExtension.JtZIUQWlhbcaHmDD2fsJ((object) projectFolderPath, (object) sourceName);

    /// <summary>
    /// Найти модуль сценариев обязательно (бросить исключение, если найти не удалось)
    /// </summary>
    /// <param name="modules">Перечисление модулей сценариев</param>
    /// <param name="scriptModuleTypeUid">Искомые уникальные идентификаторы GUID типов модулей сценариев</param>
    /// <returns>Первый попавшийся модуль, найденный по искомым идентификаторам</returns>
    /// <exception cref="T:System.Exception">"Не удалось получить модуль сценариев с TypeUid=..."</exception>
    protected static ScriptModule FindScriptModuleRequired(
      IEnumerable<ScriptModule> modules,
      params Guid[] scriptModuleTypeUid)
    {
      return AbstractCodeEditorExtension.FindScriptModule(modules, scriptModuleTypeUid) ?? throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178090244), (object) string.Join<Guid>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867358979), (IEnumerable<Guid>) scriptModuleTypeUid)));
    }

    /// <summary>Найти модуль сценариев</summary>
    /// <param name="modules">Перечисление модулей сценариев</param>
    /// <param name="scriptModuleTypeUid">Искомые уникальные идентификаторы GUID типов модулей сценариев</param>
    /// <returns>Первый попавшийся модуль, найденный по искомым идентификаторам, либо null, если найти не удалось</returns>
    protected static ScriptModule FindScriptModule(
      IEnumerable<ScriptModule> modules,
      params Guid[] scriptModuleTypeUid)
    {
      // ISSUE: reference to a compiler-generated method
      return modules.FirstOrDefault<ScriptModule>((Func<ScriptModule, bool>) (module => ((IEnumerable<Guid>) scriptModuleTypeUid).Contains<Guid>(AbstractCodeEditorExtension.\u003C\u003Ec__DisplayClass45_0.WkjQSTQcoWuG9Bi075Ou((object) module))));
    }

    private static void WriteScriptData(object projectFolderPath, object scriptData)
    {
      int num1 = 2;
      IEnumerator<IScriptReference> enumerator1;
      while (true)
      {
        int num2 = num1;
        IEnumerator<IScriptSource> enumerator2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              if (!AbstractCodeEditorExtension.ExSr1nWlGE4FOxmWsORJ(projectFolderPath))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 1;
                continue;
              }
              goto case 5;
            case 3:
              goto label_35;
            case 4:
label_5:
              enumerator1 = ((IScriptData) scriptData).Assemblies.GetEnumerator();
              num2 = 3;
              continue;
            case 5:
              enumerator2 = ((IScriptData) scriptData).Sources.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
              continue;
            case 6:
              goto label_54;
            default:
              try
              {
label_12:
                if (AbstractCodeEditorExtension.DdaYLBWluW0HaiuVOi5Y((object) enumerator2))
                  goto label_24;
                else
                  goto label_13;
label_8:
                IScriptSource current;
                int num3;
                while (true)
                {
                  string path;
                  string str1;
                  string str2;
                  object obj;
                  switch (num3)
                  {
                    case 1:
                      if (!AbstractCodeEditorExtension.ExSr1nWlGE4FOxmWsORJ((object) str1))
                      {
                        num3 = 4;
                        continue;
                      }
                      goto case 10;
                    case 2:
                      AbstractCodeEditorExtension.Iix7EEWl84fVQ6ilN2hg((object) path, FileAttributes.Normal);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 9 : 13;
                      continue;
                    case 3:
                      goto label_24;
                    case 4:
                      AbstractCodeEditorExtension.DAaqYKWlED0CQYr4osag((object) str1);
                      num3 = 10;
                      continue;
                    case 5:
                      if (AbstractCodeEditorExtension.OxMlhXWlfLMoAsnaUT1Y((object) current) != ScriptSourceType.Project)
                      {
                        num3 = 7;
                        continue;
                      }
                      obj = AbstractCodeEditorExtension.E9DSw5WlWUDKNZx4XRcw(-1822890472 ^ -1822763698);
                      break;
                    case 6:
                      path = (string) AbstractCodeEditorExtension.x2FoI8WlCUIL7Uewnnou(projectFolderPath, (object) ((string) AbstractCodeEditorExtension.baYZmeWlQUoZE39nWrS2((object) current) + str2));
                      num3 = 12;
                      continue;
                    case 7:
                      obj = AbstractCodeEditorExtension.E9DSw5WlWUDKNZx4XRcw(381945751 ^ 1158627804 ^ 1405771525);
                      break;
                    case 8:
                    case 14:
                      AbstractCodeEditorExtension.PZeD9kWlZU6V09dx2tP8((object) path, (object) current.Content);
                      num3 = 2;
                      continue;
                    case 9:
                      AbstractCodeEditorExtension.Iix7EEWl84fVQ6ilN2hg((object) path, FileAttributes.Normal);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
                      continue;
                    case 10:
                      if (!File.Exists(path))
                      {
                        num3 = 14;
                        continue;
                      }
                      goto case 9;
                    case 11:
                      goto label_5;
                    case 12:
                      str1 = (string) AbstractCodeEditorExtension.uvJ7tBWlvf8oyQW37cAN((object) path);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 1;
                      continue;
                    case 13:
                      goto label_12;
                    default:
                      File.Delete(path);
                      num3 = 8;
                      continue;
                  }
                  str2 = (string) obj;
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 6;
                }
label_13:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 11 : 11;
                goto label_8;
label_24:
                current = enumerator2.Current;
                num3 = 5;
                goto label_8;
              }
              finally
              {
                int num4;
                if (enumerator2 == null)
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 0;
                else
                  goto label_31;
label_30:
                switch (num4)
                {
                  case 1:
                  case 2:
                }
label_31:
                enumerator2.Dispose();
                num4 = 2;
                goto label_30;
              }
          }
        }
label_3:
        AbstractCodeEditorExtension.DAaqYKWlED0CQYr4osag(projectFolderPath);
        num1 = 5;
      }
label_54:
      return;
label_35:
      try
      {
label_44:
        if (AbstractCodeEditorExtension.DdaYLBWluW0HaiuVOi5Y((object) enumerator1))
          goto label_42;
        else
          goto label_45;
label_36:
        IScriptReference current;
        string path;
        int num5;
        while (true)
        {
          switch (num5)
          {
            case 1:
              AbstractCodeEditorExtension.d775vEWlRrPmUnOWxNhS((object) Path.ChangeExtension(path, (string) AbstractCodeEditorExtension.E9DSw5WlWUDKNZx4XRcw(1218962250 ^ 1218931972)), (object) current.DocumentationRaw);
              num5 = 4;
              continue;
            case 2:
              File.WriteAllBytes(path, current.AssemblyRaw);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 4 : 8;
              continue;
            case 3:
              if (AbstractCodeEditorExtension.I6yDL3WlIHEkCJlT5dNY((object) current) != null)
              {
                num5 = 6;
                continue;
              }
              goto label_44;
            case 5:
              goto label_42;
            case 6:
              path = Path.Combine((string) projectFolderPath, (string) AbstractCodeEditorExtension.Ut2BLbWlSVLWXRkulg42(AbstractCodeEditorExtension.upIpOpWlVJR83LBgMBLt((object) current), AbstractCodeEditorExtension.E9DSw5WlWUDKNZx4XRcw(-2138958856 ^ -2138876094)));
              num5 = 2;
              continue;
            case 7:
              goto label_49;
            case 8:
              if (current.DocumentationRaw != null)
              {
                num5 = 9;
                continue;
              }
              goto label_44;
            case 9:
              if (AbstractCodeEditorExtension.vqwniqWliB4vbiEM65AD((object) current).Length == 0)
              {
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
                continue;
              }
              goto case 1;
            default:
              goto label_44;
          }
        }
label_49:
        return;
label_42:
        current = enumerator1.Current;
        num5 = 3;
        goto label_36;
label_45:
        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 7 : 5;
        goto label_36;
      }
      finally
      {
        if (enumerator1 != null)
        {
          int num6 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
            num6 = 1;
          while (true)
          {
            switch (num6)
            {
              case 1:
                AbstractCodeEditorExtension.oq1b2pWlqHxuDSuRF748((object) enumerator1);
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
                continue;
              default:
                goto label_56;
            }
          }
        }
label_56:;
      }
    }

    private static string GetProjectFolderPath(object projectName, CodeType codeType)
    {
      int num = 2;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!AbstractCodeEditorExtension.ExSr1nWlGE4FOxmWsORJ((object) str))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 3 : 3;
              continue;
            }
            goto label_2;
          case 2:
            str = Path.Combine((string) AbstractCodeEditorExtension.qwB5eTWlKDP4QaUQjaIn(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408979920));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 1 : 1;
            continue;
          case 3:
            Directory.CreateDirectory(str);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return Path.Combine(str, (string) AbstractCodeEditorExtension.QN3dO9WlTMZK646MxlAs(AbstractCodeEditorExtension.E9DSw5WlWUDKNZx4XRcw(-218496594 ^ -218614514), projectName, (object) codeType, (object) AbstractCodeEditorExtension.aUuWkjWlXtliP4PJpfSI()));
    }

    private static byte[] DocumentationRaw(object modelsMetadata)
    {
      int num = 3;
      string path;
      object obj;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!AbstractCodeEditorExtension.sk81cyWl3KFTd2c0G00U((object) path))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 3 : 8;
              continue;
            }
            goto label_2;
          case 2:
            if (AbstractCodeEditorExtension.compiledBaseDir != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 12 : 9;
              continue;
            }
            goto case 4;
          case 3:
            if (!AbstractCodeEditorExtension.K8JCTbWlkNUH0QYY4B1x(AbstractCodeEditorExtension.xhmcGHWlBfGUTkryo2gU(modelsMetadata), AbstractCodeEditorExtension.E9DSw5WlWUDKNZx4XRcw(-1710575414 ^ -1710572828)))
            {
              num = 2;
              continue;
            }
            goto case 10;
          case 4:
            AbstractCodeEditorExtension.compiledBaseDir = Path.Combine((string) AbstractCodeEditorExtension.MOTOKUWleemFMlTKAPKK(AbstractCodeEditorExtension.EWToDcWl2jtSSMWfwg9Z()), (string) AbstractCodeEditorExtension.E9DSw5WlWUDKNZx4XRcw(-70007027 ^ -70022545));
            num = 11;
            continue;
          case 5:
            goto label_15;
          case 6:
            goto label_14;
          case 7:
            goto label_16;
          case 8:
            path = Path.Combine(AbstractCodeEditorExtension.compiledBaseDir, (string) AbstractCodeEditorExtension.E9DSw5WlWUDKNZx4XRcw(-1837662597 ^ -1837806951));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
            continue;
          case 9:
            goto label_2;
          case 10:
            obj = AbstractCodeEditorExtension.MuFdd5WlnTQse0OnylKx(modelsMetadata);
            if (obj == null)
            {
              num = 7;
              continue;
            }
            goto label_17;
          case 11:
          case 12:
            path = (string) AbstractCodeEditorExtension.JPIiHSWlNTXimMAqBHKV((object) AbstractCodeEditorExtension.compiledBaseDir, AbstractCodeEditorExtension.M4TcV7Wl1jtmWxak3iQS(AbstractCodeEditorExtension.uTSUGLWlPIojTOhjwvSR()), AbstractCodeEditorExtension.E9DSw5WlWUDKNZx4XRcw(-2099751081 ^ -2099616843));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 0;
            continue;
          default:
            if (!File.Exists(path))
            {
              num = 5;
              continue;
            }
            goto label_14;
        }
      }
label_2:
      return (byte[]) AbstractCodeEditorExtension.VehgflWlpCoClBw06I27((object) path);
label_14:
      return (byte[]) AbstractCodeEditorExtension.VehgflWlpCoClBw06I27((object) path);
label_15:
      return (byte[]) null;
label_16:
      return (byte[]) null;
label_17:
      return (byte[]) AbstractCodeEditorExtension.SujF9hWlOdPaLkJ7mI5i(obj);
    }

    protected AbstractCodeEditorExtension()
    {
      AbstractCodeEditorExtension.zWMhpkWlaYCrUVP3cMZi();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static AbstractCodeEditorExtension()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            AbstractCodeEditorExtension.zWMhpkWlaYCrUVP3cMZi();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            AbstractCodeEditorExtension.DefaultElmaReferences = new string[2]
            {
              (string) AbstractCodeEditorExtension.E9DSw5WlWUDKNZx4XRcw(-688192331 - 435440695 ^ -1123637662),
              (string) AbstractCodeEditorExtension.E9DSw5WlWUDKNZx4XRcw(-882126494 ^ -882200840)
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 2 : 2;
            continue;
          default:
            AbstractCodeEditorExtension.DefaultGlobalReferences = new string[13]
            {
              (string) AbstractCodeEditorExtension.E9DSw5WlWUDKNZx4XRcw(-812025778 ^ -812058596),
              (string) AbstractCodeEditorExtension.E9DSw5WlWUDKNZx4XRcw(864270449 << 6 ^ -521393824),
              (string) AbstractCodeEditorExtension.E9DSw5WlWUDKNZx4XRcw(322893104 - -1992822529 ^ -1979315601),
              (string) AbstractCodeEditorExtension.E9DSw5WlWUDKNZx4XRcw(95909607 + 343705423 ^ 439517678),
              (string) AbstractCodeEditorExtension.E9DSw5WlWUDKNZx4XRcw(1242972401 >> 4 ^ 77653033),
              (string) AbstractCodeEditorExtension.E9DSw5WlWUDKNZx4XRcw(1994213607 >> 4 ^ 124562224),
              (string) AbstractCodeEditorExtension.E9DSw5WlWUDKNZx4XRcw(-398663332 ^ -398535578),
              (string) AbstractCodeEditorExtension.E9DSw5WlWUDKNZx4XRcw(1461825605 - 1531863589 ^ -70157446),
              (string) AbstractCodeEditorExtension.E9DSw5WlWUDKNZx4XRcw(-688192331 - 435440695 ^ -1123600252),
              (string) AbstractCodeEditorExtension.E9DSw5WlWUDKNZx4XRcw(1304605005 ^ 1304637853),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360298603),
              (string) AbstractCodeEditorExtension.E9DSw5WlWUDKNZx4XRcw(1819636893 << 3 ^ 1672094822),
              (string) AbstractCodeEditorExtension.E9DSw5WlWUDKNZx4XRcw(1149433385 + 173655049 ^ 1323121290)
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 3 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static object TqkbWvWdY5B5haFdDkye([In] object obj0) => (object) ((IOmniSharpWorker) obj0).CompletionLibsPath;

    internal static bool ysWER0WdLmtSfF5rhhtI([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static bool qBMd9uWd5mwGjFxbym0R() => AbstractCodeEditorExtension.jWcJ4kWdg7oA9iLbdB7S == null;

    internal static AbstractCodeEditorExtension WdpgDJWdj3b3y0aC13SY() => AbstractCodeEditorExtension.jWcJ4kWdg7oA9iLbdB7S;

    internal static object roiMM4WdUFvmaJrpIHsh([In] object obj0) => (object) ((IOmniSharpWorker) obj0).ClientCompletionLibsPath;

    internal static object gnu5J9WdsFcda3jnrjhE() => (object) CSharpParseOptions.Default;

    internal static object wj73NaWdcGy7JivqSQKu([In] object obj0, [In] LanguageVersion obj1) => (object) ((CSharpParseOptions) obj0).WithLanguageVersion(obj1);

    internal static object HvQ0G9WdzJ0MHCTnMrde([In] object obj0) => (object) ((BaseMethodDeclarationSyntax) obj0).Body;

    internal static int OtQo8TWlFpyrbBLra71Y([In] object obj0) => ((SyntaxNode) obj0).SpanStart;

    internal static object xhmcGHWlBfGUTkryo2gU([In] object obj0) => (object) ((AssemblyModelsMetadata) obj0).Name;

    internal static object E9DSw5WlWUDKNZx4XRcw(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object NZQ8aYWlolFT5OxNBMMZ([In] object obj0) => (object) ((AssemblyModelsMetadata) obj0).AssemblyRawStream;

    internal static object f6KnkZWlbqLBrEVCZQac([In] object obj0) => (object) AbstractCodeEditorExtension.DocumentationRaw(obj0);

    internal static object JtZIUQWlhbcaHmDD2fsJ([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static bool ExSr1nWlGE4FOxmWsORJ([In] object obj0) => Directory.Exists((string) obj0);

    internal static object DAaqYKWlED0CQYr4osag([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

    internal static ScriptSourceType OxMlhXWlfLMoAsnaUT1Y([In] object obj0) => ((IScriptSource) obj0).Type;

    internal static object baYZmeWlQUoZE39nWrS2([In] object obj0) => (object) ((IScriptSource) obj0).Name;

    internal static object x2FoI8WlCUIL7Uewnnou([In] object obj0, [In] object obj1) => (object) AbstractCodeEditorExtension.GetSourceFilePath((string) obj0, (string) obj1);

    internal static object uvJ7tBWlvf8oyQW37cAN([In] object obj0) => (object) Path.GetDirectoryName((string) obj0);

    internal static void Iix7EEWl84fVQ6ilN2hg([In] object obj0, [In] FileAttributes obj1) => File.SetAttributes((string) obj0, obj1);

    internal static void PZeD9kWlZU6V09dx2tP8([In] object obj0, [In] object obj1) => File.WriteAllText((string) obj0, (string) obj1);

    internal static bool DdaYLBWluW0HaiuVOi5Y([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static object I6yDL3WlIHEkCJlT5dNY([In] object obj0) => (object) ((IScriptReference) obj0).AssemblyRaw;

    internal static object upIpOpWlVJR83LBgMBLt([In] object obj0) => (object) ((IScriptReference) obj0).Name;

    internal static object Ut2BLbWlSVLWXRkulg42([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object vqwniqWliB4vbiEM65AD([In] object obj0) => (object) ((IScriptReference) obj0).DocumentationRaw;

    internal static void d775vEWlRrPmUnOWxNhS([In] object obj0, [In] object obj1) => File.WriteAllBytes((string) obj0, (byte[]) obj1);

    internal static void oq1b2pWlqHxuDSuRF748([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object qwB5eTWlKDP4QaUQjaIn() => (object) IOExtensions.GetTempPath();

    internal static DateTime aUuWkjWlXtliP4PJpfSI() => DateTime.Now;

    internal static object QN3dO9WlTMZK646MxlAs(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static bool K8JCTbWlkNUH0QYY4B1x([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static object MuFdd5WlnTQse0OnylKx([In] object obj0) => (object) ((AssemblyModelsMetadata) obj0).DocumentationRawStream;

    internal static object SujF9hWlOdPaLkJ7mI5i([In] object obj0) => (object) ((MemoryStream) obj0).ToArray();

    internal static object EWToDcWl2jtSSMWfwg9Z() => (object) ComponentManager.Current;

    internal static object MOTOKUWleemFMlTKAPKK([In] object obj0) => (object) ((ComponentManager) obj0).WorkDirectory;

    internal static object uTSUGLWlPIojTOhjwvSR() => (object) CultureInfo.CurrentCulture;

    internal static object M4TcV7Wl1jtmWxak3iQS([In] object obj0) => (object) ((CultureInfo) obj0).Name;

    internal static object JPIiHSWlNTXimMAqBHKV([In] object obj0, [In] object obj1, [In] object obj2) => (object) Path.Combine((string) obj0, (string) obj1, (string) obj2);

    internal static bool sk81cyWl3KFTd2c0G00U([In] object obj0) => File.Exists((string) obj0);

    internal static object VehgflWlpCoClBw06I27([In] object obj0) => (object) File.ReadAllBytes((string) obj0);

    internal static void zWMhpkWlaYCrUVP3cMZi() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    /// <summary>Помощник по проекту рабочего пространства</summary>
    protected class WorkspaceProjectHelper
    {
      private static AbstractCodeEditorExtension.WorkspaceProjectHelper IGxKoVQsCgByoyBUqK0d;

      /// <summary>Ctor</summary>
      /// <param name="scriptModule">Модуль сценариев</param>
      /// <param name="altProjectName">Альтернативное имя проекта, которое будет иметь приоритет перед стандартным при его наличии</param>
      public WorkspaceProjectHelper(ScriptModule scriptModule, string altProjectName = null)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_6;
            case 2:
              this.ProjectAssemblyName = (string) AbstractCodeEditorExtension.WorkspaceProjectHelper.bTCEtXQsRc8vtoTPZnjE(AbstractCodeEditorExtension.WorkspaceProjectHelper.zClsQvQsSkvN3INaOfr4((object) scriptModule), AbstractCodeEditorExtension.WorkspaceProjectHelper.e1ZVu1QsI6MD5jFEE0NV(1033719030 - 2012070891 ^ -978349105), AbstractCodeEditorExtension.WorkspaceProjectHelper.Ym6Y1GQsiaAx3LYED5dg((object) scriptModule));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 1;
              continue;
            case 3:
              this.ProjectGuid = (string) AbstractCodeEditorExtension.WorkspaceProjectHelper.khIb1SQsVCeYeHGnRgOa((object) AbstractCodeEditorExtension.WorkspaceProjectHelper.LFTLExQsuwxteq3ul6Q1((object) scriptModule).ToString((string) AbstractCodeEditorExtension.WorkspaceProjectHelper.e1ZVu1QsI6MD5jFEE0NV(1232639661 >> 3 ^ 154109417)));
              num = 2;
              continue;
            default:
              string str = altProjectName;
              this.CsprojFileName = str == null ? (string) AbstractCodeEditorExtension.WorkspaceProjectHelper.ednbHlQsZFuv8PmUvyuk((object) scriptModule) : str;
              num = 3;
              continue;
          }
        }
label_6:;
      }

      /// <summary>Имя csproj файла проекта (без расширения)</summary>
      public string CsprojFileName { get; }

      /// <summary>Guid проекта</summary>
      public string ProjectGuid { get; }

      /// <summary>Имя сборки проекта</summary>
      public string ProjectAssemblyName { get; }

      /// <summary>Создать исходник проекта (csproj файл)</summary>
      /// <param name="content">Содержимое проекта</param>
      /// <returns>Исходник проекта (csproj файл)</returns>
      public IScriptSource CreateCsprojSource(string content) => (IScriptSource) new ScriptSource(this.CsprojFileName, content, ScriptSourceType.Project);

      internal static object ednbHlQsZFuv8PmUvyuk([In] object obj0) => (object) ((ScriptModule) obj0).ClassName;

      internal static Guid LFTLExQsuwxteq3ul6Q1([In] object obj0) => ((ScriptModule) obj0).Uid;

      internal static object e1ZVu1QsI6MD5jFEE0NV(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object khIb1SQsVCeYeHGnRgOa([In] object obj0) => (object) ((string) obj0).ToUpper();

      internal static object zClsQvQsSkvN3INaOfr4([In] object obj0) => (object) ((ScriptModule) obj0).Namespace;

      internal static object Ym6Y1GQsiaAx3LYED5dg([In] object obj0) => (object) ((ScriptModule) obj0).ModuleName;

      internal static object bTCEtXQsRc8vtoTPZnjE([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

      internal static bool y2DkHRQsvSJYD4PRi6Pw() => AbstractCodeEditorExtension.WorkspaceProjectHelper.IGxKoVQsCgByoyBUqK0d == null;

      internal static AbstractCodeEditorExtension.WorkspaceProjectHelper F8PfBKQs8wIxMtIpvij8() => AbstractCodeEditorExtension.WorkspaceProjectHelper.IGxKoVQsCgByoyBUqK0d;
    }

    private class ScriptReferenceComparer : IEqualityComparer<IScriptReference>
    {
      public static IEqualityComparer<IScriptReference> ByName;
      private static object UWBkSMQsq6oopDGXpZIe;

      public bool Equals(IScriptReference x, IScriptReference y) => AbstractCodeEditorExtension.ScriptReferenceComparer.xbCJCIQskCEAMbZJMkkb(AbstractCodeEditorExtension.ScriptReferenceComparer.xB4h3JQsTdVsNp4prswD((object) x), AbstractCodeEditorExtension.ScriptReferenceComparer.xB4h3JQsTdVsNp4prswD((object) y));

      public int GetHashCode(IScriptReference obj) => AbstractCodeEditorExtension.ScriptReferenceComparer.xB4h3JQsTdVsNp4prswD((object) obj).GetHashCode();

      public ScriptReferenceComparer()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      static ScriptReferenceComparer()
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              AbstractCodeEditorExtension.ScriptReferenceComparer.ByName = (IEqualityComparer<IScriptReference>) new AbstractCodeEditorExtension.ScriptReferenceComparer();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
              continue;
            case 2:
              AbstractCodeEditorExtension.ScriptReferenceComparer.XWhIJPQsnPCMHNcUvGwr();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }

      internal static object xB4h3JQsTdVsNp4prswD([In] object obj0) => (object) ((IScriptReference) obj0).Name;

      internal static bool xbCJCIQskCEAMbZJMkkb([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

      internal static bool PIhHPJQsKwCoCyMM3a4M() => AbstractCodeEditorExtension.ScriptReferenceComparer.UWBkSMQsq6oopDGXpZIe == null;

      internal static AbstractCodeEditorExtension.ScriptReferenceComparer qGfd8FQsXMjQEfMrQxUo() => (AbstractCodeEditorExtension.ScriptReferenceComparer) AbstractCodeEditorExtension.ScriptReferenceComparer.UWBkSMQsq6oopDGXpZIe;

      internal static void XWhIJPQsnPCMHNcUvGwr() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
