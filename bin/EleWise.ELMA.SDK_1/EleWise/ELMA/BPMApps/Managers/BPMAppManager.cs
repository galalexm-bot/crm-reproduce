// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.Managers.BPMAppManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.BPMApps.Managers
{
  public class BPMAppManager : EntityManager<IBPMApp, long>
  {
    private static BPMAppManager z5Hr5YfnK2EEmniAUdYa;

    public static BPMAppManager Instance => Locator.GetServiceNotNull<BPMAppManager>();

    /// <summary>Загрузить по идентификатору</summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public virtual IBPMApp LoadOrNull(string id)
    {
      int num = 2;
      // ISSUE: variable of a compiler-generated type
      BPMAppManager.\u003C\u003Ec__DisplayClass2_0 cDisplayClass20;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass20.id = id;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass20 = new BPMAppManager.\u003C\u003Ec__DisplayClass2_0();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      // ISSUE: type reference
      ParameterExpression parameterExpression = (ParameterExpression) BPMAppManager.KigvShfnOtfylkbg5RGi(BPMAppManager.NbKxsYfnkULYdxQHpSnl(__typeref (IBPMApp)), BPMAppManager.tUVBFgfnn4q2rt0QEOok(1461625753 ^ 1461479443));
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: field reference
      return this.Find(Expression.Lambda<Func<IBPMApp, bool>>((Expression) BPMAppManager.Fb9bfCfnPJpOyiAjFYZn((object) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IBPMApp.get_AppId))), (object) Expression.Field((Expression) BPMAppManager.yPHrU9fn2kNo9swBsaUj((object) cDisplayClass20, BPMAppManager.NbKxsYfnkULYdxQHpSnl(__typeref (BPMAppManager.\u003C\u003Ec__DisplayClass2_0))), (FieldInfo) BPMAppManager.f90HMmfneRWxVoi6H7br(__fieldref (BPMAppManager.\u003C\u003Ec__DisplayClass2_0.id)))), parameterExpression)).FirstOrDefault<IBPMApp>();
    }

    /// <summary>Загрузить или создать новый объект IBpmApp</summary>
    /// <param name="id">ID объекта</param>
    /// <returns>Объект IBPMApp</returns>
    public IBPMApp LoadOrCreate(string id)
    {
      int num = 4;
      IBPMApp bpmApp;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 2:
            goto label_5;
          case 3:
            if (bpmApp != null)
            {
              num = 2;
              continue;
            }
            goto case 5;
          case 4:
            bpmApp = this.LoadOrNull(id);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 3 : 3;
            continue;
          case 5:
            bpmApp = this.Create();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
            continue;
          default:
            BPMAppManager.FRkK0Ifn1Wl8DfPWUDyy((object) bpmApp, (object) id);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 1;
            continue;
        }
      }
label_5:
      return bpmApp;
    }

    public BPMAppManager()
    {
      BPMAppManager.MRFCw2fnNmxjtnZhmWQ4();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type NbKxsYfnkULYdxQHpSnl([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object tUVBFgfnn4q2rt0QEOok(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object KigvShfnOtfylkbg5RGi([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object yPHrU9fn2kNo9swBsaUj([In] object obj0, [In] Type obj1) => (object) Expression.Constant(obj0, obj1);

    internal static object f90HMmfneRWxVoi6H7br([In] RuntimeFieldHandle obj0) => (object) FieldInfo.GetFieldFromHandle(obj0);

    internal static object Fb9bfCfnPJpOyiAjFYZn([In] object obj0, [In] object obj1) => (object) Expression.Equal((Expression) obj0, (Expression) obj1);

    internal static bool uTwt3yfnXuhUk9EpSwt9() => BPMAppManager.z5Hr5YfnK2EEmniAUdYa == null;

    internal static BPMAppManager RXFiRVfnTrugRnA5JrLD() => BPMAppManager.z5Hr5YfnK2EEmniAUdYa;

    internal static void FRkK0Ifn1Wl8DfPWUDyy([In] object obj0, [In] object obj1) => ((IBPMApp) obj0).AppId = (string) obj1;

    internal static void MRFCw2fnNmxjtnZhmWQ4() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
