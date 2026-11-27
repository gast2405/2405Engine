using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using Gum.Forms.Controls;
using Gum.GueDeriving;
using _2405Engine.Editor.Windows;

namespace _2405Engine.Editor.Tabs;

public class HierarchyTab : EditorTab
{
    public HierarchyTab(EditorWindow ownerWinodw) : base(ownerWinodw)
    {

    }

    public override void Initialize()
    {
        base.Initialize();
        var title = new TextBox();
        title.Text = "Hello this is the Hierarchy";
        TabPanel.AddChild(title);
    }

    protected override string GetName()
    {
        return "Hierarchy";
    }

}
