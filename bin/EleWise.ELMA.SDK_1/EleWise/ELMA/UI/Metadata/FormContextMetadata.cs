// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Metadata.FormContextMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
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
  public class FormContextMetadata : EntityMetadata
  {
    internal static FormContextMetadata LfquvYBGzUJ0jEXWbp4a;

    public FormContextMetadata()
    {
      FormContextMetadata.xe7S86BEWTTHvIYb2iIK();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            FormContextMetadata.MdGijOBEo4BMKLe1mWII((object) this, EntityMetadataType.Entity);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    public override void LoadFromType(System.Type type, bool inherit = true)
    {
      int num1 = 3;
      EntityMetadata entityMetadata;
      IEnumerator<PropertyInfo> enumerator;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_20;
            case 1:
              goto label_21;
            case 2:
              if (entityMetadata != null)
              {
                num2 = 5;
                continue;
              }
              goto case 4;
            case 3:
              entityMetadata = (EntityMetadata) FormContextMetadata.FHWlntBEbsybiReSpKyF(type);
              num2 = 2;
              continue;
            case 4:
              base.LoadFromType(type, inherit);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
              continue;
            case 5:
              goto label_24;
            case 6:
              goto label_5;
            default:
              goto label_12;
          }
        }
label_24:
        enumerator = ((IEnumerable<PropertyInfo>) FormContextMetadata.nPw8KVBEhPj8r51KR5X0((object) this).GetProperties()).Where<PropertyInfo>((Func<PropertyInfo, bool>) (p =>
        {
          int num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                if (FormContextMetadata.\u003C\u003Ec.pnGLKwQo0eNBeJMefA6a((object) p).Length != 0)
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
                  continue;
                }
                goto case 2;
              case 2:
                // ISSUE: reference to a compiler-generated method
                if (FormContextMetadata.\u003C\u003Ec.XUmLoDQom5JaGlZBVtDP((object) p))
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 3;
                  continue;
                }
                goto label_5;
              case 3:
                goto label_4;
              default:
                goto label_5;
            }
          }
label_4:
          // ISSUE: reference to a compiler-generated method
          return FormContextMetadata.\u003C\u003Ec.eejnQFQoyukEQXGlTGjE((object) p);
label_5:
          return false;
        })).GetEnumerator();
        num1 = 6;
      }
label_20:
      return;
label_21:
      return;
label_12:
      return;
label_5:
      try
      {
label_8:
        if (FormContextMetadata.VJbV6PBEEJOIW2aS91tH((object) enumerator))
          goto label_10;
        else
          goto label_9;
label_6:
        PropertyInfo current;
        int num4;
        while (true)
        {
          switch (num4)
          {
            case 1:
              FormContextMetadata.tcaw7bBEG2XSNpeoFwDj((object) current, (object) this, current.GetValue((object) entityMetadata, (object[]) null), (object) null);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 2 : 3;
              continue;
            case 2:
              goto label_17;
            case 3:
              goto label_8;
            default:
              goto label_10;
          }
        }
label_17:
        return;
label_9:
        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 1 : 2;
        goto label_6;
label_10:
        current = enumerator.Current;
        num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
        {
          num4 = 1;
          goto label_6;
        }
        else
          goto label_6;
      }
      finally
      {
        if (enumerator != null)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
            num5 = 1;
          while (true)
          {
            switch (num5)
            {
              case 1:
                FormContextMetadata.bajaZjBEfgvvPvKr94OK((object) enumerator);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
                continue;
              default:
                goto label_19;
            }
          }
        }
label_19:;
      }
    }

    /// <summary>
    /// Сгенерировать новые идентификаторы для всех составляющих элементов (например, для публикации или копирования)
    /// </summary>
    public virtual void GenerateNewUids() => FormContextMetadata.GenerateNewUids((EntityMetadata) this);

    internal static void GenerateNewUids(EntityMetadata metadata)
    {
      int num1 = 1;
      List<TablePartMetadata>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            metadata.Uid = Guid.NewGuid();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_20;
          case 3:
            goto label_4;
          default:
            enumerator = metadata.TableParts.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 2 : 3;
            continue;
        }
      }
label_20:
      return;
label_4:
      try
      {
label_14:
        if (enumerator.MoveNext())
          goto label_10;
        else
          goto label_15;
label_5:
        PropertyMetadata propertyMetadata;
        int num2;
        TablePartMetadata tp;
        while (true)
        {
          switch (num2)
          {
            case 1:
              FormContextMetadata.CEl66PBEvBCbB1a1xBEQ((object) tp);
              num2 = 3;
              continue;
            case 2:
              goto label_16;
            case 3:
              goto label_14;
            case 4:
              FormContextMetadata.NsUg3oBECRfB65Hk5ixa((object) propertyMetadata, FormContextMetadata.HoEL0oBEQuovVZkpFhQS((object) metadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 1;
              continue;
            case 5:
              goto label_10;
            case 6:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              propertyMetadata = tp.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => FormContextMetadata.\u003C\u003Ec__DisplayClass3_0.CPLX97QorZFspyj59lmE(FormContextMetadata.\u003C\u003Ec__DisplayClass3_0.TOR7sLQodBHbHRcf2FpW((object) p), FormContextMetadata.\u003C\u003Ec__DisplayClass3_0.LWamkmQolUANgBxDCQWS((object) tp))));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
              continue;
            case 7:
              tp = enumerator.Current;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 6 : 6;
              continue;
            default:
              if (propertyMetadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 4 : 2;
                continue;
              }
              goto case 1;
          }
        }
label_16:
        return;
label_10:
        num2 = 5;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
        {
          num2 = 7;
          goto label_5;
        }
        else
          goto label_5;
label_15:
        num2 = 2;
        goto label_5;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    internal static EntityMetadata FindMetadata(System.Type type)
    {
      int num = 3;
      System.Type reflectedType;
      FormMetadata formMetadata;
      UidAttribute attribute;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (attribute != null)
            {
              num = 4;
              continue;
            }
            goto label_4;
          case 2:
            goto label_2;
          case 3:
            if (type.IsNested)
            {
              reflectedType = type.ReflectedType;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 6 : 5;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 2 : 2;
            continue;
          case 4:
            goto label_5;
          case 5:
            formMetadata = (FormMetadata) MetadataLoader.LoadMetadata(reflectedType);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
            continue;
          case 6:
            if (!FormContextMetadata.dqeL91BE86mWcRroeQ4M(reflectedType, (System.Type) null))
            {
              num = 5;
              continue;
            }
            goto label_14;
          case 7:
            goto label_8;
          case 8:
            goto label_14;
          case 9:
            goto label_4;
          default:
            if (formMetadata != null)
            {
              attribute = AttributeHelper<UidAttribute>.GetAttribute(type, false);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 1;
              continue;
            }
            num = 7;
            continue;
        }
      }
label_2:
      return (EntityMetadata) null;
label_4:
      return (EntityMetadata) null;
label_5:
      return (EntityMetadata) FormContextMetadata.a7qQx2BEZBtSOaMPlVK4((object) formMetadata, attribute.Uid);
label_8:
      return (EntityMetadata) null;
label_14:
      return (EntityMetadata) null;
    }

    public override TablePartMetadata CreateTablePart()
    {
      int num = 4;
      FormTablePartMetadata tp;
      while (true)
      {
        switch (num)
        {
          case 1:
            FormContextMetadata.MdGijOBEo4BMKLe1mWII((object) tp, EntityMetadataType.Entity);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 5;
            continue;
          case 2:
            FormContextMetadata.LFC8U8BEuPfWa4SlmuV7((object) tp);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 1;
            continue;
          case 3:
            tp = new FormTablePartMetadata();
            num = 2;
            continue;
          case 4:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 3 : 0;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            FormContextMetadata.NsUg3oBECRfB65Hk5ixa((object) tp.Properties.First<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => FormContextMetadata.\u003C\u003Ec__DisplayClass5_0.h7RchTQosu4VoJxubdwL(FormContextMetadata.\u003C\u003Ec__DisplayClass5_0.sQyUapQoLJD33bTyCtk8((object) p), FormContextMetadata.\u003C\u003Ec__DisplayClass5_0.apdBkBQoUUiswKxb6qUt((object) tp)))), this.Uid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (TablePartMetadata) tp;
    }

    internal static void xe7S86BEWTTHvIYb2iIK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void MdGijOBEo4BMKLe1mWII([In] object obj0, EntityMetadataType value) => ((EntityMetadata) obj0).Type = value;

    internal static bool ttHLTGBEFomZTpq9mcvR() => FormContextMetadata.LfquvYBGzUJ0jEXWbp4a == null;

    internal static FormContextMetadata tmEXqmBEBWBwGv2VKW9C() => FormContextMetadata.LfquvYBGzUJ0jEXWbp4a;

    internal static object FHWlntBEbsybiReSpKyF(System.Type type) => (object) FormContextMetadata.FindMetadata(type);

    internal static System.Type nPw8KVBEhPj8r51KR5X0([In] object obj0) => obj0.GetType();

    internal static void tcaw7bBEG2XSNpeoFwDj([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static bool VJbV6PBEEJOIW2aS91tH([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void bajaZjBEfgvvPvKr94OK([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static Guid HoEL0oBEQuovVZkpFhQS([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static void NsUg3oBECRfB65Hk5ixa([In] object obj0, Guid value) => ((PropertyMetadata) obj0).SubTypeUid = value;

    internal static void CEl66PBEvBCbB1a1xBEQ([In] object obj0) => FormContextMetadata.GenerateNewUids((EntityMetadata) obj0);

    internal static bool dqeL91BE86mWcRroeQ4M([In] System.Type obj0, [In] System.Type obj1) => obj0 == obj1;

    internal static object a7qQx2BEZBtSOaMPlVK4([In] object obj0, Guid uid) => (object) ((FormMetadata) obj0).GetPartContext(uid);

    internal static void LFC8U8BEuPfWa4SlmuV7([In] object obj0) => ((AbstractMetadata) obj0).InitNew();
  }
}
