// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.OmniSharp.ServerEntityCodeEditorExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.OmniSharp.Models;
using EleWise.ELMA.Scripts.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.OmniSharp
{
  /// <summary>
  /// Генерация исходников серверного модуля сценариев для сущностей
  /// </summary>
  [Component]
  internal sealed class ServerEntityCodeEditorExtension : AbstractCodeEditorExtension
  {
    private readonly IEnumerable<IMetadataTypeInfo> metadataTypeInfo;
    private readonly IMetadataSourceCodeCache metadataSourceCodeCache;
    private readonly IMetadataEditorService metadataEditorService;
    private IList<string> additionalElmaReferences;
    private static ServerEntityCodeEditorExtension OhoTEDWd2aC2TgnWmKB3;

    /// <inheritdoc />
    public ServerEntityCodeEditorExtension(
      IMetadataSourceCodeCache metadataSourceCodeCache,
      IMetadataEditorService metadataEditorService,
      IEnumerable<IMetadataTypeInfo> metadataTypeInfo)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.additionalElmaReferences = (IList<string>) new List<string>();
      this.metadataSourceCodeCache = metadataSourceCodeCache;
      this.metadataEditorService = metadataEditorService;
      this.metadataTypeInfo = metadataTypeInfo;
    }

    /// <inheritdoc />
    public override bool Check(InitWorkspaceRequest request)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (request != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            goto label_4;
          default:
            if (ServerEntityCodeEditorExtension.nyEx7OWd1PYwh1OJiliV((object) request) == ServerEntityCodeEditorExtension.zgroKYWdNmcGyXuqd4by((object) this))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 2 : 1;
              continue;
            }
            goto label_5;
        }
      }
label_4:
      return ServerEntityCodeEditorExtension.CGPsKHWd3btCrYE9hH2Q((object) request) is EntityMetadata;
label_5:
      return false;
    }

    /// <inheritdoc />
    public override IScriptData GenerateSource(InitWorkspaceRequest request)
    {
      int num1 = 6;
      EntityMetadata metadata;
      MetadataServiceContext metadataServiceContext;
      ScriptModule scriptModuleRequired;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          NamedMetadata namedMetadata;
          switch (num2)
          {
            case 1:
              metadataServiceContext = new MetadataServiceContext((IMetadataService) new ExtendedMetadataService((IMetadataService) this.metadataEditorService, (IEnumerable<IMetadata>) metadata.ToEnumerable<EntityMetadata>()));
              num2 = 3;
              continue;
            case 2:
              goto label_6;
            case 3:
              goto label_11;
            case 4:
              namedMetadata = (NamedMetadata) null;
              break;
            case 5:
              namedMetadata = request.Metadata;
              break;
            case 6:
              if (request == null)
                goto case 4;
              else
                goto label_9;
            case 7:
              if (metadata != null)
              {
                num2 = 8;
                continue;
              }
              goto label_6;
            case 8:
              scriptModuleRequired = AbstractCodeEditorExtension.FindScriptModuleRequired((IEnumerable<ScriptModule>) request.ScriptModules, EntityScriptModuleType.UID);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 1;
              continue;
            default:
              goto label_26;
          }
          metadata = namedMetadata as EntityMetadata;
          num2 = 7;
        }
label_9:
        num1 = 5;
      }
label_6:
      return (IScriptData) null;
label_11:
      IScriptData source;
      try
      {
        IList<IScriptSource> sources = this.GenerateSources((ClassMetadata) metadata, scriptModuleRequired);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
          num3 = 0;
        AbstractCodeEditorExtension.WorkspaceProjectHelper projectHelper;
        IList<IScriptReference> assemblies;
        while (true)
        {
          switch (num3)
          {
            case 1:
              this.AddAdditionalElmaReferences((ClassMetadata) metadata);
              num3 = 3;
              continue;
            case 2:
              source = (IScriptData) new ScriptData((IEnumerable<IScriptSource>) sources, (IEnumerable<IScriptReference>) assemblies);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 2 : 6;
              continue;
            case 3:
              assemblies = this.GetAssemblies(scriptModuleRequired);
              num3 = 5;
              continue;
            case 4:
              sources.Add(this.GenerateProjectFile(projectHelper, (IEnumerable<IScriptSource>) sources, (IEnumerable<IScriptReference>) assemblies));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 1 : 2;
              continue;
            case 5:
              projectHelper = new AbstractCodeEditorExtension.WorkspaceProjectHelper(scriptModuleRequired);
              num3 = 4;
              continue;
            case 6:
              goto label_26;
            default:
              sources.AddRange<IScriptSource>(this.GenerateWebReferencesSources(scriptModuleRequired));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 1;
              continue;
          }
        }
      }
      finally
      {
        if (metadataServiceContext != null)
        {
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
            num4 = 0;
          while (true)
          {
            switch (num4)
            {
              case 1:
                goto label_25;
              default:
                ServerEntityCodeEditorExtension.HrpN47WdpQrrC89WdljE((object) metadataServiceContext);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_25:;
      }
label_26:
      return source;
    }

    /// <inheritdoc />
    protected override ICodeEditorInitData GetCodeEditorInitData(InitWorkspaceRequest request)
    {
      int num = 5;
      ScriptModule scriptModuleRequired;
      EntityMetadata metadata;
      AbstractCodeEditorExtension.WorkspaceProjectHelper workspaceProjectHelper;
      while (true)
      {
        NamedMetadata namedMetadata;
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            workspaceProjectHelper = new AbstractCodeEditorExtension.WorkspaceProjectHelper(scriptModuleRequired);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          case 4:
            namedMetadata = (NamedMetadata) null;
            break;
          case 5:
            if (request == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 4 : 4;
              continue;
            }
            namedMetadata = request.Metadata;
            break;
          default:
            if (metadata != null)
            {
              scriptModuleRequired = AbstractCodeEditorExtension.FindScriptModuleRequired((IEnumerable<ScriptModule>) request.ScriptModules, EntityScriptModuleType.UID);
              num = 2;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 3 : 3;
            continue;
        }
        metadata = namedMetadata as EntityMetadata;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
      }
label_2:
      return (ICodeEditorInitData) null;
label_7:
      CodeEditorInitData codeEditorInitData = new CodeEditorInitData();
      ServerEntityCodeEditorExtension.CwINdxWdD1BSaKbmM0VU((object) codeEditorInitData, ServerEntityCodeEditorExtension.c9xKV6WdaMUrpbHxX6qf((object) metadata));
      ServerEntityCodeEditorExtension.CBD3CPWdt84ZwHiCvRyZ((object) codeEditorInitData, (object) ServerEntityCodeEditorExtension.GetClassName((object) metadata));
      ServerEntityCodeEditorExtension.JWZDy3Wd4V7k2AptaY3E((object) codeEditorInitData, ServerEntityCodeEditorExtension.oUDfwsWdwjPYG54l7xoE((object) request));
      ServerEntityCodeEditorExtension.qRfmgPWdHsdsNhiMSnBo((object) codeEditorInitData, ServerEntityCodeEditorExtension.kAjOS1Wd68r4eKEdyhKN((object) scriptModuleRequired));
      ServerEntityCodeEditorExtension.hCHBCRWd7994Zh0dvACN((object) codeEditorInitData, ServerEntityCodeEditorExtension.IVEKb6WdAby8ia3gZdsU((object) workspaceProjectHelper));
      return (ICodeEditorInitData) codeEditorInitData;
    }

    /// <inheritdoc />
    protected override CodeType CodeType => CodeType.Server;

    /// <inheritdoc />
    protected override IEnumerable<string> AdditionalElmaReferences => (IEnumerable<string>) this.additionalElmaReferences;

    /// <inheritdoc />
    protected override List<IScriptReference> GetDynamicAssemblies() => new List<IScriptReference>();

    private IList<IScriptSource> GenerateSources(ClassMetadata metadata, ScriptModule scriptModule)
    {
      metadata = metadata.CastAsRealType<ClassMetadata>();
      Type metadataType = metadata.GetType();
      // ISSUE: reference to a compiler-generated method
      ICodeGenerator instance = (ICodeGenerator) Activator.CreateInstance((this.metadataTypeInfo.FirstOrDefault<IMetadataTypeInfo>((Func<IMetadataTypeInfo, bool>) (m => ServerEntityCodeEditorExtension.\u003C\u003Ec__DisplayClass13_0.rWjkdXQUULpqOGpIKcsI((object) m) == metadataType)) ?? throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475908853), (object) metadataType))).GeneratorType);
      instance.Metadata = (IMetadata) metadata;
      instance.GenerationParams.FileName = metadata.Name + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1642907368);
      instance.GenerationParams.Namespace = metadata.Namespace;
      ICodeGenerator codeGenerator = (ICodeGenerator) new EntityScriptGenerator((IMetadataService) this.MetadataRuntimeService);
      codeGenerator.Metadata = (IMetadata) metadata;
      string content = Encoding.UTF8.GetString(codeGenerator.GenerateMainFile().Data);
      List<IScriptSource> sources = new List<IScriptSource>()
      {
        (IScriptSource) new ScriptSource(ServerEntityCodeEditorExtension.GetScripsFileName((object) metadata), scriptModule.SourceCode, ScriptSourceType.Edit),
        (IScriptSource) new ScriptSource(string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647906574), new string[2]
        {
          metadata.Name,
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(1597012150 ^ 1596983534)
        }), content, ScriptSourceType.Additional)
      };
      foreach (GeneratedFileInfo generatedFileInfo in instance.Generate())
      {
        if (generatedFileInfo.Type == GeneratedFileType.CS)
        {
          string str = generatedFileInfo.Extension;
          if (str.EndsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477203308)))
            str = str.Substring(0, str.Length - z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647972484).Length);
          sources.Add((IScriptSource) new ScriptSource(metadata.Name + str, Encoding.UTF8.GetString(generatedFileInfo.Data), ScriptSourceType.Additional));
        }
      }
      return (IList<IScriptSource>) sources;
    }

    private void AddAdditionalElmaReferences(ClassMetadata metadata)
    {
      int num = 1;
      Type typeByUidOrNull;
      EntityMetadata entityMetadata;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            entityMetadata = (EntityMetadata) ServerEntityCodeEditorExtension.T3pvNQWdxI2oG7JgcktK((object) (EntityMetadata) metadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
            continue;
          case 2:
            if (!(typeByUidOrNull.Assembly != (Assembly) null))
            {
              num = 12;
              continue;
            }
            goto case 9;
          case 3:
            goto label_16;
          case 4:
            if (!ServerEntityCodeEditorExtension.gatdU7WdmwBtwSD8p0aW(typeByUidOrNull, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 11 : 11;
              continue;
            }
            goto case 2;
          case 5:
            str = (string) ServerEntityCodeEditorExtension.B1a9oxWdMm6Fk5Cyn0F4(ServerEntityCodeEditorExtension.W1ehleWdyjl89MImFItK((object) typeByUidOrNull.Assembly));
            num = 10;
            continue;
          case 6:
            this.additionalElmaReferences.Add(str);
            num = 3;
            continue;
          case 7:
            goto label_2;
          case 8:
            typeByUidOrNull = this.MetadataRuntimeService.GetTypeByUidOrNull(ServerEntityCodeEditorExtension.P4FP8MWd0hnJX9RktwOl((object) entityMetadata), false);
            num = 4;
            continue;
          case 9:
            if (ServerEntityCodeEditorExtension.W1ehleWdyjl89MImFItK((object) typeByUidOrNull.Assembly) == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 7 : 3;
              continue;
            }
            goto case 5;
          case 10:
            if (!ServerEntityCodeEditorExtension.FDsUdkWdJj7kK9YT5hfA((object) str))
            {
              num = 6;
              continue;
            }
            goto label_14;
          case 11:
            goto label_20;
          case 12:
            goto label_21;
          default:
            if (entityMetadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 5 : 8;
              continue;
            }
            goto label_3;
        }
      }
label_16:
      return;
label_2:
      return;
label_20:
      return;
label_21:
      return;
label_14:
      return;
label_3:;
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
      string template = AbstractCodeEditorExtension.GenerateTemplate<ServerComponentCodeEditorExtension>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825250806), (Func<string, string>) (s => (string) ServerEntityCodeEditorExtension.\u003C\u003Ec__DisplayClass15_0.wvqM93QsWaRvXID5a4Vw((object) ((string) ServerEntityCodeEditorExtension.\u003C\u003Ec__DisplayClass15_0.wvqM93QsWaRvXID5a4Vw(ServerEntityCodeEditorExtension.\u003C\u003Ec__DisplayClass15_0.wvqM93QsWaRvXID5a4Vw((object) s, ServerEntityCodeEditorExtension.\u003C\u003Ec__DisplayClass15_0.hYeG6GQsFOR0atnyCkea(1052221104 - 768835541 ^ 283218789), ServerEntityCodeEditorExtension.\u003C\u003Ec__DisplayClass15_0.W4lH3PQsBIbPmU99Sgn1((object) projectHelper)), ServerEntityCodeEditorExtension.\u003C\u003Ec__DisplayClass15_0.hYeG6GQsFOR0atnyCkea(~541731958 ^ -542089641), ServerEntityCodeEditorExtension.\u003C\u003Ec__DisplayClass15_0.v6WrulQsocqBdCUdnul6((object) projectHelper))).Replace((string) ServerEntityCodeEditorExtension.\u003C\u003Ec__DisplayClass15_0.hYeG6GQsFOR0atnyCkea(1199946765 ^ 1199583757), this.GenerateReferencesSection(references)), ServerEntityCodeEditorExtension.\u003C\u003Ec__DisplayClass15_0.hYeG6GQsFOR0atnyCkea(-244066886 - -48452443 ^ -195909879), (object) this.GenerateEntitySourcesSection(sources))));
      return projectHelper.CreateCsprojSource(template);
    }

    private string GenerateEntitySourcesSection(IEnumerable<IScriptSource> sources)
    {
      List<IScriptSource> list = sources.ToList<IScriptSource>();
      return string.Join(Environment.NewLine, new string[2]
      {
        AbstractCodeEditorExtension.GenerateSourcesSection((IEnumerable<IScriptSource>) list),
        this.GenerateCacheSourceSection(list)
      });
    }

    private string GenerateCacheSourceSection(List<IScriptSource> sources)
    {
      this.metadataSourceCodeCache.UpdateDiskCache();
      string cacheFolder = this.metadataSourceCodeCache.GetFolderPath(this.CodeType);
      string[] files = Directory.GetFiles(cacheFolder);
      if (files.Length == 0)
        return string.Empty;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      List<string> list = sources.Select<IScriptSource, string>((Func<IScriptSource, string>) (source => (string) ServerEntityCodeEditorExtension.\u003C\u003Ec__DisplayClass17_0.PI9A57QsQ8n9sYKRFGNf((object) cacheFolder, ServerEntityCodeEditorExtension.\u003C\u003Ec__DisplayClass17_0.d4ta32QsffZaJ7mPp3am(ServerEntityCodeEditorExtension.\u003C\u003Ec__DisplayClass17_0.W8jpu6QsEhS5moyaueCR((object) source), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281905674))))).ToList<string>();
      StringBuilder stringBuilder = new StringBuilder();
      foreach (string str in files)
      {
        if (!list.Contains(str))
        {
          stringBuilder.Append(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173742433), (object) str));
          stringBuilder.AppendLine();
        }
      }
      return stringBuilder.ToString();
    }

    private static string GetScripsFileName(object metadata) => (string) ServerEntityCodeEditorExtension.I86JtvWdl7506t0fZt7e((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121154767), (object) new string[2]
    {
      (string) ServerEntityCodeEditorExtension.mSskAfWd9y5Hh6Lfm1pD(metadata),
      (string) ServerEntityCodeEditorExtension.goaPksWddmIvYegXdqM2(694673736 ^ -23604109 ^ -672045531)
    });

    private static string GetClassName(object metadata) => (string) ServerEntityCodeEditorExtension.D9SWygWdrZVf1ysW34oZ((object) ((NamedMetadata) metadata).Name, ServerEntityCodeEditorExtension.goaPksWddmIvYegXdqM2(~210725948 ^ -210648867));

    internal static CodeType nyEx7OWd1PYwh1OJiliV([In] object obj0) => ((InitWorkspaceRequest) obj0).CodeType;

    internal static CodeType zgroKYWdNmcGyXuqd4by([In] object obj0) => ((AbstractCodeEditorExtension) obj0).CodeType;

    internal static object CGPsKHWd3btCrYE9hH2Q([In] object obj0) => (object) ((InitWorkspaceRequest) obj0).Metadata;

    internal static bool lNmCdVWdeJ9UQ0CtxdVC() => ServerEntityCodeEditorExtension.OhoTEDWd2aC2TgnWmKB3 == null;

    internal static ServerEntityCodeEditorExtension Gti5mlWdP94RCOyWbPbH() => ServerEntityCodeEditorExtension.OhoTEDWd2aC2TgnWmKB3;

    internal static void HrpN47WdpQrrC89WdljE([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object c9xKV6WdaMUrpbHxX6qf([In] object obj0) => (object) ServerEntityCodeEditorExtension.GetScripsFileName(obj0);

    internal static void CwINdxWdD1BSaKbmM0VU([In] object obj0, [In] object obj1) => ((CodeEditorInitData) obj0).FileName = (string) obj1;

    internal static void CBD3CPWdt84ZwHiCvRyZ([In] object obj0, [In] object obj1) => ((CodeEditorInitData) obj0).ClassName = (string) obj1;

    internal static object oUDfwsWdwjPYG54l7xoE([In] object obj0) => (object) ((InitWorkspaceRequest) obj0).MethodName;

    internal static void JWZDy3Wd4V7k2AptaY3E([In] object obj0, [In] object obj1) => ((CodeEditorInitData) obj0).MethodName = (string) obj1;

    internal static object kAjOS1Wd68r4eKEdyhKN([In] object obj0) => (object) ((ScriptModule) obj0).SourceCode;

    internal static void qRfmgPWdHsdsNhiMSnBo([In] object obj0, [In] object obj1) => ((CodeEditorInitData) obj0).SourceCode = (string) obj1;

    internal static object IVEKb6WdAby8ia3gZdsU([In] object obj0) => (object) ((AbstractCodeEditorExtension.WorkspaceProjectHelper) obj0).CsprojFileName;

    internal static void hCHBCRWd7994Zh0dvACN([In] object obj0, [In] object obj1) => ((CodeEditorInitData) obj0).ProjectName = (string) obj1;

    internal static object T3pvNQWdxI2oG7JgcktK([In] object obj0) => (object) ((EntityMetadata) obj0).GetBaseMetadata();

    internal static Guid P4FP8MWd0hnJX9RktwOl([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static bool gatdU7WdmwBtwSD8p0aW([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object W1ehleWdyjl89MImFItK([In] object obj0) => (object) ((Assembly) obj0).GetName();

    internal static object B1a9oxWdMm6Fk5Cyn0F4([In] object obj0) => (object) ((AssemblyName) obj0).Name;

    internal static bool FDsUdkWdJj7kK9YT5hfA([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object mSskAfWd9y5Hh6Lfm1pD([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object goaPksWddmIvYegXdqM2(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object I86JtvWdl7506t0fZt7e([In] object obj0, [In] object obj1) => (object) string.Join((string) obj0, (string[]) obj1);

    internal static object D9SWygWdrZVf1ysW34oZ([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);
  }
}
