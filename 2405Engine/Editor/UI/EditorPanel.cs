using Gum.DataTypes;
using Gum.DataTypes.Variables;
using Gum.Forms.Controls;
using Gum.Forms.DefaultVisuals.V3;
using Gum.GueDeriving;
using Gum.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2405Engine.Editor.UI;
public class EditorPanel : Panel
{
    public EditorPanel() : base()
    {
        //WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
        //Visual.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
        //Anchor(Gum.Wireframe.Anchor.Center);


        // add background
        var background = new ColoredRectangleRuntime();
        background.Dock(Gum.Wireframe.Dock.Fill);
        background.Color = new Color(100, 0, 0, 100);
        AddChild(background);
    }
}
