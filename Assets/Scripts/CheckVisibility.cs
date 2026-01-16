using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class CheckVisibility : MonoBehaviour
{
    public static List<GameObject> MineableObjects = new List<GameObject>();

    [SerializeField] private Camera playerCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        if (MineableObjects.Count > 0)
        { 
            for (int i = 0; i < MineableObjects.Count; i++)
            {
                GameObject obj = (GameObject)MineableObjects[i];
                Vector3 viewportPoint = playerCamera.WorldToViewportPoint(obj.transform.position);
                bool isVisible = viewportPoint.z > 0 && viewportPoint.x > 0 && viewportPoint.x < 1 && viewportPoint.y > 0 && viewportPoint.y < 1;
                if (isVisible)
                {
                    obj.SetActive(true);
                }
                else
                {
                    obj.SetActive(false);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (MineableObjects.Count > 0)
        {
            for (int i = 0; i < MineableObjects.Count; i++)
            {
                GameObject obj = (GameObject)MineableObjects[i];
                Vector3 viewportPoint = playerCamera.WorldToViewportPoint(obj.transform.position);
                bool isVisible = viewportPoint.z > 0 && viewportPoint.x > 0 && viewportPoint.x < 1 && viewportPoint.y > 0 && viewportPoint.y < 1;
                if (isVisible)
                {
                    obj.SetActive(true);
                }
                else if (!isVisible && obj.activeSelf)
                {
                    obj.SetActive(false);
                }
            }
        }

        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Mineable"))
        {
            MineableObjects.Add(obj);
            Vector3 viewportPoint = playerCamera.WorldToViewportPoint(obj.transform.position);
            bool isVisible = viewportPoint.z > 0 && viewportPoint.x > 0 && viewportPoint.x < 1 && viewportPoint.y > 0 && viewportPoint.y < 1;
            if (isVisible)
            {
                obj.SetActive(true);
            }
            else
            {
                obj.SetActive(false);
            }
        }
    }

}
