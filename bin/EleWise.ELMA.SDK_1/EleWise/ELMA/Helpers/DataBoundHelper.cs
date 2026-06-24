// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.DataBoundHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Helpers
{
  public static class DataBoundHelper
  {
    internal static DataBoundHelper dWvTQyGBxqeGubFCYbbP;

    public static bool IsNullableType(this Type theType)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (theType.IsGenericType)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      // ISSUE: type reference
      return theType.GetGenericTypeDefinition().Equals(DataBoundHelper.SmnctMGByi5tICKd0No8(__typeref (Nullable<>)));
label_5:
      return false;
    }

    /// <summary>Можно ли из исходного типа сделать Nullable-тип</summary>
    /// <param name="sourceType">Исходный тип</param>
    /// <returns>True, если можно</returns>
    public static bool CanBeNullableType(this Type sourceType)
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (sourceType.IsGenericType)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
              continue;
            }
            goto label_11;
          case 2:
            goto label_12;
          case 3:
            goto label_2;
          case 4:
            goto label_7;
          case 5:
            if (DataBoundHelper.TRdMpSGBMDUR55hMx8St(sourceType, (Type) null))
            {
              num = 4;
              continue;
            }
            if (!DataBoundHelper.TRdMpSGBMDUR55hMx8St(sourceType, typeof (void)))
            {
              if (!sourceType.IsValueType)
              {
                num = 2;
                continue;
              }
              goto case 1;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 3 : 3;
              continue;
            }
          default:
            goto label_10;
        }
      }
label_2:
      return false;
label_7:
      throw new ArgumentNullException((string) DataBoundHelper.JAEIntGBJhAHOiauBR6x(-477139494 ^ -477284892));
label_10:
      // ISSUE: type reference
      return DataBoundHelper.kwiYjWGB9QOGR9t5xuoc(sourceType.GetGenericTypeDefinition(), DataBoundHelper.SmnctMGByi5tICKd0No8(__typeref (Nullable<>)));
label_11:
      return true;
label_12:
      return false;
    }

    public static Type NullableType(this Type sourceType)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!DataBoundHelper.TRdMpSGBMDUR55hMx8St(sourceType, (Type) null))
              {
                if (!DataBoundHelper.TRdMpSGBMDUR55hMx8St(sourceType, typeof (void)))
                {
                  if (!sourceType.IsValueType)
                  {
                    num2 = 5;
                    continue;
                  }
                  goto case 6;
                }
                else
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 2;
                  continue;
                }
              }
              else
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
                continue;
              }
            case 2:
              goto label_3;
            case 3:
            case 5:
              goto label_16;
            case 4:
              // ISSUE: type reference
              if (sourceType.GetGenericTypeDefinition() == DataBoundHelper.SmnctMGByi5tICKd0No8(__typeref (Nullable<>)))
              {
                num2 = 3;
                continue;
              }
              goto label_15;
            case 6:
              if (sourceType.IsGenericType)
                goto case 4;
              else
                goto label_9;
            case 7:
            case 8:
              goto label_15;
            default:
              goto label_10;
          }
        }
label_9:
        num1 = 7;
      }
label_3:
      return (Type) null;
label_10:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137571340));
label_15:
      return typeof (Nullable<>).MakeGenericType(sourceType);
label_16:
      return sourceType;
    }

    public static object GetValue(object dataSourceObject, string dataPropertyName) => DataBoundHelper.M1QBwNGBd9UUYDvjrLVi(dataSourceObject, (object) dataPropertyName, (Type) null, (object) null);

    public static object GetValue(
      object dataSourceObject,
      string dataPropertyName,
      Type requiredType,
      object defaultValue)
    {
      int num1 = 4;
      object obj1;
      string str;
      object obj2;
      while (true)
      {
        int num2 = num1;
        PropertyInfo property;
        DynamicEntity dynamicEntity;
        PropertyInfo propertyInfo;
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              str = (string) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 7;
              continue;
            case 2:
              goto label_33;
            case 3:
              if (!DataBoundHelper.VEtbBVGBlXTo5wgY3J3u((object) dataPropertyName))
              {
                num3 = DataBoundHelper.FInnhUGBrPjj0KglcQsS((object) dataPropertyName, '.');
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 1;
                continue;
              }
              goto label_50;
            case 4:
              if (dataSourceObject != null)
              {
                num2 = 3;
                continue;
              }
              goto label_48;
            case 5:
              goto label_32;
            case 6:
              if (!DataBoundHelper.sX8NMaGBYYTw8848nqFY((object) propertyInfo, (object) null))
              {
                num2 = 32;
                continue;
              }
              goto label_40;
            case 7:
              if (num3 <= 0)
              {
                num2 = 15;
                continue;
              }
              goto case 14;
            case 8:
              if (!(property != (PropertyInfo) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
                continue;
              }
              goto case 9;
            case 9:
              if (str == null)
              {
                num2 = 11;
                continue;
              }
              goto case 30;
            case 10:
              obj2 = (object) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 31 : 33;
              continue;
            case 11:
              goto label_13;
            case 12:
            case 26:
              if (obj2 == null)
              {
                num2 = 16;
                continue;
              }
              if (str == null)
              {
                if (!DataBoundHelper.TRdMpSGBMDUR55hMx8St(requiredType, (Type) null))
                {
                  num2 = 20;
                  continue;
                }
                goto label_18;
              }
              else
              {
                num2 = 18;
                continue;
              }
            case 13:
              goto label_16;
            case 14:
              str = dataPropertyName.Substring(num3 + 1);
              num2 = 22;
              continue;
            case 15:
            case 36:
              dynamicEntity = dataSourceObject as DynamicEntity;
              num2 = 10;
              continue;
            case 16:
              goto label_25;
            case 17:
              propertyInfo = (PropertyInfo) DataBoundHelper.GILmlHGBjn3ceZvgJJP1(dataSourceObject.GetType(), (object) dataPropertyName);
              num2 = 6;
              continue;
            case 18:
              goto label_19;
            case 19:
              goto label_34;
            case 20:
              if (!requiredType.IsAssignableFrom(obj2.GetType()))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 5 : 13;
                continue;
              }
              goto label_17;
            case 21:
              goto label_40;
            case 22:
              dataPropertyName = (string) DataBoundHelper.wSupl3GBggebGWSg1JJT((object) dataPropertyName, 0, num3);
              num2 = 36;
              continue;
            case 23:
              if (obj1 == null)
              {
                num2 = 25;
                continue;
              }
              goto label_4;
            case 24:
              if (dynamicEntity.GetDynamicMemberNames().Contains<string>(dataPropertyName))
                goto case 27;
              else
                goto label_10;
            case 27:
              // ISSUE: type reference
              property = dataSourceObject.GetType().GetProperty((string) DataBoundHelper.JAEIntGBJhAHOiauBR6x(-345420348 ^ -345422678), new Type[1]
              {
                DataBoundHelper.SmnctMGByi5tICKd0No8(__typeref (string))
              });
              num2 = 8;
              continue;
            case 28:
              goto label_48;
            case 29:
              if (requiredType.IsAssignableFrom(dataSourceObject.GetType()))
              {
                num2 = 2;
                continue;
              }
              goto label_32;
            case 30:
              obj1 = DataBoundHelper.pViHvJGB5T17Cgh4Txne((object) property, dataSourceObject, (object) (object[]) new string[1]
              {
                dataPropertyName
              });
              num2 = 23;
              continue;
            case 31:
              goto label_4;
            case 32:
              obj2 = DataBoundHelper.pViHvJGB5T17Cgh4Txne((object) propertyInfo, dataSourceObject, (object) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 12 : 0;
              continue;
            case 33:
              if (dynamicEntity != null)
              {
                num2 = 24;
                continue;
              }
              goto default;
            case 34:
              if (DataBoundHelper.TRdMpSGBMDUR55hMx8St(requiredType, (Type) null))
              {
                num2 = 19;
                continue;
              }
              goto case 29;
            default:
              if (obj2 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 26 : 26;
                continue;
              }
              goto case 17;
          }
        }
label_10:
        num1 = 35;
        continue;
label_13:
        obj2 = DataBoundHelper.pViHvJGB5T17Cgh4Txne((object) property, dataSourceObject, (object) (object[]) new string[1]
        {
          dataPropertyName
        });
        num1 = 37;
        continue;
label_50:
        num1 = 34;
      }
label_4:
      return DataBoundHelper.M1QBwNGBd9UUYDvjrLVi(obj1, (object) str, requiredType, defaultValue);
label_16:
      return defaultValue;
label_17:
      return obj2;
label_18:
      return obj2;
label_19:
      return DataBoundHelper.M1QBwNGBd9UUYDvjrLVi(obj2, (object) str, requiredType, defaultValue);
label_25:
      return defaultValue;
label_32:
      return defaultValue;
label_33:
      return dataSourceObject;
label_34:
      return dataSourceObject;
label_40:
      return defaultValue;
label_48:
      return defaultValue;
    }

    public static Type GetPropertyType(object dataSourceObject, string dataPropertyName)
    {
      int num1 = 8;
      Type type;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          PropertyInfo propertyInfo;
          string str;
          int num3;
          object obj1;
          object obj2;
          switch (num2)
          {
            case 1:
              goto label_10;
            case 2:
              propertyInfo = (PropertyInfo) DataBoundHelper.GILmlHGBjn3ceZvgJJP1(type, (object) str);
              num2 = 14;
              continue;
            case 3:
              goto label_19;
            case 4:
              obj1 = (object) null;
              goto label_27;
            case 5:
            case 11:
              num3 = DataBoundHelper.FInnhUGBrPjj0KglcQsS((object) dataPropertyName, '.');
              num2 = 16;
              continue;
            case 6:
              obj2 = DataBoundHelper.wSupl3GBggebGWSg1JJT((object) dataPropertyName, 0, num3);
              break;
            case 7:
              if (DataBoundHelper.VEtbBVGBlXTo5wgY3J3u((object) dataPropertyName))
              {
                num2 = 3;
                continue;
              }
              type = dataSourceObject.GetType();
              num2 = 9;
              continue;
            case 8:
              if (dataSourceObject != null)
              {
                num2 = 7;
                continue;
              }
              goto label_19;
            case 9:
            case 15:
              if (!DataBoundHelper.VEtbBVGBlXTo5wgY3J3u((object) dataPropertyName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 10 : 11;
                continue;
              }
              goto label_10;
            case 10:
              obj1 = DataBoundHelper.nqi75pGBLsXYwM6fwtgF((object) dataPropertyName, num3 + 1);
              goto label_27;
            case 12:
              goto label_22;
            case 13:
              obj2 = (object) dataPropertyName;
              break;
            case 14:
              if (!(propertyInfo == (PropertyInfo) null))
              {
                type = DataBoundHelper.RWQJ5CGBUbioY5Qm4dlk((object) propertyInfo);
                num2 = 15;
                continue;
              }
              goto label_4;
            case 16:
              if (num3 > 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 6 : 2;
                continue;
              }
              goto case 13;
            default:
              if (num3 > 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 10 : 2;
                continue;
              }
              goto case 4;
          }
          str = (string) obj2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
          continue;
label_27:
          dataPropertyName = (string) obj1;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 2 : 0;
        }
label_4:
        num1 = 12;
      }
label_10:
      return type;
label_19:
      return (Type) null;
label_22:
      return (Type) null;
    }

    public static void SetValue(object dataSourceObject, string dataPropertyName, object value)
    {
      int num1 = 22;
      while (true)
      {
        int num2 = num1;
        int num3;
        string str;
        object obj1;
        DynamicEntity dynamicEntity;
        PropertyInfo propertyInfo;
        PropertyInfo property;
        object obj2;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_33;
            case 1:
              if (num3 <= 0)
              {
                num2 = 20;
                continue;
              }
              goto case 27;
            case 2:
              goto label_26;
            case 3:
              obj1 = DataBoundHelper.pViHvJGB5T17Cgh4Txne((object) property, dataSourceObject, (object) (object[]) new string[1]
              {
                dataPropertyName
              });
              num2 = 11;
              continue;
            case 4:
              // ISSUE: type reference
              property = dataSourceObject.GetType().GetProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767722859), new Type[1]
              {
                DataBoundHelper.SmnctMGByi5tICKd0No8(__typeref (string))
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 16 : 25;
              continue;
            case 5:
              DataBoundHelper.vhPCgxGBsdV1WO2PT20D((object) propertyInfo, dataSourceObject, value, (object) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 12 : 10;
              continue;
            case 6:
              if (dynamicEntity != null)
              {
                num2 = 10;
                continue;
              }
              goto case 31;
            case 7:
              DataBoundHelper.OWWNA8GBccRRkmM256kq(obj2, (object) str, value);
              num2 = 33;
              continue;
            case 8:
              if (!(propertyInfo == (PropertyInfo) null))
              {
                if (str != null)
                {
                  num2 = 37;
                  continue;
                }
                if (value != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 17 : 30;
                  continue;
                }
                goto case 32;
              }
              else
              {
                num2 = 36;
                continue;
              }
            case 9:
              goto label_47;
            case 10:
              if (!dynamicEntity.GetDynamicMemberNames().Contains<string>(dataPropertyName))
              {
                num2 = 31;
                continue;
              }
              goto case 4;
            case 11:
              if (obj1 != null)
                goto case 28;
              else
                goto label_5;
            case 12:
              goto label_30;
            case 13:
              goto label_21;
            case 14:
              DataBoundHelper.vhPCgxGBsdV1WO2PT20D((object) property, dataSourceObject, value, (object) (object[]) new string[1]
              {
                dataPropertyName
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 6 : 29;
              continue;
            case 15:
              goto label_19;
            case 16:
              num3 = dataPropertyName.IndexOf('.');
              num2 = 17;
              continue;
            case 17:
              str = (string) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 1;
              continue;
            case 18:
              dataPropertyName = (string) DataBoundHelper.wSupl3GBggebGWSg1JJT((object) dataPropertyName, 0, num3);
              num2 = 24;
              continue;
            case 19:
              if (obj2 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
                continue;
              }
              goto case 7;
            case 20:
            case 24:
              dynamicEntity = dataSourceObject as DynamicEntity;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 6 : 4;
              continue;
            case 21:
              if (!DataBoundHelper.VEtbBVGBlXTo5wgY3J3u((object) dataPropertyName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 16 : 12;
                continue;
              }
              goto label_25;
            case 22:
              if (dataSourceObject != null)
              {
                num2 = 21;
                continue;
              }
              goto label_6;
            case 23:
              goto label_50;
            case 25:
              if (!(property != (PropertyInfo) null))
              {
                num2 = 15;
                continue;
              }
              goto case 26;
            case 26:
              if (str != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 3 : 2;
                continue;
              }
              goto case 14;
            case 27:
              str = (string) DataBoundHelper.nqi75pGBLsXYwM6fwtgF((object) dataPropertyName, num3 + 1);
              num2 = 18;
              continue;
            case 28:
              DataBoundHelper.OWWNA8GBccRRkmM256kq(obj1, (object) str, value);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 13 : 10;
              continue;
            case 29:
              goto label_31;
            case 30:
              if (propertyInfo.PropertyType.IsAssignableFrom(value.GetType()))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 5 : 0;
                continue;
              }
              goto label_28;
            case 31:
              propertyInfo = (PropertyInfo) DataBoundHelper.GILmlHGBjn3ceZvgJJP1(dataSourceObject.GetType(), (object) dataPropertyName);
              num2 = 8;
              continue;
            case 32:
              if (DataBoundHelper.RWQJ5CGBUbioY5Qm4dlk((object) propertyInfo).IsAssignableFromNull())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 35 : 11;
                continue;
              }
              goto label_12;
            case 33:
              goto label_14;
            case 34:
              goto label_8;
            case 35:
              propertyInfo.SetValue(dataSourceObject, (object) null, (object[]) null);
              num2 = 9;
              continue;
            case 36:
              goto label_7;
            case 37:
              obj2 = DataBoundHelper.pViHvJGB5T17Cgh4Txne((object) propertyInfo, dataSourceObject, (object) null);
              num2 = 19;
              continue;
            default:
              goto label_13;
          }
        }
label_5:
        num1 = 2;
      }
label_33:
      return;
label_26:
      return;
label_47:
      return;
label_30:
      return;
label_21:
      return;
label_19:
      return;
label_50:
      return;
label_31:
      return;
label_14:
      return;
label_8:
      return;
label_7:
      return;
label_13:
      return;
label_6:
      return;
label_28:
      return;
label_25:
      return;
label_12:;
    }

    internal static Type SmnctMGByi5tICKd0No8([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool I9D3dNGB0JDqXa0GL9XI() => DataBoundHelper.dWvTQyGBxqeGubFCYbbP == null;

    internal static DataBoundHelper uqeLc2GBmBb7UHtQ4Imy() => DataBoundHelper.dWvTQyGBxqeGubFCYbbP;

    internal static bool TRdMpSGBMDUR55hMx8St([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object JAEIntGBJhAHOiauBR6x(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool kwiYjWGB9QOGR9t5xuoc([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object M1QBwNGBd9UUYDvjrLVi(
      [In] object obj0,
      [In] object obj1,
      Type requiredType,
      [In] object obj3)
    {
      return DataBoundHelper.GetValue(obj0, (string) obj1, requiredType, obj3);
    }

    internal static bool VEtbBVGBlXTo5wgY3J3u([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static int FInnhUGBrPjj0KglcQsS([In] object obj0, [In] char obj1) => ((string) obj0).IndexOf(obj1);

    internal static object wSupl3GBggebGWSg1JJT([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static object pViHvJGB5T17Cgh4Txne([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static object GILmlHGBjn3ceZvgJJP1(Type type, [In] object obj1) => (object) type.GetReflectionProperty((string) obj1);

    internal static bool sX8NMaGBYYTw8848nqFY([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static object nqi75pGBLsXYwM6fwtgF([In] object obj0, [In] int obj1) => (object) ((string) obj0).Substring(obj1);

    internal static Type RWQJ5CGBUbioY5Qm4dlk([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static void vhPCgxGBsdV1WO2PT20D([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static void OWWNA8GBccRRkmM256kq([In] object obj0, [In] object obj1, [In] object obj2) => DataBoundHelper.SetValue(obj0, (string) obj1, obj2);
  }
}
