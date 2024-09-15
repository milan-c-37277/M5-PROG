using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> EnemySpawnerList = new List<GameObject>();
    public GameObject enemyPrefab;
    private float elapsedTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if(elapsedTime > 3f)
        {
            for(int i = 0; i < 3; i++)
            {
                GameObject enemy = Instantiate(enemyPrefab);
                Debug.Log("enemy" + enemy);
                EnemySpawnerList.Add(enemy);
                elapsedTime = 0f;
            } 
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            for(int i = 0; i < 100;  i++)
            {
                GameObject enemy = Instantiate(enemyPrefab);
                EnemySpawnerList.Add(enemy);
            }
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            foreach(GameObject e in EnemySpawnerList)
            {
                
                Destroy(e);
                
            }
            EnemySpawnerList = new List<GameObject>();

        }

    }
}
