using Gum.DataTypes;
using Gum.DataTypes.Variables;
using Gum.Forms.Controls;
using Gum.Forms.DefaultVisuals.V3;
using Gum.Managers;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2405Engine.Editor.UI;
public class EditorButton : Button
{
    public EditorButton() : base()
    {
        ButtonVisual buttonVisual = (ButtonVisual)Visual;

        buttonVisual.Height = 6f;
        buttonVisual.HeightUnits = DimensionUnitType.RelativeToChildren;
        buttonVisual.Width = 10f;
        buttonVisual.WidthUnits = DimensionUnitType.RelativeToChildren;

        Gum.GueDeriving.NineSliceRuntime background = buttonVisual.Background;
        background.Texture = Core.Content.Load<Texture2D>("images/EditorUI/NinSliceTile");
        background.TextureAddress = TextureAddress.Custom;
        background.Color = Microsoft.Xna.Framework.Color.Red;

        Gum.GueDeriving.TextRuntime textInstance = buttonVisual.TextInstance;
        textInstance.Text = "DefaultButton";
        textInstance.Color = Microsoft.Xna.Framework.Color.Black;
        textInstance.UseCustomFont = false;
        textInstance.CustomFontFile = "fonts/DefaultEditorFont.fnt";
        //textInstance.FontScale = 0.25f;
        textInstance.Anchor(Gum.Wireframe.Anchor.Center);
        textInstance.Width = 0;
        textInstance.WidthUnits = DimensionUnitType.RelativeToChildren;

        buttonVisual.ButtonCategory.ResetAllStates();

        buttonVisual.RollOn += HandleRollOn;
    }

    private void HandleRollOn(object sender, EventArgs e)
    {
        IsFocused = true;
    }
}
