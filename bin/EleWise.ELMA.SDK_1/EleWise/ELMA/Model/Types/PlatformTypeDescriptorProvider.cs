// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.PlatformTypeDescriptorProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>
  /// Базовая реализация провайдера, возвращающий список типов для отображения в группе "Объекты платформы"
  /// </summary>
  [Component]
  public abstract class PlatformTypeDescriptorProvider : IPlatformTypeDescriptorProvider
  {
    internal static PlatformTypeDescriptorProvider Ea2Ea0oJbHMiIiL5IaLY;

    /// <summary>Получить список типов</summary>
    /// <returns></returns>
    public abstract IEnumerable<ITypeDescriptor> GetTypeDescriptors();

    /// <summary>Создать дескриптор для сущности</summary>
    /// <param name="uid">Uid сущности</param>
    /// <returns></returns>
    protected ITypeDescriptor CreateEntityDescriptor(Guid uid)
    {
      int num = 3;
      ITypeDescriptor baseTypeDescriptor;
      EntityMetadata entityMetadata;
      while (true)
      {
        IMetadataService serviceOrNull;
        object obj;
        switch (num)
        {
          case 1:
            if (serviceOrNull != null)
            {
              num = 7;
              continue;
            }
            goto case 4;
          case 2:
            if (entityMetadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 3:
            entityMetadata = this.GetEntityMetadata(uid);
            num = 2;
            continue;
          case 4:
            obj = (object) null;
            break;
          case 5:
            goto label_4;
          case 6:
            if (baseTypeDescriptor == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 7 : 8;
              continue;
            }
            goto label_12;
          case 7:
            obj = PlatformTypeDescriptorProvider.jo77uioJELBTeRei9YMB((object) serviceOrNull, EntityDescriptor.UID, Guid.Empty);
            break;
          case 8:
            goto label_11;
          default:
            serviceOrNull = MetadataServiceContext.ServiceOrNull;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 1 : 1;
            continue;
        }
        baseTypeDescriptor = (ITypeDescriptor) obj;
        num = 6;
      }
label_4:
      return (ITypeDescriptor) null;
label_11:
      return (ITypeDescriptor) null;
label_12:
      return (ITypeDescriptor) new SubTypeDescriptor(baseTypeDescriptor, PlatformTypeDescriptorProvider.HRZpaFoJfnIHSGATd2J0((object) entityMetadata), (string) PlatformTypeDescriptorProvider.eNP5aBoJQnn9WxJRku0P((object) entityMetadata));
    }

    /// <summary>Создать дескриптор для сущности</summary>
    /// <typeparam name="T">Тип сущности</typeparam>
    /// <returns></returns>
    protected ITypeDescriptor CreateEntityDescriptor<T>()
    {
      UidAttribute attribute = AttributeHelper<UidAttribute>.GetAttribute(typeof (T), true);
      return this.CreateEntityDescriptor(attribute != null ? attribute.Uid : Guid.Empty);
    }

    private EntityMetadata GetEntityMetadata(Guid uid)
    {
      int num1 = 2;
      Guid uid1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            uid1 = uid;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      return ((IMetadataService) PlatformTypeDescriptorProvider.NVBiGkoJCK0XSkNqeeiD()).GetMetadataList().OfType<EntityMetadata>().Where<EntityMetadata>((Func<EntityMetadata, bool>) (m =>
      {
        int num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              if (PlatformTypeDescriptorProvider.\u003C\u003Ec.QgbUjoCVz7kIAquHqLCb((object) m) != EntityMetadataType.Interface)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        return m.Type == EntityMetadataType.Entity;
label_3:
        return true;
      })).FirstOrDefault<EntityMetadata>((Func<EntityMetadata, bool>) (m => PlatformTypeDescriptorProvider.\u003C\u003Ec__DisplayClass3_0.weCoAsCVYoUKL5GCaRAq(m.Uid, uid1)));
    }

    protected PlatformTypeDescriptorProvider()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object jo77uioJELBTeRei9YMB([In] object obj0, Guid typeUid, Guid subTypeUid) => (object) ((IMetadataService) obj0).GetTypeDescriptor(typeUid, subTypeUid);

    internal static Guid HRZpaFoJfnIHSGATd2J0([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object eNP5aBoJQnn9WxJRku0P([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static bool Oxs8cdoJhMe08j6f3rah() => PlatformTypeDescriptorProvider.Ea2Ea0oJbHMiIiL5IaLY == null;

    internal static PlatformTypeDescriptorProvider GxeTGGoJGmgvJqyPHdmc() => PlatformTypeDescriptorProvider.Ea2Ea0oJbHMiIiL5IaLY;

    internal static object NVBiGkoJCK0XSkNqeeiD() => (object) MetadataServiceContext.Service;
  }
}
