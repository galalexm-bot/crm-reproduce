// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.OmniSharp.ServerComponentCodeEditorExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.OmniSharp.Models;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Scripts;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.OmniSharp
{
  /// <summary>
  /// Генерация исходников серверного модуля сценариев компонента
  /// </summary>
  internal sealed class ServerComponentCodeEditorExtension : AbstractComponentCodeEditorExtension
  {
    private static ServerComponentCodeEditorExtension CuRCAmWdK3jfLoG3wKWd;

    /// <inheritdoc />
    public override IScriptData GenerateSource(InitWorkspaceRequest request)
    {
      int num1 = 9;
      IList<IScriptSource> sources;
      IList<IScriptReference> assemblies;
      while (true)
      {
        int num2 = num1;
        ScriptModule scriptModuleRequired;
        while (true)
        {
          ComponentMetadata componentMetadata;
          MetadataSourcesProviderArgs args;
          AbstractCodeEditorExtension.WorkspaceProjectHelper projectHelper;
          NamedMetadata namedMetadata;
          switch (num2)
          {
            case 1:
              namedMetadata = (NamedMetadata) null;
              break;
            case 2:
              MetadataSourcesProviderArgs sourcesProviderArgs = new MetadataSourcesProviderArgs();
              ServerComponentCodeEditorExtension.UXonTJWdnOA30hx6hfuP((object) sourcesProviderArgs, (object) ClassSerializationHelper.CloneObjectByXml<ComponentMetadata>(componentMetadata));
              sourcesProviderArgs.ScriptModule = scriptModuleRequired;
              sourcesProviderArgs.GenerationMode = GenerationMode.CodeEditor;
              args = sourcesProviderArgs;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
              continue;
            case 3:
              projectHelper = new AbstractCodeEditorExtension.WorkspaceProjectHelper(scriptModuleRequired);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 4 : 10;
              continue;
            case 4:
              if (componentMetadata != null)
              {
                num2 = 12;
                continue;
              }
              goto label_3;
            case 5:
              goto label_3;
            case 6:
              goto label_7;
            case 7:
              sources.AddRange<IScriptSource>(this.GenerateWebReferencesSources(scriptModuleRequired));
              num2 = 6;
              continue;
            case 8:
              namedMetadata = request.Metadata;
              break;
            case 9:
              if (request != null)
              {
                num2 = 8;
                continue;
              }
              goto case 1;
            case 10:
              sources.Add(this.GenerateProjectFile(projectHelper, (IEnumerable<IScriptSource>) sources, (IEnumerable<IScriptReference>) assemblies));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 11 : 10;
              continue;
            case 11:
              goto label_5;
            case 12:
              scriptModuleRequired = AbstractCodeEditorExtension.FindScriptModuleRequired((IEnumerable<ScriptModule>) request.ScriptModules, ServerComponentCodeEditorExtension.aDe5bDWdkIafQLWnLTHF((object) this));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 2;
              continue;
            default:
              sources = this.GenerateSources(args);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 7 : 1;
              continue;
          }
          componentMetadata = namedMetadata as ComponentMetadata;
          num2 = 4;
        }
label_7:
        assemblies = this.GetAssemblies(scriptModuleRequired);
        num1 = 3;
      }
label_3:
      return (IScriptData) null;
label_5:
      return (IScriptData) new ScriptData((IEnumerable<IScriptSource>) sources, (IEnumerable<IScriptReference>) assemblies);
    }

    /// <inheritdoc />
    protected override Guid ModuleTypeUid => ComponentScriptModuleType.TypeUid;

    /// <inheritdoc />
    protected override CodeType CodeType => CodeType.Server;

    private IList<IScriptSource> GenerateSources(MetadataSourcesProviderArgs args)
    {
      using (MetadataServiceContext.Extend(this.GetExtendMetadata((ComponentMetadata) args.Metadata)))
        return (IList<IScriptSource>) this.ComponentMetadataSourcesService.GetServerSources(args).ToList<IScriptSource>();
    }

    private IScriptSource GenerateProjectFile(
      AbstractCodeEditorExtension.WorkspaceProjectHelper projectHelper,
      IEnumerable<IScriptSource> sources,
      IEnumerable<IScriptReference> references)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      string template = AbstractCodeEditorExtension.GenerateTemplate<ServerComponentCodeEditorExtension>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234164768), (Func<string, string>) (s => (string) ServerComponentCodeEditorExtension.\u003C\u003Ec__DisplayClass6_0.lCEIQZQUrV0oowC1QLdW(ServerComponentCodeEditorExtension.\u003C\u003Ec__DisplayClass6_0.lCEIQZQUrV0oowC1QLdW(ServerComponentCodeEditorExtension.\u003C\u003Ec__DisplayClass6_0.lCEIQZQUrV0oowC1QLdW(ServerComponentCodeEditorExtension.\u003C\u003Ec__DisplayClass6_0.lCEIQZQUrV0oowC1QLdW((object) s, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638761553), ServerComponentCodeEditorExtension.\u003C\u003Ec__DisplayClass6_0.xTkS2MQUlb0pUi4J2uSV((object) projectHelper)), ServerComponentCodeEditorExtension.\u003C\u003Ec__DisplayClass6_0.fEgnYMQUgR258qeXUhlg(-643786247 ^ -643492825), ServerComponentCodeEditorExtension.\u003C\u003Ec__DisplayClass6_0.CcVo4pQU5uxQ3lwfvRas((object) projectHelper)), ServerComponentCodeEditorExtension.\u003C\u003Ec__DisplayClass6_0.fEgnYMQUgR258qeXUhlg(222162814 ^ 221798782), (object) this.GenerateReferencesSection(references)), ServerComponentCodeEditorExtension.\u003C\u003Ec__DisplayClass6_0.fEgnYMQUgR258qeXUhlg(1218962250 ^ 1218604374), (object) AbstractCodeEditorExtension.GenerateSourcesSection(sources))));
      return projectHelper.CreateCsprojSource(template);
    }

    public ServerComponentCodeEditorExtension()
    {
      ServerComponentCodeEditorExtension.wLdZCHWdOSOB9I6m4wsf();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Guid aDe5bDWdkIafQLWnLTHF([In] object obj0) => ((AbstractComponentCodeEditorExtension) obj0).ModuleTypeUid;

    internal static void UXonTJWdnOA30hx6hfuP([In] object obj0, [In] object obj1) => ((MetadataSourcesProviderArgs) obj0).Metadata = (IMetadata) obj1;

    internal static bool R6l1LnWdX5pSFFWJFuEW() => ServerComponentCodeEditorExtension.CuRCAmWdK3jfLoG3wKWd == null;

    internal static ServerComponentCodeEditorExtension PKKWS1WdTrbUnaWK48m0() => ServerComponentCodeEditorExtension.CuRCAmWdK3jfLoG3wKWd;

    internal static void wLdZCHWdOSOB9I6m4wsf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
