// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Mappings.PropertyMapService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Mappings.ReplaceUidsAtPropertyMapService;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Helpers;
using Iesi.Collections;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Mappings
{
  /// <summary>Сервис для маппинга свойств</summary>
  [Service]
  internal sealed class PropertyMapService : IPropertyMapService
  {
    /// <summary>Служба управления метаданными в режиме Runtime</summary>
    private readonly IMetadataRuntimeService metadataRuntimeService;
    private static PropertyMapService S6duK0hoVg54i8AivnIN;

    /// <summary>Конструктор</summary>
    /// <param name="metadataRuntimeService">Служба управления метаданными в режиме Runtime</param>
    public PropertyMapService(IMetadataRuntimeService metadataRuntimeService)
    {
      PropertyMapService.cEm9sQhoRClHhMViFhs5();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.metadataRuntimeService = metadataRuntimeService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public void Map(object objLeft, object objRight, PropertyMap map)
    {
      int num1 = 7;
      ReplaceUidAtPropertyMapServiceContext mapServiceContext;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_80;
          case 1:
            goto label_4;
          case 2:
            if (PropertyMapService.ahMJcghoXIMjQNaj19Uq((object) map.Items) != 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 3;
              continue;
            }
            goto label_68;
          case 3:
            mapServiceContext = (ReplaceUidAtPropertyMapServiceContext) PropertyMapService.hED5ShhoTL7ZOT9UqHvo(objLeft, objRight);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 1 : 1;
            continue;
          case 4:
            PropertyMapService.ex34fQhoKhg7DOPBF1bd((object) map, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1405642199));
            num1 = 2;
            continue;
          case 5:
            goto label_81;
          case 6:
            PropertyMapService.ex34fQhoKhg7DOPBF1bd(objRight, PropertyMapService.q1QeRDhoqJf8YTgHlG7t(277947046 - -1479185048 ^ 1756927670));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 4 : 4;
            continue;
          case 7:
            Contract.ArgumentNotNull(objLeft, z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 235997881));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 1 : 6;
            continue;
          default:
            goto label_76;
        }
      }
label_80:
      return;
label_81:
      return;
label_76:
      return;
label_4:
      try
      {
        ClassMetadata objectClassMetadata1 = this.GetObjectClassMetadata(objLeft);
        int num2 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
          num2 = 0;
        IEnumerable<IPropertyMetadata> propertiesFromMetadata1;
        ClassMetadata objectClassMetadata2;
        IEnumerable<IPropertyMetadata> propertiesFromMetadata2;
        List<PropertyMapItem>.Enumerator enumerator;
        while (true)
        {
          switch (num2)
          {
            case 1:
              propertiesFromMetadata1 = this.GetPropertiesFromMetadata(objectClassMetadata1);
              num2 = 4;
              continue;
            case 2:
              objectClassMetadata2 = this.GetObjectClassMetadata(objRight);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_11;
            case 4:
              propertiesFromMetadata2 = this.GetPropertiesFromMetadata(objectClassMetadata2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
              continue;
            default:
              enumerator = map.Items.GetEnumerator();
              num2 = 3;
              continue;
          }
        }
label_11:
        try
        {
label_51:
          if (enumerator.MoveNext())
            goto label_53;
          else
            goto label_52;
label_12:
          PropertyMetadata leftPropMetadata;
          IPropertyMetadata leftTp;
          object leftValue;
          IPropertyMetadata rightTp;
          int num3;
          while (true)
          {
            IEntity entity;
            object obj;
            IPropertyMetadata propertyMetadata;
            PropertyMapItem item;
            switch (num3)
            {
              case 1:
                if (!(rightTp is PropertyMetadata rightPropMd))
                {
                  num3 = 17;
                  continue;
                }
                goto case 4;
              case 2:
                if (rightTp is TablePartMetadata)
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 2 : 5;
                  continue;
                }
                goto case 1;
              case 3:
                obj = PropertyMapService.zbTeAVhoa8sj0qyPrEXl((object) entity, PropertyMapService.msV9lOhopTuXwkay6hrN((object) leftPropMetadata));
                goto label_64;
              case 4:
                leftPropMetadata = leftTp as PropertyMetadata;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 12 : 4;
                continue;
              case 5:
                goto label_35;
              case 6:
                if (leftValue != null)
                {
                  num3 = 11;
                  continue;
                }
                goto case 7;
              case 7:
                if (leftPropMetadata != null)
                {
                  num3 = 19;
                  continue;
                }
                goto label_51;
              case 8:
              case 15:
              case 16:
              case 17:
                goto label_51;
              case 9:
                obj = PropertyMapService.C4PEMnho3QJQw3VyqtNr((object) item);
                goto label_64;
              case 10:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                propertyMetadata = propertiesFromMetadata1.FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (p => PropertyMapService.\u003C\u003Ec__DisplayClass2_0.k6wiFPClSLhfv98K1hcp(PropertyMapService.\u003C\u003Ec__DisplayClass2_0.kvR6JSClIIbAef59DFZq((object) p), PropertyMapService.\u003C\u003Ec__DisplayClass2_0.uZEWQrClV3d5sPyS3unS((object) item))));
                break;
              case 11:
              case 19:
                num3 = 18;
                continue;
              case 12:
                entity = objLeft as IEntity;
                num3 = 27;
                continue;
              case 13:
                if (PropertyMapService.jEYlgdhokTRX2sSycJ1a((object) item) == Guid.Empty)
                {
                  num3 = 8;
                  continue;
                }
                goto case 24;
              case 14:
                goto label_73;
              case 18:
                goto label_17;
              case 20:
                propertyMetadata = (IPropertyMetadata) null;
                break;
              case 21:
                obj = this.GetPropertyValue(objLeft, PropertyMapService.msV9lOhopTuXwkay6hrN((object) leftPropMetadata));
                goto label_64;
              case 22:
                if (rightTp == null)
                {
                  num3 = 16;
                  continue;
                }
                goto case 26;
              case 23:
                item = enumerator.Current;
                num3 = 13;
                continue;
              case 24:
                if (PropertyMapService.sjNsvshoOtAZLE3TRDd5(PropertyMapService.t4A2bJhonmytmLyGlmhB((object) item), Guid.Empty))
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 4 : 10;
                  continue;
                }
                goto case 20;
              case 25:
                if (PropertyMapService.sSTOgohoN1DpE8sfXdZl((object) item))
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 24 : 29;
                  continue;
                }
                goto case 9;
              case 26:
                if (leftTp is TablePartMetadata)
                {
                  num3 = 2;
                  continue;
                }
                goto case 1;
              case 27:
                if (leftPropMetadata == null)
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 25 : 14;
                  continue;
                }
                if (entity == null)
                {
                  num3 = 21;
                  continue;
                }
                goto case 3;
              case 28:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                rightTp = propertiesFromMetadata2.FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (p => PropertyMapService.\u003C\u003Ec__DisplayClass2_0.k6wiFPClSLhfv98K1hcp(PropertyMapService.\u003C\u003Ec__DisplayClass2_0.kvR6JSClIIbAef59DFZq((object) p), item.RightPropertyUid)));
                num3 = 22;
                continue;
              case 29:
                obj = (object) entity;
                goto label_64;
              default:
                goto label_53;
            }
            leftTp = propertyMetadata;
            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 19 : 28;
            continue;
label_64:
            leftValue = obj;
            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 6 : 1;
          }
label_73:
          return;
label_17:
          try
          {
            this.MapProperty(objRight, rightPropMd, leftValue, leftPropMetadata);
            int num4 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
              num4 = 0;
            switch (num4)
            {
              default:
                goto label_51;
            }
          }
          catch (Exception ex)
          {
            int num5 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
              num5 = 0;
            while (true)
            {
              switch (num5)
              {
                case 1:
                  PropertyMapService.uSbxHZho1D5t4Nh76uD7(PropertyMapService.av70MfhoDGdOmqkDcumu(), PropertyMapService.SugC6dho4nkjIiqMETEC(PropertyMapService.q1QeRDhoqJf8YTgHlG7t(--1333735954 ^ 1333532182), leftPropMetadata == null ? PropertyMapService.BQ2hsThot30AOUQuqNjw(PropertyMapService.q1QeRDhoqJf8YTgHlG7t(1199946765 ^ 1200003157), leftValue, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123637310)) : PropertyMapService.K7Ux7ihowJQAnGJfs9nk(PropertyMapService.sJTlFwho2W1Lpxk4b5mv((object) objectClassMetadata1), PropertyMapService.q1QeRDhoqJf8YTgHlG7t(-882126494 ^ -882127962), PropertyMapService.sJTlFwho2W1Lpxk4b5mv((object) leftPropMetadata)), PropertyMapService.sJTlFwho2W1Lpxk4b5mv((object) objectClassMetadata2), PropertyMapService.W5qSlkhoeYHG0jwT14AX((object) rightTp)), (object) ex);
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_51;
              }
            }
          }
label_35:
          try
          {
            this.MapTablePart(objLeft, objRight, (TablePartMetadata) leftTp, (TablePartMetadata) rightTp, map);
            int num6 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
              num6 = 0;
            switch (num6)
            {
              default:
                goto label_51;
            }
          }
          catch (Exception ex)
          {
            int num7 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
              num7 = 0;
            while (true)
            {
              switch (num7)
              {
                case 1:
                  goto label_51;
                default:
                  PropertyMapService.uSbxHZho1D5t4Nh76uD7((object) Logger.Log, PropertyMapService.tJTptZhoPrji1QLiw9k9(PropertyMapService.q1QeRDhoqJf8YTgHlG7t(--1867379187 ^ 1867436629), (object) new object[4]
                  {
                    PropertyMapService.sJTlFwho2W1Lpxk4b5mv((object) objectClassMetadata1),
                    PropertyMapService.W5qSlkhoeYHG0jwT14AX((object) leftTp),
                    PropertyMapService.sJTlFwho2W1Lpxk4b5mv((object) objectClassMetadata2),
                    PropertyMapService.W5qSlkhoeYHG0jwT14AX((object) rightTp)
                  }), (object) ex);
                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 1 : 0;
                  continue;
              }
            }
          }
label_52:
          num3 = 14;
          goto label_12;
label_53:
          num3 = 23;
          goto label_12;
        }
        finally
        {
          enumerator.Dispose();
          int num8 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
            num8 = 0;
          switch (num8)
          {
            default:
          }
        }
      }
      finally
      {
        int num9;
        if (mapServiceContext == null)
          num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 0;
        else
          goto label_74;
label_72:
        switch (num9)
        {
          case 2:
            break;
          default:
        }
label_74:
        PropertyMapService.EbRpgGho6TWOE3mbfsjc((object) mapServiceContext);
        num9 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
        {
          num9 = 0;
          goto label_72;
        }
        else
          goto label_72;
      }
label_68:;
    }

    /// <summary>Выполнить маппинг блока</summary>
    /// <param name="objLeft">Объект-источник</param>
    /// <param name="objRight">Целевой объект</param>
    /// <param name="leftTp">Метаданные блока-источника</param>
    /// <param name="rightTp">Метаданные целевого блока</param>
    /// <param name="map">Карта свойств</param>
    public void MapTablePart(
      object objLeft,
      object objRight,
      TablePartMetadata leftTp,
      TablePartMetadata rightTp,
      PropertyMap map)
    {
      int num1 = 37;
      IEnumerator<IEntity> enumerator1;
      ISet set1;
      while (true)
      {
        int num2 = num1;
        IEntity entity1;
        Dictionary<Guid, IEntity> dictionary;
        IEnumerator enumerator2;
        Type type1;
        ISet set2;
        while (true)
        {
          IEntity entity2;
          PropertyInfo propertyInfo1;
          Type type2;
          PropertyInfo propertyInfo2;
          Type type3;
          Type type4;
          Type type5;
          object obj1;
          Type type6;
          object obj2;
          Type type7;
          List<IEntity> currentRightItems;
          switch (num2)
          {
            case 1:
              goto label_99;
            case 2:
              if (set2 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 24 : 12;
                continue;
              }
              // ISSUE: type reference
              type5 = set2.GetType().GetInterface(PropertyMapService.hbSrgEhoAui7eSQumWWB(__typeref (Iesi.Collections.Generic.ISet<>)).FullName);
              goto label_113;
            case 3:
              obj1 = this.GetPropertyValue(objRight, PropertyMapService.pBmCGUhoHDi50wjeKajr((object) rightTp));
              goto label_111;
            case 4:
              type6 = type1.GetGenericArguments()[0];
              goto label_119;
            case 5:
              goto label_6;
            case 6:
              if (entity2 != null)
              {
                num2 = 30;
                continue;
              }
              obj2 = this.GetPropertyValue(objLeft, leftTp.TablePartPropertyUid);
              break;
            case 7:
              goto label_121;
            case 8:
              goto label_37;
            case 9:
              dictionary = (Dictionary<Guid, IEntity>) null;
              num2 = 15;
              continue;
            case 10:
              goto label_21;
            case 11:
              try
              {
label_27:
                if (PropertyMapService.RUGYwaho94wuIriVdRwG((object) enumerator2))
                  goto label_24;
                else
                  goto label_28;
label_23:
                IEntity entity3;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      dictionary[(Guid) PropertyMapService.Lc59IJhoJxuF1Q6FdWS1((object) propertyInfo1, (object) entity3, (object) null)] = entity3;
                      num3 = 3;
                      continue;
                    case 2:
                      goto label_24;
                    case 3:
                      goto label_27;
                    default:
                      goto label_53;
                  }
                }
label_24:
                entity3 = (IEntity) PropertyMapService.rATkSihoMV25rBFVCgce((object) enumerator2);
                num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
                {
                  num3 = 1;
                  goto label_23;
                }
                else
                  goto label_23;
label_28:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
                goto label_23;
              }
              finally
              {
                IDisposable disposable = enumerator2 as IDisposable;
                int num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
                  num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      if (disposable == null)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 2 : 1;
                        continue;
                      }
                      break;
                    case 2:
                    case 3:
                      goto label_35;
                  }
                  PropertyMapService.EbRpgGho6TWOE3mbfsjc((object) disposable);
                  num4 = 3;
                }
label_35:;
              }
            case 12:
              try
              {
label_82:
                if (PropertyMapService.RUGYwaho94wuIriVdRwG((object) enumerator2))
                  goto label_72;
                else
                  goto label_83;
label_64:
                IEntity entity4;
                IEntity objLeft1;
                Guid guid;
                Guid? newUid;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      guid = Guid.Empty;
                      num5 = 16;
                      continue;
                    case 2:
                      dictionary.TryGetValue(guid, out entity4);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 3 : 1;
                      continue;
                    case 3:
                      if (entity4 == null)
                      {
                        num5 = 13;
                        continue;
                      }
                      goto case 11;
                    case 4:
                      goto label_72;
                    case 5:
                      entity4 = (IEntity) null;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 0;
                      continue;
                    case 6:
                      set1.Add((object) entity4);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 8 : 11;
                      continue;
                    case 7:
                      if (((IReplaceUidAtPropertyMapServiceExtension) PropertyMapService.EHPWhlhodg7JneS5BVR4()).GetUidReplace(guid, out newUid))
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 12 : 3;
                        continue;
                      }
                      goto case 2;
                    case 8:
                      goto label_82;
                    case 9:
                      goto label_46;
                    case 10:
                      guid = (Guid) PropertyMapService.Lc59IJhoJxuF1Q6FdWS1((object) propertyInfo2, (object) objLeft1, (object) null);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 7 : 6;
                      continue;
                    case 11:
                      currentRightItems.Add(entity4);
                      num5 = 14;
                      continue;
                    case 12:
                      guid = newUid.Value;
                      num5 = 2;
                      continue;
                    case 13:
                      entity4 = (IEntity) PropertyMapService.F0cEptholviSYDdqhGFu(type3);
                      num5 = 15;
                      continue;
                    case 14:
                      this.Map((object) objLeft1, (object) entity4, map);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 8 : 7;
                      continue;
                    case 15:
                      if (dictionary != null)
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
                        continue;
                      }
                      goto case 6;
                    case 16:
                      if (dictionary != null)
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 10 : 4;
                        continue;
                      }
                      goto case 3;
                    default:
                      PropertyMapService.yYmZQOhorHYMJYMEcFEY((object) propertyInfo1, (object) entity4, (object) guid, (object) null);
                      num5 = 6;
                      continue;
                  }
                }
label_72:
                objLeft1 = (IEntity) PropertyMapService.rATkSihoMV25rBFVCgce((object) enumerator2);
                num5 = 5;
                goto label_64;
label_83:
                num5 = 9;
                goto label_64;
              }
              finally
              {
                IDisposable disposable = enumerator2 as IDisposable;
                int num6 = 3;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                    case 2:
                      goto label_91;
                    case 3:
                      if (disposable == null)
                      {
                        num6 = 2;
                        continue;
                      }
                      break;
                  }
                  disposable.Dispose();
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 0;
                }
label_91:;
              }
            case 13:
              if (!PropertyMapService.k15NhuhoxQl6IxKGRwSK(type2, (Type) null))
              {
                num2 = 39;
                continue;
              }
              goto case 33;
            case 14:
              if (PropertyMapService.c5Z7suhom55NDSNeE6tT((object) propertyInfo1, (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 8 : 10;
                continue;
              }
              goto case 21;
            case 15:
              if (PropertyMapService.c5Z7suhom55NDSNeE6tT((object) propertyInfo2, (object) null))
              {
                num2 = 14;
                continue;
              }
              goto case 21;
            case 16:
label_46:
              if (dictionary == null)
              {
                num2 = 20;
                continue;
              }
              goto case 32;
            case 17:
              if (!PropertyMapService.KN0AE1ho7BF8hiMLoivU(type4, (Type) null))
              {
                num2 = 27;
                continue;
              }
              type7 = type4.GetGenericArguments()[0];
              goto label_117;
            case 18:
              if (entity1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 3 : 2;
                continue;
              }
              goto case 35;
            case 19:
              propertyInfo2 = (PropertyInfo) PropertyMapService.EteKu5ho0N8aebgMZpHW(type2, PropertyMapService.q1QeRDhoqJf8YTgHlG7t(1514961705 ^ 1514935483));
              num2 = 31;
              continue;
            case 20:
              goto label_41;
            case 21:
label_53:
              currentRightItems = new List<IEntity>();
              num2 = 28;
              continue;
            case 22:
              type6 = (Type) null;
              goto label_119;
            case 23:
              goto label_97;
            case 24:
              type5 = (Type) null;
              goto label_113;
            case 25:
              if (PropertyMapService.KN0AE1ho7BF8hiMLoivU(type1, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 4 : 4;
                continue;
              }
              goto case 22;
            case 26:
              goto label_104;
            case 27:
              type7 = (Type) null;
              goto label_117;
            case 28:
              goto label_57;
            case 29:
              goto label_114;
            case 30:
              obj2 = PropertyMapService.zbTeAVhoa8sj0qyPrEXl((object) entity2, PropertyMapService.pBmCGUhoHDi50wjeKajr((object) leftTp));
              break;
            case 31:
              propertyInfo1 = (PropertyInfo) PropertyMapService.EteKu5ho0N8aebgMZpHW(type3, PropertyMapService.q1QeRDhoqJf8YTgHlG7t(1142330761 ^ 1541959139 ^ 536778744));
              num2 = 9;
              continue;
            case 32:
              Dictionary<Guid, IEntity>.ValueCollection values = dictionary.Values;
              Func<IEntity, bool> func;
              Func<IEntity, bool> func1 = func;
              Func<IEntity, bool> predicate = func1 == null ? (func = (Func<IEntity, bool>) (i => !currentRightItems.Contains(i))) : func1;
              enumerator1 = values.Where<IEntity>(predicate).GetEnumerator();
              num2 = 5;
              continue;
            case 33:
            case 40:
              set1.Clear();
              num2 = 7;
              continue;
            case 34:
              goto label_62;
            case 35:
              obj1 = PropertyMapService.zbTeAVhoa8sj0qyPrEXl((object) entity1, PropertyMapService.pBmCGUhoHDi50wjeKajr((object) rightTp));
              goto label_111;
            case 36:
              entity2 = objLeft as IEntity;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 1;
              continue;
            case 37:
              num2 = 36;
              continue;
            case 38:
              goto label_100;
            case 39:
              if (!PropertyMapService.k15NhuhoxQl6IxKGRwSK(type3, (Type) null))
              {
                num2 = 19;
                continue;
              }
              goto case 33;
            case 41:
              if (set2 == null)
              {
                num2 = 40;
                continue;
              }
              goto case 13;
            default:
              if (set1 != null)
              {
                num2 = 41;
                continue;
              }
              goto label_92;
          }
          set2 = obj2 as ISet;
          num2 = 18;
          continue;
label_111:
          set1 = obj1 as ISet;
          num2 = 2;
          continue;
label_113:
          type4 = type5;
          num2 = 26;
          continue;
label_117:
          type2 = type7;
          num2 = 25;
          continue;
label_119:
          type3 = type6;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
        }
label_21:
        dictionary = new Dictionary<Guid, IEntity>();
        num1 = 23;
        continue;
label_37:
        Type type8 = (Type) null;
        goto label_115;
label_57:
        enumerator2 = (IEnumerator) PropertyMapService.HlVTHRhoyrfEkRhnIVCy((object) set2);
        num1 = 12;
        continue;
label_97:
        enumerator2 = (IEnumerator) PropertyMapService.HlVTHRhoyrfEkRhnIVCy((object) set1);
        num1 = 11;
        continue;
label_99:
        entity1 = objRight as IEntity;
        num1 = 6;
        continue;
label_104:
        if (set1 != null)
        {
          num1 = 29;
          continue;
        }
        goto label_37;
label_114:
        type8 = set1.GetType().GetInterface(typeof (Iesi.Collections.Generic.ISet<>).FullName);
label_115:
        type1 = type8;
        num1 = 17;
      }
label_121:
      return;
label_41:
      return;
label_62:
      return;
label_100:
      return;
label_6:
      try
      {
label_10:
        if (PropertyMapService.RUGYwaho94wuIriVdRwG((object) enumerator1))
          goto label_8;
        else
          goto label_11;
label_7:
        IEntity current;
        int num7;
        while (true)
        {
          switch (num7)
          {
            case 0:
              goto label_103;
            case 1:
              PropertyMapService.Nhw1Hohogafn52glC2rp((object) set1, (object) current);
              num7 = 3;
              continue;
            case 2:
              goto label_8;
            case 3:
              goto label_10;
            default:
              goto label_101;
          }
        }
label_103:
        return;
label_101:
        return;
label_8:
        current = enumerator1.Current;
        num7 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
        {
          num7 = 1;
          goto label_7;
        }
        else
          goto label_7;
label_11:
        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
        goto label_7;
      }
      finally
      {
        if (enumerator1 != null)
        {
          int num8 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
            num8 = 0;
          while (true)
          {
            switch (num8)
            {
              case 1:
                goto label_18;
              default:
                PropertyMapService.EbRpgGho6TWOE3mbfsjc((object) enumerator1);
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 0;
                continue;
            }
          }
        }
label_18:;
      }
label_92:;
    }

    /// <summary>Выполнить маппинг свойства</summary>
    /// <param name="objRight">Целевой объект</param>
    /// <param name="rightPropMd">Метаданные целевого свойства</param>
    /// <param name="leftValue">Значение свойства-источника</param>
    /// <param name="leftPropMetadata">Метаданные свойства-источника</param>
    public void MapProperty(
      object objRight,
      PropertyMetadata rightPropMd,
      object leftValue,
      PropertyMetadata leftPropMetadata)
    {
      int num1 = 2;
      ISet set;
      IEnumerator enumerator;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          IEntity entity;
          IEnumerable enumerable;
          object obj;
          switch (num2)
          {
            case 1:
              if (PropertyMapService.bwryYkhoY70LqNegDwDu((object) this.metadataRuntimeService, PropertyMapService.VS9QvSho5D87Jh5vTfi0((object) rightPropMd), PropertyMapService.rT9rN3hojBU4PgFRvBmu((object) rightPropMd)) is IConvertableTypeDescriptor convertableTypeDescriptor)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
                continue;
              }
              goto case 16;
            case 2:
              entity = objRight as IEntity;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 1;
              continue;
            case 3:
            case 8:
              if (leftValue != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 14 : 17;
                continue;
              }
              goto label_40;
            case 4:
              goto label_3;
            case 5:
              PropertyMapService.w4Qyr1hosxl2ULSgeMJY((object) entity, PropertyMapService.msV9lOhopTuXwkay6hrN((object) rightPropMd), leftValue);
              num2 = 4;
              continue;
            case 6:
              goto label_41;
            case 7:
              if (enumerable == null)
              {
                num2 = 3;
                continue;
              }
              goto case 10;
            case 9:
              goto label_9;
            case 10:
              enumerator = (IEnumerator) PropertyMapService.HlVTHRhoyrfEkRhnIVCy((object) enumerable);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 19 : 7;
              continue;
            case 11:
              enumerable = leftValue as IEnumerable;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 7 : 1;
              continue;
            case 12:
              if (set == null)
              {
                if (entity != null)
                {
                  num2 = 5;
                  continue;
                }
                goto case 15;
              }
              else
              {
                num2 = 18;
                continue;
              }
            case 13:
              obj = this.GetPropertyValue(objRight, PropertyMapService.msV9lOhopTuXwkay6hrN((object) rightPropMd));
              break;
            case 14:
              obj = PropertyMapService.zbTeAVhoa8sj0qyPrEXl((object) entity, PropertyMapService.msV9lOhopTuXwkay6hrN((object) rightPropMd));
              break;
            case 15:
              this.SetPropertyValue(objRight, PropertyMapService.msV9lOhopTuXwkay6hrN((object) rightPropMd), leftValue, leftPropMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 9;
              continue;
            case 16:
              if (entity == null)
              {
                num2 = 13;
                continue;
              }
              goto case 14;
            case 17:
              PropertyMapService.kfi3wXhoUhS7ZHJgqMg7((object) set, leftValue);
              num2 = 6;
              continue;
            case 18:
              goto label_32;
            case 19:
              goto label_10;
            default:
              leftValue = PropertyMapService.dvUpnDhoLL4L3PZhYGlV((object) convertableTypeDescriptor, leftValue, (object) rightPropMd);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 11 : 16;
              continue;
          }
          set = obj as ISet;
          num2 = 12;
        }
label_32:
        set.Clear();
        num1 = 11;
      }
label_3:
      return;
label_41:
      return;
label_9:
      return;
label_10:
      try
      {
label_15:
        if (PropertyMapService.RUGYwaho94wuIriVdRwG((object) enumerator))
          goto label_13;
        else
          goto label_16;
label_11:
        object current;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_21;
            case 1:
              goto label_15;
            case 2:
              PropertyMapService.kfi3wXhoUhS7ZHJgqMg7((object) set, current);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 1;
              continue;
            case 3:
              goto label_13;
            default:
              goto label_17;
          }
        }
label_21:
        return;
label_17:
        return;
label_13:
        current = enumerator.Current;
        num3 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
        {
          num3 = 0;
          goto label_11;
        }
        else
          goto label_11;
label_16:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
        goto label_11;
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
          num4 = 1;
        while (true)
        {
          switch (num4)
          {
            case 1:
              if (disposable != null)
              {
                num4 = 2;
                continue;
              }
              goto label_25;
            case 2:
              disposable.Dispose();
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
              continue;
            default:
              goto label_25;
          }
        }
label_25:;
      }
label_40:;
    }

    /// <summary>Возвращает метаданные класса для объекта</summary>
    /// <param name="obj">Объект</param>
    /// <returns>ClassMetadata</returns>
    private ClassMetadata GetObjectClassMetadata(object obj)
    {
      int num = 2;
      ClassMetadata objectClassMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (objectClassMetadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 3 : 3;
              continue;
            }
            goto label_5;
          case 2:
            objectClassMetadata = obj as ClassMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 1;
            continue;
          case 3:
            objectClassMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(obj.GetType());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return objectClassMetadata;
    }

    /// <summary>Возвращает список вложенных свойств</summary>
    /// <param name="metadata">Метаданные класса</param>
    /// <returns>Список свойств</returns>
    private IEnumerable<IPropertyMetadata> GetPropertiesFromMetadata(ClassMetadata metadata) => !(metadata is EntityMetadata) ? metadata.Properties.Cast<IPropertyMetadata>() : ((EntityMetadata) metadata).GetPropertiesAndTableParts();

    /// <summary>
    /// Получить PropertyInfo по уникальному идентификатору свойства
    /// </summary>
    /// <param name="inputObject"></param>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    /// <returns>PropertyInfo</returns>
    private PropertyInfo GetPropertyInfo(object inputObject, Guid propertyUid)
    {
      int num = 2;
      Pair<ClassMetadata, IPropertyMetadata> propertyMetadata;
      IPropertyMetadata second;
      while (true)
      {
        switch (num)
        {
          case 1:
            second = propertyMetadata.Second;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
            continue;
          case 2:
            propertyMetadata = this.GetPropertyMetadata(inputObject, propertyUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      object obj = PropertyMapService.EteKu5ho0N8aebgMZpHW(inputObject.GetType(), PropertyMapService.W5qSlkhoeYHG0jwT14AX((object) second));
      return !PropertyMapService.JqtuuyhocqYRC6iBZVoT(obj, (object) null) ? (PropertyInfo) obj : throw new EleWise.ELMA.Model.Metadata.MetadataException((string) PropertyMapService.nb93PHhbFLPUhKCaof7I((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372564057)), PropertyMapService.W5qSlkhoeYHG0jwT14AX((object) second), PropertyMapService.rTM5xthoz7bmEruEkI25((object) propertyMetadata.First)));
    }

    /// <summary>
    /// Получить PropertyInfo по уникальному идентификатору свойства
    /// </summary>
    /// <param name="inputObject"></param>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    /// <returns>PropertyInfo</returns>
    private Pair<ClassMetadata, IPropertyMetadata> GetPropertyMetadata(
      object inputObject,
      Guid propertyUid)
    {
      ClassMetadata first = (ClassMetadata) MetadataLoader.LoadMetadata(inputObject.GetType());
      if (first == null)
        throw new EleWise.ELMA.Model.Metadata.MetadataException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837868357), (object) inputObject.GetType().FullName));
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      IPropertyMetadata second = (IPropertyMetadata) first.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => PropertyMapService.\u003C\u003Ec__DisplayClass8_0.estPHfClOqIlspAouCMG(PropertyMapService.\u003C\u003Ec__DisplayClass8_0.XTBU3AClnUkGYsc7BN35((object) p), propertyUid)));
      if (second == null && first is EntityMetadata entityMetadata)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        second = (IPropertyMetadata) entityMetadata.TableParts.FirstOrDefault<TablePartMetadata>((Func<TablePartMetadata, bool>) (tp => PropertyMapService.\u003C\u003Ec__DisplayClass8_0.estPHfClOqIlspAouCMG(PropertyMapService.\u003C\u003Ec__DisplayClass8_0.IctvxvCl2PGuqPDXA1Te((object) tp), propertyUid)));
      }
      return second != null ? new Pair<ClassMetadata, IPropertyMetadata>(first, second) : throw new EleWise.ELMA.Model.Metadata.MetadataException(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420949448)), (object) propertyUid, (object) first.FullTypeName));
    }

    private object GetPropertyValue(object inputObject, Guid propertyUid) => PropertyMapService.Lc59IJhoJxuF1Q6FdWS1((object) this.GetPropertyInfo(inputObject, propertyUid), inputObject, (object) null);

    private void SetPropertyValue(
      object inputObject,
      Guid propertyUid,
      object value,
      PropertyMetadata leftPropMetadata)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        IConvertTypeMapper convertTypeMapper;
        PropertyMetadata leftPropMetadata1;
        Pair<ClassMetadata, IPropertyMetadata> md;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (convertTypeMapper != null)
              {
                num2 = 7;
                continue;
              }
              goto label_11;
            case 2:
              leftPropMetadata1 = leftPropMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
              continue;
            case 3:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 2 : 0;
              continue;
            case 4:
              goto label_11;
            case 5:
              goto label_3;
            case 6:
              convertTypeMapper = ((ComponentManager) PropertyMapService.S3jfWnhbBS3817uCqsGM()).GetExtensionPoints<IConvertTypeMapper>().FirstOrDefault<IConvertTypeMapper>((Func<IConvertTypeMapper, bool>) (c => c.RelativeConvertNeeded((IPropertyMetadata) leftPropMetadata1, md.Second)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 1;
              continue;
            case 7:
              goto label_4;
            default:
              md = this.GetPropertyMetadata(inputObject, propertyUid);
              num2 = 6;
              continue;
          }
        }
label_4:
        value = PropertyMapService.QF5lf5hbWjyuYJuaTFgJ((object) convertTypeMapper, value);
        num1 = 4;
        continue;
label_11:
        PropertyMapService.yYmZQOhorHYMJYMEcFEY((object) this.GetPropertyInfo(inputObject, propertyUid), inputObject, value, (object) null);
        num1 = 5;
      }
label_3:;
    }

    internal static void cEm9sQhoRClHhMViFhs5() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool sWVWCphoSc4QOHCYhf7q() => PropertyMapService.S6duK0hoVg54i8AivnIN == null;

    internal static PropertyMapService KR8CG4hoiakA9g6dqstC() => PropertyMapService.S6duK0hoVg54i8AivnIN;

    internal static object q1QeRDhoqJf8YTgHlG7t(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void ex34fQhoKhg7DOPBF1bd([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static int ahMJcghoXIMjQNaj19Uq([In] object obj0) => ((List<PropertyMapItem>) obj0).Count;

    internal static object hED5ShhoTL7ZOT9UqHvo([In] object obj0, [In] object obj1) => (object) ReplaceUidAtPropertyMapServiceContext.Extend(obj0, obj1);

    internal static Guid jEYlgdhokTRX2sSycJ1a([In] object obj0) => ((PropertyMapItem) obj0).RightPropertyUid;

    internal static Guid t4A2bJhonmytmLyGlmhB([In] object obj0) => ((PropertyMapItem) obj0).LeftPropertyUid;

    internal static bool sjNsvshoOtAZLE3TRDd5([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object sJTlFwho2W1Lpxk4b5mv([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object W5qSlkhoeYHG0jwT14AX([In] object obj0) => (object) ((IPropertyMetadata) obj0).Name;

    internal static object tJTptZhoPrji1QLiw9k9([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

    internal static void uSbxHZho1D5t4Nh76uD7([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static bool sSTOgohoN1DpE8sfXdZl([In] object obj0) => ((PropertyMapItem) obj0).ThisMarker;

    internal static object C4PEMnho3QJQw3VyqtNr([In] object obj0) => ((PropertyMapItem) obj0).LeftValue;

    internal static Guid msV9lOhopTuXwkay6hrN([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object zbTeAVhoa8sj0qyPrEXl([In] object obj0, Guid propertyUid) => ((IEntity) obj0).GetPropertyValue(propertyUid);

    internal static object av70MfhoDGdOmqkDcumu() => (object) Logger.Log;

    internal static object BQ2hsThot30AOUQuqNjw([In] object obj0, [In] object obj1, [In] object obj2) => (object) (obj0.ToString() + obj1 + obj2);

    internal static object K7Ux7ihowJQAnGJfs9nk([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object SugC6dho4nkjIiqMETEC(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static void EbRpgGho6TWOE3mbfsjc([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static Guid pBmCGUhoHDi50wjeKajr([In] object obj0) => ((TablePartMetadata) obj0).TablePartPropertyUid;

    internal static Type hbSrgEhoAui7eSQumWWB([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool KN0AE1ho7BF8hiMLoivU([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool k15NhuhoxQl6IxKGRwSK([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object EteKu5ho0N8aebgMZpHW(Type type, [In] object obj1) => (object) type.GetReflectionProperty((string) obj1);

    internal static bool c5Z7suhom55NDSNeE6tT([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 != (PropertyInfo) obj1;

    internal static object HlVTHRhoyrfEkRhnIVCy([In] object obj0) => (object) ((IEnumerable) obj0).GetEnumerator();

    internal static object rATkSihoMV25rBFVCgce([In] object obj0) => ((IEnumerator) obj0).Current;

    internal static object Lc59IJhoJxuF1Q6FdWS1([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static bool RUGYwaho94wuIriVdRwG([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static object EHPWhlhodg7JneS5BVR4() => (object) ReplaceUidAtPropertyMapServiceContext.Service;

    internal static object F0cEptholviSYDdqhGFu(Type t) => InterfaceActivator.Create(t);

    internal static void yYmZQOhorHYMJYMEcFEY([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static bool Nhw1Hohogafn52glC2rp([In] object obj0, [In] object obj1) => ((ISet) obj0).Remove(obj1);

    internal static Guid VS9QvSho5D87Jh5vTfi0([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static Guid rT9rN3hojBU4PgFRvBmu([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

    internal static object bwryYkhoY70LqNegDwDu([In] object obj0, Guid typeUid, Guid subTypeUid) => (object) ((IMetadataService) obj0).GetTypeDescriptor(typeUid, subTypeUid);

    internal static object dvUpnDhoLL4L3PZhYGlV([In] object obj0, [In] object obj1, [In] object obj2) => ((IConvertableTypeDescriptor) obj0).ConvertFrom(obj1, (PropertyMetadata) obj2);

    internal static bool kfi3wXhoUhS7ZHJgqMg7([In] object obj0, [In] object obj1) => ((ISet) obj0).Add(obj1);

    internal static void w4Qyr1hosxl2ULSgeMJY([In] object obj0, Guid propertyUid, [In] object obj2) => ((IEntity) obj0).SetPropertyValue(propertyUid, obj2);

    internal static bool JqtuuyhocqYRC6iBZVoT([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static object rTM5xthoz7bmEruEkI25([In] object obj0) => (object) ((ClassMetadata) obj0).FullTypeName;

    internal static object nb93PHhbFLPUhKCaof7I([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object S3jfWnhbBS3817uCqsGM() => (object) ComponentManager.Current;

    internal static object QF5lf5hbWjyuYJuaTFgJ([In] object obj0, [In] object obj1) => ((IConvertTypeMapper) obj0).Convert(obj1);
  }
}
