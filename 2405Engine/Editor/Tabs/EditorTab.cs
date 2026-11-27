using _2405Engine.Editor.UI;
using _2405Engine.Editor.Windows;
using Gum.Forms.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;

namespace _2405Engine.Editor.Tabs;

public class EditorTab
{
    public string Name { get { return GetName(); } }
    protected EditorWindow OwnerWindow;
    protected Panel ParentPanel => OwnerWindow.ContentPanel;
    protected Panel TabPanel;

    protected EditorTab(EditorWindow ownerWindow)
    {
        OwnerWindow = ownerWindow;
    }

    public virtual void Initialize()
    {
        if (ParentPanel == null)
        {
            throw new InvalidOperationException("Panel of editor window has not been initialized.");
        }
        TabPanel = new Panel();
        TabPanel.Dock(Gum.Wireframe.Dock.Fill);
        ParentPanel.AddChild(TabPanel);
    }

    protected virtual string GetName()
    {
        return "tab";
    }

    public virtual void Hide()
    {
        TabPanel.IsVisible = false;
    }

    public virtual void Show()
    {
        TabPanel.IsVisible = true;
    }

    public virtual void Remove()
    {
        if (TabPanel == null) return;
        ParentPanel?.RemoveChild(TabPanel);
        TabPanel = null;
    }

}
