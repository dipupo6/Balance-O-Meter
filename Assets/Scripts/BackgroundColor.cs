using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BackgroundColor : MonoBehaviour
{
    private GameObject GradientPlane;
    private Color[] colorArray = { Color.black, Color.black, Color.black, Color.black };
    public Color day;
    public Color cream;
	public Color night;
    // Start is called before the first frame update
    void Start()
    {
        GradientPlane = GameObject.Find("Gradient Plane");
        SetRandomColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void SetRandomColor ()
	{
		int index = Random.Range(0, 2);

		switch (index)
		{
			case 0:
                FirstColor();
				break;
			case 1:
			    SecondColor();
				break;	 
		}
	}
    public void FirstColor()
    {
        // first two colors in array for top and second two for bottom color
        Color[] colorArray = { day, day, cream, cream };
        GradientPlane.GetComponent<MeshFilter>().mesh.colors = colorArray;
    }

    public void SecondColor()
    {
        // first two colors in array for top and second two for bottom color
        Color[] colorArray = { night, night, night, night };
        GradientPlane.GetComponent<MeshFilter>().mesh.colors = colorArray;
    }
}
