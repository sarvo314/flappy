using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    //this is the speed of the background
    [SerializeField]float speed;
    [SerializeField] GameObject endPoint;
    [SerializeField] GameObject bg;
    Vector3 newBgPosition;

    bool spawnMore;


    float screenHeight;
    public static float ScreenWidth;


    private void Start()
    {
        spawnMore = true;
        screenHeight = Camera.main.orthographicSize * 2;
        ScreenWidth = screenHeight * Camera.main.aspect;

        newBgPosition = new Vector3(ScreenWidth, 0, 0);
        
    }


    private void Update()
    {
        if(endPoint.transform.position.x < ScreenWidth/2 && spawnMore)
        {
            Instantiate(bg, newBgPosition,transform.rotation);
            spawnMore = false;

        }
        if(endPoint.transform.position.x<-ScreenWidth/2)
        {
            Destroy(this.gameObject);
        }
        transform.position -= new Vector3(speed*Time.deltaTime, 0, 0);
    }

    //ASPECT RATIO = 16:9
    //screenHeight = x
    //screenWidth = (16/9)*x



}
