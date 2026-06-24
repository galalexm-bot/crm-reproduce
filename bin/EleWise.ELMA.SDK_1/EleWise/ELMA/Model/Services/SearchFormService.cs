// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Services.SearchFormService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Entities;
using EleWise.ELMA.Model.Services.Models;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UI.Services.FindComponent;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Model.Services
{
  /// <summary>Сервис поиска форм</summary>
  [Service]
  internal sealed class SearchFormService : ISearchFormServiceInternal, ISearchFormService
  {
    private readonly IEnumerable<IObjectFormProvider> objectFormProviders;
    private readonly IEntityScriptingService entityScriptingService;
    private readonly IFindComponentService findComponentService;
    private readonly MetadataItemHeaderManager metadataItemHeaderManager;
    private readonly IEnumerable<IEntityFilterProvider> entityFilterProviders;
    private readonly IMetadataRuntimeService metadataRuntimeService;
    private readonly IEnumerable<IPropertyViewItemAdjustmentRuntime2> propertyViewItemAdjustmentRuntime2;
    internal static SearchFormService NVBXMObQs7n5nhHFPcNr;

    /// <summary>Ctor</summary>
    /// <param name="objectFormProviders">Провайдеры форм</param>
    /// <param name="entityScriptingService">Сервис исполнения сценариев</param>
    /// <param name="findComponentService">Сервис поиска компонента</param>
    /// <param name="metadataRuntimeService">Сервис управления метаданными</param>
    /// <param name="metadataItemHeaderManager">Менеджер заголовков элементов метаданных</param>
    /// <param name="entityFilterProviders">Провайдеры для фильтрации</param>
    /// <param name="propertyViewItemAdjustmentRuntime2">Точки расширения для изменения представления свойства перед его отображением</param>
    public SearchFormService(
      IEnumerable<IObjectFormProvider> objectFormProviders,
      IEntityScriptingService entityScriptingService,
      IFindComponentService findComponentService,
      IMetadataRuntimeService metadataRuntimeService,
      MetadataItemHeaderManager metadataItemHeaderManager,
      IEnumerable<IEntityFilterProvider> entityFilterProviders,
      IEnumerable<IPropertyViewItemAdjustmentRuntime2> propertyViewItemAdjustmentRuntime2)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.objectFormProviders = objectFormProviders;
      this.entityScriptingService = entityScriptingService;
      this.findComponentService = findComponentService;
      this.metadataRuntimeService = metadataRuntimeService;
      this.metadataItemHeaderManager = metadataItemHeaderManager;
      this.entityFilterProviders = entityFilterProviders;
      this.propertyViewItemAdjustmentRuntime2 = propertyViewItemAdjustmentRuntime2;
    }

    /// <inheritdoc />
    public EntityFormView GetEntityForm(SearchForm searchForm)
    {
      int num1 = 33;
      IEntity entity1;
      string entityId;
      ViewType viewType;
      FormViewItem viewItem;
      Type type;
      IEnumerator<PropertyViewItem> enumerator1;
      Guid typeUid;
      while (true)
      {
        int num2 = num1;
        IEntity entity2;
        IEntityManager entityManager1;
        IObjectFormProvider objectFormProvider;
        Guid uid1;
        IEntityManager entityManager2;
        while (true)
        {
          IEnumerator<EntityPropertyMetadata> enumerator2;
          Guid uid2;
          long result1;
          IEntity entity3;
          long result2;
          Guid result3;
          IEntityManager entityManager3;
          long result4;
          Guid formUid;
          object obj1;
          switch (num2)
          {
            case 1:
label_94:
              formUid = SearchFormService.o7qlJtbCXEV3qOydG0EF((object) searchForm);
              num2 = 30;
              continue;
            case 2:
              if (!Guid.TryParse(entityId, out result3))
              {
                num2 = 4;
                continue;
              }
              goto case 36;
            case 3:
              entity1 = (IEntity) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 2 : 1;
              continue;
            case 4:
            case 29:
            case 34:
            case 60:
              if (long.TryParse(entityId, out result1))
              {
                num2 = 13;
                continue;
              }
              goto case 17;
            case 5:
              SearchFormService.uhT9nvbC8XEotcgWAOkE((object) entity1, entityMetadata.IsGroupPropertyUid, (object) true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 63;
              continue;
            case 6:
            case 26:
              entity1 = SearchFormService.HicQb8bCZkgew4GmdXbR((object) entityManager1, result3) as IEntity;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 20 : 29;
              continue;
            case 7:
              entityManager3 = (IEntityManager) SearchFormService.BQ3mtHbCW3jnjRjS76dj(uid2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 37 : 2;
              continue;
            case 8:
              if (!SearchFormService.vEiGRIbCe3Nk8Sy74VSo(SearchFormService.CMERd8bCOgsJhQUT369W(SearchFormService.nTrkvEbCnV5NoX5GyC6r()), SearchFormService.CMERd8bCOgsJhQUT369W(SearchFormService.mmlXZ9bC2nK9fFe5Z0rs())))
                goto case 55;
              else
                goto label_64;
            case 9:
              goto label_8;
            case 10:
              goto label_14;
            case 11:
              entity3 = entityManager3.Create() as IEntity;
              num2 = 16;
              continue;
            case 12:
            case 16:
            case 21:
              entity1.SetPropertyValue(entityMetadata.ParentPropertyUid, (object) entity3);
              num2 = 35;
              continue;
            case 13:
              if (result1 <= 0L)
              {
                num2 = 28;
                continue;
              }
              goto case 41;
            case 14:
            case 27:
            case 62:
              SearchFormService.uhT9nvbC8XEotcgWAOkE((object) entity1, SearchFormService.AoKfN8bCvas366CIoNTT((object) entityMetadata), (object) entity2);
              num2 = 34;
              continue;
            case 15:
              goto label_25;
            case 17:
            case 22:
            case 35:
              if (entity1 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 58 : 51;
                continue;
              }
              goto label_53;
            case 18:
              if (MetadataLoader.LoadMetadata(typeUid) is EntityMetadata entityMetadata)
              {
                entityManager1 = (IEntityManager) SearchFormService.BQ3mtHbCW3jnjRjS76dj(typeUid);
                num2 = 52;
                continue;
              }
              goto label_6;
            case 19:
              object obj2 = SearchFormService.Tf5ma0bCfdH7jofT80n6((object) searchForm);
              entity2 = (IEntity) null;
              Guid result5;
              if (Guid.TryParse((string) obj2, out result5))
                entity2 = SearchFormService.YTRWwQbCbOy9VwyXTlbM(result5, Guid.Empty) ? SearchFormService.RsVG9ybCQTpQELLxRsc8((object) entityManager2) as IEntity : entityManager2.Load(result5) as IEntity;
              if (!long.TryParse((string) obj2, out result2))
              {
                num2 = 14;
                continue;
              }
              goto case 56;
            case 20:
              if (SearchFormService.XE5KAUbCugQiPUtWvVss((object) searchForm))
                goto case 5;
              else
                goto label_51;
            case 23:
              goto label_71;
            case 24:
              goto label_53;
            case 25:
              if (SearchFormService.jsqrinbCIK8sdkTxl6dt(uid2, Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 7 : 0;
                continue;
              }
              goto case 17;
            case 28:
              entity1 = SearchFormService.RsVG9ybCQTpQELLxRsc8((object) entityManager1) as IEntity;
              num2 = 40;
              continue;
            case 30:
              if (!SearchFormService.jsqrinbCIK8sdkTxl6dt(formUid, Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 53 : 48;
                continue;
              }
              obj1 = SearchFormService.z2k9DxbCksYItboeXJ1v((object) objectFormProvider, (object) entity1, formUid);
              break;
            case 31:
            case 63:
              uid2 = SearchFormService.HUevtDbCEeZ3JpEaD8jG((object) searchForm);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 3 : 25;
              continue;
            case 32:
              typeUid = SearchFormService.axsrr7bCFRb0l9fFVI0P((object) searchForm);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 18 : 18;
              continue;
            case 33:
              num2 = 32;
              continue;
            case 36:
              if (!SearchFormService.YTRWwQbCbOy9VwyXTlbM(result3, Guid.Empty))
              {
                num2 = 26;
                continue;
              }
              goto label_8;
            case 37:
              object obj3 = SearchFormService.Tf5ma0bCfdH7jofT80n6((object) searchForm);
              entity3 = (IEntity) null;
              Guid result6;
              if (Guid.TryParse((string) obj3, out result6))
                entity3 = !SearchFormService.YTRWwQbCbOy9VwyXTlbM(result6, Guid.Empty) ? SearchFormService.lGNZdubCV4WqaNoqWvQu((object) entityManager3, result6) as IEntity : entityManager3.Create() as IEntity;
              if (!long.TryParse((string) obj3, out result4))
              {
                num2 = 21;
                continue;
              }
              goto case 64;
            case 38:
              if (objectFormProvider != null)
              {
                num2 = 49;
                continue;
              }
              goto label_14;
            case 39:
              goto label_55;
            case 40:
              if (!SearchFormService.TFbD63bChkwVFIRyJ5gZ((object) searchForm))
              {
                num2 = 22;
                continue;
              }
              goto case 20;
            case 41:
              entity1 = SearchFormService.X4SKK1bCSaaqcGBG5yA8((object) entityManager1, (object) result1) as IEntity;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 2 : 17;
              continue;
            case 42:
              SearchFormService.UYHxc4bCP6MAhhD5NcWD((object) viewItem);
              num2 = 55;
              continue;
            case 43:
              if (!SearchFormService.TFbD63bChkwVFIRyJ5gZ((object) searchForm))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 55 : 60;
                continue;
              }
              goto default;
            case 44:
              entity2 = SearchFormService.KNrYGnbCCiSmoJA56gwN((object) entityManager2, (object) result2) as IEntity;
              num2 = 27;
              continue;
            case 45:
              uid1 = SearchFormService.HUevtDbCEeZ3JpEaD8jG((object) searchForm);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 59 : 32;
              continue;
            case 46:
              enumerator2 = entityMetadata.EntityProperties.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 46 : 61;
              continue;
            case 47:
              entity3 = SearchFormService.KNrYGnbCCiSmoJA56gwN((object) entityManager3, (object) result4) as IEntity;
              num2 = 12;
              continue;
            case 48:
              goto label_27;
            case 49:
              viewType = SearchFormService.rF3wRobCiayhppPUrq9P((object) searchForm);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 13 : 54;
              continue;
            case 50:
              goto label_73;
            case 51:
              goto label_59;
            case 52:
              if (entityManager1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 23 : 2;
                continue;
              }
              entityId = searchForm.EntityId;
              num2 = 3;
              continue;
            case 53:
              obj1 = SearchFormService.J7dosDbCT5dPcyvUnC7X((object) objectFormProvider, (object) entity1, viewType);
              break;
            case 54:
              objectFormProvider.InitObject((object) entity1, viewType, (IDictionary<string, object>) new Dictionary<string, object>());
              num2 = 46;
              continue;
            case 55:
              IEnumerable<PropertyViewItem> allProperties = viewItem.GetAllProperties();
              type = entity1.GetType();
              enumerator1 = allProperties.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 50 : 32;
              continue;
            case 56:
              if (result2 <= 0L)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 39 : 38;
                continue;
              }
              goto case 44;
            case 57:
              goto label_7;
            case 58:
              goto label_54;
            case 59:
              if (uid1 != Guid.Empty)
              {
                num2 = 15;
                continue;
              }
              goto case 4;
            case 61:
              try
              {
label_36:
                if (SearchFormService.doXQUvbCKpJCxq2dUjLd((object) enumerator2))
                  goto label_40;
                else
                  goto label_37;
label_35:
                EntityPropertyMetadata current;
                TypeSettings typeSettings;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_40;
                    case 2:
                      typeSettings = entity1.LoadPropertyInstanceSettings(SearchFormService.gGO6IVbCR2arCar1tH58((object) current));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 3;
                      continue;
                    case 3:
                      if (typeSettings != null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 4;
                        continue;
                      }
                      goto label_36;
                    case 4:
                      SearchFormService.dr7toubCqbJExtv1jikV((object) current, (object) typeSettings);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 5 : 4;
                      continue;
                    case 5:
                      goto label_36;
                    default:
                      goto label_94;
                  }
                }
label_37:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
                goto label_35;
label_40:
                current = enumerator2.Current;
                num3 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
                {
                  num3 = 2;
                  goto label_35;
                }
                else
                  goto label_35;
              }
              finally
              {
                int num4;
                if (enumerator2 == null)
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 2 : 2;
                else
                  goto label_47;
label_46:
                switch (num4)
                {
                  case 1:
                  case 2:
                }
label_47:
                enumerator2.Dispose();
                num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
                {
                  num4 = 1;
                  goto label_46;
                }
                else
                  goto label_46;
              }
            case 64:
              if (result4 <= 0L)
              {
                num2 = 11;
                continue;
              }
              goto case 47;
            default:
              if (searchForm.IsGroup)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 34 : 57;
                continue;
              }
              goto case 45;
          }
          viewItem = (FormViewItem) obj1;
          num2 = 8;
        }
label_6:
        num1 = 51;
        continue;
label_7:
        entity1.SetPropertyValue(SearchFormService.i2tjS5bCGjRFLnydAysa((object) entityMetadata), (object) true);
        num1 = 45;
        continue;
label_8:
        entity1 = entityManager1.Create() as IEntity;
        num1 = 43;
        continue;
label_25:
        entityManager2 = (IEntityManager) SearchFormService.BQ3mtHbCW3jnjRjS76dj(uid1);
        num1 = 19;
        continue;
label_51:
        num1 = 31;
        continue;
label_54:
        // ISSUE: reference to a compiler-generated method
        objectFormProvider = this.objectFormProviders.FirstOrDefault<IObjectFormProvider>((Func<IObjectFormProvider, bool>) (q => SearchFormService.\u003C\u003Ec__DisplayClass8_0.UHsR62Ckjgqdce9Sk2ll((object) q, EntityMetadata.UID, typeUid)));
        num1 = 38;
        continue;
label_55:
        entity2 = SearchFormService.RsVG9ybCQTpQELLxRsc8((object) entityManager2) as IEntity;
        num1 = 62;
        continue;
label_64:
        num1 = 42;
      }
label_14:
      throw new ObjectNotFoundException((string) null, EleWise.ELMA.SR.T((string) SearchFormService.kO2QWgbCBPnyI7kIw3yC(~1767720452 ^ -1767896263), SearchFormService.wvBDtcbCo0cPB7BkBIwZ((object) entityMetadata)));
label_27:
      return this.ProcessEntityForm(entityMetadata, entity1, viewItem, new ViewType?(viewType), SearchFormService.byMmvQbCNnNWqa3hyegr((object) searchForm), (IEnumerable<Guid>) searchForm.ExistingMetadataUids, (IEnumerable<EntityDependency>) searchForm.EntityDependencies);
label_53:
      throw PublicServiceException.CreateWebFault(EleWise.ELMA.SR.T((string) SearchFormService.kO2QWgbCBPnyI7kIw3yC(-138018305 ^ -138103847), SearchFormService.wvBDtcbCo0cPB7BkBIwZ((object) entityMetadata), (object) entityId), 404);
label_59:
      throw new ObjectNotFoundException((string) null, EleWise.ELMA.SR.T((string) SearchFormService.kO2QWgbCBPnyI7kIw3yC(1642859704 ^ 1643036104), (object) typeUid));
label_71:
      throw new ObjectNotFoundException((string) null, EleWise.ELMA.SR.T((string) SearchFormService.kO2QWgbCBPnyI7kIw3yC(-1872275253 >> 6 ^ -29152083), SearchFormService.wvBDtcbCo0cPB7BkBIwZ((object) entityMetadata)));
label_73:
      try
      {
label_75:
        if (SearchFormService.doXQUvbCKpJCxq2dUjLd((object) enumerator1))
          goto label_78;
        else
          goto label_76;
label_74:
        PropertyViewItem current;
        int num5;
        while (true)
        {
          switch (num5)
          {
            case 1:
              goto label_78;
            case 2:
              this.FillFilterProvider(current, type, entity1, entityMetadata);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
              continue;
            case 3:
              goto label_27;
            default:
              goto label_75;
          }
        }
label_76:
        num5 = 3;
        goto label_74;
label_78:
        current = enumerator1.Current;
        num5 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
        {
          num5 = 0;
          goto label_74;
        }
        else
          goto label_74;
      }
      finally
      {
        int num6;
        if (enumerator1 == null)
          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 1;
        else
          goto label_83;
label_82:
        switch (num6)
        {
          case 2:
            break;
          default:
        }
label_83:
        SearchFormService.yv4bNobC1tcjD7gZeRNe((object) enumerator1);
        num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
        {
          num6 = 0;
          goto label_82;
        }
        else
          goto label_82;
      }
    }

    /// <inheritdoc />
    public EntityFormView ProcessEntityForm(EntityForm entityForm) => this.ProcessEntityForm((EntityMetadata) SearchFormService.QrETUObC3dH1eddUDPUh((object) entityForm), (IEntity) SearchFormService.KYPAKDbCp1DGZW7PT9QU((object) entityForm), entityForm.Form, new ViewType?(), entityForm.Debug, (IEnumerable<Guid>) entityForm.ExistingMetadataUids, (IEnumerable<EntityDependency>) entityForm.EntityDependencies);

    /// <inheritdoc />
    public void ClearCache()
    {
    }

    private EntityFormView ProcessEntityForm(
      EntityMetadata md,
      IEntity entity,
      FormViewItem viewItem,
      ViewType? viewType,
      bool debug,
      IEnumerable<Guid> existingMetadataUids,
      IEnumerable<EntityDependency> entityDependencies)
    {
      return viewItem.RuntimeVersion != RuntimeVersion.Version1 ? this.ProcessEntityFormRuntimeVersion2(md, entity, viewItem, viewType, debug, existingMetadataUids, entityDependencies) : this.ProcessEntityFormRuntimeVersion1(md, entity, viewItem);
    }

    private EntityFormView ProcessEntityFormRuntimeVersion1(
      EntityMetadata entityMetadata,
      IEntity entity,
      FormViewItem formViewItem)
    {
      int num1 = 1;
      FormViewBuilderInfo formViewBuilderInfo;
      FormViewItem formViewItem1;
      while (true)
      {
        int num2 = num1;
        string onLoadScriptName;
        Dictionary<string, object> parameters;
        PropertyViewInfoContainer propertyContainer;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
              continue;
            case 2:
              this.entityScriptingService.ExecuteScript(entity, onLoadScriptName, parameters, (Func<string, Type, object>) ((name, type) =>
              {
                int num3 = 1;
                ClassMetadata classMetadata;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (SearchFormService.\u003C\u003Ec__DisplayClass12_0.dE8VYtCkz4sumkg8ydY7((object) name, SearchFormService.\u003C\u003Ec__DisplayClass12_0.pwckkACkcLl7icBaw4dY(-218496594 ^ -218432952)))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_7;
                    case 2:
                      goto label_6;
                    case 3:
                      classMetadata = MetadataLoader.LoadMetadata(type.GetGenericArguments()[0]) as ClassMetadata;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 4 : 0;
                      continue;
                    case 4:
                      propertyContainer = new PropertyViewInfoContainer(classMetadata);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 2 : 0;
                      continue;
                    case 5:
                      // ISSUE: type reference
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (SearchFormService.\u003C\u003Ec__DisplayClass12_0.CSAFQ0CnBeSiwWEHcnUM(type.GetGenericTypeDefinition(), SearchFormService.\u003C\u003Ec__DisplayClass12_0.WN1omsCnFqrUPPoDbbwc(__typeref (FormViewBuilder<>))))
                      {
                        num3 = 3;
                        continue;
                      }
                      goto label_7;
                    default:
                      if (type.IsGenericType)
                      {
                        num3 = 5;
                        continue;
                      }
                      goto label_7;
                  }
                }
label_6:
                // ISSUE: reference to a compiler-generated method
                return SearchFormService.\u003C\u003Ec__DisplayClass12_0.jEKtmVCnWaX5ucMkmNn4(type, (object) new object[3]
                {
                  (object) formViewItem1,
                  (object) classMetadata,
                  (object) propertyContainer
                });
label_7:
                return (object) null;
              }));
              num2 = 7;
              continue;
            case 3:
              propertyContainer = (PropertyViewInfoContainer) null;
              num2 = 4;
              continue;
            case 4:
              parameters = new Dictionary<string, object>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 6;
              continue;
            case 5:
              goto label_10;
            case 6:
              onLoadScriptName = this.GetFormOnLoadScriptName(formViewItem1, entityMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 8 : 1;
              continue;
            case 7:
              formViewBuilderInfo = DynamicFormHelper.GetFormViewBuilderInfo(propertyContainer);
              num2 = 5;
              continue;
            case 8:
              if (!SearchFormService.gkAtcgbCa9JDCnZVBix9((object) onLoadScriptName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 2 : 1;
                continue;
              }
              goto case 7;
            default:
              goto label_4;
          }
        }
label_4:
        formViewItem1 = formViewItem;
        num1 = 3;
      }
label_10:
      EntityFormView entityFormView = new EntityFormView();
      SearchFormService.Bew8CObCDq4WCRT4L0aK((object) entityFormView, (object) new EntityJsonSerializer().Serialize((object) entity));
      SearchFormService.swoMlbbCtBPFscP3wwZr((object) entityFormView, (object) formViewItem1);
      SearchFormService.qRjQQLbCwst6yPO7K3Mt((object) entityFormView, (object) entityMetadata);
      SearchFormService.Fg0ddlbC402iiZ0hXWDV((object) entityFormView, (object) formViewBuilderInfo);
      ModelInfo modelInfo = new ModelInfo();
      SearchFormService.VtUXJ9bC6ThKdcpEID62((object) modelInfo, EntityMetadata.UID);
      SearchFormService.o8Qed0bCHa07KeIstkHD((object) modelInfo, SearchFormService.gGO6IVbCR2arCar1tH58((object) entityMetadata));
      entityFormView.ModelInfo = modelInfo;
      return entityFormView;
    }

    private EntityFormView ProcessEntityFormRuntimeVersion2(
      EntityMetadata entityMetadata,
      IEntity entity,
      FormViewItem formViewItem,
      ViewType? viewType,
      bool debug,
      IEnumerable<Guid> existingMetadataUids,
      IEnumerable<EntityDependency> clientEntityDependencies)
    {
      List<ClientScriptModel> clientScriptModels = new List<ClientScriptModel>();
      List<EnumDependency> enumDependencyList = new List<EnumDependency>();
      List<EntityDependency> entityDependencyList1 = new List<EntityDependency>();
      List<IMetadata> metadataList = new List<IMetadata>();
      HashSet<Guid> excludeFromChooseMetadata = new HashSet<Guid>();
      ObjectFormFindComponentModel findComponentModel = new ObjectFormFindComponentModel()
      {
        Form = formViewItem,
        MetadataUid = entityMetadata.Uid,
        MetadataDisplayName = entityMetadata.DisplayName,
        ItemUid = entityMetadata.Uid
      };
      Guid currentFormUid = formViewItem.Uid;
      foreach (SearchFormService.ExtendMetadataModel metadataListWithParent in this.GetMetadataListWithParents(entityMetadata))
      {
        EntityMetadata metadata = metadataListWithParent.Metadata;
        if (metadataListWithParent.IsSystem)
        {
          if (metadata.Uid != entityMetadata.Uid)
          {
            excludeFromChooseMetadata.Add(metadata.Uid);
            metadataList.Add((IMetadata) metadata);
          }
          EntityMetadata configExtMetadata = metadataListWithParent.ConfigExtMetadata;
          if (configExtMetadata?.ViewModelMetadata != null)
          {
            currentFormUid = this.ProcessMetadata(configExtMetadata.Uid, currentFormUid, enumDependencyList, entityDependencyList1, clientScriptModels, findComponentModel, debug);
            excludeFromChooseMetadata.Add(configExtMetadata.Uid);
            metadataList.Add((IMetadata) configExtMetadata);
          }
        }
        else
        {
          currentFormUid = this.ProcessMetadata(metadata.Type == EntityMetadataType.InterfaceImplementation ? metadata.ImplementationUid : metadata.Uid, currentFormUid, enumDependencyList, entityDependencyList1, clientScriptModels, findComponentModel, debug);
          if (metadata.Uid != entityMetadata.Uid)
          {
            metadataList.Add((IMetadata) metadata);
            excludeFromChooseMetadata.Add(metadata.Uid);
          }
        }
      }
      List<EntityDependency> second = new List<EntityDependency>();
      if (entityMetadata.Hierarchical)
      {
        if (entityMetadata.ParentPropertyUid != Guid.Empty)
        {
          List<EntityDependency> entityDependencyList2 = second;
          EntityDependency entityDependency = new EntityDependency();
          entityDependency.HeaderUid = entityMetadata.Uid;
          entityDependency.Name = entityMetadata.Name;
          entityDependency.DisplayName = entityMetadata.DisplayName;
          entityDependency.Properties = new List<PropertySignature>()
          {
            new PropertySignature()
            {
              Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1765823204),
              Uid = entityMetadata.ParentPropertyUid
            }
          };
          entityDependencyList2.Add(entityDependency);
        }
        if (entityMetadata.IsGroupPropertyUid != Guid.Empty)
        {
          List<EntityDependency> entityDependencyList3 = second;
          EntityDependency entityDependency = new EntityDependency();
          entityDependency.HeaderUid = entityMetadata.Uid;
          entityDependency.Name = entityMetadata.Name;
          entityDependency.DisplayName = entityMetadata.DisplayName;
          entityDependency.Properties = new List<PropertySignature>()
          {
            new PropertySignature()
            {
              Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1875951681),
              Uid = entityMetadata.IsGroupPropertyUid
            }
          };
          entityDependencyList3.Add(entityDependency);
        }
      }
      RecursiveComponentModel component = this.findComponentService.FindComponent(findComponentModel, new FindComponentOptions()
      {
        ViewMode = InterfaceBuilderViewMode.Runtime
      });
      List<EntityDependency> list1 = DependencyHelper.CombineClassDependencies<EntityDependency>(entityDependencyList1.Concat<EntityDependency>((IEnumerable<EntityDependency>) component.EntityDependencies).Concat<EntityDependency>(clientEntityDependencies).Concat<EntityDependency>((IEnumerable<EntityDependency>) second)).ToList<EntityDependency>();
      // ISSUE: reference to a compiler-generated method
      List<EntityMetadata> list2 = list1.Select<EntityDependency, EntityMetadata>((Func<EntityDependency, EntityMetadata>) (a => MetadataLoader.LoadMetadata(SearchFormService.\u003C\u003Ec.QO0LEVCnaDOCm1jy9vye((object) a)) as EntityMetadata)).Where<EntityMetadata>((Func<EntityMetadata, bool>) (a => a != null)).ToList<EntityMetadata>();
      HashSet<EntityMetadata> source = new HashSet<EntityMetadata>();
      foreach (EntityMetadata metadata in list2)
      {
        source.Add(metadata);
        foreach (ClassMetadata childClass1 in MetadataLoader.GetChildClasses((ClassMetadata) metadata))
        {
          ClassMetadata childClass = childClass1;
          source.Add((EntityMetadata) MetadataLoader.LoadMetadata(childClass.Uid));
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          if (!list1.Any<EntityDependency>((Func<EntityDependency, bool>) (c => SearchFormService.\u003C\u003Ec__DisplayClass13_1.BAVNAuCnSxlk0s9fGfsk(SearchFormService.\u003C\u003Ec__DisplayClass13_1.vKd9CBCnILZXkiYsLVSE((object) c), SearchFormService.\u003C\u003Ec__DisplayClass13_1.UFDSRVCnVvtK7gOlaFDN((object) childClass)))))
          {
            List<EntityDependency> entityDependencyList4 = list1;
            EntityDependency entityDependency = new EntityDependency();
            entityDependency.HeaderUid = childClass.Uid;
            entityDependency.Name = childClass.Name;
            entityDependency.DisplayName = childClass.DisplayName;
            entityDependencyList4.Add(entityDependency);
          }
        }
        foreach (ClassMetadata baseClass1 in MetadataLoader.GetBaseClasses((ClassMetadata) metadata))
        {
          ClassMetadata baseClass = baseClass1;
          source.Add((EntityMetadata) MetadataLoader.LoadMetadata(baseClass.Uid));
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          if (!list1.Any<EntityDependency>((Func<EntityDependency, bool>) (c => SearchFormService.\u003C\u003Ec__DisplayClass13_2.LX8qXZCnTq8dLEt13D70(c.HeaderUid, SearchFormService.\u003C\u003Ec__DisplayClass13_2.iRUADiCnXHJIfgsSTY26((object) baseClass)))))
          {
            List<EntityDependency> entityDependencyList5 = list1;
            EntityDependency entityDependency = new EntityDependency();
            entityDependency.HeaderUid = baseClass.Uid;
            entityDependency.Name = baseClass.Name;
            entityDependency.DisplayName = baseClass.DisplayName;
            entityDependencyList5.Add(entityDependency);
          }
        }
      }
      HashSet<Guid> guidSet1 = new HashSet<Guid>();
      HashSet<Guid> guidSet2 = new HashSet<Guid>();
      EntityMetadata[] array1 = source.Where<EntityMetadata>((Func<EntityMetadata, bool>) (m =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (m != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        return !excludeFromChooseMetadata.Contains(m.Uid);
label_3:
        return false;
      })).ToArray<EntityMetadata>();
      foreach (EntityMetadata entityMetadata1 in array1)
        guidSet1.Add(entityMetadata1.Uid);
      // ISSUE: reference to a compiler-generated method
      IEnumerable<EntityMetadata> collection1 = ((IEnumerable<EntityMetadata>) array1).Where<EntityMetadata>((Func<EntityMetadata, bool>) (m => !existingMetadataUids.Contains<Guid>(SearchFormService.\u003C\u003Ec__DisplayClass13_0.Hg6GRcCnEjVJTS3wZvf6((object) m))));
      metadataList.AddRange((IEnumerable<IMetadata>) collection1);
      EnumMetadata[] array2 = DependencyHelper.CombineDependencies<EnumDependency>(enumDependencyList.Concat<EnumDependency>((IEnumerable<EnumDependency>) component.EnumDependencies)).Select<EnumDependency, EnumMetadata>((Func<EnumDependency, EnumMetadata>) (a => MetadataLoader.LoadMetadata(a.HeaderUid) as EnumMetadata)).Where<EnumMetadata>((Func<EnumMetadata, bool>) (m => m != null)).ToArray<EnumMetadata>();
      foreach (EnumMetadata enumMetadata in array2)
        guidSet2.Add(enumMetadata.Uid);
      // ISSUE: reference to a compiler-generated method
      IEnumerable<EnumMetadata> collection2 = ((IEnumerable<EnumMetadata>) array2).Where<EnumMetadata>((Func<EnumMetadata, bool>) (m => !existingMetadataUids.Contains<Guid>(SearchFormService.\u003C\u003Ec__DisplayClass13_0.Hg6GRcCnEjVJTS3wZvf6((object) m))));
      metadataList.AddRange((IEnumerable<IMetadata>) collection2);
      foreach (Guid entityMetadataUid in component.EntityMetadataUids)
        guidSet1.Add(entityMetadataUid);
      foreach (Guid enumMetadataUid in component.EnumMetadataUids)
        guidSet1.Add(enumMetadataUid);
      EntitySerializationSettings settings = new EntitySerializationSettings()
      {
        WriteReferences = true
      };
      if (list1.Count == 0)
      {
        EntityDependency signature = entityMetadata.GetSignature(true);
        EntityPropertyMetadata uidProperty = entityMetadata.GetUidProperty();
        if (uidProperty != null)
          signature.Properties.Add(uidProperty.CreatePropertySignature());
        list1.Add(signature);
      }
      else
      {
        EntityDependency signature = list1.Find((Predicate<EntityDependency>) (a =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (!SearchFormService.\u003C\u003Ec__DisplayClass13_0.U4tERmCnQD0jhsV35qTq(SearchFormService.\u003C\u003Ec__DisplayClass13_0.dvO5KmCnftWD3c1l3FBH((object) a), SearchFormService.\u003C\u003Ec__DisplayClass13_0.Hg6GRcCnEjVJTS3wZvf6((object) entityMetadata)))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
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
          return SearchFormService.\u003C\u003Ec__DisplayClass13_0.dvO5KmCnftWD3c1l3FBH((object) a) == SearchFormService.\u003C\u003Ec__DisplayClass13_0.fWJ0vxCnCkRPigwOyVIe((object) entityMetadata);
label_3:
          return true;
        }));
        if (signature == null)
        {
          signature = entityMetadata.GetSignature(true);
          list1.Add(signature);
        }
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (signature.Properties.Find((Predicate<PropertySignature>) (a => SearchFormService.\u003C\u003Ec.O3ORPbCntnx2tiP5uxxC(SearchFormService.\u003C\u003Ec.KutplTCnDP4CEWuts8TL((object) a), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272598759)))) == null)
        {
          EntityPropertyMetadata uidProperty = entityMetadata.GetUidProperty();
          if (uidProperty != null)
            signature.Properties.Add(uidProperty.CreatePropertySignature());
        }
      }
      if (list1.Count > 0)
      {
        // ISSUE: reference to a compiler-generated method
        List<EntityDependency> list3 = list1.Where<EntityDependency>((Func<EntityDependency, bool>) (a => SearchFormService.\u003C\u003Ec.DFk1lUCnwjw78YmNlDh4((object) a.Properties) > 0)).ToList<EntityDependency>();
        settings.Mode = EntitySerializationMode.Default;
        // ISSUE: reference to a compiler-generated method
        settings.TypePropertySelector = list3.ToDictionary<EntityDependency, Guid, EntitySerializationSelector>((Func<EntityDependency, Guid>) (d => SearchFormService.\u003C\u003Ec.QO0LEVCnaDOCm1jy9vye((object) d)), (Func<EntityDependency, EntitySerializationSelector>) (d =>
        {
          int num1 = 5;
          List<string> list4;
          EntityMetadata entityMetadata2;
          while (true)
          {
            int num2 = num1;
            IPropertyMetadata[] array3;
            string[] strArray;
            int index;
            string name;
            while (true)
            {
              switch (num2)
              {
                case 1:
                case 12:
                  array3 = entityMetadata2.GetPropertiesAndTableParts().ToArray<IPropertyMetadata>();
                  num2 = 10;
                  continue;
                case 2:
                  num2 = 7;
                  continue;
                case 3:
                case 9:
                  ++index;
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
                  continue;
                case 4:
                  List<PropertySignature> properties = d.Properties;
                  // ISSUE: reference to a compiler-generated field
                  Func<PropertySignature, string> func = SearchFormService.\u003C\u003Ec.\u003C\u003E9__13_14;
                  Func<PropertySignature, string> selector;
                  if (func == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    SearchFormService.\u003C\u003Ec.\u003C\u003E9__13_14 = selector = (Func<PropertySignature, string>) (p => (string) SearchFormService.\u003C\u003Ec.KutplTCnDP4CEWuts8TL((object) p));
                  }
                  else
                    goto label_22;
label_21:
                  list4 = properties.Select<PropertySignature, string>(selector).ToList<string>();
                  num2 = 6;
                  continue;
label_22:
                  selector = func;
                  goto label_21;
                case 5:
                  entityMetadata2 = MetadataLoader.LoadMetadata(d.HeaderUid) as EntityMetadata;
                  num2 = 4;
                  continue;
                case 6:
                  if (list4.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146500431)))
                  {
                    num2 = 12;
                    continue;
                  }
                  goto case 16;
                case 7:
                  name = strArray[index];
                  num2 = 13;
                  continue;
                case 8:
                  goto label_3;
                case 10:
                  // ISSUE: reference to a compiler-generated method
                  strArray = (string[]) SearchFormService.\u003C\u003Ec.FprBUyCn6fQ4YfUIMoJb((object) list4);
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 14 : 13;
                  continue;
                case 13:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  if (((IEnumerable<IPropertyMetadata>) array3).FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (a => SearchFormService.\u003C\u003Ec__DisplayClass13_3.WaRq0uCnPaJbhTbi5sZE(SearchFormService.\u003C\u003Ec__DisplayClass13_3.TQUyHCCnelyGvG1g4d9F((object) a), (object) name))) != null)
                  {
                    num2 = 9;
                    continue;
                  }
                  goto case 15;
                case 14:
                  goto label_11;
                case 15:
                  list4.Remove(name);
                  num2 = 3;
                  continue;
                case 16:
                  // ISSUE: reference to a compiler-generated method
                  list4.Add((string) SearchFormService.\u003C\u003Ec.RetRutCn4nfg9hVGhhtP(1461825605 - 1531863589 ^ -70049358));
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 1;
                  continue;
                default:
                  if (index >= strArray.Length)
                  {
                    num2 = 8;
                    continue;
                  }
                  goto case 2;
              }
            }
label_11:
            index = 0;
            num1 = 11;
          }
label_3:
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          return (EntitySerializationSelector) SearchFormService.\u003C\u003Ec.ROVw2mCnHZirFRIOOBJA((object) string.Join((string) SearchFormService.\u003C\u003Ec.RetRutCn4nfg9hVGhhtP(-1334993905 ^ -1334980865), (IEnumerable<string>) list4), (object) entityMetadata2);
        }));
      }
      ContextVars.Set<UIRuntimeModel>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112720530), new UIRuntimeModel());
      IEnumerable<ClientComponentModel> additionalModules = this.findComponentService.GetAdditionalModules();
      component.ComponentCache.AddRange(additionalModules);
      string str = new EntityJsonSerializer().Serialize((object) entity, settings);
      EntityFormView entityFormView = new EntityFormView()
      {
        Model = str,
        View = formViewItem,
        Metadata = (IMetadata) entityMetadata,
        AdditionalMetadata = (IEnumerable<IMetadata>) metadataList,
        ModelInfo = new ModelInfo()
        {
          TypeUid = EntityMetadata.UID,
          SubTypeUid = entityMetadata.Uid
        },
        ClientScriptModels = (IEnumerable<ClientScriptModel>) clientScriptModels,
        RecursiveComponentModel = component,
        EntityDependencies = (IEnumerable<EntityDependency>) list1,
        EntityMetadataUids = guidSet1,
        EnumMetadataUids = guidSet2
      };
      if (viewType.HasValue)
        this.AdjustFormPropertyViewItems((ViewItem) entityFormView.View, entity, viewType.Value);
      return entityFormView;
    }

    private Guid ProcessMetadata(
      Guid headerUid,
      Guid currentFormUid,
      List<EnumDependency> enumDependencies,
      List<EntityDependency> entityDependencies,
      List<ClientScriptModel> clientScriptModels,
      ObjectFormFindComponentModel findComponentModel,
      bool debug)
    {
      IMetadataItemHeader metadataItemHeader = this.metadataItemHeaderManager.LoadOrNull(headerUid, new string[3]
      {
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951355524),
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541630293),
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459464077)
      });
      if (metadataItemHeader?.Published == null)
        throw new Exception();
      Guid formUid = currentFormUid;
      if (metadataItemHeader.Published.Dependencies is MetadataDependencyContainer dependencies1)
      {
        // ISSUE: reference to a compiler-generated method
        FormViewItemDependencyContainer dependencyContainer1 = dependencies1.FormDependencies.Find((Predicate<FormViewItemDependencyContainer>) (dep => SearchFormService.\u003C\u003Ec__DisplayClass14_0.GHkkbbCn0weRT8YPTySV((object) dep) == formUid));
        if (dependencyContainer1 != null)
        {
          enumDependencies.AddRange((IEnumerable<EnumDependency>) dependencyContainer1.EnumDependencies);
          entityDependencies.AddRange((IEnumerable<EntityDependency>) dependencyContainer1.EntityDependencies);
          findComponentModel.ComponentDependencies.AddRange((IEnumerable<ComponentDependency>) dependencyContainer1.ComponentDependencies);
          findComponentModel.DataClassDependencies.AddRange((IEnumerable<DataClassDependency>) dependencyContainer1.DataClassDependencies);
        }
        if (metadataItemHeader.Published.Metadata is EntityMetadata metadata)
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          FormViewItemTransformation itemTransformation = metadata.FormTransformations.Find((Predicate<FormViewItemTransformation>) (transformation => SearchFormService.\u003C\u003Ec__DisplayClass14_0.dNwaG7CnyWOlCY2rKdix(SearchFormService.\u003C\u003Ec__DisplayClass14_0.eQJY4FCnmTeytt9LTImm((object) transformation), formUid)));
          if (itemTransformation != null)
          {
            formUid = itemTransformation.Uid;
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            FormViewItemDependencyContainer dependencyContainer2 = dependencies1.FormDependencies.Find((Predicate<FormViewItemDependencyContainer>) (dep => SearchFormService.\u003C\u003Ec__DisplayClass14_0.dNwaG7CnyWOlCY2rKdix(SearchFormService.\u003C\u003Ec__DisplayClass14_0.GHkkbbCn0weRT8YPTySV((object) dep), formUid)));
            if (dependencyContainer2 != null)
            {
              enumDependencies.AddRange((IEnumerable<EnumDependency>) dependencyContainer2.EnumDependencies);
              entityDependencies.AddRange((IEnumerable<EntityDependency>) dependencyContainer2.EntityDependencies);
              findComponentModel.ComponentDependencies.AddRange((IEnumerable<ComponentDependency>) dependencyContainer2.ComponentDependencies);
              findComponentModel.DataClassDependencies.AddRange((IEnumerable<DataClassDependency>) dependencyContainer2.DataClassDependencies);
            }
          }
        }
        findComponentModel.FunctionDependencies.AddRange((IEnumerable<FunctionDependency>) dependencies1.FunctionDependencies);
        findComponentModel.DataClassDependencies.AddRange((IEnumerable<DataClassDependency>) dependencies1.DataClassDependencies);
      }
      ScriptModule clientScriptModule = metadataItemHeader.Published.ClientScriptModule;
      if (clientScriptModule != null)
      {
        byte[] numArray = debug ? clientScriptModule.DebugRaw : clientScriptModule.AssemblyRaw;
        ClientScriptModel clientScriptModel = new ClientScriptModel()
        {
          AssemblyName = clientScriptModule.AssemblyName,
          SourceCode = Encoding.UTF8.GetString(numArray ?? new byte[0])
        };
        clientScriptModels.Add(clientScriptModel);
        if (clientScriptModule.Dependencies is ScriptModuleDependencyContainer dependencies2)
        {
          enumDependencies.AddRange((IEnumerable<EnumDependency>) dependencies2.EnumDependencies);
          entityDependencies.AddRange((IEnumerable<EntityDependency>) dependencies2.EntityDependencies);
          findComponentModel.DataClassDependencies.AddRange((IEnumerable<DataClassDependency>) dependencies2.DataClassDependencies);
        }
      }
      return formUid;
    }

    private List<SearchFormService.ExtendMetadataModel> GetMetadataListWithParents(
      EntityMetadata entityMetadata)
    {
      List<SearchFormService.ExtendMetadataModel> metadataListWithParents = new List<SearchFormService.ExtendMetadataModel>();
      entityMetadata1 = entityMetadata;
      do
      {
        SearchFormService.ExtendMetadataModel extendMetadataModel = new SearchFormService.ExtendMetadataModel();
        extendMetadataModel.Metadata = entityMetadata1;
        extendMetadataModel.IsSystem = entityMetadata1.IsInterfaceType ? entityMetadata1.Uid.IsSystemMetadata() : entityMetadata1.ImplementationUid.IsSystemMetadata();
        if (entityMetadata1.ImplementedExtensionUids != null)
          extendMetadataModel.ConfigExtMetadata = entityMetadata1.ImplementedExtensionUids.EmptyIfNull<Guid>().Where<Guid>((Func<Guid, bool>) (uid => uid.IsConfigMetadata())).Select<Guid, EntityMetadata>((Func<Guid, EntityMetadata>) (uid => (EntityMetadata) this.metadataRuntimeService.GetMetadata(uid, false))).FirstOrDefault<EntityMetadata>();
        metadataListWithParents.Add(extendMetadataModel);
      }
      while (!(entityMetadata1.BaseClassUid == Guid.Empty) && this.metadataRuntimeService.GetMetadata(entityMetadata1.BaseClassUid) is EntityMetadata entityMetadata1);
      return metadataListWithParents;
    }

    private string GetFormOnLoadScriptName(FormViewItem formViewItem, EntityMetadata entityMetadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (SearchFormService.gkAtcgbCa9JDCnZVBix9(SearchFormService.mcHbsmbCAJZo66OxZV79((object) formViewItem)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return entityMetadata.OnViewLoadScriptName;
label_5:
      return (string) SearchFormService.mcHbsmbCAJZo66OxZV79((object) formViewItem);
    }

    private void FillFilterProvider(
      PropertyViewItem propertyViewItem,
      Type containerType,
      IEntity entity,
      EntityMetadata contextMetadata)
    {
      int num1 = 1;
      Type entityType;
      IEnumerator<PropertyViewItem> enumerator1;
      IEnumerator<IEntityFilterProvider> enumerator2;
      ViewAttributes attributes;
      PropertyMetadata propertyMetadata;
      while (true)
      {
        switch (num1)
        {
          case 1:
            (propertyMetadata, entityType) = this.FindProperty(containerType, contextMetadata, propertyViewItem.PropertyUid, (IEnumerable<Guid>) propertyViewItem.PropertyParents);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
            continue;
          case 2:
            attributes = propertyViewItem.Attributes;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 3 : 4;
            continue;
          case 3:
            goto label_4;
          case 4:
            enumerator2 = this.entityFilterProviders.GetEnumerator();
            num1 = 7;
            continue;
          case 5:
            if (entityType != (Type) null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 2 : 1;
              continue;
            }
            goto case 6;
          case 6:
          case 9:
label_39:
            enumerator1 = propertyViewItem.Items.OfType<PropertyViewItem>().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 3 : 2;
            continue;
          case 7:
            try
            {
label_27:
              if (SearchFormService.doXQUvbCKpJCxq2dUjLd((object) enumerator2))
                goto label_19;
              else
                goto label_28;
label_18:
              IEntityFilterProvider current;
              int num2;
              while (true)
              {
                string str;
                object obj;
                switch (num2)
                {
                  case 1:
                    attributes.EntityFilterData = str;
                    num2 = 4;
                    continue;
                  case 2:
                    goto label_27;
                  case 3:
                    if (!(current is IEntityInstanceFilterProvider instanceFilterProvider))
                    {
                      num2 = 6;
                      continue;
                    }
                    obj = SearchFormService.B3cgO3bCx2ZkagPvFyl1((object) instanceFilterProvider, (object) entity, entityType, (object) propertyMetadata, (object) attributes);
                    break;
                  case 4:
                  case 5:
                    goto label_39;
                  case 6:
                    obj = SearchFormService.FTmqRRbC7qSf3kxTcbqR((object) current, entityType, (object) propertyMetadata, (object) attributes);
                    break;
                  case 7:
                    SearchFormService.rQ37XgbCmHirDitB6Ppr((object) attributes, SearchFormService.vlc0MHbC0pPP99FILgJn((object) current));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 1 : 1;
                    continue;
                  case 8:
                    if (str != null)
                    {
                      num2 = 7;
                      continue;
                    }
                    goto label_27;
                  default:
                    goto label_19;
                }
                str = (string) obj;
                num2 = 8;
              }
label_19:
              current = enumerator2.Current;
              num2 = 3;
              goto label_18;
label_28:
              num2 = 5;
              goto label_18;
            }
            finally
            {
              int num3;
              if (enumerator2 == null)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 1;
              else
                goto label_34;
label_33:
              switch (num3)
              {
                case 2:
                  break;
                default:
              }
label_34:
              SearchFormService.yv4bNobC1tcjD7gZeRNe((object) enumerator2);
              num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
              {
                num3 = 0;
                goto label_33;
              }
              else
                goto label_33;
            }
          case 8:
            goto label_43;
          default:
            if (propertyMetadata == null)
            {
              num1 = 6;
              continue;
            }
            goto case 5;
        }
      }
label_43:
      return;
label_4:
      try
      {
label_9:
        if (SearchFormService.doXQUvbCKpJCxq2dUjLd((object) enumerator1))
          goto label_7;
        else
          goto label_10;
label_5:
        PropertyViewItem current;
        int num4;
        while (true)
        {
          switch (num4)
          {
            case 1:
              this.FillFilterProvider(current, containerType, entity, contextMetadata);
              num4 = 3;
              continue;
            case 2:
              goto label_36;
            case 3:
              goto label_9;
            default:
              goto label_7;
          }
        }
label_36:
        return;
label_7:
        current = enumerator1.Current;
        num4 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
        {
          num4 = 0;
          goto label_5;
        }
        else
          goto label_5;
label_10:
        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 2 : 0;
        goto label_5;
      }
      finally
      {
        int num5;
        if (enumerator1 == null)
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
        else
          goto label_14;
label_13:
        switch (num5)
        {
          case 2:
            break;
          default:
        }
label_14:
        SearchFormService.yv4bNobC1tcjD7gZeRNe((object) enumerator1);
        num5 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
        {
          num5 = 0;
          goto label_13;
        }
        else
          goto label_13;
      }
    }

    private (PropertyMetadata, Type) FindProperty(
      Type containerType,
      EntityMetadata entityMetadata,
      Guid propertyUid,
      IEnumerable<Guid> propertyParents)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      PropertyMetadata propertyMetadata1 = entityMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => SearchFormService.\u003C\u003Ec__DisplayClass19_0.x8UyorCnrm7MpQTLFXhN(SearchFormService.\u003C\u003Ec__DisplayClass19_0.mckPkaCnlofAManS0eCx((object) p), propertyUid)));
      if (propertyMetadata1 != null)
        return (propertyMetadata1, containerType);
      DataClassMetadata viewModelMetadata = entityMetadata.ViewModelMetadata;
      if (viewModelMetadata != null)
      {
        // ISSUE: reference to a compiler-generated method
        PropertyMetadata propertyMetadata2 = viewModelMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => SearchFormService.\u003C\u003Ec__DisplayClass19_0.x8UyorCnrm7MpQTLFXhN(p.Uid, propertyUid)));
        if (propertyMetadata2 != null)
          return (propertyMetadata2, containerType);
      }
      foreach (TablePartMetadata entityTablePart in (IEnumerable<TablePartMetadata>) entityMetadata.EntityTableParts)
      {
        (PropertyMetadata propertyMetadata3, Type type) = this.FindProperty(MetadataServiceContext.MetadataRuntimeService.GetTypeByUidOrNull(entityTablePart.Uid), (EntityMetadata) entityTablePart, propertyUid, propertyParents);
        if (propertyMetadata3 != null && type != (Type) null)
          return (propertyMetadata3, type);
      }
      return ((PropertyMetadata) null, (Type) null);
    }

    private void AdjustFormPropertyViewItems(ViewItem viewItem, IEntity entity, ViewType viewType)
    {
      int num1 = 3;
      RootViewItem rootViewItem;
      IEnumerator<ViewItem> enumerator1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_2;
          case 1:
            goto label_5;
          case 2:
            if (rootViewItem == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
              continue;
            }
            enumerator1 = ((EventedList<ViewItem>) SearchFormService.wfZcDibCytx2s4GGfufy((object) rootViewItem)).GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 1 : 1;
            continue;
          case 3:
            rootViewItem = viewItem as RootViewItem;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 2 : 2;
            continue;
          case 4:
            goto label_33;
          default:
            goto label_20;
        }
      }
label_2:
      return;
label_33:
      return;
label_20:
      return;
label_5:
      try
      {
label_23:
        if (SearchFormService.doXQUvbCKpJCxq2dUjLd((object) enumerator1))
          goto label_27;
        else
          goto label_24;
label_6:
        int num2;
        int num3 = num2;
        PropertyViewItem propertyViewItem;
        ViewItem current;
        IEnumerator<IPropertyViewItemAdjustmentRuntime2> enumerator2;
        while (true)
        {
          switch (num3)
          {
            case 1:
              if (propertyViewItem != null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 3 : 2;
                continue;
              }
              goto case 4;
            case 2:
              goto label_11;
            case 3:
              enumerator2 = this.propertyViewItemAdjustmentRuntime2.GetEnumerator();
              num3 = 2;
              continue;
            case 4:
              this.AdjustFormPropertyViewItems(current, entity, viewType);
              num3 = 6;
              continue;
            case 5:
              propertyViewItem = current as PropertyViewItem;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 0;
              continue;
            case 6:
              goto label_23;
            case 7:
              goto label_28;
            default:
              goto label_27;
          }
        }
label_28:
        return;
label_11:
        try
        {
label_15:
          if (enumerator2.MoveNext())
            goto label_13;
          else
            goto label_16;
label_12:
          int num4;
          switch (num4)
          {
            case 1:
              goto label_15;
            case 2:
              break;
            default:
              goto label_23;
          }
label_13:
          SearchFormService.rEOVVJbCMrlmvOhA6LnL((object) enumerator2.Current, (object) propertyViewItem, (object) entity, viewType);
          num4 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
          {
            num4 = 0;
            goto label_12;
          }
          else
            goto label_12;
label_16:
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
          goto label_12;
        }
        finally
        {
          int num5;
          if (enumerator2 == null)
            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
          else
            goto label_21;
label_19:
          switch (num5)
          {
            case 1:
            case 2:
          }
label_21:
          SearchFormService.yv4bNobC1tcjD7gZeRNe((object) enumerator2);
          num5 = 2;
          goto label_19;
        }
label_24:
        num2 = 7;
        goto label_6;
label_27:
        current = enumerator1.Current;
        num2 = 5;
        goto label_6;
      }
      finally
      {
        if (enumerator1 != null)
        {
          int num6 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
            num6 = 0;
          while (true)
          {
            switch (num6)
            {
              case 1:
                goto label_35;
              default:
                SearchFormService.yv4bNobC1tcjD7gZeRNe((object) enumerator1);
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 1;
                continue;
            }
          }
        }
label_35:;
      }
    }

    internal static Guid axsrr7bCFRb0l9fFVI0P([In] object obj0) => ((SearchForm) obj0).TypeUid;

    internal static object kO2QWgbCBPnyI7kIw3yC(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object BQ3mtHbCW3jnjRjS76dj(Guid uid) => (object) ModelHelper.GetEntityManager(uid);

    internal static object wvBDtcbCo0cPB7BkBIwZ([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static bool YTRWwQbCbOy9VwyXTlbM([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool TFbD63bChkwVFIRyJ5gZ([In] object obj0) => ((SearchForm) obj0).Hierarchical;

    internal static Guid i2tjS5bCGjRFLnydAysa([In] object obj0) => ((EntityMetadata) obj0).IsGroupPropertyUid;

    internal static Guid HUevtDbCEeZ3JpEaD8jG([In] object obj0) => ((SearchForm) obj0).ParentTypeUid;

    internal static object Tf5ma0bCfdH7jofT80n6([In] object obj0) => (object) ((SearchForm) obj0).ParentEntityId;

    internal static object RsVG9ybCQTpQELLxRsc8([In] object obj0) => ((IEntityManager) obj0).Create();

    internal static object KNrYGnbCCiSmoJA56gwN([In] object obj0, [In] object obj1) => ((IEntityManager) obj0).Load(obj1);

    internal static Guid AoKfN8bCvas366CIoNTT([In] object obj0) => ((EntityMetadata) obj0).ParentPropertyUid;

    internal static void uhT9nvbC8XEotcgWAOkE([In] object obj0, Guid propertyUid, [In] object obj2) => ((IEntity) obj0).SetPropertyValue(propertyUid, obj2);

    internal static object HicQb8bCZkgew4GmdXbR([In] object obj0, Guid uid) => ((IEntityManager) obj0).LoadOrNull(uid);

    internal static bool XE5KAUbCugQiPUtWvVss([In] object obj0) => ((SearchForm) obj0).IsGroup;

    internal static bool jsqrinbCIK8sdkTxl6dt([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object lGNZdubCV4WqaNoqWvQu([In] object obj0, Guid uid) => ((IEntityManager) obj0).Load(uid);

    internal static object X4SKK1bCSaaqcGBG5yA8([In] object obj0, [In] object obj1) => ((IEntityManager) obj0).LoadOrNull(obj1);

    internal static ViewType rF3wRobCiayhppPUrq9P([In] object obj0) => ((SearchForm) obj0).ViewType;

    internal static Guid gGO6IVbCR2arCar1tH58([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static void dr7toubCqbJExtv1jikV([In] object obj0, [In] object obj1) => ((PropertyMetadata) obj0).Settings = (TypeSettings) obj1;

    internal static bool doXQUvbCKpJCxq2dUjLd([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static Guid o7qlJtbCXEV3qOydG0EF([In] object obj0) => ((SearchForm) obj0).FormUid;

    internal static object J7dosDbCT5dPcyvUnC7X([In] object obj0, [In] object obj1, ViewType viewType) => (object) ((IObjectFormProvider) obj0).GetFormByType(obj1, viewType);

    internal static object z2k9DxbCksYItboeXJ1v([In] object obj0, [In] object obj1, Guid formUid) => (object) ((IObjectFormProvider) obj0).GetFormByUid(obj1, formUid);

    internal static object nTrkvEbCnV5NoX5GyC6r() => (object) EleWise.ELMA.SR.GetCurrentCulture();

    internal static object CMERd8bCOgsJhQUT369W([In] object obj0) => (object) ((CultureInfo) obj0).Name;

    internal static object mmlXZ9bC2nK9fFe5Z0rs() => (object) EleWise.ELMA.SR.KeyCultureInfo;

    internal static bool vEiGRIbCe3Nk8Sy74VSo([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static void UYHxc4bCP6MAhhD5NcWD([In] object obj0) => ((ViewItem) obj0).ApplyLocalization();

    internal static void yv4bNobC1tcjD7gZeRNe([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool byMmvQbCNnNWqa3hyegr([In] object obj0) => ((SearchForm) obj0).Debug;

    internal static bool zOHWC6bQcXpDIY2FLCO1() => SearchFormService.NVBXMObQs7n5nhHFPcNr == null;

    internal static SearchFormService eFvsSKbQzP0A5WFXtHQV() => SearchFormService.NVBXMObQs7n5nhHFPcNr;

    internal static object QrETUObC3dH1eddUDPUh([In] object obj0) => (object) ((EntityForm) obj0).Metadata;

    internal static object KYPAKDbCp1DGZW7PT9QU([In] object obj0) => (object) ((EntityForm) obj0).Entity;

    internal static bool gkAtcgbCa9JDCnZVBix9([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static void Bew8CObCDq4WCRT4L0aK([In] object obj0, [In] object obj1) => ((EntityFormView) obj0).Model = (string) obj1;

    internal static void swoMlbbCtBPFscP3wwZr([In] object obj0, [In] object obj1) => ((EntityFormView) obj0).View = (FormViewItem) obj1;

    internal static void qRjQQLbCwst6yPO7K3Mt([In] object obj0, [In] object obj1) => ((EntityFormView) obj0).Metadata = (IMetadata) obj1;

    internal static void Fg0ddlbC402iiZ0hXWDV([In] object obj0, [In] object obj1) => ((EntityFormView) obj0).FormViewBuilderInfo = (FormViewBuilderInfo) obj1;

    internal static void VtUXJ9bC6ThKdcpEID62([In] object obj0, Guid value) => ((ModelInfo) obj0).TypeUid = value;

    internal static void o8Qed0bCHa07KeIstkHD([In] object obj0, Guid value) => ((ModelInfo) obj0).SubTypeUid = value;

    internal static object mcHbsmbCAJZo66OxZV79([In] object obj0) => (object) ((FormView) obj0).OnLoadScriptName;

    internal static object FTmqRRbC7qSf3kxTcbqR(
      [In] object obj0,
      Type entityType,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((IEntityFilterProvider) obj0).GetFilterProviderData(entityType, (PropertyMetadata) obj2, (ViewAttributes) obj3);
    }

    internal static object B3cgO3bCx2ZkagPvFyl1(
      [In] object obj0,
      [In] object obj1,
      Type entityType,
      [In] object obj3,
      [In] object obj4)
    {
      return (object) ((IEntityInstanceFilterProvider) obj0).GetFilterProviderData((IEntity) obj1, entityType, (PropertyMetadata) obj3, (ViewAttributes) obj4);
    }

    internal static Guid vlc0MHbC0pPP99FILgJn([In] object obj0) => ((IEntityFilterProvider) obj0).ProviderUid;

    internal static void rQ37XgbCmHirDitB6Ppr([In] object obj0, Guid value) => ((ViewAttributes) obj0).EntityFilterProvider = value;

    internal static object wfZcDibCytx2s4GGfufy([In] object obj0) => (object) ((RootViewItem) obj0).Items;

    internal static void rEOVVJbCMrlmvOhA6LnL(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      ViewType viewType)
    {
      ((IPropertyViewItemAdjustmentRuntime2) obj0).Adjust((PropertyViewItem) obj1, obj2, viewType);
    }

    private sealed class ExtendMetadataModel
    {
      internal static object IR2Tf2CkJOR40MFRTfaS;

      public EntityMetadata Metadata
      {
        get => this.\u003CMetadata\u003Ek__BackingField;
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
                this.\u003CMetadata\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
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

      public bool IsSystem
      {
        get => this.\u003CIsSystem\u003Ek__BackingField;
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
                this.\u003CIsSystem\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
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

      public EntityMetadata ConfigExtMetadata
      {
        get => this.\u003CConfigExtMetadata\u003Ek__BackingField;
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
                this.\u003CConfigExtMetadata\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
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

      public ExtendMetadataModel()
      {
        SearchFormService.ExtendMetadataModel.a5ZPZ8Cklsyf1ye7V2kG();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool Lm88bdCk9CGF4xqtyG6R() => SearchFormService.ExtendMetadataModel.IR2Tf2CkJOR40MFRTfaS == null;

      internal static SearchFormService.ExtendMetadataModel Ad64XICkdvyvnTr4NTxk() => (SearchFormService.ExtendMetadataModel) SearchFormService.ExtendMetadataModel.IR2Tf2CkJOR40MFRTfaS;

      internal static void a5ZPZ8Cklsyf1ye7V2kG() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
