// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.DTO.Manager.ExternalAssemblyDtoManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts.DTO.Manager
{
  public class ExternalAssemblyDtoManager : 
    DTOManager,
    IExternalAssemblyDtoManager,
    IConfigurationService
  {
    internal static ExternalAssemblyDtoManager iDH2mObKPM3uBuvQrfRy;

    /// <summary>Менеджер управления внешними сборками</summary>
    public ExternalAssemblyManager ExternalAssemblyManager
    {
      get => this.\u003CExternalAssemblyManager\u003Ek__BackingField;
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
              this.\u003CExternalAssemblyManager\u003Ek__BackingField = value;
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

    /// <summary>Загрузить по уникальному идентификатору</summary>
    /// <param name="uid"></param>
    /// <returns></returns>
    public virtual ExternalAssemblyDto LoadOrNull(Guid uid) => Mapper.Map<IExternalAssembly, ExternalAssemblyDto>(this.ExternalAssemblyManager.LoadOrNull(uid), new ExternalAssemblyDto());

    public virtual ExternalAssemblyDto Load(string hashCode)
    {
      int num = 1;
      IExternalAssemblyFilter filter;
      while (true)
      {
        switch (num)
        {
          case 1:
            filter = InterfaceActivator.Create<IExternalAssemblyFilter>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            ExternalAssemblyDtoManager.HrRYV6bK36Ttwum2AuiF((object) filter, (object) hashCode);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 2 : 1;
            continue;
        }
      }
label_3:
      return Mapper.Map<IExternalAssembly, ExternalAssemblyDto>(this.ExternalAssemblyManager.Find((IEntityFilter) filter, (FetchOptions) null).FirstOrDefault<IExternalAssembly>(), new ExternalAssemblyDto());
    }

    public virtual string GetHashCode(Guid uid)
    {
      int num = 2;
      ExternalAssemblyDto externalAssemblyDto;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (externalAssemblyDto == null)
            {
              num = 3;
              continue;
            }
            goto label_5;
          case 2:
            externalAssemblyDto = (ExternalAssemblyDto) ExternalAssemblyDtoManager.tW8JhpbKpUC8nq1VKU4K((object) this, uid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_6;
          default:
            goto label_5;
        }
      }
label_5:
      return (string) ExternalAssemblyDtoManager.ad3RbfbKaO9oCJgXMDXy((object) externalAssemblyDto);
label_6:
      return (string) null;
    }

    public virtual Guid? Exist(string hashCode) => this.Load(hashCode)?.Uid;

    /// <summary>Сохранить сборку на сервере</summary>
    /// <param name="externalAssembly"></param>
    public virtual void Save(ExternalAssemblyDto externalAssembly)
    {
      int num = 1;
      IExternalAssembly externalAssembly1;
      while (true)
      {
        switch (num)
        {
          case 1:
            externalAssembly1 = Mapper.Map<ExternalAssemblyDto, IExternalAssembly>(externalAssembly);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.ExternalAssemblyManager.Save(externalAssembly1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    public ExternalAssemblyDtoManager()
    {
      ExternalAssemblyDtoManager.jHHwEabKDZNMAKOY2Tkm();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool o6MF6DbK1Ckg2QiNlxyV() => ExternalAssemblyDtoManager.iDH2mObKPM3uBuvQrfRy == null;

    internal static ExternalAssemblyDtoManager HVxlnPbKNWTMPIHuJsxc() => ExternalAssemblyDtoManager.iDH2mObKPM3uBuvQrfRy;

    internal static void HrRYV6bK36Ttwum2AuiF([In] object obj0, [In] object obj1) => ((IExternalAssemblyFilter) obj0).HashCode = (string) obj1;

    internal static object tW8JhpbKpUC8nq1VKU4K([In] object obj0, Guid uid) => (object) ((ExternalAssemblyDtoManager) obj0).LoadOrNull(uid);

    internal static object ad3RbfbKaO9oCJgXMDXy([In] object obj0) => (object) ((ExternalAssemblyDto) obj0).HashCode;

    internal static void jHHwEabKDZNMAKOY2Tkm() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
