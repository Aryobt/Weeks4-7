using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
        public GameObject prefabAk;

        public GameObject prefabPistol;

        public GameObject prefabSniper;

        public GameObject prefabMiniGun;

        public GameObject prefabLightSaber;

        public GameObject prefabRPG ;

        public GameObject prefabShotGun;

        public GameObject prefabBlaster;

        public Button AK;

        public Button Pistol;

        public Button Sniper;

        public Button MiniGun;

        public Button LightSaber;

        public Button RPG;

        public Button Blaster;

        public Button ShotGun;

    void Start()
        {

        }

        public void SpawnPrefabAk()
        {
            Instantiate(prefabAk, new Vector3(0, 0, 0), Quaternion.identity);
        }

        public void SpawnPrefabPistol()
        {
            Instantiate(prefabPistol, new Vector3(0, 0, 0), Quaternion.identity);
        }
        public void SpawnPrefabSniper()
        {
        Instantiate(prefabSniper, new Vector3(0, 0, 0), Quaternion.identity);
        }
    public void SpawnPrefabMiniGun()
    {
        Instantiate(prefabMiniGun, new Vector3(0, 0, 0), Quaternion.identity);
    }
    public void SpawnPrefabLightSaber()
    {
        Instantiate(prefabLightSaber, new Vector3(0, 0, 0), Quaternion.identity);
    }
    public void SpawnPrefabRPG()
    {
        Instantiate(prefabRPG, new Vector3(0, 0, 0), Quaternion.identity);
    }
    public void SpawnPrefabShotGun()
    {
        Instantiate(prefabShotGun, new Vector3(0, 0, 0), Quaternion.identity);
    }
    public void SpawnPrefabBlaster()
    {
        Instantiate(prefabBlaster, new Vector3(0, 0, 0), Quaternion.identity);
    }
}



