// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.PublicationBehaviourAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.PublicationBehaviours;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Атрибут определяющий поведение при публикации</summary>
  [AttributeUsage(AttributeTargets.Property)]
  public sealed class PublicationBehaviourAttribute : Attribute
  {
    private readonly IPublicationBehaviourChecker publicationBehaviourChecker;
    internal static PublicationBehaviourAttribute uOpcCUof2xhnG6whbARM;

    /// <summary>Ctor</summary>
    /// <param name="type">Тип публикации</param>
    public PublicationBehaviourAttribute(PublicationType type)
    {
      PublicationBehaviourAttribute.sQ0YmEof1PrguQi4s0rf();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_4;
          case 1:
            goto label_7;
          case 2:
            switch (type)
            {
              case PublicationType.Soft:
                this.publicationBehaviourChecker = (IPublicationBehaviourChecker) new SoftBehaviour();
                num = 3;
                continue;
              case PublicationType.Delta:
                this.publicationBehaviourChecker = (IPublicationBehaviourChecker) new DeltaBehaviour();
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 1 : 0;
                continue;
              case (PublicationType) 2:
                goto label_12;
              case PublicationType.Restart:
                this.publicationBehaviourChecker = (IPublicationBehaviourChecker) new RestartBehaviour();
                num = 4;
                continue;
              default:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
                continue;
            }
          case 3:
            goto label_9;
          case 4:
            goto label_3;
          default:
            goto label_13;
        }
      }
label_4:
      return;
label_7:
      return;
label_9:
      return;
label_3:
      return;
label_13:
      return;
label_12:;
    }

    /// <summary>Ctor</summary>
    /// <param name="publicationBehaviourChecker">Тип класса, осуществляющего проверку необходимости перезапуска сервера</param>
    public PublicationBehaviourAttribute(Type publicationBehaviourChecker)
    {
      PublicationBehaviourAttribute.sQ0YmEof1PrguQi4s0rf();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.publicationBehaviourChecker = (IPublicationBehaviourChecker) PublicationBehaviourAttribute.zuFP9CofNGaA6hMZe6VC(publicationBehaviourChecker);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Получить тип публикации свойства</summary>
    /// <param name="checkType">Тип проверки</param>
    /// <param name="oldValue">Старое значение свойства</param>
    /// <param name="newValue">Новое знавение свойства</param>
    /// <returns>Информация о возможности публикации</returns>
    public PublicationType CheckProperty(CheckType checkType, object oldValue, object newValue) => PublicationBehaviourAttribute.nAvvTyof3Hq8NA9Pt2Ax((object) this.publicationBehaviourChecker, checkType, oldValue, newValue);

    internal static void sQ0YmEof1PrguQi4s0rf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool CD36pTofeSIrlCYJdddN() => PublicationBehaviourAttribute.uOpcCUof2xhnG6whbARM == null;

    internal static PublicationBehaviourAttribute J9p0gNofP2KoAk9kplhT() => PublicationBehaviourAttribute.uOpcCUof2xhnG6whbARM;

    internal static object zuFP9CofNGaA6hMZe6VC([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static PublicationType nAvvTyof3Hq8NA9Pt2Ax(
      [In] object obj0,
      CheckType action,
      [In] object obj2,
      [In] object obj3)
    {
      return ((IPublicationBehaviourChecker) obj0).Check(action, obj2, obj3);
    }
  }
}
