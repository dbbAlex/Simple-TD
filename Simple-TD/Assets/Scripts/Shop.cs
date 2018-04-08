using UnityEngine;

public class Shop : MonoBehaviour {

    public TurretBlueprint standardTurret;
    public TurretBlueprint missileLauncher;

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void SelectStandardTurret ()
    {
        Debug.Log("Standard");
        buildManager.SelectTurretToBuild(standardTurret);
    }

    public void SelectMissileLauncher ()
    {
        Debug.Log("Missile");
        buildManager.SelectTurretToBuild(missileLauncher);
    }

}
