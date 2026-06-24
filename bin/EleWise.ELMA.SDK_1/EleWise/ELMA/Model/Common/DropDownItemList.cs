// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Common.DropDownItemList
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Web.Mvc;

namespace EleWise.ELMA.Model.Common
{
  /// <summary>Список элементов выпадающего списка</summary>
  public class DropDownItemList : List<DropDownItem>
  {
    internal static DropDownItemList J6HiW1hKYwL1aaLVdhDO;

    /// <summary>Сформировать список из строкового представления</summary>
    /// <param name="itemsString">Список элементов в виде строки</param>
    public void Parse(string itemsString)
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        string str;
        int index;
        string[] strArray;
        while (true)
        {
          switch (num2)
          {
            case 1:
              index = 0;
              num2 = 2;
              continue;
            case 2:
            case 8:
              if (index >= strArray.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 3 : 7;
                continue;
              }
              goto case 9;
            case 3:
              this.Add(new DropDownItem((string) DropDownItemList.VeqVg8hXBxZEBjiloIOs(DropDownItemList.VeqVg8hXBxZEBjiloIOs((object) str, DropDownItemList.zOyOqAhKcRBARgjpDZa7(979449278 ^ 979529796), DropDownItemList.zOyOqAhKcRBARgjpDZa7(323422137 << 2 ^ 1293680668)), DropDownItemList.zOyOqAhKcRBARgjpDZa7(647913418 ^ 647829954), DropDownItemList.zOyOqAhKcRBARgjpDZa7(~289714581 ^ -289713714))));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
              continue;
            case 4:
              goto label_5;
            case 5:
              if (!string.IsNullOrEmpty(itemsString))
              {
                strArray = (string[]) DropDownItemList.E704DwhXFAdiIMlLiFcn((object) itemsString, DropDownItemList.xxU6NFhKz5p1tslkiFPV(DropDownItemList.zOyOqAhKcRBARgjpDZa7(1251470110 >> 2 ^ 312842745)), StringSplitOptions.RemoveEmptyEntries);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 1;
                continue;
              }
              goto label_12;
            case 6:
              DropDownItemList.JPa5hNhKsrt5FaasQVrg((object) this);
              num2 = 5;
              continue;
            case 7:
              goto label_14;
            case 9:
              str = strArray[index];
              num2 = 3;
              continue;
            default:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 8 : 8;
              continue;
          }
        }
label_12:
        num1 = 4;
      }
label_5:
      return;
label_14:;
    }

    /// <summary>Список элементов в виде строки</summary>
    /// <returns>Строковое представление</returns>
    public override string ToString()
    {
      int num1 = 3;
      StringBuilder stringBuilder;
      while (true)
      {
        int num2 = num1;
        int index;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 5:
              if (index >= DropDownItemList.ja82FQhXovevm32QbUWm((object) this))
              {
                num2 = 8;
                continue;
              }
              goto case 6;
            case 2:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 1;
              continue;
            case 3:
              stringBuilder = new StringBuilder();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 1 : 2;
              continue;
            case 4:
              DropDownItemList.FaW4iBhXW9mOM2fdASZb((object) stringBuilder, DropDownItemList.VeqVg8hXBxZEBjiloIOs(DropDownItemList.VeqVg8hXBxZEBjiloIOs((object) this[index].ToString(), DropDownItemList.zOyOqAhKcRBARgjpDZa7(-70007027 ^ -70002187), DropDownItemList.zOyOqAhKcRBARgjpDZa7(-1939377524 ^ -1939589258)), DropDownItemList.zOyOqAhKcRBARgjpDZa7(1012087039 ^ 1012082523), DropDownItemList.zOyOqAhKcRBARgjpDZa7(236071375 ^ 236023751)));
              num2 = 7;
              continue;
            case 6:
              if (index > 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 7:
              goto label_3;
            case 8:
              goto label_4;
            default:
              DropDownItemList.FaW4iBhXW9mOM2fdASZb((object) stringBuilder, DropDownItemList.zOyOqAhKcRBARgjpDZa7(1251470110 >> 2 ^ 312842745));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 4 : 2;
              continue;
          }
        }
label_3:
        ++index;
        num1 = 5;
      }
label_4:
      return stringBuilder.ToString();
    }

    /// <summary>
    /// Преобразовать в список элементов для отображения в вебе
    /// </summary>
    /// <param name="addEmptyItem">Добавлять пустой элемент</param>
    /// <returns>Список элементов для отображения в вебе</returns>
    public IEnumerable<SelectListItem> ToMvcListItems(bool addEmptyItem = false) => (IEnumerable<SelectListItem>) new DropDownItemList.\u003CToMvcListItems\u003Ed__2(-2)
    {
      \u003C\u003E4__this = this,
      \u003C\u003E3__addEmptyItem = addEmptyItem
    };

    public DropDownItemList()
    {
      DropDownItemList.YoAaUPhXbwHUE4uVHkht();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void JPa5hNhKsrt5FaasQVrg([In] object obj0) => __nonvirtual (((List<DropDownItem>) obj0).Clear());

    internal static object zOyOqAhKcRBARgjpDZa7(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object xxU6NFhKz5p1tslkiFPV([In] object obj0) => (object) ((string) obj0).ToCharArray();

    internal static object E704DwhXFAdiIMlLiFcn([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2) => (object) ((string) obj0).Split((char[]) obj1, obj2);

    internal static object VeqVg8hXBxZEBjiloIOs([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static bool L31u1rhKLaFevYuX338Q() => DropDownItemList.J6HiW1hKYwL1aaLVdhDO == null;

    internal static DropDownItemList gdXUIshKUQMS27GyGXYn() => DropDownItemList.J6HiW1hKYwL1aaLVdhDO;

    internal static object FaW4iBhXW9mOM2fdASZb([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static int ja82FQhXovevm32QbUWm([In] object obj0) => __nonvirtual (((List<DropDownItem>) obj0).Count);

    internal static void YoAaUPhXbwHUE4uVHkht() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
