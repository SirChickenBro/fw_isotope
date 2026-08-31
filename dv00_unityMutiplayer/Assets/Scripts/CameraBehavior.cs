using UnityEngine;
using Unity.Netcode;

public class CameraBehavior : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] Vector3 offset;

    
    public void OnNetworkSpawn()
    {

    }

    //LateUpdate() executes after all Update() functions have finished executing
    public void LateUpdate()
    {

    }
}
