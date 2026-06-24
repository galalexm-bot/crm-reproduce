// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.ExportHelper.ExportHelperBuilder`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Proxy;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EleWise.ELMA.Deploy.ExportHelper
{
  public class ExportHelperBuilder<T> where T : class
  {
    private T exportObject;
    private ExportRuleList rules;
    private Dictionary<object, object> exportedObjects;
    private static object tY9Z9EEDEm5tsKpwwJnh;

    public ExportRuleList ExportRuleList
    {
      get => this.rules;
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
              this.rules = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
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

    /// <summary>Экспортированый объект</summary>
    public T ExportObject
    {
      get => this.exportObject;
      set => this.exportObject = value;
    }

    /// <summary>Скопированные во время экспортирования объекты</summary>
    public Dictionary<object, object> ExportedObjects
    {
      get => this.exportedObjects;
      set => this.exportedObjects = value;
    }

    private ExportHelperBuilder<T1> Create<T1>(T1 cloneObject, ExportHelperBuilder<T> helper) where T1 : class
    {
      ExportHelperBuilder<T1> exportHelperBuilder = new ExportHelperBuilder<T1>(cloneObject);
      if (helper != null)
      {
        exportHelperBuilder.ExportRuleList = helper.ExportRuleList;
        exportHelperBuilder.ExportedObjects = helper.ExportedObjects;
      }
      return exportHelperBuilder;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="exportObject">Экспортируемый объект</param>
    public ExportHelperBuilder(T exportObject)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.rules = new ExportRuleList();
      this.exportedObjects = new Dictionary<object, object>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.exportObject = exportObject;
      if (!exportObject.IsProxy())
        return;
      this.exportObject = (T) ((INHibernateProxy) (object) exportObject).HibernateLazyInitializer.GetImplementation();
    }

    /// <summary>Задать правила для экспорта</summary>
    /// <param name="exportRuleBuilder"></param>
    /// <returns></returns>
    public ExportHelperBuilder<T> ExportRule(Action<ExportRuleBuilder<T>> exportRuleBuilder)
    {
      ExportRuleBuilder<T> exportRuleBuilder1 = new ExportRuleBuilder<T>(this.rules);
      exportRuleBuilder(exportRuleBuilder1);
      return this;
    }

    /// <summary>
    /// Получить список объектов для экспорта корневого объекта
    /// </summary>
    /// <param name="resObj">Оъект, в который записать данные</param>
    /// <returns>Копия объекта</returns>
    public List<IEntity> EntityExportList(T resObj = null)
    {
      this.exportedObjects = new Dictionary<object, object>();
      return this.entityExportList(resObj);
    }

    /// <summary>
    /// Получить список объектов для экспорта корневого объекта
    /// </summary>
    /// <param name="resObj"></param>
    /// <returns></returns>
    private List<IEntity> entityExportList(T resObj = null)
    {
      List<IEntity> resultList = new List<IEntity>();
      if ((object) this.exportObject == null || !((object) this.exportObject is IEntity))
        return resultList;
      resultList.Add((object) this.exportObject as IEntity);
      Type type = this.exportObject.GetType();
      if (this.exportObject.IsProxy())
        type = NHibernateUtil.GetClass((object) this.exportObject);
      if (typeof (EnumBase).IsAssignableFrom(type) || type.IsEnum || this.exportedObjects.ContainsKey((object) this.exportObject))
        return resultList;
      PropertyInfo[] reflectionProperties = type.GetReflectionProperties();
      ExportRuleList exportRuleList = Locator.GetServiceNotNull<IExportRulesService>().BaseMerge((object) this.exportObject as IEntity, this.rules);
      foreach (PropertyInfo propertyInfo in reflectionProperties)
      {
        ExportAction exportAction = exportRuleList.IsPropertyIgnore(propertyInfo) ? ExportAction.Ignore : (exportRuleList.IsPropertyExport(propertyInfo) ? ExportAction.Export : (exportRuleList.IsPropertyDeepExport(propertyInfo) ? ExportAction.DeepExport : ExportAction.Ignore));
        if (exportAction == ExportAction.DeepExport)
        {
          object implementation = propertyInfo.GetValue((object) this.exportObject, (object[]) null);
          if (implementation.IsProxy())
            implementation = ((INHibernateProxy) implementation).HibernateLazyInitializer.GetImplementation();
          if (implementation != null && implementation.GetType().GetInterface(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633498789)) != (Type) null)
          {
            if (!(((IEnumerable<MethodInfo>) implementation.GetType().GetMethods()).FirstOrDefault<MethodInfo>((Func<MethodInfo, bool>) (f => f.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487346598))) == (MethodInfo) null))
            {
              foreach (object exportObject in ((IEnumerable) implementation).Cast<object>())
              {
                ExportHelperBuilder<object> exportHelperBuilder = ExportHelperBuilder.Create<object>(exportObject);
                exportHelperBuilder.ExportRuleList = this.ExportRuleList;
                List<IEntity> source = exportHelperBuilder.EntityExportList();
                resultList.AddRange(source.Where<IEntity>((Func<IEntity, bool>) (r => !resultList.Contains(r))));
              }
            }
          }
          else if (implementation is IEntity && !resultList.Contains(implementation as IEntity))
          {
            resultList.Add(implementation as IEntity);
            if (exportAction == ExportAction.DeepExport)
            {
              ExportHelperBuilder<object> exportHelperBuilder = ExportHelperBuilder.Create<object>(implementation);
              exportHelperBuilder.ExportRuleList = this.ExportRuleList;
              List<IEntity> source = exportHelperBuilder.EntityExportList();
              resultList.AddRange(source.Where<IEntity>((Func<IEntity, bool>) (r => !resultList.Contains(r))));
            }
          }
        }
      }
      return resultList;
    }

    internal static bool YCXHfhEDfvvKahfj7v17() => ExportHelperBuilder<T>.tY9Z9EEDEm5tsKpwwJnh == null;

    internal static object w5wYiEEDQFJIW9ymIsMC() => ExportHelperBuilder<T>.tY9Z9EEDEm5tsKpwwJnh;
  }
}
