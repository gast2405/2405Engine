using _2405Engine.Editor.UI;
using _2405Engine.Editor.Windows;
using Gum.Forms.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace _2405Engine.Editor.Tabs;

public class DefaultEditorTab : EditorTab
{
    private Panel selectionPanel;
    private float buttonMargin = 10f;

    public DefaultEditorTab(EditorWindow ownerWinodw) : base(ownerWinodw)
    {

    }
    public override void Initialize()
    {
        base.Initialize();
        selectionPanel = new Panel();
        selectionPanel.Dock(Gum.Wireframe.Dock.Fill);
        TabPanel.AddChild(selectionPanel);

        StackPanel buttonContainer = new StackPanel();
        buttonContainer.Orientation = Orientation.Vertical;
        buttonContainer.Spacing = buttonMargin;

        buttonContainer.Anchor(Gum.Wireframe.Anchor.TopLeft);
        selectionPanel.AddChild(buttonContainer);

        Button hierarchyButton = new EditorButton();
        hierarchyButton.Text = "Hierarchy";
        hierarchyButton.Click += (sender, args) =>
        {
            OwnerWindow.TabManager.AddTab(new HierarchyTab(OwnerWindow));
        };
        buttonContainer.AddChild(hierarchyButton);

        Button inspectorButton = new EditorButton();
        inspectorButton.Text = "Inspector";
        inspectorButton.Click += (sender, args) =>
        {
            Debug.WriteLine("Clicking inspector");
            OwnerWindow.TabManager.AddTab(new InspectorTab(OwnerWindow));
        };
        
        buttonContainer.AddChild(inspectorButton);
    }
    protected override string GetName()
    {
        return "Add tabs";
    }
}
