// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueryInFunctions.SubTypesFunction
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions.QueryInFunctions
{
  [Component]
  public class SubTypesFunction : IQueryInFunction, IEQLFunction
  {
    private static SubTypesFunction dOwsZMGxLpL8ilpJ582g;

    public string FunctionName => (string) SubTypesFunction.wAOywUGxcnbqw0XsIoWP(-1334993905 ^ -1335257181);

    public ICriterion GetCriterion(
      string alias,
      EntityMetadata metadata,
      string propName,
      object[] parameters)
    {
      int num1 = 10;
      string str;
      object[] objArray1;
      while (true)
      {
        int num2 = num1;
        PropertyInfo propertyInfo;
        string name;
        while (true)
        {
          Guid result;
          List<ClassMetadata> childClasses;
          ClassMetadata metadata1;
          object[] array;
          IMetadataRuntimeService serviceNotNull;
          Type type1;
          IEnumerable<EntityMetadata> source1;
          object[] objArray2;
          object obj1;
          Type type2;
          EntityMetadata entityMetadata1;
          object obj2;
          switch (num2)
          {
            case 1:
              if (!(propName == (string) SubTypesFunction.wAOywUGxcnbqw0XsIoWP(1052221104 - 768835541 ^ 283401401)))
              {
                num2 = 28;
                continue;
              }
              obj1 = (object) null;
              goto label_43;
            case 2:
              objArray2 = array;
              goto label_54;
            case 3:
              List<ClassMetadata> source2 = childClasses;
              // ISSUE: reference to a compiler-generated field
              Func<ClassMetadata, ReferenceOnEntityType> func = SubTypesFunction.\u003C\u003Ec.\u003C\u003E9__2_1;
              Func<ClassMetadata, ReferenceOnEntityType> selector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                SubTypesFunction.\u003C\u003Ec.\u003C\u003E9__2_1 = selector = (Func<ClassMetadata, ReferenceOnEntityType>) (m =>
                {
                  ReferenceOnEntityType criterion = new ReferenceOnEntityType();
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  SubTypesFunction.\u003C\u003Ec.VLvNfW8CQrXXq1D7E4x2((object) criterion, SubTypesFunction.\u003C\u003Ec.lOcpr48CflwNhpB0W2nP((object) m));
                  return criterion;
                });
              }
              else
                goto label_55;
label_52:
              array = (object[]) source2.Select<ClassMetadata, ReferenceOnEntityType>(selector).ToArray<ReferenceOnEntityType>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 2;
              continue;
label_55:
              selector = func;
              goto label_52;
            case 4:
              if (!SubTypesFunction.W6AsqiGxzFCmQv4sCGXC((object) propName, SubTypesFunction.wAOywUGxcnbqw0XsIoWP(-1638402543 ^ -1638419341)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 3 : 20;
                continue;
              }
              type2 = (Type) null;
              goto label_41;
            case 5:
              // ISSUE: reference to a compiler-generated method
              entityMetadata1 = source1.FirstOrDefault<EntityMetadata>((Func<EntityMetadata, bool>) (m => SubTypesFunction.\u003C\u003Ec__DisplayClass2_0.zql3OJ8CoLrj9eyrqfKE((object) m.DisplayName, (object) name)));
              goto label_47;
            case 6:
            case 24:
              num2 = 14;
              continue;
            case 7:
            case 17:
            case 22:
              childClasses = MetadataLoader.GetChildClasses(metadata1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 11 : 30;
              continue;
            case 8:
              // ISSUE: reference to a compiler-generated method
              EntityMetadata entityMetadata2 = source1.FirstOrDefault<EntityMetadata>((Func<EntityMetadata, bool>) (m => (string) SubTypesFunction.\u003C\u003Ec__DisplayClass2_0.g0lfMo8CWeEg3v0eEReq((object) m) == name));
              if (entityMetadata2 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 5;
                continue;
              }
              entityMetadata1 = entityMetadata2;
              goto label_47;
            case 9:
              if (parameters[0] is string)
              {
                serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 3 : 4;
                continue;
              }
              num2 = 26;
              continue;
            case 10:
              if (parameters.Length == 1)
              {
                num2 = 9;
                continue;
              }
              goto label_24;
            case 11:
              obj2 = (object) propName;
              goto label_49;
            case 12:
              if (SubTypesFunction.vSlpNpG0Bq7Npg0CTrPY((object) propName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021393175)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 21 : 14;
                continue;
              }
              break;
            case 13:
              goto label_33;
            case 14:
              source1 = serviceNotNull.GetMetadataList().OfType<EntityMetadata>();
              num2 = 15;
              continue;
            case 15:
              goto label_23;
            case 16:
              // ISSUE: type reference
              if (!SubTypesFunction.ORXI3bG0oXosVVCsEyCx(__typeref (ReferenceOnEntityType)).IsAssignableFrom(propertyInfo.PropertyType))
              {
                num2 = 23;
                continue;
              }
              break;
            case 18:
              obj2 = SubTypesFunction.kgE9ZDG0hHErpjbw3ph5((object) metadata);
              goto label_49;
            case 19:
              if (SubTypesFunction.W6AsqiGxzFCmQv4sCGXC((object) propName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461641723)))
              {
                num2 = 18;
                continue;
              }
              goto case 11;
            case 20:
              type2 = serviceNotNull.GetTypeByUid(metadata.Uid);
              goto label_41;
            case 21:
              goto label_20;
            case 23:
              goto label_3;
            case 25:
              if (metadata1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 22 : 5;
                continue;
              }
              goto case 29;
            case 26:
              goto label_24;
            case 27:
label_7:
              metadata1 = (ClassMetadata) MetadataLoader.LoadMetadata(result);
              num2 = 7;
              continue;
            case 28:
              obj1 = SubTypesFunction.I6AKUaG0FE6HqfAsrqEr(type1, (object) propName);
              goto label_43;
            case 29:
              metadata1 = (ClassMetadata) MetadataLoader.LoadMetadata(SubTypesFunction.bROawNG0baBmGl0wE0Zc((object) metadata1));
              num2 = 17;
              continue;
            case 30:
              childClasses.Add(metadata1);
              num2 = 19;
              continue;
            default:
              if (!SubTypesFunction.W6AsqiGxzFCmQv4sCGXC((object) propName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978494320)))
              {
                num2 = 3;
                continue;
              }
              objArray2 = childClasses.Select<ClassMetadata, object>((Func<ClassMetadata, object>) (m => (object) m.Uid)).ToArray<object>();
              goto label_54;
          }
          if (!Guid.TryParse((string) parameters[0], out result))
          {
            num2 = 6;
            continue;
          }
          goto label_7;
label_41:
          type1 = type2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 1;
          continue;
label_43:
          propertyInfo = (PropertyInfo) obj1;
          num2 = 12;
          continue;
label_47:
          metadata1 = (ClassMetadata) entityMetadata1;
          num2 = 25;
          continue;
label_49:
          str = (string) obj2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
          continue;
label_54:
          objArray1 = objArray2;
          num2 = 13;
        }
label_20:
        if (!SubTypesFunction.KDDU6OG0W2Xscqqh6sP6((object) propertyInfo, (object) null))
        {
          num1 = 16;
          continue;
        }
        break;
label_23:
        name = (string) parameters[0];
        num1 = 8;
      }
label_3:
      throw new ArgumentException();
label_24:
      throw new ArgumentException();
label_33:
      return (ICriterion) SubTypesFunction.AfOU0gG0Eic4CRT2bv9q(SubTypesFunction.Qq9T8NG0GHig9AQPZO3e((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561057946), (object) alias, (object) str), (object) objArray1);
    }

    public IEnumerable<EQLFunction> GetEqlFunctions() => (IEnumerable<EQLFunction>) new EQLFunction[1]
    {
      new EQLFunction()
      {
        DisplayName = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751360866), (object) this.FunctionName, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420479770))),
        Description = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -881862006)),
        Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236332531), (object) this.FunctionName),
        Types = new Guid[2]
        {
          ReferenceOnEntityTypeDecription.UID,
          ReferenceOnEntityTypeDecription.TypeUid_UID
        }
      }
    };

    public SubTypesFunction()
    {
      SubTypesFunction.CHpyXfG0fSkjssCUeW2Z();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object wAOywUGxcnbqw0XsIoWP(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool VyUGbMGxUqCaDPXrQGMG() => SubTypesFunction.dOwsZMGxLpL8ilpJ582g == null;

    internal static SubTypesFunction qlUT3fGxs7RBbJI8Q0St() => SubTypesFunction.dOwsZMGxLpL8ilpJ582g;

    internal static bool W6AsqiGxzFCmQv4sCGXC([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object I6AKUaG0FE6HqfAsrqEr(Type type, [In] object obj1) => (object) type.GetReflectionProperty((string) obj1);

    internal static bool vSlpNpG0Bq7Npg0CTrPY([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static bool KDDU6OG0W2Xscqqh6sP6([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static Type ORXI3bG0oXosVVCsEyCx([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static Guid bROawNG0baBmGl0wE0Zc([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object kgE9ZDG0hHErpjbw3ph5([In] object obj0) => (object) NHibernateHelper.GetCriteriaTypeUidPropertyName((EntityMetadata) obj0);

    internal static object Qq9T8NG0GHig9AQPZO3e([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object AfOU0gG0Eic4CRT2bv9q([In] object obj0, [In] object obj1) => (object) Restrictions.In((string) obj0, (object[]) obj1);

    internal static void CHpyXfG0fSkjssCUeW2Z() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
