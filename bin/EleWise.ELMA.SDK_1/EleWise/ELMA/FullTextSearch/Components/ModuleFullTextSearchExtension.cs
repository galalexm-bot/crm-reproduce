// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Components.ModuleFullTextSearchExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.Enum;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.FullTextSearch.Services;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.FullTextSearch.Components
{
  /// <summary>
  /// Точка расширения для реализации настроек и обработки полнотекстового поиска по модулям
  /// </summary>
  [Component]
  public abstract class ModuleFullTextSearchExtension : 
    IFullTextSearchFieldsMappingsReIndexingExtension,
    IFullTextSearchFieldsMappingsExtension,
    IModuleFullTextSearchExtension
  {
    private IFullTextSearchDescriptorMappingService fullTextSearchDescriptorService;
    /// <summary>
    /// Количество запрашиваемых из базы сущностей при полной переиндексации типа (значение по умолчанию)
    /// </summary>
    protected const int PageSize = 10;
    internal static ModuleFullTextSearchExtension JWBgQJGV1FbfMgqASqVi;

    private IFullTextSearchDescriptorMappingService FullTextSearchDescriptorService
    {
      get
      {
        int num = 1;
        IFullTextSearchDescriptorMappingService serviceNotNull;
        IFullTextSearchDescriptorMappingService descriptorService;
        while (true)
        {
          switch (num)
          {
            case 1:
              descriptorService = this.fullTextSearchDescriptorService;
              if (descriptorService == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.fullTextSearchDescriptorService = serviceNotNull = Locator.GetServiceNotNull<IFullTextSearchDescriptorMappingService>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 2;
              continue;
          }
        }
label_2:
        return descriptorService;
label_6:
        return serviceNotNull;
      }
    }

    /// <summary>
    /// Получить количество запрашиваемых из базы сущностей при полной переиндексации типа
    /// </summary>
    public int GetPageSize()
    {
      int num = 4;
      int setting;
      while (true)
      {
        switch (num)
        {
          case 2:
            goto label_6;
          case 3:
            if (setting <= 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 1;
              continue;
            }
            goto case 5;
          case 4:
            setting = EleWise.ELMA.SR.GetSetting<int>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121111117), 10);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 3 : 1;
            continue;
          case 5:
            if (setting >= 10000)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          default:
            goto label_7;
        }
      }
label_6:
      return setting;
label_7:
      return 10;
    }

    /// <inheritdoc />
    public virtual List<KeyValuePair<Type, Guid>> GetSupportedCardTypes(bool checkSettings = true) => new List<KeyValuePair<Type, Guid>>();

    /// <inheritdoc />
    public virtual Type GetSupportedCardType(Guid cardUid) => (Type) null;

    /// <inheritdoc />
    public virtual Guid? GetSupportedCardType(Type cardType) => new Guid?();

    /// <inheritdoc />
    public virtual Type GetSupportedCardTypeByTypeUid(Guid objectTypeUid) => (Type) null;

    /// <inheritdoc />
    public virtual Type GetSupportedCardTypeByObject(object obj) => (Type) null;

    /// <inheritdoc />
    public virtual FieldIndexList MappingFields(Type cardType) => new FieldIndexList();

    /// <inheritdoc />
    public virtual FieldIndexList MappingFields(Guid uid)
    {
      int num = 1;
      ClassMetadata classMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            classMetadata = MetadataLoader.LoadMetadata(uid) as ClassMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (FieldIndexList) ModuleFullTextSearchExtension.sWcU1QGVpKTEdiur42dK((object) this, (object) classMetadata);
    }

    /// <inheritdoc />
    public virtual FieldIndexList MappingFields(ClassMetadata metadata)
    {
      int num1 = 4;
      FieldIndexList fieldIndexList;
      List<Guid> guidList;
      List<ClassMetadata>.Enumerator enumerator1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_35;
          case 2:
            goto label_36;
          case 3:
            List<ClassMetadata> childClasses = MetadataLoader.GetChildClasses(metadata);
            childClasses.Add(metadata);
            guidList = new List<Guid>();
            fieldIndexList = new FieldIndexList();
            enumerator1 = childClasses.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
            continue;
          case 4:
            if (metadata != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 3 : 3;
              continue;
            }
            goto label_36;
          default:
            goto label_4;
        }
      }
label_4:
      try
      {
label_27:
        if (enumerator1.MoveNext())
          goto label_30;
        else
          goto label_28;
label_6:
        List<IPropertyMetadata>.Enumerator enumerator2;
        ClassMetadata current1;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_27;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 3 : 3;
              continue;
            case 3:
              List<IPropertyMetadata> propertyMetadataList = new List<IPropertyMetadata>();
              List<PropertyMetadata> baseProperties = MetadataLoader.GetBaseProperties(current1);
              propertyMetadataList.AddRange((IEnumerable<IPropertyMetadata>) baseProperties);
              propertyMetadataList.AddRange((IEnumerable<IPropertyMetadata>) current1.Properties.Where<PropertyMetadata>((Func<PropertyMetadata, bool>) (p =>
              {
                int num3 = 2;
                PropertyMetadata p1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      p1 = p;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
                      continue;
                    case 2:
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 1 : 1;
                      continue;
                    default:
                      goto label_3;
                  }
                }
label_3:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                return baseProperties.All<PropertyMetadata>((Func<PropertyMetadata, bool>) (bp => ModuleFullTextSearchExtension.\u003C\u003Ec__DisplayClass12_1.CnUC3GvY6Xfi650GHTXZ(ModuleFullTextSearchExtension.\u003C\u003Ec__DisplayClass12_1.yyFptqvY4ViFpl9QgEpO((object) bp), p1.Uid)));
              })));
              enumerator2 = propertyMetadataList.GetEnumerator();
              num2 = 4;
              continue;
            case 4:
              goto label_7;
            case 5:
              goto label_30;
            default:
              goto label_35;
          }
        }
label_7:
        try
        {
label_12:
          if (enumerator2.MoveNext())
            goto label_21;
          else
            goto label_13;
label_8:
          int num4;
          int num5 = num4;
label_9:
          FieldIndexList mappingField;
          IPropertyMetadata current2;
          while (true)
          {
            switch (num5)
            {
              case 1:
                if (ModuleFullTextSearchExtension.N7IuL8GVDRts2Ov4NhvQ((object) this.FullTextSearchDescriptorService, (object) current2))
                  break;
                goto label_18;
              case 2:
                if (!guidList.Contains(ModuleFullTextSearchExtension.qDYaXFGVad9d4rZUM1bq((object) current2)))
                {
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 1;
                  continue;
                }
                goto label_12;
              case 3:
                goto label_27;
              case 4:
                goto label_10;
              case 5:
              case 9:
                guidList.Add(ModuleFullTextSearchExtension.qDYaXFGVad9d4rZUM1bq((object) current2));
                num5 = 7;
                continue;
              case 6:
                if (mappingField != null)
                {
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 4 : 2;
                  continue;
                }
                goto case 5;
              case 7:
                goto label_12;
              case 8:
                goto label_21;
            }
            mappingField = this.FullTextSearchDescriptorService.GetMappingField(current2);
            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 6;
          }
label_10:
          fieldIndexList.AddRange((IEnumerable<FieldIndexListItem>) mappingField);
          num4 = 5;
          goto label_8;
label_18:
          num4 = 9;
          goto label_8;
label_13:
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 3 : 2;
          goto label_9;
label_21:
          current2 = enumerator2.Current;
          num4 = 2;
          goto label_8;
        }
        finally
        {
          enumerator2.Dispose();
          int num6 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0)
            num6 = 0;
          switch (num6)
          {
            default:
          }
        }
label_28:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
        goto label_6;
label_30:
        current1 = enumerator1.Current;
        num2 = 2;
        goto label_6;
      }
      finally
      {
        enumerator1.Dispose();
        int num7 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0)
          num7 = 0;
        switch (num7)
        {
          default:
        }
      }
label_35:
      return fieldIndexList;
label_36:
      return new FieldIndexList();
    }

    /// <summary>Обработка динамических свойств</summary>
    /// <param name="entity">Сущность</param>
    /// <param name="objF">Обертка объекта индексации</param>
    protected virtual void ProcessingDynamicProperties(
      IEntity entity,
      IFullTextSearchObjectContainer objF)
    {
      int num1 = 3;
      ClassMetadata classMetadata;
      List<PropertyMetadata>.Enumerator enumerator1;
      IDictionary<string, object> dictionary;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_41;
          case 2:
            if (classMetadata != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
              continue;
            }
            goto label_37;
          case 3:
            classMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(entity.GetType());
            num1 = 2;
            continue;
          case 4:
            goto label_6;
          case 5:
            enumerator1 = classMetadata.Properties.GetEnumerator();
            num1 = 4;
            continue;
          case 6:
            dictionary = (IDictionary<string, object>) ModuleFullTextSearchExtension.TsNiKRGVwa7fyJgkAsDd((object) objF);
            num1 = 5;
            continue;
          default:
            ModuleFullTextSearchExtension.VR9YIMGVttuIypmmn0A5((object) objF, (object) new ExpandoObject());
            num1 = 6;
            continue;
        }
      }
label_41:
      return;
label_6:
      try
      {
label_9:
        if (enumerator1.MoveNext())
          goto label_21;
        else
          goto label_10;
label_7:
        IFullTextSearchDescriptorService serviceNotNull;
        PropertyMetadata current1;
        PropertyInfo propertyCached;
        FieldIndexList indexField;
        IEnumerator<FieldIndexListItem> enumerator2;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 3:
              if (!ModuleFullTextSearchExtension.EdepqIGV4AHt3tIaI5Gt((object) propertyCached))
              {
                num2 = 2;
                continue;
              }
              goto case 10;
            case 4:
              if (indexField == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
                continue;
              }
              goto case 13;
            case 5:
              goto label_22;
            case 6:
              goto label_21;
            case 7:
              if (propertyCached != (PropertyInfo) null)
              {
                num2 = 3;
                continue;
              }
              goto label_9;
            case 8:
              propertyCached = entity.GetType().GetPropertyCached(current1.Name);
              num2 = 7;
              continue;
            case 9:
              serviceNotNull = Locator.GetServiceNotNull<IFullTextSearchDescriptorService>();
              num2 = 14;
              continue;
            case 10:
              indexField = serviceNotNull.GetIndexField(ModuleFullTextSearchExtension.R6xfpYGV6quBgQXOOItm((object) propertyCached, (object) entity, (object) null), (IPropertyMetadata) current1, false);
              num2 = 4;
              continue;
            case 12:
              goto label_33;
            case 13:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              enumerator2 = indexField.Where<FieldIndexListItem>((Func<FieldIndexListItem, bool>) (f => !ModuleFullTextSearchExtension.\u003C\u003Ec.L7cm7cvYmDlQDawpQc9i(ModuleFullTextSearchExtension.\u003C\u003Ec.UH0LZNvY0CgP20ckvQcP((object) f)))).GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 2 : 5;
              continue;
            case 14:
              if (!ModuleFullTextSearchExtension.N7IuL8GVDRts2Ov4NhvQ((object) serviceNotNull, (object) current1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 1 : 0;
                continue;
              }
              goto case 8;
            default:
              goto label_9;
          }
        }
label_33:
        return;
label_22:
        try
        {
label_24:
          if (ModuleFullTextSearchExtension.uBhgmNGV7nZEbaXkFfg4((object) enumerator2))
            goto label_27;
          else
            goto label_25;
label_23:
          FieldIndexListItem current2;
          int num3;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_27;
              case 2:
                dictionary[(string) ModuleFullTextSearchExtension.fWUVAQGVHcaZj9j0cWGL((object) current2)] = ModuleFullTextSearchExtension.dqj90nGVAm7CfwtRuYF9((object) current2);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
                continue;
              case 3:
                goto label_9;
              default:
                goto label_24;
            }
          }
label_25:
          num3 = 3;
          goto label_23;
label_27:
          current2 = enumerator2.Current;
          num3 = 2;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
          {
            num3 = 1;
            goto label_23;
          }
          else
            goto label_23;
        }
        finally
        {
          if (enumerator2 != null)
          {
            int num4 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
              num4 = 1;
            while (true)
            {
              switch (num4)
              {
                case 1:
                  ModuleFullTextSearchExtension.L87mgJGVxJL2IZK5w4qn((object) enumerator2);
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_35;
              }
            }
          }
label_35:;
        }
label_10:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 7 : 12;
        goto label_7;
label_21:
        current1 = enumerator1.Current;
        num2 = 9;
        goto label_7;
      }
      finally
      {
        enumerator1.Dispose();
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
          num5 = 0;
        switch (num5)
        {
          default:
        }
      }
label_37:;
    }

    /// <summary>Получения списка динамических полей для мэпинга</summary>
    /// <param name="classMd">Метаданные</param>
    protected virtual Dictionary<Guid, List<string>> ProcessingDynamicFieldsMapping(
      ClassMetadata classMd)
    {
      Dictionary<Guid, List<string>> dictionary = new Dictionary<Guid, List<string>>();
      foreach (KeyValuePair<Guid, List<IPropertyMetadata>> supportedDynamicField in this.SupportedDynamicFields(classMd))
      {
        if (!dictionary.ContainsKey(supportedDynamicField.Key))
        {
          // ISSUE: reference to a compiler-generated method
          dictionary.Add(supportedDynamicField.Key, supportedDynamicField.Value.Select<IPropertyMetadata, string>((Func<IPropertyMetadata, string>) (a => (string) ModuleFullTextSearchExtension.\u003C\u003Ec.vFTFSevYy6I4EU9OvWom((object) a))).ToList<string>());
        }
      }
      return dictionary;
    }

    /// <summary>Получение списка динамических полей для мэпинга</summary>
    /// <param name="classMd">Обрабатываемые метаданные</param>
    protected virtual Dictionary<Guid, List<IPropertyMetadata>> SupportedDynamicFields(
      ClassMetadata classMd)
    {
      List<ClassMetadata> list = MetadataLoader.GetChildClasses(classMd).Where<ClassMetadata>((Func<ClassMetadata, bool>) (c => c != null)).ToList<ClassMetadata>();
      list.Add(classMd);
      Dictionary<Guid, List<IPropertyMetadata>> dictionary = new Dictionary<Guid, List<IPropertyMetadata>>();
      foreach (ClassMetadata metadata in list)
      {
        if (!dictionary.ContainsKey(metadata.Uid))
        {
          List<IPropertyMetadata> propertyMetadataList1 = new List<IPropertyMetadata>();
          List<IPropertyMetadata> propertyMetadataList2 = new List<IPropertyMetadata>();
          List<PropertyMetadata> baseProperties = MetadataLoader.GetBaseProperties(metadata);
          propertyMetadataList2.AddRange((IEnumerable<IPropertyMetadata>) baseProperties);
          propertyMetadataList2.AddRange((IEnumerable<IPropertyMetadata>) metadata.Properties.Where<PropertyMetadata>((Func<PropertyMetadata, bool>) (p =>
          {
            int num = 2;
            PropertyMetadata p1;
            while (true)
            {
              switch (num)
              {
                case 1:
                  p1 = p;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
                  continue;
                case 2:
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 1;
                  continue;
                default:
                  goto label_2;
              }
            }
label_2:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            return baseProperties.All<PropertyMetadata>((Func<PropertyMetadata, bool>) (bp => ModuleFullTextSearchExtension.\u003C\u003Ec__DisplayClass15_1.Bvl9fOvY5soQ1geT6VL0(ModuleFullTextSearchExtension.\u003C\u003Ec__DisplayClass15_1.ge73NnvYgdVEAHZdTAhf((object) bp), ModuleFullTextSearchExtension.\u003C\u003Ec__DisplayClass15_1.ge73NnvYgdVEAHZdTAhf((object) p1))));
          })));
          foreach (IPropertyMetadata propertyMd in propertyMetadataList2)
          {
            if (this.FullTextSearchDescriptorService.IsSupportedIndexing(propertyMd))
              propertyMetadataList1.Add(propertyMd);
          }
          dictionary.Add(metadata.Uid, propertyMetadataList1);
        }
      }
      return dictionary;
    }

    /// <inheritdoc />
    public virtual Dictionary<Type, Dictionary<Guid, List<string>>> GetDynamicFieldsMapping() => (Dictionary<Type, Dictionary<Guid, List<string>>>) null;

    /// <inheritdoc />
    public virtual Dictionary<string, Weight> GetWeightSearchFields(Type cardType) => new Dictionary<string, Weight>();

    /// <inheritdoc />
    public virtual Dictionary<string, string> GetReverseMapping(Type cardType) => new Dictionary<string, string>();

    /// <inheritdoc />
    public virtual Dictionary<string, long> GetHighlightsOrder(Type cardType) => new Dictionary<string, long>();

    /// <inheritdoc />
    public abstract List<string> GetHighlightFields(Type cardType);

    /// <inheritdoc />
    public virtual List<string> GetFields(Type cardType)
    {
      List<string> fields = new List<string>();
      fields.Add(LinqUtils.NameOf<IFullTextSearchObject>((Expression<Func<IFullTextSearchObject, object>>) (textSearchObject => textSearchObject.TypeUid)));
      fields.Add(LinqUtils.NameOf<IFullTextSearchObject>((Expression<Func<IFullTextSearchObject, object>>) (textSearchObject => textSearchObject.Id)));
      return fields;
    }

    /// <inheritdoc />
    public virtual List<string> GetSearchFields(Type cardType) => new List<string>();

    /// <inheritdoc />
    public virtual List<string> GetSearchFields(Type cardType, IEntityFilter filter) => new List<string>();

    /// <inheritdoc />
    public virtual FilterList GetFilterFields(Type cardType, FullTextSearchResultModel searchModel) => new FilterList();

    /// <inheritdoc />
    public virtual FieldList GetCustomSearchFields(Type cardType, FilterProperty filterProperty) => (FieldList) null;

    /// <inheritdoc />
    public virtual FilterList GetCustomFilterFields(
      Type cardType,
      FilterProperty filterProperty,
      FullTextSearchResultModel searchModel)
    {
      int num1 = 49;
      while (true)
      {
        int num2 = num1;
        ParameterExpression parameterExpression;
        bool result1;
        bool result2;
        bool result3;
        bool result4;
        bool result5;
        bool result6;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_73;
            case 2:
              // ISSUE: method reference
              // ISSUE: type reference
              if (ModuleFullTextSearchExtension.mMM03IGVdrverdH9PS8y(ModuleFullTextSearchExtension.Fgfg5sGVJ3qdkYYTUunp((object) InterfaceActivator.LoadPropertyMetadata<IEntityFilter>(Expression.Lambda<Func<IEntityFilter, object>>((Expression) ModuleFullTextSearchExtension.k2dJvkGVriweX4Uga0Ym(ModuleFullTextSearchExtension.akBjZiGVMYAZU31yq5WU((object) parameterExpression, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IEntityFilter.get_SkipAdminPermission))), ModuleFullTextSearchExtension.j8MeypGV0lbcuV1krpTY(__typeref (object))), parameterExpression))), filterProperty.Uid))
              {
                num2 = 15;
                continue;
              }
              // ISSUE: type reference
              parameterExpression = (ParameterExpression) ModuleFullTextSearchExtension.L6PsSqGVmNNVX4OUVkSs(ModuleFullTextSearchExtension.j8MeypGV0lbcuV1krpTY(__typeref (IEntityFilter)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757007760));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 9 : 45;
              continue;
            case 3:
              goto label_82;
            case 4:
              // ISSUE: method reference
              // ISSUE: type reference
              if (ModuleFullTextSearchExtension.mMM03IGVdrverdH9PS8y(ModuleFullTextSearchExtension.Fgfg5sGVJ3qdkYYTUunp((object) InterfaceActivator.LoadPropertyMetadata<IEntityFilter>(Expression.Lambda<Func<IEntityFilter, object>>((Expression) ModuleFullTextSearchExtension.k2dJvkGVriweX4Uga0Ym(ModuleFullTextSearchExtension.akBjZiGVMYAZU31yq5WU((object) parameterExpression, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IEntityFilter.get_DisableSecurity))), ModuleFullTextSearchExtension.j8MeypGV0lbcuV1krpTY(__typeref (object))), parameterExpression))), ModuleFullTextSearchExtension.fjlFY9GV9M6o9S5tqXoE((object) filterProperty)))
              {
                num2 = 16;
                continue;
              }
              // ISSUE: type reference
              parameterExpression = (ParameterExpression) ModuleFullTextSearchExtension.L6PsSqGVmNNVX4OUVkSs(ModuleFullTextSearchExtension.j8MeypGV0lbcuV1krpTY(__typeref (IEntityFilter)), ModuleFullTextSearchExtension.tR85XbGVlJ1mqTyWbWbo(1021410165 ^ 1021510107));
              num2 = 36;
              continue;
            case 5:
              parameterExpression = (ParameterExpression) ModuleFullTextSearchExtension.L6PsSqGVmNNVX4OUVkSs(typeof (IEntityFilter), ModuleFullTextSearchExtension.tR85XbGVlJ1mqTyWbWbo(~538519529 ^ -538664264));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 17 : 9;
              continue;
            case 6:
            case 18:
              goto label_83;
            case 7:
              goto label_76;
            case 8:
              if (ModuleFullTextSearchExtension.y8vy1wGVgTGIBqbWP18j((object) filterProperty) == null)
              {
                num2 = 30;
                continue;
              }
              goto case 40;
            case 9:
              if (filterProperty.Value != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 31 : 37;
                continue;
              }
              goto label_75;
            case 10:
              if (!bool.TryParse(ModuleFullTextSearchExtension.y8vy1wGVgTGIBqbWP18j((object) filterProperty).ToString(), out result2))
              {
                num2 = 52;
                continue;
              }
              goto case 12;
            case 11:
              goto label_41;
            case 12:
              if (result2)
              {
                num2 = 42;
                continue;
              }
              goto label_22;
            case 13:
              goto label_33;
            case 14:
              if (!result1)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 27 : 46;
                continue;
              }
              goto label_46;
            case 15:
              if (filterProperty.Value == null)
              {
                num2 = 28;
                continue;
              }
              goto case 38;
            case 16:
              if (ModuleFullTextSearchExtension.y8vy1wGVgTGIBqbWP18j((object) filterProperty) == null)
              {
                num2 = 26;
                continue;
              }
              goto case 29;
            case 17:
              // ISSUE: method reference
              // ISSUE: type reference
              if (!(ModuleFullTextSearchExtension.Fgfg5sGVJ3qdkYYTUunp((object) InterfaceActivator.LoadPropertyMetadata<IEntityFilter>(Expression.Lambda<Func<IEntityFilter, object>>((Expression) Expression.Convert((Expression) ModuleFullTextSearchExtension.akBjZiGVMYAZU31yq5WU((object) parameterExpression, (object) (MethodInfo) ModuleFullTextSearchExtension.rysjTEGVyvwanHqiuvEh(__methodref (IEntityFilter.get_FullTextInAttachments))), ModuleFullTextSearchExtension.j8MeypGV0lbcuV1krpTY(__typeref (object))), parameterExpression))) == ModuleFullTextSearchExtension.fjlFY9GV9M6o9S5tqXoE((object) filterProperty)))
              {
                // ISSUE: type reference
                parameterExpression = (ParameterExpression) ModuleFullTextSearchExtension.L6PsSqGVmNNVX4OUVkSs(ModuleFullTextSearchExtension.j8MeypGV0lbcuV1krpTY(__typeref (IEntityFilter)), ModuleFullTextSearchExtension.tR85XbGVlJ1mqTyWbWbo(-2138958856 ^ -2139068074));
                num2 = 4;
                continue;
              }
              num2 = 11;
              continue;
            case 19:
              parameterExpression = (ParameterExpression) ModuleFullTextSearchExtension.L6PsSqGVmNNVX4OUVkSs(typeof (IEntityFilter), ModuleFullTextSearchExtension.tR85XbGVlJ1mqTyWbWbo(-1217523399 ^ -1217631337));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 14 : 24;
              continue;
            case 20:
              // ISSUE: type reference
              parameterExpression = Expression.Parameter(ModuleFullTextSearchExtension.j8MeypGV0lbcuV1krpTY(__typeref (IEntityFilter)), (string) ModuleFullTextSearchExtension.tR85XbGVlJ1mqTyWbWbo(277947046 - -1479185048 ^ 1757007760));
              num2 = 2;
              continue;
            case 21:
              // ISSUE: method reference
              // ISSUE: type reference
              if (!ModuleFullTextSearchExtension.mMM03IGVdrverdH9PS8y(ModuleFullTextSearchExtension.Fgfg5sGVJ3qdkYYTUunp((object) InterfaceActivator.LoadPropertyMetadata<IEntityFilter>(Expression.Lambda<Func<IEntityFilter, object>>((Expression) Expression.Convert((Expression) ModuleFullTextSearchExtension.akBjZiGVMYAZU31yq5WU((object) parameterExpression, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IEntityFilter.get_ShowOnlyGroups))), ModuleFullTextSearchExtension.j8MeypGV0lbcuV1krpTY(__typeref (object))), parameterExpression))), filterProperty.Uid))
              {
                num2 = 41;
                continue;
              }
              goto case 44;
            case 22:
              if (result5)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 1;
                continue;
              }
              goto label_72;
            case 23:
              if (ModuleFullTextSearchExtension.y8vy1wGVgTGIBqbWP18j((object) filterProperty) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 36 : 43;
                continue;
              }
              goto label_82;
            case 24:
              // ISSUE: method reference
              if (!ModuleFullTextSearchExtension.mMM03IGVdrverdH9PS8y(ModuleFullTextSearchExtension.Fgfg5sGVJ3qdkYYTUunp((object) InterfaceActivator.LoadPropertyMetadata<IEntityFilter>(Expression.Lambda<Func<IEntityFilter, object>>((Expression) ModuleFullTextSearchExtension.akBjZiGVMYAZU31yq5WU((object) parameterExpression, (object) (MethodInfo) ModuleFullTextSearchExtension.rysjTEGVyvwanHqiuvEh(__methodref (IEntityFilter.get_Subtype))), parameterExpression))), filterProperty.Uid))
              {
                num2 = 5;
                continue;
              }
              goto label_43;
            case 25:
              if (result4)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 18 : 17;
                continue;
              }
              goto label_82;
            case 26:
            case 34:
              goto label_32;
            case 27:
              goto label_52;
            case 29:
              if (bool.TryParse(ModuleFullTextSearchExtension.y8vy1wGVgTGIBqbWP18j((object) filterProperty).ToString(), out result6))
              {
                num2 = 51;
                continue;
              }
              goto label_33;
            case 30:
            case 46:
              goto label_45;
            case 31:
              goto label_22;
            case 32:
              goto label_70;
            case 33:
              goto label_43;
            case 35:
              goto label_75;
            case 36:
              // ISSUE: method reference
              // ISSUE: type reference
              if (!ModuleFullTextSearchExtension.mMM03IGVdrverdH9PS8y(InterfaceActivator.LoadPropertyMetadata<IEntityFilter>(Expression.Lambda<Func<IEntityFilter, object>>((Expression) ModuleFullTextSearchExtension.k2dJvkGVriweX4Uga0Ym(ModuleFullTextSearchExtension.akBjZiGVMYAZU31yq5WU((object) parameterExpression, (object) (MethodInfo) ModuleFullTextSearchExtension.rysjTEGVyvwanHqiuvEh(__methodref (IEntityFilter.get_DisableSoftDeletable))), ModuleFullTextSearchExtension.j8MeypGV0lbcuV1krpTY(__typeref (object))), parameterExpression)).Uid, ModuleFullTextSearchExtension.fjlFY9GV9M6o9S5tqXoE((object) filterProperty)))
              {
                num2 = 20;
                continue;
              }
              goto case 8;
            case 37:
              if (bool.TryParse(ModuleFullTextSearchExtension.y8vy1wGVgTGIBqbWP18j((object) filterProperty).ToString(), out result3))
              {
                num2 = 39;
                continue;
              }
              goto label_76;
            case 38:
              if (bool.TryParse(ModuleFullTextSearchExtension.y8vy1wGVgTGIBqbWP18j((object) filterProperty).ToString(), out result5))
              {
                num2 = 22;
                continue;
              }
              goto label_73;
            case 39:
              if (result3)
              {
                num2 = 7;
                continue;
              }
              goto label_75;
            case 40:
              if (bool.TryParse(ModuleFullTextSearchExtension.y8vy1wGVgTGIBqbWP18j((object) filterProperty).ToString(), out result1))
              {
                num2 = 14;
                continue;
              }
              goto label_46;
            case 41:
              if (ModuleFullTextSearchExtension.y8vy1wGVgTGIBqbWP18j((object) filterProperty) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 47 : 11;
                continue;
              }
              goto label_52;
            case 42:
            case 52:
              goto label_23;
            case 43:
              if (!bool.TryParse(filterProperty.Value.ToString(), out result4))
              {
                num2 = 6;
                continue;
              }
              goto case 25;
            case 44:
              if (filterProperty.Value != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 10 : 6;
                continue;
              }
              goto label_22;
            case 45:
              // ISSUE: method reference
              if (ModuleFullTextSearchExtension.mMM03IGVdrverdH9PS8y(ModuleFullTextSearchExtension.Fgfg5sGVJ3qdkYYTUunp((object) InterfaceActivator.LoadPropertyMetadata<IEntityFilter>(Expression.Lambda<Func<IEntityFilter, object>>((Expression) Expression.Convert((Expression) ModuleFullTextSearchExtension.akBjZiGVMYAZU31yq5WU((object) parameterExpression, (object) (MethodInfo) ModuleFullTextSearchExtension.rysjTEGVyvwanHqiuvEh(__methodref (IEntityFilter.get_FilterByHierarchyParent))), typeof (object)), parameterExpression))), ModuleFullTextSearchExtension.fjlFY9GV9M6o9S5tqXoE((object) filterProperty)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 9 : 3;
                continue;
              }
              parameterExpression = (ParameterExpression) ModuleFullTextSearchExtension.L6PsSqGVmNNVX4OUVkSs(typeof (IEntityFilter), ModuleFullTextSearchExtension.tR85XbGVlJ1mqTyWbWbo(~-122002947 ^ 122152108));
              num2 = 50;
              continue;
            case 47:
              goto label_53;
            case 48:
              goto label_80;
            case 49:
              // ISSUE: type reference
              parameterExpression = (ParameterExpression) ModuleFullTextSearchExtension.L6PsSqGVmNNVX4OUVkSs(ModuleFullTextSearchExtension.j8MeypGV0lbcuV1krpTY(__typeref (IEntityFilter)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957695762));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 48 : 3;
              continue;
            case 50:
              // ISSUE: method reference
              // ISSUE: type reference
              if (!ModuleFullTextSearchExtension.mMM03IGVdrverdH9PS8y(InterfaceActivator.LoadPropertyMetadata<IEntityFilter>(Expression.Lambda<Func<IEntityFilter, object>>((Expression) ModuleFullTextSearchExtension.k2dJvkGVriweX4Uga0Ym(ModuleFullTextSearchExtension.akBjZiGVMYAZU31yq5WU((object) parameterExpression, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IEntityFilter.get_DisableAutoFilter))), ModuleFullTextSearchExtension.j8MeypGV0lbcuV1krpTY(__typeref (object))), parameterExpression)).Uid, filterProperty.Uid))
              {
                parameterExpression = (ParameterExpression) ModuleFullTextSearchExtension.L6PsSqGVmNNVX4OUVkSs(typeof (IEntityFilter), ModuleFullTextSearchExtension.tR85XbGVlJ1mqTyWbWbo(-1978478350 ^ -1978619300));
                num2 = 21;
                continue;
              }
              goto label_67;
            case 51:
              if (result6)
              {
                num2 = 13;
                continue;
              }
              goto label_32;
            default:
              goto label_72;
          }
        }
label_67:
        num1 = 23;
        continue;
label_80:
        // ISSUE: method reference
        if (!ModuleFullTextSearchExtension.mMM03IGVdrverdH9PS8y(ModuleFullTextSearchExtension.Fgfg5sGVJ3qdkYYTUunp((object) InterfaceActivator.LoadPropertyMetadata<IEntityFilter>(Expression.Lambda<Func<IEntityFilter, object>>((Expression) ModuleFullTextSearchExtension.akBjZiGVMYAZU31yq5WU((object) parameterExpression, (object) (MethodInfo) ModuleFullTextSearchExtension.rysjTEGVyvwanHqiuvEh(__methodref (IEntityFilter.get_SearchString))), parameterExpression))), ModuleFullTextSearchExtension.fjlFY9GV9M6o9S5tqXoE((object) filterProperty)))
          num1 = 19;
        else
          goto label_70;
      }
label_22:
      return new FilterList();
label_23:
      return (FilterList) null;
label_32:
      return new FilterList();
label_33:
      return (FilterList) null;
label_41:
      return new FilterList();
label_43:
      return new FilterList();
label_45:
      return new FilterList();
label_46:
      return (FilterList) null;
label_52:
      return new FilterList();
label_53:
      return (FilterList) null;
label_70:
      return new FilterList();
label_72:
      return new FilterList();
label_73:
      return (FilterList) null;
label_75:
      return new FilterList();
label_76:
      return (FilterList) null;
label_82:
      return new FilterList();
label_83:
      return (FilterList) null;
    }

    /// <inheritdoc />
    public virtual FilterList GetAutoFilterFields(
      Type cardType,
      FilterProperty filterProperty,
      FullTextSearchResultModel searchModel)
    {
      return (FilterList) null;
    }

    /// <inheritdoc />
    public abstract void FillObject(
      Type cardType,
      IFullTextSearchObjectContainer obj,
      IEntity entity);

    /// <inheritdoc />
    public virtual List<IEntity> GetEntities(Type type, List<Guid> listUid) => new List<IEntity>();

    /// <inheritdoc />
    public virtual List<IEntity> GetEntities(Type cardType, List<long> listId) => new List<IEntity>();

    /// <inheritdoc />
    public virtual List<IEntity> LoadEntitiesByPage(
      Type cardType,
      int page,
      List<Guid> typeUidFilter = null)
    {
      return new List<IEntity>();
    }

    /// <inheritdoc />
    public virtual List<IEntity> LoadEntities(
      Type cardType,
      long? lastId,
      List<Guid> typeUidFilter = null)
    {
      return new List<IEntity>();
    }

    /// <inheritdoc />
    protected void SetFilterTypeUid(FullTextSearchResultModel resultModel, IEntityFilter filter)
    {
      int num = 2;
      ClassMetadata metadataByFilter;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            if (filter == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 1;
              continue;
            }
            goto case 5;
          case 3:
            if (metadataByFilter != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 4:
            goto label_10;
          case 5:
            metadataByFilter = MetadataLoader.GetEntityMetadataByFilter(filter.GetType());
            num = 3;
            continue;
          default:
            resultModel.TypeUid = metadataByFilter.Uid;
            num = 4;
            continue;
        }
      }
label_9:
      return;
label_10:
      return;
label_2:;
    }

    /// <inheritdoc />
    public virtual FullTextSearchResultModel CreateResultModelByFilter(IEntityFilter filter) => (FullTextSearchResultModel) null;

    /// <inheritdoc />
    public virtual SortList GetDefaultSortExpression() => (SortList) null;

    /// <inheritdoc />
    public virtual List<KeyValuePair<string, object>> CreateFromObject(
      Type cardType,
      IFullTextSearchObjectContainer obj)
    {
      return new List<KeyValuePair<string, object>>();
    }

    /// <inheritdoc />
    public virtual void DisableIndexing(string disableInfo)
    {
    }

    /// <inheritdoc />
    public abstract void ReconstructEntity(
      Type cardType,
      IFullTextSearchResultItem resultItem,
      IEntity<long> fakeEntity);

    /// <inheritdoc />
    public virtual IGlobalSettingsModule SettingModule => (IGlobalSettingsModule) null;

    protected ModuleFullTextSearchExtension()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool FlJxWnGVNbj4lCnUKt2T() => ModuleFullTextSearchExtension.JWBgQJGV1FbfMgqASqVi == null;

    internal static ModuleFullTextSearchExtension sLyBvUGV3RTTJuJFlGlb() => ModuleFullTextSearchExtension.JWBgQJGV1FbfMgqASqVi;

    internal static object sWcU1QGVpKTEdiur42dK([In] object obj0, [In] object obj1) => (object) ((ModuleFullTextSearchExtension) obj0).MappingFields((ClassMetadata) obj1);

    internal static Guid qDYaXFGVad9d4rZUM1bq([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static bool N7IuL8GVDRts2Ov4NhvQ([In] object obj0, [In] object obj1) => ((IFullTextSearchDescriptorService) obj0).IsSupportedIndexing((IPropertyMetadata) obj1);

    internal static void VR9YIMGVttuIypmmn0A5([In] object obj0, [In] object obj1) => ((IFullTextSearchObjectContainer) obj0).Properties = (ExpandoObject) obj1;

    internal static object TsNiKRGVwa7fyJgkAsDd([In] object obj0) => (object) ((IFullTextSearchObjectContainer) obj0).Properties;

    internal static bool EdepqIGV4AHt3tIaI5Gt([In] object obj0) => ((PropertyInfo) obj0).CanRead;

    internal static object R6xfpYGV6quBgQXOOItm([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static object fWUVAQGVHcaZj9j0cWGL([In] object obj0) => (object) ((FieldIndexListItem) obj0).Field;

    internal static object dqj90nGVAm7CfwtRuYF9([In] object obj0) => ((FieldIndexListItem) obj0).Value;

    internal static bool uBhgmNGV7nZEbaXkFfg4([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void L87mgJGVxJL2IZK5w4qn([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static Type j8MeypGV0lbcuV1krpTY([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object L6PsSqGVmNNVX4OUVkSs([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object rysjTEGVyvwanHqiuvEh([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object akBjZiGVMYAZU31yq5WU([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static Guid Fgfg5sGVJ3qdkYYTUunp([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static Guid fjlFY9GV9M6o9S5tqXoE([In] object obj0) => ((FilterProperty) obj0).Uid;

    internal static bool mMM03IGVdrverdH9PS8y([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object tR85XbGVlJ1mqTyWbWbo(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object k2dJvkGVriweX4Uga0Ym([In] object obj0, [In] Type obj1) => (object) Expression.Convert((Expression) obj0, obj1);

    internal static object y8vy1wGVgTGIBqbWP18j([In] object obj0) => ((FilterProperty) obj0).Value;
  }
}
