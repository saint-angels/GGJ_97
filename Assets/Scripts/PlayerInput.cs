using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private SpawnerAuthoring spawnerPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 mousePos = Input.mousePosition;
            //mousePos.z = transform.position.z + transform.forward.z * 10.0f;
            Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePos);
            worldMousePosition.z = transform.forward.z * 5f;
            print(transform.position);
            var newSpawner = Instantiate(spawnerPrefab, worldMousePosition, Quaternion.identity);
        }
    }
}

