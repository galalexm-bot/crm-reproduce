// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.DesignScriptCompiler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Design;
using EleWise.ELMA.Model.Scripts;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>
  /// Компилятор сценариев для проверки на стороне дизайнера
  /// </summary>
  public class DesignScriptCompiler : ScriptCompiler
  {
    private static DesignScriptCompiler qrslWkh15ZkCJv7QbZx6;

    public DesignScriptCompiler(IScriptModule scriptModule)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(scriptModule);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.AssemblyName = (string) DesignScriptCompiler.o79c5Hh1LRMP6e5vuS4M((object) scriptModule);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public override void AddAllElmaReferences()
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        int index;
        FileInfo[] fileInfoArray;
        FileInfo fileInfo;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_8;
            case 1:
            case 2:
              if (index >= fileInfoArray.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
                continue;
              }
              goto case 5;
            case 3:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 2 : 2;
              continue;
            case 4:
              DesignScriptCompiler.SrSdU0hNB89YE2VgfgbQ((object) this, DesignScriptCompiler.HKyeVRhNFHKRYa3qHx45((object) fileInfo));
              num2 = 3;
              continue;
            case 5:
              fileInfo = fileInfoArray[index];
              num2 = 4;
              continue;
            case 6:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 1 : 1;
              continue;
            case 7:
              goto label_5;
            default:
              goto label_3;
          }
        }
label_5:
        fileInfoArray = (FileInfo[]) DesignScriptCompiler.SjEN4Uh1zA20QRlBD7TE((object) new DirectoryInfo((string) DesignScriptCompiler.G8aofRh1UTsu0XCaIwqr()), DesignScriptCompiler.nNDOKjh1cgUKphuHUp9j(DesignScriptCompiler.qGxwoXh1sxrGacBdeZss(-1317790512 ^ -1317709802), (object) Array.Empty<object>()));
        num1 = 6;
      }
label_8:
      return;
label_3:;
    }

    internal static object o79c5Hh1LRMP6e5vuS4M([In] object obj0) => (object) ((IScriptModule) obj0).AssemblyName;

    internal static bool ftQ7krh1j8aeVKHq4ASw() => DesignScriptCompiler.qrslWkh15ZkCJv7QbZx6 == null;

    internal static DesignScriptCompiler UqI07qh1YKxXRtNUonpo() => DesignScriptCompiler.qrslWkh15ZkCJv7QbZx6;

    internal static object G8aofRh1UTsu0XCaIwqr() => (object) DesignEnvironment.LibsDir;

    internal static object qGxwoXh1sxrGacBdeZss(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object nNDOKjh1cgUKphuHUp9j([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

    internal static object SjEN4Uh1zA20QRlBD7TE([In] object obj0, [In] object obj1) => (object) ((DirectoryInfo) obj0).GetFiles((string) obj1);

    internal static object HKyeVRhNFHKRYa3qHx45([In] object obj0) => (object) ((FileSystemInfo) obj0).FullName;

    internal static void SrSdU0hNB89YE2VgfgbQ([In] object obj0, [In] object obj1) => ((AssemblyBuilder) obj0).AddReference((string) obj1);
  }
}
