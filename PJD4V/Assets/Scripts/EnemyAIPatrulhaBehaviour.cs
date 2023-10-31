using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAIPatrulhaBehaviour : StateMachineBehaviour
{
   
    private ZumbiEnemy myEnemy;
    void Start()
    {
        //rig = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        
        
        
    }override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex){

        myEnemy = animator.GetComponent<ZumbiEnemy>();

        if(Random.value < 0.5f){
            

            myEnemy.SetWalkDirection(Vector2.left);
        }
        else{
            myEnemy.SetWalkDirection(Vector2.right);
        }



    }

    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex){

       // myEnemy.MoveDirection();
       // myEnemy.CountTime();

   // }
    
   
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
