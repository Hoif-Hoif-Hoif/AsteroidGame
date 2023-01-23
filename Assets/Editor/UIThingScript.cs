using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

public class UIThingScript : UnityEditor.Editor
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
        var maxHealth = new IntegerField("Max Health");
        //var Source_MaxHealth = GameObject.FindObjectOfType<Health>();
        //
        rootVisualElement.Add(new Label("Howdy there!"));
        rootVisualElement.Add(maxHealth);
        maxHealth.bindingPath = "_health";
        //
        rootVisualElement.Add(new FloatField("Asteroid Speed: "));
        //
        var AsteroidDamage = AssetDatabase.FindAssets("Health");
        //myIntField.Bind(serializedObject);
        //myIntField.bindingPath = "m_Health";
        Debug.Log(AsteroidDamage);
        //var inspector = new InspectorElement(Source_MaxHealth);
        //rootVisualElement.Add(inspector);
    }


}