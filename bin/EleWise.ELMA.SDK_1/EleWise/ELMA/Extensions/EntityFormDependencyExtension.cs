// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.EntityFormDependencyExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions
{
  /// <summary>
  /// Точка расширения для работы с зависимостями форм в сущностях
  /// </summary>
  [Component(Order = 50)]
  internal class EntityFormDependencyExtension : IFormDependencyExtension
  {
    private readonly IMetadataRuntimeService metadataRuntimeService;
    private static EntityFormDependencyExtension b7ApDiGt1gFdYOBOuTpM;

    public EntityFormDependencyExtension(IMetadataRuntimeService metadataRuntimeService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.metadataRuntimeService = metadataRuntimeService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public virtual bool CheckType(Guid uid)
    {
      bool flag;
      switch (1)
      {
        case 1:
          try
          {
            flag = this.metadataRuntimeService.GetMetadata(uid, false) is EntityMetadata;
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
              num = 0;
            switch (num)
            {
            }
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_1;
                case 2:
                  flag = false;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 0;
                  continue;
                default:
                  EntityFormDependencyExtension.swm4FPGtaBlK54xMc56M(EntityFormDependencyExtension.bHYPKnGtpkN1NSk8MEXa(), (object) ex);
                  num = 2;
                  continue;
              }
            }
          }
          break;
      }
label_1:
      return flag;
    }

    public void GenerateNewDependencies(Guid dependObjectUid)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        IMetadata metadata;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_4;
            case 1:
              goto label_3;
            case 2:
              if (metadata != null)
              {
                this.GenerateNewDependencies(metadata);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_8;
            default:
              goto label_9;
          }
        }
label_8:
        metadata = this.metadataRuntimeService.GetMetadata(dependObjectUid, false);
        num1 = 2;
      }
label_4:
      return;
label_3:
      return;
label_9:;
    }

    public void GenerateNewDependencies(IMetadata dependObjectMetadata)
    {
      int num1 = 20;
      while (true)
      {
        int num2 = num1;
        // ISSUE: variable of a compiler-generated type
        EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass4_0 cDisplayClass40;
        EntityMetadata metadata1;
        List<FormViewItemTransformation> list;
        List<FormViewItemTransformation>.Enumerator enumerator1;
        EntityMetadata metadata2;
        List<Guid> guidList;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_13;
            case 1:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass40.objectUid = EntityFormDependencyExtension.xyV7rNGttohHDK9LejNO((object) metadata1);
              num2 = 21;
              continue;
            case 2:
              enumerator1 = metadata2.FormTransformations.GetEnumerator();
              num2 = 15;
              continue;
            case 3:
              goto label_7;
            case 4:
              goto label_88;
            case 5:
              if (!EntityFormDependencyExtension.AlcxXyGtwa7E3e2tpCF5(this.metadataRuntimeService.GetTypeByUidOrNull(EntityFormDependencyExtension.xyV7rNGttohHDK9LejNO((object) metadata1), false), (Type) null))
              {
                // ISSUE: reference to a compiler-generated field
                cDisplayClass40.objectUid = EntityFormDependencyExtension.yURfTeGt4vbyDoux876x((object) metadata1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 10 : 4;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 12 : 13;
              continue;
            case 6:
            case 12:
label_3:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass40.deps = new List<IFormDependencyData>();
              num2 = 3;
              continue;
            case 7:
              guidList.AddRange(MetadataLoader.GetBaseClassMetadataList((ClassMetadata) metadata2, false, false).Select<ClassMetadata, Guid>((Func<ClassMetadata, Guid>) (q => q.Uid)));
              num2 = 2;
              continue;
            case 8:
              list = metadata1.FormTransformations.ToList<FormViewItemTransformation>();
              num2 = 17;
              continue;
            case 9:
              goto label_4;
            case 10:
              // ISSUE: reference to a compiler-generated method
              guidList.AddRange(MetadataLoader.GetBaseClassMetadataList((ClassMetadata) metadata1, false, false).Select<ClassMetadata, Guid>((Func<ClassMetadata, Guid>) (q => EntityFormDependencyExtension.\u003C\u003Ec.dhFkwv8oNhMimQtWj7cr((object) q))));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 6 : 1;
              continue;
            case 11:
              goto label_10;
            case 13:
              goto label_86;
            case 14:
              goto label_87;
            case 15:
              try
              {
label_76:
                if (enumerator1.MoveNext())
                  goto label_74;
                else
                  goto label_77;
label_72:
                // ISSUE: variable of a compiler-generated type
                EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass4_1 cDisplayClass41;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated field
                      list.Add(cDisplayClass41.t);
                      num3 = 2;
                      continue;
                    case 2:
                      goto label_76;
                    case 3:
                      // ISSUE: reference to a compiler-generated method
                      if (!list.Any<FormViewItemTransformation>(new Func<FormViewItemTransformation, bool>(cDisplayClass41.\u003CGenerateNewDependencies\u003Eb__2)))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 1;
                        continue;
                      }
                      goto label_76;
                    case 4:
                      goto label_3;
                    case 5:
                      // ISSUE: reference to a compiler-generated field
                      cDisplayClass41.t = enumerator1.Current;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 1 : 3;
                      continue;
                    default:
                      goto label_74;
                  }
                }
label_74:
                // ISSUE: object of a compiler-generated type is created
                cDisplayClass41 = new EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass4_1();
                num3 = 5;
                goto label_72;
label_77:
                num3 = 4;
                goto label_72;
              }
              finally
              {
                enumerator1.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 16:
              goto label_91;
            case 17:
              if (EntityFormDependencyExtension.HvOOOOGtDO9WFKXAOv18((object) metadata1) == EntityMetadataType.InterfaceExtension)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 1;
                continue;
              }
              goto case 5;
            case 18:
              goto label_14;
            case 19:
              metadata1 = dependObjectMetadata as EntityMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 9 : 3;
              continue;
            case 20:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass40 = new EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass4_0();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 19 : 13;
              continue;
            case 21:
              metadata2 = this.metadataRuntimeService.GetMetadata(EntityFormDependencyExtension.xyV7rNGttohHDK9LejNO((object) metadata1), false) as EntityMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 7 : 22;
              continue;
            case 22:
              if (metadata2 == null)
              {
                num2 = 12;
                continue;
              }
              goto case 7;
            default:
              goto label_80;
          }
        }
label_4:
        if (metadata1 != null)
        {
          num1 = 14;
          continue;
        }
        goto label_84;
label_7:
        enumerator1 = list.GetEnumerator();
        num1 = 18;
        continue;
label_10:
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        FormDependencyHelper.Update(cDisplayClass40.objectUid, (IFormDependencyData[]) EntityFormDependencyExtension.KjYOdYGtdQEq0iLdyjpK((object) cDisplayClass40.deps));
        num1 = 4;
        continue;
label_14:
        try
        {
label_62:
          if (enumerator1.MoveNext())
            goto label_21;
          else
            goto label_63;
label_16:
          // ISSUE: variable of a compiler-generated type
          EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass4_3 cDisplayClass43;
          // ISSUE: variable of a compiler-generated type
          EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass4_2 cDisplayClass42;
          List<ViewItemTransformation>.Enumerator enumerator2;
          int num5;
          while (true)
          {
            int num6;
            switch (num5)
            {
              case 1:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                cDisplayClass43.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.deps.Add((IFormDependencyData) new FormDependencyData(cDisplayClass43.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.objectUid, cDisplayClass43.dependFormUid, cDisplayClass43.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.objectUid, cDisplayClass43.CS\u0024\u003C\u003E8__locals2.t.Uid, cDisplayClass43.dependType));
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 8 : 6;
                continue;
              case 2:
                // ISSUE: object of a compiler-generated type is created
                cDisplayClass43 = new EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass4_3();
                num5 = 7;
                continue;
              case 3:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                cDisplayClass43.dependFormUid = cDisplayClass43.CS\u0024\u003C\u003E8__locals2.t.Uid;
                num5 = 10;
                continue;
              case 4:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                enumerator2 = cDisplayClass43.CS\u0024\u003C\u003E8__locals2.t.Items.GetEnumerator();
                num5 = 6;
                continue;
              case 5:
                goto label_91;
              case 6:
                goto label_25;
              case 7:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass43.CS\u0024\u003C\u003E8__locals2 = cDisplayClass42;
                num5 = 3;
                continue;
              case 8:
                // ISSUE: reference to a compiler-generated method
                guidList.ForEach(new Action<Guid>(cDisplayClass43.\u003CGenerateNewDependencies\u003Eb__4));
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 4 : 1;
                continue;
              case 9:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass42.CS\u0024\u003C\u003E8__locals1 = cDisplayClass40;
                num5 = 11;
                continue;
              case 10:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass43.dependType = FormDependencyDataType.Inherit;
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
                continue;
              case 11:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass42.t = enumerator1.Current;
                num6 = 2;
                break;
              case 12:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                cDisplayClass43.dependFormUid = cDisplayClass43.CS\u0024\u003C\u003E8__locals2.t.NewFormUid;
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 14;
                continue;
              case 13:
                goto label_21;
              case 14:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass43.dependType = FormDependencyDataType.Child;
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 1;
                continue;
              case 15:
                goto label_62;
              default:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (EntityFormDependencyExtension.NJcdfoGt6qrjgEchMNUU(cDisplayClass43.CS\u0024\u003C\u003E8__locals2.t.NewFormUid, Guid.Empty))
                {
                  num6 = 12;
                  break;
                }
                goto case 8;
            }
            num5 = num6;
          }
label_25:
          try
          {
label_38:
            if (enumerator2.MoveNext())
              goto label_42;
            else
              goto label_39;
label_26:
            ViewItemTransformation current;
            ViewItemTransformationChange transformationChange;
            ButtonViewItem buttonViewItem;
            Type child;
            ViewItemTransformationAdd transformationAdd;
            int num7;
            while (true)
            {
              switch (num7)
              {
                case 1:
                case 3:
                case 6:
                case 8:
                case 11:
                case 17:
                case 18:
                  goto label_38;
                case 2:
                  if (!child.IsInheritOrSame<ButtonViewItem>())
                  {
                    num7 = 8;
                    continue;
                  }
                  goto case 5;
                case 4:
                  child = EntityFormDependencyExtension.k43MtyGtJ2AcPG73meFm(EntityFormDependencyExtension.qpYolcGtyTvnmXgEvqEj((object) transformationChange));
                  num7 = 10;
                  continue;
                case 5:
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  FormDependencyHelper.GenerateFormDependencies(transformationChange.Value.ToString(), cDisplayClass43.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.objectUid, cDisplayClass43.dependFormUid, cDisplayClass43.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.deps);
                  num7 = 18;
                  continue;
                case 7:
                  transformationChange = current as ViewItemTransformationChange;
                  num7 = 14;
                  continue;
                case 9:
                  buttonViewItem = EntityFormDependencyExtension.xn2iF0GtHqhJKTCFjC8q((object) transformationAdd) as ButtonViewItem;
                  num7 = 22;
                  continue;
                case 10:
                  if (!EntityFormDependencyExtension.RWmbadGt9VZUYtQ75w9S(child, (Type) null))
                  {
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 7 : 17;
                    continue;
                  }
                  goto case 2;
                case 12:
                  if (!EntityFormDependencyExtension.wWrpX3GtMUicGOW5RIPV(EntityFormDependencyExtension.qpYolcGtyTvnmXgEvqEj((object) transformationChange)))
                  {
                    num7 = 4;
                    continue;
                  }
                  goto label_38;
                case 13:
                  if (transformationAdd != null)
                  {
                    num7 = 9;
                    continue;
                  }
                  goto case 7;
                case 14:
                  if (transformationChange == null)
                  {
                    num7 = 6;
                    continue;
                  }
                  goto case 21;
                case 15:
                  if (!EntityFormDependencyExtension.x0EY7KGtxB05KCf3EGUW(EntityFormDependencyExtension.e8dghMGtAdVRu4UvSh3h((object) buttonViewItem), EntityFormDependencyExtension.ORsHhXGt75TFynGmxWFG(-1334993905 ^ -1334870737)))
                  {
                    num7 = 11;
                    continue;
                  }
                  goto case 20;
                case 16:
                  transformationAdd = current as ViewItemTransformationAdd;
                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 13 : 12;
                  continue;
                case 19:
                  goto label_42;
                case 20:
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  FormDependencyHelper.GenerateFormDependencies((string) EntityFormDependencyExtension.tLflr2Gt05Va6TifSE5V((object) buttonViewItem), cDisplayClass43.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.objectUid, cDisplayClass43.dependFormUid, cDisplayClass43.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.deps);
                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 1;
                  continue;
                case 21:
                  if (!EntityFormDependencyExtension.x0EY7KGtxB05KCf3EGUW(EntityFormDependencyExtension.XdFSYAGtmUg9TSivVIx8((object) transformationChange), EntityFormDependencyExtension.ORsHhXGt75TFynGmxWFG(1051276242 - 990076387 ^ 61221847)))
                  {
                    num7 = 3;
                    continue;
                  }
                  goto case 12;
                case 22:
                  if (buttonViewItem != null)
                  {
                    num7 = 15;
                    continue;
                  }
                  goto label_38;
                default:
                  goto label_62;
              }
            }
label_39:
            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
            goto label_26;
label_42:
            current = enumerator2.Current;
            num7 = 16;
            goto label_26;
          }
          finally
          {
            enumerator2.Dispose();
            int num8 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
              num8 = 0;
            switch (num8)
            {
              default:
            }
          }
label_21:
          // ISSUE: object of a compiler-generated type is created
          cDisplayClass42 = new EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass4_2();
          num5 = 9;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
          {
            num5 = 4;
            goto label_16;
          }
          else
            goto label_16;
label_63:
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 2 : 5;
          goto label_16;
        }
        finally
        {
          enumerator1.Dispose();
          int num9 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
            num9 = 0;
          switch (num9)
          {
            default:
          }
        }
label_87:
        guidList = new List<Guid>();
        num1 = 8;
        continue;
label_91:
        // ISSUE: reference to a compiler-generated method
        metadata1.Forms.ForEach(new Action<FormViewItem>(cDisplayClass40.\u003CGenerateNewDependencies\u003Eb__0));
        num1 = 11;
      }
label_13:
      return;
label_88:
      return;
label_86:
      return;
label_80:
      return;
label_84:;
    }

    public IEnumerable<Guid> GetFormUids(Guid uid)
    {
      List<Guid> result = new List<Guid>();
      ClassMetadata cMd = this.metadataRuntimeService.GetMetadata(uid, false) as ClassMetadata;
      if (cMd == null)
        return (IEnumerable<Guid>) result;
      cMd.Forms.ForEach((Action<FormViewItem>) (q =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              // ISSUE: reference to a compiler-generated method
              result.Add(EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass5_0.lNPc018otDkCdaLybJjE((object) q));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      cMd.FormTransformations.ForEach((Action<FormViewItemTransformation>) (q =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              result.Add(EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass5_0.nAM7kv8o4QygKLxSv58u(EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass5_0.baaP8g8owqCUx49hyEXc((object) q), Guid.Empty) ? EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass5_0.baaP8g8owqCUx49hyEXc((object) q) : q.Uid);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      EntityMetadata entityMetadata = this.metadataRuntimeService.GetMetadataList().OfType<EntityMetadata>().FirstOrDefault<EntityMetadata>((Func<EntityMetadata, bool>) (q =>
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (q.Type == EntityMetadataType.InterfaceExtension)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            case 2:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass5_0.WK1qx78oA6mLSUVMDYlU(EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass5_0.jmLVWr8o6YLdvUUDBJDY((object) q), EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass5_0.lQt86N8oHBJarWpfCAnB((object) cMd)))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 1 : 1;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass5_0.micbn28oxLIR8SHkHyNu(EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass5_0.cLCQ9c8o7FMAowfEjhpq((object) q), (object) ((string) EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass5_0.cLCQ9c8o7FMAowfEjhpq((object) cMd) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1515137947)));
label_5:
        return false;
      }));
      if (entityMetadata == null)
        return (IEnumerable<Guid>) result;
      entityMetadata.Forms.ForEach((Action<FormViewItem>) (q =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              // ISSUE: reference to a compiler-generated method
              result.Add(EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass5_0.lNPc018otDkCdaLybJjE((object) q));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      entityMetadata.FormTransformations.ForEach((Action<FormViewItemTransformation>) (q =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_4;
            case 1:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              result.Add(!EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass5_0.nAM7kv8o4QygKLxSv58u(EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass5_0.baaP8g8owqCUx49hyEXc((object) q), Guid.Empty) ? q.Uid : EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass5_0.baaP8g8owqCUx49hyEXc((object) q));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_4:
        return;
label_2:;
      }));
      return (IEnumerable<Guid>) result;
    }

    public IEnumerable<IFormDependencyData> GetDependenciesForBaseClasses(
      Guid dependObjectUid,
      Guid dependObjectFormUid,
      IMetadata usesObjectMetadata,
      Guid usesObjectFormUid,
      FormDependencyDataType type)
    {
      // ISSUE: reference to a compiler-generated method
      return !(usesObjectMetadata is ClassMetadata metadata) ? (IEnumerable<IFormDependencyData>) new List<IFormDependencyData>() : (IEnumerable<IFormDependencyData>) MetadataLoader.GetBaseClassMetadataList(metadata, false, false).Select<ClassMetadata, FormDependencyData>((Func<ClassMetadata, FormDependencyData>) (q => new FormDependencyData(dependObjectUid, dependObjectFormUid, EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass6_0.U6483n8oJGdQLBvy41Fc((object) q), usesObjectFormUid, type)));
    }

    public IEnumerable<IFormDependencyData> GetDependenciesForBaseClasses(
      Guid dependObjectUid,
      Guid dependObjectFormUid,
      Guid usesObjectUid,
      Guid usesObjectFormUid,
      FormDependencyDataType type)
    {
      IMetadata metadata = this.metadataRuntimeService.GetMetadata(usesObjectUid, false);
      return this.GetDependenciesForBaseClasses(dependObjectUid, dependObjectFormUid, metadata, usesObjectFormUid, type);
    }

    public bool ExistForm(Guid objectUid, Guid formUid)
    {
      int num1 = 11;
      bool flag1;
      bool flag2;
      while (true)
      {
        int num2 = num1;
        ViewType viewType;
        EntityMetadata eMd;
        while (true)
        {
          EntityMetadata entityMetadata;
          int num3;
          int num4;
          Guid formUid1;
          switch (num2)
          {
            case 1:
              num3 = entityMetadata.FormTransformations.Any<FormViewItemTransformation>((Func<FormViewItemTransformation, bool>) (q =>
              {
                int num5 = 1;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      if (!EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass8_0.L2wRHi8o5u6JDTb4qYJV(q.Uid, formUid1))
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_3;
                    default:
                      goto label_2;
                  }
                }
label_2:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                return EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass8_0.L2wRHi8o5u6JDTb4qYJV(EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass8_0.IL7NTf8osbOd9mL2VZBM((object) q), formUid1);
label_3:
                return true;
              })) ? 1 : 0;
              goto label_40;
            case 2:
            case 5:
            case 7:
              goto label_33;
            case 3:
              goto label_23;
            case 4:
            case 8:
            case 15:
              goto label_25;
            case 6:
              if (entityMetadata == null)
              {
                num2 = 7;
                continue;
              }
              goto case 19;
            case 9:
label_36:
              viewType = FormDependencyHelper.GuidToViewType(formUid1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 13 : 11;
              continue;
            case 10:
              formUid1 = formUid;
              num2 = 16;
              continue;
            case 11:
              num2 = 10;
              continue;
            case 12:
              num4 = eMd.FormTransformations.Any<FormViewItemTransformation>((Func<FormViewItemTransformation, bool>) (q =>
              {
                int num6 = 2;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      goto label_5;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      if (EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass8_0.L2wRHi8o5u6JDTb4qYJV(q.Uid, formUid1))
                      {
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 1;
                        continue;
                      }
                      goto label_4;
                    default:
                      goto label_4;
                  }
                }
label_4:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                return EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass8_0.L2wRHi8o5u6JDTb4qYJV(EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass8_0.IL7NTf8osbOd9mL2VZBM((object) q), formUid1);
label_5:
                return true;
              })) ? 1 : 0;
              break;
            case 13:
              if (viewType != ViewType.All)
              {
                num2 = 3;
                continue;
              }
              // ISSUE: reference to a compiler-generated method
              if (!eMd.Forms.Any<FormViewItem>((Func<FormViewItem, bool>) (q => EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass8_0.L2wRHi8o5u6JDTb4qYJV(q.Uid, formUid1))))
              {
                num2 = 12;
                continue;
              }
              num4 = 1;
              break;
            case 14:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (!entityMetadata.Forms.Any<FormViewItem>((Func<FormViewItem, bool>) (q => EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass8_0.L2wRHi8o5u6JDTb4qYJV(EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass8_0.rGHnCx8ocKbRYFGs2vVL((object) q), formUid1))))
                goto case 1;
              else
                goto label_4;
            case 16:
              try
              {
                eMd = this.metadataRuntimeService.GetMetadata(objectUid, false) as EntityMetadata;
                int num7 = 3;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                    case 2:
                      entityMetadata = this.metadataRuntimeService.GetMetadataList().OfType<EntityMetadata>().FirstOrDefault<EntityMetadata>((Func<EntityMetadata, bool>) (q =>
                      {
                        int num8 = 1;
                        while (true)
                        {
                          switch (num8)
                          {
                            case 1:
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              if (!EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass8_0.L2wRHi8o5u6JDTb4qYJV(EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass8_0.LdF8Mj8or6CPMsVlLMkW((object) q), EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass8_0.jV3Dk08ogGm3IYUOrMXw((object) eMd)))
                              {
                                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
                                continue;
                              }
                              goto case 3;
                            case 2:
                              goto label_2;
                            case 3:
                              // ISSUE: reference to a compiler-generated method
                              if (EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass8_0.iGkanK8ojJBEi1pUragY((object) q) == EntityMetadataType.InterfaceExtension)
                              {
                                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 2 : 0;
                                continue;
                              }
                              goto label_3;
                            default:
                              goto label_3;
                          }
                        }
label_2:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        return EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass8_0.D1kVAe8oUAHClsjiiGah(EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass8_0.LEMGyu8oYp9eyrakQH6i((object) q), (object) ((string) EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass8_0.LEMGyu8oYp9eyrakQH6i((object) eMd) + (string) EntityFormDependencyExtension.\u003C\u003Ec__DisplayClass8_0.WNVWvU8oLsVfOmPuWQuh(1597012150 ^ 1597188100)));
label_3:
                        return false;
                      }));
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
                      continue;
                    case 3:
                      if (eMd != null)
                      {
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 2;
                        continue;
                      }
                      goto case 4;
                    case 4:
                      flag2 = false;
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 2 : 5;
                      continue;
                    case 5:
                      goto label_26;
                    default:
                      goto label_36;
                  }
                }
              }
              catch (Exception ex)
              {
                int num9 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
                  num9 = 1;
                while (true)
                {
                  switch (num9)
                  {
                    case 1:
                      flag2 = false;
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_26;
                  }
                }
              }
            case 17:
              if (entityMetadata == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 6 : 8;
                continue;
              }
              goto case 14;
            case 18:
              num3 = 1;
              goto label_40;
            case 19:
              flag1 = EntityFormDependencyExtension.NJcdfoGt6qrjgEchMNUU(EntityFormDependencyExtension.KBBw3cGtrp27XsNTAIgN(EntityFormDependencyExtension.Ycv9WwGtlHOMumwKnGnk((object) entityMetadata), viewType), Guid.Empty);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 2 : 2;
              continue;
            case 20:
              if (flag1)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 3 : 5;
                continue;
              }
              goto case 6;
            default:
              if (flag1)
              {
                num2 = 4;
                continue;
              }
              goto case 17;
          }
          flag1 = num4 != 0;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
          continue;
label_40:
          flag1 = num3 != 0;
          num2 = 15;
        }
label_4:
        num1 = 18;
        continue;
label_23:
        flag1 = EntityFormDependencyExtension.NJcdfoGt6qrjgEchMNUU(EntityFormDependencyExtension.KBBw3cGtrp27XsNTAIgN(EntityFormDependencyExtension.Ycv9WwGtlHOMumwKnGnk((object) eMd), viewType), Guid.Empty);
        num1 = 20;
      }
label_25:
      return flag1;
label_26:
      return flag2;
label_33:
      return flag1;
    }

    internal static bool lbdGSdGtNHU1AcOyrTf8() => EntityFormDependencyExtension.b7ApDiGt1gFdYOBOuTpM == null;

    internal static EntityFormDependencyExtension aJAErpGt3XEkhZ4YL3eL() => EntityFormDependencyExtension.b7ApDiGt1gFdYOBOuTpM;

    internal static object bHYPKnGtpkN1NSk8MEXa() => (object) Logger.Log;

    internal static void swm4FPGtaBlK54xMc56M([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static EntityMetadataType HvOOOOGtDO9WFKXAOv18([In] object obj0) => ((EntityMetadata) obj0).Type;

    internal static Guid xyV7rNGttohHDK9LejNO([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

    internal static bool AlcxXyGtwa7E3e2tpCF5([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static Guid yURfTeGt4vbyDoux876x([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static bool NJcdfoGt6qrjgEchMNUU([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object xn2iF0GtHqhJKTCFjC8q([In] object obj0) => (object) ((ViewItemTransformationAdd) obj0).Item;

    internal static object e8dghMGtAdVRu4UvSh3h([In] object obj0) => (object) ((ButtonViewItem) obj0).ActionTypeProviderId;

    internal static object ORsHhXGt75TFynGmxWFG(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool x0EY7KGtxB05KCf3EGUW([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object tLflr2Gt05Va6TifSE5V([In] object obj0) => (object) ((ButtonViewItem) obj0).ActionId;

    internal static object XdFSYAGtmUg9TSivVIx8([In] object obj0) => (object) ((ViewItemTransformationChange) obj0).PropertyName;

    internal static object qpYolcGtyTvnmXgEvqEj([In] object obj0) => (object) ((ViewItemTransformationChange) obj0).TypeName;

    internal static bool wWrpX3GtMUicGOW5RIPV([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static Type k43MtyGtJ2AcPG73meFm([In] object obj0) => Type.GetType((string) obj0);

    internal static bool RWmbadGt9VZUYtQ75w9S([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object KjYOdYGtdQEq0iLdyjpK([In] object obj0) => (object) ((List<IFormDependencyData>) obj0).ToArray();

    internal static object Ycv9WwGtlHOMumwKnGnk([In] object obj0) => (object) ((ClassMetadata) obj0).DefaultForms;

    internal static Guid KBBw3cGtrp27XsNTAIgN([In] object obj0, ViewType viewType) => ((ClassDefaultForms) obj0).GetFormUid(viewType);
  }
}
