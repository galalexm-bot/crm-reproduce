// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Metadata.ComponentContextMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.UI.Metadata
{
  /// <summary>Метаданные контекста компонента</summary>
  [DataContract]
  [Serializable]
  public class ComponentContextMetadata : ClassMetadata
  {
    private static ComponentContextMetadata xRiYR7BGVn6TxstqHbdr;

    /// <inheritdoc />
    public override void LoadFromType(Type type, bool inherit = true)
    {
      int num1 = 5;
      ClassMetadata classMetadata;
      IEnumerator<PropertyInfo> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            base.LoadFromType(type, inherit);
            num1 = 6;
            continue;
          case 2:
            PropertyInfo[] properties = ComponentContextMetadata.KIUY0lBGqAysKPhwa3Xi((object) this).GetProperties();
            // ISSUE: reference to a compiler-generated field
            Func<PropertyInfo, bool> func = ComponentContextMetadata.\u003C\u003Ec.\u003C\u003E9__0_0;
            Func<PropertyInfo, bool> predicate;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              ComponentContextMetadata.\u003C\u003Ec.\u003C\u003E9__0_0 = predicate = (Func<PropertyInfo, bool>) (p =>
              {
                int num2 = 2;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                    case 4:
                      goto label_3;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      if (ComponentContextMetadata.\u003C\u003Ec.RpJtn4QoOOCQk5hyUOLU((object) p).Length != 0)
                      {
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 1 : 0;
                        continue;
                      }
                      break;
                    case 3:
                      goto label_2;
                  }
                  // ISSUE: reference to a compiler-generated method
                  if (!ComponentContextMetadata.\u003C\u003Ec.AuFm1TQo29bt79UOp87A((object) p))
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 4 : 4;
                  else
                    break;
                }
label_2:
                return p.CanWrite;
label_3:
                return false;
              });
            }
            else
              goto label_26;
label_25:
            enumerator = ((IEnumerable<PropertyInfo>) properties).Where<PropertyInfo>(predicate).GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
            continue;
label_26:
            predicate = func;
            goto label_25;
          case 3:
            goto label_23;
          case 4:
            if (classMetadata != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 2 : 0;
              continue;
            }
            goto case 1;
          case 5:
            classMetadata = (ClassMetadata) ComponentContextMetadata.DhhE52BGRN4jeNAN6bIa(type);
            num1 = 4;
            continue;
          case 6:
            goto label_2;
          default:
            goto label_7;
        }
      }
label_23:
      return;
label_2:
      return;
label_7:
      try
      {
label_10:
        if (enumerator.MoveNext())
          goto label_13;
        else
          goto label_11;
label_9:
        PropertyInfo current;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_19;
            case 2:
              ComponentContextMetadata.aGsA21BGXLI6cCKFdeFu((object) current, (object) this, ComponentContextMetadata.gXcMmDBGK0Dox9QEByvK((object) current, (object) classMetadata, (object) null), (object) null);
              num3 = 3;
              continue;
            case 3:
              goto label_10;
            default:
              goto label_13;
          }
        }
label_19:
        return;
label_11:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 1;
        goto label_9;
label_13:
        current = enumerator.Current;
        num3 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
        {
          num3 = 2;
          goto label_9;
        }
        else
          goto label_9;
      }
      finally
      {
        if (enumerator != null)
        {
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
            num4 = 1;
          while (true)
          {
            switch (num4)
            {
              case 1:
                ComponentContextMetadata.iCXD9VBGTKnPy6WBj1jP((object) enumerator);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
                continue;
              default:
                goto label_21;
            }
          }
        }
label_21:;
      }
    }

    /// <summary>Найти метаданные по типу</summary>
    /// <param name="type">Тип</param>
    /// <returns>Метаданные</returns>
    internal static ClassMetadata FindMetadata(Type type)
    {
      int num = 5;
      Type runtimeType;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(runtimeType == (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
              continue;
            }
            goto label_8;
          case 2:
            goto label_11;
          case 3:
            goto label_8;
          case 4:
            goto label_2;
          case 5:
            if (type.IsNested)
            {
              runtimeType = ComponentContextMetadata.dLwLthBGk0omupUyhCHG((object) type);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 1;
              continue;
            }
            num = 4;
            continue;
          default:
            if (!(MetadataLoader.LoadMetadata(runtimeType) is ComponentMetadata componentMetadata))
            {
              num = 2;
              continue;
            }
            goto label_12;
        }
      }
label_2:
      return (ClassMetadata) null;
label_8:
      return (ClassMetadata) null;
label_11:
      return (ClassMetadata) null;
label_12:
      return (ClassMetadata) ComponentContextMetadata.gTDeWJBGnKPo1suM05pa((object) componentMetadata.Content);
    }

    public ComponentContextMetadata()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object DhhE52BGRN4jeNAN6bIa(Type type) => (object) ComponentContextMetadata.FindMetadata(type);

    internal static Type KIUY0lBGqAysKPhwa3Xi([In] object obj0) => obj0.GetType();

    internal static object gXcMmDBGK0Dox9QEByvK([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static void aGsA21BGXLI6cCKFdeFu([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static void iCXD9VBGTKnPy6WBj1jP([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool nY9ij8BGS9YqfaNU1hnU() => ComponentContextMetadata.xRiYR7BGVn6TxstqHbdr == null;

    internal static ComponentContextMetadata ajaX0cBGiRv2QNfLFp8B() => ComponentContextMetadata.xRiYR7BGVn6TxstqHbdr;

    internal static Type dLwLthBGk0omupUyhCHG([In] object obj0) => ((MemberInfo) obj0).ReflectedType;

    internal static object gTDeWJBGnKPo1suM05pa([In] object obj0) => (object) ((ComponentContentMetadata) obj0).Context;
  }
}
