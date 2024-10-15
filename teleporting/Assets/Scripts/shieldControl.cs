using UnityEngine;
using UnityEngine.InputSystem;


public class ShieldControl: MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other) {
        
        if (other.CompareTag("enemyBullet")) {
            Destroy(other.gameObject);
        }
    }
}