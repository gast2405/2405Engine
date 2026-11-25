using _2405Engine.Editor.Layouts;
using Gum.Forms.Controls;
namespace _2405Engine.Editor.Tabs;
public class InspectorTab : EditorTab
{
    public InspectorTab(Panel parentPanel) : base(parentPanel)
    {

        var title = new TextBox();
        title.Text = "Hello this is the way better inspector";
        parentPanel.AddChild(title);
    }
}
