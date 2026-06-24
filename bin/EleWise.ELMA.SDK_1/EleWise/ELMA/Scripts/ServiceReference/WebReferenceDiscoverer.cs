// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scripts.ServiceReference.WebReferenceDiscoverer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Threading;
using System.Web.Services.Discovery;
using System.Xml;

namespace EleWise.ELMA.Scripts.ServiceReference
{
  /// <summary>Класс с логикой получения информации о веб-сервисе</summary>
  public class WebReferenceDiscoverer : ServiceReferenceDiscovererBase
  {
    internal static WebReferenceDiscoverer Vh4hWdBzOVt50scX5QyZ;

    /// <inheritdoc />
    protected override string WsdlName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852936188);

    /// <inheritdoc />
    protected override void DiscoveredWebServices(System.Web.Services.Discovery.DiscoveryClientProtocol protocol)
    {
      int num = 6;
      List<System.Web.Services.Description.ServiceDescription> services;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_13;
          case 2:
            goto label_4;
          case 3:
            this.ClientProtocol = protocol;
            num = 11;
            continue;
          case 4:
            services = new List<System.Web.Services.Description.ServiceDescription>();
            num = 9;
            continue;
          case 5:
            this.ClientProtocol = (System.Web.Services.Discovery.DiscoveryClientProtocol) null;
            num = 12;
            continue;
          case 6:
            if (protocol == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 5 : 3;
              continue;
            }
            goto case 4;
          case 7:
            this.ReferenceName = this.GetReferenceName((IEnumerable<System.Web.Services.Description.ServiceDescription>) services);
            num = 3;
            continue;
          case 9:
            if (!this.IsWsdlFile)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
              continue;
            }
            goto case 10;
          case 10:
            services.AddRange(this.GetServiceDescriptions(protocol));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 8 : 3;
            continue;
          case 11:
            this.WebReference = new WebReference((string) WebReferenceDiscoverer.DcPUEZBzPDu5dy4C7bvv((object) this.DiscoveryUri), this.ReferenceName, this.NameSpace, protocol, this.ProjectDir, this.MetadataSet);
            num = 2;
            continue;
          case 12:
            this.WebReference = (WebReference) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 1;
            continue;
          default:
            this.NameSpace = this.GetDefaultNamespace((IEnumerable<System.Web.Services.Description.ServiceDescription>) services);
            num = 7;
            continue;
        }
      }
label_13:
      return;
label_4:;
    }

    /// <inheritdoc />
    protected override void DiscoveryCompleted(AsyncDiscoveryState state, bool exception, Uri uri)
    {
      int num1 = 7;
      WebServiceDiscoveryClientProtocol discoveryClientProtocol;
      HttpAuthenticationHeader authenticationHeader1;
      bool flag;
      WebReferenceDiscoverer referenceDiscoverer;
      bool lockTaken;
      while (true)
      {
        switch (num1)
        {
          case 1:
label_6:
            if (flag)
            {
              num1 = 9;
              continue;
            }
            goto label_39;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
            continue;
          case 3:
            try
            {
              Monitor.Enter((object) referenceDiscoverer, ref lockTaken);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
                num2 = 0;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_6;
                  default:
                    flag = this.DiscoveryClientProtocol == discoveryClientProtocol;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 1;
                    continue;
                }
              }
            }
            finally
            {
              if (lockTaken)
              {
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_41;
                    default:
                      WebReferenceDiscoverer.QONYwABzNm3SaShjkCGW((object) referenceDiscoverer);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 1 : 1;
                      continue;
                  }
                }
              }
label_41:;
            }
          case 4:
            goto label_2;
          case 5:
            this.AuthenticateUser((string) WebReferenceDiscoverer.xGeWETBzpM5wfiFlVTRQ((object) authenticationHeader1));
            num1 = 8;
            continue;
          case 6:
            referenceDiscoverer = this;
            num1 = 11;
            continue;
          case 7:
            discoveryClientProtocol = (WebServiceDiscoveryClientProtocol) WebReferenceDiscoverer.A0u8EnBz1D0fUekpKcIP((object) state);
            num1 = 6;
            continue;
          case 8:
            goto label_43;
          case 9:
            if (!discoveryClientProtocol.IsAuthenticationRequired)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 10 : 0;
              continue;
            }
            goto case 12;
          case 10:
            WebReferenceDiscoverer.J3qZYgBzahcqF38uGDah((object) this, (object) discoveryClientProtocol);
            num1 = 2;
            continue;
          case 11:
            lockTaken = false;
            num1 = 3;
            continue;
          case 12:
            authenticationHeader1 = (HttpAuthenticationHeader) WebReferenceDiscoverer.Hv612iBz32yx0eBp8lME((object) discoveryClientProtocol);
            num1 = 5;
            continue;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_43:
      return;
label_39:
      return;
label_8:
      try
      {
        int num4;
        if (!WebReferenceDiscoverer.nylQGWBzDfr75nFQxtjN((object) state.Credential))
          num4 = 2;
        else
          goto label_14;
label_11:
        while (true)
        {
          switch (num4)
          {
            case 0:
              goto label_34;
            case 1:
              goto label_14;
            case 2:
              this.AddCredential(state.Uri, (DiscoveryNetworkCredential) WebReferenceDiscoverer.S7CnaeBzt6SxVHctlD2m((object) state));
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 1;
              continue;
            case 3:
            case 4:
              goto label_18;
            case 5:
              goto label_12;
            case 6:
              WebReferenceDiscoverer.MfcYYcBz4fIZKL2XdCnw((object) this, (object) state.Credential, WebReferenceDiscoverer.WpEsCoBzw6IrgPxf9A3J((object) state));
              num4 = 3;
              continue;
            default:
              goto label_32;
          }
        }
label_34:
        return;
label_32:
        return;
label_12:
        if (!this.IsWsdlFile)
        {
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 2 : 6;
          goto label_11;
        }
        else
          goto label_18;
label_14:
        if (exception)
        {
          num4 = 4;
          goto label_11;
        }
        else
          goto label_12;
label_18:
        WebReferenceDiscoverer.J3qZYgBzahcqF38uGDah((object) this, (object) discoveryClientProtocol);
        num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
        {
          num4 = 0;
          goto label_11;
        }
        else
          goto label_11;
      }
      catch
      {
        int num5 = 6;
        HttpAuthenticationHeader authenticationHeader2;
        while (true)
        {
          switch (num5)
          {
            case 1:
              this.AuthenticateUser((string) WebReferenceDiscoverer.xGeWETBzpM5wfiFlVTRQ((object) authenticationHeader2));
              num5 = 5;
              continue;
            case 2:
              goto label_28;
            case 4:
              authenticationHeader2 = (HttpAuthenticationHeader) WebReferenceDiscoverer.Hv612iBz32yx0eBp8lME((object) discoveryClientProtocol);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 1;
              continue;
            case 5:
              goto label_26;
            case 6:
              if (!WebReferenceDiscoverer.JRfUEOBz6ZOcjMwVfrUK((object) discoveryClientProtocol))
              {
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            default:
              WebReferenceDiscoverer.J3qZYgBzahcqF38uGDah((object) this, (object) discoveryClientProtocol);
              num5 = 2;
              continue;
          }
        }
label_28:
        return;
label_26:;
      }
    }

    /// <inheritdoc />
    protected override void RunDiscovery(DiscoveryNetworkCredential credential, Uri uri)
    {
      int num1 = 1;
      MetadataExchangeClient metadataExchangeClient;
      while (true)
      {
        switch (num1)
        {
          case 1:
            WSHttpBinding mexBinding = new WSHttpBinding(SecurityMode.None);
            WebReferenceDiscoverer.P5lZPHBzHMNHLRBdy7YZ((object) mexBinding, (long) int.MaxValue);
            WebReferenceDiscoverer.hQQMH7Bz7LUVZX5VvVdh(WebReferenceDiscoverer.j0hEJ6BzAQGpwKsRxNdx((object) mexBinding), int.MaxValue);
            WebReferenceDiscoverer.nLJZe1Bzxrjvv3vcSjl1((object) mexBinding.ReaderQuotas, int.MaxValue);
            metadataExchangeClient = new MetadataExchangeClient((System.ServiceModel.Channels.Binding) mexBinding);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_21;
          case 3:
label_4:
            if (this.MetadataSet == null)
            {
              num1 = 4;
              continue;
            }
            goto case 7;
          case 4:
            goto label_19;
          case 5:
            try
            {
              MetadataSet metadataSet = (MetadataSet) WebReferenceDiscoverer.g6W7PcBzytAUEUVwZIeg((object) metadataExchangeClient, (object) uri, MetadataExchangeClientMode.HttpGet);
              int num2 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
                num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    this.MetadataSet = metadataSet;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
            }
            catch (InvalidOperationException ex)
            {
              int num3 = 2;
              while (true)
              {
                switch (num3)
                {
                  case 0:
                    goto label_16;
                  case 1:
                    this.MetadataSet = (MetadataSet) null;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
                    continue;
                  case 2:
                    this.ErrorMessage = EleWise.ELMA.SR.T((string) WebReferenceDiscoverer.bJX5GbBzMoW8c410yDed(1470440286 ^ 1470406942));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 1;
                    continue;
                  default:
                    goto label_13;
                }
              }
label_16:
              return;
label_13:
              return;
            }
          case 6:
          case 8:
            WebReferenceDiscoverer.iROWtuBzmGtE2yhqAUoB((object) metadataExchangeClient, true);
            num1 = 5;
            continue;
          case 7:
            this.WebReference = new WebReference((string) WebReferenceDiscoverer.DcPUEZBzPDu5dy4C7bvv((object) this.DiscoveryUri), this.ReferenceName, this.NameSpace, this.ClientProtocol, this.ProjectDir, this.MetadataSet);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 2 : 0;
            continue;
          case 9:
            WebReferenceDiscoverer.vRP51OBz0mC1EymxAqIL((object) metadataExchangeClient, (object) credential);
            num1 = 6;
            continue;
          default:
            if (credential == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 5 : 8;
              continue;
            }
            goto case 9;
        }
      }
label_21:
      return;
label_19:;
    }

    private IEnumerable<System.Web.Services.Description.ServiceDescription> GetServiceDescriptions(
      System.Web.Services.Discovery.DiscoveryClientProtocol protocol)
    {
      List<System.Web.Services.Description.ServiceDescription> serviceDescriptions = new List<System.Web.Services.Description.ServiceDescription>();
      protocol.ResolveOneLevel();
      foreach (DictionaryEntry reference in (DictionaryBase) protocol.References)
      {
        if (reference.Value is ContractReference contractReference)
          serviceDescriptions.Add(contractReference.Contract);
      }
      return (IEnumerable<System.Web.Services.Description.ServiceDescription>) serviceDescriptions;
    }

    public WebReferenceDiscoverer()
    {
      WebReferenceDiscoverer.kwpM5hBzJXuLCMOBZ7RE();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool x7NF5CBz2d1hy7KQ084v() => WebReferenceDiscoverer.Vh4hWdBzOVt50scX5QyZ == null;

    internal static WebReferenceDiscoverer AfZRmLBzetbIdwHejnKs() => WebReferenceDiscoverer.Vh4hWdBzOVt50scX5QyZ;

    internal static object DcPUEZBzPDu5dy4C7bvv([In] object obj0) => (object) ((Uri) obj0).AbsoluteUri;

    internal static object A0u8EnBz1D0fUekpKcIP([In] object obj0) => (object) ((AsyncDiscoveryState) obj0).Protocol;

    internal static void QONYwABzNm3SaShjkCGW([In] object obj0) => Monitor.Exit(obj0);

    internal static object Hv612iBz32yx0eBp8lME([In] object obj0) => (object) ((WebServiceDiscoveryClientProtocol) obj0).GetAuthenticationHeader();

    internal static object xGeWETBzpM5wfiFlVTRQ([In] object obj0) => (object) ((HttpAuthenticationHeader) obj0).AuthenticationType;

    internal static void J3qZYgBzahcqF38uGDah([In] object obj0, [In] object obj1) => ((ServiceReferenceDiscovererBase) obj0).DiscoveredWebServices((System.Web.Services.Discovery.DiscoveryClientProtocol) obj1);

    internal static bool nylQGWBzDfr75nFQxtjN([In] object obj0) => ((DiscoveryNetworkCredential) obj0).IsDefaultAuthenticationType;

    internal static object S7CnaeBzt6SxVHctlD2m([In] object obj0) => (object) ((AsyncDiscoveryState) obj0).Credential;

    internal static object WpEsCoBzw6IrgPxf9A3J([In] object obj0) => (object) ((AsyncDiscoveryState) obj0).Uri;

    internal static void MfcYYcBz4fIZKL2XdCnw([In] object obj0, [In] object obj1, [In] object obj2) => ((ServiceReferenceDiscovererBase) obj0).RunDiscovery((DiscoveryNetworkCredential) obj1, (Uri) obj2);

    internal static bool JRfUEOBz6ZOcjMwVfrUK([In] object obj0) => ((WebServiceDiscoveryClientProtocol) obj0).IsAuthenticationRequired;

    internal static void P5lZPHBzHMNHLRBdy7YZ([In] object obj0, [In] long obj1) => ((WSHttpBindingBase) obj0).MaxReceivedMessageSize = obj1;

    internal static object j0hEJ6BzAQGpwKsRxNdx([In] object obj0) => (object) ((WSHttpBindingBase) obj0).ReaderQuotas;

    internal static void hQQMH7Bz7LUVZX5VvVdh([In] object obj0, [In] int obj1) => ((XmlDictionaryReaderQuotas) obj0).MaxStringContentLength = obj1;

    internal static void nLJZe1Bzxrjvv3vcSjl1([In] object obj0, [In] int obj1) => ((XmlDictionaryReaderQuotas) obj0).MaxNameTableCharCount = obj1;

    internal static void vRP51OBz0mC1EymxAqIL([In] object obj0, [In] object obj1) => ((MetadataExchangeClient) obj0).HttpCredentials = (ICredentials) obj1;

    internal static void iROWtuBzmGtE2yhqAUoB([In] object obj0, [In] bool obj1) => ((MetadataExchangeClient) obj0).ResolveMetadataReferences = obj1;

    internal static object g6W7PcBzytAUEUVwZIeg(
      [In] object obj0,
      [In] object obj1,
      [In] MetadataExchangeClientMode obj2)
    {
      return (object) ((MetadataExchangeClient) obj0).GetMetadata((Uri) obj1, obj2);
    }

    internal static object bJX5GbBzMoW8c410yDed(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void kwpM5hBzJXuLCMOBZ7RE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
