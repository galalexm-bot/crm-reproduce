// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.TypeHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Helpers
{
  /// <summary>
  /// A Utility class used to merge the properties of
  /// heterogenious objects
  /// </summary>
  public class TypeHelper
  {
    private static AssemblyBuilder asmBuilder;
    private static ModuleBuilder modBuilder;
    private static IDictionary<string, Type> anonymousTypes;
    private static object _syncLock;
    internal static TypeHelper KF07oOhzL6vYV5ch3u91;

    /// <summary>
    /// Merge two different object instances into a single
    /// object which is a super-set
    /// of the properties of both objects
    /// </summary>
    public static object MergeTypes(object values1, object values2)
    {
      int num1 = 2;
      bool lockTaken;
      object syncLock;
      while (true)
      {
        switch (num1)
        {
          case 1:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
            continue;
          case 2:
            syncLock = TypeHelper._syncLock;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            goto label_4;
        }
      }
label_2:
      object obj;
      return obj;
label_4:
      try
      {
        Monitor.Enter(syncLock, ref lockTaken);
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
          num2 = 0;
        string str;
        PropertyDescriptor[] properties;
        Type type;
        object instance;
        while (true)
        {
          switch (num2)
          {
            case 1:
              str = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479581520), (object) values1.GetType().AssemblyQualifiedName, (object) values2.GetType().AssemblyQualifiedName);
              num2 = 2;
              continue;
            case 2:
              instance = TypeHelper.CreateInstance((object) str, values1, values2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 7;
              continue;
            case 3:
              TypeHelper.jh4SiThzcs2NL2GUkFlO();
              num2 = 5;
              continue;
            case 4:
            case 10:
              properties = TypeHelper.GetProperties(values1, values2);
              num2 = 3;
              continue;
            case 5:
              type = TypeHelper.VmgacVhzzSRxRrBg19Zk((object) str, (object) properties);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
              continue;
            case 6:
            case 8:
              goto label_2;
            case 7:
              if (instance == null)
              {
                num2 = 10;
                continue;
              }
              goto case 11;
            case 9:
              obj = TypeHelper.iOCYwIGFFFMkSbNl61h4((object) str, values1, values2);
              num2 = 8;
              continue;
            case 11:
              obj = instance;
              num2 = 6;
              continue;
            default:
              TypeHelper.anonymousTypes.Add(str, type);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 9 : 1;
              continue;
          }
        }
      }
      finally
      {
        int num3;
        if (!lockTaken)
          num3 = 2;
        else
          goto label_21;
label_20:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_21:
        TypeHelper.AJgQtIGFBbjnXgEyuUnk(syncLock);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
        {
          num3 = 1;
          goto label_20;
        }
        else
          goto label_20;
      }
    }

    private static object CreateInstance(object name, object values1, object values2)
    {
      int num1 = 10;
      object instance;
      object syncLock;
      bool lockTaken;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          Type anonymousType;
          object[] objArray;
          switch (num2)
          {
            case 1:
            case 7:
              goto label_22;
            case 2:
              goto label_19;
            case 3:
              if (!TypeHelper.f5R1BZGFopyRT0PQIIG4(anonymousType, (Type) null))
              {
                num2 = 7;
                continue;
              }
              break;
            case 4:
            case 6:
              goto label_3;
            case 5:
              anonymousType = TypeHelper.anonymousTypes[(string) name];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 3;
              continue;
            case 8:
              objArray = (object[]) TypeHelper.rWxxakGFWRAZsdUYVoBj(values1, values2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 5;
              continue;
            case 9:
              if (TypeHelper.anonymousTypes.ContainsKey((string) name))
              {
                num2 = 8;
                continue;
              }
              goto label_3;
            case 10:
              instance = (object) null;
              num2 = 9;
              continue;
            case 11:
              goto label_4;
          }
          instance = TypeHelper.l3XsrmGFbdSyhiTfojIZ(anonymousType, (object) objArray);
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 6 : 2;
        }
label_19:
        lockTaken = false;
        num1 = 11;
        continue;
label_22:
        syncLock = TypeHelper._syncLock;
        num1 = 2;
      }
label_3:
      return instance;
label_4:
      try
      {
        Monitor.Enter(syncLock, ref lockTaken);
        int num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 1:
              TypeHelper.anonymousTypes.Remove((string) name);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
      }
      finally
      {
        int num4;
        if (!lockTaken)
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
        else
          goto label_11;
label_10:
        switch (num4)
        {
          case 1:
            break;
          default:
        }
label_11:
        TypeHelper.AJgQtIGFBbjnXgEyuUnk(syncLock);
        num4 = 2;
        goto label_10;
      }
    }

    /// <summary>Merge PropertyDescriptors for both objects</summary>
    private static PropertyDescriptor[] GetProperties(object values1, object values2)
    {
      int num1 = 9;
      List<PropertyDescriptor> propertyDescriptorList;
      while (true)
      {
        PropertyDescriptorCollection descriptorCollection1;
        int index;
        int num2;
        PropertyDescriptorCollection descriptorCollection2;
        switch (num1)
        {
          case 1:
          case 7:
            if (num2 >= TypeHelper.skoVDtGFEt9bn2F7fMYm((object) descriptorCollection2))
            {
              num1 = 14;
              continue;
            }
            goto case 6;
          case 2:
          case 4:
            propertyDescriptorList.Add(descriptorCollection1[index]);
            num1 = 5;
            continue;
          case 3:
            descriptorCollection2 = (PropertyDescriptorCollection) TypeHelper.QgCswlGFhdRLb4AT0NY9(values2);
            num1 = 11;
            continue;
          case 5:
            ++index;
            num1 = 12;
            continue;
          case 6:
            propertyDescriptorList.Add((PropertyDescriptor) TypeHelper.HEEJV9GFGCn8Iwl7fH2a((object) descriptorCollection2, num2));
            num1 = 13;
            continue;
          case 8:
            descriptorCollection1 = (PropertyDescriptorCollection) TypeHelper.QgCswlGFhdRLb4AT0NY9(values1);
            num1 = 3;
            continue;
          case 9:
            propertyDescriptorList = new List<PropertyDescriptor>();
            num1 = 8;
            continue;
          case 10:
          case 12:
            if (index < descriptorCollection1.Count)
            {
              num1 = 2;
              continue;
            }
            break;
          case 11:
            index = 0;
            num1 = 10;
            continue;
          case 13:
            ++num2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 1;
            continue;
          case 14:
            goto label_12;
        }
        num2 = 0;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 7 : 5;
      }
label_12:
      return (PropertyDescriptor[]) TypeHelper.S9h2YtGFfhQAl31Q9ujr((object) propertyDescriptorList);
    }

    private static Type[] GetTypes(object pdc)
    {
      int num = 2;
      int index;
      List<Type> typeList;
      while (true)
      {
        switch (num)
        {
          case 1:
            index = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 3 : 2;
            continue;
          case 2:
            typeList = new List<Type>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 1;
            continue;
          case 4:
          case 5:
            typeList.Add(TypeHelper.TDyS4UGFQ0K4PV0r2XhU(pdc[index]));
            num = 6;
            continue;
          case 6:
            ++index;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
            continue;
          case 7:
            goto label_8;
          default:
            if (index < pdc.Length)
            {
              num = 5;
              continue;
            }
            goto label_8;
        }
      }
label_8:
      return (Type[]) TypeHelper.GUZFJgGFC48gs22q4tFh((object) typeList);
    }

    /// <summary>
    /// Merge the values of the two types into an object array
    /// </summary>
    private static object[] MergeValues(object values1, object values2)
    {
      int num1 = 1;
      List<object> objectList;
      while (true)
      {
        int num2 = num1;
        int num3;
        PropertyDescriptorCollection descriptorCollection1;
        int index;
        PropertyDescriptorCollection descriptorCollection2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              descriptorCollection1 = (PropertyDescriptorCollection) TypeHelper.QgCswlGFhdRLb4AT0NY9(values1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
              continue;
            case 2:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 4 : 4;
              continue;
            case 3:
              objectList.Add(TypeHelper.aMyu7EGFvadIEm859v3p(TypeHelper.HEEJV9GFGCn8Iwl7fH2a((object) descriptorCollection1, num3), values1));
              num2 = 8;
              continue;
            case 4:
            case 6:
              if (index >= descriptorCollection2.Count)
              {
                num2 = 7;
                continue;
              }
              goto case 5;
            case 5:
              objectList.Add(TypeHelper.aMyu7EGFvadIEm859v3p((object) descriptorCollection2[index], values2));
              num2 = 9;
              continue;
            case 7:
              goto label_14;
            case 8:
              goto label_3;
            case 9:
              goto label_6;
            case 10:
            case 13:
              if (num3 >= TypeHelper.skoVDtGFEt9bn2F7fMYm((object) descriptorCollection1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 2;
                continue;
              }
              goto case 3;
            case 11:
              num3 = 0;
              num2 = 10;
              continue;
            case 12:
              objectList = new List<object>();
              num2 = 11;
              continue;
            default:
              descriptorCollection2 = (PropertyDescriptorCollection) TypeHelper.QgCswlGFhdRLb4AT0NY9(values2);
              num2 = 12;
              continue;
          }
        }
label_3:
        ++num3;
        num1 = 13;
        continue;
label_6:
        ++index;
        num1 = 6;
      }
label_14:
      return objectList.ToArray();
    }

    /// <summary>Initialize static objects</summary>
    private static void InitializeAssembly()
    {
      int num = 4;
      AssemblyName name;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_6;
          case 1:
            name = new AssemblyName();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 5 : 3;
            continue;
          case 2:
            TypeHelper.asmBuilder = ((AppDomain) TypeHelper.iH5OofGFuIX1I6iyHGWV()).DefineDynamicAssembly(name, AssemblyBuilderAccess.Run);
            num = 6;
            continue;
          case 3:
            goto label_2;
          case 4:
            if (!TypeHelper.TbueKUGF8jyn0HVDNmYC((object) TypeHelper.asmBuilder, (object) null))
            {
              num = 3;
              continue;
            }
            goto case 1;
          case 5:
            name.Name = (string) TypeHelper.NAnPjYGFZpExwlj2xNOy(1470440286 ^ 1470533716);
            num = 2;
            continue;
          case 6:
            TypeHelper.modBuilder = (ModuleBuilder) TypeHelper.uGqs1TGFIfG4ANe0Pntq((object) TypeHelper.asmBuilder, (object) TypeHelper.asmBuilder.GetName().Name, false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
            continue;
          default:
            goto label_10;
        }
      }
label_6:
      return;
label_2:
      return;
label_10:;
    }

    private static Type CreateType(object name, object pdc)
    {
      TypeBuilder typeBuilder = TypeHelper.CreateTypeBuilder(name);
      Type[] types = TypeHelper.GetTypes(pdc);
      FieldBuilder[] fields = (FieldBuilder[]) TypeHelper.sM3Zi7GFVuudTC6GpO0A((object) typeBuilder, pdc);
      TypeHelper.BuildCtor((object) typeBuilder, (object) fields, (object) types);
      TypeHelper.fmAy1TGFSTfcDv6IeXKN((object) typeBuilder, (object) fields);
      return typeBuilder.CreateType();
    }

    private static TypeBuilder CreateTypeBuilder(object typeName) => TypeHelper.modBuilder.DefineType((string) typeName, TypeAttributes.Public, TypeHelper.S42anWGFiZBRb01ImpGR(__typeref (object)));

    private static void BuildCtor(object typeBuilder, object fields, object types)
    {
      int num = 1;
      ILGenerator ilGenerator;
      int index;
      while (true)
      {
        switch (num)
        {
          case 1:
            ilGenerator = (ILGenerator) TypeHelper.zKh0oNGFqSU2GPghw7ne(TypeHelper.h8QHWeGFRrg4K4oDROal(typeBuilder, MethodAttributes.Public, CallingConventions.Standard, types));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
            continue;
          case 2:
          case 8:
            ilGenerator.Emit(OpCodes.Ldarg_0);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 9 : 7;
            continue;
          case 3:
            ++index;
            num = 10;
            continue;
          case 4:
            TypeHelper.HdGXWnGFTp7Nj2a2ebli((object) ilGenerator, OpCodes.Ret);
            num = 7;
            continue;
          case 5:
            TypeHelper.tqq5g9GFX8u4ljxyBBkY((object) ilGenerator, OpCodes.Stfld, fields[index]);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 3 : 2;
            continue;
          case 6:
          case 10:
            if (index < fields.Length)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 2;
              continue;
            }
            goto case 4;
          case 7:
            goto label_11;
          case 9:
            TypeHelper.JYAg9lGFK3Pake0AiEmy((object) ilGenerator, OpCodes.Ldarg, index + 1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 5 : 5;
            continue;
          default:
            index = 0;
            num = 6;
            continue;
        }
      }
label_11:;
    }

    private static FieldBuilder[] BuildFields(object typeBuilder, object pdc)
    {
      int num = 6;
      List<FieldBuilder> fieldBuilderList;
      FieldBuilder fieldBuilder;
      int index;
      PropertyDescriptor propertyDescriptor;
      while (true)
      {
        switch (num)
        {
          case 1:
            fieldBuilder = (FieldBuilder) TypeHelper.gc70uvGFnEx60yacllb3(typeBuilder, (object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317778334), TypeHelper.v9wUF3GFkqphlWJHvHGx((object) propertyDescriptor)), propertyDescriptor.PropertyType, FieldAttributes.Private);
            num = 2;
            continue;
          case 2:
            if (!fieldBuilderList.Contains(fieldBuilder))
            {
              num = 7;
              continue;
            }
            goto case 10;
          case 3:
          case 9:
            propertyDescriptor = (PropertyDescriptor) pdc[index];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
            continue;
          case 4:
            goto label_7;
          case 5:
            index = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
            continue;
          case 6:
            fieldBuilderList = new List<FieldBuilder>();
            num = 5;
            continue;
          case 7:
            fieldBuilderList.Add(fieldBuilder);
            num = 10;
            continue;
          case 10:
            ++index;
            num = 8;
            continue;
          default:
            if (index < pdc.Length)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 9 : 7;
              continue;
            }
            goto label_7;
        }
      }
label_7:
      return (FieldBuilder[]) TypeHelper.F5SgxJGFOCXHlRyWui6N((object) fieldBuilderList);
    }

    private static void BuildProperties(object typeBuilder, object fields)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        int index;
        string name;
        while (true)
        {
          switch (num2)
          {
            case 1:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_9;
            case 4:
            case 7:
              name = (string) TypeHelper.oUvM2iGFe5bg8b3dsUxX(TypeHelper.LtfXarGF24LryskKRebh(fields[index]), 1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 2 : 2;
              continue;
            case 5:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 3 : 3;
              continue;
            case 6:
              goto label_10;
            default:
              if (index < fields.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 7 : 4;
                continue;
              }
              goto label_6;
          }
        }
label_9:
        PropertyBuilder propertyBuilder = ((TypeBuilder) typeBuilder).DefineProperty(name, PropertyAttributes.None, TypeHelper.SMnEoZGFPnS527gH7ILt(fields[index]), (Type[]) null);
        MethodBuilder methodBuilder1 = (MethodBuilder) TypeHelper.RehnxJGFNPrZ9yF5LIcF(typeBuilder, TypeHelper.K7SZ0QGF1lqYIfuC1kfQ(TypeHelper.NAnPjYGFZpExwlj2xNOy(-1839087379 - 334718690 ^ 2121132337), (object) name), MethodAttributes.Public, ((FieldInfo) fields[index]).FieldType, (object) Type.EmptyTypes);
        ILGenerator ilGenerator = methodBuilder1.GetILGenerator();
        TypeHelper.HdGXWnGFTp7Nj2a2ebli((object) ilGenerator, OpCodes.Ldarg_0);
        TypeHelper.tqq5g9GFX8u4ljxyBBkY((object) ilGenerator, OpCodes.Ldfld, fields[index]);
        TypeHelper.HdGXWnGFTp7Nj2a2ebli((object) ilGenerator, OpCodes.Ret);
        MethodBuilder methodBuilder2 = methodBuilder1;
        TypeHelper.XOceIBGF36ZyJUxU3w8o((object) propertyBuilder, (object) methodBuilder2);
        num1 = 5;
      }
label_10:
      return;
label_6:;
    }

    /// <summary>
    /// [ <c>public static T GetDefault&lt; T &gt;()</c> ]
    /// <para></para>
    /// Retrieves the default value for a given Type
    /// </summary>
    /// <typeparam name="T">The Type for which to get the default value</typeparam>
    /// <returns>The default value for Type T</returns>
    /// <remarks>
    /// If a reference Type or a System.Void Type is supplied, this method always returns null.  If a value type
    /// is supplied which is not publicly visible or which contains generic parameters, this method will fail with an
    /// exception.
    /// </remarks>
    /// <seealso cref="M:EleWise.ELMA.Helpers.TypeHelper.GetDefault(System.Type)" />
    public static T GetDefault<T>() => (T) TypeHelper.GetDefault(typeof (T));

    /// <summary>
    /// [ <c>public static object GetDefault(Type type)</c> ]
    /// <para></para>
    /// Retrieves the default value for a given Type
    /// </summary>
    /// <param name="type">The Type for which to get the default value</param>
    /// <returns>The default value for <paramref name="type" /></returns>
    /// <remarks>
    /// If a null Type, a reference Type, or a System.Void Type is supplied, this method always returns null.  If a value type
    /// is supplied which is not publicly visible or which contains generic parameters, this method will fail with an
    /// exception.
    /// </remarks>
    /// <seealso cref="M:EleWise.ELMA.Helpers.TypeHelper.GetDefault``1" />
    public static object GetDefault(Type type)
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
              if (TypeHelper.KIrXufGFpixQCaHnjHRE(type, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
                continue;
              }
              goto case 10;
            case 3:
            case 7:
              goto label_22;
            case 5:
              goto label_15;
            case 6:
              goto label_5;
            case 8:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 5;
              continue;
            case 9:
              if (type.IsNotPublic)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 7 : 1;
                continue;
              }
              goto case 8;
            case 10:
              if (!type.IsValueType)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 2 : 2;
                continue;
              }
              goto case 11;
            case 11:
              // ISSUE: type reference
              if (!TypeHelper.KIrXufGFpixQCaHnjHRE(type, TypeHelper.S42anWGFiZBRb01ImpGR(__typeref (void))))
              {
                if (!type.ContainsGenericParameters)
                {
                  if (!type.IsPrimitive)
                  {
                    num2 = 9;
                    continue;
                  }
                  goto case 8;
                }
                else
                {
                  num2 = 6;
                  continue;
                }
              }
              else
                goto label_11;
            default:
              goto label_12;
          }
        }
label_11:
        num1 = 4;
      }
label_5:
      throw new ArgumentException((string) TypeHelper.eyZEQ1GFanmffEV3yiPm((object) new object[5]
      {
        TypeHelper.NAnPjYGFZpExwlj2xNOy(1642859704 ^ 1642858308),
        (object) MethodBase.GetCurrentMethod(),
        (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 133146227),
        (object) type,
        TypeHelper.NAnPjYGFZpExwlj2xNOy(-1824388195 ^ -1824409589)
      }));
label_12:
      return (object) null;
label_15:
      object obj;
      try
      {
        obj = TypeHelper.b2qGpIGFDWgCl634Bcx2(type);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
          num3 = 0;
        switch (num3)
        {
        }
      }
      catch (Exception ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
          num4 = 0;
        switch (num4)
        {
          default:
            throw new ArgumentException((string) TypeHelper.eyZEQ1GFanmffEV3yiPm((object) new object[7]
            {
              TypeHelper.NAnPjYGFZpExwlj2xNOy(-345420348 ^ -345422280),
              TypeHelper.Gv4JttGFtQuNnN9hT3VX(),
              TypeHelper.NAnPjYGFZpExwlj2xNOy(1218962250 ^ 1218729826),
              (object) type,
              TypeHelper.NAnPjYGFZpExwlj2xNOy(~541731958 ^ -541694335),
              TypeHelper.B8xJY1GFwwv03uNBKIPF((object) ex),
              TypeHelper.NAnPjYGFZpExwlj2xNOy(-70007027 ^ -70225333)
            }), ex);
        }
      }
      return obj;
label_22:
      throw new ArgumentException((string) TypeHelper.eyZEQ1GFanmffEV3yiPm((object) new object[5]
      {
        TypeHelper.NAnPjYGFZpExwlj2xNOy(572119659 - -337058038 ^ 909179037),
        TypeHelper.Gv4JttGFtQuNnN9hT3VX(),
        (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108804740),
        (object) type,
        TypeHelper.NAnPjYGFZpExwlj2xNOy(-1487388570 ^ -1487145688)
      }));
    }

    /// <summary>Если ствойство в типе</summary>
    /// <param name="type"></param>
    /// <param name="name"></param>
    /// <returns></returns>
    public static bool HasProperty(Type type, string name) => TypeHelper.dy20bBGF4oJflWxba2Gu((object) type.GetReflectionProperty(name), (object) null);

    public TypeHelper()
    {
      TypeHelper.JhQq56GF6iU5guYn5SWS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static TypeHelper()
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            TypeHelper.modBuilder = (ModuleBuilder) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            TypeHelper._syncLock = new object();
            num = 2;
            continue;
          case 4:
            TypeHelper.asmBuilder = (AssemblyBuilder) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 0;
            continue;
          case 5:
            TypeHelper.JhQq56GF6iU5guYn5SWS();
            num = 4;
            continue;
          default:
            TypeHelper.anonymousTypes = (IDictionary<string, Type>) new Dictionary<string, Type>();
            num = 3;
            continue;
        }
      }
label_2:;
    }

    internal static void jh4SiThzcs2NL2GUkFlO() => TypeHelper.InitializeAssembly();

    internal static Type VmgacVhzzSRxRrBg19Zk([In] object obj0, [In] object obj1) => TypeHelper.CreateType(obj0, obj1);

    internal static object iOCYwIGFFFMkSbNl61h4([In] object obj0, [In] object obj1, [In] object obj2) => TypeHelper.CreateInstance(obj0, obj1, obj2);

    internal static void AJgQtIGFBbjnXgEyuUnk([In] object obj0) => Monitor.Exit(obj0);

    internal static bool DW9UvGhzUQEU2lUcwvS4() => TypeHelper.KF07oOhzL6vYV5ch3u91 == null;

    internal static TypeHelper TjSYNmhzseqZcfA4Ef0D() => TypeHelper.KF07oOhzL6vYV5ch3u91;

    internal static object rWxxakGFWRAZsdUYVoBj([In] object obj0, [In] object obj1) => (object) TypeHelper.MergeValues(obj0, obj1);

    internal static bool f5R1BZGFopyRT0PQIIG4([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object l3XsrmGFbdSyhiTfojIZ([In] Type obj0, [In] object obj1) => Activator.CreateInstance(obj0, (object[]) obj1);

    internal static object QgCswlGFhdRLb4AT0NY9([In] object obj0) => (object) TypeDescriptor.GetProperties(obj0);

    internal static object HEEJV9GFGCn8Iwl7fH2a([In] object obj0, [In] int obj1) => (object) ((PropertyDescriptorCollection) obj0)[obj1];

    internal static int skoVDtGFEt9bn2F7fMYm([In] object obj0) => ((PropertyDescriptorCollection) obj0).Count;

    internal static object S9h2YtGFfhQAl31Q9ujr([In] object obj0) => (object) ((List<PropertyDescriptor>) obj0).ToArray();

    internal static Type TDyS4UGFQ0K4PV0r2XhU([In] object obj0) => ((PropertyDescriptor) obj0).PropertyType;

    internal static object GUZFJgGFC48gs22q4tFh([In] object obj0) => (object) ((List<Type>) obj0).ToArray();

    internal static object aMyu7EGFvadIEm859v3p([In] object obj0, [In] object obj1) => ((PropertyDescriptor) obj0).GetValue(obj1);

    internal static bool TbueKUGF8jyn0HVDNmYC([In] object obj0, [In] object obj1) => (Assembly) obj0 == (Assembly) obj1;

    internal static object NAnPjYGFZpExwlj2xNOy(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object iH5OofGFuIX1I6iyHGWV() => (object) Thread.GetDomain();

    internal static object uGqs1TGFIfG4ANe0Pntq([In] object obj0, [In] object obj1, [In] bool obj2) => (object) ((AssemblyBuilder) obj0).DefineDynamicModule((string) obj1, obj2);

    internal static object sM3Zi7GFVuudTC6GpO0A([In] object obj0, [In] object obj1) => (object) TypeHelper.BuildFields(obj0, obj1);

    internal static void fmAy1TGFSTfcDv6IeXKN([In] object obj0, [In] object obj1) => TypeHelper.BuildProperties(obj0, obj1);

    internal static Type S42anWGFiZBRb01ImpGR([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object h8QHWeGFRrg4K4oDROal(
      [In] object obj0,
      [In] MethodAttributes obj1,
      [In] CallingConventions obj2,
      [In] object obj3)
    {
      return (object) ((TypeBuilder) obj0).DefineConstructor(obj1, obj2, (Type[]) obj3);
    }

    internal static object zKh0oNGFqSU2GPghw7ne([In] object obj0) => (object) ((ConstructorBuilder) obj0).GetILGenerator();

    internal static void JYAg9lGFK3Pake0AiEmy([In] object obj0, [In] OpCode obj1, [In] int obj2) => ((ILGenerator) obj0).Emit(obj1, obj2);

    internal static void tqq5g9GFX8u4ljxyBBkY([In] object obj0, [In] OpCode obj1, [In] object obj2) => ((ILGenerator) obj0).Emit(obj1, (FieldInfo) obj2);

    internal static void HdGXWnGFTp7Nj2a2ebli([In] object obj0, [In] OpCode obj1) => ((ILGenerator) obj0).Emit(obj1);

    internal static object v9wUF3GFkqphlWJHvHGx([In] object obj0) => (object) ((MemberDescriptor) obj0).Name;

    internal static object gc70uvGFnEx60yacllb3(
      [In] object obj0,
      [In] object obj1,
      [In] Type obj2,
      [In] FieldAttributes obj3)
    {
      return (object) ((TypeBuilder) obj0).DefineField((string) obj1, obj2, obj3);
    }

    internal static object F5SgxJGFOCXHlRyWui6N([In] object obj0) => (object) ((List<FieldBuilder>) obj0).ToArray();

    internal static object LtfXarGF24LryskKRebh([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object oUvM2iGFe5bg8b3dsUxX([In] object obj0, [In] int obj1) => (object) ((string) obj0).Substring(obj1);

    internal static Type SMnEoZGFPnS527gH7ILt([In] object obj0) => ((FieldInfo) obj0).FieldType;

    internal static object K7SZ0QGF1lqYIfuC1kfQ([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object RehnxJGFNPrZ9yF5LIcF(
      [In] object obj0,
      [In] object obj1,
      [In] MethodAttributes obj2,
      [In] Type obj3,
      [In] object obj4)
    {
      return (object) ((TypeBuilder) obj0).DefineMethod((string) obj1, obj2, obj3, (Type[]) obj4);
    }

    internal static void XOceIBGF36ZyJUxU3w8o([In] object obj0, [In] object obj1) => ((PropertyBuilder) obj0).SetGetMethod((MethodBuilder) obj1);

    internal static bool KIrXufGFpixQCaHnjHRE([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object eyZEQ1GFanmffEV3yiPm([In] object obj0) => (object) string.Concat((object[]) obj0);

    internal static object b2qGpIGFDWgCl634Bcx2([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static object Gv4JttGFtQuNnN9hT3VX() => (object) MethodBase.GetCurrentMethod();

    internal static object B8xJY1GFwwv03uNBKIPF([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static bool dy20bBGF4oJflWxba2Gu([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 != (PropertyInfo) obj1;

    internal static void JhQq56GF6iU5guYn5SWS() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
