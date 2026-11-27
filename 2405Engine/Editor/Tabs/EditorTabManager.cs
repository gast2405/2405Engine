using System;
using System.Collections.Generic;
using System.Text;

namespace _2405Engine.Editor.Tabs;
public class EditorTabManager
{
    public List<EditorTab> Tabs = new List<EditorTab> { };

    public event Action<EditorTab> TabAdded;
    private EditorTab activeTab;

    public void AddTab(EditorTab tab)
    {
        Tabs.Add(tab);
        tab.Initialize();
        tab.Hide();

        TabAdded?.Invoke(tab);

        SwitchTab(tab);
    }

    public void SwitchTab(EditorTab tab)
    {
        if (!Tabs.Contains(tab)) throw new ArgumentException("Tab does not belong to this window");

        if (activeTab == tab) return;

        activeTab?.Hide();

        activeTab = tab;
        activeTab.Show();
    }
}
