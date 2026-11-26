using Gum.Forms.Controls;
using Gum.GueDeriving;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2405Engine.Editor.UI;
public class EditorStackPanel: StackPanel
{
    public EditorStackPanel() : base()
    {
        Visual.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
        Visual.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToParent;
        Anchor(Gum.Wireframe.Anchor.Center);

        // add background
        //var background = new ColoredRectangleRuntime();
        //background.Dock(Gum.Wireframe.Dock.Fill);
        //background.Color = new Color(30, 30, 36);
        //AddChild(background);
    }
}
