// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.EntityImportSaveActions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import.Links;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  /// <summary>Действия, выполняемые при сохранении сущности</summary>
  [Component]
  public abstract class EntityImportSaveActions : IEntityImportSaveActions
  {
    private static EntityImportSaveActions HXMQymErzuHkTkvXvGPZ;

    /// <summary>Проверка поддержки сущности реализацией расширения</summary>
    /// <param name="typeGuid"></param>
    /// <returns></returns>
    public abstract bool IsSupported(Guid typeGuid);

    /// <summary>
    /// Можно ли сохранить сущность. Проверка правил сохранения
    /// </summary>
    /// <param name="propValues"></param>
    /// <param name="data"></param>
    /// <returns></returns>
    public virtual bool CanBeSaved(
      Dictionary<string, object> propValues,
      ImportEntityCanBeSavedData data)
    {
      return true;
    }

    /// <summary>Действия, выполняемые перед сохранением сущности</summary>
    /// <param name="entity"></param>
    /// <param name="data"></param>
    /// <returns></returns>
    public virtual List<TestImportMessages> ExecPreSaveActions(
      IEntity entity,
      ImportEntityPreSaveData data)
    {
      return new List<TestImportMessages>();
    }

    /// <summary>Сохранение сущности</summary>
    /// <param name="entity"></param>
    public virtual void ExecSaveActions(IEntity entity, Dictionary<string, string> serviceData)
    {
      ISession session = Locator.GetServiceNotNull<ISessionProvider>().GetSession("");
      session.Save((object) entity);
      session.Flush();
    }

    /// <summary>Действия, выполняемые после сохранения сущности</summary>
    /// <param name="entity"></param>
    /// <param name="type"></param>
    /// <param name="values"></param>
    public virtual void ExecPostSaveActions(
      IEntity entity,
      Type type,
      Dictionary<string, object> values,
      Dictionary<string, string> serviceData,
      LinksDictionary links)
    {
    }

    /// <summary>Проверка сущности перед импортом</summary>
    public virtual void TestRead(ImportTestReadData data, ImportTestReadResult result)
    {
    }

    /// <inheritdoc />
    public virtual IEnumerable<ILinksDictionaryItem> RecoveryLinks(
      IEntity entity,
      Guid entityUid,
      LinksDictionary linksDictionary)
    {
      return Enumerable.Empty<ILinksDictionaryItem>();
    }

    protected EntityImportSaveActions()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool HEMDs7EgFXN9dd84WUwT() => EntityImportSaveActions.HXMQymErzuHkTkvXvGPZ == null;

    internal static EntityImportSaveActions MJhvAEEgBk71xMKR7iek() => EntityImportSaveActions.HXMQymErzuHkTkvXvGPZ;
  }
}
