using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
	public CharacterController2D controller;
	public Animator animator;

	public float runSpeed = 40f;
	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;

	[SerializeField]
	GameObject PobedaPanel = default;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
		Debug.Log(horizontalMove);

		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
			Debug.Log(jump);
		}

		if (Input.GetButtonDown("Crouch"))
		{
			crouch = true;
		}else if (Input.GetButtonUp("Crouch"))
		{
			crouch = false;
		}
	}

	public void Pobeda()
	{
		PobedaPanel.SetActive(true);
	}

	public void OnCrouching(bool IsCrouching)
	{
		animator.SetBool("IsCrouching", IsCrouching);
	}

	void FixedUpdate()
	{
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
	}

	private void OnTriggerEnter2D(Collider2D other)


	{
		if (other.gameObject.name == "Finish")
		{
			SendMessageUpwards("Pobeda");
			StartCoroutine(PobedioIgricu());
		}
	}


	IEnumerator PobedioIgricu()
	{
		yield return new WaitForSeconds(.7f);
		SceneManager.LoadScene(0);
	}

}
