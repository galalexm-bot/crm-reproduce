// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueryFunctionResults.ReferenceOnEntityTypeQueryResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions.QueryFunctionResults
{
  [Component]
  public class ReferenceOnEntityTypeQueryResult : IQueryFunctionResult, IEQLFunction
  {
    private static ReferenceOnEntityTypeQueryResult owwiVAGyAeBSKWono8Ld;

    public string FunctionName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487123178);

    public object GetValue(EntityMetadata metadata, string propName, object[] parameters)
    {
      int num1 = 3;
      ClassMetadata classMetadata1;
      Guid result;
      while (true)
      {
        int num2 = num1;
        IEnumerable<ClassMetadata> source;
        ClassMetadata classMetadata2;
        string name;
        while (true)
        {
          IMetadataRuntimeService serviceNotNull;
          Type type1;
          PropertyInfo propertyInfo1;
          Type type2;
          PropertyInfo propertyInfo2;
          switch (num2)
          {
            case 1:
              if (!Guid.TryParse((string) parameters[0], out result))
              {
                num2 = 23;
                continue;
              }
              goto case 9;
            case 2:
              if (parameters[0] is string)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
                continue;
              }
              goto label_13;
            case 3:
              if (parameters.Length == 1)
              {
                num2 = 2;
                continue;
              }
              goto label_13;
            case 4:
              type2 = serviceNotNull.GetTypeByUid(metadata.Uid);
              break;
            case 5:
              goto label_11;
            case 6:
              if (classMetadata1 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 12 : 0;
                continue;
              }
              goto label_13;
            case 7:
              type2 = (Type) null;
              break;
            case 8:
              // ISSUE: reference to a compiler-generated method
              classMetadata2 = source.FirstOrDefault<ClassMetadata>((Func<ClassMetadata, bool>) (m => ReferenceOnEntityTypeQueryResult.\u003C\u003Ec__DisplayClass2_0.mXgJSl8CABGbnXomg2aa((object) m.Name, (object) name)));
              if (classMetadata2 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 14 : 4;
                continue;
              }
              goto label_44;
            case 9:
              if (ReferenceOnEntityTypeQueryResult.xdNYSQGymFXqBxqm54bS((object) propName, ReferenceOnEntityTypeQueryResult.x0xpn1Gy0S8ooB7DEvsL(-1998538950 ^ -1998523048)))
              {
                num2 = 21;
                continue;
              }
              goto label_21;
            case 10:
              if (!ReferenceOnEntityTypeQueryResult.xdNYSQGymFXqBxqm54bS((object) propName, ReferenceOnEntityTypeQueryResult.x0xpn1Gy0S8ooB7DEvsL(381945751 ^ 1158627804 ^ 1405813801)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 5 : 13;
                continue;
              }
              goto case 24;
            case 11:
              if (ReferenceOnEntityTypeQueryResult.xdNYSQGymFXqBxqm54bS((object) propName, ReferenceOnEntityTypeQueryResult.x0xpn1Gy0S8ooB7DEvsL(1304605005 ^ 1304621871)))
              {
                num2 = 7;
                continue;
              }
              goto case 4;
            case 12:
              classMetadata1 = (ClassMetadata) MetadataLoader.LoadMetadata(ReferenceOnEntityTypeQueryResult.GAJ916GydJRw77PSmJUt((object) classMetadata1));
              num2 = 18;
              continue;
            case 13:
              if (ReferenceOnEntityTypeQueryResult.r0VdrAGyytlCj7QlqUiM((object) propertyInfo1, (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 10 : 17;
                continue;
              }
              goto label_13;
            case 14:
              goto label_43;
            case 15:
              name = (string) parameters[0];
              num2 = 8;
              continue;
            case 16:
              propertyInfo2 = (PropertyInfo) null;
              goto label_40;
            case 17:
              // ISSUE: type reference
              if (ReferenceOnEntityTypeQueryResult.uPHCiTGyMS5IpSiBoHE8(__typeref (ReferenceOnEntityType)).IsAssignableFrom(ReferenceOnEntityTypeQueryResult.plZ0XYGyJKcxbPa7XEO4((object) propertyInfo1)))
              {
                num2 = 24;
                continue;
              }
              goto label_13;
            case 18:
              if (!ReferenceOnEntityTypeQueryResult.xdNYSQGymFXqBxqm54bS((object) propName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283401401)))
              {
                num2 = 5;
                continue;
              }
              goto label_12;
            case 19:
              goto label_21;
            case 20:
              propertyInfo2 = type1.GetReflectionProperty(propName);
              goto label_40;
            case 21:
              goto label_22;
            case 22:
              if (ReferenceOnEntityTypeQueryResult.xdNYSQGymFXqBxqm54bS((object) propName, ReferenceOnEntityTypeQueryResult.x0xpn1Gy0S8ooB7DEvsL(1669212571 ^ 1669229561)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 4 : 16;
                continue;
              }
              goto case 20;
            case 23:
              source = serviceNotNull.GetMetadataList().OfType<ClassMetadata>();
              num2 = 15;
              continue;
            case 24:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 1 : 1;
              continue;
            default:
              serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 7 : 11;
              continue;
          }
          type1 = type2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 22 : 22;
          continue;
label_40:
          propertyInfo1 = propertyInfo2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 1 : 10;
        }
label_43:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        classMetadata2 = source.FirstOrDefault<ClassMetadata>((Func<ClassMetadata, bool>) (m => ReferenceOnEntityTypeQueryResult.\u003C\u003Ec__DisplayClass2_0.mXgJSl8CABGbnXomg2aa(ReferenceOnEntityTypeQueryResult.\u003C\u003Ec__DisplayClass2_0.rwZ3UP8C7wcBglCTvKLC((object) m), (object) name)));
label_44:
        classMetadata1 = classMetadata2;
        num1 = 6;
      }
label_11:
      ReferenceOnEntityType referenceOnEntityType1 = new ReferenceOnEntityType();
      ReferenceOnEntityTypeQueryResult.ztCOu5Gy93ZX8XSKVQR1((object) referenceOnEntityType1, ReferenceOnEntityTypeQueryResult.GAJ916GydJRw77PSmJUt((object) classMetadata1));
      return (object) referenceOnEntityType1;
label_12:
      return (object) ReferenceOnEntityTypeQueryResult.GAJ916GydJRw77PSmJUt((object) classMetadata1);
label_13:
      throw new ArgumentException();
label_21:
      ReferenceOnEntityType referenceOnEntityType2 = new ReferenceOnEntityType();
      ReferenceOnEntityTypeQueryResult.ztCOu5Gy93ZX8XSKVQR1((object) referenceOnEntityType2, result);
      return (object) referenceOnEntityType2;
label_22:
      return (object) result;
    }

    public IEnumerable<EQLFunction> GetEqlFunctions() => (IEnumerable<EQLFunction>) new EQLFunction[1]
    {
      new EQLFunction()
      {
        DisplayName = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727403976), (object) this.FunctionName, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146245405))),
        Description = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979613096)),
        Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2120898103), (object) this.FunctionName),
        Types = new Guid[2]
        {
          ReferenceOnEntityTypeDecription.UID,
          ReferenceOnEntityTypeDecription.TypeUid_UID
        }
      }
    };

    public ReferenceOnEntityTypeQueryResult()
    {
      ReferenceOnEntityTypeQueryResult.Mjcxg2Gyls2HAdWL2un3();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool CbO5vcGy7kxWwg7oMOP1() => ReferenceOnEntityTypeQueryResult.owwiVAGyAeBSKWono8Ld == null;

    internal static ReferenceOnEntityTypeQueryResult UjWDDgGyx0QS0gN9wdyW() => ReferenceOnEntityTypeQueryResult.owwiVAGyAeBSKWono8Ld;

    internal static object x0xpn1Gy0S8ooB7DEvsL(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool xdNYSQGymFXqBxqm54bS([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static bool r0VdrAGyytlCj7QlqUiM([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 != (PropertyInfo) obj1;

    internal static Type uPHCiTGyMS5IpSiBoHE8([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static Type plZ0XYGyJKcxbPa7XEO4([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static void ztCOu5Gy93ZX8XSKVQR1([In] object obj0, Guid value) => ((ReferenceOnEntityType) obj0).TypeUid = value;

    internal static Guid GAJ916GydJRw77PSmJUt([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static void Mjcxg2Gyls2HAdWL2un3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
