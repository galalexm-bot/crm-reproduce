// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.ExtensionPointAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>Атрибут интерфейса точки расширения</summary>
  [AttributeUsage(AttributeTargets.Interface)]
  public class ExtensionPointAttribute : Attribute
  {
    private readonly bool createInstance;
    private readonly ServiceScope serviceScope;
    private readonly ComponentType type;
    internal static ExtensionPointAttribute rXEhcCfuW0ZPBajlZAAP;

    /// <summary>
    /// Точка расширения с типом жизненного цикла Application и регистрацией экземпляров компонентов
    /// </summary>
    /// <param name="type">Тип компонента</param>
    public ExtensionPointAttribute(ComponentType type = ComponentType.All)
    {
      ExtensionPointAttribute.iCQQQlfuhPIJNU2mBMIi();
      // ISSUE: explicit constructor call
      this.\u002Ector(true, type);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Точка расширения с указанным типом регистрации компонентов (регистрация типов компонентов, либо экземпляров компонента)
    /// </summary>
    /// <param name="createInstance">Если false, то регистрируются только типы компонентов, реализующих данную точку расширения</param>
    /// <param name="type">Тип компонента</param>
    public ExtensionPointAttribute(bool createInstance, ComponentType type = ComponentType.All, ServiceScope scope = ServiceScope.Application)
    {
      ExtensionPointAttribute.iCQQQlfuhPIJNU2mBMIi();
      this.createInstance = true;
      this.serviceScope = ServiceScope.Application;
      this.type = ComponentType.All;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.serviceScope = scope;
            num = 3;
            continue;
          case 2:
            this.type = type;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_3;
          default:
            this.createInstance = createInstance;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Точка расширения с указанным типом жизненного цикла</summary>
    /// <param name="serviceScope">Тип жизненного цикла компонентов, реализующих данную точку расширения</param>
    /// <param name="type">Тип компонента</param>
    public ExtensionPointAttribute(ServiceScope serviceScope, ComponentType type = ComponentType.All)
    {
      ExtensionPointAttribute.iCQQQlfuhPIJNU2mBMIi();
      // ISSUE: explicit constructor call
      this.\u002Ector(true, type);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.serviceScope = serviceScope;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Создавать ли экземпляры компонентов</summary>
    /// <remarks>
    /// True, если нужно создать экземпляры (после загрузки они доступны через метод IComponentManager.GetExtensionPoints).
    /// False, если нужно загружать только их типы (после загрузки они доступны через метод IComponentManager.GetExtensionPointTypes).
    /// </remarks>
    public bool CreateInstance => this.createInstance;

    /// <summary>
    /// Контекст, в котором будут зарегистрированы и созданы компоненты, реализующие точку расширения
    /// Applcation - регистрация на уровне приложения (до инициализации IInitHandler.Init), один экземпляр на приложение
    /// Shell - регистрация уровне контейнера (контейнер пересоздается после включения/отключения расширений), один экземпляр на контейнер
    /// Transient - регистрация уровне контейнера, экземпляр создается на пождому запросу из контейнера
    /// UnitOfWork - регистрация уровне контейнера, экземпляр создается на каждый UnitOfWork (в Web сонтексте на каждый HTTP запрос)
    /// </summary>
    public ServiceScope ServiceScope => this.serviceScope;

    /// <summary>Тип компонента. По умолчанию - All</summary>
    public ComponentType Type => this.type;

    /// <summary>
    /// Регистрировать компоненты с данной точкой расширения, даже если модуль отключен или не активирован
    /// </summary>
    public bool ForceRegister
    {
      get => this.\u003CForceRegister\u003Ek__BackingField;
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
              this.\u003CForceRegister\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
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

    internal static void iCQQQlfuhPIJNU2mBMIi() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool NJtcIufuoB06dTPDMDC6() => ExtensionPointAttribute.rXEhcCfuW0ZPBajlZAAP == null;

    internal static ExtensionPointAttribute U0IndlfubRJCp2WQaZnR() => ExtensionPointAttribute.rXEhcCfuW0ZPBajlZAAP;
  }
}
