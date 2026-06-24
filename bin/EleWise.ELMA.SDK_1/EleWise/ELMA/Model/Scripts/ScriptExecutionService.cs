// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.ScriptExecutionService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>Сервис, указывающий, что выполняется скрипт</summary>
  [Service]
  public class ScriptExecutionService
  {
    private readonly IContextBoundVariableService contextBoundVariableService;
    private static readonly ILogger ScriptLog;
    private static ScriptExecutionService XEx9Q6bSag1G0QHV7d51;

    public ScriptExecutionService(
      IContextBoundVariableService contextBoundVariableService)
    {
      ScriptExecutionService.e76harbSwVCo7HSZfxL3();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.contextBoundVariableService = contextBoundVariableService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>
    /// Включен ли сервис, т.е. идет ли выполенние скрипта в текущем контексте
    /// </summary>
    public bool Turned
    {
      get
      {
        bool flag;
        return this.contextBoundVariableService.TryGetValue<bool>((string) ScriptExecutionService.flsuHSbS4bLk3OpnyXU4(132912447 ^ 133081211), out flag) & flag;
      }
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
              ScriptExecutionService.RtI3mobS6UP9Zvr20A6d((object) this.contextBoundVariableService, ScriptExecutionService.flsuHSbS4bLk3OpnyXU4(-643786247 ^ -643685187), (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
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

    public static void ScriptExecution(System.Action action, string errorTitle)
    {
      int num1 = 1;
      ScriptExecutionService serviceNotNull;
      bool turned;
      while (true)
      {
        switch (num1)
        {
          case 1:
            serviceNotNull = Locator.GetServiceNotNull<ScriptExecutionService>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            goto label_15;
          case 4:
            ScriptExecutionService.kfIGBcbSH30qupgW46mf((object) serviceNotNull, true);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 2 : 0;
            continue;
          default:
            turned = serviceNotNull.Turned;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 4 : 4;
            continue;
        }
      }
label_15:
      return;
label_2:
      try
      {
        action();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_11;
            default:
              ILogger scriptLog = ScriptExecutionService.ScriptLog;
              string str = errorTitle;
              object obj1 = ScriptExecutionService.dCAQUPbSA9a3PqI40GhJ((object) ex);
              object obj2 = obj1 == null ? (object) ex : obj1;
              object obj3 = ScriptExecutionService.OYjlZ1bS7Q5WCe5CZ5Em((object) str, obj2);
              Exception exception = ex;
              ScriptExecutionService.CK2Ss5bSxZrM8FBD7CNU((object) scriptLog, obj3, (object) exception);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 0;
              continue;
          }
        }
label_11:
        throw;
      }
      finally
      {
        ScriptExecutionService.kfIGBcbSH30qupgW46mf((object) serviceNotNull, turned);
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
          num4 = 0;
        switch (num4)
        {
          default:
        }
      }
    }

    public static void MethodNotFound(Type type, string scriptName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ScriptExecutionService.ws3sPxbS0uOqlfgjYjW8((object) ScriptExecutionService.ScriptLog, (object) EleWise.ELMA.SR.T((string) ScriptExecutionService.flsuHSbS4bLk3OpnyXU4(-1426456882 ^ 2009939514 ^ -583632758), (object) type, (object) scriptName));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    static ScriptExecutionService()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ScriptExecutionService.ScriptLog = (ILogger) ScriptExecutionService.CvFZTmbSmmR8steSt9hS((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218797304));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
            continue;
          case 2:
            ScriptExecutionService.e76harbSwVCo7HSZfxL3();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void e76harbSwVCo7HSZfxL3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool EyAOJxbSDLnwxYee5MxR() => ScriptExecutionService.XEx9Q6bSag1G0QHV7d51 == null;

    internal static ScriptExecutionService SUfsO5bStj0rgoeGhOH9() => ScriptExecutionService.XEx9Q6bSag1G0QHV7d51;

    internal static object flsuHSbS4bLk3OpnyXU4(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void RtI3mobS6UP9Zvr20A6d([In] object obj0, [In] object obj1, [In] object obj2) => ((IAbstractBoundVariableService) obj0).Set((string) obj1, obj2);

    internal static void kfIGBcbSH30qupgW46mf([In] object obj0, bool value) => ((ScriptExecutionService) obj0).Turned = value;

    internal static object dCAQUPbSA9a3PqI40GhJ([In] object obj0) => (object) ((Exception) obj0).InnerException;

    internal static object OYjlZ1bS7Q5WCe5CZ5Em([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static void CK2Ss5bSxZrM8FBD7CNU([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static void ws3sPxbS0uOqlfgjYjW8([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static object CvFZTmbSmmR8steSt9hS([In] object obj0) => (object) EleWise.ELMA.Logging.Logger.GetLogger((string) obj0);
  }
}
