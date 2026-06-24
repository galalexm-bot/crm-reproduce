// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Services.ExtendedMetadataService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Services
{
  /// <summary>
  /// Сервис метаданных, используемый для добавления метаданных к существующему сервису управления метаданных
  /// </summary>
  public class ExtendedMetadataService : IMetadataService
  {
    private IMetadataService source;
    private Dictionary<Guid, IMetadata> metadataByUid;
    internal static ExtendedMetadataService faPFJsbZbv9m0TxxhjgF;

    /// <summary>Ctor</summary>
    /// <param name="source">Исходный сервис метаданных</param>
    /// <param name="metadataList">Список метаданных</param>
    public ExtendedMetadataService(IMetadataService source, IEnumerable<IMetadata> metadataList)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.metadataByUid = new Dictionary<Guid, IMetadata>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.source = source;
      if (metadataList == null)
        return;
      foreach (IMetadata metadata in metadataList)
        this.ProcessMetadata(metadata);
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return metadata;
label_3:
      return this.source.GetMetadata(metadataUid, loadImplementation);
    }

    /// <summary>Получить список метаданных</summary>
    /// <returns>Список метаданных</returns>
    public IEnumerable<IMetadata> GetMetadataList() => this.metadataByUid.Values.Union<IMetadata>(this.source.GetMetadataList());

    /// <summary>Получить описание доступных типов данных</summary>
    /// <returns>Список типов данных</returns>
    public IEnumerable<ITypeDescriptor> GetTypeDescriptors() => this.source.GetTypeDescriptors();

    /// <summary>
    /// Получить описание типа данных по его уникальному идентификатору. Если не нашли - null
    /// </summary>
    /// <param name="typeUid">Уникальный идентификатор типа данных</param>
    /// <param name="subTypeUid">Уникальный идентификатор подтипа</param>
    /// <returns>Описание типа данных</returns>
    public ITypeDescriptor GetTypeDescriptor(Guid typeUid, Guid subTypeUid) => (ITypeDescriptor) ExtendedMetadataService.G1jeL8bZEqhGJ8fkmJnG((object) this.source, typeUid, subTypeUid);

    public ITypeDescriptor GetTypeDescriptor(Type runtimeType) => (ITypeDescriptor) ExtendedMetadataService.gGLWIbbZfPdm1kXJwFbH((object) this.source, runtimeType);

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
    public ITypeDescriptor GetIdTypeDescriptor(Guid typeUid) => (ITypeDescriptor) ExtendedMetadataService.ioKQiNbZQWMVXxFQBKZ9((object) this.source, typeUid);

    /// <inheritdoc />
    public bool IsSystem(Guid typeUid) => ExtendedMetadataService.BeSHvMbZCBJC1J0MGtpB((object) this.source, typeUid);

    /// <inheritdoc />
    public bool IsConfig(Guid typeUid)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.metadataByUid.ContainsKey(typeUid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 2:
            if (!ExtendedMetadataService.GflC5WbZvsavfs4kkeb9((object) this.source, typeUid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 1 : 1;
              continue;
            }
            goto label_8;
          default:
            goto label_6;
        }
      }
label_6:
      return !ExtendedMetadataService.BeSHvMbZCBJC1J0MGtpB((object) this.source, typeUid);
label_7:
      return false;
label_8:
      return true;
    }

    private void ProcessMetadata(IMetadata metadata)
    {
      int num1 = 2;
      IEnumerable<IMetadata> compositeParts;
      IEnumerator<IMetadata> enumerator;
      ICompositeMetadata compositeMetadata;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_25;
          case 1:
            compositeMetadata = metadata as ICompositeMetadata;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 6;
            continue;
          case 2:
            this.metadataByUid[ExtendedMetadataService.trlR6wbZ8ZvRF7DXNI4d((object) metadata)] = metadata;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 1;
            continue;
          case 3:
            enumerator = compositeParts.GetEnumerator();
            num1 = 7;
            continue;
          case 4:
            goto label_20;
          case 5:
            goto label_14;
          case 6:
            if (compositeMetadata == null)
            {
              num1 = 5;
              continue;
            }
            goto case 9;
          case 7:
            goto label_12;
          case 8:
            if (compositeParts == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 3 : 4;
              continue;
            }
            goto case 3;
          case 9:
            compositeParts = compositeMetadata.GetCompositeParts();
            num1 = 8;
            continue;
          default:
            goto label_11;
        }
      }
label_25:
      return;
label_20:
      return;
label_14:
      return;
label_11:
      return;
label_12:
      try
      {
label_15:
        if (ExtendedMetadataService.o9ZRcobZZUfmWTMMKTlx((object) enumerator))
          goto label_17;
        else
          goto label_16;
label_13:
        IMetadata current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.ProcessMetadata(current);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_8;
            case 3:
              goto label_17;
            default:
              goto label_15;
          }
        }
label_8:
        return;
label_16:
        num2 = 2;
        goto label_13;
label_17:
        current = enumerator.Current;
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
        {
          num2 = 1;
          goto label_13;
        }
        else
          goto label_13;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_27;
              default:
                enumerator.Dispose();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_27:;
      }
    }

    internal static bool JLUsAxbZhhmBrgVRRQXG() => ExtendedMetadataService.faPFJsbZbv9m0TxxhjgF == null;

    internal static ExtendedMetadataService qsLnVobZGQy9DgvDAdmp() => ExtendedMetadataService.faPFJsbZbv9m0TxxhjgF;

    internal static object G1jeL8bZEqhGJ8fkmJnG([In] object obj0, Guid typeUid, Guid subTypeUid) => (object) ((IMetadataService) obj0).GetTypeDescriptor(typeUid, subTypeUid);

    internal static object gGLWIbbZfPdm1kXJwFbH([In] object obj0, Type runtimeType) => (object) ((IMetadataService) obj0).GetTypeDescriptor(runtimeType);

    internal static object ioKQiNbZQWMVXxFQBKZ9([In] object obj0, Guid typeUid) => (object) ((IMetadataService) obj0).GetIdTypeDescriptor(typeUid);

    internal static bool BeSHvMbZCBJC1J0MGtpB([In] object obj0, Guid typeUid) => ((IMetadataService) obj0).IsSystem(typeUid);

    internal static bool GflC5WbZvsavfs4kkeb9([In] object obj0, Guid typeUid) => ((IMetadataService) obj0).IsConfig(typeUid);

    internal static Guid trlR6wbZ8ZvRF7DXNI4d([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static bool o9ZRcobZZUfmWTMMKTlx([In] object obj0) => ((IEnumerator) obj0).MoveNext();
  }
}
