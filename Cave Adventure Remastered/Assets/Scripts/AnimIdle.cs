using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimIdle : MonoBehaviour
{
    private Animator animator;
    //time in seconds
        private float timeElapsed = 0;
        public float timer = 10;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(animator!=null && timeElapsed >= timer)
            animator.SetTrigger("StartAnim");
        timeElapsed += Time.deltaTime;

    }
}
