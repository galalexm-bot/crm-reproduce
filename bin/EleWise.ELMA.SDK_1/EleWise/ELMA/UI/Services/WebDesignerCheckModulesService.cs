// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Services.WebDesignerCheckModulesService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Services
{
  /// <summary>Сервис для проверки Дизайнера ELMA</summary>
  [Service]
  internal sealed class WebDesignerCheckModulesService : IWebDesignerCheckModulesService
  {
    private readonly ModuleMetadataItemHeaderManager moduleMetadataItemHeaderManager;
    private readonly ICacheService cacheService;
    private readonly IModuleMetadataLoader moduleMetadataLoader;
    private static WebDesignerCheckModulesService YBSNsoUmYPARXpENO8L;

    /// <summary>Ctor</summary>
    /// <param name="moduleMetadataItemHeaderManager">Менеджер заголвков метаданных модулей</param>
    /// <param name="cacheService">Сервис для работы с кешем</param>
    /// <param name="moduleMetadataLoader">Загрузчик метаданных модулей</param>
    public WebDesignerCheckModulesService(
      ModuleMetadataItemHeaderManager moduleMetadataItemHeaderManager,
      ICacheService cacheService,
      IModuleMetadataLoader moduleMetadataLoader)
    {
      WebDesignerCheckModulesService.WGNVpIUJMrswvVEqCMO();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.moduleMetadataLoader = moduleMetadataLoader;
            num = 3;
            continue;
          case 2:
            this.cacheService = cacheService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 1;
            continue;
          case 3:
            goto label_3;
          default:
            this.moduleMetadataItemHeaderManager = moduleMetadataItemHeaderManager;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Проверить веб-дизайнер</summary>
    /// <returns>Результат проверки</returns>
    public CheckDesignerModuleResult[] CheckWebDesigner()
    {
      int num1 = 7;
      List<CheckDesignerModuleResult> designerModuleResultList1;
      while (true)
      {
        int num2 = num1;
        // ISSUE: variable of a compiler-generated type
        WebDesignerCheckModulesService.\u003C\u003Ec__DisplayClass5_0 cDisplayClass50;
        List<ModuleMetadataItemHeader> list;
        string str;
        Version version;
        List<ModuleMetadataItemHeader>.Enumerator enumerator;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!this.cacheService.TryGetValue<List<CheckDesignerModuleResult>>((string) WebDesignerCheckModulesService.VUEbQRU9SMIAVFh5XCK(-649342099 - -1150814748 ^ 501418295), out designerModuleResultList1))
              {
                num2 = 17;
                continue;
              }
              goto label_15;
            case 2:
              List<CheckDesignerModuleResult> designerModuleResultList2 = designerModuleResultList1;
              CheckDesignerModuleResult designerModuleResult1 = new CheckDesignerModuleResult();
              WebDesignerCheckModulesService.LjGenkUc2tWVX9T54vd((object) designerModuleResult1, WebDesignerCheckModulesService.VUEbQRU9SMIAVFh5XCK(-1120607109 - 305487170 ^ -1426107447));
              designerModuleResult1.CheckResult = (string) WebDesignerCheckModulesService.rPGJfpUzkei0bfqwIQ9((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 222116444));
              designerModuleResultList2.Add(designerModuleResult1);
              num2 = 4;
              continue;
            case 3:
            case 9:
              enumerator = list.GetEnumerator();
              num2 = 10;
              continue;
            case 4:
            case 8:
label_11:
              this.cacheService.Insert<List<CheckDesignerModuleResult>>((string) WebDesignerCheckModulesService.VUEbQRU9SMIAVFh5XCK(1199946765 ^ 1199925427), designerModuleResultList1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
              continue;
            case 5:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass50.designerModuleUids = ModuleMetadataItemHeaderManager.DesignerModules;
              num2 = 16;
              continue;
            case 6:
              designerModuleResultList1 = new List<CheckDesignerModuleResult>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 1 : 1;
              continue;
            case 7:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass50 = new WebDesignerCheckModulesService.\u003C\u003Ec__DisplayClass5_0();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 1 : 6;
              continue;
            case 10:
              try
              {
label_26:
                if (enumerator.MoveNext())
                  goto label_24;
                else
                  goto label_27;
label_21:
                ModuleMetadataItemHeader current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 2:
                      goto label_11;
                    case 3:
                      if (current.Published == null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 0;
                        continue;
                      }
                      goto case 6;
                    case 5:
                      List<CheckDesignerModuleResult> designerModuleResultList3 = designerModuleResultList1;
                      CheckDesignerModuleResult designerModuleResult2 = new CheckDesignerModuleResult();
                      WebDesignerCheckModulesService.LjGenkUc2tWVX9T54vd((object) designerModuleResult2, (object) current.Name);
                      WebDesignerCheckModulesService.s2EgSqsW4TVqYLiw2Yq((object) designerModuleResult2, WebDesignerCheckModulesService.pUhkd9sh55oLEGB6aKf(WebDesignerCheckModulesService.YCFSYssbQlEveWkE5PH((object) current)));
                      WebDesignerCheckModulesService.cNCItgso5dwGBSIyUcw((object) designerModuleResult2, (object) EleWise.ELMA.SR.T((string) WebDesignerCheckModulesService.VUEbQRU9SMIAVFh5XCK(44884861 ^ 44840317), WebDesignerCheckModulesService.n0ChpFsEoUUxxpqyPbS((object) current), (object) str));
                      CheckDesignerModuleResult designerModuleResult3 = designerModuleResult2;
                      designerModuleResultList3.Add(designerModuleResult3);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 4 : 4;
                      continue;
                    case 6:
                      if (!WebDesignerCheckModulesService.PFqEyKsGXhvSaRADjOe(WebDesignerCheckModulesService.pUhkd9sh55oLEGB6aKf(WebDesignerCheckModulesService.YCFSYssbQlEveWkE5PH((object) current)), (object) str))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
                        continue;
                      }
                      goto case 5;
                    case 7:
                      goto label_24;
                    default:
                      goto label_26;
                  }
                }
label_24:
                current = enumerator.Current;
                num3 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
                {
                  num3 = 3;
                  goto label_21;
                }
                else
                  goto label_21;
label_27:
                num3 = 2;
                goto label_21;
              }
              finally
              {
                enumerator.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 11:
              object obj = WebDesignerCheckModulesService.UgSpk8sBD8Itgxt573H(WebDesignerCheckModulesService.pSmYYFsFiJ7lQsMqPTI((object) this.moduleMetadataLoader.GetDefaultModuleVersion(ModuleMetadataItemHeaderManager.BuilderUiModuleUid)));
              str = obj.ToString();
              int fieldCount = 3;
              if (!(((Version) obj).ToString(fieldCount) != version.ToString(fieldCount)))
              {
                num2 = 9;
                continue;
              }
              goto case 14;
            case 12:
              if (WebDesignerCheckModulesService.xDFo4NUsUkFowk64b5F((object) list) == 0)
                goto case 2;
              else
                goto label_6;
            case 13:
            case 18:
              version = VersionInfo.GetVersion<EleWise.ELMA.SR>();
              num2 = 11;
              continue;
            case 14:
              List<CheckDesignerModuleResult> designerModuleResultList4 = designerModuleResultList1;
              CheckDesignerModuleResult designerModuleResult4 = new CheckDesignerModuleResult();
              designerModuleResult4.ModuleName = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137470146);
              WebDesignerCheckModulesService.s2EgSqsW4TVqYLiw2Yq((object) designerModuleResult4, (object) str);
              WebDesignerCheckModulesService.cNCItgso5dwGBSIyUcw((object) designerModuleResult4, (object) EleWise.ELMA.SR.T((string) WebDesignerCheckModulesService.VUEbQRU9SMIAVFh5XCK(~541731958 ^ -541784361), (object) str, (object) version.ToString()));
              CheckDesignerModuleResult designerModuleResult5 = designerModuleResult4;
              designerModuleResultList4.Add(designerModuleResult5);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 3 : 0;
              continue;
            case 15:
              goto label_15;
            case 16:
              ModuleMetadataItemHeaderManager itemHeaderManager = this.moduleMetadataItemHeaderManager;
              // ISSUE: type reference
              ParameterExpression parameterExpression = (ParameterExpression) WebDesignerCheckModulesService.jM8qiyUrLkLgBThoQDf(WebDesignerCheckModulesService.sKH25hUl4Bo4hEGVeQO(__typeref (ModuleMetadataItemHeader)), WebDesignerCheckModulesService.VUEbQRU9SMIAVFh5XCK(-1824388195 ^ -1824349213));
              // ISSUE: type reference
              // ISSUE: field reference
              // ISSUE: method reference
              // ISSUE: type reference
              // ISSUE: method reference
              Expression<Func<ModuleMetadataItemHeader, bool>> condition = Expression.Lambda<Func<ModuleMetadataItemHeader, bool>>((Expression) Expression.Call((Expression) WebDesignerCheckModulesService.LmhCvtUjYaqssNig55G(WebDesignerCheckModulesService.O3ym0aUgc4JWPDVMHEK((object) cDisplayClass50, WebDesignerCheckModulesService.sKH25hUl4Bo4hEGVeQO(__typeref (WebDesignerCheckModulesService.\u003C\u003Ec__DisplayClass5_0))), WebDesignerCheckModulesService.fpBmhqU5N67Bfbh3NDX(__fieldref (WebDesignerCheckModulesService.\u003C\u003Ec__DisplayClass5_0.designerModuleUids))), (MethodInfo) WebDesignerCheckModulesService.Kbb83FUYW3B9MsXFO6e(__methodref (ICollection<Guid>.Contains), __typeref (ICollection<Guid>)), (Expression) WebDesignerCheckModulesService.kRo6jUUURQABwDIZscY((object) parameterExpression, (object) (MethodInfo) WebDesignerCheckModulesService.EEPQRNULCs4kmeDSFcw(__methodref (ModuleMetadataItemHeader.get_Uid)))), parameterExpression);
              // ISSUE: reference to a compiler-generated method
              list = itemHeaderManager.Find(condition).OrderBy<ModuleMetadataItemHeader, string>((Func<ModuleMetadataItemHeader, string>) (item => (string) WebDesignerCheckModulesService.\u003C\u003Ec.LxlHtHfU5utEWVmnc1GE((object) item))).ToList<ModuleMetadataItemHeader>();
              num2 = 12;
              continue;
            case 17:
              designerModuleResultList1 = new List<CheckDesignerModuleResult>();
              num2 = 5;
              continue;
            default:
              goto label_10;
          }
        }
label_6:
        num1 = 13;
      }
label_10:
      return (CheckDesignerModuleResult[]) WebDesignerCheckModulesService.oHxruoUdiX1iQKLyJaA((object) designerModuleResultList1);
label_15:
      return (CheckDesignerModuleResult[]) WebDesignerCheckModulesService.oHxruoUdiX1iQKLyJaA((object) designerModuleResultList1);
    }

    /// <summary>Очистить кеш</summary>
    public void ClearCache()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            WebDesignerCheckModulesService.QlKUS1sfUo4MmGsPSM2((object) this.cacheService, WebDesignerCheckModulesService.VUEbQRU9SMIAVFh5XCK(-244066886 - -48452443 ^ -195560021));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static void WGNVpIUJMrswvVEqCMO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool ioqq8gUy83J9GDqF0OT() => WebDesignerCheckModulesService.YBSNsoUmYPARXpENO8L == null;

    internal static WebDesignerCheckModulesService c01guxUMVKI4uXkruGZ() => WebDesignerCheckModulesService.YBSNsoUmYPARXpENO8L;

    internal static object VUEbQRU9SMIAVFh5XCK(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object oHxruoUdiX1iQKLyJaA([In] object obj0) => (object) ((List<CheckDesignerModuleResult>) obj0).ToArray();

    internal static Type sKH25hUl4Bo4hEGVeQO([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object jM8qiyUrLkLgBThoQDf([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object O3ym0aUgc4JWPDVMHEK([In] object obj0, [In] Type obj1) => (object) Expression.Constant(obj0, obj1);

    internal static object fpBmhqU5N67Bfbh3NDX([In] RuntimeFieldHandle obj0) => (object) FieldInfo.GetFieldFromHandle(obj0);

    internal static object LmhCvtUjYaqssNig55G([In] object obj0, [In] object obj1) => (object) Expression.Field((Expression) obj0, (FieldInfo) obj1);

    internal static object Kbb83FUYW3B9MsXFO6e([In] RuntimeMethodHandle obj0, [In] RuntimeTypeHandle obj1) => (object) MethodBase.GetMethodFromHandle(obj0, obj1);

    internal static object EEPQRNULCs4kmeDSFcw([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object kRo6jUUURQABwDIZscY([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static int xDFo4NUsUkFowk64b5F([In] object obj0) => ((List<ModuleMetadataItemHeader>) obj0).Count;

    internal static void LjGenkUc2tWVX9T54vd([In] object obj0, [In] object obj1) => ((CheckDesignerModuleResult) obj0).ModuleName = (string) obj1;

    internal static object rPGJfpUzkei0bfqwIQ9([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object pSmYYFsFiJ7lQsMqPTI([In] object obj0) => (object) ((ModuleVersion) obj0).Header;

    internal static object UgSpk8sBD8Itgxt573H([In] object obj0) => (object) ((ModuleVersionHeader) obj0).Version;

    internal static void s2EgSqsW4TVqYLiw2Yq([In] object obj0, [In] object obj1) => ((CheckDesignerModuleResult) obj0).Version = (string) obj1;

    internal static void cNCItgso5dwGBSIyUcw([In] object obj0, [In] object obj1) => ((CheckDesignerModuleResult) obj0).CheckResult = (string) obj1;

    internal static object YCFSYssbQlEveWkE5PH([In] object obj0) => (object) ((ModuleMetadataItemHeader) obj0).Published;

    internal static object pUhkd9sh55oLEGB6aKf([In] object obj0) => (object) ((ModuleMetadataItem) obj0).Version;

    internal static bool PFqEyKsGXhvSaRADjOe([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static object n0ChpFsEoUUxxpqyPbS([In] object obj0) => (object) ((ModuleMetadataItemHeader) obj0).DisplayName;

    internal static void QlKUS1sfUo4MmGsPSM2([In] object obj0, [In] object obj1) => ((ICacheService) obj0).Remove((string) obj1);
  }
}
