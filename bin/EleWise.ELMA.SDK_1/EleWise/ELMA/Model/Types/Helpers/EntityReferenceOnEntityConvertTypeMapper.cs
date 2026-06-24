// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.EntityReferenceOnEntityConvertTypeMapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [Component]
  public class EntityReferenceOnEntityConvertTypeMapper : IConvertTypeMapper
  {
    private static Guid ReferenceOnEntityTypeUid;
    internal static EntityReferenceOnEntityConvertTypeMapper ruGSZ9bonuk1At85sfdN;

    public bool RelativeConvertNeeded(
      IPropertyMetadata originalPropertyMetadata,
      IPropertyMetadata convertPropertyMetadata)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (!(EntityReferenceOnEntityConvertTypeMapper.svCjKXboelKr0LTGjHR5((object) convertPropertyMetadata) != EntityReferenceOnEntityConvertTypeMapper.ReferenceOnEntityTypeUid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return false;
label_5:
      return originalPropertyMetadata.SubTypeUid != Guid.Empty;
    }

    public object Convert(object obj)
    {
      int num = 3;
      IEntity<long> entity;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (entity != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 3:
            entity = obj as IEntity<long>;
            num = 2;
            continue;
          default:
            goto label_6;
        }
      }
label_5:
      return (object) null;
label_6:
      ReferenceOnEntity referenceOnEntity = new ReferenceOnEntity();
      EntityReferenceOnEntityConvertTypeMapper.jplx8HboPhXkDGXaK4Zs((object) referenceOnEntity, (object) entity);
      return (object) referenceOnEntity;
    }

    public EntityReferenceOnEntityConvertTypeMapper()
    {
      EntityReferenceOnEntityConvertTypeMapper.GaxuEXbo1PS2agHFd3qr();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static EntityReferenceOnEntityConvertTypeMapper()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            EntityReferenceOnEntityConvertTypeMapper.ReferenceOnEntityTypeUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408807402));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
            continue;
          case 2:
            EntityReferenceOnEntityConvertTypeMapper.GaxuEXbo1PS2agHFd3qr();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static Guid svCjKXboelKr0LTGjHR5([In] object obj0) => ((IPropertyMetadata) obj0).TypeUid;

    internal static bool jVMZKUboOCyBXbeGHmPy() => EntityReferenceOnEntityConvertTypeMapper.ruGSZ9bonuk1At85sfdN == null;

    internal static EntityReferenceOnEntityConvertTypeMapper QKUisBbo2pbLIyTKZVSq() => EntityReferenceOnEntityConvertTypeMapper.ruGSZ9bonuk1At85sfdN;

    internal static void jplx8HboPhXkDGXaK4Zs([In] object obj0, [In] object obj1) => ((ReferenceOnEntity) obj0).Object = (IEntity) obj1;

    internal static void GaxuEXbo1PS2agHFd3qr() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
