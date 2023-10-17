using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAIPatrulhaBehaviour : StateMachineBehaviour
{
    public float velocidade;
    private Rigidbody2D rig;
    public bool direcao = true;
    
    void Start()
    {
       // rig = GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate()
    {
        
        if (direcao)
        {
            rig.velocity = Vector2.right * velocidade;
        }
        else
        {
            rig.velocity = Vector2.left * velocidade;
        }
        
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("PontoA"))
        {
            direcao = !direcao;
        }
        if (other.gameObject.CompareTag("PontoB"))
        {
            direcao = !direcao;
        }
        
    }
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
