// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.EntityPropertyTablePartMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>
  /// Класс-наследник от EntityPropertyMetadata. Служит, чтобы отметить, что свойство является блоком
  /// Нужен ТОЛЬКО для генерации кода и инизиализации
  /// </summary>
  public class EntityPropertyTablePartMetadata : EntityPropertyMetadata
  {
    internal static EntityPropertyTablePartMetadata ilqBStbDuMV3igfMcnRo;

    /// <summary>Ctor</summary>
    public EntityPropertyTablePartMetadata()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="metadata">Метаданные</param>
    /// <param name="tablePart">Блок</param>
    public EntityPropertyTablePartMetadata(EntityMetadata metadata, TablePartMetadata tablePart)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 6;
      PropertyMetadata propertyMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            propertyMetadata = tablePart.Properties.First<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => EntityPropertyTablePartMetadata.\u003C\u003Ec__DisplayClass1_0.bHaOneCDYiS0vccDA6rP(EntityPropertyTablePartMetadata.\u003C\u003Ec__DisplayClass1_0.xfTl4nCD5EjDKY9iL0xE((object) p), EntityPropertyTablePartMetadata.\u003C\u003Ec__DisplayClass1_0.tApxKpCDjVhNdbbEkPXE((object) tablePart))));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 5 : 4;
            continue;
          case 3:
            EntityPropertyTablePartMetadata.oXqsyEbDK6jMeRlrS7vp((object) this, EntityPropertyTablePartMetadata.dfTrDsbDqvF02UBk68p6((object) tablePart));
            num = 7;
            continue;
          case 4:
            this.SubTypeUid = EntityPropertyTablePartMetadata.MlVPEjbDn7Rppferina8((object) metadata) == EntityMetadataType.InterfaceImplementation ? EntityPropertyTablePartMetadata.mlDAKqbD2iJVBv7w4Zow((object) tablePart) : EntityPropertyTablePartMetadata.qaAGHGbDOaUYImQgkR50((object) tablePart);
            num = 2;
            continue;
          case 5:
            EntitySettings entitySettings = new EntitySettings();
            EntityPropertyTablePartMetadata.GH4I3AbDeKhdjHgbujIE((object) entitySettings, RelationType.OneToMany);
            EntityPropertyTablePartMetadata.befVc8bDPMVJ4sxDUkOS((object) entitySettings, EntityPropertyTablePartMetadata.qaAGHGbDOaUYImQgkR50((object) propertyMetadata));
            entitySettings.CascadeMode = CascadeMode.All;
            EntityPropertyTablePartMetadata.fZhQ4hbD1dPcQm8Gnhsr((object) this, (object) entitySettings);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 1;
            continue;
          case 6:
            EntityPropertyTablePartMetadata.jWUaWMbDSixw35qi70RC((object) this, tablePart.TablePartPropertyUid);
            num = 8;
            continue;
          case 7:
            EntityPropertyTablePartMetadata.O43JobbDT41GgusR2gUJ((object) this, EntityPropertyTablePartMetadata.P4kAtSbDXBpK4m0ulWqq((object) tablePart));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
            continue;
          case 8:
            EntityPropertyTablePartMetadata.ljfIU8bDRJtx4WxNCsIE((object) this, EntityPropertyTablePartMetadata.xDbbmsbDipB6GClXcXwh((object) tablePart));
            num = 3;
            continue;
          default:
            EntityPropertyTablePartMetadata.ikFHTXbDk04wAkBmJnOG((object) this, EntityDescriptor.UID);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 4 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static bool MSPQNCbDIVS7HZvV3fCN() => EntityPropertyTablePartMetadata.ilqBStbDuMV3igfMcnRo == null;

    internal static EntityPropertyTablePartMetadata JDdNTrbDVYGAWCYoCHhr() => EntityPropertyTablePartMetadata.ilqBStbDuMV3igfMcnRo;

    internal static void jWUaWMbDSixw35qi70RC([In] object obj0, Guid value) => ((AbstractMetadata) obj0).Uid = value;

    internal static object xDbbmsbDipB6GClXcXwh([In] object obj0) => (object) ((TablePartMetadata) obj0).TablePartPropertyName;

    internal static void ljfIU8bDRJtx4WxNCsIE([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).Name = (string) obj1;

    internal static object dfTrDsbDqvF02UBk68p6([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static void oXqsyEbDK6jMeRlrS7vp([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).DisplayName = (string) obj1;

    internal static object P4kAtSbDXBpK4m0ulWqq([In] object obj0) => (object) ((NamedMetadata) obj0).Description;

    internal static void O43JobbDT41GgusR2gUJ([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).Description = (string) obj1;

    internal static void ikFHTXbDk04wAkBmJnOG([In] object obj0, Guid value) => ((PropertyMetadata) obj0).TypeUid = value;

    internal static EntityMetadataType MlVPEjbDn7Rppferina8([In] object obj0) => ((EntityMetadata) obj0).Type;

    internal static Guid qaAGHGbDOaUYImQgkR50([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static Guid mlDAKqbD2iJVBv7w4Zow([In] object obj0) => ((EntityMetadata) obj0).ImplementationUid;

    internal static void GH4I3AbDeKhdjHgbujIE([In] object obj0, RelationType value) => ((EntitySettings) obj0).RelationType = value;

    internal static void befVc8bDPMVJ4sxDUkOS([In] object obj0, Guid value) => ((EntitySettings) obj0).KeyColumnUid = value;

    internal static void fZhQ4hbD1dPcQm8Gnhsr([In] object obj0, [In] object obj1) => ((PropertyMetadata) obj0).Settings = (TypeSettings) obj1;
  }
}
