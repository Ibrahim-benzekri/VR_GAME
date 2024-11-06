using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management

public class AnimationStateController : MonoBehaviour
{
    private Animator animator;
    private bool isRunning = false;
    public float speed = 10f; // Speed of the character

    public CountdownTimer counter; // Reference to CountdownTimer

    void Start()
    {
        // Get the Animator component attached to this GameObject
        animator = GetComponent<Animator>();

        // Check if counter reference is set
        if (counter == null)
        {
            Debug.LogError("CountdownTimer reference is missing in AnimationStateController. Please assign it in the Inspector.");
        }
    }

    void Update()
    {
        // Check if the CountdownTimer's isReady flag is true
        if (counter != null && counter.isReady && !isRunning)
        {
            StartMoving(); // Start moving when isReady is true
        }

        // If the character is running, move it forward
        if (isRunning)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }

    public void StartMoving()
    {
        isRunning = true; // Set isRunning to true
        animator.SetBool("isRunning", isRunning); // Trigger the running animation
    }
}
