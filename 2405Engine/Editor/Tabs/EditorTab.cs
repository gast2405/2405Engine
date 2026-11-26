using _2405Engine.Editor.UI;
using Gum.Forms.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2405Engine.Editor.Tabs;

public class EditorTab
{
    protected Panel ParentPanel;
    private Panel selectionPanel;

    private float buttonMargin = 10f;

    public EditorTab() 
    
    {
        
    }
    public EditorTab(Panel parentPanel)
    {
        Initialize(parentPanel);
    }

    public virtual void Initialize(Panel parentPanel)
    {
        ParentPanel = parentPanel;
        selectionPanel = new Panel();
        selectionPanel.Dock(Gum.Wireframe.Dock.Fill);
        ParentPanel.AddChild(selectionPanel);

        StackPanel buttonContainer = new StackPanel();
        buttonContainer.Orientation = Orientation.Vertical;
        buttonContainer.Spacing = buttonMargin;

        buttonContainer.Anchor(Gum.Wireframe.Anchor.TopLeft);
        selectionPanel.AddChild(buttonContainer);

        Button hierarchyButton = new EditorButton();
        hierarchyButton.Text = "Hierarchy";
        //hierarchyButton.Click += HandleHierarchyClicked;
        buttonContainer.AddChild(hierarchyButton);

        Button inspectorButton = new EditorButton();
        inspectorButton.Text = "Inspector";
        //inspectorButton.Click += HandleInspectorClicked;
        buttonContainer.AddChild(inspectorButton);
    }

}
