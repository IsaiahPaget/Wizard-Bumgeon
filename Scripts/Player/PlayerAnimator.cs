using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    Player player;
    AnimationManager animationManager;
    void Awake() {
        animationManager = GetComponent<AnimationManager>();
        player = GetComponent<Player>();
    }
    void Update() {
        switch (player.movement.y)
        {
            case 1:
                animationManager.PlayAnimation("movingUp");
                break;
            case -1:
                animationManager.PlayAnimation("movingDown");
                break;
            default:
                switch (player.movement.x)
                    {
                        case 1:
                            animationManager.PlayAnimation("movingRight");
                            break;
                        case -1:
                            animationManager.PlayAnimation("movingLeft");
                            break;
                        default:
                            animationManager.PlayAnimation("idle");
                        break;
                    }
            break;
        }    
    }

}
