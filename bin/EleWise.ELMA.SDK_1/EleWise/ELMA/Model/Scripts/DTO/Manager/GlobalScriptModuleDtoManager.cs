// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.DTO.Manager.GlobalScriptModuleDtoManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Model.Scripts.Exceptions;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Model.Scripts.Types;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts.DTO.Manager
{
  public class GlobalScriptModuleDtoManager : 
    DTOManager,
    IGlobalScriptModuleDtoManager,
    IConfigurationService
  {
    private bool needRestartServer;
    internal static GlobalScriptModuleDtoManager QUskpqbK6Y0i9Tklt0kD;

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
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

    public virtual GlobalScriptModuleDto Publish(GlobalScriptModuleDto gsm)
    {
      int num1 = 8;
      IGlobalScriptModule destination;
      long id;
      while (true)
      {
        switch (num1)
        {
          case 1:
            gsm = (GlobalScriptModuleDto) GlobalScriptModuleDtoManager.BSHlxObKJERtsmX48WFj((object) this, id);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 10 : 4;
            continue;
          case 2:
            try
            {
              GlobalScriptModuleDtoManager.DNUkv6bKyOWesR7GwjF3((object) this.GlobalScriptModuleManager, (object) destination);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_18;
              }
            }
            catch
            {
              int num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
                num3 = 0;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    GlobalScriptModuleDtoManager.pfGsTGbKMVXN6VGRnTh1((object) destination);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_9;
                }
              }
label_9:
              throw;
            }
          case 3:
            GlobalScriptModuleDtoManager.RmUvyLbK0QxGBaBJdCyL((object) gsm);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 9 : 0;
            continue;
          case 4:
label_18:
            this.needRestartServer = true;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 1;
            continue;
          case 5:
            GlobalScriptModuleDtoManager.himGnibKmnRchmFxbkHO((object) destination);
            num1 = 2;
            continue;
          case 6:
            id = gsm.Id;
            num1 = 3;
            continue;
          case 7:
            this.Save(gsm);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 1 : 6;
            continue;
          case 8:
            GlobalScriptModuleDtoManager.FG8PNDbKxHfmsmOlekhN((object) gsm, GlobalScriptModuleDtoManager.tm3HPKbK7Pf5w5sIaaPD(-1146510045 ^ -1146394777));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 7 : 6;
            continue;
          case 9:
            destination = this.GlobalScriptModuleManager.Create();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
            continue;
          case 10:
            goto label_16;
          default:
            Mapper.Map<GlobalScriptModuleDto, IGlobalScriptModule>(gsm, destination);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 5 : 2;
            continue;
        }
      }
label_16:
      return gsm;
    }

    public virtual GlobalScriptModuleDto Validate(GlobalScriptModuleDto gsm)
    {
      int num = 7;
      long id;
      IGlobalScriptModule globalScriptModule;
      while (true)
      {
        switch (num)
        {
          case 1:
            gsm = (GlobalScriptModuleDto) GlobalScriptModuleDtoManager.BSHlxObKJERtsmX48WFj((object) this, id);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
            continue;
          case 2:
            this.GlobalScriptModuleManager.Validate(globalScriptModule);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 1;
            continue;
          case 3:
            globalScriptModule = this.GlobalScriptModuleManager.Create();
            num = 4;
            continue;
          case 4:
            Mapper.Map<GlobalScriptModuleDto, IGlobalScriptModule>(gsm, globalScriptModule);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 2 : 2;
            continue;
          case 5:
            GlobalScriptModuleDtoManager.RmUvyLbK0QxGBaBJdCyL((object) gsm);
            num = 3;
            continue;
          case 6:
            GlobalScriptModuleDtoManager.vE1hNabK92NUIZy8p2EL((object) this, (object) gsm);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 8 : 3;
            continue;
          case 7:
            GlobalScriptModuleDtoManager.FG8PNDbKxHfmsmOlekhN((object) gsm, GlobalScriptModuleDtoManager.tm3HPKbK7Pf5w5sIaaPD(-643786247 ^ -643671107));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 3 : 6;
            continue;
          case 8:
            id = gsm.Id;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 5;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return gsm;
    }

    /// <summary>Нужна ли перезагрузка сервера</summary>
    /// <returns></returns>
    public virtual bool NeedRestartServer() => this.needRestartServer;

    public virtual GlobalScriptModuleDto Save(GlobalScriptModuleDto gsm)
    {
      int num1 = 6;
      IGlobalScriptModule globalScriptModule1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          IGlobalScriptModule globalScriptModule2;
          switch (num2)
          {
            case 1:
              this.GlobalScriptModuleManager.Save(globalScriptModule1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 1 : 4;
              continue;
            case 2:
              globalScriptModule2 = this.GlobalScriptModuleManager.Create();
              break;
            case 3:
              this.GlobalScriptModuleHeaderManager.Save((IGlobalScriptModuleHeader) GlobalScriptModuleDtoManager.VrUcMbbKl0CXjiLqlHue((object) globalScriptModule1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
              continue;
            case 4:
              GlobalScriptModuleDtoManager.OQZbr6bKdsjVsInX49hi((object) globalScriptModule1.Header, (object) globalScriptModule1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 1 : 3;
              continue;
            case 5:
              IGlobalScriptModule globalScriptModule3 = this.GlobalScriptModuleManager.LoadOrNull(gsm.Id);
              if (globalScriptModule3 != null)
              {
                globalScriptModule2 = globalScriptModule3;
                break;
              }
              goto label_10;
            case 6:
              goto label_6;
            case 7:
              Mapper.Map<GlobalScriptModuleDto, IGlobalScriptModule>(gsm, globalScriptModule1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 1 : 1;
              continue;
            default:
              goto label_7;
          }
          globalScriptModule1 = globalScriptModule2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 7 : 2;
        }
label_6:
        Contract.ArgumentNotNull((object) gsm, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882306266));
        num1 = 5;
        continue;
label_10:
        num1 = 2;
      }
label_7:
      return Mapper.Map<IGlobalScriptModule, GlobalScriptModuleDto>(globalScriptModule1, gsm);
    }

    /// <summary>
    /// Загрузить пользовательское расширение по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор пользовательского расширения</param>
    /// <returns>Пользовательское расширение</returns>
    public virtual GlobalScriptModuleDto LoadOrNull(long id) => Mapper.Map<IGlobalScriptModule, GlobalScriptModuleDto>(this.GlobalScriptModuleManager.LoadOrNull(id), new GlobalScriptModuleDto());

    /// <summary>
    /// Загрузить пользовательское расширение по идентификатору
    /// </summary>
    /// <param name="uid">Идентификатор глобального модуля</param>
    /// <returns>Глобальный модуль</returns>
    public virtual GlobalScriptModuleDto LoadOrNull(Guid uid) => Mapper.Map<IGlobalScriptModule, GlobalScriptModuleDto>(this.GlobalScriptModuleManager.LoadOrNull(uid), new GlobalScriptModuleDto());

    public virtual void DeleteDirectory(string directoryPath)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            GlobalScriptModuleDtoManager.D1pO7ZbKrNlPcjt4gLM5((object) this.GlobalScriptModuleManager, (object) directoryPath);
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

    /// <summary>Загрузить пользовательское расширение</summary>
    /// <param name="id">Идентификатор пользовательского расширения</param>
    /// <returns></returns>
    public virtual GlobalScriptModuleDto Load(long id) => Mapper.Map<IGlobalScriptModule, GlobalScriptModuleDto>(this.GlobalScriptModuleManager.Load(id), new GlobalScriptModuleDto());

    /// <summary>Загрузить модуль сценариев для редактирования</summary>
    /// <param name="gsmId">Идентификатор глобального модуля</param>
    /// <returns>Модуль для редактирования</returns>
    public virtual ScriptModuleDTO LoadScriptModuleForEdit(long gsmId) => Mapper.Map<ScriptModule, ScriptModuleDTO>((ScriptModule) GlobalScriptModuleDtoManager.N9rO2qbKgEfJ89gdsqV0((object) this.GlobalScriptModuleManager, gsmId), new ScriptModuleDTO());

    /// <summary>Сохранить модуль сценариев</summary>
    /// <param name="scriptModule">Модуль сценариев</param>
    public virtual void SaveScriptModule(ScriptModuleDTO scriptModule)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            GlobalScriptModuleDtoManager.kLdL4FbK5Qv5MlnWb5CZ((object) Mapper.Map<ScriptModuleDTO, ScriptModule>(scriptModule));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public virtual bool CheckGlobalModuleNamespace(string space)
    {
      int num = 2;
      IGlobalScriptModuleHeaderFilter filter;
      while (true)
      {
        switch (num)
        {
          case 1:
            GlobalScriptModuleDtoManager.Mc2tDxbKjERILhSUeppK((object) filter, (object) space);
            num = 3;
            continue;
          case 2:
            filter = InterfaceActivator.Create<IGlobalScriptModuleHeaderFilter>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 1 : 0;
            continue;
          case 3:
            filter.Deleted = new bool?(false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return !this.GlobalScriptModuleHeaderManager.Find((IEntityFilter) filter, (FetchOptions) null).Any<IGlobalScriptModuleHeader>();
    }

    public virtual bool CheckGlobalModuleName(string name)
    {
      int num = 2;
      IGlobalScriptModuleHeaderFilter filter;
      while (true)
      {
        switch (num)
        {
          case 1:
            GlobalScriptModuleDtoManager.imuud2bKYkqJ983momk3((object) filter, (object) name);
            num = 3;
            continue;
          case 2:
            filter = InterfaceActivator.Create<IGlobalScriptModuleHeaderFilter>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 1;
            continue;
          case 3:
            filter.Deleted = new bool?(false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return !this.GlobalScriptModuleHeaderManager.Find((IEntityFilter) filter, (FetchOptions) null).Any<IGlobalScriptModuleHeader>();
    }

    public virtual void Compile(IGlobalScriptModule gsm)
    {
      int num = 4;
      ScriptModule module;
      ScriptCompileResult scriptCompileResult;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_7;
          case 1:
            if (GlobalScriptModuleDtoManager.L7jIv3bKUFhxrTMixNni((object) gsm) is ProjectInfo)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 2;
              continue;
            }
            goto label_2;
          case 2:
            scriptCompileResult = (ScriptCompileResult) GlobalScriptModuleDtoManager.XiN2D2bKsyE3AffpnURL((object) new GlobalScriptModuleCompiler(module, gsm));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 6 : 5;
            continue;
          case 3:
            if (module != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 0;
              continue;
            }
            goto label_14;
          case 4:
            module = (ScriptModule) GlobalScriptModuleDtoManager.IkpaOZbKLft1tLYfxVch((object) gsm);
            num = 3;
            continue;
          case 5:
            goto label_6;
          case 6:
            if (!GlobalScriptModuleDtoManager.yn2xV1bKcsvjE93vpb3f((object) scriptCompileResult))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 5 : 5;
              continue;
            }
            goto label_13;
          default:
            goto label_15;
        }
      }
label_7:
      return;
label_15:
      return;
label_14:
      return;
label_6:
      throw new GlobalScriptModulePublishingException(gsm.Id, scriptCompileResult);
label_13:
      return;
label_2:;
    }

    public virtual GlobalScriptModuleDto DoNew(
      GlobalScriptModuleDto oldGsm,
      string newPrefix = "",
      bool copy = false)
    {
      int num = 4;
      IGlobalScriptModule globalScriptModule;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 3:
            goto label_13;
          case 2:
            if (globalScriptModule != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 9 : 0;
              continue;
            }
            goto label_12;
          case 4:
            if (oldGsm == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 2 : 3;
              continue;
            }
            goto case 7;
          case 5:
            globalScriptModule = this.GlobalScriptModuleManager.LoadOrNull(GlobalScriptModuleDtoManager.Mye6ADbXFmcL6YKmkeZX(GlobalScriptModuleDtoManager.IdMNldbKzyMdbOB0gf9i((object) oldGsm)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 6 : 3;
            continue;
          case 6:
            if (copy)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 7:
            if (GlobalScriptModuleDtoManager.IdMNldbKzyMdbOB0gf9i((object) oldGsm) == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 1;
              continue;
            }
            goto case 8;
          case 8:
            if (oldGsm.ScriptModule != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 4 : 5;
              continue;
            }
            goto label_13;
          case 9:
            goto label_11;
          default:
            goto label_12;
        }
      }
label_11:
      return (GlobalScriptModuleDto) null;
label_12:
      GlobalScriptModuleDto globalScriptModuleDto = ClassSerializationHelper.CloneObject<GlobalScriptModuleDto>(oldGsm);
      GlobalScriptModuleDtoManager.JGxEulbXWZORxQJI8rrQ((object) globalScriptModuleDto, GlobalScriptModuleDtoManager.tOGjrObXBmpS58fg6sSB());
      globalScriptModuleDto.Id = 0L;
      return globalScriptModuleDto;
label_13:
      return (GlobalScriptModuleDto) null;
    }

    public GlobalScriptModuleDtoManager()
    {
      GlobalScriptModuleDtoManager.vlXjk8bXoHnQlwjm3yuE();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool aMtmZfbKHrejiidNcNrf() => GlobalScriptModuleDtoManager.QUskpqbK6Y0i9Tklt0kD == null;

    internal static GlobalScriptModuleDtoManager JK14IIbKA7dhjm7ScNqI() => GlobalScriptModuleDtoManager.QUskpqbK6Y0i9Tklt0kD;

    internal static object tm3HPKbK7Pf5w5sIaaPD(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void FG8PNDbKxHfmsmOlekhN([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void RmUvyLbK0QxGBaBJdCyL([In] object obj0) => ((GlobalScriptModuleDto) obj0).ResetIdsForPublish();

    internal static void himGnibKmnRchmFxbkHO([In] object obj0) => ((IEntity) obj0).Save();

    internal static void DNUkv6bKyOWesR7GwjF3([In] object obj0, [In] object obj1) => ((GlobalScriptModuleManager) obj0).Publish((IGlobalScriptModule) obj1);

    internal static void pfGsTGbKMVXN6VGRnTh1([In] object obj0) => ((IEntity) obj0).Delete();

    internal static object BSHlxObKJERtsmX48WFj([In] object obj0, long id) => (object) ((GlobalScriptModuleDtoManager) obj0).LoadOrNull(id);

    internal static object vE1hNabK92NUIZy8p2EL([In] object obj0, [In] object obj1) => (object) ((GlobalScriptModuleDtoManager) obj0).Save((GlobalScriptModuleDto) obj1);

    internal static void OQZbr6bKdsjVsInX49hi([In] object obj0, [In] object obj1) => ((IGlobalScriptModuleHeader) obj0).Draft = (IGlobalScriptModule) obj1;

    internal static object VrUcMbbKl0CXjiLqlHue([In] object obj0) => (object) ((IGlobalScriptModule) obj0).Header;

    internal static void D1pO7ZbKrNlPcjt4gLM5([In] object obj0, [In] object obj1) => ((GlobalScriptModuleManager) obj0).DeleteDirectory((string) obj1);

    internal static object N9rO2qbKgEfJ89gdsqV0([In] object obj0, long gsmId) => (object) ((GlobalScriptModuleManager) obj0).LoadScriptModuleForEdit(gsmId);

    internal static void kLdL4FbK5Qv5MlnWb5CZ([In] object obj0) => ((Entity<long>) obj0).Save();

    internal static void Mc2tDxbKjERILhSUeppK([In] object obj0, [In] object obj1) => ((IGlobalScriptModuleHeaderFilter) obj0).Namespace = (string) obj1;

    internal static void imuud2bKYkqJ983momk3([In] object obj0, [In] object obj1) => ((IGlobalScriptModuleHeaderFilter) obj0).Name = (string) obj1;

    internal static object IkpaOZbKLft1tLYfxVch([In] object obj0) => (object) ((IGlobalScriptModule) obj0).ScriptModule;

    internal static object L7jIv3bKUFhxrTMixNni([In] object obj0) => ((IGlobalScriptModule) obj0).Items;

    internal static object XiN2D2bKsyE3AffpnURL([In] object obj0) => (object) ((ScriptCompiler) obj0).Compile();

    internal static bool yn2xV1bKcsvjE93vpb3f([In] object obj0) => ((ScriptCompileResult) obj0).Success;

    internal static object IdMNldbKzyMdbOB0gf9i([In] object obj0) => (object) ((GlobalScriptModuleDto) obj0).Header;

    internal static Guid Mye6ADbXFmcL6YKmkeZX([In] object obj0) => ((GlobalScriptModuleHeaderDto) obj0).Uid;

    internal static Guid tOGjrObXBmpS58fg6sSB() => Guid.NewGuid();

    internal static void JGxEulbXWZORxQJI8rrQ([In] object obj0, Guid value) => ((GlobalScriptModuleDto) obj0).Uid = value;

    internal static void vlXjk8bXoHnQlwjm3yuE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
