using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    public Transform player;
    float playerHeightY;

    public Transform PlatformWhiteSpace;
    public Transform FakeWhitePlatform;

    //planets
    public Transform Mars;
    private float platCheck = 0;
    private float spawnPlatTo = 5f;
    // Use this for initialization
    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        PlatformSpawner(-2.00f);
    }

    // Update is called once per frame
    void Update() {
        playerHeightY = player.position.y;

        if (playerHeightY > platCheck)
        {
            PlatformManager();
        }
        float currentCameraHeight = transform.position.y;
        float newHeightofCamera = Mathf.Lerp(currentCameraHeight, playerHeightY, Time.deltaTime * 10);
        if (playerHeightY > currentCameraHeight)
        {
            transform.position = new Vector3(transform.position.x, newHeightofCamera, transform.position.z);
        }
        else
        {
            if (playerHeightY < (currentCameraHeight - 6.25f))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
        if (playerHeightY > OnGUI2D.score)
        {
            OnGUI2D.score = (int)playerHeightY;
        }


        
        //OnGUI2D.score = (int)playerHeightY;


    }
    void PlatformManager()
    {
        platCheck = player.position.y + 15;
        PlatformSpawner(1000);
    }
    void PlatformSpawner(float floatValue)
    {
        float y = spawnPlatTo;
        while (y<= floatValue)
        {
            /*float x = -4f;
            float x1 = 4f;
            float fakespot = Random.Range(-1f, 1f);
            if (fakespot < 0)
            {
                x1 = -4f;
                x = 4f;
            }
            else 
            {
                x1 = 4f;
                x = -4f;
            }

            Vector2 posXY = new Vector2(x, y);
            Vector2 fakeposXY = new Vector2(x1, y);
            Instantiate(PlatformWhiteSpace, posXY, Quaternion.identity);
            Instantiate(FakeWhitePlatform, fakeposXY, Quaternion.identity);
*/
            //Instantiate(PlatformWhiteSpace, new Vector2(0,y+2.5f), Quaternion.identity);
        
            int[] x_coord = { -5, -2, 1, 4 };
            float pos = Random.Range(1f, 4f);
            if ((int)pos == 1)
            {
                int x = x_coord[0];
                Instantiate(PlatformWhiteSpace, new Vector2(x, y), Quaternion.identity);
                Instantiate(FakeWhitePlatform, new Vector2(x_coord[1], y), Quaternion.identity);
                Instantiate(FakeWhitePlatform, new Vector2(x_coord[2], y), Quaternion.identity);
                Instantiate(FakeWhitePlatform, new Vector2(x_coord[3], y), Quaternion.identity);
            }
            else if ((int)pos == 2)
            {
                int x = x_coord[1];
                Instantiate(PlatformWhiteSpace, new Vector2(x, y), Quaternion.identity);
                Instantiate(FakeWhitePlatform, new Vector2(x_coord[0], y), Quaternion.identity);
                Instantiate(FakeWhitePlatform, new Vector2(x_coord[2], y), Quaternion.identity);
                Instantiate(FakeWhitePlatform, new Vector2(x_coord[3], y), Quaternion.identity);
            }
            else if ((int)pos == 3)
            {
                int x = x_coord[2];
                Instantiate(PlatformWhiteSpace, new Vector2(x, y), Quaternion.identity);
                Instantiate(FakeWhitePlatform, new Vector2(x_coord[0], y), Quaternion.identity);
                Instantiate(FakeWhitePlatform, new Vector2(x_coord[1], y), Quaternion.identity);
                Instantiate(FakeWhitePlatform, new Vector2(x_coord[3], y), Quaternion.identity);
            }
            else if ((int)pos == 4)
            {
                int x = x_coord[3];
                Instantiate(PlatformWhiteSpace, new Vector2(x, y), Quaternion.identity);
                Instantiate(FakeWhitePlatform, new Vector2(x_coord[0], y), Quaternion.identity);
                Instantiate(FakeWhitePlatform, new Vector2(x_coord[1], y), Quaternion.identity);
                Instantiate(FakeWhitePlatform, new Vector2(x_coord[2], y), Quaternion.identity);
            }



            y += 5; // y_height;
            Debug.Log("Spawned Platform");
        }
        spawnPlatTo = floatValue;
    }

}
