using UnityEngine;
using System.Collections;

public class RunningScript : MonoBehaviour {
	
	public float maxSpeed = 5f;
	public bool facingRight = true;
	Animator anim;
	bool grounded = false;
	public Transform groundCheck;
	float groundRadius  = 0.2f;
	public LayerMask whatIsGround;
	public float jumpForce = 300f;
	//public bool sliding = false;
	bool secJump = false;
	
	void Start () {
		anim = GetComponent<Animator> ();
	}
	

	void FixedUpdate () {
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool ("Ground", grounded);
		anim.SetFloat ("vSpeed", GetComponent<Rigidbody2D>().velocity.y);

		if (grounded) {
			secJump = false;
		}
		float move = 1;
		//float move =  Input.GetAxis("Horizontal");
		anim.SetFloat ("Speed", move);
		GetComponent<Rigidbody2D>().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

	}
	void Update(){
		if ((grounded || !secJump) && Input.GetKeyDown (KeyCode.Space)) {
			anim.SetBool("Ground", false);
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, 0);
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
			if(!grounded){
				secJump = true;
			}
		}
		if(Input.GetKeyDown(KeyCode.LeftShift)){
			PlayerFire shot = this.gameObject.GetComponent<PlayerFire>();
			if(shot != null){
				shot.Fire();
			}
		}
		//if (grounded && Input.GetKeyDown(KeyCode.DownArrow)) {
			//anim.SetBool("Slide", true);
		//}
	}
}
