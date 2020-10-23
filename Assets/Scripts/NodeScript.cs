using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeScript : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 positionOffset;

    BuildManager buildManager;
    private Renderer rend;
    private Color startColor;
    private GameObject turret;
    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;
    }
    private void OnMouseEnter()
    {
        if (buildManager.GetTurretToBuild() == null)
            return;
        rend.material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }

    private void OnMouseDown()
    {
        if (buildManager.GetTurretToBuild() == null)
            return;

        if(turret != null)
        {
            Debug.Log("ADD MENU SCRIPT");
        }

        GameObject turretToBuild =buildManager.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);

        buildManager.SetTurretToBuild(null);
    }
}
