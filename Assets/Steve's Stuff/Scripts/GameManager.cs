using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public SongSelect SS;
    //Prefabs for nodes
    public GameObject node1;
    public GameObject node2;
    public GameObject node3;

    //Hitboxes for nodes
    public GameObject hit1;
    public GameObject hit2;
    public GameObject hit3;

    public GameObject SpritePosition;

    public bool LHeld;
    public bool MHeld;
    public bool RHeld;


    public int cbeat;
    public int combo;
    public float score;

    //UI Elements for combo and score
    public Text combotext;
    public Text scoretext;
    public GameObject TooLate;
    public GameObject TooSoon;
    public GameObject Great;

    public RhythmTool rhythmtool;
    public RhythmEventProvider REP;
    public AudioClip song;
    public AudioSource AS;
    public float CurrentFrame;
    public float TotalFrames;
    public bool SongStarted;

    public AudioSource Audio;
    public AudioClip hammer;
    public AudioClip hammernear;
    public AudioClip hammermiss;

	void Start () {
        SongStarted = false;
        SS = FindObjectOfType<SongSelect>();
        song = SS.Selectedsong;

        hit1 = GameObject.FindGameObjectWithTag("p1");
        hit2 = GameObject.FindGameObjectWithTag("p2");
        hit3 = GameObject.FindGameObjectWithTag("p3");
        SpritePosition = GameObject.FindGameObjectWithTag("Sprite");

        rhythmtool = GetComponent<RhythmTool>();
        REP = GetComponent<RhythmEventProvider>();

        rhythmtool.NewSong(song);
        rhythmtool.SongLoaded += OnSongLoaded;

        REP.onSubBeat.AddListener(OnSubBeat);

        combo = 0;
        score = 0;

        LHeld = false;
        MHeld = false;
        RHeld = false;

        TotalFrames = rhythmtool.totalFrames;
    }

    void OnSongLoaded()
    {
        rhythmtool.Play();
        SongStarted = true;
    }
	

	void Update () {

        TextChange();

        CurrentFrame = rhythmtool.currentFrame;

       if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }


       if(Input.GetKeyUp(KeyCode.A))
        {
            LHeld = false;
        }

       if(Input.GetKeyUp(KeyCode.S))
        {
            MHeld = false;
        }

       if(Input.GetKeyUp(KeyCode.D))
        {
            RHeld = false;
        }

       if(!AS.isPlaying && SongStarted == true)
        {
            SceneManager.LoadScene(4);
        }

	}



    void OnTriggerStay(Collider other)
    {
        Debug.Log("Item inside of trigger!");

        if (Input.GetKey(KeyCode.A) && other.tag.Equals("node1")) // Destroys Left Node
        {
            if (LHeld == false)
            {
                Instantiate(Great, new Vector3(-4.66f, 2.03f, -1.61f), Quaternion.identity);
                Audio.clip = hammer;
                Audio.Play();
                Destroy(other.gameObject);

                if (combo < 0)
                {
                    combo = 1;
                }

                else
                {
                    combo++;
                }

                score += 100;
                LHeld = true;
            }
        }

        if (Input.GetKey(KeyCode.S) && other.tag.Equals("node2")) // Destroy Middle Node
        {
            if (MHeld == false)
            {
                Instantiate(Great, new Vector3(-4.66f, 2.03f, -1.61f), Quaternion.identity);
                Audio.clip = hammer;
                Audio.Play();
                Destroy(other.gameObject);

                if (combo < 0)
                {
                    combo = 1;
                }

                else
                {
                    combo++;
                }

                score += 100;
                MHeld = true;
            }
        }

        if (Input.GetKey(KeyCode.D) && other.tag.Equals("node3")) // Destroy Right Node
        {
            if (RHeld == false)
            {
                Instantiate(Great, new Vector3(-4.66f, 2.03f, -1.61f), Quaternion.identity);
                Audio.clip = hammer;
                Audio.Play();
                Destroy(other.gameObject);

                if (combo < 0)

                {

                    combo = 1;

                }


                else
                {
                    combo++;
                }
                score += 100;
                RHeld = true;
            }

        }



    }

    void OnTriggerExit(Collider other)
    {
        if (Input.GetKey(KeyCode.A) && other.tag.Equals("node1")) // Destroys Left Node
        {

            if (LHeld == false)
            {
                Instantiate(TooLate, new Vector3(-4.66f, 2.03f, -1.61f), Quaternion.identity);
                Audio.clip = hammernear;
                Audio.Play();
                Destroy(other.gameObject);

                if (combo < 0)
                {
                    combo = 1;
                }

                else
                {
                    combo++;
                }

                score += 50;
                LHeld = true;
            }

        }

        if (Input.GetKey(KeyCode.S) && other.tag.Equals("node2")) // Destroy Middle Node
        {

            if (MHeld == false)
            {
                Instantiate(TooLate, new Vector3(-4.66f, 2.03f, -1.61f), Quaternion.identity);
                Audio.clip = hammernear;
                Audio.Play();
                Destroy(other.gameObject);

                if (combo < 0)
                {
                    combo = 1;
                }

                else
                {
                    combo++;
                }

                score += 50;
                MHeld = true;
            }

            
        }

        if (Input.GetKey(KeyCode.D) && other.tag.Equals("node3")) // Destroy Right Node
        {


            if (RHeld == false)
            {
                Instantiate(TooLate, new Vector3(-4.66f, 2.03f, -1.61f), Quaternion.identity);
                Audio.clip = hammernear;
                Audio.Play();
                Destroy(other.gameObject);

                if (combo < 0)
                {
                    combo = 1;
                }

                else
                {
                    combo++;
                }

                score += 50;
                RHeld = true;
            }
        }

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Item entered trigger!");

        if (Input.GetKey(KeyCode.A) && other.tag.Equals("node1")) // Destroys Left Node
        {


            if (LHeld == false)
            {
                Instantiate(TooSoon, new Vector3(-4.66f, 2.03f, -1.61f), Quaternion.identity);
                Audio.clip = hammernear;
                Audio.Play();
                Destroy(other.gameObject);

                if (combo < 0)
                {
                    combo = 1;
                }

                else
                {
                    combo++;
                }

                score += 50;
                LHeld = true;
            }

        }

        if (Input.GetKey(KeyCode.S) && other.tag.Equals("node2")) // Destroy Middle Node
        {

            if (MHeld == false)
            {
                Instantiate(TooSoon, new Vector3(-4.66f, 2.03f, -1.61f), Quaternion.identity);
                Audio.clip = hammernear;
                Audio.Play();
                Destroy(other.gameObject);

                if (combo < 0)
                {
                    combo = 1;
                }

                else
                {
                    combo++;
                }

                score += 50;
                MHeld = true;
            }

         
        }

        if (Input.GetKey(KeyCode.D) && other.tag.Equals("node3")) // Destroy Right Node
        {


            if (RHeld == false)
            {
                Instantiate(TooSoon, new Vector3(-4.66f, 2.03f, -1.61f), Quaternion.identity);
                Audio.clip = hammernear;
                Audio.Play();
                Destroy(other.gameObject);

                if (combo < 0)
                {
                    combo = 1;
                }

                else
                {
                    combo++;
                }

                score += 50;
                RHeld = true;
            }
            
        }

    }


    void TextChange()
    {
       scoretext.text = "Gold: " + score;
       combotext.text = "Combo: " + combo;
    }

    // RHYTHM TOOL EVENTS

    

    void OnSubBeat(Beat beat, int count)
    {

        cbeat = count;

        if (count == 2 )
        {

            int rand = Random.Range(1, 4);

            if (rand == 1)
            {
                Instantiate(node1, new Vector3(hit1.transform.position.x, hit1.transform.position.y + 13, hit1.transform.position.z), new Quaternion(0, 0, 19.6f, 0));
            }

            else if (rand == 2)
            {
                Instantiate(node2, new Vector3(hit2.transform.position.x, hit2.transform.position.y + 13, hit2.transform.position.z), new Quaternion(0, 0, 19.6f, 0));
            }

            else if (rand == 3)
            {
                Instantiate(node3, new Vector3(hit3.transform.position.x, hit3.transform.position.y + 13, hit3.transform.position.z), new Quaternion(0, 0, 19.6f, 0));
            }
        }
    }

   


 
}
