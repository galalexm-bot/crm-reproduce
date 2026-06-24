// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Metadata.FormTablePartMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Metadata
{
  [Serializable]
  public class FormTablePartMetadata : TablePartMetadata
  {
    private static FormTablePartMetadata LBA5OJBE6qeFZbmmEkGU;

    public override void LoadFromType(System.Type type, bool inherit = true)
    {
      int num1 = 1;
      IEnumerator<PropertyInfo> enumerator;
      EntityMetadata entityMetadata;
      while (true)
      {
        switch (num1)
        {
          case 1:
            entityMetadata = (EntityMetadata) FormTablePartMetadata.aScoXkBE7eVlmPVxgnHI(type);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_18;
          case 4:
            goto label_21;
          case 5:
            PropertyInfo[] properties = this.GetType().GetProperties();
            // ISSUE: reference to a compiler-generated field
            Func<PropertyInfo, bool> func = FormTablePartMetadata.\u003C\u003Ec.\u003C\u003E9__0_0;
            Func<PropertyInfo, bool> predicate;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              FormTablePartMetadata.\u003C\u003Ec.\u003C\u003E9__0_0 = predicate = (Func<PropertyInfo, bool>) (p =>
              {
                int num2 = 1;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      if (FormTablePartMetadata.\u003C\u003Ec.VIYOobQbQRb88ksTwu4c((object) p).Length != 0)
                      {
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
                        continue;
                      }
                      goto case 3;
                    case 3:
                      if (!p.CanRead)
                      {
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 2 : 0;
                        continue;
                      }
                      goto label_2;
                    case 4:
                      goto label_2;
                    default:
                      goto label_3;
                  }
                }
label_2:
                // ISSUE: reference to a compiler-generated method
                return FormTablePartMetadata.\u003C\u003Ec.fb4H4QQbCapuecgPDmcI((object) p);
label_3:
                return false;
              });
            }
            else
              goto label_24;
label_23:
            enumerator = ((IEnumerable<PropertyInfo>) properties).Where<PropertyInfo>(predicate).GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 2;
            continue;
label_24:
            predicate = func;
            goto label_23;
          case 6:
            base.LoadFromType(type, inherit);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 3 : 2;
            continue;
          default:
            if (entityMetadata != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 5 : 0;
              continue;
            }
            goto case 6;
        }
      }
label_18:
      return;
label_21:
      return;
label_3:
      try
      {
label_5:
        if (FormTablePartMetadata.RiPwlkBE04933lecahOs((object) enumerator))
          goto label_8;
        else
          goto label_6;
label_4:
        PropertyInfo current;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_8;
            case 2:
              goto label_19;
            case 3:
              FormTablePartMetadata.ik11ZZBExFpUcPorZQ1G((object) current, (object) this, current.GetValue((object) entityMetadata, (object[]) null), (object) null);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_19:
        return;
label_6:
        num3 = 2;
        goto label_4;
label_8:
        current = enumerator.Current;
        num3 = 3;
        goto label_4;
      }
      finally
      {
        int num4;
        if (enumerator == null)
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 2;
        else
          goto label_12;
label_11:
        switch (num4)
        {
          case 1:
            break;
          default:
        }
label_12:
        enumerator.Dispose();
        num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0)
        {
          num4 = 0;
          goto label_11;
        }
        else
          goto label_11;
      }
    }

    public override TablePartMetadata CreateTablePart()
    {
      int num1 = 2;
      FormTablePartMetadata tp;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              tp = new FormTablePartMetadata();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
              continue;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 1;
              continue;
            case 3:
              FormTablePartMetadata.loFoXwBEy9TBXsYOSjXP((object) tp, EntityMetadataType.Entity);
              num2 = 5;
              continue;
            case 4:
              goto label_5;
            case 5:
              goto label_6;
            default:
              FormTablePartMetadata.F3aGtXBEmSR900t9HW9s((object) tp);
              num2 = 3;
              continue;
          }
        }
label_6:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        FormTablePartMetadata.MIhZNtBEJFikP3quV6gl((object) tp.Properties.First<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => FormTablePartMetadata.\u003C\u003Ec__DisplayClass1_0.IVoD93QbSEWI9cjjcdfo(FormTablePartMetadata.\u003C\u003Ec__DisplayClass1_0.kgvfUBQbIDc715e22np9((object) p), FormTablePartMetadata.\u003C\u003Ec__DisplayClass1_0.P6w9nGQbVHEO22VCQYvW((object) tp)))), FormTablePartMetadata.SRBVQZBEMWQwTAHtVvm3((object) this));
        num1 = 4;
      }
label_5:
      return (TablePartMetadata) tp;
    }

    public FormTablePartMetadata()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object aScoXkBE7eVlmPVxgnHI(System.Type type) => (object) FormContextMetadata.FindMetadata(type);

    internal static void ik11ZZBExFpUcPorZQ1G([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static bool RiPwlkBE04933lecahOs([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static bool SungliBEH68AeFD7K5gL() => FormTablePartMetadata.LBA5OJBE6qeFZbmmEkGU == null;

    internal static FormTablePartMetadata uedLA6BEAnguL9jRLF6o() => FormTablePartMetadata.LBA5OJBE6qeFZbmmEkGU;

    internal static void F3aGtXBEmSR900t9HW9s([In] object obj0) => ((AbstractMetadata) obj0).InitNew();

    internal static void loFoXwBEy9TBXsYOSjXP([In] object obj0, EntityMetadataType value) => ((EntityMetadata) obj0).Type = value;

    internal static Guid SRBVQZBEMWQwTAHtVvm3([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static void MIhZNtBEJFikP3quV6gl([In] object obj0, Guid value) => ((PropertyMetadata) obj0).SubTypeUid = value;
  }
}
