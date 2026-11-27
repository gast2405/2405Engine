using System;
using System.Collections.Generic;
using System.Text;

namespace _2405Engine.Editor.Tabs;
public class EditorTabManager
{
    public List<EditorTab> Tabs = new List<EditorTab> { };

    public event Action<EditorTab> TabAdded;
    public event Action<EditorTab> TabRemoved;

    public event Action AllTabsRemoved;
    private EditorTab activeTab;

    public void AddTab(EditorTab tab)
    {
        Tabs.Add(tab);
        tab.Initialize();
        tab.Hide();

        TabAdded?.Invoke(tab);

        SwitchTab(tab);
    }

    public void RemoveTab(EditorTab tab)
    {
        if (!Tabs.Contains(tab)) return;

        tab.Remove();

        Tabs.Remove(tab);

        TabRemoved?.Invoke(tab);

        if (activeTab == tab)
        {
            activeTab = null;
            if (Tabs.Count > 0)
            {
                SwitchTab(Tabs[0]);
            }
        }

        if (Tabs.Count == 0)
        {
            AllTabsRemoved?.Invoke();
        }
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
