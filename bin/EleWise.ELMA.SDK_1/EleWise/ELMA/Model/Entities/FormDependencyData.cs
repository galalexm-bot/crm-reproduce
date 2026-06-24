// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.FormDependencyData
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Entities
{
  [Serializable]
  public class FormDependencyData : IFormDependencyData
  {
    private static FormDependencyData u2HvVYh8ySCWHba7ustw;

    public FormDependencyData(
      Guid dependObjectUid,
      Guid dependObjectFormUid,
      Guid usesObjectUid,
      Guid usesObjectFormUid,
      FormDependencyDataType type)
    {
      FormDependencyData.guAbX1h89pV4qS7sJ8kn();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.UsesObjectFormUid = usesObjectFormUid;
            num = 5;
            continue;
          case 3:
            this.DependObjectUid = dependObjectUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
            continue;
          case 4:
            this.UsesObjectUid = usesObjectUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 2;
            continue;
          case 5:
            this.Type = type;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 1;
            continue;
          default:
            this.DependObjectFormUid = dependObjectFormUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 4 : 2;
            continue;
        }
      }
label_2:;
    }

    public Guid DependObjectUid
    {
      get => this.\u003CDependObjectUid\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CDependObjectUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
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

    public Guid DependObjectFormUid
    {
      get => this.\u003CDependObjectFormUid\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CDependObjectFormUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
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

    public Guid UsesObjectUid
    {
      get => this.\u003CUsesObjectUid\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CUsesObjectUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
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

    public Guid UsesObjectFormUid
    {
      get => this.\u003CUsesObjectFormUid\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CUsesObjectFormUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
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

    public FormDependencyDataType Type
    {
      get => this.\u003CType\u003Ek__BackingField;
      private set
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
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

    public string GenerateDependInfo() => (string) FormDependencyData.bbsiSgh8doa366gumaDr((object) FormDependencyHelper.KeySplitter, (object) new object[3]
    {
      (object) this.DependObjectUid,
      (object) this.DependObjectFormUid,
      (object) this.Type
    });

    public string GenerateUsesInfo() => (string) FormDependencyData.bbsiSgh8doa366gumaDr((object) FormDependencyHelper.KeySplitter, (object) new object[3]
    {
      (object) this.UsesObjectUid,
      (object) this.UsesObjectFormUid,
      (object) this.Type
    });

    internal static void guAbX1h89pV4qS7sJ8kn() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool L8YuWnh8MB5MttINkYvL() => FormDependencyData.u2HvVYh8ySCWHba7ustw == null;

    internal static FormDependencyData KBnpTMh8JR8JxAPFSpeE() => FormDependencyData.u2HvVYh8ySCWHba7ustw;

    internal static object bbsiSgh8doa366gumaDr([In] object obj0, [In] object obj1) => (object) string.Join((string) obj0, (object[]) obj1);

    internal static class Tables
    {
      internal const string TableName = "FormDependencies";

      internal static class Fields
      {
        internal const string DependObjectUid = "DependObjectUid";
        internal const string DependObjectFormUid = "DependObjectFormUid";
        internal const string UsesObjectUid = "UsesObjectUid";
        internal const string UsesObjectFormUid = "UsesObjectFormUid";
        internal const string Type = "Type";
      }
    }
  }
}
