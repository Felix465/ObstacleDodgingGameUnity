
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public gameManeger GameManeger;

    private void OnTriggerEnter()
    {
        GameManeger.CompleteLevel();
    }
}
