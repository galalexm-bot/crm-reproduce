// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Actions.ActionImplAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Actions
{
  /// <summary>Абстрактный атрибут для системы действий</summary>
  [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
  [Serializable]
  public abstract class ActionImplAttribute : AuditableAttribute
  {
    private IAuditObject _auditObject;
    private IAuditAction _auditAction;
    private string _auditActionByUid;
    private Guid _auditActionUid;
    private Guid _auditObjectUid;
    private static ActionImplAttribute iEsqNffw06wj6xwQ1nJy;

    internal Guid AuditObjectUid
    {
      get => this._auditObjectUid;
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
              this._auditObjectUid = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
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

    protected void Apply(string actionTypeUid, string auditObjectUid = null)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_7;
            case 3:
              if (Guid.TryParse(actionTypeUid, out this._auditActionUid))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
                continue;
              }
              goto label_10;
            case 4:
              this._auditActionByUid = actionTypeUid;
              num2 = 3;
              continue;
            case 5:
              goto label_10;
            case 6:
              goto label_6;
            case 7:
              this._auditObjectUid = Guid.Empty;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 1 : 1;
              continue;
            default:
              if (Guid.TryParse(auditObjectUid, out this._auditObjectUid))
              {
                num2 = 6;
                continue;
              }
              goto case 7;
          }
        }
label_10:
        this._auditActionUid = Guid.Empty;
        num1 = 2;
      }
label_7:
      return;
label_6:;
    }

    private void Initialize()
    {
      int num = 1;
      IAuditManager serviceNotNull;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this._auditObjectUid == Guid.Empty)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
              continue;
            }
            if (!ActionImplAttribute.GsrgZZfw9s07ABKOpqwu(this._auditActionUid, Guid.Empty))
            {
              num = 8;
              continue;
            }
            goto label_20;
          case 2:
            goto label_23;
          case 3:
            goto label_7;
          case 4:
            this._auditObject = (IAuditObject) ActionImplAttribute.Gxkhxtfwdx5pd5YTfXUy((object) serviceNotNull, this._auditObjectUid);
            num = 6;
            continue;
          case 5:
            if (this._auditObject != null)
            {
              num = 3;
              continue;
            }
            goto case 14;
          case 6:
            if (this._auditObject == null)
            {
              num = 13;
              continue;
            }
            if (this._auditAction != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 2;
              continue;
            }
            goto case 11;
          case 7:
            goto label_20;
          case 8:
            if (this._auditAction != null)
            {
              num = 5;
              continue;
            }
            goto case 14;
          case 9:
            if (this._auditObject == null)
            {
              num = 4;
              continue;
            }
            goto case 6;
          case 10:
            goto label_6;
          case 11:
            this._auditAction = (IAuditAction) ActionImplAttribute.KQoDbPfwl6AbbdWmT4j4((object) serviceNotNull, (object) this._auditObject, this._auditActionUid);
            num = 12;
            continue;
          case 12:
            if (this._auditAction == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 10 : 1;
              continue;
            }
            goto label_24;
          case 13:
            goto label_13;
          case 14:
            serviceNotNull = Locator.GetServiceNotNull<IAuditManager>();
            num = 9;
            continue;
          default:
            goto label_25;
        }
      }
label_23:
      return;
label_7:
      return;
label_24:
      return;
label_6:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) ActionImplAttribute.tcLdgvfwMUqeZZM9hEr1(-643786247 ^ -643447269), (object) this._auditActionUid));
label_13:
      throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 396923812), (object) this._auditObjectUid));
label_20:
      throw new InvalidOperationException((string) ActionImplAttribute.nvl7WUfwJoaWUnCfDqco(ActionImplAttribute.tcLdgvfwMUqeZZM9hEr1(-787452571 ^ -787140023)));
label_25:
      throw new InvalidOperationException((string) ActionImplAttribute.nvl7WUfwJoaWUnCfDqco(ActionImplAttribute.tcLdgvfwMUqeZZM9hEr1(2045296739 + 1688595713 ^ -561253466)));
    }

    /// <summary>Получить действие, связанное с этим атрибутом</summary>
    /// <returns>Действие, связанное с этим атрибутом</returns>
    /// <exception cref="T:System.InvalidOperationException">Не задан индентификатор объекта действия для метода</exception>
    /// <exception cref="T:System.InvalidOperationException">Не задан ключ типа действия для метода</exception>
    /// <exception cref="T:System.InvalidOperationException">Не найден объект или тип действия для метода по ключу</exception>
    public virtual IAuditAction GetAction()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Initialize();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this._auditAction;
    }

    /// <summary>Получить объект, связанный с этим атрибутом</summary>
    /// <returns>Объект, связанный с этим атрибутом</returns>
    /// <exception cref="T:System.InvalidOperationException">Не задан индентификатор объекта действия для метода</exception>
    /// <exception cref="T:System.InvalidOperationException">Не задан ключ типа действия для метода</exception>
    /// <exception cref="T:System.InvalidOperationException">Не найден объект или тип действия для метода по ключу</exception>
    public virtual IAuditObject GetObject()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Initialize();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this._auditObject;
    }

    protected ActionImplAttribute()
    {
      ActionImplAttribute.rQwC7mfwrrksKYZRVu5R();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool NAcTUIfwmj4Eh8BEIrdj() => ActionImplAttribute.iEsqNffw06wj6xwQ1nJy == null;

    internal static ActionImplAttribute J1Ht30fwythEQgHinOCD() => ActionImplAttribute.iEsqNffw06wj6xwQ1nJy;

    internal static object tcLdgvfwMUqeZZM9hEr1(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object nvl7WUfwJoaWUnCfDqco([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool GsrgZZfw9s07ABKOpqwu([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object Gxkhxtfwdx5pd5YTfXUy([In] object obj0, Guid uid) => (object) ((IAuditManager) obj0).GetObject(uid);

    internal static object KQoDbPfwl6AbbdWmT4j4([In] object obj0, [In] object obj1, Guid uid) => (object) ((IAuditManager) obj0).GetAction((IAuditObject) obj1, uid);

    internal static void rQwC7mfwrrksKYZRVu5R() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
