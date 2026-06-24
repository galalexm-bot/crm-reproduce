// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.OmniSharp.Infrastructure.SimpleWebClient
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EleWise.ELMA.OmniSharp.Infrastructure
{
  /// <summary>Очень простой http клиент</summary>
  internal class SimpleWebClient
  {
    private Uri baseUrl;
    private static SimpleWebClient vHxD4xWrnTboZWQTHLoa;

    /// <summary>Ctor</summary>
    /// <param name="baseUrl">Базовый адрес подключаемой веб-службы</param>
    public SimpleWebClient(string baseUrl)
    {
      SimpleWebClient.tDG22yWreoTNV3x8I4QM();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.baseUrl = new Uri(baseUrl);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
            continue;
          case 2:
            SimpleWebClient.GCNVAGWr144XGB9xEX0O((object) baseUrl, SimpleWebClient.MGpTtRWrP8JNLvRl8bTO(~-122002947 ^ 122137544));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Установтить новый адрес подключаемой веб-службы</summary>
    /// <param name="baseUrl">Базовый адрес подключаемой веб-службы</param>
    public void SetBaseUrl(string baseUrl)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            SimpleWebClient.GCNVAGWr144XGB9xEX0O((object) baseUrl, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477276144));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.baseUrl = new Uri(baseUrl);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Отправить POST запрос с JSON</summary>
    /// <param name="endpoint">Адрес точки входа</param>
    /// <param name="data">Содержимое json</param>
    /// <param name="requestSetup">Дополнительная настройка веб-запроса</param>
    /// <returns>Ответ от веб-службы в виде асинхронной задачи</returns>
    public virtual Task<string> Post(string endpoint, string data, Action<WebRequest> requestSetup = null)
    {
      WebRequest req = WebRequest.Create(new Uri(this.baseUrl, endpoint));
      req.Method = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536661430);
      req.ContentType = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106383828);
      if (requestSetup != null)
        requestSetup(req);
      return this.SendPayload(req, data).Then<string>((Func<Task<string>>) (() => this.GetResponse(req)));
    }

    /// <summary>Отправить GET запрос</summary>
    /// <param name="endpoint">Адрес точки входа</param>
    /// <param name="requestSetup">Дополнительная настройка веб-запроса</param>
    /// <returns>Ответ от веб-службы в виде асинхронной задачи</returns>
    public virtual Task<string> Get(string endpoint, Action<WebRequest> requestSetup = null)
    {
      WebRequest webRequest = WebRequest.Create(new Uri(this.baseUrl, endpoint));
      webRequest.Method = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822765036);
      if (requestSetup != null)
        requestSetup(webRequest);
      return this.GetResponse(webRequest);
    }

    private Task SendPayload(WebRequest webRequest, string data)
    {
      int num = 4;
      // ISSUE: variable of a compiler-generated type
      SimpleWebClient.\u003CSendPayload\u003Ed__5 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            stateMachine.data = data;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 2 : 6;
            continue;
          case 2:
            tBuilder.Start<SimpleWebClient.\u003CSendPayload\u003Ed__5>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            stateMachine.webRequest = webRequest;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 1;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 3 : 1;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = 2;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = SimpleWebClient.kjfy5AWrN2IJClt64Zt5();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 7 : 5;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 5;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    private async Task<string> GetResponse(WebRequest webRequest)
    {
      int num1 = 4;
      while (true)
      {
        string result1;
        int num2;
        switch (num1)
        {
          case 1:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result1);
            num1 = 2;
            continue;
          case 2:
            goto label_87;
          case 3:
            try
            {
              int num3;
              if (num2 == 0)
                num3 = 17;
              else
                goto label_11;
label_7:
              while (true)
              {
                WebResponse response;
                TaskAwaiter<WebResponse> taskAwaiter1;
                int num4;
                string str;
                TaskAwaiter<WebResponse> awaiter1;
                WebResponse result2;
                switch (num3)
                {
                  case 1:
                    goto label_11;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 12 : 9;
                    continue;
                  case 3:
                    awaiter1 = webRequest.GetResponseAsync().GetAwaiter();
                    num3 = 4;
                    continue;
                  case 4:
                    if (!awaiter1.IsCompleted)
                    {
                      num3 = 2;
                      continue;
                    }
                    goto case 5;
                  case 5:
                    result2 = awaiter1.GetResult();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 7 : 11;
                    continue;
                  case 6:
                    taskAwaiter1 = new TaskAwaiter<WebResponse>();
                    num3 = 15;
                    continue;
                  case 7:
                    goto label_74;
                  case 8:
                    result1 = str;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
                    continue;
                  case 9:
                    goto label_80;
                  case 10:
label_75:
                    response = (WebResponse) null;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 8 : 8;
                    continue;
                  case 11:
                    response = result2;
                    num3 = 7;
                    continue;
                  case 12:
                    taskAwaiter1 = awaiter1;
                    num4 = 14;
                    break;
                  case 13:
                    try
                    {
                      int num5;
                      if (num2 != 1)
                        num5 = 2;
                      else
                        goto label_61;
label_19:
                      Stream stream;
                      while (true)
                      {
                        switch (num5)
                        {
                          case 1:
                            goto label_75;
                          case 2:
                            // ISSUE: reference to a compiler-generated method
                            stream = (Stream) SimpleWebClient.\u003CGetResponse\u003Ed__6.lunOd8QcpApwBTuKJAq2((object) response);
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 4 : 2;
                            continue;
                          case 3:
label_60:
                            stream = (Stream) null;
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
                            continue;
                          case 4:
                            goto label_61;
                          default:
                            try
                            {
                              int num6;
                              if (num2 != 1)
                              {
                                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 1 : 3;
                                goto label_25;
                              }
                              else
                                goto label_51;
label_24:
                              int num7;
                              num6 = num7;
label_25:
                              StreamReader streamReader;
                              while (true)
                              {
                                switch (num6)
                                {
                                  case 1:
                                    goto label_47;
                                  case 2:
label_48:
                                    streamReader = (StreamReader) null;
                                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
                                    continue;
                                  case 3:
                                    if (stream == null)
                                    {
                                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
                                      continue;
                                    }
                                    goto case 6;
                                  case 4:
                                    goto label_51;
                                  case 5:
                                    try
                                    {
                                      int num8;
                                      if (num2 != 1)
                                        num8 = 11;
                                      else
                                        goto label_29;
label_28:
                                      TaskAwaiter<string> taskAwaiter2;
                                      TaskAwaiter<string> awaiter2;
                                      while (true)
                                      {
                                        switch (num8)
                                        {
                                          case 1:
                                            taskAwaiter2 = awaiter2;
                                            num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 5 : 1;
                                            continue;
                                          case 2:
                                            goto label_29;
                                          case 3:
                                          case 6:
                                            str = awaiter2.GetResult();
                                            num8 = 10;
                                            continue;
                                          case 4:
                                            // ISSUE: explicit reference operation
                                            // ISSUE: reference to a compiler-generated field
                                            (^this).\u003C\u003E1__state = num2 = 1;
                                            num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 1;
                                            continue;
                                          case 5:
                                            // ISSUE: explicit reference operation
                                            // ISSUE: reference to a compiler-generated field
                                            (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, SimpleWebClient.\u003CGetResponse\u003Ed__6>(ref awaiter2, this);
                                            num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 7 : 7;
                                            continue;
                                          case 7:
                                            goto label_84;
                                          case 8:
                                            taskAwaiter2 = new TaskAwaiter<string>();
                                            num8 = 9;
                                            continue;
                                          case 9:
                                            // ISSUE: explicit reference operation
                                            // ISSUE: reference to a compiler-generated field
                                            (^this).\u003C\u003E1__state = num2 = -1;
                                            num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 3 : 1;
                                            continue;
                                          case 10:
                                            goto label_48;
                                          case 11:
                                            awaiter2 = streamReader.ReadToEndAsync().GetAwaiter();
                                            num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
                                            continue;
                                          default:
                                            if (awaiter2.IsCompleted)
                                            {
                                              num8 = 6;
                                              continue;
                                            }
                                            goto case 4;
                                        }
                                      }
label_84:
                                      return;
label_29:
                                      awaiter2 = taskAwaiter2;
                                      num8 = 8;
                                      goto label_28;
                                    }
                                    finally
                                    {
                                      if (num2 < 0)
                                      {
                                        int num9 = 2;
                                        while (true)
                                        {
                                          switch (num9)
                                          {
                                            case 1:
                                              goto label_45;
                                            case 2:
                                              if (streamReader != null)
                                              {
                                                num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
                                                continue;
                                              }
                                              goto label_45;
                                            default:
                                              // ISSUE: reference to a compiler-generated method
                                              SimpleWebClient.\u003CGetResponse\u003Ed__6.APiI04Qca9A4K5VZBdqq((object) streamReader);
                                              num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 1 : 0;
                                              continue;
                                          }
                                        }
                                      }
label_45:;
                                    }
                                  case 6:
                                    streamReader = new StreamReader(stream);
                                    num6 = 4;
                                    continue;
                                  default:
                                    goto label_60;
                                }
                              }
label_47:
                              str = string.Empty;
                              num7 = 6;
                              goto label_24;
label_51:
                              num7 = 5;
                              goto label_24;
                            }
                            finally
                            {
                              int num10;
                              if (num2 >= 0)
                                num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 1;
                              else
                                goto label_56;
label_54:
                              while (true)
                              {
                                switch (num10)
                                {
                                  case 1:
                                  case 3:
                                    goto label_59;
                                  case 2:
                                    goto label_56;
                                  default:
                                    stream.Dispose();
                                    num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 3 : 1;
                                    continue;
                                }
                              }
label_56:
                              if (stream != null)
                              {
                                num10 = 0;
                                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
                                {
                                  num10 = 0;
                                  goto label_54;
                                }
                                else
                                  goto label_54;
                              }
label_59:;
                            }
                        }
                      }
label_61:
                      num5 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0)
                      {
                        num5 = 0;
                        goto label_19;
                      }
                      else
                        goto label_19;
                    }
                    finally
                    {
                      if (num2 < 0)
                      {
                        int num11 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
                          num11 = 0;
                        while (true)
                        {
                          switch (num11)
                          {
                            case 1:
                              // ISSUE: reference to a compiler-generated method
                              SimpleWebClient.\u003CGetResponse\u003Ed__6.APiI04Qca9A4K5VZBdqq((object) response);
                              num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 2 : 1;
                              continue;
                            case 2:
                              goto label_70;
                            default:
                              if (response != null)
                              {
                                num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 0;
                                continue;
                              }
                              goto label_70;
                          }
                        }
                      }
label_70:;
                    }
                  case 14:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<WebResponse>, SimpleWebClient.\u003CGetResponse\u003Ed__6>(ref awaiter1, this);
                    num3 = 9;
                    continue;
                  case 15:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 5 : 1;
                    continue;
                  case 16:
                  case 17:
                    awaiter1 = taskAwaiter1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 6 : 5;
                    continue;
                  case 18:
                    str = (string) null;
                    num4 = 3;
                    break;
                  default:
                    goto label_3;
                }
                num3 = num4;
              }
label_80:
              return;
label_11:
              if (num2 != 1)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 15 : 18;
                goto label_7;
              }
label_74:
              num3 = 13;
              goto label_7;
            }
            catch (Exception ex)
            {
              int num12 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
                num12 = 0;
              while (true)
              {
                switch (num12)
                {
                  case 1:
                    goto label_79;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 0;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num12 = 2;
                    continue;
                }
              }
label_79:
              return;
            }
          case 4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = 3;
            continue;
        }
label_3:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        (^this).\u003C\u003E1__state = -2;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 1;
      }
label_87:;
    }

    private void SendRequestWrite(byte[] buffer, int offset, int length, (Stream, string) param)
    {
      (Stream stream, string s) = param;
      Encoding.UTF8.GetBytes(s, 0, s.Length, buffer, offset);
      stream.Write(buffer, offset, length);
    }

    internal static void tDG22yWreoTNV3x8I4QM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object MGpTtRWrP8JNLvRl8bTO(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void GCNVAGWr144XGB9xEX0O([In] object obj0, [In] object obj1) => Contract.ArgumentNotNullOrEmpty((string) obj0, (string) obj1);

    internal static bool DBgVjTWrOidcDtYt7pqJ() => SimpleWebClient.vHxD4xWrnTboZWQTHLoa == null;

    internal static SimpleWebClient nGdGViWr2j6RluTEQHYu() => SimpleWebClient.vHxD4xWrnTboZWQTHLoa;

    internal static AsyncTaskMethodBuilder kjfy5AWrN2IJClt64Zt5() => AsyncTaskMethodBuilder.Create();
  }
}
