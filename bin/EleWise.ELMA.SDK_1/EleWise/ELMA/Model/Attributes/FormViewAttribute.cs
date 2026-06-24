// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.FormViewAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут указывает представление карточки для класса или интерфейса
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
  public class FormViewAttribute : Attribute
  {
    private readonly string serializedView;
    private FormView view;
    private static FormViewAttribute G6Af4Lov3MWRGE2nTKfa;

    /// <summary>Ctor</summary>
    /// <param name="serializedView">Представление в XML-сериализованном виде</param>
    public FormViewAttribute(string serializedView)
    {
      FormViewAttribute.C98602ovDyhco5ykGllb();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.serializedView = serializedView;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Представление</summary>
    public FormView View
    {
      get
      {
        int num = 1;
        FormView view1;
        FormView view2;
        while (true)
        {
          switch (num)
          {
            case 1:
              view2 = this.view;
              if (view2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.view = view1 = this.DeserializeView(this.serializedView);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 2 : 2;
              continue;
          }
        }
label_2:
        return view2;
label_6:
        return view1;
      }
    }

    private FormView DeserializeView(string serializedView)
    {
      FormView formView;
      switch (1)
      {
        case 1:
          try
          {
            formView = ClassSerializationHelper.DeserializeObjectByXml<FormView>(serializedView);
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
              num = 0;
            switch (num)
            {
            }
          }
          catch (InvalidOperationException ex)
          {
            Exception exception = (Exception) FormViewAttribute.XXThmRovtuBCJOZOPXx2((object) ex);
            int num = 6;
            while (true)
            {
              switch (num)
              {
                case 1:
                  if (!(exception is InvalidOperationException))
                  {
                    num = 5;
                    continue;
                  }
                  break;
                case 2:
                  goto label_14;
                case 3:
                case 5:
                  goto label_13;
                case 4:
                  formView = (FormView) ClassSerializationHelper.DeserializeObjectByXml<FormViewItem>(serializedView);
                  num = 2;
                  continue;
                case 6:
                  if (exception != null)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 1 : 1;
                    continue;
                  }
                  goto label_13;
              }
              if (((string) FormViewAttribute.T5Ciweovw5qGTqLeiGCC((object) exception)).StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889605388), StringComparison.InvariantCulture))
                num = 4;
              else
                break;
            }
label_13:
            throw;
          }
          break;
      }
label_14:
      return formView;
    }

    internal static void C98602ovDyhco5ykGllb() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool F9yE7qovpFeQPLO2pSJX() => FormViewAttribute.G6Af4Lov3MWRGE2nTKfa == null;

    internal static FormViewAttribute danb9Qova3QsUwGMFlr1() => FormViewAttribute.G6Af4Lov3MWRGE2nTKfa;

    internal static object XXThmRovtuBCJOZOPXx2([In] object obj0) => (object) ((Exception) obj0).InnerException;

    internal static object T5Ciweovw5qGTqLeiGCC([In] object obj0) => (object) ((Exception) obj0).Message;
  }
}
