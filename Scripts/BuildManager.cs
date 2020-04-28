using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    private void Awake()
    {
        if(instance !=null)
        {
            Debug.LogError("More than one BuildManager is scene");
            return;
        }
        instance = this;
    }
 


    public GameObject standardTurretPrefab;
    public GameObject missileLauncherPrefab;

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }


    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }
}
