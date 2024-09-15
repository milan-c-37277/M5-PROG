using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    public GameObject towerPrefab; 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            float x = Random.Range(-10f, 10f);
            float z = Random.Range(-10f, 10f);
            Vector3 randomPos = new Vector3(x, 1f, z);
            GameObject tower = Instantiate(towerPrefab);
            tower.transform.position = randomPos;
            float y = Random.Range(1f, 3f);
            Vector3 scale = new Vector3(1f, y, 1f);
            tower.transform.localScale = scale; // Random.Range(1f,4f);
        }
    }

}
