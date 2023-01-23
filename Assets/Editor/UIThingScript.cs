using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class UIThingScript : EditorWindow
{
    [MenuItem("Tools/UIThing")]
    public static void ShowUIThing()
    {
        // This method is called when the user selects the menu item in the Editor
        EditorWindow wnd = GetWindow<UIThingScript>();
        wnd.titleContent = new GUIContent("UIThing");
        //
        //
        //

    }

    public void CreateGUI()
    {
        rootVisualElement.Add(new Label("Howdy there!"));
        rootVisualElement.Add(new TextField("Asteroid Damage: "));
        rootVisualElement.Add(new TextField("Asteroid Speed: "));
        //
        var AsteroidDamage = AssetDatabase.FindAssets("Health");
        Debug.Log(AsteroidDamage);
    }

}