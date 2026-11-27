using _2405Engine.Editor.Tabs;
using _2405Engine.Editor.UI;
using Gum.Forms.Controls;
using Gum.GueDeriving;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace _2405Engine.Editor.Windows;
public class EditorWindow
{
    public Vector2 Position { get; set; }
    public float Height { get; set; }
    public float Width { get; set; }

    public readonly EditorPanel Panel;

    public Panel ContentPanel { get; private set; }

    public EditorTabManager TabManager { get; private set; }

    private EditorTabMenu tabMenu;

    private bool isDestroyed;

    public EditorWindow(float width = 100f, float height = 100f)
    {
        Height = height;
        Width = width;

        Panel = new EditorPanel
        {
            X = Position.X,
            Y = Position.Y,
            Height = height,
            Width = width
        };

        ContentPanel = new Panel
        {
            X = 0,
            Y = 35,
            Width = width,
            Height = height - 35
        };

        Panel.AddChild(ContentPanel);
    }

    public virtual void Instantiate()
    {
        TabManager = new EditorTabManager();

        tabMenu = new EditorTabMenu(TabManager);

        Panel.AddChild(tabMenu.MenuPanel);

        TabManager.AddTab(new DefaultEditorTab(this));

        //destroys the window if all tabs are removed
        TabManager.AllTabsRemoved += Destroy; 

        Core.EditorGui.AddChild(Panel);
    }

    public void Destroy()
    {
        if (isDestroyed) return;
        isDestroyed = true;
        Core.EditorGui.RemoveChild(Panel);
    }
}

