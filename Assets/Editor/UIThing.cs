using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;


public class UIThing : EditorWindow
{
    [MenuItem("Window/UI Toolkit/UIThing")]
    public static void ShowExample()
    {
        UIThing wnd = GetWindow<UIThing>();
        wnd.titleContent = new GUIContent("UIThing");
    }

    public void CreateGUI()
    {
        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;

        // VisualElements objects can contain other VisualElement following a tree hierarchy.
        VisualElement label = new Label("Hello World! From C#");
        root.Add(label);
    }
}