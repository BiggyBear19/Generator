using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateScene : MonoBehaviour
{
    public int stonesRequired;
    public int treesInForest;
    public int[] Forest;
    public int[] Stones;
    
    // Start is called before the first frame update
    void Start()
    {
        GenerateGround();
        GenerateForest();
        GeneratePyramid();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateGround()
    {
        GameObject ground = GameObject.CreatePrimitive(PrimitiveType.Plane);
    }

    void GeneratePyramid()
    {
        for (int i = 1; i < stonesRequired; i++)
        {
            for (int j = 5; j > i; j--)
            {
                for (int k = 5; k > i; k--)
                {
                    float x = j * 1.0f - i * 1.0f / 2f;
                    float y = i * 1.0f;
                    float z = k * 1.0f - i * 1.0f / 2f;

                    
                    GameObject stone = GameObject.CreatePrimitive((PrimitiveType.Cube));
                    GameObject pyramid = new GameObject();
                    stone.transform.position = new Vector3(x, y, z);

                }
                
            }
            
        }
    }

    void GenerateForest()
    {
        for (int i = 1; i < treesInForest; i++)
        {
            GameObject tree = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            tree.transform.position = new Vector3(Random.Range(0, 5), 1, Random.Range(0, 5));
            tree.transform.localScale = new Vector3(Random.Range(.3f, 1.5f), Random.Range(1, 2f), Random.Range(.3f, 1.5f));
            // increment the range as the loop runs on.
            //Get renderer component for the cylinder
            var cylinderRenderer = tree.GetComponent<Renderer>();
            cylinderRenderer.material.SetColor("_Color", Color.green);
        }     
    }
}
