// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Transformations.ChangeablePropertyAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Transformations
{
  [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
  public class ChangeablePropertyAttribute : Attribute
  {
    internal static ChangeablePropertyAttribute vrU9fVWUWolOZP3ap1ix;

    public ChangeablePropertyAttribute()
    {
      ChangeablePropertyAttribute.KYOxJrWUhcKZvJIyP762();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ChangeablePropertyAttribute(params string[] subProperty)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.SubProperties = subProperty;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public ChangeablePropertyAttribute(Type changedPropertiesContainerType)
    {
      ChangeablePropertyAttribute.KYOxJrWUhcKZvJIyP762();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
        num = 0;
      IAttributesChangeableProperties changeableProperties;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.SubProperties = (string[]) ChangeablePropertyAttribute.kLFiLLWUEpS7dJo3EjUq((object) changeableProperties);
            num = 2;
            continue;
          case 2:
            goto label_3;
          default:
            changeableProperties = (IAttributesChangeableProperties) ChangeablePropertyAttribute.mhDAE3WUGlnkln1L8xDI(changedPropertiesContainerType);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    public string[] SubProperties
    {
      get => this.\u003CSubProperties\u003Ek__BackingField;
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
              this.\u003CSubProperties\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
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

    internal static void KYOxJrWUhcKZvJIyP762() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool sOYhsIWUoO88Hcb9Stwu() => ChangeablePropertyAttribute.vrU9fVWUWolOZP3ap1ix == null;

    internal static ChangeablePropertyAttribute LLvx4iWUbPpeRnvxiYlB() => ChangeablePropertyAttribute.vrU9fVWUWolOZP3ap1ix;

    internal static object mhDAE3WUGlnkln1L8xDI([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static object kLFiLLWUEpS7dJo3EjUq([In] object obj0) => (object) ((IAttributesChangeableProperties) obj0).GetProperties();
  }
}
