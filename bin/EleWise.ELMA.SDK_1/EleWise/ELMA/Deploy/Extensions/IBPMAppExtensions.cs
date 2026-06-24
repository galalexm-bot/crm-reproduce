// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Extensions.IBPMAppExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.BPMApps.Models;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using SG9KiyIbtdgGDf12qr;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Extensions
{
  /// <summary>Расширения для создания IBPMApp</summary>
  internal static class IBPMAppExtensions
  {
    private static IBPMAppExtensions FCaaLYEDAADU5n8DjOQv;

    /// <summary>
    /// Добавление данных из описания компонента ElmaStore в объект IBPMApp
    /// </summary>
    /// <param name="bpmApp">BPM App</param>
    /// <param name="componentManifest">Описание компонента ElmaStore</param>
    internal static void InputComponentManifest(
      this IBPMApp bpmApp,
      ElmaStoreComponentManifest componentManifest)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            IBPMAppExtensions.wZDiPfEDyTpofrtfhRWA((object) bpmApp, (object) componentManifest);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
            continue;
          case 2:
            IBPMAppExtensions.GapJkcEDm72jwM3v3oW6((object) bpmApp, IBPMAppExtensions.Aee0ddED0yLbh0BpVO0h((object) componentManifest));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Добавление данных из манифеста в объект IBPMApp</summary>
    /// <param name="bpmApp">BPM App</param>
    /// <param name="bpmAppManifest">Манифест для BPM App</param>
    internal static void InputAppManifest(this IBPMApp bpmApp, BPMAppManifest bpmAppManifest)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            bpmApp.AppManifest = (object) bpmAppManifest;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Добавление данных об иконке в объект IBPMApp</summary>
    /// <param name="bpmApp">BPM App</param>
    /// <param name="image">Иконка</param>
    internal static void InputImage(this IBPMApp bpmApp, Image image)
    {
      int num1 = 4;
      MemoryStream memoryStream;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 3:
              IBPMAppExtensions.WoDiUfEDr65ra3CZojP1((object) bpmApp, (object) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 6 : 2;
              continue;
            case 2:
              goto label_7;
            case 4:
              if (image == null)
              {
                num2 = 3;
                continue;
              }
              goto case 7;
            case 5:
              goto label_21;
            case 6:
              goto label_20;
            case 7:
              bpmApp.IconFileName = (string) IBPMAppExtensions.Hs7hBLEDM12pM4pTBrGe(333888594 ^ 1075625116 ^ 1409189496);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
              continue;
            default:
              memoryStream = (MemoryStream) IBPMAppExtensions.tOtJhDEDJdGcJ6pDIsWO();
              num2 = 2;
              continue;
          }
        }
label_20:
        IBPMAppExtensions.LSkYR4EDlSjfBjAEeF35((object) bpmApp, (object) null);
        num1 = 5;
      }
label_21:
      return;
label_7:
      try
      {
        IBPMAppExtensions.avfo1HEDdFCRd4f3ATee((object) image, (object) memoryStream, IBPMAppExtensions.veksRlED9F4duZY2QGJ6());
        int num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_16;
            case 1:
              IBPMAppExtensions.LSkYR4EDlSjfBjAEeF35((object) bpmApp, (object) memoryStream.ToArray());
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
              continue;
            default:
              goto label_11;
          }
        }
label_16:
        return;
label_11:;
      }
      finally
      {
        if (memoryStream != null)
        {
          int num4 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
            num4 = 1;
          while (true)
          {
            switch (num4)
            {
              case 1:
                memoryStream.Dispose();
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
                continue;
              default:
                goto label_18;
            }
          }
        }
label_18:;
      }
    }

    /// <summary>
    /// Добавление данных о дополнительных файлах в объект IBPMApp
    /// </summary>
    /// <param name="bpmApp">BPM App</param>
    /// <param name="additionalFilesContent">Содержимое прикрепленной к папки в виде zip-архива</param>
    /// <param name="helpFileContent">Содержимое файла с инструкцией</param>
    internal static void InputFilesContent(
      this IBPMApp bpmApp,
      byte[] additionalFilesContent,
      byte[] helpFileContent)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (helpFileContent == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
                continue;
              }
              goto case 6;
            case 2:
              goto label_14;
            case 4:
            case 9:
              if (additionalFilesContent != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 4 : 8;
                continue;
              }
              break;
            case 5:
              goto label_13;
            case 6:
              if (helpFileContent.Length == 0)
              {
                num2 = 7;
                continue;
              }
              goto label_13;
            case 8:
              if (additionalFilesContent.Length != 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 10;
                continue;
              }
              break;
            case 10:
              IBPMAppExtensions.ieXgeMED5kiBMTywhyIA((object) bpmApp, (object) additionalFilesContent);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 2 : 2;
              continue;
            case 11:
              goto label_6;
            default:
              bpmApp.HelpFileContent = (byte[]) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 4;
              continue;
          }
          IBPMAppExtensions.ieXgeMED5kiBMTywhyIA((object) bpmApp, (object) null);
          num2 = 11;
        }
label_13:
        IBPMAppExtensions.pOKOoFEDgowRgDkCakg1((object) bpmApp, (object) helpFileContent);
        num1 = 9;
      }
label_14:
      return;
label_6:;
    }

    internal static object Aee0ddED0yLbh0BpVO0h([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Title;

    internal static void GapJkcEDm72jwM3v3oW6([In] object obj0, [In] object obj1) => ((IBPMApp) obj0).Title = (string) obj1;

    internal static void wZDiPfEDyTpofrtfhRWA([In] object obj0, [In] object obj1) => ((IBPMApp) obj0).ComponentManifest = obj1;

    internal static bool l9sxCWED7IZ0hvTK4c90() => IBPMAppExtensions.FCaaLYEDAADU5n8DjOQv == null;

    internal static IBPMAppExtensions RuXtwIEDxOu4W2jBXRSG() => IBPMAppExtensions.FCaaLYEDAADU5n8DjOQv;

    internal static object Hs7hBLEDM12pM4pTBrGe(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object tOtJhDEDJdGcJ6pDIsWO() => (object) MemoryHelper.GetMemoryStream();

    internal static object veksRlED9F4duZY2QGJ6() => (object) ImageFormat.Png;

    internal static void avfo1HEDdFCRd4f3ATee([In] object obj0, [In] object obj1, [In] object obj2) => ((Image) obj0).Save((Stream) obj1, (ImageFormat) obj2);

    internal static void LSkYR4EDlSjfBjAEeF35([In] object obj0, [In] object obj1) => ((IBPMApp) obj0).IconData = (byte[]) obj1;

    internal static void WoDiUfEDr65ra3CZojP1([In] object obj0, [In] object obj1) => ((IBPMApp) obj0).IconFileName = (string) obj1;

    internal static void pOKOoFEDgowRgDkCakg1([In] object obj0, [In] object obj1) => ((IBPMApp) obj0).HelpFileContent = (byte[]) obj1;

    internal static void ieXgeMED5kiBMTywhyIA([In] object obj0, [In] object obj1) => ((IBPMApp) obj0).AdditionalFilesContent = (byte[]) obj1;
  }
}
