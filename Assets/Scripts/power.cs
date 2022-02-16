using UnityEngine;
using UnityEngine.UI;
public class power : MonoBehaviour
{
    public int pow;
    public Vector3 up_vel;
    int scop;
    public Text powe;
    int call_times=0;
    public Rigidbody rb;
    void FixedUpdate()
    {
        scop = Score.sc - (5*call_times);
        pow = scop/5;
        if(Input.GetKey(KeyCode.Space)){
            if(pow >=1){
                pow_call();
            }
        }
        powe.text = pow.ToString();
    }
    void pow_call(){
        call_times++;
        rb.velocity = up_vel;
    }
}
