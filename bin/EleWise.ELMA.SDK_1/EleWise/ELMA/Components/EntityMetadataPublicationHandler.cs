// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Components.EntityMetadataPublicationHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Components
{
  /// <summary>Обработчик публикации метаданных сущности</summary>
  [Component]
  internal sealed class EntityMetadataPublicationHandler : IPublicationHandler
  {
    private readonly IEntityMetadataDependencyService entityMetadataDependencyService;
    private readonly IActorContextService actorContextService;
    private static EntityMetadataPublicationHandler eGYVdyfbdMB7vbjUvTgN;

    /// <summary>Ctor</summary>
    /// <param name="entityMetadataDependencyService">Сервис сбора зависимостей для сущностей</param>
    /// <param name="actorContextService">Сервис контекста исполнения в акторе</param>
    public EntityMetadataPublicationHandler(
      IEntityMetadataDependencyService entityMetadataDependencyService,
      IActorContextService actorContextService)
    {
      EntityMetadataPublicationHandler.LMbB40fbgQacXCMksrG1();
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
            this.entityMetadataDependencyService = entityMetadataDependencyService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
            continue;
          default:
            this.actorContextService = actorContextService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc />
    public void UpdateMetadata(IMetadata metadata)
    {
      int num1 = 11;
      while (true)
      {
        int num2 = num1;
        EntityMetadata entityMetadata;
        List<ComputedValue>.Enumerator enumerator1;
        List<FormViewItemTransformation> itemTransformationList;
        List<FormViewItemTransformation>.Enumerator enumerator2;
        while (true)
        {
          List<FormViewItem> formViewItemList;
          List<FormViewItem>.Enumerator enumerator3;
          List<PropertyMetadata>.Enumerator enumerator4;
          DataClassMetadata dataClassMetadata;
          switch (num2)
          {
            case 1:
              try
              {
label_24:
                if (enumerator4.MoveNext())
                  goto label_27;
                else
                  goto label_25;
label_11:
                IViewModelPropertyMetadata current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                    case 4:
                      goto label_24;
                    case 2:
                      goto label_14;
                    case 3:
                      if (current == null)
                      {
                        num3 = 4;
                        continue;
                      }
                      break;
                    case 5:
                      goto label_27;
                    case 6:
                      enumerator1 = current.ComputedValues.GetEnumerator();
                      num3 = 2;
                      continue;
                    case 7:
                      goto label_159;
                  }
                  EntityMetadataPublicationHandler.GBjRKtfbLmstDEJnUToW(EntityMetadataPublicationHandler.jNhqJhfbjNq2gNpOY6oV((object) current), EntityMetadataPublicationHandler.xw5RKtfbYgIYNZSCTyyP((object) entityMetadata));
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 6;
                }
label_14:
                try
                {
label_18:
                  if (enumerator1.MoveNext())
                    goto label_16;
                  else
                    goto label_19;
label_15:
                  int num4;
                  switch (num4)
                  {
                    case 1:
                      goto label_18;
                    case 2:
                      break;
                    default:
                      goto label_24;
                  }
label_16:
                  EntityMetadataPublicationHandler.GBjRKtfbLmstDEJnUToW((object) enumerator1.Current, EntityMetadataPublicationHandler.xw5RKtfbYgIYNZSCTyyP((object) entityMetadata));
                  num4 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
                  {
                    num4 = 0;
                    goto label_15;
                  }
                  else
                    goto label_15;
label_19:
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
                  goto label_15;
                }
                finally
                {
                  enumerator1.Dispose();
                  int num5 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
                    num5 = 0;
                  switch (num5)
                  {
                    default:
                  }
                }
label_25:
                num3 = 7;
                goto label_11;
label_27:
                current = enumerator4.Current as IViewModelPropertyMetadata;
                num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
                {
                  num3 = 3;
                  goto label_11;
                }
                else
                  goto label_11;
              }
              finally
              {
                enumerator4.Dispose();
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                }
              }
            case 2:
              goto label_6;
            case 3:
              goto label_122;
            case 4:
label_158:
              entityMetadata.Forms = formViewItemList;
              num2 = 5;
              continue;
            case 5:
              EntityMetadataPublicationHandler.BsK2ALfhfOeFAHhT723h((object) entityMetadata);
              num2 = 6;
              continue;
            case 6:
              goto label_157;
            case 7:
label_159:
              List<FormViewItemTransformation> formTransformations = entityMetadata.FormTransformations;
              itemTransformationList = new List<FormViewItemTransformation>(EntityMetadataPublicationHandler.CWBPlrfbUEYOiaMIWy8O((object) formTransformations));
              enumerator2 = formTransformations.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 7 : 13;
              continue;
            case 8:
              List<FormViewItem> forms = entityMetadata.Forms;
              formViewItemList = new List<FormViewItem>(forms.Count);
              enumerator3 = forms.GetEnumerator();
              num2 = 12;
              continue;
            case 9:
              dataClassMetadata = (DataClassMetadata) null;
              break;
            case 10:
              if (entityMetadata == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 9 : 6;
                continue;
              }
              dataClassMetadata = entityMetadata.ViewModelMetadata;
              break;
            case 11:
              entityMetadata = metadata as EntityMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 10 : 9;
              continue;
            case 12:
              try
              {
label_125:
                if (enumerator3.MoveNext())
                  goto label_150;
                else
                  goto label_126;
label_124:
                IEnumerator<ViewItem> enumerator5;
                FormViewItem current;
                int num7;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      enumerator5 = current.GetAllItems(false).GetEnumerator();
                      num7 = 4;
                      continue;
                    case 2:
                      goto label_125;
                    case 3:
                      goto label_150;
                    case 4:
                      try
                      {
label_131:
                        if (EntityMetadataPublicationHandler.r93FGFfhhWR0Q1DgYXkF((object) enumerator5))
                          goto label_129;
                        else
                          goto label_132;
label_128:
                        int num8;
                        switch (num8)
                        {
                          case 1:
                            break;
                          case 2:
                            goto label_131;
                          case 3:
                            goto label_149;
                          default:
                            try
                            {
label_136:
                              if (enumerator1.MoveNext())
                                goto label_138;
                              else
                                goto label_137;
label_135:
                              int num9;
                              switch (num9)
                              {
                                case 1:
                                  goto label_131;
                                case 2:
                                  goto label_136;
                                default:
                                  goto label_138;
                              }
label_137:
                              num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 1;
                              goto label_135;
label_138:
                              EntityMetadataPublicationHandler.GBjRKtfbLmstDEJnUToW((object) enumerator1.Current, EntityMetadataPublicationHandler.xw5RKtfbYgIYNZSCTyyP((object) entityMetadata));
                              num9 = 2;
                              goto label_135;
                            }
                            finally
                            {
                              enumerator1.Dispose();
                              int num10 = 0;
                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
                                num10 = 0;
                              switch (num10)
                              {
                                default:
                              }
                            }
                        }
label_129:
                        enumerator1 = enumerator5.Current.DynamicProperties.GetEnumerator();
                        num8 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
                        {
                          num8 = 0;
                          goto label_128;
                        }
                        else
                          goto label_128;
label_132:
                        num8 = 3;
                        goto label_128;
                      }
                      finally
                      {
                        int num11;
                        if (enumerator5 == null)
                          num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
                        else
                          goto label_146;
label_145:
                        switch (num11)
                        {
                          case 1:
                            break;
                          default:
                        }
label_146:
                        EntityMetadataPublicationHandler.OAM81ofhGCsyVuD0tB6B((object) enumerator5);
                        num11 = 2;
                        goto label_145;
                      }
                    case 5:
label_149:
                      formViewItemList.Add((FormViewItem) EntityMetadataPublicationHandler.mj0A5SfhE5gyjteFCy7Z((object) current));
                      num7 = 2;
                      continue;
                    default:
                      goto label_158;
                  }
                }
label_126:
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
                goto label_124;
label_150:
                current = enumerator3.Current;
                num7 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
                {
                  num7 = 1;
                  goto label_124;
                }
                else
                  goto label_124;
              }
              finally
              {
                enumerator3.Dispose();
                int num12 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
                  num12 = 0;
                switch (num12)
                {
                  default:
                }
              }
            case 13:
              goto label_34;
            default:
              enumerator4 = ((ClassMetadata) EntityMetadataPublicationHandler.jUvWshfb5TguUTfs4Uw1((object) entityMetadata)).Properties.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 1;
              continue;
          }
          if (dataClassMetadata != null)
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
          else
            goto label_155;
        }
label_34:
        try
        {
label_115:
          if (enumerator2.MoveNext())
            goto label_114;
          else
            goto label_116;
label_35:
          FormViewItemTransformation current1;
          int num13;
          while (true)
          {
            List<ViewItemTransformation>.Enumerator enumerator6;
            switch (num13)
            {
              case 1:
                goto label_115;
              case 2:
                enumerator6 = current1.Items.GetEnumerator();
                num13 = 5;
                continue;
              case 3:
                goto label_122;
              case 4:
                goto label_114;
              case 5:
                try
                {
label_63:
                  if (enumerator6.MoveNext())
                    goto label_53;
                  else
                    goto label_64;
label_39:
                  ViewItemTransformation current2;
                  int num14;
                  while (true)
                  {
                    ComputedValueTransformation valueTransformation;
                    List<BaseTransformation<ComputedValue, string>> collection;
                    List<BaseTransformation<ComputedValue, string>>.Enumerator enumerator7;
                    List<ComputedValue> computedValueList;
                    switch (num14)
                    {
                      case 1:
                        object obj1 = EntityMetadataPublicationHandler.Q5umeSfbspb4rFLyjrVj((object) transformationAdd1);
                        if (obj1 == null)
                        {
                          num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
                          continue;
                        }
                        computedValueList = ((ViewItem) obj1).DynamicProperties;
                        break;
                      case 2:
                      case 15:
                        if (!(current2 is ViewItemTransformationChange transformationChange1))
                        {
                          num14 = 9;
                          continue;
                        }
                        goto case 6;
                      case 3:
                      case 9:
                      case 11:
                        goto label_63;
                      case 4:
                        try
                        {
label_90:
                          if (enumerator7.MoveNext())
                            goto label_82;
                          else
                            goto label_91;
label_67:
                          BaseTransformation<ComputedValue, string> current3;
                          int num15;
                          while (true)
                          {
                            int num16;
                            ComputedValueTransformationChange transformationChange2;
                            // ISSUE: variable of a compiler-generated type
                            EntityMetadataPublicationHandler.\u003C\u003Ec__DisplayClass3_0 cDisplayClass30;
                            string calculateScript;
                            // ISSUE: variable of a compiler-generated type
                            EntityMetadataPublicationHandler.\u003C\u003Ec__DisplayClass3_1 cDisplayClass31;
                            string methodName;
                            ComputedValueType computedValueType;
                            object obj2;
                            switch (num15)
                            {
                              case 1:
                                goto label_82;
                              case 2:
                              case 5:
                              case 7:
                              case 14:
                              case 20:
                              case 23:
                                goto label_90;
                              case 3:
                                // ISSUE: reference to a compiler-generated field
                                calculateScript = EntityMetadataPublicationHandler.TY2HAifho5enDVVvt1bo((object) cDisplayClass30.computedValueTransformationChange) as string;
                                num15 = 22;
                                continue;
                              case 4:
                                // ISSUE: reference to a compiler-generated method
                                if (valueTransformation.Items.Find(new Predicate<BaseTransformation<ComputedValue, string>>(cDisplayClass31.\u003CUpdateMetadata\u003Eb__1)) is ComputedValueTransformationChange transformationChange3)
                                {
                                  num15 = 17;
                                  continue;
                                }
                                goto case 13;
                              case 6:
                                // ISSUE: reference to a compiler-generated field
                                cDisplayClass31.CS\u0024\u003C\u003E8__locals1 = cDisplayClass30;
                                num15 = 10;
                                continue;
                              case 8:
                                // ISSUE: object of a compiler-generated type is created
                                cDisplayClass30 = new EntityMetadataPublicationHandler.\u003C\u003Ec__DisplayClass3_0();
                                num15 = 11;
                                continue;
                              case 9:
                                ComputedValueHelper.SetCalculateScriptMethodName((IComputedValue) transformationAdd.Item, EntityMetadataPublicationHandler.xw5RKtfbYgIYNZSCTyyP((object) entityMetadata));
                                num15 = 14;
                                continue;
                              case 10:
                                methodName = ComputedValueHelper.GenerateMethodName(calculateScript, entityMetadata.Uid);
                                num16 = 15;
                                break;
                              case 11:
                                if (!(current3 is ComputedValueTransformationAdd transformationAdd))
                                {
                                  num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 22 : 26;
                                  continue;
                                }
                                goto case 9;
                              case 12:
                                if (!((obj2 = transformationChange4.Value) is ComputedValueType))
                                {
                                  num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 5 : 3;
                                  continue;
                                }
                                goto default;
                              case 13:
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                collection.Add(Transformation<ComputedValue, ComputedValueTransformation, string, string>.SetPropertyValue(cDisplayClass31.CS\u0024\u003C\u003E8__locals1.computedValueTransformationChange.Uid, cDisplayClass31.methodPropertyName, (object) methodName));
                                num15 = 20;
                                continue;
                              case 15:
                                // ISSUE: reference to a compiler-generated field
                                cDisplayClass31.methodPropertyName = (string) EntityMetadataPublicationHandler.E8J4mLfbzk6On3e4r29t(-1120607109 - 305487170 ^ -1426203349);
                                num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 4 : 0;
                                continue;
                              case 16:
                                // ISSUE: reference to a compiler-generated method
                                if (!(valueTransformation.Items.Find(new Predicate<BaseTransformation<ComputedValue, string>>(cDisplayClass30.\u003CUpdateMetadata\u003Eb__0)) is ComputedValueTransformationChange transformationChange4))
                                {
                                  num15 = 23;
                                  continue;
                                }
                                goto case 12;
                              case 17:
                                EntityMetadataPublicationHandler.r3UKBhfhbde17fVRAJJH((object) transformationChange3, (object) methodName);
                                num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 2 : 2;
                                continue;
                              case 18:
                                // ISSUE: reference to a compiler-generated field
                                if (!EntityMetadataPublicationHandler.gyUECNfhFCHmaxtTZ1rt(EntityMetadataPublicationHandler.x0qg7IfhWyxGNHYfW7AL((object) cDisplayClass30.computedValueTransformationChange), EntityMetadataPublicationHandler.E8J4mLfbzk6On3e4r29t(372753449 ^ 372612611)))
                                {
                                  num15 = 3;
                                  continue;
                                }
                                goto label_90;
                              case 19:
                                if (transformationChange2 == null)
                                {
                                  num15 = 7;
                                  continue;
                                }
                                goto case 18;
                              case 21:
                                goto label_50;
                              case 22:
                                if (calculateScript != null)
                                {
                                  num16 = 16;
                                  break;
                                }
                                goto label_90;
                              case 24:
                                // ISSUE: object of a compiler-generated type is created
                                cDisplayClass31 = new EntityMetadataPublicationHandler.\u003C\u003Ec__DisplayClass3_1();
                                num16 = 6;
                                break;
                              case 25:
                                if (computedValueType == ComputedValueType.CalculateScript)
                                {
                                  num15 = 24;
                                  continue;
                                }
                                goto label_90;
                              case 26:
                              case 27:
                                // ISSUE: reference to a compiler-generated field
                                cDisplayClass30.computedValueTransformationChange = transformationChange2 = current3 as ComputedValueTransformationChange;
                                num16 = 19;
                                break;
                              default:
                                computedValueType = (ComputedValueType) obj2;
                                num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 15 : 25;
                                continue;
                            }
                            num15 = num16;
                          }
label_82:
                          current3 = enumerator7.Current;
                          num15 = 8;
                          goto label_67;
label_91:
                          num15 = 21;
                          goto label_67;
                        }
                        finally
                        {
                          enumerator7.Dispose();
                          int num17 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
                            num17 = 0;
                          switch (num17)
                          {
                            default:
                          }
                        }
                      case 5:
label_50:
                        valueTransformation.Items.AddRange((IEnumerable<BaseTransformation<ComputedValue, string>>) collection);
                        num14 = 11;
                        continue;
                      case 6:
                        if (!EntityMetadataPublicationHandler.gyUECNfhFCHmaxtTZ1rt(EntityMetadataPublicationHandler.M72ScJfbc0CQOlS5te90((object) transformationChange1), EntityMetadataPublicationHandler.E8J4mLfbzk6On3e4r29t(572119659 - -337058038 ^ 909283507)))
                        {
                          num14 = 14;
                          continue;
                        }
                        goto label_63;
                      case 7:
                        if (valueTransformation != null)
                        {
                          num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 18 : 5;
                          continue;
                        }
                        goto label_63;
                      case 8:
                        if (!(current2 is ViewItemTransformationAdd transformationAdd1))
                        {
                          num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 2 : 2;
                          continue;
                        }
                        goto case 1;
                      case 10:
                        goto label_40;
                      case 12:
                        enumerator7 = valueTransformation.Items.GetEnumerator();
                        num14 = 4;
                        continue;
                      case 13:
                        goto label_53;
                      case 14:
                        valueTransformation = EntityMetadataPublicationHandler.eA6t0ufhB0g606i4X77L((object) transformationChange1) as ComputedValueTransformation;
                        num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 7 : 4;
                        continue;
                      case 16:
                        goto label_37;
                      case 17:
label_102:
                        enumerator1 = ((ViewItem) EntityMetadataPublicationHandler.Q5umeSfbspb4rFLyjrVj((object) transformationAdd1)).DynamicProperties.GetEnumerator();
                        num14 = 10;
                        continue;
                      case 18:
                        collection = new List<BaseTransformation<ComputedValue, string>>();
                        num14 = 12;
                        continue;
                      default:
                        computedValueList = (List<ComputedValue>) null;
                        break;
                    }
                    if (computedValueList == null)
                      num14 = 3;
                    else
                      goto label_102;
                  }
label_40:
                  try
                  {
label_42:
                    if (enumerator1.MoveNext())
                      goto label_44;
                    else
                      goto label_43;
label_41:
                    int num18;
                    switch (num18)
                    {
                      case 1:
                        goto label_63;
                      case 2:
                        goto label_44;
                      default:
                        goto label_42;
                    }
label_43:
                    num18 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 1 : 1;
                    goto label_41;
label_44:
                    EntityMetadataPublicationHandler.GBjRKtfbLmstDEJnUToW((object) enumerator1.Current, EntityMetadataPublicationHandler.xw5RKtfbYgIYNZSCTyyP((object) entityMetadata));
                    num18 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
                    {
                      num18 = 0;
                      goto label_41;
                    }
                    else
                      goto label_41;
                  }
                  finally
                  {
                    enumerator1.Dispose();
                    int num19 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
                      num19 = 0;
                    switch (num19)
                    {
                      default:
                    }
                  }
label_53:
                  current2 = enumerator6.Current;
                  num14 = 4;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
                  {
                    num14 = 8;
                    goto label_39;
                  }
                  else
                    goto label_39;
label_64:
                  num14 = 16;
                  goto label_39;
                }
                finally
                {
                  enumerator6.Dispose();
                  int num20 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
                    num20 = 0;
                  switch (num20)
                  {
                    default:
                  }
                }
            }
label_37:
            itemTransformationList.Add(ClassSerializationHelper.CloneObjectByXml<FormViewItemTransformation>(current1));
            num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 0;
          }
label_114:
          current1 = enumerator2.Current;
          num13 = 2;
          goto label_35;
label_116:
          num13 = 3;
          goto label_35;
        }
        finally
        {
          enumerator2.Dispose();
          int num21 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
            num21 = 0;
          switch (num21)
          {
            default:
          }
        }
label_122:
        entityMetadata.FormTransformations = itemTransformationList;
        num1 = 8;
      }
label_6:
      return;
label_157:
      return;
label_155:;
    }

    /// <summary>Обновление поля IncludeList</summary>
    /// <param name="entityMetadata">Метаданные</param>
    internal static void UpdateIncludeList(EntityMetadata entityMetadata)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        DataClassDependency signature1;
        EntityMetadata entityMetadata1;
        EntityMetadata metadata;
        DataClassDependency signature2;
        DataClassDependency signature3;
        EntityMetadata realBaseMetadata;
        while (true)
        {
          switch (num2)
          {
            case 1:
              ((DataClassMetadata) EntityMetadataPublicationHandler.jUvWshfb5TguUTfs4Uw1((object) entityMetadata)).IncludeList.Clear();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
              continue;
            case 2:
              ((DataClassMetadata) EntityMetadataPublicationHandler.jUvWshfb5TguUTfs4Uw1((object) entityMetadata)).IncludeList.Add(signature1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 21 : 1;
              continue;
            case 3:
            case 11:
            case 15:
              if (EntityMetadataPublicationHandler.jUvWshfb5TguUTfs4Uw1((object) metadata) != null)
                goto case 18;
              else
                goto label_7;
            case 4:
              ((DataClassMetadata) EntityMetadataPublicationHandler.jUvWshfb5TguUTfs4Uw1((object) entityMetadata)).IncludeList.Add(signature3);
              num2 = 11;
              continue;
            case 5:
              signature1 = ((DataClassMetadata) EntityMetadataPublicationHandler.jUvWshfb5TguUTfs4Uw1((object) entityMetadata1)).GetSignature(true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 1 : 2;
              continue;
            case 6:
              if (EntityMetadataPublicationHandler.MsSlOjfhvbYubM1ImLlQ((object) entityMetadata) == EntityMetadataType.InterfaceExtension)
              {
                num2 = 13;
                continue;
              }
              goto case 3;
            case 7:
              ((DataClassMetadata) EntityMetadataPublicationHandler.jUvWshfb5TguUTfs4Uw1((object) entityMetadata)).IncludeList.Add(signature2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 18 : 19;
              continue;
            case 8:
              if (entityMetadata1 == null)
              {
                num2 = 17;
                continue;
              }
              goto case 10;
            case 9:
              goto label_4;
            case 10:
              if (EntityMetadataPublicationHandler.jUvWshfb5TguUTfs4Uw1((object) entityMetadata1) != null)
              {
                num2 = 5;
                continue;
              }
              goto case 17;
            case 12:
              goto label_13;
            case 13:
              if (!(EntityMetadataPublicationHandler.jRloVmfh8JO5a3FXtgXV((object) metadata) != Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 3 : 15;
                continue;
              }
              goto case 16;
            case 14:
              realBaseMetadata = (EntityMetadata) MetadataServiceContext.Service.GetMetadata(metadata.BaseClassUid, false);
              num2 = 22;
              continue;
            case 16:
              num2 = 14;
              continue;
            case 17:
            case 21:
              if (EntityMetadataPublicationHandler.jUvWshfb5TguUTfs4Uw1((object) realBaseMetadata) == null)
              {
                num2 = 3;
                continue;
              }
              goto label_13;
            case 18:
              signature2 = metadata.ViewModelMetadata.GetSignature(true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 7 : 4;
              continue;
            case 19:
              goto label_23;
            case 20:
              goto label_20;
            case 22:
              entityMetadata1 = MetadataServiceContext.Service.GetMetadataList().OfType<EntityMetadata>().FirstOrDefault<EntityMetadata>((Func<EntityMetadata, bool>) (m =>
              {
                int num3 = 2;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (EntityMetadataPublicationHandler.\u003C\u003Ec__DisplayClass4_0.QGbmB689wlVwlIA4XXYM(m.BaseClassUid, EntityMetadataPublicationHandler.\u003C\u003Ec__DisplayClass4_0.NMP8UF89to4Xdf9TFt9Y((object) realBaseMetadata)))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_7;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      if (EntityMetadataPublicationHandler.\u003C\u003Ec__DisplayClass4_0.NasO3h89DnV2IIBtY3Da((object) m) == EntityMetadataType.InterfaceExtension)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 1;
                        continue;
                      }
                      goto label_7;
                    default:
                      goto label_6;
                  }
                }
label_6:
                // ISSUE: reference to a compiler-generated method
                return EntityMetadataPublicationHandler.\u003C\u003Ec__DisplayClass4_0.Nc7gOM894WNau04Hm6pH((object) MetadataServiceContext.Service, m.Uid);
label_7:
                return false;
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 3 : 8;
              continue;
            default:
              if (!EntityMetadataPublicationHandler.xjMUoYfhQxriY1UpjlCs(entityMetadata.BaseClassUid, Guid.Empty))
              {
                metadata = (EntityMetadata) ((IMetadataService) EntityMetadataPublicationHandler.Nl1NihfhCnQkIYwotTNa()).GetMetadata(entityMetadata.BaseClassUid, false);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 6 : 1;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 2 : 9;
              continue;
          }
        }
label_7:
        num1 = 20;
        continue;
label_13:
        signature3 = realBaseMetadata.ViewModelMetadata.GetSignature(true);
        num1 = 4;
      }
label_4:
      return;
label_23:
      return;
label_20:;
    }

    /// <inheritdoc />
    public void UpdateMetadataItem(IMetadataItem source, IMetadataItem destination)
    {
      int num = 11;
      while (true)
      {
        ScriptModule scriptModule1;
        EntityMetadata metadata1;
        object obj1;
        switch (num)
        {
          case 1:
          case 10:
            EntityMetadataPublicationHandler.VcCHJZfhic6U6y1lKvix((object) destination, (object) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 9 : 0;
            continue;
          case 2:
            if (metadata1 != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 2 : 4;
              continue;
            }
            goto case 7;
          case 3:
            scriptModule1.ObjectUid = EntityMetadataPublicationHandler.FdKWI7fhSgQh3rlxTCRS((object) metadata2);
            num = 5;
            continue;
          case 4:
            obj1 = EntityMetadataPublicationHandler.jUvWshfb5TguUTfs4Uw1((object) metadata1);
            break;
          case 5:
            EntityMetadataPublicationHandler.VcCHJZfhic6U6y1lKvix((object) destination, (object) scriptModule1);
            num = 12;
            continue;
          case 6:
            this.CollectDependencies(metadata1, destination);
            num = 13;
            continue;
          case 7:
            obj1 = (object) null;
            break;
          case 8:
            ScriptModule scriptModule2 = scriptModule1;
            object obj2 = EntityMetadataPublicationHandler.VOOC4hfhZJ4mxcHcpDne((object) destination);
            Guid guid = obj2 != null ? EntityMetadataPublicationHandler.QrxXSyfhIysdM3haO23X(obj2) : EntityMetadataPublicationHandler.GLh3TufhuYwxX5dYWdV9();
            EntityMetadataPublicationHandler.wIa63wfhVT3lArQU8VjB((object) scriptModule2, guid);
            num = 14;
            continue;
          case 9:
          case 12:
            metadata1 = EntityMetadataPublicationHandler.MQmLurfhRjHMN3kVM2Y8((object) destination) as EntityMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 2 : 2;
            continue;
          case 11:
            if (EntityMetadataPublicationHandler.VOOC4hfhZJ4mxcHcpDne((object) source) == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 10;
              continue;
            }
            goto default;
          case 13:
            goto label_9;
          case 14:
            ScriptModule scriptModule3 = scriptModule1;
            object obj3 = EntityMetadataPublicationHandler.VOOC4hfhZJ4mxcHcpDne((object) destination);
            long id = obj3 == null ? 0L : ((Entity<long>) obj3).Id;
            scriptModule3.Id = id;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 3 : 15;
            continue;
          case 15:
            if (destination.Metadata is IMetadata metadata2)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 3 : 3;
              continue;
            }
            goto case 5;
          case 16:
            goto label_19;
          default:
            scriptModule1 = CloneHelperBuilder.Create<ScriptModule>(source.ScriptModule).Clone();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 8 : 8;
            continue;
        }
        if (obj1 != null)
        {
          EntityMetadataPublicationHandler.rE5VkefhKPyrXELCDBLe(EntityMetadataPublicationHandler.jUvWshfb5TguUTfs4Uw1((object) metadata1), EntityMetadataPublicationHandler.TMalPvfhqrQbhKkMP3ob(EntityMetadataPublicationHandler.E8J4mLfbzk6On3e4r29t(-1839087379 - 334718690 ^ 2120972301), (object) destination.Header.Id));
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 6;
        }
        else
          num = 16;
      }
label_9:
      return;
label_19:;
    }

    private void CollectDependencies(EntityMetadata metadata, IMetadataItem destination)
    {
      int num1 = 1;
      ICollection<IMetadata> metadataDependencies;
      MetadataServiceContext metadataServiceContext;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (!this.actorContextService.TryGet(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812006774), out object _))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
              continue;
            }
            goto label_11;
          case 2:
            if (EntityMetadataPublicationHandler.HZiy8WfhXXtYJXZIe39R((object) metadataDependencies) > 0)
            {
              num1 = 4;
              continue;
            }
            goto case 5;
          case 3:
            goto label_16;
          case 4:
            metadataServiceContext = MetadataServiceContext.Extend((IEnumerable<IMetadata>) metadataDependencies);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 6 : 4;
            continue;
          case 5:
            EntityMetadataPublicationHandler.gMLZsXfhTL3dvGwFIP35((object) this.entityMetadataDependencyService, (object) metadata, (object) destination);
            num1 = 3;
            continue;
          case 6:
            goto label_7;
          default:
            metadataDependencies = EntityMetadataDependencyService.GetPromisedMetadataDependencies(this.actorContextService);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 2 : 2;
            continue;
        }
      }
label_16:
      return;
label_11:
      return;
label_7:
      try
      {
        EntityMetadataPublicationHandler.gMLZsXfhTL3dvGwFIP35((object) this.entityMetadataDependencyService, (object) metadata, (object) destination);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        if (metadataServiceContext != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                EntityMetadataPublicationHandler.OAM81ofhGCsyVuD0tB6B((object) metadataServiceContext);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
                continue;
              default:
                goto label_18;
            }
          }
        }
label_18:;
      }
    }

    internal static void LMbB40fbgQacXCMksrG1() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool djgHWJfblrKr1YxSV97o() => EntityMetadataPublicationHandler.eGYVdyfbdMB7vbjUvTgN == null;

    internal static EntityMetadataPublicationHandler FU9rISfbr7TQHQUrRJYb() => EntityMetadataPublicationHandler.eGYVdyfbdMB7vbjUvTgN;

    internal static object jUvWshfb5TguUTfs4Uw1([In] object obj0) => (object) ((EntityMetadata) obj0).ViewModelMetadata;

    internal static object jNhqJhfbjNq2gNpOY6oV([In] object obj0) => (object) ((IViewModelPropertyMetadata) obj0).ComputedValue;

    internal static Guid xw5RKtfbYgIYNZSCTyyP([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static void GBjRKtfbLmstDEJnUToW([In] object obj0, Guid metadataUid) => ComputedValueHelper.SetCalculateScriptMethodName((IComputedValue) obj0, metadataUid);

    internal static int CWBPlrfbUEYOiaMIWy8O([In] object obj0) => ((List<FormViewItemTransformation>) obj0).Count;

    internal static object Q5umeSfbspb4rFLyjrVj([In] object obj0) => (object) ((ViewItemTransformationAdd) obj0).Item;

    internal static object M72ScJfbc0CQOlS5te90([In] object obj0) => (object) ((ViewItemTransformationChange) obj0).PropertyName;

    internal static object E8J4mLfbzk6On3e4r29t(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool gyUECNfhFCHmaxtTZ1rt([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static object eA6t0ufhB0g606i4X77L([In] object obj0) => ((ViewItemTransformationChange) obj0).Value;

    internal static object x0qg7IfhWyxGNHYfW7AL([In] object obj0) => (object) ((TransformationChange<ComputedValue, ComputedValueTransformation, string, string>) obj0).PropertyName;

    internal static object TY2HAifho5enDVVvt1bo([In] object obj0) => ((TransformationChange<ComputedValue, ComputedValueTransformation, string, string>) obj0).Value;

    internal static void r3UKBhfhbde17fVRAJJH([In] object obj0, [In] object obj1) => ((TransformationChange<ComputedValue, ComputedValueTransformation, string, string>) obj0).Value = obj1;

    internal static bool r93FGFfhhWR0Q1DgYXkF([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void OAM81ofhGCsyVuD0tB6B([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object mj0A5SfhE5gyjteFCy7Z([In] object obj0) => (object) ((ViewItem) obj0).Clone();

    internal static void BsK2ALfhfOeFAHhT723h([In] object obj0) => EntityMetadataPublicationHandler.UpdateIncludeList((EntityMetadata) obj0);

    internal static bool xjMUoYfhQxriY1UpjlCs([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object Nl1NihfhCnQkIYwotTNa() => (object) MetadataServiceContext.Service;

    internal static EntityMetadataType MsSlOjfhvbYubM1ImLlQ([In] object obj0) => ((EntityMetadata) obj0).Type;

    internal static Guid jRloVmfh8JO5a3FXtgXV([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

    internal static object VOOC4hfhZJ4mxcHcpDne([In] object obj0) => (object) ((IMetadataItem) obj0).ScriptModule;

    internal static Guid GLh3TufhuYwxX5dYWdV9() => Guid.NewGuid();

    internal static Guid QrxXSyfhIysdM3haO23X([In] object obj0) => ((ScriptModule) obj0).Uid;

    internal static void wIa63wfhVT3lArQU8VjB([In] object obj0, Guid value) => ((ScriptModule) obj0).Uid = value;

    internal static Guid FdKWI7fhSgQh3rlxTCRS([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static void VcCHJZfhic6U6y1lKvix([In] object obj0, [In] object obj1) => ((IMetadataItem) obj0).ScriptModule = (ScriptModule) obj1;

    internal static object MQmLurfhRjHMN3kVM2Y8([In] object obj0) => ((IMetadataItem) obj0).Metadata;

    internal static object TMalPvfhqrQbhKkMP3ob([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static void rE5VkefhKPyrXELCDBLe([In] object obj0, [In] object obj1) => ((DataClassMetadata) obj0).TypeRef = (string) obj1;

    internal static int HZiy8WfhXXtYJXZIe39R([In] object obj0) => ((ICollection<IMetadata>) obj0).Count;

    internal static void gMLZsXfhTL3dvGwFIP35([In] object obj0, [In] object obj1, [In] object obj2) => ((IEntityMetadataDependencyService) obj0).CollectDependencies((EntityMetadata) obj1, (IMetadataItem) obj2);
  }
}
