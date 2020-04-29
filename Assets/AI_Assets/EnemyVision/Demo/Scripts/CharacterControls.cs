using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyAI_Game.StealthLOS
{
    public class CharacterControls : MonoBehaviour
    {
        public float move_speed = 7f;
        public float move_accel = 40f;

        private Vector3 current_move = Vector3.zero;
        private Rigidbody rigid;
        private Animator animator;

        void Awake()
        {
            rigid = GetComponent<Rigidbody>();
            animator = GetComponent<Animator>();
        }

        void FixedUpdate()
        {
            Vector3 move_dir = Vector3.zero;
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
                move_dir += Vector3.forward;
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                move_dir += Vector3.left;
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                move_dir += Vector3.right;
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
                move_dir += Vector3.back;

            move_dir = move_dir.normalized * Mathf.Min(move_dir.magnitude, 1f);
            current_move = Vector3.MoveTowards(current_move, move_dir, move_accel * Time.fixedDeltaTime);
            rigid.velocity = current_move * move_speed;

            animator.SetBool("Move", current_move.magnitude > 0.1f);
        }
    }

}
