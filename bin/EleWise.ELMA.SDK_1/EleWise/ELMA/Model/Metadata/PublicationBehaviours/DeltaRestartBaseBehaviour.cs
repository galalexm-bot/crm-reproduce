// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.PublicationBehaviours.DeltaRestartBaseBehaviour
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Metadata.PublicationBehaviours
{
  /// <summary>
  /// Базовый расширитель поведения для <see cref="F:EleWise.ELMA.Model.Enums.PublicationType.Delta" /> и <see cref="F:EleWise.ELMA.Model.Enums.PublicationType.Restart" /> публикации
  /// </summary>
  internal abstract class DeltaRestartBaseBehaviour : IPublicationBehaviourChecker
  {
    private static DeltaRestartBaseBehaviour ebs6UobrW7DEVWkWGkJ5;

    /// <inheritdoc />
    public abstract PublicationType Check(CheckType action, object oldValue, object newValue);

    /// <summary>Определить тип публикации</summary>
    /// <param name="type">Установленный тип публикации</param>
    /// <param name="action">Тип действия</param>
    /// <param name="oldValue">Старое значение</param>
    /// <param name="newValue">Новое значение</param>
    /// <returns>Тип публикации</returns>
    protected PublicationType Check(
      PublicationType type,
      CheckType action,
      object oldValue,
      object newValue)
    {
      int num1 = 30;
      PublicationType publicationType;
      PublicationType type1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          IEnumerable<object> objects1;
          IEnumerable<object> objects2;
          Type type2;
          DeltaRestartBaseBehaviour restartBaseBehaviour;
          CheckType action1;
          switch (num2)
          {
            case 1:
            case 18:
              goto label_54;
            case 2:
              goto label_7;
            case 3:
              if (!oldValue.Equals(newValue))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 6 : 7;
                continue;
              }
              goto label_44;
            case 4:
              if (action1 != CheckType.Create)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 12 : 7;
                continue;
              }
              goto case 13;
            case 5:
              goto label_22;
            case 6:
              if (DeltaRestartBaseBehaviour.Y5cGrbbrEsS6MWx2Z0BM(oldValue.GetType(), newValue.GetType()))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 18 : 18;
                continue;
              }
              type2 = oldValue.GetType();
              num2 = 25;
              continue;
            case 7:
              goto label_43;
            case 8:
              if (!objects2.SequenceEqual<object>(objects1, (IEqualityComparer<object>) FunctorEqualityComparer<object>.Create((Func<object, object, bool>) ((o1, o2) => restartBaseBehaviour.Check(type1, action1, o1, o2) == PublicationType.Soft))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 16 : 23;
                continue;
              }
              goto label_32;
            case 9:
              goto label_33;
            case 10:
            case 22:
            case 31:
              if (oldValue == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 1 : 0;
                continue;
              }
              goto label_16;
            case 11:
              goto label_16;
            case 12:
              if (oldValue == null)
              {
                num2 = 26;
                continue;
              }
              break;
            case 13:
              if (!DeltaRestartBaseBehaviour.kDrrUObrh41dPHZ2xaab(newValue, type1))
              {
                num2 = 2;
                continue;
              }
              goto label_8;
            case 14:
              if (objects2.Count<object>() == objects1.Count<object>())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 8 : 2;
                continue;
              }
              goto label_31;
            case 15:
label_47:
              if (!(newValue is string str))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 2 : 22;
                continue;
              }
              goto case 16;
            case 16:
              if (!DeltaRestartBaseBehaviour.MFHHFcbrG8oLDT71yClM((object) str, (object) string.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 31 : 6;
                continue;
              }
              goto label_22;
            case 17:
              objects2 = ((IEnumerable) oldValue).Cast<object>();
              num2 = 27;
              continue;
            case 19:
              goto label_51;
            case 20:
              if (publicationType != PublicationType.Delta)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 5 : 28;
                continue;
              }
              goto label_4;
            case 21:
              type1 = type;
              num2 = 24;
              continue;
            case 23:
              goto label_31;
            case 24:
              action1 = action;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 4;
              continue;
            case 25:
              if (type2.IsClass)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            case 26:
              if (newValue == null)
              {
                num2 = 19;
                continue;
              }
              break;
            case 27:
              objects1 = ((IEnumerable) newValue).Cast<object>();
              num2 = 14;
              continue;
            case 28:
              goto label_3;
            case 29:
              restartBaseBehaviour = this;
              num2 = 21;
              continue;
            case 30:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 21 : 29;
              continue;
            default:
              // ISSUE: type reference
              if (!DeltaRestartBaseBehaviour.LrnhXTbrQ94Wgb7BOF4L(type2, DeltaRestartBaseBehaviour.qxHa82brfSHFLmvoU5jS(__typeref (string))))
              {
                if (!(oldValue is IEnumerable))
                {
                  num2 = 9;
                  continue;
                }
                goto case 17;
              }
              else
              {
                num2 = 3;
                continue;
              }
          }
          if (oldValue != null)
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 3 : 10;
          else
            goto label_47;
        }
label_16:
        if (newValue != null)
        {
          num1 = 6;
          continue;
        }
        goto label_54;
label_33:
        publicationType = DeltaRestartBaseBehaviour.tYOUn2brCr0gbDdJkRQl(oldValue, newValue);
        num1 = 20;
      }
label_3:
      return publicationType;
label_4:
      return type1;
label_7:
      return PublicationType.Restart;
label_8:
      return PublicationType.Delta;
label_22:
      return PublicationType.Delta;
label_31:
      return type1;
label_32:
      return PublicationType.Soft;
label_43:
      return type1;
label_44:
      return PublicationType.Soft;
label_51:
      return PublicationType.Soft;
label_54:
      return type1;
    }

    protected DeltaRestartBaseBehaviour()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool kDrrUObrh41dPHZ2xaab([In] object obj0, PublicationType type) => MetadataSoftPublishHelper.IsNewValuesDelta(obj0, type);

    internal static bool MFHHFcbrG8oLDT71yClM([In] object obj0, [In] object obj1) => ((string) obj0).Equals((string) obj1);

    internal static bool Y5cGrbbrEsS6MWx2Z0BM([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static Type qxHa82brfSHFLmvoU5jS([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool LrnhXTbrQ94Wgb7BOF4L([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static PublicationType tYOUn2brCr0gbDdJkRQl([In] object obj0, [In] object obj1) => MetadataSoftPublishHelper.IsEqualsObject(obj0, obj1);

    internal static bool WRh9FDbrodnnWOZoM0Mu() => DeltaRestartBaseBehaviour.ebs6UobrW7DEVWkWGkJ5 == null;

    internal static DeltaRestartBaseBehaviour u2O0Llbrb9mC6QUrJBuq() => DeltaRestartBaseBehaviour.ebs6UobrW7DEVWkWGkJ5;
  }
}
