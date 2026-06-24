// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Common.ModelHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.References;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EleWise.ELMA.Model.Common
{
  /// <summary>Класс-помощник для рендеринга моделей ELMA</summary>
  public static class ModelHelper
  {
    public const string FIELD_ENTITY_NAME = "_Name";
    public const string FIELD_ENTITY_SELECTOR = "_Selector";
    private static readonly Dictionary<string, EleWise.ELMA.SR.LocalizableString> loadedFullNamespaces;
    private static readonly Dictionary<string, string> loadedShortNamespaces;
    private static readonly Dictionary<string, EleWise.ELMA.SR.LocalizableString> loadedNamespaces;
    private static Func<Type, IEntityManager> getEntityManagerCached;
    internal static ModelHelper KI2iKrhXSKKubdRfk8gZ;

    /// <summary>
    /// Получить строку из идентификатора типа и подтипа с разделителем
    /// </summary>
    /// <param name="reference">Ссылка на тип</param>
    /// <param name="delimeter">Разделитель</param>
    /// <returns></returns>
    public static string GetTypeAndSubTypeWithDelimeterString(
      this ReferenceOnType reference,
      string delimeter = ";")
    {
      return string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643687857), (object) reference.TypeUid, (object) delimeter, (object) reference.SubTypeUid);
    }

    /// <summary>Получить дескриптор типа</summary>
    /// <param name="reference">Ссылка на тип</param>
    /// <param name="includeSubTypes">Включая подтипы</param>
    /// <returns>Дескриптор типа</returns>
    public static ITypeDescriptor GetTypeDescriptor(
      this ReferenceOnType reference,
      bool includeSubTypes = true)
    {
      int num1 = 4;
      ITypeDescriptor typeDescriptor1;
      IEnumerator<ITypeDescriptor> enumerator;
      while (true)
      {
        int num2;
        switch (num1)
        {
          case 1:
          case 9:
            typeDescriptor1 = (ITypeDescriptor) ModelHelper.LXPt6mhXTvfehNMKig7F((object) MetadataServiceContext.MetadataRuntimeService, ModelHelper.Cl3IHvhXquP38jpwJT9n((object) reference), ModelHelper.NIJYkmhXXVCmJNhJlfOF((object) reference));
            num1 = 8;
            continue;
          case 2:
            num2 = typeDescriptor1 != null ? 1 : 0;
            break;
          case 3:
            if (ModelHelper.fwnJ6HhXK2aZUKrgw2FN(ModelHelper.Cl3IHvhXquP38jpwJT9n((object) reference), Guid.Empty))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 8 : 9;
              continue;
            }
            goto case 7;
          case 4:
            if (reference != null)
            {
              num1 = 3;
              continue;
            }
            goto label_5;
          case 5:
            goto label_10;
          case 6:
            goto label_4;
          case 7:
            if (ModelHelper.fwnJ6HhXK2aZUKrgw2FN(ModelHelper.NIJYkmhXXVCmJNhJlfOF((object) reference), Guid.Empty))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 1;
              continue;
            }
            goto label_5;
          case 8:
            if (ModelHelper.fwnJ6HhXK2aZUKrgw2FN(ModelHelper.NIJYkmhXXVCmJNhJlfOF((object) reference), Guid.Empty))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 2 : 0;
              continue;
            }
            num2 = 0;
            break;
          default:
            enumerator = typeDescriptor1.GetSubTypes((ClassMetadata) null).GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 5 : 5;
            continue;
        }
        int num3 = includeSubTypes ? 1 : 0;
        if ((num2 & num3) != 0)
          num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
        else
          break;
      }
label_4:
      return typeDescriptor1;
label_5:
      return (ITypeDescriptor) null;
label_10:
      ITypeDescriptor typeDescriptor2;
      try
      {
label_15:
        if (ModelHelper.IISjOkhXkKCyPJnXCps1((object) enumerator))
          goto label_17;
        else
          goto label_16;
label_11:
        ITypeDescriptor subTypes;
        ITypeDescriptor current;
        int num4;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_17;
            case 3:
              subTypes = ModelHelper.FindSubTypes(ModelHelper.Cl3IHvhXquP38jpwJT9n((object) reference), ModelHelper.NIJYkmhXXVCmJNhJlfOF((object) reference), current.GetSubTypes((ClassMetadata) null));
              num4 = 6;
              continue;
            case 4:
              goto label_6;
            case 5:
              goto label_4;
            case 6:
              if (subTypes == null)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 2 : 2;
                continue;
              }
              goto case 7;
            case 7:
              typeDescriptor2 = subTypes;
              num4 = 4;
              continue;
            default:
              goto label_15;
          }
        }
label_16:
        num4 = 5;
        goto label_11;
label_17:
        current = enumerator.Current;
        num4 = 3;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
        {
          num4 = 0;
          goto label_11;
        }
        else
          goto label_11;
      }
      finally
      {
        int num5;
        if (enumerator == null)
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
        else
          goto label_23;
label_22:
        switch (num5)
        {
          case 1:
            break;
          default:
        }
label_23:
        ModelHelper.ilquUJhXn3sqYSHLmncf((object) enumerator);
        num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
        {
          num5 = 2;
          goto label_22;
        }
        else
          goto label_22;
      }
label_6:
      return typeDescriptor2;
    }

    private static ITypeDescriptor FindSubTypes(
      Guid uid,
      Guid subTypeUid,
      IEnumerable<ITypeDescriptor> subTypes)
    {
      if (subTypes != null)
      {
        ITypeDescriptor subTypes1 = subTypes.FirstOrDefault<ITypeDescriptor>((Func<ITypeDescriptor, bool>) (t =>
        {
          int num = 2;
          Guid guid;
          while (true)
          {
            switch (num)
            {
              case 1:
                if (guid.Equals(uid))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
                  continue;
                }
                goto label_6;
              case 2:
                // ISSUE: reference to a compiler-generated method
                guid = ModelHelper.\u003C\u003Ec__DisplayClass2_0.CKTvj9vhSWXDakYJnXvv((object) t);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 1;
                continue;
              case 3:
                goto label_5;
              default:
                // ISSUE: reference to a compiler-generated method
                guid = ModelHelper.\u003C\u003Ec__DisplayClass2_0.iDpAwkvhidPfs5xtLo2K((object) t);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 3 : 1;
                continue;
            }
          }
label_5:
          return guid.Equals(subTypeUid);
label_6:
          return false;
        }));
        if (subTypes1 != null)
          return subTypes1;
        // ISSUE: reference to a compiler-generated method
        foreach (ITypeDescriptor typeDescriptor in subTypes.Where<ITypeDescriptor>((Func<ITypeDescriptor, bool>) (t => ModelHelper.\u003C\u003Ec.OvtKgLvhT3yQ1aw0Qnow((object) t))))
        {
          ITypeDescriptor subTypes2 = ModelHelper.FindSubTypes(uid, subTypeUid, typeDescriptor.GetSubTypes((ClassMetadata) null));
          if (subTypes2 != null)
            return subTypes2;
        }
      }
      return (ITypeDescriptor) null;
    }

    /// <summary>Получить инфрмацию о типе</summary>
    /// <param name="type">Тип</param>
    /// <param name="loadImplementation">Устанавливать подтип реализации</param>
    /// <returns>Инфрмация о типе</returns>
    public static TypeHeaderInfo GetTypeInfoByTypeOrNull(Type type, bool loadImplementation = false)
    {
      int num1 = 62;
      TypeHeaderInfo infoByTypeOrNull1;
      while (true)
      {
        int num2 = num1;
        Type type1;
        ActionSettings actionSettings;
        Type type2;
        PropertySignature propertySignature;
        ITypeDescriptor typeDescriptor1;
        Type genericArgument;
        Type[] genericArguments;
        IMetadataService metadataService;
        IMetadataService serviceOrNull1;
        ImplementationUidAttribute attribute1;
        Type type3;
        ITypeDescriptor typeDescriptor2;
        IMetadataService serviceOrNull2;
        UidAttribute attribute2;
        ITypeDescriptor typeDescriptor3;
        UidAttribute attribute3;
        ImplementationUidAttribute attribute4;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 76:
              attribute2 = AttributeHelper<UidAttribute>.GetAttribute(type, true);
              num2 = 43;
              continue;
            case 2:
              if (ModelHelper.KSJpbChXmTFdKvlJjEJE(type3, (object) actionSettings))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 104;
                continue;
              }
              goto label_27;
            case 3:
            case 7:
              if (TypeOf<IDataClass>.Raw.IsAssignableFrom(type))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 59 : 66;
                continue;
              }
              goto label_22;
            case 4:
              TypeHeaderInfo typeHeaderInfo1 = infoByTypeOrNull1;
              DataClassSettings dataClassSettings = new DataClassSettings();
              ModelHelper.UJDxlYhX60cCtCOt5Tfq((object) dataClassSettings, RelationType.OneToMany);
              ModelHelper.tRWLAMhXwGdy2bpbYZvp((object) typeHeaderInfo1, (object) dataClassSettings);
              num2 = 67;
              continue;
            case 5:
              goto label_106;
            case 6:
            case 107:
              // ISSUE: type reference
              if (!ModelHelper.IiSau9hX2d1jtaCyZLq1(type.GetInterface(ModelHelper.LqAwZthXOJ2MuuuG2isf(__typeref (IEntity)).FullName), (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 78 : 38;
                continue;
              }
              goto case 122;
            case 8:
              // ISSUE: type reference
              if (ModelHelper.xY4gVbhXp8dO8XLCgQ8m(type, ModelHelper.LqAwZthXOJ2MuuuG2isf(__typeref (object))))
              {
                num2 = 36;
                continue;
              }
              typeDescriptor1 = (ITypeDescriptor) ModelHelper.MXiFEvhXD2hjJdq1gPma((object) metadataService, type);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 25 : 92;
              continue;
            case 9:
              attribute3 = AttributeHelper<UidAttribute>.GetAttribute(genericArgument, true);
              num2 = 15;
              continue;
            case 10:
              ModelHelper.GcTMTohXeugv0IGOmUVD((object) infoByTypeOrNull1, ModelHelper.cAAs4KhXtfGPJa9lnHVQ((object) typeDescriptor1));
              num2 = 42;
              continue;
            case 11:
              ModelHelper.qPs4HIhX1HRCevNe4Cbt((object) infoByTypeOrNull1, attribute4 == null ? Guid.Empty : ModelHelper.YnVTj6hXPSgrLchJ3PTw((object) attribute4));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
              continue;
            case 12:
              if (type.GetGenericArguments().Length == 1)
              {
                num2 = 40;
                continue;
              }
              goto case 59;
            case 13:
              ModelHelper.tRWLAMhXwGdy2bpbYZvp((object) infoByTypeOrNull1, (object) actionSettings);
              num2 = 97;
              continue;
            case 14:
              infoByTypeOrNull1.Nullable = type.GetGenericArguments().Length == 1 && ModelHelper.xY4gVbhXp8dO8XLCgQ8m(type.GetGenericTypeDefinition(), typeof (Nullable<>));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 51 : 2;
              continue;
            case 15:
              goto label_139;
            case 16:
              genericArguments = type.GetGenericArguments();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 72 : 62;
              continue;
            case 17:
            case 37:
            case 90:
              if (!type.IsEnum)
              {
                num2 = 80;
                continue;
              }
              goto case 21;
            case 18:
              if (!ModelHelper.MrrJ0ihX0wSDlx2ROuSU(type2))
              {
                PropertyMetadata propertyMetadata = new PropertyMetadata();
                TypeHeaderInfo infoByTypeOrNull2 = ModelHelper.GetTypeInfoByTypeOrNull(type2);
                ModelHelper.LcYc2hhXMGqxmuUWJvGC((object) propertyMetadata, ModelHelper.khxIG2hXyRwIe00u3VE1((object) infoByTypeOrNull2));
                ModelHelper.oXVAxthX9VE49EHDtjiq((object) propertyMetadata, ModelHelper.rnL6RyhXJDup3U0EZOKl((object) infoByTypeOrNull2));
                ModelHelper.iw6FfGhXlukIc96OVHbR((object) propertyMetadata, ModelHelper.DQP8GqhXd6nXJ0EvRu7M((object) infoByTypeOrNull2));
                ModelHelper.vTAGd0hXgsgGq32Z2QKO((object) propertyMetadata, ModelHelper.D4eIqfhXro9a0Vf9iKJg((object) infoByTypeOrNull2));
                propertySignature = (PropertySignature) ModelHelper.qHQ3WjhX5bugmGJUrXMQ((object) propertyMetadata);
                num2 = 91;
                continue;
              }
              num2 = 46;
              continue;
            case 19:
              ModelHelper.tRWLAMhXwGdy2bpbYZvp((object) infoByTypeOrNull1, (object) new DataClassSettings()
              {
                RelationType = RelationType.OneToOne
              });
              num2 = 86;
              continue;
            case 20:
              typeDescriptor2 = (ITypeDescriptor) ModelHelper.MXiFEvhXD2hjJdq1gPma((object) serviceOrNull2, genericArgument);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 54 : 42;
              continue;
            case 21:
              ModelHelper.GcTMTohXeugv0IGOmUVD((object) infoByTypeOrNull1, EnumDescriptor.UID);
              num2 = 74;
              continue;
            case 22:
              ModelHelper.Ca2hvKhX7MrMXZn0mKov((object) infoByTypeOrNull1, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 50 : 65;
              continue;
            case 23:
              serviceOrNull1 = MetadataServiceContext.ServiceOrNull;
              num2 = 79;
              continue;
            case 24:
              metadataService = (IMetadataService) ModelHelper.TvBv2PhXUfOSMwXvFjNt();
              num2 = 53;
              continue;
            case 25:
              if (ModelHelper.rbMJNrhXa8hmQGhSafVR(genericArgument))
              {
                num2 = 96;
                continue;
              }
              goto case 38;
            case 26:
              ModelHelper.qPs4HIhX1HRCevNe4Cbt((object) infoByTypeOrNull1, ModelHelper.y8yskkhXA7NaX52bobAJ(type));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 114 : 67;
              continue;
            case 27:
            case 51:
            case 65:
            case 67:
            case 68:
            case 77:
            case 86:
            case 89:
            case 94:
            case 97:
            case 106:
            case 109:
            case 119:
              goto label_22;
            case 28:
              if (genericArguments.Length != 2)
              {
                num2 = 85;
                continue;
              }
              goto case 56;
            case 29:
              infoByTypeOrNull1.SubTypeUid = ModelHelper.VWqCtthX4InYDPFoi5mw(genericArgument);
              num2 = 4;
              continue;
            case 30:
              serviceOrNull2 = MetadataServiceContext.ServiceOrNull;
              num2 = 31;
              continue;
            case 31:
              if (serviceOrNull2 == null)
              {
                num2 = 109;
                continue;
              }
              goto case 20;
            case 32:
            case 80:
              if (type.GetGenericArguments().Length == 1)
              {
                num2 = 33;
                continue;
              }
              goto case 103;
            case 33:
              // ISSUE: type reference
              if (!ModelHelper.xY4gVbhXp8dO8XLCgQ8m(type.GetGenericTypeDefinition(), ModelHelper.LqAwZthXOJ2MuuuG2isf(__typeref (Nullable<>))))
              {
                num2 = 103;
                continue;
              }
              goto case 98;
            case 34:
              genericArgument = type1.GetGenericArguments()[0];
              num2 = 44;
              continue;
            case 35:
              if (!ModelHelper.XDJ6BuhXLmeMNscpYLvx())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 64 : 119;
                continue;
              }
              goto case 24;
            case 36:
              ModelHelper.GcTMTohXeugv0IGOmUVD((object) infoByTypeOrNull1, AnyTypeDescriptor.UID);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 8 : 101;
              continue;
            case 38:
            case 113:
              if (!TypeOf<IDataClass>.Raw.IsAssignableFrom(genericArgument))
              {
                num2 = 57;
                continue;
              }
              goto case 75;
            case 39:
            case 57:
              ModelHelper.GcTMTohXeugv0IGOmUVD((object) infoByTypeOrNull1, EntityDescriptor.UID);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 3 : 45;
              continue;
            case 40:
              if (!ModelHelper.xY4gVbhXp8dO8XLCgQ8m(type.GetGenericTypeDefinition(), typeof (ICollection<>)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 23 : 63;
                continue;
              }
              goto case 69;
            case 41:
              ModelHelper.qPs4HIhX1HRCevNe4Cbt((object) infoByTypeOrNull1, attribute1 != null ? ModelHelper.YnVTj6hXPSgrLchJ3PTw((object) attribute1) : Guid.Empty);
              num2 = 120;
              continue;
            case 42:
              if (!ModelHelper.IiSau9hX2d1jtaCyZLq1(typeDescriptor1.SettingsType, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 50 : 11;
                continue;
              }
              goto case 108;
            case 43:
              ModelHelper.qPs4HIhX1HRCevNe4Cbt((object) infoByTypeOrNull1, attribute2 != null ? ModelHelper.uMKVBvhXN2OeHP0Rpcql((object) attribute2) : Guid.Empty);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 73 : 25;
              continue;
            case 44:
              if (!genericArgument.IsEnum)
                goto case 25;
              else
                goto label_26;
            case 45:
              if (loadImplementation)
              {
                num2 = 48;
                continue;
              }
              goto case 9;
            case 46:
              if (ModelHelper.KSJpbChXmTFdKvlJjEJE(type2, (object) actionSettings))
                goto case 58;
              else
                goto label_113;
            case 47:
              goto label_14;
            case 48:
              attribute1 = AttributeHelper<ImplementationUidAttribute>.GetAttribute(genericArgument, true);
              num2 = 41;
              continue;
            case 49:
              goto label_71;
            case 50:
            case 71:
              if (ModelHelper.qWivlIhXzvZyU75MRD63((object) typeDescriptor1))
              {
                num2 = 14;
                continue;
              }
              goto label_22;
            case 52:
              type = type.GetGenericArguments()[0];
              num2 = 70;
              continue;
            case 53:
              if (metadataService != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 8 : 4;
                continue;
              }
              goto label_22;
            case 54:
              if (typeDescriptor2 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 95;
                continue;
              }
              goto label_22;
            case 55:
              TypeHeaderInfo typeHeaderInfo2 = infoByTypeOrNull1;
              ListOfSimpleTypeSettings simpleTypeSettings = new ListOfSimpleTypeSettings();
              ModelHelper.Q6KxpuhXH9eqTA6xDxTF((object) simpleTypeSettings, ModelHelper.cAAs4KhXtfGPJa9lnHVQ((object) typeDescriptor3));
              typeHeaderInfo2.Settings = (TypeSettings) simpleTypeSettings;
              num2 = 77;
              continue;
            case 56:
              type3 = genericArguments[1];
              num2 = 84;
              continue;
            case 58:
              ModelHelper.GcTMTohXeugv0IGOmUVD((object) infoByTypeOrNull1, EleWise.ELMA.Model.Types.ActionDescriptor.UID);
              num2 = 13;
              continue;
            case 59:
            case 63:
              if (!type.IsGenericType)
              {
                num2 = 37;
                continue;
              }
              goto case 115;
            case 60:
              type1 = type;
              num2 = 34;
              continue;
            case 61:
              if (type.IsClass)
              {
                num2 = 6;
                continue;
              }
              goto case 117;
            case 62:
              infoByTypeOrNull1 = new TypeHeaderInfo();
              num2 = 61;
              continue;
            case 64:
              if (typeDescriptor3 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 89 : 56;
                continue;
              }
              goto case 55;
            case 66:
              ModelHelper.GcTMTohXeugv0IGOmUVD((object) infoByTypeOrNull1, DataClassDescriptor.UID);
              num2 = 49;
              continue;
            case 69:
              type1 = type.GetInterface(typeof (ICollection<>).FullName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 116 : 110;
              continue;
            case 70:
              infoByTypeOrNull1.TypeUid = EnumDescriptor.UID;
              num2 = 26;
              continue;
            case 72:
              if (genericArguments.Length > 2)
              {
                num2 = 5;
                continue;
              }
              actionSettings = new ActionSettings();
              num2 = 28;
              continue;
            case 74:
              ModelHelper.qPs4HIhX1HRCevNe4Cbt((object) infoByTypeOrNull1, ModelHelper.y8yskkhXA7NaX52bobAJ(type));
              num2 = 100;
              continue;
            case 75:
              ModelHelper.GcTMTohXeugv0IGOmUVD((object) infoByTypeOrNull1, DataClassDescriptor.UID);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 4 : 29;
              continue;
            case 78:
            case 110:
              if (!type.IsClass)
              {
                num2 = 112;
                continue;
              }
              goto case 105;
            case 79:
              if (serviceOrNull1 != null)
              {
                num2 = 99;
                continue;
              }
              goto label_22;
            case 81:
            case 120:
              TypeHeaderInfo typeHeaderInfo3 = infoByTypeOrNull1;
              EntitySettings entitySettings1 = new EntitySettings();
              ModelHelper.b1VU3ZhX38N5DdSsPGn9((object) entitySettings1, RelationType.OneToMany);
              typeHeaderInfo3.Settings = (TypeSettings) entitySettings1;
              num2 = 27;
              continue;
            case 82:
              infoByTypeOrNull1.TypeUid = ListOfSimpleTypeDescriptor.UID;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 4 : 23;
              continue;
            case 83:
              goto label_54;
            case 84:
              if (ModelHelper.MrrJ0ihX0wSDlx2ROuSU(type3))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 2 : 2;
                continue;
              }
              goto label_39;
            case 85:
            case 104:
              type2 = genericArguments[0];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 1 : 18;
              continue;
            case 87:
              goto label_126;
            case 88:
              if (ModelHelper.rbMJNrhXa8hmQGhSafVR(type.GetGenericArguments()[0]))
              {
                num2 = 82;
                continue;
              }
              goto case 17;
            case 91:
              ModelHelper.qb1GT6hXY57G3dPRxdia((object) actionSettings, ModelHelper.GCZZCOhXjXfsOF5iJjav((object) propertySignature));
              num2 = 58;
              continue;
            case 92:
              if (typeDescriptor1 == null)
              {
                num2 = 7;
                continue;
              }
              goto case 10;
            case 93:
              goto label_66;
            case 95:
              goto label_57;
            case 96:
              ModelHelper.GcTMTohXeugv0IGOmUVD((object) infoByTypeOrNull1, ListOfSimpleTypeDescriptor.UID);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 30 : 5;
              continue;
            case 98:
              if (!type.GetGenericArguments()[0].IsEnum)
                goto case 103;
              else
                goto label_60;
            case 99:
              typeDescriptor3 = (ITypeDescriptor) ModelHelper.MXiFEvhXD2hjJdq1gPma((object) serviceOrNull1, type.GetGenericArguments()[0]);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 57 : 64;
              continue;
            case 100:
              infoByTypeOrNull1.Settings = (TypeSettings) new EnumSettings();
              num2 = 118;
              continue;
            case 101:
              ModelHelper.tRWLAMhXwGdy2bpbYZvp((object) infoByTypeOrNull1, (object) new AnyTypeSettings()
              {
                FullTypeName = type.FullName
              });
              num2 = 93;
              continue;
            case 102:
              goto label_27;
            case 103:
            case 111:
              if (ModelHelper.qDpVfMhXx5JKxQJXnwrb(type))
              {
                num2 = 16;
                continue;
              }
              goto case 35;
            case 105:
              // ISSUE: type reference
              if (!(type.GetInterface(ModelHelper.LqAwZthXOJ2MuuuG2isf(__typeref (ICollection<>)).FullName) != (Type) null))
              {
                num2 = 12;
                continue;
              }
              goto case 69;
            case 108:
              ModelHelper.tRWLAMhXwGdy2bpbYZvp((object) infoByTypeOrNull1, (object) (TypeSettings) ModelHelper.HVgy9thXctKpv8brlHfb(ModelHelper.JVujI9hXst7XoY98RxtP((object) typeDescriptor1)));
              num2 = 71;
              continue;
            case 112:
              if (type.IsInterface)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 90 : 105;
                continue;
              }
              goto case 59;
            case 114:
              ModelHelper.tRWLAMhXwGdy2bpbYZvp((object) infoByTypeOrNull1, (object) new EnumSettings());
              num2 = 22;
              continue;
            case 115:
              // ISSUE: type reference
              if (!ModelHelper.xY4gVbhXp8dO8XLCgQ8m(type.GetGenericTypeDefinition(), ModelHelper.LqAwZthXOJ2MuuuG2isf(__typeref (IEnumerable<>))))
              {
                num2 = 90;
                continue;
              }
              goto case 88;
            case 116:
              if (!ModelHelper.xY4gVbhXp8dO8XLCgQ8m(type1, (Type) null))
                goto case 34;
              else
                goto label_4;
            case 117:
              if (type.IsInterface)
              {
                num2 = 107;
                continue;
              }
              goto case 78;
            case 118:
              ModelHelper.Ca2hvKhX7MrMXZn0mKov((object) infoByTypeOrNull1, false);
              num2 = 106;
              continue;
            case 121:
              goto label_39;
            case 122:
              ModelHelper.GcTMTohXeugv0IGOmUVD((object) infoByTypeOrNull1, EntityDescriptor.UID);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 83 : 1;
              continue;
            default:
              TypeHeaderInfo typeHeaderInfo4 = infoByTypeOrNull1;
              EntitySettings entitySettings2 = new EntitySettings();
              ModelHelper.b1VU3ZhX38N5DdSsPGn9((object) entitySettings2, RelationType.OneToOne);
              typeHeaderInfo4.Settings = (TypeSettings) entitySettings2;
              num2 = 94;
              continue;
          }
        }
label_4:
        num1 = 60;
        continue;
label_26:
        num1 = 113;
        continue;
label_54:
        if (!loadImplementation)
        {
          num1 = 76;
          continue;
        }
        goto label_126;
label_57:
        ModelHelper.tRWLAMhXwGdy2bpbYZvp((object) infoByTypeOrNull1, (object) new ListOfSimpleTypeSettings()
        {
          SimpleTypeUid = ModelHelper.cAAs4KhXtfGPJa9lnHVQ((object) typeDescriptor2)
        });
        num1 = 68;
        continue;
label_60:
        num1 = 52;
        continue;
label_71:
        ModelHelper.qPs4HIhX1HRCevNe4Cbt((object) infoByTypeOrNull1, ModelHelper.VWqCtthX4InYDPFoi5mw(type));
        num1 = 19;
        continue;
label_113:
        num1 = 47;
        continue;
label_126:
        attribute4 = AttributeHelper<ImplementationUidAttribute>.GetAttribute(type, true);
        num1 = 11;
        continue;
label_139:
        infoByTypeOrNull1.SubTypeUid = attribute3 == null ? Guid.Empty : ModelHelper.uMKVBvhXN2OeHP0Rpcql((object) attribute3);
        num1 = 81;
      }
label_14:
      return infoByTypeOrNull1;
label_22:
      return infoByTypeOrNull1;
label_27:
      return infoByTypeOrNull1;
label_39:
      return infoByTypeOrNull1;
label_66:
      return infoByTypeOrNull1;
label_106:
      return infoByTypeOrNull1;
    }

    private static bool CheckSimpleType(Type type)
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            if (type.IsPrimitive)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 1;
              continue;
            }
            goto label_6;
          case 3:
            goto label_6;
          case 4:
            goto label_8;
          case 5:
            if (!ModelHelper.IiSau9hX2d1jtaCyZLq1(type, typeof (object)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 4 : 4;
              continue;
            }
            break;
        }
        // ISSUE: type reference
        if (!(type == ModelHelper.LqAwZthXOJ2MuuuG2isf(__typeref (string))))
          num = 2;
        else
          goto label_7;
      }
label_6:
      return type.IsValueType;
label_7:
      return true;
label_8:
      return false;
    }

    private static bool ProcessReturnType(Type argument, object settings)
    {
      int num = 5;
      Type[] genericArguments;
      PropertyMetadata property;
      TypeHeaderInfo infoByTypeOrNull;
      PropertySignature propertySignature;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_20;
          case 2:
            genericArguments = argument.GetGenericArguments();
            num = 15;
            continue;
          case 3:
            if (!(argument.GetGenericTypeDefinition() != ModelHelper.cgVWufhTWufCIiFmDaUy((object) TypeOf.Task1)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 1 : 2;
              continue;
            }
            goto label_15;
          case 4:
            goto label_9;
          case 5:
            if (!(ModelHelper.KQxjXEhTBp2MC1fqhdGE(ModelHelper.bhDWpXhTF2KLeBWh3sJy(settings)) != Guid.Empty))
            {
              if (!ModelHelper.xY4gVbhXp8dO8XLCgQ8m(argument, TypeOf<Task>.Raw))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 2 : 11;
                continue;
              }
              goto label_21;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 4 : 0;
              continue;
            }
          case 6:
            Type type = genericArguments[0];
            property = new PropertyMetadata();
            infoByTypeOrNull = ModelHelper.GetTypeInfoByTypeOrNull(type);
            num = 8;
            continue;
          case 7:
            ModelHelper.oXVAxthX9VE49EHDtjiq((object) property, ModelHelper.rnL6RyhXJDup3U0EZOKl((object) infoByTypeOrNull));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
            continue;
          case 8:
            ModelHelper.LcYc2hhXMGqxmuUWJvGC((object) property, ModelHelper.khxIG2hXyRwIe00u3VE1((object) infoByTypeOrNull));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 7 : 2;
            continue;
          case 9:
            ModelHelper.ABaYPDhTodXD5fYiHiIQ(settings, (object) propertySignature.Type);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 1;
            continue;
          case 10:
            goto label_15;
          case 11:
            if (argument.IsGenericType)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 3 : 1;
              continue;
            }
            goto label_15;
          case 12:
            ModelHelper.vTAGd0hXgsgGq32Z2QKO((object) property, infoByTypeOrNull.Nullable);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 6 : 16;
            continue;
          case 13:
            goto label_21;
          case 14:
            goto label_2;
          case 15:
            if (genericArguments.Length <= 1)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 6;
              continue;
            }
            goto label_2;
          case 16:
            propertySignature = property.CreatePropertySignature();
            num = 9;
            continue;
          default:
            ModelHelper.iw6FfGhXlukIc96OVHbR((object) property, ModelHelper.DQP8GqhXd6nXJ0EvRu7M((object) infoByTypeOrNull));
            num = 12;
            continue;
        }
      }
label_2:
      return false;
label_9:
      return false;
label_15:
      return false;
label_20:
      return true;
label_21:
      return true;
    }

    /// <summary>
    /// Получить строку из идентификатора типа и подтипа с разделителем
    /// </summary>
    /// <param name="desc">Дескриптор типа</param>
    /// <param name="delimeter">Разделитель</param>
    /// <returns></returns>
    public static string GetTypeAndSubTypeWithDelimeterString(
      this ITypeDescriptor desc,
      string delimeter = ";")
    {
      return (string) ModelHelper.plgOl2hThQT92CWElodc(ModelHelper.YONCx4hTbqrRGf6T5K3L(1994213607 >> 4 ^ 124737336), (object) ModelHelper.cAAs4KhXtfGPJa9lnHVQ((object) desc), (object) delimeter, (object) desc.SubTypeUid);
    }

    /// <summary>Проверить дескриптор на тип CLR</summary>
    /// <param name="descriptor">Дескриптор типа</param>
    /// <returns>True, если тип CLR</returns>
    public static bool IsCLRTypeDescriptor(this ITypeDescriptor descriptor)
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        Type type1;
        while (true)
        {
          Type type2;
          Type type3;
          switch (num2)
          {
            case 1:
              goto label_16;
            case 3:
              goto label_6;
            case 4:
              // ISSUE: type reference
              if (type1 != ModelHelper.LqAwZthXOJ2MuuuG2isf(__typeref (object)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
                continue;
              }
              goto label_16;
            case 5:
              goto label_12;
            case 6:
              ModelHelper.VZrPVhhTGPywUo0651M6((object) descriptor, ModelHelper.YONCx4hTbqrRGf6T5K3L(864270449 << 6 ^ -521245046));
              num2 = 5;
              continue;
            case 7:
              type3 = type1;
              break;
            case 8:
              // ISSUE: type reference
              if (ModelHelper.xY4gVbhXp8dO8XLCgQ8m(ModelHelper.LqAwZthXOJ2MuuuG2isf(__typeref (CLRTypeDescriptor<>)), type2))
              {
                num2 = 3;
                continue;
              }
              type1 = type1.BaseType;
              num2 = 10;
              continue;
            case 9:
              type3 = type1.GetGenericTypeDefinition();
              break;
            case 10:
            case 11:
              if (ModelHelper.IiSau9hX2d1jtaCyZLq1(type1, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 4 : 1;
                continue;
              }
              goto label_16;
            default:
              if (type1.IsGenericType)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 9 : 7;
                continue;
              }
              goto case 7;
          }
          type2 = type3;
          num2 = 8;
        }
label_12:
        type1 = descriptor.GetType();
        num1 = 11;
      }
label_6:
      return true;
label_16:
      return false;
    }

    /// <summary>
    /// Преобразовать строку из идентификатора типа и подтипа с разделителем в кортеж
    /// </summary>
    /// <param name="typeUidSubTypeUidString">Строка из идентификатора типа и подтипа с разделителем</param>
    /// <param name="delimeter">Разделитель</param>
    /// <returns></returns>
    public static (Guid, Guid) GetTypeAndSubTypeFromStringWithDelimeter(
      string typeUidSubTypeUidString,
      string delimeter = ";")
    {
      string[] source = typeUidSubTypeUidString.Split(delimeter.ToCharArray());
      Guid result1;
      Guid result2;
      return source != null && ((IEnumerable<string>) source).Count<string>() == 2 && Guid.TryParse(source[0], out result1) && Guid.TryParse(source[1], out result2) ? (result1, result2) : (Guid.Empty, Guid.Empty);
    }

    /// <summary>Получить элементы перечисления</summary>
    /// <param name="viewData">Данные отображения</param>
    /// <returns></returns>
    public static IEnumerable<SelectListItem> GetEnumItems(ViewDataDictionary viewData)
    {
      if (!(viewData.ModelMetadata?.ModelType == (Type) null))
        return ModelHelper.GetEnumItems(viewData, viewData.ModelMetadata.ModelType);
      return (IEnumerable<SelectListItem>) new SelectListItem[1]
      {
        new SelectListItem()
        {
          Value = string.Empty,
          Text = string.Empty,
          Selected = viewData.Model == null
        }
      };
    }

    /// <summary>Получить элементы перечисления по типу</summary>
    /// <param name="viewData">Данные отображения</param>
    /// <param name="type">Тип</param>
    /// <returns></returns>
    public static IEnumerable<SelectListItem> GetEnumItems(ViewDataDictionary viewData, Type type) => (IEnumerable<SelectListItem>) new ModelHelper.\u003CGetEnumItems\u003Ed__10(-2)
    {
      \u003C\u003E3__viewData = viewData,
      \u003C\u003E3__type = type
    };

    /// <summary>Получить отображаемое имя значения перечисления</summary>
    /// <param name="value">Значение перечисления</param>
    /// <returns></returns>
    public static string GetEnumDisplayName(object value)
    {
      int num1 = 9;
      EnumValueMetadata enumValueMetadata;
      EnumMetadata enumMetadata;
      object value1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (enumValueMetadata == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 3 : 3;
              continue;
            }
            goto label_5;
          case 2:
            if (value1 != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
              continue;
            }
            goto label_12;
          case 3:
            goto label_4;
          case 4:
            if (enumMetadata == null)
            {
              num1 = 6;
              continue;
            }
            goto case 7;
          case 5:
            goto label_12;
          case 6:
            goto label_6;
          case 7:
            enumValueMetadata = enumMetadata.Values.FirstOrDefault<EnumValueMetadata>((Func<EnumValueMetadata, bool>) (v =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    if (v.EnumValue != null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_3;
                  default:
                    goto label_2;
                }
              }
label_2:
              // ISSUE: reference to a compiler-generated method
              return ModelHelper.\u003C\u003Ec__DisplayClass11_0.C1prumvh7F2G21QvhULQ((object) v).Equals(value1);
label_3:
              return false;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 1;
            continue;
          case 8:
            value1 = value;
            num1 = 2;
            continue;
          case 9:
            num1 = 8;
            continue;
          default:
            enumMetadata = MetadataLoader.LoadMetadata(value1.GetType()) as EnumMetadata;
            num1 = 4;
            continue;
        }
      }
label_4:
      return "";
label_5:
      return (string) ModelHelper.E4YwYKhTEgxOVwrIQ7Jx((object) enumValueMetadata);
label_6:
      return "";
label_12:
      return string.Empty;
    }

    /// <summary>
    /// Получить значение перечисления (расширяемого или нерасширяемого) по идентификатору значения
    /// </summary>
    /// <param name="enumType"></param>
    /// <param name="uid"></param>
    /// <returns></returns>
    public static object GetEnumValue(Type enumType, Guid uid)
    {
      int num = 4;
      EnumValueMetadata enumValueMetadata;
      Guid uid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (enumValueMetadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 0;
              continue;
            }
            goto label_3;
          case 3:
            uid1 = uid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
            continue;
          case 4:
            num = 3;
            continue;
          default:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            enumValueMetadata = ((EnumMetadata) MetadataLoader.LoadMetadata(enumType)).Values.FirstOrDefault<EnumValueMetadata>((Func<EnumValueMetadata, bool>) (v => ModelHelper.\u003C\u003Ec__DisplayClass12_0.eXF8U4vhJxCW2F1DYx1l(ModelHelper.\u003C\u003Ec__DisplayClass12_0.UhIbA5vhMRs0v6c7COlB((object) v), uid1)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 2 : 2;
            continue;
        }
      }
label_2:
      return (object) null;
label_3:
      return enumValueMetadata.EnumValue;
    }

    /// <summary>
    /// Получить значение перечисления (расширяемого или нерасширяемого) по имени значения
    /// </summary>
    /// <param name="enumType"></param>
    /// <param name="valueName"></param>
    /// <returns></returns>
    public static object GetEnumValue([NotNull] Type enumType, [NotNull] string valueName)
    {
      int num1 = 8;
      EnumValueMetadata enumValueMetadata;
      while (true)
      {
        int num2 = num1;
        string valueName1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_14;
            case 2:
              if (valueName1 != null)
              {
                enumValueMetadata = ((EnumMetadata) MetadataLoader.LoadMetadata(enumType)).Values.FirstOrDefault<EnumValueMetadata>((Func<EnumValueMetadata, bool>) (v =>
                {
                  int num3 = 2;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        goto label_3;
                      case 2:
                        // ISSUE: reference to a compiler-generated method
                        if ((string) ModelHelper.\u003C\u003Ec__DisplayClass13_0.sOiqDnvhg7ievrQxqCmG((object) v) == valueName1)
                        {
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 1 : 1;
                          continue;
                        }
                        goto label_2;
                      default:
                        goto label_2;
                    }
                  }
label_2:
                  // ISSUE: reference to a compiler-generated method
                  return ModelHelper.\u003C\u003Ec__DisplayClass13_0.Ab83PTvh5lYqqFlwuGPS((object) valueName1, (object) v.EnumValue.ToString(), StringComparison.InvariantCulture);
label_3:
                  return true;
                }));
                num2 = 4;
                continue;
              }
              goto label_12;
            case 3:
              goto label_5;
            case 4:
              if (enumValueMetadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 4 : 5;
                continue;
              }
              goto label_14;
            case 5:
              goto label_15;
            case 6:
              if (!(enumType == (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 2 : 2;
                continue;
              }
              goto label_10;
            case 7:
              valueName1 = valueName;
              num2 = 6;
              continue;
            case 8:
              num2 = 7;
              continue;
            default:
              goto label_10;
          }
        }
label_12:
        num1 = 3;
      }
label_5:
      throw new ArgumentNullException((string) ModelHelper.YONCx4hTbqrRGf6T5K3L(1819636893 << 3 ^ 1672015530));
label_10:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957726806));
label_14:
      return (object) null;
label_15:
      return ModelHelper.VV1LrUhTfVPh59A3q9hh((object) enumValueMetadata);
    }

    /// <summary>Получить элементы перечисления</summary>
    /// <param name="viewData">Данные отображения</param>
    /// <returns>Коллекция метаданных значения перечисления</returns>
    public static IEnumerable<EnumValueMetadata> GetEnumValues(ViewDataDictionary viewData)
    {
      Contract.ArgumentNotNull((object) viewData, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97887730));
      if (!(MetadataLoader.LoadMetadata(viewData.ModelMetadata.ModelType) is EnumMetadata enumMetadata))
        enumMetadata = MetadataLoader.LoadMetadata(((IEnumerable<Type>) viewData.ModelMetadata.ModelType.GetGenericArguments()).FirstOrDefault<Type>()) as EnumMetadata;
      return enumMetadata != null ? (IEnumerable<EnumValueMetadata>) enumMetadata.Values : (IEnumerable<EnumValueMetadata>) new List<EnumValueMetadata>();
    }

    /// <summary>
    /// Получить значение по умолчанию для перечисления (расширяемого или нерасширяемого)
    /// </summary>
    /// <param name="enumType"></param>
    /// <returns></returns>
    public static object GetEnumDefaultValue([NotNull] Type enumType)
    {
      int num1 = 3;
      EnumValueMetadata enumValueMetadata;
      EnumMetadata metadata;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumValueMetadata = metadata.Values.FirstOrDefault<EnumValueMetadata>((Func<EnumValueMetadata, bool>) (v =>
            {
              int num2 = 2;
              Guid guid;
              Guid? defaultValueUid;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    defaultValueUid = metadata.DefaultValueUid;
                    num2 = 3;
                    continue;
                  case 2:
                    // ISSUE: reference to a compiler-generated method
                    guid = ModelHelper.\u003C\u003Ec__DisplayClass15_0.SLFavVvhUhKe6MCTFuyu((object) v);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 0;
                    continue;
                  case 3:
                    if (!defaultValueUid.HasValue)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
                      continue;
                    }
                    goto label_3;
                  default:
                    goto label_2;
                }
              }
label_2:
              return false;
label_3:
              // ISSUE: reference to a compiler-generated method
              return ModelHelper.\u003C\u003Ec__DisplayClass15_0.J1tKYavhsyhP6jaGWW7E(guid, defaultValueUid.GetValueOrDefault());
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
            continue;
          case 2:
            if (!ModelHelper.xY4gVbhXp8dO8XLCgQ8m(enumType, (Type) null))
            {
              metadata = (EnumMetadata) MetadataLoader.LoadMetadata(enumType);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 0;
              continue;
            }
            num1 = 4;
            continue;
          case 3:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 2 : 2;
            continue;
          case 4:
            goto label_4;
          case 5:
            goto label_9;
          case 6:
            goto label_8;
          default:
            if (enumValueMetadata != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 5 : 5;
              continue;
            }
            goto label_8;
        }
      }
label_4:
      throw new ArgumentNullException((string) ModelHelper.YONCx4hTbqrRGf6T5K3L(-281842504 ^ -281964206));
label_8:
      return ModelHelper.bpkMUKhTQhenmE1yqVvw(enumType);
label_9:
      return ModelHelper.VV1LrUhTfVPh59A3q9hh((object) enumValueMetadata);
    }

    /// <summary>Получить сущность по типу и идентификатору</summary>
    /// <param name="typeUid"></param>
    /// <param name="uid"></param>
    /// <returns></returns>
    public static IEntity GetEntity(Guid typeUid, Guid uid) => (IEntity) ModelHelper.Su093LhT8HjnORlAgn5b(ModelHelper.OntqVvhTv5yT5TjeoU7b(((IMetadataRuntimeService) ModelHelper.J8UavAhTCELP89BPcMGx()).GetTypeByUid(typeUid)), uid);

    /// <summary>Получить сущность по типу и идентификатору</summary>
    /// <param name="typeUid"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static IEntity GetEntity(Guid typeUid, object id)
    {
      int num = 1;
      IEntityManager entityManager;
      while (true)
      {
        switch (num)
        {
          case 1:
            Type typeByUid = ((IMetadataRuntimeService) ModelHelper.J8UavAhTCELP89BPcMGx()).GetTypeByUid(typeUid);
            entityManager = (IEntityManager) ModelHelper.OntqVvhTv5yT5TjeoU7b(typeByUid);
            id = ModelHelper.qGoMfZhTZyjdlWHkhiJ4(typeByUid, id);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          default:
            if (id == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 2 : 2;
              continue;
            }
            goto label_6;
        }
      }
label_5:
      return (IEntity) null;
label_6:
      return (IEntity) ModelHelper.cYExWrhTuHQkxIdgqwoD((object) entityManager, id);
    }

    /// <summary>Получить сущность по типу и идентификатору</summary>
    /// <typeparam name="T">Тип сущности</typeparam>
    /// <param name="id"></param>
    /// <returns></returns>
    public static T GetEntity<T>(object id) where T : class, IEntity
    {
      IEntityManager entityManager = ModelHelper.GetEntityManager(typeof (T));
      id = ModelHelper.TryConvertEntityId(typeof (T), id);
      return id == null ? default (T) : (T) entityManager.LoadOrNull(id);
    }

    /// <summary>
    /// Получить список сущностей определенного типу по списку идентификаторов
    /// </summary>
    /// <typeparam name="T">Тип сущности</typeparam>
    /// <param name="ids"></param>
    /// <returns></returns>
    public static ICollection<T> GetEntities<T>(params object[] ids) where T : class, IEntity
    {
      IEntityManager entityManager = ModelHelper.GetEntityManager(typeof (T));
      List<T> entities = new List<T>();
      if (ids != null)
      {
        foreach (object id1 in ids)
        {
          object id2 = ModelHelper.TryConvertEntityId(typeof (T), id1);
          if (id2 == null)
            return (ICollection<T>) null;
          T obj = (T) entityManager.LoadOrNull(id2);
          if ((object) obj != null)
            entities.Add(obj);
        }
      }
      return (ICollection<T>) entities;
    }

    /// <summary>Получить тип сущности</summary>
    /// <param name="typeUid">Идентификатор типа сущности</param>
    /// <returns>Тип сущности</returns>
    public static Type GetEntityType(Guid typeUid, bool loadImplementation = true) => ((IMetadataRuntimeService) ModelHelper.J8UavAhTCELP89BPcMGx()).GetTypeByUid(typeUid, loadImplementation);

    /// <summary>Получить тип идентификатора сущности</summary>
    /// <param name="entityType">Тип сущности</param>
    /// <returns>Тип идентификатора сущности</returns>
    public static Type GetEntityIdType(Type entityType)
    {
      int num = 4;
      Type entityIdType;
      while (true)
      {
        Type[] genericArguments;
        Type type;
        switch (num)
        {
          case 1:
          case 7:
          case 8:
            goto label_8;
          case 2:
            entityIdType = genericArguments[0];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 1 : 1;
            continue;
          case 3:
            // ISSUE: type reference
            type = entityType.GetInterface(ModelHelper.LqAwZthXOJ2MuuuG2isf(__typeref (IEntity<>)).FullName);
            num = 5;
            continue;
          case 4:
            // ISSUE: type reference
            entityIdType = ModelHelper.LqAwZthXOJ2MuuuG2isf(__typeref (long));
            num = 3;
            continue;
          case 5:
            if (!ModelHelper.IiSau9hX2d1jtaCyZLq1(type, (Type) null))
            {
              num = 7;
              continue;
            }
            break;
          case 6:
            if (genericArguments.Length == 0)
            {
              num = 8;
              continue;
            }
            goto case 2;
        }
        genericArguments = type.GetGenericArguments();
        num = 6;
      }
label_8:
      return entityIdType;
    }

    /// <summary>Получить менеджер сущности с указанным типом</summary>
    /// <param name="filter">Фильтр сущности</param>
    /// <returns>Менеджер</returns>
    public static IEntityManager GetEntityManagerByFilter(IEntityFilter filter) => (IEntityManager) ModelHelper.Tvk8D7hTIPkpuhxymHql(MetadataLoader.GetEntityMetadataByFilter(filter.GetType()).Uid);

    /// <summary>Получить менеджер сущности с указанным типом</summary>
    /// <param name="uid">Уникальный идентификатор типа сущности</param>
    /// <returns>Менеджер</returns>
    public static IEntityManager GetEntityManager(Guid uid) => ModelHelper.GetEntityManager(MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(uid));

    /// <summary>Получить менеджер сущности с указанным типом</summary>
    /// <param name="entityType">Тип сущности</param>
    /// <returns>Менеджер</returns>
    public static IEntityManager GetEntityManager(Type entityType)
    {
      int num = 3;
      IEntityManager entityManager;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (entityManager != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 3:
            entityManager = (IEntityManager) ModelHelper.TDB4pOhTVX0QFcwfqX0E(entityType);
            num = 2;
            continue;
          default:
            goto label_3;
        }
      }
label_2:
      throw new ServiceNotFoundException(EleWise.ELMA.SR.T((string) ModelHelper.YONCx4hTbqrRGf6T5K3L(1470440286 ^ 1470523698), (object) entityType.FullName));
label_3:
      return entityManager;
    }

    /// <summary>
    /// Получить менеджер сущности с указанным типом (или Null, если не зарегистрирован)
    /// </summary>
    /// <param name="entityType">Тип сущности</param>
    /// <returns>Менеджер</returns>
    public static IEntityManager GetEntityManagerOrNull(Type entityType) => ModelHelper.getEntityManagerCached(entityType);

    private static IEntityManager GetEntityManagerCached(Type entityType) => (IEntityManager) Locator.GetService(typeof (IEntityManager<>).MakeGenericType(ModelHelper.sliK1dhTSiBr6ZAco64H(entityType)));

    /// <summary>
    /// Попытаться преобразовать значение идентификатора сущности к типу идентификатора сущности
    /// </summary>
    /// <param name="idValue">Значение идентификатора</param>
    /// <returns>Идентификатор сущности нужного типа</returns>
    public static object TryConvertEntityId(Guid typeUid, object idValue, bool loadImplementation = true) => ModelHelper.qGoMfZhTZyjdlWHkhiJ4(ModelHelper.GetEntityType(typeUid, loadImplementation), idValue);

    /// <summary>
    /// Попытаться преобразовать значение идентификатора сущности к типу идентификатора сущности
    /// </summary>
    /// <param name="entityType">Тип сущности</param>
    /// <param name="idValue">Значение идентификатора</param>
    /// <returns>Идентификатор сущности нужного типа</returns>
    public static object TryConvertEntityId(Type entityType, object idValue)
    {
      int num1 = 7;
      TypeConverter typeConverter;
      Type type;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_18;
          case 2:
            if (!(type == idValue.GetType()))
            {
              typeConverter = (TypeConverter) ModelHelper.yUjq1BhTRUTP5SP6vGTk(type);
              num1 = 4;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_7;
          case 4:
            if (!ModelHelper.HdFUSIhTqOPUCK0d22Oj((object) typeConverter, idValue.GetType()))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
              continue;
            }
            goto case 8;
          case 5:
          case 6:
            goto label_5;
          case 7:
            if (idValue == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 2 : 6;
              continue;
            }
            goto case 9;
          case 8:
            if (typeConverter.CanConvertFrom(idValue.GetType()))
            {
              num1 = 3;
              continue;
            }
            goto label_5;
          case 9:
            type = ModelHelper.lPi0fIhTiSWq6PKo0cmn(entityType);
            num1 = 2;
            continue;
          default:
            idValue = (object) idValue.ToString();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 8 : 5;
            continue;
        }
      }
label_5:
      return (object) null;
label_7:
      object obj;
      try
      {
        obj = ModelHelper.UgfFSJhTXXvJDoqrbgG7((object) typeConverter, (object) null, ModelHelper.ePMiVJhTKgrv0KSGlAAp(), idValue);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      catch (Exception ex)
      {
        int num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 1:
              ((ILogger) ModelHelper.aGbc16hTTM1pIyv0C4nd()).Debug((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112750072), idValue, (object) type, (object) entityType), ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
      }
      return obj;
label_18:
      return idValue;
    }

    /// <summary>
    /// Получить тип фильтра для указанного типа сущности.
    /// Если непосредственно для данного типа сущности фильтр не определен, то возвращается базовый тип фильтра.
    /// </summary>
    /// <param name="entityType">Тип сущности</param>
    /// <returns>Тип фильтра</returns>
    [NotNull]
    public static Type GetEntityFilterType([NotNull] Type entityType)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            Contract.ArgumentNotNull((object) entityType, (string) ModelHelper.YONCx4hTbqrRGf6T5K3L(-1350312861 << 3 ^ 2082353292));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return ModelHelper.GetEntityFilterType((ClassMetadata) MetadataLoader.LoadMetadata(entityType) ?? throw new EleWise.ELMA.Model.Metadata.MetadataException(string.Format((string) ModelHelper.qPZ8NOhTkeaAB4BietCq(ModelHelper.YONCx4hTbqrRGf6T5K3L(-1867198571 ^ -1867021139)), (object) entityType.FullName)));
    }

    /// <summary>
    /// Проверить метаданные на совпадение имен классов и таблиц
    /// </summary>
    /// <param name="metadataList"></param>
    public static void CheckEntityAndTableNames(List<AbstractMetadata> metadataList)
    {
      Dictionary<string, string> usedEntityNames = new Dictionary<string, string>();
      Dictionary<string, string> usedTableNames = new Dictionary<string, string>();
      foreach (object metadata in metadataList.OfType<EntityMetadata>())
        ModelHelper.CheckEntityAndTableNames(metadata, (object) "", usedEntityNames, usedTableNames);
    }

    /// <summary>Получить короткое имя пространства имен</summary>
    /// <example>
    /// Например, для пространства имен "EleWise.ELMA.Model.Entities.Documents.Folder" функция возвратит "Documents.Folder"
    /// </example>
    /// <param name="ns">Пространство имен</param>
    /// <returns>Отображаемое имя</returns>
    public static string GetNamespaceShortName(string ns)
    {
      int num1 = 1;
      Dictionary<string, string> loadedShortNamespaces1;
      bool lockTaken;
      string namespaceShortName;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (ModelHelper.qevnZkhTn7VKqw9DeN3P((object) ns))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
              continue;
            }
            if (!ModelHelper.loadedShortNamespaces.TryGetValue(ns, out namespaceShortName))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 2;
              continue;
            }
            goto label_18;
          case 2:
            loadedShortNamespaces1 = ModelHelper.loadedShortNamespaces;
            num1 = 5;
            continue;
          case 3:
            goto label_2;
          case 4:
            goto label_18;
          case 5:
            lockTaken = false;
            num1 = 3;
            continue;
          default:
            goto label_19;
        }
      }
label_2:
      try
      {
        Monitor.Enter((object) loadedShortNamespaces1, ref lockTaken);
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
          num2 = 3;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 2:
              goto label_18;
            case 3:
              if (ModelHelper.loadedShortNamespaces.TryGetValue(ns, out namespaceShortName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 0;
                continue;
              }
              break;
          }
          Dictionary<string, string> loadedShortNamespaces2 = ModelHelper.loadedShortNamespaces;
          string key = ns;
          string ns1 = ns;
          string str;
          namespaceShortName = str = ModelHelper.GetNamespace((object) ns1, (Func<string, string, string>) ((nsPart, _) => nsPart));
          loadedShortNamespaces2.Add(key, str);
          num2 = 2;
        }
      }
      finally
      {
        if (lockTaken)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                ModelHelper.boxwKThTOrFS32Aw1Drd((object) loadedShortNamespaces1);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
                continue;
              default:
                goto label_13;
            }
          }
        }
label_13:;
      }
label_18:
      return namespaceShortName;
label_19:
      return string.Empty;
    }

    /// <summary>Получить отображаемое имя пространства имен</summary>
    /// <example>
    /// Например, для пространства имен "EleWise.ELMA.Model.Entities.Documents.Folder" функция возвратит "Документы.Папки"
    /// </example>
    /// <param name="ns">Пространство имен</param>
    /// <returns>Отображаемое имя</returns>
    public static string GetNamespaceDisplayName(string ns)
    {
      int num1 = 4;
      EleWise.ELMA.SR.LocalizableString localizableString;
      bool lockTaken;
      Dictionary<string, EleWise.ELMA.SR.LocalizableString> loadedFullNamespaces;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            goto label_7;
          case 3:
            if (!ModelHelper.loadedFullNamespaces.TryGetValue(ns, out localizableString))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 6 : 2;
              continue;
            }
            goto label_21;
          case 4:
            if (!ModelHelper.qevnZkhTn7VKqw9DeN3P((object) ns))
            {
              num1 = 3;
              continue;
            }
            goto label_2;
          case 5:
            lockTaken = false;
            num1 = 2;
            continue;
          case 6:
            loadedFullNamespaces = ModelHelper.loadedFullNamespaces;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 5 : 5;
            continue;
          default:
            goto label_21;
        }
      }
label_2:
      return string.Empty;
label_7:
      try
      {
        Monitor.Enter((object) loadedFullNamespaces, ref lockTaken);
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!ModelHelper.loadedFullNamespaces.TryGetValue(ns, out localizableString))
              {
                num2 = 2;
                continue;
              }
              goto label_21;
            case 2:
              ModelHelper.loadedFullNamespaces[ns] = localizableString = (EleWise.ELMA.SR.LocalizableString) ModelHelper.zkFDxthT2rYpCDYeBkEj((object) new ModelHelper.FullNamespaceLocalizer(ns));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
              continue;
            default:
              goto label_21;
          }
        }
      }
      finally
      {
        if (lockTaken)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_18;
              default:
                ModelHelper.boxwKThTOrFS32Aw1Drd((object) loadedFullNamespaces);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 1;
                continue;
            }
          }
        }
label_18:;
      }
label_21:
      return (string) ModelHelper.egj0b8hTeRmDUbRMZmmQ((object) localizableString);
    }

    /// <summary>
    /// Получить отображаемое имя последней части в пространстве имен
    /// </summary>
    /// <param name="ns">Пространство имен</param>
    /// <example>
    /// Например, для пространства имен "EleWise.ELMA.Model.Entities.Documents.Folder" функция возвратит "Папки"
    /// </example>
    /// <returns>Отображаемое имя</returns>
    public static string GetNamespacePartDisplayName(string ns)
    {
      int num1 = 2;
      bool lockTaken;
      EleWise.ELMA.SR.LocalizableString localizableString;
      Dictionary<string, EleWise.ELMA.SR.LocalizableString> loadedNamespaces;
      while (true)
      {
        switch (num1)
        {
          case 2:
            if (ModelHelper.loadedNamespaces.TryGetValue(ns, out localizableString))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 0;
              continue;
            }
            goto case 5;
          case 3:
            goto label_7;
          case 4:
            lockTaken = false;
            num1 = 3;
            continue;
          case 5:
            loadedNamespaces = ModelHelper.loadedNamespaces;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 4 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return (string) ModelHelper.egj0b8hTeRmDUbRMZmmQ((object) localizableString);
label_7:
      try
      {
        Monitor.Enter((object) loadedNamespaces, ref lockTaken);
        int num2 = 2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              ModelHelper.loadedNamespaces[ns] = localizableString = EleWise.ELMA.SR.LocalizableString.Create((EleWise.ELMA.SR.ILocalizer) new ModelHelper.NamespacePartLocalizer(ns));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
              continue;
            case 2:
              if (ModelHelper.loadedNamespaces.TryGetValue(ns, out localizableString))
              {
                num2 = 3;
                continue;
              }
              goto case 1;
            default:
              goto label_6;
          }
        }
      }
      finally
      {
        int num3;
        if (!lockTaken)
          num3 = 2;
        else
          goto label_15;
label_14:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_15:
        Monitor.Exit((object) loadedNamespaces);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
        {
          num3 = 0;
          goto label_14;
        }
        else
          goto label_14;
      }
    }

    private static string GetNamespace(object ns, Func<string, string, string> getItem)
    {
      string ns1 = "";
      List<string> values = new List<string>();
      foreach (string str in ((string) ns).Split(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411202199).ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
      {
        ns1 = ns1 + (ns1.Length > 0 ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360337113) : "") + str;
        string namespacePartDisplayName = ModelHelper.GetNamespacePartDisplayName(ns1);
        if (!string.IsNullOrEmpty(namespacePartDisplayName))
          values.Add(getItem(str, namespacePartDisplayName));
      }
      return string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712478067), (IEnumerable<string>) values);
    }

    /// <summary>
    /// Получить тип фильтра для указанного типа сущности.
    /// Если непосредственно для данного типа сущности фильтр не определен, то возвращается базовый тип фильтра.
    /// </summary>
    /// <param name="metadata">Метаданные типа</param>
    /// <returns></returns>
    [NotNull]
    private static Type GetEntityFilterType([NotNull] ClassMetadata metadata)
    {
      int num = 5;
      Type typeByUid;
      Type reflectionType;
      EntityMetadata metadata1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (ModelHelper.yro3wghT1UE0y7u05qky((object) (EntityMetadata) metadata))
            {
              num = 11;
              continue;
            }
            goto default;
          case 3:
            if (reflectionType != (Type) null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 8 : 3;
              continue;
            }
            goto default;
          case 4:
            typeByUid = ((IMetadataRuntimeService) ModelHelper.J8UavAhTCELP89BPcMGx()).GetTypeByUid(ModelHelper.Ssmv1shTPn4Q4jB4I4Bj((object) metadata));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 6 : 6;
            continue;
          case 5:
            Contract.ArgumentNotNull((object) metadata, (string) ModelHelper.YONCx4hTbqrRGf6T5K3L(-1334993905 ^ -1334979279));
            num = 4;
            continue;
          case 6:
            if (!(metadata is EntityMetadata))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 7:
            metadata1 = (EntityMetadata) MetadataServiceContext.MetadataRuntimeService.GetMetadata(ModelHelper.qLghs6hTpv1caxwDJkmf((object) metadata));
            num = 9;
            continue;
          case 8:
            goto label_5;
          case 9:
            if (metadata1 != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 0;
              continue;
            }
            goto label_4;
          case 10:
            goto label_4;
          case 11:
            reflectionType = typeByUid.Assembly.GetReflectionType((string) ModelHelper.XjFWoMhT3XgVCGeiMBZB(ModelHelper.VWEgNrhTNo80Tfgx74s7((object) metadata), ModelHelper.YONCx4hTbqrRGf6T5K3L(1218962250 ^ 1218945142)));
            num = 3;
            continue;
          default:
            if (!ModelHelper.fwnJ6HhXK2aZUKrgw2FN(ModelHelper.qLghs6hTpv1caxwDJkmf((object) metadata), Guid.Empty))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 6 : 10;
              continue;
            }
            goto case 7;
        }
      }
label_3:
      return ModelHelper.GetEntityFilterType((ClassMetadata) metadata1);
label_4:
      // ISSUE: type reference
      return ModelHelper.LqAwZthXOJ2MuuuG2isf(__typeref (Filter));
label_5:
      return reflectionType;
    }

    private static void CheckEntityAndTableNames(
      object metadata,
      object parentMetadataName,
      Dictionary<string, string> usedEntityNames,
      Dictionary<string, string> usedTableNames)
    {
      string parentMetadataName1 = (!string.IsNullOrEmpty((string) parentMetadataName) ? (string) parentMetadataName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727409444) : "") + ((NamedMetadata) metadata).DisplayName;
      string str1;
      if (((EntityMetadata) metadata).Type == EntityMetadataType.Interface || ((EntityMetadata) metadata).Type == EntityMetadataType.Entity)
      {
        if (string.IsNullOrEmpty(((NamedMetadata) metadata).Name))
          throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70253126), (object) parentMetadataName1));
        if (usedEntityNames.TryGetValue(((NamedMetadata) metadata).Name.ToUpper(), out str1))
          throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870710307), (object) ((NamedMetadata) metadata).Name, (object) str1, (object) parentMetadataName1));
        usedEntityNames[((NamedMetadata) metadata).Name.ToUpper()] = parentMetadataName1;
        if (string.IsNullOrEmpty(((EntityMetadata) metadata).TableName))
          throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 88072405), (object) parentMetadataName1));
        if (usedTableNames.TryGetValue(((EntityMetadata) metadata).TableName.ToUpper(), out str1))
          throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921021173), (object) ((EntityMetadata) metadata).TableName, (object) str1, (object) parentMetadataName1));
        usedTableNames[((EntityMetadata) metadata).TableName.ToUpper()] = parentMetadataName1;
      }
      foreach (object tablePart in ((EntityMetadata) metadata).TableParts)
        ModelHelper.CheckEntityAndTableNames(tablePart, (object) parentMetadataName1, usedEntityNames, usedTableNames);
      foreach (PropertyMetadata property in ((ClassMetadata) metadata).Properties)
      {
        if (property.Settings is EntitySettings settings && settings.RelationType == RelationType.ManyToMany)
        {
          string str2 = parentMetadataName1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70253706) + property.DisplayName;
          if (string.IsNullOrEmpty(settings.RelationTableName))
            throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1786967252), (object) property.DisplayName, (object) parentMetadataName1));
          if (usedTableNames.TryGetValue(settings.RelationTableName.ToUpper(), out str1))
            throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178158068), (object) settings.RelationTableName, (object) str1, (object) str2));
          usedTableNames[settings.RelationTableName.ToUpper()] = str2;
        }
      }
    }

    static ModelHelper()
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        ParameterExpression parameterExpression;
        while (true)
        {
          switch (num2)
          {
            case 1:
              ModelHelper.toQtemhTaHQQ07Nu0Qh8();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_7;
            case 3:
              ModelHelper.loadedNamespaces = new Dictionary<string, EleWise.ELMA.SR.LocalizableString>();
              num2 = 5;
              continue;
            case 4:
              ModelHelper.loadedShortNamespaces = new Dictionary<string, string>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 2 : 3;
              continue;
            case 5:
              // ISSUE: type reference
              parameterExpression = (ParameterExpression) ModelHelper.nDtm8DhTDhf7KCjDCUev(ModelHelper.LqAwZthXOJ2MuuuG2isf(__typeref (Type)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740411594));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 2;
              continue;
            case 6:
              goto label_3;
            default:
              ModelHelper.loadedFullNamespaces = new Dictionary<string, EleWise.ELMA.SR.LocalizableString>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 4 : 2;
              continue;
          }
        }
label_7:
        // ISSUE: method reference
        ModelHelper.getEntityManagerCached = MetadataLoader.UseCachingForFunc<Type, IEntityManager>(Expression.Lambda<Func<Type, IEntityManager>>((Expression) ModelHelper.WN5fJghTw56KGDlKUGaU((object) null, (object) (System.Reflection.MethodInfo) ModelHelper.rRLcBQhTtTZwNNZDujQF(__methodref (ModelHelper.GetEntityManagerCached)), (object) new Expression[1]
        {
          (Expression) parameterExpression
        }), parameterExpression));
        num1 = 6;
      }
label_3:;
    }

    internal static bool Ay0AiyhXirqHE6YjbIbJ() => ModelHelper.KI2iKrhXSKKubdRfk8gZ == null;

    internal static ModelHelper Ad1t1ThXROf4hplCYOEp() => ModelHelper.KI2iKrhXSKKubdRfk8gZ;

    internal static Guid Cl3IHvhXquP38jpwJT9n([In] object obj0) => ((ReferenceOnType) obj0).TypeUid;

    internal static bool fwnJ6HhXK2aZUKrgw2FN([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static Guid NIJYkmhXXVCmJNhJlfOF([In] object obj0) => ((ReferenceOnType) obj0).SubTypeUid;

    internal static object LXPt6mhXTvfehNMKig7F([In] object obj0, Guid typeUid, Guid subTypeUid) => (object) ((IMetadataService) obj0).GetTypeDescriptor(typeUid, subTypeUid);

    internal static bool IISjOkhXkKCyPJnXCps1([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void ilquUJhXn3sqYSHLmncf([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static Type LqAwZthXOJ2MuuuG2isf([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool IiSau9hX2d1jtaCyZLq1([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static void GcTMTohXeugv0IGOmUVD([In] object obj0, Guid value) => ((TypeHeaderInfo) obj0).TypeUid = value;

    internal static Guid YnVTj6hXPSgrLchJ3PTw([In] object obj0) => ((ImplementationUidAttribute) obj0).Uid;

    internal static void qPs4HIhX1HRCevNe4Cbt([In] object obj0, Guid value) => ((TypeHeaderInfo) obj0).SubTypeUid = value;

    internal static Guid uMKVBvhXN2OeHP0Rpcql([In] object obj0) => ((UidAttribute) obj0).Uid;

    internal static void b1VU3ZhX38N5DdSsPGn9([In] object obj0, RelationType value) => ((EntitySettings) obj0).RelationType = value;

    internal static bool xY4gVbhXp8dO8XLCgQ8m([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static bool rbMJNrhXa8hmQGhSafVR(Type type) => ModelHelper.CheckSimpleType(type);

    internal static object MXiFEvhXD2hjJdq1gPma([In] object obj0, Type runtimeType) => (object) ((IMetadataService) obj0).GetTypeDescriptor(runtimeType);

    internal static Guid cAAs4KhXtfGPJa9lnHVQ([In] object obj0) => ((ITypeDescriptor) obj0).Uid;

    internal static void tRWLAMhXwGdy2bpbYZvp([In] object obj0, [In] object obj1) => ((TypeHeaderInfo) obj0).Settings = (TypeSettings) obj1;

    internal static Guid VWqCtthX4InYDPFoi5mw(Type type) => DataClassDescriptor.GetSubtypeUid(type);

    internal static void UJDxlYhX60cCtCOt5Tfq([In] object obj0, RelationType value) => ((DataClassSettings) obj0).RelationType = value;

    internal static void Q6KxpuhXH9eqTA6xDxTF([In] object obj0, Guid value) => ((ListOfSimpleTypeSettings) obj0).SimpleTypeUid = value;

    internal static Guid y8yskkhXA7NaX52bobAJ(Type type) => EnumDescriptor.GetSubtypeUid(type);

    internal static void Ca2hvKhX7MrMXZn0mKov([In] object obj0, bool value) => ((TypeHeaderInfo) obj0).Nullable = value;

    internal static bool qDpVfMhXx5JKxQJXnwrb(Type type) => type.IsFunc();

    internal static bool MrrJ0ihX0wSDlx2ROuSU(Type type) => type.IsAsync();

    internal static bool KSJpbChXmTFdKvlJjEJE(Type argument, [In] object obj1) => ModelHelper.ProcessReturnType(argument, obj1);

    internal static Guid khxIG2hXyRwIe00u3VE1([In] object obj0) => ((TypeHeaderInfo) obj0).TypeUid;

    internal static void LcYc2hhXMGqxmuUWJvGC([In] object obj0, Guid value) => ((PropertyMetadata) obj0).TypeUid = value;

    internal static Guid rnL6RyhXJDup3U0EZOKl([In] object obj0) => ((TypeHeaderInfo) obj0).SubTypeUid;

    internal static void oXVAxthX9VE49EHDtjiq([In] object obj0, Guid value) => ((PropertyMetadata) obj0).SubTypeUid = value;

    internal static object DQP8GqhXd6nXJ0EvRu7M([In] object obj0) => (object) ((TypeHeaderInfo) obj0).Settings;

    internal static void iw6FfGhXlukIc96OVHbR([In] object obj0, [In] object obj1) => ((PropertyMetadata) obj0).Settings = (TypeSettings) obj1;

    internal static bool D4eIqfhXro9a0Vf9iKJg([In] object obj0) => ((TypeHeaderInfo) obj0).Nullable;

    internal static void vTAGd0hXgsgGq32Z2QKO([In] object obj0, bool value) => ((PropertyMetadata) obj0).Nullable = value;

    internal static object qHQ3WjhX5bugmGJUrXMQ([In] object obj0) => (object) ((IPropertyMetadata) obj0).CreatePropertySignature();

    internal static object GCZZCOhXjXfsOF5iJjav([In] object obj0) => (object) ((PropertySignature) obj0).Type;

    internal static void qb1GT6hXY57G3dPRxdia([In] object obj0, [In] object obj1) => ((ActionSettings) obj0).ParameterType = (TypeSignature) obj1;

    internal static bool XDJ6BuhXLmeMNscpYLvx() => Locator.Initialized;

    internal static object TvBv2PhXUfOSMwXvFjNt() => (object) MetadataServiceContext.ServiceOrNull;

    internal static Type JVujI9hXst7XoY98RxtP([In] object obj0) => ((ITypeDescriptor) obj0).SettingsType;

    internal static object HVgy9thXctKpv8brlHfb([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static bool qWivlIhXzvZyU75MRD63([In] object obj0) => ((ITypeDescriptor) obj0).CanBeNullable;

    internal static object bhDWpXhTF2KLeBWh3sJy([In] object obj0) => (object) ((ActionSettings) obj0).ReturnType;

    internal static Guid KQxjXEhTBp2MC1fqhdGE([In] object obj0) => ((TypeSignature) obj0).TypeUid;

    internal static Type cgVWufhTWufCIiFmDaUy([In] object obj0) => ((RipeType) obj0).Raw;

    internal static void ABaYPDhTodXD5fYiHiIQ([In] object obj0, [In] object obj1) => ((ActionSettings) obj0).ReturnType = (TypeSignature) obj1;

    internal static object YONCx4hTbqrRGf6T5K3L(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object plgOl2hThQT92CWElodc(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static void VZrPVhhTGPywUo0651M6([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object E4YwYKhTEgxOVwrIQ7Jx([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static object VV1LrUhTfVPh59A3q9hh([In] object obj0) => ((EnumValueMetadata) obj0).EnumValue;

    internal static object bpkMUKhTQhenmE1yqVvw(Type type) => type.DefaultValue();

    internal static object J8UavAhTCELP89BPcMGx() => (object) MetadataServiceContext.MetadataRuntimeService;

    internal static object OntqVvhTv5yT5TjeoU7b(Type entityType) => (object) ModelHelper.GetEntityManager(entityType);

    internal static object Su093LhT8HjnORlAgn5b([In] object obj0, Guid uid) => ((IEntityManager) obj0).LoadOrNull(uid);

    internal static object qGoMfZhTZyjdlWHkhiJ4(Type entityType, [In] object obj1) => ModelHelper.TryConvertEntityId(entityType, obj1);

    internal static object cYExWrhTuHQkxIdgqwoD([In] object obj0, [In] object obj1) => ((IEntityManager) obj0).LoadOrNull(obj1);

    internal static object Tvk8D7hTIPkpuhxymHql(Guid uid) => (object) ModelHelper.GetEntityManager(uid);

    internal static object TDB4pOhTVX0QFcwfqX0E(Type entityType) => (object) ModelHelper.GetEntityManagerOrNull(entityType);

    internal static Type sliK1dhTSiBr6ZAco64H(Type type) => type.GetTypeWithoutProxy();

    internal static Type lPi0fIhTiSWq6PKo0cmn(Type entityType) => ModelHelper.GetEntityIdType(entityType);

    internal static object yUjq1BhTRUTP5SP6vGTk([In] Type obj0) => (object) System.ComponentModel.TypeDescriptor.GetConverter(obj0);

    internal static bool HdFUSIhTqOPUCK0d22Oj([In] object obj0, [In] Type obj1) => ((TypeConverter) obj0).CanConvertFrom(obj1);

    internal static object ePMiVJhTKgrv0KSGlAAp() => (object) CultureInfo.InvariantCulture;

    internal static object UgfFSJhTXXvJDoqrbgG7(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return ((TypeConverter) obj0).ConvertFrom((ITypeDescriptorContext) obj1, (CultureInfo) obj2, obj3);
    }

    internal static object aGbc16hTTM1pIyv0C4nd() => (object) Logger.Log;

    internal static object qPZ8NOhTkeaAB4BietCq([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool qevnZkhTn7VKqw9DeN3P([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static void boxwKThTOrFS32Aw1Drd([In] object obj0) => Monitor.Exit(obj0);

    internal static object zkFDxthT2rYpCDYeBkEj([In] object obj0) => (object) EleWise.ELMA.SR.LocalizableString.Create((EleWise.ELMA.SR.ILocalizer) obj0);

    internal static object egj0b8hTeRmDUbRMZmmQ([In] object obj0) => (object) (string) (EleWise.ELMA.SR.LocalizableString) obj0;

    internal static Guid Ssmv1shTPn4Q4jB4I4Bj([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static bool yro3wghT1UE0y7u05qky([In] object obj0) => ((EntityMetadata) obj0).Filterable;

    internal static object VWEgNrhTNo80Tfgx74s7([In] object obj0) => (object) ((ClassMetadata) obj0).FullTypeName;

    internal static object XjFWoMhT3XgVCGeiMBZB([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static Guid qLghs6hTpv1caxwDJkmf([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

    internal static void toQtemhTaHQQ07Nu0Qh8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object nDtm8DhTDhf7KCjDCUev([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object rRLcBQhTtTZwNNZDujQF([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object WN5fJghTw56KGDlKUGaU([In] object obj0, [In] object obj1, [In] object obj2) => (object) Expression.Call((Expression) obj0, (System.Reflection.MethodInfo) obj1, (Expression[]) obj2);

    private class FullNamespaceLocalizer : EleWise.ELMA.SR.ILocalizer
    {
      private readonly object ns;
      internal static object cqfVfKvhBjMt5WifJmxn;

      public FullNamespaceLocalizer(string ns)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.ns = (object) ns;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        return;
label_5:;
      }

      public string Localize() => ModelHelper.GetNamespace(this.ns, (Func<string, string, string>) ((_, nsItemDisplayName) => nsItemDisplayName));

      internal static bool k1dSi2vhWLjkbkt04q2F() => ModelHelper.FullNamespaceLocalizer.cqfVfKvhBjMt5WifJmxn == null;

      internal static ModelHelper.FullNamespaceLocalizer PIrDkMvholFv2rgLZtMI() => (ModelHelper.FullNamespaceLocalizer) ModelHelper.FullNamespaceLocalizer.cqfVfKvhBjMt5WifJmxn;
    }

    private class NamespacePartLocalizer : EleWise.ELMA.SR.ILocalizer
    {
      private readonly object nsMetadata;
      private readonly object nsInfo;
      private readonly object nsPart;
      private static object xeMswNvhbf8HuNWPRack;

      public NamespacePartLocalizer(string ns)
      {
        ModelHelper.NamespacePartLocalizer.mlRmZVvhEEFpL7538fvc();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_7;
            case 1:
              object obj = ModelHelper.NamespacePartLocalizer.UxZAPOvhfWeoCEr2e2ju();
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              this.nsMetadata = obj != null ? (object) ((IMetadataService) obj).GetMetadataList().OfType<NamespaceMetadata>().FirstOrDefault<NamespaceMetadata>((Func<NamespaceMetadata, bool>) (m => ModelHelper.NamespacePartLocalizer.\u003C\u003Ec__DisplayClass3_0.j5JxEYZqREQyWEJFRsIH(ModelHelper.NamespacePartLocalizer.\u003C\u003Ec__DisplayClass3_0.JUenP0Zqibb9goXlEmcZ((object) m), (object) ns))) : (object) (NamespaceMetadata) null;
              num = 2;
              continue;
            case 2:
              object nsMetadata = this.nsMetadata;
              // ISSUE: reference to a compiler-generated method
              this.nsInfo = (nsMetadata == null ? (string) null : ((NamedMetadata) nsMetadata).DisplayName) != null ? (object) (INamespaceInfo) null : (object) ((ComponentManager) ModelHelper.NamespacePartLocalizer.E9UtCdvhQ8fZZIYii3AH()).GetExtensionPoints<INamespaceInfo>().FirstOrDefault<INamespaceInfo>((Func<INamespaceInfo, bool>) (ni => ModelHelper.NamespacePartLocalizer.\u003C\u003Ec__DisplayClass3_0.j5JxEYZqREQyWEJFRsIH((object) ni.Namespace, (object) ns)));
              num = 3;
              continue;
            case 3:
              this.nsPart = ModelHelper.NamespacePartLocalizer.EEEDfcvhvl9USiWsDxn1((object) ns, ModelHelper.NamespacePartLocalizer.hT6NdCvhCXKZk3RfcMt9((object) ns, '.') + 1);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
              continue;
            default:
              goto label_6;
          }
        }
label_7:
        return;
label_6:;
      }

      public string Localize()
      {
        int num = 4;
        object obj;
        string str;
        while (true)
        {
          switch (num)
          {
            case 1:
              object nsInfo = this.nsInfo;
              if (nsInfo == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
                continue;
              }
              obj = ModelHelper.NamespacePartLocalizer.egrRLlvh8Y0BQUlbpMvJ(nsInfo);
              goto label_14;
            case 2:
              goto label_16;
            case 3:
              str = (string) null;
              break;
            case 4:
              object nsMetadata = this.nsMetadata;
              if (nsMetadata == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 3 : 1;
                continue;
              }
              str = ((NamedMetadata) nsMetadata).DisplayName;
              break;
            default:
              obj = (object) null;
              goto label_14;
          }
          if (str == null)
          {
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 0;
            continue;
          }
          break;
label_14:
          if (obj == null)
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 2 : 2;
          else
            goto label_7;
        }
        return str;
label_7:
        return (string) obj;
label_16:
        return (string) this.nsPart;
      }

      internal static void mlRmZVvhEEFpL7538fvc() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static object UxZAPOvhfWeoCEr2e2ju() => (object) MetadataServiceContext.ServiceOrNull;

      internal static object E9UtCdvhQ8fZZIYii3AH() => (object) ComponentManager.Current;

      internal static int hT6NdCvhCXKZk3RfcMt9([In] object obj0, [In] char obj1) => ((string) obj0).LastIndexOf(obj1);

      internal static object EEEDfcvhvl9USiWsDxn1([In] object obj0, [In] int obj1) => (object) ((string) obj0).Substring(obj1);

      internal static bool w1q5RNvhhblw3ImTiuNL() => ModelHelper.NamespacePartLocalizer.xeMswNvhbf8HuNWPRack == null;

      internal static ModelHelper.NamespacePartLocalizer c4Da46vhGkZNKew0RihR() => (ModelHelper.NamespacePartLocalizer) ModelHelper.NamespacePartLocalizer.xeMswNvhbf8HuNWPRack;

      internal static object egrRLlvh8Y0BQUlbpMvJ([In] object obj0) => (object) ((INamespaceInfo) obj0).DisplayName;
    }
  }
}
