// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scripts.ServiceReference.ServiceReferenceDiscovererBase
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.ServiceModel.Description;
using System.Threading;
using System.Web.Services.Description;
using System.Web.Services.Discovery;
using System.Web.Services.Protocols;

namespace EleWise.ELMA.Scripts.ServiceReference
{
  /// <summary>
  /// Базовый класс с логикой получения информации о сервисе
  /// </summary>
  public abstract class ServiceReferenceDiscovererBase
  {
    internal static ServiceReferenceDiscovererBase FCbVoNBc9ecv8TP2q64v;

    private static CredentialCache CredentialCache { get; set; }

    /// <summary>Имя ссылки</summary>
    protected string ReferenceName
    {
      get => this.\u003CReferenceName\u003Ek__BackingField;
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
              this.\u003CReferenceName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
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

    /// <summary>Адрес веб-сервиса</summary>
    protected Uri DiscoveryUri
    {
      get => this.\u003CDiscoveryUri\u003Ek__BackingField;
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
              this.\u003CDiscoveryUri\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
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

    /// <summary>Сериализованные метаданные сервиса</summary>
    protected MetadataSet MetadataSet
    {
      get => this.\u003CMetadataSet\u003Ek__BackingField;
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
              this.\u003CMetadataSet\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
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

    /// <summary>Протокол получения информации о xml-сервисе</summary>
    protected System.Web.Services.Discovery.DiscoveryClientProtocol ClientProtocol
    {
      get => this.\u003CClientProtocol\u003Ek__BackingField;
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
              this.\u003CClientProtocol\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
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
    /// Протокол получения информации о xml-сервисе с авторизацией
    /// </summary>
    protected WebServiceDiscoveryClientProtocol DiscoveryClientProtocol
    {
      get => this.\u003CDiscoveryClientProtocol\u003Ek__BackingField;
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
              this.\u003CDiscoveryClientProtocol\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
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

    /// <summary>Wsdl-файл существует</summary>
    protected bool IsWsdlFile
    {
      get => this.\u003CIsWsdlFile\u003Ek__BackingField;
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
              this.\u003CIsWsdlFile\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
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

    /// <summary>Ctor</summary>
    static ServiceReferenceDiscovererBase()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ServiceReferenceDiscovererBase.CredentialCache = new CredentialCache();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
            continue;
          case 2:
            ServiceReferenceDiscovererBase.UBTcOMBcrC9EGUlIh8xD();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Ctor</summary>
    public ServiceReferenceDiscovererBase()
    {
      ServiceReferenceDiscovererBase.UBTcOMBcrC9EGUlIh8xD();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.ReferenceName = "";
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>
    /// The prefix that will be added to the web service's namespace
    /// (typically the project's namespace).
    /// </summary>
    public string NamespacePrefix
    {
      get => this.\u003CNamespacePrefix\u003Ek__BackingField;
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
              this.\u003CNamespacePrefix\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
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

    /// <summary>Пространство имен</summary>
    protected string NameSpace
    {
      get => this.\u003CNameSpace\u003Ek__BackingField;
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
              this.\u003CNameSpace\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
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

    /// <summary>Необходимо авторизовать пользователя</summary>
    public bool NeedAuthenticateUser
    {
      get => this.\u003CNeedAuthenticateUser\u003Ek__BackingField;
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
              this.\u003CNeedAuthenticateUser\u003Ek__BackingField = value;
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

    /// <summary>Текст ошибки</summary>
    public string ErrorMessage
    {
      get => this.\u003CErrorMessage\u003Ek__BackingField;
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
              this.\u003CErrorMessage\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
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

    /// <summary>ProjectDirPath</summary>
    public string ProjectDir
    {
      get => this.\u003CProjectDir\u003Ek__BackingField;
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
              this.\u003CProjectDir\u003Ek__BackingField = value;
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

    /// <summary>The discovered web reference to add to the project.</summary>
    public WebReference WebReference
    {
      get => this.\u003CWebReference\u003Ek__BackingField;
      protected set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CWebReference\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
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

    /// <summary>Тип авторизации</summary>
    public string AuthenticationType
    {
      get => this.\u003CAuthenticationType\u003Ek__BackingField;
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
              this.\u003CAuthenticationType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
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

    /// <summary>Есть ли ссылки на веб-сервисы</summary>
    public bool ExistReferences => ((DictionaryBase) ServiceReferenceDiscovererBase.H2Y2BoBcggHP2xJLBo2e((object) this.DiscoveryClientProtocol)).Count > 0;

    /// <summary>Начать поиск веб-сервисов</summary>
    /// <param name="uri">Адрес веб-сервиса</param>
    /// <param name="credential">Учетные данные</param>
    public void Run(Uri uri, DiscoveryNetworkCredential credential = null)
    {
      int num = 2;
      while (true)
      {
        DiscoveryNetworkCredential networkCredential1;
        switch (num)
        {
          case 1:
            this.DiscoveryUri = uri;
            num = 5;
            continue;
          case 2:
            this.IsWsdlFile = ServiceReferenceDiscovererBase.w27gi4Bc5vmA0LYA9ksW((object) uri.ToString());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 1;
            continue;
          case 3:
            networkCredential1 = new DiscoveryNetworkCredential((NetworkCredential) ServiceReferenceDiscovererBase.WiuqNjBcjlPxlhQYhIMJ(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121193117));
            break;
          case 4:
            goto label_6;
          case 5:
            DiscoveryNetworkCredential networkCredential2 = credential;
            if (networkCredential2 == null)
            {
              num = 3;
              continue;
            }
            networkCredential1 = networkCredential2;
            break;
          default:
            this.StartDiscovery(uri, credential);
            num = 4;
            continue;
        }
        credential = networkCredential1;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
      }
label_6:;
    }

    /// <summary>Начать поиск веб-сервисов</summary>
    /// <param name="uri">Адрес веб-сервиса</param>
    /// <param name="credential">Учетные данные</param>
    protected void StartDiscovery(Uri uri, DiscoveryNetworkCredential credential)
    {
      int num1 = 1;
      bool exception;
      while (true)
      {
        switch (num1)
        {
          case 1:
            this.StopDiscovery();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
            continue;
          case 2:
            try
            {
              ServiceReferenceDiscovererBase.Sn0WCHBcUSdyaG3G5GlW((object) this.DiscoveryClientProtocol, ServiceReferenceDiscovererBase.duTPwDBcLDIYPkWZkCou((object) uri));
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_13;
              }
            }
            catch (Exception ex)
            {
              int num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
                num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    exception = true;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_13;
                }
              }
            }
          case 3:
label_13:
            ServiceReferenceDiscovererBase.tZpva8BcsXrrUVyZ0g6q((object) this, (object) new AsyncDiscoveryState(this.DiscoveryClientProtocol, uri, credential), exception, (object) uri);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 4;
            continue;
          case 4:
            goto label_9;
          case 5:
            ServiceReferenceDiscovererBase.FGuaGvBcY0WH1JJUXi1W((object) this.DiscoveryClientProtocol, (object) credential);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 2 : 2;
            continue;
          default:
            exception = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 5;
            continue;
        }
      }
label_9:;
    }

    /// <summary>Получить описания для сервиса</summary>
    /// <param name="protocol">Протокол получения информации о веб-сервисе</param>
    /// <param name="checkContract">Проверить имя контракта</param>
    protected IEnumerable<System.Web.Services.Description.ServiceDescription> GetServiceDescriptions(
      System.Web.Services.Discovery.DiscoveryClientProtocol protocol,
      bool checkContract = false)
    {
      List<System.Web.Services.Description.ServiceDescription> serviceDescriptions = new List<System.Web.Services.Description.ServiceDescription>();
      protocol.ResolveOneLevel();
      foreach (DictionaryEntry reference in (DictionaryBase) protocol.References)
      {
        if (reference.Value is ContractReference contractReference)
        {
          if (checkContract && string.IsNullOrEmpty(contractReference.Contract.Name) && contractReference.Contract.Services.Count == 0)
            contractReference.Contract.Name = Path.GetFileName(contractReference.Url);
          serviceDescriptions.Add(contractReference.Contract);
        }
      }
      return (IEnumerable<System.Web.Services.Description.ServiceDescription>) serviceDescriptions;
    }

    /// <summary>Авторизовать пользователя</summary>
    /// <param name="authenticationType">Тип авторизации</param>
    protected void AuthenticateUser(string authenticationType)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.AuthenticationType = authenticationType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
            continue;
          case 2:
            this.NeedAuthenticateUser = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Добавить данные авторизации в объект протокола</summary>
    /// <param name="uri">Ссылка на сервис</param>
    /// <param name="credential">Данные авторизации</param>
    protected void AddCredential(Uri uri, DiscoveryNetworkCredential credential)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ServiceReferenceDiscovererBase.f5IP2YBzWMs2K333HgWh(ServiceReferenceDiscovererBase.s8pv2vBzBacDFrGj1OcK(), (object) uri, ServiceReferenceDiscovererBase.k8UiTABccTfrKFQApps9((object) credential), (object) credential);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
            continue;
          case 2:
            ServiceReferenceDiscovererBase.aQ4UB6BzFVHL2eSOa4qm((object) ServiceReferenceDiscovererBase.CredentialCache, (object) uri, ServiceReferenceDiscovererBase.k8UiTABccTfrKFQApps9((object) credential));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 1 : 0;
            continue;
          case 3:
            if (ServiceReferenceDiscovererBase.Tio2RYBczA1MtBpbOtnL((object) ServiceReferenceDiscovererBase.CredentialCache, (object) uri, ServiceReferenceDiscovererBase.k8UiTABccTfrKFQApps9((object) credential)) != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 1 : 2;
              continue;
            }
            goto case 1;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:;
    }

    /// <summary>Получить пространство имен</summary>
    /// <param name="services">Описания веб-сервисов</param>
    protected string GetDefaultNamespace(IEnumerable<System.Web.Services.Description.ServiceDescription> services)
    {
      ContractDescription contractDescription = (ContractDescription) null;
      if (this.MetadataSet != null)
        contractDescription = new WsdlImporter(this.MetadataSet).ImportAllContracts().FirstOrDefault<ContractDescription>((Func<ContractDescription, bool>) (q =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                if (ServiceReferenceDiscovererBase.\u003C\u003Ec.F9iw9BQ1vxFj53iWBhEs((object) q) != null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
                  continue;
                }
                goto label_2;
              case 2:
                goto label_2;
              default:
                goto label_3;
            }
          }
label_2:
          // ISSUE: reference to a compiler-generated method
          return ServiceReferenceDiscovererBase.\u003C\u003Ec.TBMKl8Q18mLvPxwgwBnG((object) q) != null;
label_3:
          return true;
        }));
      string str1 = this.WsdlName;
      string nameSpace = this.WsdlName;
      if (contractDescription != null)
      {
        str1 = contractDescription.Name;
        nameSpace = contractDescription.Namespace;
      }
      else
      {
        System.Web.Services.Description.ServiceDescription serviceDescription = services.FirstOrDefault<System.Web.Services.Description.ServiceDescription>((Func<System.Web.Services.Description.ServiceDescription, bool>) (q => q.TargetNamespace != null));
        if (serviceDescription != null)
        {
          if (string.IsNullOrEmpty(serviceDescription.Name))
          {
            foreach (Service service in (CollectionBase) serviceDescription.Services)
            {
              if (string.IsNullOrEmpty(str1))
                str1 = service.Name;
            }
          }
          else
            str1 = serviceDescription.Name;
          nameSpace = serviceDescription.TargetNamespace;
        }
      }
      if (!string.IsNullOrEmpty(nameSpace) && !nameSpace.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521167422)))
      {
        if (nameSpace.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757033620)))
        {
          if (!string.IsNullOrEmpty(str1))
            return this.NamespacePrefix + z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561072224) + (!str1.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218398600)) ? string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87895371), (object) str1) : str1);
        }
        else
        {
          string str2 = ScriptHelper.ServiceNamespace(nameSpace);
          return this.NamespacePrefix + z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333733590) + str2;
        }
      }
      else if (!string.IsNullOrEmpty(str1))
        return this.NamespacePrefix + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477137122) + (!str1.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317692154)) ? string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870793761), (object) str1) : str1);
      if (this.NamespacePrefix.Length > 0 && this.DiscoveryUri != (Uri) null)
      {
        string s = ((IEnumerable<string>) this.DiscoveryUri.Segments).LastOrDefault<string>();
        return s != null && !s.IsNullOrEmpty() ? this.NamespacePrefix + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138961604) + string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574228408), (object) s.Replace('.', '_')) : this.NamespacePrefix + z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272626609) + this.DiscoveryUri.Host;
      }
      return !(this.DiscoveryUri != (Uri) null) ? string.Empty : this.DiscoveryUri.Host;
    }

    /// <summary>Получить наименование ссылки</summary>
    /// <param name="services">Описания веб-сервисов</param>
    protected string GetReferenceName(IEnumerable<System.Web.Services.Description.ServiceDescription> services)
    {
      ContractDescription contractDescription = (ContractDescription) null;
      if (this.MetadataSet != null)
        contractDescription = new WsdlImporter(this.MetadataSet).ImportAllContracts().FirstOrDefault<ContractDescription>((Func<ContractDescription, bool>) (q =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                if (ServiceReferenceDiscovererBase.\u003C\u003Ec.F9iw9BQ1vxFj53iWBhEs((object) q) == null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
                  continue;
                }
                goto label_5;
              default:
                goto label_4;
            }
          }
label_4:
          // ISSUE: reference to a compiler-generated method
          return ServiceReferenceDiscovererBase.\u003C\u003Ec.TBMKl8Q18mLvPxwgwBnG((object) q) != null;
label_5:
          return true;
        }));
      string str = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -98004394);
      string nameSpace = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218397778);
      if (contractDescription != null)
      {
        str = contractDescription.Name;
        nameSpace = contractDescription.Namespace;
      }
      else
      {
        System.Web.Services.Description.ServiceDescription serviceDescription = services.FirstOrDefault<System.Web.Services.Description.ServiceDescription>((Func<System.Web.Services.Description.ServiceDescription, bool>) (q =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                if (ServiceReferenceDiscovererBase.\u003C\u003Ec.ubugWVQ1ZShaVkCbrELx((object) q) == null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
                  continue;
                }
                goto label_4;
              case 2:
                goto label_4;
              default:
                goto label_5;
            }
          }
label_4:
          // ISSUE: reference to a compiler-generated method
          return ServiceReferenceDiscovererBase.\u003C\u003Ec.umYwXLQ1up77lviMfIId((object) q) != null;
label_5:
          return false;
        }));
        if (serviceDescription != null)
        {
          str = serviceDescription.Name;
          nameSpace = serviceDescription.TargetNamespace;
        }
      }
      if (!string.IsNullOrEmpty(nameSpace) && !nameSpace.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606687074)))
      {
        if (!nameSpace.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426192749)))
          return ScriptHelper.ServiceNamespace(nameSpace);
        if (!string.IsNullOrEmpty(str))
          return str.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138061906)) ? str : string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576117172), (object) str);
      }
      else if (!string.IsNullOrEmpty(str))
        return str.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638500409)) ? str : string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124540262), (object) str);
      if (!(this.DiscoveryUri != (Uri) null))
        return string.Empty;
      string s = ((IEnumerable<string>) this.DiscoveryUri.Segments).LastOrDefault<string>();
      return s != null && !s.IsNullOrEmpty() ? string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501374049), (object) s.Replace('.', '_')) : this.DiscoveryUri.Host;
    }

    /// <summary>
    /// Called after an asynchronous web services search has
    /// completed.
    /// </summary>
    /// <param name="state">Состояния получения информации о веб-сервисе</param>
    /// <param name="exception">Наличие ошибок</param>
    /// <param name="uri">Ссылка на веб-сервис</param>
    protected abstract void DiscoveryCompleted(AsyncDiscoveryState state, bool exception, Uri uri);

    /// <summary>Начать поиск сервисов</summary>
    /// <param name="credential">Учетные данные</param>
    /// <param name="uri">Адрес сервиса</param>
    protected abstract void RunDiscovery(DiscoveryNetworkCredential credential, Uri uri);

    /// <summary>
    /// Функция обратного вызова при завершении получения информации о веб-сервисе
    /// </summary>
    /// <param name="protocol">Протокол получения информации о веб-сервисе</param>
    protected abstract void DiscoveredWebServices(System.Web.Services.Discovery.DiscoveryClientProtocol protocol);

    /// <summary>Имя wsdl-сервиса по умолчанию</summary>
    protected abstract string WsdlName { get; }

    /// <summary>
    /// Stops any outstanding asynchronous discovery requests.
    /// </summary>
    private void StopDiscovery()
    {
      int num1 = 2;
      ServiceReferenceDiscovererBase referenceDiscovererBase;
      bool lockTaken;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_24;
            case 1:
              goto label_4;
            case 2:
              referenceDiscovererBase = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 0;
              continue;
            case 3:
              goto label_5;
            default:
              goto label_19;
          }
        }
label_4:
        lockTaken = false;
        num1 = 3;
      }
label_24:
      return;
label_19:
      return;
label_5:
      try
      {
        Monitor.Enter((object) referenceDiscovererBase, ref lockTaken);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
label_18:
              ServiceReferenceDiscovererBase.Uwh0hBBzbSPgSbvggGbs((object) this.DiscoveryClientProtocol);
              num3 = 4;
              continue;
            case 2:
              try
              {
                ServiceReferenceDiscovererBase.Dg4oQJBzoQJjbPmBbTBp((object) this.DiscoveryClientProtocol);
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                    goto label_18;
                }
              }
              catch (ObjectDisposedException ex)
              {
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
                  num5 = 0;
                switch (num5)
                {
                  default:
                    goto label_18;
                }
              }
            case 3:
              goto label_14;
            case 4:
              this.DiscoveryClientProtocol = new WebServiceDiscoveryClientProtocol();
              num3 = 3;
              continue;
            default:
              if (this.DiscoveryClientProtocol != null)
              {
                num3 = 2;
                continue;
              }
              goto case 4;
          }
        }
label_14:;
      }
      finally
      {
        if (lockTaken)
        {
          int num6 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
            num6 = 1;
          while (true)
          {
            switch (num6)
            {
              case 1:
                ServiceReferenceDiscovererBase.FlUxYIBzho9nvOi0SQBW((object) referenceDiscovererBase);
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
                continue;
              default:
                goto label_26;
            }
          }
        }
label_26:;
      }
    }

    internal static bool GW3AelBcdyWoqxvZqRL4() => ServiceReferenceDiscovererBase.FCbVoNBc9ecv8TP2q64v == null;

    internal static ServiceReferenceDiscovererBase ECn88uBclGpOZbHX4LUv() => ServiceReferenceDiscovererBase.FCbVoNBc9ecv8TP2q64v;

    internal static void UBTcOMBcrC9EGUlIh8xD() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object H2Y2BoBcggHP2xJLBo2e([In] object obj0) => (object) ((System.Web.Services.Discovery.DiscoveryClientProtocol) obj0).References;

    internal static bool w27gi4Bc5vmA0LYA9ksW([In] object obj0) => System.IO.File.Exists((string) obj0);

    internal static object WiuqNjBcjlPxlhQYhIMJ() => (object) CredentialCache.DefaultNetworkCredentials;

    internal static void FGuaGvBcY0WH1JJUXi1W([In] object obj0, [In] object obj1) => ((WebClientProtocol) obj0).Credentials = (ICredentials) obj1;

    internal static object duTPwDBcLDIYPkWZkCou([In] object obj0) => (object) ((Uri) obj0).AbsoluteUri;

    internal static object Sn0WCHBcUSdyaG3G5GlW([In] object obj0, [In] object obj1) => (object) ((System.Web.Services.Discovery.DiscoveryClientProtocol) obj0).DiscoverAny((string) obj1);

    internal static void tZpva8BcsXrrUVyZ0g6q(
      [In] object obj0,
      [In] object obj1,
      bool exception,
      [In] object obj3)
    {
      ((ServiceReferenceDiscovererBase) obj0).DiscoveryCompleted((AsyncDiscoveryState) obj1, exception, (Uri) obj3);
    }

    internal static object k8UiTABccTfrKFQApps9([In] object obj0) => (object) ((DiscoveryNetworkCredential) obj0).AuthenticationType;

    internal static object Tio2RYBczA1MtBpbOtnL([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((CredentialCache) obj0).GetCredential((Uri) obj1, (string) obj2);

    internal static void aQ4UB6BzFVHL2eSOa4qm([In] object obj0, [In] object obj1, [In] object obj2) => ((CredentialCache) obj0).Remove((Uri) obj1, (string) obj2);

    internal static object s8pv2vBzBacDFrGj1OcK() => (object) ServiceReferenceDiscovererBase.CredentialCache;

    internal static void f5IP2YBzWMs2K333HgWh([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((CredentialCache) obj0).Add((Uri) obj1, (string) obj2, (NetworkCredential) obj3);

    internal static void Dg4oQJBzoQJjbPmBbTBp([In] object obj0) => ((WebClientProtocol) obj0).Abort();

    internal static void Uwh0hBBzbSPgSbvggGbs([In] object obj0) => ((Component) obj0).Dispose();

    internal static void FlUxYIBzho9nvOi0SQBW([In] object obj0) => Monitor.Exit(obj0);
  }
}
