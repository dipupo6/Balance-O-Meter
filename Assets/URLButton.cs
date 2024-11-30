using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URLButton : MonoBehaviour
{
    public string Url;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OpenURL()
    {
        Application.OpenURL(Url);
        Debug.Log("Clicked");
    }
}
