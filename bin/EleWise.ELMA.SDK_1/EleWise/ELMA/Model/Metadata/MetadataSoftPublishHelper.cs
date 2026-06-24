// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.MetadataSoftPublishHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>
  /// Помощник для "мягкой" публикации объектов метданных (после изменений, не требующих перезапуска сервера)
  /// </summary>
  /// <summary>
  /// Помощник для "мягкой" публикации объектов метданных (после изменений, не требующих перезапуска сервера)
  /// </summary>
  public static class MetadataSoftPublishHelper
  {
    internal static MetadataSoftPublishHelper lfB5lXbwn8aKsgMleV5m;

    /// <summary>
    /// Определить тип публикации при изменении объекта метаданных
    /// </summary>
    /// <param name="oldMetadata">Старые метаданные</param>
    /// <param name="newMetadata">Новые метаданные</param>
    /// <returns>Возможный тип публикации</returns>
    internal static PublicationType GetPublicationTypeOnChange(
      IMetadata oldMetadata,
      IMetadata newMetadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (newMetadata is IDeltaRootMetadata deltaRootMetadata)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return PublicationType.Restart;
label_3:
      return MetadataSoftPublishHelper.SbvKnGbwecdkQocg7TLw((object) deltaRootMetadata, (object) oldMetadata);
    }

    /// <summary>
    /// Определить тип публикации при создании объекта метаданных
    /// </summary>
    /// <param name="newMetadata">Новые метаданные</param>
    /// <returns>Возможный тип публикации</returns>
    internal static PublicationType GetPublicationTypeOnCreate(IMetadata newMetadata)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            goto label_9;
          case 3:
            if (!MetadataSoftPublishHelper.Cpes6qbwP24eOB4Wv4qB((object) (newMetadata as ClassMetadata)))
            {
              if (!(newMetadata is EntityMetadata entityMetadata))
              {
                num = 4;
                continue;
              }
              goto default;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 2;
              continue;
            }
          case 4:
            if (!MetadataSoftPublishHelper.Pd5lrebw7JRUMedpCLI1((object) newMetadata))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 1 : 1;
              continue;
            }
            goto label_5;
          case 5:
            goto label_6;
          default:
            if (entityMetadata.Type == EntityMetadataType.InterfaceExtension)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 5 : 5;
              continue;
            }
            goto case 4;
        }
      }
label_4:
      return PublicationType.Restart;
label_5:
      return PublicationType.Delta;
label_6:
      EntityMetadata entityMetadata1 = (EntityMetadata) MetadataSoftPublishHelper.veucLrbw1caO6s10eb7I(newMetadata.GetType());
      entityMetadata1.Type = entityMetadata.Type;
      entityMetadata1.Uid = entityMetadata.Uid;
      MetadataSoftPublishHelper.pDNnRrbwNTBdevDUL6qG((object) entityMetadata1, entityMetadata.BaseClassUid);
      MetadataSoftPublishHelper.xOnub5bwpX7TJEa4wDZ9((object) entityMetadata1, MetadataSoftPublishHelper.wKGeE2bw3r2Shbr38oc0((object) entityMetadata));
      MetadataSoftPublishHelper.Ci7mZ6bwDoFAnd3yV1Hm((object) entityMetadata1, MetadataSoftPublishHelper.x8jJwTbwaOvbxUhiC8OR((object) entityMetadata));
      MetadataSoftPublishHelper.nEY4ksbwtT6DJ83E1Wvi((object) entityMetadata1, (object) entityMetadata.DisplayName);
      entityMetadata1.Description = entityMetadata.Description;
      entityMetadata1.ImplementedExtensionUids = new List<Guid>();
      MetadataSoftPublishHelper.wsSqrFbw4pQtRhTlmXf5((object) entityMetadata1, MetadataSoftPublishHelper.P5G6libwwvNuuIRaXRso((object) entityMetadata));
      MetadataSoftPublishHelper.qFx12xbwH5mV9H7rWsxO((object) entityMetadata1, MetadataSoftPublishHelper.Bu41kVbw6fjwqDyE7YSU((object) entityMetadata));
      return MetadataSoftPublishHelper.HplEtdbwAUhv7VchUsBk((object) entityMetadata1, (object) newMetadata);
label_9:
      return PublicationType.Restart;
    }

    /// <summary>
    /// Скопировать изменения, не требующие перезапуска сервера, из элемента метаданных <paramref name="changed" /> в <paramref name="original" />
    /// </summary>
    /// <param name="original">Объект, в который будут записаны изменения</param>
    /// <param name="changed">Объект, из которого будут браться изменения</param>
    internal static void CopyChanges(IMetadata original, IMetadata changed)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            MetadataSoftPublishHelper.t12FWXbwxIP0cHStqqQR((object) original, (object) changed);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
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
    /// Проверить объект на возможность осуществления мягкой и/или дельта-публикации
    /// </summary>
    /// <param name="oldObject">Старое значение объекта</param>
    /// <param name="newObject">Новое значение объекта</param>
    /// <returns>Тип публикации</returns>
    public static PublicationType IsEqualsObject(object oldObject, object newObject)
    {
      int num1 = 3;
      PublicationType publicationType;
      List<PropertyInfo>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
          case 2:
          case 4:
            goto label_21;
          case 3:
            if (oldObject == null)
            {
              num1 = 2;
              continue;
            }
            goto case 5;
          case 5:
            if (newObject == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 1;
              continue;
            }
            goto case 7;
          case 6:
            goto label_20;
          case 7:
            if (MetadataSoftPublishHelper.V7TAiLbw0p9wWkfaglWw(oldObject.GetType(), newObject.GetType()))
            {
              num1 = 4;
              continue;
            }
            List<PropertyInfo> list = ((IEnumerable<PropertyInfo>) oldObject.GetType().GetProperties()).Where<PropertyInfo>((Func<PropertyInfo, bool>) (p =>
            {
              int num2 = 5;
              while (true)
              {
                int num3 = num2;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_11;
                    case 2:
                    case 4:
                      goto label_12;
                    case 3:
                      if (p.CanWrite)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_12;
                    case 5:
                      // ISSUE: reference to a compiler-generated method
                      if (!MetadataSoftPublishHelper.\u003C\u003Ec.nnNHRGCtxNZbXCCqB6XS((object) p))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 4;
                        continue;
                      }
                      goto case 3;
                    case 6:
                      // ISSUE: type reference
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (MetadataSoftPublishHelper.\u003C\u003Ec.xapi4LCtyXf5994DKS9F((object) p, MetadataSoftPublishHelper.\u003C\u003Ec.Wk7P7ZCtm99jXlSsaVCQ(__typeref (XmlIgnoreAttribute)), true))
                      {
                        num3 = 2;
                        continue;
                      }
                      goto label_11;
                    default:
                      goto label_9;
                  }
                }
label_9:
                // ISSUE: reference to a compiler-generated method
                if (MetadataSoftPublishHelper.\u003C\u003Ec.OYoSk4Ct0lLnkER7csYX((object) p).Length == 0)
                  num2 = 6;
                else
                  goto label_12;
              }
label_11:
              // ISSUE: type reference
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              return MetadataSoftPublishHelper.\u003C\u003Ec.xapi4LCtyXf5994DKS9F((object) p, MetadataSoftPublishHelper.\u003C\u003Ec.Wk7P7ZCtm99jXlSsaVCQ(__typeref (PublicationBehaviourAttribute)), true);
label_12:
              return false;
            })).ToList<PropertyInfo>();
            publicationType = PublicationType.Soft;
            enumerator = list.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      try
      {
label_8:
        if (enumerator.MoveNext())
          goto label_10;
        else
          goto label_9;
label_6:
        PublicationBehaviourAttribute attribute;
        object obj1;
        object obj2;
        int num4;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_8;
            case 2:
              goto label_20;
            case 3:
              goto label_10;
            default:
              publicationType |= MetadataSoftPublishHelper.hms9j1bwm00qYlCMoVZn((object) attribute, CheckType.Change, obj1, obj2);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 1 : 0;
              continue;
          }
        }
label_9:
        num4 = 2;
        goto label_6;
label_10:
        PropertyInfo current = enumerator.Current;
        attribute = AttributeHelper<PublicationBehaviourAttribute>.GetAttribute((MemberInfo) current, true);
        obj1 = current.GetValue(oldObject, (object[]) null);
        obj2 = current.GetValue(newObject, (object[]) null);
        num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
        {
          num4 = 0;
          goto label_6;
        }
        else
          goto label_6;
      }
      finally
      {
        enumerator.Dispose();
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
          num5 = 0;
        switch (num5)
        {
          default:
        }
      }
label_20:
      return publicationType;
label_21:
      return PublicationType.Restart;
    }

    /// <summary>
    /// Проверка нового свойства на возможность дельта-публикации
    /// </summary>
    /// <param name="value">Значение</param>
    /// <param name="type">Тип публикации</param>
    /// <returns><c>true</c> если дельта-публикация свойства возможна</returns>
    internal static bool IsNewValuesDelta(object value, PublicationType type)
    {
      int num1 = 15;
      while (true)
      {
        int num2 = num1;
        int num3;
        Type type1;
        Type type2;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 18:
              goto label_27;
            case 2:
              type1 = value.GetType();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 7 : 17;
              continue;
            case 3:
              // ISSUE: type reference
              if (!MetadataSoftPublishHelper.k0qBcQbwdBHKF9eQWXj4(type1, MetadataSoftPublishHelper.aGPSIvbwy3Y74JFFIJpU(__typeref (string))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 4 : 6;
                continue;
              }
              goto label_27;
            case 4:
              if (!TypeOf<IMetadata>.Raw.IsAssignableFrom(type2.GetGenericArguments()[0]))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
                continue;
              }
              goto case 13;
            case 5:
              goto label_5;
            case 6:
              goto label_28;
            case 7:
              if (!(value is IList source))
                goto case 2;
              else
                goto label_10;
            case 8:
              if (!MetadataSoftPublishHelper.V7TAiLbw0p9wWkfaglWw(type2, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 2 : 2;
                continue;
              }
              goto case 7;
            case 9:
              goto label_11;
            case 10:
              goto label_19;
            case 11:
            case 20:
              if (num3 < MetadataSoftPublishHelper.KasWEjbw9KcgawurNDl0((object) source))
              {
                num2 = 19;
                continue;
              }
              goto label_5;
            case 12:
            case 19:
              if (MetadataSoftPublishHelper.hmwGQQbwJavQUjxOqjtL(MetadataSoftPublishHelper.Q1oVfdbwMlemkmiSpSO0((object) source, num3), type))
              {
                ++num3;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 11 : 10;
                continue;
              }
              num2 = 16;
              continue;
            case 13:
              if (source.OfType<IMetadata>().Any<IMetadata>())
              {
                num2 = 10;
                continue;
              }
              goto label_5;
            case 14:
              goto label_13;
            case 15:
              if (value != null)
              {
                // ISSUE: type reference
                type2 = value.GetType().GetInterface(MetadataSoftPublishHelper.aGPSIvbwy3Y74JFFIJpU(__typeref (IList<>)).FullName);
                num2 = 8;
                continue;
              }
              num2 = 14;
              continue;
            case 16:
              goto label_21;
            case 17:
              if (!type1.IsClass)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 1;
                continue;
              }
              goto case 3;
            default:
              num3 = 0;
              num2 = 20;
              continue;
          }
        }
label_10:
        num1 = 4;
        continue;
label_19:
        if (type != PublicationType.Delta)
          num1 = 9;
        else
          break;
      }
label_5:
      return true;
label_11:
      return false;
label_13:
      return true;
label_21:
      return false;
label_27:
      return true;
label_28:
      return MetadataSoftPublishHelper.Pd5lrebw7JRUMedpCLI1(value);
    }

    /// <summary>
    /// Проверка нового объекта на возможность дельта-публикации
    /// </summary>
    /// <param name="value">Объект</param>
    /// <returns><c>true</c> если дельта-публикация возможна</returns>
    internal static bool IsNewObjectDelta(object value)
    {
      int num1 = 1;
      List<PropertyInfo>.Enumerator enumerator;
      PublicationType publicationType;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (value != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
              continue;
            }
            goto label_19;
          case 2:
            goto label_4;
          case 3:
            goto label_19;
          case 4:
            goto label_18;
          default:
            PropertyInfo[] properties = value.GetType().GetProperties();
            // ISSUE: reference to a compiler-generated field
            Func<PropertyInfo, bool> func = MetadataSoftPublishHelper.\u003C\u003Ec.\u003C\u003E9__5_0;
            Func<PropertyInfo, bool> predicate;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              MetadataSoftPublishHelper.\u003C\u003Ec.\u003C\u003E9__5_0 = predicate = (Func<PropertyInfo, bool>) (p =>
              {
                int num2 = 7;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                      if (p.GetIndexParameters().Length == 0)
                      {
                        num2 = 4;
                        continue;
                      }
                      goto label_5;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      if (!MetadataSoftPublishHelper.\u003C\u003Ec.G1uCA9CtMKLpKPK3lCbN((object) p))
                      {
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
                        continue;
                      }
                      goto case 1;
                    case 3:
                      goto label_4;
                    case 4:
                      // ISSUE: type reference
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (MetadataSoftPublishHelper.\u003C\u003Ec.xapi4LCtyXf5994DKS9F((object) p, MetadataSoftPublishHelper.\u003C\u003Ec.Wk7P7ZCtm99jXlSsaVCQ(__typeref (XmlIgnoreAttribute)), true))
                      {
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 5 : 4;
                        continue;
                      }
                      goto label_4;
                    case 7:
                      // ISSUE: reference to a compiler-generated method
                      if (!MetadataSoftPublishHelper.\u003C\u003Ec.nnNHRGCtxNZbXCCqB6XS((object) p))
                      {
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 1 : 6;
                        continue;
                      }
                      goto case 2;
                    default:
                      goto label_5;
                  }
                }
label_4:
                // ISSUE: type reference
                // ISSUE: reference to a compiler-generated method
                return p.IsDefined(MetadataSoftPublishHelper.\u003C\u003Ec.Wk7P7ZCtm99jXlSsaVCQ(__typeref (PublicationBehaviourAttribute)), true);
label_5:
                return false;
              });
            }
            else
              goto label_16;
label_22:
            List<PropertyInfo> list = ((IEnumerable<PropertyInfo>) properties).Where<PropertyInfo>(predicate).ToList<PropertyInfo>();
            publicationType = PublicationType.Soft;
            enumerator = list.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 2;
            continue;
label_16:
            predicate = func;
            goto label_22;
        }
      }
label_4:
      try
      {
label_8:
        if (enumerator.MoveNext())
          goto label_10;
        else
          goto label_9;
label_5:
        PropertyInfo current;
        DefaultValueAttribute attribute1;
        object obj;
        PublicationBehaviourAttribute attribute2;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_18;
            case 2:
              publicationType |= MetadataSoftPublishHelper.hms9j1bwm00qYlCMoVZn((object) attribute2, CheckType.Create, (attribute1 == null ? (object) null : attribute1.Value) ?? MetadataSoftPublishHelper.tdII1fbwge8Nt7wyeXtq(MetadataSoftPublishHelper.m8QHF9bwroMk8RqBmY6C((object) current)), obj);
              num3 = 5;
              continue;
            case 3:
              goto label_10;
            case 4:
              attribute1 = AttributeHelper<DefaultValueAttribute>.GetAttribute((MemberInfo) current, true);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
              continue;
            case 5:
              goto label_8;
            case 6:
              attribute2 = AttributeHelper<PublicationBehaviourAttribute>.GetAttribute((MemberInfo) current, true);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 4 : 4;
              continue;
            default:
              obj = MetadataSoftPublishHelper.mCcEBebwlswWJ34tcNKK((object) current, value, (object) null);
              num3 = 2;
              continue;
          }
        }
label_9:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 1;
        goto label_5;
label_10:
        current = enumerator.Current;
        num3 = 6;
        goto label_5;
      }
      finally
      {
        enumerator.Dispose();
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
          num4 = 0;
        switch (num4)
        {
          default:
        }
      }
label_18:
      return publicationType != PublicationType.Restart;
label_19:
      return false;
    }

    /// <summary>Получить униальный идентификатор объекта метаданных</summary>
    /// <param name="metadata">Объект метаданных</param>
    /// <returns>Уникальный идентификатор</returns>
    internal static Guid GetMetadataUid(IMetadata metadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (metadata != null)
            {
              if (metadata is TablePartMetadata tablePartMetadata)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 2 : 2;
                continue;
              }
              goto label_6;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
              continue;
            }
          case 2:
            goto label_5;
          default:
            goto label_2;
        }
      }
label_2:
      return Guid.Empty;
label_5:
      return tablePartMetadata.TablePartPropertyUid;
label_6:
      return MetadataSoftPublishHelper.tJmh4lbw5teG2GMWpkwc((object) metadata);
    }

    /// <summary>Скопировать изменения</summary>
    /// <param name="original">Объект, в который будут записаны изменения</param>
    /// <param name="changed">Объект, из которого будут браться изменения</param>
    private static void CopyChangesObject(object original, object changed)
    {
      int num1 = 2;
      List<PropertyInfo>.Enumerator enumerator;
      while (true)
      {
        Type type1;
        Type type2;
        switch (num1)
        {
          case 1:
            goto label_56;
          case 2:
            if (original == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 1 : 0;
              continue;
            }
            goto case 10;
          case 3:
            PropertyInfo[] properties = type1.GetProperties();
            // ISSUE: reference to a compiler-generated field
            Func<PropertyInfo, bool> func = MetadataSoftPublishHelper.\u003C\u003Ec.\u003C\u003E9__7_0;
            Func<PropertyInfo, bool> predicate;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              MetadataSoftPublishHelper.\u003C\u003Ec.\u003C\u003E9__7_0 = predicate = (Func<PropertyInfo, bool>) (p =>
              {
                int num2 = 5;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                    case 3:
                      goto label_3;
                    case 2:
                      goto label_2;
                    case 4:
                      // ISSUE: reference to a compiler-generated method
                      if (!MetadataSoftPublishHelper.\u003C\u003Ec.G1uCA9CtMKLpKPK3lCbN((object) p))
                      {
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 1 : 1;
                        continue;
                      }
                      break;
                    case 5:
                      // ISSUE: reference to a compiler-generated method
                      if (MetadataSoftPublishHelper.\u003C\u003Ec.nnNHRGCtxNZbXCCqB6XS((object) p))
                      {
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 4 : 3;
                        continue;
                      }
                      goto label_3;
                  }
                  // ISSUE: reference to a compiler-generated method
                  if (MetadataSoftPublishHelper.\u003C\u003Ec.OYoSk4Ct0lLnkER7csYX((object) p).Length != 0)
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 3 : 1;
                  else
                    break;
                }
label_2:
                // ISSUE: reference to a compiler-generated method
                return !MetadataSoftPublishHelper.\u003C\u003Ec.xapi4LCtyXf5994DKS9F((object) p, typeof (XmlIgnoreAttribute), true);
label_3:
                return false;
              });
            }
            else
              goto label_2;
label_58:
            enumerator = ((IEnumerable<PropertyInfo>) properties).Where<PropertyInfo>(predicate).ToList<PropertyInfo>().GetEnumerator();
            num1 = 4;
            continue;
label_2:
            predicate = func;
            goto label_58;
          case 4:
            goto label_17;
          case 5:
            goto label_9;
          case 6:
            goto label_50;
          case 7:
            if (!changed.GetType().IsInstanceOfType(original))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 8 : 7;
              continue;
            }
            type2 = changed.GetType();
            break;
          case 8:
            type2 = (Type) null;
            break;
          case 9:
            if (!MetadataSoftPublishHelper.k0qBcQbwdBHKF9eQWXj4(type1, (Type) null))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 3 : 1;
              continue;
            }
            goto label_39;
          case 10:
            if (changed != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
              continue;
            }
            goto label_49;
          case 11:
            goto label_47;
          case 12:
            if (original.GetType().IsInstanceOfType(changed))
            {
              type2 = original.GetType();
              break;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 3 : 7;
            continue;
          default:
            if (!MetadataSoftPublishHelper.k0qBcQbwdBHKF9eQWXj4(original.GetType(), changed.GetType()))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 12;
              continue;
            }
            type2 = original.GetType();
            break;
        }
        type1 = type2;
        num1 = 9;
      }
label_56:
      return;
label_9:
      return;
label_50:
      return;
label_47:
      return;
label_49:
      return;
label_17:
      try
      {
label_24:
        if (enumerator.MoveNext())
          goto label_21;
        else
          goto label_25;
label_18:
        int num3;
        int num4 = num3;
label_19:
        PropertyInfo current;
        object obj1;
        LocalizableAttribute attribute;
        object obj2;
        object obj3;
        while (true)
        {
          switch (num4)
          {
            case 1:
            case 18:
              goto label_24;
            case 2:
              MetadataSoftPublishHelper.fVYWYObwsC5iknvi5QXH(obj1, obj3);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 1 : 1;
              continue;
            case 3:
            case 12:
            case 15:
            case 16:
              MetadataSoftPublishHelper.oETQpDbwUuQKxRXETlHs((object) current, original, obj2, (object) null);
              num4 = 18;
              continue;
            case 4:
              obj3 = current.GetValue(changed, (object[]) null);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
              continue;
            case 5:
              if (!MetadataSoftPublishHelper.LQ5JaVbwYN1fUk0ugj4L((object) attribute))
              {
                num4 = 3;
                continue;
              }
              goto case 8;
            case 6:
              if (!(obj2 is string str))
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 11 : 16;
                continue;
              }
              goto label_38;
            case 7:
              obj2 = MetadataSoftPublishHelper.mCcEBebwlswWJ34tcNKK((object) current, changed, (object) null);
              num4 = 6;
              continue;
            case 8:
              obj2 = MetadataSoftPublishHelper.Q0cdCZbwLHUgL8OcR3dl((object) str);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 15 : 8;
              continue;
            case 9:
              if (attribute == null)
              {
                num4 = 12;
                continue;
              }
              goto case 5;
            case 10:
              goto label_43;
            case 11:
              if (obj3 != null)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 2 : 2;
                continue;
              }
              goto label_24;
            case 13:
            case 20:
              obj1 = MetadataSoftPublishHelper.mCcEBebwlswWJ34tcNKK((object) current, original, (object) null);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 4;
              continue;
            case 14:
              if (MetadataSoftPublishHelper.UE9fSEbwjGuLIyrZsTdy((object) current, typeof (PublicationBehaviourAttribute), true))
              {
                num4 = 20;
                continue;
              }
              goto case 7;
            case 17:
              goto label_38;
            case 19:
              goto label_21;
            default:
              if (obj1 != null)
              {
                num4 = 11;
                continue;
              }
              goto label_24;
          }
        }
label_43:
        return;
label_38:
        attribute = AttributeHelper<LocalizableAttribute>.GetAttribute((MemberInfo) current, true);
        num3 = 9;
        goto label_18;
label_21:
        current = enumerator.Current;
        num4 = 14;
        goto label_19;
label_25:
        num3 = 10;
        goto label_18;
      }
      finally
      {
        enumerator.Dispose();
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
          num5 = 0;
        switch (num5)
        {
          default:
        }
      }
label_39:;
    }

    /// <summary>Скопировать значение</summary>
    /// <param name="originalValue">Оригинальное значение</param>
    /// <param name="changedValue">Измененнное значение</param>
    private static void CopyValues(object originalValue, object changedValue)
    {
      int num1 = 32;
      Dictionary<Guid, IMetadata> dictionary;
      IEnumerator enumerator;
      while (true)
      {
        int num2 = num1;
        IList list;
        int index;
        object original;
        IList source;
        Type type1;
        object changed;
        Type type2;
        Type genericArgument;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_13;
            case 2:
            case 19:
            case 26:
              ++index;
              num2 = 5;
              continue;
            case 3:
              dictionary = source.OfType<IMetadata>().ToDictionary<IMetadata, Guid>(new Func<IMetadata, Guid>(MetadataSoftPublishHelper.GetMetadataUid));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 36 : 30;
              continue;
            case 4:
              // ISSUE: type reference
              if (genericArgument != MetadataSoftPublishHelper.aGPSIvbwy3Y74JFFIJpU(__typeref (string)))
              {
                num2 = 12;
                continue;
              }
              goto case 2;
            case 5:
            case 20:
              if (index >= MetadataSoftPublishHelper.KasWEjbw9KcgawurNDl0((object) list))
              {
                num2 = 24;
                continue;
              }
              goto label_3;
            case 6:
              if (!MetadataSoftPublishHelper.V7TAiLbw0p9wWkfaglWw(type1, typeof (string)))
              {
                num2 = 14;
                continue;
              }
              goto case 8;
            case 7:
              if (changed == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 12 : 26;
                continue;
              }
              goto case 21;
            case 8:
              MetadataSoftPublishHelper.t12FWXbwxIP0cHStqqQR(originalValue, changedValue);
              num2 = 9;
              continue;
            case 9:
              goto label_11;
            case 10:
              list = originalValue as IList;
              num2 = 18;
              continue;
            case 11:
              goto label_6;
            case 12:
              MetadataSoftPublishHelper.CopyChangesObject(original, changed);
              num2 = 19;
              continue;
            case 13:
              if (original == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 2 : 1;
                continue;
              }
              goto case 7;
            case 14:
              goto label_56;
            case 15:
            case 27:
            case 30:
              type1 = originalValue.GetType();
              num2 = 25;
              continue;
            case 16:
              if (MetadataSoftPublishHelper.KasWEjbw9KcgawurNDl0((object) list) == MetadataSoftPublishHelper.KasWEjbw9KcgawurNDl0((object) source))
              {
                index = 0;
                num2 = 20;
                continue;
              }
              num2 = 11;
              continue;
            case 17:
              if (source == null)
              {
                num2 = 30;
                continue;
              }
              goto case 22;
            case 18:
              source = changedValue as IList;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
              continue;
            case 21:
              if (genericArgument.IsClass)
              {
                num2 = 4;
                continue;
              }
              goto case 2;
            case 22:
              if (!MetadataSoftPublishHelper.V7TAiLbw0p9wWkfaglWw(type2, (Type) null))
              {
                num2 = 15;
                continue;
              }
              goto case 29;
            case 23:
              goto label_3;
            case 24:
              goto label_68;
            case 25:
              if (type1.IsClass)
              {
                num2 = 6;
                continue;
              }
              goto label_57;
            case 28:
              // ISSUE: type reference
              type2 = originalValue.GetType().GetInterface(MetadataSoftPublishHelper.aGPSIvbwy3Y74JFFIJpU(__typeref (IList<>)).FullName);
              num2 = 10;
              continue;
            case 29:
              genericArgument = type2.GetGenericArguments()[0];
              num2 = 34;
              continue;
            case 31:
              goto label_65;
            case 32:
              goto label_51;
            case 33:
              goto label_41;
            case 34:
              // ISSUE: type reference
              if (MetadataSoftPublishHelper.aGPSIvbwy3Y74JFFIJpU(__typeref (IMetadata)).IsAssignableFrom(genericArgument))
              {
                num2 = 3;
                continue;
              }
              goto case 16;
            case 35:
              changed = MetadataSoftPublishHelper.Q1oVfdbwMlemkmiSpSO0((object) source, index);
              num2 = 13;
              continue;
            case 36:
              enumerator = (IEnumerator) MetadataSoftPublishHelper.Go8t1YbwcyrmrFIupir5((object) list);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 0;
              continue;
            default:
              if (list == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 24 : 27;
                continue;
              }
              goto case 17;
          }
        }
label_3:
        original = list[index];
        num1 = 35;
        continue;
label_51:
        if (originalValue != null)
        {
          num1 = 31;
          continue;
        }
        goto label_55;
label_65:
        if (changedValue != null)
          num1 = 28;
        else
          goto label_50;
      }
label_11:
      return;
label_6:
      return;
label_56:
      return;
label_68:
      return;
label_41:
      return;
label_13:
      try
      {
label_20:
        if (enumerator.MoveNext())
          goto label_18;
        else
          goto label_21;
label_14:
        int num3;
        int num4 = num3;
label_15:
        IMetadata metadata1;
        IMetadata metadata2;
        while (true)
        {
          switch (num4)
          {
            case 1:
            case 3:
            case 5:
              goto label_20;
            case 2:
              MetadataSoftPublishHelper.t12FWXbwxIP0cHStqqQR((object) metadata1, (object) metadata2);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 1;
              continue;
            case 4:
              goto label_18;
            case 6:
              if (metadata1 != null)
                goto default;
              else
                goto label_24;
            case 7:
              goto label_62;
            default:
              if (!dictionary.TryGetValue(MetadataSoftPublishHelper.I0Iudqb4F0EZlx7Jst4p((object) metadata1), out metadata2))
              {
                num4 = 3;
                continue;
              }
              goto case 2;
          }
        }
label_62:
        return;
label_24:
        num3 = 5;
        goto label_14;
label_18:
        metadata1 = (IMetadata) MetadataSoftPublishHelper.x6dbYCbwzhCKBIc18K2h((object) enumerator);
        num4 = 4;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
        {
          num4 = 6;
          goto label_15;
        }
        else
          goto label_15;
label_21:
        num3 = 7;
        goto label_14;
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        int num5 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
          num5 = 0;
        while (true)
        {
          switch (num5)
          {
            case 1:
              if (disposable != null)
              {
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
                continue;
              }
              goto label_31;
            case 2:
              goto label_31;
            default:
              MetadataSoftPublishHelper.dyspilb4Bt72Hox3KSca((object) disposable);
              num5 = 2;
              continue;
          }
        }
label_31:;
      }
label_57:
      return;
label_55:
      return;
label_50:;
    }

    private static bool HasOverrideInCustomCode(object classMetadata)
    {
      int num1 = 9;
      SyntaxTree syntaxTree;
      IEnumerable<SyntaxNode> syntaxNodes;
      ClassMetadata classMetadata1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (string.IsNullOrEmpty((string) MetadataSoftPublishHelper.x8jJwTbwaOvbxUhiC8OR((object) classMetadata1)))
            {
              syntaxNodes = (IEnumerable<SyntaxNode>) new SyntaxNode[1]
              {
                (SyntaxNode) MetadataSoftPublishHelper.JxEHHmb4EQtOiIkaZCTf((object) syntaxTree, new CancellationToken())
              };
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 10 : 10;
            continue;
          case 2:
            if (!MetadataSoftPublishHelper.HvdjP8b4hLyfRjsVJ2pZ(MetadataSoftPublishHelper.BluEKib4b9IY5nMFN1Er((object) classMetadata1), Guid.Empty))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 4 : 6;
              continue;
            }
            goto label_2;
          case 3:
            if (MetadataSoftPublishHelper.PvE7krb4ofck2ur1MGKO(MetadataSoftPublishHelper.a7nfA4b4WCuZwIdK23AN((object) classMetadata1)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 4;
              continue;
            }
            goto case 2;
          case 4:
          case 5:
            goto label_2;
          case 6:
            syntaxTree = SyntaxFactory.ParseSyntaxTree(classMetadata1.CustomCode, (ParseOptions) null, "", (Encoding) MetadataSoftPublishHelper.KNvt2Nb4GvrPwBTXiM0Q(), (ImmutableDictionary<string, ReportDiagnostic>) null, new CancellationToken());
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 1;
            continue;
          case 7:
            if (classMetadata1 != null)
            {
              num1 = 3;
              continue;
            }
            goto label_2;
          case 8:
            classMetadata1 = (ClassMetadata) classMetadata;
            num1 = 7;
            continue;
          case 9:
            num1 = 8;
            continue;
          case 10:
            goto label_12;
          default:
            goto label_16;
        }
      }
label_2:
      return false;
label_12:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      IEnumerable<SyntaxNode> source1 = ((SyntaxNode) MetadataSoftPublishHelper.JxEHHmb4EQtOiIkaZCTf((object) syntaxTree, new CancellationToken())).ChildNodes().OfType<NamespaceDeclarationSyntax>().Where<NamespaceDeclarationSyntax>((Func<NamespaceDeclarationSyntax, bool>) (nd => MetadataSoftPublishHelper.\u003C\u003Ec__DisplayClass9_0.avTmNxCt5Lkgnd0wYGWr((object) MetadataSoftPublishHelper.\u003C\u003Ec__DisplayClass9_0.zWg0LgCtr7ESNBRdeSiG((object) nd).ToString(), MetadataSoftPublishHelper.\u003C\u003Ec__DisplayClass9_0.OhCdPSCtgvf15PIkkSsQ((object) classMetadata1)))).Cast<SyntaxNode>();
      goto label_17;
label_16:
      source1 = syntaxNodes;
label_17:
      Func<SyntaxNode, IEnumerable<ClassDeclarationSyntax>> selector = (Func<SyntaxNode, IEnumerable<ClassDeclarationSyntax>>) (n => n.ChildNodes().OfType<ClassDeclarationSyntax>().Where<ClassDeclarationSyntax>((Func<ClassDeclarationSyntax, bool>) (cd =>
      {
        int num2 = 1;
        SyntaxToken syntaxToken;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              syntaxToken = MetadataSoftPublishHelper.\u003C\u003Ec__DisplayClass9_0.hVit33CtjlBdy6xe6K1A((object) cd);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        // ISSUE: reference to a compiler-generated method
        return MetadataSoftPublishHelper.\u003C\u003Ec__DisplayClass9_0.avTmNxCt5Lkgnd0wYGWr((object) syntaxToken.ToString(), (object) classMetadata1.Name);
      })));
      IEnumerable<PropertyDeclarationSyntax> source2 = source1.SelectMany<SyntaxNode, ClassDeclarationSyntax>(selector).SelectMany<ClassDeclarationSyntax, PropertyDeclarationSyntax>((Func<ClassDeclarationSyntax, IEnumerable<PropertyDeclarationSyntax>>) (cd => cd.Members.OfType<PropertyDeclarationSyntax>()));
      // ISSUE: reference to a compiler-generated field
      Func<PropertyDeclarationSyntax, bool> func = MetadataSoftPublishHelper.\u003C\u003Ec.\u003C\u003E9__9_3;
      Func<PropertyDeclarationSyntax, bool> predicate;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        MetadataSoftPublishHelper.\u003C\u003Ec.\u003C\u003E9__9_3 = predicate = (Func<PropertyDeclarationSyntax, bool>) (p => MetadataSoftPublishHelper.\u003C\u003Ec.WEG6QUCtJwEViklcqIqu((object) p).Any<SyntaxToken>((Func<SyntaxToken, bool>) (t => (ushort) t.RawKind == (ushort) 8355)));
      }
      else
        goto label_18;
label_20:
      return source2.Any<PropertyDeclarationSyntax>(predicate);
label_18:
      predicate = func;
      goto label_20;
    }

    internal static PublicationType SbvKnGbwecdkQocg7TLw([In] object obj0, [In] object obj1) => ((IDeltaRootMetadata) obj0).GetPublicationTypeOnChange((IMetadata) obj1);

    internal static bool fDTBcQbwOP2008YweNXD() => MetadataSoftPublishHelper.lfB5lXbwn8aKsgMleV5m == null;

    internal static MetadataSoftPublishHelper FvCmP2bw2Ycbkp1yKJA6() => MetadataSoftPublishHelper.lfB5lXbwn8aKsgMleV5m;

    internal static bool Cpes6qbwP24eOB4Wv4qB([In] object obj0) => MetadataSoftPublishHelper.HasOverrideInCustomCode(obj0);

    internal static object veucLrbw1caO6s10eb7I([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static void pDNnRrbwNTBdevDUL6qG([In] object obj0, Guid value) => ((ClassMetadata) obj0).BaseClassUid = value;

    internal static object wKGeE2bw3r2Shbr38oc0([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static void xOnub5bwpX7TJEa4wDZ9([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).Name = (string) obj1;

    internal static object x8jJwTbwaOvbxUhiC8OR([In] object obj0) => (object) ((ClassMetadata) obj0).Namespace;

    internal static void Ci7mZ6bwDoFAnd3yV1Hm([In] object obj0, [In] object obj1) => ((ClassMetadata) obj0).Namespace = (string) obj1;

    internal static void nEY4ksbwtT6DJ83E1Wvi([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).DisplayName = (string) obj1;

    internal static bool P5G6libwwvNuuIRaXRso([In] object obj0) => ((EntityMetadata) obj0).SaveHistory;

    internal static void wsSqrFbw4pQtRhTlmXf5([In] object obj0, bool value) => ((EntityMetadata) obj0).SaveHistory = value;

    internal static object Bu41kVbw6fjwqDyE7YSU([In] object obj0) => (object) ((EntityMetadata) obj0).Actions;

    internal static void qFx12xbwH5mV9H7rWsxO([In] object obj0, [In] object obj1) => ((EntityMetadata) obj0).Actions = (EntityActionsMetadata) obj1;

    internal static PublicationType HplEtdbwAUhv7VchUsBk([In] object obj0, [In] object obj1) => MetadataSoftPublishHelper.GetPublicationTypeOnChange((IMetadata) obj0, (IMetadata) obj1);

    internal static bool Pd5lrebw7JRUMedpCLI1([In] object obj0) => MetadataSoftPublishHelper.IsNewObjectDelta(obj0);

    internal static void t12FWXbwxIP0cHStqqQR([In] object obj0, [In] object obj1) => MetadataSoftPublishHelper.CopyChangesObject(obj0, obj1);

    internal static bool V7TAiLbw0p9wWkfaglWw([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static PublicationType hms9j1bwm00qYlCMoVZn(
      [In] object obj0,
      CheckType checkType,
      [In] object obj2,
      [In] object obj3)
    {
      return ((PublicationBehaviourAttribute) obj0).CheckProperty(checkType, obj2, obj3);
    }

    internal static Type aGPSIvbwy3Y74JFFIJpU([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object Q1oVfdbwMlemkmiSpSO0([In] object obj0, [In] int obj1) => ((IList) obj0)[obj1];

    internal static bool hmwGQQbwJavQUjxOqjtL([In] object obj0, PublicationType type) => MetadataSoftPublishHelper.IsNewValuesDelta(obj0, type);

    internal static int KasWEjbw9KcgawurNDl0([In] object obj0) => ((ICollection) obj0).Count;

    internal static bool k0qBcQbwdBHKF9eQWXj4([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object mCcEBebwlswWJ34tcNKK([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static Type m8QHF9bwroMk8RqBmY6C([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static object tdII1fbwge8Nt7wyeXtq(Type type) => type.DefaultValue();

    internal static Guid tJmh4lbw5teG2GMWpkwc([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static bool UE9fSEbwjGuLIyrZsTdy([In] object obj0, [In] Type obj1, [In] bool obj2) => ((MemberInfo) obj0).IsDefined(obj1, obj2);

    internal static bool LQ5JaVbwYN1fUk0ugj4L([In] object obj0) => ((LocalizableAttribute) obj0).IsLocalizable;

    internal static object Q0cdCZbwLHUgL8OcR3dl([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void oETQpDbwUuQKxRXETlHs([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static void fVYWYObwsC5iknvi5QXH([In] object obj0, [In] object obj1) => MetadataSoftPublishHelper.CopyValues(obj0, obj1);

    internal static object Go8t1YbwcyrmrFIupir5([In] object obj0) => (object) ((IEnumerable) obj0).GetEnumerator();

    internal static object x6dbYCbwzhCKBIc18K2h([In] object obj0) => ((IEnumerator) obj0).Current;

    internal static Guid I0Iudqb4F0EZlx7Jst4p([In] object obj0) => MetadataSoftPublishHelper.GetMetadataUid((IMetadata) obj0);

    internal static void dyspilb4Bt72Hox3KSca([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object a7nfA4b4WCuZwIdK23AN([In] object obj0) => (object) ((ClassMetadata) obj0).CustomCode;

    internal static bool PvE7krb4ofck2ur1MGKO([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static Guid BluEKib4b9IY5nMFN1Er([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

    internal static bool HvdjP8b4hLyfRjsVJ2pZ([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object KNvt2Nb4GvrPwBTXiM0Q() => (object) Encoding.UTF8;

    internal static object JxEHHmb4EQtOiIkaZCTf([In] object obj0, [In] CancellationToken obj1) => (object) ((SyntaxTree) obj0).GetRoot(obj1);
  }
}
