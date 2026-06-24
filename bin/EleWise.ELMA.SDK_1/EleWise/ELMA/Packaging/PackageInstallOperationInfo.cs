// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Packaging.PackageInstallOperationInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using NuGet;
using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Packaging
{
  [XmlRoot]
  [Serializable]
  public class PackageInstallOperationInfo
  {
    internal static PackageInstallOperationInfo nyaemDBOSxO7i1XE5Qj0;

    /// <summary>Идентификатор пакета</summary>
    [XmlElement("Id")]
    public string Id
    {
      get => this.\u003CId\u003Ek__BackingField;
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
              this.\u003CId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
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

    /// <summary>Тип операции</summary>
    [XmlElement("Type")]
    public PackageOperationType Type
    {
      get => this.\u003CType\u003Ek__BackingField;
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
              this.\u003CType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
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

    /// <summary>Идентификатор версии</summary>
    [XmlElement("Version")]
    public string Version
    {
      get => this.\u003CVersion\u003Ek__BackingField;
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
              this.\u003CVersion\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
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

    public static PackageInstallOperationInfo Create(PackageOperationInfo info)
    {
      PackageInstallOperationInfo installOperationInfo = new PackageInstallOperationInfo();
      PackageInstallOperationInfo.lDZrcCBOK2N272OG7FER((object) installOperationInfo, PackageInstallOperationInfo.sOGAARBOqrLnmpdj7Q8f((object) info.Package));
      PackageInstallOperationInfo.CqUDYyBOOMZ6CrVh41vE((object) installOperationInfo, !PackageInstallOperationInfo.FtYi2kBOkitj7DhIEysN(PackageInstallOperationInfo.zQCwacBOTGinuYgv0edE(PackageInstallOperationInfo.FIBOEbBOXq4dmP7PE23v((object) info)), (object) null) ? (!((SemanticVersion) PackageInstallOperationInfo.JHiHoCBOnC4rOPFnf30Z((object) info) != (SemanticVersion) null) ? (object) (string) null : (object) PackageInstallOperationInfo.JHiHoCBOnC4rOPFnf30Z((object) info).ToString()) : (object) PackageInstallOperationInfo.zQCwacBOTGinuYgv0edE(PackageInstallOperationInfo.FIBOEbBOXq4dmP7PE23v((object) info)).ToString());
      installOperationInfo.Type = info.Type;
      return installOperationInfo;
    }

    public PackageInstallOperationInfo()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Pxok5UBOiuWaOvuN1cc7() => PackageInstallOperationInfo.nyaemDBOSxO7i1XE5Qj0 == null;

    internal static PackageInstallOperationInfo btp824BOR6284ZrktgjQ() => PackageInstallOperationInfo.nyaemDBOSxO7i1XE5Qj0;

    internal static object sOGAARBOqrLnmpdj7Q8f([In] object obj0) => (object) ((PackageInfo) obj0).Id;

    internal static void lDZrcCBOK2N272OG7FER([In] object obj0, [In] object obj1) => ((PackageInstallOperationInfo) obj0).Id = (string) obj1;

    internal static object FIBOEbBOXq4dmP7PE23v([In] object obj0) => (object) ((PackageOperationInfo) obj0).Package;

    internal static object zQCwacBOTGinuYgv0edE([In] object obj0) => (object) ((PackageInfo) obj0).Version;

    internal static bool FtYi2kBOkitj7DhIEysN([In] object obj0, [In] object obj1) => (SemanticVersion) obj0 != (SemanticVersion) obj1;

    internal static object JHiHoCBOnC4rOPFnf30Z([In] object obj0) => (object) ((PackageOperationInfo) obj0).InstalledVersion;

    internal static void CqUDYyBOOMZ6CrVh41vE([In] object obj0, [In] object obj1) => ((PackageInstallOperationInfo) obj0).Version = (string) obj1;
  }
}
