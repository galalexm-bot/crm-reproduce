// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.UserDefinedList.UserDefinedListExecutionHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.UserDefinedList;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Scripts.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.UI.UserDefinedList
{
  /// <summary>
  /// Выполнение подготовки данных компонентов и пользовательских страниц
  /// </summary>
  [Component]
  internal sealed class UserDefinedListExecutionHandler : IUserDefinedListExecutionHandler
  {
    private readonly IComponentMetadataItemManager componentMetadataItemManager;
    private readonly IModuleReferenceManager moduleReferenceManager;
    private readonly IUserDefinedListService userDefinedListService;
    private readonly IModuleMetadataLoader moduleMetadataLoader;
    private readonly IModuleAssemblyLoader moduleAssemblyLoader;
    internal static UserDefinedListExecutionHandler y3VO5JU2cdW0UgAvGIK;

    /// <summary>Ctor</summary>
    /// <param name="componentMetadataItemManager">Менеджер метаданных компонента</param>
    /// <param name="moduleReferenceManager">Менеджер ссылки метаданных на модуль</param>
    /// <param name="moduleMetadataLoader">Загрузчик метаданных модулей</param>
    /// <param name="moduleAssemblyLoader">Загрузчик сборок модуля</param>
    /// <param name="userDefinedListService">Сервис для работы с пользовательскими списками</param>
    public UserDefinedListExecutionHandler(
      IComponentMetadataItemManager componentMetadataItemManager,
      IModuleReferenceManager moduleReferenceManager,
      IUserDefinedListService userDefinedListService,
      IModuleMetadataLoader moduleMetadataLoader,
      IModuleAssemblyLoader moduleAssemblyLoader)
    {
      UserDefinedListExecutionHandler.EsJL1sU11WWYAsm28jx();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.componentMetadataItemManager = componentMetadataItemManager;
            num = 5;
            continue;
          case 2:
            this.moduleAssemblyLoader = moduleAssemblyLoader;
            num = 3;
            continue;
          case 3:
            goto label_3;
          case 4:
            this.moduleMetadataLoader = moduleMetadataLoader;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 2;
            continue;
          case 5:
            this.moduleReferenceManager = moduleReferenceManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
            continue;
          default:
            this.userDefinedListService = userDefinedListService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 4 : 3;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public IEnumerable<object> ExecuteGetUserDefinedList(
      Guid modelSubTypeUid,
      Guid userDefinedListUid)
    {
      ModuleReference moduleReference = this.moduleReferenceManager.LoadOrNull(modelSubTypeUid);
      Guid moduleUid = moduleReference != null ? moduleReference.ModuleUid : Guid.Empty;
      ComponentMetadata componentMetadata;
      if (moduleUid == Guid.Empty)
      {
        componentMetadata = (ComponentMetadata) this.componentMetadataItemManager.Load(modelSubTypeUid).Metadata;
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        ItemRuntimeModel itemRuntimeModel = ContextVars.GetOrDefault<UIRuntimeModel>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1597012150 ^ 1597029710)).RuntimeModules.FirstOrDefault<ItemRuntimeModel>((Func<ItemRuntimeModel, bool>) (a => UserDefinedListExecutionHandler.\u003C\u003Ec__DisplayClass6_0.h829OOfU1fpSVJDCFBBo(a.HeaderUid, moduleUid)));
        if (itemRuntimeModel == null)
        {
          string message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727373482), (object) moduleUid);
          EleWise.ELMA.Logging.Logger.Log.Error((object) message);
          throw new Exception(message);
        }
        ModuleVersion specificModuleVersion = this.moduleMetadataLoader.GetSpecificModuleVersion(moduleUid, itemRuntimeModel.ItemUid);
        this.moduleAssemblyLoader.GetServerAssembly(moduleUid, itemRuntimeModel.ItemUid);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        componentMetadata = specificModuleVersion.Metadata.Components.FirstOrDefault<ComponentMetadata>((Func<ComponentMetadata, bool>) (a => UserDefinedListExecutionHandler.\u003C\u003Ec__DisplayClass6_0.h829OOfU1fpSVJDCFBBo(UserDefinedListExecutionHandler.\u003C\u003Ec__DisplayClass6_0.gBk7FOfUNBnBAfOppAy8((object) a), modelSubTypeUid)));
      }
      if (componentMetadata == null)
      {
        string message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921253049), (object) typeof (ComponentMetadata).FullName);
        EleWise.ELMA.Logging.Logger.Log.Error((object) message);
        throw new Exception(message);
      }
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      UserDefinedListInfo userDefinedListInfo = componentMetadata.UserDefinedListInfos.FirstOrDefault<UserDefinedListInfo>((Func<UserDefinedListInfo, bool>) (pdw => UserDefinedListExecutionHandler.\u003C\u003Ec__DisplayClass6_0.h829OOfU1fpSVJDCFBBo(UserDefinedListExecutionHandler.\u003C\u003Ec__DisplayClass6_0.uSJwMMfU3H5EpNcgGIUY((object) pdw), userDefinedListUid)));
      if (userDefinedListInfo == null)
      {
        string message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1598106783 - -968262081 ^ -629832050), (object) userDefinedListUid.ToString());
        EleWise.ELMA.Logging.Logger.Log.Error((object) message);
        throw new Exception(message);
      }
      return this.userDefinedListService.GetUserDefinedList(userDefinedListInfo);
    }

    internal static void EsJL1sU11WWYAsm28jx() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool ME2YrFUetlDRF5aEQAH() => UserDefinedListExecutionHandler.y3VO5JU2cdW0UgAvGIK == null;

    internal static UserDefinedListExecutionHandler FjajI7UP7OQQvggCvqa() => UserDefinedListExecutionHandler.y3VO5JU2cdW0UgAvGIK;
  }
}
