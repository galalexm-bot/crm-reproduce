// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.ClassMetadataExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions
{
  /// <summary>Методы расширения для ClassMetadata</summary>
  public static class ClassMetadataExtensions
  {
    internal static ClassMetadataExtensions i5yH8hGwZO2trWEUn1yG;

    /// <summary>Получить идентификатор свойства наименования</summary>
    /// <param name="metadata">Метаданные класса</param>
    public static Guid GetTitlePropertyUid(this ClassMetadata metadata)
    {
      int num1 = 5;
      ClassMetadata metadata1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (!metadata1.Properties.Any<PropertyMetadata>((Func<PropertyMetadata, bool>) (a =>
            {
              int num2 = 1;
              Guid guid;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    guid = ClassMetadataExtensions.\u003C\u003Ec__DisplayClass0_0.ErFqSf8bVT9u8O9G2kxk((object) a);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_3;
                }
              }
label_3:
              // ISSUE: reference to a compiler-generated method
              return guid.Equals(ClassMetadataExtensions.\u003C\u003Ec__DisplayClass0_0.uV3lG68bSOBTdotZdIrb((object) metadata1));
            })))
            {
              num1 = 3;
              continue;
            }
            goto label_10;
          case 2:
            if (ClassMetadataExtensions.ruXOusGwS6cWj9f9iWD0(ClassMetadataExtensions.egJdx3GwV8B2vQ4fgjoI((object) metadata1), Guid.Empty))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 1 : 0;
              continue;
            }
            goto case 3;
          case 3:
            if (!ClassMetadataExtensions.GvCcOsGwRxNfB030T24Y(ClassMetadataExtensions.F3Z0R2Gwirm2hFoAAC6Z((object) metadata1), Guid.Empty))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 4:
            metadata1 = metadata;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 2 : 0;
            continue;
          case 5:
            num1 = 4;
            continue;
          case 6:
            goto label_10;
          case 7:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return Guid.Empty;
label_3:
      return ClassMetadataExtensions.RW6AAdGwqSFKPqLQOg7L((object) (ClassMetadata) MetadataLoader.LoadMetadata(ClassMetadataExtensions.F3Z0R2Gwirm2hFoAAC6Z((object) metadata1)));
label_10:
      return ClassMetadataExtensions.egJdx3GwV8B2vQ4fgjoI((object) metadata1);
    }

    /// <summary>Получить свойство наименования</summary>
    /// <param name="metadata">Метаданные класса</param>
    public static PropertyMetadata GetTitleProperty(this ClassMetadata metadata)
    {
      int num1 = 4;
      PropertyMetadata titleProperty;
      ClassMetadata metadata1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!(metadata1.TitlePropertyUid != Guid.Empty))
              {
                num2 = 6;
                continue;
              }
              break;
            case 2:
              if (titleProperty == null)
                goto case 6;
              else
                goto label_4;
            case 3:
              metadata1 = metadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 1;
              continue;
            case 4:
              goto label_9;
            case 5:
              goto label_6;
            case 6:
              if (!ClassMetadataExtensions.GvCcOsGwRxNfB030T24Y(ClassMetadataExtensions.F3Z0R2Gwirm2hFoAAC6Z((object) metadata1), Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 8 : 5;
                continue;
              }
              goto label_13;
            case 7:
              goto label_13;
            case 8:
              goto label_14;
          }
          titleProperty = metadata1.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (a =>
          {
            int num3 = 1;
            Guid guid;
            while (true)
            {
              switch (num3)
              {
                case 1:
                  // ISSUE: reference to a compiler-generated method
                  guid = ClassMetadataExtensions.\u003C\u003Ec__DisplayClass1_0.ooWfdU8bXRaTVEPKY8Bo((object) a);
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_2;
              }
            }
label_2:
            // ISSUE: reference to a compiler-generated method
            return guid.Equals(ClassMetadataExtensions.\u003C\u003Ec__DisplayClass1_0.TQZwpl8bTQAHEuhYVc59((object) metadata1));
          }));
          num2 = 2;
        }
label_4:
        num1 = 5;
        continue;
label_9:
        num1 = 3;
      }
label_6:
      return titleProperty;
label_13:
      return (PropertyMetadata) null;
label_14:
      return (PropertyMetadata) ClassMetadataExtensions.pH4MMvGwKBujdGYB6oik((object) (ClassMetadata) MetadataLoader.LoadMetadata(metadata1.BaseClassUid));
    }

    internal static Guid egJdx3GwV8B2vQ4fgjoI([In] object obj0) => ((ClassMetadata) obj0).TitlePropertyUid;

    internal static bool ruXOusGwS6cWj9f9iWD0([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static Guid F3Z0R2Gwirm2hFoAAC6Z([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

    internal static bool GvCcOsGwRxNfB030T24Y([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static Guid RW6AAdGwqSFKPqLQOg7L([In] object obj0) => ((ClassMetadata) obj0).GetTitlePropertyUid();

    internal static bool nyUpWKGwu3cGloPcaRNg() => ClassMetadataExtensions.i5yH8hGwZO2trWEUn1yG == null;

    internal static ClassMetadataExtensions H6t8qWGwIwDUdhgJnGUB() => ClassMetadataExtensions.i5yH8hGwZO2trWEUn1yG;

    internal static object pH4MMvGwKBujdGYB6oik([In] object obj0) => (object) ((ClassMetadata) obj0).GetTitleProperty();
  }
}
