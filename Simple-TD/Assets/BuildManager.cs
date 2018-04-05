using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake()
    {
        if (instance != null)
        {
            return;
        }
        instance = this;    
    }

    public GameObject standardTurretPrefab;

    private GameObject turretToBuild;

    void Start()
    {
        turretToBuild = standardTurretPrefab;    
    }

    

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }


}
