// Decompiled with JetBrains decompiler
// Type: System.Linq.Dynamic.ClassFactory
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Threading;

namespace System.Linq.Dynamic
{
  internal class ClassFactory
  {
    public static readonly ClassFactory Instance;
    private ModuleBuilder module;
    private Dictionary<Signature, Type> classes;
    private int classCount;
    private ReaderWriterLock rwLock;
    private static ClassFactory YOOd0shF3xyoGr3Y7lu;

    static ClassFactory()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ClassFactory.Instance = new ClassFactory();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    private ClassFactory()
    {
      ClassFactory.IZnlaZhoMOxX59Gn69w();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
        num = 1;
      AssemblyName assemblyName;
      AssemblyBuilder assemblyBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            assemblyName = new AssemblyName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633517445));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.rwLock = new ReaderWriterLock();
            num = 2;
            continue;
          case 4:
            this.classes = new Dictionary<Signature, Type>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 3;
            continue;
          case 5:
            this.module = (ModuleBuilder) ClassFactory.gn7J6lhEmCiPeHpgayW((object) assemblyBuilder, ClassFactory.CdGS9ohGH1euuchedQe(1218962250 ^ 1218965252));
            num = 4;
            continue;
          default:
            assemblyBuilder = (AssemblyBuilder) ClassFactory.uZZOlFhhQDfcpPF1p6A(ClassFactory.cEqanehbvabFRsMiCyA(), (object) assemblyName, AssemblyBuilderAccess.Run);
            num = 5;
            continue;
        }
      }
label_3:;
    }

    public Type GetDynamicClass(IEnumerable<DynamicProperty> properties)
    {
      this.rwLock.AcquireReaderLock(-1);
      try
      {
        Signature key = new Signature(properties);
        Type dynamicClass;
        if (!this.classes.TryGetValue(key, out dynamicClass))
        {
          dynamicClass = this.CreateDynamicClass(key.properties);
          this.classes.Add(key, dynamicClass);
        }
        return dynamicClass;
      }
      finally
      {
        this.rwLock.ReleaseReaderLock();
      }
    }

    private Type CreateDynamicClass(DynamicProperty[] properties)
    {
      int num1 = 2;
      LockCookie lockCookie;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            lockCookie = ClassFactory.evTqpxhflBOFQNPOhH9((object) this.rwLock, -1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 1;
            continue;
          default:
            goto label_15;
        }
      }
label_2:
      Type dynamicClass;
      try
      {
        string str = (string) ClassFactory.pUC3p2hQFOSS15iIxjW(ClassFactory.CdGS9ohGH1euuchedQe(-606654180 ^ -606651070), (object) (this.classCount + 1));
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
          num2 = 0;
        TypeBuilder tb;
        FieldInfo[] properties1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              Type type = ClassFactory.NWmmQTh8Ooj2lwKEMEw((object) tb);
              ++this.classCount;
              dynamicClass = type;
              num2 = 3;
              continue;
            case 2:
              this.GenerateGetHashCode(tb, properties1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 1;
              continue;
            case 3:
              goto label_15;
            case 4:
              this.GenerateEquals(tb, properties1);
              num2 = 2;
              continue;
            case 5:
              properties1 = this.GenerateProperties(tb, properties);
              num2 = 4;
              continue;
            default:
              // ISSUE: type reference
              tb = (TypeBuilder) ClassFactory.Bs1yOlhvZxSc6YMvSxR((object) this.module, (object) str, TypeAttributes.Public, ClassFactory.NRYT8AhCZyPuPfSwSGn(__typeref (DynamicClass)));
              num2 = 5;
              continue;
          }
        }
      }
      finally
      {
        this.rwLock.DowngradeFromWriterLock(ref lockCookie);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
label_15:
      return dynamicClass;
    }

    private FieldInfo[] GenerateProperties(TypeBuilder tb, DynamicProperty[] properties)
    {
      int num1 = 1;
      FieldInfo[] properties1;
      while (true)
      {
        int num2 = num1;
        DynamicProperty property;
        FieldBuilder fieldBuilder;
        MethodBuilder mdBuilder;
        PropertyBuilder propertyBuilder;
        MethodBuilder methodBuilder;
        FieldInfo[] fieldInfoArray;
        int index;
        while (true)
        {
          switch (num2)
          {
            case 1:
              fieldInfoArray = (FieldInfo[]) new FieldBuilder[properties.Length];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
              continue;
            case 2:
              properties1[index] = (FieldInfo) fieldBuilder;
              num2 = 14;
              continue;
            case 3:
            case 12:
              property = properties[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 4 : 5;
              continue;
            case 4:
              goto label_7;
            case 5:
              goto label_3;
            case 6:
              object obj1 = ClassFactory.hJbjBqhiM2PKu48rLEX((object) mdBuilder);
              ((ILGenerator) obj1).Emit(OpCodes.Ldarg_0);
              ((ILGenerator) obj1).Emit(OpCodes.Ldarg_1);
              ClassFactory.wOI7QIhq3at4y3asB7D(obj1, OpCodes.Stfld, (object) fieldBuilder);
              ClassFactory.rCxlxNhRTQt0qnL8EQV(obj1, OpCodes.Ret);
              num2 = 15;
              continue;
            case 7:
              goto label_18;
            case 8:
              propertyBuilder = tb.DefineProperty((string) ClassFactory.BhZ0iuhZnTBlKgunFmt((object) property), PropertyAttributes.HasDefault, property.Type, (Type[]) null);
              num2 = 7;
              continue;
            case 9:
              mdBuilder = (MethodBuilder) ClassFactory.uVs3shhSOZxYP1oWfhf((object) tb, (object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475860875) + (string) ClassFactory.BhZ0iuhZnTBlKgunFmt((object) property)), MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName, (Type) null, (object) new Type[1]
              {
                ClassFactory.dB6RxOhIuKesMW6TrZJ((object) property)
              });
              num2 = 6;
              continue;
            case 10:
            case 17:
              goto label_16;
            case 11:
              index = 0;
              num2 = 10;
              continue;
            case 13:
              object obj2 = ClassFactory.hJbjBqhiM2PKu48rLEX((object) methodBuilder);
              ClassFactory.rCxlxNhRTQt0qnL8EQV(obj2, OpCodes.Ldarg_0);
              ClassFactory.wOI7QIhq3at4y3asB7D(obj2, OpCodes.Ldfld, (object) fieldBuilder);
              ClassFactory.rCxlxNhRTQt0qnL8EQV(obj2, OpCodes.Ret);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 3 : 9;
              continue;
            case 14:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 17 : 10;
              continue;
            case 15:
              ClassFactory.Wend0dhK8wL7vaIfFpY((object) propertyBuilder, (object) methodBuilder);
              num2 = 16;
              continue;
            case 16:
              propertyBuilder.SetSetMethod(mdBuilder);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 2 : 2;
              continue;
            default:
              properties1 = fieldInfoArray;
              num2 = 11;
              continue;
          }
        }
label_3:
        fieldBuilder = (FieldBuilder) ClassFactory.SQgiHDhVbHC7Tch2aXg((object) tb, ClassFactory.FExVJshuJnn7pMcwXLq(ClassFactory.CdGS9ohGH1euuchedQe(-1290212282 ^ -644262414 ^ 1786885582), ClassFactory.BhZ0iuhZnTBlKgunFmt((object) property)), ClassFactory.dB6RxOhIuKesMW6TrZJ((object) property), FieldAttributes.Private);
        num1 = 8;
        continue;
label_16:
        if (index < properties.Length)
        {
          num1 = 12;
          continue;
        }
        break;
label_18:
        methodBuilder = (MethodBuilder) ClassFactory.uVs3shhSOZxYP1oWfhf((object) tb, ClassFactory.FExVJshuJnn7pMcwXLq(ClassFactory.CdGS9ohGH1euuchedQe(-1217523399 ^ -1217520199), ClassFactory.BhZ0iuhZnTBlKgunFmt((object) property)), MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName, ClassFactory.dB6RxOhIuKesMW6TrZJ((object) property), (object) Type.EmptyTypes);
        num1 = 13;
      }
label_7:
      return properties1;
    }

    private void GenerateEquals(TypeBuilder tb, FieldInfo[] fields)
    {
      int num1 = 20;
      while (true)
      {
        int num2 = num1;
        ILGenerator ilGenerator;
        Label label;
        int index;
        FieldInfo[] fieldInfoArray;
        FieldInfo fieldInfo;
        LocalBuilder local;
        Type fieldType;
        Type type;
        while (true)
        {
          switch (num2)
          {
            case 1:
              index = 0;
              num2 = 13;
              continue;
            case 2:
              ClassFactory.rCxlxNhRTQt0qnL8EQV((object) ilGenerator, OpCodes.Ret);
              num2 = 17;
              continue;
            case 3:
              ClassFactory.l94FPThnKM93lwu0hpX((object) ilGenerator, label);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 24 : 31;
              continue;
            case 4:
              ilGenerator.Emit(OpCodes.Ldloc, local);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 23 : 19;
              continue;
            case 5:
              fieldType = fieldInfo.FieldType;
              num2 = 27;
              continue;
            case 6:
              ClassFactory.VZje1ZhTv74FC1O4b5I((object) ilGenerator, OpCodes.Ldloc, (object) local);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 3 : 15;
              continue;
            case 7:
              ClassFactory.rCxlxNhRTQt0qnL8EQV((object) ilGenerator, OpCodes.Ret);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
              continue;
            case 8:
              ClassFactory.wOI7QIhq3at4y3asB7D((object) ilGenerator, OpCodes.Ldfld, (object) fieldInfo);
              num2 = 4;
              continue;
            case 9:
            case 13:
              if (index < fieldInfoArray.Length)
              {
                num2 = 21;
                continue;
              }
              goto case 24;
            case 10:
              ClassFactory.E6bs58h2I5H55a0jwrU((object) ilGenerator, OpCodes.Call, (object) type.GetMethod((string) ClassFactory.CdGS9ohGH1euuchedQe(1461625753 ^ 1461628721)), (object) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 14 : 1;
              continue;
            case 11:
              label = ilGenerator.DefineLabel();
              num2 = 16;
              continue;
            case 12:
              fieldInfoArray = fields;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 1;
              continue;
            case 14:
              goto label_28;
            case 15:
              ClassFactory.IBF3bHhk7x2lZeigS6S((object) ilGenerator, OpCodes.Brtrue_S, label);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 30;
              continue;
            case 16:
              goto label_8;
            case 17:
              goto label_35;
            case 18:
            case 21:
              fieldInfo = fieldInfoArray[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 5 : 4;
              continue;
            case 19:
              local = ilGenerator.DeclareLocal((Type) tb);
              num2 = 11;
              continue;
            case 20:
              // ISSUE: type reference
              // ISSUE: type reference
              ilGenerator = ((MethodBuilder) ClassFactory.uVs3shhSOZxYP1oWfhf((object) tb, ClassFactory.CdGS9ohGH1euuchedQe(1242972401 >> 4 ^ 77686935), MethodAttributes.Public | MethodAttributes.Virtual | MethodAttributes.HideBySig, ClassFactory.NRYT8AhCZyPuPfSwSGn(__typeref (bool)), (object) new Type[1]
              {
                ClassFactory.NRYT8AhCZyPuPfSwSGn(__typeref (object))
              })).GetILGenerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 19 : 18;
              continue;
            case 22:
              ClassFactory.rCxlxNhRTQt0qnL8EQV((object) ilGenerator, OpCodes.Ldc_I4_0);
              num2 = 33;
              continue;
            case 23:
              ClassFactory.wOI7QIhq3at4y3asB7D((object) ilGenerator, OpCodes.Ldfld, (object) fieldInfo);
              num2 = 28;
              continue;
            case 24:
              ClassFactory.rCxlxNhRTQt0qnL8EQV((object) ilGenerator, OpCodes.Ldc_I4_1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 2;
              continue;
            case 25:
              ClassFactory.EaE74yhXdXRuJEcajW4((object) ilGenerator, OpCodes.Isinst, (Type) tb);
              num2 = 26;
              continue;
            case 26:
              ilGenerator.Emit(OpCodes.Stloc, local);
              num2 = 6;
              continue;
            case 27:
              type = typeof (EqualityComparer<>).MakeGenericType(fieldType);
              num2 = 32;
              continue;
            case 28:
              goto label_21;
            case 29:
              ClassFactory.IBF3bHhk7x2lZeigS6S((object) ilGenerator, OpCodes.Brtrue_S, label);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 22 : 3;
              continue;
            case 30:
              ilGenerator.Emit(OpCodes.Ldc_I4_0);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 7;
              continue;
            case 31:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 9;
              continue;
            case 32:
              label = ClassFactory.KOIW6phOrYA71d7ryUI((object) ilGenerator);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 4 : 10;
              continue;
            case 33:
              ClassFactory.rCxlxNhRTQt0qnL8EQV((object) ilGenerator, OpCodes.Ret);
              num2 = 3;
              continue;
            default:
              ClassFactory.l94FPThnKM93lwu0hpX((object) ilGenerator, label);
              num2 = 12;
              continue;
          }
        }
label_8:
        ilGenerator.Emit(OpCodes.Ldarg_1);
        num1 = 25;
        continue;
label_21:
        ClassFactory.E6bs58h2I5H55a0jwrU((object) ilGenerator, OpCodes.Callvirt, (object) type.GetMethod((string) ClassFactory.CdGS9ohGH1euuchedQe(1925118608 << 2 ^ -889461032), new Type[2]
        {
          fieldType,
          fieldType
        }), (object) null);
        num1 = 29;
        continue;
label_28:
        ilGenerator.Emit(OpCodes.Ldarg_0);
        num1 = 8;
      }
label_35:;
    }

    private void GenerateGetHashCode(TypeBuilder tb, FieldInfo[] fields)
    {
      int num1 = 15;
      while (true)
      {
        int num2 = num1;
        ILGenerator ilGenerator;
        Type type1;
        Type type2;
        FieldInfo field;
        int index;
        FieldInfo[] fieldInfoArray;
        while (true)
        {
          switch (num2)
          {
            case 1:
              type2 = ClassFactory.Hc3e22hecur3B2vkmKa((object) field);
              num2 = 6;
              continue;
            case 2:
              ClassFactory.rCxlxNhRTQt0qnL8EQV((object) ilGenerator, OpCodes.Ldarg_0);
              num2 = 12;
              continue;
            case 3:
              ClassFactory.E6bs58h2I5H55a0jwrU((object) ilGenerator, OpCodes.Call, (object) type1.GetMethod((string) ClassFactory.CdGS9ohGH1euuchedQe(1304605005 ^ 1304608229)), (object) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 2;
              continue;
            case 4:
              goto label_6;
            case 6:
              goto label_10;
            case 7:
              fieldInfoArray = fields;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 9 : 1;
              continue;
            case 8:
              ilGenerator.Emit(OpCodes.Ret);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 7 : 10;
              continue;
            case 9:
              index = 0;
              num2 = 5;
              continue;
            case 10:
              goto label_13;
            case 11:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
              continue;
            case 12:
              ilGenerator.Emit(OpCodes.Ldfld, field);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 16 : 13;
              continue;
            case 13:
              field = fieldInfoArray[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 1;
              continue;
            case 14:
              ClassFactory.rCxlxNhRTQt0qnL8EQV((object) ilGenerator, OpCodes.Ldc_I4_0);
              num2 = 7;
              continue;
            case 15:
              // ISSUE: type reference
              ilGenerator = (ILGenerator) ClassFactory.hJbjBqhiM2PKu48rLEX(ClassFactory.uVs3shhSOZxYP1oWfhf((object) tb, ClassFactory.CdGS9ohGH1euuchedQe(-710283084 ^ -537863435 ^ 173614723), MethodAttributes.Public | MethodAttributes.Virtual | MethodAttributes.HideBySig, ClassFactory.NRYT8AhCZyPuPfSwSGn(__typeref (int)), (object) Type.EmptyTypes));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 14 : 3;
              continue;
            case 16:
              ClassFactory.E6bs58h2I5H55a0jwrU((object) ilGenerator, OpCodes.Callvirt, (object) type1.GetMethod((string) ClassFactory.CdGS9ohGH1euuchedQe(825385222 ^ 825388484), new Type[1]
              {
                type2
              }), (object) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 4 : 4;
              continue;
            default:
              if (index >= fieldInfoArray.Length)
              {
                num2 = 8;
                continue;
              }
              goto case 13;
          }
        }
label_6:
        ClassFactory.rCxlxNhRTQt0qnL8EQV((object) ilGenerator, OpCodes.Xor);
        num1 = 11;
        continue;
label_10:
        type1 = typeof (EqualityComparer<>).MakeGenericType(type2);
        num1 = 3;
      }
label_13:;
    }

    internal static bool dC0Z5PhBlnfNT7VAoav() => ClassFactory.YOOd0shF3xyoGr3Y7lu == null;

    internal static ClassFactory V1xs4UhW10DI2CMlY2p() => ClassFactory.YOOd0shF3xyoGr3Y7lu;

    internal static void IZnlaZhoMOxX59Gn69w() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object cEqanehbvabFRsMiCyA() => (object) AppDomain.CurrentDomain;

    internal static object uZZOlFhhQDfcpPF1p6A(
      [In] object obj0,
      [In] object obj1,
      [In] AssemblyBuilderAccess obj2)
    {
      return (object) ((AppDomain) obj0).DefineDynamicAssembly((AssemblyName) obj1, obj2);
    }

    internal static object CdGS9ohGH1euuchedQe(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object gn7J6lhEmCiPeHpgayW([In] object obj0, [In] object obj1) => (object) ((AssemblyBuilder) obj0).DefineDynamicModule((string) obj1);

    internal static LockCookie evTqpxhflBOFQNPOhH9([In] object obj0, [In] int obj1) => ((ReaderWriterLock) obj0).UpgradeToWriterLock(obj1);

    internal static object pUC3p2hQFOSS15iIxjW([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static Type NRYT8AhCZyPuPfSwSGn([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object Bs1yOlhvZxSc6YMvSxR(
      [In] object obj0,
      [In] object obj1,
      [In] TypeAttributes obj2,
      [In] Type obj3)
    {
      return (object) ((ModuleBuilder) obj0).DefineType((string) obj1, obj2, obj3);
    }

    internal static Type NWmmQTh8Ooj2lwKEMEw([In] object obj0) => ((TypeBuilder) obj0).CreateType();

    internal static object BhZ0iuhZnTBlKgunFmt([In] object obj0) => (object) ((DynamicProperty) obj0).Name;

    internal static object FExVJshuJnn7pMcwXLq([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static Type dB6RxOhIuKesMW6TrZJ([In] object obj0) => ((DynamicProperty) obj0).Type;

    internal static object SQgiHDhVbHC7Tch2aXg(
      [In] object obj0,
      [In] object obj1,
      [In] Type obj2,
      [In] FieldAttributes obj3)
    {
      return (object) ((TypeBuilder) obj0).DefineField((string) obj1, obj2, obj3);
    }

    internal static object uVs3shhSOZxYP1oWfhf(
      [In] object obj0,
      [In] object obj1,
      [In] MethodAttributes obj2,
      [In] Type obj3,
      [In] object obj4)
    {
      return (object) ((TypeBuilder) obj0).DefineMethod((string) obj1, obj2, obj3, (Type[]) obj4);
    }

    internal static object hJbjBqhiM2PKu48rLEX([In] object obj0) => (object) ((MethodBuilder) obj0).GetILGenerator();

    internal static void rCxlxNhRTQt0qnL8EQV([In] object obj0, [In] OpCode obj1) => ((ILGenerator) obj0).Emit(obj1);

    internal static void wOI7QIhq3at4y3asB7D([In] object obj0, [In] OpCode obj1, [In] object obj2) => ((ILGenerator) obj0).Emit(obj1, (FieldInfo) obj2);

    internal static void Wend0dhK8wL7vaIfFpY([In] object obj0, [In] object obj1) => ((PropertyBuilder) obj0).SetGetMethod((MethodBuilder) obj1);

    internal static void EaE74yhXdXRuJEcajW4([In] object obj0, [In] OpCode obj1, [In] Type obj2) => ((ILGenerator) obj0).Emit(obj1, obj2);

    internal static void VZje1ZhTv74FC1O4b5I([In] object obj0, [In] OpCode obj1, [In] object obj2) => ((ILGenerator) obj0).Emit(obj1, (LocalBuilder) obj2);

    internal static void IBF3bHhk7x2lZeigS6S([In] object obj0, [In] OpCode obj1, [In] Label obj2) => ((ILGenerator) obj0).Emit(obj1, obj2);

    internal static void l94FPThnKM93lwu0hpX([In] object obj0, [In] Label obj1) => ((ILGenerator) obj0).MarkLabel(obj1);

    internal static Label KOIW6phOrYA71d7ryUI([In] object obj0) => ((ILGenerator) obj0).DefineLabel();

    internal static void E6bs58h2I5H55a0jwrU([In] object obj0, [In] OpCode obj1, [In] object obj2, [In] object obj3) => ((ILGenerator) obj0).EmitCall(obj1, (MethodInfo) obj2, (Type[]) obj3);

    internal static Type Hc3e22hecur3B2vkmKa([In] object obj0) => ((FieldInfo) obj0).FieldType;
  }
}
