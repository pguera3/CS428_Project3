using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nearPerson : MonoBehaviour
{
    public Animator anim;
    private IEnumerator coroutine;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private IEnumerator wait()
    {
        yield return new WaitForSeconds(1.5f);
        anim.SetBool("near", false);
    }
    // Update is called once per frame
    public void play()
    {
        anim.SetBool("near", true);
        coroutine = wait();
        StartCoroutine(coroutine);
    }
}
