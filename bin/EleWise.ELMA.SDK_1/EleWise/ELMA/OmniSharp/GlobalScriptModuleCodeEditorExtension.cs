// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.OmniSharp.GlobalScriptModuleCodeEditorExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.OmniSharp.Models;
using EleWise.ELMA.Scripts.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.OmniSharp
{
  /// <summary>Компонент редактора кода для глобальных модулей</summary>
  [Component]
  internal sealed class GlobalScriptModuleCodeEditorExtension : AbstractCodeEditorExtension
  {
    internal static GlobalScriptModuleCodeEditorExtension Qh2WXtW9TQoF3L4v6COH;

    /// <inheritdoc />
    protected override CodeType CodeType => CodeType.Server;

    /// <inheritdoc />
    public override bool Check(InitWorkspaceRequest request)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(request is GlobalScriptModuleInitWorkspaceRequest workspaceRequest))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return GlobalScriptModuleCodeEditorExtension.hh9dNeW9OiVCm8Wf5EVL((object) workspaceRequest) == GlobalScriptModuleCodeEditorExtension.zXRDCtW92IL8nfXprTpZ((object) this);
label_3:
      return false;
    }

    /// <inheritdoc />
    public override IScriptData GenerateSource(InitWorkspaceRequest request)
    {
      int num1 = 6;
      List<IScriptSource> sources;
      IList<IScriptReference> assemblies;
      while (true)
      {
        int num2 = num1;
        AbstractCodeEditorExtension.WorkspaceProjectHelper projectHelper;
        ScriptModule scriptModuleRequired;
        GlobalScriptModuleInitWorkspaceRequest gsmRequest;
        while (true)
        {
          switch (num2)
          {
            case 1:
              sources.AddRange(this.GenerateWebReferencesSources(scriptModuleRequired));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 3 : 3;
              continue;
            case 2:
              goto label_9;
            case 3:
              assemblies = this.GetAssemblies(scriptModuleRequired);
              num2 = 8;
              continue;
            case 4:
              scriptModuleRequired = AbstractCodeEditorExtension.FindScriptModuleRequired((IEnumerable<ScriptModule>) request.ScriptModules, GlobalScriptModuleType.UID);
              num2 = 9;
              continue;
            case 5:
              if (gsmRequest != null)
              {
                num2 = 4;
                continue;
              }
              goto label_7;
            case 6:
              gsmRequest = request as GlobalScriptModuleInitWorkspaceRequest;
              num2 = 5;
              continue;
            case 7:
              sources.Add(this.GenerateProjectFile(projectHelper, (IEnumerable<IScriptSource>) sources, (IEnumerable<IScriptReference>) assemblies));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 2 : 0;
              continue;
            case 8:
              goto label_4;
            case 9:
              sources = GlobalScriptModuleCodeEditorExtension.GenerateSources((object) gsmRequest);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 1 : 1;
              continue;
            default:
              goto label_7;
          }
        }
label_4:
        projectHelper = this.GetProjectHelper(scriptModuleRequired);
        num1 = 7;
      }
label_7:
      throw new ArgumentException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1597012150 ^ 1597131112), GlobalScriptModuleCodeEditorExtension.tEGSkcW9eXpvmVAyTsP4(-281842504 ^ -281977186), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1643003598)));
label_9:
      return (IScriptData) new ScriptData((IEnumerable<IScriptSource>) sources, (IEnumerable<IScriptReference>) assemblies);
    }

    /// <inheritdoc />
    protected override ICodeEditorInitData GetCodeEditorInitData(InitWorkspaceRequest request)
    {
      int num = 5;
      GlobalScriptModuleInitWorkspaceRequest workspaceRequest;
      GlobalScriptModuleCodeEditorExtension.FindProjectItemResult projectItem;
      ScriptModule scriptModuleRequired;
      AbstractCodeEditorExtension.WorkspaceProjectHelper projectHelper;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (projectItem != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 5 : 6;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          case 3:
            goto label_2;
          case 4:
            if (workspaceRequest != null)
            {
              projectItem = this.FindProjectItem(GlobalScriptModuleCodeEditorExtension.PBfiANW91ne9yIkXIBqt(GlobalScriptModuleCodeEditorExtension.GliNPhW9P4ruATWhDF35((object) workspaceRequest)) as ProjectInfo, GlobalScriptModuleCodeEditorExtension.evXtvmW9NO52MxfmGru1((object) workspaceRequest));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 1 : 1;
              continue;
            }
            num = 3;
            continue;
          case 5:
            workspaceRequest = request as GlobalScriptModuleInitWorkspaceRequest;
            num = 4;
            continue;
          case 6:
            scriptModuleRequired = AbstractCodeEditorExtension.FindScriptModuleRequired((IEnumerable<ScriptModule>) request.ScriptModules, GlobalScriptModuleType.UID);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
            continue;
          case 7:
            goto label_11;
          default:
            projectHelper = this.GetProjectHelper(scriptModuleRequired);
            num = 7;
            continue;
        }
      }
label_2:
      throw new ArgumentException(EleWise.ELMA.SR.T((string) GlobalScriptModuleCodeEditorExtension.tEGSkcW9eXpvmVAyTsP4(-1867198571 ^ -1867055541), GlobalScriptModuleCodeEditorExtension.tEGSkcW9eXpvmVAyTsP4(-1120607109 - 305487170 ^ -1426213601), GlobalScriptModuleCodeEditorExtension.tEGSkcW9eXpvmVAyTsP4(-1334993905 ^ -1334858119)));
label_4:
      throw new Exception((string) GlobalScriptModuleCodeEditorExtension.p3LapPW93QSC5MoA5cJT((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051276242 - 990076387 ^ 61335399)));
label_11:
      CodeEditorInitData codeEditorInitData = new CodeEditorInitData();
      GlobalScriptModuleCodeEditorExtension.t3afscW9pg1rJ4g0sWIq((object) codeEditorInitData, (object) projectItem.Path);
      GlobalScriptModuleCodeEditorExtension.x3Ms2bW9DT3PrDgy1XpY((object) codeEditorInitData, (object) ((ProjectItem) GlobalScriptModuleCodeEditorExtension.XrnUrtW9aqY7btttPC8e((object) projectItem)).Code);
      codeEditorInitData.ProjectName = (string) GlobalScriptModuleCodeEditorExtension.a900wbW9tjVOJodfjuwM((object) projectHelper);
      return (ICodeEditorInitData) codeEditorInitData;
    }

    private AbstractCodeEditorExtension.WorkspaceProjectHelper GetProjectHelper(
      ScriptModule scriptModule)
    {
      return new AbstractCodeEditorExtension.WorkspaceProjectHelper(scriptModule, ((string) GlobalScriptModuleCodeEditorExtension.ATiFNFW9ws844ddAooGK((object) scriptModule)).ToTranslit());
    }

    private GlobalScriptModuleCodeEditorExtension.FindProjectItemResult FindProjectItem(
      ProjectInfo projectInfo,
      Guid projectItemUid)
    {
      return this.FindProjectItem((ProjectFolderItem) projectInfo, projectItemUid, string.Empty);
    }

    private GlobalScriptModuleCodeEditorExtension.FindProjectItemResult FindProjectItem(
      ProjectFolderItem projectFolder,
      Guid projectItemUid,
      string currentPath)
    {
      int num1 = 5;
      ProjectItem projectItem1;
      IEnumerator<ProjectFolderItem> enumerator;
      Guid projectItemUid1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            projectItem1 = projectFolder.Items.FirstOrDefault<ProjectItem>((Func<ProjectItem, bool>) (i => GlobalScriptModuleCodeEditorExtension.\u003C\u003Ec__DisplayClass8_0.YsWHRmQUFGborMmgxRR6(GlobalScriptModuleCodeEditorExtension.\u003C\u003Ec__DisplayClass8_0.P0Re4QQLzj09X0FlRe7v((object) i), projectItemUid1)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 3 : 3;
            continue;
          case 2:
            goto label_8;
          case 3:
            if (projectItem1 != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
              continue;
            }
            enumerator = projectFolder.Items.OfType<ProjectFolderItem>().GetEnumerator();
            num1 = 2;
            continue;
          case 4:
            projectItemUid1 = projectItemUid;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 1;
            continue;
          case 5:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 4 : 3;
            continue;
          case 6:
            goto label_25;
          default:
            goto label_6;
        }
      }
label_6:
      GlobalScriptModuleCodeEditorExtension.FindProjectItemResult projectItem2 = new GlobalScriptModuleCodeEditorExtension.FindProjectItemResult();
      GlobalScriptModuleCodeEditorExtension.jDr9k7W9HBhBgI6Zifmh((object) projectItem2, GlobalScriptModuleCodeEditorExtension.XJSJygW96iquAuqKVqe0((object) currentPath, (object) ((string) GlobalScriptModuleCodeEditorExtension.J2S5wcW94YsJEsypPy0j((object) projectItem1)).ToTranslitIdent()));
      GlobalScriptModuleCodeEditorExtension.YWNR4eW9AkV7A2kCjQHg((object) projectItem2, (object) projectItem1);
      return projectItem2;
label_8:
      GlobalScriptModuleCodeEditorExtension.FindProjectItemResult projectItem3;
      try
      {
label_16:
        if (GlobalScriptModuleCodeEditorExtension.FwWRrFW97QwG01Xpqk1i((object) enumerator))
          goto label_14;
        else
          goto label_17;
label_9:
        GlobalScriptModuleCodeEditorExtension.FindProjectItemResult projectItem4;
        ProjectFolderItem current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              projectItem4 = this.FindProjectItem(current, projectItemUid1, currentPath);
              num2 = 8;
              continue;
            case 2:
              goto label_25;
            case 3:
              projectItem3 = projectItem4;
              num2 = 6;
              continue;
            case 5:
              currentPath = (string) GlobalScriptModuleCodeEditorExtension.XJSJygW96iquAuqKVqe0((object) currentPath, (object) ((string) GlobalScriptModuleCodeEditorExtension.J2S5wcW94YsJEsypPy0j((object) current)).ToTranslitIdent());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 1 : 0;
              continue;
            case 6:
              goto label_26;
            case 7:
              goto label_14;
            case 8:
              if (projectItem4 == null)
              {
                num2 = 4;
                continue;
              }
              goto case 3;
            default:
              goto label_16;
          }
        }
label_14:
        current = enumerator.Current;
        num2 = 5;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
        {
          num2 = 0;
          goto label_9;
        }
        else
          goto label_9;
label_17:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 2 : 0;
        goto label_9;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 1;
        else
          goto label_22;
label_21:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_22:
        GlobalScriptModuleCodeEditorExtension.IRhfqEW9xeHIi5VZgmGT((object) enumerator);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0)
        {
          num3 = 0;
          goto label_21;
        }
        else
          goto label_21;
      }
label_26:
      return projectItem3;
label_25:
      return (GlobalScriptModuleCodeEditorExtension.FindProjectItemResult) null;
    }

    private static List<IScriptSource> GenerateSources(object gsmRequest)
    {
      GlobalScriptModuleInitWorkspaceRequest gsmRequest1 = (GlobalScriptModuleInitWorkspaceRequest) gsmRequest;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return ((IEnumerable<IScriptSource>) GlobalScriptModuleCodeEditorExtension.EnumerateProjectItems((object) (gsmRequest1.GlobalScriptModule.Items as ProjectInfo)).Select<GlobalScriptModuleCodeEditorExtension.FindProjectItemResult, ScriptSource>((Func<GlobalScriptModuleCodeEditorExtension.FindProjectItemResult, ScriptSource>) (item => new ScriptSource((string) GlobalScriptModuleCodeEditorExtension.\u003C\u003Ec__DisplayClass9_0.E7nOAkQUhF19CW6VEcTN((object) item), item.ProjectItem.Code, GlobalScriptModuleCodeEditorExtension.\u003C\u003Ec__DisplayClass9_0.f0TFV2QUEmfIrvp2CRE5(GlobalScriptModuleCodeEditorExtension.\u003C\u003Ec__DisplayClass9_0.UZOjpnQUGYlRRTcDNLkc((object) item)) == gsmRequest1.ProjectItemUid ? ScriptSourceType.Edit : ScriptSourceType.Additional)))).ToList<IScriptSource>();
    }

    private static IEnumerable<GlobalScriptModuleCodeEditorExtension.FindProjectItemResult> EnumerateProjectItems(
      object projectInfo)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<GlobalScriptModuleCodeEditorExtension.FindProjectItemResult>) new GlobalScriptModuleCodeEditorExtension.\u003CEnumerateProjectItems\u003Ed__10(-2)
      {
        \u003C\u003E3__projectInfo = (ProjectInfo) projectInfo
      };
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
      string template = AbstractCodeEditorExtension.GenerateTemplate<GlobalScriptModuleCodeEditorExtension>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397409832), (Func<string, string>) (s => (string) GlobalScriptModuleCodeEditorExtension.\u003C\u003Ec__DisplayClass11_0.fS3hgfQUOfYtat2SCYKH(GlobalScriptModuleCodeEditorExtension.\u003C\u003Ec__DisplayClass11_0.fS3hgfQUOfYtat2SCYKH((object) ((string) GlobalScriptModuleCodeEditorExtension.\u003C\u003Ec__DisplayClass11_0.fS3hgfQUOfYtat2SCYKH((object) s, GlobalScriptModuleCodeEditorExtension.\u003C\u003Ec__DisplayClass11_0.ICNwBsQUk8P0AlPRa5Of(132912447 ^ 132749441), GlobalScriptModuleCodeEditorExtension.\u003C\u003Ec__DisplayClass11_0.H0WUEpQUnPvGCpOLuQJ2((object) projectHelper))).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97739384), (string) GlobalScriptModuleCodeEditorExtension.\u003C\u003Ec__DisplayClass11_0.pRFmUNQU2iCYaT1lMoPI((object) projectHelper)), GlobalScriptModuleCodeEditorExtension.\u003C\u003Ec__DisplayClass11_0.ICNwBsQUk8P0AlPRa5Of(~289714581 ^ -289488790), (object) this.GenerateReferencesSection(references)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979680162), (object) AbstractCodeEditorExtension.GenerateSourcesSection(sources))));
      return projectHelper.CreateCsprojSource(template);
    }

    public GlobalScriptModuleCodeEditorExtension()
    {
      GlobalScriptModuleCodeEditorExtension.W5sjJmW90Ghh76GiH7mq();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static CodeType hh9dNeW9OiVCm8Wf5EVL([In] object obj0) => ((InitWorkspaceRequest) obj0).CodeType;

    internal static CodeType zXRDCtW92IL8nfXprTpZ([In] object obj0) => ((AbstractCodeEditorExtension) obj0).CodeType;

    internal static bool vehHoWW9kdlRjrkvnuOR() => GlobalScriptModuleCodeEditorExtension.Qh2WXtW9TQoF3L4v6COH == null;

    internal static GlobalScriptModuleCodeEditorExtension TUUQKUW9nDTQuBlC5ZX8() => GlobalScriptModuleCodeEditorExtension.Qh2WXtW9TQoF3L4v6COH;

    internal static object tEGSkcW9eXpvmVAyTsP4(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object GliNPhW9P4ruATWhDF35([In] object obj0) => (object) ((GlobalScriptModuleInitWorkspaceRequest) obj0).GlobalScriptModule;

    internal static object PBfiANW91ne9yIkXIBqt([In] object obj0) => ((IGlobalScriptModule) obj0).Items;

    internal static Guid evXtvmW9NO52MxfmGru1([In] object obj0) => ((GlobalScriptModuleInitWorkspaceRequest) obj0).ProjectItemUid;

    internal static object p3LapPW93QSC5MoA5cJT([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void t3afscW9pg1rJ4g0sWIq([In] object obj0, [In] object obj1) => ((CodeEditorInitData) obj0).FileName = (string) obj1;

    internal static object XrnUrtW9aqY7btttPC8e([In] object obj0) => (object) ((GlobalScriptModuleCodeEditorExtension.FindProjectItemResult) obj0).ProjectItem;

    internal static void x3Ms2bW9DT3PrDgy1XpY([In] object obj0, [In] object obj1) => ((CodeEditorInitData) obj0).SourceCode = (string) obj1;

    internal static object a900wbW9tjVOJodfjuwM([In] object obj0) => (object) ((AbstractCodeEditorExtension.WorkspaceProjectHelper) obj0).CsprojFileName;

    internal static object ATiFNFW9ws844ddAooGK([In] object obj0) => (object) ((ScriptModule) obj0).Namespace;

    internal static object J2S5wcW94YsJEsypPy0j([In] object obj0) => (object) ((ProjectItem) obj0).Name;

    internal static object XJSJygW96iquAuqKVqe0([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static void jDr9k7W9HBhBgI6Zifmh([In] object obj0, [In] object obj1) => ((GlobalScriptModuleCodeEditorExtension.FindProjectItemResult) obj0).Path = (string) obj1;

    internal static void YWNR4eW9AkV7A2kCjQHg([In] object obj0, [In] object obj1) => ((GlobalScriptModuleCodeEditorExtension.FindProjectItemResult) obj0).ProjectItem = (ProjectItem) obj1;

    internal static bool FwWRrFW97QwG01Xpqk1i([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void IRhfqEW9xeHIi5VZgmGT([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void W5sjJmW90Ghh76GiH7mq() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    private class FindProjectItemResult
    {
      private static object kis3i3QLg7bMPuLYW1YF;

      public string Path
      {
        get => this.\u003CPath\u003Ek__BackingField;
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
                this.\u003CPath\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
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

      public ProjectItem ProjectItem
      {
        get => this.\u003CProjectItem\u003Ek__BackingField;
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
                this.\u003CProjectItem\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
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

      public FindProjectItemResult()
      {
        GlobalScriptModuleCodeEditorExtension.FindProjectItemResult.HwTq21QLYviUV6lFAg7M();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool b6EytBQL5IjKuJTSiCNo() => GlobalScriptModuleCodeEditorExtension.FindProjectItemResult.kis3i3QLg7bMPuLYW1YF == null;

      internal static GlobalScriptModuleCodeEditorExtension.FindProjectItemResult kZ8uFEQLjINRsd2EG0hk() => (GlobalScriptModuleCodeEditorExtension.FindProjectItemResult) GlobalScriptModuleCodeEditorExtension.FindProjectItemResult.kis3i3QLg7bMPuLYW1YF;

      internal static void HwTq21QLYviUV6lFAg7M() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
