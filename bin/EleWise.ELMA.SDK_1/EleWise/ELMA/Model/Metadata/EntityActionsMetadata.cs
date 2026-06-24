// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.EntityActionsMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Метаданные для действия с сущностью</summary>
  [Serializable]
  public class EntityActionsMetadata : EnumMetadata
  {
    internal static EntityActionsMetadata dEJ0Dpb6z1Oa3q9XFYF2;

    /// <summary>Загрузить значения перечисления из типа</summary>
    /// <param name="type">Тип</param>
    /// <param name="inherit"></param>
    /// <returns></returns>
    protected override void LoadValuesFromType(System.Type type, bool inherit)
    {
      int num1 = 2;
      BindingFlags bindingAttr;
      IEnumerator<PropertyInfo> enumerator1;
      IEnumerator<FieldInfo> enumerator2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (inherit)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            bindingAttr = BindingFlags.Static | BindingFlags.Public;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 0;
            continue;
          case 3:
            bindingAttr |= BindingFlags.DeclaredOnly;
            num1 = 4;
            continue;
          case 5:
            goto label_35;
          case 6:
label_39:
            // ISSUE: type reference
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            enumerator2 = ((IEnumerable<FieldInfo>) EntityActionsMetadata.F3s9wgbHhrW1XoLUUD3m(type, bindingAttr)).Where<FieldInfo>((Func<FieldInfo, bool>) (fi => EntityActionsMetadata.\u003C\u003Ec.MeUwwCCwpkHNG93QHuoO((object) fi, EntityActionsMetadata.\u003C\u003Ec.dd8GVlCw3FjbDpSScpd4(__typeref (UidAttribute)), false))).GetEnumerator();
            num1 = 7;
            continue;
          case 7:
            goto label_21;
          case 8:
            try
            {
label_9:
              if (EntityActionsMetadata.EFK8F6bHorBWUcsGpvjY((object) enumerator1))
                goto label_12;
              else
                goto label_10;
label_7:
              EnumValueMetadata enumValueMetadata;
              PropertyInfo current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_9;
                  case 2:
                    enumValueMetadata.LoadFromMember((MemberInfo) current);
                    num2 = 5;
                    continue;
                  case 3:
                    goto label_12;
                  case 4:
                    enumValueMetadata = new EnumValueMetadata();
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 2 : 2;
                    continue;
                  case 5:
                    this.Values.Add(enumValueMetadata);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 1 : 0;
                    continue;
                  default:
                    goto label_39;
                }
              }
label_10:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
              goto label_7;
label_12:
              current = enumerator1.Current;
              num2 = 4;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
              {
                num2 = 4;
                goto label_7;
              }
              else
                goto label_7;
            }
            finally
            {
              int num3;
              if (enumerator1 == null)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 1;
              else
                goto label_18;
label_17:
              switch (num3)
              {
                case 1:
                case 2:
              }
label_18:
              EntityActionsMetadata.S7y5KubHbXQ9CbRGZbXU((object) enumerator1);
              num3 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
              {
                num3 = 2;
                goto label_17;
              }
              else
                goto label_17;
            }
          default:
            // ISSUE: type reference
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            enumerator1 = ((IEnumerable<PropertyInfo>) EntityActionsMetadata.tkweqZbHWSbi3jshIKIB(type, bindingAttr)).Where<PropertyInfo>((Func<PropertyInfo, bool>) (fi => EntityActionsMetadata.\u003C\u003Ec.MeUwwCCwpkHNG93QHuoO((object) fi, EntityActionsMetadata.\u003C\u003Ec.dd8GVlCw3FjbDpSScpd4(__typeref (UidAttribute)), false))).GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 8 : 5;
            continue;
        }
      }
label_35:
      return;
label_21:
      try
      {
label_28:
        if (EntityActionsMetadata.EFK8F6bHorBWUcsGpvjY((object) enumerator2))
          goto label_24;
        else
          goto label_29;
label_22:
        EnumValueMetadata enumValueMetadata;
        FieldInfo current;
        int num4;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_28;
            case 2:
              goto label_24;
            case 3:
              enumValueMetadata.LoadFromMember((MemberInfo) current);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 4 : 5;
              continue;
            case 4:
              goto label_30;
            case 5:
              this.Values.Add(enumValueMetadata);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 0;
              continue;
            default:
              enumValueMetadata = new EnumValueMetadata();
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 3;
              continue;
          }
        }
label_30:
        return;
label_24:
        current = enumerator2.Current;
        num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
        {
          num4 = 0;
          goto label_22;
        }
        else
          goto label_22;
label_29:
        num4 = 4;
        goto label_22;
      }
      finally
      {
        if (enumerator2 != null)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
            num5 = 1;
          while (true)
          {
            switch (num5)
            {
              case 1:
                enumerator2.Dispose();
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
                continue;
              default:
                goto label_37;
            }
          }
        }
label_37:;
      }
    }

    public EntityActionsMetadata()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object tkweqZbHWSbi3jshIKIB(System.Type type, BindingFlags bindingAttr) => (object) type.GetReflectionProperties(bindingAttr);

    internal static bool EFK8F6bHorBWUcsGpvjY([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void S7y5KubHbXQ9CbRGZbXU([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object F3s9wgbHhrW1XoLUUD3m(System.Type type, BindingFlags bindingAttr) => (object) type.GetReflectionFields(bindingAttr);

    internal static bool jL58QVbHFxBfsrIk78vr() => EntityActionsMetadata.dEJ0Dpb6z1Oa3q9XFYF2 == null;

    internal static EntityActionsMetadata TbZHfsbHBiF8oQKkJ5v7() => EntityActionsMetadata.dEJ0Dpb6z1Oa3q9XFYF2;
  }
}
