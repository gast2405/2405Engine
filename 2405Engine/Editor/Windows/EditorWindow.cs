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

    public List<EditorTab> Tabs = new List<EditorTab> { };

    public Panel Panel;


    public EditorWindow(EditorTab startTab = null, float width = 10f, float height = 10f)
    {
        Height = height;
        Width = width;

        Panel = new Panel
        {
            X = Position.X,
            Y = Position.Y,
            Height = Height,
            Width = Width
        };

        if (startTab == null)
        {
            Tabs.Add(new EditorTab(Panel));
        } else
        {
            startTab.Initialize(Panel);
            Tabs.Add(startTab);
        }
        
        
    }

    public virtual void Instantiate()
    {
        Panel.AddToRoot();
    }

    private void HandleHierarchyClicked(object sender, EventArgs e)
    {
    }

    private void HandleInspectorClicked(object sender, EventArgs e)
    {
    }
}

