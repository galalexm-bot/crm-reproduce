// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.TranslateData.CodeItemCodeGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Memory;
using EleWise.ELMA.ScriptDesigner.CodeItems;
using EleWise.ELMA.ScriptDesigner.ToolBoxItems;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CSharp;
using SG9KiyIbtdgGDf12qr;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.ScriptDesigner.TranslateData
{
  public static class CodeItemCodeGenerator
  {
    internal static CodeItemCodeGenerator o5RB0i8sbowdSWYPlsZ;

    static CodeItemCodeGenerator()
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              CodeItemCodeGenerator.AlfabetList = new List<string>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
              continue;
            case 2:
              CodeItemCodeGenerator.F0dj9OZFj7Tpal4poof();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_3;
            case 4:
              goto label_4;
            default:
              goto label_5;
          }
        }
label_4:
        CodeItemCodeGenerator.yZpSb4ZBEPaZ4LDtqZj();
        num1 = 3;
        continue;
label_5:
        CodeItemCodeGenerator.ExceptionsWordList = new List<string>();
        num1 = 4;
      }
label_3:;
    }

    public static List<string> AlfabetList { get; set; }

    public static List<string> ExceptionsWordList { get; set; }

    /// <summary>Сгенерировать исходный код из CodeNamespace</summary>
    /// <param name="code">CodeNamespace</param>
    /// <returns>Исходный код</returns>
    public static byte[] GenerateCSCode(CodeNamespace code)
    {
      int num1 = 2;
      MemoryStream memoryStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            memoryStream = (MemoryStream) CodeItemCodeGenerator.CQUk1IZWfB082RT57DH();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 1 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      byte[] csCode;
      return csCode;
label_3:
      try
      {
        StreamWriter output = new StreamWriter((Stream) memoryStream, (Encoding) CodeItemCodeGenerator.SV01mDZoKMRW3dZsRkb());
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              ICodeGenerator generator = new CSharpCodeProvider().CreateGenerator((TextWriter) output);
              CodeNamespace e = code;
              StreamWriter w = output;
              CodeGeneratorOptions o = new CodeGeneratorOptions();
              CodeItemCodeGenerator.oGP5WBZhoZeR72Z6grd((object) o, CodeItemCodeGenerator.Jm855pZbDswibI4U2gQ(-710283084 ^ -537863435 ^ 173631757));
              generator.GenerateCodeFromNamespace(e, (TextWriter) w, o);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
                num3 = 0;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    goto label_2;
                  default:
                    csCode = (byte[]) CodeItemCodeGenerator.a93vbJZGccsXtqPoTOI((object) memoryStream);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 0;
                    continue;
                }
              }
            }
            finally
            {
              int num4;
              if (output == null)
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 1 : 1;
              else
                goto label_14;
label_13:
              switch (num4)
              {
                case 2:
                  break;
                default:
              }
label_14:
              CodeItemCodeGenerator.LRqoE5ZEF1FBYOkOHWZ((object) output);
              num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
              {
                num4 = 0;
                goto label_13;
              }
              else
                goto label_13;
            }
        }
      }
      finally
      {
        if (memoryStream != null)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_22;
              default:
                memoryStream.Dispose();
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_22:;
      }
    }

    /// <summary>Сгенерировать исходный код из CodeNamespace в строку</summary>
    /// <param name="code">CodeNamespace</param>
    /// <returns>Исходный код</returns>
    public static string GenerateCSCodeString(CodeNamespace code)
    {
      int num1 = 1;
      MemoryStream memoryStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            memoryStream = (MemoryStream) CodeItemCodeGenerator.CQUk1IZWfB082RT57DH();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            goto label_4;
        }
      }
label_3:
      string csCodeString;
      return csCodeString;
label_4:
      try
      {
        StreamWriter streamWriter1 = new StreamWriter((Stream) memoryStream, (Encoding) CodeItemCodeGenerator.SV01mDZoKMRW3dZsRkb());
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              object obj = CodeItemCodeGenerator.zq8bhpZfN6Q6dt4nRF0((object) new CSharpCodeProvider(), (object) streamWriter1);
              CodeNamespace codeNamespace = code;
              StreamWriter streamWriter2 = streamWriter1;
              CodeGeneratorOptions generatorOptions = new CodeGeneratorOptions();
              CodeItemCodeGenerator.oGP5WBZhoZeR72Z6grd((object) generatorOptions, CodeItemCodeGenerator.Jm855pZbDswibI4U2gQ(44884861 ^ 44867633));
              CodeItemCodeGenerator.BK8PlvZQnVpF4pM6rZ5(obj, (object) codeNamespace, (object) streamWriter2, (object) generatorOptions);
              int num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
                num3 = 0;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    csCodeString = memoryStream.AsString(Encoding.UTF8);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_3;
                }
              }
            }
            finally
            {
              int num4;
              if (streamWriter1 == null)
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 2 : 2;
              else
                goto label_16;
label_15:
              switch (num4)
              {
                case 1:
                case 2:
              }
label_16:
              CodeItemCodeGenerator.LRqoE5ZEF1FBYOkOHWZ((object) streamWriter1);
              num4 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
              {
                num4 = 0;
                goto label_15;
              }
              else
                goto label_15;
            }
        }
      }
      finally
      {
        int num5;
        if (memoryStream == null)
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 1 : 1;
        else
          goto label_22;
label_21:
        switch (num5)
        {
          case 1:
          case 2:
        }
label_22:
        CodeItemCodeGenerator.LRqoE5ZEF1FBYOkOHWZ((object) memoryStream);
        num5 = 2;
        goto label_21;
      }
    }

    /// <summary>Сгенерировать исходный код из CodeStatement в строку</summary>
    /// <param name="code">CodeStatement</param>
    /// <returns>Исходный код</returns>
    public static string GenerateCSCodeStringFromStatement(CodeStatement code)
    {
      int num1 = 1;
      MemoryStream memoryStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            memoryStream = (MemoryStream) CodeItemCodeGenerator.CQUk1IZWfB082RT57DH();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      string stringFromStatement;
      return stringFromStatement;
label_3:
      try
      {
        StreamWriter streamWriter1 = new StreamWriter((Stream) memoryStream, (Encoding) CodeItemCodeGenerator.SV01mDZoKMRW3dZsRkb());
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              object obj = CodeItemCodeGenerator.zq8bhpZfN6Q6dt4nRF0((object) new CSharpCodeProvider(), (object) streamWriter1);
              CodeStatement codeStatement = code;
              StreamWriter streamWriter2 = streamWriter1;
              CodeGeneratorOptions generatorOptions = new CodeGeneratorOptions();
              CodeItemCodeGenerator.oGP5WBZhoZeR72Z6grd((object) generatorOptions, CodeItemCodeGenerator.Jm855pZbDswibI4U2gQ(372753449 ^ 372737893));
              CodeItemCodeGenerator.W2jCmrZCAdsGhqU34cQ(obj, (object) codeStatement, (object) streamWriter2, (object) generatorOptions);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
                num3 = 0;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    goto label_2;
                  default:
                    stringFromStatement = memoryStream.AsString(Encoding.UTF8);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 1;
                    continue;
                }
              }
            }
            finally
            {
              if (streamWriter1 != null)
              {
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
                  num4 = 0;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_17;
                    default:
                      CodeItemCodeGenerator.LRqoE5ZEF1FBYOkOHWZ((object) streamWriter1);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 1;
                      continue;
                  }
                }
              }
label_17:;
            }
        }
      }
      finally
      {
        if (memoryStream != null)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_23;
              default:
                memoryStream.Dispose();
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_23:;
      }
    }

    /// <summary>Сгенерировать исходный код из CodeStatement</summary>
    /// <param name="code">CodeNamespace</param>
    /// <returns>Исходный код</returns>
    public static byte[] GenerateCSCodeFromStatement(CodeStatement code)
    {
      int num1 = 2;
      MemoryStream memoryStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            memoryStream = MemoryHelper.GetMemoryStream();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 1;
            continue;
          default:
            goto label_23;
        }
      }
label_3:
      byte[] codeFromStatement;
      try
      {
        StreamWriter streamWriter1 = new StreamWriter((Stream) memoryStream, Encoding.UTF8);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              object obj = CodeItemCodeGenerator.zq8bhpZfN6Q6dt4nRF0((object) new CSharpCodeProvider(), (object) streamWriter1);
              CodeStatement codeStatement = code;
              StreamWriter streamWriter2 = streamWriter1;
              CodeGeneratorOptions generatorOptions = new CodeGeneratorOptions();
              CodeItemCodeGenerator.oGP5WBZhoZeR72Z6grd((object) generatorOptions, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051276242 - 990076387 ^ 61183651));
              CodeItemCodeGenerator.W2jCmrZCAdsGhqU34cQ(obj, (object) codeStatement, (object) streamWriter2, (object) generatorOptions);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
                num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    codeFromStatement = (byte[]) CodeItemCodeGenerator.a93vbJZGccsXtqPoTOI((object) memoryStream);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_23;
                }
              }
            }
            finally
            {
              if (streamWriter1 != null)
              {
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
                  num4 = 0;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_16;
                    default:
                      CodeItemCodeGenerator.LRqoE5ZEF1FBYOkOHWZ((object) streamWriter1);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 1;
                      continue;
                  }
                }
              }
label_16:;
            }
        }
      }
      finally
      {
        if (memoryStream != null)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_22;
              default:
                CodeItemCodeGenerator.LRqoE5ZEF1FBYOkOHWZ((object) memoryStream);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 1;
                continue;
            }
          }
        }
label_22:;
      }
label_23:
      return codeFromStatement;
    }

    /// <summary>Сгенерировать исходный код из CodeExpression в строку</summary>
    /// <param name="expression">CodeExpression</param>
    /// <returns>Исходный код</returns>
    public static string GenerateCSCodeString(CodeExpression expression)
    {
      int num1 = 1;
      MemoryStream memoryStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            memoryStream = (MemoryStream) CodeItemCodeGenerator.CQUk1IZWfB082RT57DH();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      string csCodeString;
      return csCodeString;
label_3:
      try
      {
        StreamWriter streamWriter1 = new StreamWriter((Stream) memoryStream.AsNoClose(), (Encoding) CodeItemCodeGenerator.SV01mDZoKMRW3dZsRkb());
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
label_18:
              CodeItemCodeGenerator.m3dh8YZ8qkJk7Xk9Vs2((object) memoryStream, 0L, SeekOrigin.Begin);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 3 : 2;
              continue;
            case 2:
              goto label_2;
            case 3:
              csCodeString = memoryStream.AsString((Encoding) CodeItemCodeGenerator.SV01mDZoKMRW3dZsRkb());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 1 : 2;
              continue;
            default:
              try
              {
                object obj = CodeItemCodeGenerator.zq8bhpZfN6Q6dt4nRF0((object) new CSharpCodeProvider(), (object) streamWriter1);
                CodeExpression codeExpression = expression;
                StreamWriter streamWriter2 = streamWriter1;
                CodeGeneratorOptions generatorOptions = new CodeGeneratorOptions();
                CodeItemCodeGenerator.oGP5WBZhoZeR72Z6grd((object) generatorOptions, CodeItemCodeGenerator.Jm855pZbDswibI4U2gQ(-2092274397 << 4 ^ 883331452));
                CodeItemCodeGenerator.e5Zh2xZvXU8ED1YcT3W(obj, (object) codeExpression, (object) streamWriter2, (object) generatorOptions);
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    goto label_18;
                }
              }
              finally
              {
                int num4;
                if (streamWriter1 == null)
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
                else
                  goto label_15;
label_14:
                switch (num4)
                {
                  case 2:
                    break;
                  default:
                }
label_15:
                CodeItemCodeGenerator.LRqoE5ZEF1FBYOkOHWZ((object) streamWriter1);
                num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0)
                {
                  num4 = 0;
                  goto label_14;
                }
                else
                  goto label_14;
              }
          }
        }
      }
      finally
      {
        int num5;
        if (memoryStream == null)
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
        else
          goto label_22;
label_21:
        switch (num5)
        {
          case 2:
            break;
          default:
        }
label_22:
        memoryStream.Dispose();
        num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
        {
          num5 = 1;
          goto label_21;
        }
        else
          goto label_21;
      }
    }

    /// <summary>Сгенерировать пространство имен</summary>
    /// <param name="processName">Имя процесса(класса)</param>
    /// <param name="scriptName">Имя сценария</param>
    /// <param name="rootItem">Корневой элемент кода</param>
    /// <returns>Пространство имен</returns>
    public static CodeNamespace GenerateCode(
      string processName,
      string scriptName,
      string processDisplayName,
      RootCodeItem rootItem)
    {
      int num1 = 8;
      CodeNamespace code;
      while (true)
      {
        int num2 = num1;
        CodeMemberMethod codeMemberMethod;
        CodeTypeDeclaration codeTypeDeclaration;
        int index;
        CodeStatement[] codeStatementArray;
        CodeStatement codeStatement;
        List<VariableCodeItemToolBoxItem>.Enumerator enumerator;
        CodeCommentStatement commentStatement;
        while (true)
        {
          switch (num2)
          {
            case 1:
              codeMemberMethod.Name = scriptName.ToTranslit();
              num2 = 6;
              continue;
            case 2:
              CodeItemCodeGenerator.Dgm5IdZTU6jHKpHc7TF(CodeItemCodeGenerator.XwRdRwZXRmVlUBvbM3P((object) codeMemberMethod), (object) commentStatement);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 17 : 11;
              continue;
            case 3:
            case 16:
              if (index < codeStatementArray.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 5 : 10;
                continue;
              }
              goto label_35;
            case 4:
            case 17:
              goto label_32;
            case 5:
              CodeItemCodeGenerator.UU5hvTZinnTEWZ0kcsi(CodeItemCodeGenerator.LoSE0sZS6YKBrKpCPjp((object) codeMemberMethod), (object) new CodeCommentStatement((string) CodeItemCodeGenerator.Jm855pZbDswibI4U2gQ(964881585 - -1459193222 ^ -1870908965), true));
              num2 = 32;
              continue;
            case 6:
              CodeItemCodeGenerator.OAB3eTZqBsHL1eaLcoh((object) codeMemberMethod, (object) new CodeTypeReference(typeof (void)));
              num2 = 12;
              continue;
            case 7:
              codeTypeDeclaration = new CodeTypeDeclaration((string) CodeItemCodeGenerator.k81MifZZ2SHvqMjGwc4((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1012104053), (object) processName));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 2 : 13;
              continue;
            case 8:
              code = new CodeNamespace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978494048));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 7 : 4;
              continue;
            case 9:
              CodeItemCodeGenerator.pLOsvUZRm83vD9wWda1((object) codeMemberMethod, MemberAttributes.Public);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 1;
              continue;
            case 10:
            case 18:
              codeStatement = codeStatementArray[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 1 : 31;
              continue;
            case 11:
              goto label_29;
            case 12:
              ((CodeParameterDeclarationExpressionCollection) CodeItemCodeGenerator.thHrBYZKRkPiUZcAeAb((object) codeMemberMethod)).Add(new CodeParameterDeclarationExpression((string) CodeItemCodeGenerator.Jm855pZbDswibI4U2gQ(1669212571 ^ 1669229983), (string) CodeItemCodeGenerator.Jm855pZbDswibI4U2gQ(1917998801 >> 2 ^ 479515042)));
              num2 = 24;
              continue;
            case 13:
              CodeItemCodeGenerator.ze9aZsZuyX1hMnoZy97((object) codeTypeDeclaration, true);
              num2 = 14;
              continue;
            case 14:
              CodeItemCodeGenerator.L7FmdnZIkgMewCIDQbB((object) codeTypeDeclaration, TypeAttributes.Public);
              num2 = 26;
              continue;
            case 15:
              goto label_35;
            case 19:
              try
              {
label_20:
                if (enumerator.MoveNext())
                  goto label_17;
                else
                  goto label_21;
label_16:
                VariableCodeItemToolBoxItem current;
                CodeExpression initExpression;
                CodeVariableDeclarationStatement declarationStatement;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_20;
                    case 2:
                      goto label_5;
                    case 3:
                      initExpression = (CodeExpression) CodeItemCodeGenerator.VowLIVZkfxhOJw6gnE7((object) current);
                      num3 = 5;
                      continue;
                    case 4:
                      goto label_17;
                    case 5:
                      declarationStatement = new CodeVariableDeclarationStatement((string) CodeItemCodeGenerator.Jm855pZbDswibI4U2gQ(874012245 ^ 873994753), (string) CodeItemCodeGenerator.ORnOYVZnNrJJDTL0IYc((object) current), initExpression);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
                      continue;
                    default:
                      CodeItemCodeGenerator.Dgm5IdZTU6jHKpHc7TF((object) codeMemberMethod.Statements, (object) declarationStatement);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 1;
                      continue;
                  }
                }
label_17:
                current = enumerator.Current;
                num3 = 3;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
                {
                  num3 = 3;
                  goto label_16;
                }
                else
                  goto label_16;
label_21:
                num3 = 2;
                goto label_16;
              }
              finally
              {
                enumerator.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 20:
              CodeItemCodeGenerator.UU5hvTZinnTEWZ0kcsi(CodeItemCodeGenerator.LoSE0sZS6YKBrKpCPjp((object) codeTypeDeclaration), (object) new CodeCommentStatement((string) CodeItemCodeGenerator.Jm855pZbDswibI4U2gQ(-675505729 ^ -675489197), true));
              num2 = 25;
              continue;
            case 21:
              index = 0;
              num2 = 3;
              continue;
            case 22:
              if (!rootItem.LocalVariables.Any<VariableCodeItemToolBoxItem>())
              {
                num2 = 4;
                continue;
              }
              goto case 2;
            case 23:
              CodeItemCodeGenerator.Bm1s07ZP5UICFQwRDgc((object) code.Types, (object) codeTypeDeclaration);
              num2 = 11;
              continue;
            case 24:
              goto label_31;
            case 25:
              codeMemberMethod = new CodeMemberMethod();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 5 : 9;
              continue;
            case 26:
              CodeItemCodeGenerator.dfVrIlZVnFMyXFJT6C5((object) codeTypeDeclaration, true);
              num2 = 28;
              continue;
            case 27:
              CodeItemCodeGenerator.UU5hvTZinnTEWZ0kcsi(CodeItemCodeGenerator.LoSE0sZS6YKBrKpCPjp((object) codeMemberMethod), (object) new CodeCommentStatement((string) CodeItemCodeGenerator.k81MifZZ2SHvqMjGwc4((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123615756), (object) scriptName), true));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 4 : 5;
              continue;
            case 28:
              CodeItemCodeGenerator.UU5hvTZinnTEWZ0kcsi(CodeItemCodeGenerator.LoSE0sZS6YKBrKpCPjp((object) codeTypeDeclaration), (object) new CodeCommentStatement((string) CodeItemCodeGenerator.Jm855pZbDswibI4U2gQ(1021410165 ^ 1021393121), true));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
              continue;
            case 29:
label_5:
              CodeItemCodeGenerator.Dgm5IdZTU6jHKpHc7TF(CodeItemCodeGenerator.XwRdRwZXRmVlUBvbM3P((object) codeMemberMethod), (object) new CodeSnippetStatement());
              num2 = 30;
              continue;
            case 30:
              goto label_44;
            case 31:
              codeMemberMethod.Statements.Add(codeStatement);
              num2 = 33;
              continue;
            case 32:
              commentStatement = new CodeCommentStatement(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1597012150 ^ 1596996766)));
              num2 = 22;
              continue;
            case 33:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 10 : 16;
              continue;
            default:
              CodeItemCodeGenerator.UU5hvTZinnTEWZ0kcsi((object) codeTypeDeclaration.Comments, (object) new CodeCommentStatement(EleWise.ELMA.SR.T((string) CodeItemCodeGenerator.Jm855pZbDswibI4U2gQ(-345420348 ^ -345436562), (object) processDisplayName), true));
              num2 = 20;
              continue;
          }
        }
label_31:
        CodeItemCodeGenerator.UU5hvTZinnTEWZ0kcsi((object) codeMemberMethod.Comments, (object) new CodeCommentStatement((string) CodeItemCodeGenerator.Jm855pZbDswibI4U2gQ(322893104 - -1992822529 ^ -1979234395), true));
        num1 = 27;
        continue;
label_32:
        enumerator = rootItem.LocalVariables.GetEnumerator();
        num1 = 19;
        continue;
label_35:
        CodeItemCodeGenerator.IV5ObCZetANEa9QBQOW(CodeItemCodeGenerator.KSrmouZ2jk8HaS3LYIF((object) codeTypeDeclaration), (object) codeMemberMethod);
        num1 = 23;
        continue;
label_44:
        codeStatementArray = (CodeStatement[]) CodeItemCodeGenerator.q0FWgCZO4F6eHGCC1Ho((object) rootItem);
        num1 = 21;
      }
label_29:
      return code;
    }

    public static CodeExpression GetInitExpressionByType(NewCodeItemToolBoxItem variable)
    {
      int num1 = 1;
      Type type;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              type = CodeItemCodeGenerator.USUMUvZ1cfILEEmdrR8((object) variable);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
              continue;
            case 2:
            case 5:
              goto label_12;
            case 3:
              goto label_7;
            case 4:
              goto label_23;
            case 6:
              goto label_15;
            case 7:
              // ISSUE: type reference
              if (CodeItemCodeGenerator.thuHmdZaCnvBdmAVWNo(type, CodeItemCodeGenerator.QU8swGZpqvZti8c4VKU(__typeref (string))))
              {
                num2 = 6;
                continue;
              }
              goto case 12;
            case 8:
              // ISSUE: type reference
              if (CodeItemCodeGenerator.PV8ZduZDk4n04ft5cPQ(type, CodeItemCodeGenerator.QU8swGZpqvZti8c4VKU(__typeref (bool))))
              {
                num2 = 5;
                continue;
              }
              goto label_13;
            case 9:
              if (CodeItemCodeGenerator.DtxPw5ZwdxcfHQhbUe8(type))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 2 : 1;
                continue;
              }
              goto case 8;
            case 10:
              if (!CodeItemCodeGenerator.qCBkUuZ3ZwOp60UopZL(type))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 12 : 5;
                continue;
              }
              goto case 7;
            case 11:
              goto label_5;
            case 12:
              // ISSUE: type reference
              if (!CodeItemCodeGenerator.PV8ZduZDk4n04ft5cPQ(type, CodeItemCodeGenerator.QU8swGZpqvZti8c4VKU(__typeref (string))))
              {
                if (!CodeItemCodeGenerator.bDH4rnZtAi8J7yIkJFt(type))
                {
                  num2 = 9;
                  continue;
                }
                goto label_12;
              }
              else
                goto label_17;
            default:
              if (!CodeItemCodeGenerator.Bp95ZIZNcPtwgptFZKA(type))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 3 : 10;
                continue;
              }
              goto label_23;
          }
        }
label_13:
        // ISSUE: type reference
        if (CodeItemCodeGenerator.PV8ZduZDk4n04ft5cPQ(type, CodeItemCodeGenerator.QU8swGZpqvZti8c4VKU(__typeref (DateTime))))
        {
          num1 = 11;
          continue;
        }
        goto label_6;
label_17:
        num1 = 3;
      }
label_5:
      return (CodeExpression) new CodeSnippetExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521250562));
label_6:
      return (CodeExpression) new CodeSnippetExpression(string.Format((string) CodeItemCodeGenerator.Jm855pZbDswibI4U2gQ(-649342099 - -1150814748 ^ 501455191), (object) type.Namespace, CodeItemCodeGenerator.iDeM3XZ66bAQMbOGn4p((object) type)));
label_7:
      return (CodeExpression) new CodeSnippetExpression((string) CodeItemCodeGenerator.Jm855pZbDswibI4U2gQ(-477139494 ^ -477157000));
label_12:
      return (CodeExpression) new CodePrimitiveExpression(CodeItemCodeGenerator.CRNDvCZ47bP79sA5OjT(type));
label_15:
      return (CodeExpression) new CodeObjectCreateExpression(variable.VariableType, Array.Empty<CodeExpression>());
label_23:
      return (CodeExpression) new CodeSnippetExpression((string) CodeItemCodeGenerator.k81MifZZ2SHvqMjGwc4(CodeItemCodeGenerator.Jm855pZbDswibI4U2gQ(-342626196 - 1290888215 ^ -1633499125), (object) CodeItemCodeGenerator.USUMUvZ1cfILEEmdrR8((object) variable)));
    }

    public static object GetDefaultValue(Type t)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (!t.IsValueType)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return Activator.CreateInstance(t);
label_3:
      return (object) null;
    }

    public static bool IsEntity(Type type)
    {
      int num1 = 2;
      Type type1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            type1 = (Type) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 0;
            continue;
          default:
            goto label_9;
        }
      }
label_3:
      try
      {
        type1 = type.GetInterface((string) CodeItemCodeGenerator.Jm855pZbDswibI4U2gQ(-2138958856 ^ -2138941692));
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      catch
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
          num3 = 0;
        switch (num3)
        {
        }
      }
label_9:
      return type1 != (Type) null;
    }

    public static bool IsCollection(Type type)
    {
      int num1 = 1;
      Type type1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: type reference
            if (CodeItemCodeGenerator.PV8ZduZDk4n04ft5cPQ(type, CodeItemCodeGenerator.QU8swGZpqvZti8c4VKU(__typeref (string))))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
              continue;
            }
            type1 = (Type) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 2;
            continue;
          case 2:
            goto label_2;
          case 3:
            goto label_8;
          default:
            goto label_11;
        }
      }
label_2:
      try
      {
        type1 = type.GetInterface((string) CodeItemCodeGenerator.Jm855pZbDswibI4U2gQ(381945751 ^ 1158627804 ^ 1405813573));
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      catch
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
          num3 = 0;
        switch (num3)
        {
        }
      }
label_8:
      return type1 != (Type) null;
label_11:
      return false;
    }

    public static string GenerateCodeString(
      string processName,
      string scriptName,
      string projectDisplayName,
      RootCodeItem rootItem)
    {
      int num = 3;
      string str1;
      List<string> list;
      string str2;
      while (true)
      {
        switch (num)
        {
          case 1:
            str1 = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107976774), (IEnumerable<string>) list);
            num = 5;
            continue;
          case 2:
            list = ((IEnumerable<string>) str1.Split((char[]) CodeItemCodeGenerator.ncHTskZHXwPfYd0M2yM(CodeItemCodeGenerator.Jm855pZbDswibI4U2gQ(-16752921 ^ -16760509)))).ToList<string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
            continue;
          case 3:
            str1 = CodeItemCodeGenerator.GenerateCSCodeString(CodeItemCodeGenerator.GenerateCode(processName, scriptName, projectDisplayName, rootItem));
            num = 2;
            continue;
          case 4:
            goto label_8;
          case 5:
            str2 = (string) CodeItemCodeGenerator.k81MifZZ2SHvqMjGwc4((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909162057), CodeItemCodeGenerator.xi5U8KZ7Pb3pd0NAOa2((object) processName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121142957), (object) ""));
            num = 4;
            continue;
          case 6:
            list.RemoveAt(2);
            num = 7;
            continue;
          case 7:
            CodeItemCodeGenerator.rPvUMGZAfdIjlPfvQDj((object) list, 7);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 1;
            continue;
          default:
            CodeItemCodeGenerator.rPvUMGZAfdIjlPfvQDj((object) list, 2);
            num = 6;
            continue;
        }
      }
label_8:
      return (string) CodeItemCodeGenerator.YUxfl7ZxPI5dkZBmI7Z(CodeItemCodeGenerator.Jm855pZbDswibI4U2gQ(-97972138 ^ -97953556), (object) str2, (object) str1);
    }

    public static string GenerateMethodCodeString(
      string processName,
      string scriptName,
      RootCodeItem rootItem)
    {
      int num1 = 3;
      string methodCodeString;
      while (true)
      {
        int num2 = num1;
        int index;
        CodeStatement[] codeStatementArray;
        List<VariableCodeItemToolBoxItem>.Enumerator enumerator;
        CodeStatement codeStatement;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 9:
              if (index >= codeStatementArray.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
                continue;
              }
              goto case 11;
            case 2:
              enumerator = rootItem.LocalVariables.GetEnumerator();
              num2 = 5;
              continue;
            case 3:
              methodCodeString = string.Empty;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 1 : 2;
              continue;
            case 4:
              methodCodeString = (string) CodeItemCodeGenerator.KWH7CCZmt9rjDadj2kf((object) methodCodeString, CodeItemCodeGenerator.Jm855pZbDswibI4U2gQ(1051276242 - 990076387 ^ 61196875));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 10 : 4;
              continue;
            case 5:
              goto label_13;
            case 6:
              methodCodeString = (string) CodeItemCodeGenerator.KWH7CCZmt9rjDadj2kf((object) methodCodeString, CodeItemCodeGenerator.SfMVJIZ0xlHYIr8jU5R((object) codeStatement));
              num2 = 4;
              continue;
            case 7:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 1;
              continue;
            case 8:
              goto label_10;
            case 10:
              ++index;
              num2 = 9;
              continue;
            case 11:
              codeStatement = codeStatementArray[index];
              num2 = 6;
              continue;
            default:
              goto label_9;
          }
        }
label_10:
        codeStatementArray = (CodeStatement[]) CodeItemCodeGenerator.q0FWgCZO4F6eHGCC1Ho((object) rootItem);
        num1 = 7;
        continue;
label_13:
        try
        {
label_17:
          if (enumerator.MoveNext())
            goto label_21;
          else
            goto label_18;
label_14:
          VariableCodeItemToolBoxItem current;
          CodeExpression initExpression;
          CodeVariableDeclarationStatement declarationStatement;
          int num3;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_10;
              case 2:
                declarationStatement = new CodeVariableDeclarationStatement(CodeItemCodeGenerator.USUMUvZ1cfILEEmdrR8((object) current), (string) CodeItemCodeGenerator.ORnOYVZnNrJJDTL0IYc((object) current), initExpression);
                num3 = 3;
                continue;
              case 3:
                methodCodeString = (string) CodeItemCodeGenerator.KWH7CCZmt9rjDadj2kf((object) methodCodeString, CodeItemCodeGenerator.SfMVJIZ0xlHYIr8jU5R((object) declarationStatement));
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 6 : 1;
                continue;
              case 4:
                goto label_17;
              case 5:
                goto label_21;
              case 6:
                methodCodeString = (string) CodeItemCodeGenerator.KWH7CCZmt9rjDadj2kf((object) methodCodeString, CodeItemCodeGenerator.Jm855pZbDswibI4U2gQ(-812025778 ^ -812029974));
                num3 = 4;
                continue;
              default:
                initExpression = (CodeExpression) CodeItemCodeGenerator.VowLIVZkfxhOJw6gnE7((object) current);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 2;
                continue;
            }
          }
label_18:
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 0;
          goto label_14;
label_21:
          current = enumerator.Current;
          num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
          {
            num3 = 0;
            goto label_14;
          }
          else
            goto label_14;
        }
        finally
        {
          enumerator.Dispose();
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
            num4 = 0;
          switch (num4)
          {
            default:
          }
        }
      }
label_9:
      return methodCodeString;
    }

    public static CodeStatement[] TranslateToCode(RootCodeItem rootCodeItem)
    {
      int num1 = 2;
      List<CodeStatement> codeStatementList1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            codeStatementList1 = new List<CodeStatement>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return codeStatementList1.ToArray();
label_3:
      try
      {
        List<CodeItem>.Enumerator enumerator = rootCodeItem.Items.GetEnumerator();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
          num2 = 0;
        switch (num2)
        {
          case 1:
            goto label_2;
          default:
            try
            {
label_10:
              if (enumerator.MoveNext())
                goto label_14;
              else
                goto label_11;
label_8:
              CodeStatement[] codeStatementList2;
              CodeStatement codeStatement;
              int num3;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    codeStatementList1.AddRange((IEnumerable<CodeStatement>) codeStatementList2);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 5 : 6;
                    continue;
                  case 2:
                    goto label_2;
                  case 3:
                    codeStatementList1.Add(codeStatement);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
                    continue;
                  case 4:
                    if (((IEnumerable<CodeStatement>) codeStatementList2).Any<CodeStatement>())
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 0;
                      continue;
                    }
                    goto label_10;
                  case 5:
                    if (codeStatement != null)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 2 : 3;
                      continue;
                    }
                    break;
                  case 6:
                    goto label_10;
                  case 7:
                    goto label_14;
                }
                if (codeStatementList2 != null)
                  num3 = 4;
                else
                  goto label_10;
              }
label_11:
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 2 : 2;
              goto label_8;
label_14:
              CodeItem current = enumerator.Current;
              codeStatement = (CodeStatement) CodeItemCodeGenerator.Cqy5nVZy4Mub8H7gDRo((object) current);
              codeStatementList2 = current.ToCodeStatementList();
              num3 = 5;
              goto label_8;
            }
            finally
            {
              enumerator.Dispose();
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
                num4 = 0;
              switch (num4)
              {
                default:
              }
            }
        }
      }
      catch (Exception ex)
      {
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
          num5 = 0;
        switch (num5)
        {
          default:
            throw new Exception(EleWise.ELMA.SR.T((string) CodeItemCodeGenerator.Jm855pZbDswibI4U2gQ(1251470110 >> 2 ^ 312848907), CodeItemCodeGenerator.GlvHgPZMnFO7hmNbu5V((object) ex), CodeItemCodeGenerator.nlqmBmZJYWXDsXogWRq((object) ex)));
        }
      }
    }

    public static void InitializeAlfabet()
    {
      int num1 = 10;
      while (true)
      {
        int num2 = num1;
        int num3;
        string str;
        char ch;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_12;
            case 1:
            case 8:
              ++num3;
              num2 = 5;
              continue;
            case 2:
              if (CodeItemCodeGenerator.ExceptionsWordList.Contains(str))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 0;
                continue;
              }
              goto case 6;
            case 3:
            case 4:
              ch = (char) num3;
              num2 = 7;
              continue;
            case 5:
            case 9:
              goto label_13;
            case 6:
              CodeItemCodeGenerator.AlfabetList.Add(str);
              num2 = 8;
              continue;
            case 7:
              str = (string) CodeItemCodeGenerator.dj11UoZd3t1oDCKJpbT(CodeItemCodeGenerator.LHR3IQZ9IsEOolGoGqj(CodeItemCodeGenerator.KWH7CCZmt9rjDadj2kf((object) ch.ToString(), CodeItemCodeGenerator.Jm855pZbDswibI4U2gQ(1994213607 >> 4 ^ 124624300))));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 2 : 1;
              continue;
            case 10:
              goto label_8;
            default:
              goto label_9;
          }
        }
label_8:
        num3 = 65;
        num1 = 9;
        continue;
label_13:
        if (num3 <= 90)
          num1 = 3;
        else
          goto label_10;
      }
label_12:
      return;
label_9:
      return;
label_10:;
    }

    public static string GetRandomName()
    {
      int num = 2;
      string alfabet;
      while (true)
      {
        switch (num)
        {
          case 2:
            if (CodeItemCodeGenerator.rsvGYlZlNnZXnbVFGtm((object) CodeItemCodeGenerator.AlfabetList) != 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 1;
              continue;
            }
            goto case 7;
          case 3:
            if (CodeItemCodeGenerator.ExceptionsWordList.Contains(alfabet))
            {
              num = 6;
              continue;
            }
            goto case 8;
          case 4:
            alfabet = CodeItemCodeGenerator.AlfabetList[0];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 3 : 0;
            continue;
          case 5:
          case 6:
            goto label_6;
          case 7:
            CodeItemCodeGenerator.yZpSb4ZBEPaZ4LDtqZj();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
            continue;
          case 8:
            CodeItemCodeGenerator.rPvUMGZAfdIjlPfvQDj((object) CodeItemCodeGenerator.AlfabetList, 0);
            num = 5;
            continue;
          default:
            CodeItemCodeGenerator.AlfabetList.RemoveAll((Predicate<string>) (a => CodeItemCodeGenerator.ExceptionsWordList.Contains(a)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 4;
            continue;
        }
      }
label_6:
      return alfabet;
    }

    public static void AddString(string word)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (CodeItemCodeGenerator.AlfabetList.Contains(word))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 4 : 2;
              continue;
            }
            break;
          case 3:
            if (CodeItemCodeGenerator.AlfabetList != null)
            {
              num = 2;
              continue;
            }
            goto label_2;
          case 4:
            goto label_9;
        }
        CodeItemCodeGenerator.AlfabetList.Add(word);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 1;
      }
label_3:
      return;
label_9:
      return;
label_2:;
    }

    internal static void F0dj9OZFj7Tpal4poof() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void yZpSb4ZBEPaZ4LDtqZj() => CodeItemCodeGenerator.InitializeAlfabet();

    internal static bool nJXTs38c5r1LHRXAYrE() => CodeItemCodeGenerator.o5RB0i8sbowdSWYPlsZ == null;

    internal static CodeItemCodeGenerator tbOshl8zeHft1bm21cH() => CodeItemCodeGenerator.o5RB0i8sbowdSWYPlsZ;

    internal static object CQUk1IZWfB082RT57DH() => (object) MemoryHelper.GetMemoryStream();

    internal static object SV01mDZoKMRW3dZsRkb() => (object) Encoding.UTF8;

    internal static object Jm855pZbDswibI4U2gQ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void oGP5WBZhoZeR72Z6grd([In] object obj0, [In] object obj1) => ((CodeGeneratorOptions) obj0).BracingStyle = (string) obj1;

    internal static object a93vbJZGccsXtqPoTOI([In] object obj0) => (object) ((MemoryStream) obj0).ToArray();

    internal static void LRqoE5ZEF1FBYOkOHWZ([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object zq8bhpZfN6Q6dt4nRF0([In] object obj0, [In] object obj1) => (object) ((CodeDomProvider) obj0).CreateGenerator((TextWriter) obj1);

    internal static void BK8PlvZQnVpF4pM6rZ5([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((ICodeGenerator) obj0).GenerateCodeFromNamespace((CodeNamespace) obj1, (TextWriter) obj2, (CodeGeneratorOptions) obj3);

    internal static void W2jCmrZCAdsGhqU34cQ([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((ICodeGenerator) obj0).GenerateCodeFromStatement((CodeStatement) obj1, (TextWriter) obj2, (CodeGeneratorOptions) obj3);

    internal static void e5Zh2xZvXU8ED1YcT3W([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((ICodeGenerator) obj0).GenerateCodeFromExpression((CodeExpression) obj1, (TextWriter) obj2, (CodeGeneratorOptions) obj3);

    internal static long m3dh8YZ8qkJk7Xk9Vs2([In] object obj0, [In] long obj1, [In] SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

    internal static object k81MifZZ2SHvqMjGwc4([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void ze9aZsZuyX1hMnoZy97([In] object obj0, [In] bool obj1) => ((CodeTypeDeclaration) obj0).IsClass = obj1;

    internal static void L7FmdnZIkgMewCIDQbB([In] object obj0, [In] TypeAttributes obj1) => ((CodeTypeDeclaration) obj0).TypeAttributes = obj1;

    internal static void dfVrIlZVnFMyXFJT6C5([In] object obj0, [In] bool obj1) => ((CodeTypeDeclaration) obj0).IsPartial = obj1;

    internal static object LoSE0sZS6YKBrKpCPjp([In] object obj0) => (object) ((CodeTypeMember) obj0).Comments;

    internal static int UU5hvTZinnTEWZ0kcsi([In] object obj0, [In] object obj1) => ((CodeCommentStatementCollection) obj0).Add((CodeCommentStatement) obj1);

    internal static void pLOsvUZRm83vD9wWda1([In] object obj0, [In] MemberAttributes obj1) => ((CodeTypeMember) obj0).Attributes = obj1;

    internal static void OAB3eTZqBsHL1eaLcoh([In] object obj0, [In] object obj1) => ((CodeMemberMethod) obj0).ReturnType = (CodeTypeReference) obj1;

    internal static object thHrBYZKRkPiUZcAeAb([In] object obj0) => (object) ((CodeMemberMethod) obj0).Parameters;

    internal static object XwRdRwZXRmVlUBvbM3P([In] object obj0) => (object) ((CodeMemberMethod) obj0).Statements;

    internal static int Dgm5IdZTU6jHKpHc7TF([In] object obj0, [In] object obj1) => ((CodeStatementCollection) obj0).Add((CodeStatement) obj1);

    internal static object VowLIVZkfxhOJw6gnE7([In] object obj0) => (object) CodeItemCodeGenerator.GetInitExpressionByType((NewCodeItemToolBoxItem) obj0);

    internal static object ORnOYVZnNrJJDTL0IYc([In] object obj0) => (object) ((NewCodeItemToolBoxItem) obj0).VariableName;

    internal static object q0FWgCZO4F6eHGCC1Ho([In] object obj0) => (object) CodeItemCodeGenerator.TranslateToCode((RootCodeItem) obj0);

    internal static object KSrmouZ2jk8HaS3LYIF([In] object obj0) => (object) ((CodeTypeDeclaration) obj0).Members;

    internal static int IV5ObCZetANEa9QBQOW([In] object obj0, [In] object obj1) => ((CodeTypeMemberCollection) obj0).Add((CodeTypeMember) obj1);

    internal static int Bm1s07ZP5UICFQwRDgc([In] object obj0, [In] object obj1) => ((CodeTypeDeclarationCollection) obj0).Add((CodeTypeDeclaration) obj1);

    internal static Type USUMUvZ1cfILEEmdrR8([In] object obj0) => ((NewCodeItemToolBoxItem) obj0).VariableType;

    internal static bool Bp95ZIZNcPtwgptFZKA(Type type) => CodeItemCodeGenerator.IsEntity(type);

    internal static bool qCBkUuZ3ZwOp60UopZL(Type type) => CodeItemCodeGenerator.IsCollection(type);

    internal static Type QU8swGZpqvZti8c4VKU([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool thuHmdZaCnvBdmAVWNo([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool PV8ZduZDk4n04ft5cPQ([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static bool bDH4rnZtAi8J7yIkJFt(Type type) => type.IsNullableType();

    internal static bool DtxPw5ZwdxcfHQhbUe8(Type type) => type.IsNumericType();

    internal static object CRNDvCZ47bP79sA5OjT(Type t) => CodeItemCodeGenerator.GetDefaultValue(t);

    internal static object iDeM3XZ66bAQMbOGn4p([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object ncHTskZHXwPfYd0M2yM([In] object obj0) => (object) ((string) obj0).ToCharArray();

    internal static void rPvUMGZAfdIjlPfvQDj([In] object obj0, [In] int obj1) => ((List<string>) obj0).RemoveAt(obj1);

    internal static object xi5U8KZ7Pb3pd0NAOa2([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static object YUxfl7ZxPI5dkZBmI7Z([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object SfMVJIZ0xlHYIr8jU5R([In] object obj0) => (object) CodeItemCodeGenerator.GenerateCSCodeStringFromStatement((CodeStatement) obj0);

    internal static object KWH7CCZmt9rjDadj2kf([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object Cqy5nVZy4Mub8H7gDRo([In] object obj0) => (object) ((CodeItem) obj0).ToCodeStatement();

    internal static object GlvHgPZMnFO7hmNbu5V([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static object nlqmBmZJYWXDsXogWRq([In] object obj0) => (object) ((Exception) obj0).StackTrace;

    internal static object LHR3IQZ9IsEOolGoGqj([In] object obj0) => (object) ((string) obj0).ToLower();

    internal static object dj11UoZd3t1oDCKJpbT([In] object obj0) => (object) ((string) obj0).Trim();

    internal static int rsvGYlZlNnZXnbVFGtm([In] object obj0) => ((List<string>) obj0).Count;
  }
}
