// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.DTO.Manager.GlobalScriptModuleHeaderDtoManager
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
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts.DTO.Manager
{
  public class GlobalScriptModuleHeaderDtoManager : 
    DTOManager,
    IGlobalScriptModuleHeaderDtoManager,
    IConfigurationService
  {
    internal static GlobalScriptModuleHeaderDtoManager WQgFhIbXb0Ow90IYJbjp;

    /// <summary>Менеджер управления заголовками процессов</summary>
    public GlobalScriptModuleHeaderManager GlobalScriptModuleHeaderManager
    {
      get => this.\u003CGlobalScriptModuleHeaderManager\u003Ek__BackingField;
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
              this.\u003CGlobalScriptModuleHeaderManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
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

    /// <summary>Менеджер управления глобальными модулями</summary>
    public GlobalScriptModuleManager GlobalScriptModuleManager
    {
      get => this.\u003CGlobalScriptModuleManager\u003Ek__BackingField;
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
              this.\u003CGlobalScriptModuleManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
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

    /// <summary>Загрузить заголовок процесса</summary>
    /// <param name="id">Id заголовка</param>
    /// <returns>Заголовок процесса</returns>
    public virtual GlobalScriptModuleHeaderDto LoadOrNull(long id) => Mapper.Map<IGlobalScriptModuleHeader, GlobalScriptModuleHeaderDto>(this.GlobalScriptModuleHeaderManager.LoadOrNull(id), new GlobalScriptModuleHeaderDto());

    /// <summary>Загрузить заголовок процесса</summary>
    /// <param name="uid">Uid заголовка</param>
    /// <returns>Заголовок процесса</returns>
    public virtual GlobalScriptModuleHeaderDto LoadOrNull(Guid uid) => Mapper.Map<IGlobalScriptModuleHeader, GlobalScriptModuleHeaderDto>(this.GlobalScriptModuleHeaderManager.LoadOrNull(uid), new GlobalScriptModuleHeaderDto());

    /// <summary>Сохранить заголовок процесса</summary>
    /// <param name="header">Заголовок</param>
    public virtual GlobalScriptModuleHeaderDto Save(GlobalScriptModuleHeaderDto header)
    {
      int num = 1;
      IGlobalScriptModuleHeader source;
      while (true)
      {
        switch (num)
        {
          case 1:
            source = Mapper.Map<GlobalScriptModuleHeaderDto, IGlobalScriptModuleHeader>(header);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.GlobalScriptModuleHeaderManager.Save(source);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 2 : 2;
            continue;
        }
      }
label_3:
      return Mapper.Map<IGlobalScriptModuleHeader, GlobalScriptModuleHeaderDto>(source, new GlobalScriptModuleHeaderDto());
    }

    public virtual IEnumerable<GlobalScriptModuleHeaderDto> LoadGlobalScriptModulesByName(
      string headerName)
    {
      return (IEnumerable<GlobalScriptModuleHeaderDto>) this.GlobalScriptModuleHeaderManager.Find((Expression<Func<IGlobalScriptModuleHeader, bool>>) (scriptModuleHeader => scriptModuleHeader.Name == headerName)).Select<IGlobalScriptModuleHeader, GlobalScriptModuleHeaderDto>((Func<IGlobalScriptModuleHeader, GlobalScriptModuleHeaderDto>) (h => Mapper.Map<IGlobalScriptModuleHeader, GlobalScriptModuleHeaderDto>(h, new GlobalScriptModuleHeaderDto()))).ToList<GlobalScriptModuleHeaderDto>();
    }

    /// <summary>
    /// Получить все опубликованные заголовки пользовательских расширений
    /// </summary>
    /// <returns></returns>
    public virtual IEnumerable<GlobalScriptModuleHeaderDto> LoadPublishedGlobalScriptModuleHeaders() => this.LoadPublishedGlobalScriptModuleHeaders(true);

    /// <summary>
    /// Получить все опубликованные заголовки пользовательских расширений
    /// </summary>
    /// <returns></returns>
    public virtual IEnumerable<GlobalScriptModuleHeaderDto> LoadPublishedGlobalScriptModuleHeaders(
      bool deletedIncluded)
    {
      if (!deletedIncluded)
        return (IEnumerable<GlobalScriptModuleHeaderDto>) this.GlobalScriptModuleHeaderManager.Find((Expression<Func<IGlobalScriptModuleHeader, bool>>) (scriptModuleHeader => scriptModuleHeader.Published != default (object) && scriptModuleHeader.Deleted != true)).Select<IGlobalScriptModuleHeader, GlobalScriptModuleHeaderDto>((Func<IGlobalScriptModuleHeader, GlobalScriptModuleHeaderDto>) (h => Mapper.Map<IGlobalScriptModuleHeader, GlobalScriptModuleHeaderDto>(h, new GlobalScriptModuleHeaderDto()))).ToList<GlobalScriptModuleHeaderDto>();
      return (IEnumerable<GlobalScriptModuleHeaderDto>) this.GlobalScriptModuleHeaderManager.Find((Expression<Func<IGlobalScriptModuleHeader, bool>>) (scriptModuleHeader => scriptModuleHeader.Published != default (object))).Select<IGlobalScriptModuleHeader, GlobalScriptModuleHeaderDto>((Func<IGlobalScriptModuleHeader, GlobalScriptModuleHeaderDto>) (h => Mapper.Map<IGlobalScriptModuleHeader, GlobalScriptModuleHeaderDto>(h, new GlobalScriptModuleHeaderDto()))).ToList<GlobalScriptModuleHeaderDto>();
    }

    public virtual IEnumerable<GlobalScriptModuleHeaderDto> LoadRuntimeLoadedHeaders() => (IEnumerable<GlobalScriptModuleHeaderDto>) this.GlobalScriptModuleHeaderManager.LoadRuntimeLoadedHeaders().Select<IGlobalScriptModuleHeader, GlobalScriptModuleHeaderDto>((Func<IGlobalScriptModuleHeader, GlobalScriptModuleHeaderDto>) (h => Mapper.Map<IGlobalScriptModuleHeader, GlobalScriptModuleHeaderDto>(h, new GlobalScriptModuleHeaderDto()))).ToList<GlobalScriptModuleHeaderDto>();

    /// <summary>
    /// Удаление заголовка пользовательского расширения.
    /// Сущность из базы не удаляется.
    /// </summary>
    /// <param name="header"></param>
    public virtual void Delete(GlobalScriptModuleHeaderDto header)
    {
      int num = 3;
      IGlobalScriptModuleHeader destination;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            Mapper.Map<GlobalScriptModuleHeaderDto, IGlobalScriptModuleHeader>(header, destination);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 2 : 4;
            continue;
          case 2:
            destination = this.GlobalScriptModuleHeaderManager.Load(header.Id);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 1;
            continue;
          case 3:
            GlobalScriptModuleHeaderDtoManager.hmqGb1bXEvFkJYvyRifE((object) header, true);
            num = 2;
            continue;
          case 4:
            this.GlobalScriptModuleHeaderManager.Save(destination);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:;
    }

    /// <summary>Получить raw сборки</summary>
    /// <param name="headerUid"></param>
    /// <returns></returns>
    public virtual byte[] GetAssemblyRaw(Guid headerUid) => (byte[]) GlobalScriptModuleHeaderDtoManager.KGwE6rbXff7GWT8shcI3((object) this.GlobalScriptModuleHeaderManager, headerUid);

    /// <summary>
    /// Проверить, можно ли использовать указанное имя пользовательского расширения
    /// </summary>
    /// <param name="id">Id заголовка пользовательского расширения. Если пользовательское расширение новое, то 0</param>
    /// <param name="name">Имя пользовательского расширения</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns>True, если имя использовать можно</returns>
    public virtual bool CheckGlobalScriptModuleName(long id, string name, out string errorMessage) => this.GlobalScriptModuleHeaderManager.CheckGlobalScriptModuleName(id, name, out errorMessage);

    /// <summary>Получить все заголовки глобальных модулей сценариев</summary>
    /// <returns></returns>
    public virtual IEnumerable<GlobalScriptModuleHeaderDto> LoadAllGlobalScriptModuleHeaders()
    {
      IGlobalScriptModuleHeaderFilter filter = InterfaceActivator.Create<IGlobalScriptModuleHeaderFilter>();
      filter.Deleted = new bool?(false);
      return (IEnumerable<GlobalScriptModuleHeaderDto>) this.GlobalScriptModuleHeaderManager.Find((IEntityFilter) filter, (FetchOptions) null).Select<IGlobalScriptModuleHeader, GlobalScriptModuleHeaderDto>((Func<IGlobalScriptModuleHeader, GlobalScriptModuleHeaderDto>) (h => Mapper.Map<IGlobalScriptModuleHeader, GlobalScriptModuleHeaderDto>(h, new GlobalScriptModuleHeaderDto()))).ToList<GlobalScriptModuleHeaderDto>();
    }

    /// <summary>
    /// Проверить, можно ли использовать указанное имя для класса контекста пользовательского расширения
    /// </summary>
    /// <param name="id">Id заголовка пользовательского расширения. Если пользовательское расширение новое, то 0</param>
    /// <param name="name">Имя класса контекста пользовательского расширения</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns>True, если имя использовать можно</returns>
    public virtual bool CheckGlobalScriptModuleClassName(
      long id,
      string name,
      out string errorMessage)
    {
      return this.GlobalScriptModuleHeaderManager.CheckGlobalScriptModuleClassName(id, name, out errorMessage);
    }

    /// <summary>
    /// Проверить, можно ли использовать указанное имя для таблицы контекста пользовательского расширения
    /// </summary>
    /// <param name="id">Id заголовка пользовательского расширения. Если пользовательское расширение новое, то 0</param>
    /// <param name="name">Имя таблицы контекста пользовательского расширения</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns>True, если имя использовать можно</returns>
    public virtual bool CheckGlobalScriptModuleTableName(
      long id,
      string name,
      out string errorMessage)
    {
      return this.GlobalScriptModuleHeaderManager.CheckGlobalScriptModuleTableName(id, name, out errorMessage);
    }

    public GlobalScriptModuleHeaderDtoManager()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool ltGCVHbXh0MrvcNOniD9() => GlobalScriptModuleHeaderDtoManager.WQgFhIbXb0Ow90IYJbjp == null;

    internal static GlobalScriptModuleHeaderDtoManager JLPsX6bXGGgpkXYenRmf() => GlobalScriptModuleHeaderDtoManager.WQgFhIbXb0Ow90IYJbjp;

    internal static void hmqGb1bXEvFkJYvyRifE([In] object obj0, bool value) => ((GlobalScriptModuleHeaderDto) obj0).Deleted = value;

    internal static object KGwE6rbXff7GWT8shcI3([In] object obj0, Guid headerUid) => (object) ((GlobalScriptModuleHeaderManager) obj0).GetAssemblyRaw(headerUid);
  }
}
