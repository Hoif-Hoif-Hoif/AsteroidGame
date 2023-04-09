using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;
using System.IO;
using Ship;

public class TheEditorWindow : EditorWindow
{
    [MenuItem("Window/UI Toolkit/TheEditorWindow")]
    public static void ShowExample()
    {
        TheEditorWindow wnd = GetWindow<TheEditorWindow>();
        wnd.titleContent = new GUIContent("TheEditorWindow");
    }

    public float laserSpeed;
    public float throttle;
    public float rotation;

    public TextField laserField;
    public TextField throttleField;
    public TextField rotationField;

    public GameObject prefabLaser;
    public GameObject playerShip;

    public void CreateGUI()
    {
        VisualElement root = rootVisualElement;
        var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Editor/TheEditorWindow.uxml");
        VisualElement labelFromUXML = visualTree.Instantiate();
        root.Add(labelFromUXML);

        ///////////////////////////////////////////////

        VisualElement shipThrottleLabel = new Label("Ship Throttle:");
        root.Add(shipThrottleLabel);
        throttleField = new TextField();
        root.Add(throttleField);

        VisualElement shipRotationLabel = new Label("Ship Rotation:");
        root.Add(shipRotationLabel);
        rotationField = new TextField();
        root.Add(rotationField);

        VisualElement laserLabel = new Label("Laser Speed:");
        root.Add(laserLabel);
        laserField = new TextField();
        root.Add(laserField);

        ///////
        VisualElement asteroidLabel = new Label("Asteroid:");
        root.Add(asteroidLabel);

        ///////
        Button destroyAsteroidsButton = new Button(DestroyAsteroids);
        destroyAsteroidsButton.text = "Destroy All Asteroids";
        root.Add(destroyAsteroidsButton);

        prefabLaser = AssetDatabase.LoadAssetAtPath("Assets/_Game/Components/Laser/Laser.prefab", typeof(GameObject)) as GameObject;
        playerShip = GameObject.Find("Ship");

        laserField.value = (prefabLaser.GetComponent<Laser>()._speed).ToString();
        throttleField.value = (playerShip.GetComponent<Engine>()._throttlePower.ToString());
        rotationField.value = (playerShip.GetComponent<Engine>()._rotationPower.ToString());
    }


    public void DestroyAsteroids()
    {
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Asteroid"))
        {
            Destroy(obj);
        }
    }
        
    public void UpdateLaserSpeed()
    {
        laserSpeed = float.Parse(laserField.text);
        prefabLaser.GetComponent<Laser>()._speed = laserSpeed;
    }

    public void UpdateShipMovements()
    {
        playerShip = GameObject.Find("Ship");
        throttle = float.Parse(throttleField.text);
        playerShip.GetComponent<Engine>()._throttlePower = throttle;
        rotation = float.Parse(rotationField.text);
        playerShip.GetComponent<Engine>()._rotationPower = rotation;
    }

    void OnGUI()
    {
        if (Event.current.Equals(Event.KeyboardEvent(KeyCode.Return.ToString())))
        {
            UpdateLaserSpeed();
            UpdateShipMovements();
        }
    }

}