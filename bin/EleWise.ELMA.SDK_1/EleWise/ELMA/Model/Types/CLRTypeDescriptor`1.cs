// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.CLRTypeDescriptor`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Абстрактный класс описания типа данных CLR</summary>
  /// <typeparam name="T">Тип CLR</typeparam>
  public abstract class CLRTypeDescriptor<T> : SimpleTypeDescriptor<T>, IRuntimeTypeDescriptor
  {
    internal static object slAJh3oJDY6KMD29jbAd;

    /// <summary>Тип CLR</summary>
    public virtual Type RuntimeType => typeof (T);

    /// <summary>
    /// Можно ли использовать данное описание типа при определении описания типа по Runtime-типу
    /// </summary>
    public virtual bool IsRuntimeType => true;

    /// <summary>Получить значение по умолчанию</summary>
    /// <returns>Значение</returns>
    protected object GetRuntimeTypeDefaultValue()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 2:
            if (!this.RuntimeType.IsValueType)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 1 : 1;
              continue;
            }
            goto case 3;
          case 3:
            if (this.RuntimeType.IsNullableType())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return (object) null;
label_3:
      return Activator.CreateInstance(this.RuntimeType);
    }

    protected CLRTypeDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool K79Op1oJtmEUAhcAX7Cx() => CLRTypeDescriptor<T>.slAJh3oJDY6KMD29jbAd == null;

    internal static object ULMV2XoJw6wnflYExURZ() => CLRTypeDescriptor<T>.slAJh3oJDY6KMD29jbAd;
  }
}
