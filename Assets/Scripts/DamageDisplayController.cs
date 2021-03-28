using System.Collections;
using System.Collections.Generic;
using Unity.Profiling;
using UnityEngine;

public class DamageDisplayController : MonoBehaviour
{

    [Range(0f,1f)]
    public float destroyDelay;
    TextMesh damageText;
    CharacterClass classStats;
    public GameObject damageNumberPrefab;



    void Start()
    {
        damageText = GetComponent<TextMesh>();
        classStats = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterClass>();
        Destroy(gameObject, destroyDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
        damageText.text = classStats.charStats.baseDamage.ToString();

    }




    public void displayDPS(float timer)
    {

        Instantiate(damageNumberPrefab, transform.position, Quaternion.identity);

        Destroy(damageNumberPrefab, timer);
    }
}
