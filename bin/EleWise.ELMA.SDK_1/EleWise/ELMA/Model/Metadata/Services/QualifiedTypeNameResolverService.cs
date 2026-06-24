// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Services.QualifiedTypeNameResolverService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Metadata.Services
{
  /// <inheritdoc />
  [Service]
  internal class QualifiedTypeNameResolverService : IQualifiedTypeNameResolverService
  {
    private readonly IEnumerable<IQualifiedTypeResolverExtension> qualifiedTypeResolverExtensions;
    private static QualifiedTypeNameResolverService n5hyvsbLT6DQf6ZSEW4r;

    /// <summary>ctor</summary>
    /// <param name="qualifiedTypeResolverExtensions">Реализации точки расширения для <see cref="T:EleWise.ELMA.Model.Metadata.Services.IQualifiedTypeNameResolverService" /></param>
    public QualifiedTypeNameResolverService(
      IEnumerable<IQualifiedTypeResolverExtension> qualifiedTypeResolverExtensions)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.qualifiedTypeResolverExtensions = qualifiedTypeResolverExtensions;
    }

    /// <inheritdoc />
    public string GetQualifiedTypeName(Type type)
    {
      int num1 = 1;
      IQualifiedTypeResolverExtension resolverExtension;
      Guid uid;
      Type type1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_5;
            case 3:
              goto label_3;
            case 4:
              uid = resolverExtension.Uid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 2 : 0;
              continue;
            default:
              type1 = type;
              num2 = 3;
              continue;
          }
        }
label_3:
        resolverExtension = this.qualifiedTypeResolverExtensions.First<IQualifiedTypeResolverExtension>((Func<IQualifiedTypeResolverExtension, bool>) (e => e.CheckType(type1)));
        num1 = 4;
      }
label_5:
      return (string) QualifiedTypeNameResolverService.OxoDXsbLOhtgdO8G31wV((object) ((IEnumerable<byte>) uid.ToByteArray()).Concat<byte>(resolverExtension.GetQualifiedTypeData(type1)).ToArray<byte>());
    }

    /// <inheritdoc />
    public Type GetType(string qualifiedTypeName)
    {
      int num = 2;
      byte[] source;
      Guid uid;
      while (true)
      {
        switch (num)
        {
          case 1:
            source = Convert.FromBase64String(qualifiedTypeName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 0;
            continue;
          case 3:
            goto label_2;
          default:
            uid = new Guid(((IEnumerable<byte>) source).Take<byte>(16).ToArray<byte>());
            num = 3;
            continue;
        }
      }
label_2:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.qualifiedTypeResolverExtensions.First<IQualifiedTypeResolverExtension>((Func<IQualifiedTypeResolverExtension, bool>) (e => QualifiedTypeNameResolverService.\u003C\u003Ec__DisplayClass3_0.DWZkciCMWqEm0REm288R(QualifiedTypeNameResolverService.\u003C\u003Ec__DisplayClass3_0.M54rnOCMBDd6Y9x6MmF9((object) e), uid))).GetType(((IEnumerable<byte>) source).Skip<byte>(16));
    }

    internal static object OxoDXsbLOhtgdO8G31wV([In] object obj0) => (object) Convert.ToBase64String((byte[]) obj0);

    internal static bool lINoqibLkh16I7QXqoQZ() => QualifiedTypeNameResolverService.n5hyvsbLT6DQf6ZSEW4r == null;

    internal static QualifiedTypeNameResolverService YoFRPgbLnWoAIJSHj7ZS() => QualifiedTypeNameResolverService.n5hyvsbLT6DQf6ZSEW4r;
  }
}
