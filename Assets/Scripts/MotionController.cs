using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

    public abstract class MotionController : MonoBehaviour
    {
        public GameObject _bullet;
        [SerializeField, Range(3, 10)] private float _motionSpeed;
        [SerializeField, Range(3, 10)] private float _rotateSpeed;
        [SerializeField, Range(3, 10)] private float _jumpHeight;
        public float time;
        private CharacterController _controller;
        private float _gravity;
        protected Vector3 _motion;
        protected float _rotation;
        protected float _jumpVelocity;

        protected virtual void Awake()
        {
            _controller = GetComponent<CharacterController>();
            CalculateJump();
        }

        protected virtual void Update()
        {
            time -= Time.deltaTime;
            Gravitate();
            Move();
            Rotate();
        }

        protected void SetMotion(float horizontal, float vertical)
        {
            _motion.x = horizontal * _motionSpeed;
            _motion.z = vertical * _motionSpeed;
        }

        protected void SetRotate(float rotation) => _rotation = rotation;

        private void Gravitate()
        {
            if (_controller.isGrounded == false)
                _motion.y += _gravity * Time.deltaTime;
        }

        private void CalculateJump()
        {
            float timeToApex = 0.5f;
            _gravity = -_jumpHeight * 2 / Mathf.Pow(timeToApex, 2);
            _jumpVelocity = 2 * _jumpHeight / timeToApex;
        }

        protected void Jump()
        {
            if (_controller.isGrounded)
                _motion.y = _jumpVelocity;
        }

        private void Rotate() => transform.Rotate(Vector3.up, _rotation * _rotateSpeed * 20f * Time.deltaTime);

        private void Move() => _controller.Move(transform.TransformDirection(_motion * Time.deltaTime));

        protected void Fire()
        {
            if (time < 0f)
            {
                Instantiate(_bullet, transform.position, transform.rotation);
                time = 3f;
            }
        }

        protected void SendMessage() => Debug.Log("Нажата клавиша действия");
    }
