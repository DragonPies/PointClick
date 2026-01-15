using UnityEngine;

public class CheckVisibility : MonoBehaviour
{
    [SerializeField] private GameObject treeObject;
    [SerializeField] private GameObject pineObject;
    [SerializeField] private GameObject oakObject;
    [SerializeField] private GameObject rockObject;
    [SerializeField] private GameObject coalObject;
    [SerializeField] private GameObject ironObject;
    [SerializeField] private GameObject landObject;
    [SerializeField] private GameObject waterObject;

    [SerializeField] private Camera playerCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerCamera = Camera.main;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 viewportPointTree = playerCamera.WorldToViewportPoint(treeObject.transform.position);
        bool isVisibleTree = viewportPointTree.z > 0 && viewportPointTree.x > 0 && viewportPointTree.x < 1 && viewportPointTree.y > 0 && viewportPointTree.y < 1;
        
        Vector3 viewportPointPine = playerCamera.WorldToViewportPoint(pineObject.transform.position);
        bool isVisiblePine = viewportPointPine.z > 0 && viewportPointPine.x > 0 && viewportPointPine.x < 1 && viewportPointPine.y > 0 && viewportPointPine.y < 1;

        Vector3 viewportPointOak = playerCamera.WorldToViewportPoint(oakObject.transform.position);
        bool isVisibleOak = viewportPointOak.z > 0 && viewportPointOak.x > 0 && viewportPointOak.x < 1 && viewportPointOak.y > 0 && viewportPointOak.y < 1;

        Vector3 viewportPointRock = playerCamera.WorldToViewportPoint(rockObject.transform.position);
        bool isVisibleRock = viewportPointRock.z > 0 && viewportPointRock.x > 0 && viewportPointRock.x < 1 && viewportPointRock.y > 0 && viewportPointRock.y < 1;

        Vector3 viewportPointCoal = playerCamera.WorldToViewportPoint(coalObject.transform.position);
        bool isVisibleCoal = viewportPointCoal.z > 0 && viewportPointCoal.x > 0 && viewportPointCoal.x < 1 && viewportPointCoal.y > 0 && viewportPointCoal.y < 1;

        Vector3 viewportPointIron = playerCamera.WorldToViewportPoint(ironObject.transform.position);
        bool isVisibleIron = viewportPointIron.z > 0 && viewportPointIron.x > 0 && viewportPointIron.x < 1 && viewportPointIron.y > 0 && viewportPointIron.y < 1;

        Vector3 viewportPointLand = playerCamera.WorldToViewportPoint(ironObject.transform.position);
        bool isVisibleLand = viewportPointLand.z > 0 && viewportPointLand.x > 0 && viewportPointLand.x < 1 && viewportPointLand.y > 0 && viewportPointLand.y < 1;

        Vector3 viewportPointWater = playerCamera.WorldToViewportPoint(ironObject.transform.position);
        bool isVisibleWater = viewportPointWater.z > 0 && viewportPointWater.x > 0 && viewportPointWater.x < 1 && viewportPointWater.y > 0 && viewportPointWater.y < 1;
        
        if (isVisibleTree)
        {
            treeObject.SetActive(true);
        }
        else
        {
            treeObject.SetActive(false);
        }
        if (isVisiblePine)
        {
            pineObject.SetActive(true);
        }
        else
        {
            pineObject.SetActive(false);
        }
        if (isVisibleOak)
        {
            oakObject.SetActive(true);
        }
        else
        {
            oakObject.SetActive(false);
        }
        if (isVisibleRock)
        {
            rockObject.SetActive(true);
        }
        else
        {
            rockObject.SetActive(false);
        }
        if (isVisibleCoal)
        {
            coalObject.SetActive(true);
        }
        else
        {
            coalObject.SetActive(false);
        }
        if (isVisibleIron)
        {
            ironObject.SetActive(true);
        }
        else
        {
            ironObject.SetActive(false);
        }
        if (isVisibleLand)
        {
            landObject.SetActive(true);
        }
        else
        {
            landObject.SetActive(false);
        }
        if (isVisibleWater)
        {
            waterObject.SetActive(true);
        }
        else
        {
            waterObject.SetActive(false);
        }
    }


}
