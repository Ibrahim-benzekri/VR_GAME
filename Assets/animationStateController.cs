using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    private Animator animator;
    private bool isRuning = false;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Animator component attached to this GameObject
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the "1" key is pressed to toggle running state
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            isRuning = true;
            animator.SetBool("isRuning", isRuning);
        }
    }
}
