using _2405Engine.Editor.Layouts;
using _2405Engine.Editor.Windows;
using Gum.Forms.Controls;
namespace _2405Engine.Editor.Tabs;
public class InspectorTab : EditorTab
{
    public InspectorTab(EditorWindow ownerWindow) : base(ownerWindow)
    {
        
    }

    public override void Initialize()
    {
        base.Initialize();
        var title = new TextBox();
        title.Text = "Hello this is the way better inspector";
        TabPanel.AddChild(title);
    }
    protected override string GetName()
    {
        return "Inspector";
    }
}
