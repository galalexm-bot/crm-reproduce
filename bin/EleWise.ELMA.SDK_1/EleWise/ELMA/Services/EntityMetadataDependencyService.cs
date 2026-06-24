// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.EntityMetadataDependencyService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services
{
  /// <inheritdoc />
  [Service]
  internal sealed class EntityMetadataDependencyService : IEntityMetadataDependencyService
  {
    /// <summary>Ключ наличия объекта который появится позже</summary>
    internal const string PromisedDependenciesKey = "HasPromisedDependencies";
    /// <summary>Шаблон ключа объекта который появится позже</summary>
    internal const string PromisedKeyTemplate = "Promised{0}_{1}";
    private readonly IDependencyService dependencyService;
    private readonly ISearchMetadataService searchMetadataService;
    internal static EntityMetadataDependencyService BYeIZXBDtjf03038l55y;

    /// <summary>Ctor</summary>
    /// <param name="dependencyService">Сервис по работе с зависимостями</param>
    /// <param name="searchMetadataService">Сервис поиска метаданных</param>
    public EntityMetadataDependencyService(
      IDependencyService dependencyService,
      ISearchMetadataService searchMetadataService)
    {
      EntityMetadataDependencyService.up0JBgBD6lSY4YJGLWIa();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.dependencyService = dependencyService;
            num = 2;
            continue;
          case 2:
            this.searchMetadataService = searchMetadataService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <inheritdoc />
    public void CollectDependencies(EntityMetadata metadata, IMetadataItem metadataItem)
    {
      int num1 = 5;
      MetadataDependencyContainer metadataDependencies;
      MetadataServiceContext metadataServiceContext;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            goto label_49;
          case 3:
label_3:
            EntityMetadataDependencyService.WvkH2tBDmqhEtBqdYKbH((object) metadataItem, (object) metadataDependencies);
            num1 = 2;
            continue;
          case 4:
            metadataServiceContext = MetadataServiceContext.Extend(((IEnumerable<IMetadata>) this.searchMetadataService.GetPublishedDataClasses().ToList<DataClassMetadata>()).Concat<IMetadata>((IMetadata) metadata).Concat<IMetadata>((IEnumerable<IMetadata>) this.searchMetadataService.GetPublishedFunctions()).Concat<IMetadata>((IEnumerable<IMetadata>) this.searchMetadataService.GetPublishedComponents()));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
            continue;
          case 5:
            if (EntityMetadataDependencyService.C1UUcTBDHO3Xbpd8n71U((object) metadata) != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 4 : 0;
              continue;
            }
            goto label_43;
          default:
            try
            {
              // ISSUE: reference to a compiler-generated method
              metadataDependencies = this.dependencyService.GetClassMetadataDependencies((ClassMetadata) EntityMetadataDependencyService.C1UUcTBDHO3Xbpd8n71U((object) metadata), (IMetadata) metadata, metadata.Forms.Where<FormViewItem>((Func<FormViewItem, bool>) (f => EntityMetadataDependencyService.\u003C\u003Ec.taV3FpQXRWtbsOxdlcjB((object) f) == RuntimeVersion.Version2)));
              int num2 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
                num2 = 1;
              List<FormViewItemTransformation>.Enumerator enumerator1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    enumerator1 = metadata.FormTransformations.GetEnumerator();
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_12;
                }
              }
label_12:
              try
              {
label_23:
                if (enumerator1.MoveNext())
                  goto label_18;
                else
                  goto label_24;
label_14:
                FormViewItemDependencyContainer dependencyContainer;
                DependencyAnalysisResult dependencyAnalysisResult;
                FormViewItem form;
                FormViewItemTransformation current1;
                List<ViewItemTransformation>.Enumerator enumerator2;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      dependencyContainer.EntityDependencies.AddRange((IEnumerable<EntityDependency>) dependencyAnalysisResult.EntityDependencies);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 7 : 11;
                      continue;
                    case 2:
                      goto label_18;
                    case 3:
                      dependencyContainer.ComponentDependencies.AddRange((IEnumerable<ComponentDependency>) dependencyAnalysisResult.ComponentDependencies);
                      num3 = 4;
                      continue;
                    case 4:
                      metadataDependencies.FormDependencies.Add(dependencyContainer);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 12 : 10;
                      continue;
                    case 5:
label_38:
                      dependencyAnalysisResult = this.dependencyService.SimpleFormDependencyAnalysis((ClassMetadata) metadata.ViewModelMetadata, (IMetadata) metadata, form);
                      num3 = 8;
                      continue;
                    case 6:
                      form = new FormViewItem();
                      num3 = 7;
                      continue;
                    case 7:
                      enumerator2 = current1.Items.GetEnumerator();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 10 : 2;
                      continue;
                    case 8:
                      dependencyContainer = new FormViewItemDependencyContainer()
                      {
                        FormUid = !(EntityMetadataDependencyService.KveWtbBDxrJpQi2Djj6a((object) current1) != Guid.Empty) ? current1.Uid : EntityMetadataDependencyService.KveWtbBDxrJpQi2Djj6a((object) current1)
                      };
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
                      continue;
                    case 9:
                      goto label_3;
                    case 10:
                      try
                      {
label_32:
                        if (enumerator2.MoveNext())
                          goto label_28;
                        else
                          goto label_33;
label_27:
                        int num4;
                        switch (num4)
                        {
                          case 1:
                            goto label_30;
                          case 2:
                            goto label_38;
                          case 4:
                            break;
                          default:
                            goto label_32;
                        }
label_28:
                        if (!(enumerator2.Current is ViewItemTransformationAdd current2))
                        {
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
                          goto label_27;
                        }
label_30:
                        ((EventedList<ViewItem>) EntityMetadataDependencyService.e3Bpi1BDA3eb1kwt2g6m((object) form)).Add((ViewItem) EntityMetadataDependencyService.s0wv1FBD74q0fFXgLPZ6((object) current2));
                        num4 = 3;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
                        {
                          num4 = 3;
                          goto label_27;
                        }
                        else
                          goto label_27;
label_33:
                        num4 = 2;
                        goto label_27;
                      }
                      finally
                      {
                        enumerator2.Dispose();
                        int num5 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
                          num5 = 0;
                        switch (num5)
                        {
                          default:
                        }
                      }
                    case 11:
                      dependencyContainer.DataClassDependencies.AddRange((IEnumerable<DataClassDependency>) dependencyAnalysisResult.DataClassDependencies);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 3 : 1;
                      continue;
                    case 12:
                      goto label_23;
                    default:
                      dependencyContainer.EnumDependencies.AddRange((IEnumerable<EnumDependency>) dependencyAnalysisResult.EnumDependencies);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 0;
                      continue;
                  }
                }
label_18:
                current1 = enumerator1.Current;
                num3 = 6;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
                {
                  num3 = 4;
                  goto label_14;
                }
                else
                  goto label_14;
label_24:
                num3 = 9;
                goto label_14;
              }
              finally
              {
                enumerator1.Dispose();
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                }
              }
            }
            finally
            {
              if (metadataServiceContext != null)
              {
                int num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
                  num7 = 0;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      goto label_51;
                    default:
                      EntityMetadataDependencyService.nsJ3AWBD0xScwK06BxBL((object) metadataServiceContext);
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 1 : 1;
                      continue;
                  }
                }
              }
label_51:;
            }
        }
      }
label_2:
      return;
label_49:
      return;
label_43:;
    }

    /// <summary>
    /// Получить коллекцию обещанных метаданных для публикации
    /// </summary>
    /// <param name="actorContextService">Сервис контекста исполнения в акторе</param>
    /// <returns>Коллекция обещанных метаданных для публикации</returns>
    internal static ICollection<IMetadata> GetPromisedMetadataDependencies(
      IActorContextService actorContextService)
    {
      object metadataDependencies;
      if (!actorContextService.TryGet(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121211825), out metadataDependencies))
        actorContextService.Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123549756), (object) (List<IMetadata>) (metadataDependencies = (object) new List<IMetadata>()));
      return (ICollection<IMetadata>) metadataDependencies;
    }

    internal static void up0JBgBD6lSY4YJGLWIa() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool XEDrvdBDwvFyr5iYQYpE() => EntityMetadataDependencyService.BYeIZXBDtjf03038l55y == null;

    internal static EntityMetadataDependencyService bGOCJbBD4m45H1VC0vZ8() => EntityMetadataDependencyService.BYeIZXBDtjf03038l55y;

    internal static object C1UUcTBDHO3Xbpd8n71U([In] object obj0) => (object) ((EntityMetadata) obj0).ViewModelMetadata;

    internal static object e3Bpi1BDA3eb1kwt2g6m([In] object obj0) => (object) ((RootViewItem) obj0).Items;

    internal static object s0wv1FBD74q0fFXgLPZ6([In] object obj0) => (object) ((ViewItemTransformationAdd) obj0).Item;

    internal static Guid KveWtbBDxrJpQi2Djj6a([In] object obj0) => ((FormViewItemTransformation) obj0).NewFormUid;

    internal static void nsJ3AWBD0xScwK06BxBL([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void WvkH2tBDmqhEtBqdYKbH([In] object obj0, [In] object obj1) => ((IMetadataItem) obj0).Dependencies = obj1;
  }
}
