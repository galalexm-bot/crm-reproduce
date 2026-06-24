// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Remoting.UrlHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Remoting
{
  /// <summary>Helper для работы с URL-ми</summary>
  public static class UrlHelper
  {
    internal static UrlHelper kURgcDTtfTY0M7wG9kA;

    /// <summary>Получить значение параметра из URL</summary>
    /// <param name="queryString">URL</param>
    /// <param name="parameterName">Имя параметра</param>
    /// <returns>Значение параметра</returns>
    public static string GetParameter(string queryString, string parameterName)
    {
      int num1 = 5;
      int num2;
      int num3;
      while (true)
      {
        int num4 = num1;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_3;
            case 2:
              goto label_12;
            case 3:
              num3 = UrlHelper.NLdBJFTHK2b34QKRIVS((object) queryString);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 1 : 1;
              continue;
            case 4:
              if (UrlHelper.NLdBJFTHK2b34QKRIVS((object) queryString) > 0)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 5:
              parameterName = (string) UrlHelper.AJSrkuT6Y4CpFmCLmsS((object) parameterName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1199943687));
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 4;
              continue;
            case 6:
              if (num2 != -1)
              {
                num4 = 8;
                continue;
              }
              goto label_4;
            case 7:
              num3 = UrlHelper.KjBX9STxY6cEDKvmj35((object) queryString, UrlHelper.hmHcxQT7kB8G9XcYImM(654297945 ^ 654290753), num2);
              num4 = 2;
              continue;
            case 8:
              num2 += UrlHelper.NLdBJFTHK2b34QKRIVS((object) parameterName);
              num4 = 7;
              continue;
            default:
              num2 = UrlHelper.BsK3DiTA8J7AeEy5mRJ((object) queryString, (object) parameterName);
              num4 = 6;
              continue;
          }
        }
label_12:
        if (num3 == -1)
          num1 = 3;
        else
          break;
      }
label_3:
      return (string) UrlHelper.xHENaQT0pnnrJYf7Qpf((object) queryString, num2, num3 - num2);
label_4:
      return "";
    }

    /// <summary>Подгатавливает адрес</summary>
    /// <param name="serverUrl">Адрес сервера</param>
    /// <param name="port">Порт, на который нужно заменить существующий (если не нужно менять - передавать null)</param>
    /// <param name="path">Путь</param>
    /// <param name="protocol">Протокол</param>
    /// <returns>Готовый адрес</returns>
    public static string PrepareUrl(string serverUrl, int? port, string path, string protocol)
    {
      Contract.ArgumentNotNull((object) serverUrl, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099760311));
      Contract.ArgumentNotNullOrEmpty(serverUrl, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137433132));
      if (!serverUrl.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106493968)))
        serverUrl = z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757139200) + serverUrl;
      UriBuilder uriBuilder = new UriBuilder(serverUrl);
      if (port.HasValue)
        uriBuilder.Port = port.Value;
      if (!string.IsNullOrEmpty(path))
      {
        if (path.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106494060)))
          path = path.Substring(1);
        uriBuilder.Path += path;
      }
      if (!string.IsNullOrWhiteSpace(protocol))
        uriBuilder.Scheme = protocol;
      return uriBuilder.Uri.AbsoluteUri;
    }

    /// <summary>Подгатавливает адрес</summary>
    /// <param name="serverUrl">Адрес сервера</param>
    /// <param name="port">Порт, на который нужно заменить существующий (если не нужно менять - передавать null)</param>
    /// <param name="path">Путь</param>
    /// <param name="protocol">Протокол</param>
    /// <param name="fragment">Ссылка на фрагмент документа</param>
    /// <returns>Готовый адрес</returns>
    public static string PrepareUrl(
      string serverUrl,
      int? port,
      string path,
      string protocol,
      string fragment)
    {
      Contract.ArgumentNotNull((object) serverUrl, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418447508));
      Contract.ArgumentNotNullOrEmpty(serverUrl, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283409093));
      if (!serverUrl.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309648504)))
        serverUrl = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87347127) + serverUrl;
      UriBuilder uriBuilder = new UriBuilder(serverUrl);
      if (port.HasValue)
        uriBuilder.Port = port.Value;
      if (!string.IsNullOrEmpty(path))
      {
        path = path.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939400998)) ? path.Substring(2) : path;
        path = path.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459581071)) ? path.Substring(1) : path;
        uriBuilder.Path += path;
      }
      if (!string.IsNullOrWhiteSpace(protocol))
        uriBuilder.Scheme = protocol;
      if (!string.IsNullOrWhiteSpace(fragment))
        uriBuilder.Fragment = fragment;
      return uriBuilder.Uri.AbsoluteUri;
    }

    /// <summary>Получить имя хоста из URL-а</summary>
    /// <param name="serverUrl"></param>
    /// <returns></returns>
    public static string GetHost(string serverUrl)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 5:
            goto label_4;
          case 2:
            serverUrl = (string) UrlHelper.hmHcxQT7kB8G9XcYImM(--1867379187 ^ 1867355597) + serverUrl;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 5 : 1;
            continue;
          case 3:
            UrlHelper.PItmIGTyqWRybjfsprK((object) serverUrl, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1199953939));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
            continue;
          case 4:
            UrlHelper.bKtdhuTmkWdnrBBAV6a((object) serverUrl, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1012096225));
            num = 3;
            continue;
          default:
            if (UrlHelper.VdB3rkTMMmw9pCPSW2A((object) serverUrl, UrlHelper.hmHcxQT7kB8G9XcYImM(-1876063057 ^ -1876039525)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 0;
              continue;
            }
            goto case 2;
        }
      }
label_4:
      return (string) UrlHelper.TOFmCqTJy9A6Ooxn7Bk((object) new UriBuilder(serverUrl));
    }

    /// <summary>Получить порт из URL-а</summary>
    /// <param name="serverUrl"></param>
    /// <returns></returns>
    public static int GetPort(string serverUrl)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            serverUrl = (string) UrlHelper.AJSrkuT6Y4CpFmCLmsS(UrlHelper.hmHcxQT7kB8G9XcYImM(-688192331 - 435440695 ^ -1123623872), (object) serverUrl);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 1 : 1;
            continue;
          case 3:
            Contract.ArgumentNotNullOrEmpty(serverUrl, (string) UrlHelper.hmHcxQT7kB8G9XcYImM(-1290212282 ^ -644262414 ^ 1786895786));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
            continue;
          case 4:
            Contract.ArgumentNotNull((object) serverUrl, (string) UrlHelper.hmHcxQT7kB8G9XcYImM(1319452732 ^ 1319445538));
            num = 3;
            continue;
          default:
            if (!UrlHelper.VdB3rkTMMmw9pCPSW2A((object) serverUrl, UrlHelper.hmHcxQT7kB8G9XcYImM(979449278 ^ 979456394)))
            {
              num = 2;
              continue;
            }
            goto label_6;
        }
      }
label_6:
      return UrlHelper.lVqRdiT9pDXb4w6fyIJ((object) new UriBuilder(serverUrl));
    }

    /// <summary>Убирает из URL значение раздела</summary>
    /// <param name="url">Исходный URL</param>
    /// <param name="fragment">Значение раздела</param>
    /// <returns>URL без раздела</returns>
    public static string GetUrlWithoutFragment(string url, out string fragment)
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_9;
            case 2:
            case 7:
              fragment = (string) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 4 : 4;
              continue;
            case 3:
              url = (string) UrlHelper.K5BD53Trtr7v3ETlwWc((object) url, num3);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
              continue;
            case 5:
              if (num3 < 0)
              {
                num2 = 7;
                continue;
              }
              goto label_9;
            case 6:
              num3 = UrlHelper.qfKcFUTdsp0jPLnPRtL((object) url, '#');
              num2 = 5;
              continue;
            default:
              goto label_8;
          }
        }
label_9:
        fragment = (string) UrlHelper.svlbPOTlm94MwR6sVQ4((object) url, num3 + 1);
        num1 = 3;
      }
label_8:
      return url;
    }

    internal static object AJSrkuT6Y4CpFmCLmsS([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static int NLdBJFTHK2b34QKRIVS([In] object obj0) => ((string) obj0).Length;

    internal static int BsK3DiTA8J7AeEy5mRJ([In] object obj0, [In] object obj1) => ((string) obj0).IndexOf((string) obj1);

    internal static object hmHcxQT7kB8G9XcYImM(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static int KjBX9STxY6cEDKvmj35([In] object obj0, [In] object obj1, [In] int obj2) => ((string) obj0).IndexOf((string) obj1, obj2);

    internal static object xHENaQT0pnnrJYf7Qpf([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static bool hxlbQNTw0Lp2bqB6MDf() => UrlHelper.kURgcDTtfTY0M7wG9kA == null;

    internal static UrlHelper UUhImpT4myRVmZDkHYg() => UrlHelper.kURgcDTtfTY0M7wG9kA;

    internal static void bKtdhuTmkWdnrBBAV6a([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void PItmIGTyqWRybjfsprK([In] object obj0, [In] object obj1) => Contract.ArgumentNotNullOrEmpty((string) obj0, (string) obj1);

    internal static bool VdB3rkTMMmw9pCPSW2A([In] object obj0, [In] object obj1) => ((string) obj0).Contains((string) obj1);

    internal static object TOFmCqTJy9A6Ooxn7Bk([In] object obj0) => (object) ((UriBuilder) obj0).Host;

    internal static int lVqRdiT9pDXb4w6fyIJ([In] object obj0) => ((UriBuilder) obj0).Port;

    internal static int qfKcFUTdsp0jPLnPRtL([In] object obj0, [In] char obj1) => ((string) obj0).IndexOf(obj1);

    internal static object svlbPOTlm94MwR6sVQ4([In] object obj0, [In] int obj1) => (object) ((string) obj0).Substring(obj1);

    internal static object K5BD53Trtr7v3ETlwWc([In] object obj0, [In] int obj1) => (object) ((string) obj0).Remove(obj1);
  }
}
