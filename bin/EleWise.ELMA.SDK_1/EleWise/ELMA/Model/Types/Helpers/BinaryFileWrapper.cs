// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.BinaryFileWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Files;
using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [Component]
  [XmlRoot("BinaryFileValue")]
  public class BinaryFileWrapper : IXsiType
  {
    internal static BinaryFileWrapper FWHW1oboAupKW4AvNF4O;

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
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

    [XmlElement("SecondId")]
    public string SecondId
    {
      get => this.\u003CSecondId\u003Ek__BackingField;
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
              this.\u003CSecondId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
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

    public BinaryFileWrapper()
    {
      BinaryFileWrapper.lxVhDHbo0XwdaAtD4qx1();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public BinaryFileWrapper(BinaryFile file)
    {
      BinaryFileWrapper.lxVhDHbo0XwdaAtD4qx1();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.Id = (string) BinaryFileWrapper.kZ3hSEbomrm8XQtInQx9((object) file);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
            continue;
          default:
            this.SecondId = (string) BinaryFileWrapper.ywP8yTboykSkgDvnFI9M((object) file);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static bool LFnVsTbo7yecYwV7bE7m() => BinaryFileWrapper.FWHW1oboAupKW4AvNF4O == null;

    internal static BinaryFileWrapper GPshqQboxmRDRJHVRECv() => BinaryFileWrapper.FWHW1oboAupKW4AvNF4O;

    internal static void lxVhDHbo0XwdaAtD4qx1() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object kZ3hSEbomrm8XQtInQx9([In] object obj0) => (object) ((BinaryFile) obj0).Id;

    internal static object ywP8yTboykSkgDvnFI9M([In] object obj0) => (object) ((BinaryFile) obj0).SecondId;
  }
}
