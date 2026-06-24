// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Packaging.PackageInstallInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Packaging
{
  [XmlRoot]
  [Serializable]
  public class PackageInstallInfo
  {
    public const string Prefix = "PackageInstallInfo";
    private static PackageInstallInfo jOwC9kBOCoKVwLTHDH9n;

    [XmlArray]
    public List<PackageInstallOperationInfo> Operations { get; set; }

    [XmlElement("UpdatingUid")]
    public Guid UpdatingUid
    {
      get => this.\u003CUpdatingUid\u003Ek__BackingField;
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
              this.\u003CUpdatingUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
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

    public PackageInstallInfo()
    {
      PackageInstallInfo.DKJpWpBOZ28yMDjALFto();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Operations = new List<PackageInstallOperationInfo>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>
    /// Сгенерировать имя файла для сохранения действий для обновления
    /// </summary>
    /// <returns></returns>
    public static string GenerateFileName() => (string) PackageInstallInfo.BbjwbNBOV0Vo8KWLOk0M(PackageInstallInfo.WUCJDABOuDWyU579wgRr(-16752921 ^ -16683131), (object) PackageInstallInfo.vsRLySBOIdmNVibjP6TQ().ToString((string) PackageInstallInfo.WUCJDABOuDWyU579wgRr(694673736 ^ -23604109 ^ -672070473)), PackageInstallInfo.WUCJDABOuDWyU579wgRr(1033719030 - 2012070891 ^ -978385083));

    internal static bool XnY5qVBOvUP9iDnUhcpX() => PackageInstallInfo.jOwC9kBOCoKVwLTHDH9n == null;

    internal static PackageInstallInfo Ebp9erBO8DN3QvX4yR84() => PackageInstallInfo.jOwC9kBOCoKVwLTHDH9n;

    internal static void DKJpWpBOZ28yMDjALFto() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object WUCJDABOuDWyU579wgRr(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static DateTime vsRLySBOIdmNVibjP6TQ() => DateTime.Now;

    internal static object BbjwbNBOV0Vo8KWLOk0M([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);
  }
}
