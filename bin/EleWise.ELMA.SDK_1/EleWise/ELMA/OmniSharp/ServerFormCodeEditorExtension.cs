// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.OmniSharp.ServerFormCodeEditorExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.OmniSharp.Models;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Scripts;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.OmniSharp
{
  /// <inheritdoc />
  [Component]
  internal sealed class ServerFormCodeEditorExtension : AbstractCodeEditorExtension
  {
    private static ServerFormCodeEditorExtension qc5ZbDWdbwDJcEepPppe;

    /// <inheritdoc />
    public override bool Check(InitWorkspaceRequest request)
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
              goto label_10;
            case 2:
              goto label_4;
            case 3:
              goto label_5;
            case 4:
              if (request == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 3 : 3;
                continue;
              }
              goto label_10;
            case 5:
              if (ServerFormCodeEditorExtension.aABKjFWdQjup1Vd0htOX((object) request) is PortletMetadata)
              {
                num2 = 2;
                continue;
              }
              goto label_3;
            default:
              goto label_3;
          }
        }
label_10:
        if (ServerFormCodeEditorExtension.kW6m9uWdEeAGAv6IIwxZ((object) request) == ServerFormCodeEditorExtension.RIArnZWdfDIyfRaJvTlq((object) this))
          num1 = 5;
        else
          goto label_5;
      }
label_3:
      return ServerFormCodeEditorExtension.aABKjFWdQjup1Vd0htOX((object) request) is PageMetadata;
label_4:
      return true;
label_5:
      return false;
    }

    /// <inheritdoc />
    public override IScriptData GenerateSource(InitWorkspaceRequest request)
    {
      int num1 = 8;
      IList<IScriptSource> sources;
      IList<IScriptReference> assemblies;
      while (true)
      {
        int num2 = num1;
        ScriptModule scriptModuleRequired;
        while (true)
        {
          AbstractCodeEditorExtension.WorkspaceProjectHelper projectHelper;
          FormMetadata metadata;
          NamedMetadata namedMetadata;
          switch (num2)
          {
            case 1:
              goto label_12;
            case 2:
              if (metadata == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 0;
                continue;
              }
              scriptModuleRequired = AbstractCodeEditorExtension.FindScriptModuleRequired((IEnumerable<ScriptModule>) request.ScriptModules, PageScriptModuleType.UID, PortletScriptModuleType.UID);
              num2 = 10;
              continue;
            case 3:
              sources.Add(this.GenerateProjectFile(projectHelper, (IEnumerable<IScriptSource>) sources, (IEnumerable<IScriptReference>) assemblies));
              num2 = 5;
              continue;
            case 4:
              assemblies = this.GetAssemblies(scriptModuleRequired);
              num2 = 6;
              continue;
            case 5:
              goto label_14;
            case 6:
              projectHelper = new AbstractCodeEditorExtension.WorkspaceProjectHelper(scriptModuleRequired);
              num2 = 3;
              continue;
            case 7:
              namedMetadata = request.Metadata;
              break;
            case 8:
              if (request == null)
                goto case 9;
              else
                goto label_9;
            case 9:
              namedMetadata = (NamedMetadata) null;
              break;
            case 10:
              sources = this.GenerateSources(metadata, scriptModuleRequired);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
          metadata = namedMetadata as FormMetadata;
          num2 = 2;
        }
label_3:
        sources.AddRange<IScriptSource>(this.GenerateWebReferencesSources(scriptModuleRequired));
        num1 = 4;
        continue;
label_9:
        num1 = 7;
      }
label_12:
      return (IScriptData) null;
label_14:
      return (IScriptData) new ScriptData((IEnumerable<IScriptSource>) sources, (IEnumerable<IScriptReference>) assemblies);
    }

    /// <inheritdoc />
    protected override ICodeEditorInitData GetCodeEditorInitData(InitWorkspaceRequest request)
    {
      int num = 5;
      ScriptModule scriptModuleRequired;
      AbstractCodeEditorExtension.WorkspaceProjectHelper workspaceProjectHelper;
      FormMetadata formMetadata;
      while (true)
      {
        NamedMetadata namedMetadata;
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            workspaceProjectHelper = new AbstractCodeEditorExtension.WorkspaceProjectHelper(scriptModuleRequired);
            num = 3;
            continue;
          case 3:
            goto label_6;
          case 4:
            namedMetadata = (NamedMetadata) null;
            break;
          case 5:
            if (request == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 4 : 2;
              continue;
            }
            namedMetadata = request.Metadata;
            break;
          default:
            if (formMetadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 1;
              continue;
            }
            scriptModuleRequired = AbstractCodeEditorExtension.FindScriptModuleRequired((IEnumerable<ScriptModule>) request.ScriptModules, PageScriptModuleType.UID, PortletScriptModuleType.UID);
            num = 2;
            continue;
        }
        formMetadata = namedMetadata as FormMetadata;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
      }
label_6:
      CodeEditorInitData codeEditorInitData = new CodeEditorInitData();
      ServerFormCodeEditorExtension.c9a5k1Wdv5edmZ6tPhQJ((object) codeEditorInitData, ServerFormCodeEditorExtension.mJV0LrWdCedDqGF32dhq((object) formMetadata));
      ServerFormCodeEditorExtension.E27o5BWdZcWV3d8k0yFd((object) codeEditorInitData, (object) (formMetadata.Name + (string) ServerFormCodeEditorExtension.iIhMq7Wd82UuSQdhp9Cq(222162814 ^ 222118918)));
      ServerFormCodeEditorExtension.vDtmv6WdI4xuvsG92MgT((object) codeEditorInitData, ServerFormCodeEditorExtension.u5qCeeWduB9MjUHWWnQH((object) request));
      ServerFormCodeEditorExtension.mKIHtSWdSGCaAIjmtYVn((object) codeEditorInitData, ServerFormCodeEditorExtension.W0aC8sWdVGmU3jUhobXo((object) scriptModuleRequired));
      ServerFormCodeEditorExtension.IOJ7v1WdRXE5sbRi7I07((object) codeEditorInitData, ServerFormCodeEditorExtension.swSAD5WdiB25y3yXPlVD((object) workspaceProjectHelper));
      return (ICodeEditorInitData) codeEditorInitData;
label_9:
      return (ICodeEditorInitData) null;
    }

    /// <inheritdoc />
    protected override CodeType CodeType => CodeType.Server;

    private IList<IScriptSource> GenerateSources(FormMetadata metadata, ScriptModule scriptModule)
    {
      using (new MetadataServiceContext((IMetadataService) new ExtendedMetadataService((IMetadataService) this.MetadataRuntimeService, metadata.GetMetadataToRegister())))
      {
        List<IScriptSource> sources = new List<IScriptSource>()
        {
          (IScriptSource) new ScriptSource(ServerFormCodeEditorExtension.GetControllerFileName((object) metadata), scriptModule.SourceCode, ScriptSourceType.Edit)
        };
        foreach (GeneratedFileInfo generatedFileInfo in FormCodeCompiler.CreateGenerator(metadata).Generate())
        {
          if (generatedFileInfo.Type == GeneratedFileType.CS)
          {
            string str = generatedFileInfo.Extension;
            if (str.EndsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70101138)))
              str = str.Substring(0, str.Length - z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488809851).Length);
            sources.Add((IScriptSource) new ScriptSource(metadata.Name + str, Encoding.UTF8.GetString(generatedFileInfo.Data), ScriptSourceType.Additional));
          }
        }
        return (IList<IScriptSource>) sources;
      }
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
      string template = AbstractCodeEditorExtension.GenerateTemplate<ServerComponentCodeEditorExtension>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606796820), (Func<string, string>) (s => (string) ServerFormCodeEditorExtension.\u003C\u003Ec__DisplayClass6_0.J3leZHQUytIYY25MteiC(ServerFormCodeEditorExtension.\u003C\u003Ec__DisplayClass6_0.J3leZHQUytIYY25MteiC(ServerFormCodeEditorExtension.\u003C\u003Ec__DisplayClass6_0.J3leZHQUytIYY25MteiC(ServerFormCodeEditorExtension.\u003C\u003Ec__DisplayClass6_0.J3leZHQUytIYY25MteiC((object) s, ServerFormCodeEditorExtension.\u003C\u003Ec__DisplayClass6_0.v4fvB8QU0HuYdaHPnAmC(1461825605 - 1531863589 ^ -69811298), ServerFormCodeEditorExtension.\u003C\u003Ec__DisplayClass6_0.WySPrcQUmMhAX5F0Uy08((object) projectHelper)), ServerFormCodeEditorExtension.\u003C\u003Ec__DisplayClass6_0.v4fvB8QU0HuYdaHPnAmC(1178210108 ^ 1178567394), (object) projectHelper.ProjectAssemblyName), ServerFormCodeEditorExtension.\u003C\u003Ec__DisplayClass6_0.v4fvB8QU0HuYdaHPnAmC(~1767720452 ^ -1767426053), (object) this.GenerateReferencesSection(references)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -69842671), (object) AbstractCodeEditorExtension.GenerateSourcesSection(sources))));
      return projectHelper.CreateCsprojSource(template);
    }

    private static string GetControllerFileName(object metadata) => string.Join((string) ServerFormCodeEditorExtension.iIhMq7Wd82UuSQdhp9Cq(-1822890472 ^ -1822884644), new string[2]
    {
      (string) ServerFormCodeEditorExtension.EiXJl7WdqpvB3EL1In7R(metadata),
      (string) ServerFormCodeEditorExtension.iIhMq7Wd82UuSQdhp9Cq(-1858887263 ^ -1858925863)
    });

    public ServerFormCodeEditorExtension()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static CodeType kW6m9uWdEeAGAv6IIwxZ([In] object obj0) => ((InitWorkspaceRequest) obj0).CodeType;

    internal static CodeType RIArnZWdfDIyfRaJvTlq([In] object obj0) => ((AbstractCodeEditorExtension) obj0).CodeType;

    internal static object aABKjFWdQjup1Vd0htOX([In] object obj0) => (object) ((InitWorkspaceRequest) obj0).Metadata;

    internal static bool fcyKpBWdhxrUK3jJCokc() => ServerFormCodeEditorExtension.qc5ZbDWdbwDJcEepPppe == null;

    internal static ServerFormCodeEditorExtension pN9oKmWdGQbxl3HWRwxH() => ServerFormCodeEditorExtension.qc5ZbDWdbwDJcEepPppe;

    internal static object mJV0LrWdCedDqGF32dhq([In] object obj0) => (object) ServerFormCodeEditorExtension.GetControllerFileName(obj0);

    internal static void c9a5k1Wdv5edmZ6tPhQJ([In] object obj0, [In] object obj1) => ((CodeEditorInitData) obj0).FileName = (string) obj1;

    internal static object iIhMq7Wd82UuSQdhp9Cq(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void E27o5BWdZcWV3d8k0yFd([In] object obj0, [In] object obj1) => ((CodeEditorInitData) obj0).ClassName = (string) obj1;

    internal static object u5qCeeWduB9MjUHWWnQH([In] object obj0) => (object) ((InitWorkspaceRequest) obj0).MethodName;

    internal static void vDtmv6WdI4xuvsG92MgT([In] object obj0, [In] object obj1) => ((CodeEditorInitData) obj0).MethodName = (string) obj1;

    internal static object W0aC8sWdVGmU3jUhobXo([In] object obj0) => (object) ((ScriptModule) obj0).SourceCode;

    internal static void mKIHtSWdSGCaAIjmtYVn([In] object obj0, [In] object obj1) => ((CodeEditorInitData) obj0).SourceCode = (string) obj1;

    internal static object swSAD5WdiB25y3yXPlVD([In] object obj0) => (object) ((AbstractCodeEditorExtension.WorkspaceProjectHelper) obj0).CsprojFileName;

    internal static void IOJ7v1WdRXE5sbRi7I07([In] object obj0, [In] object obj1) => ((CodeEditorInitData) obj0).ProjectName = (string) obj1;

    internal static object EiXJl7WdqpvB3EL1In7R([In] object obj0) => (object) ((NamedMetadata) obj0).Name;
  }
}
