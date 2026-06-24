// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Cryptography.ElmaCryptoProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Memory;
using EleWise.ELMA.Text;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace EleWise.ELMA.Security.Cryptography
{
  /// <summary>Провайдер шифрования</summary>
  public static class ElmaCryptoProvider
  {
    private static ElmaCryptoProvider NW9ct4BL7uDHSq4PCOO8;

    /// <summary>Зашифровать пароль (с возможностью расшифровки)</summary>
    /// <param name="pwd">Пароль</param>
    /// <returns>Зашифрованный пароль</returns>
    public static string EncryptPassword(string pwd)
    {
      int num1 = 2;
      RijndaelManaged rijndaelManaged;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            rijndaelManaged = new RijndaelManaged();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 1;
            continue;
          default:
            goto label_44;
        }
      }
label_3:
      string str;
      try
      {
        MemoryStream memoryStream = (MemoryStream) ElmaCryptoProvider.yg5BXKBLmWrvoIoF0S2S();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              CryptoStream cryptoStream = new CryptoStream((Stream) ElmaCryptoProvider.NXJBIeBLyMHM9QpVi4OD((object) memoryStream), (ICryptoTransform) ElmaCryptoProvider.Q6fJXIBL9WhtM4grZVSD((object) rijndaelManaged, (object) ((ElmaCryptoProvider.Container) ElmaCryptoProvider.w6bFWOBLMewq6fK5V0SE()).GetPub(), ElmaCryptoProvider.dM96JtBLJs3ih9JUaCqp(ElmaCryptoProvider.w6bFWOBLMewq6fK5V0SE())), CryptoStreamMode.Write);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
                num3 = 0;
              while (true)
              {
                switch (num3)
                {
                  case 1:
label_10:
                    ElmaCryptoProvider.rvpTE3BLrVbMYZqaGCUs((object) memoryStream, 0L, SeekOrigin.Begin);
                    num3 = 2;
                    continue;
                  case 2:
                    str = MemoryHelper.ActionWithMemoryBuffer<byte, MemoryStream, string>((int) ElmaCryptoProvider.enDQj0BLgTd979M7UhZ3((object) memoryStream), memoryStream, new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, MemoryStream, string>(ElmaCryptoProvider.EncryptPasswordAction));
                    num3 = 3;
                    continue;
                  case 3:
                    goto label_44;
                  default:
                    try
                    {
                      StreamWriter streamWriter = new StreamWriter((Stream) cryptoStream);
                      int num4 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
                        num4 = 0;
                      switch (num4)
                      {
                        default:
                          try
                          {
                            ElmaCryptoProvider.E8Sex1BLd9qmbemZV2ne((object) streamWriter, (object) pwd);
                            int num5 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
                              num5 = 0;
                            switch (num5)
                            {
                              default:
                                goto label_10;
                            }
                          }
                          finally
                          {
                            int num6;
                            if (streamWriter == null)
                              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 1;
                            else
                              goto label_23;
label_22:
                            switch (num6)
                            {
                              case 2:
                                break;
                              default:
                            }
label_23:
                            ElmaCryptoProvider.DIAPpYBLlbfhAxx9BGbI((object) streamWriter);
                            num6 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
                            {
                              num6 = 0;
                              goto label_22;
                            }
                            else
                              goto label_22;
                          }
                      }
                    }
                    finally
                    {
                      if (cryptoStream != null)
                      {
                        int num7 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0)
                          num7 = 0;
                        while (true)
                        {
                          switch (num7)
                          {
                            case 1:
                              goto label_31;
                            default:
                              ElmaCryptoProvider.DIAPpYBLlbfhAxx9BGbI((object) cryptoStream);
                              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 1;
                              continue;
                          }
                        }
                      }
label_31:;
                    }
                }
              }
            }
            finally
            {
              int num8;
              if (memoryStream == null)
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
              else
                goto label_35;
label_34:
              switch (num8)
              {
                case 2:
                  break;
                default:
              }
label_35:
              ElmaCryptoProvider.DIAPpYBLlbfhAxx9BGbI((object) memoryStream);
              num8 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
              {
                num8 = 1;
                goto label_34;
              }
              else
                goto label_34;
            }
        }
      }
      finally
      {
        if (rijndaelManaged != null)
        {
          int num9 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
            num9 = 0;
          while (true)
          {
            switch (num9)
            {
              case 1:
                goto label_43;
              default:
                ElmaCryptoProvider.DIAPpYBLlbfhAxx9BGbI((object) rijndaelManaged);
                num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 1;
                continue;
            }
          }
        }
label_43:;
      }
label_44:
      return str;
    }

    private static string EncryptPasswordAction(
      object buffer,
      int offset,
      int length,
      object memoryStream)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ElmaCryptoProvider.c0A69WBL5ToMBWGR7BFv(memoryStream, buffer, offset, length);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return Convert.ToBase64String((byte[]) buffer, offset, length);
    }

    /// <summary>
    /// Расшифровать пароль
    /// Для расшифровки будут взяты символы только первой строки(до "\r\n")
    /// </summary>
    /// <param name="pwd">Зашифрованный пароль</param>
    /// <returns>Расшифрованный пароль</returns>
    public static string DecryptPassword(string pwd)
    {
      int num1 = 3;
      RijndaelManaged rijndaelManaged;
      byte[] numArray;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            rijndaelManaged = new RijndaelManaged();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
            continue;
          case 3:
            numArray = (byte[]) ElmaCryptoProvider.PYRQwXBLjuUcvBVqRiIV((object) pwd);
            num1 = 2;
            continue;
          default:
            goto label_4;
        }
      }
label_3:
      string str;
      return str;
label_4:
      try
      {
        MemoryStream memoryStream = (MemoryStream) ElmaCryptoProvider.q3Ouw8BLYuWLvriEWv4I((object) numArray, false);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, (ICryptoTransform) ElmaCryptoProvider.BCknJABLULRuBSOGMA12((object) rijndaelManaged, ElmaCryptoProvider.JXJiXcBLLKMhhDOhqVJh(ElmaCryptoProvider.w6bFWOBLMewq6fK5V0SE()), ElmaCryptoProvider.dM96JtBLJs3ih9JUaCqp(ElmaCryptoProvider.w6bFWOBLMewq6fK5V0SE())), CryptoStreamMode.Read);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
                num3 = 0;
              switch (num3)
              {
                default:
                  try
                  {
                    StreamReader streamReader = new StreamReader((Stream) cryptoStream);
                    int num4 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
                      num4 = 0;
                    switch (num4)
                    {
                      default:
                        try
                        {
                          str = streamReader.ReadLine();
                          int num5 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0)
                            num5 = 0;
                          switch (num5)
                          {
                            default:
                              goto label_3;
                          }
                        }
                        finally
                        {
                          if (streamReader != null)
                          {
                            int num6 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
                              num6 = 0;
                            while (true)
                            {
                              switch (num6)
                              {
                                case 1:
                                  goto label_25;
                                default:
                                  ElmaCryptoProvider.DIAPpYBLlbfhAxx9BGbI((object) streamReader);
                                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 0;
                                  continue;
                              }
                            }
                          }
label_25:;
                        }
                    }
                  }
                  finally
                  {
                    if (cryptoStream != null)
                    {
                      int num7 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
                        num7 = 0;
                      while (true)
                      {
                        switch (num7)
                        {
                          case 1:
                            goto label_31;
                          default:
                            ElmaCryptoProvider.DIAPpYBLlbfhAxx9BGbI((object) cryptoStream);
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 1;
                            continue;
                        }
                      }
                    }
label_31:;
                  }
              }
            }
            finally
            {
              int num8;
              if (memoryStream == null)
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 0;
              else
                goto label_35;
label_34:
              switch (num8)
              {
                case 2:
                  break;
                default:
              }
label_35:
              ElmaCryptoProvider.DIAPpYBLlbfhAxx9BGbI((object) memoryStream);
              num8 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
              {
                num8 = 0;
                goto label_34;
              }
              else
                goto label_34;
            }
        }
      }
      finally
      {
        if (rijndaelManaged != null)
        {
          int num9 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
            num9 = 1;
          while (true)
          {
            switch (num9)
            {
              case 1:
                ElmaCryptoProvider.DIAPpYBLlbfhAxx9BGbI((object) rijndaelManaged);
                num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
                continue;
              default:
                goto label_43;
            }
          }
        }
label_43:;
      }
    }

    /// <summary>Расшифровать пароль</summary>
    /// <param name="pwd">Зашифрованный пароль</param>
    /// <returns>Расшифрованный пароль</returns>
    public static SecureString DecryptPasswordSecure(string pwd)
    {
      int num1 = 3;
      byte[] buffer;
      RijndaelManaged rijndaelManaged;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            rijndaelManaged = new RijndaelManaged();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 1;
            continue;
          case 3:
            buffer = (byte[]) ElmaCryptoProvider.PYRQwXBLjuUcvBVqRiIV((object) pwd);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 2 : 1;
            continue;
          default:
            goto label_39;
        }
      }
label_2:
      SecureString secureString1;
      try
      {
        MemoryStream memoryStream = MemoryHelper.GetMemoryStream(buffer, false);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, (ICryptoTransform) ElmaCryptoProvider.BCknJABLULRuBSOGMA12((object) rijndaelManaged, ElmaCryptoProvider.JXJiXcBLLKMhhDOhqVJh(ElmaCryptoProvider.w6bFWOBLMewq6fK5V0SE()), ElmaCryptoProvider.dM96JtBLJs3ih9JUaCqp((object) ElmaCryptoProvider.Container.Instance)), CryptoStreamMode.Read);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
                num3 = 0;
              switch (num3)
              {
                default:
                  try
                  {
                    SecureString secureString2 = new SecureString();
                    int num4 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
                      num4 = 0;
                    int num5;
                    while (true)
                    {
                      switch (num4)
                      {
                        case 1:
                          goto label_39;
                        case 2:
                        case 3:
                          ElmaCryptoProvider.CYsbokBLcB76nLaQFEfg((object) secureString2, Convert.ToChar(num5));
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 1 : 5;
                          continue;
                        case 4:
                          secureString1 = secureString2;
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 1 : 1;
                          continue;
                        case 5:
                          num5 = ElmaCryptoProvider.JdtPk9BLsI44i6oC3v4y((object) cryptoStream);
                          num4 = 7;
                          continue;
                        case 6:
                        case 7:
                          if (num5 > -1)
                          {
                            num4 = 2;
                            continue;
                          }
                          goto case 4;
                        default:
                          num5 = ElmaCryptoProvider.JdtPk9BLsI44i6oC3v4y((object) cryptoStream);
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 4 : 6;
                          continue;
                      }
                    }
                  }
                  finally
                  {
                    if (cryptoStream != null)
                    {
                      int num6 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
                        num6 = 1;
                      while (true)
                      {
                        switch (num6)
                        {
                          case 1:
                            cryptoStream.Dispose();
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_24;
                        }
                      }
                    }
label_24:;
                  }
              }
            }
            finally
            {
              if (memoryStream != null)
              {
                int num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
                  num7 = 0;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      goto label_30;
                    default:
                      ElmaCryptoProvider.DIAPpYBLlbfhAxx9BGbI((object) memoryStream);
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 1 : 0;
                      continue;
                  }
                }
              }
label_30:;
            }
        }
      }
      finally
      {
        if (rijndaelManaged != null)
        {
          int num8 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
            num8 = 0;
          while (true)
          {
            switch (num8)
            {
              case 1:
                goto label_36;
              default:
                ElmaCryptoProvider.DIAPpYBLlbfhAxx9BGbI((object) rijndaelManaged);
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 0;
                continue;
            }
          }
        }
label_36:;
      }
label_39:
      return secureString1;
    }

    /// <summary>Закодировать текст по алгоритму AES-256</summary>
    /// <param name="text">Текст</param>
    /// <param name="key">Ключ</param>
    /// <param name="iv">Вектор инициализации</param>
    /// <returns>hex string</returns>
    public static string EncryptTextAes256(string text, byte[] key, byte[] iv)
    {
      int num1 = 1;
      RijndaelManaged rijndaelManaged1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            RijndaelManaged rijndaelManaged2 = new RijndaelManaged();
            rijndaelManaged2.KeySize = 256;
            ElmaCryptoProvider.DUT1lrBLzTLAcf1OY9d8((object) rijndaelManaged2, 256);
            rijndaelManaged1 = rijndaelManaged2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_34;
          default:
            goto label_3;
        }
      }
label_3:
      string str;
      try
      {
        MemoryStream memoryStream = (MemoryStream) ElmaCryptoProvider.yg5BXKBLmWrvoIoF0S2S();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              CryptoStream cryptoStream = new CryptoStream((Stream) ElmaCryptoProvider.NXJBIeBLyMHM9QpVi4OD((object) memoryStream), rijndaelManaged1.CreateEncryptor(key, iv), CryptoStreamMode.Write);
              int num3 = 3;
              while (true)
              {
                switch (num3)
                {
                  case 1:
label_11:
                    ElmaCryptoProvider.rvpTE3BLrVbMYZqaGCUs((object) memoryStream, 0L, SeekOrigin.Begin);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 2 : 2;
                    continue;
                  case 2:
                    str = MemoryHelper.ActionWithMemoryBuffer<byte, MemoryStream, string>((int) ElmaCryptoProvider.enDQj0BLgTd979M7UhZ3((object) memoryStream), memoryStream, new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, MemoryStream, string>(ElmaCryptoProvider.EncryptTextAes256ToString));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
                    continue;
                  case 3:
                    try
                    {
                      MemoryHelper.ActionWithMemoryBuffer<byte, (CryptoStream, string)>(EncodingCache.UTF8WithoutEmitIdentifier.GetByteCount(text), (cryptoStream, text), new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, (CryptoStream, string)>(ElmaCryptoProvider.EncryptTextAes256WriteStream));
                      int num4 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
                        num4 = 1;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                            ElmaCryptoProvider.uKykuJBUFLCQUeKHp0qA((object) cryptoStream);
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_11;
                        }
                      }
                    }
                    finally
                    {
                      int num5;
                      if (cryptoStream == null)
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
                      else
                        goto label_19;
label_18:
                      switch (num5)
                      {
                        case 2:
                          break;
                        default:
                      }
label_19:
                      ElmaCryptoProvider.DIAPpYBLlbfhAxx9BGbI((object) cryptoStream);
                      num5 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
                      {
                        num5 = 1;
                        goto label_18;
                      }
                      else
                        goto label_18;
                    }
                  default:
                    goto label_34;
                }
              }
            }
            finally
            {
              if (memoryStream != null)
              {
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
                  num6 = 0;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      goto label_27;
                    default:
                      ElmaCryptoProvider.DIAPpYBLlbfhAxx9BGbI((object) memoryStream);
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 1 : 1;
                      continue;
                  }
                }
              }
label_27:;
            }
        }
      }
      finally
      {
        int num7;
        if (rijndaelManaged1 == null)
          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 0;
        else
          goto label_31;
label_30:
        switch (num7)
        {
          case 1:
          case 2:
        }
label_31:
        rijndaelManaged1.Dispose();
        num7 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
        {
          num7 = 2;
          goto label_30;
        }
        else
          goto label_30;
      }
label_34:
      return str;
    }

    private static string EncryptTextAes256ToString(
      object bytes,
      int bufferOffset,
      int bufferLength,
      object stream)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ((Stream) stream).Read((byte[]) bytes, bufferOffset, bufferLength);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (string) ElmaCryptoProvider.JifloNBUo6rbSg2JPsW6(ElmaCryptoProvider.OtuNyEBUBU9KILtUiHsy(bytes, bufferOffset, bufferLength), ElmaCryptoProvider.slUp5gBUWGEHW3l0wAud(-1146510045 ^ -1146508465), (object) "");
    }

    private static void EncryptTextAes256WriteStream(
      object buffer,
      int offset,
      int length,
      (CryptoStream, string) param)
    {
      (CryptoStream cryptoStream, string s) = param;
      EncodingCache.UTF8WithoutEmitIdentifier.GetBytes(s, 0, s.Length, (byte[]) buffer, offset);
      cryptoStream.Write((byte[]) buffer, offset, length);
    }

    /// <summary>Раскодировать текст по алгоритму AES-256</summary>
    /// <param name="encodedData">Закодированные данные</param>
    /// <param name="key">Ключ</param>
    /// <param name="iv">Вектор инициализации</param>
    public static string DecryptTextAes256(byte[] encodedData, byte[] key, byte[] iv)
    {
      int num1 = 2;
      RijndaelManaged rijndaelManaged1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            RijndaelManaged rijndaelManaged2 = new RijndaelManaged();
            ElmaCryptoProvider.vWFbqxBUbfUZdnmrcY94((object) rijndaelManaged2, 256);
            ElmaCryptoProvider.DUT1lrBLzTLAcf1OY9d8((object) rijndaelManaged2, 256);
            rijndaelManaged1 = rijndaelManaged2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 1 : 1;
            continue;
          default:
            goto label_33;
        }
      }
label_2:
      string str;
      try
      {
        MemoryStream memoryStream = (MemoryStream) ElmaCryptoProvider.yg5BXKBLmWrvoIoF0S2S();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              CryptoStream cryptoStream = new CryptoStream((Stream) ElmaCryptoProvider.NXJBIeBLyMHM9QpVi4OD((object) memoryStream), (ICryptoTransform) ElmaCryptoProvider.BCknJABLULRuBSOGMA12((object) rijndaelManaged1, (object) key, (object) iv), CryptoStreamMode.Write);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
                num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    try
                    {
                      ElmaCryptoProvider.BPTTQhBUh4u8kDhc3Gvm((object) cryptoStream, (object) encodedData, 0, encodedData.Length);
                      int num4 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
                        num4 = 0;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                            goto label_19;
                          default:
                            ElmaCryptoProvider.uKykuJBUFLCQUeKHp0qA((object) cryptoStream);
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 1;
                            continue;
                        }
                      }
                    }
                    finally
                    {
                      if (cryptoStream != null)
                      {
                        int num5 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
                          num5 = 0;
                        while (true)
                        {
                          switch (num5)
                          {
                            case 1:
                              goto label_18;
                            default:
                              ElmaCryptoProvider.DIAPpYBLlbfhAxx9BGbI((object) cryptoStream);
                              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 1 : 1;
                              continue;
                          }
                        }
                      }
label_18:;
                    }
                  case 2:
                    goto label_33;
                }
label_19:
                str = (string) ElmaCryptoProvider.amxsXIBUGdEF8V1CfJqy((object) memoryStream, (object) EncodingCache.UTF8WithoutEmitIdentifier);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 1 : 2;
              }
            }
            finally
            {
              if (memoryStream != null)
              {
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
                  num6 = 0;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      goto label_25;
                    default:
                      ElmaCryptoProvider.DIAPpYBLlbfhAxx9BGbI((object) memoryStream);
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 1 : 1;
                      continue;
                  }
                }
              }
label_25:;
            }
        }
      }
      finally
      {
        int num7;
        if (rijndaelManaged1 == null)
          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
        else
          goto label_29;
label_28:
        switch (num7)
        {
          case 1:
            break;
          default:
        }
label_29:
        ElmaCryptoProvider.DIAPpYBLlbfhAxx9BGbI((object) rijndaelManaged1);
        num7 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
        {
          num7 = 2;
          goto label_28;
        }
        else
          goto label_28;
      }
label_33:
      return str;
    }

    /// <summary>Раскодировать текст по алгоритму AES-256</summary>
    /// <param name="encodedData">Данные в формате hex-string</param>
    /// <param name="key">Ключ</param>
    /// <param name="iv">Вектор инициализации</param>
    /// <returns></returns>
    public static string DecryptTextAes256(string encodedData, byte[] key, byte[] iv)
    {
      int num = 2;
      string encodedData1;
      while (true)
      {
        switch (num)
        {
          case 1:
            encodedData1 = encodedData;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 1 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      IEnumerable<int> source = Enumerable.Range(0, encodedData1.Length);
      // ISSUE: reference to a compiler-generated field
      Func<int, bool> func = ElmaCryptoProvider.\u003C\u003Ec.\u003C\u003E9__9_0;
      Func<int, bool> predicate;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        ElmaCryptoProvider.\u003C\u003Ec.\u003C\u003E9__9_0 = predicate = (Func<int, bool>) (x => (x & 1) == 0);
      }
      else
        goto label_5;
label_7:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return ElmaCryptoProvider.DecryptTextAes256(source.Where<int>(predicate).Select<int, byte>((Func<int, byte>) (x => ElmaCryptoProvider.\u003C\u003Ec__DisplayClass9_0.HSJpaVQP0a6gC8bJEy05(ElmaCryptoProvider.\u003C\u003Ec__DisplayClass9_0.N9HJWhQPxX43LduvKnPF((object) encodedData1, x, 2), 16))).ToArray<byte>(), key, iv);
label_5:
      predicate = func;
      goto label_7;
    }

    internal static object yg5BXKBLmWrvoIoF0S2S() => (object) MemoryHelper.GetMemoryStream();

    internal static object NXJBIeBLyMHM9QpVi4OD([In] object obj0) => (object) ((MemoryStream) obj0).AsNoClose();

    internal static object w6bFWOBLMewq6fK5V0SE() => (object) ElmaCryptoProvider.Container.Instance;

    internal static object dM96JtBLJs3ih9JUaCqp([In] object obj0) => (object) ((ElmaCryptoProvider.Container) obj0).GetIv();

    internal static object Q6fJXIBL9WhtM4grZVSD([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((SymmetricAlgorithm) obj0).CreateEncryptor((byte[]) obj1, (byte[]) obj2);

    internal static void E8Sex1BLd9qmbemZV2ne([In] object obj0, [In] object obj1) => ((TextWriter) obj0).Write((string) obj1);

    internal static void DIAPpYBLlbfhAxx9BGbI([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static long rvpTE3BLrVbMYZqaGCUs([In] object obj0, [In] long obj1, [In] SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

    internal static long enDQj0BLgTd979M7UhZ3([In] object obj0) => ((Stream) obj0).Length;

    internal static bool gGQ6ORBLx66uTkOTg0MO() => ElmaCryptoProvider.NW9ct4BL7uDHSq4PCOO8 == null;

    internal static ElmaCryptoProvider XfqEEoBL0D9YipHkg0jG() => ElmaCryptoProvider.NW9ct4BL7uDHSq4PCOO8;

    internal static int c0A69WBL5ToMBWGR7BFv([In] object obj0, [In] object obj1, [In] int obj2, [In] int obj3) => ((Stream) obj0).Read((byte[]) obj1, obj2, obj3);

    internal static object PYRQwXBLjuUcvBVqRiIV([In] object obj0) => (object) Convert.FromBase64String((string) obj0);

    internal static object q3Ouw8BLYuWLvriEWv4I([In] object obj0, bool writable) => (object) MemoryHelper.GetMemoryStream((byte[]) obj0, writable);

    internal static object JXJiXcBLLKMhhDOhqVJh([In] object obj0) => (object) ((ElmaCryptoProvider.Container) obj0).GetPub();

    internal static object BCknJABLULRuBSOGMA12([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((SymmetricAlgorithm) obj0).CreateDecryptor((byte[]) obj1, (byte[]) obj2);

    internal static int JdtPk9BLsI44i6oC3v4y([In] object obj0) => ((Stream) obj0).ReadByte();

    internal static void CYsbokBLcB76nLaQFEfg([In] object obj0, [In] char obj1) => ((SecureString) obj0).AppendChar(obj1);

    internal static void DUT1lrBLzTLAcf1OY9d8([In] object obj0, [In] int obj1) => ((SymmetricAlgorithm) obj0).BlockSize = obj1;

    internal static void uKykuJBUFLCQUeKHp0qA([In] object obj0) => ((CryptoStream) obj0).FlushFinalBlock();

    internal static object OtuNyEBUBU9KILtUiHsy([In] object obj0, [In] int obj1, [In] int obj2) => (object) BitConverter.ToString((byte[]) obj0, obj1, obj2);

    internal static object slUp5gBUWGEHW3l0wAud(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object JifloNBUo6rbSg2JPsW6([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static void vWFbqxBUbfUZdnmrcY94([In] object obj0, [In] int obj1) => ((SymmetricAlgorithm) obj0).KeySize = obj1;

    internal static void BPTTQhBUh4u8kDhc3Gvm([In] object obj0, [In] object obj1, [In] int obj2, [In] int obj3) => ((Stream) obj0).Write((byte[]) obj1, obj2, obj3);

    internal static object amxsXIBUGdEF8V1CfJqy([In] object obj0, [In] object obj1) => (object) ((MemoryStream) obj0).AsString((Encoding) obj1);

    private sealed class Container
    {
      private static object instance;
      private object pubKey;
      private object iv;
      internal static object U8PEAkQPDIxYP6oOAUy5;

      private Container()
      {
        ElmaCryptoProvider.Container.AhugMaQP46dC4c3bqvwe();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.Init();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 1 : 0;
              continue;
          }
        }
label_3:;
      }

      private void Init()
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              byte[] numArray1 = new byte[16];
              // ISSUE: field reference
              ElmaCryptoProvider.Container.JD30vbQP6OBO7gU8TbvG((object) numArray1, __fieldref (\u003CPrivateImplementationDetails\u003E.\u00357514714EBF5072C179DF17C7016AF16F2D16520));
              this.iv = (object) numArray1;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
              continue;
            case 2:
              byte[] numArray2 = new byte[16];
              // ISSUE: field reference
              ElmaCryptoProvider.Container.JD30vbQP6OBO7gU8TbvG((object) numArray2, __fieldref (\u003CPrivateImplementationDetails\u003E.\u003694FA395BBB60E36DFBEF2137683E684F595E83C));
              this.pubKey = (object) numArray2;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 1 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }

      internal byte[] GetPub() => (byte[]) this.pubKey;

      internal byte[] GetIv() => (byte[]) this.iv;

      internal static ElmaCryptoProvider.Container Instance
      {
        get
        {
          int num = 1;
          object instance;
          while (true)
          {
            switch (num)
            {
              case 1:
                instance = ElmaCryptoProvider.Container.instance;
                if (instance == null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
                  continue;
                }
                goto label_2;
              default:
                goto label_5;
            }
          }
label_2:
          return (ElmaCryptoProvider.Container) instance;
label_5:
          return (ElmaCryptoProvider.Container) (ElmaCryptoProvider.Container.instance = (object) new ElmaCryptoProvider.Container());
        }
      }

      internal static void AhugMaQP46dC4c3bqvwe() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool CA7S4hQPt1d3cgNHoFBP() => ElmaCryptoProvider.Container.U8PEAkQPDIxYP6oOAUy5 == null;

      internal static ElmaCryptoProvider.Container BxVNEaQPwYUCEm55EyCv() => (ElmaCryptoProvider.Container) ElmaCryptoProvider.Container.U8PEAkQPDIxYP6oOAUy5;

      internal static void JD30vbQP6OBO7gU8TbvG([In] object obj0, [In] RuntimeFieldHandle obj1) => RuntimeHelpers.InitializeArray((Array) obj0, obj1);
    }
  }
}
