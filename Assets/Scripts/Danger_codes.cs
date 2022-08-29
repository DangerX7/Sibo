using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danger_codes : MonoBehaviour
{
    /*
     Basic arrow movements
    void Update()
    {
    float horizontalInput = Input.GetAxis("Horizontal");
    float verticalInput = Input.GetAxis("Vertical");

    playerRb.AddForce(Vector3.forward * 2 * Time.deltaTime * horizontalInput);
    playerRb.AddForce(Vector3.right * 2 * Time.deltaTime * verticalInput);
    }
     ///////////////////////////////////////////////////////////////////////////////////////
     Make a camera that follows the player
      
    public GameObject plane;
    private Vector3 offset = new Vector3(32, 1.5f, 2f);
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
     
     
    -----Check for collision with a tag

     if (col.gameObject.tag.Equals("Sound"))
    //////////////////////////////////////////////
    -----Check for collision with a game object name

    if (col.transform.gameObject.name == ("Sound"))
    //////////////////////////////////////////////
    -----Check for collision with a game object reference

      if (col.gameObject == S2x20)
    ///////////////////////////////////////////////
    -----Check for keyboard short press

    if (Input.GetKeyDown(KeyCode.T)
    ////////////////////////////////////////////
    -----Initiate Coroutine

    
    StartCoroutine(CoroutineWait());
    //////////////////////////////////////////////
    -----Create a Coroutine

    IEnumerator CoroutineWait()
    {
        yield return null;
        yield return new WaitForSeconds(0.001f);
        yield break;                                   //end coroutine
    }
    ////////////////////////////////////////////////
    -----reference to another script
    
    GameObject Master = GameObject.Find("MasterObject");
    master_script switchReference = Master.GetComponent<master_script>();
    ///////////////////////////////////////////////////
    -----To manually exit out of a function at any time, use the 'return' keyword.
    
            return;
    /////////////////////////////////////////////////////////////////
    -----check if object exists after name

    if (GameObject.Find("SceneUnlocker") != null)
    ///////////////////////////////////////////////////////////////
    -----check if referenced object exists

    if (enemies1 != null)
    ///////////////////////////////////////////////////////////
    -----check if parent is active

    if (gameObject.activeInHierarchy)
    ////////////////////////////////////////////////////
    -----check if object with the script exists

    if (gameObject.activeSelf)
    //////////////////////////////////////////////////////
    ---set sprite renderer and sprites

    public SpriteRenderer spriteRenderer;
    public Sprite up, down, left, right, win, lose, perfect_win;
    /////////////////////////////////////////////////////////
    -----change sprite

    spriteRenderer.sprite = down;
    //////////////////////////////////////////////////////////
    -----activate or deactivate object

    player.SetActive(true);
    //////////////////////////////////////////////////////////////
    -----destroy current object

    Destroy(this.gameObject);
    /////////////////////////////////////////////////////
    -----destroy all enemies with the same tag

    GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
    foreach(GameObject enemy in enemies)
    GameObject.Destroy(enemy);
    //////////////////////////////////////
    ----destroy collided object

     Destroy(collision.collider.gameObject);
    /////////////////////////////////////////////////////
    -----add a new Vector3

    Vector3 temp = new Vector3(0, -0.04f, 0);
    ///////////////////////////////////////////////
    -----change object tag

    gameObject.tag = "ArmourEnemy";
    //////////////////////////////////////////////////
    -----assing new possition to certain game object
    
    spike.transform.position = originalPos;
    /////////////////////////////////////////////////////////
    -----find the game obbject by tag and make reference to object script variables 

    portal_master_object_script p;
    void Start()
    {
        p = GameObject.FindGameObjectWithTag("Var").GetComponent<portal_master_object_script>();
    }
        public void Update()
        {
            if (p.variablesReset == true)  //reset variables
            {
                moves = 0;
                isReverseTrue = false;
            }
        }
    //////////////////////////////////////////////////////////
    ---set a variable to a random value

    dirrection = Random.Range(0, 3);

    ///////////////////////////////////////////////////////////////////
    -call an function from another script

      SceneUnlocker.GetComponent<scene_unlocker_script>().VersusModeEnd();
    //////////////////////////////////////////////////////////////
    -activate a child
    
     transform.GetChild(0).gameObject.SetActive(true);
    //////////////////////////////////////////////////////////////
    -reference parent object in child script

    GameObject Father = transform.parent.gameObject;
    //////////////////////////////////////////////////////////////
    -reference child object in parent script

    GameObject Child = transform.GetChild(0).gameObject;
    //////////////////////////////////////////////////////////////////
    -check if animation ended

        if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("animation_name"))
        {
            Debug.Log("Animation Ended!");
        }
    ////////////////////////////////////////////////////////////////////////////
    -dissable curent animation
    
        animator.gameObject.GetComponent<Animator>().enabled = false;
    ///////////////////////////////////////////////////////////////////
    -spawn an object from Resources

        GameObject Projectile1 = Instantiate(Resources.Load("projectile-B1DownF")) as GameObject;
        Projectile1.transform.position = spawn1;
    //////////////////////////////////////////////////////////////////////////////////////////////////
    -load scene by name

    SceneManager.LoadScene("1Main_Gate-1");
    /////////////////////////////////////
    -restart level

    SceneManager. LoadScene(SceneManager. GetActiveScene(). name);
    /////////////////////////////////////////////////////////
    -set boolean to opposite of current value

    rotateDirrection = !rotateDirrection;
    //////////////////////////////////////////////
    -new rotation variable

    Quaternion rotation;
    /////////////////////////////////////
    new position variable (vector)

    Vector3 PlayerPos = new Vector3 (0,0,0)
    /////////////////////////////////////////////
    deactivate mesh renderer

    playerRenderer.enabled = false;
    //////////////////////////////////////////////
    find the absolute value of a number
    using System;

    Math.Abs(-2)
    ///////////////////////
    find objects with same tag and chose a new parent for them
    
    GameObject[] Players = GameObject.FindGameObjectsWithTag("Player");
    foreach (GameObject player in Players)
    {
        player.transform.parent = ballParent.transform;
    }
    ///////////////////////////////
    instant freeze object possition

    rb.velocity = Vector3.zero;
    //////////////////////////////////////
    check if object name starts with certain string

    if (players.name.StartsWith("P1"))
            {
                //do something
            }
    ////////////////////////////////////
    reference father of father script

    GameObject EnemyFather = transform.parent.gameObject;
    GameObject GrandFather = EnemyFather.transform.parent.gameObject;
    enemySpawnDelay = GrandFather.GetComponent<EnemySpawnDelay>();
    ////////////////////////////////////
    Scale the size of an object (double size)

    P1.transform.localScale += new Vector3(1, 1, 1);
    //////////////////////////////////////////////////////////
    freeze rigidbody position

    playerRB.constraints = RigidbodyConstraints.FreezePositionY;

    [Unfreeze]  playerRB.constraints = RigidbodyConstraints.None;
    ///////////////////////////////////////////////////////////////////
    Change collision type to trigger

    Collider m_ObjectCollider = GetComponent<Collider>();
    m_ObjectCollider.isTrigger = true;
    /////////////////////////////////////////////////////////////
    Check if object is moving

    var vel = enemyRB.velocity;
    if (vel == Vector3.zero)
    {
        Debug.Log("No move!");
    }
    ////////////////////////////////////////////////////////////
    Check if object is moving 2

    public void FixedUpdate
    {
        if (!isEnemyOnGround && transform.position.x == xPos && transform.position.z == zPos && pushed)
        {
            BallsRespawn();
        }
        xPos = transform.position.x;
        zPos = transform.position.z;
    }
    //////////////////////////////////////////////
    Ignore collision between 2 objects (Item is target object)

    Physics.IgnoreCollision(Item.GetComponent<Collider>(), GetComponent<Collider>());
    ////////////////////////////////////////////////////////////////////////////////////////
    Remove certain text from a string

    str1 = lookAtMe
    str2 = AtMe
    result = str1.Replace(str2, "")
    /////////////////////////////////////////////
        ///Use half-size textures.
        QualitySettings.masterTextureLimit = 1;
    /////////////////////////////////////////////////
    Add Rotation to Object

    rb.AddTorque(Vector3.up * Time.deltaTime);
    ///////////////////////////////////////////////////////////
    Change Material in script


    public Material default_skin, FL1;
    GetComponent<MeshRenderer>().material = FL1;
    ///////////////////////////////////////////////////
    Find the distance between 2 vectors

    float distBetweenAB = (lastPos - presentPos).magnitude;
    /////////////////////////////////////////////////////////////
    Convert float to int

    int a = Mathf.Round(float b);
    /////////////////////////////////////////////////////////////
    Access script from any other script with static, and keep game object thru scenes

    
    public static MainManager Instance;  //MainManager = script name

    private void Awake()
    {
        if (Instance != null)    //if game object already exist then remove it
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    ///////////////////////////////////////////////
    Save and Load with Json
    
using System.IO;

    [System.Serializable]
    class SaveData
    {
        public Color TeamColor;
    }

    public void SaveColor()
    {
        SaveData data = new SaveData();
        data.TeamColor = TeamColor;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadColor()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            TeamColor = data.TeamColor;
        }
    }
    /////////////////////////////////////////////////////////
    -add and change text

    
using TMPro;
    public TextMeshProUGUI gameText;
    gameText.text = "Update";
    //////////////////////////////////////////////////////////////////////
    -raise a number at a power

using System;

    double amplify = Math.Pow(5, 2);
    /////////////////////////////////////////////////////
    -find the square root of a number
    
using System;

    double divide = Math.Sqrt(81);
    ////////////////////////////////////////////////////////
    - find the distance between 2 points

    distance = Math.Sqrt(Math.Pow((Player.transform.position.x - playerCenterPoss.x), 2) + Math.Pow((Player.transform.position.y - playerCenterPoss.y), 2));
    //////////////////////////
    -invoke a method
    
        Invoke("DoSomething", 2.0f);                            -Once

        InvokeRepeating("LaunchProjectile", 2.0f, 0.3f);        -Infinitely
    ///////////////////////////////////////////////////////////////////////////////
     */
}
