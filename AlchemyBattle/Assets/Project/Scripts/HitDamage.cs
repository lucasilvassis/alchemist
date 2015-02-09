using UnityEngine;
using System.Collections;

public class HitDamage : MonoBehaviour {

	public LayerMask targetLayer;
	public float damage;
	public bool melee = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{

		if ((targetLayer.value & (1<<other.gameObject.layer))!=0) {

			Health h = other.GetComponent<Health>();
			if(h != null)
				h.Damage(damage);

			if(!melee)
				Destroy(gameObject);
			//(mask.value & (1 << obj.layer)
		}
	}
}