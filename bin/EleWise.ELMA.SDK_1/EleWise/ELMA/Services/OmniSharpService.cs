// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.OmniSharpService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.OmniSharp;
using EleWise.ELMA.Scripts;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Services
{
  /// <inheritdoc />
  [Service]
  internal sealed class OmniSharpService : IOmniSharpService
  {
    private readonly IOmniSharpWorker omniSharpWorker;
    private readonly IEnumerable<ICodeEditorExtension> codeEditorExtensions;
    private readonly IGlobalModulesReferenceService globalModulesReferenceService;
    private static OmniSharpService OWwA05BtnabW1qaa6L0d;

    /// <summary>Ctor</summary>
    /// <param name="omniSharpWorker">Элемент для работы с сервером OmniSharp</param>
    /// <param name="codeEditorExtensions">Компоненты точки расширения генерации исходников для сервера автокомплита</param>
    /// <param name="globalModulesReferenceService">Сервис для добавления ссылок на глобальный модуль</param>
    public OmniSharpService(
      IOmniSharpWorker omniSharpWorker,
      IEnumerable<ICodeEditorExtension> codeEditorExtensions,
      IGlobalModulesReferenceService globalModulesReferenceService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.omniSharpWorker = omniSharpWorker;
      this.codeEditorExtensions = codeEditorExtensions;
      this.globalModulesReferenceService = globalModulesReferenceService;
    }

    /// <inheritdoc />
    public void Start(bool needRestart)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            OmniSharpService.EST8tGBtelMjHpVTffOV((object) this.omniSharpWorker, needRestart);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    public void Stop()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            OmniSharpService.H1rvMuBtPpILt4RBEwsu((object) this.omniSharpWorker);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    public Task<OmniSharpItem> InitWorkspace(InitWorkspaceRequest request)
    {
      this.omniSharpWorker.Start(false);
      if (request == null)
        return Task.FromResult<OmniSharpItem>((OmniSharpItem) null);
      // ISSUE: reference to a compiler-generated method
      ICodeEditorExtension codeEditorExtension = this.codeEditorExtensions.FirstOrDefault<ICodeEditorExtension>((Func<ICodeEditorExtension, bool>) (q => OmniSharpService.\u003C\u003Ec__DisplayClass6_0.jAWmE4QXkVXJjTIGhymb((object) q, (object) request)));
      return codeEditorExtension == null ? Task.FromResult<OmniSharpItem>((OmniSharpItem) null) : codeEditorExtension.InitWorkspace(request);
    }

    /// <inheritdoc />
    public Task<string> GetResult(OmniSharpRequest request) => this.omniSharpWorker.GetResult(request.Command, request.PostData, request.FileName);

    /// <inheritdoc />
    public Task AddReferences(AddReferencesRequest request)
    {
      int num1 = 4;
      List<string> webReferencesPath;
      List<string> assembliesPathList;
      while (true)
      {
        int num2 = num1;
        string str1;
        WebReferenceInfo[] webReferenceInfoArray;
        int index;
        WebReferenceInfo webReferenceInfo;
        string sourceFileName;
        string destFileName;
        string str2;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 16:
              if (index >= webReferenceInfoArray.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 6;
                continue;
              }
              goto case 7;
            case 2:
              str1 = (string) OmniSharpService.I5ccSOBtphTbP50IREMo(OmniSharpService.s1Nkp6Bt3eeZOgj1KacL((object) request));
              num2 = 14;
              continue;
            case 3:
              goto label_21;
            case 4:
              if (request == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 3 : 1;
                continue;
              }
              assembliesPathList = this.GetAssembliesPathList((string[]) OmniSharpService.QmWHjYBtNoY14rWL0PSg((object) request), request.GlobalModulesUids);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 2 : 2;
              continue;
            case 5:
              File.Copy(sourceFileName, destFileName, true);
              num2 = 19;
              continue;
            case 6:
              if (OmniSharpService.EZ4aARBtAZtUo9y24y4c((object) assembliesPathList) <= 0)
              {
                num2 = 13;
                continue;
              }
              goto label_19;
            case 7:
              webReferenceInfo = webReferenceInfoArray[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 10 : 10;
              continue;
            case 8:
              goto label_11;
            case 9:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 0;
              continue;
            case 10:
              sourceFileName = (string) OmniSharpService.S7kYufBtD13YefbqRNos((object) webReferenceInfo);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
              continue;
            case 11:
              destFileName = (string) OmniSharpService.SYfHtQBtHH7WhbV8dfxe((object) str1, (object) str2);
              num2 = 5;
              continue;
            case 12:
              webReferenceInfoArray = (WebReferenceInfo[]) OmniSharpService.tiI8vdBta464x8HkQ0S4((object) request);
              num2 = 9;
              continue;
            case 13:
              if (OmniSharpService.EZ4aARBtAZtUo9y24y4c((object) webReferencesPath) > 0)
              {
                num2 = 15;
                continue;
              }
              goto label_20;
            case 14:
              webReferencesPath = new List<string>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 12 : 11;
              continue;
            case 15:
              goto label_19;
            case 17:
            case 18:
              ++index;
              num2 = 16;
              continue;
            case 19:
              webReferencesPath.Add(destFileName);
              num2 = 17;
              continue;
            default:
              if (!OmniSharpService.o45JIIBttxmwoNgtBwHs((object) sourceFileName))
              {
                num2 = 18;
                continue;
              }
              goto label_11;
          }
        }
label_11:
        str2 = (string) OmniSharpService.VI0ED8Bt6ZJLqkFpvmD5(OmniSharpService.m9BDPEBtwVcSK7yUwawR((object) webReferenceInfo), OmniSharpService.hB2pKJBt4FiMB9JXuf04(-643786247 ^ -643727177));
        num1 = 11;
      }
label_19:
      return this.omniSharpWorker.AddReferences((IEnumerable<string>) assembliesPathList, (IEnumerable<string>) webReferencesPath, (string) OmniSharpService.s1Nkp6Bt3eeZOgj1KacL((object) request), (string) OmniSharpService.DMbRtiBt7UTQVJmQkD3s((object) request));
label_20:
      return (Task) OmniSharpService.bfKh0QBt1ubDHgc3r0RK();
label_21:
      return (Task) OmniSharpService.bfKh0QBt1ubDHgc3r0RK();
    }

    private string[] AssemblySearchPaths => new string[2]
    {
      (string) OmniSharpService.dotiGuBtx91VaoYQx7AR((object) this.omniSharpWorker),
      (string) OmniSharpService.xrIHBIBt0pipnDlBoWfW()
    };

    private string GetAssemblyPath(string assemblyName)
    {
      int num = 1;
      string fileName;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            fileName = (string) OmniSharpService.VI0ED8Bt6ZJLqkFpvmD5((object) assemblyName, OmniSharpService.hB2pKJBt4FiMB9JXuf04(--1360331293 ^ 1360283303));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 1 : 2;
            continue;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      return ((IEnumerable<string>) this.AssemblySearchPaths).Select<string, string>((Func<string, string>) (path => (string) OmniSharpService.\u003C\u003Ec__DisplayClass11_0.PpJRvNQXPZcfQK8C6ycE((object) path, (object) fileName))).FirstOrDefault<string>(new Func<string, bool>(File.Exists));
    }

    /// <inheritdoc />
    public Task RemoveReferences(RemoveReferencesRequest request)
    {
      int num1 = 5;
      List<string> list;
      List<string> assembliesPathList;
      while (true)
      {
        int num2 = num1;
        string projectFolderPath;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_7;
            case 2:
              assembliesPathList = this.GetAssembliesPathList((string[]) OmniSharpService.WxPMhsBtmtdyMwgsUIOC((object) request), request.GlobalModulesUids);
              num2 = 6;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              list = ((IEnumerable<string>) OmniSharpService.lVQGm4BtMMfGACKEyJhN((object) request)).Select<string, string>((Func<string, string>) (webRef => (string) OmniSharpService.\u003C\u003Ec__DisplayClass12_0.hZBlAhQXtvasQWjE4a0o((object) projectFolderPath, OmniSharpService.\u003C\u003Ec__DisplayClass12_0.Juth2MQXDVJ5G5iN9Wlo((object) webRef, OmniSharpService.\u003C\u003Ec__DisplayClass12_0.zCj6GqQXaCe2l0JroGnp(-867826612 ^ -867754750))))).ToList<string>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
              continue;
            case 4:
              if (request != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 2 : 2;
                continue;
              }
              goto label_7;
            case 5:
              goto label_5;
            case 6:
              projectFolderPath = (string) OmniSharpService.I5ccSOBtphTbP50IREMo(OmniSharpService.Uno8P3BtydYTdiNJ0I2W((object) request));
              num2 = 3;
              continue;
            default:
              goto label_6;
          }
        }
label_5:
        num1 = 4;
      }
label_6:
      return this.omniSharpWorker.RemoveReferences((IEnumerable<string>) assembliesPathList, (IEnumerable<string>) list, (string) OmniSharpService.Uno8P3BtydYTdiNJ0I2W((object) request), (string) OmniSharpService.Fhfl55BtJnJMJuXq7nXo((object) request));
label_7:
      return (Task) OmniSharpService.bfKh0QBt1ubDHgc3r0RK();
    }

    private List<string> GetAssembliesPathList(string[] assemblyNames, Guid[] globalModulesUids) => ((IEnumerable<string>) assemblyNames).Select<string, string>(new Func<string, string>(this.GetAssemblyPath)).Concat<string>(((IEnumerable<Guid>) globalModulesUids).Select<Guid, string>(new Func<Guid, string>(this.globalModulesReferenceService.CreateGlobalModuleAssembly))).Where<string>((Func<string, bool>) (path => path != null)).ToList<string>();

    internal static void EST8tGBtelMjHpVTffOV([In] object obj0, bool needRestart) => ((IOmniSharpWorker) obj0).Start(needRestart);

    internal static bool VqTGtwBtOcw9nZottPkH() => OmniSharpService.OWwA05BtnabW1qaa6L0d == null;

    internal static OmniSharpService GwuYxOBt2yYWxIBIJq1G() => OmniSharpService.OWwA05BtnabW1qaa6L0d;

    internal static void H1rvMuBtPpILt4RBEwsu([In] object obj0) => ((IOmniSharpWorker) obj0).Stop();

    internal static object bfKh0QBt1ubDHgc3r0RK() => (object) Task.CompletedTask;

    internal static object QmWHjYBtNoY14rWL0PSg([In] object obj0) => (object) ((AddReferencesRequest) obj0).AssemblyNames;

    internal static object s1Nkp6Bt3eeZOgj1KacL([In] object obj0) => (object) ((AddReferencesRequest) obj0).ProjectFileName;

    internal static object I5ccSOBtphTbP50IREMo([In] object obj0) => (object) Path.GetDirectoryName((string) obj0);

    internal static object tiI8vdBta464x8HkQ0S4([In] object obj0) => (object) ((AddReferencesRequest) obj0).WebReferences;

    internal static object S7kYufBtD13YefbqRNos([In] object obj0) => (object) ((WebReferenceInfo) obj0).CodeFilePath;

    internal static bool o45JIIBttxmwoNgtBwHs([In] object obj0) => File.Exists((string) obj0);

    internal static object m9BDPEBtwVcSK7yUwawR([In] object obj0) => (object) ((WebReferenceInfo) obj0).WebReferenceName;

    internal static object hB2pKJBt4FiMB9JXuf04(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object VI0ED8Bt6ZJLqkFpvmD5([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object SYfHtQBtHH7WhbV8dfxe([In] object obj0, [In] object obj1) => (object) AbstractCodeEditorExtension.GetSourceFilePath((string) obj0, (string) obj1);

    internal static int EZ4aARBtAZtUo9y24y4c([In] object obj0) => ((List<string>) obj0).Count;

    internal static object DMbRtiBt7UTQVJmQkD3s([In] object obj0) => (object) ((AddReferencesRequest) obj0).FileName;

    internal static object dotiGuBtx91VaoYQx7AR([In] object obj0) => (object) ((IOmniSharpWorker) obj0).CompletionLibsPath;

    internal static object xrIHBIBt0pipnDlBoWfW() => (object) AssemblyReferenceHelper.GlobalAssemblyLocation;

    internal static object WxPMhsBtmtdyMwgsUIOC([In] object obj0) => (object) ((RemoveReferencesRequest) obj0).AssemblyNames;

    internal static object Uno8P3BtydYTdiNJ0I2W([In] object obj0) => (object) ((RemoveReferencesRequest) obj0).ProjectFileName;

    internal static object lVQGm4BtMMfGACKEyJhN([In] object obj0) => (object) ((RemoveReferencesRequest) obj0).WebReferencesNames;

    internal static object Fhfl55BtJnJMJuXq7nXo([In] object obj0) => (object) ((RemoveReferencesRequest) obj0).FileName;
  }
}
