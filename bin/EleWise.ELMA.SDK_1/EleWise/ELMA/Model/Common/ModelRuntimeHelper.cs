// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Common.ModelRuntimeHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Model.Common
{
  /// <summary>
  /// </summary>
  public static class ModelRuntimeHelper
  {
    private static readonly ConcurrentDictionary<string, Type> loadedContextTypes;
    private static readonly object synk;
    internal static ModelRuntimeHelper qy1Pt0hT4fSXdUxCcPdj;

    /// <summary>Получить тип сущности для контекста процесса</summary>
    public static Type GetEntityType(
      EntityMetadata context,
      string assemblyName,
      byte[] assemblyRaw)
    {
      int num1 = 2;
      string key;
      string assemblyName1;
      byte[] assemblyRaw1;
      string fullTypeName;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_12;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 1;
              continue;
            case 3:
              if (context != null)
              {
                if (!ModelRuntimeHelper.xKXhiShT7bgIYYpTwtfr(ModelRuntimeHelper.MkblGqhTADiIejQNSAdJ((object) context)))
                {
                  key = (string) ModelRuntimeHelper.vNA6i6hT0RaHPUxqhrid(ModelRuntimeHelper.MkblGqhTADiIejQNSAdJ((object) context), ModelRuntimeHelper.hRny9RhTxDOulXyYHR0n(-35995181 ^ -35992111), (object) assemblyName1);
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 5 : 3;
                  continue;
                }
                num2 = 6;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 5 : 7;
              continue;
            case 4:
              assemblyRaw1 = assemblyRaw;
              num2 = 3;
              continue;
            case 5:
              fullTypeName = context.FullTypeName;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
              continue;
            case 6:
              goto label_5;
            case 7:
              goto label_7;
            default:
              goto label_4;
          }
        }
label_12:
        assemblyName1 = assemblyName;
        num1 = 4;
      }
label_4:
      Func<Assembly, bool> func;
      return ModelRuntimeHelper.loadedContextTypes.GetOrAdd(key, (Func<string, Type>) (s =>
      {
        int num3 = 2;
        bool lockTaken;
        object synk;
        while (true)
        {
          switch (num3)
          {
            case 1:
              lockTaken = false;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
              continue;
            case 2:
              synk = ModelRuntimeHelper.synk;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 1;
              continue;
            case 3:
              goto label_2;
            default:
              goto label_4;
          }
        }
label_2:
        Type entityType;
        return entityType;
label_4:
        try
        {
          Monitor.Enter(synk, ref lockTaken);
          int num4 = 11;
          while (true)
          {
            int num5;
            Type type;
            Assembly assembly;
            bool flag;
            switch (num4)
            {
              case 1:
                if (assembly == (Assembly) null)
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
                  continue;
                }
                goto case 10;
              case 2:
                flag = true;
                num4 = 10;
                continue;
              case 3:
                // ISSUE: reference to a compiler-generated method
                ModelRuntimeHelper.\u003C\u003Ec__DisplayClass2_0.zNgG4IvGQ0N43QnoQTug((object) Locator.GetServiceNotNull<IMetadataRuntimeService>(), type);
                num4 = 6;
                continue;
              case 4:
                goto label_2;
              case 5:
                // ISSUE: reference to a compiler-generated method
                object source = ModelRuntimeHelper.\u003C\u003Ec__DisplayClass2_0.OE5ywtvGWuLoqYlIgiP2();
                Func<Assembly, bool> func1 = func;
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                Func<Assembly, bool> predicate = func1 == null ? (func = (Func<Assembly, bool>) (a => ModelRuntimeHelper.\u003C\u003Ec__DisplayClass2_0.Ng3j4YvG8ipnruwSDCOr(ModelRuntimeHelper.\u003C\u003Ec__DisplayClass2_0.SVVeGhvGvkC2c8UOKT01((object) a), (object) assemblyName1))) : func1;
                assembly = ((IEnumerable<Assembly>) source).FirstOrDefault<Assembly>(predicate);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 0;
                continue;
              case 6:
                entityType = type;
                num5 = 4;
                break;
              case 7:
                goto label_17;
              case 8:
                // ISSUE: reference to a compiler-generated method
                if (!ModelRuntimeHelper.\u003C\u003Ec__DisplayClass2_0.dYtUsGvGGc9RYB1rBvtP(type, (Type) null))
                {
                  num5 = 12;
                  break;
                }
                goto label_17;
              case 9:
                goto label_13;
              case 10:
                // ISSUE: reference to a compiler-generated method
                type = ModelRuntimeHelper.\u003C\u003Ec__DisplayClass2_0.jWArNRvGhPUknvXxpNm9((object) assembly, (object) fullTypeName);
                num4 = 8;
                continue;
              case 11:
                flag = false;
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 5;
                continue;
              case 12:
                if (flag)
                {
                  num4 = 3;
                  continue;
                }
                goto case 6;
              default:
                if (assemblyRaw1 == null)
                {
                  num4 = 9;
                  continue;
                }
                // ISSUE: reference to a compiler-generated method
                assembly = (Assembly) ModelRuntimeHelper.\u003C\u003Ec__DisplayClass2_0.aWferrvGb7aAZk7nlxRt((object) assemblyRaw1);
                num4 = 2;
                continue;
            }
            num4 = num5;
          }
label_13:
          // ISSUE: reference to a compiler-generated method
          throw new EleWise.ELMA.Model.Metadata.MetadataException(EleWise.ELMA.SR.T((string) ModelRuntimeHelper.\u003C\u003Ec__DisplayClass2_0.sZ9aXpvGosjU6pOeJuFP(-488881205 ^ -489029933), (object) assemblyName1));
label_17:
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          throw new EleWise.ELMA.Model.Metadata.MetadataException((string) ModelRuntimeHelper.\u003C\u003Ec__DisplayClass2_0.IubeK6vGf1Kgjh4MKDt9(ModelRuntimeHelper.\u003C\u003Ec__DisplayClass2_0.vo8YM7vGElvYauViRSwp(ModelRuntimeHelper.\u003C\u003Ec__DisplayClass2_0.sZ9aXpvGosjU6pOeJuFP(1218962250 ^ 1218600476)), (object) assemblyName1, (object) fullTypeName));
        }
        finally
        {
          if (lockTaken)
          {
            int num6 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
              num6 = 1;
            while (true)
            {
              switch (num6)
              {
                case 1:
                  // ISSUE: reference to a compiler-generated method
                  ModelRuntimeHelper.\u003C\u003Ec__DisplayClass2_0.DUhejqvGCathQCXkYixP(synk);
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_30;
              }
            }
          }
label_30:;
        }
      }));
label_5:
      throw new ArgumentException((string) ModelRuntimeHelper.hRny9RhTxDOulXyYHR0n(1574260816 ^ 1574313348));
label_7:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218479176));
    }

    static ModelRuntimeHelper()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            ModelRuntimeHelper.loadedContextTypes = new ConcurrentDictionary<string, Type>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
            continue;
          case 3:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = 2;
            continue;
          default:
            ModelRuntimeHelper.synk = new object();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static object MkblGqhTADiIejQNSAdJ([In] object obj0) => (object) ((ClassMetadata) obj0).FullTypeName;

    internal static bool xKXhiShT7bgIYYpTwtfr([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object hRny9RhTxDOulXyYHR0n(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object vNA6i6hT0RaHPUxqhrid([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static bool AD7SlMhT6GHdEr6HiDDO() => ModelRuntimeHelper.qy1Pt0hT4fSXdUxCcPdj == null;

    internal static ModelRuntimeHelper GFq4o0hTHunohjVsoqRc() => ModelRuntimeHelper.qy1Pt0hT4fSXdUxCcPdj;
  }
}
