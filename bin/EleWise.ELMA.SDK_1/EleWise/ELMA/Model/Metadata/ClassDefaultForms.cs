// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.ClassDefaultForms
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Привязки типов форм к самим формам</summary>
  [Serializable]
  public class ClassDefaultForms
  {
    [OptionalField]
    private List<ActionForm> actionGuids;
    private ClassMetadata owner;
    [OptionalField]
    private List<DefaultFormSetting> formSettings;
    internal static ClassDefaultForms iGjGRBbthoaxn88GVXgT;

    public ClassDefaultForms()
    {
      ClassDefaultForms.k7LFTRbtfmBulZ2mwbxh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.FormSettings = new List<DefaultFormSetting>();
            num = 2;
            continue;
          case 2:
            goto label_3;
          default:
            this.ActionGuids = new List<ActionForm>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerialize()
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!ClassDefaultForms.cUB5kfbtQlZHBwOCnbNp((object) this))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
                continue;
              }
              goto label_10;
            case 2:
              if (ClassDefaultForms.RYungUbtvWxu2iO7P9wc((object) this))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 6 : 2;
                continue;
              }
              goto label_9;
            case 3:
              if (!ClassDefaultForms.ylScGIbtCnWRj0vjU0XD((object) this))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 2 : 0;
                continue;
              }
              goto label_10;
            case 4:
              goto label_9;
            case 5:
            case 6:
              goto label_10;
            default:
              if (!this.ShouldSerializeEditUid())
                goto case 3;
              else
                goto label_4;
          }
        }
label_4:
        num1 = 5;
      }
label_9:
      return ClassDefaultForms.DRkefXbt8ydiJE3BFJlB((object) this);
label_10:
      return true;
    }

    /// <summary>Уникальный идентификатор формы создания объекта</summary>
    public Guid CreateUid
    {
      get => this.\u003CCreateUid\u003Ek__BackingField;
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
              this.\u003CCreateUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
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
    public virtual bool ShouldSerializeCreateUid() => this.CreateUid != Guid.Empty;

    /// <summary>Уникальный идентификатор формы редактирования объекта</summary>
    public Guid EditUid
    {
      get => this.\u003CEditUid\u003Ek__BackingField;
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
              this.\u003CEditUid\u003Ek__BackingField = value;
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

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeEditUid() => this.EditUid != Guid.Empty;

    /// <summary>Уникальный идентификатор формы просмотра объекта</summary>
    public Guid DisplayUid
    {
      get => this.\u003CDisplayUid\u003Ek__BackingField;
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
              this.\u003CDisplayUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
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
    public virtual bool ShouldSerializeDisplayUid() => ClassDefaultForms.GOi8vSbtZgAEIB0SXK2P(this.DisplayUid, Guid.Empty);

    /// <summary>Уникальные идентификаторы форм на действия с объектом</summary>
    public List<ActionForm> ActionGuids
    {
      get => this.actionGuids;
      set => this.actionGuids = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeActionGuids()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.ActionGuids != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return ClassDefaultForms.XwykP5btuKcgyNfJVeQX((object) this.ActionGuids) > 0;
label_5:
      return false;
    }

    /// <summary>Настройки форм</summary>
    public List<DefaultFormSetting> FormSettings
    {
      get => this.formSettings;
      set => this.formSettings = value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeFormSettings()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (this.FormSettings == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return this.FormSettings.Count > 0;
label_3:
      return false;
    }

    /// <summary>Форма создания</summary>
    public FormViewItem Create => this.GetForm(this.CreateUid);

    /// <summary>Форма редактирования</summary>
    public FormViewItem Edit => this.GetForm(this.EditUid);

    /// <summary>Форма просмотра</summary>
    public FormViewItem Display => this.GetForm(this.DisplayUid);

    /// <summary>
    /// Преобразовать в словарь "Тип представления-&gt;Уникальный идентификатор формы"
    /// </summary>
    /// <returns></returns>
    public List<Tuple<ViewType, Guid, Guid, Guid, Guid, bool>> ToDictionary()
    {
      List<Tuple<ViewType, Guid, Guid, Guid, Guid, bool>> dictionary = new List<Tuple<ViewType, Guid, Guid, Guid, Guid, bool>>();
      if (this.CreateUid != Guid.Empty)
        dictionary.Add(new Tuple<ViewType, Guid, Guid, Guid, Guid, bool>(ViewType.Create, Guid.Empty, this.CreateUid, Guid.Empty, Guid.Empty, false));
      if (this.EditUid != Guid.Empty)
        dictionary.Add(new Tuple<ViewType, Guid, Guid, Guid, Guid, bool>(ViewType.Edit, Guid.Empty, this.EditUid, Guid.Empty, Guid.Empty, false));
      if (this.DisplayUid != Guid.Empty)
        dictionary.Add(new Tuple<ViewType, Guid, Guid, Guid, Guid, bool>(ViewType.Display, Guid.Empty, this.DisplayUid, Guid.Empty, Guid.Empty, false));
      if (this.ActionGuids != null)
      {
        foreach (ActionForm actionGuid in this.ActionGuids)
          dictionary.Add(new Tuple<ViewType, Guid, Guid, Guid, Guid, bool>(ViewType.Custom, actionGuid.ActionTypeUid, actionGuid.ActionUid, actionGuid.GroupUid, actionGuid.Target, actionGuid.DeletedFromChild));
      }
      return dictionary;
    }

    /// <summary>Преобразовать настройки в словарь</summary>
    /// <returns></returns>
    public Dictionary<Guid, string> FormSettingsToDictionary()
    {
      Dictionary<Guid, string> dictionary = new Dictionary<Guid, string>();
      if (this.FormSettings == null)
        return dictionary;
      foreach (DefaultFormSetting formSetting in this.FormSettings)
        dictionary.Add(formSetting.Uid, formSetting.Value);
      return dictionary;
    }

    /// <summary>
    /// Прочитать из словаря "Тип представления-&gt;Уникальный идентификатор формы"
    /// </summary>
    /// <param name="dictionary"></param>
    public void FromDictionary(
      List<Tuple<ViewType, Guid, Guid, Guid, Guid, bool>> dictionary)
    {
      this.FromDictionary(dictionary, true);
    }

    /// <summary>Восстановить настройки</summary>
    /// <param name="dict"></param>
    public void FormSettingsFromDictionary(Dictionary<Guid, string> dict, bool reset = true)
    {
      if (this.FormSettings == null)
        return;
      if (reset)
        this.FormSettings.Clear();
      foreach (KeyValuePair<Guid, string> keyValuePair in dict)
      {
        KeyValuePair<Guid, string> pair = keyValuePair;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        DefaultFormSetting defaultFormSetting = this.FormSettings.FirstOrDefault<DefaultFormSetting>((Func<DefaultFormSetting, bool>) (s => ClassDefaultForms.\u003C\u003Ec__DisplayClass34_0.I7V22kCtFjkG2YbA4X5K(ClassDefaultForms.\u003C\u003Ec__DisplayClass34_0.WadNWxCDz6tk52ouhDNi((object) s), pair.Key)));
        if (defaultFormSetting == null)
        {
          defaultFormSetting = new DefaultFormSetting()
          {
            Uid = pair.Key
          };
          this.FormSettings.Add(defaultFormSetting);
        }
        defaultFormSetting.Value = pair.Value;
      }
    }

    /// <summary>
    /// Прочитать из словаря "Тип представления-&gt;Уникальный идентификатор формы"
    /// </summary>
    /// <param name="dictionary"></param>
    /// <param name="reset">Нужно ли сбрасывать значения</param>
    public void FromDictionary(
      List<Tuple<ViewType, Guid, Guid, Guid, Guid, bool>> dictionary,
      bool reset)
    {
      Func<ViewType, Guid, Guid> func = (Func<ViewType, Guid, Guid>) ((viewType, defaultUid) =>
      {
        int num1 = 3;
        Tuple<ViewType, Guid, Guid, Guid, Guid, bool> tuple;
        while (true)
        {
          int num2 = num1;
          ViewType viewType1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                if (tuple != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 6 : 4;
                  continue;
                }
                goto label_3;
              case 2:
                viewType1 = viewType;
                num2 = 4;
                continue;
              case 3:
                num2 = 2;
                continue;
              case 4:
                tuple = dictionary.FirstOrDefault<Tuple<ViewType, Guid, Guid, Guid, Guid, bool>>((Func<Tuple<ViewType, Guid, Guid, Guid, Guid, bool>, bool>) (d => d.Item1 == viewType1));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 0;
                continue;
              case 5:
                goto label_3;
              case 6:
                goto label_4;
              case 7:
                goto label_10;
              default:
                goto label_9;
            }
          }
label_4:
          if (tuple.Item3 != Guid.Empty)
            num1 = 7;
          else
            goto label_9;
        }
label_3:
        return defaultUid;
label_9:
        return defaultUid;
label_10:
        return tuple.Item3;
      });
      this.CreateUid = func(ViewType.Create, !reset ? this.CreateUid : Guid.Empty);
      this.EditUid = func(ViewType.Edit, this.EditUid);
      this.DisplayUid = func(ViewType.Display, this.DisplayUid);
      IEnumerable<Tuple<ViewType, Guid, Guid, Guid, Guid, bool>> tuples = dictionary.Where<Tuple<ViewType, Guid, Guid, Guid, Guid, bool>>((Func<Tuple<ViewType, Guid, Guid, Guid, Guid, bool>, bool>) (d => d.Item1 == ViewType.Custom && d.Item2 != Guid.Empty && d.Item4 != Guid.Empty && d.Item5 != Guid.Empty));
      if (reset)
        this.ActionGuids.Clear();
      foreach (Tuple<ViewType, Guid, Guid, Guid, Guid, bool> tuple in tuples)
      {
        Tuple<ViewType, Guid, Guid, Guid, Guid, bool> view = tuple;
        ActionForm actionForm = this.ActionGuids.FirstOrDefault<ActionForm>((Func<ActionForm, bool>) (a =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (ClassDefaultForms.\u003C\u003Ec__DisplayClass35_2.zcx25mCtuLMlYNWEgEhA(ClassDefaultForms.\u003C\u003Ec__DisplayClass35_2.TuOINLCtZsTu2xJ2qQxg((object) a), view.Item4))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
                  continue;
                }
                goto label_3;
              case 2:
                goto label_2;
              default:
                // ISSUE: reference to a compiler-generated method
                if (ClassDefaultForms.\u003C\u003Ec__DisplayClass35_2.mlk0DGCtIji6wGY4nPt3((object) a) == view.Item5)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 2 : 2;
                  continue;
                }
                goto label_3;
            }
          }
label_2:
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          return ClassDefaultForms.\u003C\u003Ec__DisplayClass35_2.zcx25mCtuLMlYNWEgEhA(ClassDefaultForms.\u003C\u003Ec__DisplayClass35_2.Ffl2ccCtV5n4SfCD6HnM((object) a), view.Item2);
label_3:
          return false;
        }));
        if (actionForm == null)
        {
          this.ActionGuids.Add(new ActionForm()
          {
            ActionTypeUid = view.Item2,
            ActionUid = view.Item3,
            GroupUid = view.Item4,
            Target = view.Item5,
            DeletedFromChild = view.Item6
          });
        }
        else
        {
          actionForm.ActionUid = tuple.Item3;
          actionForm.DeletedFromChild = tuple.Item6;
        }
      }
    }

    /// <summary>Получить форму для указанного типа представления</summary>
    /// <param name="viewType">Тип представления</param>
    /// <returns></returns>
    public FormViewItem GetForm(ViewType viewType)
    {
      int num = 1;
      Guid formUid;
      while (true)
      {
        switch (num)
        {
          case 1:
            formUid = this.GetFormUid(viewType);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this.GetForm(formUid);
    }

    /// <summary>Установить владельца</summary>
    /// <param name="owner"></param>
    public void SetOwner(ClassMetadata owner)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.owner = owner;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Получить уникальный идентификатор формы по умолчанию для указанного типа предсталвения
    /// </summary>
    /// <param name="viewType">Тип представления</param>
    /// <returns></returns>
    public Guid GetFormUid(ViewType viewType)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            switch (viewType)
            {
              case ViewType.Create:
                goto label_2;
              case ViewType.Edit:
                goto label_3;
              case ViewType.Create | ViewType.Edit:
                goto label_5;
              case ViewType.Display:
                goto label_4;
              default:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
                continue;
            }
          case 2:
            goto label_2;
          default:
            goto label_5;
        }
      }
label_2:
      return this.CreateUid;
label_3:
      return this.EditUid;
label_4:
      return this.DisplayUid;
label_5:
      return Guid.Empty;
    }

    public FormViewItem GetForm(Guid formUid)
    {
      int num = 4;
      Guid formUid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.owner != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 2;
              continue;
            }
            goto label_5;
          case 2:
            if (!ClassDefaultForms.GOi8vSbtZgAEIB0SXK2P(formUid1, Guid.Empty))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 3:
            formUid1 = formUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 1;
            continue;
          case 4:
            num = 3;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return (FormViewItem) null;
label_6:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.owner.GetForms().FirstOrDefault<FormViewItem>((Func<FormViewItem, bool>) (f => ClassDefaultForms.\u003C\u003Ec__DisplayClass39_0.v8XO4ICtOOJ7UMOtL0vi(ClassDefaultForms.\u003C\u003Ec__DisplayClass39_0.zYWle7Ctnv1hMtx1yA5S((object) f), formUid1)));
    }

    public string GetFormSetting(Guid settingUid)
    {
      int num = 2;
      DefaultFormSetting defaultFormSetting;
      Guid settingUid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            settingUid1 = settingUid;
            num = 4;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 1 : 0;
            continue;
          case 3:
            goto label_3;
          case 4:
            // ISSUE: reference to a compiler-generated method
            defaultFormSetting = this.FormSettings.FirstOrDefault<DefaultFormSetting>((Func<DefaultFormSetting, bool>) (s => ClassDefaultForms.\u003C\u003Ec__DisplayClass40_0.OKKstxCtNy20GOmDiCyX(s.Uid, settingUid1)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
            continue;
          default:
            if (defaultFormSetting == null)
            {
              num = 3;
              continue;
            }
            goto label_4;
        }
      }
label_3:
      return (string) null;
label_4:
      return (string) ClassDefaultForms.zBDT2HbtIAhT7C8NciCO((object) defaultFormSetting);
    }

    public void SetFormSetting(Guid settingUid, string val)
    {
      int num = 3;
      DefaultFormSetting defaultFormSetting1;
      Guid settingUid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_10;
          case 2:
            settingUid1 = settingUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 5 : 7;
            continue;
          case 3:
            num = 2;
            continue;
          case 4:
          case 6:
            defaultFormSetting1.Value = val;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 1;
            continue;
          case 5:
            this.FormSettings.Add(defaultFormSetting1);
            num = 4;
            continue;
          case 7:
            defaultFormSetting1 = this.FormSettings.FirstOrDefault<DefaultFormSetting>((Func<DefaultFormSetting, bool>) (s => s.Uid == settingUid1));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
            continue;
          case 8:
            DefaultFormSetting defaultFormSetting2 = new DefaultFormSetting();
            ClassDefaultForms.jGlS38btVdj6seo0QinI((object) defaultFormSetting2, settingUid1);
            defaultFormSetting1 = defaultFormSetting2;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 5 : 5;
            continue;
          default:
            if (defaultFormSetting1 != null)
            {
              num = 6;
              continue;
            }
            goto case 8;
        }
      }
label_10:;
    }

    internal static void k7LFTRbtfmBulZ2mwbxh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool t1QJ59btGYZgbgw7EObT() => ClassDefaultForms.iGjGRBbthoaxn88GVXgT == null;

    internal static ClassDefaultForms NBAYZ5btEGkfes7iMXCM() => ClassDefaultForms.iGjGRBbthoaxn88GVXgT;

    internal static bool cUB5kfbtQlZHBwOCnbNp([In] object obj0) => ((ClassDefaultForms) obj0).ShouldSerializeCreateUid();

    internal static bool ylScGIbtCnWRj0vjU0XD([In] object obj0) => ((ClassDefaultForms) obj0).ShouldSerializeDisplayUid();

    internal static bool RYungUbtvWxu2iO7P9wc([In] object obj0) => ((ClassDefaultForms) obj0).ShouldSerializeActionGuids();

    internal static bool DRkefXbt8ydiJE3BFJlB([In] object obj0) => ((ClassDefaultForms) obj0).ShouldSerializeFormSettings();

    internal static bool GOi8vSbtZgAEIB0SXK2P([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static int XwykP5btuKcgyNfJVeQX([In] object obj0) => ((List<ActionForm>) obj0).Count;

    internal static object zBDT2HbtIAhT7C8NciCO([In] object obj0) => (object) ((DefaultFormSetting) obj0).Value;

    internal static void jGlS38btVdj6seo0QinI([In] object obj0, Guid value) => ((DefaultFormSetting) obj0).Uid = value;
  }
}
