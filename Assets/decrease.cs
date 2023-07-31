using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class decrease : MonoBehaviour
{
    // Start is called before the first frame update

    public int framerate = 60;
    void Start()
    {

        Application.targetFrameRate = framerate;
        OnDemandRendering.renderFrameInterval = 6;
    }

}
