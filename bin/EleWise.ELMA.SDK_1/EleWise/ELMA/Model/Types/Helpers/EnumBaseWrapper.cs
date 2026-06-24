// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.EnumBaseWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [XmlRoot("EnumBaseValue")]
  [Component]
  public class EnumBaseWrapper : IXsiType
  {
    internal static EnumBaseWrapper TkMTD0boN28Wwrj4SZGS;

    public EnumBaseWrapper()
    {
      EnumBaseWrapper.sp5O9kboaYRalZvSO81h();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public EnumBaseWrapper(EnumBase enumBase)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 2;
      while (true)
      {
        int num2;
        IMetadata metadata;
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            this.Value = EnumBaseWrapper.qcXjKCboD8beUuZ0e7j5((object) enumBase);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
            continue;
          case 3:
            if (metadata != null)
            {
              num2 = 4;
              break;
            }
            goto label_9;
          case 4:
            this.TypeUid = metadata.Uid;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 0;
            continue;
          default:
            metadata = MetadataLoader.LoadMetadata(enumBase.GetType());
            num2 = 3;
            break;
        }
        num1 = num2;
      }
label_3:
      return;
label_9:;
    }

    [XmlElement("Value")]
    public Guid Value
    {
      get => this.\u003CValue\u003Ek__BackingField;
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
              this.\u003CValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
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

    [XmlElement("TypeUid")]
    public Guid TypeUid
    {
      get => this.\u003CTypeUid\u003Ek__BackingField;
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
              this.\u003CTypeUid\u003Ek__BackingField = value;
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
    }

    internal static void sp5O9kboaYRalZvSO81h() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool qQjO5fbo3S3D51xv7jWY() => EnumBaseWrapper.TkMTD0boN28Wwrj4SZGS == null;

    internal static EnumBaseWrapper P4sOZQbopwDu6Am4XKcA() => EnumBaseWrapper.TkMTD0boN28Wwrj4SZGS;

    internal static Guid qcXjKCboD8beUuZ0e7j5([In] object obj0) => ((EnumBase) obj0).Value;
  }
}
