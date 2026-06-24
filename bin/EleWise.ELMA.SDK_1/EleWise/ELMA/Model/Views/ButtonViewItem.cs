// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ButtonViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views.Toolbox;
using EleWise.ELMA.Scripts.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Кнопка</summary>
  [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_ButtonViewItem), "DisplayName")]
  [Serializable]
  public class ButtonViewItem : RootViewItem, ITooltipViewItem
  {
    /// <summary>
    /// Уникальный идентификатор слота для страницы внутри кнопки
    /// </summary>
    public static Guid PageComponentSlotUid;
    internal static ButtonViewItem wo3hcaoTHlygQSADUcph;

    /// <summary>
    /// ID действия (ссылки) по нажатию на кнопку. null, если
    /// по нажатию на кнопку выполняется сценарий, а не
    /// осуществляется переход по ссылке
    /// </summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue(null)]
    public string ActionId
    {
      get => this.\u003CActionId\u003Ek__BackingField;
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
              this.\u003CActionId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
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

    /// <summary>ID провайдера типа действия (ссылки)</summary>
    [DefaultValue(null)]
    public string ActionTypeProviderId
    {
      get => this.\u003CActionTypeProviderId\u003Ek__BackingField;
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
              this.\u003CActionTypeProviderId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
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

    /// <summary>Стиль кнопки</summary>
    [DefaultValue(ButtonStyle.Default)]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public ButtonStyle ButtonStyle
    {
      get => this.\u003CButtonStyle\u003Ek__BackingField;
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
              this.\u003CButtonStyle\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
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

    /// <summary>Размер кнопки</summary>
    [DefaultValue(ViewItemButtonSize.Default)]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public ViewItemButtonSize ButtonSize
    {
      get => this.\u003CButtonSize\u003Ek__BackingField;
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
              this.\u003CButtonSize\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
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

    /// <summary>Форма кнопки</summary>
    [DefaultValue(ViewItemButtonShape.Default)]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public ViewItemButtonShape ButtonShape
    {
      get => this.\u003CButtonShape\u003Ek__BackingField;
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
              this.\u003CButtonShape\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
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

    /// <summary>
    /// Состояние кнопки в неактивном режиме родительской формы (readonly)
    /// </summary>
    [DefaultValue(ButtonInactiveState.Active)]
    public ButtonInactiveState ButtonInactiveState
    {
      get => this.\u003CButtonInactiveState\u003Ek__BackingField;
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
              this.\u003CButtonInactiveState\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
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

    /// <summary>Тип кнопки</summary>
    [DefaultValue(ViewItemButtonType.Fill)]
    public ViewItemButtonType ButtonType
    {
      get => this.\u003CButtonType\u003Ek__BackingField;
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
              this.\u003CButtonType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
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

    /// <summary>Отображать как гиперссылку</summary>
    [DefaultValue(false)]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public bool DisplayAsLink
    {
      get => this.\u003CDisplayAsLink\u003Ek__BackingField;
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
              this.\u003CDisplayAsLink\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
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

    /// <summary>Изображение-иконка</summary>
    [DefaultValue(null)]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public MetadataImage Image
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
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

    /// <summary>URL иконки</summary>
    [DefaultValue(null)]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public string ImageUrl
    {
      get => this.\u003CImageUrl\u003Ek__BackingField;
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
              this.\u003CImageUrl\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
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

    /// <summary>
    /// Отключена ли кнопка (отключенная кнопка отображается, но на нее нельзя нажать)
    /// </summary>
    [DefaultValue(false)]
    public bool IsDisabled
    {
      get => this.\u003CIsDisabled\u003Ek__BackingField;
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
              this.\u003CIsDisabled\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
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

    /// <summary>Минимальная ширина кнопки</summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue(null)]
    public int? MinWidth { get; set; }

    /// <summary>Название сценария</summary>
    [DefaultValue(null)]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public string ScriptName
    {
      get => this.\u003CScriptName\u003Ek__BackingField;
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
              this.\u003CScriptName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
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

    /// <summary>Тип сценария</summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue(CodeType.Server)]
    public CodeType CodeType
    {
      get => this.\u003CCodeType\u003Ek__BackingField;
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
              this.\u003CCodeType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
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

    /// <summary>Текст кнопки</summary>
    [EleWise.ELMA.Globalization.Localizable]
    [DefaultValue(null)]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public string Text
    {
      get => this.\u003CText\u003Ek__BackingField;
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
              this.\u003CText\u003Ek__BackingField = value;
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

    /// <summary>Тип текста</summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue(TextType.Default)]
    public TextType TextType
    {
      get => this.\u003CTextType\u003Ek__BackingField;
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
              this.\u003CTextType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
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

    /// <summary>Всплывающая подсказка</summary>
    [EleWise.ELMA.Globalization.Localizable]
    [DefaultValue(null)]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public string Tooltip
    {
      get => this.\u003CTooltip\u003Ek__BackingField;
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
              this.\u003CTooltip\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
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

    /// <summary>
    /// Обязательная валидация формы перед выполнением действия
    /// </summary>
    [DefaultValue(false)]
    public bool ValidationRequired
    {
      get => this.\u003CValidationRequired\u003Ek__BackingField;
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
              this.\u003CValidationRequired\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
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

    /// <summary>
    /// Data URI иконки (используется, если пользователь загрузил свою иконку)
    /// </summary>
    public string ImageSrc
    {
      get
      {
        int num = 1;
        string base64String;
        string str;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.Image == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
                continue;
              }
              str = (string) ButtonViewItem.tNiI5EoTymFi077IfFyj(ButtonViewItem.BNpcCqoTxxVnS3rk0nPh(-867826612 ^ -867935892), ButtonViewItem.RPWPnooTmUo8abQBQF7a((object) ButtonViewItem.XYcpRhoT0HjcAR46nZ2Q((object) this.Image).ToString()));
              num = 3;
              continue;
            case 2:
              goto label_7;
            case 3:
              base64String = Convert.ToBase64String((byte[]) ButtonViewItem.cP9j1FoTM4qa1EhjcX9n((object) this.Image));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 2 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return (string) null;
label_7:
        return (string) ButtonViewItem.uUSnf1oTJYm0Dr1Vhmgl(ButtonViewItem.BNpcCqoTxxVnS3rk0nPh(1669371371 ^ 1669515483), (object) str, (object) base64String);
      }
    }

    public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (parentViewItem != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return parentViewItem.IsChildValid((ViewItem) this);
label_5:
      return true;
    }

    /// <inheritdoc />
    public override bool IsChildValid(ViewItem childViewItem)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_8;
          case 2:
            if (!(ButtonViewItem.TDjSIooT9rpEi34Ii2jd((object) slotViewItem) == ButtonViewItem.PageComponentSlotUid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
              continue;
            }
            goto label_9;
          case 3:
            if (childViewItem is SlotViewItem slotViewItem)
            {
              num = 2;
              continue;
            }
            break;
          case 4:
            goto label_7;
          case 5:
            goto label_9;
        }
        if (!(childViewItem is DynamicListViewItem))
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 1 : 0;
        else
          break;
      }
label_7:
      return true;
label_8:
      return childViewItem is ButtonViewItem;
label_9:
      ListViewItem items = this.Items;
      // ISSUE: reference to a compiler-generated field
      Func<ViewItem, bool> func = ButtonViewItem.\u003C\u003Ec.\u003C\u003E9__77_0;
      Func<ViewItem, bool> predicate;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        ButtonViewItem.\u003C\u003Ec.\u003C\u003E9__77_0 = predicate = (Func<ViewItem, bool>) (item => item is SlotViewItem);
      }
      else
        goto label_2;
label_11:
      return !items.Any<ViewItem>(predicate);
label_2:
      predicate = func;
      goto label_11;
    }

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Views.ButtonViewItem.MinWidth" />
    /// </summary>
    /// <returns><c>true</c>, если нужно сериализовать свойство <see cref="P:EleWise.ELMA.Model.Views.ButtonViewItem.MinWidth" /></returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeMinWidth()
    {
      int num = 1;
      int? minWidth;
      while (true)
      {
        switch (num)
        {
          case 1:
            minWidth = this.MinWidth;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return minWidth.HasValue;
    }

    public ButtonViewItem()
    {
      ButtonViewItem.TcIu7goTdMcbcMQtPmxp();
      // ISSUE: reference to a compiler-generated field
      this.\u003CCodeType\u003Ek__BackingField = CodeType.Server;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ButtonViewItem()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ButtonViewItem.PageComponentSlotUid = new Guid((string) ButtonViewItem.BNpcCqoTxxVnS3rk0nPh(-1598106783 - -968262081 ^ -629733256));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool b4G0vDoTA5coZr7j87bk() => ButtonViewItem.wo3hcaoTHlygQSADUcph == null;

    internal static ButtonViewItem JkOXwFoT7edeDqQ0tggo() => ButtonViewItem.wo3hcaoTHlygQSADUcph;

    internal static object BNpcCqoTxxVnS3rk0nPh(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static ImageFormatType XYcpRhoT0HjcAR46nZ2Q([In] object obj0) => ((MetadataImage) obj0).Format;

    internal static object RPWPnooTmUo8abQBQF7a([In] object obj0) => (object) ((string) obj0).ToLower();

    internal static object tNiI5EoTymFi077IfFyj([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object cP9j1FoTM4qa1EhjcX9n([In] object obj0) => (object) ((MetadataImage) obj0).Data;

    internal static object uUSnf1oTJYm0Dr1Vhmgl([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static Guid TDjSIooT9rpEi34Ii2jd([In] object obj0) => ((SlotViewItem) obj0).PlaceholderUid;

    internal static void TcIu7goTdMcbcMQtPmxp() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    [Component(Order = 450)]
    private class ToolboxItem : CommonViewItemToolboxItem<ButtonViewItem>
    {
      private static object b965STCEv3HLpTpQeHF5;

      public ToolboxItem()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool TTL99YCE8INpK7j7W2BV() => ButtonViewItem.ToolboxItem.b965STCEv3HLpTpQeHF5 == null;

      internal static ButtonViewItem.ToolboxItem oSpuEqCEZthrJuDASXf9() => (ButtonViewItem.ToolboxItem) ButtonViewItem.ToolboxItem.b965STCEv3HLpTpQeHF5;
    }
  }
}
