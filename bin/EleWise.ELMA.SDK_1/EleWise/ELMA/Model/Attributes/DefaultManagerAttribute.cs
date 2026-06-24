// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.DefaultManagerAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Managers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Атрибут, определяющий тип менеджера по умолчанию</summary>
  public class DefaultManagerAttribute : Attribute
  {
    private readonly Type managerType;
    internal static DefaultManagerAttribute VC6KjToIOZE4AuD5HArP;

    /// <summary>Конструктор</summary>
    /// <param name="managerType">Тип менеджера или тип класс, генерирующего менеджер (реализующего интерфейс IManagerMaker)</param>
    public DefaultManagerAttribute(Type managerType)
    {
      DefaultManagerAttribute.UVTC4koIP1dBspBe7f1t();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.managerType = managerType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>
    /// Получить тип менеджера объекта с типом <paramref name="objectType" />
    /// </summary>
    /// <param name="objectType">Тип объекта</param>
    /// <returns></returns>
    public Type GetManagerType(Type objectType)
    {
      int num = 1;
      while (true)
      {
        Type type;
        switch (num)
        {
          case 1:
            DefaultManagerAttribute.Woah9woINCbVnjNLJaLr((object) objectType, DefaultManagerAttribute.e5IZOooI1ZdVbb2Zsj8J(1052221104 - 768835541 ^ 283527113));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          case 3:
            type = (Type) null;
            break;
          default:
            Type managerType = this.managerType;
            if ((object) managerType == null)
            {
              num = 3;
              continue;
            }
            // ISSUE: type reference
            // ISSUE: explicit non-virtual call
            type = __nonvirtual (managerType.GetInterface(DefaultManagerAttribute.BON9UAoI3kqQQmmx9qnx(__typeref (IManagerMaker)).FullName));
            break;
        }
        if (DefaultManagerAttribute.VRLBgRoIprFWOGYFEJuu(type, (Type) null))
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 2 : 1;
        else
          goto label_6;
      }
label_5:
      return DefaultManagerAttribute.eN1e2goIDTmqNvXfqNmA((object) (IManagerMaker) DefaultManagerAttribute.kOIEgjoIa6O0FbdagQOJ(this.managerType), objectType);
label_6:
      return this.managerType;
    }

    internal static void UVTC4koIP1dBspBe7f1t() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Fbu7Q6oI2k9U8Xbkxv0C() => DefaultManagerAttribute.VC6KjToIOZE4AuD5HArP == null;

    internal static DefaultManagerAttribute mxCcfNoIeGpZPrJ1FT9y() => DefaultManagerAttribute.VC6KjToIOZE4AuD5HArP;

    internal static object e5IZOooI1ZdVbb2Zsj8J(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void Woah9woINCbVnjNLJaLr([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static Type BON9UAoI3kqQQmmx9qnx([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool VRLBgRoIprFWOGYFEJuu([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object kOIEgjoIa6O0FbdagQOJ([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static Type eN1e2goIDTmqNvXfqNmA([In] object obj0, Type objectType) => ((IManagerMaker) obj0).MakeManager(objectType);
  }
}
