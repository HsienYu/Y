using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wave.OpenXR.Toolkit.CompositionLayer.Passthrough;
using Wave.OpenXR.CompositionLayer.Passthrough;
using Wave.OpenXR.CompositionLayer;


public class test : MonoBehaviour
{
    int ID;
    void Start()
    {
        CompositionLayerPassthroughAPI.CreatePlanarPassthrough(LayerType.Underlay);

    }

    void Update()
    {

    }

    private void OnDestroy()
    {
        CompositionLayerPassthroughAPI.DestroyPassthrough(ID); //destroy the passthrough layer
    }


}
