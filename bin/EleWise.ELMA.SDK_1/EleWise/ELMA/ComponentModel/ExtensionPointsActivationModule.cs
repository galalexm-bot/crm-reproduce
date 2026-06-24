// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.ExtensionPointsActivationModule
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac;
using Autofac.Core;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// Модуль перехвата активации коллекций точек расширений.
  /// Осуществляет сортировку по <see cref="P:EleWise.ELMA.ComponentModel.ComponentAttribute.Order" /> или <see cref="P:EleWise.ELMA.ComponentModel.ComponentOrderAttribute.Order" />
  /// </summary>
  internal class ExtensionPointsActivationModule : Module
  {
    private ConcurrentDictionary<Type, bool> isExtPoints;
    private ConcurrentDictionary<Type, int> typeOrders;
    internal static ExtensionPointsActivationModule kwQsD0fEy1HpKLCRtbAR;

    protected override void AttachToComponentRegistration(
      IComponentRegistry componentRegistry,
      IComponentRegistration registration)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            registration.Activating += new EventHandler<ActivatingEventArgs<object>>(this.RegistrationOnActivating);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private void RegistrationOnActivating(object sender, ActivatingEventArgs<object> e)
    {
      Type type1 = e.Instance.GetType();
      if (!ComponentManager.Initialized || !type1.IsArray)
        return;
      Type elementType = type1.GetElementType();
      if (!(elementType != (Type) null) || !(elementType != typeof (object)))
        return;
      bool flag;
      if (!this.isExtPoints.TryGetValue(elementType, out flag))
      {
        flag = AttributeHelper<ExtensionPointAttribute>.GetAttribute(elementType, true) != null;
        this.isExtPoints[elementType] = flag;
      }
      if (!flag)
        return;
      IEnumerable<object> source = ((IEnumerable) e.Instance).OfType<object>();
      if (source.Count<object>() == 1)
        return;
      object[] array = source.OrderBy<object, int>((Func<object, int>) (p =>
      {
        int num1 = 5;
        int num2;
        while (true)
        {
          int num3 = num1;
          Type type2;
          ComponentOrderAttribute attribute1;
          while (true)
          {
            ComponentAttribute attribute2;
            int num4;
            switch (num3)
            {
              case 1:
                goto label_6;
              case 2:
                goto label_15;
              case 3:
                num4 = attribute1.Order;
                break;
              case 4:
                if (!this.typeOrders.TryGetValue(type2, out num2))
                  goto case 11;
                else
                  goto label_4;
              case 5:
                type2 = p.GetType();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 2 : 4;
                continue;
              case 6:
                num4 = 0;
                break;
              case 7:
              case 9:
                goto label_13;
              case 8:
                if (attribute1 != null)
                {
                  num3 = 3;
                  continue;
                }
                goto case 10;
              case 10:
                if (attribute2 != null)
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
                  continue;
                }
                goto case 6;
              case 11:
                attribute2 = AttributeHelper<ComponentAttribute>.GetAttribute(type2, true);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 1;
                continue;
              default:
                num4 = attribute2.Order;
                break;
            }
            num2 = num4;
            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 2 : 0;
          }
label_4:
          num1 = 9;
          continue;
label_6:
          attribute1 = AttributeHelper<ComponentOrderAttribute>.GetAttribute(type2, true);
          num1 = 8;
          continue;
label_15:
          this.typeOrders[type2] = num2;
          num1 = 7;
        }
label_13:
        return num2;
      })).ToArray<object>();
      Array instance = Array.CreateInstance(elementType, array.Length);
      Array.Copy((Array) array, instance, array.Length);
      e.Instance = (object) instance;
    }

    public ExtensionPointsActivationModule()
    {
      ExtensionPointsActivationModule.TZjnSXfE9TTixHiS6W3g();
      this.isExtPoints = new ConcurrentDictionary<Type, bool>();
      this.typeOrders = new ConcurrentDictionary<Type, int>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool uF0GEjfEMqYmwGjCq8H3() => ExtensionPointsActivationModule.kwQsD0fEy1HpKLCRtbAR == null;

    internal static ExtensionPointsActivationModule FBHLIffEJ9cG65Molsw9() => ExtensionPointsActivationModule.kwQsD0fEy1HpKLCRtbAR;

    internal static void TZjnSXfE9TTixHiS6W3g() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
