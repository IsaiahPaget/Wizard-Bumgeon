using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    Animator animator;
    void Awake() {
        animator = GetComponent<Animator>();
    }
    public void PlayAnimation(string animationName)
    {
        // Set all animations to false
        foreach (AnimatorControllerParameter parameter in animator.parameters)
        {
            if (parameter.type == AnimatorControllerParameterType.Bool)
            {
                animator.SetBool(parameter.name, false);
            }
        }

        // Set the specified animation to true
        if (animationName != "idle") {
            animator.SetBool(animationName, true);
        }
    }
}
