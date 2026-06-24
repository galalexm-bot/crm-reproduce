// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.EnumBaseWrapperDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [Component(Order = 1100)]
  public class EnumBaseWrapperDescriptor : ITypeWrapperDescriptor
  {
    internal static EnumBaseWrapperDescriptor qnU5uNbotSxx5KIJUZJ7;

    public IMetadataRuntimeService MetadataRuntimeService
    {
      get => this.\u003CMetadataRuntimeService\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CMetadataRuntimeService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public Type OriginalType => EnumBaseWrapperDescriptor.NRKjh5bo6sqwiH1CFPAZ(__typeref (EnumBase));

    public Type WrapperType => EnumBaseWrapperDescriptor.NRKjh5bo6sqwiH1CFPAZ(__typeref (EnumBaseWrapper));

    public object CreateWrapper(object obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if ((object) (obj as EnumBase) != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (object) new EnumBaseWrapper((EnumBase) obj);
label_5:
      return (object) null;
    }

    public object GetObject(object wrapper)
    {
      int num1 = 1;
      EnumBaseWrapper enumBaseWrapper;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_12;
          default:
            enumBaseWrapper = (EnumBaseWrapper) wrapper;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 2;
            continue;
        }
      }
label_3:
      object obj;
      try
      {
        List<EnumValueMetadata> values = EnumMetadata.Load(this.MetadataRuntimeService.GetTypeByUid(enumBaseWrapper.TypeUid)).Values;
        // ISSUE: reference to a compiler-generated field
        Func<EnumValueMetadata, object> func = EnumBaseWrapperDescriptor.\u003C\u003Ec.\u003C\u003E9__9_0;
        Func<EnumValueMetadata, object> selector;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          EnumBaseWrapperDescriptor.\u003C\u003Ec.\u003C\u003E9__9_0 = selector = (Func<EnumValueMetadata, object>) (v => EnumBaseWrapperDescriptor.\u003C\u003Ec.uKT8uPCk6fWcKHRYOHBO((object) v));
        }
        else
          goto label_14;
label_5:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        obj = values.Select<EnumValueMetadata, object>(selector).FirstOrDefault<object>((Func<object, bool>) (v => EnumBaseWrapperDescriptor.\u003C\u003Ec__DisplayClass9_0.mcujCpCkpBN0FGekLDE7((object) (EnumBase) v) == EnumBaseWrapperDescriptor.\u003C\u003Ec__DisplayClass9_0.nFwIJVCka8hJyB2tYV5s((object) enumBaseWrapper)));
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_12;
        }
label_14:
        selector = func;
        goto label_5;
      }
      catch (TypeNotFoundException ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_12;
            default:
              obj = (object) null;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 1;
              continue;
          }
        }
      }
label_12:
      return obj;
    }

    public Type[] GenericArgumentsTypes => (Type[]) null;

    public bool TestType(Type type) => EnumBaseWrapperDescriptor.NRKjh5bo6sqwiH1CFPAZ(__typeref (EnumBase)).IsAssignableFrom(type);

    public EnumBaseWrapperDescriptor()
    {
      EnumBaseWrapperDescriptor.YLTuYnboHhCjCU3ckrFG();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool RHpDGKbowUA7smMTNK5O() => EnumBaseWrapperDescriptor.qnU5uNbotSxx5KIJUZJ7 == null;

    internal static EnumBaseWrapperDescriptor aXvcwnbo4X4l8ID1kBnt() => EnumBaseWrapperDescriptor.qnU5uNbotSxx5KIJUZJ7;

    internal static Type NRKjh5bo6sqwiH1CFPAZ([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static void YLTuYnboHhCjCU3ckrFG() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
