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
        EditorWindow Window = GetWindow<UIThingScript>();
        Window.titleContent = new GUIContent("UIThing");
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