// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueryFunctionResults.EnumQueryResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions.QueryFunctionResults
{
  [Component]
  public class EnumQueryResult : IQueryFunctionResult, IEQLFunction
  {
    internal static EnumQueryResult oTHo5mGMJhSkW8xTyQ4a;

    public string FunctionName => (string) EnumQueryResult.N1ga1NGMl5hFt7S4TJj2(1199946765 ^ 1199684269);

    public object GetValue(EntityMetadata metadata, string propName, object[] parameters)
    {
      int num1 = 11;
      TypeConverter typeConverter;
      Type c;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          PropertyInfo propertyInfo;
          Type type;
          switch (num2)
          {
            case 1:
              typeConverter = EnumQueryResult.rEQg61GMs2rIyblZp1yC(typeof (EnumBaseConverter<>).MakeGenericType(c)) as TypeConverter;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
              continue;
            case 2:
              propertyInfo = (PropertyInfo) EnumQueryResult.WAfNGUGMg4tbQvn2PvVl(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(EnumQueryResult.fldgCYGMrgEGrS0spumh((object) metadata)), (object) propName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 9 : 1;
              continue;
            case 3:
              if (!EnumQueryResult.qVAZTGGMjSPVxiE6JSSX((object) propertyInfo).IsNullableType())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 10 : 15;
                continue;
              }
              type = EnumQueryResult.qVAZTGGMjSPVxiE6JSSX((object) propertyInfo).GetNonNullableType();
              break;
            case 4:
            case 14:
              if (EnumQueryResult.FOaDERGMYPLBD0w0vkV6(c, (Type) null))
              {
                num2 = 5;
                continue;
              }
              goto label_31;
            case 5:
              // ISSUE: type reference
              if (EnumQueryResult.kpaESdGMLIogg8AZn4ct(__typeref (EnumBase)).IsAssignableFrom(c))
                goto case 1;
              else
                goto label_19;
            case 6:
              // ISSUE: type reference
              if (!EnumQueryResult.kpaESdGMLIogg8AZn4ct(__typeref (Enum)).IsAssignableFrom(c))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 14 : 9;
                continue;
              }
              goto label_22;
            case 7:
              goto label_22;
            case 8:
              if (!EnumQueryResult.FOaDERGMYPLBD0w0vkV6(c, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 2 : 4;
                continue;
              }
              goto case 6;
            case 9:
              if (EnumQueryResult.HC6QtnGM5J8FC9uh6Z5y((object) propertyInfo, (object) null))
              {
                num2 = 16;
                continue;
              }
              goto case 3;
            case 10:
              if (parameters[0] is string)
              {
                num2 = 2;
                continue;
              }
              goto label_31;
            case 11:
              if (parameters.Length == 1)
              {
                num2 = 10;
                continue;
              }
              goto label_31;
            case 12:
              goto label_31;
            case 13:
              goto label_12;
            case 15:
              type = EnumQueryResult.qVAZTGGMjSPVxiE6JSSX((object) propertyInfo);
              break;
            case 16:
              type = (Type) null;
              break;
            default:
              if (typeConverter == null)
              {
                num2 = 13;
                continue;
              }
              goto label_29;
          }
          c = type;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 8 : 8;
        }
label_19:
        num1 = 12;
      }
label_12:
      Guid guid = Guid.Empty;
      goto label_30;
label_22:
      return (object) (int) EnumQueryResult.FKSuwPGMUiAyHvC2o2KM(c, (object) (string) parameters[0]);
label_29:
      guid = EnumQueryResult.n9kXhVGMzmyfjgu8EMkc((object) (EnumBase) EnumQueryResult.mvO29AGMcX7BTrMEoXva((object) typeConverter, (object) (string) parameters[0]));
label_30:
      return (object) guid;
label_31:
      throw new ArgumentException();
    }

    public IEnumerable<EQLFunction> GetEqlFunctions() => (IEnumerable<EQLFunction>) new EQLFunction[1]
    {
      new EQLFunction()
      {
        DisplayName = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195798933), (object) this.FunctionName, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137722838))),
        Description = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105363376)),
        Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281583484), (object) this.FunctionName),
        Types = new Guid[1]{ EnumDescriptor.UID }
      }
    };

    public EnumQueryResult()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object N1ga1NGMl5hFt7S4TJj2(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool keivJUGM9TQnbLajpqqj() => EnumQueryResult.oTHo5mGMJhSkW8xTyQ4a == null;

    internal static EnumQueryResult Fm2mHfGMdlI4LhODjIF2() => EnumQueryResult.oTHo5mGMJhSkW8xTyQ4a;

    internal static Guid fldgCYGMrgEGrS0spumh([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object WAfNGUGMg4tbQvn2PvVl(Type type, [In] object obj1) => (object) type.GetReflectionProperty((string) obj1);

    internal static bool HC6QtnGM5J8FC9uh6Z5y([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static Type qVAZTGGMjSPVxiE6JSSX([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static bool FOaDERGMYPLBD0w0vkV6([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static Type kpaESdGMLIogg8AZn4ct([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object FKSuwPGMUiAyHvC2o2KM([In] Type obj0, [In] object obj1) => Enum.Parse(obj0, (string) obj1);

    internal static object rEQg61GMs2rIyblZp1yC([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static object mvO29AGMcX7BTrMEoXva([In] object obj0, [In] object obj1) => ((TypeConverter) obj0).ConvertFromInvariantString((string) obj1);

    internal static Guid n9kXhVGMzmyfjgu8EMkc([In] object obj0) => ((EnumBase) obj0).Value;
  }
}
