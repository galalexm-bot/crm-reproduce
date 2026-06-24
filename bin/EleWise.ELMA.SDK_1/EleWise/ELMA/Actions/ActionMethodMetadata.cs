// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Actions.ActionMethodMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Actions
{
  /// <summary>Описание данных для вызова действия</summary>
  [Serializable]
  public class ActionMethodMetadata : IAuditEventHolder
  {
    private readonly IAuditObject _auditObject;
    private readonly IAuditAction _auditAction;
    private readonly IList<ActionMethodArgument> _arguments;
    private readonly ActionMethodArgument _resultArgument;
    internal static ActionMethodMetadata eCLhggfwvUHJ16C4L728;

    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.Object" /> class.
    /// </summary>
    public ActionMethodMetadata(
      IAuditObject auditObject,
      IAuditAction auditAction,
      IList<ActionMethodArgument> arguments,
      ActionMethodArgument resultArgument)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this._auditObject = auditObject;
      this._auditAction = auditAction;
      this._arguments = arguments;
      this._resultArgument = resultArgument;
    }

    /// <summary>Объект события</summary>
    public IAuditObject Object => this._auditObject;

    /// <summary>Действие события</summary>
    public IAuditAction Action => this._auditAction;

    /// <summary>Данные, описывающие результат выполнения действия</summary>
    public ActionMethodArgument ResultArgument => this._resultArgument;

    /// <summary>Описание агрументов для выполнения действия</summary>
    public ReadOnlyCollection<ActionMethodArgument> Arguments => new ReadOnlyCollection<ActionMethodArgument>(this._arguments);

    /// <summary>Создать описание действия из метаданных метода</summary>
    /// <param name="auditObject">Объект события</param>
    /// <param name="auditAction">Тип действия события</param>
    /// <param name="methodInfo">Метаданные метода выполнения</param>
    /// <returns>Описание действия</returns>
    /// <exception cref="T:System.ArgumentNullException">Один из параметров передан как <c>null</c></exception>
    public static ActionMethodMetadata Create(
      [NotNull] IAuditObject auditObject,
      [NotNull] IAuditAction auditAction,
      [NotNull] MethodInfo methodInfo)
    {
      int num = 8;
      List<ActionMethodArgument> list;
      ActionMethodArgument resultArgument;
      while (true)
      {
        ActionMethodArgument actionMethodArgument;
        switch (num)
        {
          case 1:
            goto label_8;
          case 2:
            actionMethodArgument = new ActionMethodArgument((string) null, ActionMethodMetadata.X0FwQ0fwIDrcXlKiIdlL((object) methodInfo));
            break;
          case 3:
            goto label_11;
          case 4:
            // ISSUE: type reference
            if (ActionMethodMetadata.YMhm7ZfwSVBRunfjuUXl(ActionMethodMetadata.X0FwQ0fwIDrcXlKiIdlL((object) methodInfo), ActionMethodMetadata.O479PDfwV6btL6dWqSiq(__typeref (void))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 5:
            list = ((IEnumerable<ParameterInfo>) methodInfo.GetParameters()).Select<ParameterInfo, ActionMethodArgument>((Func<ParameterInfo, ActionMethodArgument>) (parameter => new ActionMethodArgument(parameter.Name, parameter.ParameterType))).ToList<ActionMethodArgument>();
            num = 6;
            continue;
          case 6:
            goto label_2;
          case 7:
            goto label_5;
          case 8:
            if (auditObject == null)
            {
              num = 7;
              continue;
            }
            if (auditAction == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 3 : 1;
              continue;
            }
            if (!(methodInfo == (MethodInfo) null))
            {
              num = 4;
              continue;
            }
            goto label_8;
          default:
            actionMethodArgument = new ActionMethodArgument((string) ActionMethodMetadata.tSrCvbfwR8LxD7tqmgJA(ActionMethodMetadata.X8hagEfwi45Nei7v8Oi5((object) methodInfo)), ActionMethodMetadata.alsa3XfwqhtivwxF70ZZ(ActionMethodMetadata.X8hagEfwi45Nei7v8Oi5((object) methodInfo)));
            break;
        }
        resultArgument = actionMethodArgument;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 5;
      }
label_2:
      return new ActionMethodMetadata(auditObject, auditAction, (IList<ActionMethodArgument>) list, resultArgument);
label_5:
      throw new ArgumentNullException((string) ActionMethodMetadata.MLr4KqfwuMH5SdsXmCQv(1051802738 - -1831968059 ^ -1410889749));
label_8:
      throw new ArgumentNullException((string) ActionMethodMetadata.MLr4KqfwuMH5SdsXmCQv(-1858887263 ^ -1858668259));
label_11:
      throw new ArgumentNullException((string) ActionMethodMetadata.MLr4KqfwuMH5SdsXmCQv(901793403 ^ 902109211));
    }

    internal static object MLr4KqfwuMH5SdsXmCQv(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type X0FwQ0fwIDrcXlKiIdlL([In] object obj0) => ((MethodInfo) obj0).ReturnType;

    internal static Type O479PDfwV6btL6dWqSiq([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool YMhm7ZfwSVBRunfjuUXl([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object X8hagEfwi45Nei7v8Oi5([In] object obj0) => (object) ((MethodInfo) obj0).ReturnParameter;

    internal static object tSrCvbfwR8LxD7tqmgJA([In] object obj0) => (object) ((ParameterInfo) obj0).Name;

    internal static Type alsa3XfwqhtivwxF70ZZ([In] object obj0) => ((ParameterInfo) obj0).ParameterType;

    internal static bool Nnv2s4fw839Uex78rBMr() => ActionMethodMetadata.eCLhggfwvUHJ16C4L728 == null;

    internal static ActionMethodMetadata OLoWZjfwZIRttir9LSdd() => ActionMethodMetadata.eCLhggfwvUHJ16C4L728;
  }
}
