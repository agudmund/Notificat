using System.Collections;
using UnityEngine;
// using TMPro;

// Needs a header font update.
// should be grabbable by default.
// has no typing sound, fall collission sound, ground scratching sound, pickup sound, or stepped on sound.
// General vanish should be time dependant on stack and is addressed during object pooling. 
// uses two tags, Player for location of popup and is marked msgPanel itself.
// Belongs as part of the actual player class.  (or just feed it a pop point, which comes from player or not)
// and settings should be available in the editor.
// Has a TextMesh Pro dependency, and the Player then has an Inut Action dependency.
namespace Jennifer.Things{
    public class NotificatCtrl : MonoBehaviour
    {
        // PlayerCtrl player;
        // public GameObject banner;
        // public GameObject[] stack;
        // NotifiCat page;
        // TextMeshPro header;
        // TextMeshPro body;

        // GameObject rez;

        // Vector3 offset(Transform loc){
        //     // Count active panels and offset them slightly forward so they stack
        //     stack = GameObject.FindGameObjectsWithTag("msgPanel");
        //     float posZ = loc.position.z + (stack.Length / 50f);
        //     Vector3 _offset = new Vector3(loc.position.x,loc.position.y,posZ);
        //     return _offset;
        // }

        // public void Notificat(string _header, string _body, Transform loc){
        //     player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCtrl>();
        //     rez = GameObject.Instantiate(banner, offset(loc), Quaternion.identity, player.notebook);

        //     // Get the components of the new message panel.
        //     page = rez.GetComponent<NotifiCat>();
        //     header = page.header.GetComponent<TextMeshPro>();
        //     body = page.body.GetComponent<TextMeshPro>();

        //     StartCoroutine(Meow(_header,_body));
        // }

        // IEnumerator Meow(string _header, string _body){
        //     header.text = _header;
        //     string message = "";
        //     for(int i=0;i<_body.Length ;i++){
        //         message += _body[i].ToString();
        //         body.text = message;
        //         yield return new WaitForSeconds(0.03f);
        //     }
        //     StartCoroutine(Activate());
            
        // }
        // IEnumerator Activate(){
        //     yield return new WaitForSeconds( 1f );
        //     rez.transform.parent = null;
        //     Rigidbody rb = rez.GetComponent<Rigidbody>();
        //     rb.useGravity = true;
        //     rb.isKinematic = false;
        //     rb.AddTorque(new Vector3(Random.Range(0,30),0,Random.Range(-30,30)));

        // }
    }
}
