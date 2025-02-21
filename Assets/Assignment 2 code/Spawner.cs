using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
        public GameObject prefabAk;
        public GameObject prefabPistol;
        public Button AK;
        public Button Pistol;

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
    }


