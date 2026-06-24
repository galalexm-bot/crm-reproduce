// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.CacheFilesServiceExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Files;
using EleWise.ELMA.Services;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions
{
  public static class CacheFilesServiceExtension
  {
    internal static CacheFilesServiceExtension rVxVgtGtSpGj9ft6VApq;

    public static BinaryFile GetBinaryFile(this ICacheFilesService cacheFilesService, Guid uid)
    {
      int num1 = 6;
      BinaryFile binaryFile1;
      BinaryFile binaryFile2;
      while (true)
      {
        int num2 = num1;
        string contentFilePath;
        IMimeMappingService serviceNotNull;
        string name1;
        string name2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_15;
            case 2:
              serviceNotNull = Locator.GetServiceNotNull<IMimeMappingService>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
              continue;
            case 3:
              contentFilePath = (string) CacheFilesServiceExtension.aKJnNgGtkvduwjRWo7ba((object) cacheFilesService, uid);
              num2 = 2;
              continue;
            case 4:
              goto label_19;
            case 5:
              name2 = (string) CacheFilesServiceExtension.ETKSQfGtXNjd6Sy7Gh8H(CacheFilesServiceExtension.cbQhMEGtKA9t2RV6rER5(-1290212282 ^ -644262414 ^ 1786922912), (object) uid.ToString());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 10 : 3;
              continue;
            case 6:
              if (CacheFilesServiceExtension.gbNidmGtqvZtKELZZRdi(uid, Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 5 : 0;
                continue;
              }
              goto label_4;
            case 7:
              if (binaryFile2 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 4 : 0;
                continue;
              }
              name1 = (string) CacheFilesServiceExtension.tQaI9SGtTPR5rnMIcVHP((object) cacheFilesService, uid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 3 : 3;
              continue;
            case 8:
            case 9:
              goto label_4;
            case 10:
              ContextVars.TryGetValue<BinaryFile>(name2, out binaryFile2);
              num2 = 7;
              continue;
            case 11:
              goto label_3;
            case 12:
              binaryFile1 = (BinaryFile) CacheFilesServiceExtension.X4iPxHGtP9a3iwJCFyoK((object) ((BinaryFileBuilder) CacheFilesServiceExtension.fC41eSGteoBTp99cEX83((object) BinaryFile.CreateNew().Uid(uid), CacheFilesServiceExtension.zWQRMYGt2V7Pbc234n2D((object) serviceNotNull, (object) Path.GetExtension((string) CacheFilesServiceExtension.rh5ZctGtO3DaOFB7oyny((object) name1))))).Name(name1).Content(contentFilePath));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 0;
              continue;
            case 13:
              if (!CacheFilesServiceExtension.JvDFpvGtnokESKAJcGTi((object) contentFilePath))
              {
                num2 = 8;
                continue;
              }
              goto case 12;
            default:
              if (string.IsNullOrEmpty(contentFilePath))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 2 : 9;
                continue;
              }
              goto case 13;
          }
        }
label_15:
        ContextVars.Set<BinaryFile>(name2, binaryFile1);
        num1 = 11;
      }
label_3:
      return binaryFile1;
label_4:
      return (BinaryFile) null;
label_19:
      return binaryFile2;
    }

    internal static bool gbNidmGtqvZtKELZZRdi([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object cbQhMEGtKA9t2RV6rER5(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object ETKSQfGtXNjd6Sy7Gh8H([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object tQaI9SGtTPR5rnMIcVHP([In] object obj0, Guid uid) => (object) ((ICacheFilesService) obj0).GetFileName(uid);

    internal static object aKJnNgGtkvduwjRWo7ba([In] object obj0, Guid uid) => (object) ((ICacheFilesService) obj0).GetFilePath(uid);

    internal static bool JvDFpvGtnokESKAJcGTi([In] object obj0) => File.Exists((string) obj0);

    internal static object rh5ZctGtO3DaOFB7oyny([In] object obj0) => (object) ((string) obj0).ReplaceInvalidFileNameChars();

    internal static object zWQRMYGt2V7Pbc234n2D([In] object obj0, [In] object obj1) => (object) ((IMimeMappingService) obj0).GetTypeByExtension((string) obj1);

    internal static object fC41eSGteoBTp99cEX83([In] object obj0, [In] object obj1) => (object) ((BinaryFileBuilder) obj0).ContentType((string) obj1);

    internal static object X4iPxHGtP9a3iwJCFyoK([In] object obj0) => (object) ((BinaryFileBuilder) obj0).Build();

    internal static bool eiIuPqGti0aZD8SmLU9l() => CacheFilesServiceExtension.rVxVgtGtSpGj9ft6VApq == null;

    internal static CacheFilesServiceExtension pMw0cMGtRAZcbEYn1eY7() => CacheFilesServiceExtension.rVxVgtGtSpGj9ft6VApq;
  }
}
