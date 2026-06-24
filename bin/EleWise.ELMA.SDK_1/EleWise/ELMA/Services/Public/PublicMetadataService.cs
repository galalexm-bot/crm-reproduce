// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Public.PublicMetadataService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services.Public
{
  /// <summary>Сервис для работы с метаданными в API</summary>
  [Service(EnableInterceptors = false, Type = ComponentType.Server)]
  public class PublicMetadataService
  {
    private IEnumerable<IPublicMetadataProvider> _providers;
    private IMetadataRuntimeService _metadataRuntimeService;
    internal static PublicMetadataService OW4WL1B0Dy3Zo2CrN71H;

    public PublicMetadataService(
      IEnumerable<IPublicMetadataProvider> providers,
      IMetadataRuntimeService metadataRuntimeService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      if (providers == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574187438));
      if (metadataRuntimeService == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979391490));
      this._providers = providers;
      this._metadataRuntimeService = metadataRuntimeService;
    }

    /// <summary>
    /// Получить список с информацией о группах объектов метаданных
    /// </summary>
    /// <returns></returns>
    public IEnumerable<IPublicMetadataGroupInfo> GetGroupInfoList() => (IEnumerable<IPublicMetadataGroupInfo>) this._providers.SelectMany<IPublicMetadataProvider, IPublicMetadataGroupInfo>((Func<IPublicMetadataProvider, IEnumerable<IPublicMetadataGroupInfo>>) (p => p.GetGroups())).ToArray<IPublicMetadataGroupInfo>();

    /// <summary>Получить список с информацией об объектах метаданных</summary>
    /// <returns></returns>
    public IEnumerable<IPublicMetadataInfo> GetMetadataInfoList() => (IEnumerable<IPublicMetadataInfo>) this._providers.SelectMany<IPublicMetadataProvider, IPublicMetadataInfo>((Func<IPublicMetadataProvider, IEnumerable<IPublicMetadataInfo>>) (p => p.GetMetadataInfoList())).ToArray<IPublicMetadataInfo>();

    /// <summary>Получить список метаданных</summary>
    /// <returns></returns>
    public IEnumerable<IMetadata> GetMetadataList() => (IEnumerable<IMetadata>) this.GetMetadataInfoList().Select<IPublicMetadataInfo, IMetadata>((Func<IPublicMetadataInfo, IMetadata>) (i => (IMetadata) PublicMetadataService.\u003C\u003Ec.fHYvBGQntClom5cMY6GO((object) i))).Where<IMetadata>((Func<IMetadata, bool>) (m => m != null)).ToArray<IMetadata>();

    /// <summary>Загрузить объект метаданных</summary>
    /// <param name="uid"></param>
    /// <returns>Объект метаданных, или NULL</returns>
    public IMetadata LoadMetadata(Guid uid)
    {
      int num = 2;
      IPublicMetadataInfo publicMetadataInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (publicMetadataInfo == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            publicMetadataInfo = this.LoadMetadataInfo(uid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return (IMetadata) null;
label_6:
      return publicMetadataInfo.GetMetadata();
    }

    /// <summary>Загрузить информацию об объекте метаданных</summary>
    /// <param name="uid"></param>
    /// <returns>Информация об объекте метаданных, или NULL</returns>
    public IPublicMetadataInfo LoadMetadataInfo(Guid uid)
    {
      int num = 1;
      Guid uid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            uid1 = uid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 2 : 2;
            continue;
        }
      }
label_3:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.GetMetadataInfoList().FirstOrDefault<IPublicMetadataInfo>((Func<IPublicMetadataInfo, bool>) (i => PublicMetadataService.\u003C\u003Ec__DisplayClass5_0.X2HhxqQn7A0NQ9hYSWL8(PublicMetadataService.\u003C\u003Ec__DisplayClass5_0.AnqoOHQnAogGLaS7yaqA((object) i), uid1)));
    }

    /// <summary>
    /// Получить тип по уникальному идентификатору. Если не найден, вызывается исключение <see cref="T:EleWise.ELMA.Exceptions.TypeNotFoundException" />
    /// </summary>
    /// <param name="uid"></param>
    /// <returns></returns>
    public Type GetTypeByUid(Guid uid)
    {
      Type typeByUidOrNull = this.GetTypeByUidOrNull(uid);
      return !PublicMetadataService.X0CB1MB04oU42UN0xP5I(typeByUidOrNull, (Type) null) ? typeByUidOrNull : throw new TypeNotFoundException(uid);
    }

    /// <summary>
    /// Получить тип по уникальному идентификатору. Если не найден, возвращается NULL
    /// </summary>
    /// <param name="uid"></param>
    /// <returns></returns>
    public Type GetTypeByUidOrNull(Guid uid)
    {
      int num1 = 2;
      IMetadata metadata;
      Type typeByUidOrNull;
      while (true)
      {
        int num2 = num1;
        IPublicMetadataInfo publicMetadataInfo;
        Guid uid1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              uid1 = uid;
              num2 = 7;
              continue;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 0;
              continue;
            case 3:
              goto label_9;
            case 4:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              publicMetadataInfo = this.GetMetadataInfoList().FirstOrDefault<IPublicMetadataInfo>((Func<IPublicMetadataInfo, bool>) (i => PublicMetadataService.\u003C\u003Ec__DisplayClass7_0.bx73OGQnJRC7QD0a5DA2(PublicMetadataService.\u003C\u003Ec__DisplayClass7_0.rLPosvQnMmuWU68m6RL7((object) i), uid1)));
              num2 = 9;
              continue;
            case 5:
              if (metadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
                continue;
              }
              goto label_13;
            case 6:
              goto label_13;
            case 7:
              typeByUidOrNull = this._metadataRuntimeService.GetTypeByUidOrNull(uid1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 8 : 6;
              continue;
            case 8:
              if (!(typeByUidOrNull == (Type) null))
              {
                num2 = 6;
                continue;
              }
              goto case 4;
            case 9:
              if (publicMetadataInfo != null)
              {
                num2 = 3;
                continue;
              }
              goto label_13;
            default:
              goto label_12;
          }
        }
label_9:
        metadata = (IMetadata) PublicMetadataService.Bb6Lh0B06FciwKP6kDmB((object) publicMetadataInfo);
        num1 = 5;
      }
label_12:
      return this._metadataRuntimeService.GetTypeByUidOrNull(PublicMetadataService.cAZvnMB0HsJWbQKVutXL((object) metadata));
label_13:
      return typeByUidOrNull;
    }

    internal static bool e4FOH2B0tZwuP3dSXA1S() => PublicMetadataService.OW4WL1B0Dy3Zo2CrN71H == null;

    internal static PublicMetadataService ud5XgVB0wAXy7E4V1hAg() => PublicMetadataService.OW4WL1B0Dy3Zo2CrN71H;

    internal static bool X0CB1MB04oU42UN0xP5I([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object Bb6Lh0B06FciwKP6kDmB([In] object obj0) => (object) ((IPublicMetadataInfo) obj0).GetMetadata();

    internal static Guid cAZvnMB0HsJWbQKVutXL([In] object obj0) => ((IMetadata) obj0).Uid;
  }
}
