using UnityEngine;

public class Kretanje : MonoBehaviour
{
    private CharacterController character_controller;
    private Vector3 move_direction;

    public float speed = 5f;
    private float gravity = 10f;
    public float jump_force = 5f;
    private float vertical_velocity;
    public float sprint_speed = 10f;
    public float crouch_speed = 2f;

    private Transform kamere;
    private Vector3 pocetnaPozicijaKamere;
    private float brzinaHodanja;
    private bool is_crouching;
    public float crouchCameraDrop = 0.4f;

    private void Awake()
    {
        character_controller = GetComponent<CharacterController>();
        kamere = transform.GetChild(0);

        pocetnaPozicijaKamere = kamere.localPosition;
        brzinaHodanja = speed;
    }

    private void Update()
    {
        Crouch();
        Sprint();
        MoveThePlayer();
    }

    private void MoveThePlayer()
    {
        move_direction = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        move_direction = transform.TransformDirection(move_direction);
        move_direction *= speed * Time.deltaTime;
        ApplyGravity();
        character_controller.Move(move_direction);
    }

    private void ApplyGravity()
    {
        vertical_velocity -= gravity * Time.deltaTime;
        PlayerJump();
        move_direction.y = vertical_velocity * Time.deltaTime;
    }

    private void PlayerJump()
    {
        if (character_controller.isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            vertical_velocity = jump_force;
        }
    }

    private void Sprint()
    {
        if (is_crouching)
        {
            speed = crouch_speed;
        }
        else
        {
            speed = Input.GetKey(KeyCode.LeftShift) ? sprint_speed : brzinaHodanja;
        }
    }

    private void Crouch()
    {
        if (!Input.GetKeyDown(KeyCode.LeftControl))
            return;

        is_crouching = !is_crouching;
        kamere.localPosition = is_crouching ? pocetnaPozicijaKamere + Vector3.down * crouchCameraDrop : pocetnaPozicijaKamere;
    }
}
