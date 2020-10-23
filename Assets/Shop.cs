using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void PurchaseStandartTurret()
    {
        Debug.Log("STD TOWER PURCHASED");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }

    public void PurchaseAnotherTurret()
    {
        buildManager.SetTurretToBuild(buildManager.anotherTurretPrefab);
    }
}
