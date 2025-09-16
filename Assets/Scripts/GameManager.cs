using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Npc npc1;
    public Npc npc2;
    public Npc npc3;
    void Start()
    {
        npc1 = new Npc("Marco", Emotion.Sad, "hola caraon con cola");
        npc2 = new Npc("Marco", Emotion.Sad, "hola caraon con cola");
        npc3 = new Npc("Marco", Emotion.Sad, "hola caraon con cola");
    }
     
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            npc1.Talk("Zuricatita");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            npc2.Talk("lolo" , Emotion.Angry);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            npc3.Talk("Tecsup coach", Emotion.Angry , "nadie me usa");
        }
    }


}
