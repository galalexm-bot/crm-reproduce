// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.FormViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Представление в виде формы для конструктора форм</summary>
  [DebuggerTypeProxy(typeof (FormViewItem.DebugView))]
  [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_FormViewItem), "DisplayName")]
  [Serializable]
  public class FormViewItem : FormView, IContainerViewItem, IThemeContainerViewItem
  {
    internal static FormViewItem dx5aZFo26ct58dwCeCZf;

    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public override Guid Uid
    {
      get => base.Uid;
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
              base.Uid = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
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
    /// Уид метаданных объекта, для которого предназначена форма (не заполняется если форма предназначена для редактируемого объекта метаданных)
    /// </summary>
    public Guid GroupUid
    {
      get => this.\u003CGroupUid\u003Ek__BackingField;
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
              this.\u003CGroupUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
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

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeGroupUid() => FormViewItem.BDtySEo27qxkxWsqkZKD(this.GroupUid, Guid.Empty);

    /// <summary>
    /// Уид группы форм, к которой принадлежит форма (не заполняется если форма предназначена для редактируемого объекта метаданных)
    /// </summary>
    public Guid TargetUid
    {
      get => this.\u003CTargetUid\u003Ek__BackingField;
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
              this.\u003CTargetUid\u003Ek__BackingField = value;
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
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeTargetUid() => FormViewItem.BDtySEo27qxkxWsqkZKD(this.TargetUid, Guid.Empty);

    /// <summary>Отображаемое название формы</summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [EleWise.ELMA.Globalization.Localizable]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
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
    /// Указывает, что пустые свойства, расположенные на данной форме, должны скрываться
    /// </summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [Obsolete("Use HideEmptySettings instead", false)]
    [ForceDefaultValue(false)]
    [XmlForceElement]
    public bool HideEmptyChildProperties
    {
      get => false;
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
              this.HideEmpty = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
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

    /// <summary>Уникальный идентификатор основной области для вставки</summary>
    public Guid MainPlaceholderUid
    {
      get => this.\u003CMainPlaceholderUid\u003Ek__BackingField;
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
              this.\u003CMainPlaceholderUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
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

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeMainPlaceholderUid() => FormViewItem.BDtySEo27qxkxWsqkZKD(this.MainPlaceholderUid, Guid.Empty);

    /// <summary>Панель кнопок для формы</summary>
    public EleWise.ELMA.Model.Views.Toolbar.Toolbar Toolbar
    {
      get => this.\u003CToolbar\u003Ek__BackingField;
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
              this.\u003CToolbar\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
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

    /// <summary>Тема отображения</summary>
    public ViewItemTheme Theme
    {
      get => this.\u003CTheme\u003Ek__BackingField;
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
              this.\u003CTheme\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
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

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeTheme() => this.Theme != 0;

    /// <summary>Версия рантайма для рендера формы</summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue(RuntimeVersion.Version1)]
    public RuntimeVersion RuntimeVersion
    {
      get => this.\u003CRuntimeVersion\u003Ek__BackingField;
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
              this.\u003CRuntimeVersion\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
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
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Views.FormViewItem.RuntimeVersion" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeRuntimeVersion() => this.RuntimeVersion != 0;

    /// <inheritdoc />
    protected internal override void SetReadOnly() => base.SetReadOnly();

    /// <inheritdoc />
    protected internal override void SetReadOnly(bool value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.ReadOnly = new bool?(value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            base.SetReadOnly(value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    public bool IsValid() => this.IsValid(out ViewItem _);

    public bool IsValid(out ViewItem invalidItem)
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        ICollection<Guid> uids;
        Guid? nullable1;
        ICollection<Guid> guids;
        object obj;
        while (true)
        {
          Guid? nullable2;
          switch (num2)
          {
            case 1:
              goto label_16;
            case 2:
              guids = (ICollection<Guid>) new Guid[0];
              num2 = 3;
              continue;
            case 3:
              goto label_12;
            case 4:
              goto label_11;
            case 5:
              nullable2 = this.MetadataUid;
              break;
            case 6:
              if (!FormViewItem.BDtySEo27qxkxWsqkZKD(this.GroupUid, Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 5 : 5;
                continue;
              }
              nullable2 = new Guid?(this.GroupUid);
              break;
            case 7:
              invalidItem = FormViewItem.InvalidItem((object) this, uids, this.ViewType);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 4 : 4;
              continue;
            default:
              if (!nullable1.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 2 : 2;
                continue;
              }
              obj = (object) ViewItemMetadataAttribute.GetUids(MetadataLoader.LoadMetadata(nullable1.Value));
              if (obj == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 1;
                continue;
              }
              goto label_17;
          }
          nullable1 = nullable2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
        }
label_12:
        obj = (object) guids;
        goto label_17;
label_16:
        obj = (object) new Guid[1]{ nullable1.Value };
label_17:
        uids = (ICollection<Guid>) obj;
        num1 = 7;
      }
label_11:
      return invalidItem == null;
    }

    private static ViewItem InvalidItem(
      object parentViewItem,
      ICollection<Guid> uids,
      ViewType viewType)
    {
      if (parentViewItem is RootViewItem rootViewItem)
      {
        foreach (ViewItem parentViewItem1 in (EventedList<ViewItem>) rootViewItem.Items)
        {
          if (!ViewItemMetadataAttribute.IsAvailable(parentViewItem1.GetType(), uids) || !parentViewItem1.IsValid(viewType, (ViewItem) parentViewItem))
            return parentViewItem1;
          ViewItem viewItem = FormViewItem.InvalidItem((object) parentViewItem1, uids, viewType);
          if (viewItem != null)
            return viewItem;
        }
      }
      return (ViewItem) null;
    }

    public FormViewItem Transformate(ViewItemTransformation transformation)
    {
      int num = 3;
      FormViewItem formViewItem;
      ViewItemTransformation transformation1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            formViewItem = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
            continue;
          case 3:
            num = 2;
            continue;
          case 4:
            if (transformation1 != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            transformation1 = transformation;
            num = 4;
            continue;
        }
      }
label_3:
      return ContextCacheExtensions.GetCacheData<FormViewItem, ViewItemTransformation, FormViewItem>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234176836), this, transformation1, (Func<FormViewItem>) (() => (FormViewItem) ((ViewItem) formViewItem).Transformate(transformation1)));
label_4:
      return (FormViewItem) base.Transformate((ViewItemTransformation) null);
    }

    public FormViewItem()
    {
      FormViewItem.p8Mtxko2xJyGUMpp0SDx();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool lfqSRDo2HlFb6tOOlXxn() => FormViewItem.dx5aZFo26ct58dwCeCZf == null;

    internal static FormViewItem TvcAKTo2AwmZrDlr7TNU() => FormViewItem.dx5aZFo26ct58dwCeCZf;

    internal static bool BDtySEo27qxkxWsqkZKD([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static void p8Mtxko2xJyGUMpp0SDx() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    public new sealed class DebugView
    {
      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      private readonly FormViewItem viewItem;
      [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
      private readonly RootViewItem.DebugView _rootViewItemDebugView;
      internal static FormViewItem.DebugView ouy2PjCQKmkdhHrrpaIS;

      public DebugView(FormViewItem viewItem)
      {
        FormViewItem.DebugView.gMvJqJCQkvHfHelRN1oE();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              this._rootViewItemDebugView = new RootViewItem.DebugView((RootViewItem) viewItem);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            default:
              this.viewItem = viewItem;
              num = 2;
              continue;
          }
        }
label_3:;
      }

      public ViewType ViewType
      {
        get => this.viewItem.ViewType;
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
                this.viewItem.ViewType = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
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

      public bool? ReadOnly
      {
        get => this.viewItem.ReadOnly;
        set => this.viewItem.ReadOnly = value;
      }

      public EleWise.ELMA.Model.Views.Toolbar.Toolbar Toolbar
      {
        get => this.viewItem.Toolbar;
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
                FormViewItem.DebugView.EZPEhCCQnuE70gmh40d1((object) this.viewItem, (object) value);
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

      public string OnLoadScriptName
      {
        get => this.viewItem.OnLoadScriptName;
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
                FormViewItem.DebugView.QQCpZ6CQOtEr5eBeVmgl((object) this.viewItem, (object) value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
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

      internal static void gMvJqJCQkvHfHelRN1oE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool j2i6rsCQXluVPLZwAGNx() => FormViewItem.DebugView.ouy2PjCQKmkdhHrrpaIS == null;

      internal static FormViewItem.DebugView gr2xtMCQTjstHbiA9yTn() => FormViewItem.DebugView.ouy2PjCQKmkdhHrrpaIS;

      internal static void EZPEhCCQnuE70gmh40d1([In] object obj0, [In] object obj1) => ((FormViewItem) obj0).Toolbar = (EleWise.ELMA.Model.Views.Toolbar.Toolbar) obj1;

      internal static void QQCpZ6CQOtEr5eBeVmgl([In] object obj0, [In] object obj1) => ((FormView) obj0).OnLoadScriptName = (string) obj1;
    }
  }
}
