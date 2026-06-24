// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scripts.ServiceReference.ServiceReferenceDiscoverer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Threading;
using System.Xml;

namespace EleWise.ELMA.Scripts.ServiceReference
{
  /// <summary>Класс с логикой получения информации о сервисе</summary>
  public sealed class ServiceReferenceDiscoverer : ServiceReferenceDiscovererBase
  {
    internal static ServiceReferenceDiscoverer N6LWdfBzG0WXdXmjQVI6;

    /// <summary>Ctor</summary>
    public ServiceReferenceDiscoverer()
    {
      ServiceReferenceDiscoverer.GToTf7BzQnhDalLfB0hB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Описание веб-сервисов</summary>
    public IEnumerable<System.Web.Services.Description.ServiceDescription> Services { get; private set; }

    /// <inheritdoc />
    protected override string WsdlName => (string) ServiceReferenceDiscoverer.xM7vLcBzC4FDoq9fyyVy(1178210108 ^ 1178307872);

    /// <inheritdoc />
    protected override void RunDiscovery(DiscoveryNetworkCredential credential, Uri uri)
    {
      int num1 = 14;
      while (true)
      {
        int num2 = num1;
        MetadataExchangeClient metadataExchangeClient;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 6:
              ServiceReferenceDiscoverer.FG4f2iBzZVurtVnNZSu8((object) metadataExchangeClient, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 9;
              continue;
            case 2:
              goto label_3;
            case 3:
label_29:
              if (this.MetadataSet != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 3 : 7;
                continue;
              }
              goto label_23;
            case 4:
              goto label_26;
            case 5:
              metadataExchangeClient.HttpCredentials = (ICredentials) credential;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 1;
              continue;
            case 7:
              new WsdlImporter(this.MetadataSet).ImportAllContracts();
              num2 = 11;
              continue;
            case 8:
              goto label_32;
            case 9:
              try
              {
                MetadataSet metadataSet = (MetadataSet) ServiceReferenceDiscoverer.dPpTayBzufcHvwcecAOS((object) metadataExchangeClient, (object) uri, MetadataExchangeClientMode.HttpGet);
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_29;
                    default:
                      this.MetadataSet = metadataSet;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 1;
                      continue;
                  }
                }
              }
              catch (InvalidOperationException ex)
              {
                int num4 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
                  num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 0:
                      goto label_17;
                    case 1:
                      this.MetadataSet = (MetadataSet) null;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      this.ErrorMessage = (string) ServiceReferenceDiscoverer.Y35MisBzI9fiqxdqp1yK(ServiceReferenceDiscoverer.xM7vLcBzC4FDoq9fyyVy(1113862659 ^ 1113960515));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 1;
                      continue;
                    default:
                      goto label_9;
                  }
                }
label_17:
                return;
label_9:
                return;
              }
            case 10:
              if (credential == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 5 : 6;
                continue;
              }
              goto case 5;
            case 11:
              if (this.MetadataSet != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 12 : 8;
                continue;
              }
              goto label_19;
            case 12:
              this.WebReference = new WebReference((string) ServiceReferenceDiscoverer.b1HMAnBzVV14Nn0pOKBs((object) this.DiscoveryUri), this.ReferenceName, this.NameSpace, this.ClientProtocol, this.ProjectDir, this.MetadataSet);
              num2 = 2;
              continue;
            case 13:
              this.WebReference = new WebReference(this.DiscoveryUri.AbsoluteUri, this.ReferenceName, this.NameSpace, this.ClientProtocol, this.ProjectDir, (MetadataSet) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
              continue;
            case 14:
              if (!this.IsWsdlFile)
              {
                WSHttpBinding mexBinding = new WSHttpBinding(SecurityMode.None);
                mexBinding.MaxReceivedMessageSize = (long) int.MaxValue;
                ServiceReferenceDiscoverer.akSTyJBzvnPMThCIAvAR((object) mexBinding.ReaderQuotas, int.MaxValue);
                ServiceReferenceDiscoverer.IpbJfrBz8Hwtgg6sdC6q((object) mexBinding.ReaderQuotas, int.MaxValue);
                metadataExchangeClient = new MetadataExchangeClient((System.ServiceModel.Channels.Binding) mexBinding);
                num2 = 10;
                continue;
              }
              goto label_12;
            default:
              this.Services = this.GetServiceDescriptions(this.ClientProtocol);
              num2 = 8;
              continue;
          }
        }
label_12:
        num1 = 13;
      }
label_3:
      return;
label_26:
      return;
label_32:
      return;
label_19:
      return;
label_23:;
    }

    /// <inheritdoc />
    protected override void DiscoveryCompleted(AsyncDiscoveryState state, bool exception, Uri uri)
    {
      int num1 = 7;
      WebServiceDiscoveryClientProtocol protocol;
      while (true)
      {
        int num2 = num1;
        ServiceReferenceDiscoverer referenceDiscoverer;
        bool lockTaken;
        bool flag;
        HttpAuthenticationHeader authenticationHeader;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!ServiceReferenceDiscoverer.lGXbEgBzRLdKEOQpMsJX((object) protocol))
              {
                num2 = 12;
                continue;
              }
              goto case 3;
            case 2:
              goto label_14;
            case 3:
              authenticationHeader = (HttpAuthenticationHeader) ServiceReferenceDiscoverer.rphMNwBzqKd7Yan2gjoA((object) protocol);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 2 : 4;
              continue;
            case 4:
              this.AuthenticateUser(authenticationHeader.AuthenticationType);
              num2 = 11;
              continue;
            case 5:
              try
              {
                Monitor.Enter((object) referenceDiscoverer, ref lockTaken);
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_40;
                    default:
                      flag = this.DiscoveryClientProtocol == protocol;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 1 : 1;
                      continue;
                  }
                }
              }
              finally
              {
                int num4;
                if (!lockTaken)
                  num4 = 2;
                else
                  goto label_11;
label_10:
                switch (num4)
                {
                  case 1:
                  case 2:
                }
label_11:
                ServiceReferenceDiscoverer.RL3pknBzidK2gvMOtONd((object) referenceDiscoverer);
                num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
                {
                  num4 = 0;
                  goto label_10;
                }
                else
                  goto label_10;
              }
            case 6:
              goto label_37;
            case 7:
              protocol = (WebServiceDiscoveryClientProtocol) ServiceReferenceDiscoverer.GyWDhLBzSnkMaDPXulCk((object) state);
              num2 = 6;
              continue;
            case 8:
              lockTaken = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 5;
              continue;
            case 9:
label_40:
              if (flag)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 1;
                continue;
              }
              goto label_32;
            case 10:
              goto label_36;
            case 11:
              goto label_45;
            case 12:
              ServiceReferenceDiscoverer.BvfeJ7BzKyl52R7H4vAB((object) this, (object) protocol);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
              continue;
            default:
              num2 = 2;
              continue;
          }
        }
label_37:
        referenceDiscoverer = this;
        num1 = 8;
      }
label_36:
      return;
label_45:
      return;
label_14:
      try
      {
        int num5;
        if (ServiceReferenceDiscoverer.kCh14PBzT2QAqk7PJwp1(ServiceReferenceDiscoverer.H99I7aBzXHuERvMJaEqj((object) state)))
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 2 : 2;
        else
          goto label_20;
label_16:
        while (true)
        {
          switch (num5)
          {
            case 0:
              goto label_29;
            case 1:
              this.DiscoveredWebServices((System.Web.Services.Discovery.DiscoveryClientProtocol) protocol);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
              continue;
            case 2:
            case 3:
              if (!exception)
              {
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 5 : 4;
                continue;
              }
              goto case 1;
            case 4:
              goto label_20;
            case 5:
              ServiceReferenceDiscoverer.EF1gpHBzkU9jNjrkdVDa((object) this, ServiceReferenceDiscoverer.H99I7aBzXHuERvMJaEqj((object) state), (object) state.Uri);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 1;
              continue;
            default:
              goto label_28;
          }
        }
label_29:
        return;
label_28:
        return;
label_20:
        this.AddCredential(state.Uri, state.Credential);
        num5 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
        {
          num5 = 3;
          goto label_16;
        }
        else
          goto label_16;
      }
      catch
      {
        int num6 = 2;
        HttpAuthenticationHeader authenticationHeader;
        while (true)
        {
          switch (num6)
          {
            case 0:
              goto label_25;
            case 1:
              authenticationHeader = (HttpAuthenticationHeader) ServiceReferenceDiscoverer.rphMNwBzqKd7Yan2gjoA((object) protocol);
              num6 = 6;
              continue;
            case 2:
              if (!ServiceReferenceDiscoverer.lGXbEgBzRLdKEOQpMsJX((object) protocol))
              {
                num6 = 5;
                continue;
              }
              goto case 1;
            case 3:
            case 5:
              ServiceReferenceDiscoverer.BvfeJ7BzKyl52R7H4vAB((object) this, (object) protocol);
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
              continue;
            case 4:
              goto label_18;
            case 6:
              this.AuthenticateUser((string) ServiceReferenceDiscoverer.EjS7uEBznDS3buHa3FmN((object) authenticationHeader));
              num6 = 4;
              continue;
            default:
              goto label_17;
          }
        }
label_25:
        return;
label_18:
        return;
label_17:
        return;
      }
label_32:;
    }

    /// <inheritdoc />
    protected override void DiscoveredWebServices(System.Web.Services.Discovery.DiscoveryClientProtocol protocol)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.ClientProtocol = protocol;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 10 : 2;
              continue;
            case 2:
              this.Services = (IEnumerable<System.Web.Services.Description.ServiceDescription>) this.GetServiceDescriptions(protocol).ToList<System.Web.Services.Description.ServiceDescription>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_15;
            case 4:
              if (this.Services == null)
                goto case 2;
              else
                goto label_12;
            case 5:
              if (protocol == null)
              {
                this.ClientProtocol = (System.Web.Services.Discovery.DiscoveryClientProtocol) null;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 8 : 7;
                continue;
              }
              num2 = 4;
              continue;
            case 7:
              goto label_3;
            case 8:
              this.WebReference = (WebReference) null;
              num2 = 7;
              continue;
            case 9:
              this.ReferenceName = this.GetReferenceName(this.Services);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 1 : 1;
              continue;
            case 10:
              this.WebReference = new WebReference((string) ServiceReferenceDiscoverer.b1HMAnBzVV14Nn0pOKBs((object) this.DiscoveryUri), this.ReferenceName, this.NameSpace, protocol, this.ProjectDir, this.MetadataSet);
              num2 = 3;
              continue;
            default:
              this.NameSpace = this.GetDefaultNamespace(this.Services);
              num2 = 9;
              continue;
          }
        }
label_12:
        num1 = 6;
      }
label_15:
      return;
label_3:;
    }

    internal static void GToTf7BzQnhDalLfB0hB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool ikteEBBzE9QpjOcLdXjF() => ServiceReferenceDiscoverer.N6LWdfBzG0WXdXmjQVI6 == null;

    internal static ServiceReferenceDiscoverer cHgCwWBzfS5RjpvldlLt() => ServiceReferenceDiscoverer.N6LWdfBzG0WXdXmjQVI6;

    internal static object xM7vLcBzC4FDoq9fyyVy(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void akSTyJBzvnPMThCIAvAR([In] object obj0, [In] int obj1) => ((XmlDictionaryReaderQuotas) obj0).MaxStringContentLength = obj1;

    internal static void IpbJfrBz8Hwtgg6sdC6q([In] object obj0, [In] int obj1) => ((XmlDictionaryReaderQuotas) obj0).MaxNameTableCharCount = obj1;

    internal static void FG4f2iBzZVurtVnNZSu8([In] object obj0, [In] bool obj1) => ((MetadataExchangeClient) obj0).ResolveMetadataReferences = obj1;

    internal static object dPpTayBzufcHvwcecAOS(
      [In] object obj0,
      [In] object obj1,
      [In] MetadataExchangeClientMode obj2)
    {
      return (object) ((MetadataExchangeClient) obj0).GetMetadata((Uri) obj1, obj2);
    }

    internal static object Y35MisBzI9fiqxdqp1yK([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object b1HMAnBzVV14Nn0pOKBs([In] object obj0) => (object) ((Uri) obj0).AbsoluteUri;

    internal static object GyWDhLBzSnkMaDPXulCk([In] object obj0) => (object) ((AsyncDiscoveryState) obj0).Protocol;

    internal static void RL3pknBzidK2gvMOtONd([In] object obj0) => Monitor.Exit(obj0);

    internal static bool lGXbEgBzRLdKEOQpMsJX([In] object obj0) => ((WebServiceDiscoveryClientProtocol) obj0).IsAuthenticationRequired;

    internal static object rphMNwBzqKd7Yan2gjoA([In] object obj0) => (object) ((WebServiceDiscoveryClientProtocol) obj0).GetAuthenticationHeader();

    internal static void BvfeJ7BzKyl52R7H4vAB([In] object obj0, [In] object obj1) => ((ServiceReferenceDiscovererBase) obj0).DiscoveredWebServices((System.Web.Services.Discovery.DiscoveryClientProtocol) obj1);

    internal static object H99I7aBzXHuERvMJaEqj([In] object obj0) => (object) ((AsyncDiscoveryState) obj0).Credential;

    internal static bool kCh14PBzT2QAqk7PJwp1([In] object obj0) => ((DiscoveryNetworkCredential) obj0).IsDefaultAuthenticationType;

    internal static void EF1gpHBzkU9jNjrkdVDa([In] object obj0, [In] object obj1, [In] object obj2) => ((ServiceReferenceDiscovererBase) obj0).RunDiscovery((DiscoveryNetworkCredential) obj1, (Uri) obj2);

    internal static object EjS7uEBznDS3buHa3FmN([In] object obj0) => (object) ((HttpAuthenticationHeader) obj0).AuthenticationType;
  }
}
