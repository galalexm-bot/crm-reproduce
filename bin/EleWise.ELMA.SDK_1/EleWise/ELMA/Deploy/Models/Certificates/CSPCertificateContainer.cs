// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Models.Certificates.CSPCertificateContainer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace EleWise.ELMA.Deploy.Models.Certificates
{
  /// <summary>Контейнер для управления сертификатами и подписанием</summary>
  public sealed class CSPCertificateContainer : ICertificateContainer
  {
    /// <summary>Сертификат компонента</summary>
    private X509Certificate2 componentCertificate;
    /// <summary>Сертификат Store</summary>
    private X509Certificate2 storeCertificate;
    internal static CSPCertificateContainer Yq091YE4h80lS5Hdy4Gs;

    /// <summary>Ctor</summary>
    /// <param name="certificate">Сертификат</param>
    /// <param name="password">Пароль</param>
    public CSPCertificateContainer(byte[] certificate, string password)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.componentCertificate = new X509Certificate2(certificate, password);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
            continue;
          default:
            this.storeCertificate = (X509Certificate2) CSPCertificateContainer.RNLketE4f8k8IZTYRimJ((object) this.componentCertificate, (object) certificate, (object) password);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc />
    public void WriteSignature(string filePath)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            string componentFileName = filePath;
            List<SignatureCertificateReference> certificates = new List<SignatureCertificateReference>();
            SignatureCertificateReference certificateReference = new SignatureCertificateReference();
            CSPCertificateContainer.SPdBd6E4Q6wMXRYauFQg((object) certificateReference, (object) this.componentCertificate);
            certificateReference.StoreCertificate = this.storeCertificate;
            certificates.Add(certificateReference);
            ElmaStoreComponentsBuilder.Sign(componentFileName, (IEnumerable<SignatureCertificateReference>) certificates);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Проверить целостность цепочки сертификатов</summary>
    /// <returns>Результат проверки</returns>
    public bool ValidateChain() => CSPCertificateContainer.eBbZQIE4CkHQ4Rwqx9XA((object) this.componentCertificate, (object) this.storeCertificate);

    private static X509Certificate2 GetIssuer(
      object componentCertificate,
      object certificate,
      object password)
    {
      int num1 = 1;
      X509Certificate2 issuer;
      X509Chain x509Chain;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (!(((X509Certificate) componentCertificate).Subject == (string) CSPCertificateContainer.K8HD8gE4vfs475OhmnKC(componentCertificate)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
              continue;
            }
            goto label_23;
          case 2:
            goto label_3;
          case 3:
            goto label_23;
          case 4:
            x509Chain = new X509Chain();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 2;
            continue;
          case 5:
            goto label_2;
          default:
            issuer = (X509Certificate2) null;
            num1 = 4;
            continue;
        }
      }
label_2:
      return issuer;
label_3:
      try
      {
        x509Chain.ChainPolicy.RevocationMode = X509RevocationMode.NoCheck;
        int num2 = 5;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
          num2 = 2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              issuer = ((X509ChainElementCollection) CSPCertificateContainer.CNmrqhE4IXwfiQj4YJQo((object) x509Chain))[1].Certificate;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            case 3:
              CSPCertificateContainer.vdA0oYE4u8J6l2VktPiu((object) x509Chain, componentCertificate);
              num2 = 4;
              continue;
            case 4:
              if (((X509ChainElementCollection) CSPCertificateContainer.CNmrqhE4IXwfiQj4YJQo((object) x509Chain)).Count > 1)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 1;
                continue;
              }
              break;
            case 5:
              CSPCertificateContainer.NX6S1bE4Z8DgfGMPKw1s(CSPCertificateContainer.c52OQyE48W4GwGbtfuRf((object) x509Chain.ChainPolicy), certificate, password, X509KeyStorageFlags.Exportable);
              num2 = 3;
              continue;
          }
          x509Chain.Reset();
          num2 = 2;
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_2;
            default:
              CSPCertificateContainer.Kw8fkyE4Vwfaf4lt3xVA((object) Logger.Log, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889232584), (object) ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
              continue;
          }
        }
      }
      finally
      {
        if (x509Chain != null)
        {
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
            num4 = 0;
          while (true)
          {
            switch (num4)
            {
              case 1:
                goto label_21;
              default:
                CSPCertificateContainer.s8waOBE4SVoZ5CkcTYhU((object) x509Chain);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 1;
                continue;
            }
          }
        }
label_21:;
      }
label_23:
      return (X509Certificate2) componentCertificate;
    }

    internal static object RNLketE4f8k8IZTYRimJ([In] object obj0, [In] object obj1, [In] object obj2) => (object) CSPCertificateContainer.GetIssuer(obj0, obj1, obj2);

    internal static bool bI16FyE4GYeZdwJhCHEp() => CSPCertificateContainer.Yq091YE4h80lS5Hdy4Gs == null;

    internal static CSPCertificateContainer jxQ49PE4ENcxQQ3FuVRw() => CSPCertificateContainer.Yq091YE4h80lS5Hdy4Gs;

    internal static void SPdBd6E4Q6wMXRYauFQg([In] object obj0, [In] object obj1) => ((SignatureCertificateReference) obj0).ComponentCertificate = (X509Certificate2) obj1;

    internal static bool eBbZQIE4CkHQ4Rwqx9XA([In] object obj0, [In] object obj1) => ElmaStoreComponentsBuilder.ValidateChain((X509Certificate2) obj0, (X509Certificate2) obj1);

    internal static object K8HD8gE4vfs475OhmnKC([In] object obj0) => (object) ((X509Certificate) obj0).Issuer;

    internal static object c52OQyE48W4GwGbtfuRf([In] object obj0) => (object) ((X509ChainPolicy) obj0).ExtraStore;

    internal static void NX6S1bE4Z8DgfGMPKw1s(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] X509KeyStorageFlags obj3)
    {
      ((X509Certificate2Collection) obj0).Import((byte[]) obj1, (string) obj2, obj3);
    }

    internal static bool vdA0oYE4u8J6l2VktPiu([In] object obj0, [In] object obj1) => ((X509Chain) obj0).Build((X509Certificate2) obj1);

    internal static object CNmrqhE4IXwfiQj4YJQo([In] object obj0) => (object) ((X509Chain) obj0).ChainElements;

    internal static void Kw8fkyE4Vwfaf4lt3xVA([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static void s8waOBE4SVoZ5CkcTYhU([In] object obj0) => ((IDisposable) obj0).Dispose();
  }
}
