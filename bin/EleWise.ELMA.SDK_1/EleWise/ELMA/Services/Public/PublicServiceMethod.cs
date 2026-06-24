// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Public.PublicServiceMethod
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services.Public
{
  /// <summary>Класс для представления метода публичного сервиса</summary>
  public sealed class PublicServiceMethod : IPublicServiceMethod
  {
    private Guid serviceUid;
    private string name;
    private string description;
    private Func<WebData, PublicServiceMethodExecutor> executorFactory;
    private TypeSerializationDescriptor parametersDescriptor;
    private TypeSerializationDescriptor resultDescriptor;
    private readonly Version version;
    internal static PublicServiceMethod pLKI7bBmv5Pxs24CHV7R;

    /// <summary>Инициализировать экзепляр класса</summary>
    /// <param name="serviceUid">Идентификатор сервиса <see cref="T:EleWise.ELMA.Services.Public.IPublicService" /></param>
    /// <param name="name">Имя метода, используется при обращении</param>
    /// <param name="description">Описание метода</param>
    /// <param name="apiVersion">Версия API метода. Правила формирования смотреть в <see cref="F:EleWise.ELMA.API.PublicContractInfo.ApiVersionString" /></param>
    /// <param name="executorFactory">Функция для создания классов-исполнителей</param>
    public PublicServiceMethod(
      Guid serviceUid,
      [NotNull] string name,
      [NotNull] string description,
      [NotNull] Version apiVersion,
      [NotNull] Func<WebData, PublicServiceMethodExecutor> executorFactory)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      if (string.IsNullOrWhiteSpace(name))
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281845586));
      if (string.IsNullOrWhiteSpace(description))
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -672049361));
      if (apiVersion == (Version) null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105142836));
      if (executorFactory == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858944025));
      this.serviceUid = serviceUid;
      this.name = name;
      this.description = description;
      this.executorFactory = executorFactory;
      this.version = apiVersion;
      this.parametersDescriptor = new TypeSerializationDescriptor();
      this.resultDescriptor = new TypeSerializationDescriptor();
    }

    /// <summary>
    /// Идентификатор сервиса, к которому относится данный метод
    /// </summary>
    public Guid ServiceUid
    {
      get => this.serviceUid;
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
              this.serviceUid = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
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

    /// <summary>
    /// Имя метода.
    /// Должно содержать только англйские символы.
    /// Используется как часть пути доступа к методу
    /// </summary>
    public string Name
    {
      get => this.name;
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
              this.name = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
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

    /// <summary>Описание метода</summary>
    public string Description
    {
      get => this.description;
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
              this.description = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
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

    public Version Version => this.version;

    /// <summary>Описание данных для входящего параметра</summary>
    public TypeSerializationDescriptor ParametersDescriptor
    {
      get => this.parametersDescriptor;
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
              this.parametersDescriptor = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
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

    /// <summary>Описание результата выполнения</summary>
    public TypeSerializationDescriptor ResultDescriptor
    {
      get => this.resultDescriptor;
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
              this.resultDescriptor = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
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

    /// <summary>Фабрика для получения исполнителей метода</summary>
    public Func<WebData, PublicServiceMethodExecutor> ExecutorFactory
    {
      get => this.executorFactory;
      set => this.executorFactory = value;
    }

    /// <summary>Выполнить действие метода</summary>
    /// <param name="parameters">Входящий параметр в формате универсальных данных</param>
    /// <exception cref="T:System.NotImplementedException">Функция <see cref="P:EleWise.ELMA.Services.Public.PublicServiceMethod.ExecutorFactory" /> не задана</exception>
    /// <returns>Результат выполнения в формате универсальных данных</returns>
    WebData IPublicServiceMethod.Execute(WebData parameters)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.ExecutorFactory == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      throw new NotImplementedException((string) PublicServiceMethod.ChlCkHBmu7urNTeaOIbC((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867736028)));
label_5:
      return this.ExecutorFactory(parameters).Execute();
    }

    internal static bool om1K7GBm89OnKymxRsFo() => PublicServiceMethod.pLKI7bBmv5Pxs24CHV7R == null;

    internal static PublicServiceMethod mUyjihBmZhtjSeSm4IB5() => PublicServiceMethod.pLKI7bBmv5Pxs24CHV7R;

    internal static object ChlCkHBmu7urNTeaOIbC([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);
  }
}
