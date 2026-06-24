// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.Dynamic.ExposedClass
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
  /// Динамический объект, позволяющий вызывать приватные статические методы классов
  /// http://exposedobject.codeplex.com
  /// </summary>
  public class ExposedClass : DynamicObject
  {
    private Type m_type;
    private Dictionary<string, Dictionary<int, List<MethodInfo>>> m_staticMethods;
    private Dictionary<string, Dictionary<int, List<MethodInfo>>> m_genStaticMethods;
    internal static ExposedClass mAyQjGGxVAxfmPReyC95;

    private ExposedClass(Type type)
    {
      ExposedClass.TkUZpWGxRyAVkIXBa09I();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            MethodInfo[] methods = this.m_type.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            // ISSUE: reference to a compiler-generated field
            Func<MethodInfo, bool> func1 = ExposedClass.\u003C\u003Ec.\u003C\u003E9__3_0;
            Func<MethodInfo, bool> predicate;
            if (func1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              ExposedClass.\u003C\u003Ec.\u003C\u003E9__3_0 = predicate = (Func<MethodInfo, bool>) (m => !ExposedClass.\u003C\u003Ec.Ks2gmZ8QAOKaM7n9YnHZ((object) m));
            }
            else
              goto label_21;
label_6:
            // ISSUE: reference to a compiler-generated method
            IEnumerable<IGrouping<string, MethodInfo>> source1 = ((IEnumerable<MethodInfo>) methods).Where<MethodInfo>(predicate).GroupBy<MethodInfo, string>((Func<MethodInfo, string>) (m => (string) ExposedClass.\u003C\u003Ec.fEVxNM8Q75gsjdK6cQVe((object) m)));
            // ISSUE: reference to a compiler-generated field
            Func<IGrouping<string, MethodInfo>, string> func2 = ExposedClass.\u003C\u003Ec.\u003C\u003E9__3_2;
            Func<IGrouping<string, MethodInfo>, string> keySelector1;
            if (func2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              ExposedClass.\u003C\u003Ec.\u003C\u003E9__3_2 = keySelector1 = (Func<IGrouping<string, MethodInfo>, string>) (p => p.Key);
            }
            else
              goto label_20;
label_9:
            // ISSUE: reference to a compiler-generated method
            this.m_staticMethods = source1.ToDictionary<IGrouping<string, MethodInfo>, string, Dictionary<int, List<MethodInfo>>>(keySelector1, (Func<IGrouping<string, MethodInfo>, Dictionary<int, List<MethodInfo>>>) (p => p.GroupBy<MethodInfo, int>((Func<MethodInfo, int>) (r => ExposedClass.\u003C\u003Ec.aD5xCO8Qx1n3pEZiwQbS((object) r).Length)).ToDictionary<IGrouping<int, MethodInfo>, int, List<MethodInfo>>((Func<IGrouping<int, MethodInfo>, int>) (r => r.Key), (Func<IGrouping<int, MethodInfo>, List<MethodInfo>>) (r => r.ToList<MethodInfo>()))));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
            continue;
label_20:
            keySelector1 = func2;
            goto label_9;
label_21:
            predicate = func1;
            goto label_6;
          case 2:
            this.m_type = type;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_17;
          default:
            // ISSUE: reference to a compiler-generated method
            IEnumerable<MethodInfo> source2 = ((IEnumerable<MethodInfo>) this.m_type.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)).Where<MethodInfo>((Func<MethodInfo, bool>) (m => ExposedClass.\u003C\u003Ec.Ks2gmZ8QAOKaM7n9YnHZ((object) m)));
            // ISSUE: reference to a compiler-generated field
            Func<MethodInfo, string> func3 = ExposedClass.\u003C\u003Ec.\u003C\u003E9__3_5;
            Func<MethodInfo, string> keySelector2;
            if (func3 == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              ExposedClass.\u003C\u003Ec.\u003C\u003E9__3_5 = keySelector2 = (Func<MethodInfo, string>) (m => (string) ExposedClass.\u003C\u003Ec.fEVxNM8Q75gsjdK6cQVe((object) m));
            }
            else
              goto label_7;
label_13:
            IEnumerable<IGrouping<string, MethodInfo>> source3 = source2.GroupBy<MethodInfo, string>(keySelector2);
            // ISSUE: reference to a compiler-generated field
            Func<IGrouping<string, MethodInfo>, string> func4 = ExposedClass.\u003C\u003Ec.\u003C\u003E9__3_6;
            Func<IGrouping<string, MethodInfo>, string> keySelector3;
            if (func4 == null)
            {
              // ISSUE: reference to a compiler-generated field
              ExposedClass.\u003C\u003Ec.\u003C\u003E9__3_6 = keySelector3 = (Func<IGrouping<string, MethodInfo>, string>) (p => p.Key);
            }
            else
              goto label_11;
label_16:
            // ISSUE: reference to a compiler-generated field
            Func<IGrouping<string, MethodInfo>, Dictionary<int, List<MethodInfo>>> func5 = ExposedClass.\u003C\u003Ec.\u003C\u003E9__3_7;
            Func<IGrouping<string, MethodInfo>, Dictionary<int, List<MethodInfo>>> elementSelector;
            if (func5 == null)
            {
              // ISSUE: reference to a compiler-generated field
              ExposedClass.\u003C\u003Ec.\u003C\u003E9__3_7 = elementSelector = (Func<IGrouping<string, MethodInfo>, Dictionary<int, List<MethodInfo>>>) (p => p.GroupBy<MethodInfo, int>((Func<MethodInfo, int>) (r => r.GetParameters().Length)).ToDictionary<IGrouping<int, MethodInfo>, int, List<MethodInfo>>((Func<IGrouping<int, MethodInfo>, int>) (r => r.Key), (Func<IGrouping<int, MethodInfo>, List<MethodInfo>>) (r => r.ToList<MethodInfo>())));
            }
            else
              goto label_14;
label_19:
            this.m_genStaticMethods = source3.ToDictionary<IGrouping<string, MethodInfo>, string, Dictionary<int, List<MethodInfo>>>(keySelector3, elementSelector);
            num = 3;
            continue;
label_14:
            elementSelector = func5;
            goto label_19;
label_11:
            keySelector3 = func4;
            goto label_16;
label_7:
            keySelector2 = func3;
            goto label_13;
        }
      }
label_17:;
    }

    public override bool TryInvokeMember(
      InvokeMemberBinder binder,
      object[] args,
      out object result)
    {
      int num1 = 17;
      while (true)
      {
        int num2 = num1;
        Type[] typeArray;
        List<MethodInfo>.Enumerator enumerator;
        List<MethodInfo> instanceMethods;
        while (true)
        {
          switch (num2)
          {
            case 1:
label_40:
              if (!ExposedObjectHelper.InvokeBestMethod(args, (object) null, instanceMethods, out result))
              {
                num2 = 14;
                continue;
              }
              goto label_6;
            case 2:
              if (typeArray.Length != 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 9 : 1;
                continue;
              }
              goto case 7;
            case 3:
              if (ExposedObjectHelper.InvokeBestMethod(args, (object) null, this.m_staticMethods[(string) ExposedClass.XnHbLJGxKZdJ6cIbEtvR((object) binder)][args.Length], out result))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
                continue;
              }
              goto case 19;
            case 4:
            case 9:
              if (typeArray == null)
              {
                num2 = 6;
                continue;
              }
              goto case 19;
            case 5:
              try
              {
label_25:
                if (enumerator.MoveNext())
                  goto label_28;
                else
                  goto label_26;
label_24:
                MethodInfo current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_28;
                    case 2:
                      goto label_40;
                    case 3:
                      instanceMethods.Add((MethodInfo) ExposedClass.PkuA8PGxT70LdN3vwF7j((object) current, (object) typeArray));
                      num3 = 4;
                      continue;
                    case 4:
                      goto label_25;
                    default:
                      if (ExposedClass.HrcQm7GxX4AgrYhEbwx9((object) current).Length == typeArray.Length)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 3 : 2;
                        continue;
                      }
                      goto label_25;
                  }
                }
label_26:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 2;
                goto label_24;
label_28:
                current = enumerator.Current;
                num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
                {
                  num3 = 0;
                  goto label_24;
                }
                else
                  goto label_24;
              }
              finally
              {
                enumerator.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 6:
              if (this.m_staticMethods.ContainsKey(binder.Name))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 5 : 12;
                continue;
              }
              goto case 19;
            case 7:
              typeArray = (Type[]) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 4 : 0;
              continue;
            case 8:
              goto label_6;
            case 10:
              enumerator = this.m_genStaticMethods[(string) ExposedClass.XnHbLJGxKZdJ6cIbEtvR((object) binder)][args.Length].GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 5;
              continue;
            case 11:
              if (!this.m_staticMethods[(string) ExposedClass.XnHbLJGxKZdJ6cIbEtvR((object) binder)].ContainsKey(args.Length))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 15 : 7;
                continue;
              }
              goto case 13;
            case 12:
              if (!this.m_staticMethods[binder.Name].ContainsKey(args.Length))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 19 : 2;
                continue;
              }
              goto case 3;
            case 13:
              instanceMethods = new List<MethodInfo>();
              num2 = 10;
              continue;
            case 14:
            case 15:
              result = (object) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 2 : 18;
              continue;
            case 16:
              if (typeArray != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 2 : 1;
                continue;
              }
              goto case 4;
            case 17:
              goto label_37;
            case 18:
              goto label_36;
            case 19:
              if (this.m_staticMethods.ContainsKey((string) ExposedClass.XnHbLJGxKZdJ6cIbEtvR((object) binder)))
              {
                num2 = 11;
                continue;
              }
              goto case 14;
            default:
              goto label_3;
          }
        }
label_37:
        typeArray = (Type[]) ExposedClass.tnLY5KGxqiKGhB2OdItP((object) binder);
        num1 = 16;
      }
label_3:
      return true;
label_6:
      return true;
label_36:
      return false;
    }

    public override bool TrySetMember(SetMemberBinder binder, object value)
    {
      int num = 5;
      while (true)
      {
        FieldInfo fieldInfo;
        PropertyInfo propertyInfo;
        switch (num)
        {
          case 1:
            goto label_8;
          case 2:
            fieldInfo = (FieldInfo) ExposedClass.LdAUO7GxeIwRtoL1a0Ko(this.m_type, ExposedClass.DprT56Gx2y2JMfGt2E1W((object) binder), BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            num = 6;
            continue;
          case 3:
            ExposedClass.HSXQYKGx1pNOCcCoIfm1((object) fieldInfo, (object) null, value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 1 : 1;
            continue;
          case 4:
            if (!ExposedClass.IjBDwHGxn2D1ucZ7Ri37((object) propertyInfo, (object) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 2 : 2;
              continue;
            }
            break;
          case 5:
            propertyInfo = (PropertyInfo) ExposedClass.VIvaQZGxkhAGq3MuieLU(this.m_type, (object) binder.Name, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            num = 4;
            continue;
          case 6:
            if (ExposedClass.KncENhGxPrvUjmrAxbVg((object) fieldInfo, (object) null))
            {
              num = 3;
              continue;
            }
            goto label_9;
          case 7:
            goto label_2;
        }
        ExposedClass.w736qSGxOvuQOeMQdSW2((object) propertyInfo, (object) null, value, (object) null);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 7 : 1;
      }
label_2:
      return true;
label_8:
      return true;
label_9:
      return false;
    }

    public override bool TryGetMember(GetMemberBinder binder, out object result)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        PropertyInfo propertyInfo;
        FieldInfo fieldInfo;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!ExposedClass.KncENhGxPrvUjmrAxbVg((object) fieldInfo, (object) null))
              {
                num2 = 9;
                continue;
              }
              goto label_4;
            case 2:
              goto label_4;
            case 3:
              goto label_9;
            case 4:
              result = propertyInfo.GetValue((object) null, (object[]) null);
              num2 = 5;
              continue;
            case 5:
              goto label_11;
            case 6:
              goto label_6;
            case 7:
              if (!(propertyInfo != (PropertyInfo) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 8:
              propertyInfo = (PropertyInfo) ExposedClass.VIvaQZGxkhAGq3MuieLU(this.m_type, ExposedClass.WqBJy0GxNOxEGWSg5MrC((object) binder), BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 7 : 1;
              continue;
            case 9:
              result = (object) null;
              num2 = 6;
              continue;
            default:
              fieldInfo = (FieldInfo) ExposedClass.LdAUO7GxeIwRtoL1a0Ko(this.m_type, ExposedClass.WqBJy0GxNOxEGWSg5MrC((object) binder), BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 1;
              continue;
          }
        }
label_4:
        result = ExposedClass.jubmUsGx3PbvbwvbM2af((object) fieldInfo, (object) null);
        num1 = 3;
      }
label_6:
      return false;
label_9:
      return true;
label_11:
      return true;
    }

    public static object From(Type type) => (object) new ExposedClass(type);

    internal static void TkUZpWGxRyAVkIXBa09I() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool gnGsgpGxSKQ3ocprhJ69() => ExposedClass.mAyQjGGxVAxfmPReyC95 == null;

    internal static ExposedClass BEa1fjGxiUMdx5GB9aLR() => ExposedClass.mAyQjGGxVAxfmPReyC95;

    internal static object tnLY5KGxqiKGhB2OdItP([In] object obj0) => (object) ExposedObjectHelper.GetTypeArgs((InvokeMemberBinder) obj0);

    internal static object XnHbLJGxKZdJ6cIbEtvR([In] object obj0) => (object) ((InvokeMemberBinder) obj0).Name;

    internal static object HrcQm7GxX4AgrYhEbwx9([In] object obj0) => (object) ((MethodBase) obj0).GetGenericArguments();

    internal static object PkuA8PGxT70LdN3vwF7j([In] object obj0, [In] object obj1) => (object) ((MethodInfo) obj0).MakeGenericMethod((Type[]) obj1);

    internal static object VIvaQZGxkhAGq3MuieLU(Type type, [In] object obj1, BindingFlags bindingAttr) => (object) type.GetReflectionProperty((string) obj1, bindingAttr);

    internal static bool IjBDwHGxn2D1ucZ7Ri37([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 != (PropertyInfo) obj1;

    internal static void w736qSGxOvuQOeMQdSW2([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static object DprT56Gx2y2JMfGt2E1W([In] object obj0) => (object) ((SetMemberBinder) obj0).Name;

    internal static object LdAUO7GxeIwRtoL1a0Ko(Type type, [In] object obj1, BindingFlags bindingAttr) => (object) type.GetReflectionField((string) obj1, bindingAttr);

    internal static bool KncENhGxPrvUjmrAxbVg([In] object obj0, [In] object obj1) => (FieldInfo) obj0 != (FieldInfo) obj1;

    internal static void HSXQYKGx1pNOCcCoIfm1([In] object obj0, [In] object obj1, [In] object obj2) => ((FieldInfo) obj0).SetValue(obj1, obj2);

    internal static object WqBJy0GxNOxEGWSg5MrC([In] object obj0) => (object) ((GetMemberBinder) obj0).Name;

    internal static object jubmUsGx3PbvbwvbM2af([In] object obj0, [In] object obj1) => ((FieldInfo) obj0).GetValue(obj1);
  }
}
