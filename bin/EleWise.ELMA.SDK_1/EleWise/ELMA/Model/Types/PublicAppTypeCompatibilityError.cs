// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.PublicAppTypeCompatibilityError
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.API.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>
  /// Результат возможности отображения свойств определенного типа данных во внешних приложениях (ошибка или предупреждение)
  /// </summary>
  public class PublicAppTypeCompatibilityError : IPublicApplicationCompatibilityError
  {
    private string _typeCode;
    private string _typeName;
    private bool? _isReadOnly;
    private List<string> _propertyNames;
    internal static PublicAppTypeCompatibilityError IhrsjRoyCXomZPYSOlTa;

    public PublicAppTypeCompatibilityError(
      string typeCode,
      string typeName,
      bool? isReadOnly,
      params string[] propertyNames)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this._propertyNames = new List<string>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this._typeCode = typeCode;
      this._typeName = typeName;
      this._isReadOnly = isReadOnly;
      if (propertyNames != null)
        this._propertyNames.AddRange((IEnumerable<string>) propertyNames);
      this.IsError = true;
    }

    /// <summary>Если True, то это ошибка. Иначе предупреждение.</summary>
    public bool IsError
    {
      get => this.\u003CIsError\u003Ek__BackingField;
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
              this.\u003CIsError\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
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

    /// <summary>Сообщение об ошибке</summary>
    public string Message
    {
      get
      {
        int num = 2;
        bool? isReadOnly;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (isReadOnly.HasValue)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
                continue;
              }
              goto label_13;
            case 2:
              isReadOnly = this.IsReadOnly;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_8;
            case 4:
              if (!isReadOnly.Value)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 3 : 2;
                continue;
              }
              goto label_12;
            default:
              isReadOnly = this.IsReadOnly;
              num = 4;
              continue;
          }
        }
label_8:
        string t1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874172343);
        object[] objArray1 = new object[2]
        {
          (object) this._typeName,
          null
        };
        object obj = PublicAppTypeCompatibilityError.YjeFNwoyZ3F6uAh4Vykv(-1876063057 ^ -1876066131);
        List<string> propertyNames1 = this._propertyNames;
        Func<string, string> func1 = PublicAppTypeCompatibilityError.\u003C\u003Ec.\u003C\u003E9__6_2;
        Func<string, string> selector1;
        if (func1 == null)
          PublicAppTypeCompatibilityError.\u003C\u003Ec.\u003C\u003E9__6_2 = selector1 = (Func<string, string>) (p => (string) PublicAppTypeCompatibilityError.\u003C\u003Ec.oJxnILCVHrwEIXkwLERU(~541731958 ^ -541733161) + p + (string) PublicAppTypeCompatibilityError.\u003C\u003Ec.oJxnILCVHrwEIXkwLERU(-740338220 ^ -740341622));
        else
          goto label_16;
label_11:
        string[] array1 = propertyNames1.Select<string, string>(selector1).ToArray<string>();
        objArray1[1] = PublicAppTypeCompatibilityError.L3CX8ZoyuPIbqlbBwETe(obj, (object) array1);
        return EleWise.ELMA.SR.T(t1, objArray1);
label_16:
        selector1 = func1;
        goto label_11;
label_12:
        return EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121058407), (object) this._typeName, PublicAppTypeCompatibilityError.L3CX8ZoyuPIbqlbBwETe((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488878135), (object) this._propertyNames.Select<string, string>((Func<string, string>) (p => (string) PublicAppTypeCompatibilityError.\u003C\u003Ec.dwlyW0CVAk1deikMjSWb(PublicAppTypeCompatibilityError.\u003C\u003Ec.oJxnILCVHrwEIXkwLERU(-1334993905 ^ -1335000751), (object) p, PublicAppTypeCompatibilityError.\u003C\u003Ec.oJxnILCVHrwEIXkwLERU(572119659 - -337058038 ^ 909176383)))).ToArray<string>()));
label_13:
        object t2 = PublicAppTypeCompatibilityError.YjeFNwoyZ3F6uAh4Vykv(-420743386 ^ -420912090);
        object[] objArray2 = new object[2]
        {
          (object) this._typeName,
          null
        };
        string str = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643787269);
        List<string> propertyNames2 = this._propertyNames;
        Func<string, string> func2 = PublicAppTypeCompatibilityError.\u003C\u003Ec.\u003C\u003E9__6_0;
        Func<string, string> selector2;
        if (func2 == null)
          PublicAppTypeCompatibilityError.\u003C\u003Ec.\u003C\u003E9__6_0 = selector2 = (Func<string, string>) (p => (string) PublicAppTypeCompatibilityError.\u003C\u003Ec.dwlyW0CVAk1deikMjSWb(PublicAppTypeCompatibilityError.\u003C\u003Ec.oJxnILCVHrwEIXkwLERU(-345420348 ^ -345419622), (object) p, PublicAppTypeCompatibilityError.\u003C\u003Ec.oJxnILCVHrwEIXkwLERU(1051276242 - 990076387 ^ 61196465)));
        else
          goto label_9;
label_15:
        string[] array2 = propertyNames2.Select<string, string>(selector2).ToArray<string>();
        objArray2[1] = PublicAppTypeCompatibilityError.L3CX8ZoyuPIbqlbBwETe((object) str, (object) array2);
        return EleWise.ELMA.SR.T((string) t2, objArray2);
label_9:
        selector2 = func2;
        goto label_15;
      }
    }

    /// <summary>Код типа</summary>
    public string TypeCode => this._typeCode;

    /// <summary>Имя типа</summary>
    public string TypeName => this._typeName;

    /// <summary>
    /// Указывает режим отображения, к которому относится данная ошибка. Если null, то для обоих режимов.
    /// </summary>
    public bool? IsReadOnly => this._isReadOnly;

    /// <summary>Имена свойств с данным типом</summary>
    public List<string> PropertyNames => this._propertyNames;

    internal static bool uKFbDkoyvSyKtjTuvAsB() => PublicAppTypeCompatibilityError.IhrsjRoyCXomZPYSOlTa == null;

    internal static PublicAppTypeCompatibilityError HaR73Yoy8y2KXF7HZKSm() => PublicAppTypeCompatibilityError.IhrsjRoyCXomZPYSOlTa;

    internal static object YjeFNwoyZ3F6uAh4Vykv(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object L3CX8ZoyuPIbqlbBwETe([In] object obj0, [In] object obj1) => (object) string.Join((string) obj0, (string[]) obj1);
  }
}
