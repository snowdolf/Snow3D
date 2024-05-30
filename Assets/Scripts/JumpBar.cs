using UnityEngine;

public class JumpBar : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Player player))
        {
            player.controller.OnJumpBar();
        }
    }
}
