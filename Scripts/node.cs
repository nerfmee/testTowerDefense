using UnityEngine;
using UnityEngine.EventSystems;

public class node : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 positionOffset;

    private GameObject turret;

    BuildManager buildManager;
    private Renderer rend;
    private Color startColor;


    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;
    }

    private void OnMouseDown()
    {
        if (buildManager.GetTurretToBuild() == null)
            return;
        
            if (turret != null)
            {
                Debug.Log("Can't build there ");
                return;
            }

            GameObject turretToBuild = buildManager.GetTurretToBuild();
            turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
        


    }

    private void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (buildManager.GetTurretToBuild() == null)
            return;

        rend.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
