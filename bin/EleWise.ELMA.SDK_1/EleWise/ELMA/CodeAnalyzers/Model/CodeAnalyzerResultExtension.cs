// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CodeAnalyzers.Model.CodeAnalyzerResultExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.CodeAnalyzers.Model
{
  /// <summary>Расширение для результата анализа кода</summary>
  public static class CodeAnalyzerResultExtension
  {
    private static CodeAnalyzerResultExtension xCMAfPfRcerS2FrncrVx;

    /// <summary>Объединить результаты анализа</summary>
    /// <param name="first">Первый результат</param>
    /// <param name="second">Второй результат</param>
    /// <returns>Объединенный результат анализа</returns>
    public static CodeAnalyzerResult CombineResult(
      this ICodeAnalyzerResult first,
      ICodeAnalyzerResult second)
    {
      int num1 = 2;
      IEnumerator<KeyValuePair<IMetadata, ICollection<IPropertyMetadata>>> enumerator1;
      CodeAnalyzerResult codeAnalyzerResult;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              codeAnalyzerResult.ReferenceMetadata.AddRange<KeyValuePair<IMetadata, ICollection<IPropertyMetadata>>>((IEnumerable<KeyValuePair<IMetadata, ICollection<IPropertyMetadata>>>) first.ReferenceMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
              continue;
            case 2:
              codeAnalyzerResult = new CodeAnalyzerResult();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_3;
            case 4:
              goto label_37;
            default:
              goto label_40;
          }
        }
label_40:
        enumerator1 = second.ReferenceMetadata.GetEnumerator();
        num1 = 3;
      }
label_3:
      try
      {
label_5:
        if (CodeAnalyzerResultExtension.DTcmLYfqBHrtnkl2NSVa((object) enumerator1))
          goto label_26;
        else
          goto label_6;
label_4:
        IMetadata key;
        IEnumerator<IPropertyMetadata> enumerator2;
        ICollection<IPropertyMetadata> source;
        KeyValuePair<IMetadata, ICollection<IPropertyMetadata>> current;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_8;
            case 2:
              goto label_5;
            case 3:
              codeAnalyzerResult.ReferenceMetadata[key] = (ICollection<IPropertyMetadata>) new List<IPropertyMetadata>();
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 6 : 0;
              continue;
            case 4:
              if (!codeAnalyzerResult.ReferenceMetadata.ContainsKey(key))
              {
                num3 = 3;
                continue;
              }
              goto case 6;
            case 5:
              key = current.Key;
              num3 = 4;
              continue;
            case 6:
              source = codeAnalyzerResult.ReferenceMetadata[key];
              num3 = 7;
              continue;
            case 7:
              enumerator2 = current.Value.GetEnumerator();
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 1;
              continue;
            case 8:
              goto label_37;
            default:
              goto label_26;
          }
        }
label_8:
        try
        {
label_16:
          if (CodeAnalyzerResultExtension.DTcmLYfqBHrtnkl2NSVa((object) enumerator2))
            goto label_12;
          else
            goto label_17;
label_9:
          int num4;
          IPropertyMetadata property;
          while (true)
          {
            switch (num4)
            {
              case 1:
                goto label_12;
              case 2:
              case 3:
                goto label_16;
              case 4:
                source.Add(property);
                num4 = 2;
                continue;
              case 5:
                goto label_5;
              case 6:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (source.FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (a => CodeAnalyzerResultExtension.\u003C\u003Ec__DisplayClass0_0.yVpRLa8Y3kp6AJhnSGbB(CodeAnalyzerResultExtension.\u003C\u003Ec__DisplayClass0_0.d4tPZj8YN8SaRGqAiLpR((object) a), property.Uid))) != null)
                {
                  num4 = 3;
                  continue;
                }
                goto case 4;
              default:
                property = enumerator2.Current;
                num4 = 6;
                continue;
            }
          }
label_12:
          num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
          {
            num4 = 0;
            goto label_9;
          }
          else
            goto label_9;
label_17:
          num4 = 5;
          goto label_9;
        }
        finally
        {
          int num5;
          if (enumerator2 == null)
            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 2 : 0;
          else
            goto label_21;
label_20:
          switch (num5)
          {
            case 1:
            case 2:
          }
label_21:
          enumerator2.Dispose();
          num5 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
          {
            num5 = 1;
            goto label_20;
          }
          else
            goto label_20;
        }
label_6:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 8 : 2;
        goto label_4;
label_26:
        current = enumerator1.Current;
        num3 = 5;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
        {
          num3 = 1;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        int num6;
        if (enumerator1 == null)
          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
        else
          goto label_34;
label_33:
        switch (num6)
        {
          case 1:
            break;
          default:
        }
label_34:
        enumerator1.Dispose();
        num6 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
        {
          num6 = 2;
          goto label_33;
        }
        else
          goto label_33;
      }
label_37:
      return codeAnalyzerResult;
    }

    internal static bool DTcmLYfqBHrtnkl2NSVa([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static bool LeKn04fRzstf7WJaEcU6() => CodeAnalyzerResultExtension.xCMAfPfRcerS2FrncrVx == null;

    internal static CodeAnalyzerResultExtension HfDuQkfqFEOfm9jWxUVg() => CodeAnalyzerResultExtension.xCMAfPfRcerS2FrncrVx;
  }
}
