// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.Dynamic.ExposedObject
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions.Dynamic
{
  /// <summary>
  /// Динамический объект позволяющий вызыватье непуюличные методы
  /// http://exposedobject.codeplex.com
  /// </summary>
  public class ExposedObject : DynamicObject
  {
    private object m_object;
    private Type m_type;
    private Dictionary<string, Dictionary<int, List<MethodInfo>>> m_instanceMethods;
    private Dictionary<string, Dictionary<int, List<MethodInfo>>> m_genInstanceMethods;
    internal static ExposedObject kqrndRGxpCS0nmo8DAMl;

    private ExposedObject(object obj)
    {
      ExposedObject.lbuoVPGxttqNRoPFjuqF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated method
            IEnumerable<MethodInfo> source1 = ((IEnumerable<MethodInfo>) this.m_type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)).Where<MethodInfo>((Func<MethodInfo, bool>) (m => !ExposedObject.\u003C\u003Ec.kAmPVb8QJCsQGyyNobTM((object) m)));
            // ISSUE: reference to a compiler-generated field
            Func<MethodInfo, string> func1 = ExposedObject.\u003C\u003Ec.\u003C\u003E9__4_1;
            Func<MethodInfo, string> keySelector1;
            if (func1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              ExposedObject.\u003C\u003Ec.\u003C\u003E9__4_1 = keySelector1 = (Func<MethodInfo, string>) (m => m.Name);
            }
            else
              goto label_6;
label_8:
            IEnumerable<IGrouping<string, MethodInfo>> source2 = source1.GroupBy<MethodInfo, string>(keySelector1);
            // ISSUE: reference to a compiler-generated field
            Func<IGrouping<string, MethodInfo>, Dictionary<int, List<MethodInfo>>> func2 = ExposedObject.\u003C\u003Ec.\u003C\u003E9__4_3;
            Func<IGrouping<string, MethodInfo>, Dictionary<int, List<MethodInfo>>> elementSelector;
            if (func2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              ExposedObject.\u003C\u003Ec.\u003C\u003E9__4_3 = elementSelector = (Func<IGrouping<string, MethodInfo>, Dictionary<int, List<MethodInfo>>>) (p => p.GroupBy<MethodInfo, int>((Func<MethodInfo, int>) (r => ExposedObject.\u003C\u003Ec.CT9cT88Q9ZK6KBVu8j03((object) r).Length)).ToDictionary<IGrouping<int, MethodInfo>, int, List<MethodInfo>>((Func<IGrouping<int, MethodInfo>, int>) (r => r.Key), (Func<IGrouping<int, MethodInfo>, List<MethodInfo>>) (r => r.ToList<MethodInfo>())));
            }
            else
              goto label_12;
label_10:
            this.m_instanceMethods = source2.ToDictionary<IGrouping<string, MethodInfo>, string, Dictionary<int, List<MethodInfo>>>((Func<IGrouping<string, MethodInfo>, string>) (p => p.Key), elementSelector);
            num = 3;
            continue;
label_12:
            elementSelector = func2;
            goto label_10;
label_6:
            keySelector1 = func1;
            goto label_8;
          case 2:
            this.m_type = obj.GetType();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 1;
            continue;
          case 3:
            MethodInfo[] methods = this.m_type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            // ISSUE: reference to a compiler-generated field
            Func<MethodInfo, bool> func3 = ExposedObject.\u003C\u003Ec.\u003C\u003E9__4_4;
            Func<MethodInfo, bool> predicate;
            if (func3 == null)
            {
              // ISSUE: reference to a compiler-generated field
              ExposedObject.\u003C\u003Ec.\u003C\u003E9__4_4 = predicate = (Func<MethodInfo, bool>) (m => m.IsGenericMethod);
            }
            else
              goto label_22;
label_14:
            IEnumerable<MethodInfo> source3 = ((IEnumerable<MethodInfo>) methods).Where<MethodInfo>(predicate);
            // ISSUE: reference to a compiler-generated field
            Func<MethodInfo, string> func4 = ExposedObject.\u003C\u003Ec.\u003C\u003E9__4_5;
            Func<MethodInfo, string> keySelector2;
            if (func4 == null)
            {
              // ISSUE: reference to a compiler-generated field
              ExposedObject.\u003C\u003Ec.\u003C\u003E9__4_5 = keySelector2 = (Func<MethodInfo, string>) (m => m.Name);
            }
            else
              goto label_21;
label_16:
            IEnumerable<IGrouping<string, MethodInfo>> source4 = source3.GroupBy<MethodInfo, string>(keySelector2);
            // ISSUE: reference to a compiler-generated field
            Func<IGrouping<string, MethodInfo>, string> func5 = ExposedObject.\u003C\u003Ec.\u003C\u003E9__4_6;
            Func<IGrouping<string, MethodInfo>, string> keySelector3;
            if (func5 == null)
            {
              // ISSUE: reference to a compiler-generated field
              ExposedObject.\u003C\u003Ec.\u003C\u003E9__4_6 = keySelector3 = (Func<IGrouping<string, MethodInfo>, string>) (p => p.Key);
            }
            else
              goto label_20;
label_19:
            // ISSUE: reference to a compiler-generated method
            this.m_genInstanceMethods = source4.ToDictionary<IGrouping<string, MethodInfo>, string, Dictionary<int, List<MethodInfo>>>(keySelector3, (Func<IGrouping<string, MethodInfo>, Dictionary<int, List<MethodInfo>>>) (p => p.GroupBy<MethodInfo, int>((Func<MethodInfo, int>) (r => ExposedObject.\u003C\u003Ec.CT9cT88Q9ZK6KBVu8j03((object) r).Length)).ToDictionary<IGrouping<int, MethodInfo>, int, List<MethodInfo>>((Func<IGrouping<int, MethodInfo>, int>) (r => r.Key), (Func<IGrouping<int, MethodInfo>, List<MethodInfo>>) (r => r.ToList<MethodInfo>()))));
            num = 4;
            continue;
label_20:
            keySelector3 = func5;
            goto label_19;
label_21:
            keySelector2 = func4;
            goto label_16;
label_22:
            predicate = func3;
            goto label_14;
          case 4:
            goto label_17;
          default:
            this.m_object = obj;
            num = 2;
            continue;
        }
      }
label_17:;
    }

    public object Object => this.m_object;

    public static object New<T>() => ExposedObject.New(typeof (T));

    public static object New(Type type) => (object) new ExposedObject(ExposedObject.Dmc2YBGxwMZSmMNPIT5G(type));

    public static object From(object obj) => (object) new ExposedObject(obj);

    public static T Cast<T>(ExposedObject t) => (T) t.m_object;

    public override bool TryInvokeMember(
      InvokeMemberBinder binder,
      object[] args,
      out object result)
    {
      int num1 = 7;
      Type[] typeArray;
      List<MethodInfo> instanceMethods;
      List<MethodInfo>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
          case 18:
            if (typeArray == null)
            {
              num1 = 13;
              continue;
            }
            goto case 15;
          case 2:
            if (typeArray.Length == 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 3 : 3;
              continue;
            }
            goto case 1;
          case 3:
            typeArray = (Type[]) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 1 : 1;
            continue;
          case 4:
          case 12:
            result = (object) null;
            num1 = 19;
            continue;
          case 5:
            goto label_34;
          case 6:
            if (typeArray == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 18 : 18;
              continue;
            }
            goto case 2;
          case 7:
            typeArray = (Type[]) ExposedObject.xducfiGx4gSffTQQEwJf((object) binder);
            num1 = 6;
            continue;
          case 8:
label_9:
            if (!ExposedObjectHelper.InvokeBestMethod(args, this.m_object, instanceMethods, out result))
            {
              num1 = 4;
              continue;
            }
            goto label_34;
          case 9:
            goto label_14;
          case 10:
            instanceMethods = new List<MethodInfo>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 11;
            continue;
          case 11:
            enumerator = this.m_genInstanceMethods[(string) ExposedObject.jZpDA4Gx6uQ35ZNi3VUe((object) binder)][args.Length].GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 16 : 16;
            continue;
          case 13:
            if (!this.m_instanceMethods.ContainsKey(binder.Name))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 15 : 10;
              continue;
            }
            goto default;
          case 14:
            if (this.m_instanceMethods[binder.Name].ContainsKey(args.Length))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 8 : 10;
              continue;
            }
            goto case 4;
          case 15:
          case 17:
            if (!this.m_instanceMethods.ContainsKey((string) ExposedObject.jZpDA4Gx6uQ35ZNi3VUe((object) binder)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 12 : 7;
              continue;
            }
            goto case 14;
          case 16:
            try
            {
label_23:
              if (enumerator.MoveNext())
                goto label_22;
              else
                goto label_24;
label_18:
              MethodInfo current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    instanceMethods.Add((MethodInfo) ExposedObject.SOpO7bGxATxgLMt3ogvX((object) current, (object) typeArray));
                    num2 = 2;
                    continue;
                  case 2:
                    goto label_23;
                  case 3:
                    goto label_22;
                  case 4:
                    if (ExposedObject.mVMjXhGxHQeGcFnffHKy((object) current).Length == typeArray.Length)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 1;
                      continue;
                    }
                    goto label_23;
                  default:
                    goto label_9;
                }
              }
label_22:
              current = enumerator.Current;
              num2 = 4;
              goto label_18;
label_24:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
              goto label_18;
            }
            finally
            {
              enumerator.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 19:
            goto label_30;
          case 20:
            if (ExposedObjectHelper.InvokeBestMethod(args, this.m_object, this.m_instanceMethods[(string) ExposedObject.jZpDA4Gx6uQ35ZNi3VUe((object) binder)][args.Length], out result))
            {
              num1 = 9;
              continue;
            }
            goto case 15;
          default:
            if (!this.m_instanceMethods[(string) ExposedObject.jZpDA4Gx6uQ35ZNi3VUe((object) binder)].ContainsKey(args.Length))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 17 : 15;
              continue;
            }
            goto case 20;
        }
      }
label_14:
      return true;
label_30:
      return false;
label_34:
      return true;
    }

    public override bool TrySetMember(SetMemberBinder binder, object value)
    {
      int num = 3;
      FieldInfo fieldInfo;
      PropertyInfo propertyInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_10;
          case 2:
            if (ExposedObject.BhuNW1GxxrlNka24Dyo5((object) propertyInfo, (object) null))
            {
              num = 6;
              continue;
            }
            fieldInfo = (FieldInfo) ExposedObject.G94HZ3GxmNTQH6LnJt2v(this.m_type, (object) binder.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 3 : 4;
            continue;
          case 3:
            propertyInfo = (PropertyInfo) ExposedObject.uT0siLGx7VgcZFItKWQK(this.m_type, (object) binder.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 2 : 2;
            continue;
          case 4:
            if (ExposedObject.jqBDKeGxyMkg3IDcs9eb((object) fieldInfo, (object) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 5:
            goto label_5;
          case 6:
            ExposedObject.iCb7wVGx011Lb6pDdTt4((object) propertyInfo, this.m_object, value, (object) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 1 : 1;
            continue;
          default:
            fieldInfo.SetValue(this.m_object, value);
            num = 5;
            continue;
        }
      }
label_5:
      return true;
label_6:
      return false;
label_10:
      return true;
    }

    public override bool TryGetMember(GetMemberBinder binder, out object result)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        FieldInfo fieldInfo;
        PropertyInfo propertyInfo;
        while (true)
        {
          switch (num2)
          {
            case 1:
              result = ExposedObject.B3ZSNIGxJuYtNtK2j1pb((object) propertyInfo, this.m_object, (object) null);
              num2 = 4;
              continue;
            case 2:
              goto label_3;
            case 3:
              if (!(fieldInfo != (FieldInfo) null))
              {
                num2 = 6;
                continue;
              }
              goto case 5;
            case 4:
              goto label_5;
            case 5:
              result = ExposedObject.W1hUQDGx9YbEajYWmQ0M((object) fieldInfo, this.m_object);
              num2 = 2;
              continue;
            case 6:
              result = (object) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
              continue;
            case 7:
              if (ExposedObject.BhuNW1GxxrlNka24Dyo5((object) propertyInfo, (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 1;
                continue;
              }
              goto label_6;
            case 8:
              propertyInfo = (PropertyInfo) ExposedObject.uT0siLGx7VgcZFItKWQK(this.m_object.GetType(), ExposedObject.ndliLfGxMMDUUEUmd3xb((object) binder), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 5 : 7;
              continue;
            default:
              goto label_8;
          }
        }
label_6:
        fieldInfo = (FieldInfo) ExposedObject.G94HZ3GxmNTQH6LnJt2v(this.m_object.GetType(), ExposedObject.ndliLfGxMMDUUEUmd3xb((object) binder), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        num1 = 3;
      }
label_3:
      return true;
label_5:
      return true;
label_8:
      return false;
    }

    public override bool TryConvert(ConvertBinder binder, out object result)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            result = this.m_object;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return true;
    }

    internal static void lbuoVPGxttqNRoPFjuqF() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool tL54svGxaLm5wuZbSokj() => ExposedObject.kqrndRGxpCS0nmo8DAMl == null;

    internal static ExposedObject JHym40GxDgPmdF3Bx1oy() => ExposedObject.kqrndRGxpCS0nmo8DAMl;

    internal static object Dmc2YBGxwMZSmMNPIT5G([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static object xducfiGx4gSffTQQEwJf([In] object obj0) => (object) ExposedObjectHelper.GetTypeArgs((InvokeMemberBinder) obj0);

    internal static object jZpDA4Gx6uQ35ZNi3VUe([In] object obj0) => (object) ((InvokeMemberBinder) obj0).Name;

    internal static object mVMjXhGxHQeGcFnffHKy([In] object obj0) => (object) ((MethodBase) obj0).GetGenericArguments();

    internal static object SOpO7bGxATxgLMt3ogvX([In] object obj0, [In] object obj1) => (object) ((MethodInfo) obj0).MakeGenericMethod((Type[]) obj1);

    internal static object uT0siLGx7VgcZFItKWQK(Type type, [In] object obj1, BindingFlags bindingAttr) => (object) type.GetReflectionProperty((string) obj1, bindingAttr);

    internal static bool BhuNW1GxxrlNka24Dyo5([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 != (PropertyInfo) obj1;

    internal static void iCb7wVGx011Lb6pDdTt4([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static object G94HZ3GxmNTQH6LnJt2v(Type type, [In] object obj1, BindingFlags bindingAttr) => (object) type.GetReflectionField((string) obj1, bindingAttr);

    internal static bool jqBDKeGxyMkg3IDcs9eb([In] object obj0, [In] object obj1) => (FieldInfo) obj0 != (FieldInfo) obj1;

    internal static object ndliLfGxMMDUUEUmd3xb([In] object obj0) => (object) ((GetMemberBinder) obj0).Name;

    internal static object B3ZSNIGxJuYtNtK2j1pb([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static object W1hUQDGx9YbEajYWmQ0M([In] object obj0, [In] object obj1) => ((FieldInfo) obj0).GetValue(obj1);
  }
}
