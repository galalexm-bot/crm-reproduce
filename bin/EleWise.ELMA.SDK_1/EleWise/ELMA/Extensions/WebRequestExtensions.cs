// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.WebRequestExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace EleWise.ELMA.Extensions
{
  /// <summary>Асинхронные методы расширения WebRequest.</summary>
  /// <remarks>
  /// Код позаимстован из Samples for Parallel Programming with the .NET Framework 4
  /// </remarks>
  public static class WebRequestExtensions
  {
    /// <summary>
    /// Создать системную задачу, которая представляет асинхронный запрос к GetResponse (получить ответ).
    /// </summary>
    /// <param name="webRequest">Веб запрос.</param>
    /// <returns>Системную задачу с результатом "WebResponse (ответ удалённого хоста)".</returns>
    public static Task<WebResponse> GetResponseAsync(this WebRequest webRequest)
    {
      Contract.ArgumentNotNull((object) webRequest, z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 902020719));
      return Task<WebResponse>.Factory.FromAsync(new Func<AsyncCallback, object, IAsyncResult>(webRequest.BeginGetResponse), new Func<IAsyncResult, WebResponse>(webRequest.EndGetResponse), (object) webRequest);
    }

    /// <summary>
    /// Создать системную задачу, которая представляет асинхронный запрос GetRequestStream
    /// <para>(получить поток для тела запроса, при этом инициируется соединение с удалённым хостом).</para>
    /// </summary>
    /// <param name="webRequest">Веб запрос.</param>
    /// <returns>Системную задачу с результатом "поток для тела запроса".</returns>
    public static Task<Stream> GetRequestStreamAsync(this WebRequest webRequest)
    {
      Contract.ArgumentNotNull((object) webRequest, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413502987));
      return Task<Stream>.Factory.FromAsync(new Func<AsyncCallback, object, IAsyncResult>(webRequest.BeginGetRequestStream), new Func<IAsyncResult, Stream>(webRequest.EndGetRequestStream), (object) webRequest);
    }

    /// <summary>
    /// Создать системную задачу, которая представляет асинхронное скачивание всего контента из WebRequest (веб-запроса).
    /// </summary>
    /// <param name="webRequest">Веб запрос.</param>
    /// <returns>Системную задачу с результатом "контент ответа".</returns>
    public static Task<byte[]> DownloadDataAsync(this WebRequest webRequest) => webRequest.GetResponseAsync().Then<WebResponse, byte[]>((Func<WebResponse, Task<byte[]>>) (response => response.GetResponseStream().ReadAllBytesAsync()));
  }
}
