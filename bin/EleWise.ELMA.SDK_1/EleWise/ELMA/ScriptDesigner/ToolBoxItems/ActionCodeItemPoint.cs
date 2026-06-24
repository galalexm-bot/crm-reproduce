// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.ToolBoxItems.ActionCodeItemPoint
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.API;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems
{
  [Serializable]
  public class ActionCodeItemPoint : IActionCodeItemPoint
  {
    internal static ActionCodeItemPoint rAXyLgu3lDSJoispIms;

    public ActionCodeItemPoint()
    {
      ActionCodeItemPoint.QnBxjLuDOiVYDDH5Zq9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ActionCodeItemPoint(MethodInfo info, string callPath, int order)
    {
      ActionCodeItemPoint.QnBxjLuDOiVYDDH5Zq9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 5;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.InitializeParameters(info);
            num = 6;
            continue;
          case 3:
            // ISSUE: type reference
            this.ReturnType = ActionCodeItemPoint.xdoQFCu6uZqR3MmRTMf(ActionCodeItemPoint.pwwQ34uwxTrtxaj1Vo1((object) info), ActionCodeItemPoint.EsHGDNu4cyeuwg4xUrf(__typeref (void))) ? new DesignerParameterInfo((string) ActionCodeItemPoint.CZEcyQuH1xMLoA3a44t(372753449 ^ 372739551), ActionCodeItemPoint.pwwQ34uwxTrtxaj1Vo1((object) info), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082384158), 0) : (DesignerParameterInfo) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 7 : 5;
            continue;
          case 4:
            this.Description = (string) ActionCodeItemPoint.TWdFM3uA7LV1RgyhU8n((object) info);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 1 : 1;
            continue;
          case 5:
            this.Parameters = new List<DesignerParameterInfo>();
            num = 2;
            continue;
          case 6:
            this.Name = (string) ActionCodeItemPoint.ao1vREutlopm1RXomaq((object) info);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          case 7:
            this.CallPath = callPath;
            num = 4;
            continue;
          default:
            this.Order = order;
            num = 3;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Наименование</summary>
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
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
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
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

    /// <summary>Порядковый номер действия</summary>
    public int Order
    {
      get => this.\u003COrder\u003Ek__BackingField;
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
              this.\u003COrder\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
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

    /// <summary>Отображаемое имя</summary>
    public string DisplayName
    {
      get => this.\u003CDisplayName\u003Ek__BackingField;
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
              this.\u003CDisplayName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
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

    /// <summary>Описание действия</summary>
    public string Description
    {
      get => this.\u003CDescription\u003Ek__BackingField;
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
              this.\u003CDescription\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
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

    /// <summary>Параметры метода</summary>
    public List<DesignerParameterInfo> Parameters { get; set; }

    /// <summary>Возвращаемый параметр</summary>
    public DesignerParameterInfo ReturnType
    {
      get => this.\u003CReturnType\u003Ek__BackingField;
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
              this.\u003CReturnType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
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

    /// <summary>Путь вызова метода</summary>
    public string CallPath
    {
      get => this.\u003CCallPath\u003Ek__BackingField;
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
              this.\u003CCallPath\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
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

    /// <summary>Иконка</summary>
    public Image Image
    {
      get => this.\u003CImage\u003Ek__BackingField;
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
              this.\u003CImage\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
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

    /// <summary>Инициализировать параметры</summary>
    /// <param name="info"></param>
    private void InitializeParameters(MethodInfo info)
    {
      switch (1)
      {
        case 1:
          try
          {
            Dictionary<string, string> parametersDescription = XmlCommentsHelper.GetParametersDescription(info);
            int num = 4;
            int index;
            ParameterInfo[] parameterInfoArray;
            ParameterInfo[] parameters;
            ParameterInfo parameterInfo;
            string description;
            int order;
            DesignerParameterInfo designerParameterInfo;
            bool flag;
            while (true)
            {
              switch (num)
              {
                case 1:
                  this.Parameters.Add(designerParameterInfo);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 2 : 2;
                  continue;
                case 2:
                  ++index;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 7 : 3;
                  continue;
                case 3:
                  parametersDescription.TryGetValue((string) ActionCodeItemPoint.B4Z8Hqu74fVgDFBpdj2((object) parameterInfo), out description);
                  num = 10;
                  continue;
                case 4:
                  parameters = info.GetParameters();
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 6 : 11;
                  continue;
                case 5:
                  parameterInfo = parameterInfoArray[index];
                  num = 6;
                  continue;
                case 6:
                  flag = AttributeHelper<RequiredParameterAttribute>.GetAttribute(parameterInfo, false) != null;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 3 : 1;
                  continue;
                case 7:
                case 12:
                  if (index >= parameterInfoArray.Length)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 8 : 2;
                    continue;
                  }
                  goto case 5;
                case 8:
                  goto label_18;
                case 9:
                  index = 0;
                  num = 12;
                  continue;
                case 10:
                  order = EnumerableExtensions.IndexOf(parameters, (object) parameterInfo);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
                  continue;
                case 11:
                  parameterInfoArray = parameters;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 9 : 9;
                  continue;
                case 13:
                  designerParameterInfo.Required = flag;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 0;
                  continue;
                default:
                  designerParameterInfo = new DesignerParameterInfo((string) ActionCodeItemPoint.B4Z8Hqu74fVgDFBpdj2((object) parameterInfo), ActionCodeItemPoint.dvxuy4uxi2bQqUiVgLd((object) parameterInfo), description, order);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 7 : 13;
                  continue;
              }
            }
label_18:
            break;
          }
          catch
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
              num = 0;
            switch (num)
            {
              case 0:
                return;
              default:
                return;
            }
          }
      }
    }

    internal static void QnBxjLuDOiVYDDH5Zq9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool IEAEJrup8jgZSeeMDQo() => ActionCodeItemPoint.rAXyLgu3lDSJoispIms == null;

    internal static ActionCodeItemPoint DWYw0puahk6da7a991F() => ActionCodeItemPoint.rAXyLgu3lDSJoispIms;

    internal static object ao1vREutlopm1RXomaq([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static Type pwwQ34uwxTrtxaj1Vo1([In] object obj0) => ((MethodInfo) obj0).ReturnType;

    internal static Type EsHGDNu4cyeuwg4xUrf([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool xdoQFCu6uZqR3MmRTMf([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object CZEcyQuH1xMLoA3a44t(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object TWdFM3uA7LV1RgyhU8n([In] object obj0) => (object) ((MethodInfo) obj0).GetFullComments();

    internal static object B4Z8Hqu74fVgDFBpdj2([In] object obj0) => (object) ((ParameterInfo) obj0).Name;

    internal static Type dvxuy4uxi2bQqUiVgLd([In] object obj0) => ((ParameterInfo) obj0).ParameterType;
  }
}
