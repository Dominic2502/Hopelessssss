using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosistion : MonoBehaviour
{
    [SerializeField] Vector2 playerCurrentPosition;
    [SerializeField] Vector2 currentCheckpointPosition;
    public TransformData playerPositionData;
    

    void Start()
    {
        
    }

    public void onCheckpoint (GameObject col)
    {
        Vector2 newCheckpointposition = col.transform.position;
        currentCheckpointPosition = newCheckpointposition;
        SavePosition(currentCheckpointPosition);
    }

    public void onTrap()
    {
        ChangePalyerPosition(currentCheckpointPosition);
    }

    private void LoadPosition()
    {
        playerCurrentPosition = playerPositionData.position;
    }
    private void SavePosition(Vector2 newPosition)
    {
        playerPositionData.position = newPosition ;
    }

    private void ChangePalyerPosition (Vector2 newPosition)
    {
        transform.position = newPosition;
    }

}
