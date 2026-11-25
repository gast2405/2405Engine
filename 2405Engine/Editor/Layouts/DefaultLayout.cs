using _2405Engine.Editor.Tabs;
using _2405Engine.Editor.Windows;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2405Engine.Editor.Layouts;
public class DefaultLayout : EditorLayout
{
    private EditorWindow topLeftWindow;
    private EditorWindow bottomLeftWindow;
    private EditorWindow topRightWindow;
    private EditorWindow bottomRightWindow;
    public DefaultLayout()
    {
        topLeftWindow = new EditorWindow();
        bottomLeftWindow = new EditorWindow(new HierarchyTab());
        //topRightWindow = new EditorWindow(Vector2.Zero, 25f, 25f);    
        //bottomRightWindow = new EditorWindow(Vector2.Zero, 25f, 25f);

        topLeftWindow.Panel.Anchor(Gum.Wireframe.Anchor.TopLeft);
        bottomLeftWindow.Panel.Anchor(Gum.Wireframe.Anchor.BottomLeft);
        //topRightWindow.Panel.Anchor(Gum.Wireframe.Anchor.TopRight);
        //bottomRightWindow.Panel.Anchor(Gum.Wireframe.Anchor.BottomRight);

        topLeftWindow.Instantiate();
        bottomLeftWindow.Instantiate();
        //topRightWindow.Instantiate();
        //bottomRightWindow.Instantiate();
    }
}

