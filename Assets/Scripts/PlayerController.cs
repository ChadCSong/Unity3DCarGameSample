using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityStandardAssets.CrossPlatformInput;
public class PlayerController : MonoBehaviour {


	public Rigidbody rb;
	public float speed;
	public Joystick joystick;
	public PointerEventData pointerED;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
//		joystick.OnDrag (pointerED);
	}


//	void FixedUpdate(){
////		float moveHorizontal = joystick.
////		pointerED
////		joystick.
//		float moveHorizontal = joystick.GetAxis ("Horizontal");
//		float moveVertical = Input.GetAxis ("Vertical");
//		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
//		rb.AddForce (movement * speed);
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		//摇杆没有被触发  
//		if (joystick.tapCount <= 0)  
//		{  
//			return;  
//		}  
//		//获取摇杆偏移  
//		var joyPositionX = joystick.position.x;  
//		var joyPositionY = joystick.position.y;  
//		float moveHorizontal =  Input.GetAxis ("Horizontal");
//		float moveVertical = Input.GetAxis ("Vertical");
//		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
//		rb.AddForce (movement * speed);
//
//		if (joyPositionY != 0 || joyPositionX != 0)  
//		{  
//			//设置角色的朝向（朝向当前坐标+摇杆偏移量）  
//			player.transform.LookAt(new Vector3(player.transform.position.x + joyPositionX, player.transform.position.y, player.transform.position.z + joyPositionY));  
//			//移动玩家的位置（按朝向位置移动）  
//			player.transform.Translate(Vector3.forward * Time.deltaTime * 5);  
//			//播放奔跑动画  
//			player.animation.Play("run");  
//		}  
//	}
}
