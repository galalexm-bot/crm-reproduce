// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.MetadataServiceExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions
{
  /// <summary>Расширение для IMetadataService</summary>
  public static class MetadataServiceExtensions
  {
    internal static MetadataServiceExtensions Hx2VstG36skfuSFjqOyY;

    /// <summary>Получить отображаемое имя</summary>
    /// <param name="service">Интерфейс службы управления метаданными</param>
    /// <param name="metadata">Метаданные</param>
    /// <returns>Отображаемое имя</returns>
    public static string GetDisplayName(this IMetadataService service, ICodeItemMetadata metadata)
    {
      int num = 1;
      string extensionPropertyValue;
      while (true)
      {
        switch (num)
        {
          case 1:
            IMetadataService service1 = service;
            ICodeItemMetadata metadata1 = metadata;
            // ISSUE: reference to a compiler-generated field
            Antlr.Runtime.Misc.Func<ICodeItemMetadata, string> func1 = MetadataServiceExtensions.\u003C\u003Ec.\u003C\u003E9__0_0;
            Antlr.Runtime.Misc.Func<ICodeItemMetadata, string> func2;
            if (func1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              MetadataServiceExtensions.\u003C\u003Ec.\u003C\u003E9__0_0 = func2 = (Antlr.Runtime.Misc.Func<ICodeItemMetadata, string>) (e => (string) MetadataServiceExtensions.\u003C\u003Ec.wlPiyK8FOlZPqiRJWe7i((object) e));
            }
            else
              goto label_8;
label_5:
            extensionPropertyValue = service1.GetConfigurationMetadataExtensionPropertyValue<string, ICodeItemMetadata>(metadata1, func2);
            if (extensionPropertyValue == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
label_8:
            func2 = func1;
            goto label_5;
          default:
            goto label_7;
        }
      }
label_3:
      return extensionPropertyValue;
label_7:
      return string.Empty;
    }

    private static T1 GetConfigurationMetadataExtensionPropertyValue<T1, T2>(
      this object service,
      T2 metadata,
      Antlr.Runtime.Misc.Func<T2, T1> func)
      where T2 : class, IMetadata
    {
      return !(service.GetConfigurationMetadataExtension((object) metadata) is T2 metadataExtension) ? default (T1) : func(metadataExtension);
    }

    private static IMetadata GetConfigurationMetadataExtension(this object service, object metadata)
    {
      int num1 = 6;
      IMetadata metadata1;
      IMetadataService service1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            IMetadata metadata2 = (IMetadata) service1.GetMetadataList().OfType<EntityMetadata>().FirstOrDefault<EntityMetadata>((System.Func<EntityMetadata, bool>) (m =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    if (MetadataServiceExtensions.\u003C\u003Ec__DisplayClass2_0.AUXfut8FNyFhj1wSDAXG((object) m) == EntityMetadataType.InterfaceExtension)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
                      continue;
                    }
                    goto label_7;
                  case 2:
                    goto label_6;
                  default:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    if (MetadataServiceExtensions.\u003C\u003Ec__DisplayClass2_0.WmjHPV8Fa9lm9fBD8EwV(MetadataServiceExtensions.\u003C\u003Ec__DisplayClass2_0.iQRQXR8F3ZM2w89QXQUo((object) m), MetadataServiceExtensions.\u003C\u003Ec__DisplayClass2_0.WPOqDL8Fp6K3tEghQji3((object) metadata1)))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 2 : 0;
                      continue;
                    }
                    goto label_7;
                }
              }
label_6:
              // ISSUE: reference to a compiler-generated method
              return MetadataServiceExtensions.\u003C\u003Ec__DisplayClass2_0.CA1eFY8FDwyX6kCCLgA6((object) service1, m.Uid);
label_7:
              return false;
            }));
            metadata1 = metadata2 == null ? metadata1 : metadata2;
            num1 = 3;
            continue;
          case 2:
            if (MetadataServiceExtensions.gswyoIG3xrGaQj8WXwye((object) entityMetadata) == EntityMetadataType.Interface)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 1;
              continue;
            }
            goto label_5;
          case 3:
            goto label_5;
          case 4:
            service1 = (IMetadataService) service;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
            continue;
          case 5:
            metadata1 = (IMetadata) metadata;
            num1 = 4;
            continue;
          case 6:
            num1 = 5;
            continue;
          case 7:
            goto label_2;
          default:
            if (!(service1 is IMetadataRuntimeService))
            {
              if (metadata1 is EntityMetadata entityMetadata)
              {
                num1 = 2;
                continue;
              }
              goto label_5;
            }
            else
            {
              num1 = 7;
              continue;
            }
        }
      }
label_2:
      return MetadataLoader.LoadMetadata(MetadataServiceExtensions.lZb3wiG37T09uNdTH0jy((object) metadata1));
label_5:
      return metadata1;
    }

    internal static bool cK66G3G3HMWVHoxxSfPE() => MetadataServiceExtensions.Hx2VstG36skfuSFjqOyY == null;

    internal static MetadataServiceExtensions cmmjN5G3AkOtWTAD1r1t() => MetadataServiceExtensions.Hx2VstG36skfuSFjqOyY;

    internal static Guid lZb3wiG37T09uNdTH0jy([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static EntityMetadataType gswyoIG3xrGaQj8WXwye([In] object obj0) => ((EntityMetadata) obj0).Type;
  }
}
