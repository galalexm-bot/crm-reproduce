// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Services.ConfigurationModelBuilderMetadataService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Services
{
  /// <summary>
  /// Сервис метаданных, используемый при построении сборки конфигурации
  /// </summary>
  public class ConfigurationModelBuilderMetadataService : IMetadataService
  {
    private IMetadataRuntimeService source;
    private Dictionary<Guid, IMetadata> metadataByUid;
    private static ConfigurationModelBuilderMetadataService O7JNMnb8LJFEShpQpnKo;

    /// <summary>Ctor</summary>
    /// <param name="source">Исходный сервис метаданных</param>
    /// <param name="metadataList">Список метаданных</param>
    public ConfigurationModelBuilderMetadataService(
      IMetadataRuntimeService source,
      IEnumerable<IMetadata> metadataList)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.metadataByUid = new Dictionary<Guid, IMetadata>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.source = source;
      foreach (IMetadata metadata in source.GetMetadataList())
        this.metadataByUid[metadata.Uid] = metadata;
      if (metadataList == null)
        return;
      foreach (IMetadata metadata in metadataList)
        this.AddMetadata(metadata);
    }

    /// <summary>Добавить объект метаданных</summary>
    /// <param name="metadata"></param>
    public void AddMetadata(IMetadata metadata)
    {
      int num1 = 3;
      IEnumerator<IMetadata> enumerator;
      while (true)
      {
        int num2 = num1;
        ICompositeMetadata compositeMetadata;
        IEnumerable<IMetadata> compositeParts;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (compositeParts != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
                continue;
              }
              goto label_16;
            case 2:
              compositeMetadata = metadata as ICompositeMetadata;
              num2 = 7;
              continue;
            case 3:
              goto label_22;
            case 4:
              goto label_23;
            case 5:
              goto label_4;
            case 6:
              goto label_3;
            case 7:
              if (compositeMetadata == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 2 : 6;
                continue;
              }
              goto case 8;
            case 8:
              compositeParts = compositeMetadata.GetCompositeParts();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 1 : 1;
              continue;
            default:
              enumerator = compositeParts.GetEnumerator();
              num2 = 5;
              continue;
          }
        }
label_22:
        this.metadataByUid[ConfigurationModelBuilderMetadataService.H5m33Cb8cqmVGB1PTNNs((object) metadata)] = metadata;
        num1 = 2;
      }
label_23:
      return;
label_3:
      return;
label_4:
      try
      {
label_8:
        if (enumerator.MoveNext())
          goto label_7;
        else
          goto label_9;
label_5:
        IMetadata current;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_11;
            case 1:
              goto label_8;
            case 2:
              goto label_7;
            case 3:
              this.AddMetadata(current);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 1 : 1;
              continue;
            default:
              goto label_6;
          }
        }
label_11:
        return;
label_6:
        return;
label_7:
        current = enumerator.Current;
        num3 = 3;
        goto label_5;
label_9:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
        goto label_5;
      }
      finally
      {
        if (enumerator != null)
        {
          int num4 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
            num4 = 1;
          while (true)
          {
            switch (num4)
            {
              case 1:
                enumerator.Dispose();
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
                continue;
              default:
                goto label_18;
            }
          }
        }
label_18:;
      }
label_16:;
    }

    /// <summary>Получить объект метаданных по Uid-у</summary>
    /// <param name="metadataUid">Uid объекта метаданных</param>
    /// <param name="loadImplementation">Загружать ли метаданные реализации, если указанный тип - интерфейс</param>
    /// <returns>Метаданные</returns>
    public IMetadata GetMetadata(Guid metadataUid, bool loadImplementation = true)
    {
      int num = 1;
      IMetadata metadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.metadataByUid.TryGetValue(metadataUid, out metadata))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
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
      throw new ObjectNotFoundException(this.metadataByUid.ToString(), EleWise.ELMA.SR.T((string) ConfigurationModelBuilderMetadataService.i04yJ6b8zyqj7Bclr17f(~541731958 ^ -541610879), (object) metadataUid));
label_3:
      return metadata;
    }

    /// <summary>Получить список метаданных</summary>
    /// <returns>Список метаданных</returns>
    public IEnumerable<IMetadata> GetMetadataList() => (IEnumerable<IMetadata>) this.metadataByUid.Values;

    /// <summary>Получить описание доступных типов данных</summary>
    /// <returns>Список типов данных</returns>
    public IEnumerable<ITypeDescriptor> GetTypeDescriptors() => this.source.GetTypeDescriptors();

    /// <summary>
    /// Получить описание типа данных по его уникальному идентификатору. Если не нашли - null
    /// </summary>
    /// <param name="typeUid">Уникальный идентификатор типа данных</param>
    /// <param name="subTypeUid">Уникальный идентификатор подтипа</param>
    /// <returns>Описание типа данных</returns>
    public ITypeDescriptor GetTypeDescriptor(Guid typeUid, Guid subTypeUid) => (ITypeDescriptor) ConfigurationModelBuilderMetadataService.sWIPyEbZF3DQeg784MCR((object) this.source, typeUid, subTypeUid);

    /// <summary>
    /// Получить описание типа данных по его уникальному идентификатору. Если не нашли - null
    /// </summary>
    /// <param name="runtimeType">Тип CLR</param>
    /// <returns>Описание типа данных</returns>
    public ITypeDescriptor GetTypeDescriptor(Type runtimeType) => (ITypeDescriptor) ConfigurationModelBuilderMetadataService.JXsATvbZBRIbiPYIUjin((object) this.source, runtimeType);

    /// <summary>
    /// Получить описание типов данных, которые можно использовать для первичного ключа
    /// </summary>
    /// <returns>Список типов данных</returns>
    public IEnumerable<ITypeDescriptor> GetIdTypeDescriptors() => this.source.GetIdTypeDescriptors();

    /// <summary>
    /// Получить описание типа данных, который можно использовать для первичного ключа, по его уникальному идентфикатору. Если не нашли - null
    /// </summary>
    /// <param name="typeUid">Уникальный идентификатор типа данных</param>
    /// <returns>Описание типа данных</returns>
    public ITypeDescriptor GetIdTypeDescriptor(Guid typeUid) => (ITypeDescriptor) ConfigurationModelBuilderMetadataService.g12lb4bZWR0os8UOdgc9((object) this.source, typeUid);

    /// <inheritdoc />
    public bool IsSystem(Guid typeUid) => ConfigurationModelBuilderMetadataService.b39VQlbZoWcSgUfVXvAW((object) this.source, typeUid);

    /// <inheritdoc />
    public bool IsConfig(Guid typeUid)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.source.IsConfig(typeUid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            goto label_2;
          case 3:
            if (this.metadataByUid.ContainsKey(typeUid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 2 : 1;
              continue;
            }
            goto label_3;
          default:
            goto label_4;
        }
      }
label_2:
      return !this.source.IsSystem(typeUid);
label_3:
      return false;
label_4:
      return true;
    }

    internal static Guid H5m33Cb8cqmVGB1PTNNs([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static bool Gw7n1mb8UGeZbDalw9Lq() => ConfigurationModelBuilderMetadataService.O7JNMnb8LJFEShpQpnKo == null;

    internal static ConfigurationModelBuilderMetadataService FLMygjb8sBw4qJOgpox9() => ConfigurationModelBuilderMetadataService.O7JNMnb8LJFEShpQpnKo;

    internal static object i04yJ6b8zyqj7Bclr17f(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object sWIPyEbZF3DQeg784MCR([In] object obj0, Guid typeUid, Guid subTypeUid) => (object) ((IMetadataService) obj0).GetTypeDescriptor(typeUid, subTypeUid);

    internal static object JXsATvbZBRIbiPYIUjin([In] object obj0, Type runtimeType) => (object) ((IMetadataService) obj0).GetTypeDescriptor(runtimeType);

    internal static object g12lb4bZWR0os8UOdgc9([In] object obj0, Guid typeUid) => (object) ((IMetadataService) obj0).GetIdTypeDescriptor(typeUid);

    internal static bool b39VQlbZoWcSgUfVXvAW([In] object obj0, Guid typeUid) => ((IMetadataRuntimeService) obj0).IsSystem(typeUid);
  }
}
