using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
        public GameObject prefabAk;//calling a public game object and naming it 

        public GameObject prefabPistol;//calling a public game object and naming it

    public GameObject prefabSniper;//calling a public game object and naming it

    public GameObject prefabMiniGun;//calling a public game object and naming it

    public GameObject prefabLightSaber;//calling a public game object and naming it

    public GameObject prefabRPG;//calling a public game object and naming it

    public GameObject prefabShotGun;//calling a public game object and naming it

    public GameObject prefabBlaster;//calling a public game object and naming it

    public Button AK;//calling a public button and naming it

    public Button Pistol;//calling a public button and naming it

    public Button Sniper;//calling a public button and naming it

    public Button MiniGun;//calling a public button and naming it

    public Button LightSaber;//calling a public button and naming it

    public Button RPG;//calling a public button and naming it

    public Button Blaster;//calling a public button and naming it

    public Button ShotGun;//calling a public button and naming it

    void Start()
        {

        }

        public void SpawnPrefabAk()//calling a public void to spawn an prefab
        {
            Instantiate(prefabAk, new Vector3(0, 0, 0), Quaternion.identity);//spawning gameobjects based on prefabs
        Destroy(prefabAk,5);//destroy the prefab after 5 seconds
        }

        public void SpawnPrefabPistol()//calling a public void to spawn an prefab
    {
            Instantiate(prefabPistol, new Vector3(0, 0, 0), Quaternion.identity);//spawning gameobjects based on prefabs
        Destroy (prefabPistol,5);//destroy the prefab after 5 seconds

    }
        public void SpawnPrefabSniper()//calling a public void to spawn an prefab
    {
        Instantiate(prefabSniper, new Vector3(0, 0, 0), Quaternion.identity);//spawning gameobjects based on prefabs
        DestroyImmediate(prefabSniper);//destroy the prefab after 5 seconds
    }
    public void SpawnPrefabMiniGun()//calling a public void to spawn an prefab
    {
        Instantiate(prefabMiniGun, new Vector3(0, 0, 0), Quaternion.identity);//spawning gameobjects based on prefabs
        Destroy(prefabMiniGun);//destroy the prefab after 5 seconds
    }
    public void SpawnPrefabLightSaber()//calling a public void to spawn an prefab
    {
        Instantiate(prefabLightSaber, new Vector3(0, 0, 0), Quaternion.identity);//spawning gameobjects based on prefabs
        Destroy(prefabLightSaber);//destroy the prefab after 5 seconds
    }
    public void SpawnPrefabRPG()//calling a public void to spawn an prefab
    {
        Instantiate(prefabRPG, new Vector3(0, 0, 0), Quaternion.identity);//spawning gameobjects based on prefabs
        Destroy(prefabRPG);//destroy the prefab after 5 seconds
    }
    public void SpawnPrefabShotGun()//calling a public void to spawn an prefab
    {
        Instantiate(prefabShotGun, new Vector3(0, 0, 0), Quaternion.identity);//spawning gameobjects based on prefabs
        Destroy(prefabShotGun);//destroy the prefab after 5 seconds
    }
    public void SpawnPrefabBlaster()//calling a public void to spawn an prefab
    {
        Instantiate(prefabBlaster, new Vector3(0, 0, 0), Quaternion.identity);//spawning gameobjects based on prefabs
        Destroy (prefabBlaster);//destroy the prefab after 5 seconds
    }
}



