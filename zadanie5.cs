using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class zad5 : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public float delay = 3.0f;
    int objectCounter = 0;
    public int objectGenerate = 0;
    public GameObject plane;

    public GameObject block;

    void Start()
    {


        Renderer planerenderer= plane.GetComponent<Renderer>();
        if (planerenderer != null)
        {
            Bounds planebounds = planerenderer.bounds;
            for(int i=0; i < objectGenerate; i++)
            {
                float posx=UnityEngine.Random.Range(planebounds.min.x,planebounds.max.x);
                float posz=UnityEngine.Random.Range(planebounds.min.z, planebounds.max.z);
                float posy = planebounds.max.y + 1;
                this.positions.Add(new Vector3(posx, posy, posz));

            }
            foreach (Vector3 elem in positions)
            {
                Debug.Log(elem);
            }

            StartCoroutine(GenerujObiekt());
        }

    }

    void Update()
    {

    }

    IEnumerator GenerujObiekt()
    {
        Debug.Log("wywołano coroutine");
        foreach (Vector3 pos in positions)
        {
            
            GameObject newblock=Instantiate(this.block, this.positions.ElementAt(this.objectCounter++), Quaternion.identity);

            yield return new WaitForSeconds(this.delay);
        }

        StopCoroutine(GenerujObiekt());
    }
}