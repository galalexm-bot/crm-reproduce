// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.AuditEventArgs
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Dynamic;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Events.Audit
{
  /// <summary>Базовый класс события аудита</summary>
  [Serializable]
  public class AuditEventArgs : 
    EventArgs,
    IAuditEventArgs,
    IAuditEventHolder,
    IExtendedPropertiesContainer
  {
    protected IAuditObject auditObject;
    protected IAuditAction auditAction;
    private readonly IDictionary<string, object> _extendedProperties;
    internal static AuditEventArgs DfXak9GLJcTdi401ntN3;

    /// <summary>
    /// Initializes a new instance of the <see cref="T:EleWise.ELMA.Events.Audit.AuditEventArgs" /> class.
    /// </summary>
    public AuditEventArgs()
    {
      AuditEventArgs.ylZA3DGLlOpqLnsLoCuZ();
      this._extendedProperties = (IDictionary<string, object>) new Dictionary<string, object>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:EleWise.ELMA.Events.Audit.AuditEventArgs" /> class.
    /// </summary>
    public AuditEventArgs(IAuditObject auditObject, IAuditAction auditAction)
    {
      AuditEventArgs.ylZA3DGLlOpqLnsLoCuZ();
      this._extendedProperties = (IDictionary<string, object>) new Dictionary<string, object>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Initialize(auditObject, auditAction);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    protected void Initialize(IAuditObject @object, IAuditAction action)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            AuditEventArgs.pouqYsGLg5hpLbiFeVIy((object) this, (object) action);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
            continue;
          case 2:
            AuditEventArgs.DZsvj5GLrgEN0AefQUiH((object) this, (object) @object);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Объект события</summary>
    [JsonIgnore]
    public virtual IAuditObject Object
    {
      get => this.auditObject;
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
              this.auditObject = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
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

    /// <summary>Действие</summary>
    [JsonIgnore]
    public virtual IAuditAction Action
    {
      get => this.auditAction;
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
              this.auditAction = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
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

    /// <summary>Получить словарь свойств расширения объекта</summary>
    [JsonIgnore]
    public virtual IDictionary<string, object> ExtendedProperties => this._extendedProperties;

    private bool Equals(AuditEventArgs other)
    {
      int num1 = 17;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (AuditEventArgs.sxleleGLL2D0emfKcEKB((object) other) != null)
                goto case 5;
              else
                goto label_34;
            case 2:
              goto label_25;
            case 3:
              if (AuditEventArgs.sxleleGLL2D0emfKcEKB((object) this) != null)
              {
                num2 = 20;
                continue;
              }
              goto label_28;
            case 4:
              if (AuditEventArgs.sxleleGLL2D0emfKcEKB((object) this) != null)
              {
                num2 = 5;
                continue;
              }
              goto case 14;
            case 5:
              if (other.Action != null)
              {
                num2 = 3;
                continue;
              }
              goto label_28;
            case 6:
              goto label_27;
            case 7:
              if (other.ExtendedProperties.Count == AuditEventArgs.lpCGTXGLsEWEx0VfLJId((object) this.ExtendedProperties))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 2 : 1;
                continue;
              }
              goto label_26;
            case 8:
              if (this.ExtendedProperties == null)
              {
                num2 = 6;
                continue;
              }
              goto case 19;
            case 9:
              if (this.ExtendedProperties == null)
              {
                num2 = 11;
                continue;
              }
              goto case 7;
            case 10:
              if (AuditEventArgs.pcVkfhGLYi9EUrHXsCKw(other.Object.Uid, AuditEventArgs.pidJH2GLjlY6mDujwTgX(AuditEventArgs.DsJvgVGL5jSZL2gpJ372((object) this))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 1;
                continue;
              }
              goto label_28;
            case 11:
            case 13:
              goto label_26;
            case 12:
              goto label_17;
            case 14:
              if (other.ExtendedProperties == null)
              {
                num2 = 8;
                continue;
              }
              goto case 19;
            case 15:
              if (AuditEventArgs.DsJvgVGL5jSZL2gpJ372((object) this) != null)
              {
                num2 = 22;
                continue;
              }
              goto case 1;
            case 16:
              goto label_22;
            case 17:
              if (other == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 16 : 10;
                continue;
              }
              if (this != other)
              {
                if (other.Object == null)
                {
                  num2 = 15;
                  continue;
                }
                goto case 22;
              }
              else
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 12 : 12;
                continue;
              }
            case 19:
              if (other.ExtendedProperties != null)
                goto case 9;
              else
                goto label_16;
            case 20:
              if (!AuditEventArgs.pcVkfhGLYi9EUrHXsCKw(AuditEventArgs.FiJomZGLU46feYQhWSXX((object) other.Action), ((IAuditAction) AuditEventArgs.sxleleGLL2D0emfKcEKB((object) this)).Uid))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
                continue;
              }
              goto case 14;
            case 21:
              if (AuditEventArgs.DsJvgVGL5jSZL2gpJ372((object) this) == null)
              {
                num2 = 18;
                continue;
              }
              goto case 10;
            case 22:
              if (AuditEventArgs.DsJvgVGL5jSZL2gpJ372((object) other) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 21;
                continue;
              }
              goto label_28;
            default:
              goto label_28;
          }
        }
label_16:
        num1 = 13;
        continue;
label_34:
        num1 = 4;
      }
label_17:
      return true;
label_22:
      return false;
label_25:
      return !other.ExtendedProperties.Except<KeyValuePair<string, object>>((IEnumerable<KeyValuePair<string, object>>) this.ExtendedProperties).Any<KeyValuePair<string, object>>();
label_26:
      return false;
label_27:
      return true;
label_28:
      return false;
    }

    public override bool Equals(object obj)
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
              goto label_12;
            case 2:
              goto label_6;
            case 3:
              if (this != obj)
              {
                if (obj is AuditEventArgs)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 0;
                  continue;
                }
                goto label_11;
              }
              else
                goto label_5;
            case 4:
              if (obj != null)
              {
                num2 = 3;
                continue;
              }
              goto label_3;
            case 5:
              goto label_3;
            default:
              goto label_11;
          }
        }
label_5:
        num1 = 2;
      }
label_3:
      return false;
label_6:
      return true;
label_11:
      return false;
label_12:
      return this.Equals((AuditEventArgs) obj);
    }

    public override int GetHashCode()
    {
      int num1 = 1;
      int hashCode;
      IEnumerator<KeyValuePair<string, object>> enumerator;
      while (true)
      {
        Guid guid;
        int num2;
        switch (num1)
        {
          case 1:
            if (this.Object != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            int num3 = hashCode * 397;
            int num4;
            if (AuditEventArgs.sxleleGLL2D0emfKcEKB((object) this) == null)
            {
              num4 = 0;
            }
            else
            {
              guid = AuditEventArgs.FiJomZGLU46feYQhWSXX(AuditEventArgs.sxleleGLL2D0emfKcEKB((object) this));
              num4 = guid.GetHashCode();
            }
            hashCode = num3 ^ num4;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 8;
            continue;
          case 3:
            num2 = 0;
            break;
          case 4:
            goto label_26;
          case 5:
            enumerator = this.ExtendedProperties.GetEnumerator();
            num1 = 6;
            continue;
          case 6:
            goto label_5;
          case 7:
            num2 = guid.GetHashCode();
            break;
          case 8:
            if (this.ExtendedProperties != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 4 : 5;
              continue;
            }
            goto label_26;
          default:
            guid = AuditEventArgs.pidJH2GLjlY6mDujwTgX(AuditEventArgs.DsJvgVGL5jSZL2gpJ372((object) this));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 2 : 7;
            continue;
        }
        hashCode = num2;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 2 : 0;
      }
label_5:
      try
      {
label_15:
        if (AuditEventArgs.jQEgx2GLcnVQAsS3dEWo((object) enumerator))
          goto label_9;
        else
          goto label_16;
label_6:
        KeyValuePair<string, object> current;
        int num5;
        while (true)
        {
          switch (num5)
          {
            case 1:
              if (current.Key != null)
              {
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 5 : 6;
                continue;
              }
              goto case 3;
            case 2:
            case 5:
              goto label_15;
            case 3:
              if (current.Value == null)
              {
                num5 = 2;
                continue;
              }
              goto case 7;
            case 4:
              goto label_9;
            case 6:
              hashCode = hashCode * 397 ^ current.Key.GetHashCode();
              num5 = 3;
              continue;
            case 7:
              hashCode = hashCode * 397 ^ current.Value.GetHashCode();
              num5 = 5;
              continue;
            default:
              goto label_26;
          }
        }
label_9:
        current = enumerator.Current;
        num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
        {
          num5 = 1;
          goto label_6;
        }
        else
          goto label_6;
label_16:
        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
        goto label_6;
      }
      finally
      {
        if (enumerator != null)
        {
          int num6 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
            num6 = 1;
          while (true)
          {
            switch (num6)
            {
              case 1:
                AuditEventArgs.rQeiuCGLzhYH1JmVwHfl((object) enumerator);
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
                continue;
              default:
                goto label_22;
            }
          }
        }
label_22:;
      }
label_26:
      return hashCode;
    }

    internal static void ylZA3DGLlOpqLnsLoCuZ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Qh2yeHGL9xhCe4cR3Tpc() => AuditEventArgs.DfXak9GLJcTdi401ntN3 == null;

    internal static AuditEventArgs xIJEDbGLdkqReU198jD9() => AuditEventArgs.DfXak9GLJcTdi401ntN3;

    internal static void DZsvj5GLrgEN0AefQUiH([In] object obj0, [In] object obj1) => ((AuditEventArgs) obj0).Object = (IAuditObject) obj1;

    internal static void pouqYsGLg5hpLbiFeVIy([In] object obj0, [In] object obj1) => ((AuditEventArgs) obj0).Action = (IAuditAction) obj1;

    internal static object DsJvgVGL5jSZL2gpJ372([In] object obj0) => (object) ((AuditEventArgs) obj0).Object;

    internal static Guid pidJH2GLjlY6mDujwTgX([In] object obj0) => ((IAuditObject) obj0).Uid;

    internal static bool pcVkfhGLYi9EUrHXsCKw([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object sxleleGLL2D0emfKcEKB([In] object obj0) => (object) ((AuditEventArgs) obj0).Action;

    internal static Guid FiJomZGLU46feYQhWSXX([In] object obj0) => ((IAuditAction) obj0).Uid;

    internal static int lpCGTXGLsEWEx0VfLJId([In] object obj0) => ((ICollection<KeyValuePair<string, object>>) obj0).Count;

    internal static bool jQEgx2GLcnVQAsS3dEWo([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void rQeiuCGLzhYH1JmVwHfl([In] object obj0) => ((IDisposable) obj0).Dispose();
  }
}
