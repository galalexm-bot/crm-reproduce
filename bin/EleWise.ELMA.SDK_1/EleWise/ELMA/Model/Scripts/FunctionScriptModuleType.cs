// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.FunctionScriptModuleType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Templates;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>Тип сценария для функций</summary>
  [Component]
  internal sealed class FunctionScriptModuleType : IScriptModuleType
  {
    /// <summary>Наименование аргумента по умолчанию</summary>
    internal const string Arg = "arg";
    /// <summary>Отступ для аргумента на новой строке</summary>
    internal const string ArgIndent = "            ";
    /// <summary>
    /// Максимальная суммарная длина полных имен типов, при превышении которой
    /// аргумент функции будет перенесен на новую строку
    /// </summary>
    internal const int MaxTypesLengthThreshold = 91;
    /// <summary>Строковое представление типа void</summary>
    public const string VoidType = "void";
    /// <summary>Уникальный идентификатор</summary>
    public const string UidS = "{8A29ABCF-70F0-4561-A3D1-22DAD6C1575F}";
    /// <summary>Уникальный идентификатор</summary>
    public static readonly Guid UID;
    internal static FunctionScriptModuleType UdqDK0bVzCAYDRLOlvCP;

    /// <inheritdoc />
    public Guid Uid => FunctionScriptModuleType.UID;

    /// <inheritdoc />
    public string Name => (string) FunctionScriptModuleType.be6lQYbSoqgPmCnHlMKo(FunctionScriptModuleType.lwZOnhbSWURUD7i0lI1K(-2106517564 ^ -2106348512));

    /// <inheritdoc />
    public string GenerateSourceCode(object parameters)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(parameters is FunctionMetadata functionMetadata))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return string.Empty;
label_5:
      return (string) FunctionScriptModuleType.vbVGy6bSbqf6Enqse269((object) functionMetadata);
    }

    /// <inheritdoc />
    public ScriptCompileResult Compile(ScriptModule module) => throw new NotImplementedException();

    /// <summary>Сгенерировать исходный код</summary>
    /// <param name="functionMetadata">Метаданные функции</param>
    /// <returns>Исходный код</returns>
    internal static string GenerateSourceCode(FunctionMetadata functionMetadata)
    {
      int num = 4;
      StringBuilder stringBuilder;
      FunctionMetadata functionMetadata1;
      string returnType;
      string paramType;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 13:
            goto label_13;
          case 2:
            if (!FunctionScriptModuleType.YghLUsbSf86apkmvLuQT((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870737909), (object) paramType))
            {
              num = 5;
              continue;
            }
            goto case 9;
          case 3:
            functionMetadata1 = functionMetadata;
            num = 12;
            continue;
          case 4:
            num = 3;
            continue;
          case 5:
          case 10:
            stringBuilder = (StringBuilder) FunctionScriptModuleType.h2Qjy9bSCrNQHXaPJwb8(FunctionScriptModuleType.h2Qjy9bSCrNQHXaPJwb8(FunctionScriptModuleType.qWSlPubSQLqY3BFPexT7((object) new StringBuilder(), (object) paramType), FunctionScriptModuleType.lwZOnhbSWURUD7i0lI1K(-1334993905 ^ -1334979283)), FunctionScriptModuleType.lwZOnhbSWURUD7i0lI1K(1178210108 ^ 1178118832));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 8 : 7;
            continue;
          case 6:
            paramType = FunctionScriptModuleType.GetTypeName((TypeSignature) FunctionScriptModuleType.syejNgbSErYtD31lcIHn((object) functionMetadata1));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 2 : 2;
            continue;
          case 7:
            paramType = stringBuilder.ToString();
            num = 13;
            continue;
          case 8:
            if (FunctionScriptModuleType.iEFHmFbSvJSSXYS4Xrop((object) paramType) + FunctionScriptModuleType.iEFHmFbSvJSSXYS4Xrop((object) returnType) > 91)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 1 : 11;
              continue;
            }
            goto case 7;
          case 9:
            paramType = "";
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 1;
            continue;
          case 11:
            FunctionScriptModuleType.HArUKcbS8xK3RNiU3vos(FunctionScriptModuleType.HArUKcbS8xK3RNiU3vos((object) stringBuilder, 0, FunctionScriptModuleType.lwZOnhbSWURUD7i0lI1K(-675505729 ^ -675404297)), 0, FunctionScriptModuleType.jN8btGbSZOseZGLaqU9V());
            num = 7;
            continue;
          case 12:
            FunctionScriptModuleType.hqUgHNbShXDyeBTcVTCy((object) functionMetadata1, FunctionScriptModuleType.lwZOnhbSWURUD7i0lI1K(1052221104 - 768835541 ^ 283550403));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
            continue;
          default:
            returnType = FunctionScriptModuleType.GetTypeName((TypeSignature) FunctionScriptModuleType.wiNLCobSGHPbpMYy66Cy((object) functionMetadata1));
            num = 6;
            continue;
        }
      }
label_13:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return ResourceTemplateGenerator.GenerateTemplate<FunctionScriptModuleType>((string) FunctionScriptModuleType.lwZOnhbSWURUD7i0lI1K(-1445902765 ^ -1980277732 ^ 539272747), (Func<string, string>) (s => ((string) FunctionScriptModuleType.\u003C\u003Ec__DisplayClass12_0.Wpvr71CPMtChIHbNtK3T(FunctionScriptModuleType.\u003C\u003Ec__DisplayClass12_0.Wpvr71CPMtChIHbNtK3T(FunctionScriptModuleType.\u003C\u003Ec__DisplayClass12_0.Wpvr71CPMtChIHbNtK3T((object) s.Replace((string) FunctionScriptModuleType.\u003C\u003Ec__DisplayClass12_0.tbHqTeCPyGbSDvgWfbTN(-710283084 ^ -537863435 ^ 173835233), (string) FunctionScriptModuleType.\u003C\u003Ec__DisplayClass12_0.tbHqTeCPyGbSDvgWfbTN(-244066886 - -48452443 ^ -195703607)), FunctionScriptModuleType.\u003C\u003Ec__DisplayClass12_0.tbHqTeCPyGbSDvgWfbTN(-606654180 ^ -606955320), FunctionScriptModuleType.\u003C\u003Ec__DisplayClass12_0.tbHqTeCPyGbSDvgWfbTN(1033719030 - 2012070891 ^ -978504837)), FunctionScriptModuleType.\u003C\u003Ec__DisplayClass12_0.tbHqTeCPyGbSDvgWfbTN(1012087039 ^ 1012306683), FunctionScriptModuleType.\u003C\u003Ec__DisplayClass12_0.dTM655CPJKtwJBqPhCdj((object) functionMetadata1)), FunctionScriptModuleType.\u003C\u003Ec__DisplayClass12_0.tbHqTeCPyGbSDvgWfbTN(-1146510045 ^ -1146351853), FunctionScriptModuleType.\u003C\u003Ec__DisplayClass12_0.x2BOwQCP9fLRhbHyh5P8((object) functionMetadata1))).Replace((string) FunctionScriptModuleType.\u003C\u003Ec__DisplayClass12_0.tbHqTeCPyGbSDvgWfbTN(1669371371 ^ 1669676985), returnType).Replace((string) FunctionScriptModuleType.\u003C\u003Ec__DisplayClass12_0.tbHqTeCPyGbSDvgWfbTN(-1334993905 ^ -1335347585), paramType)));
    }

    /// <summary>Получить имя типа</summary>
    /// <param name="typeSignature">Сигнатура типа</param>
    /// <param name="ignoreNamespaces">Игнорируемые пространства имён</param>
    /// <returns></returns>
    internal static string GetTypeName(
      TypeSignature typeSignature,
      ICollection<string> ignoreNamespaces = null)
    {
      if (typeSignature.TypeUid == Guid.Empty)
        return z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951339558);
      ITypeGenerationInfo typeDescriptor = MetadataServiceContext.Service.GetTypeDescriptor(typeSignature.TypeUid, typeSignature.SubTypeUid) as ITypeGenerationInfo;
      if (typeDescriptor == null)
        return z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333628462);
      ClassMetadata fakeMetadata = new ClassMetadata();
      PropertyMetadata propertyMetadata = new PropertyMetadata()
      {
        TypeUid = typeSignature.TypeUid,
        SubTypeUid = typeSignature.SubTypeUid,
        Nullable = typeSignature.Nullable
      };
      if (ignoreNamespaces == null)
        ignoreNamespaces = (ICollection<string>) Array.Empty<string>();
      string str = ignoreNamespaces.WithIgnoreNamespaces<ISyntaxNode>((Func<ISyntaxNode>) (() =>
      {
        int num = 1;
        PropertyMetadata propertyMetadata1;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (!FunctionScriptModuleType.\u003C\u003Ec__DisplayClass13_0.OvFhIKCPjDHD7MlFnAdI(FunctionScriptModuleType.\u003C\u003Ec__DisplayClass13_0.qPhcZlCP5bCGGDEkZAKu((object) typeSignature), ListOfSimpleTypeDescriptor.UID))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            case 2:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (!(FunctionScriptModuleType.\u003C\u003Ec__DisplayClass13_0.JrB701CPU9S0CuHE35U1(FunctionScriptModuleType.\u003C\u003Ec__DisplayClass13_0.s1LAo3CPYSrquXdBgdGT(), FunctionScriptModuleType.\u003C\u003Ec__DisplayClass13_0.OUPOBaCPLJtTP6awKVNP((object) typeSignature), Guid.Empty) is ITypeGenerationInfo typeGenerationInfo2))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 4 : 2;
                continue;
              }
              goto case 5;
            case 3:
              goto label_7;
            case 5:
              PropertyMetadata propertyMetadata2 = new PropertyMetadata();
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              FunctionScriptModuleType.\u003C\u003Ec__DisplayClass13_0.oFBq5NCPs1VsMPSchBij((object) propertyMetadata2, FunctionScriptModuleType.\u003C\u003Ec__DisplayClass13_0.OUPOBaCPLJtTP6awKVNP((object) typeSignature));
              // ISSUE: reference to a compiler-generated method
              propertyMetadata2.Nullable = FunctionScriptModuleType.\u003C\u003Ec__DisplayClass13_0.CjDSXmCPchZr54e2EUjb((object) typeSignature);
              propertyMetadata1 = propertyMetadata2;
              num = 3;
              continue;
            default:
              goto label_8;
          }
        }
label_7:
        // ISSUE: reference to a compiler-generated method
        return (ISyntaxNode) FunctionScriptModuleType.\u003C\u003Ec__DisplayClass13_0.KTJu75CPzPGYYNgejyXb((object) typeGenerationInfo2, (object) fakeMetadata, (object) propertyMetadata1, false);
label_8:
        return typeDescriptor.GetPropertyTypeReference(fakeMetadata, propertyMetadata, false);
      })).ToString().Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -98003692), "");
      return typeSignature.RelationType != RelationType.OneToOne ? str + z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 44982227) : str;
    }

    public FunctionScriptModuleType()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static FunctionScriptModuleType()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            FunctionScriptModuleType.BYd1MLbSu9fKmIMmAyXH();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            FunctionScriptModuleType.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -476037041));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static object lwZOnhbSWURUD7i0lI1K(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object be6lQYbSoqgPmCnHlMKo([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool DxRfg9bSFuq3v75l631s() => FunctionScriptModuleType.UdqDK0bVzCAYDRLOlvCP == null;

    internal static FunctionScriptModuleType SZd0qDbSBETMY9MYIjav() => FunctionScriptModuleType.UdqDK0bVzCAYDRLOlvCP;

    internal static object vbVGy6bSbqf6Enqse269([In] object obj0) => (object) FunctionScriptModuleType.GenerateSourceCode((FunctionMetadata) obj0);

    internal static void hqUgHNbShXDyeBTcVTCy([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object wiNLCobSGHPbpMYy66Cy([In] object obj0) => (object) ((FunctionMetadata) obj0).ReturnType;

    internal static object syejNgbSErYtD31lcIHn([In] object obj0) => (object) ((FunctionMetadata) obj0).ParameterType;

    internal static bool YghLUsbSf86apkmvLuQT([In] object obj0, [In] object obj1) => object.Equals(obj0, obj1);

    internal static object qWSlPubSQLqY3BFPexT7([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static object h2Qjy9bSCrNQHXaPJwb8([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static int iEFHmFbSvJSSXYS4Xrop([In] object obj0) => ((string) obj0).Length;

    internal static object HArUKcbS8xK3RNiU3vos([In] object obj0, [In] int obj1, [In] object obj2) => (object) ((StringBuilder) obj0).Insert(obj1, (string) obj2);

    internal static object jN8btGbSZOseZGLaqU9V() => (object) Environment.NewLine;

    internal static void BYd1MLbSu9fKmIMmAyXH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
