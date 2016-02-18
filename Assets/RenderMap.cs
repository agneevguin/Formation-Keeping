using UnityEngine;
using System.Collections;

public class RenderMap : MonoBehaviour {

    public struct Point
    {
        public float x, y;
        public Point(float p1, float p2)
        {
            x = p1;
            y = p2;
        }
    }

    float[] polygonX = new float[] { 48.041f, 97.811f, 96.429f, 154.49f, 153.8f, 100.58f, 101.96f, 164.86f, 163.48f, 104.03f, 101.27f, 45.968f, 38.364f, 249.19f, 133.06f, 132.37f, 179.38f, 185.6f, 134.45f, 132.37f, 191.82f, 190.44f, 134.45f, 133.06f, 249.19f, 251.27f };
    float[] polygonY = new float[] { 247.81f, 247.81f, 199.56f, 199.56f, 182.89f, 179.39f, 117.98f, 115.35f, 86.404f, 86.404f, 33.772f, 32.895f, 247.81f, 249.56f, 249.56f, 226.75f, 229.39f, 148.68f, 151.32f, 137.28f, 134.65f, 60.965f, 60.965f, 38.158f, 38.158f, 241.67f };
    int[] endPoints = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3 };
    int width = 250;
    int height = 250;
    Point startPos = new Point(120f, 220f);
    Point goalPos = new Point(150f, 75f);


    // Use this for initialization
    void Start () {

        GameObject camObj = GameObject.Find("Main Camera");
        camObj.transform.position = new Vector3((float)(width / 2), (float)(height / 2), -2);
        carAgents.createCarAgents();
    }
	

	// Update is called once per frame
	void Update () {

        int polygonStart = 0;
        for(int i=0; i<endPoints.Length; i++)
        {
            if(endPoints[i] == 3)
            {
                Debug.DrawLine(new Vector2(polygonX[polygonStart], polygonY[polygonStart]), new Vector2(polygonX[i], polygonY[i]),  Color.green);
                polygonStart = i+1;
            }
            else
                Debug.DrawLine(new Vector2(polygonX[i], polygonY[i]), new Vector2(polygonX[i+1], polygonY[i+1]), Color.green);
        }
    }
    
}
