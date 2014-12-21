using UnityEngine;
using System.Collections;

public class GlobalCooldown : MonoBehaviour {

    public bool isCooldownOff = true;
    public float cooldownAmount;

    public void StartCooldown() {
        StartCoroutine(Cooldown());   
    }

    IEnumerator Cooldown() {
        isCooldownOff = false;
        yield return new WaitForSeconds(cooldownAmount);
        isCooldownOff = true;
    }
}
