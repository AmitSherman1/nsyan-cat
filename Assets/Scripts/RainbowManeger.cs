using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainbowManeger : MonoBehaviour
{
    public List<Rainbow> rainbowList = new List<Rainbow>();

    public class Rainbow {

        public Vector3 position;
        public Quaternion rotation;

        public Rainbow(Vector3 position, Quaternion rotation)
        {
            this.position = position;
            this.rotation = rotation;
        }

    }
    public void FixedUpdate()
    {
        UpdateRainbowList();
    }

    public void UpdateRainbowList()
    {
        rainbowList.Add(new Rainbow(transform.position, transform.rotation));
    }

    public void ClearRainbowList()
    {
        rainbowList.Clear();
        rainbowList.Add(new Rainbow(transform.position, transform.rotation));
    }
        
 }

