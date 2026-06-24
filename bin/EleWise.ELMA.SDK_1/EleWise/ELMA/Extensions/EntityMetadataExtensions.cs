// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.EntityMetadataExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions
{
  /// <summary>Расширение для EntityMetadata</summary>
  public static class EntityMetadataExtensions
  {
    /// <summary>
    /// Уникальный идентификатор активных метаданных привилегий
    /// </summary>
    public static Guid PermissionMetadataUid;
    /// <summary>Постфикс для генерации класса привилегий</summary>
    public const string PermissionPostfix = "Permission";
    private static EntityMetadataExtensions aPdmyFGaihaq59gUdX0B;

    /// <summary>
    /// Подерживаются ли права на элемент справочника для типа с заданными метаданными
    /// </summary>
    /// <param name="metadata">Метаданные</param>
    /// <returns>Возвращает true, если типом объекта поддерживаются права на элемент справочника.</returns>
    public static bool CanUsePermissions(this EntityMetadata metadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (metadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return EntityMetadataExtensions.CWxtNGGaK0jJaKUJBKMI((object) metadata) != null;
label_5:
      return false;
    }

    /// <summary>
    /// Получить название для свойства привилегий по умолчанию
    /// </summary>
    /// <param name="metadata">Метаданные для добавления свойства привилегий</param>
    public static string GetPermissionPropertyDefaultName(EntityMetadata metadata) => (string) EntityMetadataExtensions.qbZm64GaXUTkYcM5nWke((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(993438473 ^ 993350437), (object) EntityMetadataExtensions.GetPermissionPropertyNameIndex((object) metadata));

    /// <summary>Получить базовые метаданные</summary>
    /// <param name="uid">Уникальный идентификатор метаданных</param>
    public static EntityMetadata GetBaseMetadata(Guid uid) => (((IMetadataService) EntityMetadataExtensions.l25tXfGaTPylBOyc2Jgy()).GetMetadata(uid, false) as EntityMetadata).GetBaseMetadata();

    /// <summary>Получить базовые метаданные</summary>
    /// <param name="metadata">Метаданные</param>
    public static EntityMetadata GetBaseMetadata(this EntityMetadata metadata)
    {
      int num = 1;
      EntityMetadata baseMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            baseMetadata = metadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
            continue;
          case 3:
          case 4:
            goto label_7;
          case 5:
          case 6:
            baseMetadata = ((IMetadataService) EntityMetadataExtensions.l25tXfGaTPylBOyc2Jgy()).GetMetadata(EntityMetadataExtensions.ykTq8EGakJ3jXoEWD02m((object) baseMetadata), false) as EntityMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 2 : 2;
            continue;
          case 7:
            if (EntityMetadataExtensions.TicalFGanByw4cEl4BPT(EntityMetadataExtensions.ykTq8EGakJ3jXoEWD02m((object) baseMetadata), Guid.Empty))
            {
              num = 6;
              continue;
            }
            goto label_7;
          default:
            if (baseMetadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 4 : 2;
              continue;
            }
            goto case 7;
        }
      }
label_7:
      return baseMetadata;
    }

    /// <summary>
    /// Являются ли метаданные активным хранилищем привилегий сущности
    /// </summary>
    /// <param name="metadata">Метаданные</param>
    public static bool IsActivePermissionMetadata(this EntityMetadata metadata)
    {
      int num = 2;
      Guid tablePartPropertyUid;
      TablePartMetadata tablePartMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (tablePartMetadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            tablePartMetadata = metadata as TablePartMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            tablePartPropertyUid = tablePartMetadata.TablePartPropertyUid;
            num = 3;
            continue;
        }
      }
label_2:
      return tablePartPropertyUid.Equals(EntityMetadataExtensions.PermissionMetadataUid);
label_3:
      return false;
    }

    /// <summary>
    /// Отключить использование блока как хранилища привилегий
    /// </summary>
    /// <param name="metadata">Метаданные для которых отключаются привилегии</param>
    public static void DisablePermissionMetadata(this EntityMetadata metadata)
    {
      int num = 2;
      TablePartMetadata permissionMetadata;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            if (permissionMetadata != null)
            {
              EntityMetadataExtensions.TIdY4VGa2upeefQd8CTO((object) permissionMetadata, EntityMetadataExtensions.ig4i99GaOxUf3mEFYHHe());
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
              continue;
            }
            num = 3;
            continue;
          case 2:
            permissionMetadata = metadata.GetActivePermissionMetadata();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_3;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_3:
      return;
label_8:;
    }

    /// <summary>
    /// Задействовать класс метаданных блока в качестве хранилища привилегий
    /// </summary>
    /// <param name="metadata">Метаданные для которых активируются привилегии</param>
    /// <param name="permissionPropertyName">Свойство для хранения привилегий</param>
    public static void ActivatePermissionMetadata(
      this EntityMetadata metadata,
      string permissionPropertyName)
    {
      int num = 2;
      TablePartMetadata tablePartMetadata;
      string permissionPropertyName1;
      while (true)
      {
        switch (num)
        {
          case 1:
            permissionPropertyName1 = permissionPropertyName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 1;
            continue;
          case 3:
            goto label_2;
          case 4:
            EntityMetadataExtensions.fQuXspGaefOAB6OIbFYN((object) metadata, (object) tablePartMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 3 : 3;
            continue;
          default:
            // ISSUE: reference to a compiler-generated method
            tablePartMetadata = metadata.GetBaseMetadata().TableParts.FirstOrDefault<TablePartMetadata>((Func<TablePartMetadata, bool>) (p1 => (string) EntityMetadataExtensions.\u003C\u003Ec__DisplayClass9_0.FeZNIJ8Bs3AYRVamoZpZ((object) p1) == permissionPropertyName1));
            num = 4;
            continue;
        }
      }
label_2:;
    }

    /// <summary>
    /// Задействовать класс метаданных блока в качестве хранилища привилегий
    /// </summary>
    /// <param name="metadata">Метаданные для которых активируются привилегии</param>
    /// <param name="tablePartMetadata">Метаданные привилегий</param>
    public static void ActivatePermissionMetadata(
      this EntityMetadata metadata,
      TablePartMetadata tablePartMetadata)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        TablePartMetadata tablePartMetadata1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_8;
            case 2:
              if (!EntityMetadataExtensions.TicalFGanByw4cEl4BPT(EntityMetadataExtensions.JGg29PGaNujtHyA7UwNq((object) tablePartMetadata1), EntityMetadataExtensions.JGg29PGaNujtHyA7UwNq((object) tablePartMetadata)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
                continue;
              }
              goto label_8;
            case 3:
              goto label_3;
            case 4:
              if (tablePartMetadata != null)
              {
                tablePartMetadata1 = (TablePartMetadata) EntityMetadataExtensions.CWxtNGGaK0jJaKUJBKMI((object) metadata);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 6 : 5;
                continue;
              }
              goto label_7;
            case 6:
              if (tablePartMetadata1 == null)
              {
                num2 = 5;
                continue;
              }
              goto case 2;
            case 7:
              goto label_5;
            default:
              tablePartMetadata.TablePartPropertyUid = EntityMetadataExtensions.PermissionMetadataUid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 7 : 4;
              continue;
          }
        }
label_7:
        num1 = 3;
      }
label_5:
      return;
label_3:
      throw new MetadataException((string) EntityMetadataExtensions.utqQVGGa1aionmu8mMKn(EntityMetadataExtensions.sWcV0vGaPP7QWEEEJnMr(381945751 ^ 1158627804 ^ 1405664781)));
label_8:
      throw new MetadataException(EleWise.ELMA.SR.T((string) EntityMetadataExtensions.sWcV0vGaPP7QWEEEJnMr(1917998801 >> 2 ^ 479685904), (object) tablePartMetadata.Name, EntityMetadataExtensions.kjwNM2Ga3XClfRAXh0PW((object) metadata)));
    }

    /// <summary>Получить метаданные привилегий родительского типа</summary>
    /// <param name="metadata">Метаданные для которых запрашиваются привилегии</param>
    /// <returns>Возвращает метаданные привилегий, если их нет, то метаданные родительского типа.</returns>
    public static TablePartMetadata GetActivePermissionMetadata(this EntityMetadata metadata)
    {
      int num1 = 4;
      TablePartMetadata permissionMetadata;
      EntityMetadata baseMetadata;
      while (true)
      {
        switch (num1)
        {
          case 1:
            permissionMetadata = (TablePartMetadata) EntityMetadataExtensions.mhrE1VGaaTtISPUkHvdo((object) baseMetadata);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            baseMetadata = (EntityMetadata) EntityMetadataExtensions.fEEweXGapw1tmIhRWu1V((object) metadata);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 1;
            continue;
          case 4:
            num1 = 3;
            continue;
          case 5:
            if (EntityMetadataExtensions.M4J3dAGaDZ6kFHo4El48((object) baseMetadata))
            {
              num1 = 2;
              continue;
            }
            goto label_3;
          default:
            if (permissionMetadata == null)
            {
              num1 = 5;
              continue;
            }
            goto label_3;
        }
      }
label_2:
      return EntityMetadataExtensions.GetActivePermissionMetadataFromMetadata(MetadataServiceContext.Service.GetMetadataList().OfType<EntityMetadata>().FirstOrDefault<EntityMetadata>((Func<EntityMetadata, bool>) (a =>
      {
        int num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              if (EntityMetadataExtensions.\u003C\u003Ec__DisplayClass11_0.ybwia68WW5FD7mlvYuk0((object) a) == EntityMetadataType.InterfaceExtension)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
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
        return EntityMetadataExtensions.\u003C\u003Ec__DisplayClass11_0.ftsbiG8WbO9JROndjJpY(EntityMetadataExtensions.\u003C\u003Ec__DisplayClass11_0.kTdxB68WodeK4FlpHnpa((object) a), baseMetadata.Uid);
label_3:
        return false;
      })));
label_3:
      return permissionMetadata;
    }

    /// <summary>Получить метаданные привилегий</summary>
    /// <param name="metadata">Метаданные для которых запрашиваются привилегии</param>
    /// <returns>Возвращает метаданные привилегий, если их нет, то метаданные родительского типа.</returns>
    internal static TablePartMetadata GetActivePermissionMetadataFromMetadata(
      EntityMetadata metadata)
    {
      int num1 = 5;
      IEnumerable<TablePartMetadata> source;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (EntityMetadataExtensions.O5Cv0rGatKDII4Fjmjen((object) metadata.TableParts) == 0)
              {
                num2 = 2;
                continue;
              }
              List<TablePartMetadata> tableParts = metadata.TableParts;
              // ISSUE: reference to a compiler-generated field
              Func<TablePartMetadata, bool> func = EntityMetadataExtensions.\u003C\u003Ec.\u003C\u003E9__12_0;
              Func<TablePartMetadata, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                EntityMetadataExtensions.\u003C\u003Ec.\u003C\u003E9__12_0 = predicate = (Func<TablePartMetadata, bool>) (p1 => p1.IsActivePermissionMetadata());
              }
              else
                goto label_7;
label_22:
              source = tableParts.Where<TablePartMetadata>(predicate);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 9 : 5;
              continue;
label_7:
              predicate = func;
              goto label_22;
            case 2:
            case 6:
              goto label_19;
            case 3:
              if (source.Any<TablePartMetadata>())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 10;
                continue;
              }
              goto label_8;
            case 4:
              if (metadata.TableParts == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 6 : 5;
                continue;
              }
              goto case 1;
            case 5:
              goto label_3;
            case 8:
              goto label_15;
            case 9:
              if (source == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            case 10:
              if (source.Count<TablePartMetadata>() == 1)
              {
                num2 = 8;
                continue;
              }
              goto label_16;
            default:
              goto label_8;
          }
        }
label_3:
        if (metadata != null)
          num1 = 4;
        else
          goto label_19;
      }
label_8:
      return (TablePartMetadata) null;
label_15:
      return source.First<TablePartMetadata>();
label_16:
      throw new MetadataException(EleWise.ELMA.SR.T((string) EntityMetadataExtensions.sWcV0vGaPP7QWEEEJnMr(-35995181 ^ -36095997), EntityMetadataExtensions.kjwNM2Ga3XClfRAXh0PW((object) metadata)));
label_19:
      return (TablePartMetadata) null;
    }

    /// <summary>
    /// Создать новый экземпляр метаданных для хранения привилегий
    /// </summary>
    /// <param name="metadata">Метаданные для которых добавляются привилегий</param>
    /// <param name="permissionMetadata">Метаданные привилегий</param>
    /// <param name="metadataName">Наименование для метаданных привилегий</param>
    /// <param name="propertyName">Название</param>
    public static void InitNewPermissionMetadata(
      this EntityMetadata metadata,
      TablePartMetadata permissionMetadata,
      string metadataName,
      string propertyName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            metadata.InitNewPermissionMetadata(permissionMetadata, metadataName, propertyName, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Создать новый экземпляр метаданных для хранения привилегий
    /// </summary>
    /// <param name="metadata">Метаданные для которых добавляются привилегий</param>
    /// <param name="permissionMetadata">Метаданные привилегий</param>
    /// <param name="metadataName">Наименование для метаданных привилегий</param>
    /// <param name="propertyName">Название</param>
    /// <param name="activate">Активировать созданные метаданные как хранилище привилегий</param>
    public static void InitNewPermissionMetadata(
      this EntityMetadata metadata,
      TablePartMetadata permissionMetadata,
      string metadataName,
      string propertyName,
      bool activate)
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        EntityMetadata entityMetadata;
        while (true)
        {
          string str1;
          string str2;
          switch (num2)
          {
            case 0:
              goto label_17;
            case 1:
              EntityMetadataExtensions.fQuXspGaefOAB6OIbFYN((object) metadata, (object) permissionMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 5 : 0;
              continue;
            case 2:
              if (!activate)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
                continue;
              }
              goto case 1;
            case 3:
              EntityMetadataExtensions.wBt7ZRGaJLJjfybb9S89((object) permissionMetadata, (object) entityMetadata);
              num2 = 2;
              continue;
            case 4:
              EntityMetadataExtensions.d5vr6NGaMRbv5om3SF8j((object) permissionMetadata, false);
              num2 = 3;
              continue;
            case 5:
              goto label_3;
            case 6:
              EntityMetadataExtensions.yZOytRGa6WqjcrOT0Xvs((object) permissionMetadata, !EntityMetadataExtensions.BdHK2HGawxJXM0NsIGdR((object) metadataName) ? (object) metadataName : EntityMetadataExtensions.LARtMbGa4uymplrSA7ID((object) entityMetadata.Name, EntityMetadataExtensions.sWcV0vGaPP7QWEEEJnMr(-16752921 ^ -16538477)));
              num2 = 14;
              continue;
            case 7:
              goto label_13;
            case 8:
              EntityMetadataExtensions.QvJ93WGa0CSX5A4WuHbV((object) permissionMetadata, (object) EleWise.ELMA.SR.T((string) EntityMetadataExtensions.sWcV0vGaPP7QWEEEJnMr(1319452732 ^ 1319549692), (object) entityMetadata.DisplayName));
              num2 = 16;
              continue;
            case 9:
              EntityMetadataExtensions.n3FPdFGaypg5RmDucLWa((object) permissionMetadata, false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 4 : 2;
              continue;
            case 10:
              goto label_11;
            case 11:
              EntityMetadataExtensions.bSktZmGaxNBxnXtMsO8y((object) permissionMetadata, (object) propertyName);
              num2 = 13;
              continue;
            case 12:
              str2 = ((string) EntityMetadataExtensions.kjwNM2Ga3XClfRAXh0PW((object) permissionMetadata)).Substring(0, 28);
              break;
            case 13:
              permissionMetadata.DisplayName = EleWise.ELMA.SR.T((string) EntityMetadataExtensions.sWcV0vGaPP7QWEEEJnMr(-688192331 - 435440695 ^ -1123728654), (object) entityMetadata.DisplayName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 5 : 15;
              continue;
            case 14:
              if (EntityMetadataExtensions.fk9okqGaHQteRgRNYKE6(EntityMetadataExtensions.kjwNM2Ga3XClfRAXh0PW((object) permissionMetadata)) > 28)
              {
                num2 = 12;
                continue;
              }
              str2 = permissionMetadata.Name;
              break;
            case 15:
              permissionMetadata.TableName = str1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 8 : 6;
              continue;
            case 16:
              EntityMetadataExtensions.vtYX9kGamemEXFxuMhgj((object) permissionMetadata, false);
              num2 = 9;
              continue;
            default:
              goto label_24;
          }
          str1 = str2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 2 : 10;
        }
label_11:
        EntityMetadataExtensions.IC4jfiGa7IFvWyBgduBv((object) permissionMetadata, EntityMetadataExtensions.FbI8imGaA55QnMChiv3L((object) entityMetadata));
        num1 = 11;
        continue;
label_13:
        entityMetadata = (EntityMetadata) EntityMetadataExtensions.fEEweXGapw1tmIhRWu1V((object) metadata);
        num1 = 6;
      }
label_17:
      return;
label_3:
      return;
label_24:;
    }

    /// <summary>
    /// Добавить реализуемые интерфейсы и необходимые свойства в метаданные привилегий
    /// </summary>
    /// <param name="permissionMetadata">Метаданные привилегий</param>
    /// <param name="baseMetadata">Базовые метаданные</param>
    public static void AddPermissionInterfaces(
      this EntityMetadata permissionMetadata,
      EntityMetadata baseMetadata)
    {
      int num1 = 1;
      IEnumerator<IEntityPermissionsTypeExtensionPoint> enumerator1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator1 = ((ComponentManager) EntityMetadataExtensions.m94rvVGa96TMyk7k4M3N()).GetExtensionPoints<IEntityPermissionsTypeExtensionPoint>().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_39;
          default:
            goto label_3;
        }
      }
label_39:
      return;
label_3:
      try
      {
label_31:
        if (enumerator1.MoveNext())
          goto label_30;
        else
          goto label_32;
label_5:
        IEnumerator<PropertyMetadata> enumerator2;
        int num2;
        switch (num2)
        {
          case 0:
            return;
          case 1:
            goto label_31;
          case 2:
            try
            {
label_11:
              if (EntityMetadataExtensions.HabaQGGarbRoAc9E01mZ((object) enumerator2))
                goto label_15;
              else
                goto label_12;
label_7:
              ClassMetadata metadata;
              int num3;
              PropertyMetadata defaultProperty;
              while (true)
              {
                PropertyMetadata propertyMetadata1;
                switch (num3)
                {
                  case 1:
                    if (!EntityMetadataExtensions.TicalFGanByw4cEl4BPT(EntityMetadataExtensions.n8PCR2GalgrBxbrDbH7s((object) propertyMetadata1), EntityMetadataExtensions.n8PCR2GalgrBxbrDbH7s((object) defaultProperty)))
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 10 : 3;
                      continue;
                    }
                    break;
                  case 2:
                    goto label_10;
                  case 3:
                  case 7:
                    if (EntityMetadataExtensions.TicalFGanByw4cEl4BPT(EntityMetadataExtensions.fg46OmGadeiKnaCIo3ee((object) propertyMetadata1), defaultProperty.TypeUid))
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
                      continue;
                    }
                    goto case 1;
                  case 4:
                    defaultProperty = enumerator2.Current;
                    num3 = 13;
                    continue;
                  case 6:
                    permissionMetadata.Properties.Add(defaultProperty);
                    num3 = 8;
                    continue;
                  case 8:
                  case 10:
                    goto label_11;
                  case 9:
                    goto label_31;
                  case 11:
                    if (propertyMetadata1 != null)
                    {
                      num3 = 7;
                      continue;
                    }
                    goto case 6;
                  case 12:
                    goto label_15;
                  case 13:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    PropertyMetadata propertyMetadata2 = permissionMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (a => EntityMetadataExtensions.\u003C\u003Ec__DisplayClass15_0.vG0rcX8Wu55TiWQeKxMZ(EntityMetadataExtensions.\u003C\u003Ec__DisplayClass15_0.F0b56f8WZwvP7hUoySAH((object) a), defaultProperty.Uid)));
                    // ISSUE: reference to a compiler-generated method
                    propertyMetadata1 = permissionMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (a => EntityMetadataExtensions.\u003C\u003Ec__DisplayClass15_0.QSs4n08WIyKxpiIJovKq((object) a.Name, (object) defaultProperty.Name)));
                    if (propertyMetadata2 == null)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 3 : 11;
                      continue;
                    }
                    goto label_11;
                }
                metadata = ((IMetadataService) EntityMetadataExtensions.l25tXfGaTPylBOyc2Jgy()).GetMetadata(EntityMetadataExtensions.n8PCR2GalgrBxbrDbH7s((object) defaultProperty)) as ClassMetadata;
                num3 = 2;
              }
label_10:
              throw new MetadataException(EleWise.ELMA.SR.T((string) EntityMetadataExtensions.sWcV0vGaPP7QWEEEJnMr(132912447 ^ 133164601), (object) defaultProperty.Name, EntityMetadataExtensions.kjwNM2Ga3XClfRAXh0PW((object) metadata)));
label_12:
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 8 : 9;
              goto label_7;
label_15:
              num3 = 4;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
              {
                num3 = 2;
                goto label_7;
              }
              else
                goto label_7;
            }
            finally
            {
              int num4;
              if (enumerator2 == null)
                num4 = 2;
              else
                goto label_27;
label_26:
              switch (num4)
              {
                case 1:
                case 2:
              }
label_27:
              enumerator2.Dispose();
              num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
              {
                num4 = 1;
                goto label_26;
              }
              else
                goto label_26;
            }
          case 3:
            break;
          default:
            return;
        }
label_30:
        enumerator2 = enumerator1.Current.GetDefaultPermissionMetadataProperties(baseMetadata).GetEnumerator();
        num2 = 2;
        goto label_5;
label_32:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
        goto label_5;
      }
      finally
      {
        int num5;
        if (enumerator1 == null)
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
        else
          goto label_38;
label_36:
        switch (num5)
        {
          case 1:
            break;
          default:
        }
label_38:
        enumerator1.Dispose();
        num5 = 2;
        goto label_36;
      }
    }

    /// <summary>
    /// Для EntityMetadataType.Interface определяет уникальный идентификатор реализующей сущности.
    /// Для EntityMetadataType.InterfaceImplementation определяет уникальный идентификатор интерфейса.
    /// </summary>
    public static Guid GetImplementationUid(this IEntityMetadata metadata)
    {
      int num = 1;
      EntityMetadata entityMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            entityMetadata = metadata as EntityMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          case 3:
            goto label_3;
          default:
            if (entityMetadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 2 : 2;
              continue;
            }
            goto label_3;
        }
      }
label_3:
      return entityMetadata.ImplementationUid;
label_4:
      return EntityMetadataExtensions.QF503fGagqkTdQ7f4MUo((object) metadata);
    }

    /// <summary>Uid базового класса</summary>
    public static Guid GetBaseClassUid(this IEntityMetadata metadata)
    {
      int num = 3;
      EntityMetadata entityMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (entityMetadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          case 3:
            entityMetadata = metadata as EntityMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 2;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return EntityMetadataExtensions.ykTq8EGakJ3jXoEWD02m((object) entityMetadata);
label_5:
      return Guid.Empty;
    }

    private static int? GetPermissionPropertyNameIndex(object metadata)
    {
      int? propertyNameIndex = new int?();
      foreach (PropertyMetadata property in ((ClassMetadata) metadata).Properties)
      {
        if (property.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538632134))
        {
          if (!propertyNameIndex.HasValue)
            propertyNameIndex = new int?(1);
        }
        else
        {
          int result;
          if (property.Name.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669557703)) && int.TryParse(property.Name.Substring(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121114151).Length), out result))
          {
            int num = result;
            int? nullable = propertyNameIndex;
            int valueOrDefault = nullable.GetValueOrDefault();
            if (num > valueOrDefault & nullable.HasValue)
              propertyNameIndex = new int?(result);
          }
        }
      }
      return propertyNameIndex;
    }

    /// <summary>Являются ли метаданные системными</summary>
    /// <param name="metadata">Метаданные</param>
    public static bool IsSystem(this IMetadata metadata) => EntityMetadataExtensions.qx5HCJGa5c4jG7moke0X(EntityMetadataExtensions.QF503fGagqkTdQ7f4MUo((object) metadata));

    /// <summary>Являются ли тип системными</summary>
    /// <param name="type">Тип</param>
    public static bool IsSystem(this Type type) => EntityMetadataExtensions.qx5HCJGa5c4jG7moke0X(InterfaceActivator.UID(type, false));

    /// <summary>Являются ли метаданные системными</summary>
    /// <param name="typeUid">Идентификатор метаданных</param>
    public static bool IsSystemMetadata(this Guid typeUid) => EntityMetadataExtensions.olUxD1GajyiCiNfZkZQw(EntityMetadataExtensions.l25tXfGaTPylBOyc2Jgy(), typeUid);

    /// <summary>Являются ли метаданные созданными в конфигурации</summary>
    /// <param name="metadata">Метаданные</param>
    public static bool IsConfig(this IMetadata metadata) => EntityMetadataExtensions.UtIHCTGaYqCD3SdlqPuJ(EntityMetadataExtensions.QF503fGagqkTdQ7f4MUo((object) metadata));

    /// <summary>Являются ли тип в конфигурации</summary>
    /// <param name="type">Тип</param>
    public static bool IsConfig(this Type type) => InterfaceActivator.UID(type, false).IsConfigMetadata();

    /// <summary>Являются ли метаданные созданными в конфигурации</summary>
    /// <param name="typeUid">Идентификатор метаданных</param>
    public static bool IsConfigMetadata(this Guid typeUid) => EntityMetadataExtensions.rG9eEiGaLt1hp0EHxlb3(EntityMetadataExtensions.l25tXfGaTPylBOyc2Jgy(), typeUid);

    /// <summary>Получить отображаемое имя</summary>
    /// <param name="metadata">Метаданные</param>
    /// <returns>Отображаемое имя</returns>
    public static string GetDisplayName(this ICodeItemMetadata metadata) => (string) EntityMetadataExtensions.W3v935GaU8aWP6Y8GYjb((object) MetadataServiceContext.Service, (object) metadata);

    static EntityMetadataExtensions()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            EntityMetadataExtensions.PermissionMetadataUid = new Guid((string) EntityMetadataExtensions.sWcV0vGaPP7QWEEEJnMr(-882126494 ^ -882365778));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
            continue;
          case 2:
            EntityMetadataExtensions.DEqgX8GasBrdMDr2jBWf();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object CWxtNGGaK0jJaKUJBKMI([In] object obj0) => (object) ((EntityMetadata) obj0).GetActivePermissionMetadata();

    internal static bool nXKexuGaRkDQAlWShKgS() => EntityMetadataExtensions.aPdmyFGaihaq59gUdX0B == null;

    internal static EntityMetadataExtensions WsoayIGaqUAnY6Z3tJuh() => EntityMetadataExtensions.aPdmyFGaihaq59gUdX0B;

    internal static object qbZm64GaXUTkYcM5nWke([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static object l25tXfGaTPylBOyc2Jgy() => (object) MetadataServiceContext.Service;

    internal static Guid ykTq8EGakJ3jXoEWD02m([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

    internal static bool TicalFGanByw4cEl4BPT([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static Guid ig4i99GaOxUf3mEFYHHe() => Guid.NewGuid();

    internal static void TIdY4VGa2upeefQd8CTO([In] object obj0, Guid value) => ((TablePartMetadata) obj0).TablePartPropertyUid = value;

    internal static void fQuXspGaefOAB6OIbFYN([In] object obj0, [In] object obj1) => ((EntityMetadata) obj0).ActivatePermissionMetadata((TablePartMetadata) obj1);

    internal static object sWcV0vGaPP7QWEEEJnMr(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object utqQVGGa1aionmu8mMKn([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static Guid JGg29PGaNujtHyA7UwNq([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object kjwNM2Ga3XClfRAXh0PW([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object fEEweXGapw1tmIhRWu1V([In] object obj0) => (object) ((EntityMetadata) obj0).GetBaseMetadata();

    internal static object mhrE1VGaaTtISPUkHvdo([In] object obj0) => (object) EntityMetadataExtensions.GetActivePermissionMetadataFromMetadata((EntityMetadata) obj0);

    internal static bool M4J3dAGaDZ6kFHo4El48([In] object obj0) => ((IMetadata) obj0).IsSystem();

    internal static int O5Cv0rGatKDII4Fjmjen([In] object obj0) => ((List<TablePartMetadata>) obj0).Count;

    internal static bool BdHK2HGawxJXM0NsIGdR([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object LARtMbGa4uymplrSA7ID([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void yZOytRGa6WqjcrOT0Xvs([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).Name = (string) obj1;

    internal static int fk9okqGaHQteRgRNYKE6([In] object obj0) => ((string) obj0).Length;

    internal static object FbI8imGaA55QnMChiv3L([In] object obj0) => (object) ((ClassMetadata) obj0).Namespace;

    internal static void IC4jfiGa7IFvWyBgduBv([In] object obj0, [In] object obj1) => ((ClassMetadata) obj0).Namespace = (string) obj1;

    internal static void bSktZmGaxNBxnXtMsO8y([In] object obj0, [In] object obj1) => ((TablePartMetadata) obj0).TablePartPropertyName = (string) obj1;

    internal static void QvJ93WGa0CSX5A4WuHbV([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).Description = (string) obj1;

    internal static void vtYX9kGamemEXFxuMhgj([In] object obj0, bool value) => ((EntityMetadata) obj0).ShowInCatalogList = value;

    internal static void n3FPdFGaypg5RmDucLWa([In] object obj0, bool value) => ((ClassMetadata) obj0).ShowInTypeTree = value;

    internal static void d5vr6NGaMRbv5om3SF8j([In] object obj0, bool value) => ((ClassMetadata) obj0).ShowInDesigner = value;

    internal static void wBt7ZRGaJLJjfybb9S89([In] object obj0, [In] object obj1) => ((EntityMetadata) obj0).AddPermissionInterfaces((EntityMetadata) obj1);

    internal static object m94rvVGa96TMyk7k4M3N() => (object) ComponentManager.Current;

    internal static Guid fg46OmGadeiKnaCIo3ee([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static Guid n8PCR2GalgrBxbrDbH7s([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

    internal static bool HabaQGGarbRoAc9E01mZ([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static Guid QF503fGagqkTdQ7f4MUo([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static bool qx5HCJGa5c4jG7moke0X(Guid typeUid) => typeUid.IsSystemMetadata();

    internal static bool olUxD1GajyiCiNfZkZQw([In] object obj0, Guid typeUid) => ((IMetadataService) obj0).IsSystem(typeUid);

    internal static bool UtIHCTGaYqCD3SdlqPuJ(Guid typeUid) => typeUid.IsConfigMetadata();

    internal static bool rG9eEiGaLt1hp0EHxlb3([In] object obj0, Guid typeUid) => ((IMetadataService) obj0).IsConfig(typeUid);

    internal static object W3v935GaU8aWP6Y8GYjb([In] object obj0, [In] object obj1) => (object) ((IMetadataService) obj0).GetDisplayName((ICodeItemMetadata) obj1);

    internal static void DEqgX8GasBrdMDr2jBWf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
