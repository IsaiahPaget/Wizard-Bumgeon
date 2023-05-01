using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField]
    Player player;

    [SerializeField]
    AnimationManager animationManager;
    void Update() {
        switch (player.getMovement().y)
        {
            case 1:
                animationManager.PlayAnimation("movingUp");
                break;
            case -1:
                animationManager.PlayAnimation("movingDown");
                break;
            default:
                switch (player.getMovement().x)
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
