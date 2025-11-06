using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Vector2 currentRoom;

    Dictionary<Vector2, Transform> roomData = new Dictionary<Vector2, Transform>();

    List<Vector2> roomKeys = new List<Vector2>();
    List<Transform> roomValues = new List<Transform>();

    private void OnStart()
    {
        for (int i = 0; i < roomKeys.Count; i++)
        {

            {
                roomData.Add(roomKeys[i], roomValues[i]);
            }

        }
    }

    private void MoveRoom()
    {
        if (roomData.ContainsKey(currentRoom + Vector2.right))
        {
            currentRoom = currentRoom + Vector2.right;
            transform.position = roomData[currentRoom].position;
        }
    }

    

}
