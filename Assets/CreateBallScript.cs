using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBallScript : MonoBehaviour
{
    public GameObject prefab;
    private float elapsedTime = 0f;
    void Start()
    {
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > 1f)
        {
            Color color = randomColor();
            Vector3 randPos = randomVec();
            GameObject ball = CreateBall(color, randPos);
            DestroyBall(ball, 3f);
            elapsedTime = 0f;
        }
        Debug.Log(elapsedTime);
    }

    private Color randomColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        Color randColor = new Color(r, g, b, 1f);
        return randColor;
    }

    private Vector3 randomVec()
    {
        float x = Random.Range(-25f, 25f);
        float y = Random.Range(-25f, 25f);
        Vector3 randVec3 = new Vector3(x, y, 5);
        return randVec3;
    }

    private void DestroyBall(GameObject ball, float time)
    {
        Destroy(ball, time);
    }

    private GameObject CreateBall(Color c, Vector3 position)
    {

        GameObject ball = Instantiate(prefab, position, Quaternion.identity);
        Material material = ball.GetComponent<MeshRenderer>().material;
        material.SetColor("_Color", c);

        return ball;

    }
}
