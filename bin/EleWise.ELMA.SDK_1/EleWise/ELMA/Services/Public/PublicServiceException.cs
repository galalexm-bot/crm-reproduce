// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Public.PublicServiceException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.ServiceModel.Web;
using System.Xml.Serialization;

namespace EleWise.ELMA.Services.Public
{
  /// <summary>Исключение, для публичного сервиса</summary>
  [DataContract]
  [Serializable]
  public class PublicServiceException
  {
    private int statusCode;
    internal static PublicServiceException HVGtNsBmhgO0XpOebAcZ;

    /// <summary>Создать исключение</summary>
    /// <param name="message">Сообщение</param>
    /// <param name="statusCode">Статус, <see cref="T:System.Net.HttpStatusCode" /></param>
    /// <returns></returns>
    public static Exception CreateWebFault(string message, int statusCode = 200) => (Exception) new WebFaultException<PublicServiceException>(new PublicServiceException(message, statusCode), HttpStatusCode.BadRequest);

    /// <summary>Создать исключение</summary>
    /// <param name="message">Сообщение</param>
    /// <param name="statusCode">Статус, <see cref="T:System.Net.HttpStatusCode" /></param>
    /// <param name="innerException">Внутреннее исключение</param>
    /// <returns></returns>
    public static Exception CreateWebFault(
      string message,
      Exception innerException,
      int statusCode = 200)
    {
      return (Exception) new WebFaultException<PublicServiceException>(new PublicServiceException(message, statusCode, innerException), HttpStatusCode.BadRequest);
    }

    /// <summary>
    /// Код статуса исключения.
    /// Чаще всего используются значения <see cref="T:System.Net.HttpStatusCode" />
    /// </summary>
    [DataMember]
    [XmlElement("StatusCode")]
    public int StatusCode
    {
      get => this.statusCode;
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
              this.statusCode = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
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

    /// <summary>Сообщение</summary>
    [XmlElement("Message")]
    [DataMember]
    public string Message
    {
      get => this.\u003CMessage\u003Ek__BackingField;
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
              this.\u003CMessage\u003Ek__BackingField = value;
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

    /// <summary>Внутреннее исключение</summary>
    [DataMember]
    [XmlElement("InnerException")]
    public PublicServiceException InnerException
    {
      get => this.\u003CInnerException\u003Ek__BackingField;
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
              this.\u003CInnerException\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
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

    public PublicServiceException()
    {
      PublicServiceException.wMAtUyBmfUus9eDiTEF2();
      this.statusCode = 200;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Выполняет инициализацию нового экземпляра класса <see cref="T:System.Exception" />, используя указанное сообщение об ошибке.
    /// </summary>
    /// <param name="message">Сообщение, описывающее ошибку. </param>
    public PublicServiceException(string message)
    {
      PublicServiceException.wMAtUyBmfUus9eDiTEF2();
      this.statusCode = 200;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Message = message;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
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
    /// Выполняет инициализацию нового экземпляра класса <see cref="T:System.Exception" />, используя указанное сообщение об ошибке.
    /// </summary>
    /// <param name="message">Сообщение, описывающее ошибку. </param>
    public PublicServiceException(string message, int statusCode)
    {
      PublicServiceException.wMAtUyBmfUus9eDiTEF2();
      this.statusCode = 200;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.StatusCode = statusCode;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
            continue;
          case 2:
            this.Message = message;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 1 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <summary>
    /// Выполняет инициализацию нового экземпляра класса <see cref="T:System.Exception" /> с указанным сообщением об ошибке и ссылкой на внутреннее исключение, которое стало причиной данного исключения.
    /// </summary>
    /// <param name="message">Сообщение об ошибке с объяснением причины исключения. </param>
    /// <param name="innerException">Исключение, вызвавшее текущее исключение, или указатель NULL (Nothing в Visual Basic), если внутреннее исключение не задано. </param>
    public PublicServiceException(string message, int statusCode, Exception innerException)
    {
      PublicServiceException.wMAtUyBmfUus9eDiTEF2();
      this.statusCode = 200;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.StatusCode = statusCode;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
            continue;
          case 2:
            this.SetInnerException(innerException);
            num = 3;
            continue;
          case 3:
            goto label_3;
          default:
            this.Message = message;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>
    /// Выполняет инициализацию нового экземпляра класса <see cref="T:System.Exception" /> с указанным сообщением об ошибке и ссылкой на внутреннее исключение, которое стало причиной данного исключения.
    /// </summary>
    /// <param name="exception">Исключение, вызвавшее текущее исключение, или указатель NULL (Nothing в Visual Basic), если внутреннее исключение не задано. </param>
    public PublicServiceException(Exception exception)
    {
      PublicServiceException.wMAtUyBmfUus9eDiTEF2();
      this.statusCode = 200;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.InitializeFromException(exception);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>
    /// Выполняет инициализацию нового экземпляра класса <see cref="T:System.Exception" /> с указанным сообщением об ошибке и ссылкой на внутреннее исключение, которое стало причиной данного исключения.
    /// </summary>
    /// <param name="message">Сообщение об ошибке с объяснением причины исключения. </param>
    /// <param name="innerException">Исключение, вызвавшее текущее исключение, или указатель NULL (Nothing в Visual Basic), если внутреннее исключение не задано. </param>
    public PublicServiceException(string message, Exception innerException)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.statusCode = 200;
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
            this.Message = message;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
            continue;
          default:
            this.SetInnerException(innerException);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 1;
            continue;
        }
      }
label_2:;
    }

    private void InitializeFromException(Exception innerException)
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_7;
          case 1:
            goto label_2;
          case 2:
            this.SetInnerException(innerException);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
            continue;
          case 3:
            this.Message = (string) PublicServiceException.PT6qN5BmQI5P1Ucr5604((object) innerException);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 2;
            continue;
          case 4:
            if (innerException == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 1;
              continue;
            }
            goto case 3;
          case 5:
            this.StatusCode = 200;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 4 : 4;
            continue;
          default:
            goto label_9;
        }
      }
label_7:
      return;
label_2:
      return;
label_9:;
    }

    private void SetInnerException(Exception innerException)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            goto label_2;
          case 2:
            if (innerException == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 1;
              continue;
            }
            goto case 3;
          case 3:
            this.InnerException = new PublicServiceException((string) PublicServiceException.PT6qN5BmQI5P1Ucr5604((object) innerException), (Exception) PublicServiceException.gjbc38BmC6iDdGRgy2mL((object) innerException));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_2:
      return;
label_7:;
    }

    internal static bool Ne5UbTBmGJheialv20I4() => PublicServiceException.HVGtNsBmhgO0XpOebAcZ == null;

    internal static PublicServiceException nEm1QvBmE0gfA0Vimq6E() => PublicServiceException.HVGtNsBmhgO0XpOebAcZ;

    internal static void wMAtUyBmfUus9eDiTEF2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object PT6qN5BmQI5P1Ucr5604([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static object gjbc38BmC6iDdGRgy2mL([In] object obj0) => (object) ((Exception) obj0).InnerException;
  }
}
