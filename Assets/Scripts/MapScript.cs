using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapScript : MonoBehaviour
{
    public float maxScale;
    public float minScale;

    void Update() => Zoom(Input.GetAxis("Mouse ScrollWheel"));

    void Zoom(float increment)
    {
        float currentScale = gameObject.transform.localScale.x;

        if (currentScale + increment < maxScale && currentScale + increment >= minScale && increment != 0)
        {
            gameObject.transform.localScale += new Vector3(increment, increment);
        }
    }
}
