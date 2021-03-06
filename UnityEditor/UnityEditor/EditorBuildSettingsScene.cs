﻿// Decompiled with JetBrains decompiler
// Type: UnityEditor.EditorBuildSettingsScene
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 01B28312-B6F5-4E06-90F6-BE297B711E41
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEditor.dll

using System;
using System.Runtime.InteropServices;

namespace UnityEditor
{
  [StructLayout(LayoutKind.Sequential)]
  public sealed class EditorBuildSettingsScene : IComparable
  {
    private int m_Enabled;
    private string m_Path;

    public bool enabled
    {
      get
      {
        return this.m_Enabled != 0;
      }
      set
      {
        this.m_Enabled = !value ? 0 : 1;
      }
    }

    public string path
    {
      get
      {
        return this.m_Path;
      }
      set
      {
        this.m_Path = value.Replace("\\", "/");
      }
    }

    public EditorBuildSettingsScene(string path, bool enable)
    {
      this.m_Path = path.Replace("\\", "/");
      this.enabled = enable;
    }

    public EditorBuildSettingsScene()
    {
    }

    public int CompareTo(object obj)
    {
      if (obj is EditorBuildSettingsScene)
        return ((EditorBuildSettingsScene) obj).m_Path.CompareTo(this.m_Path);
      throw new ArgumentException("object is not a EditorBuildSettingsScene");
    }
  }
}
