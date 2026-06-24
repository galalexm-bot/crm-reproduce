// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Contract
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Exceptions;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA
{
  /// <summary>Предоставляет методы для проверки условий</summary>
  public static class Contract
  {
    private static Contract XGuSHmQwLUNwIt3wgc7;

    /// <summary>Выполнить проверку условия</summary>
    /// <typeparam name="TException">Тип исключения</typeparam>
    /// <exception cref="T:TException">Если значение условия равно False</exception>
    /// <param name="condition">Значение условия</param>
    /// <param name="conditionText">Текст условия</param>
    public static void Check<TException>(bool condition, string conditionText) where TException : Exception => Contract.CheckWithMessage<TException>((condition ? 1 : 0) != 0, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675500995), (object) conditionText));

    /// <summary>Выполнить проверку условия</summary>
    /// <typeparam name="TException">Тип исключения</typeparam>
    /// <exception cref="T:TException">Если значение условия равно False</exception>
    /// <param name="condition">Значение условия</param>
    /// <param name="messageText">Текст сообщения об ошибке</param>
    public static void CheckWithMessage<TException>(bool condition, string messageText) where TException : Exception
    {
      if (condition)
        return;
      ConstructorInfo constructorInfo = ((IEnumerable<ConstructorInfo>) typeof (TException).GetConstructors(BindingFlags.Instance | BindingFlags.Public)).FirstOrDefault<ConstructorInfo>((Func<ConstructorInfo, bool>) (c =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (c.GetParameters().Length == 1)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        return c.GetParameters()[0].ParameterType == typeof (string);
label_3:
        return false;
      }));
      if (constructorInfo != (ConstructorInfo) null)
        throw (object) (TException) constructorInfo.Invoke((object[]) new string[1]
        {
          messageText
        });
      throw new Exception(messageText);
    }

    /// <summary>Проверить на Null заданное значение</summary>
    /// <exception cref="T:System.NullReferenceException">Если значение равно Null</exception>
    /// <param name="value">Значение</param>
    /// <param name="valueName">Имя значения</param>
    public static void NotNull(object value, string valueName)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (value != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_3:
      return;
label_2:
      throw new NullReferenceException(SR.T((string) Contract.gOdGblQH8yNFh3O2n0w(-2138160520 ^ -2138146872), (object) valueName));
    }

    /// <summary>Проверить заданное значение строки на Null и пустоту</summary>
    /// <exception cref="T:System.NullReferenceException">Если значение равно Null или пустое</exception>
    /// <param name="value">Значение</param>
    /// <param name="valueName">Имя значения</param>
    public static void NotNullOrEmpty(string value, string valueName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (Contract.t2uZ8ZQAgiwip6Pe29k((object) value))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_3;
        }
      }
label_3:
      throw new NullReferenceException(SR.T((string) Contract.gOdGblQH8yNFh3O2n0w(1232639661 >> 3 ^ 154084599), (object) valueName));
label_2:;
    }

    /// <summary>Проверить на Null значение аргумента метода</summary>
    /// <exception cref="T:System.ArgumentNullException">Если значение параметра равно Null</exception>
    /// <param name="value">Значение параметра</param>
    /// <param name="argumentName">Имя параметра</param>
    public static void ArgumentNotNull(object value, string argumentName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (value == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_3;
        }
      }
label_3:
      throw new ArgumentNullException(argumentName);
label_2:;
    }

    /// <summary>Проверить на Null значение параметра метода</summary>
    /// <exception cref="T:System.ArgumentException">Если значение параметра равно Null или пустое</exception>
    /// <param name="value">Значение параметра</param>
    /// <param name="argumentName">Имя параметра</param>
    public static void ArgumentNotNullOrEmpty(string value, string argumentName)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (!Contract.t2uZ8ZQAgiwip6Pe29k((object) value))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 1 : 1;
              continue;
            }
            goto label_5;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:
      throw new ArgumentException(SR.T((string) Contract.gOdGblQH8yNFh3O2n0w(~-122002947 ^ 122005672), (object) argumentName));
    }

    /// <summary>Проверить условие для параметра метода</summary>
    /// <exception cref="T:System.ArgumentException">Если значение условия равно False</exception>
    /// <param name="condition">Значение условия</param>
    /// <param name="conditionText">Текст условия</param>
    public static void CheckArgument(bool condition, string conditionText)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!condition)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:
      throw new ArgumentException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112715866), (object) conditionText));
    }

    /// <summary>Проверить на Null значение сервиса</summary>
    /// <exception cref="T:EleWise.ELMA.Exceptions.ServiceNotFoundException">Если значение сервиса равно Null</exception>
    /// <param name="service">Значение сервиса</param>
    /// <param name="serviceName">Имя сервиса</param>
    public static void ServiceNotNull(object service, string serviceName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (service == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:
      throw new ServiceNotFoundException(serviceName);
    }

    internal static object gOdGblQH8yNFh3O2n0w(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool sjitIrQ4DTTg0J9MuhM() => Contract.XGuSHmQwLUNwIt3wgc7 == null;

    internal static Contract bFNkgAQ685xf08AhZ2Z() => Contract.XGuSHmQwLUNwIt3wgc7;

    internal static bool t2uZ8ZQAgiwip6Pe29k([In] object obj0) => string.IsNullOrEmpty((string) obj0);
  }
}
