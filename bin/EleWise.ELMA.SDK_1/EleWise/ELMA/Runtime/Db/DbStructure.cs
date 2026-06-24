// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.DbStructure
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.Runtime.Db
{
  /// <summary>Класс для хранения структуры базы данных</summary>
  [Serializable]
  public class DbStructure
  {
    private string xml;
    private object methodExecutor;
    private Guid uid;
    private SerializableDictionary<string, DbStructure.DbTable> tables;
    private SerializableDictionary<string, DbStructure.DbView> views;
    private SerializableDictionary<string, DbStructure.DbTrigger> triggers;
    private SerializableDictionary<string, DbStructure.DbScript> scripts;
    private SerializableDictionary<string, DbStructure.DbProcedure> procedures;
    private SerializableDictionary<string, DbStructure.UserMethod> methods;
    private SerializableDictionary<string, DbStructure.DbIndex> indexes;
    internal static DbStructure REK1TFWuip1GeydpvaOw;

    public DbStructure()
    {
      DbStructure.ioi9jIWuKC0cWo9G7nv0();
      this.tables = new SerializableDictionary<string, DbStructure.DbTable>();
      this.views = new SerializableDictionary<string, DbStructure.DbView>();
      this.triggers = new SerializableDictionary<string, DbStructure.DbTrigger>();
      this.scripts = new SerializableDictionary<string, DbStructure.DbScript>();
      this.procedures = new SerializableDictionary<string, DbStructure.DbProcedure>();
      this.methods = new SerializableDictionary<string, DbStructure.UserMethod>();
      this.indexes = new SerializableDictionary<string, DbStructure.DbIndex>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public DbStructure(string xml, object methodExecutor)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.tables = new SerializableDictionary<string, DbStructure.DbTable>();
      this.views = new SerializableDictionary<string, DbStructure.DbView>();
      this.triggers = new SerializableDictionary<string, DbStructure.DbTrigger>();
      this.scripts = new SerializableDictionary<string, DbStructure.DbScript>();
      this.procedures = new SerializableDictionary<string, DbStructure.DbProcedure>();
      this.methods = new SerializableDictionary<string, DbStructure.UserMethod>();
      this.indexes = new SerializableDictionary<string, DbStructure.DbIndex>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            DbStructure.iB13pWWuXpI0KQIW6T42((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 1;
            continue;
          case 3:
            this.methodExecutor = methodExecutor;
            num = 2;
            continue;
          default:
            this.xml = xml;
            num = 3;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Деактивация данной структуры</summary>
    public bool Deactivating
    {
      get => this.\u003CDeactivating\u003Ek__BackingField;
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
              this.\u003CDeactivating\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
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

    /// <summary>Исходный XML-файл</summary>
    public string Xml => this.xml;

    /// <summary>Объект, исполняющие методы из структуры</summary>
    public object MethodExecutor => this.methodExecutor;

    /// <summary>Уникальный идентификатор файла структуры</summary>
    public Guid Uid => this.uid;

    /// <summary>Таблицы</summary>
    public SerializableDictionary<string, DbStructure.DbTable> Tables => this.tables;

    /// <summary>Представления</summary>
    public SerializableDictionary<string, DbStructure.DbView> Views => this.views;

    /// <summary>Триггеры</summary>
    public SerializableDictionary<string, DbStructure.DbTrigger> Triggers
    {
      get => this.triggers;
      set => this.triggers = value;
    }

    /// <summary>Скрипты</summary>
    public SerializableDictionary<string, DbStructure.DbScript> Scripts
    {
      get => this.scripts;
      set => this.scripts = value;
    }

    /// <summary>Хранимые процедуры</summary>
    public SerializableDictionary<string, DbStructure.DbProcedure> Procedures => this.procedures;

    /// <summary>Пользовательские методы</summary>
    public SerializableDictionary<string, DbStructure.UserMethod> Methods
    {
      get => this.methods;
      set => this.methods = value;
    }

    /// <summary>Индексы</summary>
    public SerializableDictionary<string, DbStructure.DbIndex> Indexes
    {
      get => this.indexes;
      set => this.indexes = value;
    }

    /// <summary>Объединить список структур в одну</summary>
    /// <param name="structures">Список структур</param>
    /// <returns>Объединенная структура</returns>
    public static DbStructure Merge(IEnumerable<DbStructure> structures)
    {
      DbStructure dbStructure = new DbStructure();
      if (structures != null)
      {
        foreach (DbStructure structure in structures)
          dbStructure.Merge(structure);
      }
      return dbStructure;
    }

    /// <summary>Выполнить слияние с другой структурой</summary>
    /// <param name="structure">Другая структура</param>
    public void Merge(DbStructure structure)
    {
      int num1 = 3;
      Dictionary<string, DbStructure.DbIndex>.Enumerator enumerator1;
      while (true)
      {
        int num2 = num1;
        Dictionary<string, DbStructure.DbProcedure>.Enumerator enumerator2;
        Dictionary<string, DbStructure.DbTable>.Enumerator enumerator3;
        Dictionary<string, DbStructure.UserMethod>.Enumerator enumerator4;
        Dictionary<string, DbStructure.DbView>.Enumerator enumerator5;
        Dictionary<string, DbStructure.DbScript>.Enumerator enumerator6;
        Dictionary<string, DbStructure.DbTrigger>.Enumerator enumerator7;
        while (true)
        {
          switch (num2)
          {
            case 1:
label_70:
              enumerator7 = structure.Triggers.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
              continue;
            case 2:
              try
              {
label_19:
                if (enumerator4.MoveNext())
                  goto label_21;
                else
                  goto label_20;
label_7:
                KeyValuePair<string, DbStructure.UserMethod> current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_50;
                    case 2:
                    case 5:
                      goto label_19;
                    case 3:
                      if (DbStructure.PDSUGZWuksG5xdbGYRd6((object) current.Value))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
                        continue;
                      }
                      goto case 9;
                    case 4:
                      if (!this.Methods.ContainsKey(current.Key))
                      {
                        num3 = 7;
                        continue;
                      }
                      goto label_19;
                    case 6:
                      if (!DbStructure.PDSUGZWuksG5xdbGYRd6((object) current.Value))
                      {
                        num3 = 8;
                        continue;
                      }
                      goto label_19;
                    case 7:
                      if (DbStructure.trEqLFWuTgY9LLxMO2Ua((object) structure))
                      {
                        num3 = 3;
                        continue;
                      }
                      goto case 9;
                    case 9:
                      if (DbStructure.trEqLFWuTgY9LLxMO2Ua((object) structure))
                      {
                        num3 = 2;
                        continue;
                      }
                      goto case 6;
                    case 10:
                      goto label_21;
                    default:
                      this.Methods.Add(current.Key, current.Value);
                      num3 = 5;
                      continue;
                  }
                }
label_20:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 1;
                goto label_7;
label_21:
                current = enumerator4.Current;
                num3 = 4;
                goto label_7;
              }
              finally
              {
                enumerator4.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 3:
              enumerator4 = structure.Methods.GetEnumerator();
              num2 = 2;
              continue;
            case 4:
              try
              {
label_135:
                if (enumerator3.MoveNext())
                  goto label_137;
                else
                  goto label_136;
label_133:
                KeyValuePair<string, DbStructure.DbTable> current;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_70;
                    case 2:
                      this.Tables.Add(current.Key, current.Value);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 4 : 1;
                      continue;
                    case 3:
                    case 4:
                      goto label_135;
                    case 5:
                      goto label_137;
                    default:
                      if (this.Tables.ContainsKey(current.Key))
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 3 : 3;
                        continue;
                      }
                      goto case 2;
                  }
                }
label_136:
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 1;
                goto label_133;
label_137:
                current = enumerator3.Current;
                num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
                {
                  num5 = 0;
                  goto label_133;
                }
                else
                  goto label_133;
              }
              finally
              {
                enumerator3.Dispose();
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                }
              }
            case 5:
              goto label_51;
            case 6:
label_85:
              if (!DbStructure.trEqLFWuTgY9LLxMO2Ua((object) structure))
              {
                enumerator2 = structure.Procedures.GetEnumerator();
                num2 = 13;
                continue;
              }
              num2 = 7;
              continue;
            case 7:
              goto label_145;
            case 8:
              goto label_3;
            case 9:
              try
              {
label_39:
                if (enumerator5.MoveNext())
                  goto label_33;
                else
                  goto label_40;
label_27:
                int num7;
                int num8 = num7;
label_28:
                KeyValuePair<string, DbStructure.DbView> current;
                DbStructure.DbView dbView;
                while (true)
                {
                  switch (num8)
                  {
                    case 1:
                    case 9:
                      goto label_41;
                    case 2:
                      this.Views.Add(current.Key, current.Value);
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 6 : 1;
                      continue;
                    case 3:
                      dbView.Mappings = (string) DbStructure.dH4hJdWupYieB3MmHhax((object) current.Value);
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
                      continue;
                    case 4:
                      if (string.IsNullOrEmpty((string) DbStructure.WK9nYVWuNgpnFWkSQXMV((object) current.Value)))
                      {
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 9;
                        continue;
                      }
                      goto case 10;
                    case 5:
                      goto label_33;
                    case 7:
                      goto label_84;
                    case 10:
                      DbStructure.FXEwPVWu3hnhcWgn5yJm((object) dbView, DbStructure.WK9nYVWuNgpnFWkSQXMV((object) current.Value));
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 1;
                      continue;
                    case 11:
                      if (DbStructure.H4b3BlWu2X3AsLUHZf3D(DbStructure.dH4hJdWupYieB3MmHhax((object) current.Value)))
                      {
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 2 : 8;
                        continue;
                      }
                      goto case 3;
                    case 12:
                      if (string.IsNullOrEmpty((string) DbStructure.WK9nYVWuNgpnFWkSQXMV((object) dbView)))
                      {
                        num8 = 4;
                        continue;
                      }
                      goto label_41;
                    case 13:
                      if (!this.Views.TryGetValue(current.Key, out dbView))
                      {
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 1 : 2;
                        continue;
                      }
                      goto case 12;
                    default:
                      goto label_39;
                  }
                }
label_41:
                if (DbStructure.H4b3BlWu2X3AsLUHZf3D(DbStructure.dH4hJdWupYieB3MmHhax((object) dbView)))
                {
                  num7 = 11;
                  goto label_27;
                }
                else
                  goto label_39;
label_33:
                current = enumerator5.Current;
                num8 = 7;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
                {
                  num8 = 13;
                  goto label_28;
                }
                else
                  goto label_28;
label_40:
                num7 = 7;
                goto label_27;
              }
              finally
              {
                enumerator5.Dispose();
                int num9 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
                  num9 = 0;
                switch (num9)
                {
                  default:
                }
              }
            case 10:
label_50:
              enumerator6 = structure.Scripts.GetEnumerator();
              num2 = 11;
              continue;
            case 11:
              try
              {
label_121:
                if (enumerator6.MoveNext())
                  goto label_113;
                else
                  goto label_122;
label_111:
                KeyValuePair<string, DbStructure.DbScript> current;
                int num10;
                while (true)
                {
                  switch (num10)
                  {
                    case 1:
                    case 3:
                    case 11:
                      goto label_121;
                    case 2:
                      if (!this.Scripts.ContainsKey(current.Key))
                      {
                        num10 = 9;
                        continue;
                      }
                      goto label_121;
                    case 5:
                      if (DbStructure.kMXXyVWunp8oC5mn5VMC((object) current.Value))
                      {
                        num10 = 11;
                        continue;
                      }
                      break;
                    case 6:
                      goto label_85;
                    case 7:
                      if (current.Value.OnDeactivate)
                      {
                        num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 4 : 4;
                        continue;
                      }
                      goto case 8;
                    case 8:
                      if (DbStructure.trEqLFWuTgY9LLxMO2Ua((object) structure))
                      {
                        num10 = 3;
                        continue;
                      }
                      goto case 5;
                    case 9:
                      if (DbStructure.trEqLFWuTgY9LLxMO2Ua((object) structure))
                      {
                        num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 5 : 7;
                        continue;
                      }
                      goto case 8;
                    case 10:
                      goto label_113;
                  }
                  this.Scripts.Add(current.Key, current.Value);
                  num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 1 : 0;
                }
label_113:
                current = enumerator6.Current;
                num10 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
                {
                  num10 = 2;
                  goto label_111;
                }
                else
                  goto label_111;
label_122:
                num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 6;
                goto label_111;
              }
              finally
              {
                enumerator6.Dispose();
                int num11 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
                  num11 = 0;
                switch (num11)
                {
                  default:
                }
              }
            case 12:
              goto label_52;
            case 13:
              try
              {
label_90:
                if (enumerator2.MoveNext())
                  goto label_98;
                else
                  goto label_91;
label_89:
                KeyValuePair<string, DbStructure.DbProcedure> current;
                int num12;
                while (true)
                {
                  int num13;
                  DbStructure.DbProcedure dbProcedure;
                  switch (num12)
                  {
                    case 1:
                      goto label_5;
                    case 2:
                      DbStructure.hvcA37WueBmlPlq5l0F6((object) dbProcedure, DbStructure.gOhQLsWuOsXErWNKWeRV((object) current.Value));
                      num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 12 : 8;
                      continue;
                    case 3:
                    case 5:
                    case 9:
                      goto label_90;
                    case 4:
                    case 12:
                      if (!DbStructure.H4b3BlWu2X3AsLUHZf3D(DbStructure.ds3cB6WuPDJU63hAHwx3((object) dbProcedure)))
                      {
                        num12 = 5;
                        continue;
                      }
                      goto default;
                    case 6:
                      if (this.Procedures.TryGetValue(current.Key, out dbProcedure))
                      {
                        num13 = 10;
                        break;
                      }
                      goto case 13;
                    case 7:
                      if (DbStructure.H4b3BlWu2X3AsLUHZf3D(DbStructure.gOhQLsWuOsXErWNKWeRV((object) current.Value)))
                      {
                        num12 = 4;
                        continue;
                      }
                      goto case 2;
                    case 8:
                      DbStructure.N7XCXRWu1xDkMid83fLe((object) dbProcedure, DbStructure.ds3cB6WuPDJU63hAHwx3((object) current.Value));
                      num13 = 9;
                      break;
                    case 10:
                    case 11:
                      if (DbStructure.H4b3BlWu2X3AsLUHZf3D(DbStructure.gOhQLsWuOsXErWNKWeRV((object) dbProcedure)))
                      {
                        num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 7 : 3;
                        continue;
                      }
                      goto case 4;
                    case 13:
                      this.Procedures.Add(current.Key, current.Value);
                      num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 3 : 3;
                      continue;
                    case 14:
                      goto label_98;
                    default:
                      if (!DbStructure.H4b3BlWu2X3AsLUHZf3D(DbStructure.ds3cB6WuPDJU63hAHwx3((object) current.Value)))
                      {
                        num12 = 8;
                        continue;
                      }
                      goto label_90;
                  }
                  num12 = num13;
                }
label_91:
                num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
                goto label_89;
label_98:
                current = enumerator2.Current;
                num12 = 6;
                goto label_89;
              }
              finally
              {
                enumerator2.Dispose();
                int num14 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
                  num14 = 0;
                switch (num14)
                {
                  default:
                }
              }
            case 14:
label_5:
              enumerator3 = structure.Tables.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 2 : 4;
              continue;
            case 15:
label_84:
              enumerator1 = structure.Indexes.GetEnumerator();
              num2 = 12;
              continue;
            default:
              goto label_71;
          }
        }
label_51:
        enumerator5 = structure.Views.GetEnumerator();
        num1 = 9;
        continue;
label_71:
        try
        {
label_75:
          if (enumerator7.MoveNext())
            goto label_74;
          else
            goto label_76;
label_73:
          KeyValuePair<string, DbStructure.DbTrigger> current;
          int num15;
          while (true)
          {
            switch (num15)
            {
              case 1:
              case 2:
                goto label_75;
              case 3:
                goto label_51;
              case 4:
                if (this.Triggers.ContainsKey(current.Key))
                {
                  num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 1 : 1;
                  continue;
                }
                break;
              case 5:
                goto label_74;
            }
            this.Triggers.Add(current.Key, current.Value);
            num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 2;
          }
label_74:
          current = enumerator7.Current;
          num15 = 4;
          goto label_73;
label_76:
          num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 1 : 3;
          goto label_73;
        }
        finally
        {
          enumerator7.Dispose();
          int num16 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
            num16 = 0;
          switch (num16)
          {
            default:
          }
        }
      }
label_145:
      return;
label_3:
      return;
label_52:
      try
      {
label_58:
        if (enumerator1.MoveNext())
          goto label_63;
        else
          goto label_59;
label_53:
        KeyValuePair<string, DbStructure.DbIndex> current;
        DbStructure.DbIndex dbIndex;
        int num17;
        while (true)
        {
          switch (num17)
          {
            case 1:
              if (!this.Indexes.TryGetValue(current.Key, out dbIndex))
              {
                num17 = 2;
                continue;
              }
              goto case 3;
            case 2:
              this.Indexes.Add(current.Key, current.Value);
              num17 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 3 : 5;
              continue;
            case 3:
              if (DbStructure.H4b3BlWu2X3AsLUHZf3D(DbStructure.wp6hOnWuaa8J28UVjc2b((object) dbIndex)))
              {
                num17 = 6;
                continue;
              }
              goto label_58;
            case 4:
              goto label_141;
            case 6:
              if (!DbStructure.H4b3BlWu2X3AsLUHZf3D((object) current.Value.Text))
              {
                num17 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 5 : 7;
                continue;
              }
              goto label_58;
            case 7:
              DbStructure.pQmXFxWuDy0KUIbW4U9O((object) dbIndex, DbStructure.wp6hOnWuaa8J28UVjc2b((object) current.Value));
              num17 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
              continue;
            case 8:
              goto label_63;
            default:
              goto label_58;
          }
        }
label_141:
        return;
label_59:
        num17 = 4;
        goto label_53;
label_63:
        current = enumerator1.Current;
        num17 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
        {
          num17 = 1;
          goto label_53;
        }
        else
          goto label_53;
      }
      finally
      {
        enumerator1.Dispose();
        int num18 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
          num18 = 0;
        switch (num18)
        {
          default:
        }
      }
    }

    /// <summary>Применить описания</summary>
    public void ApplyDescriptions(DbStructure descr)
    {
      int num1 = 2;
      Dictionary<string, DbStructure.DbTable>.ValueCollection.Enumerator enumerator1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_44;
          case 2:
            if (descr == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 1 : 0;
              continue;
            }
            enumerator1 = descr.Tables.Values.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
            continue;
          case 3:
            goto label_46;
          default:
            goto label_4;
        }
      }
label_44:
      return;
label_46:
      return;
label_4:
      try
      {
label_12:
        if (enumerator1.MoveNext())
          goto label_39;
        else
          goto label_13;
label_6:
        DbStructure.DbTable current1;
        DbStructure.DbTable dbTable;
        Dictionary<string, DbStructure.DbColumn>.ValueCollection.Enumerator enumerator2;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (DbStructure.H4b3BlWu2X3AsLUHZf3D(DbStructure.ajoLFkWuwmxu4XxyL2C0((object) current1)))
              {
                num2 = 13;
                continue;
              }
              goto case 14;
            case 2:
            case 3:
              enumerator2 = current1.Columns.Values.GetEnumerator();
              num2 = 4;
              continue;
            case 4:
              goto label_18;
            case 5:
            case 8:
              goto label_12;
            case 6:
            case 13:
              if (!DbStructure.H4b3BlWu2X3AsLUHZf3D(DbStructure.hKblOrWu6WFJQq2TRrv5((object) dbTable)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 2 : 2;
                continue;
              }
              goto case 9;
            case 7:
              if (!this.tables.TryGetValue((string) DbStructure.UL6griWutes0x4AGY86U((object) current1.Name), out dbTable))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 5 : 0;
                continue;
              }
              goto default;
            case 9:
              if (!DbStructure.H4b3BlWu2X3AsLUHZf3D(DbStructure.hKblOrWu6WFJQq2TRrv5((object) current1)))
              {
                num2 = 10;
                continue;
              }
              goto case 2;
            case 10:
              DbStructure.Oa13ZhWuHZdrHtaV9q6V((object) dbTable, DbStructure.hKblOrWu6WFJQq2TRrv5((object) current1));
              num2 = 3;
              continue;
            case 11:
              goto label_39;
            case 12:
              goto label_40;
            case 14:
              DbStructure.NsmOIaWu4ffWds0N5pmA((object) dbTable, DbStructure.ajoLFkWuwmxu4XxyL2C0((object) current1));
              num2 = 6;
              continue;
            default:
              if (DbStructure.H4b3BlWu2X3AsLUHZf3D(DbStructure.ajoLFkWuwmxu4XxyL2C0((object) dbTable)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 1 : 1;
                continue;
              }
              goto case 6;
          }
        }
label_40:
        return;
label_18:
        try
        {
label_29:
          if (enumerator2.MoveNext())
            goto label_20;
          else
            goto label_30;
label_19:
          DbStructure.DbColumn current2;
          DbStructure.DbColumn dbColumn;
          int num3;
          while (true)
          {
            switch (num3)
            {
              case 1:
              case 3:
              case 4:
              case 8:
                goto label_29;
              case 2:
                if (string.IsNullOrEmpty((string) DbStructure.TWsZIsWu7LbRNkC4oX43((object) current2)))
                {
                  num3 = 3;
                  continue;
                }
                goto case 9;
              case 5:
                goto label_12;
              case 6:
                if (!dbTable.Columns.TryGetValue((string) DbStructure.UL6griWutes0x4AGY86U(DbStructure.FhvyAaWuAC4JyAPwAUFj((object) current2)), out dbColumn))
                {
                  num3 = 8;
                  continue;
                }
                goto default;
              case 7:
                goto label_20;
              case 9:
                DbStructure.VjYMO2WuxdNC5xsMMdpu((object) dbColumn, DbStructure.TWsZIsWu7LbRNkC4oX43((object) current2));
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 4 : 3;
                continue;
              default:
                if (!DbStructure.H4b3BlWu2X3AsLUHZf3D(DbStructure.TWsZIsWu7LbRNkC4oX43((object) dbColumn)))
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 1;
                  continue;
                }
                goto case 2;
            }
          }
label_20:
          current2 = enumerator2.Current;
          num3 = 2;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
          {
            num3 = 6;
            goto label_19;
          }
          else
            goto label_19;
label_30:
          num3 = 5;
          goto label_19;
        }
        finally
        {
          enumerator2.Dispose();
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
            num4 = 0;
          switch (num4)
          {
            default:
          }
        }
label_13:
        num2 = 12;
        goto label_6;
label_39:
        current1 = enumerator1.Current;
        num2 = 7;
        goto label_6;
      }
      finally
      {
        enumerator1.Dispose();
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0)
          num5 = 0;
        switch (num5)
        {
          default:
        }
      }
    }

    /// <summary>Прочитать структуру из XML</summary>
    protected virtual void ReadXml()
    {
      int num1 = 4;
      DbStructure.DbScript dbScript;
      DbStructure.DbTable dbTable;
      DbStructure.UserMethod userMethod;
      DbStructure.DbView dbView;
      DbStructure.DbIndex dbIndex;
      DbStructure.DbProcedure dbProcedure;
      DbStructure.DbTrigger dbTrigger;
      while (true)
      {
        int num2 = num1;
        XmlNode xmlNode1;
        XmlNode xmlNode2;
        XmlNode indexNode;
        XmlNode xmlNode3;
        XmlNode xmlNode4;
        XmlNode xmlNode5;
        XmlNode xmlNode6;
        XmlNode xmlNode7;
        XmlNode scriptNode;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 67:
              if (xmlNode3 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 39 : 79;
                continue;
              }
              goto case 13;
            case 2:
              if (DbStructure.ssnjbcWugJciBU2pwqBZ(DbStructure.UL6griWutes0x4AGY86U(DbStructure.vxQjf0WumMOPHjXhdvJl((object) xmlNode2)), DbStructure.AXZlKCWuybnW6tTSTg3l(-1858887263 ^ -1858967647)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
                continue;
              }
              goto case 8;
            case 3:
            case 21:
              if (xmlNode6 == null)
              {
                num2 = 62;
                continue;
              }
              goto case 28;
            case 4:
              XmlDocument xmlDocument = new XmlDocument();
              xmlDocument.LoadXml(this.xml);
              xmlNode6 = (XmlNode) DbStructure.UrX5u6Wu0wbcaqrsv4N0((object) xmlDocument);
              num2 = 3;
              continue;
            case 5:
              goto label_42;
            case 6:
            case 31:
              if (xmlNode5 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 35 : 0;
                continue;
              }
              goto case 33;
            case 7:
              if (!this.methods.ContainsKey((string) DbStructure.UL6griWutes0x4AGY86U(DbStructure.UPfvs0WIouLew7b4n7gn((object) userMethod))))
              {
                num2 = 22;
                continue;
              }
              goto label_12;
            case 8:
              xmlNode2 = xmlNode2.NextSibling;
              num2 = 16;
              continue;
            case 9:
              xmlNode1 = (XmlNode) DbStructure.bTjM5DWuUPoS170aP7XU((object) xmlNode1);
              num2 = 93;
              continue;
            case 10:
              if (DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E((object) xmlNode6), DbStructure.AXZlKCWuybnW6tTSTg3l(333888594 ^ 1075625116 ^ 1409008408)) != null)
              {
                num2 = 24;
                continue;
              }
              goto label_93;
            case 11:
              dbProcedure = (DbStructure.DbProcedure) DbStructure.eL9B3SWIFIyPvap5IIXA((object) xmlNode1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 89 : 31;
              continue;
            case 12:
            case 36:
              if (DbStructure.ssnjbcWugJciBU2pwqBZ(DbStructure.UL6griWutes0x4AGY86U(DbStructure.vxQjf0WumMOPHjXhdvJl((object) xmlNode4)), DbStructure.AXZlKCWuybnW6tTSTg3l(-35995181 ^ -35978069)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 75 : 47;
                continue;
              }
              goto case 39;
            case 13:
              if ((string) DbStructure.UL6griWutes0x4AGY86U(DbStructure.vxQjf0WumMOPHjXhdvJl((object) xmlNode3)) == (string) DbStructure.AXZlKCWuybnW6tTSTg3l(-1921202237 ^ -1921187021))
              {
                num2 = 41;
                continue;
              }
              goto case 56;
            case 14:
            case 51:
              scriptNode = (XmlNode) DbStructure.bTjM5DWuUPoS170aP7XU((object) scriptNode);
              num2 = 87;
              continue;
            case 15:
              goto label_95;
            case 16:
            case 63:
              if (xmlNode2 == null)
              {
                num2 = 61;
                continue;
              }
              goto case 2;
            case 17:
            case 35:
              if (DbStructure.ssnjbcWugJciBU2pwqBZ(DbStructure.UL6griWutes0x4AGY86U(DbStructure.vxQjf0WumMOPHjXhdvJl((object) xmlNode5)), DbStructure.AXZlKCWuybnW6tTSTg3l(1574260816 ^ 1574212944)))
              {
                num2 = 49;
                continue;
              }
              goto case 90;
            case 18:
              if (DbStructure.ssnjbcWugJciBU2pwqBZ((object) ((string) DbStructure.vxQjf0WumMOPHjXhdvJl((object) indexNode)).ToUpper(), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97986648)))
              {
                num2 = 58;
                continue;
              }
              goto case 66;
            case 19:
              try
              {
                this.uid = new Guid((string) DbStructure.tpxbeyWul9cYgV4dHtTj(DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E((object) xmlNode6), DbStructure.AXZlKCWuybnW6tTSTg3l(-1290212282 ^ -644262414 ^ 1786804834))));
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    goto label_77;
                }
              }
              catch (Exception ex)
              {
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                    throw new Exception((string) DbStructure.O5NYb5WuJa4ZO2C52yMy((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477189756)) + (string) DbStructure.AXZlKCWuybnW6tTSTg3l(277947046 - -1479185048 ^ 1757049304) + (string) DbStructure.Ow3Z4xWur7bRGMTwQwEW((object) ex), ex);
                }
              }
            case 20:
              dbScript = DbStructure.ReadScript((object) scriptNode);
              num2 = 74;
              continue;
            case 22:
              this.methods.Add((string) DbStructure.UL6griWutes0x4AGY86U(DbStructure.UPfvs0WIouLew7b4n7gn((object) userMethod)), userMethod);
              num2 = 68;
              continue;
            case 23:
              this.views.Add((string) DbStructure.UL6griWutes0x4AGY86U(DbStructure.RDVHQUWuLXU4uNrLiK7m((object) dbView)), dbView);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 19 : 39;
              continue;
            case 24:
              num2 = 19;
              continue;
            case 25:
              if (DbStructure.ssnjbcWugJciBU2pwqBZ(DbStructure.UL6griWutes0x4AGY86U(DbStructure.vxQjf0WumMOPHjXhdvJl((object) xmlNode1)), DbStructure.AXZlKCWuybnW6tTSTg3l(-1867198571 ^ -1867183765)))
              {
                num2 = 11;
                continue;
              }
              goto case 9;
            case 26:
            case 85:
              if (DbStructure.ssnjbcWugJciBU2pwqBZ(DbStructure.UL6griWutes0x4AGY86U(DbStructure.vxQjf0WumMOPHjXhdvJl((object) xmlNode3)), DbStructure.AXZlKCWuybnW6tTSTg3l(-2106517564 ^ -2106535646)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 40 : 44;
                continue;
              }
              goto case 57;
            case 27:
            case 93:
              if (xmlNode1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 26 : 33;
                continue;
              }
              goto case 25;
            case 28:
              if (!DbStructure.temBa1WuMEuxPtC2qUkq(DbStructure.vxQjf0WumMOPHjXhdvJl((object) xmlNode6), DbStructure.AXZlKCWuybnW6tTSTg3l(1218962250 ^ 1218846838)))
              {
                num2 = 54;
                continue;
              }
              goto case 29;
            case 29:
              xmlNode6 = xmlNode6.NextSibling;
              num2 = 21;
              continue;
            case 30:
            case 97:
              if (!(((string) DbStructure.vxQjf0WumMOPHjXhdvJl((object) xmlNode3)).ToUpper() == (string) DbStructure.AXZlKCWuybnW6tTSTg3l(333888594 ^ 1075625116 ^ 1409009314)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 18 : 26;
                continue;
              }
              goto label_99;
            case 32:
            case 83:
              if (indexNode == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 9 : 96;
                continue;
              }
              goto case 18;
            case 33:
            case 37:
            case 42:
            case 47:
            case 61:
            case 64:
            case 96:
              xmlNode3 = (XmlNode) DbStructure.bTjM5DWuUPoS170aP7XU((object) xmlNode3);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 1;
              continue;
            case 34:
              userMethod = (DbStructure.UserMethod) DbStructure.xfW5sKWIWPVo3wDRXnZ6((object) xmlNode7, this.methodExecutor);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 7 : 2;
              continue;
            case 38:
              goto label_99;
            case 39:
              xmlNode4 = (XmlNode) DbStructure.bTjM5DWuUPoS170aP7XU((object) xmlNode4);
              num2 = 88;
              continue;
            case 40:
              goto label_93;
            case 41:
              xmlNode5 = (XmlNode) DbStructure.UrX5u6Wu0wbcaqrsv4N0((object) xmlNode3);
              num2 = 6;
              continue;
            case 43:
              if (!this.views.ContainsKey(((string) DbStructure.RDVHQUWuLXU4uNrLiK7m((object) dbView)).ToUpper()))
              {
                num2 = 23;
                continue;
              }
              goto label_42;
            case 44:
              xmlNode1 = (XmlNode) DbStructure.UrX5u6Wu0wbcaqrsv4N0((object) xmlNode3);
              num2 = 27;
              continue;
            case 45:
              goto label_14;
            case 46:
              xmlNode7 = (XmlNode) DbStructure.UrX5u6Wu0wbcaqrsv4N0((object) xmlNode3);
              num2 = 80;
              continue;
            case 48:
              if (!this.tables.ContainsKey((string) DbStructure.UL6griWutes0x4AGY86U((object) dbTable.Name)))
              {
                this.tables.Add(((string) DbStructure.GHT8GcWujYYXdxwndgLH((object) dbTable)).ToUpper(), dbTable);
                num2 = 90;
                continue;
              }
              num2 = 69;
              continue;
            case 49:
              dbTable = (DbStructure.DbTable) DbStructure.Q3jEoKWu5H7IZ3sAjQbu((object) xmlNode5);
              num2 = 48;
              continue;
            case 50:
              xmlNode4 = (XmlNode) DbStructure.UrX5u6Wu0wbcaqrsv4N0((object) xmlNode3);
              num2 = 76;
              continue;
            case 52:
            case 80:
              if (xmlNode7 != null)
              {
                num2 = 59;
                continue;
              }
              goto case 33;
            case 53:
              indexNode = (XmlNode) DbStructure.UrX5u6Wu0wbcaqrsv4N0((object) xmlNode3);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 15 : 32;
              continue;
            case 54:
            case 62:
              if (xmlNode6 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 3 : 10;
                continue;
              }
              goto label_95;
            case 55:
              goto label_72;
            case 56:
              if (((string) DbStructure.vxQjf0WumMOPHjXhdvJl((object) xmlNode3)).ToUpper() == (string) DbStructure.AXZlKCWuybnW6tTSTg3l(694673736 ^ -23604109 ^ -672010159))
              {
                num2 = 50;
                continue;
              }
              goto case 77;
            case 57:
              if (DbStructure.ssnjbcWugJciBU2pwqBZ(DbStructure.UL6griWutes0x4AGY86U(DbStructure.vxQjf0WumMOPHjXhdvJl((object) xmlNode3)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121244031)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 43 : 46;
                continue;
              }
              goto case 92;
            case 58:
              dbIndex = this.ReadUserIndex(indexNode);
              num2 = 72;
              continue;
            case 59:
            case 84:
              if (!DbStructure.ssnjbcWugJciBU2pwqBZ(DbStructure.UL6griWutes0x4AGY86U(DbStructure.vxQjf0WumMOPHjXhdvJl((object) xmlNode7)), DbStructure.AXZlKCWuybnW6tTSTg3l(-1487388570 ^ -1487304736)))
              {
                num2 = 81;
                continue;
              }
              goto case 34;
            case 60:
              this.triggers.Add((string) DbStructure.UL6griWutes0x4AGY86U(DbStructure.tg63PuWucfpnEslapXoy((object) dbTrigger)), dbTrigger);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 7 : 8;
              continue;
            case 65:
              goto label_12;
            case 66:
              indexNode = indexNode.NextSibling;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 83 : 1;
              continue;
            case 68:
            case 81:
              xmlNode7 = (XmlNode) DbStructure.bTjM5DWuUPoS170aP7XU((object) xmlNode7);
              num2 = 52;
              continue;
            case 69:
              goto label_6;
            case 70:
            case 87:
              if (scriptNode != null)
              {
                num2 = 78;
                continue;
              }
              goto case 33;
            case 71:
            case 78:
              if (!DbStructure.ssnjbcWugJciBU2pwqBZ((object) ((string) DbStructure.vxQjf0WumMOPHjXhdvJl((object) scriptNode)).ToUpper(), DbStructure.AXZlKCWuybnW6tTSTg3l(--1418440330 ^ 1418356980)))
              {
                num2 = 14;
                continue;
              }
              goto case 20;
            case 72:
              if (!this.indexes.ContainsKey((string) DbStructure.UL6griWutes0x4AGY86U(DbStructure.GemKxfWIbUJyHsmSB4rS((object) dbIndex))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 69 : 82;
                continue;
              }
              goto label_66;
            case 73:
              goto label_66;
            case 74:
              if (this.scripts.ContainsKey(dbScript.Name.ToUpper()))
              {
                num2 = 45;
                continue;
              }
              this.scripts.Add(((string) DbStructure.mPFrMfWuzEMgdbWscN4V((object) dbScript)).ToUpper(), dbScript);
              num2 = 51;
              continue;
            case 75:
              goto label_32;
            case 76:
            case 88:
              if (xmlNode4 != null)
              {
                num2 = 36;
                continue;
              }
              goto case 33;
            case 77:
              if (!DbStructure.ssnjbcWugJciBU2pwqBZ((object) xmlNode3.Name.ToUpper(), DbStructure.AXZlKCWuybnW6tTSTg3l(-1939377524 ^ -1939425440)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 17 : 30;
                continue;
              }
              goto case 91;
            case 79:
              goto label_110;
            case 82:
              this.indexes.Add((string) DbStructure.UL6griWutes0x4AGY86U((object) dbIndex.Name), dbIndex);
              num2 = 66;
              continue;
            case 86:
              goto label_75;
            case 89:
              if (this.procedures.ContainsKey((string) DbStructure.UL6griWutes0x4AGY86U(DbStructure.RXfOh8WIBFhRhuFMMfxj((object) dbProcedure))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 55 : 52;
                continue;
              }
              this.procedures.Add(((string) DbStructure.RXfOh8WIBFhRhuFMMfxj((object) dbProcedure)).ToUpper(), dbProcedure);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 7 : 9;
              continue;
            case 90:
              xmlNode5 = xmlNode5.NextSibling;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 14 : 31;
              continue;
            case 91:
              xmlNode2 = (XmlNode) DbStructure.UrX5u6Wu0wbcaqrsv4N0((object) xmlNode3);
              num2 = 63;
              continue;
            case 92:
              if (DbStructure.ssnjbcWugJciBU2pwqBZ(DbStructure.UL6griWutes0x4AGY86U((object) xmlNode3.Name), DbStructure.AXZlKCWuybnW6tTSTg3l(993438473 ^ 993488101)))
              {
                num2 = 53;
                continue;
              }
              goto case 33;
            case 94:
label_77:
              xmlNode3 = (XmlNode) DbStructure.UrX5u6Wu0wbcaqrsv4N0((object) xmlNode6);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 67 : 38;
              continue;
            case 95:
              if (!this.triggers.ContainsKey((string) DbStructure.UL6griWutes0x4AGY86U((object) dbTrigger.Name)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 46 : 60;
                continue;
              }
              goto label_75;
            default:
              goto label_88;
          }
        }
label_32:
        dbView = (DbStructure.DbView) DbStructure.vsmjMZWuYdUdEMs9tkYN((object) xmlNode4);
        num1 = 43;
        continue;
label_88:
        dbTrigger = (DbStructure.DbTrigger) DbStructure.PklhiDWus7dgyfDYFKC7((object) xmlNode2);
        num1 = 95;
        continue;
label_99:
        scriptNode = (XmlNode) DbStructure.UrX5u6Wu0wbcaqrsv4N0((object) xmlNode3);
        num1 = 70;
      }
label_110:
      return;
label_6:
      throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236186817), DbStructure.GHT8GcWujYYXdxwndgLH((object) dbTable)));
label_12:
      throw new Exception(EleWise.ELMA.SR.T((string) DbStructure.AXZlKCWuybnW6tTSTg3l(-643786247 ^ -643735953), (object) userMethod.Name));
label_14:
      throw new Exception(EleWise.ELMA.SR.T((string) DbStructure.AXZlKCWuybnW6tTSTg3l(-138018305 ^ -137902223), DbStructure.mPFrMfWuzEMgdbWscN4V((object) dbScript)));
label_42:
      throw new Exception(EleWise.ELMA.SR.T((string) DbStructure.AXZlKCWuybnW6tTSTg3l(-1837662597 ^ -1837712385), DbStructure.RDVHQUWuLXU4uNrLiK7m((object) dbView)));
label_66:
      throw new Exception(EleWise.ELMA.SR.T((string) DbStructure.AXZlKCWuybnW6tTSTg3l(-812025778 ^ -812076990), DbStructure.GemKxfWIbUJyHsmSB4rS((object) dbIndex)));
label_72:
      throw new Exception(EleWise.ELMA.SR.T((string) DbStructure.AXZlKCWuybnW6tTSTg3l(-1867198571 ^ -1867183999), DbStructure.RXfOh8WIBFhRhuFMMfxj((object) dbProcedure)));
label_75:
      throw new Exception(EleWise.ELMA.SR.T((string) DbStructure.AXZlKCWuybnW6tTSTg3l(--1418440330 ^ 1418356888), DbStructure.tg63PuWucfpnEslapXoy((object) dbTrigger)));
label_93:
      throw new Exception(EleWise.ELMA.SR.T((string) DbStructure.AXZlKCWuybnW6tTSTg3l(-1837662597 ^ -1837711973)));
label_95:
      throw new Exception((string) DbStructure.O5NYb5WuJa4ZO2C52yMy(DbStructure.AXZlKCWuybnW6tTSTg3l(1253244298 - 1829393894 ^ -576101140)));
    }

    private DbStructure.DbIndex ReadUserIndex(XmlNode indexNode)
    {
      int num1 = 25;
      DbStructure.DbIndex dbIndex1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          bool result;
          XmlAttribute xmlAttribute1;
          XmlAttribute xmlAttribute2;
          int num3;
          switch (num2)
          {
            case 1:
              if (DbStructure.H4b3BlWu2X3AsLUHZf3D(DbStructure.tpxbeyWul9cYgV4dHtTj((object) xmlAttribute2)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 16 : 22;
                continue;
              }
              dbIndex1.TableName = (string) DbStructure.tpxbeyWul9cYgV4dHtTj(DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E((object) indexNode), DbStructure.AXZlKCWuybnW6tTSTg3l(-951514650 ^ -951533244)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 17 : 8;
              continue;
            case 2:
              bool.TryParse(((XmlNode) DbStructure.GjPaCSWudS7TMqtfvAdF((object) indexNode.Attributes, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561027980))).Value, out result);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 16 : 10;
              continue;
            case 3:
              goto label_3;
            case 4:
              if (dbIndex1.Columns != null)
              {
                num2 = 11;
                continue;
              }
              goto case 7;
            case 5:
              xmlAttribute2 = ((XmlAttributeCollection) DbStructure.pt0cfaWu9N4ZdF1DSZ9E((object) indexNode))[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461676859)];
              num2 = 9;
              continue;
            case 6:
            case 14:
              goto label_4;
            case 7:
              num3 = 0;
              break;
            case 8:
              goto label_19;
            case 9:
              if (xmlAttribute2 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 13 : 8;
                continue;
              }
              goto case 1;
            case 10:
              if (DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E((object) indexNode), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082417208)) != null)
              {
                num2 = 21;
                continue;
              }
              goto case 23;
            case 11:
              num3 = DbStructure.iXQbQAWIQ4No2NQwl8i0((object) dbIndex1.Columns);
              break;
            case 12:
              if (xmlAttribute1 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 3 : 20;
                continue;
              }
              goto label_8;
            case 13:
            case 22:
              goto label_26;
            case 15:
            case 16:
              DbStructure.qnrL1AWIGQL4CRSEWyM7((object) dbIndex1, result);
              num2 = 10;
              continue;
            case 17:
              result = false;
              num2 = 19;
              continue;
            case 18:
              goto label_8;
            case 19:
              if (DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E((object) indexNode), DbStructure.AXZlKCWuybnW6tTSTg3l(87862435 ^ 87909811)) == null)
              {
                num2 = 15;
                continue;
              }
              goto case 2;
            case 20:
              if (!DbStructure.H4b3BlWu2X3AsLUHZf3D(DbStructure.tpxbeyWul9cYgV4dHtTj((object) xmlAttribute1)))
              {
                DbStructure.Q8L236WIhrvxTVQM94uG((object) dbIndex1, DbStructure.tpxbeyWul9cYgV4dHtTj((object) xmlAttribute1));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 5 : 1;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 18 : 13;
              continue;
            case 21:
              goto label_34;
            case 23:
              dbIndex1.IgnoreVersions = DbStructure.ReadVersions((object) indexNode);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
              continue;
            case 24:
              xmlAttribute1 = ((XmlAttributeCollection) DbStructure.pt0cfaWu9N4ZdF1DSZ9E((object) indexNode))[(string) DbStructure.AXZlKCWuybnW6tTSTg3l(44884861 ^ 44887915)];
              num2 = 12;
              continue;
            case 25:
              dbIndex1 = new DbStructure.DbIndex();
              num2 = 24;
              continue;
            default:
              DbStructure.iIwBFDWIf4AWTX9b5FwA((object) dbIndex1, (object) indexNode);
              num2 = 4;
              continue;
          }
          if (num3 != 0)
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 14 : 4;
          else
            break;
        }
label_19:
        if (!DbStructure.H4b3BlWu2X3AsLUHZf3D((object) dbIndex1.Text))
        {
          num1 = 6;
          continue;
        }
        break;
label_34:
        DbStructure.DbIndex dbIndex2 = dbIndex1;
        object source = DbStructure.odv9OWWIEGuQN40Jyldg(DbStructure.tpxbeyWul9cYgV4dHtTj(DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E((object) indexNode), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372641033))), (object) new char[1]
        {
          ','
        });
        // ISSUE: reference to a compiler-generated field
        Func<string, string> func = DbStructure.\u003C\u003Ec.\u003C\u003E9__56_0;
        Func<string, string> selector;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          DbStructure.\u003C\u003Ec.\u003C\u003E9__56_0 = selector = (Func<string, string>) (c => (string) DbStructure.\u003C\u003Ec.pYUmCvQaLotntjT0Dc9U((object) c, (object) new char[1]
          {
            ' '
          }));
        }
        else
          goto label_40;
label_36:
        List<string> list = ((IEnumerable<string>) source).Select<string, string>(selector).ToList<string>();
        dbIndex2.Columns = list;
        num1 = 23;
        continue;
label_40:
        selector = func;
        goto label_36;
      }
label_3:
      throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824275793)));
label_4:
      return dbIndex1;
label_8:
      throw new Exception((string) DbStructure.O5NYb5WuJa4ZO2C52yMy((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882239226)));
label_26:
      throw new Exception((string) DbStructure.O5NYb5WuJa4ZO2C52yMy(DbStructure.AXZlKCWuybnW6tTSTg3l(-740338220 ^ -740385428)));
    }

    private static List<string> ReadVersions(object node)
    {
      List<string> stringList = new List<string>();
      if (((XmlNode) node).Attributes[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218849458)] != null)
      {
        foreach (string str in ((XmlNode) node).Attributes[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323135946)].Value.Split(z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957835620).ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
          stringList.Add(str.Trim());
      }
      return stringList;
    }

    private static List<string> ReadExecuteVersions(object node)
    {
      List<string> stringList = new List<string>();
      XmlAttribute xmlAttribute = ((XmlNode) node).Attributes[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917241490)] ?? ((XmlNode) node).Attributes[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146589415)];
      if (xmlAttribute != null)
      {
        foreach (string str in xmlAttribute.Value.Split(z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757143522).ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
          stringList.Add(str.Trim());
      }
      return stringList;
    }

    private static DbStructure.DbView ReadView(object viewNode)
    {
      DbStructure.DbView dbView = new DbStructure.DbView();
      dbView.Name = DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E(viewNode), DbStructure.AXZlKCWuybnW6tTSTg3l(1514961705 ^ 1514960703)) != null ? ((XmlAttributeCollection) DbStructure.pt0cfaWu9N4ZdF1DSZ9E(viewNode))[(string) DbStructure.AXZlKCWuybnW6tTSTg3l(-244066886 - -48452443 ^ -195615485)].Value : throw new Exception((string) DbStructure.O5NYb5WuJa4ZO2C52yMy(DbStructure.AXZlKCWuybnW6tTSTg3l(-1886646897 ^ -1886533677)));
      DbStructure.iIwBFDWIf4AWTX9b5FwA((object) dbView, viewNode);
      DbStructure.hGPFBTWICWNdrgaNIbCX((object) dbView, viewNode);
      dbView.IgnoreVersions = DbStructure.ReadVersions(viewNode);
      return dbView;
    }

    private static DbStructure.DbTrigger ReadTrigger(object triggerNode)
    {
      DbStructure.DbTrigger dbTrigger = new DbStructure.DbTrigger();
      dbTrigger.Name = DbStructure.GjPaCSWudS7TMqtfvAdF((object) ((XmlNode) triggerNode).Attributes, DbStructure.AXZlKCWuybnW6tTSTg3l(-218496594 ^ -218493512)) != null ? (string) DbStructure.tpxbeyWul9cYgV4dHtTj(DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E(triggerNode), DbStructure.AXZlKCWuybnW6tTSTg3l(813604817 ^ 813601735))) : throw new Exception(EleWise.ELMA.SR.T((string) DbStructure.AXZlKCWuybnW6tTSTg3l(-87337865 ^ -87384377)));
      DbStructure.iIwBFDWIf4AWTX9b5FwA((object) dbTrigger, triggerNode);
      dbTrigger.IgnoreVersions = DbStructure.ReadVersions(triggerNode);
      return dbTrigger;
    }

    private static DbStructure.DbScript ReadScript(object scriptNode)
    {
      DbStructure.DbScript dbScript = new DbStructure.DbScript();
      if (DbStructure.GjPaCSWudS7TMqtfvAdF((object) ((XmlNode) scriptNode).Attributes, DbStructure.AXZlKCWuybnW6tTSTg3l(-1638402543 ^ -1638401529)) == null)
        throw new Exception((string) DbStructure.O5NYb5WuJa4ZO2C52yMy(DbStructure.AXZlKCWuybnW6tTSTg3l(-812025778 ^ -812076364)));
      DbStructure.eMMneaWIvlLjdQN2I2Fj((object) dbScript, DbStructure.tpxbeyWul9cYgV4dHtTj(DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E(scriptNode), DbStructure.AXZlKCWuybnW6tTSTg3l(-630932142 - 1120244082 ^ -1751177226))));
      DbStructure.UtmrWtWIZLWLloEjXSgR((object) dbScript, DbStructure.S2PJObWI8FTGVLcVhBlD(scriptNode));
      DbStructure.M15rXdWIIOdOpdgJtv4v((object) dbScript, DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E(scriptNode), DbStructure.AXZlKCWuybnW6tTSTg3l(813604817 ^ 813651091)) != null && DbStructure.zfHKGeWIuD7BVxUZ0fHg(DbStructure.tpxbeyWul9cYgV4dHtTj((object) ((XmlNode) scriptNode).Attributes[(string) DbStructure.AXZlKCWuybnW6tTSTg3l(222162814 ^ 222045244)]), DbStructure.AXZlKCWuybnW6tTSTg3l(1051802738 - -1831968059 ^ -1411230661), StringComparison.CurrentCultureIgnoreCase));
      dbScript.ExecuteVersions = DbStructure.ReadExecuteVersions(scriptNode);
      DbStructure.iIwBFDWIf4AWTX9b5FwA((object) dbScript, scriptNode);
      dbScript.IgnoreVersions = DbStructure.ReadVersions(scriptNode);
      DbStructure.hmRhvOWIVZlDJRURZiTG((object) dbScript, DbStructure.GjPaCSWudS7TMqtfvAdF((object) ((XmlNode) scriptNode).Attributes, DbStructure.AXZlKCWuybnW6tTSTg3l(1669371371 ^ 1669422731)) != null && DbStructure.zfHKGeWIuD7BVxUZ0fHg(DbStructure.tpxbeyWul9cYgV4dHtTj((object) ((XmlAttributeCollection) DbStructure.pt0cfaWu9N4ZdF1DSZ9E(scriptNode))[z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 222045214)]), DbStructure.AXZlKCWuybnW6tTSTg3l(--1867379187 ^ 1867349093), StringComparison.CurrentCultureIgnoreCase));
      DbStructure.sXTpnjWIS6hJuvpCFdV4((object) dbScript, DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E(scriptNode), DbStructure.AXZlKCWuybnW6tTSTg3l(1470998129 - 231418599 ^ 1239658742)) == null ? (object) (string) null : (object) ((XmlNode) DbStructure.GjPaCSWudS7TMqtfvAdF((object) ((XmlNode) scriptNode).Attributes, DbStructure.AXZlKCWuybnW6tTSTg3l(1304605005 ^ 1304656433))).Value);
      return dbScript;
    }

    private static DbStructure.DbTable ReadTable(object tableNode)
    {
      int num1 = 6;
      DbStructure.DbColumn dbColumn;
      DbStructure.DbTable dbTable;
      DbStructure.DbForeignKey dbForeignKey;
      while (true)
      {
        int num2 = num1;
        XmlNode node;
        int result;
        while (true)
        {
          switch (num2)
          {
            case 1:
              dbColumn.UniqueKey = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 21 : 43;
              continue;
            case 2:
              if (DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E((object) node), DbStructure.AXZlKCWuybnW6tTSTg3l(1470998129 - 231418599 ^ 1239657278)) != null)
              {
                num2 = 70;
                continue;
              }
              goto label_48;
            case 3:
              if (!DbStructure.ssnjbcWugJciBU2pwqBZ(DbStructure.UL6griWutes0x4AGY86U(DbStructure.vxQjf0WumMOPHjXhdvJl((object) node)), DbStructure.AXZlKCWuybnW6tTSTg3l(1925118608 << 2 ^ -889576444)))
              {
                num2 = 39;
                continue;
              }
              goto case 31;
            case 4:
              if (DbStructure.ssnjbcWugJciBU2pwqBZ((object) ((string) DbStructure.tpxbeyWul9cYgV4dHtTj(DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E((object) node), DbStructure.AXZlKCWuybnW6tTSTg3l(1461625753 ^ 1461677741)))).ToUpper(), DbStructure.AXZlKCWuybnW6tTSTg3l(44884861 ^ 44855019)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 25 : 25;
                continue;
              }
              goto case 38;
            case 5:
              goto label_58;
            case 6:
              dbTable = new DbStructure.DbTable();
              num2 = 5;
              continue;
            case 7:
            case 49:
              if (node != null)
                goto case 73;
              else
                goto label_9;
            case 8:
              if (DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E(tableNode), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 44925289)) != null)
              {
                num2 = 55;
                continue;
              }
              goto case 56;
            case 9:
              if (((XmlAttributeCollection) DbStructure.pt0cfaWu9N4ZdF1DSZ9E((object) node))[(string) DbStructure.AXZlKCWuybnW6tTSTg3l(864270449 << 6 ^ -521153782)] == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 23 : 65;
                continue;
              }
              goto label_101;
            case 10:
              if (DbStructure.GjPaCSWudS7TMqtfvAdF((object) node.Attributes, DbStructure.AXZlKCWuybnW6tTSTg3l(-1852837372 ^ -1852834266)) == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 19 : 62;
                continue;
              }
              DbStructure.hFan0pWIqBTbY24GNXEK((object) dbColumn, DbStructure.tpxbeyWul9cYgV4dHtTj(DbStructure.GjPaCSWudS7TMqtfvAdF((object) node.Attributes, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477142536))));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 64 : 15;
              continue;
            case 11:
            case 69:
              if (node.Attributes[(string) DbStructure.AXZlKCWuybnW6tTSTg3l(-105199646 ^ -105182624)] != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 63 : 49;
                continue;
              }
              goto case 27;
            case 12:
              goto label_43;
            case 13:
              dbColumn = new DbStructure.DbColumn();
              num2 = 51;
              continue;
            case 14:
            case 44:
              dbColumn.IgnoreVersions = DbStructure.ReadVersions((object) node);
              num2 = 3;
              continue;
            case 15:
              goto label_48;
            case 16:
              DbStructure.dhUvhqWIPJhnQpRwAZ9g((object) dbForeignKey, DbStructure.tpxbeyWul9cYgV4dHtTj(DbStructure.GjPaCSWudS7TMqtfvAdF((object) node.Attributes, DbStructure.AXZlKCWuybnW6tTSTg3l(95909607 + 343705423 ^ 439496528))));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 32 : 21;
              continue;
            case 17:
            case 39:
              node = (XmlNode) DbStructure.bTjM5DWuUPoS170aP7XU((object) node);
              num2 = 49;
              continue;
            case 18:
              if (((XmlAttributeCollection) DbStructure.pt0cfaWu9N4ZdF1DSZ9E((object) node))[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77638011)] == null)
              {
                num2 = 23;
                continue;
              }
              goto case 53;
            case 19:
            case 23:
              goto label_83;
            case 20:
              DbStructure.MgHddAWI17D8lvKIaIy8((object) dbForeignKey, DbStructure.tpxbeyWul9cYgV4dHtTj((object) node.Attributes[(string) DbStructure.AXZlKCWuybnW6tTSTg3l(2045296739 + 1688595713 ^ -561021922)]));
              num2 = 68;
              continue;
            case 21:
              goto label_52;
            case 22:
              goto label_85;
            case 24:
              DbStructure.D6kycEWInlLBWNwMqpkm((object) dbColumn, DbStructure.tpxbeyWul9cYgV4dHtTj((object) ((XmlAttributeCollection) DbStructure.pt0cfaWu9N4ZdF1DSZ9E((object) node))[(string) DbStructure.AXZlKCWuybnW6tTSTg3l(-740338220 ^ -740385806)]));
              num2 = 14;
              continue;
            case 25:
              DbStructure.xuA8FhWIKYuU4dKQ2D3E((object) dbColumn, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 38 : 37;
              continue;
            case 26:
              goto label_69;
            case 27:
              if (DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E((object) node), DbStructure.AXZlKCWuybnW6tTSTg3l(1242972401 >> 4 ^ 77638185)) == null)
              {
                num2 = 44;
                continue;
              }
              goto case 24;
            case 28:
            case 43:
              if (DbStructure.GjPaCSWudS7TMqtfvAdF((object) node.Attributes, DbStructure.AXZlKCWuybnW6tTSTg3l(372753449 ^ 372721793)) != null)
              {
                num2 = 33;
                continue;
              }
              goto case 18;
            case 29:
              if (DbStructure.ssnjbcWugJciBU2pwqBZ((object) ((XmlNode) DbStructure.GjPaCSWudS7TMqtfvAdF((object) node.Attributes, DbStructure.AXZlKCWuybnW6tTSTg3l(1461825605 - 1531863589 ^ -70089858))).Value.ToUpper(), DbStructure.AXZlKCWuybnW6tTSTg3l(1012087039 ^ 1012118889)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 1 : 0;
                continue;
              }
              goto case 28;
            case 30:
              goto label_72;
            case 31:
              dbForeignKey = new DbStructure.DbForeignKey();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 74 : 40;
              continue;
            case 32:
            case 41:
              if (DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E((object) node), DbStructure.AXZlKCWuybnW6tTSTg3l(~541731958 ^ -541850893)) == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 54 : 47;
                continue;
              }
              goto case 20;
            case 33:
              DbStructure.Ql1xm3WIT2tHH0Xqewcq((object) dbColumn, (object) ((XmlNode) DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E((object) node), DbStructure.AXZlKCWuybnW6tTSTg3l(2045296739 + 1688595713 ^ -561110580))).Value);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 18 : 6;
              continue;
            case 34:
              DbStructure.WUuR3OWIXnNeBmOjAWh5((object) dbColumn, true);
              num2 = 40;
              continue;
            case 35:
              goto label_35;
            case 36:
              if (!dbTable.ForeignKeys.ContainsKey((string) DbStructure.UL6griWutes0x4AGY86U(DbStructure.K15hUsWIOsry5nh2lhET((object) dbForeignKey))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 41 : 66;
                continue;
              }
              goto label_85;
            case 37:
              dbColumn.StringFieldLength = result;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 27 : 26;
              continue;
            case 38:
            case 75:
              if (node.Attributes[(string) DbStructure.AXZlKCWuybnW6tTSTg3l(1669371371 ^ 1669421229)] == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
                continue;
              }
              goto case 71;
            case 42:
              if (DbStructure.GjPaCSWudS7TMqtfvAdF((object) node.Attributes, DbStructure.AXZlKCWuybnW6tTSTg3l(1113862659 ^ 1113935895)) != null)
              {
                num2 = 26;
                continue;
              }
              goto case 52;
            case 45:
              if (DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E((object) node), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647990956)) == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 60 : 54;
                continue;
              }
              goto case 16;
            case 46:
              dbTable.IgnoreVersions = DbStructure.ReadVersions(tableNode);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 67 : 51;
              continue;
            case 47:
              goto label_3;
            case 48:
              goto label_16;
            case 50:
            case 68:
              dbForeignKey.IgnoreVersions = DbStructure.ReadVersions((object) node);
              num2 = 17;
              continue;
            case 51:
              if (DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E((object) node), DbStructure.AXZlKCWuybnW6tTSTg3l(589593376 ^ -1977315327 ^ -1459558601)) != null)
              {
                num2 = 72;
                continue;
              }
              goto label_35;
            case 52:
              if (!dbTable.Columns.ContainsKey(((string) DbStructure.FhvyAaWuAC4JyAPwAUFj((object) dbColumn)).ToUpper()))
              {
                dbTable.Columns.Add((string) DbStructure.UL6griWutes0x4AGY86U(DbStructure.FhvyAaWuAC4JyAPwAUFj((object) dbColumn)), dbColumn);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 10 : 7;
                continue;
              }
              num2 = 48;
              continue;
            case 53:
              DbStructure.MUEMDIWIkbieB26UsG3b((object) dbColumn, (object) ((XmlNode) DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E((object) node), DbStructure.AXZlKCWuybnW6tTSTg3l(-675505729 ^ -675457845))).Value);
              num2 = 11;
              continue;
            case 54:
              dbForeignKey.AlterAction = (string) null;
              num2 = 50;
              continue;
            case 55:
              dbTable.Description = (string) DbStructure.tpxbeyWul9cYgV4dHtTj(DbStructure.GjPaCSWudS7TMqtfvAdF((object) ((XmlNode) tableNode).Attributes, DbStructure.AXZlKCWuybnW6tTSTg3l(1012087039 ^ 1012030187)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 3 : 56;
              continue;
            case 56:
              if (DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E(tableNode), DbStructure.AXZlKCWuybnW6tTSTg3l(-1822890472 ^ -1822828864)) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 58 : 44;
                continue;
              }
              goto case 46;
            case 57:
              dbTable.Name = (string) DbStructure.tpxbeyWul9cYgV4dHtTj(DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E(tableNode), DbStructure.AXZlKCWuybnW6tTSTg3l(-1872275253 >> 6 ^ -29257355)));
              num2 = 8;
              continue;
            case 58:
              DbStructure.Oa13ZhWuHZdrHtaV9q6V((object) dbTable, DbStructure.tpxbeyWul9cYgV4dHtTj(DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E(tableNode), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488803565))));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 43 : 46;
              continue;
            case 59:
              if (DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E((object) node), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669416431)) != null)
              {
                DbStructure.KVi7mtWIeIRuWhioNMdK((object) dbForeignKey, DbStructure.tpxbeyWul9cYgV4dHtTj((object) ((XmlAttributeCollection) DbStructure.pt0cfaWu9N4ZdF1DSZ9E((object) node))[(string) DbStructure.AXZlKCWuybnW6tTSTg3l(-1380439818 << 3 ^ 1841338292)]));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 2 : 2;
                continue;
              }
              num2 = 61;
              continue;
            case 60:
              DbStructure.dhUvhqWIPJhnQpRwAZ9g((object) dbForeignKey, (object) null);
              num2 = 41;
              continue;
            case 61:
              goto label_40;
            case 62:
              goto label_78;
            case 63:
              if (int.TryParse((string) DbStructure.tpxbeyWul9cYgV4dHtTj((object) node.Attributes[z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 44904191)]), out result))
              {
                num2 = 37;
                continue;
              }
              goto label_3;
            case 64:
              if (DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E((object) node), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951532334)) == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 50 : 75;
                continue;
              }
              goto case 4;
            case 65:
              goto label_100;
            case 66:
              dbTable.ForeignKeys.Add(((string) DbStructure.K15hUsWIOsry5nh2lhET((object) dbForeignKey)).ToUpper(), dbForeignKey);
              num2 = 9;
              continue;
            case 67:
              node = (XmlNode) DbStructure.UrX5u6Wu0wbcaqrsv4N0(tableNode);
              num2 = 7;
              continue;
            case 70:
              dbForeignKey.RefColumn = (string) DbStructure.tpxbeyWul9cYgV4dHtTj(DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E((object) node), DbStructure.AXZlKCWuybnW6tTSTg3l(-1217523399 ^ -1217412723)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 38 : 45;
              continue;
            case 71:
              if (DbStructure.ssnjbcWugJciBU2pwqBZ((object) ((string) DbStructure.tpxbeyWul9cYgV4dHtTj(DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E((object) node), DbStructure.AXZlKCWuybnW6tTSTg3l(-1837662597 ^ -1837714627)))).ToUpper(), DbStructure.AXZlKCWuybnW6tTSTg3l(1470440286 ^ 1470475976)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 34 : 28;
                continue;
              }
              goto default;
            case 72:
              DbStructure.r2Xml9WIiP2cd9wKrdyW((object) dbColumn, DbStructure.tpxbeyWul9cYgV4dHtTj(DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E((object) node), DbStructure.AXZlKCWuybnW6tTSTg3l(~210725948 ^ -210722859))));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 42 : 42;
              continue;
            case 73:
              if (DbStructure.ssnjbcWugJciBU2pwqBZ((object) ((string) DbStructure.vxQjf0WumMOPHjXhdvJl((object) node)).ToUpper(), DbStructure.AXZlKCWuybnW6tTSTg3l(-1204263869 ^ -1341583247 ^ 137412548)))
              {
                num2 = 13;
                continue;
              }
              goto case 3;
            case 74:
              if (DbStructure.GjPaCSWudS7TMqtfvAdF((object) node.Attributes, DbStructure.AXZlKCWuybnW6tTSTg3l(1669212571 ^ 1669211533)) != null)
              {
                dbForeignKey.Name = (string) DbStructure.tpxbeyWul9cYgV4dHtTj(DbStructure.GjPaCSWudS7TMqtfvAdF((object) node.Attributes, DbStructure.AXZlKCWuybnW6tTSTg3l(-1217523399 ^ -1217520337)));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 34 : 36;
                continue;
              }
              num2 = 30;
              continue;
            default:
              if (DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E((object) node), DbStructure.AXZlKCWuybnW6tTSTg3l(1142330761 ^ 1541959139 ^ 536818996)) == null)
              {
                num2 = 28;
                continue;
              }
              goto case 29;
          }
        }
label_9:
        num1 = 12;
        continue;
label_58:
        if (((XmlAttributeCollection) DbStructure.pt0cfaWu9N4ZdF1DSZ9E(tableNode))[(string) DbStructure.AXZlKCWuybnW6tTSTg3l(-1876063057 ^ -1876066119)] != null)
        {
          num1 = 57;
          continue;
        }
        goto label_52;
label_69:
        dbColumn.Description = ((XmlNode) DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E((object) node), DbStructure.AXZlKCWuybnW6tTSTg3l(-680446928 - -370807692 ^ -309713496))).Value;
        num1 = 52;
        continue;
label_83:
        DbStructure.MUEMDIWIkbieB26UsG3b((object) dbColumn, (object) null);
        num1 = 69;
        continue;
label_101:
        DbStructure.iuq5bkWI2SZffvyoELcM((object) dbForeignKey, (object) ((XmlNode) DbStructure.GjPaCSWudS7TMqtfvAdF((object) node.Attributes, DbStructure.AXZlKCWuybnW6tTSTg3l(1051276242 - 990076387 ^ 61086373))).Value);
        num1 = 59;
      }
label_3:
      throw new Exception(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306565430)), DbStructure.FhvyAaWuAC4JyAPwAUFj((object) dbColumn), DbStructure.GHT8GcWujYYXdxwndgLH((object) dbTable)));
label_16:
      throw new Exception((string) DbStructure.wZ1W2HWIRisIbHFZ5m53(DbStructure.O5NYb5WuJa4ZO2C52yMy((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97985480)), (object) dbColumn.Name, (object) dbTable.Name));
label_35:
      throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335078903), DbStructure.GHT8GcWujYYXdxwndgLH((object) dbTable)));
label_40:
      throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606674684), DbStructure.K15hUsWIOsry5nh2lhET((object) dbForeignKey), (object) dbTable.Name));
label_43:
      return dbTable;
label_48:
      throw new Exception(EleWise.ELMA.SR.T((string) DbStructure.AXZlKCWuybnW6tTSTg3l(1149433385 + 173655049 ^ 1323133688), (object) dbForeignKey.Name, DbStructure.GHT8GcWujYYXdxwndgLH((object) dbTable)));
label_52:
      throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 901877205)));
label_72:
      throw new Exception(EleWise.ELMA.SR.T((string) DbStructure.AXZlKCWuybnW6tTSTg3l(1021410165 ^ 1021359401), DbStructure.GHT8GcWujYYXdxwndgLH((object) dbTable)));
label_78:
      throw new Exception((string) DbStructure.wZ1W2HWIRisIbHFZ5m53(DbStructure.O5NYb5WuJa4ZO2C52yMy(DbStructure.AXZlKCWuybnW6tTSTg3l(-1598106783 - -968262081 ^ -629892616)), DbStructure.FhvyAaWuAC4JyAPwAUFj((object) dbColumn), DbStructure.GHT8GcWujYYXdxwndgLH((object) dbTable)));
label_85:
      throw new Exception(EleWise.ELMA.SR.T((string) DbStructure.AXZlKCWuybnW6tTSTg3l(589593376 ^ -1977315327 ^ -1459542541), (object) dbForeignKey.Name, DbStructure.GHT8GcWujYYXdxwndgLH((object) dbTable)));
label_100:
      throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138841960), DbStructure.K15hUsWIOsry5nh2lhET((object) dbForeignKey), DbStructure.GHT8GcWujYYXdxwndgLH((object) dbTable)));
    }

    private static DbStructure.DbProcedure ReadProcedure(object procNode)
    {
      DbStructure.DbProcedure dbProcedure = new DbStructure.DbProcedure();
      if (((XmlAttributeCollection) DbStructure.pt0cfaWu9N4ZdF1DSZ9E(procNode))[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998537940)] == null)
        throw new Exception((string) DbStructure.O5NYb5WuJa4ZO2C52yMy((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998494034)));
      dbProcedure.Name = ((XmlNode) DbStructure.GjPaCSWudS7TMqtfvAdF((object) ((XmlNode) procNode).Attributes, DbStructure.AXZlKCWuybnW6tTSTg3l(-1088304168 ^ -1088305202))).Value;
      DbStructure.iIwBFDWIf4AWTX9b5FwA((object) dbProcedure, procNode);
      DbStructure.hGPFBTWICWNdrgaNIbCX((object) dbProcedure, procNode);
      dbProcedure.IgnoreVersions = DbStructure.ReadVersions(procNode);
      return dbProcedure;
    }

    private static DbStructure.UserMethod ReadUserMethods(object methNode, object methodExecutor)
    {
      int num1 = 4;
      DbStructure.UserMethod userMethod1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_5;
            case 2:
              userMethod1.IgnoreVersions = DbStructure.ReadVersions(methNode);
              num2 = 10;
              continue;
            case 3:
              if (DbStructure.GjPaCSWudS7TMqtfvAdF((object) ((XmlNode) methNode).Attributes, DbStructure.AXZlKCWuybnW6tTSTg3l(-1638402543 ^ -1638401529)) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 5 : 0;
                continue;
              }
              goto label_5;
            case 4:
              DbStructure.UserMethod userMethod2 = new DbStructure.UserMethod();
              DbStructure.tP51tfWINxSS5u8Zhuyv((object) userMethod2, methodExecutor);
              userMethod1 = userMethod2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 3 : 3;
              continue;
            case 5:
              goto label_6;
            case 6:
              DbStructure.r4kvWkWIp5HkkkEqx1Gn((object) userMethod1, DbStructure.GjPaCSWudS7TMqtfvAdF((object) ((XmlNode) methNode).Attributes, DbStructure.AXZlKCWuybnW6tTSTg3l(-1426456882 ^ 2009939514 ^ -583672350)) != null ? (object) ((XmlNode) methNode).Attributes[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87406239)].Value : DbStructure.UPfvs0WIouLew7b4n7gn((object) userMethod1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 8 : 3;
              continue;
            case 7:
              goto label_3;
            case 8:
              DbStructure.rZpZgaWIaD0JlVy9CZIW((object) userMethod1, DbStructure.ReadExecuteTime(methNode));
              num2 = 9;
              continue;
            case 9:
              DbStructure.loBBvHWIDFkI2GuaPM5R((object) userMethod1, DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E(methNode), DbStructure.AXZlKCWuybnW6tTSTg3l(-70007027 ^ -70120369)) != null && DbStructure.zfHKGeWIuD7BVxUZ0fHg(DbStructure.tpxbeyWul9cYgV4dHtTj(DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E(methNode), DbStructure.AXZlKCWuybnW6tTSTg3l(95909607 + 343705423 ^ 439498100))), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306483506), StringComparison.CurrentCultureIgnoreCase));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 2 : 0;
              continue;
            case 10:
              DbStructure.c3dAH8WIto12iuxmSDMS((object) userMethod1, DbStructure.GjPaCSWudS7TMqtfvAdF((object) ((XmlNode) methNode).Attributes, DbStructure.AXZlKCWuybnW6tTSTg3l(-281842504 ^ -281892904)) != null && DbStructure.zfHKGeWIuD7BVxUZ0fHg((object) ((XmlNode) DbStructure.GjPaCSWudS7TMqtfvAdF((object) ((XmlNode) methNode).Attributes, DbStructure.AXZlKCWuybnW6tTSTg3l(-1088304168 ^ -1088421704))).Value, DbStructure.AXZlKCWuybnW6tTSTg3l(1218962250 ^ 1218932444), StringComparison.CurrentCultureIgnoreCase));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
              continue;
            default:
              DbStructure.vkJT9UWIwOJudNiKDIgY((object) userMethod1, DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E(methNode), DbStructure.AXZlKCWuybnW6tTSTg3l(2045296739 + 1688595713 ^ -561027560)) != null ? DbStructure.tpxbeyWul9cYgV4dHtTj(DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E(methNode), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461676261))) : (object) null);
              num2 = 7;
              continue;
          }
        }
label_6:
        DbStructure.QvRs4fWI35wM5O6SeVw7((object) userMethod1, (object) ((XmlNode) DbStructure.GjPaCSWudS7TMqtfvAdF(DbStructure.pt0cfaWu9N4ZdF1DSZ9E(methNode), DbStructure.AXZlKCWuybnW6tTSTg3l(-477139494 ^ -477142580))).Value);
        num1 = 6;
      }
label_3:
      return userMethod1;
label_5:
      throw new Exception((string) DbStructure.O5NYb5WuJa4ZO2C52yMy(DbStructure.AXZlKCWuybnW6tTSTg3l(-542721635 ^ -542676867)));
    }

    private static DbStructure.ExecuteTime ReadExecuteTime(object node)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (DbStructure.GjPaCSWudS7TMqtfvAdF((object) ((XmlNode) node).Attributes, DbStructure.AXZlKCWuybnW6tTSTg3l(-1598106783 - -968262081 ^ -629897468)) == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return DbStructure.ExecuteTime.OnComplete;
label_5:
      // ISSUE: type reference
      return (DbStructure.ExecuteTime) DbStructure.V3ar7PWI6CqNuiE6rfrL(DbStructure.AK1rgiWI4BMr5629HpKX(__typeref (DbStructure.ExecuteTime)), DbStructure.tpxbeyWul9cYgV4dHtTj((object) ((XmlAttributeCollection) DbStructure.pt0cfaWu9N4ZdF1DSZ9E(node))[(string) DbStructure.AXZlKCWuybnW6tTSTg3l(712480695 ^ 712394129)]));
    }

    private static void ReadText(object textObj, object node)
    {
      int num = 6;
      while (true)
      {
        XmlNode xmlNode;
        switch (num)
        {
          case 1:
            if (!DbStructure.ssnjbcWugJciBU2pwqBZ(DbStructure.vxQjf0WumMOPHjXhdvJl((object) xmlNode), DbStructure.AXZlKCWuybnW6tTSTg3l(-105199646 ^ -105179742)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 2 : 4;
              continue;
            }
            goto case 9;
          case 2:
          case 5:
            if (xmlNode == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 3 : 2;
              continue;
            }
            goto case 1;
          case 3:
            goto label_11;
          case 4:
          case 7:
          case 8:
            xmlNode = (XmlNode) DbStructure.bTjM5DWuUPoS170aP7XU((object) xmlNode);
            num = 2;
            continue;
          case 6:
            xmlNode = (XmlNode) DbStructure.UrX5u6Wu0wbcaqrsv4N0(node);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 5 : 2;
            continue;
          case 9:
            if (DbStructure.z8OnhLWIHJ4Htqrym9HG((object) xmlNode) == null)
            {
              num = 7;
              continue;
            }
            break;
        }
        DbStructure.Enae4TWIAT0ZcaL3ma6m(textObj, DbStructure.z8OnhLWIHJ4Htqrym9HG((object) xmlNode));
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 8 : 8;
      }
label_11:;
    }

    private static void ReadMappings(object mappingsObj, object node)
    {
      int num = 2;
      XmlNode xmlNode;
      while (true)
      {
        switch (num)
        {
          case 2:
            xmlNode = (XmlNode) DbStructure.UrX5u6Wu0wbcaqrsv4N0(node);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 0;
            continue;
          case 3:
            if (!DbStructure.ssnjbcWugJciBU2pwqBZ(DbStructure.vxQjf0WumMOPHjXhdvJl((object) xmlNode), DbStructure.AXZlKCWuybnW6tTSTg3l(-1837662597 ^ -1837716425)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 5 : 1;
              continue;
            }
            goto case 7;
          case 4:
          case 5:
          case 10:
            xmlNode = (XmlNode) DbStructure.bTjM5DWuUPoS170aP7XU((object) xmlNode);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
            continue;
          case 6:
            DbStructure.FiqSCLWIxlKdDcPWmuNr(mappingsObj, DbStructure.F9FaTrWI7lHtn9Igwevh((object) xmlNode));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 9;
            continue;
          case 7:
            if (xmlNode.InnerXml == null)
            {
              num = 10;
              continue;
            }
            goto case 6;
          case 8:
            goto label_12;
          case 9:
            DbStructure.FiqSCLWIxlKdDcPWmuNr(mappingsObj, DbStructure.KEwwx6WImcdcMyoSim8t(DbStructure.AhoR6CWI0bwKSLCP9BtV(mappingsObj)));
            num = 4;
            continue;
          default:
            if (xmlNode == null)
            {
              num = 8;
              continue;
            }
            goto case 3;
        }
      }
label_12:;
    }

    internal static void ioi9jIWuKC0cWo9G7nv0() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool sM3iRjWuRmQA2ijAGurK() => DbStructure.REK1TFWuip1GeydpvaOw == null;

    internal static DbStructure amjBbIWuqgtFg6Cv9qFI() => DbStructure.REK1TFWuip1GeydpvaOw;

    internal static void iB13pWWuXpI0KQIW6T42([In] object obj0) => ((DbStructure) obj0).ReadXml();

    internal static bool trEqLFWuTgY9LLxMO2Ua([In] object obj0) => ((DbStructure) obj0).Deactivating;

    internal static bool PDSUGZWuksG5xdbGYRd6([In] object obj0) => ((DbStructure.UserMethod) obj0).OnDeactivate;

    internal static bool kMXXyVWunp8oC5mn5VMC([In] object obj0) => ((DbStructure.DbScript) obj0).OnDeactivate;

    internal static object gOhQLsWuOsXErWNKWeRV([In] object obj0) => (object) ((DbStructure.DbProcedure) obj0).Text;

    internal static bool H4b3BlWu2X3AsLUHZf3D([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static void hvcA37WueBmlPlq5l0F6([In] object obj0, [In] object obj1) => ((DbStructure.DbProcedure) obj0).Text = (string) obj1;

    internal static object ds3cB6WuPDJU63hAHwx3([In] object obj0) => (object) ((DbStructure.DbProcedure) obj0).Mappings;

    internal static void N7XCXRWu1xDkMid83fLe([In] object obj0, [In] object obj1) => ((DbStructure.DbProcedure) obj0).Mappings = (string) obj1;

    internal static object WK9nYVWuNgpnFWkSQXMV([In] object obj0) => (object) ((DbStructure.DbView) obj0).Text;

    internal static void FXEwPVWu3hnhcWgn5yJm([In] object obj0, [In] object obj1) => ((DbStructure.DbView) obj0).Text = (string) obj1;

    internal static object dH4hJdWupYieB3MmHhax([In] object obj0) => (object) ((DbStructure.DbView) obj0).Mappings;

    internal static object wp6hOnWuaa8J28UVjc2b([In] object obj0) => (object) ((DbStructure.DbIndex) obj0).Text;

    internal static void pQmXFxWuDy0KUIbW4U9O([In] object obj0, [In] object obj1) => ((DbStructure.DbIndex) obj0).Text = (string) obj1;

    internal static object UL6griWutes0x4AGY86U([In] object obj0) => (object) ((string) obj0).ToUpper();

    internal static object ajoLFkWuwmxu4XxyL2C0([In] object obj0) => (object) ((DbStructure.DbTable) obj0).Description;

    internal static void NsmOIaWu4ffWds0N5pmA([In] object obj0, [In] object obj1) => ((DbStructure.DbTable) obj0).Description = (string) obj1;

    internal static object hKblOrWu6WFJQq2TRrv5([In] object obj0) => (object) ((DbStructure.DbTable) obj0).Module;

    internal static void Oa13ZhWuHZdrHtaV9q6V([In] object obj0, [In] object obj1) => ((DbStructure.DbTable) obj0).Module = (string) obj1;

    internal static object FhvyAaWuAC4JyAPwAUFj([In] object obj0) => (object) ((DbStructure.DbColumn) obj0).Name;

    internal static object TWsZIsWu7LbRNkC4oX43([In] object obj0) => (object) ((DbStructure.DbColumn) obj0).Description;

    internal static void VjYMO2WuxdNC5xsMMdpu([In] object obj0, [In] object obj1) => ((DbStructure.DbColumn) obj0).Description = (string) obj1;

    internal static object UrX5u6Wu0wbcaqrsv4N0([In] object obj0) => (object) ((XmlNode) obj0).FirstChild;

    internal static object vxQjf0WumMOPHjXhdvJl([In] object obj0) => (object) ((XmlNode) obj0).Name;

    internal static object AXZlKCWuybnW6tTSTg3l(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool temBa1WuMEuxPtC2qUkq([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static object O5NYb5WuJa4ZO2C52yMy([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object pt0cfaWu9N4ZdF1DSZ9E([In] object obj0) => (object) ((XmlNode) obj0).Attributes;

    internal static object GjPaCSWudS7TMqtfvAdF([In] object obj0, [In] object obj1) => (object) ((XmlAttributeCollection) obj0)[(string) obj1];

    internal static object tpxbeyWul9cYgV4dHtTj([In] object obj0) => (object) ((XmlNode) obj0).Value;

    internal static object Ow3Z4xWur7bRGMTwQwEW([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static bool ssnjbcWugJciBU2pwqBZ([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object Q3jEoKWu5H7IZ3sAjQbu([In] object obj0) => (object) DbStructure.ReadTable(obj0);

    internal static object GHT8GcWujYYXdxwndgLH([In] object obj0) => (object) ((DbStructure.DbTable) obj0).Name;

    internal static object vsmjMZWuYdUdEMs9tkYN([In] object obj0) => (object) DbStructure.ReadView(obj0);

    internal static object RDVHQUWuLXU4uNrLiK7m([In] object obj0) => (object) ((DbStructure.DbView) obj0).Name;

    internal static object bTjM5DWuUPoS170aP7XU([In] object obj0) => (object) ((XmlNode) obj0).NextSibling;

    internal static object PklhiDWus7dgyfDYFKC7([In] object obj0) => (object) DbStructure.ReadTrigger(obj0);

    internal static object tg63PuWucfpnEslapXoy([In] object obj0) => (object) ((DbStructure.DbTrigger) obj0).Name;

    internal static object mPFrMfWuzEMgdbWscN4V([In] object obj0) => (object) ((DbStructure.DbScript) obj0).Name;

    internal static object eL9B3SWIFIyPvap5IIXA([In] object obj0) => (object) DbStructure.ReadProcedure(obj0);

    internal static object RXfOh8WIBFhRhuFMMfxj([In] object obj0) => (object) ((DbStructure.DbProcedure) obj0).Name;

    internal static object xfW5sKWIWPVo3wDRXnZ6([In] object obj0, [In] object obj1) => (object) DbStructure.ReadUserMethods(obj0, obj1);

    internal static object UPfvs0WIouLew7b4n7gn([In] object obj0) => (object) ((DbStructure.UserMethod) obj0).Name;

    internal static object GemKxfWIbUJyHsmSB4rS([In] object obj0) => (object) ((DbStructure.DbIndex) obj0).Name;

    internal static void Q8L236WIhrvxTVQM94uG([In] object obj0, [In] object obj1) => ((DbStructure.DbIndex) obj0).Name = (string) obj1;

    internal static void qnrL1AWIGQL4CRSEWyM7([In] object obj0, bool value) => ((DbStructure.DbIndex) obj0).IsUnique = value;

    internal static object odv9OWWIEGuQN40Jyldg([In] object obj0, [In] object obj1) => (object) ((string) obj0).Split((char[]) obj1);

    internal static void iIwBFDWIf4AWTX9b5FwA([In] object obj0, [In] object obj1) => DbStructure.ReadText(obj0, obj1);

    internal static int iXQbQAWIQ4No2NQwl8i0([In] object obj0) => ((List<string>) obj0).Count;

    internal static void hGPFBTWICWNdrgaNIbCX([In] object obj0, [In] object obj1) => DbStructure.ReadMappings(obj0, obj1);

    internal static void eMMneaWIvlLjdQN2I2Fj([In] object obj0, [In] object obj1) => ((DbStructure.DbScript) obj0).Name = (string) obj1;

    internal static DbStructure.ExecuteTime S2PJObWI8FTGVLcVhBlD([In] object obj0) => DbStructure.ReadExecuteTime(obj0);

    internal static void UtmrWtWIZLWLloEjXSgR([In] object obj0, DbStructure.ExecuteTime value) => ((DbStructure.DbScript) obj0).ExecuteTime = value;

    internal static bool zfHKGeWIuD7BVxUZ0fHg([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).Equals((string) obj1, obj2);

    internal static void M15rXdWIIOdOpdgJtv4v([In] object obj0, bool value) => ((DbStructure.DbScript) obj0).AlwaysExecute = value;

    internal static void hmRhvOWIVZlDJRURZiTG([In] object obj0, bool value) => ((DbStructure.DbScript) obj0).OnDeactivate = value;

    internal static void sXTpnjWIS6hJuvpCFdV4([In] object obj0, [In] object obj1) => ((DbStructure.DbScript) obj0).TransformationInVersion = (string) obj1;

    internal static void r2Xml9WIiP2cd9wKrdyW([In] object obj0, [In] object obj1) => ((DbStructure.DbColumn) obj0).Name = (string) obj1;

    internal static object wZ1W2HWIRisIbHFZ5m53([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static void hFan0pWIqBTbY24GNXEK([In] object obj0, [In] object obj1) => ((DbStructure.DbColumn) obj0).Type = (string) obj1;

    internal static void xuA8FhWIKYuU4dKQ2D3E([In] object obj0, bool value) => ((DbStructure.DbColumn) obj0).NotNull = value;

    internal static void WUuR3OWIXnNeBmOjAWh5([In] object obj0, bool value) => ((DbStructure.DbColumn) obj0).PrimaryKey = value;

    internal static void Ql1xm3WIT2tHH0Xqewcq([In] object obj0, [In] object obj1) => ((DbStructure.DbColumn) obj0).DefaultValue = (string) obj1;

    internal static void MUEMDIWIkbieB26UsG3b([In] object obj0, [In] object obj1) => ((DbStructure.DbColumn) obj0).Index = (string) obj1;

    internal static void D6kycEWInlLBWNwMqpkm([In] object obj0, [In] object obj1) => ((DbStructure.DbColumn) obj0).AfterCreation = (string) obj1;

    internal static object K15hUsWIOsry5nh2lhET([In] object obj0) => (object) ((DbStructure.DbForeignKey) obj0).Name;

    internal static void iuq5bkWI2SZffvyoELcM([In] object obj0, [In] object obj1) => ((DbStructure.DbForeignKey) obj0).KeyColumn = (string) obj1;

    internal static void KVi7mtWIeIRuWhioNMdK([In] object obj0, [In] object obj1) => ((DbStructure.DbForeignKey) obj0).RefTable = (string) obj1;

    internal static void dhUvhqWIPJhnQpRwAZ9g([In] object obj0, [In] object obj1) => ((DbStructure.DbForeignKey) obj0).OnDelete = (string) obj1;

    internal static void MgHddAWI17D8lvKIaIy8([In] object obj0, [In] object obj1) => ((DbStructure.DbForeignKey) obj0).AlterAction = (string) obj1;

    internal static void tP51tfWINxSS5u8Zhuyv([In] object obj0, [In] object obj1) => ((DbStructure.UserMethod) obj0).MethodExecutor = obj1;

    internal static void QvRs4fWI35wM5O6SeVw7([In] object obj0, [In] object obj1) => ((DbStructure.UserMethod) obj0).Name = (string) obj1;

    internal static void r4kvWkWIp5HkkkEqx1Gn([In] object obj0, [In] object obj1) => ((DbStructure.UserMethod) obj0).Method = (string) obj1;

    internal static void rZpZgaWIaD0JlVy9CZIW([In] object obj0, DbStructure.ExecuteTime value) => ((DbStructure.UserMethod) obj0).ExecuteTime = value;

    internal static void loBBvHWIDFkI2GuaPM5R([In] object obj0, bool value) => ((DbStructure.UserMethod) obj0).AlwaysExecute = value;

    internal static void c3dAH8WIto12iuxmSDMS([In] object obj0, bool value) => ((DbStructure.UserMethod) obj0).OnDeactivate = value;

    internal static void vkJT9UWIwOJudNiKDIgY([In] object obj0, [In] object obj1) => ((DbStructure.UserMethod) obj0).TransformationInVersion = (string) obj1;

    internal static Type AK1rgiWI4BMr5629HpKX([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object V3ar7PWI6CqNuiE6rfrL([In] Type obj0, [In] object obj1) => Enum.Parse(obj0, (string) obj1);

    internal static object z8OnhLWIHJ4Htqrym9HG([In] object obj0) => (object) ((XmlNode) obj0).InnerText;

    internal static void Enae4TWIAT0ZcaL3ma6m([In] object obj0, [In] object obj1) => ((DbStructure.IDbText) obj0).Text = (string) obj1;

    internal static object F9FaTrWI7lHtn9Igwevh([In] object obj0) => (object) ((XmlNode) obj0).InnerXml;

    internal static void FiqSCLWIxlKdDcPWmuNr([In] object obj0, [In] object obj1) => ((DbStructure.IDbMappings) obj0).Mappings = (string) obj1;

    internal static object AhoR6CWI0bwKSLCP9BtV([In] object obj0) => (object) ((DbStructure.IDbMappings) obj0).Mappings;

    internal static object KEwwx6WImcdcMyoSim8t([In] object obj0) => (object) DbStructureReader.PrepareSqlText((string) obj0);

    /// <summary>Время исполнения скриптов или методов</summary>
    public enum ExecuteTime
    {
      /// <summary>
      /// Перед началом преобразования (выполняется в отдельной транзакции)
      /// </summary>
      OnBeforeStart,
      /// <summary>Начало преобразования</summary>
      OnStart,
      /// <summary>После удаления триггеров</summary>
      OnTriggersDeleted,
      /// <summary>После удаления процедур</summary>
      OnProceduresDeleted,
      /// <summary>После удаления представлений</summary>
      OnViewsDeleted,
      /// <summary>После удаления индексов</summary>
      OnIndexesDeleted,
      /// <summary>После удаления внешних ключей</summary>
      OnForeignKeysDeleted,
      /// <summary>После удаления первичных ключей</summary>
      OnPrimaryKeysDeleted,
      /// <summary>Перед созданием таблиц и колонок</summary>
      OnTablesCreating,
      /// <summary>После создания таблиц и колонок</summary>
      OnTablesCreated,
      /// <summary>Перед удалением ненужных таблиц и колонок</summary>
      OnTablesDeleting,
      /// <summary>После удаления ненужных таблиц и колонок</summary>
      OnTablesDeleted,
      /// <summary>После создания внешних ключей</summary>
      OnForeignKeysCreated,
      /// <summary>После создания первичных ключей</summary>
      OnPrimaryKeysCreated,
      /// <summary>После создания индексов</summary>
      OnIndexesCreated,
      /// <summary>После создания представлений</summary>
      OnViewsCreated,
      /// <summary>После создания процедур</summary>
      OnProceduresCreated,
      /// <summary>После создания триггеров</summary>
      OnTriggersCreated,
      /// <summary>После завершения преобразования</summary>
      OnComplete,
    }

    /// <summary>Интерфейс для объекта БД, имеющего SQL-скрипт</summary>
    public interface IDbText
    {
      /// <summary>SQL-скрипт</summary>
      string Text { get; set; }
    }

    /// <summary>
    /// Интерфейс для объекта БД, имеющего NHibernate-маппинги
    /// </summary>
    public interface IDbMappings
    {
      /// <summary>NHibernate-маппинги</summary>
      string Mappings { get; set; }
    }

    /// <summary>Таблица</summary>
    [Serializable]
    public class DbTable
    {
      private string name;
      private string description;
      private string module;
      private SerializableDictionary<string, DbStructure.DbColumn> columns;
      private SerializableDictionary<string, DbStructure.DbForeignKey> foreignKeys;
      private List<string> ignoreVersions;
      private static DbStructure.DbTable gYvDqZQaiPBqskv7PyKi;

      /// <summary>Имя</summary>
      public string Name
      {
        get => this.name;
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
                this.name = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
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

      /// <summary>Описание</summary>
      public string Description
      {
        get => this.description;
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
                this.description = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
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

      /// <summary>Модуль</summary>
      public string Module
      {
        get => this.module;
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
                this.module = value;
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

      /// <summary>Колонки</summary>
      public SerializableDictionary<string, DbStructure.DbColumn> Columns => this.columns;

      /// <summary>Внешние ключи</summary>
      public SerializableDictionary<string, DbStructure.DbForeignKey> ForeignKeys => this.foreignKeys;

      /// <summary>Первичный ключ</summary>
      public DbStructure.DbColumn PrimaryColumn
      {
        get
        {
          int num1 = 2;
          Dictionary<string, DbStructure.DbColumn>.ValueCollection.Enumerator enumerator;
          while (true)
          {
            switch (num1)
            {
              case 1:
                goto label_3;
              case 2:
                enumerator = this.columns.Values.GetEnumerator();
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 1;
                continue;
              default:
                goto label_16;
            }
          }
label_3:
          DbStructure.DbColumn primaryColumn;
          try
          {
label_10:
            if (enumerator.MoveNext())
              goto label_6;
            else
              goto label_11;
label_4:
            DbStructure.DbColumn current;
            int num2;
            while (true)
            {
              switch (num2)
              {
                case 1:
                  if (current.PrimaryKey)
                  {
                    num2 = 5;
                    continue;
                  }
                  goto label_10;
                case 2:
                  goto label_16;
                case 3:
                  goto label_17;
                case 4:
                  goto label_10;
                case 5:
                  primaryColumn = current;
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 3 : 3;
                  continue;
                default:
                  goto label_6;
              }
            }
label_6:
            current = enumerator.Current;
            num2 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
            {
              num2 = 1;
              goto label_4;
            }
            else
              goto label_4;
label_11:
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 2 : 2;
            goto label_4;
          }
          finally
          {
            enumerator.Dispose();
            int num3 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
              num3 = 0;
            switch (num3)
            {
              default:
            }
          }
label_17:
          return primaryColumn;
label_16:
          return (DbStructure.DbColumn) null;
        }
      }

      /// <summary>Версии, для которых не нужно обновлять</summary>
      public List<string> IgnoreVersions
      {
        get => this.ignoreVersions;
        set => this.ignoreVersions = value;
      }

      public DbTable()
      {
        DbStructure.DbTable.HyP0cvQaKZ1ypbWMDfWH();
        this.columns = new SerializableDictionary<string, DbStructure.DbColumn>();
        this.foreignKeys = new SerializableDictionary<string, DbStructure.DbForeignKey>();
        this.ignoreVersions = new List<string>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool cZHO9OQaR1MfRE6qOQbY() => DbStructure.DbTable.gYvDqZQaiPBqskv7PyKi == null;

      internal static DbStructure.DbTable jhxVFsQaqO0pPYZMiEAK() => DbStructure.DbTable.gYvDqZQaiPBqskv7PyKi;

      internal static void HyP0cvQaKZ1ypbWMDfWH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }

    /// <summary>Колонка таблицы</summary>
    [Serializable]
    public class DbColumn
    {
      private string name;
      private string description;
      private string type;
      private bool notNull;
      private bool primaryKey;
      private bool uniqueKey;
      private int stringFieldLength;
      private string defVal;
      private string index;
      private string afterCreation;
      private List<string> ignoreVersions;
      internal static DbStructure.DbColumn lXYpW1QaXa1TKmkGkOvo;

      /// <summary>Имя</summary>
      public string Name
      {
        get => this.name;
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
                this.name = value;
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

      /// <summary>Описание</summary>
      public string Description
      {
        get => this.description;
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
                this.description = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
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

      /// <summary>Тип данных</summary>
      public string Type
      {
        get => this.type;
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
                this.type = value;
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

      /// <summary>Not null</summary>
      public bool NotNull
      {
        get => this.notNull;
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
                this.notNull = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
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

      /// <summary>Первичный ключ</summary>
      public bool PrimaryKey
      {
        get => this.primaryKey;
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
                this.primaryKey = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
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

      public bool UniqueKey
      {
        get => this.uniqueKey;
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
                this.uniqueKey = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
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

      /// <summary>Длина (для текстового поля)</summary>
      public int StringFieldLength
      {
        get => this.stringFieldLength;
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
                this.stringFieldLength = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
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

      /// <summary>Значение по умолчанию</summary>
      public string DefaultValue
      {
        get => this.defVal;
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
                this.defVal = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
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

      /// <summary>Имя индекса (если не индексированная колонка - null)</summary>
      public string Index
      {
        get => this.index;
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
                this.index = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
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

      /// <summary>Скрипт, выполняемый после создания</summary>
      public string AfterCreation
      {
        get => this.afterCreation;
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
                this.afterCreation = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
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

      /// <summary>Версии, для которых не нужно обновлять</summary>
      public List<string> IgnoreVersions
      {
        get => this.ignoreVersions;
        set => this.ignoreVersions = value;
      }

      public DbColumn()
      {
        DbStructure.DbColumn.PhxHbrQanfGdc2XLuc9E();
        this.stringFieldLength = (int) byte.MaxValue;
        this.ignoreVersions = new List<string>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool cclJoiQaTlM3Ix5JCBgw() => DbStructure.DbColumn.lXYpW1QaXa1TKmkGkOvo == null;

      internal static DbStructure.DbColumn lKIxDYQak9gMrWSpOsAu() => DbStructure.DbColumn.lXYpW1QaXa1TKmkGkOvo;

      internal static void PhxHbrQanfGdc2XLuc9E() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }

    /// <summary>Внешний ключ</summary>
    [Serializable]
    public class DbForeignKey
    {
      private string name;
      private string keyColumn;
      private string refTable;
      private string refColumn;
      private string onDelete;
      private string alteraction;
      private List<string> ignoreVersions;
      internal static DbStructure.DbForeignKey Ypwcd1QaOqFtAg2F5CKh;

      /// <summary>Имя</summary>
      public string Name
      {
        get => this.name;
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
                this.name = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
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

      /// <summary>Ключевое поле</summary>
      public string KeyColumn
      {
        get => this.keyColumn;
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
                this.keyColumn = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
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

      /// <summary>Ссылаемая таблица</summary>
      public string RefTable
      {
        get => this.refTable;
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
                this.refTable = value;
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

      /// <summary>Ссылаемая колонка</summary>
      public string RefColumn
      {
        get => this.refColumn;
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
                this.refColumn = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
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

      /// <summary>Правило удаления</summary>
      public string OnDelete
      {
        get => this.onDelete;
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
                this.onDelete = value;
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

      /// <summary>
      /// Действие, которое производится перед созданием внешнего ключа
      /// </summary>
      public string AlterAction
      {
        get => this.alteraction;
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
                this.alteraction = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
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

      /// <summary>Версии, для которых не нужно обновлять</summary>
      public List<string> IgnoreVersions
      {
        get => this.ignoreVersions;
        set => this.ignoreVersions = value;
      }

      public DbForeignKey()
      {
        DbStructure.DbForeignKey.vladEfQaPoTmXrTQ2WQ9();
        this.ignoreVersions = new List<string>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool XdMtpdQa2aVwyVGw6haJ() => DbStructure.DbForeignKey.Ypwcd1QaOqFtAg2F5CKh == null;

      internal static DbStructure.DbForeignKey OyFYxoQaevfyPMePaw1I() => DbStructure.DbForeignKey.Ypwcd1QaOqFtAg2F5CKh;

      internal static void vladEfQaPoTmXrTQ2WQ9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }

    /// <summary>Представление</summary>
    [Serializable]
    public class DbView : DbStructure.IDbText, DbStructure.IDbMappings
    {
      private string name;
      private string text;
      private string mappings;
      private List<string> ignoreVersions;
      internal static DbStructure.DbView YQLbx2Qa1S8qWqNurgWq;

      /// <summary>Имя</summary>
      public string Name
      {
        get => this.name;
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
                this.name = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
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

      /// <summary>Текст представления</summary>
      public string Text
      {
        get => this.text;
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
                this.text = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
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

      /// <summary>NHibernate-маппинги</summary>
      public string Mappings
      {
        get => this.mappings;
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
                this.mappings = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
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

      /// <summary>Версии, для которых не нужно обновлять</summary>
      public List<string> IgnoreVersions
      {
        get => this.ignoreVersions;
        set => this.ignoreVersions = value;
      }

      public DbView()
      {
        DbStructure.DbView.OMhhlgQapEoix3bKyHIT();
        this.ignoreVersions = new List<string>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool hV6ToYQaN34iKGQUQMbG() => DbStructure.DbView.YQLbx2Qa1S8qWqNurgWq == null;

      internal static DbStructure.DbView KpJ5AnQa3tvtDAtkpStY() => DbStructure.DbView.YQLbx2Qa1S8qWqNurgWq;

      internal static void OMhhlgQapEoix3bKyHIT() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }

    /// <summary>Триггер</summary>
    [Serializable]
    public class DbTrigger : DbStructure.IDbText
    {
      private string name;
      private string text;
      private List<string> ignoreVersions;
      internal static DbStructure.DbTrigger OcA3p9QaaZxXwvpBMkuC;

      /// <summary>Имя</summary>
      public string Name
      {
        get => this.name;
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
                this.name = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
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

      /// <summary>Текст</summary>
      public string Text
      {
        get => this.text;
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
                this.text = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
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

      /// <summary>Версии, для которых не нужно обновлять</summary>
      public List<string> IgnoreVersions
      {
        get => this.ignoreVersions;
        set => this.ignoreVersions = value;
      }

      public DbTrigger()
      {
        DbStructure.DbTrigger.fN0KBBQawsG3TRGAiLGG();
        this.ignoreVersions = new List<string>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool iNO0RIQaDRRjeq1hNCw1() => DbStructure.DbTrigger.OcA3p9QaaZxXwvpBMkuC == null;

      internal static DbStructure.DbTrigger Ldg2mPQatpFHuq1DagJN() => DbStructure.DbTrigger.OcA3p9QaaZxXwvpBMkuC;

      internal static void fN0KBBQawsG3TRGAiLGG() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }

    /// <summary>SQL-Скрипт</summary>
    [Serializable]
    public class DbScript : DbStructure.IDbText
    {
      private string name;
      private DbStructure.ExecuteTime executeTime;
      private bool alwaysExecute;
      private string text;
      private List<string> ignoreVersions;
      private List<string> executeVersions;
      private bool onDeactivate;
      private static DbStructure.DbScript RZpGDUQa4OO7l9UeTbSK;

      /// <summary>Имя скрипта</summary>
      public string Name
      {
        get => this.name;
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
                this.name = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
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

      /// <summary>Время исполнения скрипта</summary>
      public DbStructure.ExecuteTime ExecuteTime
      {
        get => this.executeTime;
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
                this.executeTime = value;
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
      }

      /// <summary>Выполнять каждый раз при обновлении</summary>
      public bool AlwaysExecute
      {
        get => this.alwaysExecute;
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
                this.alwaysExecute = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
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

      /// <summary>SQL-скрипт</summary>
      public string Text
      {
        get => this.text;
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
                this.text = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
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

      /// <summary>Версии, для которых не нужно обновлять</summary>
      public List<string> IgnoreVersions
      {
        get => this.ignoreVersions;
        set => this.ignoreVersions = value;
      }

      /// <summary>Версии, для которых нужно обновлять</summary>
      public List<string> ExecuteVersions
      {
        get => this.executeVersions;
        set => this.executeVersions = value;
      }

      /// <summary>Выполнять при деактивации модуля</summary>
      public bool OnDeactivate
      {
        get => this.onDeactivate;
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
                this.onDeactivate = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
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

      /// <summary>Метка преобразования существующих данных</summary>
      /// <remarks>
      /// Атрибут устанавливается для описания скрипта в dbstructure.xml для пометки действия выполняемого только для преобразования существующей базы.
      /// В качестве значения рекомендуется указывать версию ELMA, для которой добавляется действие.
      /// Помеченное таким образом действие при первом старте системы выполняться не будет.
      /// </remarks>
      public string TransformationInVersion
      {
        get => this.\u003CTransformationInVersion\u003Ek__BackingField;
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
                this.\u003CTransformationInVersion\u003Ek__BackingField = value;
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

      public DbScript()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        this.ignoreVersions = new List<string>();
        this.executeVersions = new List<string>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool bs6OkZQa6OMfmgGhN3VU() => DbStructure.DbScript.RZpGDUQa4OO7l9UeTbSK == null;

      internal static DbStructure.DbScript wNmCw0QaHZUux3NMcuYM() => DbStructure.DbScript.RZpGDUQa4OO7l9UeTbSK;
    }

    /// <summary>Хранимая процедура</summary>
    [Serializable]
    public class DbProcedure : DbStructure.IDbText, DbStructure.IDbMappings
    {
      private string name;
      private string text;
      private string mappings;
      private List<string> ignoreVersions;
      private static DbStructure.DbProcedure c8h1ALQaA3QRj4JWq3mW;

      /// <summary>Имя</summary>
      public string Name
      {
        get => this.name;
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
                this.name = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
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

      /// <summary>Текст создания процедуры</summary>
      public string Text
      {
        get => this.text;
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
                this.text = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
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

      /// <summary>Маппинги для NHibernate</summary>
      public string Mappings
      {
        get => this.mappings;
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
                this.mappings = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
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

      /// <summary>Версии, для которых не нужно обновлять</summary>
      public List<string> IgnoreVersions
      {
        get => this.ignoreVersions;
        set => this.ignoreVersions = value;
      }

      public DbProcedure()
      {
        DbStructure.DbProcedure.bpxcfEQa0AcuX3QMtvTv();
        this.ignoreVersions = new List<string>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool Flavb0Qa7ekDRBhR4XJq() => DbStructure.DbProcedure.c8h1ALQaA3QRj4JWq3mW == null;

      internal static DbStructure.DbProcedure JqruF9QaxNClMgFV08UB() => DbStructure.DbProcedure.c8h1ALQaA3QRj4JWq3mW;

      internal static void bpxcfEQa0AcuX3QMtvTv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }

    /// <summary>Вызов методов</summary>
    [Serializable]
    public class UserMethod
    {
      private string name;
      private bool alwaysExecute;
      private string method;
      private DbStructure.ExecuteTime executeTime;
      private List<string> ignoreVersions;
      private object methodExecutor;
      private bool onDeactivate;
      private static DbStructure.UserMethod PbebKuQamfwkmqjIqBJc;

      /// <summary>Имя метода</summary>
      public string Name
      {
        get => this.name;
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
                this.name = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
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

      /// <summary>Выполнять каждый раз при обновлении</summary>
      public bool AlwaysExecute
      {
        get => this.alwaysExecute;
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
                this.alwaysExecute = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
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

      /// <summary>Имя метода в классе</summary>
      public string Method
      {
        get => this.method;
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
                this.method = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
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

      /// <summary>Время исполнения метода</summary>
      public DbStructure.ExecuteTime ExecuteTime
      {
        get => this.executeTime;
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
                this.executeTime = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
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

      /// <summary>Версии, для которых не нужно обновлять</summary>
      public List<string> IgnoreVersions
      {
        get => this.ignoreVersions;
        set => this.ignoreVersions = value;
      }

      /// <summary>Объект, содержащий метод для исполнения</summary>
      public object MethodExecutor
      {
        get => this.methodExecutor;
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
                this.methodExecutor = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
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

      /// <summary>Выполнять при деактивации модуля</summary>
      public bool OnDeactivate
      {
        get => this.onDeactivate;
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
                this.onDeactivate = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
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

      /// <summary>Метка преобразования существующих данных</summary>
      /// <remarks>
      /// Атрибут устанавливается для описания метода в dbstructure.xml для пометки действия выполняемого только для преобразования существующей базы.
      /// В качестве значения рекомендуется указывать версию ELMA, для которой добавляется действие.
      /// Помеченное таким образом действие при первом старте системы выполняться не будет.
      /// </remarks>
      public string TransformationInVersion
      {
        get => this.\u003CTransformationInVersion\u003Ek__BackingField;
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
                this.\u003CTransformationInVersion\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
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

      public UserMethod()
      {
        DbStructure.UserMethod.twbZSvQaJ4LFvZAZuAuQ();
        this.ignoreVersions = new List<string>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool rycZOOQayF5EQ3dW2iBV() => DbStructure.UserMethod.PbebKuQamfwkmqjIqBJc == null;

      internal static DbStructure.UserMethod EJw8AiQaM9ZMPGSW1uuJ() => DbStructure.UserMethod.PbebKuQamfwkmqjIqBJc;

      internal static void twbZSvQaJ4LFvZAZuAuQ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }

    /// <summary>Индекс</summary>
    [Serializable]
    public class DbIndex : DbStructure.IDbText
    {
      private string name;
      private string tableName;
      private string text;
      private bool isUnique;
      private List<string> columns;
      private List<string> ignoreVersions;
      private List<string> executeVersions;
      private bool onDeactivate;
      internal static DbStructure.DbIndex sUF1hNQa9tlWitFh1OQB;

      /// <summary>Имя индекса</summary>
      public string Name
      {
        get => this.name;
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
                this.name = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
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

      /// <summary>Текст скрипта для создания нестандартного индекса</summary>
      public string TableName
      {
        get => this.tableName;
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
                this.tableName = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
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

      /// <summary>Время исполнения индекса (всегда OnIndexesCreated)</summary>
      public DbStructure.ExecuteTime ExecuteTime => DbStructure.ExecuteTime.OnIndexesCreated;

      /// <summary>
      /// Выполнять каждый раз при обновлении (для индексов всегда true)
      /// </summary>
      public bool AlwaysExecute => true;

      /// <summary>Текст скрипта для создания нестандартного индекса</summary>
      public string Text
      {
        get => this.text;
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
                this.text = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
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

      /// <summary>Флаг уникальности индекса (true == уникальный)</summary>
      public bool IsUnique
      {
        get => this.isUnique;
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
                this.isUnique = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
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

      /// <summary>Колонки, входящие в индекс</summary>
      public List<string> Columns
      {
        get => this.columns;
        set => this.columns = value;
      }

      /// <summary>Версии, для которых не нужно обновлять</summary>
      public List<string> IgnoreVersions
      {
        get => this.ignoreVersions;
        set => this.ignoreVersions = value;
      }

      /// <summary>Версии, для которых нужно обновлять</summary>
      public List<string> ExecuteVersions
      {
        get => this.executeVersions;
        set => this.executeVersions = value;
      }

      public DbIndex()
      {
        DbStructure.DbIndex.up1Jf2QarFKkpPXX3SHp();
        this.columns = new List<string>();
        this.ignoreVersions = new List<string>();
        this.executeVersions = new List<string>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool tTgSsbQadEQ0fgPVum1Y() => DbStructure.DbIndex.sUF1hNQa9tlWitFh1OQB == null;

      internal static DbStructure.DbIndex vrKLKKQal7em7rUlT6ds() => DbStructure.DbIndex.sUF1hNQa9tlWitFh1OQB;

      internal static void up1Jf2QarFKkpPXX3SHp() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
