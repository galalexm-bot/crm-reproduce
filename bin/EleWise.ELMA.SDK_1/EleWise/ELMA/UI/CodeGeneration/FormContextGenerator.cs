// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.CodeGeneration.FormContextGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.CodeGeneration
{
  public class FormContextGenerator : EntityGenerator
  {
    private static FormContextGenerator Voq6pIBVRm6TvrcEk9hg;

    public IEnumerable<ISyntaxNode> Generate() => this.GenerateMainFile();

    protected override ISyntaxNode GetBaseClass()
    {
      int num = 1;
      ISyntaxNode syntaxNode;
      while (true)
      {
        switch (num)
        {
          case 1:
            syntaxNode = (ISyntaxNode) FormContextGenerator.MEDsvnBVXitjJGh2kJ6S((object) (ITypeGenerationInfo) this.GetIdTypeDescriptor(), (object) this.metadata, (object) null, false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      // ISSUE: type reference
      return FormContextGenerator.J0FEqRBVT2DmTA4qoC6n(__typeref (Entity<>)).CreateTypeSyntax(syntaxNode);
    }

    protected override void WriteTypeAttributes(ISyntaxNode type)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            type.AddAttributes(FormContextGenerator.J0FEqRBVT2DmTA4qoC6n(__typeref (UidAttribute)).CreateAttribute((object) FormContextGenerator.qyCSFnBVkgMrc3T7TORs((object) this.metadata).ToString()), FormContextGenerator.J0FEqRBVT2DmTA4qoC6n(__typeref (MetadataTypeAttribute)).CreateAttribute((object) this.metadata.GetType()), FormContextGenerator.J0FEqRBVT2DmTA4qoC6n(__typeref (DefaultManagerAttribute)).CreateAttribute((object) FormContextGenerator.J0FEqRBVT2DmTA4qoC6n(__typeref (MemoryEntityManagerMaker))));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    protected override void WritePropertyAttributes(
      ISyntaxNode property,
      PropertyMetadata propertyMetadata,
      string resourcePrefix = null)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        Dictionary<string, object> settingsValuePairs;
        while (true)
        {
          switch (num2)
          {
            case 1:
              FormContextGenerator.h10ZB6BVOi5fgTjNNpsh((object) propertyMetadata, FormContextGenerator.XrsQnMBVnpjBMgNlvHNs(1819636893 << 3 ^ 1672211898));
              num2 = 4;
              continue;
            case 2:
              FormContextGenerator.h10ZB6BVOi5fgTjNNpsh((object) property, FormContextGenerator.XrsQnMBVnpjBMgNlvHNs(1251470110 >> 2 ^ 312796097));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 1;
              continue;
            case 3:
              property.AddAttributes(this.WriteValidatePropertyAttributes(propertyMetadata));
              num2 = 7;
              continue;
            case 4:
              if (FormContextGenerator.TDBkeDBV2K8aQ8HB6McS((object) propertyMetadata))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
                continue;
              }
              goto case 6;
            case 5:
              property.AddAttributes((ISyntaxNode) FormContextGenerator.I3FViKBVPoXLZlqbm59S(FormContextGenerator.wFL3rtBVesdhI0YN9iEB((object) propertyMetadata).GetType(), (object) settingsValuePairs.ToArray<KeyValuePair<string, object>>()));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 3 : 1;
              continue;
            case 6:
              if (FormContextGenerator.wFL3rtBVesdhI0YN9iEB((object) propertyMetadata) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 8 : 3;
                continue;
              }
              goto label_14;
            case 7:
              goto label_3;
            case 8:
              goto label_12;
            default:
              // ISSUE: type reference
              property.AddAttributes(FormContextGenerator.J0FEqRBVT2DmTA4qoC6n(__typeref (RequiredAttribute)).CreateAttribute((object) FormContextGenerator.TDBkeDBV2K8aQ8HB6McS((object) propertyMetadata)));
              num2 = 6;
              continue;
          }
        }
label_12:
        settingsValuePairs = ((TypeSettings) FormContextGenerator.wFL3rtBVesdhI0YN9iEB((object) propertyMetadata)).GetSettingsValuePairs();
        num1 = 5;
      }
label_3:
      return;
label_14:;
    }

    protected override IEnumerable<ISyntaxTrivia> Resources() => (IEnumerable<ISyntaxTrivia>) new FormContextGenerator.\u003CResources\u003Ed__4(-2);

    /// <summary>Создать генератор кода класса табличной части</summary>
    /// <returns>Генератор</returns>
    [Obsolete("Метод устарел", true)]
    protected override EntityGenerator CreateTablePartGenerator() => (EntityGenerator) FormContextGenerator.wkEAyMBV1Jb64jnmQavs((object) this, (object) null);

    /// <summary>Создать генератор кода класса табличной части</summary>
    /// <param name="tablePart">Метаданные табличной части</param>
    protected override EntityGenerator CreateTablePartGenerator(TablePartMetadata tablePart) => (EntityGenerator) new FormContextGenerator();

    public FormContextGenerator()
    {
      FormContextGenerator.vLXdrEBVNtkA6o08ZnLT();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object MEDsvnBVXitjJGh2kJ6S(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      bool forFilter)
    {
      return (object) ((ITypeGenerationInfo) obj0).GetPropertyTypeReference((ClassMetadata) obj1, (PropertyMetadata) obj2, forFilter);
    }

    internal static Type J0FEqRBVT2DmTA4qoC6n([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool tUUI2kBVqYnCDrp4dFAn() => FormContextGenerator.Voq6pIBVRm6TvrcEk9hg == null;

    internal static FormContextGenerator xAkyoRBVK5s9W0Wt1s0x() => FormContextGenerator.Voq6pIBVRm6TvrcEk9hg;

    internal static Guid qyCSFnBVkgMrc3T7TORs([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object XrsQnMBVnpjBMgNlvHNs(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void h10ZB6BVOi5fgTjNNpsh([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool TDBkeDBV2K8aQ8HB6McS([In] object obj0) => ((PropertyMetadata) obj0).Required;

    internal static object wFL3rtBVesdhI0YN9iEB([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static object I3FViKBVPoXLZlqbm59S(Type attributeType, [In] object obj1) => (object) attributeType.CreateAttribute((KeyValuePair<string, object>[]) obj1);

    internal static object wkEAyMBV1Jb64jnmQavs([In] object obj0, [In] object obj1) => (object) ((EntityGenerator) obj0).CreateTablePartGenerator((TablePartMetadata) obj1);

    internal static void vLXdrEBVNtkA6o08ZnLT() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
