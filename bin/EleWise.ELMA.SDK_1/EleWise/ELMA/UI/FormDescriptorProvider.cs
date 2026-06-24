// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.FormDescriptorProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.UI
{
  [Service(Type = ComponentType.Server)]
  public class FormDescriptorProvider
  {
    private ConcurrentDictionary<Type, Type> _descriptorTypes;
    private static FormDescriptorProvider VHeCCjyhvHAnQr070iS;

    public IMemoryCacheService MemoryCacheService
    {
      get => this.\u003CMemoryCacheService\u003Ek__BackingField;
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
              this.\u003CMemoryCacheService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
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

    public ICacheService CacheService
    {
      get => this.\u003CCacheService\u003Ek__BackingField;
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
              this.\u003CCacheService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
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

    /// <summary>Получить дескриптор формы по имени</summary>
    /// <param name="metadataType">Идентификатор типа метаданных (страница или портлет)</param>
    /// <param name="name">Имя формы</param>
    /// <param name="forEmulation">Для эмуляции или нет</param>
    /// <returns></returns>
    public virtual FormDescriptor GetDescriptor(Guid metadataType, string name, bool forEmulation)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            Contract.ServiceNotNull((object) this.CacheService, (string) FormDescriptorProvider.axj46syQ0FHvPGG6UeX(694673736 ^ -23604109 ^ -672096991));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
            continue;
          case 2:
            FormDescriptorProvider.pxsh3nyfoU4BNavq4G7((object) this.MemoryCacheService, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837639287));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (FormDescriptor) FormDescriptorProvider.IUiqQVyCNHVVgvSOIEm((object) this.GetCollection(metadataType), (object) name, forEmulation);
    }

    /// <summary>
    /// Получить дескриптор формы по уникальному идентификатору заголовка
    /// </summary>
    /// <param name="metadataType">Идентификатор типа метаданных (страница или портлет)</param>
    /// <param name="headerUid">Уникальный идентификатор заголовка</param>
    /// <returns></returns>
    public virtual FormDescriptor GetDescriptorByHeaderUid(
      Guid metadataType,
      Guid headerUid,
      bool forEmulation)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            FormDescriptorProvider.pxsh3nyfoU4BNavq4G7((object) this.MemoryCacheService, FormDescriptorProvider.axj46syQ0FHvPGG6UeX(516838154 ^ 516879608));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            Contract.ServiceNotNull((object) this.CacheService, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751153670));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 2 : 2;
            continue;
        }
      }
label_3:
      return (FormDescriptor) FormDescriptorProvider.gWPiJ7yvHup9Exd67B5((object) this.GetCollection(metadataType), headerUid, forEmulation);
    }

    /// <summary>
    /// Получить дескриптор формы по уникальному идентификатору
    /// </summary>
    /// <param name="metadataType">Идентификатор типа метаданных (страница или портлет)</param>
    /// <param name="descriptorUid">Уникальный идентификатор дескриптора</param>
    /// <returns></returns>
    public virtual FormDescriptor GetDescriptor(Guid metadataType, Guid descriptorUid)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            FormDescriptorProvider.pxsh3nyfoU4BNavq4G7((object) this.MemoryCacheService, FormDescriptorProvider.axj46syQ0FHvPGG6UeX(~289714581 ^ -289674856));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            FormDescriptorProvider.pxsh3nyfoU4BNavq4G7((object) this.CacheService, FormDescriptorProvider.axj46syQ0FHvPGG6UeX(-1824388195 ^ -1824349305));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 2 : 0;
            continue;
        }
      }
label_4:
      return (FormDescriptor) FormDescriptorProvider.F3uEiPy8vdbkJSTZgZt((object) this.GetCollection(metadataType), descriptorUid);
    }

    /// <summary>Получить список дескрипторов определенного типа</summary>
    /// <param name="metadataType">Идентификатор типа метаданных (страница или портлет)</param>
    /// <param name="forEmulation">Для эмуляции или нет</param>
    /// <returns></returns>
    public virtual IEnumerable<FormDescriptor> GetDescriptors(Guid metadataType, bool forEmulation) => this.GetCollection(metadataType).GetDescriptors(forEmulation);

    internal void UpdateCache(Guid metadataType)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            Contract.ServiceNotNull((object) this.MemoryCacheService, (string) FormDescriptorProvider.axj46syQ0FHvPGG6UeX(~289714581 ^ -289674856));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
            continue;
          case 2:
            this.CacheService.Insert<long>(FormDescriptorProvider.axj46syQ0FHvPGG6UeX(-1886646897 ^ -1886607943).ToString() + (object) metadataType, FormDescriptorProvider.Dn9hhtyZg4Mi7ZMG6uj().Ticks);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 3 : 3;
            continue;
          case 3:
            goto label_2;
          default:
            FormDescriptorProvider.pxsh3nyfoU4BNavq4G7((object) this.CacheService, FormDescriptorProvider.axj46syQ0FHvPGG6UeX(-2092274397 << 4 ^ 883325482));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal FormDescriptor CreateDescriptor(IFormMetadataItem item)
    {
      int num1 = 16;
      Type type1;
      Type t;
      while (true)
      {
        int num2 = num1;
        IFormDescriptorInfo formDescriptorInfo;
        IEnumerable<IFormDescriptorInfo> extensionPoints;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 5:
              if (FormDescriptorProvider.xllTC9yRgfBTkdKkpfS(t, (Type) null))
              {
                num2 = 13;
                continue;
              }
              goto case 7;
            case 2:
              // ISSUE: reference to a compiler-generated method
              formDescriptorInfo = extensionPoints.FirstOrDefault<IFormDescriptorInfo>((Func<IFormDescriptorInfo, bool>) (i => FormDescriptorProvider.\u003C\u003Ec__DisplayClass13_0.w1xTZhfg588HDlCy8Y0y(i.MetadataType, t)));
              num2 = 6;
              continue;
            case 3:
              num2 = 8;
              continue;
            case 4:
            case 17:
              goto label_20;
            case 6:
              if (formDescriptorInfo == null)
              {
                num2 = 10;
                continue;
              }
              goto label_25;
            case 7:
              if (!FormDescriptorProvider.c336PbyqByxTEMx4AfC(type1, (Type) null))
              {
                num2 = 18;
                continue;
              }
              goto label_17;
            case 8:
              goto label_12;
            case 9:
              goto label_9;
            case 10:
              goto label_4;
            case 11:
              if (this._descriptorTypes.TryGetValue(FormDescriptorProvider.gBA2E3yV2ekbjTkQRCB((object) item).GetType(), out type1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 17 : 11;
                continue;
              }
              goto case 3;
            case 12:
              t = FormDescriptorProvider.gBA2E3yV2ekbjTkQRCB((object) item).GetType();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
              continue;
            case 13:
              if (!(type1 == (Type) null))
              {
                num2 = 7;
                continue;
              }
              goto case 2;
            case 14:
              goto label_17;
            case 15:
              FormDescriptorProvider.ziw837yIlksXKE3MmYW(item.Metadata != null, FormDescriptorProvider.axj46syQ0FHvPGG6UeX(1033719030 - 2012070891 ^ -978378367));
              num2 = 11;
              continue;
            case 16:
              FormDescriptorProvider.xOn5tByus6cQJUg46yr((object) item, FormDescriptorProvider.axj46syQ0FHvPGG6UeX(-105199646 ^ -105222244));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 6 : 15;
              continue;
            case 18:
              this._descriptorTypes[item.Metadata.GetType()] = type1;
              num2 = 4;
              continue;
            default:
              type1 = (Type) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 1 : 1;
              continue;
          }
        }
label_4:
        Type type2 = (Type) null;
        goto label_26;
label_9:
        t = t.BaseType;
        num1 = 5;
        continue;
label_12:
        extensionPoints = ((ComponentManager) FormDescriptorProvider.exw2MeyST8kiYaGUZpq()).GetExtensionPoints<IFormDescriptorInfo>();
        num1 = 12;
        continue;
label_25:
        type2 = FormDescriptorProvider.KSts59yi7lk2jTbQ90Q((object) formDescriptorInfo);
label_26:
        type1 = type2;
        num1 = 9;
      }
label_17:
      throw new InvalidOperationException((string) FormDescriptorProvider.uob5n6yKxYaSfnk3DTh((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317751704), (object) t.FullName));
label_20:
      return (FormDescriptor) FormDescriptorProvider.pAVBysyXY8KEboq1Pb4(type1, (object) new object[1]
      {
        (object) item
      });
    }

    private long GetTimestamp(Guid metadataType)
    {
      int num = 2;
      long? nullable;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!nullable.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            nullable = this.CacheService.Get<long?>(FormDescriptorProvider.axj46syQ0FHvPGG6UeX(381945751 ^ 1158627804 ^ 1405873789).ToString() + (object) metadataType);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 1 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return 0;
label_3:
      return nullable.Value;
    }

    private FormDescriptorProvider.FormDescriptorCollection GetCollection(Guid metadataType)
    {
      int num1 = 3;
      FormDescriptorProvider.FormDescriptorCollection result;
      FormDescriptorProvider.FormDescriptorCollection descriptorCollection;
      bool lockTaken;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          long timestamp;
          bool flag;
          string key;
          switch (num2)
          {
            case 1:
              flag = FormDescriptorProvider.fYSHFoykeemElDLZoZd((object) result) != timestamp;
              num2 = 5;
              continue;
            case 2:
              flag = false;
              num2 = 10;
              continue;
            case 3:
              timestamp = this.GetTimestamp(metadataType);
              num2 = 2;
              continue;
            case 4:
            case 13:
              goto label_34;
            case 5:
            case 11:
              if (flag)
                break;
              goto label_38;
            case 6:
              lockTaken = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 2 : 14;
              continue;
            case 7:
              flag = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 11 : 7;
              continue;
            case 8:
              if (this.MemoryCacheService.TryGetValue<FormDescriptorProvider.FormDescriptorCollection>(key, out result))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 1;
                continue;
              }
              goto case 9;
            case 9:
              result = new FormDescriptorProvider.FormDescriptorCollection(this, metadataType);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 9 : 12;
              continue;
            case 10:
              key = (string) FormDescriptorProvider.E2uMBiyT7XIrBm3wDbM(FormDescriptorProvider.axj46syQ0FHvPGG6UeX(-882126494 ^ -882149292), (object) metadataType);
              num2 = 8;
              continue;
            case 12:
              this.MemoryCacheService.Insert<FormDescriptorProvider.FormDescriptorCollection>(key, result);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 7 : 0;
              continue;
            case 14:
              goto label_6;
          }
          descriptorCollection = result;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 6 : 5;
        }
label_38:
        num1 = 4;
      }
label_6:
      try
      {
        Monitor.Enter((object) descriptorCollection, ref lockTaken);
        int num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
          num3 = 0;
        IEnumerator<FormMetadataItemHeaderManager.HeaderDescriptorInfo> enumerator;
        while (true)
        {
          switch (num3)
          {
            case 1:
              enumerator = Locator.GetServiceNotNull<FormMetadataItemHeaderManager>().GetPublishedHeaderDescriptorInfos(metadataType).GetEnumerator();
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        try
        {
label_13:
          if (FormDescriptorProvider.u67kb9y2AvIRRJ7GQ7d((object) enumerator))
            goto label_17;
          else
            goto label_14;
label_12:
          FormMetadataItemHeaderManager.HeaderDescriptorInfo current;
          FormDescriptorProvider.FormDescriptorEntry existingEntry;
          int num4;
          while (true)
          {
            switch (num4)
            {
              case 1:
                goto label_17;
              case 2:
                goto label_13;
              case 3:
                this.CheckEntry(result, current, existingEntry);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 2 : 0;
                continue;
              case 4:
                goto label_34;
              default:
                existingEntry = (FormDescriptorProvider.FormDescriptorEntry) FormDescriptorProvider.CE575JyOsT07QFdoYnH((object) result, FormDescriptorProvider.xr0ofFynQBK4OuKM4QS((object) current));
                num4 = 3;
                continue;
            }
          }
label_14:
          num4 = 4;
          goto label_12;
label_17:
          current = enumerator.Current;
          num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
          {
            num4 = 0;
            goto label_12;
          }
          else
            goto label_12;
        }
        finally
        {
          if (enumerator != null)
          {
            int num5 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
              num5 = 0;
            while (true)
            {
              switch (num5)
              {
                case 1:
                  goto label_24;
                default:
                  enumerator.Dispose();
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 1 : 1;
                  continue;
              }
            }
          }
label_24:;
        }
      }
      finally
      {
        int num6;
        if (!lockTaken)
          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 2 : 2;
        else
          goto label_28;
label_27:
        switch (num6)
        {
          case 1:
            break;
          default:
        }
label_28:
        FormDescriptorProvider.x8yBnUyec1jpbIW3Rhr((object) descriptorCollection);
        num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
        {
          num6 = 0;
          goto label_27;
        }
        else
          goto label_27;
      }
label_34:
      return result;
    }

    private void CheckEntry(
      FormDescriptorProvider.FormDescriptorCollection collection,
      FormMetadataItemHeaderManager.HeaderDescriptorInfo di,
      FormDescriptorProvider.FormDescriptorEntry existingEntry)
    {
      int num1 = 32;
      while (true)
      {
        int num2 = num1;
        bool flag;
        while (true)
        {
          FormDescriptor formDescriptor1;
          long? nullable;
          FormMetadataItemManager serviceNotNull;
          IFormMetadataItem formMetadataItem1;
          FormDescriptor formDescriptor2;
          FormDescriptorProvider.FormDescriptorEntry formDescriptorEntry1;
          IFormMetadataItem formMetadataItem2;
          object obj;
          FormDescriptor formDescriptor3;
          switch (num2)
          {
            case 1:
              if (formDescriptor1 != null)
              {
                num2 = 16;
                continue;
              }
              goto case 14;
            case 2:
              FormDescriptorProvider.FormDescriptorEntry formDescriptorEntry2 = new FormDescriptorProvider.FormDescriptorEntry();
              FormDescriptorProvider.yZnvnjyD4qLTUyTxPsw((object) formDescriptorEntry2, FormDescriptorProvider.xr0ofFynQBK4OuKM4QS((object) di));
              FormDescriptorProvider.DYAwgYytaVnkKqpeWbS((object) formDescriptorEntry2, FormDescriptorProvider.vdkY0xy3YlOG0022lNk((object) di));
              FormDescriptorProvider.BlN0mwyw2vD23E4n3UY((object) formDescriptorEntry2, (object) formDescriptor2);
              FormDescriptorProvider.lnrH1Oy4rG2a3kMTTMT((object) formDescriptorEntry2, (object) formDescriptor1);
              formDescriptorEntry1 = formDescriptorEntry2;
              num2 = 28;
              continue;
            case 3:
              obj = FormDescriptorProvider.knZW7JyPsWKlYg3BQTP((object) existingEntry);
              break;
            case 4:
            case 13:
              if (flag)
              {
                num2 = 2;
                continue;
              }
              goto label_63;
            case 5:
              goto label_41;
            case 6:
              formDescriptor3 = (FormDescriptor) null;
              goto label_71;
            case 7:
              if (nullable.HasValue)
              {
                num2 = 23;
                continue;
              }
              goto case 18;
            case 8:
              if (!nullable.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 6 : 30;
                continue;
              }
              goto case 22;
            case 9:
label_15:
              flag = true;
              num2 = 34;
              continue;
            case 10:
            case 41:
              FormMetadataItemManager metadataItemManager1 = serviceNotNull;
              nullable = di.EmulationId;
              long id1 = nullable.Value;
              formMetadataItem1 = metadataItemManager1.Load(id1);
              num2 = 27;
              continue;
            case 11:
              if (!((string) FormDescriptorProvider.jdycL2yawZrqXXq0Y4i((object) existingEntry) != (string) FormDescriptorProvider.vdkY0xy3YlOG0022lNk((object) di)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 2 : 4;
                continue;
              }
              goto case 17;
            case 12:
              obj = (object) null;
              break;
            case 14:
            case 34:
              if (existingEntry != null)
              {
                num2 = 11;
                continue;
              }
              goto case 17;
            case 15:
              if (nullable.HasValue)
              {
                num2 = 42;
                continue;
              }
              goto case 36;
            case 16:
              formDescriptor1 = (FormDescriptor) null;
              num2 = 43;
              continue;
            case 17:
              flag = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 13 : 12;
              continue;
            case 18:
              nullable = di.EmulationId;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 16 : 26;
              continue;
            case 19:
              try
              {
                formDescriptor2 = this.CreateDescriptor(formMetadataItem2);
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    goto label_8;
                }
              }
              catch (Exception ex)
              {
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
                  num4 = 0;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_8;
                    default:
                      FormDescriptorProvider.qY5bHnypx53tQh8eG7U(FormDescriptorProvider.asUmf9yNFcyb5M3LdBr(), FormDescriptorProvider.uob5n6yKxYaSfnk3DTh(FormDescriptorProvider.axj46syQ0FHvPGG6UeX(1012087039 ^ 1012109715), FormDescriptorProvider.vdkY0xy3YlOG0022lNk((object) di)), (object) ex);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 1 : 1;
                      continue;
                  }
                }
              }
            case 21:
              formDescriptor2 = (FormDescriptor) null;
              num2 = 35;
              continue;
            case 22:
              if (formDescriptor2 == null)
              {
                num2 = 24;
                continue;
              }
              goto case 37;
            case 23:
              if (formDescriptor1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 9 : 41;
                continue;
              }
              goto case 45;
            case 24:
            case 40:
              FormMetadataItemManager metadataItemManager2 = serviceNotNull;
              nullable = di.PublishedId;
              long id2 = nullable.Value;
              formMetadataItem2 = metadataItemManager2.Load(id2);
              num2 = 19;
              continue;
            case 25:
            case 30:
              nullable = di.PublishedId;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 7 : 15;
              continue;
            case 26:
              if (!nullable.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 1;
                continue;
              }
              goto case 14;
            case 27:
              try
              {
                formDescriptor1 = this.CreateDescriptor(formMetadataItem1);
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0)
                  num5 = 0;
                switch (num5)
                {
                  default:
                    goto label_15;
                }
              }
              catch (Exception ex)
              {
                int num6 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
                  num6 = 0;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      FormDescriptorProvider.qY5bHnypx53tQh8eG7U(FormDescriptorProvider.asUmf9yNFcyb5M3LdBr(), FormDescriptorProvider.uob5n6yKxYaSfnk3DTh((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236093469), (object) di.Name), (object) ex);
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_15;
                  }
                }
              }
            case 28:
              FormDescriptorProvider.vmwqDny69ysdYxd17WT((object) collection, (object) formDescriptorEntry1);
              num2 = 44;
              continue;
            case 31:
              if (existingEntry != null)
              {
                num2 = 3;
                continue;
              }
              goto case 12;
            case 32:
              serviceNotNull = Locator.GetServiceNotNull<FormMetadataItemManager>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 31 : 11;
              continue;
            case 33:
label_8:
              flag = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
              continue;
            case 35:
              flag = true;
              num2 = 20;
              continue;
            case 36:
              if (formDescriptor2 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 8 : 29;
                continue;
              }
              goto case 21;
            case 37:
              long num7 = FormDescriptorProvider.b4X0kKy1YXJrXCM5EGU((object) formDescriptor2);
              nullable = di.PublishedId;
              long num8 = nullable.Value;
              if (num7 != num8)
              {
                num2 = 40;
                continue;
              }
              goto case 25;
            case 38:
              nullable = di.PublishedId;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 4 : 8;
              continue;
            case 39:
              if (existingEntry == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 6 : 6;
                continue;
              }
              formDescriptor3 = existingEntry.Emulation;
              goto label_71;
            case 43:
              flag = true;
              num2 = 14;
              continue;
            case 44:
              goto label_64;
            case 45:
              long num9 = FormDescriptorProvider.b4X0kKy1YXJrXCM5EGU((object) formDescriptor1);
              nullable = di.EmulationId;
              long num10 = nullable.Value;
              if (num9 != num10)
              {
                num2 = 10;
                continue;
              }
              goto case 18;
            default:
              nullable = di.EmulationId;
              num2 = 7;
              continue;
          }
          formDescriptor2 = (FormDescriptor) obj;
          num2 = 39;
          continue;
label_71:
          formDescriptor1 = formDescriptor3;
          num2 = 5;
        }
label_41:
        flag = false;
        num1 = 38;
      }
label_64:
      return;
label_63:;
    }

    public FormDescriptorProvider()
    {
      FormDescriptorProvider.u69M9iyHEDZNAWlh45x();
      this._descriptorTypes = new ConcurrentDictionary<Type, Type>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool ltwdOPyGeZgxqlY6m4P() => FormDescriptorProvider.VHeCCjyhvHAnQr070iS == null;

    internal static FormDescriptorProvider dyMn4iyEnIgQtpx5DZx() => FormDescriptorProvider.VHeCCjyhvHAnQr070iS;

    internal static void pxsh3nyfoU4BNavq4G7([In] object obj0, [In] object obj1) => Contract.ServiceNotNull(obj0, (string) obj1);

    internal static object axj46syQ0FHvPGG6UeX(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object IUiqQVyCNHVVgvSOIEm([In] object obj0, [In] object obj1, bool forEmulation) => (object) ((FormDescriptorProvider.FormDescriptorCollection) obj0).GetDescriptor((string) obj1, forEmulation);

    internal static object gWPiJ7yvHup9Exd67B5([In] object obj0, Guid uid, bool forEmulation) => (object) ((FormDescriptorProvider.FormDescriptorCollection) obj0).GetDescriptorByHeaderUid(uid, forEmulation);

    internal static object F3uEiPy8vdbkJSTZgZt([In] object obj0, Guid uid) => (object) ((FormDescriptorProvider.FormDescriptorCollection) obj0).GetDescriptor(uid);

    internal static DateTime Dn9hhtyZg4Mi7ZMG6uj() => DateTime.Now;

    internal static void xOn5tByus6cQJUg46yr([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void ziw837yIlksXKE3MmYW(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static object gBA2E3yV2ekbjTkQRCB([In] object obj0) => ((IFormMetadataItem) obj0).Metadata;

    internal static object exw2MeyST8kiYaGUZpq() => (object) ComponentManager.Current;

    internal static Type KSts59yi7lk2jTbQ90Q([In] object obj0) => ((IFormDescriptorInfo) obj0).DescriptorType;

    internal static bool xllTC9yRgfBTkdKkpfS([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool c336PbyqByxTEMx4AfC([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object uob5n6yKxYaSfnk3DTh([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object pAVBysyXY8KEboq1Pb4([In] Type obj0, [In] object obj1) => Activator.CreateInstance(obj0, (object[]) obj1);

    internal static object E2uMBiyT7XIrBm3wDbM([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static long fYSHFoykeemElDLZoZd([In] object obj0) => ((FormDescriptorProvider.FormDescriptorCollection) obj0).Timestamp;

    internal static Guid xr0ofFynQBK4OuKM4QS([In] object obj0) => ((FormMetadataItemHeaderManager.HeaderDescriptorInfo) obj0).Uid;

    internal static object CE575JyOsT07QFdoYnH([In] object obj0, Guid uid) => (object) ((FormDescriptorProvider.FormDescriptorCollection) obj0).GetEntry(uid);

    internal static bool u67kb9y2AvIRRJ7GQ7d([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void x8yBnUyec1jpbIW3Rhr([In] object obj0) => Monitor.Exit(obj0);

    internal static object knZW7JyPsWKlYg3BQTP([In] object obj0) => (object) ((FormDescriptorProvider.FormDescriptorEntry) obj0).Published;

    internal static long b4X0kKy1YXJrXCM5EGU([In] object obj0) => ((FormDescriptor) obj0).MetadataItemId;

    internal static object asUmf9yNFcyb5M3LdBr() => (object) Logger.Log;

    internal static object vdkY0xy3YlOG0022lNk([In] object obj0) => (object) ((FormMetadataItemHeaderManager.HeaderDescriptorInfo) obj0).Name;

    internal static void qY5bHnypx53tQh8eG7U([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static object jdycL2yawZrqXXq0Y4i([In] object obj0) => (object) ((FormDescriptorProvider.FormDescriptorEntry) obj0).Name;

    internal static void yZnvnjyD4qLTUyTxPsw([In] object obj0, Guid value) => ((FormDescriptorProvider.FormDescriptorEntry) obj0).Uid = value;

    internal static void DYAwgYytaVnkKqpeWbS([In] object obj0, [In] object obj1) => ((FormDescriptorProvider.FormDescriptorEntry) obj0).Name = (string) obj1;

    internal static void BlN0mwyw2vD23E4n3UY([In] object obj0, [In] object obj1) => ((FormDescriptorProvider.FormDescriptorEntry) obj0).Published = (FormDescriptor) obj1;

    internal static void lnrH1Oy4rG2a3kMTTMT([In] object obj0, [In] object obj1) => ((FormDescriptorProvider.FormDescriptorEntry) obj0).Emulation = (FormDescriptor) obj1;

    internal static void vmwqDny69ysdYxd17WT([In] object obj0, [In] object obj1) => ((FormDescriptorProvider.FormDescriptorCollection) obj0).Put((FormDescriptorProvider.FormDescriptorEntry) obj1);

    internal static void u69M9iyHEDZNAWlh45x() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    private class FormDescriptorEntry
    {
      internal static object giSNJEfgpjfFKDFelEIs;

      public Guid Uid
      {
        get => this.\u003CUid\u003Ek__BackingField;
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
                this.\u003CUid\u003Ek__BackingField = value;
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
      }

      public string Name
      {
        get => this.\u003CName\u003Ek__BackingField;
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
                this.\u003CName\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
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

      public FormDescriptor Published
      {
        get => this.\u003CPublished\u003Ek__BackingField;
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
                this.\u003CPublished\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
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

      public FormDescriptor Emulation
      {
        get => this.\u003CEmulation\u003Ek__BackingField;
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
                this.\u003CEmulation\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
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

      public FormDescriptorEntry()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool tDDW8xfgaR4FLxLHkmG4() => FormDescriptorProvider.FormDescriptorEntry.giSNJEfgpjfFKDFelEIs == null;

      internal static FormDescriptorProvider.FormDescriptorEntry EfICZZfgDaHqi2JpLNEd() => (FormDescriptorProvider.FormDescriptorEntry) FormDescriptorProvider.FormDescriptorEntry.giSNJEfgpjfFKDFelEIs;
    }

    private class FormDescriptorCollection
    {
      private object _owner;
      private ConcurrentDictionary<Guid, FormDescriptor> _descriptors;
      private ConcurrentDictionary<Guid, FormDescriptorProvider.FormDescriptorEntry> _entries;
      private ConcurrentDictionary<Guid, FormDescriptorProvider.FormDescriptorEntry> _entriesByHeaderUid;
      private ConcurrentDictionary<string, FormDescriptorProvider.FormDescriptorEntry> _entriesByName;
      internal static object teDnoyfgtKTyPaMENWov;

      public FormDescriptorCollection(FormDescriptorProvider owner, Guid metadataType)
      {
        FormDescriptorProvider.FormDescriptorCollection.IiPmOJfg603HViTRcixo();
        this._descriptors = new ConcurrentDictionary<Guid, FormDescriptor>();
        this._entries = new ConcurrentDictionary<Guid, FormDescriptorProvider.FormDescriptorEntry>();
        this._entriesByHeaderUid = new ConcurrentDictionary<Guid, FormDescriptorProvider.FormDescriptorEntry>();
        this._entriesByName = new ConcurrentDictionary<string, FormDescriptorProvider.FormDescriptorEntry>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.MetadataType = metadataType;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
              continue;
            case 2:
              FormDescriptorProvider.FormDescriptorCollection.r6X8GXfgAq3ftTLmgdD5((object) owner, FormDescriptorProvider.FormDescriptorCollection.NVMj7JfgHRAFvGQoHm7f(-53329496 >> 4 ^ -3650266));
              num = 3;
              continue;
            case 3:
              this._owner = (object) owner;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 1;
              continue;
            default:
              goto label_6;
          }
        }
label_2:
        return;
label_6:;
      }

      public Guid MetadataType
      {
        get => this.\u003CMetadataType\u003Ek__BackingField;
        private set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CMetadataType\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
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

      public long Timestamp
      {
        get => this.\u003CTimestamp\u003Ek__BackingField;
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
                this.\u003CTimestamp\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
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

      public void Put(FormDescriptorProvider.FormDescriptorEntry entry)
      {
        int num1 = 15;
        while (true)
        {
          int num2 = num1;
          FormDescriptorProvider.FormDescriptorEntry formDescriptorEntry;
          FormDescriptorProvider.FormDescriptorEntry entry1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_19;
              case 2:
              case 7:
                this._entriesByHeaderUid[FormDescriptorProvider.FormDescriptorCollection.rd7AM5fgmPHjg8i67HwH((object) entry1)] = entry1;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 1;
                continue;
              case 3:
              case 6:
                if (FormDescriptorProvider.FormDescriptorCollection.lul5xHfg058xCyiBIkhX((object) entry1) == null)
                {
                  num2 = 18;
                  continue;
                }
                goto case 19;
              case 4:
                this._entriesByName[((string) FormDescriptorProvider.FormDescriptorCollection.q83kBmfgyvqKoDtboRUq((object) entry1)).ToLower()] = entry1;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
                continue;
              case 5:
                goto label_3;
              case 8:
                if (FormDescriptorProvider.FormDescriptorCollection.Vp9q5afg7DfBCFqeZGnI((object) entry1) != null)
                {
                  num2 = 17;
                  continue;
                }
                goto case 3;
              case 9:
              case 18:
                this._entries[FormDescriptorProvider.FormDescriptorCollection.rd7AM5fgmPHjg8i67HwH((object) entry1)] = entry1;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 16 : 0;
                continue;
              case 10:
              case 20:
                this._entriesByName[(string) FormDescriptorProvider.FormDescriptorCollection.cFS9rqfgMBbA3EvUZAKG((object) entry1.Name)] = entry1;
                num2 = 7;
                continue;
              case 11:
                if (!FormDescriptorProvider.FormDescriptorCollection.KbBTT5fgJbXlpN4SRKrr(FormDescriptorProvider.FormDescriptorCollection.cFS9rqfgMBbA3EvUZAKG(FormDescriptorProvider.FormDescriptorCollection.q83kBmfgyvqKoDtboRUq((object) formDescriptorEntry)), (object) entry1.Name.ToLower()))
                {
                  num2 = 20;
                  continue;
                }
                goto case 4;
              case 12:
                FormDescriptorProvider.FormDescriptorCollection.r6X8GXfgAq3ftTLmgdD5((object) entry1, FormDescriptorProvider.FormDescriptorCollection.NVMj7JfgHRAFvGQoHm7f(44884861 ^ 44665399));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 2 : 8;
                continue;
              case 13:
                this._descriptors[FormDescriptorProvider.FormDescriptorCollection.YMweaqfgxbr1E70gykbA(FormDescriptorProvider.FormDescriptorCollection.lul5xHfg058xCyiBIkhX((object) entry1))] = (FormDescriptor) FormDescriptorProvider.FormDescriptorCollection.lul5xHfg058xCyiBIkhX((object) entry1);
                num2 = 9;
                continue;
              case 14:
                entry1 = entry;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 12 : 9;
                continue;
              case 15:
                num2 = 14;
                continue;
              case 16:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                formDescriptorEntry = this._entriesByName.Values.FirstOrDefault<FormDescriptorProvider.FormDescriptorEntry>((Func<FormDescriptorProvider.FormDescriptorEntry, bool>) (v => FormDescriptorProvider.FormDescriptorCollection.\u003C\u003Ec__DisplayClass9_0.wMROGBZCOOb15xBfrLSD(v.Uid, FormDescriptorProvider.FormDescriptorCollection.\u003C\u003Ec__DisplayClass9_0.abZsTXZCnSH9IfTYnbkn((object) entry1))));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 1 : 21;
                continue;
              case 17:
                if (this._descriptors.ContainsKey(FormDescriptorProvider.FormDescriptorCollection.YMweaqfgxbr1E70gykbA(FormDescriptorProvider.FormDescriptorCollection.Vp9q5afg7DfBCFqeZGnI((object) entry1))))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 3 : 3;
                  continue;
                }
                goto label_3;
              case 19:
                if (!this._descriptors.ContainsKey(FormDescriptorProvider.FormDescriptorCollection.YMweaqfgxbr1E70gykbA(FormDescriptorProvider.FormDescriptorCollection.lul5xHfg058xCyiBIkhX((object) entry1))))
                {
                  num2 = 13;
                  continue;
                }
                goto case 9;
              case 21:
                if (formDescriptorEntry != null)
                {
                  num2 = 11;
                  continue;
                }
                goto case 10;
              default:
                this._entriesByName.TryRemove((string) FormDescriptorProvider.FormDescriptorCollection.cFS9rqfgMBbA3EvUZAKG(FormDescriptorProvider.FormDescriptorCollection.q83kBmfgyvqKoDtboRUq((object) formDescriptorEntry)), out formDescriptorEntry);
                num2 = 2;
                continue;
            }
          }
label_3:
          this._descriptors[FormDescriptorProvider.FormDescriptorCollection.YMweaqfgxbr1E70gykbA(FormDescriptorProvider.FormDescriptorCollection.Vp9q5afg7DfBCFqeZGnI((object) entry1))] = (FormDescriptor) FormDescriptorProvider.FormDescriptorCollection.Vp9q5afg7DfBCFqeZGnI((object) entry1);
          num1 = 6;
        }
label_19:;
      }

      public FormDescriptor GetDescriptor(Guid uid)
      {
        int num = 1;
        FormDescriptor descriptor;
        while (true)
        {
          switch (num)
          {
            case 1:
              this._descriptors.TryGetValue(uid, out descriptor);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return descriptor;
      }

      public FormDescriptor GetDescriptorByHeaderUid(Guid uid, bool forEmulation)
      {
        int num = 3;
        FormDescriptorProvider.FormDescriptorEntry formDescriptorEntry;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              if (formDescriptorEntry != null)
              {
                num = 5;
                continue;
              }
              goto label_5;
            case 3:
              this._entriesByHeaderUid.TryGetValue(uid, out formDescriptorEntry);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 2;
              continue;
            case 4:
              goto label_10;
            case 5:
              if (forEmulation)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
                continue;
              }
              goto label_10;
            case 6:
              goto label_11;
            default:
              if (FormDescriptorProvider.FormDescriptorCollection.lul5xHfg058xCyiBIkhX((object) formDescriptorEntry) != null)
              {
                num = 6;
                continue;
              }
              goto label_10;
          }
        }
label_5:
        return (FormDescriptor) null;
label_10:
        return (FormDescriptor) FormDescriptorProvider.FormDescriptorCollection.Vp9q5afg7DfBCFqeZGnI((object) formDescriptorEntry);
label_11:
        return (FormDescriptor) FormDescriptorProvider.FormDescriptorCollection.lul5xHfg058xCyiBIkhX((object) formDescriptorEntry);
      }

      public FormDescriptor GetDescriptor(string name, bool forEmulation)
      {
        int num1 = 6;
        FormDescriptorProvider.FormDescriptorEntry formDescriptorEntry;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_5;
              case 2:
                if (FormDescriptorProvider.FormDescriptorCollection.lul5xHfg058xCyiBIkhX((object) formDescriptorEntry) == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
                  continue;
                }
                goto label_4;
              case 3:
                goto label_6;
              case 4:
                if (formDescriptorEntry != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 3 : 3;
                  continue;
                }
                goto label_5;
              case 5:
                this._entriesByName.TryGetValue((string) FormDescriptorProvider.FormDescriptorCollection.cFS9rqfgMBbA3EvUZAKG((object) name), out formDescriptorEntry);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 4 : 2;
                continue;
              case 6:
                FormDescriptorProvider.FormDescriptorCollection.zdOkr5fg9UaoHsvZJNhP((object) name, FormDescriptorProvider.FormDescriptorCollection.NVMj7JfgHRAFvGQoHm7f(-675505729 ^ -675506775));
                num2 = 5;
                continue;
              default:
                goto label_3;
            }
          }
label_6:
          if (forEmulation)
            num1 = 2;
          else
            break;
        }
label_3:
        return (FormDescriptor) FormDescriptorProvider.FormDescriptorCollection.Vp9q5afg7DfBCFqeZGnI((object) formDescriptorEntry);
label_4:
        return (FormDescriptor) FormDescriptorProvider.FormDescriptorCollection.lul5xHfg058xCyiBIkhX((object) formDescriptorEntry);
label_5:
        return (FormDescriptor) null;
      }

      public IEnumerable<FormDescriptor> GetDescriptors(bool forEmulation) => (IEnumerable<FormDescriptor>) this._entries.Select<KeyValuePair<Guid, FormDescriptorProvider.FormDescriptorEntry>, FormDescriptor>((Func<KeyValuePair<Guid, FormDescriptorProvider.FormDescriptorEntry>, FormDescriptor>) (e => !forEmulation ? e.Value.Published : e.Value.Emulation)).Where<FormDescriptor>((Func<FormDescriptor, bool>) (d => d != null)).ToArray<FormDescriptor>();

      public FormDescriptorProvider.FormDescriptorEntry GetEntry(Guid uid)
      {
        int num = 1;
        FormDescriptorProvider.FormDescriptorEntry entry;
        while (true)
        {
          switch (num)
          {
            case 1:
              this._entries.TryGetValue(uid, out entry);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return entry;
      }

      internal static void IiPmOJfg603HViTRcixo() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static object NVMj7JfgHRAFvGQoHm7f(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static void r6X8GXfgAq3ftTLmgdD5([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

      internal static bool tmClxkfgwjubJKkyfUku() => FormDescriptorProvider.FormDescriptorCollection.teDnoyfgtKTyPaMENWov == null;

      internal static FormDescriptorProvider.FormDescriptorCollection xhNXCvfg4096fIt2mHWY() => (FormDescriptorProvider.FormDescriptorCollection) FormDescriptorProvider.FormDescriptorCollection.teDnoyfgtKTyPaMENWov;

      internal static object Vp9q5afg7DfBCFqeZGnI([In] object obj0) => (object) ((FormDescriptorProvider.FormDescriptorEntry) obj0).Published;

      internal static Guid YMweaqfgxbr1E70gykbA([In] object obj0) => ((FormDescriptor) obj0).Uid;

      internal static object lul5xHfg058xCyiBIkhX([In] object obj0) => (object) ((FormDescriptorProvider.FormDescriptorEntry) obj0).Emulation;

      internal static Guid rd7AM5fgmPHjg8i67HwH([In] object obj0) => ((FormDescriptorProvider.FormDescriptorEntry) obj0).Uid;

      internal static object q83kBmfgyvqKoDtboRUq([In] object obj0) => (object) ((FormDescriptorProvider.FormDescriptorEntry) obj0).Name;

      internal static object cFS9rqfgMBbA3EvUZAKG([In] object obj0) => (object) ((string) obj0).ToLower();

      internal static bool KbBTT5fgJbXlpN4SRKrr([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

      internal static void zdOkr5fg9UaoHsvZJNhP([In] object obj0, [In] object obj1) => Contract.ArgumentNotNullOrEmpty((string) obj0, (string) obj1);
    }
  }
}
