// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.Helpers.MetadataImportHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Metadata;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Import.Helpers
{
  /// <summary>Помощник для модуля метаданных</summary>
  public static class MetadataImportHelper
  {
    internal static MetadataImportHelper ILhJuvEykNKYmlqIYu2d;

    /// <summary>Являются ли метаданные системными</summary>
    /// <param name="md"></param>
    /// <returns></returns>
    [Obsolete("Use EntityMetadataExtensions.IsSystem instead", true)]
    public static bool IsSystem(EntityMetadata md) => MetadataImportHelper.XRkrLSEy2qfJLREGCI0B((object) md);

    /// <summary>Являются ли метаданные системными</summary>
    /// <param name="md"></param>
    /// <returns></returns>
    [Obsolete("Use EntityMetadataExtensions.IsSystem or MetadataRuntimeService.IsSystem instead", true)]
    public static bool IsSystem(IMetadata md) => md.IsSystem();

    /// <summary>Являются ли метаданные системными</summary>
    /// <param name="typeUidMd"></param>
    /// <returns></returns>
    [Obsolete("Use EntityMetadataExtensions.IsSystemMetadata or MetadataRuntimeService.IsSystem instead", true)]
    public static bool IsSystem(Guid typeUidMd) => typeUidMd.IsSystemMetadata();

    /// <summary>Являются ли метаданные созданными в конфигурации</summary>
    /// <param name="md">Метаданные</param>
    [Obsolete("Use EntityMetadataExtensions.IsConfig or MetadataRuntimeService.IsConfig instead", true)]
    public static bool IsConfig(IMetadata md) => MetadataImportHelper.IDvr2BEyeY7516cnNhlA((object) md);

    /// <summary>Являются ли метаданные созданными в конфигурации</summary>
    /// <param name="typeUidMd">Идентификатор метаданных</param>
    [Obsolete("Use EntityMetadataExtensions.IsConfigMetadata or MetadataRuntimeService.IsConfig instead", true)]
    public static bool IsConfig(Guid typeUidMd) => typeUidMd.IsConfigMetadata();

    /// <summary>
    /// Рекурсивное получение списка всех свойств и блоков, относящихся к метаданным
    /// </summary>
    /// <param name="md"></param>
    /// <returns></returns>
    public static List<IPropertyMetadata> GetAllPropertiesAndTableParts(EntityMetadata md)
    {
      List<IPropertyMetadata> result = new List<IPropertyMetadata>();
      if (md != null && md.Properties != null)
        result.AddRange((IEnumerable<IPropertyMetadata>) md.Properties);
      if (md != null && md.TableParts != null)
        md.TableParts.ForEach((Action<TablePartMetadata>) (t =>
        {
          int num = 2;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                result.AddRange((IEnumerable<IPropertyMetadata>) MetadataImportHelper.GetAllPropertiesAndTableParts((EntityMetadata) t));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
                continue;
              case 2:
                result.Add((IPropertyMetadata) t);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 1 : 1;
                continue;
              default:
                goto label_5;
            }
          }
label_2:
          return;
label_5:;
        }));
      return result;
    }

    /// <summary>Нужен ли перезапуск сервера</summary>
    /// <returns></returns>
    public static bool IsRestartNeeded() => Locator.GetServiceNotNull<IModelManager>().GetRestartRequiredMetadataUids().Count > 0;

    /// <summary>Валидировать имя объекта метаданных</summary>
    /// <param name="metadata">Метаданные</param>
    /// <param name="name">Имя метаданных</param>
    /// <returns>Сообщения в результате проверки файла импорта</returns>
    public static TestImportMessages ValidateObjectName(NamedMetadata metadata, string name)
    {
      int num1 = 12;
      NamedMetadata namedMetadata;
      string text;
      NamedMetadata metadata1;
      Func<NamedMetadata, bool> checkMetadata;
      string name1;
      while (true)
      {
        switch (num1)
        {
          case 1:
          case 6:
          case 23:
            if (!((IMetadataService) MetadataImportHelper.SsJUppEy3PnZ6h2mMab2()).GetMetadataList().OfType<NamedMetadata>().Any<NamedMetadata>((Func<NamedMetadata, bool>) (m =>
            {
              int num2 = 4;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                  case 2:
                    goto label_5;
                  case 3:
                    // ISSUE: reference to a compiler-generated method
                    if (MetadataImportHelper.\u003C\u003Ec__DisplayClass7_0.dSpTnb8DlSWs3dy9jTUt((object) m) == null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 1;
                      continue;
                    }
                    break;
                  case 4:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    if (MetadataImportHelper.\u003C\u003Ec__DisplayClass7_0.CVsqFq8DdtmA6nrtfsio(MetadataImportHelper.\u003C\u003Ec__DisplayClass7_0.G2crOj8D9YuKjjDwlo90((object) m), MetadataImportHelper.\u003C\u003Ec__DisplayClass7_0.G2crOj8D9YuKjjDwlo90((object) metadata1)))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 3 : 1;
                      continue;
                    }
                    goto label_5;
                  case 5:
                    goto label_4;
                }
                if (!checkMetadata(m))
                  num2 = 2;
                else
                  break;
              }
label_4:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              return MetadataImportHelper.\u003C\u003Ec__DisplayClass7_0.Gf4HCB8DrKBBJY59fosd(MetadataImportHelper.\u003C\u003Ec__DisplayClass7_0.dSpTnb8DlSWs3dy9jTUt((object) m), (object) name1, StringComparison.CurrentCultureIgnoreCase);
label_5:
              return false;
            })))
            {
              num1 = 7;
              continue;
            }
            goto label_16;
          case 2:
            if (namedMetadata is FunctionMetadata _)
            {
              num1 = 16;
              continue;
            }
            goto case 8;
          case 3:
            if (namedMetadata == null)
            {
              num1 = 14;
              continue;
            }
            goto case 10;
          case 4:
          case 13:
            // ISSUE: reference to a compiler-generated field
            Func<NamedMetadata, bool> func1 = MetadataImportHelper.\u003C\u003Ec.\u003C\u003E9__7_1;
            Func<NamedMetadata, bool> func2;
            if (func1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              MetadataImportHelper.\u003C\u003Ec.\u003C\u003E9__7_1 = func2 = (Func<NamedMetadata, bool>) (m => m is ComponentMetadata);
            }
            else
              goto label_30;
label_27:
            checkMetadata = func2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 15 : 0;
            continue;
label_30:
            func2 = func1;
            goto label_27;
          case 5:
            text = EleWise.ELMA.SR.T((string) MetadataImportHelper.jgyh0PEy1XR7gj3FqUWV(-1876063057 ^ -1876345699), (object) name1);
            num1 = 23;
            continue;
          case 7:
            goto label_17;
          case 8:
          case 14:
            checkMetadata = (Func<NamedMetadata, bool>) (m =>
            {
              int num3 = 2;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    if (m is FunctionMetadata)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
                      continue;
                    }
                    goto case 3;
                  case 2:
                    if (!(m is ComponentMetadata))
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 1 : 1;
                      continue;
                    }
                    goto label_10;
                  case 3:
                    if (m is EntityMetadata entityMetadata2)
                    {
                      num3 = 4;
                      continue;
                    }
                    goto label_9;
                  case 4:
                    goto label_8;
                  default:
                    goto label_10;
                }
              }
label_8:
              return !entityMetadata2.Type.In<EntityMetadataType>(EntityMetadataType.InterfaceExtension, EntityMetadataType.InterfaceImplementation);
label_9:
              return true;
label_10:
              return false;
            });
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 10 : 17;
            continue;
          case 9:
            name1 = name;
            num1 = 18;
            continue;
          case 10:
            if (namedMetadata is ComponentMetadata _)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 1 : 4;
              continue;
            }
            goto case 2;
          case 11:
            metadata1 = metadata;
            num1 = 9;
            continue;
          case 12:
            num1 = 11;
            continue;
          case 15:
            text = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420521850), (object) name1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 1;
            continue;
          case 16:
          case 19:
            checkMetadata = (Func<NamedMetadata, bool>) (m => m is FunctionMetadata);
            num1 = 5;
            continue;
          case 17:
            text = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 902100673), (object) name1);
            num1 = 6;
            continue;
          case 18:
            if (!MetadataImportHelper.ApapVyEyP3LmxV9sDU5W((object) name1))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
              continue;
            }
            if (!MetadataImportHelper.jK9OTtEyNDaCFAyR8mVR((object) name1))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 8 : 20;
              continue;
            }
            goto label_12;
          case 20:
            namedMetadata = metadata1;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 3;
            continue;
          case 21:
            goto label_16;
          case 22:
            goto label_12;
          default:
            goto label_22;
        }
      }
label_12:
      return new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) MetadataImportHelper.jgyh0PEy1XR7gj3FqUWV(1232639661 >> 3 ^ 153861525), (object) name1));
label_16:
      return new TestImportMessages(TestImportMessagesType.Error, text);
label_17:
      return (TestImportMessages) null;
label_22:
      return new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) MetadataImportHelper.jgyh0PEy1XR7gj3FqUWV(-138018305 ^ -138236019), (object) name1));
    }

    /// <summary>Валидировать имя объекта метаданных для блока</summary>
    public static TestImportMessages ValidateObjectTablePartName(
      ICodeItemMetadata metadata,
      string name,
      Guid uid)
    {
      int num1 = 2;
      ICodeItemMetadata metadata1;
      string name1;
      Guid uid1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            metadata1 = metadata;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 3 : 0;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 1;
            continue;
          case 3:
            name1 = name;
            num1 = 7;
            continue;
          case 4:
            goto label_8;
          case 5:
            if (MetadataImportHelper.jK9OTtEyNDaCFAyR8mVR((object) name1))
            {
              num1 = 4;
              continue;
            }
            if (!MetadataServiceContext.Service.GetMetadataList().OfType<ICodeItemMetadata>().Any<ICodeItemMetadata>((Func<ICodeItemMetadata, bool>) (m =>
            {
              int num2 = 6;
              while (true)
              {
                int num3 = num2;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      if (MetadataImportHelper.\u003C\u003Ec__DisplayClass8_0.pbtMgK8tbQes37R59tOC((object) (EntityMetadata) m) == EntityMetadataType.Interface)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
                        continue;
                      }
                      goto label_10;
                    case 2:
                      if (m is EntityMetadata)
                        goto case 4;
                      else
                        goto label_14;
                    case 3:
                      goto label_9;
                    case 4:
                      // ISSUE: reference to a compiler-generated method
                      if (MetadataImportHelper.\u003C\u003Ec__DisplayClass8_0.pbtMgK8tbQes37R59tOC((object) (EntityMetadata) m) == EntityMetadataType.Entity)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 7;
                        continue;
                      }
                      goto case 1;
                    case 5:
                      // ISSUE: reference to a compiler-generated method
                      if (MetadataImportHelper.\u003C\u003Ec__DisplayClass8_0.X1IhOi8tonNtyTqCAqxO((object) m) != null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 2;
                        continue;
                      }
                      goto label_10;
                    case 6:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (MetadataImportHelper.\u003C\u003Ec__DisplayClass8_0.DbWcGq8tWOgdpR9RdJEf(m.Uid, MetadataImportHelper.\u003C\u003Ec__DisplayClass8_0.Rk7b048tBxsKbPf4NqJF((object) metadata1)))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 5 : 5;
                        continue;
                      }
                      goto label_10;
                    case 8:
                      goto label_10;
                    default:
                      if (!m.Name.Equals(name1, StringComparison.CurrentCultureIgnoreCase))
                      {
                        num3 = 8;
                        continue;
                      }
                      goto label_9;
                  }
                }
label_14:
                num2 = 9;
              }
label_9:
              // ISSUE: reference to a compiler-generated method
              return MetadataImportHelper.\u003C\u003Ec__DisplayClass8_0.DbWcGq8tWOgdpR9RdJEf(m.Uid, uid1);
label_10:
              return false;
            })))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
              continue;
            }
            goto label_14;
          case 6:
            goto label_5;
          case 7:
            uid1 = uid;
            num1 = 8;
            continue;
          case 8:
            if (MetadataImportHelper.ApapVyEyP3LmxV9sDU5W((object) name1))
            {
              num1 = 5;
              continue;
            }
            goto label_5;
          case 9:
            goto label_14;
          default:
            goto label_15;
        }
      }
label_5:
      return new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479208692), (object) name1));
label_8:
      return new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) MetadataImportHelper.jgyh0PEy1XR7gj3FqUWV(589593376 ^ -1977315327 ^ -1459332821), (object) name1));
label_14:
      return new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) MetadataImportHelper.jgyh0PEy1XR7gj3FqUWV(323422137 << 2 ^ 1293462658), (object) name1));
label_15:
      return (TestImportMessages) null;
    }

    /// <summary>Валидировать имя таблицы сущности</summary>
    public static TestImportMessages ValidateEntityTableName(
      EntityMetadata metadata,
      string tableName,
      string messageAdditionalInfo = null)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (MetadataImportHelper.HZtra3Eyp8v2JenA8gET((object) metadata) == EntityMetadataType.InterfaceExtension)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
              continue;
            }
            if (!(metadata is TablePartMetadata))
            {
              num = 3;
              continue;
            }
            goto label_10;
          case 2:
            if (metadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 0;
              continue;
            }
            goto label_7;
          case 3:
            goto label_4;
          default:
            goto label_7;
        }
      }
label_4:
      Guid ownerUid = metadata.Uid;
      goto label_11;
label_7:
      return (TestImportMessages) null;
label_10:
      ownerUid = MetadataImportHelper.GOm7ykEya66GGNQudyGE((object) (TablePartMetadata) metadata);
label_11:
      string tableName1 = tableName;
      Guid uid = new Guid();
      string messageAdditionalInfo1 = messageAdditionalInfo;
      return MetadataImportHelper.ValidateTableName(ownerUid, tableName1, uid, messageAdditionalInfo1);
    }

    public static string NewRelationTableName(
      string tableName,
      Guid propertyImportedUid,
      EntitySettings propertyImportedSettings)
    {
      int num1 = 1;
      string str;
      while (true)
      {
        int num2;
        object obj;
        switch (num1)
        {
          case 1:
            if (tableName.Count<char>() >= 28)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
              continue;
            }
            goto case 6;
          case 2:
          case 9:
            goto label_16;
          case 3:
            str = (string) MetadataImportHelper.PPxEimEywpOTRbu4HjTt((object) tableName, (object) ++num2);
            num1 = 7;
            continue;
          case 4:
            num2 = 0;
            num1 = 3;
            continue;
          case 5:
            str = (string) MetadataImportHelper.PPxEimEywpOTRbu4HjTt((object) tableName, (object) ++num2);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 3 : 8;
            continue;
          case 6:
            obj = (object) tableName;
            break;
          case 7:
          case 8:
            if (MetadataImportHelper.ValidateTableName(propertyImportedUid, str) == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 9 : 3;
              continue;
            }
            goto case 12;
          case 10:
            str = "";
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 2 : 13;
            continue;
          case 11:
            goto label_2;
          case 12:
            if (str.Count<char>() < 28)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 5 : 3;
              continue;
            }
            goto label_2;
          case 13:
            if (MetadataImportHelper.js7CQUEytgX4utoivcHE((object) tableName) <= 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 2 : 0;
              continue;
            }
            goto case 4;
          default:
            obj = MetadataImportHelper.t4oYKSEyDXEhmVqo2RQt((object) tableName, 0, 23);
            break;
        }
        tableName = (string) obj;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 10 : 10;
      }
label_2:
      return "";
label_16:
      return str;
    }

    /// <summary>Валидировать имя таблицы для какого-либо элемента</summary>
    public static TestImportMessages ValidateTableName(
      Guid ownerUid,
      string tableName,
      Guid uid = default (Guid),
      string messageAdditionalInfo = null)
    {
      int num1 = 9;
      IEnumerator<EntityMetadata> enumerator;
      string str;
      int num2;
      while (true)
      {
        object obj;
        switch (num1)
        {
          case 1:
            if (MetadataImportHelper.T3rjTWEy6gd9DkVBVCYe((object) tableName))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 2 : 5;
              continue;
            }
            if (!MetadataImportHelper.xqo1qPEyAOxmC4E7GLum((object) tableName, MetadataImportHelper.jgyh0PEy1XR7gj3FqUWV(1470440286 ^ 1470443300)))
            {
              if (!MetadataImportHelper.ApapVyEyP3LmxV9sDU5W((object) tableName))
              {
                num1 = 4;
                continue;
              }
              num2 = MetadataImportHelper.yV5VfdEyxKnJlfq2vb1S(MetadataImportHelper.wdxxmBEy7wiZcu1mKmfl((object) Locator.GetServiceNotNull<ITransformationProvider>()));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 4 : 7;
              continue;
            }
            num1 = 3;
            continue;
          case 2:
            goto label_35;
          case 3:
            goto label_18;
          case 4:
            goto label_23;
          case 5:
            goto label_27;
          case 6:
            goto label_2;
          case 7:
            if (tableName.Length > num2)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 2;
              continue;
            }
            enumerator = MetadataServiceContext.Service.GetMetadataList().OfType<EntityMetadata>().GetEnumerator();
            num1 = 6;
            continue;
          case 8:
            obj = MetadataImportHelper.Td76TmEy4D9fbDElmmiZ((object) messageAdditionalInfo, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787275725));
            break;
          case 9:
            if (!string.IsNullOrWhiteSpace(messageAdditionalInfo))
            {
              num1 = 8;
              continue;
            }
            obj = (object) "";
            break;
          default:
            goto label_30;
        }
        str = (string) obj;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 1;
      }
label_2:
      TestImportMessages testImportMessages1;
      try
      {
label_9:
        if (MetadataImportHelper.kEmFYtEy0rQ2v31HI1ZU((object) enumerator))
          goto label_7;
        else
          goto label_10;
label_3:
        TestImportMessages testImportMessages2;
        EntityMetadata current;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              testImportMessages2 = MetadataImportHelper.ValidateRelationTableNameForMd(ownerUid, (object) tableName, (object) current, uid, messageAdditionalInfo);
              num3 = 5;
              continue;
            case 2:
              goto label_30;
            case 3:
              goto label_31;
            case 4:
              testImportMessages1 = testImportMessages2;
              num3 = 3;
              continue;
            case 5:
              if (testImportMessages2 != null)
              {
                num3 = 4;
                continue;
              }
              goto label_9;
            case 6:
              goto label_7;
            default:
              goto label_9;
          }
        }
label_7:
        current = enumerator.Current;
        num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
        {
          num3 = 1;
          goto label_3;
        }
        else
          goto label_3;
label_10:
        num3 = 2;
        goto label_3;
      }
      finally
      {
        int num4;
        if (enumerator == null)
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 1;
        else
          goto label_15;
label_14:
        switch (num4)
        {
          case 1:
          case 2:
        }
label_15:
        MetadataImportHelper.P4CWWAEympblS5thpmGf((object) enumerator);
        num4 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
        {
          num4 = 1;
          goto label_14;
        }
        else
          goto label_14;
      }
label_31:
      return testImportMessages1;
label_18:
      return new TestImportMessages(TestImportMessagesType.Error, str + EleWise.ELMA.SR.T((string) MetadataImportHelper.jgyh0PEy1XR7gj3FqUWV(-812025778 ^ -811742550), (object) tableName, MetadataImportHelper.iYkomWEyHtAk2crgG1XY(MetadataImportHelper.jgyh0PEy1XR7gj3FqUWV(323422137 << 2 ^ 1293462920))));
label_23:
      return new TestImportMessages(TestImportMessagesType.Error, (string) MetadataImportHelper.Td76TmEy4D9fbDElmmiZ((object) str, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138235109), (object) tableName, MetadataImportHelper.iYkomWEyHtAk2crgG1XY(MetadataImportHelper.jgyh0PEy1XR7gj3FqUWV(~-306453669 ^ 306229112)))));
label_27:
      return new TestImportMessages(TestImportMessagesType.Error, (string) MetadataImportHelper.Td76TmEy4D9fbDElmmiZ((object) str, (object) EleWise.ELMA.SR.T((string) MetadataImportHelper.jgyh0PEy1XR7gj3FqUWV(-1978478350 ^ -1978244586), (object) tableName, MetadataImportHelper.iYkomWEyHtAk2crgG1XY(MetadataImportHelper.jgyh0PEy1XR7gj3FqUWV(-867826612 ^ -868042908)))));
label_30:
      return (TestImportMessages) null;
label_35:
      return new TestImportMessages(TestImportMessagesType.Error, (string) MetadataImportHelper.Td76TmEy4D9fbDElmmiZ((object) str, (object) EleWise.ELMA.SR.T((string) MetadataImportHelper.jgyh0PEy1XR7gj3FqUWV(333888594 ^ 1075625116 ^ 1409200682), (object) tableName, (object) EleWise.ELMA.SR.T((string) MetadataImportHelper.jgyh0PEy1XR7gj3FqUWV(1514961705 ^ 1514721269), (object) num2))));
    }

    private static TestImportMessages ValidateRelationTableNameForMd(
      Guid ownerUid,
      object tableName,
      object m,
      Guid uid = default (Guid),
      string messageAdditionalInfo = null)
    {
      int num1 = 9;
      TestImportMessages testImportMessages1;
      List<TablePartMetadata>.Enumerator enumerator1;
      string str;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          List<PropertyMetadata>.Enumerator enumerator2;
          Guid guid1;
          switch (num2)
          {
            case 1:
              goto label_36;
            case 2:
              if (MetadataImportHelper.kXJcsIEy9KUR81t9c3yP(MetadataImportHelper.e8UtyrEyJMgs3P3rCwlc(m), tableName, StringComparison.CurrentCultureIgnoreCase))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 4;
                continue;
              }
              goto case 7;
            case 3:
            case 14:
              goto label_41;
            case 4:
              if (uid == Guid.Empty)
              {
                num2 = 14;
                continue;
              }
              goto case 10;
            case 5:
              guid1 = ((AbstractMetadata) m).Uid;
              break;
            case 6:
label_35:
              enumerator1 = ((EntityMetadata) m).TableParts.GetEnumerator();
              num2 = 12;
              continue;
            case 7:
label_42:
              enumerator2 = ((ClassMetadata) m).Properties.GetEnumerator();
              num2 = 13;
              continue;
            case 8:
              goto label_25;
            case 9:
              if (((EntityMetadata) m).Type == EntityMetadataType.InterfaceImplementation)
              {
                num2 = 8;
                continue;
              }
              if (!MetadataImportHelper.T8AooyEyy690hqDxRI3k((object) messageAdditionalInfo))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
                continue;
              }
              goto label_57;
            case 10:
              if (!(MetadataImportHelper.IyYeWTEyd338qTIyidUk(m) != uid))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 7 : 0;
                continue;
              }
              goto label_41;
            case 11:
              if (!(m is TablePartMetadata))
              {
                num2 = 5;
                continue;
              }
              guid1 = MetadataImportHelper.GOm7ykEya66GGNQudyGE((object) (TablePartMetadata) m);
              break;
            case 12:
              goto label_43;
            case 13:
              try
              {
label_13:
                if (enumerator2.MoveNext())
                  goto label_15;
                else
                  goto label_14;
label_10:
                PropertyMetadata current;
                TestImportMessages testImportMessages2;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_37;
                    case 2:
                      goto label_13;
                    case 3:
                      if (testImportMessages2 != null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
                        continue;
                      }
                      goto label_13;
                    case 4:
                      goto label_15;
                    case 5:
                      goto label_35;
                    case 6:
                      testImportMessages2 = (TestImportMessages) MetadataImportHelper.BlV9LREyl62uYSMYkxPq(ownerUid, tableName, (object) current);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 3;
                      continue;
                    default:
                      testImportMessages1 = testImportMessages2;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 1;
                      continue;
                  }
                }
label_14:
                num3 = 5;
                goto label_10;
label_15:
                current = enumerator2.Current;
                num3 = 6;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0)
                {
                  num3 = 0;
                  goto label_10;
                }
                else
                  goto label_10;
              }
              finally
              {
                enumerator2.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 15:
              if (MetadataImportHelper.HZtra3Eyp8v2JenA8gET(m) != EntityMetadataType.Entity)
              {
                num2 = 16;
                continue;
              }
              goto case 2;
            case 16:
              if (MetadataImportHelper.HZtra3Eyp8v2JenA8gET(m) == EntityMetadataType.Interface)
              {
                num2 = 2;
                continue;
              }
              goto case 7;
            case 17:
              if (MetadataImportHelper.e8UtyrEyJMgs3P3rCwlc(m) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 2 : 15;
                continue;
              }
              goto case 7;
            default:
              goto label_32;
          }
          Guid guid2 = ownerUid;
          if (MetadataImportHelper.LIZkmVEyMqSLO9DMXIxu(guid1, guid2))
            num2 = 17;
          else
            goto label_42;
        }
label_32:
        object obj = MetadataImportHelper.Td76TmEy4D9fbDElmmiZ((object) messageAdditionalInfo, MetadataImportHelper.jgyh0PEy1XR7gj3FqUWV(1218962250 ^ 1218752028));
        goto label_58;
label_57:
        obj = (object) "";
label_58:
        str = (string) obj;
        num1 = 11;
      }
label_25:
      return (TestImportMessages) null;
label_36:
      return (TestImportMessages) null;
label_37:
      return testImportMessages1;
label_41:
      return new TestImportMessages(TestImportMessagesType.Error, (string) MetadataImportHelper.Td76TmEy4D9fbDElmmiZ((object) str, (object) EleWise.ELMA.SR.T((string) MetadataImportHelper.jgyh0PEy1XR7gj3FqUWV(381945751 ^ 1158627804 ^ 1406137201), tableName, (object) ((NamedMetadata) m).DisplayName)));
label_43:
      try
      {
label_50:
        if (enumerator1.MoveNext())
          goto label_46;
        else
          goto label_51;
label_44:
        TestImportMessages testImportMessages3;
        TablePartMetadata current;
        int num5;
        while (true)
        {
          switch (num5)
          {
            case 1:
              goto label_46;
            case 2:
              if (testImportMessages3 == null)
              {
                num5 = 7;
                continue;
              }
              goto case 3;
            case 3:
              testImportMessages1 = testImportMessages3;
              num5 = 4;
              continue;
            case 4:
              goto label_37;
            case 5:
              goto label_36;
            case 6:
            case 7:
              goto label_50;
            default:
              testImportMessages3 = MetadataImportHelper.ValidateRelationTableNameForMd(ownerUid, tableName, (object) current, uid, messageAdditionalInfo);
              num5 = 2;
              continue;
          }
        }
label_46:
        current = enumerator1.Current;
        num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
        {
          num5 = 0;
          goto label_44;
        }
        else
          goto label_44;
label_51:
        num5 = 5;
        goto label_44;
      }
      finally
      {
        enumerator1.Dispose();
        int num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
          num6 = 0;
        switch (num6)
        {
          default:
        }
      }
    }

    private static TestImportMessages ValidateRelationTableName(
      Guid ownerUid,
      object tableName,
      object pm)
    {
      int num = 7;
      EntitySettings entitySettings;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (MetadataImportHelper.p8hxy5Ey5HsLifPDhL8Z((object) entitySettings) != null)
            {
              num = 2;
              continue;
            }
            goto label_9;
          case 2:
            if (!MetadataImportHelper.kXJcsIEy9KUR81t9c3yP(MetadataImportHelper.p8hxy5Ey5HsLifPDhL8Z((object) entitySettings), tableName, StringComparison.CurrentCultureIgnoreCase))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 3 : 4;
              continue;
            }
            goto label_8;
          case 3:
            if (entitySettings != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
              continue;
            }
            goto label_9;
          case 4:
            goto label_9;
          case 5:
            goto label_8;
          case 6:
            goto label_10;
          case 7:
            if (MetadataImportHelper.YhC6KSEyraWvue7dX7nj(ownerUid, MetadataImportHelper.IyYeWTEyd338qTIyidUk(pm)))
            {
              num = 6;
              continue;
            }
            entitySettings = MetadataImportHelper.vyTd0IEygts4trlgPWVg(pm) as EntitySettings;
            num = 3;
            continue;
          default:
            if (entitySettings.RelationType == RelationType.ManyToMany)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 1 : 0;
              continue;
            }
            goto label_9;
        }
      }
label_8:
      return new TestImportMessages(TestImportMessagesType.InfoMetadata, EleWise.ELMA.SR.T((string) MetadataImportHelper.jgyh0PEy1XR7gj3FqUWV(654297945 ^ 654016205), tableName));
label_9:
      return (TestImportMessages) null;
label_10:
      return (TestImportMessages) null;
    }

    /// <summary>
    /// Проверить, можно ли задать данное отображаемое имя для свойства
    /// </summary>
    /// <param name="propertyMetadata">Метаданные свойства или блока</param>
    /// <param name="name">Отображаемое имя свойства</param>
    /// <param name="message">Сообщение об ошибке</param>
    /// <returns>True, если имя корректно</returns>
    public static bool CheckPropertyDisplayName(
      List<IMetadata> allProperties,
      IMetadata propertyMetadata,
      string name,
      out string message)
    {
      message = (string) null;
      if (allProperties == null)
        return true;
      IPropertyMetadata propertyMetadata1 = allProperties.OfType<IPropertyMetadata>().FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (p =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              if (MetadataImportHelper.\u003C\u003Ec__DisplayClass14_0.dNc06M8tQm7QRWVjU95R((object) p.DisplayName, (object) name, StringComparison.CurrentCultureIgnoreCase))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
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
        // ISSUE: reference to a compiler-generated method
        return MetadataImportHelper.\u003C\u003Ec__DisplayClass14_0.osGWuj8tv8KJFl7rVL1S(MetadataImportHelper.\u003C\u003Ec__DisplayClass14_0.zVwfsg8tCIjubN1nBUeO((object) p), MetadataImportHelper.\u003C\u003Ec__DisplayClass14_0.zVwfsg8tCIjubN1nBUeO((object) (IPropertyMetadata) propertyMetadata));
label_3:
        return false;
      }));
      if (propertyMetadata1 == null)
        return true;
      message = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29021317), (object) propertyMetadata1.Name, (object) propertyMetadata1.Uid, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477373468)));
      return false;
    }

    /// <summary>Проверить, можно ли задать данное имя для свойства</summary>
    /// <param name="propertyMetadata">Метаданные свойства или блока</param>
    /// <param name="name">Имя свойства</param>
    /// <param name="message">Сообщение об ошибке</param>
    /// <returns>True, если имя корректно</returns>
    public static bool CheckPropertyName(
      List<IMetadata> allProperties,
      IMetadata propertyMetadata,
      string mdName,
      string name,
      out string message)
    {
      message = (string) null;
      if (string.IsNullOrEmpty(name) || name.Trim().Equals(string.Empty))
      {
        message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239862562));
        return false;
      }
      if (allProperties == null)
        return true;
      if (name.Equals(mdName, StringComparison.CurrentCultureIgnoreCase))
      {
        message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516613584));
        return false;
      }
      IPropertyMetadata propertyMetadata1 = allProperties.OfType<IPropertyMetadata>().FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (p =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              if (!MetadataImportHelper.\u003C\u003Ec__DisplayClass15_0.oam5e88tVNE3qPJHppZl((object) p.Name, (object) name, StringComparison.CurrentCultureIgnoreCase))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_4;
            default:
              goto label_5;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return MetadataImportHelper.\u003C\u003Ec__DisplayClass15_0.l8EGqB8tiol4BkqaNMWN(MetadataImportHelper.\u003C\u003Ec__DisplayClass15_0.FGvlhT8tSZ20WJ7uW1WP((object) p), MetadataImportHelper.\u003C\u003Ec__DisplayClass15_0.FGvlhT8tSZ20WJ7uW1WP((object) (IPropertyMetadata) propertyMetadata));
label_5:
        return false;
      }));
      if (propertyMetadata1 != null)
      {
        message = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470207302), (object) propertyMetadata1.Name, (object) propertyMetadata1.Uid, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178515580)));
        return false;
      }
      if (!name.IsValidIdentifier())
      {
        message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 396983112));
        return false;
      }
      if (!CSharpHelper.IsKeyword(name))
        return true;
      message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957580590));
      return false;
    }

    /// <summary>
    /// Проверить, можно ли задать данное имя для поля в таблице сущности
    /// </summary>
    /// <param name="propertyMetadata">Метаданные свойства или блока</param>
    /// <param name="name">Имя свойства</param>
    /// <param name="message">Сообщение об ошибке</param>
    /// <returns>True, если имя корректно</returns>
    public static bool CheckPropertyFieldName(
      List<IMetadata> allProperties,
      IMetadata propertyMetadata,
      string name,
      out string message)
    {
      message = (string) null;
      if (string.IsNullOrEmpty(name) || name.Trim().Equals(string.Empty))
      {
        message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293461042));
        return false;
      }
      if (allProperties == null)
        return true;
      // ISSUE: reference to a compiler-generated method
      if (((IEnumerable<string>) MetadataImportHelper.GetFieldNames((IEnumerable<IMetadata>) allProperties, ((IPropertyMetadata) propertyMetadata).PropertyUid)).Any<string>((Func<string, bool>) (n => MetadataImportHelper.\u003C\u003Ec__DisplayClass16_0.adBt1c8tTWaeU9YJYvd3((object) n, (object) name, StringComparison.CurrentCultureIgnoreCase))))
      {
        message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757350974), (object) name);
        return false;
      }
      if (name.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874009135)))
      {
        message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234068406));
        return false;
      }
      if (!name.IsValidIdentifier())
      {
        message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909396645));
        return false;
      }
      if (!name.Equals(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-122002947 ^ 121970524), StringComparison.CurrentCultureIgnoreCase))
        return true;
      message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77979313), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516799340));
      return false;
    }

    /// <summary>
    /// Проверить, можно ли задать данное имя для поля в таблице (для таблицы связей)
    /// </summary>
    /// <param name="name">Имя поля</param>
    /// <returns>True, если имя корректно</returns>
    public static TestImportMessages ValidateFieldName(string name)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 4:
            goto label_5;
          case 2:
            if (string.IsNullOrEmpty(name))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 1 : 0;
              continue;
            }
            goto case 6;
          case 3:
            goto label_10;
          case 5:
            goto label_2;
          case 6:
            if (!MetadataImportHelper.YMXRFkEyjSRmaChaVYhL((object) name.Trim(), (object) string.Empty))
            {
              if (!name.StartsWith((string) MetadataImportHelper.jgyh0PEy1XR7gj3FqUWV(-53329496 >> 4 ^ -3332000)))
              {
                if (name.IsValidIdentifier())
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
                  continue;
                }
                goto label_10;
              }
              else
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 5 : 5;
                continue;
              }
            }
            else
            {
              num = 4;
              continue;
            }
          default:
            goto label_11;
        }
      }
label_2:
      return new TestImportMessages(TestImportMessagesType.Error, (string) MetadataImportHelper.iYkomWEyHtAk2crgG1XY(MetadataImportHelper.jgyh0PEy1XR7gj3FqUWV(-1088304168 ^ -1088064894)));
label_5:
      return new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 132689385)));
label_10:
      return new TestImportMessages(TestImportMessagesType.Error, (string) MetadataImportHelper.iYkomWEyHtAk2crgG1XY(MetadataImportHelper.jgyh0PEy1XR7gj3FqUWV(-1824388195 ^ -1824083367)));
label_11:
      return (TestImportMessages) null;
    }

    private static string[] GetFieldNames(IEnumerable<IMetadata> properties, Guid ignorePropertyUid) => properties.OfType<PropertyMetadata>().Where<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => MetadataImportHelper.\u003C\u003Ec__DisplayClass18_0.BaoPRR8tPvJScPY3S5UL(MetadataImportHelper.\u003C\u003Ec__DisplayClass18_0.UgxPiA8teFAQCf5oDCVC((object) p), ignorePropertyUid))).Select<PropertyMetadata, TypeSettings>((Func<PropertyMetadata, TypeSettings>) (p => (TypeSettings) MetadataImportHelper.\u003C\u003Ec.YRcUcK8DLyeyHYlOQ86q((object) p))).OfType<SimpleTypeSettings>().Select<SimpleTypeSettings, string[]>((Func<SimpleTypeSettings, string[]>) (s => (string[]) MetadataImportHelper.\u003C\u003Ec.JDmeIw8DUw6gkT8N0rXg((object) s))).Where<string[]>((Func<string[], bool>) (fn => fn != null)).SelectMany<string[], string>((Func<string[], IEnumerable<string>>) (fn => (IEnumerable<string>) fn)).ToArray<string>();

    /// <summary>
    /// Проверить, можно ли задать данное отображаемое имя для значения перечисления
    /// </summary>
    /// <param name="valueMetadata">Метаданные значения перечисления</param>
    /// <param name="name">Отображаемое имя значения</param>
    /// <returns>True, если имя корректно</returns>
    public static string CheckEnumValueDisplayName(
      EnumValueMetadata valueMetadata,
      string name,
      List<EnumValueMetadata> allValues)
    {
      return allValues.FirstOrDefault<EnumValueMetadata>((Func<EnumValueMetadata, bool>) (p =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (!MetadataImportHelper.\u003C\u003Ec__DisplayClass19_0.fUPYkN8tDdksZqNSwDGS(MetadataImportHelper.\u003C\u003Ec__DisplayClass19_0.nNjCC08taT98eFmqgNL4((object) p), (object) name, StringComparison.CurrentCultureIgnoreCase))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_4;
            default:
              goto label_5;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return MetadataImportHelper.\u003C\u003Ec__DisplayClass19_0.t67m2g8twt5OPpKeXhP4(MetadataImportHelper.\u003C\u003Ec__DisplayClass19_0.YKOHUm8tt41eq2BcIKgM((object) p), MetadataImportHelper.\u003C\u003Ec__DisplayClass19_0.YKOHUm8tt41eq2BcIKgM((object) valueMetadata));
label_5:
        return false;
      })) != null ? EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124350066)) : (string) null;
    }

    /// <summary>
    /// Проверить, можно ли задать данное имя для значения перечисления
    /// </summary>
    /// <param name="valueMetadata">Метаданные значения перечисления</param>
    /// <param name="name">Имя значения</param>
    /// <returns>True, если имя корректно</returns>
    public static string CheckEnumValueName(
      EnumValueMetadata valueMetadata,
      string name,
      List<EnumValueMetadata> allValues)
    {
      if (allValues.OfType<NamedMetadata>().FirstOrDefault<NamedMetadata>((Func<NamedMetadata, bool>) (p =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (MetadataImportHelper.\u003C\u003Ec__DisplayClass20_0.qWXe6a8txO2X18ZP8Vi8(MetadataImportHelper.\u003C\u003Ec__DisplayClass20_0.rx0sKF8t768MCxHlylLn((object) p), (object) name, StringComparison.CurrentCultureIgnoreCase))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
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
        return MetadataImportHelper.\u003C\u003Ec__DisplayClass20_0.og027K8tm6JBlE3QGgF3(MetadataImportHelper.\u003C\u003Ec__DisplayClass20_0.hZa4ok8t00ObgYdMPMOs((object) p), valueMetadata.Uid);
label_5:
        return false;
      })) != null)
        return EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470208418));
      if (!name.IsValidIdentifier())
        return EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1642641396));
      return CSharpHelper.IsKeyword(name) ? EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475642773)) : (string) null;
    }

    /// <summary>Проверить, целочисленное значение</summary>
    /// <param name="valueMetadata">Метаданные значения перечисления</param>
    /// <param name="intValue">Целочисленное значение</param>
    /// <returns>True, если значение корректно</returns>
    public static string CheckEnumIntValue(
      EnumValueMetadata valueMetadata,
      int? intValue,
      List<EnumValueMetadata> allValues)
    {
      string str = (string) null;
      if (!intValue.HasValue)
        return str;
      return allValues.FirstOrDefault<EnumValueMetadata>((Func<EnumValueMetadata, bool>) (p =>
      {
        int num = 2;
        int? intValue1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (intValue1.HasValue)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 1 : 3;
                continue;
              }
              goto label_9;
            case 2:
              intValue1 = p.IntValue;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 1;
              continue;
            case 3:
              intValue1 = p.IntValue;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 4;
              continue;
            case 4:
              if (intValue1.Value == intValue.Value)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
                continue;
              }
              goto label_9;
            default:
              goto label_8;
          }
        }
label_8:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return MetadataImportHelper.\u003C\u003Ec__DisplayClass21_0.IXVguT8tdOv9onYXve6r(MetadataImportHelper.\u003C\u003Ec__DisplayClass21_0.Xs6Zdr8t90r1d4VCCCCi((object) p), MetadataImportHelper.\u003C\u003Ec__DisplayClass21_0.Xs6Zdr8t90r1d4VCCCCi((object) valueMetadata));
label_9:
        return false;
      })) != null ? EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487078360)) : (string) null;
    }

    internal static bool XRkrLSEy2qfJLREGCI0B([In] object obj0) => ((IMetadata) obj0).IsSystem();

    internal static bool IDvr2BEyeY7516cnNhlA([In] object obj0) => ((IMetadata) obj0).IsConfig();

    internal static bool FLVHwsEynHRDoTRI97e4() => MetadataImportHelper.ILhJuvEykNKYmlqIYu2d == null;

    internal static MetadataImportHelper PPoZx3EyON5B3hb50Iqm() => MetadataImportHelper.ILhJuvEykNKYmlqIYu2d;

    internal static bool ApapVyEyP3LmxV9sDU5W([In] object obj0) => ((string) obj0).IsValidIdentifier();

    internal static object jgyh0PEy1XR7gj3FqUWV(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool jK9OTtEyNDaCFAyR8mVR([In] object obj0) => CSharpHelper.IsKeyword((string) obj0);

    internal static object SsJUppEy3PnZ6h2mMab2() => (object) MetadataServiceContext.Service;

    internal static EntityMetadataType HZtra3Eyp8v2JenA8gET([In] object obj0) => ((EntityMetadata) obj0).Type;

    internal static Guid GOm7ykEya66GGNQudyGE([In] object obj0) => ((TablePartMetadata) obj0).TablePartPropertyUid;

    internal static object t4oYKSEyDXEhmVqo2RQt([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static int js7CQUEytgX4utoivcHE([In] object obj0) => ((string) obj0).Length;

    internal static object PPxEimEywpOTRbu4HjTt([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static object Td76TmEy4D9fbDElmmiZ([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static bool T3rjTWEy6gd9DkVBVCYe([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object iYkomWEyHtAk2crgG1XY([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool xqo1qPEyAOxmC4E7GLum([In] object obj0, [In] object obj1) => ((string) obj0).StartsWith((string) obj1);

    internal static object wdxxmBEy7wiZcu1mKmfl([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static int yV5VfdEyxKnJlfq2vb1S([In] object obj0) => ((Dialect) obj0).MaxTableNameLength;

    internal static bool kEmFYtEy0rQ2v31HI1ZU([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void P4CWWAEympblS5thpmGf([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool T8AooyEyy690hqDxRI3k([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static bool LIZkmVEyMqSLO9DMXIxu([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object e8UtyrEyJMgs3P3rCwlc([In] object obj0) => (object) ((EntityMetadata) obj0).TableName;

    internal static bool kXJcsIEy9KUR81t9c3yP([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).Equals((string) obj1, obj2);

    internal static Guid IyYeWTEyd338qTIyidUk([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object BlV9LREyl62uYSMYkxPq(Guid ownerUid, [In] object obj1, [In] object obj2) => (object) MetadataImportHelper.ValidateRelationTableName(ownerUid, obj1, obj2);

    internal static bool YhC6KSEyraWvue7dX7nj([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object vyTd0IEygts4trlgPWVg([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static object p8hxy5Ey5HsLifPDhL8Z([In] object obj0) => (object) ((EntitySettings) obj0).RelationTableName;

    internal static bool YMXRFkEyjSRmaChaVYhL([In] object obj0, [In] object obj1) => ((string) obj0).Equals((string) obj1);
  }
}
