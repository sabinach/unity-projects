using UnityEngine;
using UnityEngine.UI;

public class CameraSwitch : MonoBehaviour
{
	// general
    public GameObject camera2;
    public GameObject camera1;
    public GameObject cameraStatic;
    public GameObject cameraMap;
    public GameObject score1;
    public GameObject score2;

    // player map
    public GameObject map1;
    public GameObject map2;
    private bool MapToggle1;
    private bool MapToggle2;

    // player minimap
    public GameObject minimap1;
    public GameObject minimap2;
    private bool MinimapToggle1;
    private bool MinimapToggle2;

    void Start()
    {
    	MapToggle1 = false;
    	MapToggle2 = false;

    	MinimapToggle1 = false;
    	MinimapToggle2 = false;

    	PlayerView();
    }

    void Update()
    {
    	// general
    	if(Input.GetKeyDown(KeyCode.Alpha1))
    		PlayerView();
    	if(Input.GetKeyDown(KeyCode.Alpha2))
    		StaticView();
        if(Input.GetKeyDown(KeyCode.Alpha3))
            MapView();

        // player map toggle
        if(Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKey(KeyCode.LeftControl))
        	Map1();
        if(Input.GetKeyDown(KeyCode.RightShift) && Input.GetKey(KeyCode.RightControl))
        	Map2();

        // player minimap toggle
        if(Input.GetKeyDown(KeyCode.LeftShift) && !(Input.GetKey(KeyCode.LeftControl)))
        	Minimap1();
        if(Input.GetKeyDown(KeyCode.RightShift) && !(Input.GetKey(KeyCode.RightControl)))
        	Minimap2();
    }

    // player default
    void PlayerView()
    {
    	camera1.SetActive(true);
    	camera2.SetActive(true);
        score1.SetActive(true);
        score2.SetActive(true);
    	cameraStatic.SetActive(false);
        cameraMap.SetActive(false);

        // toggle
        MapToggle1 = false; map1.SetActive(MapToggle1);
        MapToggle2 = false; map2.SetActive(MapToggle2);
        minimap1.SetActive(MinimapToggle1);
        minimap2.SetActive(MinimapToggle2);
    }

    // general
    void StaticView()
    {
    	camera1.SetActive(false);
    	camera2.SetActive(false);
        score1.SetActive(false);
        score2.SetActive(false);
    	cameraStatic.SetActive(true);
        cameraMap.SetActive(false);

        // toggle
        MapToggle1 = false; map1.SetActive(MapToggle1);
        MapToggle2 = false; map2.SetActive(MapToggle2);
        MinimapToggle1 = false; minimap1.SetActive(MinimapToggle1);
        MinimapToggle2 = false; minimap2.SetActive(MinimapToggle2);
    }
    void MapView()
    {
        camera1.SetActive(false);
        camera2.SetActive(false);
        score1.SetActive(false);
        score2.SetActive(false);
        cameraStatic.SetActive(false);
        cameraMap.SetActive(true);

        // toggle
        MapToggle1 = false; map1.SetActive(MapToggle1);
        MapToggle2 = false; map2.SetActive(MapToggle2);
        MinimapToggle1 = false; minimap1.SetActive(MinimapToggle1);
        MinimapToggle2 = false; minimap2.SetActive(MinimapToggle2);
    }

    // player map toggle
    void Map1()
    {
    	// enable player map view
    	MapToggle1 = !MapToggle1;
    	map1.SetActive(MapToggle1);

    	// disable minimap (bc we already have fullscreen view)
    	MinimapToggle1 = false; 
    	minimap1.SetActive(MinimapToggle1);
    }
    void Map2()
    {
    	// enable player map view
    	MapToggle2 = !MapToggle2;
    	map2.SetActive(!MapToggle2);

    	// disable minimap (bc we already have fullscreen view)
    	MinimapToggle2 = false;
    	minimap2.SetActive(MinimapToggle2);
    }

    // player minimap toggle
    void Minimap1()
    {
    	MinimapToggle1 = !MinimapToggle1;
    	minimap1.SetActive(MinimapToggle1);
    }

    void Minimap2()
    {
    	MinimapToggle2 = !MinimapToggle2;
    	minimap2.SetActive(!MinimapToggle2);
    }
}
