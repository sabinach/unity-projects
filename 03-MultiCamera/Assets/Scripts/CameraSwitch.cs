using UnityEngine;
using UnityEngine.UI;

public class CameraSwitch : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    public GameObject cameraStatic;
    public GameObject cameraMinimap;
    public GameObject score1;
    //public Text score2;

    void Start()
    {
    	PlayerView();
    }

    void Update()
    {
    	if(Input.GetKeyDown(KeyCode.Alpha1))
    		PlayerView();
    	if(Input.GetKeyDown(KeyCode.Alpha2))
    		StaticView();
        if(Input.GetKeyDown(KeyCode.Alpha3))
            MinimapView();
    }

    void PlayerView()
    {
    	camera1.SetActive(true);
    	camera2.SetActive(true);
        score1.SetActive(true);
        //score2.SetActive(true);
    	cameraStatic.SetActive(false);
        cameraMinimap.SetActive(false);
    }

    void StaticView()
    {
    	camera1.SetActive(false);
    	camera2.SetActive(false);
        score1.SetActive(false);
        //score2.SetActive(false);
    	cameraStatic.SetActive(true);
        cameraMinimap.SetActive(false);
    }

    void MinimapView()
    {
        camera1.SetActive(false);
        camera2.SetActive(false);
        score1.SetActive(false);
        //score2.SetActive(false);
        cameraStatic.SetActive(false);
        cameraMinimap.SetActive(true);
    }
}
