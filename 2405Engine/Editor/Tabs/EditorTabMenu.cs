using _2405Engine.Editor.UI;
using _2405Engine.Editor.Windows;
using Gum.Forms.Controls;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2405Engine.Editor.Tabs;
public class EditorTabMenu
{
    public StackPanel MenuPanel;
    private EditorTabManager tabManager;

    public EditorTabMenu(EditorTabManager _tabManager)
    {
        tabManager = _tabManager;

        MenuPanel = new StackPanel
        {
            Orientation = Orientation.Horizontal,
            Spacing = 5,
            //Width = 400,
            //Height = 35
        };

        tabManager.TabAdded += AddTabButton;

        foreach (EditorTab tab in tabManager.Tabs)
        {
            AddTabButton(tab);
        }
    }

    private void AddTabButton(EditorTab tab)
    {
        Button button = new EditorButton();

        button.Text = tab.Name;

        button.Click += (sender, args) =>
        {
            tabManager.SwitchTab(tab);
        };

        MenuPanel.AddChild(button);
    }
}
