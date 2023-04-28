using UnityEngine;
using UnityEngine.Events;

public class VRUIOperations : MonoBehaviour
{
    public UnityEvent OnEnter;
    public UnityEvent OnExit;

    public void OnTriggerEnter(Collider other) 
    {
        TrigExit.instance.currentCollider = GetComponent<VRUIOperations>();
        OnEnter.Invoke();
    }
}
