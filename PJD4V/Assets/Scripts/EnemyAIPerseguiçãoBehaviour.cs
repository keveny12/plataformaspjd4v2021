using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAIPerseguiçãoBehaviour : StateMachineBehaviour
{[SerializeField] private float changeDirectionTime;
    private Vector2 walkDirection;
    private float _currentChangeTime;
    private Animator enemyAI;

    public void SetWalkDirection (Vector2 direction){


        walkDirection = direction;
    }
    public void MoveDirection(){

        //transform.Translate(walkDirection * Time.deltaTime); 
    }

    void Start(){

        //enemyAI = GetComponent<Animator>();
    }
  
    void Update(){

        MoveDirection();
        CountTime();

    }

    public void CountTime(){

        if (_currentChangeTime <= changeDirectionTime){

            _currentChangeTime += Time.deltaTime;
      
        }
        else {
            _currentChangeTime = 0; //mudar a direcao de andar
            enemyAI.SetTrigger("Change Direction");
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
